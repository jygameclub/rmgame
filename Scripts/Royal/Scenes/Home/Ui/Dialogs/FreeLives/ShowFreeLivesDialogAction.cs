using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.FreeLives
{
    public sealed class ShowFreeLivesDialogAction : DialogAction
    {
        // Fields
        private Royal.Scenes.Home.Ui.Dialogs.FreeLives.FreeLivesDialog dialog;
        private readonly Royal.Scenes.Start.Context.Units.Flow.DialogOriginType <OriginType>k__BackingField;
        
        // Properties
        public override Royal.Scenes.Start.Context.Units.Flow.DialogOriginType OriginType { get; }
        public override int Type { get; }
        
        // Methods
        public override Royal.Scenes.Start.Context.Units.Flow.DialogOriginType get_OriginType()
        {
            return (Royal.Scenes.Start.Context.Units.Flow.DialogOriginType)this.<OriginType>k__BackingField;
        }
        public ShowFreeLivesDialogAction(Royal.Scenes.Start.Context.Units.Flow.DialogOriginType originType)
        {
            this.<OriginType>k__BackingField = originType;
        }
        public override int get_Type()
        {
            return 2;
        }
        public override void Execute()
        {
            this.dialog = Royal.Infrastructure.UiComponents.Dialog.UiDialog.InstantiateFromResources<Royal.Scenes.Home.Ui.Dialogs.FreeLives.FreeLivesDialog>(assetName:  "FreeLivesDialog", action:  this);
            goto typeof(Royal.Scenes.Home.Ui.Dialogs.FreeLives.FreeLivesDialog).__il2cppRuntimeField_240;
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
