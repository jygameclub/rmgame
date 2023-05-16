using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct ClaimKingsCupRewardRequest : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public long GroupId { get; }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.CurrentUserInventory> CurrentUserInventory { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.ClaimKingsCupRewardRequest GetRootAsClaimKingsCupRewardRequest(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.ClaimKingsCupRewardRequest.GetRootAsClaimKingsCupRewardRequest(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.ClaimKingsCupRewardRequest() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.ClaimKingsCupRewardRequest GetRootAsClaimKingsCupRewardRequest(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.ClaimKingsCupRewardRequest obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.ClaimKingsCupRewardRequest() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528413756304] = _i;
            mem[1152921528413756312] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.ClaimKingsCupRewardRequest __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528413876496] = _i;
            mem[1152921528413876504] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.ClaimKingsCupRewardRequest() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public long get_GroupId()
        {
        
        }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.CurrentUserInventory> get_CurrentUserInventory()
        {
            throw 36701911;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ClaimKingsCupRewardRequest> CreateClaimKingsCupRewardRequest(FlatBuffers.FlatBufferBuilder builder, long group_id = 0, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.CurrentUserInventory> current_user_inventoryOffset)
        {
            builder.StartObject(numfields:  2);
            Royal.Infrastructure.Services.Backend.Protocol.ClaimKingsCupRewardRequest.AddGroupId(builder:  builder, groupId:  group_id);
            Royal.Infrastructure.Services.Backend.Protocol.ClaimKingsCupRewardRequest.AddCurrentUserInventory(builder:  builder, currentUserInventoryOffset:  new FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.CurrentUserInventory>() {Value = current_user_inventoryOffset.Value & 4294967295});
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ClaimKingsCupRewardRequest> val_2 = Royal.Infrastructure.Services.Backend.Protocol.ClaimKingsCupRewardRequest.EndClaimKingsCupRewardRequest(builder:  builder);
            val_2.Value = val_2.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ClaimKingsCupRewardRequest>)val_2.Value;
        }
        public static void StartClaimKingsCupRewardRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  2);
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
        public static void AddCurrentUserInventory(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.CurrentUserInventory> currentUserInventoryOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  1, x:  currentUserInventoryOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ClaimKingsCupRewardRequest> EndClaimKingsCupRewardRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
