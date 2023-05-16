using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.LadderOffer.Actions
{
    public class PlayLadderClaimAction : ALadderFlowAction
    {
        // Fields
        private readonly Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferStep stepConfig;
        
        // Methods
        public PlayLadderClaimAction(int eventId, Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferStep stepConfig)
        {
            this.stepConfig = stepConfig;
        }
        public override bool SupportsMultiple()
        {
            return true;
        }
        public override void Execute()
        {
            if(this.ShouldPlayAnimation() == false)
            {
                    return;
            }
            
            UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Dialogs.LadderOffer.Animations.LadderClaimAnimation>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Dialogs.LadderOffer.Animations.LadderClaimAnimation>(path:  "LadderClaimAnimation")).Play(ladderOfferStep:  this.stepConfig, onComplete:  new System.Action(object:  this, method:  public System.Void Royal.Scenes.Home.Ui.Dialogs.LadderOffer.Actions.ALadderFlowAction::Complete()));
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
        
        }
    
    }

}
