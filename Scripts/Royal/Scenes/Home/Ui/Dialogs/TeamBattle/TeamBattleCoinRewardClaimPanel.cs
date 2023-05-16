using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.TeamBattle
{
    public class TeamBattleCoinRewardClaimPanel : UiPanel
    {
        // Fields
        public TMPro.TextMeshPro tapText;
        public UnityEngine.SpriteRenderer background;
        public UnityEngine.Transform reward;
        public Royal.Infrastructure.Utils.Text.CurvedTextAnimator curvedTextAnimator;
        public UnityEngine.ParticleSystem appearParticles;
        public UnityEngine.Transform lightParticles;
        private bool isTapEnabled;
        private System.Action onComplete;
        private Royal.Infrastructure.Contexts.Units.CameraManager camManager;
        private Royal.Infrastructure.UiComponents.Touch.UiTouchListener uiTouchListener;
        private DG.Tweening.Sequence hoverSequence;
        private DG.Tweening.Tween hoverTween;
        private Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        
        // Methods
        public void Show(UnityEngine.Transform reward, System.Action onCompleteAction)
        {
            null = null;
            Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_element_class.ChangeSection(type:  0);
            this.reward = reward;
            Royal.Infrastructure.Utils.Text.TextProOnAnAnimationCurve val_8 = reward.GetComponentInChildren<Royal.Infrastructure.Utils.Text.TextProOnAnAnimationCurve>();
            if(val_8 != 0)
            {
                    val_8 = 1;
            }
            
            reward.SetParent(p:  this.transform);
            this.camManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
            this.uiTouchListener = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  this.camManager.cameraWidth, y:  this.camManager.cameraHeight);
            this.background.size = new UnityEngine.Vector2() {x = val_7.x, y = val_7.y};
            this.curvedTextAnimator.Init(frameDelayBetweenChars:  2);
            this.curvedTextAnimator.StartAnimation(isReversed:  false);
            this.onComplete = onCompleteAction;
            this.Invoke(methodName:  "AnimateTapToContinue", time:  1f);
            this.ShowCoins(reward:  reward);
        }
        private void AnimateTapToContinue()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.tapText.transform, endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  0.15f), ease:  1));
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattleCoinRewardClaimPanel::<AnimateTapToContinue>b__14_0()));
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.tapText.transform, endValue:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, duration:  0.2f), ease:  27));
            DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattleCoinRewardClaimPanel::<AnimateTapToContinue>b__14_1()));
        }
        private void ShowCoins(UnityEngine.Transform reward)
        {
            UnityEngine.Vector3 val_1 = reward.position;
            reward.transform.localPosition = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  1.5f);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  1.2f);
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  0.9f);
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  1.05f);
            float val_47 = 0f;
            float val_8 = val_1.x + 0.5f;
            val_47 = val_1.y + val_47;
            val_47 = val_47 * 0.5f;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, t:  0.5f);
            UnityEngine.Vector3[] val_10 = new UnityEngine.Vector3[4];
            val_10[0] = val_1;
            val_10[0] = val_1.y;
            val_10[1] = val_1.z;
            val_10[1] = 0;
            val_10[2] = 0f;
            float val_48 = -0.5f;
            val_9.x = val_9.x + 0.5f;
            val_48 = val_9.y + val_48;
            val_10[3] = val_9.x;
            val_10[3] = val_48;
            val_10[4] = val_9.z;
            val_10[4] = 0;
            val_10[5] = 0f;
            DG.Tweening.Sequence val_11 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Color val_14 = UnityEngine.Color.blue;
            DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_11, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>>(t:  DG.Tweening.ShortcutExtensions.DOPath(target:  reward.transform, path:  val_10, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  25f), pathType:  1, pathMode:  1, resolution:  50, gizmoColor:  new System.Nullable<UnityEngine.Color>() {HasValue = true}), ease:  4));
            DG.Tweening.Sequence val_22 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_11, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  reward.transform, endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  25f)), ease:  3));
            DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_11, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattleCoinRewardClaimPanel::<ShowCoins>b__15_0()));
            DG.Tweening.Sequence val_29 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_11, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  reward.transform, endValue:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  4f)), ease:  3));
            DG.Tweening.Sequence val_31 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_11, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattleCoinRewardClaimPanel::<ShowCoins>b__15_1()));
            DG.Tweening.Sequence val_36 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_11, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  reward.transform, endValue:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  7f)), ease:  3));
            DG.Tweening.Sequence val_41 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_11, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  reward.transform, endValue:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  6f)), ease:  3));
            DG.Tweening.Sequence val_46 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_11, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  reward.transform, endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  4f)), ease:  3));
        }
        public override void TouchUp(UnityEngine.Vector2 position)
        {
            if(this.isTapEnabled == false)
            {
                    return;
            }
            
            this.ContinueClicked();
        }
        private void ContinueClicked()
        {
            this.isTapEnabled = false;
            this.curvedTextAnimator.EnableUpdateForCurvedTexts();
            if(val_1.Length >= 1)
            {
                    var val_30 = 0;
                do
            {
                EmissionModule val_2 = this.appearParticles.GetComponentsInChildren<UnityEngine.ParticleSystem>()[val_30].emission;
                val_30 = val_30 + 1;
            }
            while(val_30 < val_1.Length);
            
            }
            
            DG.Tweening.Sequence val_3 = DG.Tweening.DOTween.Sequence();
            if(this.lightParticles != 0)
            {
                    UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
                DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_3, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.lightParticles, endValue:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, duration:  0.1f), ease:  1));
            }
            
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_3, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.reward.transform, endValue:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, duration:  0.15f), ease:  1));
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.zero;
            DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_3, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.tapText.transform, endValue:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, duration:  0.15f), ease:  1));
            DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_3, atPosition:  0f, t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.background, endValue:  0f, duration:  0.2f));
            var val_32 = 0;
            label_24:
            if(val_32 >= this.curvedTextAnimator.texts.Length)
            {
                goto label_21;
            }
            
            DG.Tweening.Sequence val_23 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_3, atPosition:  0f, t:  DG.Tweening.ShortcutExtensionsTMPText.DOFade(target:  this.curvedTextAnimator.texts[val_32].GetComponent<TMPro.TextMeshPro>(), endValue:  0f, duration:  0.15f));
            val_32 = val_32 + 1;
            if(this.curvedTextAnimator != null)
            {
                goto label_24;
            }
            
            throw new NullReferenceException();
            label_21:
            DG.Tweening.Sequence val_26 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_3, atPosition:  0f, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.curvedTextAnimator.transform, endValue:  1.1f, duration:  0.15f));
            DG.Tweening.Sequence val_28 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_3, action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattleCoinRewardClaimPanel::<ContinueClicked>b__17_0()));
        }
        public TeamBattleCoinRewardClaimPanel()
        {
        
        }
        private void <AnimateTapToContinue>b__14_0()
        {
            this.tapText.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Tap to Continue");
        }
        private void <AnimateTapToContinue>b__14_1()
        {
            this.isTapEnabled = true;
        }
        private void <ShowCoins>b__15_0()
        {
            if(this.audioManager != null)
            {
                    this.audioManager.PlaySound(type:  22, offset:  0.04f);
                return;
            }
            
            throw new NullReferenceException();
        }
        private void <ShowCoins>b__15_1()
        {
            if(this.appearParticles != null)
            {
                    this.appearParticles.Play();
                return;
            }
            
            throw new NullReferenceException();
        }
        private void <ContinueClicked>b__17_0()
        {
            if(this.onComplete != null)
            {
                    this.onComplete.Invoke();
            }
            
            UnityEngine.Object.Destroy(obj:  this.gameObject);
        }
    
    }

}
