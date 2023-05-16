using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass
{
    public class RoyalPassExtraWarnBarRewardView : MonoBehaviour
    {
        // Fields
        public UnityEngine.Transform root;
        private Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassRewardView rewardView;
        private Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassUnclaimedReward royalPassUnclaimedRewardView;
        
        // Methods
        public void CreateReward(Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassReward royalPassReward, Royal.Player.Context.Units.RewardName rewardName)
        {
            this.DestroyReward();
            this.AddNewReward(royalPassReward:  royalPassReward, rewardName:  rewardName);
        }
        public bool SetupForSmallDisplay(Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassStep royalPassStep, bool hasRoyalPass)
        {
            UnityEngine.Object val_20;
            var val_21;
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassReward val_22;
            float val_24;
            float val_25;
            float val_26;
            val_20 = hasRoyalPass;
            val_21 = royalPassStep;
            if(val_21 == null)
            {
                goto label_37;
            }
            
            if(val_20 != true)
            {
                    if(royalPassStep.r.GetGoldChestName() != 12)
            {
                goto label_4;
            }
            
            }
            
            val_22 = System.Linq.Enumerable.FirstOrDefault<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassReward>(source:  royalPassStep.r.g);
            Royal.Player.Context.Units.RewardName val_3 = royalPassStep.r.GetGoldChestName();
            goto label_7;
            label_4:
            val_22 = System.Linq.Enumerable.FirstOrDefault<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassReward>(source:  royalPassStep.r.f);
            Royal.Player.Context.Units.RewardName val_5 = royalPassStep.r.GetFreeChestName();
            label_7:
            this.DestroyReward();
            this.AddNewReward(royalPassReward:  val_22, rewardName:  val_5);
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
            if(val_5 > 12)
            {
                goto label_12;
            }
            
            var val_20 = 36530540 + (val_5) << 2;
            val_20 = val_20 + 36530540;
            goto (36530540 + (val_5) << 2 + 36530540);
            label_12:
            val_25 = -0.03f;
            val_26 = 0f;
            val_24 = 0.6f;
            val_21 = 0;
            if(this.rewardView != 0)
            {
                    if(this.rewardView != null)
            {
                goto label_28;
            }
            
            }
            
            val_20 = 0;
            if(this.royalPassUnclaimedRewardView == 0)
            {
                goto label_32;
            }
            
            this.royalPassUnclaimedRewardView.IncreaseSorting(multiplier:  10);
            label_28:
            val_20 = this.royalPassUnclaimedRewardView.transform;
            label_32:
            if(val_20 != 0)
            {
                    UnityEngine.Vector3 val_12 = val_20.localScale;
                UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, d:  val_24);
                val_20.localScale = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
                UnityEngine.Vector3 val_14 = val_20.localPosition;
                UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
                val_20.localPosition = new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z};
            }
            
            label_37:
            var val_21 = ???;
            return (bool)val_21;
        }
        public void DestroyReward()
        {
            int val_2 = this.root.childCount - 1;
            if(<0)
            {
                    return;
            }
            
            do
            {
                UnityEngine.Transform val_3 = this.root.GetChild(index:  val_2);
                val_3.SetParent(p:  0);
                UnityEngine.Object.Destroy(obj:  val_3.gameObject);
                val_2 = val_2 - 1;
            }
            while(>=0);
        
        }
        private void AddNewReward(Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassReward royalPassReward, Royal.Player.Context.Units.RewardName rewardName)
        {
            if(rewardName != 12)
            {
                    if(rewardName != 0)
            {
                goto label_2;
            }
            
            }
            
            if(royalPassReward == null)
            {
                goto label_22;
            }
            
            Royal.Player.Context.Units.RewardType val_1 = royalPassReward.GetRewardType();
            if(((0 & 0) != 0) || ((-1) > 12))
            {
                goto label_22;
            }
            
            this.rewardView = UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassRewardFiniteBoosterView>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassRewardFiniteBoosterView>(path:  "RoyalPassRewardFiniteBoosterView"), parent:  this.root);
            goto label_22;
            label_2:
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassRewardChestView val_5 = UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassRewardChestView>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassRewardChestView>(path:  "RoyalPassRewardChestView"), parent:  this.root);
            val_5.InitForChest(rewardName:  rewardName);
            this.rewardView = val_5;
            label_22:
            bool val_6 = UnityEngine.Object.op_Inequality(x:  this.rewardView, y:  0);
            var val_9 = ???;
        }
        private Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassUnclaimedReward CreateRoyalPassUnclaimedReward(Royal.Player.Context.Units.RewardType rewardType, int count)
        {
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassUnclaimedReward val_4 = UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassUnclaimedReward>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassUnclaimedReward>(path:  "UnclaimedRewards/"("UnclaimedRewards/") + "RoyalPassUnclaimed" + rewardType("RoyalPassUnclaimed" + rewardType)), parent:  this.root);
            val_4.InitForExtraWarn(rewardType:  rewardType);
            if(rewardType == 2)
            {
                    val_4.SetLifeForExtraWarn(minutes:  count);
                return val_4;
            }
            
            val_4.SetAmount(amount:  count);
            return val_4;
        }
        public RoyalPassExtraWarnBarRewardView()
        {
        
        }
    
    }

}
