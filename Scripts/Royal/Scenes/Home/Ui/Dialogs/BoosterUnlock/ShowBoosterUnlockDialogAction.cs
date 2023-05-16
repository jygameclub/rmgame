using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.BoosterUnlock
{
    public class ShowBoosterUnlockDialogAction : DialogAction
    {
        // Fields
        private readonly Royal.Scenes.Game.Mechanics.Boosters.BoosterType boosterType;
        private Royal.Scenes.Home.Ui.Dialogs.BoosterUnlock.BoosterUnlockDialog dialog;
        private readonly Royal.Infrastructure.UiComponents.Touch.UiTouchListener uiTouchListener;
        
        // Methods
        public ShowBoosterUnlockDialogAction(Royal.Scenes.Game.Mechanics.Boosters.BoosterType type)
        {
            this.uiTouchListener = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            val_1.disabler.DisableTouch();
            this.boosterType = type;
        }
        public override void Execute()
        {
            Royal.Scenes.Home.Ui.Dialogs.BoosterUnlock.BoosterUnlockDialog val_1 = Royal.Infrastructure.UiComponents.Dialog.UiDialog.InstantiateFromResources<Royal.Scenes.Home.Ui.Dialogs.BoosterUnlock.BoosterUnlockDialog>(assetName:  "BoosterUnlockDialog", action:  this);
            this.dialog = val_1;
            val_1.Init(type:  this.boosterType);
            UnityEngine.Coroutine val_3 = Royal.Scenes.Home.Context.HomeContext.ManualStartCoroutine(iEnumerator:  this.EnableTouch());
        }
        private System.Collections.IEnumerator EnableTouch()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new ShowBoosterUnlockDialogAction.<EnableTouch>d__5();
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
