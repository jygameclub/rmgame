using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.KingsCup
{
    public class ShowKingsCupInfoDialogAction : DialogAction
    {
        // Fields
        private readonly bool userAction;
        private readonly int <Type>k__BackingField;
        
        // Properties
        public override int Type { get; }
        
        // Methods
        public override int get_Type()
        {
            return (int)this.<Type>k__BackingField;
        }
        public ShowKingsCupInfoDialogAction(bool userAction)
        {
            this.userAction = userAction;
            this.<Type>k__BackingField = ((userAction & true) != 0) ? (2 + 1) : 2;
        }
        public override void Execute()
        {
            Royal.Scenes.Start.Context.Units.Flow.DialogAction val_10;
            var val_11;
            val_10 = this;
            val_11 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.KingsCupManager>(id:  7);
            if((val_1.newUnlimitedLifeTimeMs == 0) && (val_11.IsInAGroup != false))
            {
                    Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupInfoDialogEntered val_3 = Royal.Infrastructure.UiComponents.Dialog.UiDialog.InstantiateFromResources<Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupInfoDialogEntered>(assetName:  "KingsCupInfoDialogEntered", action:  this);
                val_11 = ???;
                val_10 = ???;
            }
            else
            {
                    Royal.Infrastructure.UiComponents.Dialog.UiDialog.InstantiateFromResources<Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupInfoDialogEnter>(assetName:  "KingsCupInfoDialogEnter", action:  val_10).Show(userAction:  val_10 + 32, animateProgressBar:  ((val_11 + 32) > 0) ? 1 : 0);
            }
        
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
        
        }
    
    }

}
