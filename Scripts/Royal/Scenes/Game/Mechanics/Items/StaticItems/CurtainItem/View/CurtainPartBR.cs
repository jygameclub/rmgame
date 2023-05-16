using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View
{
    public class CurtainPartBR : CurtainPart
    {
        // Methods
        public override void ArrangeSprite(int spriteType)
        {
            if((spriteType - 2) > 3)
            {
                    return;
            }
            
            var val_8 = 36604808 + ((spriteType - 2)) << 2;
            val_8 = val_8 + 36604808;
            goto (36604808 + ((spriteType - 2)) << 2 + 36604808);
        }
        public CurtainPartBR()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
