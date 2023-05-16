using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Star
{
    public class ShowStarDialogAction : DialogAction
    {
        // Fields
        private readonly Royal.Scenes.Home.Ui.Dialogs.Star.StarDialogType dialogType;
        private Royal.Scenes.Home.Ui.Dialogs.Star.StarDialog dialog;
        
        // Properties
        public override int Type { get; }
        
        // Methods
        public override int get_Type()
        {
            return 1;
        }
        public ShowStarDialogAction(Royal.Scenes.Home.Ui.Dialogs.Star.StarDialogType dialogType)
        {
            this.dialogType = dialogType;
        }
        public override void Execute()
        {
            var val_3;
            if((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.IsInLeague()) != false)
            {
                    val_3 = public System.Void Royal.Scenes.Start.Context.Units.Flow.FlowAction::Complete();
            }
            else
            {
                    Royal.Scenes.Home.Ui.Dialogs.Star.StarDialog val_2 = Royal.Infrastructure.UiComponents.Dialog.UiDialog.InstantiateFromResources<Royal.Scenes.Home.Ui.Dialogs.Star.StarDialog>(assetName:  "StarDialog", action:  this);
                this.dialog = val_2;
                val_2.Init(dialogType:  this.dialogType);
            }
        
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
