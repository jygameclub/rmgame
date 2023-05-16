using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.StaticItems.HoneyItem.View
{
    public class HoneyItemSpriteBR : HoneyItemSprite
    {
        // Methods
        protected override void InitSprite()
        {
            this.InitSprite();
            this.flipX = true;
            this.flipY = true;
        }
        public override void SelectSprite(bool top, bool bottom, bool left, bool right, bool topLeft, bool topRight, bool bottomLeft, bool bottomRight, UnityEngine.SpriteRenderer connectRenderer)
        {
            connectRenderer.enabled = false;
            bool val_1 = bottom & right;
            if((val_1 == false) || (bottomRight == false))
            {
                goto label_3;
            }
            
            label_23:
            mem[1152921520030859354] = 2;
            goto label_31;
            label_3:
            if(val_1 == false)
            {
                goto label_5;
            }
            
            mem[1152921520030859354] = 5;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_2 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetHoneySortingForCorner(sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = right, order = right, sortEverything = left});
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  connectRenderer, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_2.layer, order = val_2.order, sortEverything = val_2.sortEverything & 4294967295});
            goto label_31;
            label_5:
            if(((top == true) || (bottom == false)) || (bottomRight == false))
            {
                goto label_11;
            }
            
            mem[1152921520030859354] = 4;
            this.flipX = false;
            label_28:
            UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.Euler(x:  0f, y:  0f, z:  90f);
            this.transform.localRotation = new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w};
            label_31:
            this.EnableSprites();
            return;
            label_11:
            if(right != false)
            {
                    if(bottomRight == true)
            {
                goto label_18;
            }
            
            }
            
            if(bottom == false)
            {
                goto label_19;
            }
            
            if(top == false)
            {
                goto label_20;
            }
            
            mem[1152921520030859354] = 0;
            goto label_31;
            label_19:
            if(right == false)
            {
                goto label_22;
            }
            
            label_18:
            var val_6 = (left != true) ? 0 : 4;
            goto label_23;
            label_20:
            mem[1152921520030859354] = 4;
            this.flipY = false;
            UnityEngine.Transform val_7 = this.transform;
            goto label_28;
            label_22:
            mem[1152921520030859354] = 3;
            if(bottomRight == false)
            {
                goto label_31;
            }
            
            mem[1152921520030859356] = 1;
            connectRenderer.enabled = true;
            connectRenderer.sprite = connectRenderer.GetConnect();
            goto label_31;
        }
        public override void PrepareForExplosion(bool top, bool bottom, bool left, bool right, bool topLeft, bool topRight, bool bottomLeft, bool bottomRight)
        {
            if((true <= 5) && ((0 & 43) == 0))
            {
                    return;
            }
            
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_1 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetHoneySortingForExplosion();
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  static_value_02D64000, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_1.layer, order = val_1.order, sortEverything = val_1.sortEverything & 4294967295});
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_3 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetHoneySortingForExplosion();
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  static_value_02D64000, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_3.layer, order = val_3.order, sortEverything = val_3.sortEverything & 4294967295});
            var val_6 = (right != true) ? 2f : 1f;
            var val_7 = (bottom != true) ? 2f : 1f;
            this.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        public HoneyItemSpriteBR()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
