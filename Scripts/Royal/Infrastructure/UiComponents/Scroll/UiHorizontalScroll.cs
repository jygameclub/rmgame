using UnityEngine;

namespace Royal.Infrastructure.UiComponents.Scroll
{
    public class UiHorizontalScroll : UiScroll
    {
        // Properties
        public override Royal.Infrastructure.UiComponents.Scroll.Direction ScrollDirection { get; }
        
        // Methods
        public override Royal.Infrastructure.UiComponents.Scroll.Direction get_ScrollDirection()
        {
            return 0;
        }
        protected override float LocalPosition(UnityEngine.Vector2 worldPosition)
        {
            UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = worldPosition.x, y = worldPosition.y});
            return this.transform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        }
        public override void PrepareContent(float distance)
        {
            UnityEngine.Transform val_1 = 40534.transform;
            UnityEngine.Vector3 val_2 = val_1.localPosition;
            float val_3 = UnityEngine.Mathf.Clamp(value:  distance, min:  V12.16B, max:  V11.16B);
            val_1.localPosition = new UnityEngine.Vector3() {x = val_3, y = val_2.y, z = val_2.z};
            mem[1152921527511265104] = val_3;
            goto typeof(UnityEngine.Transform).__il2cppRuntimeField_190;
        }
        protected override void MoveContent()
        {
            UnityEngine.Transform val_1 = this.transform;
            UnityEngine.Vector3 val_2 = val_1.localPosition;
            float val_3 = S3 - val_2.x;
            val_3 = val_3 * 0.52f;
            val_1.localPosition = new UnityEngine.Vector3() {x = val_2.x + val_3, y = val_2.y, z = val_2.z};
            goto typeof(UnityEngine.Transform).__il2cppRuntimeField_190;
        }
        protected override void PrepareContent()
        {
            UnityEngine.Vector2 val_1 = this.size;
            float val_6 = 0.5f;
            val_6 = val_1.x * val_6;
            float val_2 = S2 - val_6;
            mem[1152921527511505484] = val_2;
            val_1.x = ((val_1.y < 0) ? val_1.x : val_1.y) - val_1.x;
            val_1.x = val_6 + val_1.x;
            val_1.x = val_2 - val_1.x;
            mem[1152921527511505480] = val_1.x;
            UnityEngine.Transform val_4 = this.transform;
            UnityEngine.Vector3 val_5 = val_4.localPosition;
            val_4.localPosition = new UnityEngine.Vector3() {x = V8.16B, y = val_5.y, z = val_5.z};
            mem[1152921527511505488] = ???;
        }
        public UiHorizontalScroll()
        {
        
        }
    
    }

}
