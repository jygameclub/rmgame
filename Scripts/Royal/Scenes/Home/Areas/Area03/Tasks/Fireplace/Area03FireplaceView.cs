using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area03.Tasks.Fireplace
{
    public class Area03FireplaceView : AreaTaskView
    {
        // Fields
        public UnityEngine.Transform fireplaceBottom;
        public UnityEngine.SpriteRenderer fireplaceBottomReflection;
        public UnityEngine.Transform fireplaceLeft;
        public UnityEngine.SpriteRenderer fireplaceLeftReflection;
        public UnityEngine.SpriteRenderer fireplaceLeftShadow;
        public UnityEngine.Transform fireplaceRight;
        public UnityEngine.SpriteRenderer fireplaceRightReflection;
        public UnityEngine.Transform fireplaceTop;
        public UnityEngine.SpriteRenderer fireplaceTopShadow;
        public UnityEngine.SpriteRenderer fireplaceTopShadowRight;
        public UnityEngine.SpriteRenderer fireplaceBigShadow;
        public UnityEngine.Transform leftCandleBottom;
        public UnityEngine.Transform leftCandle1;
        public UnityEngine.Transform leftCandle2;
        public UnityEngine.Transform leftCandle3;
        public UnityEngine.ParticleSystem leftCandle1Particles;
        public UnityEngine.ParticleSystem leftCandle2Particles;
        public UnityEngine.ParticleSystem leftCandle3Particles;
        public UnityEngine.Transform rightCandleBottom;
        public UnityEngine.Transform rightCandle1;
        public UnityEngine.Transform rightCandle2;
        public UnityEngine.Transform rightCandle3;
        public UnityEngine.ParticleSystem rightCandle1Particles;
        public UnityEngine.ParticleSystem rightCandle2Particles;
        public UnityEngine.ParticleSystem rightCandle3Particles;
        public UnityEngine.Transform horseBottom;
        public UnityEngine.Transform toyHorse;
        public UnityEngine.Transform leftVase;
        public UnityEngine.SpriteRenderer leftVaseReflection;
        public UnityEngine.SpriteRenderer leftVaseShadow;
        public UnityEngine.Transform rightVase;
        public UnityEngine.SpriteRenderer rightVaseReflection;
        public UnityEngine.ParticleSystem fireplaceParticles;
        
        // Methods
        protected override void Awake()
        {
            this.Awake();
            this.EnableParticles(enable:  true);
        }
        public override void PrepareAnimation()
        {
            this.PrepareAnimation();
            this.EnableParticles(enable:  false);
            this.fireplaceBigShadow.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        }
        public override DG.Tweening.Sequence PlayAnimation()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0.2f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Scripts.AreaTaskView::PlayDefaultAnimationSound()));
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0f, t:  this.AnimateFireplaceBottom());
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0.2f, t:  this.AnimateFireplaceSide(side:  this.fireplaceLeft, reflection:  this.fireplaceLeftReflection, shadow:  this.fireplaceLeftShadow));
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0.2f, t:  this.AnimateFireplaceSide(side:  this.fireplaceRight, reflection:  this.fireplaceRightReflection, shadow:  0));
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0.4f, t:  this.AnimateFireplaceTop());
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0.6f, t:  this.PlayOrnaments());
            DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  1.2f, t:  this.PlayVases());
            DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  2f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area03.Tasks.Fireplace.Area03FireplaceView::<PlayAnimation>b__35_0()));
            DG.Tweening.Sequence val_19 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0.4f, t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.fireplaceBigShadow, endValue:  1f, duration:  0.2f));
            return val_1;
        }
        private void EnableParticles(bool enable)
        {
            this.fireplaceParticles.gameObject.SetActive(value:  enable);
            this.leftCandle1Particles.gameObject.SetActive(value:  enable);
            this.leftCandle2Particles.gameObject.SetActive(value:  enable);
            this.leftCandle3Particles.gameObject.SetActive(value:  enable);
            this.rightCandle1Particles.gameObject.SetActive(value:  enable);
            this.rightCandle2Particles.gameObject.SetActive(value:  enable);
            this.rightCandle3Particles.gameObject.SetActive(value:  enable);
            if(enable == false)
            {
                    return;
            }
            
            this.fireplaceParticles.Play();
            this.leftCandle1Particles.Play();
            this.leftCandle2Particles.Play();
            this.leftCandle3Particles.Play();
            this.rightCandle1Particles.Play();
            this.rightCandle2Particles.Play();
            this.rightCandle3Particles.Play();
        }
        private DG.Tweening.Sequence AnimateFireplaceSide(UnityEngine.Transform side, UnityEngine.SpriteRenderer reflection, UnityEngine.SpriteRenderer shadow)
        {
            Area03FireplaceView.<>c__DisplayClass37_0 val_1 = new Area03FireplaceView.<>c__DisplayClass37_0();
            .side = side;
            .<>4__this = this;
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_3 = (Area03FireplaceView.<>c__DisplayClass37_0)[1152921519772075968].side.localPosition;
            UnityEngine.Vector3 val_4 = (Area03FireplaceView.<>c__DisplayClass37_0)[1152921519772075968].side.localScale;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            (Area03FireplaceView.<>c__DisplayClass37_0)[1152921519772075968].side.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
            (Area03FireplaceView.<>c__DisplayClass37_0)[1152921519772075968].side.localScale = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            (Area03FireplaceView.<>c__DisplayClass37_0)[1152921519772075968].side.gameObject.SetActive(value:  false);
            reflection.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            if(shadow != 0)
            {
                    shadow.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            }
            
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.OnStart<DG.Tweening.Sequence>(t:  val_2, action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void Area03FireplaceView.<>c__DisplayClass37_0::<AnimateFireplaceSide>b__0()));
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  (Area03FireplaceView.<>c__DisplayClass37_0)[1152921519772075968].side, endValue:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, duration:  0.3f, snapping:  false), ease:  2), action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void Area03FireplaceView.<>c__DisplayClass37_0::<AnimateFireplaceSide>b__1())));
            DG.Tweening.Sequence val_19 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_2, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  (Area03FireplaceView.<>c__DisplayClass37_0)[1152921519772075968].side, endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  0.1f), ease:  2));
            DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_2, t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  reflection, endValue:  1f, duration:  0.3f));
            if(shadow == 0)
            {
                    return val_2;
            }
            
            DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_2, t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  shadow, endValue:  1f, duration:  0.3f));
            return val_2;
        }
        private void SquashStretch(UnityEngine.Transform trans, float xScale = 1.1, float yScale = 0.9, float duration = 0.1)
        {
            UnityEngine.Vector3 val_1 = trans.localScale;
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  trans, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  duration));
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  trans, endValue:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, duration:  duration));
        }
        private DG.Tweening.Sequence AnimateFireplaceTop()
        {
            Area03FireplaceView.<>c__DisplayClass39_0 val_1 = new Area03FireplaceView.<>c__DisplayClass39_0();
            .<>4__this = this;
            UnityEngine.Vector3 val_3 = this.fireplaceTop.transform.localPosition;
            .originalPos = val_3;
            mem[1152921519772568284] = val_3.y;
            mem[1152921519772568288] = val_3.z;
            this.fireplaceTopShadow.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            this.fireplaceTopShadowRight.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            this.fireplaceTop.gameObject.SetActive(value:  false);
            DG.Tweening.Sequence val_5 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.OnStart<DG.Tweening.Sequence>(t:  val_5, action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void Area03FireplaceView.<>c__DisplayClass39_0::<AnimateFireplaceTop>b__0()));
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.one;
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_5, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.fireplaceTop.transform, endValue:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, duration:  0.1f));
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_5, t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.fireplaceTopShadow, endValue:  1f, duration:  0.15f), delay:  0.2f));
            DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_5, t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.fireplaceTopShadowRight, endValue:  1f, duration:  0.15f), delay:  0.2f));
            DG.Tweening.Sequence val_23 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_5, atPosition:  0.1f, t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.fireplaceTop.transform, endValue:  new UnityEngine.Vector3() {x = (Area03FireplaceView.<>c__DisplayClass39_0)[1152921519772568256].originalPos, y = 0.15f, z = val_9.z}, duration:  0.15f, snapping:  false), ease:  2), action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void Area03FireplaceView.<>c__DisplayClass39_0::<AnimateFireplaceTop>b__1())));
            return val_5;
        }
        private DG.Tweening.Sequence AnimateFireplaceBottom()
        {
            Area03FireplaceView.<>c__DisplayClass40_0 val_1 = new Area03FireplaceView.<>c__DisplayClass40_0();
            .<>4__this = this;
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_4 = this.fireplaceBottom.transform.localPosition;
            .originalPos = val_4;
            mem[1152921519772899420] = val_4.y;
            mem[1152921519772899424] = val_4.z;
            this.fireplaceBottomReflection.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            this.fireplaceBottom.gameObject.SetActive(value:  false);
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.OnStart<DG.Tweening.Sequence>(t:  val_2, action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void Area03FireplaceView.<>c__DisplayClass40_0::<AnimateFireplaceBottom>b__0()));
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.one;
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.fireplaceBottom.transform, endValue:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, duration:  0.1f));
            DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  0.1f, t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.fireplaceBottom.transform, endValue:  new UnityEngine.Vector3() {x = (Area03FireplaceView.<>c__DisplayClass40_0)[1152921519772899392].originalPos, y = val_9.y, z = val_9.z}, duration:  0.15f, snapping:  false), ease:  2), action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void Area03FireplaceView.<>c__DisplayClass40_0::<AnimateFireplaceBottom>b__1())));
            DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  0.1f, t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.fireplaceBottomReflection, endValue:  1f, duration:  0.15f), delay:  0.2f));
            return val_2;
        }
        private DG.Tweening.Sequence PlayOrnaments()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.PlayLeftCandles());
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  this.PlayRightCandles());
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  this.PlayToy());
            return val_1;
        }
        private DG.Tweening.Sequence PlayLeftCandles()
        {
            Area03FireplaceView.<>c__DisplayClass42_0 val_1 = new Area03FireplaceView.<>c__DisplayClass42_0();
            .<>4__this = this;
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
            this.leftCandleBottom.transform.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
            this.leftCandle1.transform.localScale = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
            this.leftCandle2.transform.localScale = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
            this.leftCandle3.transform.localScale = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
            UnityEngine.Vector3 val_12 = this.leftCandle1.transform.localPosition;
            UnityEngine.Vector3 val_14 = this.leftCandle2.transform.localPosition;
            UnityEngine.Vector3 val_16 = this.leftCandle3.transform.localPosition;
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
            this.leftCandle1.transform.localPosition = new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z};
            UnityEngine.Vector3 val_21 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, b:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z});
            this.leftCandle2.transform.localPosition = new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z};
            UnityEngine.Vector3 val_24 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, b:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z});
            this.leftCandle3.transform.localPosition = new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z};
            .xSquash = 1.1f;
            .ySquash = 0.9f;
            UnityEngine.Vector3 val_26 = UnityEngine.Vector3.one;
            DG.Tweening.Sequence val_28 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  0f, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.leftCandleBottom, endValue:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z}, duration:  0.1f));
            DG.Tweening.Sequence val_31 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  0.1f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.leftCandle1, endValue:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, duration:  0.2f, snapping:  false), ease:  2));
            UnityEngine.Vector3 val_32 = UnityEngine.Vector3.one;
            DG.Tweening.Sequence val_36 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  0.1f, t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.leftCandle1, endValue:  new UnityEngine.Vector3() {x = val_32.x, y = val_32.y, z = val_32.z}, duration:  0.2f), action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void Area03FireplaceView.<>c__DisplayClass42_0::<PlayLeftCandles>b__0())));
            DG.Tweening.Sequence val_39 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  0.2f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.leftCandle2, endValue:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, duration:  0.2f, snapping:  false), ease:  2));
            UnityEngine.Vector3 val_40 = UnityEngine.Vector3.one;
            DG.Tweening.Sequence val_44 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  0.2f, t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.leftCandle2, endValue:  new UnityEngine.Vector3() {x = val_40.x, y = val_40.y, z = val_40.z}, duration:  0.2f), action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void Area03FireplaceView.<>c__DisplayClass42_0::<PlayLeftCandles>b__1())));
            DG.Tweening.Sequence val_47 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  0.3f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.leftCandle3, endValue:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, duration:  0.2f, snapping:  false), ease:  2));
            UnityEngine.Vector3 val_48 = UnityEngine.Vector3.one;
            DG.Tweening.Sequence val_52 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  0.3f, t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.leftCandle3, endValue:  new UnityEngine.Vector3() {x = val_48.x, y = val_48.y, z = val_48.z}, duration:  0.2f), action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void Area03FireplaceView.<>c__DisplayClass42_0::<PlayLeftCandles>b__2())));
            return val_2;
        }
        private DG.Tweening.Sequence PlayToy()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            this.horseBottom.transform.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
            this.toyHorse.transform.localScale = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            UnityEngine.Vector3 val_7 = this.toyHorse.transform.localPosition;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            this.toyHorse.transform.localPosition = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.one;
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0f, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.horseBottom, endValue:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, duration:  0.1f));
            DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0.4f, t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.toyHorse, endValue:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, duration:  0.2f, snapping:  false), ease:  2), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area03.Tasks.Fireplace.Area03FireplaceView::<PlayToy>b__43_0())));
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.one;
            DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.toyHorse, endValue:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, duration:  0.1f));
            return val_1;
        }
        private DG.Tweening.Sequence PlayRightCandles()
        {
            Area03FireplaceView.<>c__DisplayClass44_0 val_1 = new Area03FireplaceView.<>c__DisplayClass44_0();
            .<>4__this = this;
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
            this.rightCandleBottom.transform.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
            this.rightCandle1.transform.localScale = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
            this.rightCandle2.transform.localScale = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
            this.rightCandle3.transform.localScale = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
            UnityEngine.Vector3 val_12 = this.rightCandle1.transform.localPosition;
            UnityEngine.Vector3 val_14 = this.rightCandle2.transform.localPosition;
            UnityEngine.Vector3 val_16 = this.rightCandle3.transform.localPosition;
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
            this.rightCandle1.transform.localPosition = new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z};
            UnityEngine.Vector3 val_21 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, b:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z});
            this.rightCandle2.transform.localPosition = new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z};
            UnityEngine.Vector3 val_24 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, b:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z});
            this.rightCandle3.transform.localPosition = new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z};
            .xSquash = 1.1f;
            .ySquash = 0.9f;
            UnityEngine.Vector3 val_26 = UnityEngine.Vector3.one;
            DG.Tweening.Sequence val_28 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  0f, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.rightCandleBottom, endValue:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z}, duration:  0.1f));
            DG.Tweening.Sequence val_31 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  0.1f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.rightCandle3, endValue:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, duration:  0.2f, snapping:  false), ease:  2));
            UnityEngine.Vector3 val_32 = UnityEngine.Vector3.one;
            DG.Tweening.Sequence val_36 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  0.1f, t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.rightCandle3, endValue:  new UnityEngine.Vector3() {x = val_32.x, y = val_32.y, z = val_32.z}, duration:  0.2f), action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void Area03FireplaceView.<>c__DisplayClass44_0::<PlayRightCandles>b__0())));
            DG.Tweening.Sequence val_39 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  0.2f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.rightCandle2, endValue:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, duration:  0.2f, snapping:  false), ease:  2));
            UnityEngine.Vector3 val_40 = UnityEngine.Vector3.one;
            DG.Tweening.Sequence val_44 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  0.2f, t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.rightCandle2, endValue:  new UnityEngine.Vector3() {x = val_40.x, y = val_40.y, z = val_40.z}, duration:  0.2f), action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void Area03FireplaceView.<>c__DisplayClass44_0::<PlayRightCandles>b__1())));
            DG.Tweening.Sequence val_47 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  0.3f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.rightCandle1, endValue:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, duration:  0.2f, snapping:  false), ease:  2));
            UnityEngine.Vector3 val_48 = UnityEngine.Vector3.one;
            DG.Tweening.Sequence val_52 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  0.3f, t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.rightCandle1, endValue:  new UnityEngine.Vector3() {x = val_48.x, y = val_48.y, z = val_48.z}, duration:  0.2f), action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void Area03FireplaceView.<>c__DisplayClass44_0::<PlayRightCandles>b__2())));
            return val_2;
        }
        private DG.Tweening.Sequence PlayVases()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.PlayVase(vase:  this.leftVase, reflection:  this.leftVaseReflection, shadow:  this.leftVaseShadow, left:  true));
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  this.PlayVase(vase:  this.rightVase, reflection:  this.rightVaseReflection, shadow:  0, left:  false));
            return val_1;
        }
        private DG.Tweening.Sequence PlayVase(UnityEngine.Transform vase, UnityEngine.SpriteRenderer reflection, UnityEngine.SpriteRenderer shadow, bool left)
        {
            Area03FireplaceView.<>c__DisplayClass46_0 val_1 = new Area03FireplaceView.<>c__DisplayClass46_0();
            .vase = vase;
            .<>4__this = this;
            vase.gameObject.SetActive(value:  false);
            DG.Tweening.Sequence val_3 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_4 = (Area03FireplaceView.<>c__DisplayClass46_0)[1152921519774981440].vase.localPosition;
            UnityEngine.Vector3 val_5 = (Area03FireplaceView.<>c__DisplayClass46_0)[1152921519774981440].vase.localScale;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            (Area03FireplaceView.<>c__DisplayClass46_0)[1152921519774981440].vase.localPosition = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
            (Area03FireplaceView.<>c__DisplayClass46_0)[1152921519774981440].vase.localScale = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            (Area03FireplaceView.<>c__DisplayClass46_0)[1152921519774981440].vase.gameObject.SetActive(value:  false);
            reflection.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            if(shadow != 0)
            {
                    shadow.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            }
            
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.OnStart<DG.Tweening.Sequence>(t:  val_3, action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void Area03FireplaceView.<>c__DisplayClass46_0::<PlayVase>b__0()));
            DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_3, t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  (Area03FireplaceView.<>c__DisplayClass46_0)[1152921519774981440].vase, endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  0.3f, snapping:  false), ease:  2), action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void Area03FireplaceView.<>c__DisplayClass46_0::<PlayVase>b__1())));
            DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_3, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  (Area03FireplaceView.<>c__DisplayClass46_0)[1152921519774981440].vase, endValue:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, duration:  0.1f), ease:  2));
            DG.Tweening.Sequence val_22 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_3, t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  reflection, endValue:  1f, duration:  0.3f));
            DG.Tweening.Sequence val_28 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_3, t:  DG.Tweening.TweenSettingsExtensions.Join(s:  val_3, t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  shadow, endValue:  1f, duration:  0.3f)).ShakeVase(vase:  (Area03FireplaceView.<>c__DisplayClass46_0)[1152921519774981440].vase, left:  left));
            return val_3;
        }
        private DG.Tweening.Sequence ShakeVase(UnityEngine.Transform vase, bool left)
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            float val_2 = (left != true) ? 1f : -1f;
            float val_3 = val_2 * 5f;
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.ShortcutExtensions.DOLocalRotate(target:  vase, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  0.12f, mode:  0)), ease:  3);
            float val_7 = val_2 * (-4f);
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.ShortcutExtensions.DOLocalRotate(target:  vase, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  0.14f, mode:  0)), ease:  2);
            float val_11 = val_2 * 3f;
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.ShortcutExtensions.DOLocalRotate(target:  vase, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  0.12f, mode:  0)), ease:  3);
            float val_15 = val_2 * (-2f);
            DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.ShortcutExtensions.DOLocalRotate(target:  vase, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  0.14f, mode:  0)), ease:  2);
            DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.ShortcutExtensions.DOLocalRotate(target:  vase, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  0.1f, mode:  0)), ease:  3);
            DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.ShortcutExtensions.DOLocalRotate(target:  vase, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  0.12f, mode:  0)), ease:  2);
            DG.Tweening.Sequence val_27 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.ShortcutExtensions.DOLocalRotate(target:  vase, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  0.05f, mode:  0)), ease:  3);
            return val_1;
        }
        public Area03FireplaceView()
        {
        
        }
        private void <PlayAnimation>b__35_0()
        {
            this.EnableParticles(enable:  true);
        }
        private void <PlayToy>b__43_0()
        {
            this.SquashStretch(trans:  this.toyHorse, xScale:  1.1f, yScale:  0.9f, duration:  0.1f);
        }
    
    }

}
