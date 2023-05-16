using UnityEngine;

namespace Royal.Player.Context.Units
{
    [Serializable]
    public class MadnessStep
    {
        // Fields
        public int s;
        public int t;
        public string n;
        public Royal.Player.Context.Units.MadnessReward[] r;
        
        // Methods
        public Royal.Player.Context.Units.RewardName GetRewardName()
        {
            var val_8;
            if((System.String.op_Equality(a:  this.n, b:  "Small")) != false)
            {
                    val_8 = 1;
                return (Royal.Player.Context.Units.RewardName)((System.String.op_Equality(a:  this.n, b:  "BigChest")) != true) ? 6 : 0;
            }
            
            if((System.String.op_Equality(a:  this.n, b:  "Medium")) != false)
            {
                    val_8 = 2;
                return (Royal.Player.Context.Units.RewardName)((System.String.op_Equality(a:  this.n, b:  "BigChest")) != true) ? 6 : 0;
            }
            
            if((System.String.op_Equality(a:  this.n, b:  "Big")) != false)
            {
                    val_8 = 3;
                return (Royal.Player.Context.Units.RewardName)((System.String.op_Equality(a:  this.n, b:  "BigChest")) != true) ? 6 : 0;
            }
            
            if((System.String.op_Equality(a:  this.n, b:  "SmallChest")) != false)
            {
                    val_8 = 4;
                return (Royal.Player.Context.Units.RewardName)((System.String.op_Equality(a:  this.n, b:  "BigChest")) != true) ? 6 : 0;
            }
            
            if((System.String.op_Equality(a:  this.n, b:  "MediumChest")) == false)
            {
                    return (Royal.Player.Context.Units.RewardName)((System.String.op_Equality(a:  this.n, b:  "BigChest")) != true) ? 6 : 0;
            }
            
            val_8 = 5;
            return (Royal.Player.Context.Units.RewardName)((System.String.op_Equality(a:  this.n, b:  "BigChest")) != true) ? 6 : 0;
        }
        public string GetPrefabName(string prefix)
        {
            object val_10;
            string val_11;
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder(value:  prefix);
            if(this.GetRewardName() != 0)
            {
                    Royal.Player.Context.Units.RewardName val_3 = this.GetRewardName();
                val_10 = val_3;
                System.Text.StringBuilder val_4 = val_1.Append(value:  val_3);
                return (string)val_1;
            }
            
            Royal.Player.Context.Units.MadnessReward val_5 = System.Linq.Enumerable.First<Royal.Player.Context.Units.MadnessReward>(source:  this.r);
            Royal.Player.Context.Units.RewardType val_6 = val_5.GetRewardType();
            val_10 = val_6;
            System.Text.StringBuilder val_7 = val_1.Append(value:  val_6);
            if(val_5.GetRewardType() != 1)
            {
                    return (string)val_1;
            }
            
            if(val_5.a >= 10000)
            {
                goto label_7;
            }
            
            if(val_5.a >= 5000)
            {
                goto label_8;
            }
            
            if(val_5.a >= 1000)
            {
                goto label_9;
            }
            
            val_11 = "100";
            goto label_12;
            label_7:
            val_11 = "10000";
            goto label_12;
            label_8:
            val_11 = "5000";
            goto label_12;
            label_9:
            val_11 = "1000";
            label_12:
            System.Text.StringBuilder val_9 = val_1.Append(value:  val_11);
            return (string)val_1;
        }
        public string GetRewardText()
        {
            if(this.GetRewardName() == 0)
            {
                    return System.Linq.Enumerable.First<Royal.Player.Context.Units.MadnessReward>(source:  this.r).GetAmountOrDurationText();
            }
            
            return 0;
        }
        public MadnessStep()
        {
        
        }
    
    }

}
