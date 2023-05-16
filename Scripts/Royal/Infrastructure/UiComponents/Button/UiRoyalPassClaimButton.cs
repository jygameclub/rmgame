using UnityEngine;

namespace Royal.Infrastructure.UiComponents.Button
{
    public class UiRoyalPassClaimButton : UiButton
    {
        // Methods
        public override void TouchUp(UnityEngine.Vector2 position)
        {
            if(true != 0)
            {
                goto label_1;
            }
            
            UnityEngine.Vector3 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = position.x, y = position.y});
            if((this.IsInside(point:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z})) == true)
            {
                goto label_6;
            }
            
            label_1:
            mem[1152921527530923412] = 0;
            this.PlayScaleUpAnimation();
            label_6:
            this.InvokeClick(position:  new UnityEngine.Vector2() {x = position.x, y = position.y});
        }
        public UiRoyalPassClaimButton()
        {
            mem[1152921527531035372] = 1;
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
