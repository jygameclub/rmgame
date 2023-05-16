using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.TeamBattle
{
    public class TeamBattleContributionClaimAction : FlowAction
    {
        // Fields
        private readonly Royal.Scenes.Game.Mechanics.Boosters.BoosterType boosterType;
        private readonly int amount;
        
        // Methods
        public TeamBattleContributionClaimAction(Royal.Scenes.Game.Mechanics.Boosters.BoosterType boosterType, int amount)
        {
            this.boosterType = boosterType;
            this.amount = amount;
        }
        public override void Execute()
        {
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.identity;
            UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattleContributionClaimPanel>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattleContributionClaimPanel>(path:  "TeamBattleContributionClaimPanel"), position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rotation:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w}).Show(boosterType:  this.boosterType, amount:  this.amount, onComplete:  new System.Action(object:  this, method:  public System.Void Royal.Scenes.Start.Context.Units.Flow.FlowAction::Complete()));
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
            this.Complete();
        }
    
    }

}
