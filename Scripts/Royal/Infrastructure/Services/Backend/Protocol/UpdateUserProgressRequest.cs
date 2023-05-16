using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct UpdateUserProgressRequest : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public int DeviceId { get; }
        public int UserProgressTypeLength { get; }
        public int UserProgressLength { get; }
        public long KingsCupGroupId { get; }
        public long TeamId { get; }
        public long TeamBattleGroupId { get; }
        public int MadnessEventVersion { get; }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.ForceData> ForceData { get; }
        public int LadderOfferVersion { get; }
        public int RoyalPassVersion { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.UpdateUserProgressRequest GetRootAsUpdateUserProgressRequest(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.UpdateUserProgressRequest.GetRootAsUpdateUserProgressRequest(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.UpdateUserProgressRequest() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.UpdateUserProgressRequest GetRootAsUpdateUserProgressRequest(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.UpdateUserProgressRequest obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.UpdateUserProgressRequest() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528612325648] = _i;
            mem[1152921528612325656] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.UpdateUserProgressRequest __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528612445840] = _i;
            mem[1152921528612445848] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.UpdateUserProgressRequest() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public int get_DeviceId()
        {
        
        }
        public Royal.Infrastructure.Services.Backend.Protocol.UserProgressType UserProgressType(int j)
        {
        
        }
        public int get_UserProgressTypeLength()
        {
        
        }
        public System.Nullable<System.ArraySegment<byte>> GetUserProgressTypeBytes()
        {
        
        }
        public Royal.Infrastructure.Services.Backend.Protocol.UserProgressType[] GetUserProgressTypeArray()
        {
        
        }
        public System.Nullable<TTable> UserProgress<TTable>(int j); // 0
        public int get_UserProgressLength()
        {
        
        }
        public long get_KingsCupGroupId()
        {
        
        }
        public long get_TeamId()
        {
        
        }
        public long get_TeamBattleGroupId()
        {
        
        }
        public int get_MadnessEventVersion()
        {
        
        }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.ForceData> get_ForceData()
        {
        
        }
        public int get_LadderOfferVersion()
        {
        
        }
        public int get_RoyalPassVersion()
        {
            throw 36607321;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UpdateUserProgressRequest> CreateUpdateUserProgressRequest(FlatBuffers.FlatBufferBuilder builder, int device_id = 0, FlatBuffers.VectorOffset user_progress_typeOffset, FlatBuffers.VectorOffset user_progressOffset, long kings_cup_group_id = 0, long team_id = 0, long team_battle_group_id = 0, int madness_event_version = 0, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ForceData> forceDataOffset, int ladder_offer_version = 0, int royal_pass_version = 0)
        {
            int val_1;
            int val_2;
            builder.StartObject(numfields:  10);
            Royal.Infrastructure.Services.Backend.Protocol.UpdateUserProgressRequest.AddTeamBattleGroupId(builder:  builder, teamBattleGroupId:  team_battle_group_id);
            Royal.Infrastructure.Services.Backend.Protocol.UpdateUserProgressRequest.AddTeamId(builder:  builder, teamId:  team_id);
            Royal.Infrastructure.Services.Backend.Protocol.UpdateUserProgressRequest.AddKingsCupGroupId(builder:  builder, kingsCupGroupId:  kings_cup_group_id);
            Royal.Infrastructure.Services.Backend.Protocol.UpdateUserProgressRequest.AddRoyalPassVersion(builder:  builder, royalPassVersion:  val_1);
            Royal.Infrastructure.Services.Backend.Protocol.UpdateUserProgressRequest.AddLadderOfferVersion(builder:  builder, ladderOfferVersion:  val_2);
            Royal.Infrastructure.Services.Backend.Protocol.UpdateUserProgressRequest.AddForceData(builder:  builder, forceDataOffset:  new FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ForceData>() {Value = forceDataOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.UpdateUserProgressRequest.AddMadnessEventVersion(builder:  builder, madnessEventVersion:  madness_event_version);
            Royal.Infrastructure.Services.Backend.Protocol.UpdateUserProgressRequest.AddUserProgress(builder:  builder, userProgressOffset:  new FlatBuffers.VectorOffset() {Value = user_progressOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.UpdateUserProgressRequest.AddUserProgressType(builder:  builder, userProgressTypeOffset:  new FlatBuffers.VectorOffset() {Value = user_progress_typeOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.UpdateUserProgressRequest.AddDeviceId(builder:  builder, deviceId:  device_id);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UpdateUserProgressRequest> val_6 = Royal.Infrastructure.Services.Backend.Protocol.UpdateUserProgressRequest.EndUpdateUserProgressRequest(builder:  builder);
            val_6.Value = val_6.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UpdateUserProgressRequest>)val_6.Value;
        }
        public static void StartUpdateUserProgressRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  10);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddDeviceId(FlatBuffers.FlatBufferBuilder builder, int deviceId)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  0, x:  deviceId, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddUserProgressType(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.VectorOffset userProgressTypeOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  1, x:  userProgressTypeOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.VectorOffset CreateUserProgressTypeVector(FlatBuffers.FlatBufferBuilder builder, Royal.Infrastructure.Services.Backend.Protocol.UserProgressType[] data)
        {
            var val_5;
            builder.StartVector(elemSize:  1, count:  data.Length, alignment:  1);
            if(<0)
            {
                goto label_4;
            }
            
            int val_2 = data.Length & 4294967295;
            val_5 = (long)data.Length - 1;
            int val_3 = data.Length - 2;
            label_5:
            builder.AddByte(x:  data[val_5]);
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
        public static FlatBuffers.VectorOffset CreateUserProgressTypeVectorBlock(FlatBuffers.FlatBufferBuilder builder, Royal.Infrastructure.Services.Backend.Protocol.UserProgressType[] data)
        {
            builder.StartVector(elemSize:  1, count:  data.Length, alignment:  1);
            builder.Add<Royal.Infrastructure.Services.Backend.Protocol.UserProgressType>(x:  data);
            FlatBuffers.VectorOffset val_1 = builder.EndVector();
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_1.Value;
        }
        public static void StartUserProgressTypeVector(FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
            if(builder != null)
            {
                    builder.StartVector(elemSize:  1, count:  numElems, alignment:  1);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddUserProgress(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.VectorOffset userProgressOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  2, x:  userProgressOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.VectorOffset CreateUserProgressVector(FlatBuffers.FlatBufferBuilder builder, int[] data)
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
            builder.AddOffset(off:  data[((long)(int)((data.Length - 1))) << 2]);
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
        public static FlatBuffers.VectorOffset CreateUserProgressVectorBlock(FlatBuffers.FlatBufferBuilder builder, int[] data)
        {
            builder.StartVector(elemSize:  4, count:  data.Length, alignment:  4);
            builder.Add<System.Int32>(x:  data);
            FlatBuffers.VectorOffset val_1 = builder.EndVector();
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_1.Value;
        }
        public static void StartUserProgressVector(FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
            if(builder != null)
            {
                    builder.StartVector(elemSize:  4, count:  numElems, alignment:  4);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddKingsCupGroupId(FlatBuffers.FlatBufferBuilder builder, long kingsCupGroupId)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  3, x:  kingsCupGroupId, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddTeamId(FlatBuffers.FlatBufferBuilder builder, long teamId)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  4, x:  teamId, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddTeamBattleGroupId(FlatBuffers.FlatBufferBuilder builder, long teamBattleGroupId)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  5, x:  teamBattleGroupId, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddMadnessEventVersion(FlatBuffers.FlatBufferBuilder builder, int madnessEventVersion)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  6, x:  madnessEventVersion, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddForceData(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ForceData> forceDataOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  7, x:  forceDataOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddLadderOfferVersion(FlatBuffers.FlatBufferBuilder builder, int ladderOfferVersion)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  8, x:  ladderOfferVersion, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddRoyalPassVersion(FlatBuffers.FlatBufferBuilder builder, int royalPassVersion)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  9, x:  royalPassVersion, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UpdateUserProgressRequest> EndUpdateUserProgressRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
