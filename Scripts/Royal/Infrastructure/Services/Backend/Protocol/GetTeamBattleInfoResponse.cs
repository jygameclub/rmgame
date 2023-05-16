using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct GetTeamBattleInfoResponse : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode Status { get; }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.TeamBattleInfo> TeamBattleInfo { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.GetTeamBattleInfoResponse GetRootAsGetTeamBattleInfoResponse(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.GetTeamBattleInfoResponse.GetRootAsGetTeamBattleInfoResponse(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.GetTeamBattleInfoResponse() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.GetTeamBattleInfoResponse GetRootAsGetTeamBattleInfoResponse(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.GetTeamBattleInfoResponse obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.GetTeamBattleInfoResponse() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528460609808] = _i;
            mem[1152921528460609816] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.GetTeamBattleInfoResponse __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528460730000] = _i;
            mem[1152921528460730008] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.GetTeamBattleInfoResponse() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode get_Status()
        {
        
        }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.TeamBattleInfo> get_TeamBattleInfo()
        {
            throw 36703479;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.GetTeamBattleInfoResponse> CreateGetTeamBattleInfoResponse(FlatBuffers.FlatBufferBuilder builder, Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode status = 0, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.TeamBattleInfo> team_battle_infoOffset)
        {
            builder.StartObject(numfields:  2);
            Royal.Infrastructure.Services.Backend.Protocol.GetTeamBattleInfoResponse.AddTeamBattleInfo(builder:  builder, teamBattleInfoOffset:  new FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.TeamBattleInfo>() {Value = team_battle_infoOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.GetTeamBattleInfoResponse.AddStatus(builder:  builder, status:  status);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.GetTeamBattleInfoResponse> val_2 = Royal.Infrastructure.Services.Backend.Protocol.GetTeamBattleInfoResponse.EndGetTeamBattleInfoResponse(builder:  builder);
            val_2.Value = val_2.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.GetTeamBattleInfoResponse>)val_2.Value;
        }
        public static void StartGetTeamBattleInfoResponse(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  2);
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
        public static void AddTeamBattleInfo(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.TeamBattleInfo> teamBattleInfoOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  1, x:  teamBattleInfoOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.GetTeamBattleInfoResponse> EndGetTeamBattleInfoResponse(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}