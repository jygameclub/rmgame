using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass
{
    [Serializable]
    public class RoyalPassReward
    {
        // Fields
        public string t;
        public int a;
        
        // Methods
        public Royal.Player.Context.Units.RewardType GetRewardType()
        {
            var val_17;
            uint val_1 = _PrivateImplementationDetails_.ComputeStringHash(s:  this.t);
            if(val_1 > (-1112900628))
            {
                goto label_1;
            }
            
            if(val_1 > 1508438041)
            {
                goto label_2;
            }
            
            if(val_1 == 620754425)
            {
                goto label_3;
            }
            
            if(val_1 == 1473897065)
            {
                goto label_4;
            }
            
            if((val_1 != 1508438041) || ((System.String.op_Equality(a:  this.t, b:  "IG")) == false))
            {
                goto label_50;
            }
            
            val_17 = 10;
            return (Royal.Player.Context.Units.RewardType)val_17;
            label_1:
            if(val_1 > (-854850313))
            {
                goto label_8;
            }
            
            if(val_1 > (-972293646))
            {
                goto label_9;
            }
            
            if(val_1 == (-1005848884))
            {
                goto label_10;
            }
            
            if((val_1 != (-972293646)) || ((System.String.op_Equality(a:  this.t, b:  "C")) == false))
            {
                goto label_50;
            }
            
            val_17 = 1;
            return (Royal.Player.Context.Units.RewardType)val_17;
            label_2:
            if(val_1 > 1727238636)
            {
                goto label_14;
            }
            
            if(val_1 == 1693683398)
            {
                goto label_15;
            }
            
            if((val_1 != 1727238636) || ((System.String.op_Equality(a:  this.t, b:  "UT")) == false))
            {
                goto label_50;
            }
            
            val_17 = 4;
            return (Royal.Player.Context.Units.RewardType)val_17;
            label_8:
            if(val_1 > (-810903486))
            {
                goto label_19;
            }
            
            if(val_1 == (-821295075))
            {
                goto label_20;
            }
            
            if((val_1 != (-810903486)) || ((System.String.op_Equality(a:  this.t, b:  "ULB")) == false))
            {
                goto label_50;
            }
            
            val_17 = 5;
            return (Royal.Player.Context.Units.RewardType)val_17;
            label_9:
            if(val_1 == (-921960789))
            {
                goto label_24;
            }
            
            if((val_1 != (-854850313)) || ((System.String.op_Equality(a:  this.t, b:  "H")) == false))
            {
                goto label_50;
            }
            
            val_17 = 6;
            return (Royal.Player.Context.Units.RewardType)val_17;
            label_14:
            if(val_1 == (-1146455866))
            {
                goto label_28;
            }
            
            if((val_1 != (-1112900628)) || ((System.String.op_Equality(a:  this.t, b:  "ULP")) == false))
            {
                goto label_50;
            }
            
            val_17 = 15;
            return (Royal.Player.Context.Units.RewardType)val_17;
            label_19:
            if(val_1 == (-787739837))
            {
                goto label_32;
            }
            
            if((val_1 != (-687074123)) || ((System.String.op_Equality(a:  this.t, b:  "R")) == false))
            {
                goto label_50;
            }
            
            val_17 = 13;
            return (Royal.Player.Context.Units.RewardType)val_17;
            label_3:
            if((System.String.op_Equality(a:  this.t, b:  "PL")) == false)
            {
                goto label_50;
            }
            
            val_17 = 14;
            return (Royal.Player.Context.Units.RewardType)val_17;
            label_4:
            if((System.String.op_Equality(a:  this.t, b:  "Ca")) == false)
            {
                goto label_50;
            }
            
            val_17 = 8;
            return (Royal.Player.Context.Units.RewardType)val_17;
            label_10:
            if((System.String.op_Equality(a:  this.t, b:  "A")) == false)
            {
                goto label_50;
            }
            
            val_17 = 7;
            return (Royal.Player.Context.Units.RewardType)val_17;
            label_15:
            if((System.String.op_Equality(a:  this.t, b:  "UR")) == false)
            {
                goto label_50;
            }
            
            val_17 = 3;
            return (Royal.Player.Context.Units.RewardType)val_17;
            label_20:
            if((System.String.op_Equality(a:  this.t, b:  "J")) == false)
            {
                goto label_50;
            }
            
            val_17 = 9;
            return (Royal.Player.Context.Units.RewardType)val_17;
            label_24:
            if((System.String.op_Equality(a:  this.t, b:  "L")) == false)
            {
                goto label_50;
            }
            
            val_17 = 12;
            return (Royal.Player.Context.Units.RewardType)val_17;
            label_28:
            if((System.String.op_Equality(a:  this.t, b:  "ULV")) == false)
            {
                goto label_50;
            }
            
            val_17 = 2;
            return (Royal.Player.Context.Units.RewardType)val_17;
            label_32:
            if((System.String.op_Equality(a:  this.t, b:  "T")) != false)
            {
                    val_17 = 11;
                return (Royal.Player.Context.Units.RewardType)val_17;
            }
            
            label_50:
            val_17 = 0;
            return (Royal.Player.Context.Units.RewardType)val_17;
        }
        private string GetCoinAmountTextInFormat(int coinAmount)
        {
            object val_2 = System.Globalization.CultureInfo.InvariantCulture.Clone();
            if(null == null)
            {
                    val_2.NumberGroupSeparator = " ";
                return (string)coinAmount.ToString(format:  "#,0", provider:  val_2);
            }
        
        }
        public string GetAmountOrDurationText()
        {
            string val_6;
            string val_7;
            var val_8;
            uint val_1 = _PrivateImplementationDetails_.ComputeStringHash(s:  this.t);
            if(val_1 > (-1112900628))
            {
                goto label_1;
            }
            
            if(val_1 > 1508438041)
            {
                goto label_2;
            }
            
            if(val_1 == 620754425)
            {
                goto label_3;
            }
            
            if(val_1 == 1473897065)
            {
                goto label_4;
            }
            
            if(val_1 != 1508438041)
            {
                goto label_38;
            }
            
            val_6 = "IG";
            goto label_34;
            label_1:
            if(val_1 > (-854850313))
            {
                goto label_7;
            }
            
            if(val_1 > (-972293646))
            {
                goto label_8;
            }
            
            if(val_1 == (-1005848884))
            {
                goto label_9;
            }
            
            if(val_1 != (-972293646))
            {
                goto label_38;
            }
            
            bool val_2 = System.String.op_Equality(a:  this.t, b:  "C");
            if(val_2 == false)
            {
                goto label_38;
            }
            
            return val_2.GetCoinAmountTextInFormat(coinAmount:  this.a);
            label_2:
            if(val_1 > 1727238636)
            {
                goto label_12;
            }
            
            if(val_1 == 1693683398)
            {
                goto label_13;
            }
            
            if(val_1 != 1727238636)
            {
                goto label_38;
            }
            
            val_7 = "UT";
            goto label_32;
            label_7:
            if(val_1 > (-810903486))
            {
                goto label_16;
            }
            
            if(val_1 == (-821295075))
            {
                goto label_17;
            }
            
            if(val_1 != (-810903486))
            {
                goto label_38;
            }
            
            val_7 = "ULB";
            goto label_32;
            label_8:
            if(val_1 == (-921960789))
            {
                goto label_20;
            }
            
            if(val_1 != (-854850313))
            {
                goto label_38;
            }
            
            val_6 = "H";
            goto label_34;
            label_12:
            if(val_1 == (-1146455866))
            {
                goto label_23;
            }
            
            if(val_1 != (-1112900628))
            {
                goto label_38;
            }
            
            val_7 = "ULP";
            goto label_32;
            label_16:
            if(val_1 == (-787739837))
            {
                goto label_26;
            }
            
            if(val_1 != (-687074123))
            {
                goto label_38;
            }
            
            val_6 = "R";
            goto label_34;
            label_3:
            val_6 = "PL";
            goto label_34;
            label_4:
            val_6 = "Ca";
            goto label_34;
            label_9:
            val_6 = "A";
            goto label_34;
            label_13:
            val_7 = "UR";
            goto label_32;
            label_17:
            val_6 = "J";
            goto label_34;
            label_20:
            val_6 = "L";
            goto label_34;
            label_23:
            val_7 = "ULV";
            label_32:
            if((System.String.op_Equality(a:  this.t, b:  val_7)) == false)
            {
                goto label_38;
            }
            
            return Royal.Infrastructure.Utils.Time.TimeUtil.GetDurationInMinutesOrHours(totalMinutes:  this.a);
            label_26:
            val_6 = "T";
            label_34:
            if((System.String.op_Equality(a:  this.t, b:  val_6)) != false)
            {
                    string val_5 = "x" + this.a;
                return (string)val_8;
            }
            
            label_38:
            val_8 = "";
            return (string)val_8;
        }
        public RoyalPassReward()
        {
        
        }
    
    }

}
