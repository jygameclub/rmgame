using UnityEngine;

namespace Royal.Infrastructure.Utils.Slider
{
    public class FloatVariableSetter : MonoBehaviour
    {
        // Fields
        public Royal.Infrastructure.Utils.Slider.FloatVariable floatVariable;
        
        // Methods
        public void SetAllVariables()
        {
            var val_2;
            if(val_1.Length < 1)
            {
                    return;
            }
            
            var val_7 = 0;
            label_9:
            T val_2 = this.GetComponentsInChildren<Royal.Infrastructure.Utils.Slider.IFloatVariableHolder>()[val_7];
            var val_6 = val_2;
            if((val_1[0x0][0] + 294) == 0)
            {
                goto label_8;
            }
            
            var val_3 = val_1[0x0][0] + 176;
            var val_4 = 0;
            val_3 = val_3 + 8;
            label_7:
            if(((val_1[0x0][0] + 176 + 8) + -8) == null)
            {
                goto label_6;
            }
            
            val_4 = val_4 + 1;
            val_3 = val_3 + 16;
            if(val_4 < (val_1[0x0][0] + 294))
            {
                goto label_7;
            }
            
            goto label_8;
            label_6:
            var val_5 = val_3;
            val_5 = val_5 + 1;
            val_6 = val_6 + val_5;
            val_2 = val_6 + 304;
            label_8:
            val_2.FloatVariable = this.floatVariable;
            val_7 = val_7 + 1;
            if(val_7 < val_1.Length)
            {
                goto label_9;
            }
        
        }
        public FloatVariableSetter()
        {
        
        }
    
    }

}
