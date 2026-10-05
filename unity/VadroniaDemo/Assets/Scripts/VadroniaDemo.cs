using UnityEngine;
#if ENABLE_INPUT_SYSTEM
using UnityEngine.InputSystem;
#endif

namespace Vadronia
{
    /// <summary>Scene entry point: builds the village and connects input, movement and rendering.</summary>
    public sealed class VadroniaDemo : MonoBehaviour
    {
        public Texture2D characterAtlas; // Keep existing scene reference for the neutral idle frames.
        CharacterView player, conrad;
        TownWorld town;
        Camera view;
        int waypoint = 1;
        float wait;
        bool warnedPatrol;

        void Start()
        {
            var playerWalk = Resources.Load<Texture2D>("Vadronia/player-walk");
            var conradWalk = Resources.Load<Texture2D>("Vadronia/conrad-walk");
            var scenery = Resources.Load<Texture2D>("Vadronia/town");
            if (characterAtlas == null || playerWalk == null || conradWalk == null || scenery == null)
            {
                Debug.LogError("Atlas ausente. Use Vadronia > Abrir demo ou reimporte a pasta completa.", this);
                enabled = false;
                return;
            }
            QualitySettings.antiAliasing = 0;
            QualitySettings.anisotropicFiltering = AnisotropicFiltering.Disable;
            Application.targetFrameRate = 60;
            town = new TownWorld(scenery);
            player = new CharacterView("Player", new FootPoint(0, -5), playerWalk, characterAtlas, false);
            conrad = new CharacterView("Conrad", TownLayout.Patrol[0], conradWalk, characterAtlas, true);
            view = new GameObject("Camera — Grünwald").AddComponent<Camera>();
            view.tag = "MainCamera";
            view.orthographic = true;
            view.orthographicSize = 5.4f;
            view.clearFlags = CameraClearFlags.SolidColor;
            view.backgroundColor = new Color32(42, 66, 38, 255);
            view.allowHDR = view.allowMSAA = view.allowDynamicResolution = false;
            FollowCamera();
        }
        void Update()
        {
            if (player == null) return;
            float dt = Mathf.Min(Time.deltaTime, .1f);
            Vector2 input = Vector2.ClampMagnitude(ReadMovement(), 1);
            player.Place(MovementCore.Move(player.Position, input.x * 3.2f * dt, input.y * 3.2f * dt, town.Blocks));
            var old = conrad.Position;
            if (wait > 0)
            {
                wait -= dt;
                conrad.Place(old);
                return;
            }
            var target = TownLayout.Patrol[waypoint];
            var movement = Vector2.ClampMagnitude(new Vector2(target.X - old.X, target.Y - old.Y), 1.65f * dt);
            var next = MovementCore.Move(old, movement.x, movement.y, town.Blocks);
            conrad.Place(next);
            if (Vector2.Distance(new Vector2(next.X, next.Y), new Vector2(target.X, target.Y)) < .02f)
            {
                waypoint = (waypoint + 1) % TownLayout.Patrol.Length;
                wait = 1.1f;
            }
            else if (!conrad.Cycle.Moving && !warnedPatrol)
            {
                warnedPatrol = true;
                Debug.LogWarning("Conrad encontrou obstáculo na patrulha; confira TownLayout.");
            }
        }
        void LateUpdate() { if (player != null) FollowCamera(); }
        void FollowCamera()
        {
            // Fixed ortho zoom; snap camera to the terrain's pixel grid to avoid subpixel shimmer.
            float halfHeight = view.orthographicSize;
            float halfWidth = halfHeight * Screen.width / Mathf.Max(1f, Screen.height);
            float x = halfWidth >= 14 ? 0 : Mathf.Clamp(player.Position.X, -14 + halfWidth, 14 - halfWidth);
            float y = Mathf.Clamp(player.Position.Y + 1, -11 + halfHeight, 11 - halfHeight);
            view.transform.position = new Vector3(Mathf.Round(x * 32) / 32, Mathf.Round(y * 32) / 32, -10);
        }
        static Vector2 ReadMovement()
        {
#if ENABLE_INPUT_SYSTEM
            var k = Keyboard.current;
            if (k == null) return Vector2.zero;
            return new Vector2((k.dKey.isPressed || k.rightArrowKey.isPressed ? 1 : 0) -
                (k.aKey.isPressed || k.leftArrowKey.isPressed ? 1 : 0),
                (k.wKey.isPressed || k.upArrowKey.isPressed ? 1 : 0) -
                (k.sKey.isPressed || k.downArrowKey.isPressed ? 1 : 0));
#else
            return new Vector2((Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) ? 1 : 0) -
                (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) ? 1 : 0),
                (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) ? 1 : 0) -
                (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow) ? 1 : 0));
#endif
        }

        void OnDestroy()
        {
            player?.Dispose(); conrad?.Dispose(); town?.Dispose();
            if (view != null) Destroy(view.gameObject);
        }
        void OnDrawGizmosSelected()
        {
            Gizmos.color = new Color(1, .5f, 0, .7f);
            foreach (var block in TownLayout.Blocks())
                Gizmos.DrawWireCube(new Vector3((block.Left + block.Right) / 2, (block.Bottom + block.Top) / 2, 0),
                    new Vector3(block.Right - block.Left, block.Top - block.Bottom, 0));
        }
    }
}
