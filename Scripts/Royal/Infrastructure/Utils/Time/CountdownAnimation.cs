using UnityEngine;

namespace Royal.Infrastructure.Utils.Time
{
    public class CountdownAnimation : MonoBehaviour
    {
        // Fields
        private int rotationDirection;
        
        // Methods
        private void Awake()
        {
            this.rotationDirection = 0;
        }
        public void Rotate()
        {
            int val_7 = this.rotationDirection;
            int val_1 = val_7 + 1;
            val_7 = (val_1 < 0) ? (val_7 + 4) : (val_7 + 1);
            val_7 = val_7 & 4294967292;
            val_7 = val_1 - val_7;
            this.rotationDirection = val_7;
            float val_3 = (float)val_7 * (-90f);
            DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> val_6 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalRotate(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  0.2166667f, mode:  0), ease:  27);
        }
        public void Reset()
        {
            this.rotationDirection = 0;
            UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.Euler(x:  0f, y:  0f, z:  (float)this.rotationDirection * (-90f));
            this.transform.localRotation = new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w};
        }
        public CountdownAnimation()
        {
        
        }
    
    }

}
