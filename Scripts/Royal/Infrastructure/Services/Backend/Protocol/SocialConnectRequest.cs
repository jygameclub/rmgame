using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct SocialConnectRequest : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public long FacebookId { get; }
        public string Name { get; }
        public string DeviceId { get; }
        public int FriendsLength { get; }
        public string AppleId { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.SocialConnectRequest GetRootAsSocialConnectRequest(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.SocialConnectRequest.GetRootAsSocialConnectRequest(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.SocialConnectRequest() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.SocialConnectRequest GetRootAsSocialConnectRequest(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.SocialConnectRequest obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.SocialConnectRequest() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528572515472] = _i;
            mem[1152921528572515480] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.SocialConnectRequest __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528572635664] = _i;
            mem[1152921528572635672] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.SocialConnectRequest() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public long get_FacebookId()
        {
        
        }
        public string get_Name()
        {
        
        }
        public System.Nullable<System.ArraySegment<byte>> GetNameBytes()
        {
        
        }
        public byte[] GetNameArray()
        {
        
        }
        public string get_DeviceId()
        {
        
        }
        public System.Nullable<System.ArraySegment<byte>> GetDeviceIdBytes()
        {
        
        }
        public byte[] GetDeviceIdArray()
        {
        
        }
        public long Friends(int j)
        {
        
        }
        public int get_FriendsLength()
        {
        
        }
        public System.Nullable<System.ArraySegment<byte>> GetFriendsBytes()
        {
        
        }
        public long[] GetFriendsArray()
        {
        
        }
        public string get_AppleId()
        {
        
        }
        public System.Nullable<System.ArraySegment<byte>> GetAppleIdBytes()
        {
        
        }
        public byte[] GetAppleIdArray()
        {
            throw 36700685;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.SocialConnectRequest> CreateSocialConnectRequest(FlatBuffers.FlatBufferBuilder builder, long facebook_id = 0, FlatBuffers.StringOffset nameOffset, FlatBuffers.StringOffset device_idOffset, FlatBuffers.VectorOffset friendsOffset, FlatBuffers.StringOffset apple_idOffset)
        {
            builder.StartObject(numfields:  5);
            Royal.Infrastructure.Services.Backend.Protocol.SocialConnectRequest.AddFacebookId(builder:  builder, facebookId:  facebook_id);
            Royal.Infrastructure.Services.Backend.Protocol.SocialConnectRequest.AddAppleId(builder:  builder, appleIdOffset:  new FlatBuffers.StringOffset() {Value = apple_idOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.SocialConnectRequest.AddFriends(builder:  builder, friendsOffset:  new FlatBuffers.VectorOffset() {Value = friendsOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.SocialConnectRequest.AddDeviceId(builder:  builder, deviceIdOffset:  new FlatBuffers.StringOffset() {Value = device_idOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.SocialConnectRequest.AddName(builder:  builder, nameOffset:  new FlatBuffers.StringOffset() {Value = nameOffset.Value & 4294967295});
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.SocialConnectRequest> val_5 = Royal.Infrastructure.Services.Backend.Protocol.SocialConnectRequest.EndSocialConnectRequest(builder:  builder);
            val_5.Value = val_5.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.SocialConnectRequest>)val_5.Value;
        }
        public static void StartSocialConnectRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  5);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddFacebookId(FlatBuffers.FlatBufferBuilder builder, long facebookId)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  0, x:  facebookId, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddName(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset nameOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  1, x:  nameOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddDeviceId(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset deviceIdOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  2, x:  deviceIdOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddFriends(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.VectorOffset friendsOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  3, x:  friendsOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.VectorOffset CreateFriendsVector(FlatBuffers.FlatBufferBuilder builder, long[] data)
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
        public static FlatBuffers.VectorOffset CreateFriendsVectorBlock(FlatBuffers.FlatBufferBuilder builder, long[] data)
        {
            builder.StartVector(elemSize:  8, count:  data.Length, alignment:  8);
            builder.Add<System.Int64>(x:  data);
            FlatBuffers.VectorOffset val_1 = builder.EndVector();
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_1.Value;
        }
        public static void StartFriendsVector(FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
            if(builder != null)
            {
                    builder.StartVector(elemSize:  8, count:  numElems, alignment:  8);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddAppleId(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset appleIdOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  4, x:  appleIdOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.SocialConnectRequest> EndSocialConnectRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
