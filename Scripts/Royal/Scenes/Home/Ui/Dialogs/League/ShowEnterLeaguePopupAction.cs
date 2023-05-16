using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.League
{
    public class ShowEnterLeaguePopupAction : FlowAction
    {
        // Properties
        public override int Type { get; }
        
        // Methods
        public override int get_Type()
        {
            return 2;
        }
        public override void Execute()
        {
            var val_8;
            Royal.Scenes.Home.Context.Units.Area.AreaManager val_1 = Royal.Scenes.Home.Context.HomeContext.Get<Royal.Scenes.Home.Context.Units.Area.AreaManager>(id:  0);
            val_1.<AreaView>k__BackingField.StopBackgroundSounds();
            Royal.Infrastructure.Contexts.Units.CameraManager val_2 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            if(val_2.IsDeviceTall() == false)
            {
                goto label_8;
            }
            
            val_8 = "EnterLeaguePopupForTallDevices";
            if(val_2.camera != null)
            {
                goto label_9;
            }
            
            label_8:
            string val_5 = (val_2.IsDeviceWide() != true) ? "EnterLeaguePopupForWideDevices" : "EnterLeaguePopupForOtherDevices";
            label_9:
            Royal.Infrastructure.UiComponents.Dialog.UiPopup.Instantiate<Royal.Scenes.Home.Ui.Dialogs.League.EnterLeaguePopup>(assetName:  val_5, parent:  val_2.camera.transform, action:  this).Show(prefabName:  val_5);
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
        
        }
        public ShowEnterLeaguePopupAction()
        {
        
        }
    
    }

}
