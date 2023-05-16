using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View
{
    public class CurtainPartTL : CurtainPart
    {
        // Methods
        public override void ArrangeSprite(int spriteType)
        {
            if(spriteType > 3)
            {
                    return;
            }
            
            var val_9 = 36604824 + (spriteType) << 2;
            val_9 = val_9 + 36604824;
            goto (36604824 + (spriteType) << 2 + 36604824);
        }
        public CurtainPartTL()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
