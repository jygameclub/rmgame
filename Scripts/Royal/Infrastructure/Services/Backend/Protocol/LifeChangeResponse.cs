using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct LifeChangeResponse : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.UserInfo> UserInfo { get; }
        public int HelpersLength { get; }
        public int ConsumedLength { get; }
        public long Time { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.LifeChangeResponse GetRootAsLifeChangeResponse(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.LifeChangeResponse.GetRootAsLifeChangeResponse(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.LifeChangeResponse() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.LifeChangeResponse GetRootAsLifeChangeResponse(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.LifeChangeResponse obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.LifeChangeResponse() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528513849616] = _i;
            mem[1152921528513849624] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.LifeChangeResponse __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528513969808] = _i;
            mem[1152921528513969816] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.LifeChangeResponse() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.UserInfo> get_UserInfo()
        {
        
        }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.UserInfo> Helpers(int j)
        {
        
        }
        public int get_HelpersLength()
        {
        
        }
        public long Consumed(int j)
        {
        
        }
        public int get_ConsumedLength()
        {
        
        }
        public System.Nullable<System.ArraySegment<byte>> GetConsumedBytes()
        {
        
        }
        public long[] GetConsumedArray()
        {
        
        }
        public long get_Time()
        {
            throw 36704700;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LifeChangeResponse> CreateLifeChangeResponse(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UserInfo> user_infoOffset, FlatBuffers.VectorOffset helpersOffset, FlatBuffers.VectorOffset consumedOffset, long time = 0)
        {
            builder.StartObject(numfields:  4);
            Royal.Infrastructure.Services.Backend.Protocol.LifeChangeResponse.AddTime(builder:  builder, time:  time);
            Royal.Infrastructure.Services.Backend.Protocol.LifeChangeResponse.AddConsumed(builder:  builder, consumedOffset:  new FlatBuffers.VectorOffset() {Value = consumedOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.LifeChangeResponse.AddHelpers(builder:  builder, helpersOffset:  new FlatBuffers.VectorOffset() {Value = helpersOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.LifeChangeResponse.AddUserInfo(builder:  builder, userInfoOffset:  new FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UserInfo>() {Value = user_infoOffset.Value & 4294967295});
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LifeChangeResponse> val_4 = Royal.Infrastructure.Services.Backend.Protocol.LifeChangeResponse.EndLifeChangeResponse(builder:  builder);
            val_4.Value = val_4.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LifeChangeResponse>)val_4.Value;
        }
        public static void StartLifeChangeResponse(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  4);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddUserInfo(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UserInfo> userInfoOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  0, x:  userInfoOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddHelpers(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.VectorOffset helpersOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  1, x:  helpersOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.VectorOffset CreateHelpersVector(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UserInfo>[] data)
        {
            var val_5;
            builder.StartVector(elemSize:  4, count:  data.Length, alignment:  4);
            if(<0)
            {
                goto label_4;
            }
            
            int val_2 = data.Length & 4294967295;
            val_5 = (long)data.Length - 1;
            int val_3 = data.Length - 2;
            label_5:
            builder.AddOffset(off:  data[val_5]);
            if((val_3 & 2147483648) != 0)
            {
                goto label_4;
            }
            
            val_5 = val_5 - 1;
            val_3 = val_3 - 1;
            if(val_5 < data.Length)
            {
                goto label_5;
            }
            
            throw new IndexOutOfRangeException();
            label_4:
            FlatBuffers.VectorOffset val_4 = builder.EndVector();
            val_4.Value = val_4.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_4.Value;
        }
        public static FlatBuffers.VectorOffset CreateHelpersVectorBlock(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UserInfo>[] data)
        {
            builder.StartVector(elemSize:  4, count:  data.Length, alignment:  4);
            builder.Add<FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UserInfo>>(x:  data);
            FlatBuffers.VectorOffset val_1 = builder.EndVector();
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_1.Value;
        }
        public static void StartHelpersVector(FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
            if(builder != null)
            {
                    builder.StartVector(elemSize:  4, count:  numElems, alignment:  4);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddConsumed(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.VectorOffset consumedOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  2, x:  consumedOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.VectorOffset CreateConsumedVector(FlatBuffers.FlatBufferBuilder builder, long[] data)
        {
            var val_5;
            builder.StartVector(elemSize:  8, count:  data.Length, alignment:  8);
            if(<0)
            {
                goto label_4;
            }
            
            int val_2 = data.Length & 4294967295;
            val_5 = (long)data.Length - 1;
            int val_3 = data.Length - 2;
            label_5:
            builder.AddLong(x:  data[val_5]);
            if((val_3 & 2147483648) != 0)
            {
                goto label_4;
            }
            
            val_5 = val_5 - 1;
            val_3 = val_3 - 1;
            if(val_5 < data.Length)
            {
                goto label_5;
            }
            
            throw new IndexOutOfRangeException();
            label_4:
            FlatBuffers.VectorOffset val_4 = builder.EndVector();
            val_4.Value = val_4.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_4.Value;
        }
        public static FlatBuffers.VectorOffset CreateConsumedVectorBlock(FlatBuffers.FlatBufferBuilder builder, long[] data)
        {
            builder.StartVector(elemSize:  8, count:  data.Length, alignment:  8);
            builder.Add<System.Int64>(x:  data);
            FlatBuffers.VectorOffset val_1 = builder.EndVector();
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_1.Value;
        }
        public static void StartConsumedVector(FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
            if(builder != null)
            {
                    builder.StartVector(elemSize:  8, count:  numElems, alignment:  8);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddTime(FlatBuffers.FlatBufferBuilder builder, long time)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  3, x:  time, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LifeChangeResponse> EndLifeChangeResponse(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
