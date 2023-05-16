using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct UpdateUserProgressResponse : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode Status { get; }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.UserProgress> UserProgress { get; }
        public bool TeamExist { get; }
        public int LeagueRank { get; }
        public long LeagueRemainingTime { get; }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.KingsCupInfo> KingsCupInfo { get; }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.TeamBattleInfo> TeamBattleInfo { get; }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.MadnessEventInfo> MadnessEventInfo { get; }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.LogData> LogData { get; }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.LadderOfferInfo> LadderOfferInfo { get; }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassInfo> RoyalPassInfo { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.UpdateUserProgressResponse GetRootAsUpdateUserProgressResponse(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.UpdateUserProgressResponse.GetRootAsUpdateUserProgressResponse(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.UpdateUserProgressResponse() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.UpdateUserProgressResponse GetRootAsUpdateUserProgressResponse(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.UpdateUserProgressResponse obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.UpdateUserProgressResponse() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528616963216] = _i;
            mem[1152921528616963224] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.UpdateUserProgressResponse __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528617083408] = _i;
            mem[1152921528617083416] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.UpdateUserProgressResponse() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode get_Status()
        {
        
        }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.UserProgress> get_UserProgress()
        {
        
        }
        public bool get_TeamExist()
        {
        
        }
        public int get_LeagueRank()
        {
        
        }
        public long get_LeagueRemainingTime()
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
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.LogData> get_LogData()
        {
        
        }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.LadderOfferInfo> get_LadderOfferInfo()
        {
        
        }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassInfo> get_RoyalPassInfo()
        {
            throw 36607386;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UpdateUserProgressResponse> CreateUpdateUserProgressResponse(FlatBuffers.FlatBufferBuilder builder, Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode status = 0, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UserProgress> user_progressOffset, bool team_exist = False, int league_rank = 0, long league_remaining_time = 0, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.KingsCupInfo> kings_cup_infoOffset, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.TeamBattleInfo> team_battle_infoOffset, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.MadnessEventInfo> madness_event_infoOffset, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LogData> log_dataOffset, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LadderOfferInfo> ladder_offer_infoOffset, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassInfo> royal_pass_infoOffset)
        {
            var val_1;
            var val_2;
            builder.StartObject(numfields:  11);
            Royal.Infrastructure.Services.Backend.Protocol.UpdateUserProgressResponse.AddLeagueRemainingTime(builder:  builder, leagueRemainingTime:  league_remaining_time);
            Royal.Infrastructure.Services.Backend.Protocol.UpdateUserProgressResponse.AddRoyalPassInfo(builder:  builder, royalPassInfoOffset:  new FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassInfo>() {Value = val_2 & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.UpdateUserProgressResponse.AddLadderOfferInfo(builder:  builder, ladderOfferInfoOffset:  new FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LadderOfferInfo>() {Value = val_1 & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.UpdateUserProgressResponse.AddLogData(builder:  builder, logDataOffset:  new FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LogData>() {Value = ladder_offer_infoOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.UpdateUserProgressResponse.AddMadnessEventInfo(builder:  builder, madnessEventInfoOffset:  new FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.MadnessEventInfo>() {Value = madness_event_infoOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.UpdateUserProgressResponse.AddTeamBattleInfo(builder:  builder, teamBattleInfoOffset:  new FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.TeamBattleInfo>() {Value = team_battle_infoOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.UpdateUserProgressResponse.AddKingsCupInfo(builder:  builder, kingsCupInfoOffset:  new FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.KingsCupInfo>() {Value = kings_cup_infoOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.UpdateUserProgressResponse.AddLeagueRank(builder:  builder, leagueRank:  league_rank);
            Royal.Infrastructure.Services.Backend.Protocol.UpdateUserProgressResponse.AddUserProgress(builder:  builder, userProgressOffset:  new FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UserProgress>() {Value = user_progressOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.UpdateUserProgressResponse.AddTeamExist(builder:  builder, teamExist:  team_exist);
            Royal.Infrastructure.Services.Backend.Protocol.UpdateUserProgressResponse.AddStatus(builder:  builder, status:  status);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UpdateUserProgressResponse> val_11 = Royal.Infrastructure.Services.Backend.Protocol.UpdateUserProgressResponse.EndUpdateUserProgressResponse(builder:  builder);
            val_11.Value = val_11.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UpdateUserProgressResponse>)val_11.Value;
        }
        public static void StartUpdateUserProgressResponse(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  11);
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
        public static void AddUserProgress(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UserProgress> userProgressOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  1, x:  userProgressOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddTeamExist(FlatBuffers.FlatBufferBuilder builder, bool teamExist)
        {
            if(builder != null)
            {
                    builder.AddBool(o:  2, x:  teamExist, d:  false);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddLeagueRank(FlatBuffers.FlatBufferBuilder builder, int leagueRank)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  3, x:  leagueRank, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddLeagueRemainingTime(FlatBuffers.FlatBufferBuilder builder, long leagueRemainingTime)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  4, x:  leagueRemainingTime, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddKingsCupInfo(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.KingsCupInfo> kingsCupInfoOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  5, x:  kingsCupInfoOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddTeamBattleInfo(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.TeamBattleInfo> teamBattleInfoOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  6, x:  teamBattleInfoOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddMadnessEventInfo(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.MadnessEventInfo> madnessEventInfoOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  7, x:  madnessEventInfoOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddLogData(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LogData> logDataOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  8, x:  logDataOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddLadderOfferInfo(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LadderOfferInfo> ladderOfferInfoOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  9, x:  ladderOfferInfoOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddRoyalPassInfo(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassInfo> royalPassInfoOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  10, x:  royalPassInfoOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UpdateUserProgressResponse> EndUpdateUserProgressResponse(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
