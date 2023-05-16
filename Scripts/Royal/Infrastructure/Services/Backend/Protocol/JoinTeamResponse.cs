using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct JoinTeamResponse : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode Status { get; }
        public bool RequestSent { get; }
        public Royal.Infrastructure.Services.Backend.Protocol.JoinTeamFailReason FailReason { get; }
        public long UserData { get; }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.TeamBattleInfo> TeamBattleInfo { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.JoinTeamResponse GetRootAsJoinTeamResponse(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.JoinTeamResponse.GetRootAsJoinTeamResponse(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.JoinTeamResponse() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.JoinTeamResponse GetRootAsJoinTeamResponse(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.JoinTeamResponse obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.JoinTeamResponse() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528476656400] = _i;
            mem[1152921528476656408] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.JoinTeamResponse __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528476776592] = _i;
            mem[1152921528476776600] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.JoinTeamResponse() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode get_Status()
        {
        
        }
        public bool get_RequestSent()
        {
        
        }
        public Royal.Infrastructure.Services.Backend.Protocol.JoinTeamFailReason get_FailReason()
        {
        
        }
        public long get_UserData()
        {
        
        }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.TeamBattleInfo> get_TeamBattleInfo()
        {
            throw 36703933;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.JoinTeamResponse> CreateJoinTeamResponse(FlatBuffers.FlatBufferBuilder builder, Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode status = 0, bool request_sent = False, Royal.Infrastructure.Services.Backend.Protocol.JoinTeamFailReason fail_reason = 0, long userData = 0, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.TeamBattleInfo> team_battle_infoOffset)
        {
            builder.StartObject(numfields:  5);
            Royal.Infrastructure.Services.Backend.Protocol.JoinTeamResponse.AddUserData(builder:  builder, userData:  userData);
            Royal.Infrastructure.Services.Backend.Protocol.JoinTeamResponse.AddTeamBattleInfo(builder:  builder, teamBattleInfoOffset:  new FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.TeamBattleInfo>() {Value = team_battle_infoOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.JoinTeamResponse.AddFailReason(builder:  builder, failReason:  fail_reason);
            Royal.Infrastructure.Services.Backend.Protocol.JoinTeamResponse.AddRequestSent(builder:  builder, requestSent:  request_sent);
            Royal.Infrastructure.Services.Backend.Protocol.JoinTeamResponse.AddStatus(builder:  builder, status:  status);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.JoinTeamResponse> val_3 = Royal.Infrastructure.Services.Backend.Protocol.JoinTeamResponse.EndJoinTeamResponse(builder:  builder);
            val_3.Value = val_3.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.JoinTeamResponse>)val_3.Value;
        }
        public static void StartJoinTeamResponse(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  5);
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
        public static void AddRequestSent(FlatBuffers.FlatBufferBuilder builder, bool requestSent)
        {
            if(builder != null)
            {
                    builder.AddBool(o:  1, x:  requestSent, d:  false);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddFailReason(FlatBuffers.FlatBufferBuilder builder, Royal.Infrastructure.Services.Backend.Protocol.JoinTeamFailReason failReason)
        {
            if(builder != null)
            {
                    builder.AddSbyte(o:  2, x:  failReason, d:  0);
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
        public static void AddTeamBattleInfo(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.TeamBattleInfo> teamBattleInfoOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  4, x:  teamBattleInfoOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.JoinTeamResponse> EndJoinTeamResponse(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
