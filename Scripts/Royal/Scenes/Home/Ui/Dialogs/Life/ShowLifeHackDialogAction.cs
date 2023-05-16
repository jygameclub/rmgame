using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Life
{
    public class ShowLifeHackDialogAction : DialogAction
    {
        // Fields
        private readonly int hackLevel;
        
        // Properties
        public override int Type { get; }
        
        // Methods
        public override int get_Type()
        {
            return 2;
        }
        public ShowLifeHackDialogAction(int hackLevel)
        {
            this.hackLevel = hackLevel;
        }
        public override void Execute()
        {
            Royal.Infrastructure.UiComponents.Dialog.UiDialog.InstantiateFromResources<Royal.Scenes.Home.Ui.Dialogs.Life.LifeHackDialog>(assetName:  "LifeHackDialog", action:  this).Show(hackLevel:  this.hackLevel);
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
        
        }
    
    }

}
