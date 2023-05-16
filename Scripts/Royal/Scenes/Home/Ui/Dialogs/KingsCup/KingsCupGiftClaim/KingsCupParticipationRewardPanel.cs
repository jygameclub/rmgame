using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim
{
    public class KingsCupParticipationRewardPanel : UiPanel
    {
        // Fields
        public TMPro.TextMeshPro tapText;
        public UnityEngine.SpriteRenderer background;
        public UnityEngine.Transform reward;
        public Royal.Infrastructure.Utils.Text.CurvedTextAnimator curvedTextAnimator;
        public UnityEngine.ParticleSystem appearParticles;
        public Royal.Infrastructure.Utils.Particles.AutoDisableParticles trailParticles;
        public TMPro.TextMeshPro amountText;
        private Royal.Scenes.Home.Ui.Dialogs.EpisodeChest.TapState tapState;
        private bool isTapEnabled;
        private System.Action onComplete;
        private Royal.Infrastructure.Contexts.Units.CameraManager camManager;
        private Royal.Infrastructure.UiComponents.Touch.UiTouchListener uiTouchListener;
        private DG.Tweening.Sequence hoverSequence;
        private DG.Tweening.Tween hoverTween;
        private Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        
        // Methods
        public void Show(System.Action onComplete)
        {
            null = null;
            Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_element_class.ChangeSection(type:  0);
            this.camManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
            this.uiTouchListener = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  this.camManager.cameraWidth, y:  this.camManager.cameraHeight);
            this.background.size = new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
            this.curvedTextAnimator.Init(frameDelayBetweenChars:  1);
            this.curvedTextAnimator.StartAnimation(isReversed:  false);
            this.onComplete = onComplete;
            this.Invoke(methodName:  "AnimateTextToContinue", time:  1f);
            this.ShowReward();
        }
        public override void TouchUp(UnityEngine.Vector2 position)
        {
            if(this.isTapEnabled == false)
            {
                    return;
            }
            
            if(this.tapState != 1)
            {
                    return;
            }
            
            this.ContinueClicked();
        }
        private void ContinueClicked()
        {
            var val_18;
            this.isTapEnabled = false;
            DG.Tweening.Sequence val_1 = this.SendGiftToButton(duration:  0.6f);
            this.curvedTextAnimator.EnableUpdateForCurvedTexts();
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.tapText.transform, endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  0.15f), ease:  1));
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  0f, t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.background, endValue:  0f, duration:  0.2f));
            val_18 = 0;
            label_12:
            if(val_18 >= this.curvedTextAnimator.texts.Length)
            {
                goto label_9;
            }
            
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  0f, t:  DG.Tweening.ShortcutExtensionsTMPText.DOFade(target:  this.curvedTextAnimator.texts[val_18].GetComponent<TMPro.TextMeshPro>(), endValue:  0f, duration:  0.15f));
            val_18 = val_18 + 1;
            if(this.curvedTextAnimator != null)
            {
                goto label_12;
            }
            
            throw new NullReferenceException();
            label_9:
            DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  0f, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.curvedTextAnimator.transform, endValue:  1.1f, duration:  0.15f));
            DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  0f, t:  DG.Tweening.ShortcutExtensionsTMPText.DOFade(target:  this.amountText, endValue:  0f, duration:  0.1f));
        }
        private void AnimateTextToContinue()
        {
            this.tapState = 1;
            this.AnimateText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Tap to Continue"));
        }
        private void AnimateText(string text)
        {
            KingsCupParticipationRewardPanel.<>c__DisplayClass19_0 val_1 = new KingsCupParticipationRewardPanel.<>c__DisplayClass19_0();
            .<>4__this = this;
            .text = text;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
            this.isTapEnabled = false;
            DG.Tweening.Sequence val_3 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_3, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.tapText.transform, endValue:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, duration:  0.15f), ease:  1));
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_3, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void KingsCupParticipationRewardPanel.<>c__DisplayClass19_0::<AnimateText>b__0()));
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_3, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.tapText.transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.2f), ease:  27));
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_3, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void KingsCupParticipationRewardPanel.<>c__DisplayClass19_0::<AnimateText>b__1()));
        }
        private void HideText()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.tapText.transform, endValue:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, duration:  0.15f), ease:  1));
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupParticipationRewardPanel::<HideText>b__20_0()));
        }
        public void ShowReward()
        {
            UnityEngine.Vector3 val_2 = this.reward.transform.localScale;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  1.2f);
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  0.9f);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  1.05f);
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
            this.reward.transform.localScale = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            DG.Tweening.Sequence val_8 = DG.Tweening.DOTween.Sequence();
            Royal.Infrastructure.Utils.Text.CurvedSingleText val_36 = this.curvedTextAnimator.texts[0];
            float val_10 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  (float)(this.curvedTextAnimator.texts[0].<CharCount>k__BackingField) - 1);
            val_10 = val_10 * 2.3f;
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_8, interval:  val_10);
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_8, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.reward.transform, endValue:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  4f)), ease:  3));
            DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_8, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupParticipationRewardPanel::<ShowReward>b__21_0()));
            DG.Tweening.Sequence val_23 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_8, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.reward.transform, endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  7f)), ease:  3));
            DG.Tweening.Sequence val_28 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_8, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.reward.transform, endValue:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  6f)), ease:  3));
            DG.Tweening.Sequence val_33 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_8, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.reward.transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  4f)), ease:  3));
            DG.Tweening.Sequence val_35 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_8, callback:  new DG.Tweening.TweenCallback(object:  this, method:  public System.Void Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupParticipationRewardPanel::Hover()));
        }
        public DG.Tweening.Sequence SendGiftToButton(float duration)
        {
            var val_14;
            if(this.hoverTween != null)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  this.hoverTween, complete:  false);
                this.hoverTween = 0;
            }
            
            if(this.hoverSequence != null)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  this.hoverSequence, complete:  false);
                this.hoverSequence = 0;
            }
            
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            val_14 = null;
            val_14 = null;
            UnityEngine.Vector3 val_6 = Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_this_arg + 136.transform.parent.transform.position;
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOMove(target:  this.reward.transform, endValue:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, duration:  duration, snapping:  false), ease:  26));
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0.1f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupParticipationRewardPanel::<SendGiftToButton>b__22_0()));
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_1, action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupParticipationRewardPanel::<SendGiftToButton>b__22_1()));
            return val_1;
        }
        public void Hover()
        {
            .<>4__this = this;
            UnityEngine.Vector3 val_3 = this.reward.transform.localPosition;
            float val_9 = 0.1f;
            mem[1152921519484788208] = val_3.z;
            .firstPos = val_3;
            val_9 = val_3.y + val_9;
            mem[1152921519484788216] = val_9;
            mem[1152921519484788220] = val_3.z;
            val_3.y = val_3.y + (-0.1f);
            .secondPos = val_3;
            mem[1152921519484788204] = val_3.y;
            this.hoverTween = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.reward.transform, endValue:  new UnityEngine.Vector3() {x = (KingsCupParticipationRewardPanel.<>c__DisplayClass23_0)[1152921519484788176].firstPos, y = val_3.y, z = val_3.z}, duration:  1f, snapping:  false), action:  new DG.Tweening.TweenCallback(object:  new KingsCupParticipationRewardPanel.<>c__DisplayClass23_0(), method:  System.Void KingsCupParticipationRewardPanel.<>c__DisplayClass23_0::<Hover>b__0())), ease:  4);
        }
        private void PlayButtonHitAnimation()
        {
            var val_37;
            KingsCupParticipationRewardPanel.<>c__DisplayClass24_0 val_1 = new KingsCupParticipationRewardPanel.<>c__DisplayClass24_0();
            .<>4__this = this;
            val_37 = null;
            val_37 = null;
            UnityEngine.Transform val_3 = Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_this_arg + 136.transform.parent;
            UnityEngine.GameObject val_5 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "EpisodeRewardHitParticles"));
            .hitParticles = val_5;
            UnityEngine.Vector3 val_8 = val_3.transform.position;
            val_5.transform.position = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            if(val_9.Length >= 1)
            {
                    var val_38 = 0;
                do
            {
                (KingsCupParticipationRewardPanel.<>c__DisplayClass24_0)[1152921519485066064].hitParticles.GetComponentsInChildren<UnityEngine.ParticleSystem>()[val_38].Play();
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
            DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_10, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_3, endValue:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, duration:  0.05f));
            DG.Tweening.Sequence val_19 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_10, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void KingsCupParticipationRewardPanel.<>c__DisplayClass24_0::<PlayButtonHitAnimation>b__0()));
            UnityEngine.Vector2 val_20 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            UnityEngine.Vector2 val_21 = new UnityEngine.Vector2(x:  0.98f, y:  1.02f);
            UnityEngine.Vector2 val_22 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_20.x, y = val_20.y}, b:  new UnityEngine.Vector2() {x = val_21.x, y = val_21.y});
            UnityEngine.Vector3 val_23 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_22.x, y = val_22.y});
            DG.Tweening.Sequence val_25 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_10, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_3, endValue:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, duration:  0.075f));
            UnityEngine.Vector2 val_26 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            UnityEngine.Vector2 val_27 = new UnityEngine.Vector2(x:  1.01f, y:  0.99f);
            UnityEngine.Vector2 val_28 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_26.x, y = val_26.y}, b:  new UnityEngine.Vector2() {x = val_27.x, y = val_27.y});
            UnityEngine.Vector3 val_29 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_28.x, y = val_28.y});
            DG.Tweening.Sequence val_31 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_10, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_3, endValue:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z}, duration:  0.06f));
            DG.Tweening.Sequence val_33 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_10, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_3, endValue:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, duration:  0.05f));
            DG.Tweening.Sequence val_34 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_10, interval:  2f);
            DG.Tweening.Sequence val_36 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_10, action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void KingsCupParticipationRewardPanel.<>c__DisplayClass24_0::<PlayButtonHitAnimation>b__1()));
        }
        public KingsCupParticipationRewardPanel()
        {
        
        }
        private void <HideText>b__20_0()
        {
            this.tapText.text = "";
        }
        private void <ShowReward>b__21_0()
        {
            this.audioManager.PlaySound(type:  22, offset:  0.04f);
            this.appearParticles.Play();
        }
        private void <SendGiftToButton>b__22_0()
        {
            if(this.trailParticles != null)
            {
                    this.trailParticles.Play(shouldDestroy:  true);
                return;
            }
            
            throw new NullReferenceException();
        }
        private void <SendGiftToButton>b__22_1()
        {
            this.trailParticles.transform.SetParent(p:  0);
            this.PlayButtonHitAnimation();
            if(this.onComplete != null)
            {
                    this.onComplete.Invoke();
            }
            
            UnityEngine.Object.Destroy(obj:  this.gameObject);
        }
    
    }

}
