using UnityEngine;

namespace Royal.Scenes.Home.Context
{
    public class HomeContextController : MonoBehaviour
    {
        // Fields
        public UnityEngine.Camera homeCamera;
        public Royal.Scenes.Home.Ui.HomeUi homeUi;
        private Royal.Scenes.Home.Context.HomeContext homeContext;
        private Royal.Infrastructure.Contexts.Units.CameraManager cameraManager;
        private Royal.Scenes.Home.Context.Units.Area.AreaManager areaManager;
        
        // Methods
        private void Awake()
        {
            this.homeContext = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Home.Context.HomeContext>(id:  10);
            this.cameraManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            this.areaManager = Royal.Scenes.Home.Context.HomeContext.Get<Royal.Scenes.Home.Context.Units.Area.AreaManager>(id:  0);
            this.Activate();
        }
        private void Activate()
        {
            this.cameraManager.SetSceneCamera(camera:  this.homeCamera);
            if((this.areaManager.<AreaView>k__BackingField) == 0)
            {
                    this.areaManager.CreateAreaView();
            }
            
            this.homeContext.Activate(controller:  this);
        }
        private void OnDestroy()
        {
            if(this.homeContext != null)
            {
                    this.homeContext.Deactivate();
                return;
            }
            
            throw new NullReferenceException();
        }
        public void PrepareUiForGame()
        {
            Royal.Scenes.Home.Context.Units.Area.AreaManager val_1 = Royal.Scenes.Home.Context.HomeContext.Get<Royal.Scenes.Home.Context.Units.Area.AreaManager>(id:  0);
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Dialog.DialogManager>(id:  13).CloseDialog(uiDialog:  0, fast:  false);
            Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.HideText();
        }
        public void ChangeSection(Royal.Scenes.Home.Ui.Sections.SectionType section)
        {
            this.homeUi.sectionManager.ChangeSection(type:  section);
        }
        public void PlayHomeUiAppearAnimation()
        {
            if(this.homeUi != null)
            {
                    this.homeUi.PlayHomeUiAppearAnimation();
                return;
            }
            
            throw new NullReferenceException();
        }
        public void PlayHomeUiHideAnimation()
        {
            if(this.homeUi != null)
            {
                    this.homeUi.PlayHomeUiHideAnimation();
                return;
            }
            
            throw new NullReferenceException();
        }
        public void HideHomeUiWithoutAnimation()
        {
            if(this.homeUi != null)
            {
                    this.homeUi.HideHomeUiWithoutAnimation();
                return;
            }
            
            throw new NullReferenceException();
        }
        public HomeContextController()
        {
        
        }
    
    }

}
