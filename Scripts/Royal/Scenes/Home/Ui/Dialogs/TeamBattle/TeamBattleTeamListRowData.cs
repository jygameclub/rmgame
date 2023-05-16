using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.TeamBattle
{
    public struct TeamBattleTeamListRowData : IUiScrollContentData
    {
        // Fields
        public readonly int order;
        public readonly Royal.Infrastructure.Services.Storage.Tables.Leader leader;
        
        // Methods
        public TeamBattleTeamListRowData(int order, Royal.Infrastructure.Services.Storage.Tables.Leader leader)
        {
            mem[1152921519175666848] = order;
        }
    
    }

}
