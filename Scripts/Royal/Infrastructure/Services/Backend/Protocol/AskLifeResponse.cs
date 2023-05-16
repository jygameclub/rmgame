using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct AskLifeResponse : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode Status { get; }
        public long RemainingTime { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.AskLifeResponse GetRootAsAskLifeResponse(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.AskLifeResponse.GetRootAsAskLifeResponse(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.AskLifeResponse() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.AskLifeResponse GetRootAsAskLifeResponse(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.AskLifeResponse obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.AskLifeResponse() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528391021328] = _i;
            mem[1152921528391021336] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.AskLifeResponse __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528391141520] = _i;
            mem[1152921528391141528] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.AskLifeResponse() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode get_Status()
        {
        
        }
        public long get_RemainingTime()
        {
            var val_1;
            if(!=0)
            {
                    return (long)1152921528391369616;
            }
            
            throw new NullReferenceException();
            label_2:
            if(((X2 + 176 + 8) + -8) == X1)
            {
                goto label_1;
            }
            
             =  + 1;
             =  + 16;
            if( < (X2 + 294))
            {
                goto label_2;
            }
            
            goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X2, typeof(X1), slot: -1985281136);
            label_1:
            var val_3 = ;
            val_3 = val_3 + 1152921528391369616;
             =  + val_3;
            val_1 =  + 304;
            goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X2, typeof(X1), slot: -1985281136);
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.AskLifeResponse> CreateAskLifeResponse(FlatBuffers.FlatBufferBuilder builder, Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode status = 0, long remaining_time = 0)
        {
            builder.StartObject(numfields:  2);
            Royal.Infrastructure.Services.Backend.Protocol.AskLifeResponse.AddRemainingTime(builder:  builder, remainingTime:  remaining_time);
            Royal.Infrastructure.Services.Backend.Protocol.AskLifeResponse.AddStatus(builder:  builder, status:  status);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.AskLifeResponse> val_1 = Royal.Infrastructure.Services.Backend.Protocol.AskLifeResponse.EndAskLifeResponse(builder:  builder);
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.AskLifeResponse>)val_1.Value;
        }
        public static void StartAskLifeResponse(FlatBuffers.FlatBufferBuilder builder)
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
        public static void AddRemainingTime(FlatBuffers.FlatBufferBuilder builder, long remainingTime)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  1, x:  remainingTime, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.AskLifeResponse> EndAskLifeResponse(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
