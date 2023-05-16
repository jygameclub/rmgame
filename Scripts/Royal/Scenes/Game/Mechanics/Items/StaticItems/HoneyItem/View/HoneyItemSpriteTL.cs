using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.StaticItems.HoneyItem.View
{
    public class HoneyItemSpriteTL : HoneyItemSprite
    {
        // Methods
        protected override void InitSprite()
        {
            this.InitSprite();
            this.flipX = false;
            this.flipY = false;
        }
        public override void SelectSprite(bool top, bool bottom, bool left, bool right, bool topLeft, bool topRight, bool bottomLeft, bool bottomRight, UnityEngine.SpriteRenderer connectRenderer)
        {
            bool val_8;
            var val_9;
            val_8 = right;
            bool val_1 = top & left;
            if((val_1 == false) || (topLeft == false))
            {
                goto label_2;
            }
            
            label_28:
            mem[1152921520031352410] = 2;
            goto label_29;
            label_2:
            if(val_1 == false)
            {
                goto label_4;
            }
            
            mem[1152921520031352410] = 5;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_2 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetHoneySortingForCorner(sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = left, order = left, sortEverything = val_8});
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  topLeft, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_2.layer, order = val_2.order, sortEverything = val_2.sortEverything & 4294967295});
            goto label_29;
            label_4:
            if(((top == false) || (topLeft == false)) || (bottom == true))
            {
                goto label_10;
            }
            
            label_24:
            mem[1152921520031352410] = 4;
            this.flipX = true;
            val_9 = this.transform;
            goto label_15;
            label_10:
            if((left == false) || (topLeft == false))
            {
                goto label_17;
            }
            
            if(val_8 == false)
            {
                goto label_28;
            }
            
            label_27:
            mem[1152921520031352410] = 1;
            val_9 = this.transform;
            label_15:
            UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.Euler(x:  0f, y:  0f, z:  -90f);
            val_9.localRotation = new UnityEngine.Quaternion() {x = val_6.x, y = val_6.y, z = val_6.z, w = val_6.w};
            label_29:
            this.EnableSprites();
            return;
            label_17:
            if(top == false)
            {
                goto label_23;
            }
            
            if(bottom == false)
            {
                goto label_24;
            }
            
            goto label_28;
            label_23:
            if(left == false)
            {
                goto label_26;
            }
            
            if(val_8 == true)
            {
                goto label_27;
            }
            
            goto label_28;
            label_26:
            mem[1152921520031352410] = 3;
            mem[1152921520031352412] = topLeft;
            goto label_29;
        }
        public override void PrepareForExplosion(bool top, bool bottom, bool left, bool right, bool topLeft, bool topRight, bool bottomLeft, bool bottomRight)
        {
            var val_23;
            var val_28;
            var val_29;
            var val_30;
            if((true <= 5) && ((0 & 41) == 0))
            {
                    return;
            }
            
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_1 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetHoneySortingForExplosion();
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  static_value_02D64000, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_1.layer, order = val_1.order, sortEverything = val_1.sortEverything & 4294967295});
            var val_4 = (left != true) ? 2f : 1f;
            val_23 = this.transform;
            var val_5 = (top != true) ? 2f : 1f;
            label_29:
            if(val_23 != null)
            {
                goto label_8;
            }
            
            if(top != true)
            {
                    if(left == false)
            {
                    return;
            }
            
            }
            
            if(topLeft == false)
            {
                goto label_12;
            }
            
            if(top == false)
            {
                goto label_13;
            }
            
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.up;
            val_28 = 5;
            val_29 = 1;
            val_30 = 0;
            goto label_16;
            label_12:
            UnityEngine.Transform val_13 = this.transform;
            goto label_29;
            label_8:
            localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            return;
            label_13:
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.left;
            val_28 = 5;
            val_30 = 1;
            val_29 = 0;
            label_16:
            this.InitExtraRenderer(type:  5, flipX:  true, flipY:  false, position:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
        }
        public HoneyItemSpriteTL()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
