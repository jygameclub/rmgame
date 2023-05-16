using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.TeamBattle
{
    public class TeamBattleCoinRewardClaimAction : FlowAction
    {
        // Fields
        private UnityEngine.Transform reward;
        private int rewardAmount;
        
        // Methods
        public TeamBattleCoinRewardClaimAction(UnityEngine.Transform reward, int rewardAmount)
        {
            this.reward = reward;
            this.rewardAmount = rewardAmount;
        }
        public override void Execute()
        {
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.identity;
            UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattleCoinRewardClaimPanel>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattleCoinRewardClaimPanel>(path:  "TeamBattleCoinRewardClaimPanel"), position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rotation:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w}).Show(reward:  this.reward, onCompleteAction:  new System.Action(object:  this, method:  public System.Void Royal.Scenes.Start.Context.Units.Flow.FlowAction::Complete()));
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
        
        }
    
    }

}
