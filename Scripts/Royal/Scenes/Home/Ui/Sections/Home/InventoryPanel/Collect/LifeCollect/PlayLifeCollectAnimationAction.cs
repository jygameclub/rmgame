using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect
{
    public class PlayLifeCollectAnimationAction : FlowAction
    {
        // Fields
        private readonly int unlimitedMinutes;
        private readonly float waitForSeconds;
        private bool disableUiTouch;
        
        // Methods
        public PlayLifeCollectAnimationAction(float delay, int minutes, int lifeCount = 0)
        {
            var val_1;
            this.waitForSeconds = delay;
            this.unlimitedMinutes = minutes;
            val_1 = null;
            val_1 = null;
            Royal.Scenes.Home.Ui.__il2cppRuntimeField_38.PrepareTextForAnimation(animationData:  new Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.LifeCollectAnimationData() {lifeCount = lifeCount, unlimitedMinutes = minutes});
        }
        public override void Execute()
        {
            bool val_2 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).HasAutoActionInTheFlow;
            this.disableUiTouch = val_2;
            if(val_2 != false)
            {
                    Royal.Infrastructure.UiComponents.Touch.UiTouchListener val_4 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
                val_4.disabler.DisableTouch();
            }
            
            UnityEngine.Coroutine val_6 = Royal.Scenes.Home.Context.HomeContext.ManualStartCoroutine(iEnumerator:  this.CompleteAfterDelay());
        }
        private System.Collections.IEnumerator CompleteAfterDelay()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new PlayLifeCollectAnimationAction.<CompleteAfterDelay>d__5();
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
            goto typeof(Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.PlayLifeCollectAnimationAction).__il2cppRuntimeField_1B0;
        }
        public override void Complete()
        {
            if(this.disableUiTouch != false)
            {
                    Royal.Infrastructure.UiComponents.Touch.UiTouchListener val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
                val_1.disabler.EnableTouch();
            }
            
            this.Complete();
        }
    
    }

}
