using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Animations
{
    public class RoyalPassUnlimitedRewardCountdownAnimation : MonoBehaviour
    {
        // Fields
        private DG.Tweening.Sequence seq;
        
        // Methods
        private void OnEnable()
        {
            this.seq = DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.PrependInterval(s:  DG.Tweening.TweenSettingsExtensions.Append(s:  DG.Tweening.DOTween.Sequence(), t:  DG.Tweening.ShortcutExtensions.DOLocalRotate(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  23f), mode:  1)), interval:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  48f)), loops:  0);
        }
        private void OnDisable()
        {
            DG.Tweening.TweenExtensions.Kill(t:  this.seq, complete:  false);
            this.seq = 0;
            UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.identity;
            this.transform.localRotation = new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w};
        }
        public RoyalPassUnlimitedRewardCountdownAnimation()
        {
        
        }
    
    }

}
