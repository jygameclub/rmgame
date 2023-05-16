using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Social.MyTeam
{
    public struct MemberListRowData : IUiScrollContentData
    {
        // Fields
        public readonly long id;
        public readonly string name;
        public readonly int helps;
        public readonly int level;
        public readonly int leagueLevel;
        public readonly long lastLevelUpdateDate;
        public readonly bool isMyTeam;
        public readonly bool isMyUser;
        public readonly bool isLeader;
        public readonly bool isCoLeader;
        public readonly bool isGold;
        public int order;
        
        // Methods
        public MemberListRowData(long id, string name, int helps, int level, int leagueLevel, long lastLevelUpdateDate, bool isMyTeam, bool isMyUser, bool isLeader, bool isCoLeader, bool isGold)
        {
            mem[1152921518984892560] = 0;
            this.helps = id;
            this.leagueLevel = name;
            this.lastLevelUpdateDate = helps;
            mem[1152921518984892532] = level;
            this.isMyTeam = leagueLevel;
            this.order = lastLevelUpdateDate;
            mem[1152921518984892552] = isMyTeam;
            mem[1152921518984892553] = isMyUser;
            mem[1152921518984892554] = isLeader;
            mem[1152921518984892555] = isCoLeader;
            mem[1152921518984892556] = isGold;
        }
        public void UpdateOrder(int index)
        {
            mem[1152921518985008656] = index;
        }
    
    }

}
