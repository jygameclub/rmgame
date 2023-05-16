using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Madness.Actions
{
    public class PlayMadnessCollectAction : AMadnessFlowAction
    {
        // Fields
        private readonly Royal.Infrastructure.Services.Backend.Protocol.MadnessEventType eventType;
        private readonly int collectedAmount;
        
        // Methods
        public PlayMadnessCollectAction(int eventId, Royal.Infrastructure.Services.Backend.Protocol.MadnessEventType eventType, int collectedAmount)
        {
            this.eventType = eventType;
            this.collectedAmount = collectedAmount;
        }
        public override void Execute()
        {
            var val_6;
            if(this.ShouldPlayAnimation() != false)
            {
                    val_6 = null;
                val_6 = null;
                Royal.Scenes.Home.Ui.__il2cppRuntimeField_50.BringToFront();
                bool val_2 = this.DisableTouchesIfNecessary(force:  true);
                UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Dialogs.Madness.Animations.MadnessCollectAnimation>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Dialogs.Madness.Animations.MadnessCollectAnimation>(path:  "MadnessCollectAnimation")).Play(eventType:  this.eventType, count:  this.collectedAmount, onComplete:  new System.Action(object:  this, method:  typeof(Royal.Scenes.Home.Ui.Dialogs.Madness.Actions.PlayMadnessCollectAction).__il2cppRuntimeField_1B8));
            }
        
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
        
        }
        public override void Complete()
        {
            null = null;
            Royal.Scenes.Home.Ui.__il2cppRuntimeField_50.BringBackToOriginal();
            this.Complete();
        }
    
    }

}
