using UnityEngine;

namespace Royal.Player.Context.Units
{
    [Serializable]
    public class MadnessReward
    {
        // Fields
        public string t;
        public int a;
        
        // Methods
        public Royal.Player.Context.Units.RewardType GetRewardType()
        {
            var val_12;
            uint val_1 = _PrivateImplementationDetails_.ComputeStringHash(s:  this.t);
            if(val_1 > (-1146455866))
            {
                goto label_1;
            }
            
            if(val_1 > 1508438041)
            {
                goto label_2;
            }
            
            if(val_1 == 1473897065)
            {
                goto label_3;
            }
            
            if((val_1 != 1508438041) || ((System.String.op_Equality(a:  this.t, b:  "IG")) == false))
            {
                goto label_32;
            }
            
            val_12 = 10;
            return (Royal.Player.Context.Units.RewardType)val_12;
            label_1:
            if(val_1 > (-972293646))
            {
                goto label_7;
            }
            
            if(val_1 == (-1005848884))
            {
                goto label_8;
            }
            
            if((val_1 != (-972293646)) || ((System.String.op_Equality(a:  this.t, b:  "C")) == false))
            {
                goto label_32;
            }
            
            val_12 = 1;
            return (Royal.Player.Context.Units.RewardType)val_12;
            label_2:
            if(val_1 == (-1146455866))
            {
                goto label_12;
            }
            
            if(val_1 == 1693683398)
            {
                goto label_13;
            }
            
            if((val_1 != 1727238636) || ((System.String.op_Equality(a:  this.t, b:  "UT")) == false))
            {
                goto label_32;
            }
            
            val_12 = 4;
            return (Royal.Player.Context.Units.RewardType)val_12;
            label_7:
            if(val_1 == (-854850313))
            {
                goto label_17;
            }
            
            if(val_1 == (-821295075))
            {
                goto label_18;
            }
            
            if((val_1 != (-810903486)) || ((System.String.op_Equality(a:  this.t, b:  "ULB")) == false))
            {
                goto label_32;
            }
            
            val_12 = 5;
            return (Royal.Player.Context.Units.RewardType)val_12;
            label_3:
            if((System.String.op_Equality(a:  this.t, b:  "Ca")) == false)
            {
                goto label_32;
            }
            
            val_12 = 8;
            return (Royal.Player.Context.Units.RewardType)val_12;
            label_8:
            if((System.String.op_Equality(a:  this.t, b:  "A")) == false)
            {
                goto label_32;
            }
            
            val_12 = 7;
            return (Royal.Player.Context.Units.RewardType)val_12;
            label_12:
            if((System.String.op_Equality(a:  this.t, b:  "ULV")) == false)
            {
                goto label_32;
            }
            
            val_12 = 2;
            return (Royal.Player.Context.Units.RewardType)val_12;
            label_13:
            if((System.String.op_Equality(a:  this.t, b:  "UR")) == false)
            {
                goto label_32;
            }
            
            val_12 = 3;
            return (Royal.Player.Context.Units.RewardType)val_12;
            label_17:
            if((System.String.op_Equality(a:  this.t, b:  "H")) == false)
            {
                goto label_32;
            }
            
            val_12 = 6;
            return (Royal.Player.Context.Units.RewardType)val_12;
            label_18:
            if((System.String.op_Equality(a:  this.t, b:  "J")) != false)
            {
                    val_12 = 9;
                return (Royal.Player.Context.Units.RewardType)val_12;
            }
            
            label_32:
            val_12 = 0;
            return (Royal.Player.Context.Units.RewardType)val_12;
        }
        public string GetAmountOrDurationText()
        {
            string val_4;
            string val_5;
            uint val_1 = _PrivateImplementationDetails_.ComputeStringHash(s:  this.t);
            if(val_1 > (-1146455866))
            {
                goto label_1;
            }
            
            if(val_1 > 1508438041)
            {
                goto label_2;
            }
            
            if(val_1 == 1473897065)
            {
                goto label_3;
            }
            
            if(val_1 != 1508438041)
            {
                    return "";
            }
            
            val_4 = "IG";
            goto label_24;
            label_1:
            if(val_1 > (-972293646))
            {
                goto label_6;
            }
            
            if(val_1 == (-1005848884))
            {
                goto label_7;
            }
            
            if(val_1 != (-972293646))
            {
                    return "";
            }
            
            val_4 = "C";
            goto label_24;
            label_2:
            if(val_1 == (-1146455866))
            {
                goto label_10;
            }
            
            if(val_1 == 1693683398)
            {
                goto label_11;
            }
            
            if(val_1 != 1727238636)
            {
                    return "";
            }
            
            val_5 = "UT";
            goto label_20;
            label_6:
            if(val_1 == (-854850313))
            {
                goto label_14;
            }
            
            if(val_1 == (-821295075))
            {
                goto label_15;
            }
            
            if(val_1 != (-810903486))
            {
                    return "";
            }
            
            val_5 = "ULB";
            goto label_20;
            label_3:
            val_4 = "Ca";
            goto label_24;
            label_7:
            val_4 = "A";
            goto label_24;
            label_10:
            val_5 = "ULV";
            goto label_20;
            label_11:
            val_5 = "UR";
            label_20:
            if((System.String.op_Equality(a:  this.t, b:  val_5)) == false)
            {
                    return "";
            }
            
            return Royal.Infrastructure.Utils.Time.TimeUtil.GetDurationInMinutesOrHours(totalMinutes:  this.a);
            label_14:
            val_4 = "H";
            goto label_24;
            label_15:
            val_4 = "J";
            label_24:
            if((System.String.op_Equality(a:  this.t, b:  val_4)) == false)
            {
                    return "";
            }
            
            return this.a.ToString();
        }
        public MadnessReward()
        {
        
        }
    
    }

}
