using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct PingRequest : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public int BadWordsVersion { get; }
        public long LeagueGroupId { get; }
        public int LeagueConfigVersion { get; }
        public long KingsCupGroupId { get; }
        public long TeamBattleGroupId { get; }
        public long TeamId { get; }
        public int MadnessEventVersion { get; }
        public int LadderOfferVersion { get; }
        public int RoyalPassVersion { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.PingRequest GetRootAsPingRequest(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.PingRequest.GetRootAsPingRequest(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.PingRequest() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.PingRequest GetRootAsPingRequest(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.PingRequest obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.PingRequest() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528523260688] = _i;
            mem[1152921528523260696] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.PingRequest __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528523380880] = _i;
            mem[1152921528523380888] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.PingRequest() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public int get_BadWordsVersion()
        {
        
        }
        public long get_LeagueGroupId()
        {
        
        }
        public int get_LeagueConfigVersion()
        {
        
        }
        public long get_KingsCupGroupId()
        {
        
        }
        public long get_TeamBattleGroupId()
        {
        
        }
        public long get_TeamId()
        {
        
        }
        public int get_MadnessEventVersion()
        {
        
        }
        public int get_LadderOfferVersion()
        {
        
        }
        public int get_RoyalPassVersion()
        {
            throw 36704913;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.PingRequest> CreatePingRequest(FlatBuffers.FlatBufferBuilder builder, int bad_words_version = 0, long league_group_id = 0, int league_config_version = 0, long kings_cup_group_id = 0, long team_battle_group_id = 0, long team_id = 0, int madness_event_version = 0, int ladder_offer_version = 0, int royal_pass_version = 0)
        {
            builder.StartObject(numfields:  9);
            Royal.Infrastructure.Services.Backend.Protocol.PingRequest.AddTeamId(builder:  builder, teamId:  team_id);
            Royal.Infrastructure.Services.Backend.Protocol.PingRequest.AddTeamBattleGroupId(builder:  builder, teamBattleGroupId:  team_battle_group_id);
            Royal.Infrastructure.Services.Backend.Protocol.PingRequest.AddKingsCupGroupId(builder:  builder, kingsCupGroupId:  kings_cup_group_id);
            Royal.Infrastructure.Services.Backend.Protocol.PingRequest.AddLeagueGroupId(builder:  builder, leagueGroupId:  league_group_id);
            Royal.Infrastructure.Services.Backend.Protocol.PingRequest.AddRoyalPassVersion(builder:  builder, royalPassVersion:  royal_pass_version);
            Royal.Infrastructure.Services.Backend.Protocol.PingRequest.AddLadderOfferVersion(builder:  builder, ladderOfferVersion:  ladder_offer_version);
            Royal.Infrastructure.Services.Backend.Protocol.PingRequest.AddMadnessEventVersion(builder:  builder, madnessEventVersion:  madness_event_version);
            Royal.Infrastructure.Services.Backend.Protocol.PingRequest.AddLeagueConfigVersion(builder:  builder, leagueConfigVersion:  league_config_version);
            Royal.Infrastructure.Services.Backend.Protocol.PingRequest.AddBadWordsVersion(builder:  builder, badWordsVersion:  bad_words_version);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.PingRequest> val_1 = Royal.Infrastructure.Services.Backend.Protocol.PingRequest.EndPingRequest(builder:  builder);
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.PingRequest>)val_1.Value;
        }
        public static void StartPingRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  9);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddBadWordsVersion(FlatBuffers.FlatBufferBuilder builder, int badWordsVersion)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  0, x:  badWordsVersion, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddLeagueGroupId(FlatBuffers.FlatBufferBuilder builder, long leagueGroupId)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  1, x:  leagueGroupId, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddLeagueConfigVersion(FlatBuffers.FlatBufferBuilder builder, int leagueConfigVersion)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  2, x:  leagueConfigVersion, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddKingsCupGroupId(FlatBuffers.FlatBufferBuilder builder, long kingsCupGroupId)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  3, x:  kingsCupGroupId, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddTeamBattleGroupId(FlatBuffers.FlatBufferBuilder builder, long teamBattleGroupId)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  4, x:  teamBattleGroupId, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddTeamId(FlatBuffers.FlatBufferBuilder builder, long teamId)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  5, x:  teamId, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddMadnessEventVersion(FlatBuffers.FlatBufferBuilder builder, int madnessEventVersion)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  6, x:  madnessEventVersion, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddLadderOfferVersion(FlatBuffers.FlatBufferBuilder builder, int ladderOfferVersion)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  7, x:  ladderOfferVersion, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddRoyalPassVersion(FlatBuffers.FlatBufferBuilder builder, int royalPassVersion)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  8, x:  royalPassVersion, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.PingRequest> EndPingRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
