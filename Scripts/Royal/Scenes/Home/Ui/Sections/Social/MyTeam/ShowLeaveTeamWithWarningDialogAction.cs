using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Social.MyTeam
{
    public class ShowLeaveTeamWithWarningDialogAction : DialogAction
    {
        // Fields
        private Royal.Scenes.Home.Ui.Sections.Social.MyTeam.LeaveTeamWithWarning dialog;
        private readonly System.Action onConfirm;
        
        // Properties
        public override int Type { get; }
        
        // Methods
        public override int get_Type()
        {
            return 2;
        }
        public ShowLeaveTeamWithWarningDialogAction(System.Action onConfirm)
        {
            this.onConfirm = onConfirm;
        }
        public override void Execute()
        {
            Royal.Scenes.Home.Ui.Sections.Social.MyTeam.LeaveTeamWithWarning val_1 = Royal.Infrastructure.UiComponents.Dialog.UiDialog.InstantiateFromResources<Royal.Scenes.Home.Ui.Sections.Social.MyTeam.LeaveTeamWithWarning>(assetName:  "LeaveTeamWithWarning", action:  this);
            this.dialog = val_1;
            val_1.Show(confirm:  this.onConfirm);
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
            if(this.dialog != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
    
    }

}
