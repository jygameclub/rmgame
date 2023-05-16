using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Prelevel
{
    public class StoryPrelevelDialog : UiDialog
    {
        // Fields
        public UnityEngine.GameObject justPlayButton;
        public UnityEngine.GameObject playAndSkipButton;
        public UnityEngine.GameObject backgroundLeftColumn;
        public UnityEngine.GameObject backgroundRightColumn;
        public UnityEngine.Transform root;
        private Royal.Player.Context.Units.LevelManager levelManager;
        private Royal.Scenes.Start.Context.Units.FeatureBundle.KingDrillBundle kingDrillBundle;
        
        // Methods
        private void Awake()
        {
            Royal.Player.Context.Units.LevelManager val_1 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LevelManager>(id:  2);
            this.levelManager = val_1;
            val_1.LevelLoad();
            int val_2 = StoryLevelTryCount;
            this.justPlayButton.SetActive(value:  (val_2 < 1) ? 1 : 0);
            this.playAndSkipButton.SetActive(value:  (val_2 > 0) ? 1 : 0);
            if(val_2 >= 1)
            {
                    this.SetPositionsForSkip();
            }
            
            this.kingDrillBundle = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleManager>(id:  25).GetBundle(bundleType:  3);
            this.SetBundledPrefabInstance();
        }
        private void SetPositionsForSkip()
        {
            this.backgroundLeftColumn.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.backgroundRightColumn.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.playAndSkipButton.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        public override Royal.Infrastructure.UiComponents.Dialog.DialogConfig GetConfig()
        {
            bool val_2;
            float val_3;
            bool val_4;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_0;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_1 = this.GetConfig();
            val_0.shouldCloseOnEscape = true;
            val_0.shouldCloseOnTouch = true;
            val_0.shouldHideBackground = val_2;
            val_0.backgroundFadeInDuration = val_3;
            val_0.shouldCloseOnSwipe = val_4;
            return val_0;
        }
        public void Play()
        {
            if(this.levelManager != null)
            {
                    this.levelManager.LevelStart();
                return;
            }
            
            throw new NullReferenceException();
        }
        public void Skip()
        {
            var val_3;
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Analytics.AnalyticsManager>(id:  17).SkipStoryLevel();
            SetStoryLevel();
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.UserManager>(id:  1).SendDataToBackend(forceToSend:  false, forceScoreData:  false);
            this.levelManager.ResourcesLoad();
            val_3 = null;
            val_3 = null;
            Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_this_arg.PrepareLevelButton();
            goto typeof(Royal.Scenes.Home.Ui.Dialogs.Prelevel.StoryPrelevelDialog).__il2cppRuntimeField_250;
        }
        private void SetBundledPrefabInstance()
        {
            UnityEngine.GameObject val_2 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.kingDrillBundle.StoryPrelevelBundledSubPrefab, parent:  this.root);
        }
        private void OnDestroy()
        {
            if(this.kingDrillBundle != null)
            {
                    this.kingDrillBundle.RemovePrelevelBundledSubPrefabReference();
                return;
            }
            
            throw new NullReferenceException();
        }
        public StoryPrelevelDialog()
        {
        
        }
    
    }

}
