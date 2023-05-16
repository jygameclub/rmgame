using UnityEngine;

namespace Royal.Infrastructure.UiComponents.Scroll
{
    public class UiVerticalScroll : UiScroll
    {
        // Properties
        public override Royal.Infrastructure.UiComponents.Scroll.Direction ScrollDirection { get; }
        public bool IsAtTop { get; }
        public bool IsAtBottom { get; }
        
        // Methods
        public override Royal.Infrastructure.UiComponents.Scroll.Direction get_ScrollDirection()
        {
            return 1;
        }
        public bool get_IsAtTop()
        {
            return (bool)(S0 <= S1) ? 1 : 0;
        }
        public bool get_IsAtBottom()
        {
            return (bool)(S1 >= S0) ? 1 : 0;
        }
        protected override float LocalPosition(UnityEngine.Vector2 worldPosition)
        {
            UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = worldPosition.x, y = worldPosition.y});
            UnityEngine.Vector3 val_3 = this.transform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            return (float)val_3.y;
        }
        public void MoveContentToBottom(bool withAnimation)
        {
            if(X8 != 0)
            {
                    if(withAnimation == false)
            {
                goto typeof(Royal.Infrastructure.UiComponents.Scroll.UiVerticalScroll).__il2cppRuntimeField_280;
            }
            
                this.AnimateContent(distance:  X8 + 76);
                return;
            }
            
            throw new NullReferenceException();
        }
        public void MoveContentToTop(bool withAnimation)
        {
            if(withAnimation != false)
            {
                    this.AnimateContent(distance:  0f);
            }
        
        }
        public void AnimateContent(float distance)
        {
            float val_1 = UnityEngine.Mathf.Clamp(value:  distance, min:  V10.16B, max:  V9.16B);
            UnityEngine.Vector3 val_3 = 0.transform.localPosition;
            float val_4 = val_1 - val_3.y;
            if((Royal.Infrastructure.Utils.Math.NumberExtensions.Approximately(a:  val_4, b:  0f, precision:  0.001f)) != false)
            {
                    return;
            }
            
            val_4 = val_4 / 20f;
            this.StopAllCoroutines();
            UnityEngine.Coroutine val_7 = this.StartCoroutine(routine:  this.PrepareContentWithAnimation(current:  val_3.y, piece:  val_4, final:  val_1));
        }
        private System.Collections.IEnumerator PrepareContentWithAnimation(float current, float piece, float final)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .current = current;
            .piece = piece;
            .final = final;
            return (System.Collections.IEnumerator)new UiVerticalScroll.<PrepareContentWithAnimation>d__10();
        }
        public override void PrepareContent(float distance)
        {
            UnityEngine.Transform val_1 = 40605.transform;
            UnityEngine.Vector3 val_2 = val_1.localPosition;
            float val_3 = UnityEngine.Mathf.Clamp(value:  distance, min:  V12.16B, max:  V11.16B);
            val_1.localPosition = new UnityEngine.Vector3() {x = val_2.x, y = val_3, z = val_2.z};
            mem[1152921527514684944] = val_3;
            goto typeof(UnityEngine.Transform).__il2cppRuntimeField_190;
        }
        protected override void MoveContent()
        {
            UnityEngine.Transform val_1 = this.transform;
            UnityEngine.Vector3 val_2 = val_1.localPosition;
            float val_3 = S3 - val_2.y;
            val_3 = val_3 * 0.52f;
            val_1.localPosition = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y + val_3, z = val_2.z};
            goto typeof(UnityEngine.Transform).__il2cppRuntimeField_190;
        }
        protected override void PrepareContent()
        {
            UnityEngine.Vector2 val_1 = this.size;
            float val_5 = 0.5f;
            val_5 = val_1.y * val_5;
            val_1.x = val_5 + val_1.x;
            mem[1152921527514925320] = val_1.x;
            float val_2 = (S2 < 0) ? val_1.y : (S2);
            val_2 = val_2 - val_5;
            val_1.x = val_2 + val_1.x;
            mem[1152921527514925324] = val_1.x;
            UnityEngine.Transform val_3 = this.transform;
            UnityEngine.Vector3 val_4 = val_3.localPosition;
            val_3.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = V8.16B, z = val_4.z};
            mem[1152921527514925328] = ???;
        }
        public UiVerticalScroll()
        {
        
        }
    
    }

}
