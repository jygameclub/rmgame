using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SoilItem.View
{
    public class SoilItemSpriteBL : SoilItemSprite
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
            var val_2;
            bool val_1 = bottom & left;
            if((val_1 != false) && (bottomLeft != false))
            {
                    this.flipY = true;
                val_2 = 4;
            }
            else
            {
                    if(val_1 != false)
            {
                    val_2 = 7;
            }
            else
            {
                    if(bottom != false)
            {
                    this.flipY = true;
                val_2 = 3;
            }
            else
            {
                    if(left != false)
            {
                    val_2 = 6;
            }
            else
            {
                    val_2 = 5;
            }
            
            }
            
            }
            
            }
            
            mem[1152921520161192336] = 5;
            this.EnableSprites();
        }
        public SoilItemSpriteBL()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
