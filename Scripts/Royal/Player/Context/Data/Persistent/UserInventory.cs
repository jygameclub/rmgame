using UnityEngine;

namespace Royal.Player.Context.Data.Persistent
{
    public class UserInventory
    {
        // Fields
        public const byte MaxCloche = 3;
        public const short ClocheUnlockLevel = 32;
        private const short MaxBoosterDigit = 16;
        private const short ClocheStartIndex = 48;
        private const short ClocheEndIndex = 49;
        private const short StoryLevelStartIndex = 50;
        private const short StoryLevelEndIndex = 50;
        private const short SkillStartIndex = 51;
        private const short SkillEndIndex = 53;
        private const short TryCountStartIndex = 54;
        private const short TryCountEndIndex = 60;
        private const short MaxTryCount = 127;
        private const short UnlimitedRocketPausedTimeStartIndex = 0;
        private const short UnlimitedRocketPausedTimeEndIndex = 15;
        private const short UnlimitedTntPausedTimeStartIndex = 16;
        private const short UnlimitedTntPausedTimeEndIndex = 31;
        private const short UnlimitedLightballPausedTimeStartIndex = 32;
        private const short UnlimitedLightballPausedTimeEndIndex = 47;
        private int <Coins>k__BackingField;
        private int <Stars>k__BackingField;
        private int <Inbox>k__BackingField;
        private int <Chest>k__BackingField;
        private long <EventInventory>k__BackingField;
        private long <InGameInventory>k__BackingField;
        private long <PreLevelInventory>k__BackingField;
        private int <RocketEndTime>k__BackingField;
        private int <TntEndTime>k__BackingField;
        private int <LightBallEndTime>k__BackingField;
        private long <RemainingBoosterTimes>k__BackingField;
        private Royal.Player.Context.Data.Persistent.RoyalPassProgress <RoyalPass>k__BackingField;
        private System.Action OnStarUpdated;
        private System.Action OnCoinUpdated;
        private System.Action OnChestUpdated;
        
        // Properties
        public int Coins { get; set; }
        public int Stars { get; set; }
        public int Inbox { get; set; }
        public int Chest { get; set; }
        public long EventInventory { get; set; }
        public long InGameInventory { get; set; }
        public long PreLevelInventory { get; set; }
        public int RocketEndTime { get; set; }
        public int TntEndTime { get; set; }
        public int LightBallEndTime { get; set; }
        public long RemainingBoosterTimes { get; set; }
        public Royal.Player.Context.Data.Persistent.RoyalPassProgress RoyalPass { get; set; }
        
        // Methods
        public int get_Coins()
        {
            return (int)this.<Coins>k__BackingField;
        }
        public void set_Coins(int value)
        {
            this.<Coins>k__BackingField = value;
        }
        public int get_Stars()
        {
            return (int)this.<Stars>k__BackingField;
        }
        public void set_Stars(int value)
        {
            this.<Stars>k__BackingField = value;
        }
        public int get_Inbox()
        {
            return (int)this.<Inbox>k__BackingField;
        }
        public void set_Inbox(int value)
        {
            this.<Inbox>k__BackingField = value;
        }
        public int get_Chest()
        {
            return (int)this.<Chest>k__BackingField;
        }
        public void set_Chest(int value)
        {
            this.<Chest>k__BackingField = value;
        }
        public long get_EventInventory()
        {
            return (long)this.<EventInventory>k__BackingField;
        }
        public void set_EventInventory(long value)
        {
            this.<EventInventory>k__BackingField = value;
        }
        public long get_InGameInventory()
        {
            return (long)this.<InGameInventory>k__BackingField;
        }
        public void set_InGameInventory(long value)
        {
            this.<InGameInventory>k__BackingField = value;
        }
        public long get_PreLevelInventory()
        {
            return (long)this.<PreLevelInventory>k__BackingField;
        }
        public void set_PreLevelInventory(long value)
        {
            this.<PreLevelInventory>k__BackingField = value;
        }
        public int get_RocketEndTime()
        {
            return (int)this.<RocketEndTime>k__BackingField;
        }
        public void set_RocketEndTime(int value)
        {
            this.<RocketEndTime>k__BackingField = value;
        }
        public int get_TntEndTime()
        {
            return (int)this.<TntEndTime>k__BackingField;
        }
        public void set_TntEndTime(int value)
        {
            this.<TntEndTime>k__BackingField = value;
        }
        public int get_LightBallEndTime()
        {
            return (int)this.<LightBallEndTime>k__BackingField;
        }
        public void set_LightBallEndTime(int value)
        {
            this.<LightBallEndTime>k__BackingField = value;
        }
        public long get_RemainingBoosterTimes()
        {
            return (long)this.<RemainingBoosterTimes>k__BackingField;
        }
        public void set_RemainingBoosterTimes(long value)
        {
            this.<RemainingBoosterTimes>k__BackingField = value;
        }
        public Royal.Player.Context.Data.Persistent.RoyalPassProgress get_RoyalPass()
        {
            Royal.Player.Context.Data.Persistent.RoyalPassProgress val_0;
            val_0.<GoldProgress>k__BackingField = ;
            val_0.step = ;
            val_0.<PassProgress>k__BackingField = this.<RoyalPass>k__BackingField;
            return val_0;
        }
        public void set_RoyalPass(Royal.Player.Context.Data.Persistent.RoyalPassProgress value)
        {
            mem[1152921524237914976] = value.<GoldProgress>k__BackingField;
            mem[1152921524237914992] = value.step;
            this.<RoyalPass>k__BackingField = value.<PassProgress>k__BackingField;
        }
        public void add_OnStarUpdated(System.Action value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnStarUpdated, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnStarUpdated != 1152921524238043376);
            
            return;
            label_2:
        }
        public void remove_OnStarUpdated(System.Action value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnStarUpdated, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnStarUpdated != 1152921524238179952);
            
            return;
            label_2:
        }
        public void add_OnCoinUpdated(System.Action value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnCoinUpdated, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnCoinUpdated != 1152921524238316536);
            
            return;
            label_2:
        }
        public void remove_OnCoinUpdated(System.Action value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnCoinUpdated, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnCoinUpdated != 1152921524238453112);
            
            return;
            label_2:
        }
        public void add_OnChestUpdated(System.Action value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnChestUpdated, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnChestUpdated != 1152921524238589696);
            
            return;
            label_2:
        }
        public void remove_OnChestUpdated(System.Action value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnChestUpdated, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnChestUpdated != 1152921524238726272);
            
            return;
            label_2:
        }
        public void UpdateInbox(int inboxItemCount)
        {
            object[] val_1 = new object[2];
            val_1[0] = this.<Inbox>k__BackingField;
            val_1[1] = inboxItemCount;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  9, log:  "Inbox: {0} -> {1}", values:  val_1);
            int val_2 = (inboxItemCount < 15) ? inboxItemCount : 15;
            this.<Inbox>k__BackingField = val_2;
            bool val_3 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetInt(key:  "Inbox", value:  val_2);
        }
        public void AddInbox(int delta)
        {
            delta = (this.<Inbox>k__BackingField) + delta;
            this.UpdateInbox(inboxItemCount:  delta);
        }
        public bool HasEnoughStars(int delta)
        {
            return (bool)((this.<Stars>k__BackingField) >= delta) ? 1 : 0;
        }
        public void UpdateStars(int newStars)
        {
            object[] val_1 = new object[2];
            val_1[0] = this.<Stars>k__BackingField;
            val_1[1] = newStars;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  9, log:  "Stars: {0} -> {1}", values:  val_1);
            int val_2 = newStars & (~(newStars >> 31));
            this.<Stars>k__BackingField = val_2;
            bool val_3 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetInt(key:  "Stars", value:  val_2);
            if(this.OnStarUpdated == null)
            {
                    return;
            }
            
            this.OnStarUpdated.Invoke();
        }
        public void AddStars(int delta)
        {
            delta = (this.<Stars>k__BackingField) + delta;
            this.UpdateStars(newStars:  delta);
        }
        public bool SpendStars(int delta)
        {
            if((delta & 2147483648) != 0)
            {
                    return (bool)0;
            }
            
            delta = (this.<Stars>k__BackingField) - delta;
            if()
            {
                    return (bool)0;
            }
            
            this.UpdateStars(newStars:  delta);
            0 = 1;
            return (bool)0;
        }
        public bool HasEnoughCoins(int delta)
        {
            return (bool)((this.<Coins>k__BackingField) >= delta) ? 1 : 0;
        }
        public void UpdateCoins(int newCoins)
        {
            object[] val_1 = new object[2];
            val_1[0] = this.<Coins>k__BackingField;
            val_1[1] = newCoins;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  9, log:  "Coins: {0} -> {1}", values:  val_1);
            int val_2 = newCoins & (~(newCoins >> 31));
            this.<Coins>k__BackingField = val_2;
            bool val_3 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetLong(key:  "Coins", value:  val_2);
            if(this.OnCoinUpdated == null)
            {
                    return;
            }
            
            this.OnCoinUpdated.Invoke();
        }
        public void AddCoins(int delta)
        {
            delta = (this.<Coins>k__BackingField) + delta;
            this.UpdateCoins(newCoins:  delta);
        }
        public bool SpendCoins(Royal.Player.Context.Data.Session.SpendingData spendingData)
        {
            var val_2;
            spendingData.<CoinAmount>k__BackingField = (this.<Coins>k__BackingField) - (spendingData.<CoinAmount>k__BackingField);
            if()
            {
                    val_2 = 0;
                return (bool)val_2;
            }
            
            this.UpdateCoins(newCoins:  spendingData.<CoinAmount>k__BackingField);
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Analytics.AnalyticsManager>(id:  17).Spending(spendingData:  new Royal.Player.Context.Data.Session.SpendingData() {<CoinAmount>k__BackingField = spendingData.<CoinAmount>k__BackingField, <SpendingName>k__BackingField = spendingData.<SpendingName>k__BackingField});
            val_2 = 1;
            return (bool)val_2;
        }
        public int GetPausedUnlimitedLivesTimeInMinutes()
        {
            return (int)this;
        }
        public void UpdatePausedUnlimitedLivesTimeInMinutes(int lifeTimeMinutes)
        {
            this.UpdateChest(newChest:  Royal.Infrastructure.Utils.Math.BitwiseOperations.UpdateInt(toNumber:  this.<Chest>k__BackingField, number:  lifeTimeMinutes, fromPosition:  16, toPosition:  31));
        }
        public int GetPiggy()
        {
            return (int)this.<Chest>k__BackingField;
        }
        public void UpdatePiggy(int newPiggy)
        {
            this.UpdateChest(newChest:  Royal.Infrastructure.Utils.Math.BitwiseOperations.UpdateInt(toNumber:  this.<Chest>k__BackingField, number:  UnityEngine.Mathf.Clamp(value:  newPiggy, min:  0, max:  136), fromPosition:  0, toPosition:  15));
        }
        public void UpdateChest(int newChest)
        {
            object[] val_1 = new object[2];
            val_1[0] = this.<Chest>k__BackingField;
            val_1[1] = newChest;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  9, log:  "Chest: {0} -> {1}", values:  val_1);
            this.<Chest>k__BackingField = newChest;
            bool val_2 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetInt(key:  "Chest", value:  newChest);
            if(this.OnChestUpdated == null)
            {
                    return;
            }
            
            this.OnChestUpdated.Invoke();
        }
        public Royal.Player.Context.Data.Persistent.MadnessProgress GetMadness()
        {
            int val_1 = (ulong)((this.<EventInventory>k__BackingField) >> 15) & 131071;
            val_1 = val_1 & 114688;
            return new Royal.Player.Context.Data.Persistent.MadnessProgress() {step = (ulong)((this.<EventInventory>k__BackingField) >> 14) & 63, count = val_1, eventId = (ulong)((this.<EventInventory>k__BackingField) >> 20) & 511};
        }
        public void UpdateMadness(Royal.Player.Context.Data.Persistent.MadnessProgress madness)
        {
            this.UpdateEventInventory(newEventInventory:  null);
        }
        public Royal.Player.Context.Data.Persistent.LadderOfferProgress GetLadderOffer()
        {
            .step = (ulong)((this.<EventInventory>k__BackingField) >> 32) & 63;
            .eventId = (ulong)((this.<EventInventory>k__BackingField) >> 38) & 511;
            .availability = (ulong)((this.<EventInventory>k__BackingField) >> 47) & 7;
            return (Royal.Player.Context.Data.Persistent.LadderOfferProgress)new Royal.Player.Context.Data.Persistent.LadderOfferProgress();
        }
        public void UpdateLadderOffer(Royal.Player.Context.Data.Persistent.LadderOfferProgress ladderOffer)
        {
            this.UpdateEventInventory(newEventInventory:  ladderOffer.UpdateLong(inventory:  this.<EventInventory>k__BackingField));
        }
        public void UpdateEventInventory(long newEventInventory)
        {
            object[] val_1 = new object[2];
            val_1[0] = this.<EventInventory>k__BackingField;
            val_1[1] = newEventInventory;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  9, log:  "Event: {0} -> {1}", values:  val_1);
            this.<EventInventory>k__BackingField = newEventInventory;
            bool val_2 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetLong(key:  "EventInventory", value:  newEventInventory);
        }
        public void UpdateRoyalPass(Royal.Player.Context.Data.Persistent.RoyalPassProgress royalPassProgress)
        {
            object[] val_1 = new object[2];
            val_1[0] = this.<RoyalPass>k__BackingField;
            val_1[1] = royalPassProgress.<PassProgress>k__BackingField;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  9, log:  "RoyalPass: {0} -> {1}", values:  val_1);
            this.<RoyalPass>k__BackingField = royalPassProgress.<GoldProgress>k__BackingField;
            this.<RoyalPass>k__BackingField = royalPassProgress.step;
            this.<RoyalPass>k__BackingField = royalPassProgress.<PassProgress>k__BackingField;
            bool val_2 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetLong(key:  "RoyalPassProgress", value:  this.<RoyalPass>k__BackingField);
            bool val_3 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetLong(key:  "RoyalPassFree", value:  this.<RoyalPass>k__BackingField);
            bool val_4 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetLong(key:  "RoyalPassGold", value:  this.<RoyalPass>k__BackingField);
        }
        public void UpdateRoyalPassFromServer(System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassUserProgress> royalPassUserProgress)
        {
            bool val_5 = royalPassUserProgress.HasValue;
            if((royalPassUserProgress.HasValue + 16) == 0)
            {
                    return;
            }
            
            if((royalPassUserProgress.HasValue + 16) != 0)
            {
                
            }
            
            if((royalPassUserProgress.HasValue + 16) != 0)
            {
                
            }
            
            this.UpdateRoyalPass(royalPassProgress:  new Royal.Player.Context.Data.Persistent.RoyalPassProgress() {isGold = false, eventId = (-) & , step = (-) & , count = (-) & , tutorialState = (-) & });
            if(Royal.Player.Context.Units.RoyalPassManager.ShouldShowFirstTimeTutorial() == true)
            {
                    return;
            }
            
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.RoyalPassManager>(id:  12).ResetTutorialCache();
        }
        public void UpdateRoyalPassIsGold(bool isGold)
        {
            Royal.Player.Context.Data.Persistent.RoyalPassProgress val_6 = this.<RoyalPass>k__BackingField;
            val_6 = val_6 & (-2);
            object val_2 = (isGold != true) ? (val_6 | 1) : (val_6);
            object[] val_3 = new object[2];
            val_3[0] = this.<RoyalPass>k__BackingField;
            val_3[1] = val_2;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  9, log:  "RoyalPass: {0} -> {1}", values:  val_3);
            this.<RoyalPass>k__BackingField = val_2;
            mem[1152921524241540632] = ???;
            mem[1152921524241540648] = isGold;
            mem[1152921524241540664] = ???;
            mem[1152921524241540649] = ???;
            bool val_5 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetLong(key:  "RoyalPassProgress", value:  val_2);
        }
        public int GetCloche()
        {
            return (int)W8 & 3;
        }
        public void ResetCloche()
        {
            if(((this.<PreLevelInventory>k__BackingField) & 844424930131968) != 0)
            {
                    return;
            }
            
            this.UpdatePreLevelInventory(newPreLevelInventory:  Royal.Infrastructure.Utils.Math.BitwiseOperations.UpdateLong(toNumber:  this.<PreLevelInventory>k__BackingField, number:  0, fromPosition:  48, toPosition:  49));
        }
        public void UpdateCloche(int amount)
        {
            this.UpdatePreLevelInventory(newPreLevelInventory:  Royal.Infrastructure.Utils.Math.BitwiseOperations.UpdateLong(toNumber:  this.<PreLevelInventory>k__BackingField, number:  UnityEngine.Mathf.Clamp(value:  amount, min:  0, max:  3), fromPosition:  48, toPosition:  49));
        }
        public bool IsStoryLevelPlayed()
        {
            return (bool)(uint)(((uint)((W8>>2) & 0x1)) >> 2) & 1;
        }
        public void SetStoryLevel()
        {
            UnityEngine.PlayerPrefs.DeleteKey(key:  "SLTC");
            this.UpdatePreLevelInventory(newPreLevelInventory:  Royal.Infrastructure.Utils.Math.BitwiseOperations.UpdateLong(toNumber:  this.<PreLevelInventory>k__BackingField, number:  1, fromPosition:  50, toPosition:  50));
        }
        public void ResetStoryLevel()
        {
            this.UpdatePreLevelInventory(newPreLevelInventory:  Royal.Infrastructure.Utils.Math.BitwiseOperations.UpdateLong(toNumber:  this.<PreLevelInventory>k__BackingField, number:  0, fromPosition:  50, toPosition:  50));
        }
        private void UpdateStoryLevel(int level)
        {
            this.UpdatePreLevelInventory(newPreLevelInventory:  Royal.Infrastructure.Utils.Math.BitwiseOperations.UpdateLong(toNumber:  this.<PreLevelInventory>k__BackingField, number:  level, fromPosition:  50, toPosition:  50));
        }
        public void AddBooster(Royal.Scenes.Game.Mechanics.Boosters.BoosterType type, int delta)
        {
            this.SetBooster(type:  type, delta:  delta);
        }
        public void FillBoosters(Royal.Scenes.Game.Mechanics.Boosters.BoosterType boosterType)
        {
            int val_1 = this.GetBooster(type:  boosterType);
            if(val_1 > 2)
            {
                    return;
            }
            
            SetBooster(type:  boosterType, delta:  3 - val_1);
        }
        public void UseBooster(Royal.Scenes.Game.Mechanics.Boosters.BoosterType type, int delta)
        {
            this.SetBooster(type:  type, delta:  -delta);
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Analytics.AnalyticsManager>(id:  17).BoosterUse(boosterType:  type);
        }
        public int GetBooster(Royal.Scenes.Game.Mechanics.Boosters.BoosterType type)
        {
            if((type - 1) > 6)
            {
                    return 0;
            }
            
            var val_2 = 36601096 + ((type - 1)) << 2;
            val_2 = val_2 + 36601096;
            goto (36601096 + ((type - 1)) << 2 + 36601096);
        }
        private void SetBooster(Royal.Scenes.Game.Mechanics.Boosters.BoosterType type, int delta)
        {
            if((type - 1) > 6)
            {
                    return;
            }
            
            var val_10 = 36601068 + ((type - 1)) << 2;
            int val_3 = (this.GetBooster(type:  type)) + delta;
            type = val_3 & (~(val_3 >> 31));
            val_10 = val_10 + 36601068;
            goto (36601068 + ((type - 1)) << 2 + 36601068);
        }
        private static int ParseBooster(long inventory, int shift)
        {
            var val_3 = 15;
            var val_2 = 1;
            val_2 = val_2 - (shift << 4);
            val_3 = val_2 + val_3;
            val_3 = val_3 & 48;
            val_3 = 0 << val_3;
            inventory = (inventory >> X11) & (~val_3);
            return (int)inventory;
        }
        private static long UpdateBooster(long inventory, int amount, int shift)
        {
            return Royal.Infrastructure.Utils.Math.BitwiseOperations.UpdateLong(toNumber:  inventory, number:  amount, fromPosition:  shift << 4, toPosition:  15);
        }
        public void UpdateInGameInventory(long newInGameInventory)
        {
            this.<InGameInventory>k__BackingField = newInGameInventory;
            bool val_1 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetLong(key:  "InGameInventory", value:  newInGameInventory);
        }
        public void UpdatePreLevelInventory(long newPreLevelInventory)
        {
            this.<PreLevelInventory>k__BackingField = newPreLevelInventory;
            bool val_1 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetLong(key:  "PreLevelInventory", value:  newPreLevelInventory);
        }
        public void UpdateRemainingBoosterTimes(long newRemainingBoosterTimes)
        {
            this.<RemainingBoosterTimes>k__BackingField = newRemainingBoosterTimes;
            bool val_1 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetLong(key:  "RemainingBoosterTimes", value:  newRemainingBoosterTimes);
        }
        public int GetPausedUnlimitedBoosterTimeInMinutes(Royal.Scenes.Game.Mechanics.Boosters.BoosterType boosterType)
        {
            var val_4;
            var val_5;
            Royal.Scenes.Game.Mechanics.Boosters.BoosterType val_1 = boosterType - 1;
            if(val_1 <= 2)
            {
                    val_4 = val_1 << 4;
                val_5 = val_4 + 16;
            }
            else
            {
                    val_4 = 0;
                val_5 = 1;
            }
            
            val_5 = val_5 - val_4;
            val_5 = val_5 & 49;
            var val_3 = val_4;
            val_5 = 0 << val_5;
            val_3 = (this.<RemainingBoosterTimes>k__BackingField) >> val_3;
            return (int)val_3 & (~val_5);
        }
        public void UpdatePausedUnlimitedBoosterTimeInMinutes(Royal.Scenes.Game.Mechanics.Boosters.BoosterType boosterType, int lifeTimeMinutes)
        {
            var val_4;
            var val_5;
            Royal.Scenes.Game.Mechanics.Boosters.BoosterType val_1 = boosterType - 1;
            if(val_1 <= 2)
            {
                    val_4 = val_1 << 4;
            }
            else
            {
                    val_5 = 0;
                val_4 = 0;
            }
            
            this.UpdateRemainingBoosterTimes(newRemainingBoosterTimes:  Royal.Infrastructure.Utils.Math.BitwiseOperations.UpdateLong(toNumber:  this.<RemainingBoosterTimes>k__BackingField, number:  lifeTimeMinutes, fromPosition:  0, toPosition:  0));
        }
        public void ResetTimes()
        {
            this.UpdateRocketEndTime(endTime:  0);
            this.UpdateTntEndTime(endTime:  0);
            this.UpdateLightballEndTime(endTime:  0);
            this.UpdateChest(newChest:  Royal.Infrastructure.Utils.Math.BitwiseOperations.UpdateInt(toNumber:  this.<Chest>k__BackingField, number:  0, fromPosition:  16, toPosition:  31));
            this.UpdateRemainingBoosterTimes(newRemainingBoosterTimes:  0);
        }
        public int RemainingTime(Royal.Scenes.Game.Mechanics.Boosters.BoosterType type)
        {
            int val_4;
            var val_5;
            if((val_1.<IsOfflineClientTimeTakenBack>k__BackingField) != false)
            {
                    return 0;
            }
            
            if(type == 3)
            {
                goto label_5;
            }
            
            if(type == 2)
            {
                goto label_6;
            }
            
            if(type != 1)
            {
                goto label_7;
            }
            
            val_4 = this.<RocketEndTime>k__BackingField;
            goto label_9;
            label_5:
            val_4 = this.<LightBallEndTime>k__BackingField;
            goto label_9;
            label_6:
            val_4 = this.<TntEndTime>k__BackingField;
            label_9:
            val_5 = val_4 - (Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.TimeHelper>(id:  14).CurrentServerTimeInSeconds());
            return UnityEngine.Mathf.Max(a:  0, b:  0);
            label_7:
            val_5 = 0;
            return UnityEngine.Mathf.Max(a:  0, b:  0);
        }
        public void AddTime(Royal.Scenes.Game.Mechanics.Boosters.BoosterType boosterType, int deltaSeconds)
        {
            var val_7;
            var val_8;
            if(deltaSeconds < 1)
            {
                    return;
            }
            
            long val_2 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.TimeHelper>(id:  14).CurrentServerTimeInSeconds();
            if(boosterType == 3)
            {
                goto label_5;
            }
            
            if(boosterType == 2)
            {
                goto label_6;
            }
            
            if(boosterType != 1)
            {
                goto label_7;
            }
            
            int val_7 = val_2;
            val_7 = (UnityEngine.Mathf.Max(a:  this.<RocketEndTime>k__BackingField, b:  val_7)) + deltaSeconds;
            this.UpdateRocketEndTime(endTime:  val_7);
            val_7 = 0;
            val_8 = 16;
            goto label_16;
            label_6:
            int val_8 = val_2;
            val_8 = (UnityEngine.Mathf.Max(a:  this.<TntEndTime>k__BackingField, b:  val_8)) + deltaSeconds;
            this.UpdateTntEndTime(endTime:  val_8);
            val_7 = 16;
            val_8 = 32;
            goto label_16;
            label_5:
            int val_9 = val_2;
            val_9 = (UnityEngine.Mathf.Max(a:  this.<LightBallEndTime>k__BackingField, b:  val_9)) + deltaSeconds;
            this.UpdateLightballEndTime(endTime:  val_9);
            val_7 = 32;
            val_8 = 48;
            goto label_16;
            label_7:
            val_7 = 0;
            val_8 = 1;
            label_16:
            val_8 = val_8 - val_7;
            val_8 = val_8 & 49;
            val_8 = 0 << val_8;
            val_7 = (this.<RemainingBoosterTimes>k__BackingField) >> val_7;
            val_7 = val_7 & (~val_8);
            if(val_7 < 1)
            {
                    return;
            }
            
            this.UpdatePausedUnlimitedBoosterTimeInMinutes(boosterType:  boosterType, lifeTimeMinutes:  0 + val_7);
        }
        public void UpdateRocketEndTime(int endTime)
        {
            object[] val_1 = new object[2];
            val_1[0] = this.<RocketEndTime>k__BackingField;
            val_1[1] = endTime;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  9, log:  "RocketEndTime: {0} -> {1}", values:  val_1);
            this.<RocketEndTime>k__BackingField = endTime;
            bool val_2 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetLong(key:  "RET", value:  (long)endTime);
        }
        public void UpdateTntEndTime(int endTime)
        {
            object[] val_1 = new object[2];
            val_1[0] = this.<TntEndTime>k__BackingField;
            val_1[1] = endTime;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  9, log:  "TntEndTime: {0} -> {1}", values:  val_1);
            this.<TntEndTime>k__BackingField = endTime;
            bool val_2 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetLong(key:  "TET", value:  (long)endTime);
        }
        public void UpdateLightballEndTime(int endTime)
        {
            object[] val_1 = new object[2];
            val_1[0] = this.<LightBallEndTime>k__BackingField;
            val_1[1] = endTime;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  9, log:  "LightballEndTime: {0} -> {1}", values:  val_1);
            this.<LightBallEndTime>k__BackingField = endTime;
            bool val_2 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetLong(key:  "LET", value:  (long)endTime);
        }
        public bool HasUnlimitedBooster()
        {
            var val_4;
            if((val_1.<IsOfflineClientTimeTakenBack>k__BackingField) != false)
            {
                    val_4 = 0;
                return (bool)(val_2 < (this.<LightBallEndTime>k__BackingField)) ? 1 : 0;
            }
            
            long val_2 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.TimeHelper>(id:  14).CurrentServerTimeInSeconds();
            if(val_2 >= (this.<RocketEndTime>k__BackingField))
            {
                    if(val_2 >= (this.<TntEndTime>k__BackingField))
            {
                    return (bool)(val_2 < (this.<LightBallEndTime>k__BackingField)) ? 1 : 0;
            }
            
            }
            
            val_4 = 1;
            return (bool)(val_2 < (this.<LightBallEndTime>k__BackingField)) ? 1 : 0;
        }
        public int GetTryCount()
        {
            return (int)(ulong)((this.<PreLevelInventory>k__BackingField) >> 54) & 127;
        }
        public void ResetTryCount()
        {
            if(((this.<PreLevelInventory>k__BackingField) & 2287828610704211968) != 0)
            {
                    return;
            }
            
            this.UpdatePreLevelInventory(newPreLevelInventory:  Royal.Infrastructure.Utils.Math.BitwiseOperations.UpdateLong(toNumber:  this.<PreLevelInventory>k__BackingField, number:  0, fromPosition:  54, toPosition:  60));
        }
        public void UpdateTryCount(int amount)
        {
            this.UpdatePreLevelInventory(newPreLevelInventory:  Royal.Infrastructure.Utils.Math.BitwiseOperations.UpdateLong(toNumber:  this.<PreLevelInventory>k__BackingField, number:  UnityEngine.Mathf.Clamp(value:  amount, min:  0, max:  127), fromPosition:  54, toPosition:  60));
        }
        public Royal.Player.Context.Units.UserSkill GetSkill()
        {
            return (Royal.Player.Context.Units.UserSkill)(ulong)((this.<PreLevelInventory>k__BackingField) >> 51) & 7;
        }
        public void ResetSkill()
        {
            if(((this.<PreLevelInventory>k__BackingField) & 15762598695796736) != 0)
            {
                    return;
            }
            
            this.UpdatePreLevelInventory(newPreLevelInventory:  Royal.Infrastructure.Utils.Math.BitwiseOperations.UpdateLong(toNumber:  this.<PreLevelInventory>k__BackingField, number:  0, fromPosition:  51, toPosition:  53));
        }
        public void UpdateSkill(Royal.Player.Context.Units.UserSkill skill)
        {
            this.UpdatePreLevelInventory(newPreLevelInventory:  Royal.Infrastructure.Utils.Math.BitwiseOperations.UpdateLong(toNumber:  this.<PreLevelInventory>k__BackingField, number:  System.Convert.ToInt32(value:  skill), fromPosition:  51, toPosition:  53));
        }
        public UserInventory()
        {
        
        }
    
    }

}
