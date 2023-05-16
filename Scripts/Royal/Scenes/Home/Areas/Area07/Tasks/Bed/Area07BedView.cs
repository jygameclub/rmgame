using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area07.Tasks.Bed
{
    public class Area07BedView : AreaTaskView
    {
        // Fields
        private UnityEngine.Animator bedAnimator;
        public UnityEngine.SpriteRenderer bedShadow;
        public UnityEngine.SpriteRenderer pillowShadow;
        public UnityEngine.SpriteRenderer blanket;
        public UnityEngine.Transform headboard;
        public UnityEngine.Transform footboard;
        public UnityEngine.Transform mattress;
        public UnityEngine.Transform pillowLeft;
        public UnityEngine.Transform pillowRight;
        public UnityEngine.Transform drawerLeft;
        public UnityEngine.Transform drawerRight;
        public UnityEngine.Transform drawerLeftOrigin;
        public UnityEngine.Transform drawerRightOrigin;
        public UnityEngine.Transform lampLeft;
        public UnityEngine.Transform lampRight;
        public UnityEngine.GameObject[] blanketMasks;
        
        // Methods
        protected override void Awake()
        {
            UnityEngine.Animator val_1 = this.GetComponent<UnityEngine.Animator>();
            this.bedAnimator = val_1;
            val_1.enabled = false;
            var val_3 = 0;
            label_6:
            if(val_3 >= this.blanketMasks.Length)
            {
                goto label_3;
            }
            
            this.blanketMasks[val_3].SetActive(value:  false);
            val_3 = val_3 + 1;
            if(this.blanketMasks != null)
            {
                goto label_6;
            }
            
            throw new NullReferenceException();
            label_3:
            this.blanket.maskInteraction = 0;
        }
        public override void PrepareAnimation()
        {
            this.PlayFinalParticles();
            this.DisableAllObjects();
            this.bedShadow.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            this.pillowShadow.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            this.pillowShadow.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            var val_3 = 0;
            label_8:
            if(val_3 >= this.blanketMasks.Length)
            {
                goto label_5;
            }
            
            this.blanketMasks[val_3].SetActive(value:  true);
            val_3 = val_3 + 1;
            if(this.blanketMasks != null)
            {
                goto label_8;
            }
            
            throw new NullReferenceException();
            label_5:
            this.blanket.maskInteraction = 1;
        }
        public override DG.Tweening.Sequence PlayAnimation()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0f, t:  this.AnimatePart(part:  this.headboard, jumpMultiplier:  1.2f));
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Scripts.AreaTaskView::PlayDefaultAnimationSound()));
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0.1f, t:  this.AnimatePart(part:  this.footboard, jumpMultiplier:  1.2f));
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0.1f, t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.bedShadow, endValue:  1f, duration:  1f));
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0.2f, t:  this.AnimatePart(part:  this.mattress, jumpMultiplier:  1f));
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0.6f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area07.Tasks.Bed.Area07BedView::<PlayAnimation>b__18_0()));
            DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0.6f, t:  this.AnimatePart(part:  this.pillowLeft, jumpMultiplier:  0.6f));
            DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0.65f, t:  this.AnimatePart(part:  this.pillowRight, jumpMultiplier:  0.6f));
            DG.Tweening.Sequence val_19 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0.75f, t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.pillowShadow, endValue:  1f, duration:  0.3f));
            DG.Tweening.Sequence val_22 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0.75f, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.pillowShadow.transform, endValue:  1f, duration:  0.3f));
            DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  1f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area07.Tasks.Bed.Area07BedView::AnimateDrawers()));
            return val_1;
        }
        public override void EndAnimation()
        {
            this.bedAnimator.enabled = false;
            var val_2 = 0;
            label_5:
            if(val_2 >= this.blanketMasks.Length)
            {
                goto label_2;
            }
            
            this.blanketMasks[val_2].SetActive(value:  false);
            val_2 = val_2 + 1;
            if(this.blanketMasks != null)
            {
                goto label_5;
            }
            
            throw new NullReferenceException();
            label_2:
            this.blanket.maskInteraction = 0;
        }
        private void DisableAllObjects()
        {
            this.headboard.gameObject.SetActive(value:  false);
            this.footboard.gameObject.SetActive(value:  false);
            this.mattress.gameObject.SetActive(value:  false);
            this.pillowRight.gameObject.SetActive(value:  false);
            this.pillowLeft.gameObject.SetActive(value:  false);
            this.blanket.gameObject.SetActive(value:  false);
            this.drawerLeft.gameObject.SetActive(value:  false);
            this.drawerRight.gameObject.SetActive(value:  false);
        }
        private DG.Tweening.Sequence AnimatePart(UnityEngine.Transform part, float jumpMultiplier = 1.2)
        {
            Area07BedView.<>c__DisplayClass21_0 val_1 = new Area07BedView.<>c__DisplayClass21_0();
            .part = part;
            .jumpMultiplier = jumpMultiplier;
            .<>4__this = this;
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_4 = (Area07BedView.<>c__DisplayClass21_0)[1152921519697150944].part.transform.localPosition;
            .originalPos = val_4;
            mem[1152921519697150972] = val_4.y;
            mem[1152921519697150976] = val_4.z;
            (Area07BedView.<>c__DisplayClass21_0)[1152921519697150944].part.gameObject.SetActive(value:  false);
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.OnStart<DG.Tweening.Sequence>(t:  val_2, action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void Area07BedView.<>c__DisplayClass21_0::<AnimatePart>b__0()));
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.one;
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  (Area07BedView.<>c__DisplayClass21_0)[1152921519697150944].part.transform, endValue:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, duration:  0.1f));
            DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  0.1f, t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  (Area07BedView.<>c__DisplayClass21_0)[1152921519697150944].part.transform, endValue:  new UnityEngine.Vector3() {x = (Area07BedView.<>c__DisplayClass21_0)[1152921519697150944].originalPos, y = val_9.y, z = val_9.z}, duration:  0.15f, snapping:  false), ease:  2), action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void Area07BedView.<>c__DisplayClass21_0::<AnimatePart>b__1())));
            return val_2;
        }
        private void AnimateDrawers()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_2 = this.drawerLeft.localPosition;
            UnityEngine.Vector3 val_3 = this.drawerRight.localPosition;
            UnityEngine.Vector3 val_4 = this.drawerLeftOrigin.localPosition;
            this.drawerLeft.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            UnityEngine.Vector3 val_5 = this.drawerRightOrigin.localPosition;
            this.drawerRight.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
            this.drawerLeft.localScale = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
            this.drawerRight.localScale = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area07.Tasks.Bed.Area07BedView::<AnimateDrawers>b__22_0()));
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.one;
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.drawerLeft, endValue:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, duration:  0.25f), ease:  27, overshoot:  1.3f));
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.one;
            DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.drawerRight, endValue:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, duration:  0.25f), ease:  27, overshoot:  1.3f));
            DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.1f);
            DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.drawerLeft, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.25f, snapping:  false), ease:  4));
            DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.drawerRight, endValue:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, duration:  0.25f, snapping:  false), ease:  4));
            DG.Tweening.Sequence val_27 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalRotate(target:  this.lampLeft, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  0.05f, mode:  0), ease:  2));
            DG.Tweening.Sequence val_30 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalRotate(target:  this.lampRight, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  0.05f, mode:  0), ease:  2));
            DG.Tweening.Sequence val_32 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area07.Tasks.Bed.Area07BedView::<AnimateDrawers>b__22_1()));
        }
        private void ShakeLamp(UnityEngine.Transform vase, bool right)
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            float val_2 = (right != true) ? 1f : -1f;
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Sequence>(t:  val_1, delay:  0.05f);
            float val_4 = val_2 * 3f;
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.ShortcutExtensions.DOLocalRotate(target:  vase, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  0.18f, mode:  0)), ease:  3);
            float val_8 = val_2 * (-2f);
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.ShortcutExtensions.DOLocalRotate(target:  vase, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  0.21f, mode:  0)), ease:  2);
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.ShortcutExtensions.DOLocalRotate(target:  vase, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  0.15f, mode:  0)), ease:  3);
            DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.ShortcutExtensions.DOLocalRotate(target:  vase, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  0.18f, mode:  0)), ease:  2);
            DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.ShortcutExtensions.DOLocalRotate(target:  vase, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  0.075f, mode:  0)), ease:  3);
        }
        private void SquashStretch(UnityEngine.Transform trans, float xScale = 1.1, float yScale = 0.9, float duration = 0.1)
        {
            UnityEngine.Vector3 val_1 = trans.localScale;
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  trans, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  duration));
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  trans, endValue:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, duration:  duration));
        }
        public Area07BedView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
        private void <PlayAnimation>b__18_0()
        {
            this.blanket.gameObject.SetActive(value:  true);
            this.bedAnimator.enabled = true;
            this.bedAnimator.Play(stateNameHash:  0, layer:  0, normalizedTime:  0f);
        }
        private void <AnimateDrawers>b__22_0()
        {
            this.drawerLeft.gameObject.SetActive(value:  true);
            this.drawerRight.gameObject.SetActive(value:  true);
        }
        private void <AnimateDrawers>b__22_1()
        {
            this.ShakeLamp(vase:  this.lampLeft, right:  false);
            this.ShakeLamp(vase:  this.lampRight, right:  true);
        }
    
    }

}
