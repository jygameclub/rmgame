using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.PiggyBank
{
    public class ShowPiggyBankStatusDialogAction : DialogAction
    {
        // Fields
        private Royal.Scenes.Home.Ui.Dialogs.PiggyBank.PiggyBankStatusDialog dialog;
        private readonly Royal.Infrastructure.UiComponents.Touch.UiTouchListener uiTouchListener;
        private readonly bool disableTouch;
        private readonly Royal.Player.Context.Units.PiggyBankStatusDialogType piggyBankStatusDialogType;
        private readonly int <Type>k__BackingField;
        
        // Properties
        public override int Type { get; }
        
        // Methods
        public override int get_Type()
        {
            return (int)this.<Type>k__BackingField;
        }
        public ShowPiggyBankStatusDialogAction(bool disableTouch = False, bool newPiggy = False, bool fromAnotherDialog = False)
        {
            var val_5;
            this.<Type>k__BackingField = ((fromAnotherDialog & true) != 0) ? 3 : (0 + 1);
            this.disableTouch = disableTouch;
            if(newPiggy != false)
            {
                    val_5 = 0;
            }
            
            this.piggyBankStatusDialogType = Royal.Player.Context.Units.PiggyBankManager.GetPiggyBankStatusDialogTypeByAmount();
            this.uiTouchListener = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            if(disableTouch == false)
            {
                    return;
            }
            
            this.uiTouchListener.disabler.DisableTouch();
        }
        public override void Execute()
        {
            Royal.Scenes.Home.Ui.Dialogs.PiggyBank.PiggyBankStatusDialog val_1 = Royal.Infrastructure.UiComponents.Dialog.UiDialog.InstantiateFromResources<Royal.Scenes.Home.Ui.Dialogs.PiggyBank.PiggyBankStatusDialog>(assetName:  "PiggyBankStatusDialog", action:  this);
            this.dialog = val_1;
            val_1.Init(type:  this.piggyBankStatusDialogType);
            if(this.disableTouch == false)
            {
                    return;
            }
            
            this.uiTouchListener.disabler.EnableTouch();
            this = ???;
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
