using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Social.NoTeam
{
    public struct TeamListRowData : IUiScrollContentData
    {
        // Fields
        public readonly long id;
        public readonly string name;
        public readonly int capacity;
        public readonly bool isPending;
        public readonly int onlineCount;
        public readonly Royal.Scenes.Home.Ui.Sections.Social.Logo.TeamLogoConfig logoConfig;
        
        // Methods
        public TeamListRowData(long id, string name, int capacity, bool isPending, int onlineCount, Royal.Scenes.Home.Ui.Sections.Social.Logo.TeamLogoConfig logoConfig)
        {
            this.capacity = id;
            this.onlineCount = name;
            this.logoConfig = capacity;
            mem[1152921518969105176] = onlineCount;
            mem[1152921518969105172] = isPending;
            mem[1152921518969105184] = logoConfig;
        }
    
    }

}
