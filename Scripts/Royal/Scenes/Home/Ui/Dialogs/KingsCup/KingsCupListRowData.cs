using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.KingsCup
{
    public struct KingsCupListRowData : IUiScrollContentData
    {
        // Fields
        public readonly int order;
        public readonly Royal.Infrastructure.Services.Storage.Tables.Leader leader;
        
        // Methods
        public KingsCupListRowData(int order, Royal.Infrastructure.Services.Storage.Tables.Leader leader)
        {
            mem[1152921519466515264] = order;
        }
    
    }

}
