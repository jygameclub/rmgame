using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.CupItem.View
{
    public class CupShelfPartBL : CupShelfViewPart
    {
        // Methods
        protected override void InitSprite()
        {
            this.InitSprite();
            this.flipX = false;
            this.flipY = false;
        }
        public override void SelectSprite(bool top, bool bottom, bool left, bool right, bool topLeft, bool topRight, bool bottomLeft, bool bottomRight)
        {
            bool val_1 = bottom & left;
            if((val_1 == false) || (bottomLeft == false))
            {
                goto label_1;
            }
            
            this.flipY = true;
            label_10:
            mem[1152921523763725676] = 4;
            goto label_3;
            label_1:
            if(val_1 == false)
            {
                goto label_4;
            }
            
            mem[1152921523763725676] = 2.12199579442373E-314;
            label_3:
            this.EnableSprites();
            return;
            label_4:
            if(bottom == false)
            {
                goto label_5;
            }
            
            this.flipY = true;
            goto label_10;
            label_5:
            if(left == false)
            {
                goto label_10;
            }
            
            goto label_10;
        }
        public override void SetSorting(Royal.Scenes.Game.Mechanics.Sortings.SortingData sortingData)
        {
            bool val_4 = sortingData.sortEverything;
            mem[1152921523763837664] = sortingData.layer;
            mem[1152921523763837668] = sortingData.order;
            mem[1152921523763837672] = val_4;
            val_4 = val_4 & 4294967295;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_1 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = val_4}, offset:  417800192);
            val_1.sortEverything = val_1.sortEverything & 4294967295;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_2 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_1.layer, order = val_1.order, sortEverything = val_1.sortEverything}, offset:  417800192);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  sortingData.layer, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_2.layer, order = val_2.order, sortEverything = val_2.sortEverything & 4294967295});
        }
        public CupShelfPartBL()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
