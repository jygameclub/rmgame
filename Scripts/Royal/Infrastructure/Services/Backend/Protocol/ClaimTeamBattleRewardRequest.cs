using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct ClaimTeamBattleRewardRequest : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public long GroupId { get; }
        public long TeamId { get; }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.CurrentUserInventory> CurrentUserInventory { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.ClaimTeamBattleRewardRequest GetRootAsClaimTeamBattleRewardRequest(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.ClaimTeamBattleRewardRequest.GetRootAsClaimTeamBattleRewardRequest(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.ClaimTeamBattleRewardRequest() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.ClaimTeamBattleRewardRequest GetRootAsClaimTeamBattleRewardRequest(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.ClaimTeamBattleRewardRequest obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.ClaimTeamBattleRewardRequest() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528420160656] = _i;
            mem[1152921528420160664] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.ClaimTeamBattleRewardRequest __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528420280848] = _i;
            mem[1152921528420280856] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.ClaimTeamBattleRewardRequest() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public long get_GroupId()
        {
        
        }
        public long get_TeamId()
        {
        
        }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.CurrentUserInventory> get_CurrentUserInventory()
        {
            throw 36702171;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ClaimTeamBattleRewardRequest> CreateClaimTeamBattleRewardRequest(FlatBuffers.FlatBufferBuilder builder, long group_id = 0, long team_id = 0, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.CurrentUserInventory> current_user_inventoryOffset)
        {
            builder.StartObject(numfields:  3);
            Royal.Infrastructure.Services.Backend.Protocol.ClaimTeamBattleRewardRequest.AddTeamId(builder:  builder, teamId:  team_id);
            Royal.Infrastructure.Services.Backend.Protocol.ClaimTeamBattleRewardRequest.AddGroupId(builder:  builder, groupId:  group_id);
            Royal.Infrastructure.Services.Backend.Protocol.ClaimTeamBattleRewardRequest.AddCurrentUserInventory(builder:  builder, currentUserInventoryOffset:  new FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.CurrentUserInventory>() {Value = current_user_inventoryOffset.Value & 4294967295});
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ClaimTeamBattleRewardRequest> val_2 = Royal.Infrastructure.Services.Backend.Protocol.ClaimTeamBattleRewardRequest.EndClaimTeamBattleRewardRequest(builder:  builder);
            val_2.Value = val_2.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ClaimTeamBattleRewardRequest>)val_2.Value;
        }
        public static void StartClaimTeamBattleRewardRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  3);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddGroupId(FlatBuffers.FlatBufferBuilder builder, long groupId)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  0, x:  groupId, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddTeamId(FlatBuffers.FlatBufferBuilder builder, long teamId)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  1, x:  teamId, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddCurrentUserInventory(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.CurrentUserInventory> currentUserInventoryOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  2, x:  currentUserInventoryOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ClaimTeamBattleRewardRequest> EndClaimTeamBattleRewardRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
