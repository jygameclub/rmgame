using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SoilItem.View
{
    public class SoilItemSpriteTR : SoilItemSprite
    {
        // Methods
        protected override void InitSprite()
        {
            this.InitSprite();
            this.flipX = true;
            this.flipY = false;
        }
        public override void SelectSprite(bool top, bool bottom, bool left, bool right, bool topLeft, bool topRight, bool bottomLeft, bool bottomRight)
        {
            bool val_1 = top & right;
            if((val_1 != false) && (topRight != false))
            {
                    mem[1152921520162200336] = 4;
                this.EnableSprites();
                return;
            }
            
            if(val_1 != false)
            {
                    mem[1152921520162200336] = 2;
                this.EnableSprites();
                return;
            }
            
            if(top == false)
            {
                goto label_3;
            }
            
            if(this == null)
            {
                goto label_4;
            }
            
            mem[1152921520162200336] = ((topRight & true) != 0) ? 3 : (!0);
            this.EnableSprites();
            return;
            label_3:
            if(right != false)
            {
                    mem[1152921520162200336] = ((topRight & true) != 0) ? (-0) : 0;
                this.EnableSprites();
                return;
            }
            
            mem[1152921520162200336] = 0;
            this.EnableSprites();
            return;
            label_4:
            throw new NullReferenceException();
        }
        public SoilItemSpriteTR()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
