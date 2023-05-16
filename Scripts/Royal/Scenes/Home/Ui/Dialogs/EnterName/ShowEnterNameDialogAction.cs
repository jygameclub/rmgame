using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.EnterName
{
    public class ShowEnterNameDialogAction : DialogAction
    {
        // Fields
        private readonly string origin;
        private readonly bool changeName;
        private readonly string controlName;
        private readonly int <Type>k__BackingField;
        
        // Properties
        public override int Type { get; }
        
        // Methods
        public override int get_Type()
        {
            return (int)this.<Type>k__BackingField;
        }
        public ShowEnterNameDialogAction(bool changeName = False, string controlName)
        {
            this.controlName = controlName;
            this.changeName = changeName;
            this.<Type>k__BackingField = 2;
        }
        public ShowEnterNameDialogAction(string origin, int type)
        {
            this.origin = origin;
            this.<Type>k__BackingField = type;
        }
        public override void Execute()
        {
            Royal.Infrastructure.UiComponents.Dialog.UiDialog.InstantiateFromResources<Royal.Scenes.Home.Ui.Dialogs.EnterName.EnterNameDialog>(assetName:  "EnterNameDialog", action:  this).Show(change:  this.changeName, firstName:  this.controlName, origin:  this.origin);
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
        
        }
    
    }

}
