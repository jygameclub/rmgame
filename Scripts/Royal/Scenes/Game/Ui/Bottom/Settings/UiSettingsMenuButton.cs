using UnityEngine;

namespace Royal.Scenes.Game.Ui.Bottom.Settings
{
    public class UiSettingsMenuButton : MonoBehaviour
    {
        // Fields
        public UnityEngine.Vector3 target;
        public UnityEngine.Vector3 origin;
        private DG.Tweening.Tween inTween;
        private DG.Tweening.Tween outTween;
        
        // Methods
        protected virtual void Awake()
        {
            if((Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1).IsDeviceWide()) == false)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.right;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  2f);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.origin, y = V8.16B, z = V9.16B}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            this.origin = val_5;
            mem[1152921519948485800] = val_5.y;
            mem[1152921519948485804] = val_5.z;
            UnityEngine.Transform val_6 = this.transform;
            UnityEngine.Vector3 val_7 = val_6.position;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.right;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, d:  2f);
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            val_6.position = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
        }
        public void Show(float interval, DG.Tweening.Sequence seq)
        {
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_4 = DG.Tweening.TweenExtensions.Pause<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = this.target}, duration:  0.3f, snapping:  false), ease:  27));
            this.inTween = val_4;
            val_4 = 1073741824;
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Insert(s:  seq, atPosition:  interval, t:  DG.Tweening.TweenExtensions.Play<DG.Tweening.Tween>(t:  this.inTween));
        }
        public void Hide(float interval, DG.Tweening.Sequence seq)
        {
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_4 = DG.Tweening.TweenExtensions.Pause<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = this.origin}, duration:  0.1f, snapping:  false), ease:  3));
            this.outTween = val_4;
            val_4 = 1073741824;
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Insert(s:  seq, atPosition:  interval, t:  DG.Tweening.TweenExtensions.Play<DG.Tweening.Tween>(t:  this.outTween));
        }
        public UiSettingsMenuButton()
        {
        
        }
    
    }

}
