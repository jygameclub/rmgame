using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.League
{
    public struct LeagueMemberListRowData : IUiScrollContentData
    {
        // Fields
        public readonly int order;
        public readonly Royal.Infrastructure.Services.Storage.Tables.Leader leader;
        public readonly bool isMyUser;
        
        // Methods
        public LeagueMemberListRowData(int order, Royal.Infrastructure.Services.Storage.Tables.Leader leader)
        {
        
        }
    
    }

}
