using UnityEngine;

namespace Royal.Scenes.Game.Ui.Dialogs.RemainingMoves
{
    public class RemainingMovesDialogAction : DialogAction
    {
        // Fields
        private Royal.Scenes.Game.Levels.Units.MoveManager moveManager;
        private Royal.Player.Context.Data.Session.UserActiveLevelData activeLevelData;
        private Royal.Scenes.Game.Levels.Units.RemainingMoves.RemainingMovesManager remainingMovesManager;
        
        // Methods
        public override void Execute()
        {
            var val_4;
            var val_5;
            Royal.Scenes.Game.Levels.Units.RemainingMoves.RemainingMovesManager val_1 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.RemainingMoves.RemainingMovesManager>(contextId:  33);
            this.remainingMovesManager = val_1;
            if(val_1.ShouldSendMoves() != false)
            {
                    Royal.Scenes.Game.Ui.Dialogs.RemainingMoves.RemainingMovesDialog val_3 = Royal.Infrastructure.UiComponents.Dialog.UiDialog.Instantiate<Royal.Scenes.Game.Ui.Dialogs.RemainingMoves.RemainingMovesDialog>(asset:  static System.Int32 System.Globalization.EncodingTable::internalGetCodePageFromName(string name).__il2cppRuntimeField_40, action:  this);
            }
            else
            {
                    val_5 = null;
                val_5 = null;
                ResetSorting();
                this.remainingMovesManager.CompleteRemainingMovesImmediately();
                val_4 = public System.Void Royal.Scenes.Start.Context.Units.Flow.FlowAction::Complete();
            }
            
            this.Complete();
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
        
        }
        public RemainingMovesDialogAction()
        {
        
        }
    
    }

}
