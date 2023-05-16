using UnityEngine;

namespace Royal.Scenes.Game.Ui.Dialogs.LevelFail
{
    public class StoryLevelFailDialog : UiDialog
    {
        // Fields
        public UnityEngine.Transform root;
        private Royal.Scenes.Start.Context.Units.FeatureBundle.KingDrillBundle kingDrillBundle;
        
        // Methods
        private void Awake()
        {
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16).PlaySound(type:  150, offset:  0.04f);
            this.kingDrillBundle = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleManager>(id:  25).GetBundle(bundleType:  3);
            this.SetBundledPrefabInstance();
        }
        public void Play()
        {
            bool val_2 = Royal.Scenes.Game.Context.GameContext.Get<Royal.Scenes.Game.Context.Units.GameManager>(id:  1).RestartGameWhenPossible();
            goto typeof(Royal.Scenes.Game.Ui.Dialogs.LevelFail.StoryLevelFailDialog).__il2cppRuntimeField_250;
        }
        public void Skip()
        {
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Analytics.AnalyticsManager>(id:  17).SkipStoryLevel();
            SetStoryLevel();
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.UserManager>(id:  1).SendDataToBackend(forceToSend:  false, forceScoreData:  false);
            Royal.Scenes.Game.Context.GameContext.Get<Royal.Scenes.Game.Context.Units.GameManager>(id:  1).ExitGameWhenPossible();
        }
        public void Exit()
        {
            Royal.Scenes.Game.Context.GameContext.Get<Royal.Scenes.Game.Context.Units.GameManager>(id:  1).ExitGameWhenPossible();
        }
        private void SetBundledPrefabInstance()
        {
            UnityEngine.GameObject val_2 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.kingDrillBundle.StoryFailDialogBundledSubPrefab, parent:  this.root);
        }
        private void OnDestroy()
        {
            if(this.kingDrillBundle != null)
            {
                    this.kingDrillBundle.RemoveFailDialogBundledSubPrefabReference();
                return;
            }
            
            throw new NullReferenceException();
        }
        public StoryLevelFailDialog()
        {
        
        }
    
    }

}
