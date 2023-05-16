using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Life
{
    public sealed class ShowMoreLivesDialogAction : DialogAction
    {
        // Fields
        private Royal.Scenes.Home.Ui.Dialogs.Life.MoreLivesDialog dialog;
        private readonly Royal.Scenes.Start.Context.Units.Flow.DialogOriginType <OriginType>k__BackingField;
        
        // Properties
        public override Royal.Scenes.Start.Context.Units.Flow.DialogOriginType OriginType { get; }
        public override int Type { get; }
        
        // Methods
        public override Royal.Scenes.Start.Context.Units.Flow.DialogOriginType get_OriginType()
        {
            return (Royal.Scenes.Start.Context.Units.Flow.DialogOriginType)this.<OriginType>k__BackingField;
        }
        public ShowMoreLivesDialogAction(Royal.Scenes.Start.Context.Units.Flow.DialogOriginType originType)
        {
            this.<OriginType>k__BackingField = originType;
        }
        public override int get_Type()
        {
            return 2;
        }
        public override void Execute()
        {
            Royal.Scenes.Home.Ui.Dialogs.Life.MoreLivesDialog val_1 = Royal.Infrastructure.UiComponents.Dialog.UiDialog.InstantiateFromResources<Royal.Scenes.Home.Ui.Dialogs.Life.MoreLivesDialog>(assetName:  "MoreLivesDialog", action:  this);
            this.dialog = val_1;
            val_1 = this;
            goto typeof(Royal.Scenes.Home.Ui.Dialogs.Life.MoreLivesDialog).__il2cppRuntimeField_240;
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
