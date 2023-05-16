using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct TeamBattleTeam : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public long TeamId { get; }
        public string TeamName { get; }
        public int TeamLogo { get; }
        public int Score { get; }
        public long LastUpdateDate { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.TeamBattleTeam GetRootAsTeamBattleTeam(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.TeamBattleTeam.GetRootAsTeamBattleTeam(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.TeamBattleTeam() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.TeamBattleTeam GetRootAsTeamBattleTeam(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.TeamBattleTeam obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.TeamBattleTeam() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528589289232] = _i;
            mem[1152921528589289240] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.TeamBattleTeam __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528589409424] = _i;
            mem[1152921528589409432] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.TeamBattleTeam() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public long get_TeamId()
        {
        
        }
        public string get_TeamName()
        {
        
        }
        public System.Nullable<System.ArraySegment<byte>> GetTeamNameBytes()
        {
        
        }
        public byte[] GetTeamNameArray()
        {
        
        }
        public int get_TeamLogo()
        {
        
        }
        public int get_Score()
        {
        
        }
        public long get_LastUpdateDate()
        {
            throw 36700964;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.TeamBattleTeam> CreateTeamBattleTeam(FlatBuffers.FlatBufferBuilder builder, long team_id = 0, FlatBuffers.StringOffset team_nameOffset, int team_logo = 0, int score = 0, long last_update_date = 0)
        {
            builder.StartObject(numfields:  5);
            Royal.Infrastructure.Services.Backend.Protocol.TeamBattleTeam.AddLastUpdateDate(builder:  builder, lastUpdateDate:  last_update_date);
            Royal.Infrastructure.Services.Backend.Protocol.TeamBattleTeam.AddTeamId(builder:  builder, teamId:  team_id);
            Royal.Infrastructure.Services.Backend.Protocol.TeamBattleTeam.AddScore(builder:  builder, score:  score);
            Royal.Infrastructure.Services.Backend.Protocol.TeamBattleTeam.AddTeamLogo(builder:  builder, teamLogo:  team_logo);
            Royal.Infrastructure.Services.Backend.Protocol.TeamBattleTeam.AddTeamName(builder:  builder, teamNameOffset:  new FlatBuffers.StringOffset() {Value = team_nameOffset.Value & 4294967295});
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.TeamBattleTeam> val_2 = Royal.Infrastructure.Services.Backend.Protocol.TeamBattleTeam.EndTeamBattleTeam(builder:  builder);
            val_2.Value = val_2.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.TeamBattleTeam>)val_2.Value;
        }
        public static void StartTeamBattleTeam(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  5);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddTeamId(FlatBuffers.FlatBufferBuilder builder, long teamId)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  0, x:  teamId, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddTeamName(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset teamNameOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  1, x:  teamNameOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddTeamLogo(FlatBuffers.FlatBufferBuilder builder, int teamLogo)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  2, x:  teamLogo, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddScore(FlatBuffers.FlatBufferBuilder builder, int score)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  3, x:  score, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddLastUpdateDate(FlatBuffers.FlatBufferBuilder builder, long lastUpdateDate)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  4, x:  lastUpdateDate, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.TeamBattleTeam> EndTeamBattleTeam(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
