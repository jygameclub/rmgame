using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area04.Tasks.DogHouse
{
    public class Area04DogHouseView : AreaTaskView
    {
        // Fields
        public UnityEngine.Animator dogHouseAnimator;
        public UnityEngine.Animator ballAnimator;
        public UnityEngine.Transform pot1;
        public UnityEngine.Transform pot2;
        public UnityEngine.Transform potBase;
        public UnityEngine.Transform mop;
        public UnityEngine.Transform bone;
        public UnityEngine.Transform sand;
        public Royal.Scenes.Home.Areas.Area04.Tasks.DogHouse.Area04SandboxView sandbox;
        
        // Methods
        protected override void Awake()
        {
            this.Awake();
            this.dogHouseAnimator.enabled = false;
            this.ballAnimator.enabled = false;
        }
        public override void PrepareAnimation()
        {
            this.PrepareAnimation();
            this.DisableObjects();
            Royal.Scenes.Home.Areas.Scripts.AreaTaskAssets val_1 = this.AreaTaskAssets;
            this.sandbox.PrepareAnimation(prefab:  val_1.particles[0]);
        }
        public override DG.Tweening.Sequence PlayAnimation()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            this.sand.gameObject.SetActive(value:  true);
            this.sandbox.PlayAnimation();
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area04.Tasks.DogHouse.Area04DogHouseView::<PlayAnimation>b__11_0()));
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0.1f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Scripts.AreaTaskView::PlayDefaultAnimationSound()));
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0.3f, t:  this.AnimatePots());
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0.5f, t:  this.AnimateMop());
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0.6f, t:  this.AnimateBone());
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0.6f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area04.Tasks.DogHouse.Area04DogHouseView::<PlayAnimation>b__11_1()));
            return val_1;
        }
        public override void EndAnimation()
        {
            this.EndAnimation();
            this.ballAnimator.enabled = false;
            this.dogHouseAnimator.enabled = false;
            this.sandbox.EndAnimation();
        }
        private DG.Tweening.Sequence AnimateBone()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_2 = this.bone.localPosition;
            UnityEngine.Vector3 val_3 = this.bone.localScale;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
            this.bone.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            UnityEngine.Vector3 val_5 = this.bone.localPosition;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  0.6f);
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            this.bone.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area04.Tasks.DogHouse.Area04DogHouseView::<AnimateBone>b__13_0()));
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.bone, endValue:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, duration:  0.15f), ease:  27, overshoot:  3f));
            DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0.12f, t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.bone, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.1f, snapping:  false), ease:  1), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area04.Tasks.DogHouse.Area04DogHouseView::<AnimateBone>b__13_1())));
            return val_1;
        }
        private DG.Tweening.Sequence AnimateMop()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            this.mop.localScale = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area04.Tasks.DogHouse.Area04DogHouseView::<AnimateMop>b__14_0()));
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.mop, endValue:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, duration:  0.2f), ease:  27));
            return val_2;
        }
        private DG.Tweening.Sequence AnimatePots()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_2 = this.potBase.localScale;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            this.potBase.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            UnityEngine.Vector3 val_4 = this.pot1.localPosition;
            UnityEngine.Vector3 val_5 = this.pot1.localPosition;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  0.4f);
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            this.pot1.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
            this.pot1.localScale = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
            UnityEngine.Vector3 val_10 = this.pot2.localPosition;
            UnityEngine.Vector3 val_11 = this.pot2.localPosition;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, d:  0.4f);
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, b:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
            this.pot2.localPosition = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.zero;
            this.pot2.localScale = new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z};
            DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area04.Tasks.DogHouse.Area04DogHouseView::<AnimatePots>b__15_0()));
            DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.potBase.transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.2f), ease:  27));
            UnityEngine.Vector3 val_22 = UnityEngine.Vector3.one;
            DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0.17f, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.pot1, endValue:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, duration:  0.1f));
            DG.Tweening.Sequence val_29 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0.24f, t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.pot1, endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  0.1f, snapping:  false), ease:  2), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area04.Tasks.DogHouse.Area04DogHouseView::<AnimatePots>b__15_1())));
            UnityEngine.Vector3 val_30 = UnityEngine.Vector3.one;
            DG.Tweening.Sequence val_32 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0.22f, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.pot2, endValue:  new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z}, duration:  0.1f));
            DG.Tweening.Sequence val_37 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0.29f, t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.pot2, endValue:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, duration:  0.1f, snapping:  false), ease:  2), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area04.Tasks.DogHouse.Area04DogHouseView::<AnimatePots>b__15_2())));
            return val_1;
        }
        private void SquashStretch(UnityEngine.Transform trans, float xScale = 1.05, float yScale = 0.95)
        {
            UnityEngine.Vector3 val_1 = trans.localScale;
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  trans, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  0.1f));
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  trans, endValue:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, duration:  0.1f));
        }
        private void DisableObjects()
        {
            this.pot1.gameObject.SetActive(value:  false);
            this.pot2.gameObject.SetActive(value:  false);
            this.potBase.gameObject.SetActive(value:  false);
            this.mop.gameObject.SetActive(value:  false);
            this.bone.gameObject.SetActive(value:  false);
            this.sand.gameObject.SetActive(value:  false);
            this.dogHouseAnimator.gameObject.SetActive(value:  false);
            this.ballAnimator.gameObject.SetActive(value:  false);
        }
        public Area04DogHouseView()
        {
        
        }
        private void <PlayAnimation>b__11_0()
        {
            this.dogHouseAnimator.gameObject.SetActive(value:  true);
            this.dogHouseAnimator.enabled = true;
            this.dogHouseAnimator.Play(stateNameHash:  0, layer:  0, normalizedTime:  0f);
        }
        private void <PlayAnimation>b__11_1()
        {
            this.ballAnimator.gameObject.SetActive(value:  true);
            this.ballAnimator.enabled = true;
            this.ballAnimator.Play(stateNameHash:  0, layer:  0, normalizedTime:  0f);
        }
        private void <AnimateBone>b__13_0()
        {
            this.bone.gameObject.SetActive(value:  true);
        }
        private void <AnimateBone>b__13_1()
        {
            this.SquashStretch(trans:  this.bone, xScale:  0.95f, yScale:  0.95f);
        }
        private void <AnimateMop>b__14_0()
        {
            this.mop.gameObject.SetActive(value:  true);
        }
        private void <AnimatePots>b__15_0()
        {
            this.potBase.gameObject.SetActive(value:  true);
            this.pot1.gameObject.SetActive(value:  true);
            this.pot2.gameObject.SetActive(value:  true);
        }
        private void <AnimatePots>b__15_1()
        {
            this.SquashStretch(trans:  this.pot1, xScale:  1.05f, yScale:  0.95f);
        }
        private void <AnimatePots>b__15_2()
        {
            this.SquashStretch(trans:  this.pot2, xScale:  1.05f, yScale:  0.95f);
        }
    
    }

}
