using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.LadderOffer
{
    [Serializable]
    public class LadderOfferStep
    {
        // Fields
        public int s;
        public int a;
        public int p;
        public string n;
        public Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferReward[] r;
        public Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferReward[] c;
        public bool isLocked;
        public bool isChecked;
        public int backgroundColorIndex;
        
        // Methods
        public int GetCoinAmountInChestInventory()
        {
            int val_2;
            if(this.c == null)
            {
                goto label_1;
            }
            
            var val_4 = 4;
            label_5:
            if((val_4 - 4) >= this.c.Length)
            {
                goto label_1;
            }
            
            if(this.c[0].GetRewardType() == 1)
            {
                goto label_4;
            }
            
            val_4 = val_4 + 1;
            if(this.c != null)
            {
                goto label_5;
            }
            
            throw new NullReferenceException();
            label_1:
            val_2 = 0;
            return val_2;
            label_4:
            Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferReward val_5 = this.c[0];
            val_2 = this.c[0].a;
            return val_2;
        }
        public bool HasChestOrGiftbox()
        {
            if(this.c == null)
            {
                    return false;
            }
            
            return (bool)(this.c.Length != 0) ? 1 : 0;
        }
        public bool HasCoins()
        {
            var val_2;
            System.Func<Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferReward, System.Boolean> val_4;
            val_2 = null;
            val_2 = null;
            val_4 = LadderOfferStep.<>c.<>9__11_0;
            if(val_4 != null)
            {
                    return System.Linq.Enumerable.Any<Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferReward>(source:  this.r, predicate:  System.Func<Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferReward, System.Boolean> val_1 = null);
            }
            
            val_4 = val_1;
            val_1 = new System.Func<Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferReward, System.Boolean>(object:  LadderOfferStep.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean LadderOfferStep.<>c::<HasCoins>b__11_0(Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferReward t));
            LadderOfferStep.<>c.<>9__11_0 = val_4;
            return System.Linq.Enumerable.Any<Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferReward>(source:  this.r, predicate:  val_1);
        }
        public bool HasInGameInventory()
        {
            var val_2;
            System.Func<Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferReward, System.Boolean> val_4;
            val_2 = null;
            val_2 = null;
            val_4 = LadderOfferStep.<>c.<>9__12_0;
            if(val_4 != null)
            {
                    return System.Linq.Enumerable.Any<Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferReward>(source:  this.r, predicate:  System.Func<Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferReward, System.Boolean> val_1 = null);
            }
            
            val_4 = val_1;
            val_1 = new System.Func<Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferReward, System.Boolean>(object:  LadderOfferStep.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean LadderOfferStep.<>c::<HasInGameInventory>b__12_0(Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferReward t));
            LadderOfferStep.<>c.<>9__12_0 = val_4;
            return System.Linq.Enumerable.Any<Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferReward>(source:  this.r, predicate:  val_1);
        }
        public bool HasPreLevelInventory()
        {
            var val_2;
            System.Func<Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferReward, System.Boolean> val_4;
            val_2 = null;
            val_2 = null;
            val_4 = LadderOfferStep.<>c.<>9__13_0;
            if(val_4 != null)
            {
                    return System.Linq.Enumerable.Any<Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferReward>(source:  this.r, predicate:  System.Func<Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferReward, System.Boolean> val_1 = null);
            }
            
            val_4 = val_1;
            val_1 = new System.Func<Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferReward, System.Boolean>(object:  LadderOfferStep.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean LadderOfferStep.<>c::<HasPreLevelInventory>b__13_0(Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferReward t));
            LadderOfferStep.<>c.<>9__13_0 = val_4;
            return System.Linq.Enumerable.Any<Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferReward>(source:  this.r, predicate:  val_1);
        }
        public bool HasUnlimitedPrelevelBoosters()
        {
            var val_2;
            System.Func<Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferReward, System.Boolean> val_4;
            val_2 = null;
            val_2 = null;
            val_4 = LadderOfferStep.<>c.<>9__14_0;
            if(val_4 != null)
            {
                    return System.Linq.Enumerable.Any<Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferReward>(source:  this.r, predicate:  System.Func<Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferReward, System.Boolean> val_1 = null);
            }
            
            val_4 = val_1;
            val_1 = new System.Func<Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferReward, System.Boolean>(object:  LadderOfferStep.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean LadderOfferStep.<>c::<HasUnlimitedPrelevelBoosters>b__14_0(Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferReward t));
            LadderOfferStep.<>c.<>9__14_0 = val_4;
            return System.Linq.Enumerable.Any<Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferReward>(source:  this.r, predicate:  val_1);
        }
        public bool HasUnlimitedLives()
        {
            var val_2;
            System.Func<Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferReward, System.Boolean> val_4;
            val_2 = null;
            val_2 = null;
            val_4 = LadderOfferStep.<>c.<>9__15_0;
            if(val_4 != null)
            {
                    return System.Linq.Enumerable.Any<Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferReward>(source:  this.r, predicate:  System.Func<Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferReward, System.Boolean> val_1 = null);
            }
            
            val_4 = val_1;
            val_1 = new System.Func<Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferReward, System.Boolean>(object:  LadderOfferStep.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean LadderOfferStep.<>c::<HasUnlimitedLives>b__15_0(Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferReward t));
            LadderOfferStep.<>c.<>9__15_0 = val_4;
            return System.Linq.Enumerable.Any<Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferReward>(source:  this.r, predicate:  val_1);
        }
        public Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig CreateShopConfig()
        {
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferReward[] val_17;
            int val_18;
            var val_19;
            Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig val_0;
            val_10 = val_0;
            Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferReward[] val_9 = this.r;
            if(val_9 == null)
            {
                goto label_1;
            }
            
            val_11 = 0;
            val_12 = 0;
            val_13 = 0;
            val_14 = 0;
            val_15 = 0;
            val_16 = 0;
            var val_26 = 4;
            label_66:
            val_9 = val_26 - 4;
            if(val_9 >= this.r.Length)
            {
                goto label_2;
            }
            
            val_9 = val_9[0].GetRewardType() - 1;
            if(val_9 > 14)
            {
                goto label_5;
            }
            
            var val_10 = 36587340 + ((val_1 - 1)) << 2;
            val_10 = val_10 + 36587340;
            goto (36587340 + ((val_1 - 1)) << 2 + 36587340);
            label_5:
            val_17 = this.r;
            val_26 = val_26 + 1;
            if( != null)
            {
                goto label_66;
            }
            
            label_2:
            val_10 = val_10;
            val_18 = this.r[0].a;
            goto label_68;
            label_1:
            val_16 = 0;
            val_15 = 0;
            val_14 = 0;
            val_13 = 0;
            val_12 = 0;
            val_11 = 0;
            val_18 = 0;
            label_68:
            Royal.Infrastructure.Services.Native.NativeService val_2 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Native.NativeService>(id:  19);
            if(this.p != 0)
            {
                    Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct val_4 = val_2.purchaseManager.purchaseProducts.Item["com.dreamgames.royal.ladder." + this.p];
                return val_0;
            }
            
            val_9 = 1152921505134215168;
            val_19 = null;
            val_19 = null;
            return val_0;
        }
        public Royal.Player.Context.Units.RewardType GetChestGiftboxRewardType()
        {
            var val_2;
            var val_3 = 0;
            label_5:
            if(val_3 >= this.r.Length)
            {
                goto label_1;
            }
            
            this.r[val_3] = this.r[val_3].GetRewardType() - 16;
            if(this.r[val_3] < 6)
            {
                    return (Royal.Player.Context.Units.RewardType)val_2;
            }
            
            val_3 = val_3 + 1;
            if(this.r != null)
            {
                goto label_5;
            }
            
            throw new NullReferenceException();
            label_1:
            val_2 = 0;
            return (Royal.Player.Context.Units.RewardType)val_2;
        }
        public System.Collections.Generic.Dictionary<Royal.Player.Context.Units.RewardType, string> GetChestGiftboxRewards()
        {
            var val_5;
            string val_6;
            var val_7;
            Royal.Player.Context.Units.RewardType val_8;
            System.Collections.Generic.Dictionary<Royal.Player.Context.Units.RewardType, System.String> val_1 = new System.Collections.Generic.Dictionary<Royal.Player.Context.Units.RewardType, System.String>();
            val_5 = 4;
            do
            {
                val_6 = val_5 - 4;
                if(val_6 >= this.c.Length)
            {
                    return val_1;
            }
            
                Royal.Player.Context.Units.RewardType val_2 = this.c[0].GetRewardType();
                val_6 = this.c[0].GetAmountOrDurationText();
                if((val_2 - 14) < 2)
            {
                    val_1.Add(key:  13, value:  val_6);
                val_1.Add(key:  11, value:  val_6);
                val_7 = public System.Void System.Collections.Generic.Dictionary<Royal.Player.Context.Units.RewardType, System.String>::Add(Royal.Player.Context.Units.RewardType key, System.String value);
                val_8 = 12;
            }
            else
            {
                    if(val_2 == 10)
            {
                    val_1.Add(key:  6, value:  val_6);
                val_1.Add(key:  7, value:  val_6);
                val_1.Add(key:  8, value:  val_6);
                val_7 = public System.Void System.Collections.Generic.Dictionary<Royal.Player.Context.Units.RewardType, System.String>::Add(Royal.Player.Context.Units.RewardType key, System.String value);
                val_8 = 9;
            }
            else
            {
                    val_7 = public System.Void System.Collections.Generic.Dictionary<Royal.Player.Context.Units.RewardType, System.String>::Add(Royal.Player.Context.Units.RewardType key, System.String value);
                val_8 = val_2;
            }
            
            }
            
                val_1.Add(key:  val_8, value:  val_6);
                val_5 = val_5 + 1;
            }
            while(this.c != null);
            
            throw new NullReferenceException();
        }
        public string GetChestGiftboxPrefabName()
        {
            var val_4;
            if((this.GetChestGiftboxRewardType() - 16) <= 5)
            {
                    var val_3 = 36587316 + ((val_1 - 16)) << 2;
                val_3 = val_3 + 36587316;
            }
            else
            {
                    val_4 = 0;
                return (string);
            }
        
        }
        public System.Collections.Generic.Dictionary<string, string> GetPrefabNamesAndRewardTexts()
        {
            string val_9;
            string val_10;
            System.Collections.Generic.Dictionary<System.String, System.String> val_1 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            var val_13 = 4;
            label_22:
            if((val_13 - 4) >= this.r.Length)
            {
                    return val_1;
            }
            
            System.Text.StringBuilder val_3 = new System.Text.StringBuilder(value:  "LadderOffer");
            Royal.Player.Context.Units.RewardType val_4 = this.r[0].GetRewardType();
            string val_6 = val_4.ToString();
            val_9 = val_4.ToString();
            System.Text.StringBuilder val_7 = val_3.Append(value:  val_9);
            if(null != 1)
            {
                goto label_8;
            }
            
            Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferReward val_11 = this.r[0];
            if(this.r[0].a >= 15000)
            {
                goto label_12;
            }
            
            if(this.r[0].a >= 5000)
            {
                goto label_13;
            }
            
            if(this.r[0].a >= 3000)
            {
                goto label_14;
            }
            
            val_10 = "100";
            goto label_17;
            label_12:
            val_10 = "15000";
            goto label_17;
            label_13:
            val_10 = "5000";
            goto label_17;
            label_14:
            val_10 = "3000";
            label_17:
            System.Text.StringBuilder val_8 = val_3.Append(value:  val_10);
            label_8:
            val_1.Add(key:  val_3, value:  this.r[0].GetAmountOrDurationText());
            val_13 = val_13 + 1;
            if(this.r != null)
            {
                goto label_22;
            }
            
            throw new NullReferenceException();
        }
        public LadderOfferStep()
        {
        
        }
    
    }

}
