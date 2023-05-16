using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.TeamBattle
{
    public struct TeamBattlePlayerListRowData : IUiScrollContentData
    {
        // Fields
        public readonly int order;
        public readonly Royal.Infrastructure.Services.Storage.Tables.Leader leader;
        
        // Methods
        public TeamBattlePlayerListRowData(int order, Royal.Infrastructure.Services.Storage.Tables.Leader leader)
        {
            mem[1152921519169725216] = order;
        }
    
    }

}
