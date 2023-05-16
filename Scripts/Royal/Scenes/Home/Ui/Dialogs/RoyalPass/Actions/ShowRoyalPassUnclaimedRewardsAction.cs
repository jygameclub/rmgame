using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Actions
{
    public class ShowRoyalPassUnclaimedRewardsAction : FlowAction
    {
        // Fields
        private Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassUnclaimedRewardsPanel panel;
        private Royal.Player.Context.Units.RoyalPassManager royalPassManager;
        private System.Collections.Generic.Dictionary<Royal.Player.Context.Units.RewardType, int> dict;
        
        // Properties
        public override int Type { get; }
        public override bool IsForClaim { get; }
        
        // Methods
        public override int get_Type()
        {
            return 3;
        }
        public override bool get_IsForClaim()
        {
            return true;
        }
        public override void Execute()
        {
            Royal.Player.Context.Units.RoyalPassManager val_1 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.RoyalPassManager>(id:  12);
            this.royalPassManager = val_1;
            System.Collections.Generic.Dictionary<Royal.Player.Context.Units.RewardType, System.Int32> val_2 = val_1.ClaimAndGetAllUnclaimedRewards();
            this.dict = val_2;
            this.ReplaceMultiples(rewards:  val_2);
            if(this.dict.Keys.Count >= 1)
            {
                    Royal.Player.Context.Data.InventoryPackage val_5 = Royal.Player.Context.Data.InventoryPackage.GetInventoryPackageFromRewardTypes(rewardCounts:  this.dict);
                Royal.Player.Context.Units.UserManager.AddInventoryPackage(package:  val_5);
                Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.UserManager>(id:  1).SendDataToBackend(forceToSend:  false, forceScoreData:  false);
                Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Analytics.AnalyticsManager>(id:  17).PassClaim(eventId:  (long)((this.royalPassManager.<EventId>k__BackingField) == 0) ? (typeof(Royal.Player.Context.Data.Persistent.UserInventory).__il2cppRuntimeField_6C) : this.royalPassManager.<EventId>k__BackingField, stage:  0, claimStage:  -2, safeStage:  this.royalPassManager.GetSafeStepIndex(), isFree:  (Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_typeDefinition == 0) ? 1 : 0, package:  val_5);
                UnityEngine.Vector3 val_12 = UnityEngine.Vector3.zero;
                UnityEngine.Quaternion val_13 = UnityEngine.Quaternion.identity;
                Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassUnclaimedRewardsPanel val_14 = UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassUnclaimedRewardsPanel>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassUnclaimedRewardsPanel>(path:  "RoyalPassUnclaimedRewardsPanel"), position:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, rotation:  new UnityEngine.Quaternion() {x = val_13.x, y = val_13.y, z = val_13.z, w = val_13.w});
                this.panel = val_14;
                val_14.Show(onComplete:  new System.Action(object:  this, method:  typeof(Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Actions.ShowRoyalPassUnclaimedRewardsAction).__il2cppRuntimeField_1B8), rewardCounts:  this.dict);
            }
        
        }
        public override void Complete()
        {
            if(this.royalPassManager != null)
            {
                    object[] val_1 = new object[1];
                val_1[0] = this.dict.Keys.Count;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  28, log:  "Unclaimed reward count: {0}", values:  val_1);
                this.royalPassManager.ClearRoyalPassInfo();
            }
            
            this.Complete();
        }
        private void ReplaceMultiples(System.Collections.Generic.Dictionary<Royal.Player.Context.Units.RewardType, int> rewards)
        {
            if((rewards.ContainsKey(key:  14)) != false)
            {
                    int val_2 = rewards.Item[14];
                val_2.AddRewardTypeToDict(dict:  rewards, rewardType:  13, amount:  val_2);
                val_2.AddRewardTypeToDict(dict:  rewards, rewardType:  11, amount:  val_2);
                val_2.AddRewardTypeToDict(dict:  rewards, rewardType:  12, amount:  val_2);
                bool val_3 = rewards.Remove(key:  14);
            }
            
            if((rewards.ContainsKey(key:  15)) != false)
            {
                    int val_5 = rewards.Item[15];
                val_5.AddRewardTypeToDict(dict:  rewards, rewardType:  3, amount:  val_5);
                val_5.AddRewardTypeToDict(dict:  rewards, rewardType:  4, amount:  val_5);
                val_5.AddRewardTypeToDict(dict:  rewards, rewardType:  5, amount:  val_5);
                bool val_6 = rewards.Remove(key:  15);
            }
            
            if((rewards.ContainsKey(key:  10)) == false)
            {
                    return;
            }
            
            int val_8 = rewards.Item[10];
            val_8.AddRewardTypeToDict(dict:  rewards, rewardType:  6, amount:  val_8);
            val_8.AddRewardTypeToDict(dict:  rewards, rewardType:  7, amount:  val_8);
            val_8.AddRewardTypeToDict(dict:  rewards, rewardType:  8, amount:  val_8);
            val_8.AddRewardTypeToDict(dict:  rewards, rewardType:  9, amount:  val_8);
            bool val_9 = rewards.Remove(key:  10);
        }
        private void AddRewardTypeToDict(System.Collections.Generic.Dictionary<Royal.Player.Context.Units.RewardType, int> dict, Royal.Player.Context.Units.RewardType rewardType, int amount)
        {
            int val_1 = 0;
            if((dict.TryGetValue(key:  rewardType, value: out  val_1)) != false)
            {
                    dict.set_Item(key:  rewardType, value:  val_1 + amount);
                return;
            }
            
            dict.Add(key:  rewardType, value:  amount);
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
        
        }
        public ShowRoyalPassUnclaimedRewardsAction()
        {
        
        }
    
    }

}
