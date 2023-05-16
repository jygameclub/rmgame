using UnityEngine;

namespace Royal.Scenes.Game.Ui.Cloche
{
    public class ClocheItemView : MonoBehaviour
    {
        // Fields
        public float endScale;
        public UnityEngine.SpriteRenderer view;
        public UnityEngine.SpriteRenderer shadow;
        public UnityEngine.SpriteRenderer flatShadow;
        
        // Methods
        public float Anticipate(float yScale = 0.9)
        {
            UnityEngine.Vector3 val_2 = this.transform.localPosition;
            UnityEngine.Bounds val_3 = this.view.bounds;
            UnityEngine.Vector3 val_7 = this.transform.localScale;
            float val_8 = 1f - yScale;
            val_8 = val_8 * val_2.y;
            float val_28 = 0.5f;
            val_28 = val_8 * val_28;
            float val_9 = val_7.y * yScale;
            float val_10 = 1f / yScale;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            DG.Tweening.Sequence val_12 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_12, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  0.1f));
            DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_12, t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, duration:  0.05f, snapping:  false));
            DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_12, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, duration:  0.05f));
            DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_12, t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.025f, snapping:  false));
            DG.Tweening.Sequence val_26 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_12, action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Game.Ui.Cloche.ClocheItemView::<Anticipate>b__4_0()));
            return (float)DG.Tweening.TweenExtensions.Duration(t:  val_12, includeLoops:  true);
        }
        public ClocheItemView()
        {
        
        }
        private void <Anticipate>b__4_0()
        {
            if(this.flatShadow != null)
            {
                    this.flatShadow.enabled = false;
                return;
            }
            
            throw new NullReferenceException();
        }
    
    }

}
