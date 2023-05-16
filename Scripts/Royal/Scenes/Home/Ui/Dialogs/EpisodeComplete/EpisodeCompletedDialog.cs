using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.EpisodeComplete
{
    public class EpisodeCompletedDialog : UiDialog
    {
        // Fields
        public UnityEngine.SpriteRenderer background;
        public UnityEngine.Transform tapToContinue;
        public UnityEngine.GameObject completedText;
        public Royal.Infrastructure.Utils.Text.TextProOnAnAnimationCurve[] completedCurves;
        public UnityEngine.ParticleSystem episodeCompletedParticles;
        public UnityEngine.Transform spineHolder;
        public Spine.Unity.SkeletonAnimation areaCompletedSkeleton;
        public Spine.Unity.AnimationReferenceAsset areaCompletedAnimationRef;
        public Spine.Unity.SkeletonPartsRenderer ruloPart;
        public Spine.Unity.SkeletonPartsRenderer otherParts;
        public UnityEngine.SpriteMask textMask;
        public UnityEngine.Transform bannerPosition;
        public UnityEngine.Transform screenTopPosition;
        public string flamaBone;
        private Royal.Infrastructure.Contexts.Units.CameraManager cameraManager;
        private bool continueClicked;
        private bool continueEnabled;
        private Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        private Royal.Scenes.Home.Context.Units.Area.AreaManager areaManager;
        private bool didStopHomeMusic;
        
        // Methods
        private void Awake()
        {
            this.cameraManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
            this.areaManager = Royal.Scenes.Home.Context.HomeContext.Get<Royal.Scenes.Home.Context.Units.Area.AreaManager>(id:  0);
            if((Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.GetBool(key:  "Sfx", defaultValue:  true)) != false)
            {
                    this.didStopHomeMusic = true;
                this.audioManager.StopHomeMusic();
                Royal.Scenes.Home.Context.Units.Area.AreaManager val_5 = Royal.Scenes.Home.Context.HomeContext.Get<Royal.Scenes.Home.Context.Units.Area.AreaManager>(id:  0);
                val_5.<AreaView>k__BackingField.StopBackgroundSounds();
            }
            
            this.PrepareCompletedText();
            this.PrepareBackgroundSize();
            this.PrepareButtonPosition();
            this.PrepareSortings();
            this.PlayAnimation();
        }
        public override void OnShow(UnityEngine.Vector3 position)
        {
            UnityEngine.Transform val_1 = this.transform;
            val_1.position = new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z};
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
            val_1.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        }
        private void PrepareSortings()
        {
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_1 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetDialogBackgroundSorting();
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.background, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_1.layer, order = val_1.order, sortEverything = val_1.sortEverything & 4294967295});
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_3 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetDialogSorting();
            bool val_13 = val_3.sortEverything;
            val_13 = val_13 & 4294967295;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_5 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_3.layer, order = val_3.order, sortEverything = val_13}, offset:  100);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.otherParts.GetComponent<UnityEngine.Renderer>(), data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_5.layer, order = val_5.order, sortEverything = val_5.sortEverything & 4294967295});
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_8 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_3.layer, order = val_3.order, sortEverything = val_13}, offset:  101);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(group:  this.completedText.GetComponent<UnityEngine.Rendering.SortingGroup>(), data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_8.layer, order = val_8.order, sortEverything = val_8.sortEverything & 4294967295});
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_11 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_3.layer, order = val_3.order, sortEverything = val_13}, offset:  102);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.ruloPart.GetComponent<UnityEngine.Renderer>(), data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_11.layer, order = val_11.order, sortEverything = val_11.sortEverything & 4294967295});
        }
        private void PrepareBackgroundSize()
        {
            UnityEngine.Vector2 val_2 = this.cameraManager.GetCenterPosition();
            UnityEngine.Vector3 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
            this.transform.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  this.cameraManager.cameraWidth, y:  this.cameraManager.cameraHeight);
            this.background.size = new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
        }
        private void PrepareButtonPosition()
        {
            UnityEngine.Vector3 val_1 = this.tapToContinue.position;
            UnityEngine.Vector3 val_2 = this.cameraManager.GetSafeBottomCenterOfCamera();
            val_2.y = val_2.y + 1.65f;
            this.tapToContinue.position = new UnityEngine.Vector3() {x = val_1.x, y = val_2.y, z = val_1.z};
        }
        private void PrepareCompletedText()
        {
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isGerman == false)
            {
                    return;
            }
            
            var val_7 = 0;
            label_6:
            if(val_7 >= this.completedCurves.Length)
            {
                goto label_3;
            }
            
            this.completedCurves[val_7] = 1078355558;
            val_7 = val_7 + 1;
            if(this.completedCurves != null)
            {
                goto label_6;
            }
            
            throw new NullReferenceException();
            label_3:
            UnityEngine.Transform val_1 = this.completedText.transform;
            UnityEngine.Vector3 val_2 = val_1.localPosition;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.right;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  0.03f);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            val_1.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        }
        private void SetBannerPositionForScreen()
        {
            Spine.Bone val_2 = this.areaCompletedSkeleton.Skeleton.FindBone(boneName:  this.flamaBone);
            UnityEngine.Vector2 val_3 = Spine.Unity.SkeletonExtensions.GetLocalPosition(bone:  val_2);
            UnityEngine.Vector3 val_4 = this.cameraManager.GetSafeTopCenterOfCamera();
            UnityEngine.Vector3 val_5 = this.cameraManager.GetBottomCenterOfCamera();
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            val_6.y = val_6.y + (-4.5f);
            Spine.Unity.SkeletonExtensions.SetLocalPosition(bone:  val_2, position:  new UnityEngine.Vector2() {x = val_3.x, y = val_6.y});
            val_2.UpdateWorldTransform();
            UnityEngine.Vector3 val_8 = Spine.Unity.SkeletonExtensions.GetWorldPosition(bone:  val_2, spineGameObjectTransform:  this.areaCompletedSkeleton.transform);
            this.bannerPosition.transform.position = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            UnityEngine.Vector3 val_10 = this.cameraManager.GetTopCenterOfCamera();
            this.screenTopPosition.transform.position = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = 0f};
        }
        public void PlayAnimation()
        {
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            this.tapToContinue.transform.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            this.spineHolder.gameObject.SetActive(value:  false);
            float val_22 = 0.3f;
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_4 = DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.background, endValue:  0.8f, duration:  val_22);
            val_22 = (Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  18f)) + val_22;
            DG.Tweening.Sequence val_6 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_6, atPosition:  val_22, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.EpisodeComplete.EpisodeCompletedDialog::<PlayAnimation>b__27_0()));
            float val_23 = 0.17f;
            val_23 = val_22 + val_23;
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_6, atPosition:  val_23, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.EpisodeComplete.EpisodeCompletedDialog::<PlayAnimation>b__27_1()));
            float val_24 = 1.5f;
            val_24 = val_22 + val_24;
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_6, atPosition:  val_24, callback:  new DG.Tweening.TweenCallback(object:  this.episodeCompletedParticles, method:  public System.Void UnityEngine.ParticleSystem::Play()));
            float val_14 = val_22 + 4.5f;
            DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_6, atPosition:  val_14, t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.background, endValue:  0f, duration:  0.2f));
            DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_6, atPosition:  val_14, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.EpisodeComplete.EpisodeCompletedDialog::<PlayAnimation>b__27_2()));
            float val_25 = 5f;
            val_25 = val_22 + val_25;
            DG.Tweening.Sequence val_19 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_6, atPosition:  val_25, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.EpisodeComplete.EpisodeCompletedDialog::<PlayAnimation>b__27_3()));
            DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_6, atPosition:  0.5f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.EpisodeComplete.EpisodeCompletedDialog::<PlayAnimation>b__27_4()));
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
        private void AnimateTapToSkipText()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.tapToContinue.transform, endValue:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, duration:  0.7f), ease:  4));
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, d:  1.1f);
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.tapToContinue.transform, endValue:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, duration:  0.7f), ease:  4));
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Sequence>(t:  val_1, loops:  0);
        }
        public void ContinueClicked()
        {
            if(this.continueEnabled == false)
            {
                    return;
            }
            
            if(this.continueClicked != false)
            {
                    return;
            }
            
            this.continueClicked = true;
            this.episodeCompletedParticles.transform.SetParent(p:  0);
            if(val_2.Length >= 1)
            {
                    var val_10 = 0;
                do
            {
                this.episodeCompletedParticles.GetComponentsInChildren<UnityEngine.ParticleSystem>()[val_10].gameObject.AddComponent<Royal.Infrastructure.Utils.Particles.ParticleSystemFadeOut>().FadeOut(seconds:  0.2f);
                val_10 = val_10 + 1;
            }
            while(val_10 < val_2.Length);
            
            }
            
            this.tapToContinue.gameObject.SetActive(value:  false);
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  DG.Tweening.DOTween.Sequence(), atPosition:  0.6f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.EpisodeComplete.EpisodeCompletedDialog::<ContinueClicked>b__30_0()));
        }
        public override Royal.Infrastructure.UiComponents.Dialog.DialogConfig GetConfig()
        {
            float val_2;
            bool val_3;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_0;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_1 = this.GetConfig();
            val_0.backgroundFadeAlpha = 0f;
            val_0.backgroundFadeOutDuration = val_2;
            val_0.shouldHideBackground = val_3;
            return val_0;
        }
        public EpisodeCompletedDialog()
        {
        
        }
        private void <PlayAnimation>b__27_0()
        {
            null = null;
            Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_this_arg.ArrangeTasksButtonAnimation();
            this.spineHolder.gameObject.SetActive(value:  true);
            UnityEngine.Vector3 val_2 = this.cameraManager.GetBottomCenterOfCamera();
            this.spineHolder.transform.position = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = 0f};
            this.SetBannerPositionForScreen();
            this.areaCompletedSkeleton.state.SetAnimation(trackIndex:  1, animation:  Spine.Unity.AnimationReferenceAsset.op_Implicit(asset:  this.areaCompletedAnimationRef), loop:  false) = 0;
            this.areaCompletedSkeleton.Update(deltaTime:  UnityEngine.Time.deltaTime);
        }
        private void <PlayAnimation>b__27_1()
        {
            float val_1 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  15f);
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_3 = DG.Tweening.ShortcutExtensions.DOLocalMoveX(target:  this.textMask.transform, endValue:  0f, duration:  val_1, snapping:  false);
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_5 = DG.Tweening.ShortcutExtensions.DOScaleX(target:  this.textMask.transform, endValue:  940f, duration:  val_1);
        }
        private void <PlayAnimation>b__27_2()
        {
            this.ArrangeMusicBack();
            this.completedText.SetActive(value:  false);
            this.areaCompletedSkeleton.gameObject.SetActive(value:  false);
            this.areaManager.<AreaView>k__BackingField.HideAllTasks();
        }
        private void <PlayAnimation>b__27_3()
        {
            OnReplayKilled val_2 = this.areaManager.<AreaView>k__BackingField.ReplayAnimations(isForPreviousArea:  false, onComplete:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.EpisodeComplete.EpisodeCompletedDialog::<PlayAnimation>b__27_5()));
        }
        private void <PlayAnimation>b__27_5()
        {
            this.continueEnabled = true;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  1.1f);
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_6 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.tapToContinue, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.3f), ease:  1), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.EpisodeComplete.EpisodeCompletedDialog::AnimateTapToSkipText()));
        }
        private void <PlayAnimation>b__27_4()
        {
            if(this.audioManager != null)
            {
                    this.audioManager.PlaySound(type:  2, offset:  0.04f);
                return;
            }
            
            throw new NullReferenceException();
        }
        private void <ContinueClicked>b__30_0()
        {
            UnityEngine.Object.Destroy(obj:  this.episodeCompletedParticles.gameObject);
        }
    
    }

}
