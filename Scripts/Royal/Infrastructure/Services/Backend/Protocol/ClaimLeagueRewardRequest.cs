using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct ClaimLeagueRewardRequest : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.CurrentUserInventory> CurrentUserInventory { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.ClaimLeagueRewardRequest GetRootAsClaimLeagueRewardRequest(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.ClaimLeagueRewardRequest.GetRootAsClaimLeagueRewardRequest(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.ClaimLeagueRewardRequest() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.ClaimLeagueRewardRequest GetRootAsClaimLeagueRewardRequest(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.ClaimLeagueRewardRequest obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.ClaimLeagueRewardRequest() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528417074576] = _i;
            mem[1152921528417074584] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.ClaimLeagueRewardRequest __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528417194768] = _i;
            mem[1152921528417194776] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.ClaimLeagueRewardRequest() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.CurrentUserInventory> get_CurrentUserInventory()
        {
            throw 36702040;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ClaimLeagueRewardRequest> CreateClaimLeagueRewardRequest(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.CurrentUserInventory> current_user_inventoryOffset)
        {
            builder.StartObject(numfields:  1);
            Royal.Infrastructure.Services.Backend.Protocol.ClaimLeagueRewardRequest.AddCurrentUserInventory(builder:  builder, currentUserInventoryOffset:  new FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.CurrentUserInventory>() {Value = current_user_inventoryOffset.Value & 4294967295});
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ClaimLeagueRewardRequest> val_2 = Royal.Infrastructure.Services.Backend.Protocol.ClaimLeagueRewardRequest.EndClaimLeagueRewardRequest(builder:  builder);
            val_2.Value = val_2.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ClaimLeagueRewardRequest>)val_2.Value;
        }
        public static void StartClaimLeagueRewardRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  1);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddCurrentUserInventory(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.CurrentUserInventory> currentUserInventoryOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  0, x:  currentUserInventoryOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ClaimLeagueRewardRequest> EndClaimLeagueRewardRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
