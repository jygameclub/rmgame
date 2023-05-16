using UnityEngine;

namespace Royal.Infrastructure.Utils.Sprite
{
    public static class SpriteExtensions
    {
        // Methods
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetSorting(UnityEngine.Renderer renderer)
        {
            int val_1 = renderer.sortingLayerID;
            int val_2 = renderer.sortingOrder;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {sortEverything = false};
        }
        public static void SetSorting(UnityEngine.Renderer renderer, Royal.Scenes.Game.Mechanics.Sortings.SortingData data)
        {
            renderer.sortingLayerID = data.layer;
            renderer.sortingOrder = data.layer >> 32;
        }
        public static void SetSorting(UnityEngine.Rendering.SortingGroup group, Royal.Scenes.Game.Mechanics.Sortings.SortingData data)
        {
            group.sortingLayerID = data.layer;
            group.sortingOrder = data.layer >> 32;
        }
        public static void SetSorting(TMPro.TextMeshPro textMeshPro, Royal.Scenes.Game.Mechanics.Sortings.SortingData data)
        {
            textMeshPro.sortingLayerID = data.layer;
            textMeshPro.sortingOrder = data.layer >> 32;
        }
        public static void SetSorting(UnityEngine.Canvas canvas, Royal.Scenes.Game.Mechanics.Sortings.SortingData data)
        {
            canvas.sortingLayerID = data.layer;
            canvas.sortingOrder = data.layer >> 32;
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetSorting(UnityEngine.Rendering.SortingGroup group)
        {
            int val_1 = group.sortingLayerID;
            int val_2 = group.sortingOrder;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {sortEverything = false};
        }
        public static UnityEngine.Sprite ToSprite(UnityEngine.TextAsset textAsset, int width, int height, UnityEngine.TextureFormat format)
        {
            UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  0.5f, y:  0.5f);
            return (UnityEngine.Sprite)Royal.Infrastructure.Utils.Sprite.SpriteExtensions.ToSprite(textAsset:  textAsset, width:  width, height:  height, format:  format, pivot:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
        }
        public static UnityEngine.Sprite ToSprite(UnityEngine.TextAsset textAsset, int width, int height, UnityEngine.TextureFormat format, UnityEngine.Vector2 pivot)
        {
            var val_8;
            int val_9;
            UnityEngine.Texture2D val_1 = null;
            val_9 = width;
            val_1 = new UnityEngine.Texture2D(width:  val_9, height:  height, textureFormat:  format, mipChain:  false);
            if(val_1 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_9 = 1;
            val_8 = val_1;
            val_1.filterMode = val_9;
            if(textAsset == null)
            {
                    throw new NullReferenceException();
            }
            
            bool val_3 = UnityEngine.ImageConversion.LoadImage(tex:  val_1, data:  textAsset.bytes, markNonReadable:  true);
            return (UnityEngine.Sprite)UnityEngine.Sprite.Create(texture:  val_1, rect:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, pivot:  new UnityEngine.Vector2() {x = pivot.x, y = pivot.y}, pixelsPerUnit:  140f, extrude:  0, meshType:  0);
        }
        public static void ChangeAlpha(UnityEngine.SpriteRenderer sprite, float alpha)
        {
            UnityEngine.Color val_1 = sprite.color;
            sprite.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = alpha};
        }
        public static UnityEngine.Rect GetAtlasUvRect(UnityEngine.Sprite sprite)
        {
            UnityEngine.Rect val_1 = sprite.rect;
            float val_11 = (float)sprite.texture.width;
            val_11 = (val_1.m_XMin.System.IConvertible.ToSingle(provider:  0)) / val_11;
            val_1.m_XMin.xPlacement = val_11;
            float val_12 = (float)sprite.texture.width;
            val_12 = val_11 / val_12;
            float val_13 = (float)sprite.texture.height;
            val_13 = val_12 / val_13;
            float val_14 = (float)sprite.texture.height;
            val_14 = val_13 / val_14;
            return new UnityEngine.Rect() {m_XMin = val_1.m_XMin, m_YMin = val_1.m_YMin, m_Width = val_1.m_Width, m_Height = val_1.m_Height};
        }
        public static UnityEngine.Vector4 GetAtlasUv(UnityEngine.Sprite sprite)
        {
            UnityEngine.Rect val_1 = Royal.Infrastructure.Utils.Sprite.SpriteExtensions.GetAtlasUvRect(sprite:  sprite);
            float val_2 = val_1.m_XMin.System.IConvertible.ToSingle(provider:  0);
            float val_3 = val_1.m_XMin.System.IConvertible.ToSingle(provider:  0);
            float val_4 = val_3 + val_3;
            float val_5 = val_3 + val_3;
            return new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f};
        }
        public static UnityEngine.Vector4 GetAtlasUvFromUvs(UnityEngine.Sprite sprite)
        {
            float val_6;
            var val_7;
            var val_8;
            var val_9;
            int val_6 = val_1.Length;
            if(val_6 >= 1)
            {
                    var val_7 = 0;
                val_6 = val_6 & 4294967295;
                do
            {
                val_6 = UnityEngine.Mathf.Min(a:  1f, b:  6.724291E+27f);
                val_7 = UnityEngine.Mathf.Max(a:  0f, b:  6.724291E+27f);
                val_8 = UnityEngine.Mathf.Min(a:  1f, b:  6.724291E+27f);
                val_7 = val_7 + 1;
                val_9 = UnityEngine.Mathf.Max(a:  0f, b:  6.724291E+27f);
            }
            while(val_7 < (val_1.Length << ));
            
            }
            else
            {
                    val_6 = 1f;
                val_7 = 0f;
                val_8 = val_6;
                val_9 = 0f;
            }
            
            return new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f};
        }
    
    }

}
