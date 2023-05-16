using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.BuyBooster
{
    public class ShowBuyBoosterDialogAction : DialogAction
    {
        // Fields
        private readonly Royal.Scenes.Start.Context.Units.Flow.DialogOriginType <OriginType>k__BackingField;
        private readonly Royal.Scenes.Game.Mechanics.Boosters.BoosterType boosterType;
        private Royal.Scenes.Home.Ui.Dialogs.BuyBooster.BuyBoosterDialog dialog;
        
        // Properties
        public override Royal.Scenes.Start.Context.Units.Flow.DialogOriginType OriginType { get; }
        public override int Type { get; }
        
        // Methods
        public override Royal.Scenes.Start.Context.Units.Flow.DialogOriginType get_OriginType()
        {
            return (Royal.Scenes.Start.Context.Units.Flow.DialogOriginType)this.<OriginType>k__BackingField;
        }
        public override int get_Type()
        {
            return 1;
        }
        public ShowBuyBoosterDialogAction(Royal.Scenes.Game.Mechanics.Boosters.BoosterType type, Royal.Scenes.Start.Context.Units.Flow.DialogOriginType origin = 0)
        {
            this.<OriginType>k__BackingField = origin;
            this.boosterType = type;
        }
        public override void Execute()
        {
            Royal.Scenes.Home.Ui.Dialogs.BuyBooster.BuyBoosterDialog val_1 = Royal.Infrastructure.UiComponents.Dialog.UiDialog.Instantiate<Royal.Scenes.Home.Ui.Dialogs.BuyBooster.BuyBoosterDialog>(asset:  0, action:  this);
            this.dialog = val_1;
            val_1.Init(type:  this.boosterType);
            goto typeof(Royal.Scenes.Home.Ui.Dialogs.BuyBooster.BuyBoosterDialog).__il2cppRuntimeField_240;
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
