using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct KingsCupInfo : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public long GroupId { get; }
        public Royal.Infrastructure.Services.Backend.Protocol.UserEventStatus Status { get; }
        public int Rank { get; }
        public long RemainingTime { get; }
        public long UnlimitedLivesEndTime { get; }
        public int UsersLength { get; }
        public int EventId { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.KingsCupInfo GetRootAsKingsCupInfo(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.KingsCupInfo.GetRootAsKingsCupInfo(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.KingsCupInfo() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.KingsCupInfo GetRootAsKingsCupInfo(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.KingsCupInfo obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.KingsCupInfo() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528478804496] = _i;
            mem[1152921528478804504] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.KingsCupInfo __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528478924688] = _i;
            mem[1152921528478924696] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.KingsCupInfo() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public long get_GroupId()
        {
        
        }
        public Royal.Infrastructure.Services.Backend.Protocol.UserEventStatus get_Status()
        {
        
        }
        public int get_Rank()
        {
        
        }
        public long get_RemainingTime()
        {
        
        }
        public long get_UnlimitedLivesEndTime()
        {
        
        }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.KingsCupUser> Users(int j)
        {
        
        }
        public int get_UsersLength()
        {
        
        }
        public int get_EventId()
        {
            throw 36703984;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.KingsCupInfo> CreateKingsCupInfo(FlatBuffers.FlatBufferBuilder builder, long group_id = 0, Royal.Infrastructure.Services.Backend.Protocol.UserEventStatus status = 0, int rank = 0, long remaining_time = 0, long unlimited_lives_end_time = 0, FlatBuffers.VectorOffset usersOffset, int event_id = 0)
        {
            builder.StartObject(numfields:  7);
            Royal.Infrastructure.Services.Backend.Protocol.KingsCupInfo.AddUnlimitedLivesEndTime(builder:  builder, unlimitedLivesEndTime:  unlimited_lives_end_time);
            Royal.Infrastructure.Services.Backend.Protocol.KingsCupInfo.AddRemainingTime(builder:  builder, remainingTime:  remaining_time);
            Royal.Infrastructure.Services.Backend.Protocol.KingsCupInfo.AddGroupId(builder:  builder, groupId:  group_id);
            Royal.Infrastructure.Services.Backend.Protocol.KingsCupInfo.AddEventId(builder:  builder, eventId:  event_id);
            Royal.Infrastructure.Services.Backend.Protocol.KingsCupInfo.AddUsers(builder:  builder, usersOffset:  new FlatBuffers.VectorOffset() {Value = usersOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.KingsCupInfo.AddRank(builder:  builder, rank:  rank);
            Royal.Infrastructure.Services.Backend.Protocol.KingsCupInfo.AddStatus(builder:  builder, status:  status);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.KingsCupInfo> val_2 = Royal.Infrastructure.Services.Backend.Protocol.KingsCupInfo.EndKingsCupInfo(builder:  builder);
            val_2.Value = val_2.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.KingsCupInfo>)val_2.Value;
        }
        public static void StartKingsCupInfo(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  7);
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
        public static void AddStatus(FlatBuffers.FlatBufferBuilder builder, Royal.Infrastructure.Services.Backend.Protocol.UserEventStatus status)
        {
            if(builder != null)
            {
                    builder.AddSbyte(o:  1, x:  status, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddRank(FlatBuffers.FlatBufferBuilder builder, int rank)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  2, x:  rank, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddRemainingTime(FlatBuffers.FlatBufferBuilder builder, long remainingTime)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  3, x:  remainingTime, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddUnlimitedLivesEndTime(FlatBuffers.FlatBufferBuilder builder, long unlimitedLivesEndTime)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  4, x:  unlimitedLivesEndTime, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddUsers(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.VectorOffset usersOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  5, x:  usersOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.VectorOffset CreateUsersVector(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.KingsCupUser>[] data)
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
        public static FlatBuffers.VectorOffset CreateUsersVectorBlock(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.KingsCupUser>[] data)
        {
            builder.StartVector(elemSize:  4, count:  data.Length, alignment:  4);
            builder.Add<FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.KingsCupUser>>(x:  data);
            FlatBuffers.VectorOffset val_1 = builder.EndVector();
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_1.Value;
        }
        public static void StartUsersVector(FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
            if(builder != null)
            {
                    builder.StartVector(elemSize:  4, count:  numElems, alignment:  4);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddEventId(FlatBuffers.FlatBufferBuilder builder, int eventId)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  6, x:  eventId, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.KingsCupInfo> EndKingsCupInfo(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
