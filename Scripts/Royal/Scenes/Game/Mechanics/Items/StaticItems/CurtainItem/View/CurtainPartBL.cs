using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View
{
    public class CurtainPartBL : CurtainPart
    {
        // Methods
        public override void ArrangeSprite(int spriteType)
        {
            if((spriteType - 2) > 3)
            {
                    return;
            }
            
            var val_8 = 36604792 + ((spriteType - 2)) << 2;
            val_8 = val_8 + 36604792;
            goto (36604792 + ((spriteType - 2)) << 2 + 36604792);
        }
        public CurtainPartBL()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
