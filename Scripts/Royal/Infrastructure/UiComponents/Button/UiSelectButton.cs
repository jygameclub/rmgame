using UnityEngine;

namespace Royal.Infrastructure.UiComponents.Button
{
    public class UiSelectButton : UiButton
    {
        // Fields
        public UnityEngine.GameObject selectedState;
        public UnityEngine.GameObject unselectedState;
        public UnityEngine.Transform objectToScale;
        private UnityEngine.Vector3 initialObjectScale;
        private DG.Tweening.Sequence sequence;
        
        // Methods
        public void Awake()
        {
            if(this.objectToScale == 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_2 = this.objectToScale.localScale;
            this.initialObjectScale = val_2;
            mem[1152921527531619956] = val_2.y;
            mem[1152921527531619960] = val_2.z;
        }
        public void Select(bool select)
        {
            this.selectedState.SetActive(value:  select);
            this.unselectedState.SetActive(value:  (~select) & 1);
        }
        protected override void PlayScaleDownAnimation()
        {
            if(this.objectToScale == 0)
            {
                    this.PlayScaleDownAnimation();
                return;
            }
            
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            this.sequence = val_2;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.initialObjectScale, y = V8.16B, z = V9.16B}, d:  0.9f);
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.objectToScale, endValue:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, duration:  0.05f));
        }
        protected override void PlayScaleUpAnimation()
        {
            if(this.objectToScale == 0)
            {
                    this.PlayScaleUpAnimation();
                return;
            }
            
            DG.Tweening.TweenExtensions.Kill(t:  this.sequence, complete:  false);
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.initialObjectScale, y = V8.16B, z = V9.16B}, d:  0.9f);
            this.objectToScale.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            DG.Tweening.Sequence val_3 = DG.Tweening.DOTween.Sequence();
            this.sequence = val_3;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.initialObjectScale, y = val_2.y, z = val_2.z}, d:  1.05f);
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Append(s:  DG.Tweening.TweenSettingsExtensions.Append(s:  val_3, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.objectToScale, endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  0.05f)), t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.objectToScale, endValue:  new UnityEngine.Vector3() {x = this.initialObjectScale, y = val_4.y, z = val_4.z}, duration:  0.05f));
        }
        public UiSelectButton()
        {
            mem[1152921527532215340] = 1;
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
