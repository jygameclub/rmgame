using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct ChangeUserNameResponse : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode Status { get; }
        public long UserData { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.ChangeUserNameResponse GetRootAsChangeUserNameResponse(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.ChangeUserNameResponse.GetRootAsChangeUserNameResponse(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.ChangeUserNameResponse() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.ChangeUserNameResponse GetRootAsChangeUserNameResponse(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.ChangeUserNameResponse obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.ChangeUserNameResponse() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528406783760] = _i;
            mem[1152921528406783768] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.ChangeUserNameResponse __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528406903952] = _i;
            mem[1152921528406903960] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.ChangeUserNameResponse() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode get_Status()
        {
        
        }
        public long get_UserData()
        {
            throw 36701681;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ChangeUserNameResponse> CreateChangeUserNameResponse(FlatBuffers.FlatBufferBuilder builder, Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode status = 0, long user_data = 0)
        {
            builder.StartObject(numfields:  2);
            Royal.Infrastructure.Services.Backend.Protocol.ChangeUserNameResponse.AddUserData(builder:  builder, userData:  user_data);
            Royal.Infrastructure.Services.Backend.Protocol.ChangeUserNameResponse.AddStatus(builder:  builder, status:  status);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ChangeUserNameResponse> val_1 = Royal.Infrastructure.Services.Backend.Protocol.ChangeUserNameResponse.EndChangeUserNameResponse(builder:  builder);
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ChangeUserNameResponse>)val_1.Value;
        }
        public static void StartChangeUserNameResponse(FlatBuffers.FlatBufferBuilder builder)
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
        public static void AddUserData(FlatBuffers.FlatBufferBuilder builder, long userData)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  1, x:  userData, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ChangeUserNameResponse> EndChangeUserNameResponse(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
