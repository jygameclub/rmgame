using UnityEngine;

namespace Royal.Scenes.Game.Context
{
    public class GameContextController : MonoBehaviour
    {
        // Fields
        public UnityEngine.Camera gameCamera;
        public Royal.Scenes.Game.Ui.GameUi gameUi;
        private Royal.Scenes.Game.Ui.SpecialLevelAssets specialLevelAssets;
        private Royal.Scenes.Game.Context.GameContext gameContext;
        private Royal.Infrastructure.Contexts.Units.CameraManager cameraManager;
        private Royal.Scenes.Home.Context.Units.Area.AreaManager areaManager;
        
        // Methods
        private void Awake()
        {
            this.gameContext = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Game.Context.GameContext>(id:  11);
            this.cameraManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            this.areaManager = Royal.Scenes.Home.Context.HomeContext.Get<Royal.Scenes.Home.Context.Units.Area.AreaManager>(id:  0);
            this.Activate();
        }
        private void Activate()
        {
            this.cameraManager.SetSceneCamera(camera:  this.gameCamera);
            if((this.areaManager.<AreaView>k__BackingField) == 0)
            {
                    this.areaManager.CreateAreaView();
            }
            
            this.gameContext.Activate(controller:  this);
        }
        private void LateUpdate()
        {
            Royal.Scenes.Game.Context.GameContext.ManualLateUpdate();
        }
        public void PrepareUiForHome()
        {
            this.gameUi.gameObject.SetActive(value:  false);
            Royal.Scenes.Home.Context.Units.Area.AreaManager val_2 = Royal.Scenes.Home.Context.HomeContext.Get<Royal.Scenes.Home.Context.Units.Area.AreaManager>(id:  0);
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Dialog.DialogManager>(id:  13).CloseDialog(uiDialog:  0, fast:  false);
            Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.HideText();
        }
        public Royal.Scenes.Game.Ui.SpecialLevelAssets GetLeagueLevelAssets()
        {
            Royal.Scenes.Game.Ui.SpecialLevelAssets val_3;
            if(this.specialLevelAssets != 0)
            {
                    val_3 = this.specialLevelAssets;
                return val_2;
            }
            
            Royal.Scenes.Game.Ui.SpecialLevelAssets val_2 = UnityEngine.Resources.Load<Royal.Scenes.Game.Ui.SpecialLevelAssets>(path:  "LeagueLevelAssets");
            this.specialLevelAssets = val_2;
            return val_2;
        }
        public Royal.Scenes.Game.Ui.SpecialLevelAssets GetHardLevelAssets(sbyte difficulty)
        {
            Royal.Scenes.Game.Ui.SpecialLevelAssets val_5;
            if(this.specialLevelAssets != 0)
            {
                    val_5 = this.specialLevelAssets;
                return val_4;
            }
            
            Royal.Scenes.Game.Ui.SpecialLevelAssets val_4 = UnityEngine.Resources.Load<Royal.Scenes.Game.Ui.SpecialLevelAssets>(path:  ((difficulty & 255) == 1) ? "HardLevelAssets" : "SuperHardLevelAssets");
            this.specialLevelAssets = val_4;
            return val_4;
        }
        public GameContextController()
        {
        
        }
    
    }

}
