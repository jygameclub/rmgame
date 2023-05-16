using UnityEngine;

namespace Royal.Scenes.Game.Ui.Dialogs.LevelFail
{
    public class ShowOutOfMovesBannerAction : DialogAction
    {
        // Properties
        public override int Type { get; }
        
        // Methods
        public override int get_Type()
        {
            return 2;
        }
        public override void Execute()
        {
            string val_6;
            var val_7;
            if(IsLeague == false)
            {
                goto label_5;
            }
            
            val_6 = "LeagueOutOfMovesBanner";
            val_7 = public static Royal.Scenes.Game.Ui.Dialogs.LevelFail.OutOfMovesBanner Royal.Infrastructure.UiComponents.Dialog.UiDialog::InstantiateFromResources<Royal.Scenes.Game.Ui.Dialogs.LevelFail.OutOfMovesBanner>(string assetName, Royal.Scenes.Start.Context.Units.Flow.DialogAction action);
            goto label_6;
            label_5:
            if(IsHard == false)
            {
                goto label_7;
            }
            
            val_6 = mem[Royal.Player.Context.Data.Session.__il2cppRuntimeField_2C == 0x1 ? "HardOutOfMovesBanner" : "SuperHardOutOfMovesBanner"];
            val_6 = (Royal.Player.Context.Data.Session.__il2cppRuntimeField_2C == 1) ? "HardOutOfMovesBanner" : "SuperHardOutOfMovesBanner";
            val_7 = public static Royal.Scenes.Game.Ui.Dialogs.LevelFail.OutOfMovesBanner Royal.Infrastructure.UiComponents.Dialog.UiDialog::InstantiateFromResources<Royal.Scenes.Game.Ui.Dialogs.LevelFail.OutOfMovesBanner>(string assetName, Royal.Scenes.Start.Context.Units.Flow.DialogAction action);
            label_6:
            if((Royal.Infrastructure.UiComponents.Dialog.UiDialog.InstantiateFromResources<Royal.Scenes.Game.Ui.Dialogs.LevelFail.OutOfMovesBanner>(assetName:  val_6, action:  this)) != null)
            {
                goto typeof(Royal.Scenes.Game.Ui.Dialogs.LevelFail.OutOfMovesBanner).__il2cppRuntimeField_240;
            }
            
            label_7:
            Royal.Scenes.Game.Ui.Dialogs.LevelFail.OutOfMovesBanner val_5 = Royal.Infrastructure.UiComponents.Dialog.UiDialog.Instantiate<Royal.Scenes.Game.Ui.Dialogs.LevelFail.OutOfMovesBanner>(asset:  Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_element_class + 32, action:  this);
            goto typeof(Royal.Scenes.Game.Ui.Dialogs.LevelFail.OutOfMovesBanner).__il2cppRuntimeField_240;
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
        
        }
        public ShowOutOfMovesBannerAction()
        {
        
        }
    
    }

}
