using UnityEngine;

namespace Royal.Player.Context.Data
{
    public class InventoryPackage
    {
        // Fields
        public int id;
        public int coins;
        public int lives;
        public int unlimitedLifetimeMin;
        public System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Boosters.BoosterType, int> boosters;
        public System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Boosters.BoosterType, int> unlimitedBoosters;
        
        // Methods
        public int GetBoosterCount(Royal.Scenes.Game.Mechanics.Boosters.BoosterType boosterType)
        {
            int val_1 = 0;
            bool val_2 = this.boosters.TryGetValue(key:  boosterType, value: out  val_1);
            return val_1;
        }
        public int GetBoosterUnlimited(Royal.Scenes.Game.Mechanics.Boosters.BoosterType boosterType)
        {
            System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Boosters.BoosterType, System.Int32> val_3;
            int val_1 = 0;
            val_3 = this.unlimitedBoosters;
            if(val_3 == null)
            {
                    return (int)val_3;
            }
            
            bool val_2 = val_3.TryGetValue(key:  boosterType, value: out  val_1);
            val_3 = val_1;
            return (int)val_3;
        }
        public static Royal.Player.Context.Data.InventoryPackage GetAreaChestPackage(int areaId)
        {
            .id = areaId;
            .coins = 250;
            System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Boosters.BoosterType, System.Int32> val_2 = new System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Boosters.BoosterType, System.Int32>();
            val_2.Add(key:  4, value:  1);
            .boosters = val_2;
            val_2.Add(key:  1, value:  1);
            (Royal.Player.Context.Data.InventoryPackage)[1152921524202434768].boosters.Add(key:  2, value:  1);
            (Royal.Player.Context.Data.InventoryPackage)[1152921524202434768].boosters.Add(key:  3, value:  1);
            if(areaId == 1)
            {
                    return (Royal.Player.Context.Data.InventoryPackage)new Royal.Player.Context.Data.InventoryPackage();
            }
            
            (Royal.Player.Context.Data.InventoryPackage)[1152921524202434768].boosters.Add(key:  6, value:  1);
            (Royal.Player.Context.Data.InventoryPackage)[1152921524202434768].boosters.Add(key:  5, value:  1);
            (Royal.Player.Context.Data.InventoryPackage)[1152921524202434768].boosters.Add(key:  7, value:  1);
            return (Royal.Player.Context.Data.InventoryPackage)new Royal.Player.Context.Data.InventoryPackage();
        }
        public static Royal.Player.Context.Data.InventoryPackage GetKingsCupPackage(int rank)
        {
            var val_4;
            Royal.Scenes.Game.Mechanics.Boosters.BoosterType val_5;
            var val_6;
            .boosters = new System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Boosters.BoosterType, System.Int32>();
            if((rank - 1) <= 9)
            {
                    var val_4 = 36600864 + ((rank - 1)) << 2;
                val_4 = val_4 + 36600864;
            }
            else
            {
                    val_5 = 1;
                val_6 = 1;
                val_4 = public System.Void System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Boosters.BoosterType, System.Int32>::Add(Royal.Scenes.Game.Mechanics.Boosters.BoosterType key, System.Int32 value);
                (Royal.Player.Context.Data.InventoryPackage)[1152921524202628688].boosters.Add(key:  null, value:  1);
                var val_5 = ???;
                return (Royal.Player.Context.Data.InventoryPackage)new Royal.Player.Context.Data.InventoryPackage();
            }
        
        }
        public static Royal.Player.Context.Data.InventoryPackage GetTeamBattlePackage(int myRank, int teamRank, int myScore)
        {
            System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Boosters.BoosterType, System.Int32> val_6;
            System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Boosters.BoosterType, System.Int32> val_7;
            var val_8;
            System.Int32[] val_9;
            int val_10;
            var val_11;
            var val_12;
            Royal.Scenes.Game.Mechanics.Boosters.BoosterType val_13;
            val_6 = myScore;
            val_7 = myRank;
            if(val_6 <= 0)
            {
                goto label_1;
            }
            
            if(val_6 < 0)
            {
                goto label_2;
            }
            
            val_8 = null;
            val_8 = null;
            val_9 = Royal.Player.Context.Units.TeamBattleManager.Rewards;
            if(Royal.Player.Context.Units.TeamBattleManager.Rewards.Length >= teamRank)
            {
                goto label_6;
            }
            
            label_2:
            val_10 = 0;
            goto label_7;
            label_1:
            Royal.Player.Context.Data.InventoryPackage val_2 = null;
            val_11 = val_2;
            val_2 = new Royal.Player.Context.Data.InventoryPackage();
            System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Boosters.BoosterType, System.Int32> val_3 = null;
            val_7 = val_3;
            val_3 = new System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Boosters.BoosterType, System.Int32>();
            .boosters = val_7;
            return (Royal.Player.Context.Data.InventoryPackage)val_11;
            label_6:
            val_9 = Royal.Player.Context.Units.TeamBattleManager.Rewards;
            val_9 = val_9 + ((teamRank - 1) << 2);
            val_10 = mem[(Royal.Player.Context.Units.TeamBattleManager.Rewards + ((teamRank - 1)) << 2) + 32];
            val_10 = (Royal.Player.Context.Units.TeamBattleManager.Rewards + ((teamRank - 1)) << 2) + 32;
            label_7:
            Royal.Player.Context.Data.InventoryPackage val_4 = null;
            val_11 = val_4;
            val_4 = new Royal.Player.Context.Data.InventoryPackage();
            .coins = val_10;
            System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Boosters.BoosterType, System.Int32> val_5 = null;
            val_6 = val_5;
            val_5 = new System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Boosters.BoosterType, System.Int32>();
            .boosters = val_6;
            if(val_7 == 3)
            {
                goto label_15;
            }
            
            if(val_7 == 2)
            {
                goto label_16;
            }
            
            if(val_7 != 1)
            {
                    return (Royal.Player.Context.Data.InventoryPackage)val_11;
            }
            
            val_12 = 1152921524202357264;
            val_13 = 3;
            goto label_21;
            label_16:
            val_12 = 1152921524202357264;
            val_13 = 2;
            goto label_21;
            label_15:
            val_12 = 1152921524202357264;
            val_13 = 1;
            label_21:
            val_5.Add(key:  val_13, value:  2);
            return (Royal.Player.Context.Data.InventoryPackage)val_11;
        }
        public static Royal.Player.Context.Data.InventoryPackage GetInventoryPackageFromShop(Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig config)
        {
            Royal.Player.Context.Data.InventoryPackage val_1 = new Royal.Player.Context.Data.InventoryPackage();
            .coins = config.cannonAmount;
            .unlimitedLifetimeMin = 1152921524202979776;
            .boosters = new System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Boosters.BoosterType, System.Int32>();
            .unlimitedBoosters = new System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Boosters.BoosterType, System.Int32>();
            if(48 == 0)
            {
                    return val_1;
            }
            
            Royal.Player.Context.Data.InventoryPackage.TryToAddBoosterToInventoryPackage(inventoryPackage:  val_1, boosterType:  1, amount:  config.tntAmount);
            Royal.Player.Context.Data.InventoryPackage.TryToAddBoosterToInventoryPackage(inventoryPackage:  val_1, boosterType:  2, amount:  config.lightballAmount);
            Royal.Player.Context.Data.InventoryPackage.TryToAddBoosterToInventoryPackage(inventoryPackage:  val_1, boosterType:  3, amount:  config.lifetime);
            Royal.Player.Context.Data.InventoryPackage.TryToAddBoosterToInventoryPackage(inventoryPackage:  val_1, boosterType:  4, amount:  config.arrowAmount);
            Royal.Player.Context.Data.InventoryPackage.TryToAddBoosterToInventoryPackage(inventoryPackage:  val_1, boosterType:  6, amount:  config.jesterHatAmount);
            Royal.Player.Context.Data.InventoryPackage.TryToAddBoosterToInventoryPackage(inventoryPackage:  val_1, boosterType:  5, amount:  config.rocketAmount);
            Royal.Player.Context.Data.InventoryPackage.TryToAddBoosterToInventoryPackage(inventoryPackage:  val_1, boosterType:  7, amount:  config.rocketMinutes);
            Royal.Player.Context.Data.InventoryPackage.TryToAddUnlimitedBoosterToInventoryPackage(inventoryPackage:  val_1, boosterType:  1, minutes:  config.tntMinutes);
            Royal.Player.Context.Data.InventoryPackage.TryToAddUnlimitedBoosterToInventoryPackage(inventoryPackage:  val_1, boosterType:  2, minutes:  config.lightballMinutes);
            Royal.Player.Context.Data.InventoryPackage.TryToAddUnlimitedBoosterToInventoryPackage(inventoryPackage:  val_1, boosterType:  3, minutes:  config.isSpecialItemAlternative);
            return val_1;
        }
        private static void TryToAddBoosterToInventoryPackage(Royal.Player.Context.Data.InventoryPackage inventoryPackage, Royal.Scenes.Game.Mechanics.Boosters.BoosterType boosterType, int amount)
        {
            if(amount < 1)
            {
                    return;
            }
            
            inventoryPackage.boosters.Add(key:  boosterType, value:  amount);
        }
        private static void TryToAddUnlimitedBoosterToInventoryPackage(Royal.Player.Context.Data.InventoryPackage inventoryPackage, Royal.Scenes.Game.Mechanics.Boosters.BoosterType boosterType, int minutes)
        {
            if(minutes < 1)
            {
                    return;
            }
            
            inventoryPackage.unlimitedBoosters.Add(key:  boosterType, value:  minutes);
        }
        public static Royal.Player.Context.Data.InventoryPackage GetMadnessPackage(Royal.Player.Context.Units.MadnessStep step)
        {
            System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Boosters.BoosterType, System.Int32> val_6;
            .boosters = new System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Boosters.BoosterType, System.Int32>();
            System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Boosters.BoosterType, System.Int32> val_3 = null;
            val_6 = val_3;
            val_3 = new System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Boosters.BoosterType, System.Int32>();
            .unlimitedBoosters = val_6;
            var val_8 = 0;
            if(val_8 >= step.r.Length)
            {
                    return (Royal.Player.Context.Data.InventoryPackage)new Royal.Player.Context.Data.InventoryPackage();
            }
            
            val_6 = step.r[0x0][0].a;
            if(step.r[val_8].GetRewardType() > 10)
            {
                    throw new System.ArgumentOutOfRangeException();
            }
            
            var val_7 = 36600904 + (val_4) << 2;
            val_7 = val_7 + 36600904;
            goto (36600904 + (val_4) << 2 + 36600904);
        }
        public static Royal.Player.Context.Data.InventoryPackage GetRoyalPassPackage(Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassStep step, bool isFree)
        {
            Royal.Player.Context.Data.InventoryPackage val_1 = new Royal.Player.Context.Data.InventoryPackage();
            .boosters = new System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Boosters.BoosterType, System.Int32>();
            .coins = 0;
            .unlimitedBoosters = new System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Boosters.BoosterType, System.Int32>();
            var val_4 = (isFree != true) ? 24 : 40;
            var val_6 = 0;
            Royal.Player.Context.Data.InventoryPackage.AddStepRewardsToInventory(inventoryPackage:  val_1, reward:  Royal.Scenes.Home.Ui.Dialogs.RoyalPass.__il2cppRuntimeField_20.GetRewardType(), amount:  Royal.Scenes.Home.Ui.Dialogs.RoyalPass.__il2cppRuntimeField_20 + 24);
            val_6 = val_6 + 1;
            return val_1;
        }
        public static Royal.Player.Context.Data.InventoryPackage Get1000ThLevelPackage()
        {
            .coins = 1000;
            .unlimitedLifetimeMin = 60;
            .boosters = new System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Boosters.BoosterType, System.Int32>();
            System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Boosters.BoosterType, System.Int32> val_3 = new System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Boosters.BoosterType, System.Int32>();
            val_3.Add(key:  3, value:  60);
            val_3.Add(key:  1, value:  60);
            val_3.Add(key:  2, value:  60);
            .unlimitedBoosters = val_3;
            return (Royal.Player.Context.Data.InventoryPackage)new Royal.Player.Context.Data.InventoryPackage();
        }
        public static Royal.Player.Context.Data.InventoryPackage GetInventoryPackageFromRewardTypes(System.Collections.Generic.Dictionary<Royal.Player.Context.Units.RewardType, int> rewardCounts)
        {
            Royal.Player.Context.Data.InventoryPackage val_1 = new Royal.Player.Context.Data.InventoryPackage();
            .boosters = new System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Boosters.BoosterType, System.Int32>();
            .coins = 0;
            .unlimitedBoosters = new System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Boosters.BoosterType, System.Int32>();
            Dictionary.Enumerator<TKey, TValue> val_4 = rewardCounts.GetEnumerator();
            label_4:
            if(( & 1) == 0)
            {
                goto label_3;
            }
            
            Royal.Player.Context.Data.InventoryPackage.AddStepRewardsToInventory(inventoryPackage:  val_1, reward:  0, amount:  0);
            goto label_4;
            label_3:
            0.Dispose();
            return val_1;
        }
        private static void AddStepRewardsToInventory(Royal.Player.Context.Data.InventoryPackage inventoryPackage, Royal.Player.Context.Units.RewardType reward, int amount)
        {
            if((reward - 1) > 14)
            {
                    return;
            }
            
            var val_6 = 36600948 + ((reward - 1)) << 2;
            val_6 = val_6 + 36600948;
            goto (36600948 + ((reward - 1)) << 2 + 36600948);
        }
        public static Royal.Player.Context.Data.InventoryPackage GetLadderOfferPackage(Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferStep step)
        {
            var val_4;
            Royal.Player.Context.Data.InventoryPackage val_1 = new Royal.Player.Context.Data.InventoryPackage();
            .boosters = new System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Boosters.BoosterType, System.Int32>();
            .unlimitedBoosters = new System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Boosters.BoosterType, System.Int32>();
            val_4 = 0;
            label_6:
            if(val_4 >= (step.r.Length << ))
            {
                goto label_4;
            }
            
            Royal.Player.Context.Data.InventoryPackage.AddStepRewardsToInventory(reward:  step.r[val_4], inventoryPackage:  val_1);
            val_4 = val_4 + 1;
            if(step.r != null)
            {
                goto label_6;
            }
            
            label_4:
            if(step.c == null)
            {
                    return val_1;
            }
            
            val_4 = 0;
            do
            {
                if(val_4 >= (step.c.Length << ))
            {
                    return val_1;
            }
            
                Royal.Player.Context.Data.InventoryPackage.AddStepRewardsToInventory(reward:  step.c[val_4], inventoryPackage:  val_1);
                val_4 = val_4 + 1;
            }
            while(step.c != null);
            
            throw new NullReferenceException();
        }
        private static void AddStepRewardsToInventory(Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferReward reward, Royal.Player.Context.Data.InventoryPackage inventoryPackage)
        {
            if((reward.GetRewardType() - 1) > 14)
            {
                    return;
            }
            
            var val_7 = 36601008 + ((val_1 - 1)) << 2;
            val_7 = val_7 + 36601008;
            goto (36601008 + ((val_1 - 1)) << 2 + 36601008);
        }
        private static void AddOrUpdateInventory(System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Boosters.BoosterType, int> boosters, int amount, Royal.Scenes.Game.Mechanics.Boosters.BoosterType boosterType)
        {
            if((boosters.ContainsKey(key:  boosterType)) != false)
            {
                    boosters.set_Item(key:  boosterType, value:  boosters.Item[boosterType] + amount);
                return;
            }
            
            boosters.Add(key:  boosterType, value:  amount);
        }
        public InventoryPackage()
        {
        
        }
    
    }

}
