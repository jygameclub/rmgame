using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct UserProgress : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public int Level { get; }
        public long FullLivesTimeInMs { get; }
        public long UnlimitedLivesEndTimeInMs { get; }
        public long UserData { get; }
        public int Coins { get; }
        public int Stars { get; }
        public int Inbox { get; }
        public long InGameInventory { get; }
        public long PreLevelInventory { get; }
        public int AreaId { get; }
        public int AreaTasks { get; }
        public int AreaStatus { get; }
        public long TeamId { get; }
        public string Name { get; }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.LeagueProgress> DepreciatedLeagueProgress { get; }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.LeagueProgress> LeagueProgress { get; }
        public int Chest { get; }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.KingsCupInfo> KingsCupInfo { get; }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.TeamBattleInfo> TeamBattleInfo { get; }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.MadnessEventInfo> MadnessEventInfo { get; }
        public long EventProgress { get; }
        public int UnlimitedRocketEndTime { get; }
        public int UnlimitedTntEndTime { get; }
        public int UnlimitedLightballEndTime { get; }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.LogData> LogData { get; }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.LadderOfferInfo> LadderOfferInfo { get; }
        public long RemainingBoosterTimes { get; }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassInfo> RoyalPassInfo { get; }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassUserProgress> RoyalPassUserProgress { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.UserProgress GetRootAsUserProgress(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.UserProgress.GetRootAsUserProgress(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.UserProgress() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.UserProgress GetRootAsUserProgress(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.UserProgress obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.UserProgress() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528623197200] = _i;
            mem[1152921528623197208] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.UserProgress __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528623317392] = _i;
            mem[1152921528623317400] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.UserProgress() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public int get_Level()
        {
        
        }
        public long get_FullLivesTimeInMs()
        {
        
        }
        public long get_UnlimitedLivesEndTimeInMs()
        {
        
        }
        public long get_UserData()
        {
        
        }
        public int get_Coins()
        {
        
        }
        public int get_Stars()
        {
        
        }
        public int get_Inbox()
        {
        
        }
        public long get_InGameInventory()
        {
        
        }
        public long get_PreLevelInventory()
        {
        
        }
        public int get_AreaId()
        {
        
        }
        public int get_AreaTasks()
        {
        
        }
        public int get_AreaStatus()
        {
        
        }
        public long get_TeamId()
        {
        
        }
        public string get_Name()
        {
        
        }
        public System.Nullable<System.ArraySegment<byte>> GetNameBytes()
        {
        
        }
        public byte[] GetNameArray()
        {
        
        }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.LeagueProgress> get_DepreciatedLeagueProgress()
        {
        
        }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.LeagueProgress> get_LeagueProgress()
        {
        
        }
        public int get_Chest()
        {
        
        }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.KingsCupInfo> get_KingsCupInfo()
        {
        
        }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.TeamBattleInfo> get_TeamBattleInfo()
        {
        
        }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.MadnessEventInfo> get_MadnessEventInfo()
        {
        
        }
        public long get_EventProgress()
        {
        
        }
        public int get_UnlimitedRocketEndTime()
        {
        
        }
        public int get_UnlimitedTntEndTime()
        {
        
        }
        public int get_UnlimitedLightballEndTime()
        {
        
        }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.LogData> get_LogData()
        {
        
        }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.LadderOfferInfo> get_LadderOfferInfo()
        {
        
        }
        public long get_RemainingBoosterTimes()
        {
        
        }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassInfo> get_RoyalPassInfo()
        {
        
        }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassUserProgress> get_RoyalPassUserProgress()
        {
            throw 36607559;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UserProgress> CreateUserProgress(FlatBuffers.FlatBufferBuilder builder, int level = 0, long full_lives_time_in_ms = 0, long unlimited_lives_end_time_in_ms = 0, long user_data = 0, int coins = 0, int stars = 0, int inbox = 0, long in_game_inventory = 0, long pre_level_inventory = 0, int area_id = 0, int area_tasks = 0, int area_status = 0, long team_id = 0, FlatBuffers.StringOffset nameOffset, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeagueProgress> depreciated_league_progressOffset, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeagueProgress> league_progressOffset, int chest = 0, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.KingsCupInfo> kings_cup_infoOffset, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.TeamBattleInfo> team_battle_infoOffset, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.MadnessEventInfo> madness_event_infoOffset, long event_progress = 0, int unlimited_rocket_end_time = 0, int unlimited_tnt_end_time = 0, int unlimited_lightball_end_time = 0, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LogData> log_dataOffset, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LadderOfferInfo> ladder_offer_infoOffset, long remaining_booster_times = 0, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassInfo> royal_pass_infoOffset, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassUserProgress> royal_pass_user_progressOffset)
        {
            var val_1;
            var val_2;
            var val_3;
            long val_4;
            var val_5;
            var val_6;
            builder.StartObject(numfields:  29);
            Royal.Infrastructure.Services.Backend.Protocol.UserProgress.AddRemainingBoosterTimes(builder:  builder, remainingBoosterTimes:  val_4);
            Royal.Infrastructure.Services.Backend.Protocol.UserProgress.AddEventProgress(builder:  builder, eventProgress:  unlimited_lightball_end_time);
            Royal.Infrastructure.Services.Backend.Protocol.UserProgress.AddTeamId(builder:  builder, teamId:  team_id);
            Royal.Infrastructure.Services.Backend.Protocol.UserProgress.AddPreLevelInventory(builder:  builder, preLevelInventory:  pre_level_inventory);
            Royal.Infrastructure.Services.Backend.Protocol.UserProgress.AddInGameInventory(builder:  builder, inGameInventory:  in_game_inventory);
            Royal.Infrastructure.Services.Backend.Protocol.UserProgress.AddUserData(builder:  builder, userData:  user_data);
            Royal.Infrastructure.Services.Backend.Protocol.UserProgress.AddUnlimitedLivesEndTimeInMs(builder:  builder, unlimitedLivesEndTimeInMs:  unlimited_lives_end_time_in_ms);
            Royal.Infrastructure.Services.Backend.Protocol.UserProgress.AddFullLivesTimeInMs(builder:  builder, fullLivesTimeInMs:  full_lives_time_in_ms);
            Royal.Infrastructure.Services.Backend.Protocol.UserProgress.AddRoyalPassUserProgress(builder:  builder, royalPassUserProgressOffset:  new FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassUserProgress>() {Value = val_2 & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.UserProgress.AddRoyalPassInfo(builder:  builder, royalPassInfoOffset:  new FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassInfo>() {Value = val_1 & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.UserProgress.AddLadderOfferInfo(builder:  builder, ladderOfferInfoOffset:  new FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LadderOfferInfo>() {Value = val_3 & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.UserProgress.AddLogData(builder:  builder, logDataOffset:  new FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LogData>() {Value = val_5 & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.UserProgress.AddUnlimitedLightballEndTime(builder:  builder, unlimitedLightballEndTime:  royal_pass_infoOffset.Value);
            Royal.Infrastructure.Services.Backend.Protocol.UserProgress.AddUnlimitedTntEndTime(builder:  builder, unlimitedTntEndTime:  remaining_booster_times);
            Royal.Infrastructure.Services.Backend.Protocol.UserProgress.AddUnlimitedRocketEndTime(builder:  builder, unlimitedRocketEndTime:  log_dataOffset.Value);
            Royal.Infrastructure.Services.Backend.Protocol.UserProgress.AddMadnessEventInfo(builder:  builder, madnessEventInfoOffset:  new FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.MadnessEventInfo>() {Value = unlimited_tnt_end_time & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.UserProgress.AddTeamBattleInfo(builder:  builder, teamBattleInfoOffset:  new FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.TeamBattleInfo>() {Value = unlimited_rocket_end_time & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.UserProgress.AddKingsCupInfo(builder:  builder, kingsCupInfoOffset:  new FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.KingsCupInfo>() {Value = event_progress & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.UserProgress.AddChest(builder:  builder, chest:  team_battle_infoOffset.Value);
            Royal.Infrastructure.Services.Backend.Protocol.UserProgress.AddLeagueProgress(builder:  builder, leagueProgressOffset:  new FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeagueProgress>() {Value = val_6 & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.UserProgress.AddDepreciatedLeagueProgress(builder:  builder, depreciatedLeagueProgressOffset:  new FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeagueProgress>() {Value = league_progressOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.UserProgress.AddName(builder:  builder, nameOffset:  new FlatBuffers.StringOffset() {Value = nameOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.UserProgress.AddAreaStatus(builder:  builder, areaStatus:  area_status);
            Royal.Infrastructure.Services.Backend.Protocol.UserProgress.AddAreaTasks(builder:  builder, areaTasks:  area_tasks);
            Royal.Infrastructure.Services.Backend.Protocol.UserProgress.AddAreaId(builder:  builder, areaId:  area_id);
            Royal.Infrastructure.Services.Backend.Protocol.UserProgress.AddInbox(builder:  builder, inbox:  inbox);
            Royal.Infrastructure.Services.Backend.Protocol.UserProgress.AddStars(builder:  builder, stars:  stars);
            Royal.Infrastructure.Services.Backend.Protocol.UserProgress.AddCoins(builder:  builder, coins:  coins);
            Royal.Infrastructure.Services.Backend.Protocol.UserProgress.AddLevel(builder:  builder, level:  level);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UserProgress> val_17 = Royal.Infrastructure.Services.Backend.Protocol.UserProgress.EndUserProgress(builder:  builder);
            val_17.Value = val_17.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UserProgress>)val_17.Value;
        }
        public static void StartUserProgress(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  29);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddLevel(FlatBuffers.FlatBufferBuilder builder, int level)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  0, x:  level, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddFullLivesTimeInMs(FlatBuffers.FlatBufferBuilder builder, long fullLivesTimeInMs)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  1, x:  fullLivesTimeInMs, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddUnlimitedLivesEndTimeInMs(FlatBuffers.FlatBufferBuilder builder, long unlimitedLivesEndTimeInMs)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  2, x:  unlimitedLivesEndTimeInMs, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddUserData(FlatBuffers.FlatBufferBuilder builder, long userData)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  3, x:  userData, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddCoins(FlatBuffers.FlatBufferBuilder builder, int coins)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  4, x:  coins, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddStars(FlatBuffers.FlatBufferBuilder builder, int stars)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  5, x:  stars, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddInbox(FlatBuffers.FlatBufferBuilder builder, int inbox)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  6, x:  inbox, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddInGameInventory(FlatBuffers.FlatBufferBuilder builder, long inGameInventory)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  7, x:  inGameInventory, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddPreLevelInventory(FlatBuffers.FlatBufferBuilder builder, long preLevelInventory)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  8, x:  preLevelInventory, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddAreaId(FlatBuffers.FlatBufferBuilder builder, int areaId)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  9, x:  areaId, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddAreaTasks(FlatBuffers.FlatBufferBuilder builder, int areaTasks)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  10, x:  areaTasks, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddAreaStatus(FlatBuffers.FlatBufferBuilder builder, int areaStatus)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  11, x:  areaStatus, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddTeamId(FlatBuffers.FlatBufferBuilder builder, long teamId)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  12, x:  teamId, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddName(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset nameOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  13, x:  nameOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddDepreciatedLeagueProgress(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeagueProgress> depreciatedLeagueProgressOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  14, x:  depreciatedLeagueProgressOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddLeagueProgress(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeagueProgress> leagueProgressOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  15, x:  leagueProgressOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddChest(FlatBuffers.FlatBufferBuilder builder, int chest)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  16, x:  chest, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddKingsCupInfo(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.KingsCupInfo> kingsCupInfoOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  17, x:  kingsCupInfoOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddTeamBattleInfo(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.TeamBattleInfo> teamBattleInfoOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  18, x:  teamBattleInfoOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddMadnessEventInfo(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.MadnessEventInfo> madnessEventInfoOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  19, x:  madnessEventInfoOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddEventProgress(FlatBuffers.FlatBufferBuilder builder, long eventProgress)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  20, x:  eventProgress, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddUnlimitedRocketEndTime(FlatBuffers.FlatBufferBuilder builder, int unlimitedRocketEndTime)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  21, x:  unlimitedRocketEndTime, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddUnlimitedTntEndTime(FlatBuffers.FlatBufferBuilder builder, int unlimitedTntEndTime)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  22, x:  unlimitedTntEndTime, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddUnlimitedLightballEndTime(FlatBuffers.FlatBufferBuilder builder, int unlimitedLightballEndTime)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  23, x:  unlimitedLightballEndTime, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddLogData(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LogData> logDataOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  24, x:  logDataOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddLadderOfferInfo(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LadderOfferInfo> ladderOfferInfoOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  25, x:  ladderOfferInfoOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddRemainingBoosterTimes(FlatBuffers.FlatBufferBuilder builder, long remainingBoosterTimes)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  26, x:  remainingBoosterTimes, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddRoyalPassInfo(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassInfo> royalPassInfoOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  27, x:  royalPassInfoOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddRoyalPassUserProgress(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassUserProgress> royalPassUserProgressOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  28, x:  royalPassUserProgressOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UserProgress> EndUserProgress(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
        public static void FinishUserProgressBuffer(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UserProgress> offset)
        {
            if(builder != null)
            {
                    builder.Finish(rootTable:  offset.Value);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void FinishSizePrefixedUserProgressBuffer(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UserProgress> offset)
        {
            if(builder != null)
            {
                    builder.FinishSizePrefixed(rootTable:  offset.Value);
                return;
            }
            
            throw new NullReferenceException();
        }
    
    }

}
