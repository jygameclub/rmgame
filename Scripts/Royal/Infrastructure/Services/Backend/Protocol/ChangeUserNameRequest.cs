using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct ChangeUserNameRequest : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public string NewName { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.ChangeUserNameRequest GetRootAsChangeUserNameRequest(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.ChangeUserNameRequest.GetRootAsChangeUserNameRequest(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.ChangeUserNameRequest() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.ChangeUserNameRequest GetRootAsChangeUserNameRequest(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.ChangeUserNameRequest obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.ChangeUserNameRequest() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528405373200] = _i;
            mem[1152921528405373208] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.ChangeUserNameRequest __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528405493392] = _i;
            mem[1152921528405493400] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.ChangeUserNameRequest() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public string get_NewName()
        {
        
        }
        public System.Nullable<System.ArraySegment<byte>> GetNewNameBytes()
        {
        
        }
        public byte[] GetNewNameArray()
        {
            throw 36701620;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ChangeUserNameRequest> CreateChangeUserNameRequest(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset new_nameOffset)
        {
            builder.StartObject(numfields:  1);
            Royal.Infrastructure.Services.Backend.Protocol.ChangeUserNameRequest.AddNewName(builder:  builder, newNameOffset:  new FlatBuffers.StringOffset() {Value = new_nameOffset.Value & 4294967295});
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ChangeUserNameRequest> val_2 = Royal.Infrastructure.Services.Backend.Protocol.ChangeUserNameRequest.EndChangeUserNameRequest(builder:  builder);
            val_2.Value = val_2.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ChangeUserNameRequest>)val_2.Value;
        }
        public static void StartChangeUserNameRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  1);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddNewName(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset newNameOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  0, x:  newNameOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ChangeUserNameRequest> EndChangeUserNameRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
