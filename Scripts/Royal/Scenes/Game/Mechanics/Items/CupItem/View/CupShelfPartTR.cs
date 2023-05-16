using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.CupItem.View
{
    public class CupShelfPartTR : CupShelfViewPart
    {
        // Fields
        public UnityEngine.SpriteRenderer shadow;
        private int shadowType;
        
        // Methods
        protected override void InitSprite()
        {
            this.InitSprite();
            this.flipX = true;
            this.flipY = false;
            this.shadow.flipX = true;
            this.shadow.flipY = false;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            this.shadow.transform.localPosition = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            this.shadowType = 0;
        }
        public override void SelectSprite(bool top, bool bottom, bool left, bool right, bool topLeft, bool topRight, bool bottomLeft, bool bottomRight)
        {
            var val_4;
            bool val_1 = top & right;
            if((val_1 == false) || (topRight == false))
            {
                goto label_1;
            }
            
            label_12:
            mem[1152921523765312748] = 4;
            goto label_6;
            label_1:
            if(val_1 == false)
            {
                goto label_3;
            }
            
            this.shadowType = 10;
            mem[1152921523765312748] = 0;
            this.shadow.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            goto label_6;
            label_3:
            if(top == false)
            {
                goto label_7;
            }
            
            var val_3 = ((topRight & true) != 0) ? 3 : (!0);
            goto label_12;
            label_7:
            if(right == false)
            {
                goto label_10;
            }
            
            mem[1152921523765312748] = 1;
            if(topRight == false)
            {
                goto label_11;
            }
            
            goto label_12;
            label_10:
            val_4 = 8;
            mem[1152921523765312748] = 0;
            goto label_13;
            label_11:
            val_4 = 9;
            label_13:
            this.shadowType = 9;
            label_6:
            this.EnableSprites();
            this.EnableShadow();
        }
        public override void SetSorting(Royal.Scenes.Game.Mechanics.Sortings.SortingData sortingData)
        {
            bool val_4 = sortingData.sortEverything;
            mem[1152921523765432928] = sortingData.layer;
            mem[1152921523765432932] = sortingData.order;
            mem[1152921523765432936] = val_4;
            val_4 = val_4 & 4294967295;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_1 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = val_4}, offset:  417800192);
            val_1.sortEverything = val_1.sortEverything & 4294967295;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_2 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_1.layer, order = val_1.order, sortEverything = val_1.sortEverything}, offset:  417800192);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  sortingData.layer, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_2.layer, order = val_2.order, sortEverything = val_2.sortEverything & 4294967295});
        }
        protected void EnableShadow()
        {
            if(this.shadowType != 1)
            {
                    this.shadow.enabled = true;
                this.shadow.sprite = this.shadow.GetSprite(order:  this.shadowType);
                Royal.Scenes.Game.Mechanics.Sortings.SortingData val_2 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = X21, order = X21, sortEverything = true}, offset:  60);
                Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.shadow, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_2.layer, order = val_2.order, sortEverything = val_2.sortEverything & 4294967295});
                return;
            }
            
            this.shadow.sprite = 0;
            this.shadow.enabled = false;
        }
        public CupShelfPartTR()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
