using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Actions
{
    public class PlayRoyalPassClaimAction : ARoyalPassFlowAction
    {
        // Fields
        private readonly Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassStep stepConfig;
        private readonly bool isFreeRewardAction;
        
        // Methods
        public PlayRoyalPassClaimAction(Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassStep stepConfig, bool isFreeRewardAction)
        {
            this.stepConfig = stepConfig;
            this.isFreeRewardAction = isFreeRewardAction;
        }
        public override void Execute()
        {
            if(this.ShouldPlayAnimation() != false)
            {
                    UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Animations.RoyalPassClaimAnimation>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Animations.RoyalPassClaimAnimation>(path:  "RoyalPassClaimAnimation")).Play(royalPassStep:  this.stepConfig, isFreeReward:  (this.isFreeRewardAction == true) ? 1 : 0, onComplete:  new System.Action(object:  this, method:  public System.Void Royal.Scenes.Start.Context.Units.Flow.FlowAction::Complete()));
                return;
            }
            
            this.Complete();
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
        
        }
    
    }

}
