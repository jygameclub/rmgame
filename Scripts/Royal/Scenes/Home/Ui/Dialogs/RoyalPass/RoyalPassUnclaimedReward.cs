using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass
{
    public class RoyalPassUnclaimedReward : MonoBehaviour
    {
        // Fields
        public Royal.Player.Context.Units.RewardType rewardType;
        public TMPro.TextMeshPro text;
        public UnityEngine.SpriteRenderer reward;
        protected UnityEngine.SpriteRenderer giftShadow;
        protected UnityEngine.Transform levelButtonFrame;
        protected UnityEngine.Vector3 targetPosition;
        protected UnityEngine.Vector3 targetScale;
        protected DG.Tweening.Sequence showSequence;
        protected DG.Tweening.Sequence hoverSequence;
        protected DG.Tweening.Tween hoverTween;
        protected Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        protected bool sendToTarget;
        private Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassUnclaimedReward.CollectStrategy collectStrategy;
        
        // Methods
        public virtual void Init(Royal.Player.Context.Units.RewardType rewardType, Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassUnclaimedReward.CollectStrategy collectStrategy)
        {
            var val_12;
            this.rewardType = rewardType;
            this.collectStrategy = collectStrategy;
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
            val_12 = null;
            val_12 = null;
            this.levelButtonFrame = Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_this_arg + 136.transform.parent;
            UnityEngine.Vector3 val_5 = this.transform.localPosition;
            this.targetPosition = val_5;
            mem[1152921519279609396] = val_5.y;
            mem[1152921519279609400] = val_5.z;
            UnityEngine.Vector3 val_7 = this.transform.localScale;
            this.targetScale = val_7;
            mem[1152921519279609408] = val_7.y;
            mem[1152921519279609412] = val_7.z;
            UnityEngine.Transform val_9 = this.transform.Find(n:  "Shadow");
            if(val_9 == 0)
            {
                    return;
            }
            
            this.giftShadow = val_9.GetComponent<UnityEngine.SpriteRenderer>();
        }
        public void Init(Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassUnclaimedReward.CollectStrategy collectStrategy)
        {
            goto typeof(Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassUnclaimedReward).__il2cppRuntimeField_170;
        }
        public void InitForExtraWarn(Royal.Player.Context.Units.RewardType rewardType)
        {
            this.rewardType = rewardType;
            UnityEngine.Vector3 val_2 = this.transform.localPosition;
            this.targetPosition = val_2;
            mem[1152921519279903028] = val_2.y;
            mem[1152921519279903032] = val_2.z;
            UnityEngine.Vector3 val_4 = this.transform.localScale;
            this.targetScale = val_4;
            mem[1152921519279903040] = val_4.y;
            mem[1152921519279903044] = val_4.z;
        }
        public void IncreaseSorting(int multiplier)
        {
            if(val_1.Length >= 1)
            {
                    var val_8 = 0;
                do
            {
                T val_7 = this.GetComponentsInChildren<UnityEngine.SpriteRenderer>()[val_8];
                val_7.sortingOrder = val_7.sortingOrder * multiplier;
                val_8 = val_8 + 1;
            }
            while(val_8 < val_1.Length);
            
            }
            
            if(this.text == 0)
            {
                    return;
            }
            
            this.text.sortingOrder = this.text.sortingOrder * multiplier;
        }
        public void SetAmount(int amount)
        {
            var val_8;
            TMPro.TextMeshPro val_10;
            val_8 = this;
            Royal.Player.Context.Units.RewardType val_8 = this.rewardType;
            val_8 = val_8 - 2;
            if(val_8 <= 3)
            {
                    string val_1 = Royal.Infrastructure.Utils.Time.TimeUtil.GetDurationInMinutesOrHours(totalMinutes:  (long)amount);
            }
            
            val_10 = this.text;
            if(val_10 != 0)
            {
                    this.text.GetComponent<TMPro.TextMeshPro>().text = +amount;
            }
            
            T[] val_5 = this.GetComponentsInChildren<Royal.Infrastructure.Utils.Text.TextPositioner>();
            if(val_5 == null)
            {
                    return;
            }
            
            string val_6 = this.text.text;
            if(val_5.Length < 1)
            {
                    return;
            }
            
            do
            {
                1152921506482711552.ArrangeTransformByCharCount(charCount:  (Royal.Infrastructure.Services.Localization.LocalizationHelper.isArabic == false) ? 2 : val_6.m_stringLength);
                val_10 = 0 + 1;
            }
            while(val_10 < val_5.Length);
        
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
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_1, action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassUnclaimedReward::<SendGiftToButton>b__18_0()));
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
            DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.Insert(s:  this.showSequence, atPosition:  delay, t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.reward, endValue:  1f, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  2f)));
            if(this.giftShadow != 0)
            {
                    DG.Tweening.Sequence val_25 = DG.Tweening.TweenSettingsExtensions.Insert(s:  this.showSequence, atPosition:  delay, t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.giftShadow, endValue:  0.3921569f, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  2f)));
            }
            
            DG.Tweening.Sequence val_27 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  this.showSequence, action:  new DG.Tweening.TweenCallback(object:  new RoyalPassUnclaimedReward.<>c__DisplayClass19_0(), method:  System.Void RoyalPassUnclaimedReward.<>c__DisplayClass19_0::<Show>b__0()));
        }
        public virtual void Appear(float delay, float hoverDelay)
        {
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            this.transform.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            this.showSequence = DG.Tweening.DOTween.Sequence();
            UnityEngine.Color val_4 = this.reward.color;
            this.reward.color = new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = 0f};
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Insert(s:  this.showSequence, atPosition:  delay, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.reward.transform, endValue:  new UnityEngine.Vector3() {x = this.targetScale, y = val_4.g, z = val_4.b}, duration:  0.2f), ease:  27));
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Insert(s:  this.showSequence, atPosition:  delay, t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.reward, endValue:  1f, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  3f)));
            if(this.giftShadow != 0)
            {
                    DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.Insert(s:  this.showSequence, atPosition:  delay, t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.giftShadow, endValue:  0.3921569f, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  2f)));
            }
            
            DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  this.showSequence, action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassUnclaimedReward::<Appear>b__20_0()));
        }
        public void Hover(float delay)
        {
            .<>4__this = this;
            UnityEngine.Vector3 val_3 = this.transform.localPosition;
            float val_10 = 0.1f;
            val_10 = val_3.y + val_10;
            val_3.y = val_3.y + (-0.1f);
            mem[1152921519281418000] = val_3.z;
            .firstPos = val_3;
            mem[1152921519281418008] = val_10;
            mem[1152921519281418012] = val_3.z;
            .secondPos = val_3;
            mem[1152921519281417996] = val_3.y;
            float val_11 = 4f;
            val_11 = delay * val_11;
            this.hoverTween = DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = (RoyalPassUnclaimedReward.<>c__DisplayClass21_0)[1152921519281417968].firstPos, y = val_3.y, z = val_3.z}, duration:  1f, snapping:  false), action:  new DG.Tweening.TweenCallback(object:  new RoyalPassUnclaimedReward.<>c__DisplayClass21_0(), method:  System.Void RoyalPassUnclaimedReward.<>c__DisplayClass21_0::<Hover>b__0())), ease:  4), delay:  val_11);
        }
        private void PlayButtonHitAnimation()
        {
            var val_37;
            RoyalPassUnclaimedReward.<>c__DisplayClass22_0 val_1 = new RoyalPassUnclaimedReward.<>c__DisplayClass22_0();
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
                (RoyalPassUnclaimedReward.<>c__DisplayClass22_0)[1152921519281712240].hitParticles.GetComponentsInChildren<UnityEngine.ParticleSystem>()[val_38].Play();
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
            DG.Tweening.Sequence val_19 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_10, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void RoyalPassUnclaimedReward.<>c__DisplayClass22_0::<PlayButtonHitAnimation>b__0()));
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
            DG.Tweening.Sequence val_36 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_10, action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void RoyalPassUnclaimedReward.<>c__DisplayClass22_0::<PlayButtonHitAnimation>b__1()));
        }
        public virtual DG.Tweening.Sequence Collect(float duration)
        {
            if(this.rewardType != 1)
            {
                    return this.SendGiftToButton(duration:  duration);
            }
            
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  0f, duration:  0.2f), ease:  27));
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0.1f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassUnclaimedReward::<Collect>b__23_0()));
            return val_1;
        }
        public RoyalPassUnclaimedReward()
        {
        
        }
        private void <SendGiftToButton>b__18_0()
        {
            this.PlayButtonHitAnimation();
            UnityEngine.Object.Destroy(obj:  this.gameObject);
        }
        private void <Appear>b__20_0()
        {
            this.showSequence = 0;
        }
        private void <Collect>b__23_0()
        {
            Royal.Player.Context.Data.Session.BeforeAfterData val_5;
            if(this.collectStrategy == 1)
            {
                    val_5 = mem[Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg + 48];
                val_5 = Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg + 48;
            }
            else
            {
                    val_5 = mem[Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg + 40];
                val_5 = Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg + 40;
            }
            
            UnityEngine.Vector3 val_4 = this.transform.position;
            UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.CoinCollect.CoinCollectAnimation>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.CoinCollect.CoinCollectAnimation>(path:  "CoinCollectAnimation")).Play(data:  val_5, startPosition:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        }
    
    }

}
