using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.StaticItems.HoneyItem.View
{
    public class HoneyItemSpriteBL : HoneyItemSprite
    {
        // Methods
        protected override void InitSprite()
        {
            this.InitSprite();
            this.flipX = false;
            this.flipY = true;
        }
        public override void SelectSprite(bool top, bool bottom, bool left, bool right, bool topLeft, bool topRight, bool bottomLeft, bool bottomRight, UnityEngine.SpriteRenderer connectRenderer)
        {
            bool val_9;
            var val_10;
            var val_12;
            val_9 = bottomLeft;
            connectRenderer.enabled = false;
            bool val_1 = bottom & left;
            if((val_1 == false) || (val_9 == false))
            {
                goto label_3;
            }
            
            label_32:
            mem[1152921520030349914] = 2;
            goto label_40;
            label_3:
            if(val_1 == false)
            {
                goto label_5;
            }
            
            mem[1152921520030349914] = 5;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_2 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetHoneySortingForCorner(sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = right, order = right, sortEverything = val_9});
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  connectRenderer, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_2.layer, order = val_2.order, sortEverything = val_2.sortEverything & 4294967295});
            goto label_40;
            label_5:
            if(((top == true) || (bottom == false)) || (val_9 == false))
            {
                goto label_11;
            }
            
            mem[1152921520030349914] = 4;
            this.flipY = false;
            val_10 = this.transform;
            goto label_29;
            label_11:
            if((left == false) || (val_9 == false))
            {
                goto label_18;
            }
            
            if(right == false)
            {
                goto label_19;
            }
            
            label_31:
            val_12 = 1;
            goto label_20;
            label_18:
            if(bottom == false)
            {
                goto label_21;
            }
            
            if(top == false)
            {
                goto label_22;
            }
            
            mem[1152921520030349914] = 0;
            goto label_40;
            label_19:
            mem[1152921520030349914] = 4;
            this.flipX = true;
            this.flipY = false;
            val_10 = this.transform;
            goto label_29;
            label_21:
            if(left == false)
            {
                goto label_30;
            }
            
            if(right == true)
            {
                goto label_31;
            }
            
            goto label_32;
            label_22:
            val_12 = 4;
            label_20:
            mem[1152921520030349914] = val_12;
            this.flipX = true;
            val_10 = this.transform;
            label_29:
            UnityEngine.Quaternion val_7 = UnityEngine.Quaternion.Euler(x:  0f, y:  0f, z:  -90f);
            val_10.localRotation = new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w};
            label_40:
            this.EnableSprites();
            return;
            label_30:
            mem[1152921520030349914] = 3;
            if(val_9 == false)
            {
                goto label_40;
            }
            
            mem[1152921520030349916] = 1;
            connectRenderer.enabled = true;
            connectRenderer.sprite = connectRenderer.GetConnect();
            goto label_40;
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
            var val_4 = (left != true) ? 2f : 1f;
            var val_5 = (bottom != true) ? 2f : 1f;
            localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        public HoneyItemSpriteBL()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
