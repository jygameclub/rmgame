using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area02.Tasks.Tent
{
    public class Area02TentView : AreaTaskView
    {
        // Fields
        public UnityEngine.SpriteRenderer tent;
        public UnityEngine.SpriteRenderer tentCap;
        public UnityEngine.SpriteRenderer tentBack;
        public UnityEngine.SpriteRenderer baseReflection;
        public UnityEngine.Transform basePart;
        public UnityEngine.Transform[] leftPoleParts;
        public UnityEngine.Transform[] rightPoleParts;
        private UnityEngine.Animator tentAnimator;
        public float partPos;
        public float partDelay;
        
        // Methods
        protected override void Awake()
        {
            this.Awake();
            UnityEngine.Animator val_1 = this.GetComponent<UnityEngine.Animator>();
            this.tentAnimator = val_1;
            val_1.enabled = false;
        }
        public override void PrepareAnimation()
        {
            this.PrepareAnimation();
            this.ShowTent(enable:  false);
        }
        public override DG.Tweening.Sequence PlayAnimation()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Scripts.AreaTaskView::PlayDefaultAnimationSound()));
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.AnimateBase());
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.AnimatePole(poleParts:  this.leftPoleParts));
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  this.AnimatePole(poleParts:  this.rightPoleParts));
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area02.Tasks.Tent.Area02TentView::<PlayAnimation>b__12_0()));
            return val_1;
        }
        public override void EndAnimation()
        {
            this.EndAnimation();
            this.tentAnimator.enabled = false;
        }
        private void ShowTent(bool enable)
        {
            bool val_1 = enable;
            this.tent.enabled = val_1;
            this.tentCap.enabled = val_1;
            this.tentBack.enabled = enable;
        }
        private DG.Tweening.Sequence AnimateBase()
        {
            UnityEngine.Vector3 val_2 = this.basePart.transform.localPosition;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            this.basePart.localPosition = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  0.5f);
            this.basePart.transform.localScale = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            this.baseReflection.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            DG.Tweening.Sequence val_8 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.one;
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_8, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.basePart.transform, endValue:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, duration:  0.1f));
            DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_8, t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.baseReflection, endValue:  1f, duration:  0.15f), delay:  0.2f));
            DG.Tweening.Sequence val_16 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_16, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.basePart.transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.15f, snapping:  false), ease:  1));
            DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_16, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.basePart.transform, endValue:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, duration:  0.05f, snapping:  false), ease:  1));
            DG.Tweening.Sequence val_28 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_16, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.basePart.transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.05f, snapping:  false), ease:  1));
            DG.Tweening.Sequence val_29 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_8, atPosition:  0.1f, t:  val_16);
            return val_8;
        }
        private DG.Tweening.Sequence AnimatePole(UnityEngine.Transform[] poleParts)
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            if(poleParts.Length < 1)
            {
                    return val_1;
            }
            
            var val_18 = 0;
            do
            {
                .<>4__this = this;
                .polePart = null;
                UnityEngine.Vector3 val_4 = 1152921508158637376.transform.localPosition;
                UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                (Area02TentView.<>c__DisplayClass16_0)[1152921519787544960].polePart.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
                UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
                (Area02TentView.<>c__DisplayClass16_0)[1152921519787544960].polePart.localScale = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
                float val_17 = 0f;
                val_17 = this.partDelay * val_17;
                DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  val_17, t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  (Area02TentView.<>c__DisplayClass16_0)[1152921519787544960].polePart.transform, endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  0.15f, snapping:  false), ease:  2), action:  new DG.Tweening.TweenCallback(object:  new Area02TentView.<>c__DisplayClass16_0(), method:  System.Void Area02TentView.<>c__DisplayClass16_0::<AnimatePole>b__0())));
                UnityEngine.Vector3 val_14 = UnityEngine.Vector3.one;
                DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  (Area02TentView.<>c__DisplayClass16_0)[1152921519787544960].polePart.transform, endValue:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, duration:  0.03f));
                val_18 = val_18 + 1;
            }
            while(val_18 < poleParts.Length);
            
            return val_1;
        }
        private void SquashStretch(UnityEngine.Transform trans, float xScale = 1.05, float yScale = 0.95)
        {
            UnityEngine.Vector3 val_1 = trans.localScale;
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  trans, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  0.1f));
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  trans, endValue:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, duration:  0.1f));
        }
        public Area02TentView()
        {
            this.partPos = 0.3f;
            this.partDelay = 0.07f;
        }
        private void <PlayAnimation>b__12_0()
        {
            this.ShowTent(enable:  true);
            this.tentAnimator.enabled = true;
            this.tentAnimator.Play(stateName:  "Area02TentAppear", layer:  0, normalizedTime:  0f);
        }
    
    }

}
