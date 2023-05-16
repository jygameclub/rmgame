using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct PingResponse : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode Status { get; }
        public long Flags { get; }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.UserProgress> UserProgress { get; }
        public int MaxLevel { get; }
        public Royal.Infrastructure.Services.Backend.Protocol.RequestedOperationType RequestedOperation { get; }
        public string RequestReason { get; }
        public int ForceUpdateVersion { get; }
        public bool TeamExist { get; }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.BadWordsData> BadWordsFilter { get; }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.ABTestContent> AbTestContent { get; }
        public int LeagueRank { get; }
        public long LeagueRemainingTime { get; }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig> DepreciatedLeagueConfig { get; }
        public int RequiredLevelForLeague { get; }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig> LeagueConfig { get; }
        public long AbTestData { get; }
        public long AbTestUpdateData { get; }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.KingsCupInfo> KingsCupInfo { get; }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.TeamBattleInfo> TeamBattleInfo { get; }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.MadnessEventInfo> MadnessEventInfo { get; }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.LadderOfferInfo> LadderOfferInfo { get; }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassInfo> RoyalPassInfo { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.PingResponse GetRootAsPingResponse(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.PingResponse.GetRootAsPingResponse(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.PingResponse() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.PingResponse GetRootAsPingResponse(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.PingResponse obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.PingResponse() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528526304784] = _i;
            mem[1152921528526304792] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.PingResponse __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528526424976] = _i;
            mem[1152921528526424984] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.PingResponse() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode get_Status()
        {
        
        }
        public long get_Flags()
        {
        
        }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.UserProgress> get_UserProgress()
        {
        
        }
        public int get_MaxLevel()
        {
        
        }
        public Royal.Infrastructure.Services.Backend.Protocol.RequestedOperationType get_RequestedOperation()
        {
        
        }
        public string get_RequestReason()
        {
        
        }
        public System.Nullable<System.ArraySegment<byte>> GetRequestReasonBytes()
        {
        
        }
        public byte[] GetRequestReasonArray()
        {
        
        }
        public int get_ForceUpdateVersion()
        {
        
        }
        public bool get_TeamExist()
        {
        
        }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.BadWordsData> get_BadWordsFilter()
        {
        
        }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.ABTestContent> get_AbTestContent()
        {
        
        }
        public int get_LeagueRank()
        {
        
        }
        public long get_LeagueRemainingTime()
        {
        
        }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig> get_DepreciatedLeagueConfig()
        {
        
        }
        public int get_RequiredLevelForLeague()
        {
        
        }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig> get_LeagueConfig()
        {
        
        }
        public long get_AbTestData()
        {
        
        }
        public long get_AbTestUpdateData()
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
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.LadderOfferInfo> get_LadderOfferInfo()
        {
        
        }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassInfo> get_RoyalPassInfo()
        {
            throw 36704964;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.PingResponse> CreatePingResponse(FlatBuffers.FlatBufferBuilder builder, Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode status = 0, long flags = 0, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UserProgress> user_progressOffset, int max_level = 0, Royal.Infrastructure.Services.Backend.Protocol.RequestedOperationType requested_operation = 0, FlatBuffers.StringOffset request_reasonOffset, int force_update_version = 0, bool team_exist = False, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.BadWordsData> bad_words_filterOffset, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ABTestContent> ab_test_contentOffset, int league_rank = 0, long league_remaining_time = 0, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig> depreciated_league_configOffset, int required_level_for_league = 0, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig> league_configOffset, long ab_test_data = 0, long ab_test_update_data = 0, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.KingsCupInfo> kings_cup_infoOffset, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.TeamBattleInfo> team_battle_infoOffset, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.MadnessEventInfo> madness_event_infoOffset, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LadderOfferInfo> ladder_offer_infoOffset, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassInfo> royal_pass_infoOffset)
        {
            var val_1;
            var val_2;
            var val_3;
            var val_4;
            var val_5;
            builder.StartObject(numfields:  22);
            Royal.Infrastructure.Services.Backend.Protocol.PingResponse.AddAbTestUpdateData(builder:  builder, abTestUpdateData:  madness_event_infoOffset.Value);
            Royal.Infrastructure.Services.Backend.Protocol.PingResponse.AddAbTestData(builder:  builder, abTestData:  kings_cup_infoOffset.Value);
            Royal.Infrastructure.Services.Backend.Protocol.PingResponse.AddLeagueRemainingTime(builder:  builder, leagueRemainingTime:  depreciated_league_configOffset.Value);
            Royal.Infrastructure.Services.Backend.Protocol.PingResponse.AddFlags(builder:  builder, flags:  flags);
            Royal.Infrastructure.Services.Backend.Protocol.PingResponse.AddRoyalPassInfo(builder:  builder, royalPassInfoOffset:  new FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassInfo>() {Value = val_2 & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.PingResponse.AddLadderOfferInfo(builder:  builder, ladderOfferInfoOffset:  new FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LadderOfferInfo>() {Value = val_1 & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.PingResponse.AddMadnessEventInfo(builder:  builder, madnessEventInfoOffset:  new FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.MadnessEventInfo>() {Value = val_4 & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.PingResponse.AddTeamBattleInfo(builder:  builder, teamBattleInfoOffset:  new FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.TeamBattleInfo>() {Value = val_3 & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.PingResponse.AddKingsCupInfo(builder:  builder, kingsCupInfoOffset:  new FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.KingsCupInfo>() {Value = royal_pass_infoOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.PingResponse.AddLeagueConfig(builder:  builder, leagueConfigOffset:  new FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig>() {Value = ab_test_update_data & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.PingResponse.AddRequiredLevelForLeague(builder:  builder, requiredLevelForLeague:  ab_test_data);
            Royal.Infrastructure.Services.Backend.Protocol.PingResponse.AddDepreciatedLeagueConfig(builder:  builder, depreciatedLeagueConfigOffset:  new FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig>() {Value = val_5 & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.PingResponse.AddLeagueRank(builder:  builder, leagueRank:  league_remaining_time);
            Royal.Infrastructure.Services.Backend.Protocol.PingResponse.AddAbTestContent(builder:  builder, abTestContentOffset:  new FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ABTestContent>() {Value = league_rank & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.PingResponse.AddBadWordsFilter(builder:  builder, badWordsFilterOffset:  new FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.BadWordsData>() {Value = bad_words_filterOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.PingResponse.AddForceUpdateVersion(builder:  builder, forceUpdateVersion:  force_update_version);
            Royal.Infrastructure.Services.Backend.Protocol.PingResponse.AddRequestReason(builder:  builder, requestReasonOffset:  new FlatBuffers.StringOffset() {Value = request_reasonOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.PingResponse.AddMaxLevel(builder:  builder, maxLevel:  max_level);
            Royal.Infrastructure.Services.Backend.Protocol.PingResponse.AddUserProgress(builder:  builder, userProgressOffset:  new FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UserProgress>() {Value = user_progressOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.PingResponse.AddTeamExist(builder:  builder, teamExist:  team_exist);
            Royal.Infrastructure.Services.Backend.Protocol.PingResponse.AddRequestedOperation(builder:  builder, requestedOperation:  requested_operation);
            Royal.Infrastructure.Services.Backend.Protocol.PingResponse.AddStatus(builder:  builder, status:  status);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.PingResponse> val_18 = Royal.Infrastructure.Services.Backend.Protocol.PingResponse.EndPingResponse(builder:  builder);
            val_18.Value = val_18.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.PingResponse>)val_18.Value;
        }
        public static void StartPingResponse(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  22);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddStatus(FlatBuffers.FlatBufferBuilder builder, Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode status)
        {
            if(builder != null)
            {
                    builder.AddSbyte(o:  0, x:  status, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddFlags(FlatBuffers.FlatBufferBuilder builder, long flags)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  1, x:  flags, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddUserProgress(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UserProgress> userProgressOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  2, x:  userProgressOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddMaxLevel(FlatBuffers.FlatBufferBuilder builder, int maxLevel)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  3, x:  maxLevel, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddRequestedOperation(FlatBuffers.FlatBufferBuilder builder, Royal.Infrastructure.Services.Backend.Protocol.RequestedOperationType requestedOperation)
        {
            if(builder != null)
            {
                    builder.AddSbyte(o:  4, x:  requestedOperation, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddRequestReason(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset requestReasonOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  5, x:  requestReasonOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddForceUpdateVersion(FlatBuffers.FlatBufferBuilder builder, int forceUpdateVersion)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  6, x:  forceUpdateVersion, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddTeamExist(FlatBuffers.FlatBufferBuilder builder, bool teamExist)
        {
            if(builder != null)
            {
                    builder.AddBool(o:  7, x:  teamExist, d:  false);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddBadWordsFilter(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.BadWordsData> badWordsFilterOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  8, x:  badWordsFilterOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddAbTestContent(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ABTestContent> abTestContentOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  9, x:  abTestContentOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddLeagueRank(FlatBuffers.FlatBufferBuilder builder, int leagueRank)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  10, x:  leagueRank, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddLeagueRemainingTime(FlatBuffers.FlatBufferBuilder builder, long leagueRemainingTime)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  11, x:  leagueRemainingTime, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddDepreciatedLeagueConfig(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig> depreciatedLeagueConfigOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  12, x:  depreciatedLeagueConfigOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddRequiredLevelForLeague(FlatBuffers.FlatBufferBuilder builder, int requiredLevelForLeague)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  13, x:  requiredLevelForLeague, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddLeagueConfig(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig> leagueConfigOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  14, x:  leagueConfigOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddAbTestData(FlatBuffers.FlatBufferBuilder builder, long abTestData)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  15, x:  abTestData, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddAbTestUpdateData(FlatBuffers.FlatBufferBuilder builder, long abTestUpdateData)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  16, x:  abTestUpdateData, d:  0);
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
        public static void AddLadderOfferInfo(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LadderOfferInfo> ladderOfferInfoOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  20, x:  ladderOfferInfoOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddRoyalPassInfo(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassInfo> royalPassInfoOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  21, x:  royalPassInfoOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.PingResponse> EndPingResponse(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
