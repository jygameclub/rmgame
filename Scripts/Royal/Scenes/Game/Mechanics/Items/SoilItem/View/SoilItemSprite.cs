using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SoilItem.View
{
    public abstract class SoilItemSprite : MonoBehaviour
    {
        // Fields
        protected const int NoSprite = -1;
        protected const int TopCorner = 0;
        protected const int TopSide = 1;
        protected const int TopExtra = 2;
        protected const int MidSide = 3;
        protected const int InSide = 4;
        protected const int BottomCorner = 5;
        protected const int BottomSide = 6;
        protected const int BottomExtra = 7;
        private Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory;
        private Royal.Scenes.Game.Mechanics.Items.SoilItem.View.SoilItemAssets itemAssets;
        public UnityEngine.SpriteRenderer part;
        protected int currentType;
        
        // Methods
        public void Init()
        {
            this.itemFactory = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1);
            this.itemAssets = val_1.assetsLibrary.Load<Royal.Scenes.Game.Mechanics.Items.SoilItem.View.SoilItemAssets>();
            goto typeof(Royal.Scenes.Game.Mechanics.Items.SoilItem.View.SoilItemSprite).__il2cppRuntimeField_170;
        }
        public bool IsExtra()
        {
            return (bool)((this.currentType == 2) ? 1 : 0) | ((this.currentType == 7) ? 1 : 0);
        }
        protected virtual void InitSprite()
        {
            this.currentType = 0;
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            this.part.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a};
            UnityEngine.Transform val_2 = this.transform;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
            val_2.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
            val_2.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.identity;
            val_2.localRotation = new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w};
        }
        public abstract void SelectSprite(bool top, bool bottom, bool left, bool right, bool topLeft, bool topRight, bool bottomLeft, bool bottomRight); // 0
        protected void EnableSprites()
        {
            if(this.currentType != 1)
            {
                    this.part.enabled = true;
                this.part.sprite = this.itemAssets.GetSprite(order:  this.currentType);
                return;
            }
            
            this.part.sprite = 0;
            this.part.enabled = false;
        }
        public void UpdateSorting(Royal.Scenes.Game.Mechanics.Sortings.SortingData sortingData)
        {
            var val_4;
            if(this.currentType != 7)
            {
                    if(this.currentType != 2)
            {
                goto label_2;
            }
            
            }
            
            val_4 = 12;
            goto label_3;
            label_2:
            val_4 = 1;
            label_3:
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_2 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = sortingData.sortEverything & 4294967295}, offset:  1);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.part, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_2.layer, order = val_2.order, sortEverything = val_2.sortEverything & 4294967295});
        }
        protected SoilItemSprite()
        {
        
        }
    
    }

}
