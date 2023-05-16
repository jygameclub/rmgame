using UnityEngine;

namespace Royal.Infrastructure.UiComponents.Button
{
    public class UiBoosterButton : UiButton
    {
        // Fields
        public UnityEngine.Transform view;
        public bool animate;
        private DG.Tweening.Sequence sequence;
        
        // Methods
        public void SetAnimate(bool withAnimation)
        {
            this.animate = withAnimation;
        }
        protected override void PlayScaleDownAnimation()
        {
            if(this.animate != false)
            {
                    DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
                this.sequence = val_1;
                DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.view.transform, endValue:  0.85f, duration:  0.05f));
                return;
            }
            
            this.PlayScaleDownAnimation();
        }
        protected override void PlayScaleUpAnimation()
        {
            if(this.animate != false)
            {
                    if(this.animate != false)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  this.sequence, complete:  false);
            }
            
                UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
                UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  0.85f);
                this.view.transform.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
                DG.Tweening.Sequence val_4 = DG.Tweening.DOTween.Sequence();
                this.sequence = val_4;
                DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.Append(s:  DG.Tweening.TweenSettingsExtensions.Append(s:  val_4, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.view.transform, endValue:  1.05f, duration:  0.05f)), t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.view.transform, endValue:  1f, duration:  0.05f));
                return;
            }
            
            this.PlayScaleUpAnimation();
        }
        public UiBoosterButton()
        {
            mem[1152921527529377324] = 1;
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
