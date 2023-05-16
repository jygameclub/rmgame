using UnityEngine;

namespace Royal.Scenes.Game.Ui.Dialogs.LevelFail
{
    public class ShowFailDialogAction : DialogAction
    {
        // Properties
        public override int Type { get; }
        
        // Methods
        public override int get_Type()
        {
            return 2;
        }
        public ShowFailDialogAction(bool clearBoosterSelectionData)
        {
            if(clearBoosterSelectionData == false)
            {
                    return;
            }
            
            Reset();
        }
        public override void Execute()
        {
            Royal.Scenes.Start.Context.Units.Flow.DialogAction val_7;
            var val_8;
            string val_9;
            var val_10;
            val_7 = this;
            if(IsStory == false)
            {
                goto label_5;
            }
            
            val_9 = "StoryLevelFailDialog";
            val_10 = 1152921519932437392;
            goto label_6;
            label_5:
            if(IsLeague == false)
            {
                goto label_7;
            }
            
            val_9 = "LeagueLevelFailDialog";
            val_10 = 1152921519932438528;
            label_6:
            label_10:
            Royal.Scenes.Game.Ui.Dialogs.LevelFail.LevelFailDialog val_3 = Royal.Infrastructure.UiComponents.Dialog.UiDialog.InstantiateFromResources<Royal.Scenes.Game.Ui.Dialogs.LevelFail.LevelFailDialog>(assetName:  val_9, action:  this);
            label_13:
            val_8 = ???;
            val_7 = ???;
            goto typeof(Royal.Scenes.Game.Ui.Dialogs.LevelFail.LevelFailDialog).__il2cppRuntimeField_240;
            label_7:
            if(val_8.IsHard == false)
            {
                goto label_9;
            }
            
            var val_5 = ((val_8 + 44) == 1) ? "HardLevelFailDialog" : "SuperHardLevelFailDialog";
            goto label_10;
            label_9:
            if((Royal.Infrastructure.UiComponents.Dialog.UiDialog.Instantiate<Royal.Scenes.Game.Ui.Dialogs.LevelFail.LevelFailDialog>(asset:  val_7 + 24 + 64 + 40, action:  val_7)) != null)
            {
                goto label_13;
            }
            
            throw new NullReferenceException();
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
        
        }
    
    }

}
