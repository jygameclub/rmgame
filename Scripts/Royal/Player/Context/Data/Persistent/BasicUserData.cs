using UnityEngine;

namespace Royal.Player.Context.Data.Persistent
{
    public class BasicUserData
    {
        // Fields
        private const byte PaidUserIndex = 0;
        private const byte MovesChestOpenedIndex = 1;
        private const byte MinHighestBoughtBundleIndex = 2;
        private const byte MaxHighestBoughtBundleIndex = 9;
        private const byte EnterNameOnceIndex = 10;
        private const byte ChangeNameOnceIndex = 11;
        private const byte UserHasTeamIndex = 12;
        private const byte MinHighestBoughtSinglePackageIndex = 14;
        private const byte MaxHighestBoughtSinglePackageIndex = 21;
        private const byte SocialBanIndex = 22;
        private const byte SupportBanIndex = 23;
        private int <SyncId>k__BackingField;
        private int <Level>k__BackingField;
        private int <LeagueLevel>k__BackingField;
        private long <FullLivesTimeInMs>k__BackingField;
        private long <UnlimitedLivesEndTimeInMs>k__BackingField;
        private long <UserData>k__BackingField;
        
        // Properties
        public int SyncId { get; set; }
        public int Level { get; set; }
        public int LeagueLevel { get; set; }
        public long FullLivesTimeInMs { get; set; }
        public long UnlimitedLivesEndTimeInMs { get; set; }
        public long UserData { get; set; }
        public bool IsPaidUser { get; }
        public bool HasBoughtBundle { get; }
        public bool HasSupportBan { get; }
        public byte GetHighestBoughtBundle { get; }
        public byte GetHighestBoughtSinglePackage { get; }
        public int StoryLevel { get; }
        
        // Methods
        public int get_SyncId()
        {
            return (int)this.<SyncId>k__BackingField;
        }
        public void set_SyncId(int value)
        {
            this.<SyncId>k__BackingField = value;
        }
        public int get_Level()
        {
            return (int)this.<Level>k__BackingField;
        }
        public void set_Level(int value)
        {
            this.<Level>k__BackingField = value;
        }
        public int get_LeagueLevel()
        {
            return (int)this.<LeagueLevel>k__BackingField;
        }
        public void set_LeagueLevel(int value)
        {
            this.<LeagueLevel>k__BackingField = value;
        }
        public long get_FullLivesTimeInMs()
        {
            return (long)this.<FullLivesTimeInMs>k__BackingField;
        }
        public void set_FullLivesTimeInMs(long value)
        {
            this.<FullLivesTimeInMs>k__BackingField = value;
        }
        public long get_UnlimitedLivesEndTimeInMs()
        {
            return (long)this.<UnlimitedLivesEndTimeInMs>k__BackingField;
        }
        public void set_UnlimitedLivesEndTimeInMs(long value)
        {
            this.<UnlimitedLivesEndTimeInMs>k__BackingField = value;
        }
        public long get_UserData()
        {
            return (long)this.<UserData>k__BackingField;
        }
        public void set_UserData(long value)
        {
            this.<UserData>k__BackingField = value;
        }
        public bool get_IsPaidUser()
        {
            return (bool)(this.<UserData>k__BackingField) & 1;
        }
        public bool IsNameEnteredOnce()
        {
            return (bool)(uint)(((uint)((W8>>2) & 0x1)) >> 2) & 1;
        }
        public bool IsNameChangedOnce()
        {
            return (bool)(uint)(((uint)((W8>>3) & 0x1)) >> 3) & 1;
        }
        public bool get_HasBoughtBundle()
        {
            return (bool)((this.<UserData>k__BackingField) != 1020) ? 1 : 0;
        }
        public bool get_HasSupportBan()
        {
            return (bool)W8 >> 7;
        }
        public byte get_GetHighestBoughtBundle()
        {
            return (byte)(this.<UserData>k__BackingField) >> 2;
        }
        public byte get_GetHighestBoughtSinglePackage()
        {
            return (byte)(this.<UserData>k__BackingField) >> 14;
        }
        public int get_StoryLevel()
        {
            var val_2;
            if(this.IsThereStoryLevelForThisLevel() != false)
            {
                    val_2 = -(this.<Level>k__BackingField);
                return (int)val_2;
            }
            
            val_2 = 0;
            return (int)val_2;
        }
        public void UpdateSyncId(int newSyncId)
        {
            object[] val_1 = new object[2];
            val_1[0] = this.<SyncId>k__BackingField;
            val_1[1] = newSyncId;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  9, log:  "SyncId: {0} -> {1}", values:  val_1);
            this.<SyncId>k__BackingField = newSyncId;
            bool val_2 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetInt(key:  "SyncId", value:  newSyncId);
        }
        public void UpdateUserData(long newUserData)
        {
            object[] val_1 = new object[2];
            val_1[0] = this.<UserData>k__BackingField;
            val_1[1] = newUserData;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  9, log:  "Basic: {0} -> {1}", values:  val_1);
            this.<UserData>k__BackingField = newUserData;
            bool val_2 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetLong(key:  "UserData", value:  newUserData);
        }
        public void UpdateUnlimitedLivesEndTimeInMs(long newUnlimitedLivesEndTimeInMs)
        {
            object[] val_1 = new object[2];
            val_1[0] = this.<UnlimitedLivesEndTimeInMs>k__BackingField;
            val_1[1] = newUnlimitedLivesEndTimeInMs;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  9, log:  "ULives: {0} -> {1}", values:  val_1);
            this.<UnlimitedLivesEndTimeInMs>k__BackingField = newUnlimitedLivesEndTimeInMs;
            bool val_2 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetLong(key:  "UnlimitedLivesEndTimeInMs", value:  newUnlimitedLivesEndTimeInMs);
        }
        public void UpdateFullLivesTimeInMs(long newFullLivesTimeInMs)
        {
            object[] val_1 = new object[2];
            val_1[0] = this.<FullLivesTimeInMs>k__BackingField;
            val_1[1] = newFullLivesTimeInMs;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  9, log:  "Lives: {0} -> {1}", values:  val_1);
            this.<FullLivesTimeInMs>k__BackingField = newFullLivesTimeInMs;
            bool val_2 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetLong(key:  "FullLivesTimeInMs", value:  newFullLivesTimeInMs);
        }
        public void SubstractTimeFromFullLivesTimeInMs(long delta)
        {
            delta = (this.<FullLivesTimeInMs>k__BackingField) - delta;
            this.UpdateFullLivesTimeInMs(newFullLivesTimeInMs:  delta);
        }
        public void UpdateLevel(int newLevel)
        {
            object[] val_1 = new object[2];
            val_1[0] = this.<Level>k__BackingField;
            val_1[1] = newLevel;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  9, log:  "Level: {0} -> {1}", values:  val_1);
            this.<Level>k__BackingField = newLevel;
            bool val_2 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetInt(key:  "Level", value:  newLevel);
        }
        public void UpdateLeagueLevel(int newLevel)
        {
            object[] val_1 = new object[2];
            val_1[0] = this.<LeagueLevel>k__BackingField;
            val_1[1] = newLevel;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  9, log:  "LeagueLevel: {0} -> {1}", values:  val_1);
            this.<LeagueLevel>k__BackingField = newLevel;
            bool val_2 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetInt(key:  "LeagueLevel", value:  newLevel);
        }
        public void IncrementLevel(Royal.Player.Context.Data.Session.UserActiveLevelData levelData)
        {
            var val_7;
            if(levelData.IsStory != false)
            {
                    SetStoryLevel();
                return;
            }
            
            if(levelData.IsLeague != false)
            {
                    this.UpdateLeagueLevel(newLevel:  (this.<LeagueLevel>k__BackingField) + 1);
                Royal.Infrastructure.Services.Storage.Tables.LeaderboardTable.IncrementMyLeagueScoreWithEvents(increment:  1);
                return;
            }
            
            if((this.<Level>k__BackingField) > 1000)
            {
                    return;
            }
            
            this.UpdateLevel(newLevel:  (this.<Level>k__BackingField) + 1);
            if(levelData.IsHard != false)
            {
                    var val_6 = (levelData.difficulty == 1) ? 3 : 5;
            }
            else
            {
                    val_7 = 1;
            }
            
            this.UpdateStoryLevel();
            Royal.Infrastructure.Services.Storage.Tables.LeaderboardTable.IncrementMyLevelWithEvents(increment:  1);
        }
        private void UpdateStoryLevel()
        {
            if(this.IsThereStoryLevelForThisLevel() == false)
            {
                    return;
            }
            
            UpdatePreLevelInventory(newPreLevelInventory:  Royal.Infrastructure.Utils.Math.BitwiseOperations.UpdateLong(toNumber:  Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_this_arg, number:  0, fromPosition:  50, toPosition:  50));
        }
        private bool IsThereStoryLevelForThisLevel()
        {
            var val_6;
            var val_7;
            if((Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleManager>(id:  25).IsDownloaded(bundleType:  3)) == false)
            {
                goto label_4;
            }
            
            if((this.<Level>k__BackingField) != 9)
            {
                goto label_5;
            }
            
            val_6 = 1;
            return (bool)val_6;
            label_4:
            val_7 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_7 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_7 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_7 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  22, log:  "King drill bundle is not downloaded.", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            val_6 = 0;
            return (bool)val_6;
            label_5:
            val_6 = (((this.<Level>k__BackingField) == 45) ? 1 : 0) | (((this.<Level>k__BackingField) == 96) ? 1 : 0);
            return (bool)val_6;
        }
        public BasicUserData()
        {
        
        }
    
    }

}
