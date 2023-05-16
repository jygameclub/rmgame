using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.AreaUnlocked
{
    public class AreaUnlockedDialog : UiDialog
    {
        // Fields
        public UnityEngine.ParticleSystem areaUnlockParticlesPrefab;
        public UnityEngine.SpriteRenderer areaImage;
        public TMPro.TextMeshPro areaTitle;
        public Royal.Infrastructure.UiComponents.UiSpinner spinner;
        private int nextAreaId;
        private Royal.Infrastructure.UiComponents.Touch.UiTouchListener uiTouchListener;
        private Royal.Scenes.Home.Context.Units.AssetBundles.AssetBundleHelper assetBundleHelper;
        
        // Methods
        private void Start()
        {
            this.uiTouchListener = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            this.nextAreaId = 1152921509031073873;
            Royal.Scenes.Home.Context.Units.Area.Config.AreaConfig val_3 = Royal.Scenes.Home.Context.HomeContext.Get<Royal.Scenes.Home.Context.Units.Area.AreaManager>(id:  0).LoadConfig(id:  129259601);
            this.areaTitle.SetText(sourceText:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  val_3.areaName), syncTextInputBox:  true);
            this.areaImage.sprite = Royal.Scenes.Home.Episodes.Scripts.EpisodeAssetsLibrary.Instance.GetEmptySpriteForEpisode(episodeNo:  val_3.areaId);
        }
        public void Continue()
        {
            Royal.Scenes.Home.Context.Units.AssetBundles.AssetBundleHelper val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Home.Context.Units.AssetBundles.AssetBundleHelper>(id:  8);
            this.assetBundleHelper = val_1;
            if((val_1.TryLoadArea(areaNo:  this.nextAreaId, onLoaded:  0)) != false)
            {
                    this.ShowNewArea();
                return;
            }
            
            this.EnableTouches(enable:  false);
            this.spinner.Show();
            this.assetBundleHelper.DownloadAreaBundle(areaNo:  this.nextAreaId, onSuccess:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.AreaUnlocked.AreaUnlockedDialog::AreaBundleLoadSuccess()), onFail:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.AreaUnlocked.AreaUnlockedDialog::AreaBundleLoadFail()));
        }
        private void AreaBundleLoadSuccess()
        {
            if(this.spinner != 0)
            {
                    this.spinner.Hide();
            }
            
            this.EnableTouches(enable:  true);
            this.ShowNewArea();
        }
        private void AreaBundleLoadFail()
        {
            if(this.spinner != 0)
            {
                    this.spinner.Hide();
            }
            
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).Push(action:  new Royal.Scenes.Home.Ui.Dialogs.AreaDownloadFail.AreaDownloadFailAction(isAtAreaUnlock:  true, isAtAreaLoad:  false));
            object[] val_4 = new object[1];
            val_4[0] = this.nextAreaId;
            Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  22, log:  "Area can\'t be downloaded (AreaBundleLoadFail): {0}", values:  val_4);
            this.EnableTouches(enable:  true);
        }
        private void EnableTouches(bool enable)
        {
            if(enable != false)
            {
                    this.uiTouchListener.disabler.EnableTouch();
                this = ???;
            }
            
            this.uiTouchListener.disabler.DisableTouch();
            var val_1 = (val_6 + 80) + 64;
            var val_4 = (val_6 + 80) + 64;
            throw new NullReferenceException();
        }
        private void ShowNewArea()
        {
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16).PlaySound(type:  6, offset:  0.04f);
            UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.identity;
            UnityEngine.ParticleSystem val_3 = UnityEngine.Object.Instantiate<UnityEngine.ParticleSystem>(original:  this.areaUnlockParticlesPrefab, position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, rotation:  new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w});
            val_3.Play();
            UnityEngine.Coroutine val_6 = Royal.Scenes.Start.Context.ApplicationContext.ManualStartCoroutine(iEnumerator:  Royal.Scenes.Home.Ui.Dialogs.AreaUnlocked.AreaUnlockedDialog.DestroyParticles(particles:  val_3.gameObject));
            Royal.Scenes.Home.Context.HomeContext.Get<Royal.Scenes.Home.Context.Units.Area.AreaManager>(id:  0).UnlockNextArea();
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).Push(action:  new Royal.Scenes.Home.Ui.Sections.Home.Buttons.PlayNotificationAnimationAction(delay:  0.6f));
        }
        private static System.Collections.IEnumerator DestroyParticles(UnityEngine.Object particles)
        {
            .<>1__state = 0;
            .particles = particles;
            return (System.Collections.IEnumerator)new AreaUnlockedDialog.<DestroyParticles>d__13();
        }
        public override void OnClose(System.Action dialogClosed)
        {
            this.OnClose(dialogClosed:  dialogClosed);
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16).ResumeHomeMusic();
        }
        public void CloseButtonClicked()
        {
            goto typeof(Royal.Scenes.Home.Ui.Dialogs.AreaUnlocked.AreaUnlockedDialog).__il2cppRuntimeField_2C0;
        }
        public override void CloseOnEscape()
        {
            null = null;
            Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_this_arg.ArrangeTasksButtonAnimation();
            goto typeof(Royal.Scenes.Home.Ui.Dialogs.AreaUnlocked.AreaUnlockedDialog).__il2cppRuntimeField_250;
        }
        public override Royal.Infrastructure.UiComponents.Dialog.DialogConfig GetConfig()
        {
            bool val_2;
            float val_3;
            bool val_4;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_0;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_1 = this.GetConfig();
            val_0.shouldCloseOnEscape = true;
            val_0.shouldHideBackground = val_2;
            val_0.backgroundFadeInDuration = val_3;
            val_0.shouldCloseOnTouch = val_4;
            return val_0;
        }
        public AreaUnlockedDialog()
        {
        
        }
    
    }

}
