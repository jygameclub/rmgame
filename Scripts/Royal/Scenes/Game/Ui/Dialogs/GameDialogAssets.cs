using UnityEngine;

namespace Royal.Scenes.Game.Ui.Dialogs
{
    public class GameDialogAssets : ScriptableObject
    {
        // Fields
        public Royal.Scenes.Game.Ui.Dialogs.LevelWin.LevelWinDialog levelWinDialog;
        public Royal.Scenes.Game.Ui.Dialogs.LevelFail.OutOfMovesBanner outOfMovesBanner;
        public Royal.Scenes.Game.Ui.Dialogs.LevelFail.LevelFailDialog levelFailDialog;
        public Royal.Scenes.Game.Ui.Dialogs.LevelQuit.LevelQuitDialog levelQuitDialog;
        public Royal.Scenes.Game.Ui.Dialogs.LevelFail.EgoDialog egoDialog;
        public Royal.Scenes.Game.Ui.Dialogs.RemainingMoves.RemainingMovesDialog remainingMovesDialog;
        public Royal.Scenes.Game.Ui.Dialogs.WinLogoAnimation.WinLogoAnimationDialog winLogoAnimationDialog;
        
        // Methods
        public GameDialogAssets()
        {
        
        }
    
    }

}
