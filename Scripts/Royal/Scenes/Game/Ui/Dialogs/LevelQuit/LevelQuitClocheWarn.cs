using UnityEngine;

namespace Royal.Scenes.Game.Ui.Dialogs.LevelQuit
{
    public class LevelQuitClocheWarn : ClocheWarn
    {
        // Methods
        protected override void SetupClocheAndCrossSign(int clocheCount)
        {
            float val_11;
            if(clocheCount == 1)
            {
                    UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
                UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  0.58f);
                localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
                val_11 = 0.183f;
            }
            else
            {
                    if(clocheCount == 2)
            {
                    UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
                UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  0.65f);
                localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
                val_11 = 0.083f;
            }
            else
            {
                    UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
                UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  0.62f);
                localScale = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
                val_11 = 0.067f;
            }
            
            }
            
            this.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        public LevelQuitClocheWarn()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
