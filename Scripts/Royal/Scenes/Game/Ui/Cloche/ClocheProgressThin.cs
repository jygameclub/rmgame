using UnityEngine;

namespace Royal.Scenes.Game.Ui.Cloche
{
    public class ClocheProgressThin : ClocheProgress
    {
        // Methods
        protected override void PrepareClocheSpritePosition()
        {
            float val_10;
            float val_11;
            float val_12;
            UnityEngine.Transform val_1 = 8059.transform;
            if(true != 2)
            {
                    if(true != 0)
            {
                    return;
            }
            
                UnityEngine.Vector3 val_2 = val_1.localPosition;
                val_10 = val_2.x;
                val_11 = val_2.y;
                val_12 = val_2.z;
                UnityEngine.Vector3 val_3 = UnityEngine.Vector3.down;
            }
            else
            {
                    UnityEngine.Vector3 val_4 = val_1.localPosition;
                val_10 = val_4.x;
                val_11 = val_4.y;
                val_12 = val_4.z;
                UnityEngine.Vector3 val_5 = UnityEngine.Vector3.up;
            }
            
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  0.025f);
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_10, y = val_11, z = val_12}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            val_1.localPosition = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, d:  0.75f);
            val_1.localScale = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
        }
        public ClocheProgressThin()
        {
        
        }
    
    }

}
