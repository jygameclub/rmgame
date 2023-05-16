using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.StaticItems.HoneyItem.View
{
    public class HoneyItemSprite : MonoBehaviour
    {
        // Fields
        protected const short NoSprite = 0;
        protected const short Side = 1;
        protected const short Inside = 2;
        protected const short Corner = 3;
        protected const short CornerSide = 4;
        protected const short InsideCorner = 5;
        public UnityEngine.SpriteRenderer spriteRenderer;
        protected Royal.Scenes.Game.Mechanics.Sortings.SortingData defaultSorting;
        protected Royal.Scenes.Game.Mechanics.Items.StaticItems.HoneyItem.View.HoneyItemAssets itemAssets;
        private short previousType;
        protected short currentType;
        protected bool isFirstCorner;
        private UnityEngine.SpriteRenderer[] extras;
        
        // Methods
        public void Init(Royal.Scenes.Game.Mechanics.Items.StaticItems.HoneyItem.View.HoneyItemAssets honeyItemAssets, UnityEngine.SpriteRenderer[] extraRenderers)
        {
            this.extras = extraRenderers;
            this.itemAssets = honeyItemAssets;
            this.previousType = 0;
            this.currentType = 0;
            this.spriteRenderer.sprite = 0;
            this.spriteRenderer.enabled = false;
        }
        public void UpdateSorting(Royal.Scenes.Game.Mechanics.Sortings.SortingData sortingData)
        {
            this.defaultSorting = sortingData;
            mem[1152921520028924104] = sortingData.sortEverything;
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.spriteRenderer, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = sortingData.sortEverything & 4294967295});
        }
        public void SetTransparency(UnityEngine.Color color)
        {
            if(this.spriteRenderer != null)
            {
                    this.spriteRenderer.color = new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a};
                return;
            }
            
            throw new NullReferenceException();
        }
        protected void InitExtraRenderer(int type, bool flipX, bool flipY, UnityEngine.Vector3 position)
        {
            UnityEngine.SpriteRenderer val_8;
            if(this.extras.Length < 1)
            {
                goto label_1;
            }
            
            var val_8 = 0;
            label_6:
            val_8 = this.extras[0];
            if(val_8.enabled == false)
            {
                goto label_4;
            }
            
            val_8 = val_8 + 1;
            if(val_8 < this.extras.Length)
            {
                goto label_6;
            }
            
            goto label_7;
            label_1:
            val_8 = 0;
            label_7:
            label_4:
            val_8.flipX = flipX;
            val_8.flipY = flipY;
            val_8.enabled = true;
            UnityEngine.Color val_4 = UnityEngine.Color.white;
            val_8.color = new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a};
            val_8.transform.localPosition = new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z};
            if(type == 5)
            {
                    UnityEngine.Sprite val_6 = this.itemAssets.GetInnerCorner();
            }
            
            val_8.sprite = this.itemAssets.GetInnerFill();
        }
        protected virtual void InitSprite()
        {
            this.isFirstCorner = false;
            this.currentType = 0;
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            this.spriteRenderer.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a};
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.spriteRenderer, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = this.defaultSorting, order = this.defaultSorting, sortEverything = false});
            UnityEngine.Transform val_2 = this.transform;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
            val_2.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
            val_2.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.identity;
            val_2.localRotation = new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w};
        }
        protected void EnableSprites()
        {
            var val_7;
            short val_7 = this.currentType;
            if(val_7 == 0)
            {
                goto label_0;
            }
            
            if(this.previousType != val_7)
            {
                goto label_1;
            }
            
            if(this.spriteRenderer != null)
            {
                goto label_2;
            }
            
            label_0:
            this.previousType = 0;
            this.spriteRenderer.sprite = 0;
            val_7 = 0;
            goto label_6;
            label_1:
            val_7 = val_7 - 1;
            if(val_7 > 4)
            {
                goto label_7;
            }
            
            var val_8 = 36604856 + ((this.currentType - 1)) << 2;
            val_8 = val_8 + 36604856;
            goto (36604856 + ((this.currentType - 1)) << 2 + 36604856);
            label_7:
            this.previousType = this.currentType;
            label_2:
            val_7 = 1;
            label_6:
            this.spriteRenderer.enabled = true;
        }
        public virtual void SelectSprite(bool top, bool bottom, bool left, bool right, bool topLeft, bool topRight, bool bottomLeft, bool bottomRight, UnityEngine.SpriteRenderer connectRenderer)
        {
        
        }
        public virtual void PrepareForExplosion(bool top, bool bottom, bool left, bool right, bool topLeft, bool topRight, bool bottomLeft, bool bottomRight)
        {
        
        }
        public HoneyItemSprite()
        {
        
        }
    
    }

}
