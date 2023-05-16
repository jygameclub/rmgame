using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass
{
    public class RoyalPassRewardRevealDialog : UiDialog
    {
        // Fields
        private const int TapSkip = 0;
        private const int TapClaim = 1;
        private const int TapDisabled = 2;
        public UnityEngine.GameObject root;
        public UnityEngine.SpriteRenderer transitionBackground;
        public Royal.Infrastructure.Utils.Text.CurvedTextAnimator curvedTitle;
        public UnityEngine.Transform ticket;
        public TMPro.TextMeshPro description;
        public Royal.Scenes.Home.Ui.Dialogs.RoyalPass.GoldNickName nickName;
        public TMPro.TextMeshPro nickNameShadow;
        public UnityEngine.SpriteRenderer picture;
        public UnityEngine.SpriteRenderer kingPicture;
        public UnityEngine.GameObject personalAvatar;
        public UnityEngine.Transform robertFrame;
        public UnityEngine.Transform frameShadow;
        public UnityEngine.Transform frameParticle;
        public UnityEngine.Transform life;
        public UnityEngine.Transform lifeShadow;
        public UnityEngine.Transform lifeParticle;
        public UnityEngine.Transform giftBox;
        public UnityEngine.Transform boxShadow;
        public UnityEngine.Transform boxParticle;
        public TMPro.TextMeshPro rewardInfoText;
        public TMPro.TextMeshPro tapText;
        public UnityEngine.BoxCollider2D tapCollider;
        private Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        private Royal.Infrastructure.Contexts.Units.CameraManager cameraManager;
        private int tapState;
        private int tapCounter;
        private bool isSkipEnabled;
        
        // Methods
        private void Awake()
        {
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
            this.cameraManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            this.transitionBackground.gameObject.SetActive(value:  true);
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  this.cameraManager.cameraWidth, y:  this.cameraManager.cameraHeight);
            this.transitionBackground.size = new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
            UnityEngine.Vector2 val_5 = this.transitionBackground.size;
            this.tapCollider.size = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
            this.tapState = 2;
            if(this.cameraManager.IsDeviceTall() != true)
            {
                    this.SetupForShortDevice();
            }
            
            this.ShowTexts();
            this.ArrangePersonalInfo();
        }
        private void ArrangePersonalInfo()
        {
            UnityEngine.Object val_8;
            this.nickName.SetNickName(nickName:  Royal.Player.Context.Units.RoyalPassManager.GetEventNickName(), isGold:  true, borderType:  0);
            this.nickNameShadow.text = Royal.Player.Context.Units.RoyalPassManager.GetEventNickName();
            val_8 = 0;
            if((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.IsConnectedFacebook()) != false)
            {
                    val_8 = Royal.Infrastructure.Services.Login.FacebookConnect.LoadProfilePicture(facebookId:  Royal.Player.Context.Data.UserId.__il2cppRuntimeField_byval_arg);
            }
            
            if(val_8 != 0)
            {
                    this.personalAvatar.SetActive(value:  true);
                this.kingPicture.gameObject.SetActive(value:  false);
                this.picture.sprite = val_8;
                return;
            }
            
            this.personalAvatar.SetActive(value:  false);
            this.kingPicture.gameObject.SetActive(value:  true);
        }
        public void OnTap()
        {
            if(this.tapState != 1)
            {
                    if(this.tapState != 0)
            {
                    return;
            }
            
                if(this.isSkipEnabled == false)
            {
                    return;
            }
            
                int val_2 = this.tapCounter;
                val_2 = val_2 + 1;
                this.tapCounter = val_2;
                this = "Skip counter: "("Skip counter: ") + val_2;
                UnityEngine.Debug.Log(message:  this);
                return;
            }
            
            this.ClaimRewards();
            this.tapState = 2;
        }
        private void ClaimRewards()
        {
            var val_53;
            RoyalPassRewardRevealDialog.<>c__DisplayClass33_0 val_1 = new RoyalPassRewardRevealDialog.<>c__DisplayClass33_0();
            .<>4__this = this;
            if(this.tapState != 1)
            {
                    return;
            }
            
            this.tapState = 2;
            val_53 = null;
            val_53 = null;
            .sectionBar = null;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.zero;
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.zero;
            UnityEngine.Vector3 val_21 = UnityEngine.Vector3.zero;
            UnityEngine.Vector3 val_26 = UnityEngine.Vector3.zero;
            UnityEngine.Vector3 val_31 = UnityEngine.Vector3.zero;
            UnityEngine.Vector3 val_36 = UnityEngine.Vector3.zero;
            UnityEngine.Vector3 val_41 = UnityEngine.Vector3.zero;
            DG.Tweening.Sequence val_52 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  DG.Tweening.TweenSettingsExtensions.Insert(s:  DG.Tweening.TweenSettingsExtensions.Insert(s:  DG.Tweening.TweenSettingsExtensions.Insert(s:  DG.Tweening.TweenSettingsExtensions.Insert(s:  DG.Tweening.TweenSettingsExtensions.Insert(s:  DG.Tweening.TweenSettingsExtensions.Insert(s:  DG.Tweening.TweenSettingsExtensions.Insert(s:  DG.Tweening.TweenSettingsExtensions.Insert(s:  DG.Tweening.TweenSettingsExtensions.Insert(s:  DG.Tweening.DOTween.Sequence(), atPosition:  0f, t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.transitionBackground, endValue:  0f, duration:  0.4f)), atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.curvedTitle.transform, endValue:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, duration:  0.1f), ease:  2)), atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.tapText.transform, endValue:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, duration:  0.1f), ease:  2)), atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.ticket.transform, endValue:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, duration:  0.1f), ease:  2)), atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.description.transform, endValue:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z}, duration:  0.1f), ease:  2)), atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.rewardInfoText.transform, endValue:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z}, duration:  0.1f), ease:  2)), atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.frameParticle.transform, endValue:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z}, duration:  0.1f), ease:  2)), atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.lifeParticle.transform, endValue:  new UnityEngine.Vector3() {x = val_36.x, y = val_36.y, z = val_36.z}, duration:  0.1f), ease:  2)), atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.boxParticle.transform, endValue:  new UnityEngine.Vector3() {x = val_41.x, y = val_41.y, z = val_41.z}, duration:  0.1f), ease:  2)), atPosition:  0.2f, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void RoyalPassRewardRevealDialog.<>c__DisplayClass33_0::<ClaimRewards>b__0())), atPosition:  0.3f, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void RoyalPassRewardRevealDialog.<>c__DisplayClass33_0::<ClaimRewards>b__1())), atPosition:  0.4f, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void RoyalPassRewardRevealDialog.<>c__DisplayClass33_0::<ClaimRewards>b__2())), atPosition:  1.6f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  typeof(Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassRewardRevealDialog).__il2cppRuntimeField_258));
        }
        private void ShowTexts()
        {
            .<>4__this = this;
            this.audioManager.PlaySound(type:  246, offset:  0.04f);
            this.curvedTitle.Init(frameDelayBetweenChars:  1);
            this.curvedTitle.EnableUpdateForCurvedTexts();
            this.curvedTitle.StartAnimation(isReversed:  false);
            UnityEngine.Vector3 val_3 = this.ticket.transform.localScale;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
            this.ticket.transform.localScale = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            UnityEngine.Vector3 val_7 = this.description.transform.localScale;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
            this.description.transform.localScale = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
            UnityEngine.Vector3 val_11 = this.tapText.transform.localScale;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.zero;
            this.tapText.transform.localScale = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
            this.tapText.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Tap to skip");
            .robertAppearSeq = DG.Tweening.TweenExtensions.Pause<DG.Tweening.Sequence>(t:  this.RewardAppearSequence(reward:  this.robertFrame.transform, textKey:  "RoyalPassRewardsRevealSceneInGolden", index:  0));
            .robertMoveSeq = DG.Tweening.TweenExtensions.Pause<DG.Tweening.Sequence>(t:  this.RewardMoveSequence(reward:  this.robertFrame.transform));
            .giftAppearSeq = DG.Tweening.TweenExtensions.Pause<DG.Tweening.Sequence>(t:  this.RewardAppearSequence(reward:  this.giftBox.transform, textKey:  "RoyalPassRewardsRevealSceneGiftShared", index:  1));
            .giftMoveSeq = DG.Tweening.TweenExtensions.Pause<DG.Tweening.Sequence>(t:  this.RewardMoveSequence(reward:  this.giftBox.transform));
            .lifeSeq = DG.Tweening.TweenExtensions.Pause<DG.Tweening.Sequence>(t:  this.RewardAppearSequence(reward:  this.life.transform, textKey:  "RoyalPassRewardsRevealSceneMaxLives", index:  2));
            UnityEngine.Vector3 val_30 = UnityEngine.Vector3.zero;
            this.life.localScale = new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z};
            DG.Tweening.Sequence val_31 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_35 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_31, atPosition:  0.3f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.ticket.transform, endValue:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, duration:  0.4f), ease:  27, overshoot:  2f));
            DG.Tweening.Sequence val_39 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_31, atPosition:  0.4f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.description.transform, endValue:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, duration:  0.4f), ease:  27));
            DG.Tweening.Sequence val_43 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_31, atPosition:  0.5f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.tapText.transform, endValue:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, duration:  0.3f), ease:  27));
            DG.Tweening.Sequence val_45 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_31, atPosition:  0.7f, callback:  new DG.Tweening.TweenCallback(object:  new RoyalPassRewardRevealDialog.<>c__DisplayClass34_0(), method:  System.Void RoyalPassRewardRevealDialog.<>c__DisplayClass34_0::<ShowTexts>b__0()));
        }
        private System.Collections.IEnumerator PlayAnimations(DG.Tweening.Sequence robertAppearSeq, DG.Tweening.Sequence robertMoveSeq, DG.Tweening.Sequence giftAppearSeq, DG.Tweening.Sequence giftMoveSeq, DG.Tweening.Sequence lifeAppearSeq)
        {
            .<>1__state = 0;
            .robertAppearSeq = robertAppearSeq;
            .robertMoveSeq = robertMoveSeq;
            .giftMoveSeq = giftMoveSeq;
            .giftAppearSeq = giftAppearSeq;
            .<>4__this = this;
            .lifeAppearSeq = lifeAppearSeq;
            return (System.Collections.IEnumerator)new RoyalPassRewardRevealDialog.<PlayAnimations>d__35();
        }
        private void AnimateTextToClaim()
        {
            this.tapState = 2;
            DG.Tweening.Sequence val_16 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_16, t:  DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.tapText.transform, endValue:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, duration:  0.15f), ease:  1));
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_16, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassRewardRevealDialog::<AnimateTextToClaim>b__36_0()));
            UnityEngine.Transform val_9 = this.tapText.transform;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.one;
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_16, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_9, endValue:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, duration:  0.2f), ease:  27));
            System.Delegate val_15 = System.Delegate.Combine(a:  val_9, b:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassRewardRevealDialog::<AnimateTextToClaim>b__36_1()));
            if(val_15 != null)
            {
                    if(null != null)
            {
                goto label_9;
            }
            
            }
            
            val_16 = val_15;
            return;
            label_9:
        }
        private DG.Tweening.Sequence RewardAppearSequence(UnityEngine.Transform reward, string textKey, int index)
        {
            RoyalPassRewardRevealDialog.<>c__DisplayClass37_0 val_1 = new RoyalPassRewardRevealDialog.<>c__DisplayClass37_0();
            .<>4__this = this;
            .textKey = textKey;
            UnityEngine.Vector3 val_2 = reward.localScale;
            if(index == 0)
            {
                    UnityEngine.Color val_3 = this.rewardInfoText.color;
                this.rewardInfoText.color = new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = 0f};
            }
            
            DG.Tweening.Sequence val_4 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.OnStart<DG.Tweening.Sequence>(t:  val_4, action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void RoyalPassRewardRevealDialog.<>c__DisplayClass37_0::<RewardAppearSequence>b__0()));
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_4, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  reward, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.3f), ease:  27, overshoot:  2f));
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_4, atPosition:  0.1f, t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.OnStart<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.ShortcutExtensionsTMPText.DOFade(target:  this.rewardInfoText, endValue:  1f, duration:  0.2f), ease:  3), action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void RoyalPassRewardRevealDialog.<>c__DisplayClass37_0::<RewardAppearSequence>b__1())), action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void RoyalPassRewardRevealDialog.<>c__DisplayClass37_0::<RewardAppearSequence>b__2())));
            return val_4;
        }
        private DG.Tweening.Sequence RewardMoveSequence(UnityEngine.Transform reward)
        {
            UnityEngine.Vector3 val_1 = reward.localPosition;
            UnityEngine.Vector3 val_2 = reward.localScale;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  1.25f);
            reward.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
            reward.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            DG.Tweening.Sequence val_5 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.OnStart<DG.Tweening.Sequence>(t:  val_5, action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassRewardRevealDialog::<RewardMoveSequence>b__38_0()));
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_5, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.OnStart<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.ShortcutExtensionsTMPText.DOFade(target:  this.rewardInfoText, endValue:  0f, duration:  0.2f), ease:  2), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassRewardRevealDialog::<RewardMoveSequence>b__38_1())));
            DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_5, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  reward, endValue:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, duration:  0.4f, snapping:  false), ease:  4));
            DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_5, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  reward, endValue:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, duration:  0.2f), ease:  3));
            DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_5, atPosition:  0.2f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  reward, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.2f), ease:  2));
            return val_5;
        }
        public override Royal.Infrastructure.UiComponents.Dialog.DialogConfig GetConfig()
        {
            bool val_2;
            float val_3;
            bool val_4;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_0;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_1 = this.GetConfig();
            val_0.shouldCloseOnEscape = false;
            val_0.shouldCloseOnTouch = false;
            val_0.shouldHideBackground = val_2;
            val_0.backgroundFadeOutDuration = val_3;
            val_0.shouldCloseOnSwipe = val_4;
            val_0.backgroundFadeAlpha = 0f;
            return val_0;
        }
        public override void OnShow(UnityEngine.Vector3 position)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
            UnityEngine.Transform val_2 = this.transform;
            val_2.position = new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z};
            val_2.localScale = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
        }
        private void SetupForShortDevice()
        {
            UnityEngine.Vector3 val_2 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1).GetSafeBottomCenterOfCamera();
            UnityEngine.Transform val_4 = this.tapText.transform;
            val_4.SetYPosition(transform:  val_4, y:  val_2.y + 1.5f);
        }
        private void SetYPosition(UnityEngine.Transform transform, float y)
        {
            UnityEngine.Vector3 val_1 = transform.position;
            transform.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        private System.Collections.IEnumerator PlayCollectAnimation(UnityEngine.Transform item, UnityEngine.Transform target, UnityEngine.Transform shadow, float dur = 0.7, float shadowMaxY = 0.25, bool isLifeCollect = False)
        {
            .<>1__state = 0;
            .target = target;
            .<>4__this = this;
            .item = item;
            .shadow = shadow;
            .dur = dur;
            .shadowMaxY = shadowMaxY;
            .isLifeCollect = isLifeCollect;
            return (System.Collections.IEnumerator)new RoyalPassRewardRevealDialog.<PlayCollectAnimation>d__43();
        }
        private void PlayHitAnimation(UnityEngine.Transform target, bool isLifeCollect)
        {
            var val_22;
            var val_24;
            val_22 = isLifeCollect;
            this.audioManager.PlaySound(type:  23, offset:  0.04f);
            UnityEngine.GameObject val_3 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "EpisodeRewardHitParticles"));
            .hitParticles = val_3;
            UnityEngine.Vector3 val_6 = target.transform.position;
            val_3.transform.position = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            if(val_7.Length >= 1)
            {
                    var val_23 = 0;
                do
            {
                (RoyalPassRewardRevealDialog.<>c__DisplayClass44_0)[1152921519248151664].hitParticles.GetComponentsInChildren<UnityEngine.ParticleSystem>()[val_23].Play();
                val_23 = val_23 + 1;
            }
            while(val_23 < val_7.Length);
            
            }
            
            UnityEngine.Vector3 val_9 = target.transform.localScale;
            DG.Tweening.Sequence val_10 = DG.Tweening.DOTween.Sequence();
            if(val_22 != false)
            {
                    val_24 = null;
                val_24 = null;
                Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.LifeCollectAnimationData val_11 = new Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.LifeCollectAnimationData(minutes:  0, count:  0);
                Royal.Scenes.Home.Ui.__il2cppRuntimeField_38.PlayHitAnimation(animationData:  new Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.LifeCollectAnimationData() {lifeCount = val_11.lifeCount, unlimitedMinutes = val_11.lifeCount});
            }
            else
            {
                    UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, d:  0.8f);
                DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_10, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  target, endValue:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  3f)));
                DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_10, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  target, endValue:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  4f)));
            }
            
            DG.Tweening.Sequence val_19 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_10, interval:  2f);
            DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_10, action:  new DG.Tweening.TweenCallback(object:  new RoyalPassRewardRevealDialog.<>c__DisplayClass44_0(), method:  System.Void RoyalPassRewardRevealDialog.<>c__DisplayClass44_0::<PlayHitAnimation>b__0()));
        }
        public RoyalPassRewardRevealDialog()
        {
        
        }
        private void <AnimateTextToClaim>b__36_0()
        {
            this.tapText.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "TaptoClaim");
        }
        private void <AnimateTextToClaim>b__36_1()
        {
            this.tapState = 1;
        }
        private void <RewardMoveSequence>b__38_0()
        {
            if(this.audioManager != null)
            {
                    this.audioManager.PlaySound(type:  248, offset:  0.04f);
                return;
            }
            
            throw new NullReferenceException();
        }
        private void <RewardMoveSequence>b__38_1()
        {
            UnityEngine.Debug.Log(message:  "Skip Disabled: "("Skip Disabled: ") + UnityEngine.Time.frameCount);
            this.isSkipEnabled = false;
        }
    
    }

}
