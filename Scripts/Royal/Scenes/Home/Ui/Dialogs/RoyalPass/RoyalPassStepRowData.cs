using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass
{
    public struct RoyalPassStepRowData : IUiScrollContentData
    {
        // Fields
        public readonly int step;
        public readonly Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassReward freeReward;
        public readonly Royal.Player.Context.Units.RewardName freeRewardName;
        public readonly Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassReward goldReward;
        public readonly Royal.Player.Context.Units.RewardName goldRewardName;
        
        // Methods
        public RoyalPassStepRowData(int step, Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassReward freeReward, Royal.Player.Context.Units.RewardName freeRewardName, Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassReward goldReward, Royal.Player.Context.Units.RewardName goldRewardName)
        {
            this.freeRewardName = step;
            this.goldReward = freeReward;
            this.goldRewardName = freeRewardName;
            mem[1152921519256974504] = goldReward;
            mem[1152921519256974512] = goldRewardName;
        }
    
    }

}
