using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Madness.Actions
{
    public class PlayMadnessNewRewardAction : AMadnessFlowAction
    {
        // Fields
        private readonly Royal.Player.Context.Units.MadnessStep madnessStep;
        
        // Methods
        public PlayMadnessNewRewardAction(int eventId, Royal.Player.Context.Units.MadnessStep nextStepConfig)
        {
            this.madnessStep = nextStepConfig;
        }
        public override bool SupportsMultiple()
        {
            return true;
        }
        public override void Execute()
        {
            if(this.ShouldPlayAnimation() != false)
            {
                    if((this.DisableTouchesIfNecessary(force:  false)) != true)
            {
                    if((Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).HasAutoActionInTheFlow) != false)
            {
                    bool val_5 = this.DisableTouchesIfNecessary(force:  true);
            }
            
            }
            
                UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Dialogs.Madness.Animations.MadnessNewRewardAnimation>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Dialogs.Madness.Animations.MadnessNewRewardAnimation>(path:  "MadnessNewRewardAnimation")).Play(madnessStep:  this.madnessStep, onComplete:  new System.Action(object:  this, method:  public System.Void Royal.Scenes.Start.Context.Units.Flow.FlowAction::Complete()));
                return;
            }
            
            this.Complete();
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
        
        }
    
    }

}
