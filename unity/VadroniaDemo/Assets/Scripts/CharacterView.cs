using System;
using UnityEngine;

namespace Vadronia
{
    public sealed class CharacterView : IDisposable
    {
        readonly SpriteRenderer renderer;
        readonly Sprite[] walk = new Sprite[16], idle = new Sprite[4];
        public readonly WalkCycle Cycle = new WalkCycle();
        public FootPoint Position { get; private set; }
        public CharacterView(string name, FootPoint position, Texture2D walking, Texture2D original, bool conrad)
        {
            renderer = new GameObject(name).AddComponent<SpriteRenderer>();
            var rects = conrad ? WalkAtlasLayout.Conrad : WalkAtlasLayout.Player;
            var pivots = conrad ? WalkAtlasLayout.ConradPivots : WalkAtlasLayout.PlayerPivots;
            float ppu = conrad ? WalkAtlasLayout.ConradPPU : WalkAtlasLayout.PlayerPPU;
            for (int i = 0; i < 16; i++)
                walk[i] = Sprite.Create(walking, rects[i], pivots[i], ppu, 0, SpriteMeshType.FullRect);
            for (int i = 0; i < 4; i++)
                idle[i] = Sprite.Create(original, AtlasLayout.Frames[i * 8 + (conrad ? 5 : 1)],
                    new Vector2(.5f, 0), conrad ? 175 : 173, 0, SpriteMeshType.FullRect);
            Position = position;
            Place(position);
        }
        public void Place(FootPoint next)
        {
            Cycle.Advance(next.X - Position.X, next.Y - Position.Y);
            Position = next;
            renderer.sprite = Cycle.Moving ? walk[Cycle.Facing * 4 + Cycle.Frame] : idle[Cycle.Facing];
            renderer.transform.position = new Vector3(next.X, next.Y, 0);
            renderer.sortingOrder = -Mathf.RoundToInt(next.Y * 100) + 1;
            renderer.transform.localScale = Vector3.one;
        }
        public void Dispose()
        {
            if (renderer != null) UnityEngine.Object.Destroy(renderer.gameObject);
            foreach (var sprite in walk) UnityEngine.Object.Destroy(sprite);
            foreach (var sprite in idle) UnityEngine.Object.Destroy(sprite);
        }
    }
}
