using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Life
{
    public sealed class ShowOutOfLivesDialogAction : DialogAction
    {
        // Fields
        private Royal.Scenes.Home.Ui.Dialogs.Life.OutOfLivesDialog dialog;
        private readonly Royal.Scenes.Start.Context.Units.Flow.DialogOriginType <OriginType>k__BackingField;
        
        // Properties
        public override Royal.Scenes.Start.Context.Units.Flow.DialogOriginType OriginType { get; }
        public override int Type { get; }
        
        // Methods
        public override Royal.Scenes.Start.Context.Units.Flow.DialogOriginType get_OriginType()
        {
            return (Royal.Scenes.Start.Context.Units.Flow.DialogOriginType)this.<OriginType>k__BackingField;
        }
        public ShowOutOfLivesDialogAction(Royal.Scenes.Start.Context.Units.Flow.DialogOriginType originType)
        {
            this.<OriginType>k__BackingField = originType;
        }
        public override int get_Type()
        {
            return 2;
        }
        public override void Execute()
        {
            if(IsLeague == false)
            {
                goto label_5;
            }
            
            Royal.Scenes.Home.Ui.Dialogs.Life.OutOfLivesDialog val_2 = Royal.Infrastructure.UiComponents.Dialog.UiDialog.InstantiateFromResources<Royal.Scenes.Home.Ui.Dialogs.Life.OutOfLivesDialog>(assetName:  "LeagueOutOfLivesDialog", action:  this);
            goto label_8;
            label_5:
            if(IsHard == false)
            {
                goto label_7;
            }
            
            Royal.Scenes.Home.Ui.Dialogs.Life.OutOfLivesDialog val_5 = Royal.Infrastructure.UiComponents.Dialog.UiDialog.InstantiateFromResources<Royal.Scenes.Home.Ui.Dialogs.Life.OutOfLivesDialog>(assetName:  (Royal.Player.Context.Data.Session.__il2cppRuntimeField_2C == 1) ? "HardOutOfLivesDialog" : "SuperHardOutOfLivesDialog", action:  this);
            if(this != null)
            {
                goto label_8;
            }
            
            label_7:
            label_8:
            this.dialog = Royal.Infrastructure.UiComponents.Dialog.UiDialog.Instantiate<Royal.Scenes.Home.Ui.Dialogs.Life.OutOfLivesDialog>(asset:  Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_castClass + 40, action:  this);
            goto typeof(Royal.Scenes.Home.Ui.Dialogs.Life.OutOfLivesDialog).__il2cppRuntimeField_240;
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
