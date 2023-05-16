using UnityEngine;

namespace Royal.Player.Context.Data.Session
{
    public class AnimationData
    {
        // Fields
        public readonly Royal.Player.Context.Data.Session.BeforeAfterData leagueCrown;
        public readonly Royal.Player.Context.Data.Session.BeforeAfterData kingsCup;
        public readonly Royal.Player.Context.Data.Session.BeforeAfterData teamBattle;
        public readonly Royal.Player.Context.Data.Session.BeforeAfterData coin;
        public readonly Royal.Player.Context.Data.Session.BeforeAfterData completed1000ThLevelCoin;
        public readonly Royal.Player.Context.Data.Session.MadnessSessionData madness;
        public readonly Royal.Player.Context.Data.Session.RoyalPassLevelData royalPass;
        public readonly System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Boosters.BoosterType> boosters;
        public readonly System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Boosters.BoosterType> unlimitedBoosters;
        public int boosterCount;
        public int boosterMinutes;
        public bool boosterShouldConsume;
        
        // Methods
        public AnimationData()
        {
            this.leagueCrown = new Royal.Player.Context.Data.Session.BeforeAfterData();
            this.kingsCup = new Royal.Player.Context.Data.Session.BeforeAfterData();
            this.teamBattle = new Royal.Player.Context.Data.Session.BeforeAfterData();
            this.coin = new Royal.Player.Context.Data.Session.BeforeAfterData();
            this.completed1000ThLevelCoin = new Royal.Player.Context.Data.Session.BeforeAfterData();
            Royal.Player.Context.Data.Session.MadnessSessionData val_6 = null;
            .eventId = 0;
            val_6 = new Royal.Player.Context.Data.Session.MadnessSessionData();
            this.madness = val_6;
            Royal.Player.Context.Data.Session.RoyalPassLevelData val_7 = null;
            .eventId = 0;
            val_7 = new Royal.Player.Context.Data.Session.RoyalPassLevelData();
            this.royalPass = val_7;
            this.boosters = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Boosters.BoosterType>();
            this.unlimitedBoosters = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Boosters.BoosterType>();
        }
        public void Reset()
        {
            this.leagueCrown = 0;
            this.kingsCup = 0;
            this.teamBattle = 0;
            this.coin = 0;
            this.completed1000ThLevelCoin = 0;
            this.madness = 0;
            this.royalPass = 0;
            this.boosterShouldConsume = false;
            this.boosters.Clear();
            this.unlimitedBoosters.Clear();
        }
        public void AddCoin(int coins)
        {
            Royal.Player.Context.Data.Session.BeforeAfterData val_1;
            if(coins < 1)
            {
                    return;
            }
            
            val_1 = this.coin;
            if(this.coin.shouldConsume != true)
            {
                    this.Prepare(coins:  coins);
                val_1 = this.coin;
            }
            
            int val_1 = this.coin.before;
            val_1 = 1;
            val_1 = val_1 + coins;
            val_1 = val_1;
        }
        public void AddBooster(Royal.Scenes.Game.Mechanics.Boosters.BoosterType booster, int count)
        {
            if(count >= 1)
            {
                    var val_1 = 0;
                do
            {
                this.boosterCount = 1;
                this.boosters.Add(item:  booster);
                val_1 = val_1 + 1;
            }
            while(val_1 < count);
            
            }
            
            this.boosterShouldConsume = true;
        }
        public void AddLeagueCrown()
        {
            int val_1 = this.leagueCrown.before;
            this.leagueCrown = 1;
            val_1 = val_1 + 1;
            this.leagueCrown = val_1;
            this.leagueCrown = 1;
        }
        public void AddKingsCup(sbyte difficulty)
        {
            Royal.Player.Context.Data.Session.BeforeAfterData val_2;
            Royal.Player.Context.Data.Session.BeforeAfterData val_3;
            int val_2 = this.kingsCup.before;
            sbyte val_1 = difficulty & 255;
            val_2 = val_2 + 1;
            this.kingsCup = 1;
            this.kingsCup = val_2;
            if(val_1 == 2)
            {
                goto label_1;
            }
            
            if(val_1 != 1)
            {
                goto label_2;
            }
            
            val_2 = this.kingsCup;
            val_3 = 2;
            goto label_4;
            label_1:
            val_2 = this.kingsCup;
            val_3 = 4;
            label_4:
            val_2 = 1;
            val_3 = this.kingsCup.after + val_3;
            val_2 = val_3;
            label_2:
            this.kingsCup = 1;
        }
        public void AddTeamBattle(sbyte difficulty)
        {
            Royal.Player.Context.Data.Session.BeforeAfterData val_2;
            Royal.Player.Context.Data.Session.BeforeAfterData val_3;
            int val_2 = this.teamBattle.before;
            sbyte val_1 = difficulty & 255;
            val_2 = val_2 + 1;
            this.teamBattle = 1;
            this.teamBattle = val_2;
            if(val_1 == 2)
            {
                goto label_1;
            }
            
            if(val_1 != 1)
            {
                goto label_2;
            }
            
            val_2 = this.teamBattle;
            val_3 = 2;
            goto label_4;
            label_1:
            val_2 = this.teamBattle;
            val_3 = 4;
            label_4:
            val_2 = 1;
            val_3 = this.teamBattle.after + val_3;
            val_2 = val_3;
            label_2:
            this.teamBattle = 1;
        }
        public void AddRoyalPass(sbyte difficulty)
        {
            if(this.royalPass != null)
            {
                    sbyte val_1 = difficulty & 255;
                val_1 = (val_1 == 1) ? 3 : ((val_1 == 2) ? 5 : (0 + 1));
                val_1 = W13 + val_1;
                this.royalPass = 1;
                this.royalPass = val_1;
                return;
            }
            
            throw new NullReferenceException();
        }
        public int GetValueForDifficulty(sbyte difficulty)
        {
            sbyte val_1 = difficulty & 255;
            if(val_1 != 1)
            {
                    return (int)(val_1 == 2) ? 5 : (0 + 1);
            }
            
            return 3;
        }
        private void Prepare(int coins)
        {
            this.coin = 0;
            this.coin = ((Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_name - coins) & (~((int)(Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_name - coins)) >> 31));
            this.coin = ((Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_name - coins) & (~((int)(Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_name - coins)) >> 31));
        }
        public void AddPackage(Royal.Player.Context.Data.InventoryPackage package)
        {
            var val_2;
            Royal.Scenes.Game.Mechanics.Boosters.BoosterType val_3;
            Royal.Scenes.Game.Mechanics.Boosters.BoosterType val_8;
            System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Boosters.BoosterType> val_9;
            this.AddCoin(coins:  package.coins);
            Dictionary.Enumerator<TKey, TValue> val_1 = package.boosters.GetEnumerator();
            label_5:
            if(((-1869324304) & 1) == 0)
            {
                goto label_3;
            }
            
            val_8 = val_3;
            val_9 = this.boosters;
            this.boosterCount = val_8 >> 32;
            if(val_9 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_9.Add(item:  val_8);
            goto label_5;
            label_3:
            val_2.Dispose();
            Dictionary.Enumerator<TKey, TValue> val_5 = package.unlimitedBoosters.GetEnumerator();
            label_9:
            if(((-1869324304) & 1) == 0)
            {
                goto label_7;
            }
            
            val_8 = val_3;
            val_9 = this.unlimitedBoosters;
            this.boosterMinutes = val_8 >> 32;
            if(val_9 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_9.Add(item:  val_8);
            goto label_9;
            label_7:
            val_2.Dispose();
            this.boosterShouldConsume = true;
        }
        public void ConsumeBoosters()
        {
            this.boosterShouldConsume = false;
            this.boosters.Clear();
            this.unlimitedBoosters.Clear();
        }
    
    }

}
