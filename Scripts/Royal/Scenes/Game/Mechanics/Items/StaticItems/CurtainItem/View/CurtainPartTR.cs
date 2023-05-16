using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View
{
    public class CurtainPartTR : CurtainPart
    {
        // Methods
        public override void ArrangeSprite(int spriteType)
        {
            if(spriteType > 3)
            {
                    return;
            }
            
            var val_9 = 36604840 + (spriteType) << 2;
            val_9 = val_9 + 36604840;
            goto (36604840 + (spriteType) << 2 + 36604840);
        }
        public CurtainPartTR()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
