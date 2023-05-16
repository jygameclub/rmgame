using UnityEngine;

namespace Royal.Scenes.Game.Ui.Dialogs.LevelQuit
{
    public class ShowLevelQuitDialogAction : DialogAction
    {
        // Properties
        public override int Type { get; }
        
        // Methods
        public override int get_Type()
        {
            return 1;
        }
        public override void Execute()
        {
            var val_7;
            string val_8;
            var val_9;
            if(IsStory == false)
            {
                goto label_5;
            }
            
            val_7 = public System.Void Royal.Scenes.Start.Context.Units.Flow.FlowAction::Complete();
            goto typeof(Royal.Scenes.Game.Ui.Dialogs.LevelQuit.LevelQuitDialog).__il2cppRuntimeField_240;
            label_5:
            if(IsLeague == false)
            {
                goto label_7;
            }
            
            val_8 = "LeagueLevelQuitDialog";
            val_9 = public static Royal.Scenes.Game.Ui.Dialogs.LevelQuit.LevelQuitDialog Royal.Infrastructure.UiComponents.Dialog.UiDialog::InstantiateFromResources<Royal.Scenes.Game.Ui.Dialogs.LevelQuit.LevelQuitDialog>(string assetName, Royal.Scenes.Start.Context.Units.Flow.DialogAction action);
            goto label_8;
            label_7:
            if(IsHard == false)
            {
                goto label_9;
            }
            
            val_8 = mem[Royal.Player.Context.Data.Session.__il2cppRuntimeField_2C == 0x1 ? "HardLevelQuitDialog" : "SuperHardLevelQuitDialog"];
            val_8 = (Royal.Player.Context.Data.Session.__il2cppRuntimeField_2C == 1) ? "HardLevelQuitDialog" : "SuperHardLevelQuitDialog";
            val_9 = public static Royal.Scenes.Game.Ui.Dialogs.LevelQuit.LevelQuitDialog Royal.Infrastructure.UiComponents.Dialog.UiDialog::InstantiateFromResources<Royal.Scenes.Game.Ui.Dialogs.LevelQuit.LevelQuitDialog>(string assetName, Royal.Scenes.Start.Context.Units.Flow.DialogAction action);
            label_8:
            if((Royal.Infrastructure.UiComponents.Dialog.UiDialog.InstantiateFromResources<Royal.Scenes.Game.Ui.Dialogs.LevelQuit.LevelQuitDialog>(assetName:  val_8, action:  this)) != null)
            {
                goto typeof(Royal.Scenes.Game.Ui.Dialogs.LevelQuit.LevelQuitDialog).__il2cppRuntimeField_240;
            }
            
            label_9:
            Royal.Scenes.Game.Ui.Dialogs.LevelQuit.LevelQuitDialog val_6 = Royal.Infrastructure.UiComponents.Dialog.UiDialog.Instantiate<Royal.Scenes.Game.Ui.Dialogs.LevelQuit.LevelQuitDialog>(asset:  Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_element_class + 48, action:  this);
            goto typeof(Royal.Scenes.Game.Ui.Dialogs.LevelQuit.LevelQuitDialog).__il2cppRuntimeField_240;
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
            if(this != null)
            {
                    this.CloseDialog(uiDialog:  0, fast:  false);
                return;
            }
            
            throw new NullReferenceException();
        }
        public ShowLevelQuitDialogAction()
        {
        
        }
    
    }

}
