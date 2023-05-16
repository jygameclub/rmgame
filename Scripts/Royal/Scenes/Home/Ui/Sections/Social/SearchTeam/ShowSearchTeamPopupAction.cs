using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Social.SearchTeam
{
    public class ShowSearchTeamPopupAction : FlowAction
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
            Royal.Infrastructure.Contexts.Units.CameraManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            Royal.Infrastructure.UiComponents.Dialog.UiPopup.Instantiate<Royal.Scenes.Home.Ui.Sections.Social.SearchTeam.SearchTeamPopup>(assetName:  "SearchTeamPopup", parent:  val_1.camera.transform, action:  this).Show();
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
        
        }
        public ShowSearchTeamPopupAction()
        {
            val_1 = new System.Object();
        }
    
    }

}
