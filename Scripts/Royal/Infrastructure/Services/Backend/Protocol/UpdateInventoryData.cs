using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct UpdateInventoryData : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public int Coins { get; }
        public int Stars { get; }
        public int Inbox { get; }
        public long InGameInventory { get; }
        public long PreLevelInventory { get; }
        public int Chest { get; }
        public long EventProgress { get; }
        public int UnlimitedRocketEndTime { get; }
        public int UnlimitedTntEndTime { get; }
        public int UnlimitedLightballEndTime { get; }
        public long RemainingBoosterTimes { get; }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassUserProgress> RoyalPassUserProgress { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.UpdateInventoryData GetRootAsUpdateInventoryData(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.UpdateInventoryData.GetRootAsUpdateInventoryData(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.UpdateInventoryData() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.UpdateInventoryData GetRootAsUpdateInventoryData(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.UpdateInventoryData obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.UpdateInventoryData() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528602877200] = _i;
            mem[1152921528602877208] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.UpdateInventoryData __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528602997392] = _i;
            mem[1152921528602997400] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.UpdateInventoryData() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public int get_Coins()
        {
        
        }
        public int get_Stars()
        {
        
        }
        public int get_Inbox()
        {
        
        }
        public long get_InGameInventory()
        {
        
        }
        public long get_PreLevelInventory()
        {
        
        }
        public int get_Chest()
        {
        
        }
        public long get_EventProgress()
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
        
        }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassUserProgress> get_RoyalPassUserProgress()
        {
            throw 36701290;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UpdateInventoryData> CreateUpdateInventoryData(FlatBuffers.FlatBufferBuilder builder, int coins = 0, int stars = 0, int inbox = 0, long in_game_inventory = 0, long pre_level_inventory = 0, int chest = 0, long event_progress = 0, int unlimited_rocket_end_time = 0, int unlimited_tnt_end_time = 0, int unlimited_lightball_end_time = 0, long remaining_booster_times = 0, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassUserProgress> royal_pass_user_progressOffset)
        {
            builder.StartObject(numfields:  12);
            Royal.Infrastructure.Services.Backend.Protocol.UpdateInventoryData.AddRemainingBoosterTimes(builder:  builder, remainingBoosterTimes:  remaining_booster_times);
            Royal.Infrastructure.Services.Backend.Protocol.UpdateInventoryData.AddEventProgress(builder:  builder, eventProgress:  event_progress);
            Royal.Infrastructure.Services.Backend.Protocol.UpdateInventoryData.AddPreLevelInventory(builder:  builder, preLevelInventory:  pre_level_inventory);
            Royal.Infrastructure.Services.Backend.Protocol.UpdateInventoryData.AddInGameInventory(builder:  builder, inGameInventory:  in_game_inventory);
            Royal.Infrastructure.Services.Backend.Protocol.UpdateInventoryData.AddRoyalPassUserProgress(builder:  builder, royalPassUserProgressOffset:  new FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassUserProgress>() {Value = royal_pass_user_progressOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.UpdateInventoryData.AddUnlimitedLightballEndTime(builder:  builder, unlimitedLightballEndTime:  unlimited_lightball_end_time);
            Royal.Infrastructure.Services.Backend.Protocol.UpdateInventoryData.AddUnlimitedTntEndTime(builder:  builder, unlimitedTntEndTime:  unlimited_tnt_end_time);
            Royal.Infrastructure.Services.Backend.Protocol.UpdateInventoryData.AddUnlimitedRocketEndTime(builder:  builder, unlimitedRocketEndTime:  unlimited_rocket_end_time);
            Royal.Infrastructure.Services.Backend.Protocol.UpdateInventoryData.AddChest(builder:  builder, chest:  chest);
            Royal.Infrastructure.Services.Backend.Protocol.UpdateInventoryData.AddInbox(builder:  builder, inbox:  inbox);
            Royal.Infrastructure.Services.Backend.Protocol.UpdateInventoryData.AddStars(builder:  builder, stars:  stars);
            Royal.Infrastructure.Services.Backend.Protocol.UpdateInventoryData.AddCoins(builder:  builder, coins:  coins);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UpdateInventoryData> val_2 = Royal.Infrastructure.Services.Backend.Protocol.UpdateInventoryData.EndUpdateInventoryData(builder:  builder);
            val_2.Value = val_2.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UpdateInventoryData>)val_2.Value;
        }
        public static void StartUpdateInventoryData(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  12);
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
        public static void AddStars(FlatBuffers.FlatBufferBuilder builder, int stars)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  1, x:  stars, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddInbox(FlatBuffers.FlatBufferBuilder builder, int inbox)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  2, x:  inbox, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddInGameInventory(FlatBuffers.FlatBufferBuilder builder, long inGameInventory)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  3, x:  inGameInventory, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddPreLevelInventory(FlatBuffers.FlatBufferBuilder builder, long preLevelInventory)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  4, x:  preLevelInventory, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddChest(FlatBuffers.FlatBufferBuilder builder, int chest)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  5, x:  chest, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddEventProgress(FlatBuffers.FlatBufferBuilder builder, long eventProgress)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  6, x:  eventProgress, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddUnlimitedRocketEndTime(FlatBuffers.FlatBufferBuilder builder, int unlimitedRocketEndTime)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  7, x:  unlimitedRocketEndTime, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddUnlimitedTntEndTime(FlatBuffers.FlatBufferBuilder builder, int unlimitedTntEndTime)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  8, x:  unlimitedTntEndTime, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddUnlimitedLightballEndTime(FlatBuffers.FlatBufferBuilder builder, int unlimitedLightballEndTime)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  9, x:  unlimitedLightballEndTime, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddRemainingBoosterTimes(FlatBuffers.FlatBufferBuilder builder, long remainingBoosterTimes)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  10, x:  remainingBoosterTimes, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddRoyalPassUserProgress(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassUserProgress> royalPassUserProgressOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  11, x:  royalPassUserProgressOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UpdateInventoryData> EndUpdateInventoryData(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
