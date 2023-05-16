using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct CurrentUserInventory : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public int Coins { get; }
        public int Chest { get; }
        public long InGameInventory { get; }
        public long PreLevelInventory { get; }
        public long FullLivesTimeInMs { get; }
        public long UnlimitedLivesEndTimeInMs { get; }
        public int UnlimitedRocketEndTime { get; }
        public int UnlimitedTntEndTime { get; }
        public int UnlimitedLightballEndTime { get; }
        public long RemainingBoosterTimes { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.CurrentUserInventory GetRootAsCurrentUserInventory(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.CurrentUserInventory.GetRootAsCurrentUserInventory(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.CurrentUserInventory() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.CurrentUserInventory GetRootAsCurrentUserInventory(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.CurrentUserInventory obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.CurrentUserInventory() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528432319888] = _i;
            mem[1152921528432319896] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.CurrentUserInventory __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528432440080] = _i;
            mem[1152921528432440088] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.CurrentUserInventory() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public int get_Coins()
        {
        
        }
        public int get_Chest()
        {
        
        }
        public long get_InGameInventory()
        {
        
        }
        public long get_PreLevelInventory()
        {
        
        }
        public long get_FullLivesTimeInMs()
        {
        
        }
        public long get_UnlimitedLivesEndTimeInMs()
        {
        
        }
        public int get_UnlimitedRocketEndTime()
        {
        
        }
        public int get_UnlimitedTntEndTime()
        {
        
        }
        public int get_UnlimitedLightballEndTime()
        {
        
        }
        public long get_RemainingBoosterTimes()
        {
            throw 36702526;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.CurrentUserInventory> CreateCurrentUserInventory(FlatBuffers.FlatBufferBuilder builder, int coins = 0, int chest = 0, long in_game_inventory = 0, long pre_level_inventory = 0, long full_lives_time_in_ms = 0, long unlimited_lives_end_time_in_ms = 0, int unlimited_rocket_end_time = 0, int unlimited_tnt_end_time = 0, int unlimited_lightball_end_time = 0, long remaining_booster_times = 0)
        {
            builder.StartObject(numfields:  10);
            Royal.Infrastructure.Services.Backend.Protocol.CurrentUserInventory.AddRemainingBoosterTimes(builder:  builder, remainingBoosterTimes:  remaining_booster_times);
            Royal.Infrastructure.Services.Backend.Protocol.CurrentUserInventory.AddUnlimitedLivesEndTimeInMs(builder:  builder, unlimitedLivesEndTimeInMs:  unlimited_lives_end_time_in_ms);
            Royal.Infrastructure.Services.Backend.Protocol.CurrentUserInventory.AddFullLivesTimeInMs(builder:  builder, fullLivesTimeInMs:  full_lives_time_in_ms);
            Royal.Infrastructure.Services.Backend.Protocol.CurrentUserInventory.AddPreLevelInventory(builder:  builder, preLevelInventory:  pre_level_inventory);
            Royal.Infrastructure.Services.Backend.Protocol.CurrentUserInventory.AddInGameInventory(builder:  builder, inGameInventory:  in_game_inventory);
            Royal.Infrastructure.Services.Backend.Protocol.CurrentUserInventory.AddUnlimitedLightballEndTime(builder:  builder, unlimitedLightballEndTime:  unlimited_lightball_end_time);
            Royal.Infrastructure.Services.Backend.Protocol.CurrentUserInventory.AddUnlimitedTntEndTime(builder:  builder, unlimitedTntEndTime:  unlimited_tnt_end_time);
            Royal.Infrastructure.Services.Backend.Protocol.CurrentUserInventory.AddUnlimitedRocketEndTime(builder:  builder, unlimitedRocketEndTime:  unlimited_rocket_end_time);
            Royal.Infrastructure.Services.Backend.Protocol.CurrentUserInventory.AddChest(builder:  builder, chest:  chest);
            Royal.Infrastructure.Services.Backend.Protocol.CurrentUserInventory.AddCoins(builder:  builder, coins:  coins);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.CurrentUserInventory> val_1 = Royal.Infrastructure.Services.Backend.Protocol.CurrentUserInventory.EndCurrentUserInventory(builder:  builder);
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.CurrentUserInventory>)val_1.Value;
        }
        public static void StartCurrentUserInventory(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  10);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddCoins(FlatBuffers.FlatBufferBuilder builder, int coins)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  0, x:  coins, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddChest(FlatBuffers.FlatBufferBuilder builder, int chest)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  1, x:  chest, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddInGameInventory(FlatBuffers.FlatBufferBuilder builder, long inGameInventory)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  2, x:  inGameInventory, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddPreLevelInventory(FlatBuffers.FlatBufferBuilder builder, long preLevelInventory)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  3, x:  preLevelInventory, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddFullLivesTimeInMs(FlatBuffers.FlatBufferBuilder builder, long fullLivesTimeInMs)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  4, x:  fullLivesTimeInMs, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddUnlimitedLivesEndTimeInMs(FlatBuffers.FlatBufferBuilder builder, long unlimitedLivesEndTimeInMs)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  5, x:  unlimitedLivesEndTimeInMs, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddUnlimitedRocketEndTime(FlatBuffers.FlatBufferBuilder builder, int unlimitedRocketEndTime)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  6, x:  unlimitedRocketEndTime, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddUnlimitedTntEndTime(FlatBuffers.FlatBufferBuilder builder, int unlimitedTntEndTime)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  7, x:  unlimitedTntEndTime, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddUnlimitedLightballEndTime(FlatBuffers.FlatBufferBuilder builder, int unlimitedLightballEndTime)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  8, x:  unlimitedLightballEndTime, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddRemainingBoosterTimes(FlatBuffers.FlatBufferBuilder builder, long remainingBoosterTimes)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  9, x:  remainingBoosterTimes, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.CurrentUserInventory> EndCurrentUserInventory(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
