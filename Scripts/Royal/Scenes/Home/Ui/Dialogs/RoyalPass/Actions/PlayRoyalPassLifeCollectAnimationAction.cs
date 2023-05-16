using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Actions
{
    public class PlayRoyalPassLifeCollectAnimationAction : FlowAction
    {
        // Fields
        private readonly int unlimitedMinutes;
        private readonly float waitForSecondsToComplete;
        
        // Methods
        public PlayRoyalPassLifeCollectAnimationAction(float delay, int minutes, int lifeCount = 0)
        {
            var val_2;
            this.waitForSecondsToComplete = delay;
            this.unlimitedMinutes = minutes;
            val_2 = null;
            val_2 = null;
            Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.LifeCollectAnimationData val_1 = new Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.LifeCollectAnimationData(minutes:  minutes, count:  lifeCount);
            Royal.Scenes.Home.Ui.__il2cppRuntimeField_38.PrepareTextForAnimation(animationData:  new Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.LifeCollectAnimationData() {lifeCount = val_1.lifeCount, unlimitedMinutes = val_1.lifeCount});
        }
        public override void Execute()
        {
            UnityEngine.Coroutine val_2 = Royal.Scenes.Home.Context.HomeContext.ManualStartCoroutine(iEnumerator:  this.CompleteAfterDelay());
        }
        private System.Collections.IEnumerator CompleteAfterDelay()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new PlayRoyalPassLifeCollectAnimationAction.<CompleteAfterDelay>d__4();
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
            this.Complete();
        }
    
    }

}
