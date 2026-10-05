using System;
using System.Collections.Generic;
using UnityEngine;

namespace Vadronia
{
    public sealed class TownWorld : IDisposable
    {
        readonly GameObject root;
        readonly List<UnityEngine.Object> owned = new List<UnityEngine.Object>();
        public readonly List<FootBlock> Blocks = TownLayout.Blocks();
        public TownWorld(Texture2D scenery)
        {
            root = new GameObject("Grünwald — ruas e praça");
            var texture = PaintGround();
            owned.Add(texture);
            var ground = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), Vector2.one * .5f, 32);
            owned.Add(ground);
            Add("Chão", ground, Vector2.zero, 1, -10000);
            for (int i = 0; i < TownLayout.Props.Length; i++)
            {
                var prop = TownLayout.Props[i];
                Rect bounds = TownAtlasLayout.Frames[prop.Sprite];
                Sprite sprite = Sprite.Create(scenery, bounds, new Vector2(.5f, 0), bounds.width / prop.Width, 0, SpriteMeshType.FullRect);
                owned.Add(sprite);
                Add(prop.Name, sprite, new Vector2(prop.X, prop.Y), 1, -Mathf.RoundToInt(prop.Y * 100));
            }
        }
        void Add(string name, Sprite sprite, Vector2 position, float scale, int order)
        {
            var renderer = new GameObject(name).AddComponent<SpriteRenderer>();
            renderer.transform.SetParent(root.transform);
            renderer.transform.position = new Vector3(position.x, position.y, 0);
            renderer.transform.localScale = Vector3.one * scale;
            renderer.sprite = sprite;
            renderer.sortingOrder = order;
        }
        static Texture2D PaintGround()
        {
            const int width = 896, height = 704;
            var texture = new Texture2D(width, height, TextureFormat.RGBA32, false);
            texture.name = "Grünwald terrain";
            texture.filterMode = FilterMode.Point;
            texture.wrapMode = TextureWrapMode.Clamp;
            var pixels = new Color32[width * height];
            var random = new System.Random(317);
            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x++)
                {
                    float wx = x / 32f - 14, wy = y / 32f - 11;
                    bool plaza = Mathf.Abs(wx) < 4.3f && wy > -3.6f && wy < 4.3f;
                    bool road = Mathf.Abs(wx) < 1.3f || (Mathf.Abs(wy - 2.5f) < .8f && Mathf.Abs(wx) < 10)
                        || (Mathf.Abs(wy + 5) < .65f && wx > -9 && wx < 7);
                    int noise = random.Next(-5, 6);
                    bool edge = Mathf.Abs(wx) > 13.3f || Mathf.Abs(wy) > 10.3f;
                    Color32 color;
                    if (plaza)
                    {
                        bool seam = y % 10 == 0 || (x + (y / 10 % 2) * 8) % 18 == 0;
                        color = seam ? new Color32(112, 110, 86, 255) : Color(155 + noise, 151 + noise, 116 + noise);
                    }
                    else if (road) color = Color(165 + noise, 136 + noise, 86 + noise);
                    else color = Color((edge ? 61 : 82) + noise, (edge ? 98 : 124) + noise, 54 + noise);
                    if (!road && !plaza && !edge && random.Next(160) == 0) color = new Color32(132, 155, 73, 255);
                    pixels[y * width + x] = color;
                }
            texture.SetPixels32(pixels);
            texture.Apply(false, true);
            return texture;
        }
        static Color32 Color(int r, int g, int b) { return new Color32((byte)r, (byte)g, (byte)b, 255); }
        public void Dispose()
        {
            if (root != null) UnityEngine.Object.Destroy(root);
            foreach (var asset in owned) if (asset != null) UnityEngine.Object.Destroy(asset);
        }
    }
}
