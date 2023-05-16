using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Completed1000ThLevel
{
    public class Completed1000ThLevelPanel : UiPanel
    {
        // Fields
        public UnityEngine.GameObject root;
        public UnityEngine.SpriteRenderer background;
        public UnityEngine.BoxCollider2D blockerCollider;
        public UnityEngine.BoxCollider2D panelCollider;
        public Royal.Infrastructure.Utils.Text.CurvedTextAnimator curvedTitle;
        public UnityEngine.ParticleSystem episodeCompletedParticles;
        public UnityEngine.Transform screenTopPosition;
        public UnityEngine.Transform plateAndBugle;
        public UnityEngine.Transform description;
        public TMPro.TextMeshPro tapText;
        public UnityEngine.Transform rewardContainer;
        public System.Collections.Generic.List<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassUnclaimedReward> rewardViews;
        private Royal.Infrastructure.Contexts.Units.CameraManager cameraManager;
        private bool isTapEnabled;
        private System.Action onComplete;
        private float fadeDuration;
        private Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        private bool didStopHomeMusic;
        
        // Methods
        public void Show(System.Action onComplete)
        {
            Royal.Infrastructure.Utils.Text.CurvedTextAnimator val_10;
            this.cameraManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
            this.onComplete = onComplete;
            if((Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.GetBool(key:  "Sfx", defaultValue:  true)) != false)
            {
                    this.didStopHomeMusic = true;
                this.audioManager.StopHomeMusic();
                Royal.Scenes.Home.Context.Units.Area.AreaManager val_4 = Royal.Scenes.Home.Context.HomeContext.Get<Royal.Scenes.Home.Context.Units.Area.AreaManager>(id:  0);
                val_4.<AreaView>k__BackingField.StopBackgroundSounds();
            }
            
            this.isTapEnabled = false;
            UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  this.cameraManager.cameraWidth, y:  this.cameraManager.cameraHeight);
            this.background.size = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
            UnityEngine.Color val_6 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32());
            this.background.color = new UnityEngine.Color() {r = val_6.r, g = val_6.g, b = val_6.b, a = val_6.a};
            UnityEngine.Vector2 val_7 = this.background.size;
            this.panelCollider.size = new UnityEngine.Vector2() {x = val_7.x, y = val_7.y};
            UnityEngine.Vector2 val_8 = this.background.size;
            this.blockerCollider.size = new UnityEngine.Vector2() {x = val_8.x, y = val_8.y};
            val_10 = this.curvedTitle;
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isArabic == false)
            {
                goto label_16;
            }
            
            var val_11 = 0;
            label_22:
            if(val_11 >= this.curvedTitle.texts.Length)
            {
                goto label_19;
            }
            
            this.curvedTitle.texts[val_11] = 0;
            val_10 = this.curvedTitle;
            val_11 = val_11 + 1;
            if(val_10 != null)
            {
                goto label_22;
            }
            
            throw new NullReferenceException();
            label_16:
            label_19:
            val_10.Init(frameDelayBetweenChars:  1);
            if(this.cameraManager.IsDeviceTall() != true)
            {
                    this.SetupForShortDevice();
            }
            
            this.ShowTexts();
            this.PlayAnimation();
        }
        private void CreateRewards()
        {
            Royal.Player.Context.Data.InventoryPackage val_1 = Royal.Player.Context.Data.InventoryPackage.Get1000ThLevelPackage();
            var val_9 = 4;
            label_36:
            var val_2 = val_9 - 4;
            if(val_2 >= 36528128)
            {
                    return;
            }
            
            if(36528128 <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            8.Init(collectStrategy:  1);
            if(36528128 <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_6 = mem[68719476768];
            val_6 = val_6 - 1;
            if(val_6 > 4)
            {
                goto label_44;
            }
            
            var val_7 = 36587780 + ((mem[68719476768] - 1)) << 2;
            val_7 = val_7 + 36587780;
            goto (36587780 + ((mem[68719476768] - 1)) << 2 + 36587780);
            label_44:
            if(val_7 <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            (36587780 + ((mem[68719476768] - 1)) << 2 + 36587780) + 32.gameObject.SetActive(value:  true);
            if(val_7 <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            float val_8 = (float)val_2;
            float val_5 = val_8 * 0.03f;
            val_8 = val_8 * 0.01f;
            val_9 = val_9 + 1;
            if(this.rewardViews != null)
            {
                goto label_36;
            }
            
            if(((36587780 + ((mem[68719476768] - 1)) << 2 + 36587780) + 32) <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            (36587780 + ((mem[68719476768] - 1)) << 2 + 36587780) + 32 + ((4 + 1)) << 3.SetLife(minutes:  val_1.unlimitedLifetimeMin, prepareTextForAnimation:  false);
            goto label_44;
        }
        private void ShowTexts()
        {
            this.curvedTitle.StartAnimation(isReversed:  false);
            UnityEngine.Vector3 val_2 = this.description.transform.localScale;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
            this.description.transform.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            UnityEngine.Vector3 val_6 = this.tapText.transform.localScale;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
            this.tapText.transform.localScale = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            DG.Tweening.Sequence val_9 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_9, atPosition:  1.03f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.description, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.5f), ease:  27));
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_9, atPosition:  1.23f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.Completed1000ThLevel.Completed1000ThLevelPanel::<ShowTexts>b__20_0()));
            DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_9, atPosition:  2.2f, t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.tapText.transform, endValue:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, duration:  0.2f), ease:  27), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.Completed1000ThLevel.Completed1000ThLevelPanel::<ShowTexts>b__20_1())));
        }
        private void PlayAnimation()
        {
            float val_1 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  18f);
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_2, atPosition:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.Completed1000ThLevel.Completed1000ThLevelPanel::<PlayAnimation>b__21_0()));
            float val_12 = 1.13f;
            val_12 = val_1 + val_12;
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_2, atPosition:  val_12, callback:  new DG.Tweening.TweenCallback(object:  this.episodeCompletedParticles, method:  public System.Void UnityEngine.ParticleSystem::Play()));
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_2, atPosition:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  1f), callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.Completed1000ThLevel.Completed1000ThLevelPanel::<PlayAnimation>b__21_1()));
            float val_13 = 4.5f;
            val_13 = val_1 + val_13;
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_2, atPosition:  val_13, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.Completed1000ThLevel.Completed1000ThLevelPanel::<PlayAnimation>b__21_2()));
        }
        private void ArrangeMusicBack()
        {
            if(this.didStopHomeMusic == false)
            {
                    return;
            }
            
            this.didStopHomeMusic = false;
            this.audioManager.ResumeHomeMusic();
            Royal.Scenes.Home.Context.Units.Area.AreaManager val_1 = Royal.Scenes.Home.Context.HomeContext.Get<Royal.Scenes.Home.Context.Units.Area.AreaManager>(id:  0);
            val_1.<AreaView>k__BackingField.PlayBackgroundSounds();
        }
        public override void TouchUp(UnityEngine.Vector2 position)
        {
            if(this.isTapEnabled == false)
            {
                    return;
            }
            
            this.isTapEnabled = false;
            this.episodeCompletedParticles.transform.SetParent(p:  0);
            this.rewardContainer.GetComponent<UnityEngine.Rendering.SortingGroup>().enabled = true;
            if(val_3.Length >= 1)
            {
                    var val_7 = 0;
                do
            {
                this.episodeCompletedParticles.GetComponentsInChildren<UnityEngine.ParticleSystem>()[val_7].gameObject.AddComponent<Royal.Infrastructure.Utils.Particles.ParticleSystemFadeOut>().FadeOut(seconds:  0.2f);
                val_7 = val_7 + 1;
            }
            while(val_7 < val_3.Length);
            
            }
            
            this.PlayRewardAnimations();
        }
        private void PlayRewardAnimations()
        {
            var val_8 = 0;
            var val_7 = 0;
            label_8:
            if(val_7 >= 36585472)
            {
                goto label_2;
            }
            
            if(36585472 <= val_7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            float val_4 = 0f;
            val_4 = val_4 * (-0.075f);
            float val_2 = UnityEngine.Mathf.Max(a:  0.4f, b:  val_4 + 0.7f);
            System.Collections.Generic.List<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassUnclaimedReward> val_5 = this.rewardViews;
            val_5 = val_8 + val_5;
            float val_6 = (float)val_5;
            val_6 = val_6 * 0.04f;
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Sequence>(t:  3, delay:  val_6);
            val_7 = val_7 + 1;
            val_8 = val_8 - 1;
            if(this.rewardViews != null)
            {
                goto label_8;
            }
            
            label_2:
            this.rewardContainer.SetParent(p:  0);
            this.HideTexts();
        }
        private void HideTexts()
        {
            this.background.gameObject.SetActive(value:  true);
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.curvedTitle.transform, endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  0.15f), ease:  1));
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.plateAndBugle.transform, endValue:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, duration:  0.2f), ease:  26));
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.zero;
            DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  0.02f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.description.transform, endValue:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, duration:  0.15f), ease:  1));
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.zero;
            DG.Tweening.Sequence val_22 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  0.04f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.tapText.transform, endValue:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, duration:  0.15f), ease:  1));
            DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  0f, t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.background, endValue:  0f, duration:  0.2f));
            DG.Tweening.Sequence val_26 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_2, atPosition:  0.2f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.Completed1000ThLevel.Completed1000ThLevelPanel::<HideTexts>b__25_0()));
            DG.Tweening.Sequence val_28 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_2, atPosition:  this.fadeDuration, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.Completed1000ThLevel.Completed1000ThLevelPanel::<HideTexts>b__25_1()));
            DG.Tweening.Sequence val_30 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_2, atPosition:  2f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.Completed1000ThLevel.Completed1000ThLevelPanel::<HideTexts>b__25_2()));
        }
        private void SetupForShortDevice()
        {
            Royal.Infrastructure.Contexts.Units.CameraManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            UnityEngine.Vector3 val_4 = this.rewardContainer.transform.localPosition;
            val_4.y = val_4.y + (-0.3f);
            this.rewardContainer.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Vector3 val_6 = val_1.GetSafeTopCenterOfCamera();
            float val_15 = -1.95f;
            val_15 = val_6.y + val_15;
            val_1.SetLocalYPosition(transform:  this.curvedTitle.transform, y:  val_15);
            UnityEngine.Vector3 val_8 = val_1.GetSafeTopCenterOfCamera();
            float val_16 = -5.07f;
            val_16 = val_8.y + val_16;
            val_1.SetLocalYPosition(transform:  this.plateAndBugle.transform, y:  val_16);
            UnityEngine.Vector3 val_10 = val_1.GetSafeTopCenterOfCamera();
            float val_17 = -7.25f;
            val_17 = val_10.y + val_17;
            val_1.SetLocalYPosition(transform:  this.description.transform, y:  val_17);
            UnityEngine.Vector3 val_12 = val_1.GetSafeTopCenterOfCamera();
            float val_18 = -13.47f;
            val_18 = val_12.y + val_18;
            val_1.SetLocalYPosition(transform:  this.rewardContainer.transform, y:  val_18);
            UnityEngine.Vector3 val_14 = val_1.GetSafeBottomCenterOfCamera();
            float val_19 = 1.5f;
            val_19 = val_14.y + val_19;
            val_1.SetLocalYPosition(transform:  this.tapText.transform, y:  val_19);
        }
        private void SetLocalYPosition(UnityEngine.Transform transform, float y)
        {
            UnityEngine.Vector3 val_1 = transform.localPosition;
            transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        public Completed1000ThLevelPanel()
        {
            this.fadeDuration = 3f;
        }
        private void <ShowTexts>b__20_0()
        {
            this.CreateRewards();
        }
        private void <ShowTexts>b__20_1()
        {
            this.isTapEnabled = true;
        }
        private void <PlayAnimation>b__21_0()
        {
            UnityEngine.Vector3 val_1 = this.cameraManager.GetTopCenterOfCamera();
            this.screenTopPosition.transform.position = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = 0f};
        }
        private void <PlayAnimation>b__21_1()
        {
            if(this.audioManager != null)
            {
                    this.audioManager.PlaySound(type:  76, offset:  0.04f);
                return;
            }
            
            throw new NullReferenceException();
        }
        private void <PlayAnimation>b__21_2()
        {
            this.ArrangeMusicBack();
        }
        private void <HideTexts>b__25_0()
        {
            if(this.root != null)
            {
                    this.root.SetActive(value:  false);
                return;
            }
            
            throw new NullReferenceException();
        }
        private void <HideTexts>b__25_1()
        {
            UnityEngine.Object.Destroy(obj:  this.gameObject);
            if(this.onComplete == null)
            {
                    return;
            }
            
            this.onComplete.Invoke();
        }
        private void <HideTexts>b__25_2()
        {
            UnityEngine.Object.Destroy(obj:  this.rewardContainer.gameObject);
        }
    
    }

}
