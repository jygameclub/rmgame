using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.StaticItems.HoneyItem.View
{
    public class HoneyItemSpriteTR : HoneyItemSprite
    {
        // Methods
        protected override void InitSprite()
        {
            this.InitSprite();
            this.flipX = true;
            this.flipY = false;
        }
        public override void SelectSprite(bool top, bool bottom, bool left, bool right, bool topLeft, bool topRight, bool bottomLeft, bool bottomRight, UnityEngine.SpriteRenderer connectRenderer)
        {
            bool val_1 = top & right;
            if((val_1 == false) || (topRight == false))
            {
                goto label_2;
            }
            
            label_25:
            mem[1152921520031845466] = 2;
            goto label_26;
            label_2:
            if(val_1 == false)
            {
                goto label_4;
            }
            
            mem[1152921520031845466] = 5;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_2 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetHoneySortingForCorner(sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = right, order = right, sortEverything = left});
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  topRight, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_2.layer, order = val_2.order, sortEverything = val_2.sortEverything & 4294967295});
            goto label_26;
            label_4:
            if(((top == false) || (topRight == false)) || (bottom == true))
            {
                goto label_10;
            }
            
            label_21:
            mem[1152921520031845466] = 4;
            this.flipY = true;
            UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.Euler(x:  0f, y:  0f, z:  90f);
            this.transform.localRotation = new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w};
            label_26:
            this.EnableSprites();
            return;
            label_10:
            if((right == false) || (topRight == false))
            {
                goto label_17;
            }
            
            if(left == false)
            {
                goto label_25;
            }
            
            mem[1152921520031845466] = 0;
            goto label_26;
            label_17:
            if(top == false)
            {
                goto label_20;
            }
            
            if(bottom == false)
            {
                goto label_21;
            }
            
            goto label_25;
            label_20:
            if(right == false)
            {
                goto label_23;
            }
            
            var val_6 = (left != true) ? 0 : 4;
            goto label_25;
            label_23:
            mem[1152921520031845466] = 3;
            mem[1152921520031845468] = topRight;
            goto label_26;
        }
        public override void PrepareForExplosion(bool top, bool bottom, bool left, bool right, bool topLeft, bool topRight, bool bottomLeft, bool bottomRight)
        {
            if((true <= 5) && ((0 & 41) == 0))
            {
                    return;
            }
            
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_1 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetHoneySortingForExplosion();
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  static_value_02D64000, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_1.layer, order = val_1.order, sortEverything = val_1.sortEverything & 4294967295});
            UnityEngine.Transform val_3 = this.transform;
            var val_4 = (right != true) ? 2f : 1f;
            var val_5 = (top != true) ? 2f : 1f;
            localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        public HoneyItemSpriteTR()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
