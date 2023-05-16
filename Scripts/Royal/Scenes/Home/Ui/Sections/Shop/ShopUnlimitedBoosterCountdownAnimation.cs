using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Shop
{
    public class ShopUnlimitedBoosterCountdownAnimation : MonoBehaviour
    {
        // Methods
        private void Awake()
        {
            this.RotateLooped();
        }
        private void RotateLooped()
        {
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.PrependInterval(s:  DG.Tweening.TweenSettingsExtensions.Append(s:  DG.Tweening.DOTween.Sequence(), t:  DG.Tweening.ShortcutExtensions.DOLocalRotate(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  23f), mode:  1)), interval:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  48f)), loops:  0);
        }
        public ShopUnlimitedBoosterCountdownAnimation()
        {
        
        }
    
    }

}
