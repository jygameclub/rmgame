using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area02.Tasks.Candles
{
    public class Area02SingleCandleView : MonoBehaviour
    {
        // Fields
        public UnityEngine.SpriteRenderer shadow;
        public UnityEngine.SpriteRenderer bottom;
        public UnityEngine.SpriteRenderer middle;
        public UnityEngine.SpriteRenderer top;
        public UnityEngine.SpriteRenderer[] candles;
        public UnityEngine.ParticleSystem[] particles;
        public float yOffset;
        public float footDuration;
        public float duration;
        public float candleDuration;
        public float delay;
        public float delay2;
        
        // Methods
        public DG.Tweening.Sequence PlaySticks()
        {
            var val_53;
            DG.Tweening.TweenCallback val_55;
            UnityEngine.Transform val_56;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            this.shadow.transform.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
            this.bottom.transform.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            UnityEngine.Transform val_5 = this.middle.transform;
            UnityEngine.Vector3 val_6 = val_5.localPosition;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  this.yOffset);
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            val_5.localPosition = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
            val_5.localScale = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
            UnityEngine.Transform val_11 = this.top.transform;
            UnityEngine.Vector3 val_12 = val_11.localPosition;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, d:  this.yOffset);
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, b:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
            val_11.localPosition = new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z};
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.zero;
            val_11.localScale = new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z};
            DG.Tweening.Sequence val_17 = DG.Tweening.DOTween.Sequence();
            var val_54 = 0;
            label_18:
            if(val_54 >= this.particles.Length)
            {
                goto label_14;
            }
            
            this.particles[val_54].gameObject.SetActive(value:  false);
            val_54 = val_54 + 1;
            if(this.particles != null)
            {
                goto label_18;
            }
            
            label_14:
            DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_17, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.bottom.transform, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  this.footDuration), ease:  4), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area02.Tasks.Candles.Area02SingleCandleView::<PlaySticks>b__12_0())));
            DG.Tweening.Sequence val_30 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_17, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.shadow.transform, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  this.footDuration), ease:  4), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area02.Tasks.Candles.Area02SingleCandleView::<PlaySticks>b__12_1())));
            val_53 = null;
            val_53 = null;
            val_55 = Area02SingleCandleView.<>c.<>9__12_2;
            if(val_55 == null)
            {
                    DG.Tweening.TweenCallback val_34 = null;
                val_55 = val_34;
                val_34 = new DG.Tweening.TweenCallback(object:  Area02SingleCandleView.<>c.__il2cppRuntimeField_static_fields, method:  System.Void Area02SingleCandleView.<>c::<PlaySticks>b__12_2());
                Area02SingleCandleView.<>c.<>9__12_2 = val_55;
            }
            
            DG.Tweening.Sequence val_36 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_17, atPosition:  this.delay, t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.middle.transform, endValue:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, duration:  this.duration, snapping:  false), ease:  2), action:  val_34));
            UnityEngine.Vector3 val_38 = UnityEngine.Vector3.one;
            DG.Tweening.Sequence val_40 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_17, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.middle.transform, endValue:  new UnityEngine.Vector3() {x = val_38.x, y = val_38.y, z = val_38.z}, duration:  0.03f));
            DG.Tweening.Sequence val_46 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_17, atPosition:  this.delay2, t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.top.transform, endValue:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, duration:  this.duration, snapping:  false), ease:  2), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area02.Tasks.Candles.Area02SingleCandleView::<PlaySticks>b__12_3())));
            val_56 = this.top.transform;
            UnityEngine.Vector3 val_48 = UnityEngine.Vector3.one;
            DG.Tweening.Sequence val_50 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_17, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_56, endValue:  new UnityEngine.Vector3() {x = val_48.x, y = val_48.y, z = val_48.z}, duration:  0.03f));
            var val_56 = 0;
            do
            {
                if(val_56 >= this.candles.Length)
            {
                    return val_17;
            }
            
                val_56 = this.candles[val_56].transform;
                UnityEngine.Vector3 val_52 = UnityEngine.Vector3.zero;
                val_56.localScale = new UnityEngine.Vector3() {x = val_52.x, y = val_52.y, z = val_52.z};
                val_56 = val_56 + 1;
            }
            while(this.candles != null);
            
            throw new NullReferenceException();
        }
        public DG.Tweening.Sequence PlayCandles()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            var val_23 = 0;
            label_13:
            if(val_23 >= this.candles.Length)
            {
                goto label_4;
            }
            
            .<>4__this = this;
            UnityEngine.SpriteRenderer val_21 = this.candles[val_23];
            .candle = val_21;
            UnityEngine.Transform val_3 = val_21.transform;
            UnityEngine.Vector3 val_4 = val_3.localPosition;
            .candleTargetPos = val_4;
            mem[1152921519796046492] = val_4.y;
            mem[1152921519796046496] = val_4.z;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  this.yOffset);
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  2f);
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            val_3.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
            val_3.localScale = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  new Area02SingleCandleView.<>c__DisplayClass13_0(), method:  System.Void Area02SingleCandleView.<>c__DisplayClass13_0::<PlayCandles>b__0()));
            float val_22 = this.candleDuration;
            val_22 = val_22 * 0.75f;
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  val_22);
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.one;
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  (Area02SingleCandleView.<>c__DisplayClass13_0)[1152921519796046464].candle.transform, endValue:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, duration:  0.03f));
            val_23 = val_23 + 1;
            if(this.candles != null)
            {
                goto label_13;
            }
            
            label_4:
            DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.2f);
            var val_25 = 0;
            do
            {
                if(val_25 >= this.particles.Length)
            {
                    return val_1;
            }
            
                .particle = this.particles[val_25];
                DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  new Area02SingleCandleView.<>c__DisplayClass13_1(), method:  System.Void Area02SingleCandleView.<>c__DisplayClass13_1::<PlayCandles>b__2()));
                val_25 = val_25 + 1;
            }
            while(this.particles != null);
            
            throw new NullReferenceException();
        }
        private void SquashStretch(UnityEngine.SpriteRenderer spriteRenderer, float xScale = 1.1, float yScale = 0.9, float duration = 0.1)
        {
            UnityEngine.Vector3 val_2 = spriteRenderer.transform.localScale;
            DG.Tweening.Sequence val_3 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_3, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  spriteRenderer.transform, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  duration));
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_3, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  spriteRenderer.transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  duration));
        }
        public Area02SingleCandleView()
        {
            this.yOffset = ;
            this.footDuration = ;
            this.duration = 0.15f;
            this.candleDuration = 0.1f;
            this.delay = 0.35f;
            this.delay2 = 0.5f;
        }
        private void <PlaySticks>b__12_0()
        {
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_4 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.bottom.transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.1f), ease:  4);
        }
        private void <PlaySticks>b__12_1()
        {
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_4 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.shadow.transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.1f), ease:  4);
        }
        private void <PlaySticks>b__12_3()
        {
            this.SquashStretch(spriteRenderer:  this.shadow, xScale:  1.1f, yScale:  0.9f, duration:  0.1f);
            this.SquashStretch(spriteRenderer:  this.bottom, xScale:  1.1f, yScale:  0.9f, duration:  0.1f);
        }
    
    }

}
