using UnityEngine;

namespace Royal.Infrastructure.Services.Storage.Tables
{
    public struct Leader
    {
        // Fields
        private byte <Type>k__BackingField;
        private long <UserId>k__BackingField;
        private string <UserName>k__BackingField;
        private long <TeamId>k__BackingField;
        private string <TeamName>k__BackingField;
        private int <TeamLogo>k__BackingField;
        private int <Level>k__BackingField;
        private int <LeagueLevel>k__BackingField;
        private long <LevelUpdateTime>k__BackingField;
        private long <FacebookId>k__BackingField;
        private bool <IsGold>k__BackingField;
        
        // Properties
        public byte Type { get; set; }
        public long UserId { get; set; }
        public string UserName { get; set; }
        public long TeamId { get; set; }
        public string TeamName { get; set; }
        public int TeamLogo { get; set; }
        public int Level { get; set; }
        public int LeagueLevel { get; set; }
        public long LevelUpdateTime { get; set; }
        public long FacebookId { get; set; }
        public bool IsGold { get; set; }
        
        // Methods
        public byte get_Type()
        {
            return (byte)this.<UserName>k__BackingField;
        }
        public void set_Type(byte value)
        {
            this.<UserName>k__BackingField = value;
        }
        public long get_UserId()
        {
            return (long)this.<TeamId>k__BackingField;
        }
        public void set_UserId(long value)
        {
            this.<TeamId>k__BackingField = value;
        }
        public string get_UserName()
        {
            return (string)this.<TeamName>k__BackingField;
        }
        public void set_UserName(string value)
        {
            this.<TeamName>k__BackingField = value;
        }
        public long get_TeamId()
        {
            return (long)this.<TeamLogo>k__BackingField;
        }
        public void set_TeamId(long value)
        {
            this.<TeamLogo>k__BackingField = value;
        }
        public string get_TeamName()
        {
            return (string)this.<LeagueLevel>k__BackingField;
        }
        public void set_TeamName(string value)
        {
            this.<LeagueLevel>k__BackingField = value;
        }
        public int get_TeamLogo()
        {
            return (int)this.<LevelUpdateTime>k__BackingField;
        }
        public void set_TeamLogo(int value)
        {
            this.<LevelUpdateTime>k__BackingField = value;
        }
        public int get_Level()
        {
            return (int)this;
        }
        public void set_Level(int value)
        {
            mem[1152921527544008268] = value;
        }
        public int get_LeagueLevel()
        {
            return (int)this.<FacebookId>k__BackingField;
        }
        public void set_LeagueLevel(int value)
        {
            this.<FacebookId>k__BackingField = value;
        }
        public long get_LevelUpdateTime()
        {
            return (long)this.<IsGold>k__BackingField;
        }
        public void set_LevelUpdateTime(long value)
        {
            this.<IsGold>k__BackingField = value;
        }
        public long get_FacebookId()
        {
            return (long)this;
        }
        public void set_FacebookId(long value)
        {
            mem[1152921527544680288] = value;
        }
        public bool get_IsGold()
        {
            return (bool)this;
        }
        public void set_IsGold(bool value)
        {
            mem[1152921527544904296] = value;
        }
        public bool HasData()
        {
            return (bool)(W8 > 0) ? 1 : 0;
        }
    
    }

}
