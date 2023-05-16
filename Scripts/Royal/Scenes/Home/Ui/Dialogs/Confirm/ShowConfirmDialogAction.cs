using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Confirm
{
    public class ShowConfirmDialogAction : DialogAction
    {
        // Fields
        private Royal.Scenes.Home.Ui.Dialogs.Confirm.ConfirmDialog dialog;
        private readonly string title;
        private readonly string message;
        private readonly string yesString;
        private readonly string noString;
        private readonly System.Action onConfirm;
        
        // Properties
        public override int Type { get; }
        
        // Methods
        public override int get_Type()
        {
            return 2;
        }
        public ShowConfirmDialogAction(string title, string message, System.Action onConfirm)
        {
            this.title = title;
            this.message = message;
            this.onConfirm = onConfirm;
            this.yesString = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Yes");
            this.noString = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "No");
        }
        public ShowConfirmDialogAction(string title, string message, string yesString, string noString, System.Action onConfirm)
        {
            this.title = title;
            this.message = message;
            this.noString = noString;
            this.onConfirm = onConfirm;
            this.yesString = yesString;
        }
        public override void Execute()
        {
            Royal.Scenes.Home.Ui.Dialogs.Confirm.ConfirmDialog val_1 = Royal.Infrastructure.UiComponents.Dialog.UiDialog.InstantiateFromResources<Royal.Scenes.Home.Ui.Dialogs.Confirm.ConfirmDialog>(assetName:  "ConfirmDialog", action:  this);
            this.dialog = val_1;
            val_1.Show(title:  this.title, message:  this.message, yesString:  this.yesString, noString:  this.noString, confirm:  this.onConfirm);
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
