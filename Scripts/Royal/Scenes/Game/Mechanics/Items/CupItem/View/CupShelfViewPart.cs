using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.CupItem.View
{
    public abstract class CupShelfViewPart : MonoBehaviour
    {
        // Fields
        public const int NoSprite = -1;
        public const int TopCorner = 0;
        public const int TopSide = 1;
        public const int TopExtra = 2;
        public const int MidSide = 3;
        public const int InSide = 4;
        public const int BottomCorner = 5;
        public const int BottomSide = 6;
        public const int BottomExtra = 7;
        public const int ShadowCorner = 8;
        public const int ShadowSide = 9;
        public const int ShadowExtra = 10;
        protected Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory;
        protected Royal.Scenes.Game.Mechanics.Items.CupItem.View.CupItemAssets cupItemAssets;
        public UnityEngine.SpriteRenderer part;
        protected Royal.Scenes.Game.Mechanics.Sortings.SortingData defaultSorting;
        protected int currentType;
        protected int sortingOffset;
        protected int topMostLeftSideDiff;
        protected int topMostRightSideDiff;
        
        // Methods
        public void Init(Royal.Scenes.Game.Mechanics.Sortings.SortingData defaultSorting, int topMostLeftSideDiff, int topMostRightSideDiff)
        {
            this.itemFactory = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1);
            this.cupItemAssets = val_1.assetsLibrary.Load<Royal.Scenes.Game.Mechanics.Items.CupItem.View.CupItemAssets>();
            this.defaultSorting = defaultSorting;
            mem[1152921523765822184] = defaultSorting.sortEverything;
            this.topMostLeftSideDiff = topMostLeftSideDiff;
            this.topMostRightSideDiff = topMostRightSideDiff;
            goto typeof(Royal.Scenes.Game.Mechanics.Items.CupItem.View.CupShelfViewPart).__il2cppRuntimeField_170;
        }
        protected virtual void InitSprite()
        {
            this.currentType = 4294967295;
            this.sortingOffset = 0;
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
        public virtual void SetSorting(Royal.Scenes.Game.Mechanics.Sortings.SortingData sortingData)
        {
            bool val_3 = sortingData.sortEverything;
            this.defaultSorting = sortingData;
            mem[1152921523766078952] = val_3;
            val_3 = val_3 & 4294967295;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_1 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = val_3}, offset:  this.sortingOffset);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.part, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_1.layer, order = val_1.order, sortEverything = val_1.sortEverything & 4294967295});
        }
        public abstract void SelectSprite(bool top, bool bottom, bool left, bool right, bool topLeft, bool topRight, bool bottomLeft, bool bottomRight); // 0
        protected void EnableSprites()
        {
            if(this.currentType != 1)
            {
                    this.part.enabled = true;
                this.part.sprite = this.cupItemAssets.GetSprite(order:  this.currentType);
                this = ???;
            }
            else
            {
                    this.sprite = 0;
                val_6 + 40.enabled = false;
            }
        
        }
        protected CupShelfViewPart()
        {
        
        }
    
    }

}
