using UnityEngine;

namespace Royal.Scenes.Game.Ui.Dialogs.WinLogoAnimation
{
    public class ShowWinLogoDialogAction : DialogAction
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
            UnityEngine.Coroutine val_2 = Royal.Scenes.Start.Context.ApplicationContext.ManualStartCoroutine(iEnumerator:  this.ShowLogoWithDelay());
        }
        private System.Collections.IEnumerator ShowLogoWithDelay()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new ShowWinLogoDialogAction.<ShowLogoWithDelay>d__3();
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
        
        }
        public ShowWinLogoDialogAction()
        {
        
        }
    
    }

}
