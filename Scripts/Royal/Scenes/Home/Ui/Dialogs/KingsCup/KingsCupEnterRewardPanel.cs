using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.KingsCup
{
    public class KingsCupEnterRewardPanel : UiPanel
    {
        // Fields
        public TMPro.TextMeshPro timeText;
        public TMPro.TextMeshPro tapText;
        public UnityEngine.SpriteRenderer background;
        public UnityEngine.Transform rewardHeart;
        public Royal.Infrastructure.Utils.Text.CurvedTextAnimator curvedTextAnimator;
        public UnityEngine.ParticleSystem appearParticles;
        public Royal.Infrastructure.Utils.Particles.AutoDisableParticles trailParticles;
        private bool isTapEnabled;
        private System.Action onComplete;
        private Royal.Infrastructure.Contexts.Units.CameraManager camManager;
        private Royal.Infrastructure.UiComponents.Touch.UiTouchListener uiTouchListener;
        private DG.Tweening.Sequence hoverSequence;
        private DG.Tweening.Tween hoverTween;
        private Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        
        // Methods
        public void Show(UnityEngine.Transform heartTransform, System.Action onCompleteAction)
        {
            this.camManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
            this.uiTouchListener = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  this.camManager.cameraWidth, y:  this.camManager.cameraHeight);
            this.background.size = new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
            UnityEngine.Color val_5 = this.timeText.color;
            this.timeText.color = new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = 0f};
            this.curvedTextAnimator.Init(frameDelayBetweenChars:  2);
            this.curvedTextAnimator.StartAnimation(isReversed:  false);
            this.onComplete = onCompleteAction;
            this.Invoke(methodName:  "AnimateTime", time:  0.75f);
            this.Invoke(methodName:  "AnimateTapToContinue", time:  1f);
            this.ShowHeart(heartTransform:  heartTransform);
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
            var val_21;
            this.isTapEnabled = false;
            DG.Tweening.Sequence val_1 = this.SendHeartToHomeIcon(duration:  0.6f);
            this.curvedTextAnimator.EnableUpdateForCurvedTexts();
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.tapText.transform, endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  0.15f), ease:  1));
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.timeText.transform, endValue:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, duration:  0.15f), ease:  1));
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  0f, t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.background, endValue:  0f, duration:  0.2f));
            val_21 = 0;
            label_13:
            if(val_21 >= this.curvedTextAnimator.texts.Length)
            {
                goto label_10;
            }
            
            DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  0f, t:  DG.Tweening.ShortcutExtensionsTMPText.DOFade(target:  this.curvedTextAnimator.texts[val_21].GetComponent<TMPro.TextMeshPro>(), endValue:  0f, duration:  0.15f));
            val_21 = val_21 + 1;
            if(this.curvedTextAnimator != null)
            {
                goto label_13;
            }
            
            throw new NullReferenceException();
            label_10:
            DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  0f, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.curvedTextAnimator.transform, endValue:  1.1f, duration:  0.15f));
        }
        private void AnimateTapToContinue()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.tapText.transform, endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  0.15f), ease:  1));
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupEnterRewardPanel::<AnimateTapToContinue>b__17_0()));
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.tapText.transform, endValue:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, duration:  0.2f), ease:  27));
            DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupEnterRewardPanel::<AnimateTapToContinue>b__17_1()));
        }
        private void AnimateTime()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.timeText.transform, endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  0.15f), ease:  1));
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupEnterRewardPanel::<AnimateTime>b__18_0()));
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.timeText.transform, endValue:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, duration:  0.2f), ease:  27));
        }
        private void ShowHeart(UnityEngine.Transform heartTransform)
        {
            UnityEngine.Vector3 val_1 = heartTransform.position;
            UnityEngine.Vector3 val_2 = heartTransform.localScale;
            UnityEngine.Vector3 val_4 = this.rewardHeart.transform.localPosition;
            this.rewardHeart.transform.localPosition = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
            UnityEngine.Vector3 val_7 = this.rewardHeart.transform.localScale;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  1.2f);
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  0.9f);
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  1.05f);
            this.rewardHeart.transform.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            float val_12 = val_1.y + val_4.y;
            float val_13 = val_1.x + 0.5f;
            val_12 = val_12 * 0.5f;
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, t:  0.5f);
            UnityEngine.Vector3[] val_15 = new UnityEngine.Vector3[4];
            val_15[0] = val_1;
            val_15[0] = val_1.y;
            val_15[1] = val_1.z;
            val_15[1] = 0;
            val_15[2] = 0f;
            float val_57 = -0.5f;
            val_14.x = val_14.x + 0.5f;
            val_57 = val_14.y + val_57;
            val_15[3] = val_14.x;
            val_15[3] = val_57;
            val_15[4] = val_14.z;
            val_15[4] = val_4;
            val_15[5] = val_4.y;
            val_15[5] = val_4.z;
            DG.Tweening.Sequence val_16 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Color val_19 = UnityEngine.Color.blue;
            DG.Tweening.Sequence val_22 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_16, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>>(t:  DG.Tweening.ShortcutExtensions.DOPath(target:  this.rewardHeart.transform, path:  val_15, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  25f), pathType:  1, pathMode:  1, resolution:  50, gizmoColor:  new System.Nullable<UnityEngine.Color>() {HasValue = true}), ease:  4));
            DG.Tweening.Sequence val_27 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_16, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.rewardHeart.transform, endValue:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  25f)), ease:  3));
            DG.Tweening.Sequence val_29 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_16, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupEnterRewardPanel::<ShowHeart>b__19_0()));
            DG.Tweening.Sequence val_34 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_16, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.rewardHeart.transform, endValue:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  4f)), ease:  3));
            DG.Tweening.Sequence val_36 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_16, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupEnterRewardPanel::<ShowHeart>b__19_1()));
            DG.Tweening.Sequence val_41 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_16, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.rewardHeart.transform, endValue:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  7f)), ease:  3));
            DG.Tweening.Sequence val_46 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_16, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.rewardHeart.transform, endValue:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  6f)), ease:  3));
            DG.Tweening.Sequence val_51 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_16, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.rewardHeart.transform, endValue:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  4f)), ease:  3));
            DG.Tweening.Sequence val_53 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_16, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupEnterRewardPanel::Hover()));
            DG.Tweening.Sequence val_56 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_16, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.ShortcutExtensionsTMPText.DOFade(target:  this.timeText, endValue:  1f, duration:  0.5f), ease:  3));
        }
        public DG.Tweening.Sequence SendHeartToHomeIcon(float duration)
        {
            var val_21;
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
            val_21 = null;
            val_21 = null;
            UnityEngine.Vector3 val_4 = Royal.Scenes.Home.Ui.__il2cppRuntimeField_38 + 64.transform.position;
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOMove(target:  this.rewardHeart.transform, endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  duration, snapping:  false), ease:  26));
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.ShortcutExtensionsTMPText.DOFade(target:  this.timeText, endValue:  1f, duration:  0.5f), ease:  3));
            UnityEngine.Vector3 val_13 = Royal.Scenes.Home.Ui.__il2cppRuntimeField_38 + 64.transform.localScale;
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.rewardHeart.transform, endValue:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, duration:  duration), ease:  26));
            DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0.1f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupEnterRewardPanel::<SendHeartToHomeIcon>b__20_0()));
            DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_1, action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupEnterRewardPanel::<SendHeartToHomeIcon>b__20_1()));
            return val_1;
        }
        private void Hover()
        {
            .<>4__this = this;
            UnityEngine.Vector3 val_3 = this.rewardHeart.transform.localPosition;
            float val_9 = 0.1f;
            mem[1152921519453818896] = val_3.z;
            .firstPos = val_3;
            val_9 = val_3.y + val_9;
            mem[1152921519453818904] = val_9;
            mem[1152921519453818908] = val_3.z;
            val_3.y = val_3.y + (-0.1f);
            .secondPos = val_3;
            mem[1152921519453818892] = val_3.y;
            this.hoverTween = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.rewardHeart.transform, endValue:  new UnityEngine.Vector3() {x = (KingsCupEnterRewardPanel.<>c__DisplayClass21_0)[1152921519453818864].firstPos, y = val_3.y, z = val_3.z}, duration:  1f, snapping:  false), action:  new DG.Tweening.TweenCallback(object:  new KingsCupEnterRewardPanel.<>c__DisplayClass21_0(), method:  System.Void KingsCupEnterRewardPanel.<>c__DisplayClass21_0::<Hover>b__0())), ease:  4);
        }
        private void PlayButtonHitAnimation()
        {
            var val_36;
            var val_37;
            KingsCupEnterRewardPanel.<>c__DisplayClass22_0 val_1 = new KingsCupEnterRewardPanel.<>c__DisplayClass22_0();
            .<>4__this = this;
            val_36 = null;
            val_36 = null;
            Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.LifeCollectAnimationData val_2 = new Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.LifeCollectAnimationData(minutes:  30, count:  0);
            Royal.Scenes.Home.Ui.__il2cppRuntimeField_38.PlayHitAnimation(animationData:  new Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.LifeCollectAnimationData() {lifeCount = val_2.lifeCount, unlimitedMinutes = val_2.lifeCount});
            val_37 = null;
            val_37 = null;
            UnityEngine.GameObject val_4 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "EpisodeRewardHitParticles"));
            .hitParticles = val_4;
            UnityEngine.Vector3 val_7 = Royal.Scenes.Home.Ui.__il2cppRuntimeField_38 + 64.transform.position;
            val_4.transform.position = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            if(val_8.Length >= 1)
            {
                    var val_37 = 0;
                do
            {
                (KingsCupEnterRewardPanel.<>c__DisplayClass22_0)[1152921519454088560].hitParticles.GetComponentsInChildren<UnityEngine.ParticleSystem>()[val_37].Play();
                val_37 = val_37 + 1;
            }
            while(val_37 < val_8.Length);
            
            }
            
            DG.Tweening.Sequence val_9 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.one;
            UnityEngine.Vector2 val_11 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
            UnityEngine.Vector2 val_12 = new UnityEngine.Vector2(x:  1.04f, y:  0.97f);
            UnityEngine.Vector2 val_13 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y}, b:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y});
            UnityEngine.Vector3 val_14 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_13.x, y = val_13.y});
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_9, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  Royal.Scenes.Home.Ui.__il2cppRuntimeField_38 + 64, endValue:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, duration:  0.05f));
            DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_9, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void KingsCupEnterRewardPanel.<>c__DisplayClass22_0::<PlayButtonHitAnimation>b__0()));
            UnityEngine.Vector2 val_19 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
            UnityEngine.Vector2 val_20 = new UnityEngine.Vector2(x:  0.98f, y:  1.02f);
            UnityEngine.Vector2 val_21 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_19.x, y = val_19.y}, b:  new UnityEngine.Vector2() {x = val_20.x, y = val_20.y});
            UnityEngine.Vector3 val_22 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_21.x, y = val_21.y});
            DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_9, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  Royal.Scenes.Home.Ui.__il2cppRuntimeField_38 + 64, endValue:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, duration:  0.075f));
            UnityEngine.Vector2 val_25 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
            UnityEngine.Vector2 val_26 = new UnityEngine.Vector2(x:  1.01f, y:  0.99f);
            UnityEngine.Vector2 val_27 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_25.x, y = val_25.y}, b:  new UnityEngine.Vector2() {x = val_26.x, y = val_26.y});
            UnityEngine.Vector3 val_28 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_27.x, y = val_27.y});
            DG.Tweening.Sequence val_30 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_9, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  Royal.Scenes.Home.Ui.__il2cppRuntimeField_38 + 64, endValue:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z}, duration:  0.06f));
            DG.Tweening.Sequence val_32 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_9, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  Royal.Scenes.Home.Ui.__il2cppRuntimeField_38 + 64, endValue:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, duration:  0.05f));
            DG.Tweening.Sequence val_33 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_9, interval:  2f);
            DG.Tweening.Sequence val_35 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_9, action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void KingsCupEnterRewardPanel.<>c__DisplayClass22_0::<PlayButtonHitAnimation>b__1()));
        }
        public KingsCupEnterRewardPanel()
        {
        
        }
        private void <AnimateTapToContinue>b__17_0()
        {
            this.tapText.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Tap to Continue");
        }
        private void <AnimateTapToContinue>b__17_1()
        {
            this.isTapEnabled = true;
        }
        private void <AnimateTime>b__18_0()
        {
            string val_3;
            string val_4;
            string val_1 = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "m");
            val_3 = "30";
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isArabic != false)
            {
                    val_4 = val_1;
            }
            else
            {
                    val_4 = val_3;
                val_3 = val_1;
            }
            
            this.timeText.text = val_4 + val_3;
        }
        private void <ShowHeart>b__19_0()
        {
            if(this.audioManager != null)
            {
                    this.audioManager.PlaySound(type:  22, offset:  0.04f);
                return;
            }
            
            throw new NullReferenceException();
        }
        private void <ShowHeart>b__19_1()
        {
            if(this.appearParticles != null)
            {
                    this.appearParticles.Play();
                return;
            }
            
            throw new NullReferenceException();
        }
        private void <SendHeartToHomeIcon>b__20_0()
        {
            if(this.trailParticles != null)
            {
                    this.trailParticles.Play(shouldDestroy:  true);
                return;
            }
            
            throw new NullReferenceException();
        }
        private void <SendHeartToHomeIcon>b__20_1()
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
