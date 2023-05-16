using UnityEngine;

namespace Royal.Scenes.Game.Ui.Dialogs.LevelWin
{
    public class ShowLevelWinDialogAction : DialogAction
    {
        // Methods
        public override void Execute()
        {
            var val_6;
            string val_7;
            var val_8;
            val_6 = null;
            val_6 = null;
            ResetSorting();
            if(IsLeague == false)
            {
                goto label_13;
            }
            
            val_7 = "LeagueLevelWinDialog";
            val_8 = public static Royal.Scenes.Game.Ui.Dialogs.LevelWin.LevelWinDialog Royal.Infrastructure.UiComponents.Dialog.UiDialog::InstantiateFromResources<Royal.Scenes.Game.Ui.Dialogs.LevelWin.LevelWinDialog>(string assetName, Royal.Scenes.Start.Context.Units.Flow.DialogAction action);
            goto label_14;
            label_13:
            if(IsHard == false)
            {
                goto label_15;
            }
            
            val_7 = mem[Royal.Player.Context.Data.Session.__il2cppRuntimeField_2C == 0x1 ? "HardLevelWinDialog" : "SuperHardLevelWinDialog"];
            val_7 = (Royal.Player.Context.Data.Session.__il2cppRuntimeField_2C == 1) ? "HardLevelWinDialog" : "SuperHardLevelWinDialog";
            val_8 = public static Royal.Scenes.Game.Ui.Dialogs.LevelWin.LevelWinDialog Royal.Infrastructure.UiComponents.Dialog.UiDialog::InstantiateFromResources<Royal.Scenes.Game.Ui.Dialogs.LevelWin.LevelWinDialog>(string assetName, Royal.Scenes.Start.Context.Units.Flow.DialogAction action);
            label_14:
            if((Royal.Infrastructure.UiComponents.Dialog.UiDialog.InstantiateFromResources<Royal.Scenes.Game.Ui.Dialogs.LevelWin.LevelWinDialog>(assetName:  val_7, action:  this)) != null)
            {
                goto typeof(Royal.Scenes.Game.Ui.Dialogs.LevelWin.LevelWinDialog).__il2cppRuntimeField_240;
            }
            
            label_15:
            Royal.Scenes.Game.Ui.Dialogs.LevelWin.LevelWinDialog val_5 = Royal.Infrastructure.UiComponents.Dialog.UiDialog.Instantiate<Royal.Scenes.Game.Ui.Dialogs.LevelWin.LevelWinDialog>(asset:  Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_element_class + 24, action:  this);
            goto typeof(Royal.Scenes.Game.Ui.Dialogs.LevelWin.LevelWinDialog).__il2cppRuntimeField_240;
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
        
        }
        public ShowLevelWinDialogAction()
        {
        
        }
    
    }

}
