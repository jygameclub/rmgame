using UnityEngine;

namespace Royal.Scenes.Game.Ui.Dialogs.RemainingMoves
{
    public class RemainingMovesDialog : UiDialog
    {
        // Fields
        private const float BlackFadeOutDuration = 0.3;
        private Royal.Scenes.Game.Levels.Units.RemainingMoves.RemainingMovesManager remainingMovesManager;
        
        // Methods
        public override void OnShow(UnityEngine.Vector3 position)
        {
            this.remainingMovesManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.RemainingMoves.RemainingMovesManager>(contextId:  33);
            UnityEngine.Transform val_2 = this.transform;
            val_2.position = new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z};
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
            val_2.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            this.remainingMovesManager.StartRemainingMovesWithDialog(dialog:  this);
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_4 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetUiSorting();
            this.SetSorting(getDialogSorting:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_4.layer, order = val_4.order, sortEverything = val_4.sortEverything & 4294967295});
            this.Invoke(methodName:  "ShowTapToSkip", time:  0.3f);
        }
        private void ShowTapToSkip()
        {
            if(this.remainingMovesManager != null)
            {
                    if(this.remainingMovesManager.tapToSkip == null)
            {
                    return;
            }
            
                this.remainingMovesManager.tapToSkip.ShowSkipText();
                return;
            }
            
            throw new NullReferenceException();
        }
        public override Royal.Infrastructure.UiComponents.Dialog.DialogConfig GetConfig()
        {
            bool val_2;
            float val_3;
            var val_4;
            var val_5;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_0;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_1 = this.GetConfig();
            val_0.shouldHideBackground = true;
            val_0.shouldCloseOnEscape = false;
            val_0.shouldCloseOnTouch = false;
            val_0.shouldCloseOnSwipe = false;
            val_0.shouldHideBackgroundOnShow = true;
            val_0.backgroundFadeInDuration = 0.3f;
            val_0.shouldSkipFastOnTouch = val_2;
            mem[1152921519910442682] = val_5;
            mem[1152921519910442678] = val_4;
            val_0.backgroundFadeOutDuration = val_3;
            val_0.backgroundFadeAlpha = 0f;
            return val_0;
        }
        public RemainingMovesDialog()
        {
        
        }
    
    }

}
