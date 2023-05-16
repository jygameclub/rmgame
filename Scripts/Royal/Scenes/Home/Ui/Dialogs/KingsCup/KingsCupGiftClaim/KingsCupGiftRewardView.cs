using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim
{
    public class KingsCupGiftRewardView : MonoBehaviour
    {
        // Fields
        protected UnityEngine.SpriteRenderer gift;
        protected UnityEngine.SpriteRenderer giftShadow;
        protected UnityEngine.Transform levelButtonFrame;
        protected UnityEngine.Vector3 targetPosition;
        protected UnityEngine.Vector3 targetScale;
        protected DG.Tweening.Sequence showSequence;
        protected DG.Tweening.Sequence hoverSequence;
        protected DG.Tweening.Tween hoverTween;
        protected Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        protected bool sendToTarget;
        
        // Methods
        protected virtual void Awake()
        {
            var val_17;
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
            val_17 = null;
            val_17 = null;
            this.levelButtonFrame = Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_this_arg + 136.transform.parent;
            UnityEngine.Vector3 val_5 = this.transform.localPosition;
            this.targetPosition = val_5;
            mem[1152921519477930036] = val_5.y;
            mem[1152921519477930040] = val_5.z;
            UnityEngine.Vector3 val_7 = this.transform.localScale;
            this.targetScale = val_7;
            mem[1152921519477930048] = val_7.y;
            mem[1152921519477930052] = val_7.z;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
            this.transform.localPosition = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.zero;
            this.transform.localScale = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
            UnityEngine.SpriteRenderer val_12 = this.GetComponent<UnityEngine.SpriteRenderer>();
            this.gift = val_12;
            UnityEngine.Transform val_14 = val_12.transform.Find(n:  "Shadow");
            if(val_14 != 0)
            {
                    UnityEngine.SpriteRenderer val_16 = val_14.GetComponent<UnityEngine.SpriteRenderer>();
                this.giftShadow = val_16;
                val_16.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            }
            
            this.gift.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        }
        public void SetAmount(int amount)
        {
            string val_6;
            UnityEngine.Transform val_2 = this.gift.transform.Find(n:  "Text");
            if(val_2 == 0)
            {
                    return;
            }
            
            TMPro.TextMeshPro val_4 = val_2.GetComponent<TMPro.TextMeshPro>();
            if(amount >= 2)
            {
                goto label_7;
            }
            
            val_6 = "";
            if(val_4 != null)
            {
                goto label_8;
            }
            
            label_7:
            val_6 = "x" + amount;
            label_8:
            val_4.text = val_6;
        }
        public DG.Tweening.Sequence SendGiftToButton(float duration)
        {
            this.sendToTarget = true;
            if(this.showSequence != null)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  this.showSequence, complete:  true);
                this.showSequence = 0;
            }
            
            if(this.hoverSequence != null)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  this.hoverSequence, complete:  false);
                this.hoverSequence = 0;
            }
            
            if(this.hoverTween != null)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  this.hoverTween, complete:  false);
                this.hoverTween = 0;
            }
            
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_4 = this.levelButtonFrame.transform.position;
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOMove(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  duration, snapping:  false), ease:  26));
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_1, action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftRewardView::<SendGiftToButton>b__12_0()));
            return val_1;
        }
        public virtual void Show(float delay, float hoverDelay, UnityEngine.Vector3 middlePoint, float middleDuration = 0)
        {
            DG.Tweening.Tween val_29;
            DG.Tweening.Sequence val_30;
            .<>4__this = this;
            .hoverDelay = hoverDelay;
            this.showSequence = DG.Tweening.DOTween.Sequence();
            UnityEngine.Transform val_4 = this.transform;
            if((Royal.Infrastructure.Utils.Math.NumberExtensions.Approximately(v1:  new UnityEngine.Vector3() {x = middlePoint.x, y = middlePoint.y, z = middlePoint.z}, v2:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f})) != false)
            {
                    val_29 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  val_4, endValue:  new UnityEngine.Vector3() {x = this.targetPosition, y = middlePoint.y, z = middlePoint.z}, duration:  0.4f, snapping:  false), ease:  27);
                val_30 = this.showSequence;
            }
            else
            {
                    DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Insert(s:  this.showSequence, atPosition:  delay, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  val_4, endValue:  new UnityEngine.Vector3() {x = middlePoint.x, y = middlePoint.y, z = middlePoint.z}, duration:  middleDuration, snapping:  false), ease:  1));
                float val_28 = 0.4f;
                val_28 = val_28 - middleDuration;
                val_29 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = this.targetPosition, y = middlePoint.y, z = middlePoint.z}, duration:  val_28, snapping:  false), ease:  27);
                val_30 = this.showSequence;
            }
            
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_30, atPosition:  delay + middleDuration, t:  val_29);
            DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.Insert(s:  this.showSequence, atPosition:  delay, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = this.targetScale, y = middlePoint.y, z = middlePoint.z}, duration:  0.1f), ease:  3));
            DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.Insert(s:  this.showSequence, atPosition:  delay, t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.gift, endValue:  1f, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  2f)));
            if(this.giftShadow != 0)
            {
                    DG.Tweening.Sequence val_25 = DG.Tweening.TweenSettingsExtensions.Insert(s:  this.showSequence, atPosition:  delay, t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.giftShadow, endValue:  0.3921569f, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  2f)));
            }
            
            DG.Tweening.Sequence val_27 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  this.showSequence, action:  new DG.Tweening.TweenCallback(object:  new KingsCupGiftRewardView.<>c__DisplayClass13_0(), method:  System.Void KingsCupGiftRewardView.<>c__DisplayClass13_0::<Show>b__0()));
        }
        public void Hover(float delay)
        {
            .<>4__this = this;
            UnityEngine.Vector3 val_3 = this.transform.localPosition;
            float val_10 = 0.1f;
            val_10 = val_3.y + val_10;
            val_3.y = val_3.y + (-0.1f);
            mem[1152921519478896416] = val_3.z;
            .firstPos = val_3;
            mem[1152921519478896424] = val_10;
            mem[1152921519478896428] = val_3.z;
            .secondPos = val_3;
            mem[1152921519478896412] = val_3.y;
            float val_11 = 4f;
            val_11 = delay * val_11;
            this.hoverTween = DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = (KingsCupGiftRewardView.<>c__DisplayClass14_0)[1152921519478896384].firstPos, y = val_3.y, z = val_3.z}, duration:  1f, snapping:  false), action:  new DG.Tweening.TweenCallback(object:  new KingsCupGiftRewardView.<>c__DisplayClass14_0(), method:  System.Void KingsCupGiftRewardView.<>c__DisplayClass14_0::<Hover>b__0())), ease:  4), delay:  val_11);
        }
        private void PlayButtonHitAnimation()
        {
            var val_37;
            KingsCupGiftRewardView.<>c__DisplayClass15_0 val_1 = new KingsCupGiftRewardView.<>c__DisplayClass15_0();
            .<>4__this = this;
            val_37 = null;
            val_37 = null;
            this.levelButtonFrame = Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_this_arg + 136.transform.parent;
            UnityEngine.GameObject val_5 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "EpisodeRewardHitParticles"));
            .hitParticles = val_5;
            UnityEngine.Vector3 val_8 = this.levelButtonFrame.transform.position;
            val_5.transform.position = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            if(val_9.Length >= 1)
            {
                    var val_38 = 0;
                do
            {
                (KingsCupGiftRewardView.<>c__DisplayClass15_0)[1152921519479190656].hitParticles.GetComponentsInChildren<UnityEngine.ParticleSystem>()[val_38].Play();
                val_38 = val_38 + 1;
            }
            while(val_38 < val_9.Length);
            
            }
            
            DG.Tweening.Sequence val_10 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.one;
            UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            UnityEngine.Vector2 val_13 = new UnityEngine.Vector2(x:  1.04f, y:  0.97f);
            UnityEngine.Vector2 val_14 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y}, b:  new UnityEngine.Vector2() {x = val_13.x, y = val_13.y});
            UnityEngine.Vector3 val_15 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_14.x, y = val_14.y});
            DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_10, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.levelButtonFrame, endValue:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, duration:  0.05f));
            DG.Tweening.Sequence val_19 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_10, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void KingsCupGiftRewardView.<>c__DisplayClass15_0::<PlayButtonHitAnimation>b__0()));
            UnityEngine.Vector2 val_20 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            UnityEngine.Vector2 val_21 = new UnityEngine.Vector2(x:  0.98f, y:  1.02f);
            UnityEngine.Vector2 val_22 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_20.x, y = val_20.y}, b:  new UnityEngine.Vector2() {x = val_21.x, y = val_21.y});
            UnityEngine.Vector3 val_23 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_22.x, y = val_22.y});
            DG.Tweening.Sequence val_25 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_10, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.levelButtonFrame, endValue:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, duration:  0.075f));
            UnityEngine.Vector2 val_26 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            UnityEngine.Vector2 val_27 = new UnityEngine.Vector2(x:  1.01f, y:  0.99f);
            UnityEngine.Vector2 val_28 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_26.x, y = val_26.y}, b:  new UnityEngine.Vector2() {x = val_27.x, y = val_27.y});
            UnityEngine.Vector3 val_29 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_28.x, y = val_28.y});
            DG.Tweening.Sequence val_31 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_10, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.levelButtonFrame, endValue:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z}, duration:  0.06f));
            DG.Tweening.Sequence val_33 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_10, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.levelButtonFrame, endValue:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, duration:  0.05f));
            DG.Tweening.Sequence val_34 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_10, interval:  2f);
            DG.Tweening.Sequence val_36 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_10, action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void KingsCupGiftRewardView.<>c__DisplayClass15_0::<PlayButtonHitAnimation>b__1()));
        }
        public KingsCupGiftRewardView()
        {
        
        }
        private void <SendGiftToButton>b__12_0()
        {
            this.PlayButtonHitAnimation();
            UnityEngine.Object.Destroy(obj:  this.gameObject);
        }
    
    }

}
