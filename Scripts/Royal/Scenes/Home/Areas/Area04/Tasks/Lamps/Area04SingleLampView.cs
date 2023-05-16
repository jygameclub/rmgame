using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area04.Tasks.Lamps
{
    public class Area04SingleLampView : MonoBehaviour
    {
        // Fields
        public UnityEngine.SpriteRenderer bottom;
        public UnityEngine.SpriteRenderer middle;
        public UnityEngine.SpriteRenderer top;
        public float yOffset;
        public float footDuration;
        public float duration;
        public float delay;
        public float delay2;
        
        // Methods
        public virtual DG.Tweening.Sequence PlayAnimation()
        {
            UnityEngine.Vector3 val_2 = this.bottom.transform.localPosition;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  this.yOffset);
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            this.bottom.transform.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
            this.bottom.transform.localScale = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            UnityEngine.Vector3 val_10 = this.middle.transform.localPosition;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, d:  this.yOffset);
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
            this.middle.transform.localPosition = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.zero;
            this.middle.transform.localScale = new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z};
            UnityEngine.Vector3 val_18 = this.top.transform.localPosition;
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, d:  this.yOffset);
            UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, b:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z});
            this.top.transform.localPosition = new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z};
            UnityEngine.Vector3 val_24 = UnityEngine.Vector3.zero;
            this.top.transform.localScale = new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z};
            DG.Tweening.Sequence val_25 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_31 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_25, t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.bottom.transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.15f, snapping:  false), ease:  2), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area04.Tasks.Lamps.Area04SingleLampView::<PlayAnimation>b__8_0())));
            UnityEngine.Vector3 val_33 = UnityEngine.Vector3.one;
            DG.Tweening.Sequence val_35 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_25, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.bottom.transform, endValue:  new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z}, duration:  0.03f));
            DG.Tweening.Sequence val_36 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_25, interval:  0.05f);
            DG.Tweening.Sequence val_42 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_25, t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.middle.transform, endValue:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, duration:  0.15f, snapping:  false), ease:  2), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area04.Tasks.Lamps.Area04SingleLampView::<PlayAnimation>b__8_1())));
            UnityEngine.Vector3 val_44 = UnityEngine.Vector3.one;
            DG.Tweening.Sequence val_46 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_25, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.middle.transform, endValue:  new UnityEngine.Vector3() {x = val_44.x, y = val_44.y, z = val_44.z}, duration:  0.03f));
            DG.Tweening.Sequence val_47 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_25, interval:  0.05f);
            DG.Tweening.Sequence val_53 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_25, t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.top.transform, endValue:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, duration:  0.15f, snapping:  false), ease:  2), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area04.Tasks.Lamps.Area04SingleLampView::<PlayAnimation>b__8_2())));
            UnityEngine.Vector3 val_55 = UnityEngine.Vector3.one;
            DG.Tweening.Sequence val_57 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_25, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.top.transform, endValue:  new UnityEngine.Vector3() {x = val_55.x, y = val_55.y, z = val_55.z}, duration:  0.03f));
            return val_25;
        }
        private void SquashStretch(UnityEngine.Transform trans, float xScale = 1.1, float yScale = 0.9, float duration = 0.1)
        {
            UnityEngine.Vector3 val_1 = trans.localScale;
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  trans, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  duration));
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  trans, endValue:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, duration:  duration));
        }
        public Area04SingleLampView()
        {
            this.delay2 = 0.5f;
            this.yOffset = ;
            this.footDuration = ;
            this.duration = 0.15f;
            this.delay = 0.35f;
        }
        private void <PlayAnimation>b__8_0()
        {
            UnityEngine.Transform val_1 = this.bottom.transform;
            val_1.SquashStretch(trans:  val_1, xScale:  1.1f, yScale:  0.9f, duration:  0.1f);
        }
        private void <PlayAnimation>b__8_1()
        {
            UnityEngine.Transform val_1 = this.middle.transform;
            val_1.SquashStretch(trans:  val_1, xScale:  1.1f, yScale:  0.9f, duration:  0.1f);
        }
        private void <PlayAnimation>b__8_2()
        {
            UnityEngine.Transform val_1 = this.top.transform;
            val_1.SquashStretch(trans:  val_1, xScale:  1.1f, yScale:  0.9f, duration:  0.1f);
        }
    
    }

}
