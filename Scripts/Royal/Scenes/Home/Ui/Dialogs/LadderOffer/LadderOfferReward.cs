using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.LadderOffer
{
    [Serializable]
    public class LadderOfferReward
    {
        // Fields
        public string t;
        public int a;
        
        // Methods
        public Royal.Player.Context.Units.RewardType GetRewardType()
        {
            var val_23;
            uint val_1 = _PrivateImplementationDetails_.ComputeStringHash(s:  this.t);
            if(val_1 > (-1232946657))
            {
                goto label_1;
            }
            
            if(val_1 > 1508438041)
            {
                goto label_2;
            }
            
            if(val_1 > 620754425)
            {
                goto label_3;
            }
            
            if(val_1 == 163471254)
            {
                goto label_4;
            }
            
            if((val_1 != 620754425) || ((System.String.op_Equality(a:  this.t, b:  "PL")) == false))
            {
                goto label_69;
            }
            
            val_23 = 14;
            return (Royal.Player.Context.Units.RewardType)val_23;
            label_1:
            if(val_1 > (-972293646))
            {
                goto label_8;
            }
            
            if(val_1 > (-1146455866))
            {
                goto label_9;
            }
            
            if(val_1 == (-1194237607))
            {
                goto label_10;
            }
            
            if((val_1 != (-1146455866)) || ((System.String.op_Equality(a:  this.t, b:  "ULV")) == false))
            {
                goto label_69;
            }
            
            val_23 = 2;
            return (Royal.Player.Context.Units.RewardType)val_23;
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
                goto label_69;
            }
            
            val_23 = 4;
            return (Royal.Player.Context.Units.RewardType)val_23;
            label_8:
            if(val_1 > (-821295075))
            {
                goto label_19;
            }
            
            if(val_1 == (-921960789))
            {
                goto label_20;
            }
            
            if(val_1 == (-854850313))
            {
                goto label_21;
            }
            
            if((val_1 != (-821295075)) || ((System.String.op_Equality(a:  this.t, b:  "J")) == false))
            {
                goto label_69;
            }
            
            val_23 = 9;
            return (Royal.Player.Context.Units.RewardType)val_23;
            label_3:
            if(val_1 == 1216374316)
            {
                goto label_25;
            }
            
            if(val_1 == 1473897065)
            {
                goto label_26;
            }
            
            if((val_1 != 1508438041) || ((System.String.op_Equality(a:  this.t, b:  "IG")) == false))
            {
                goto label_69;
            }
            
            val_23 = 10;
            return (Royal.Player.Context.Units.RewardType)val_23;
            label_9:
            if(val_1 == (-1112900628))
            {
                goto label_30;
            }
            
            if(val_1 == (-1005848884))
            {
                goto label_31;
            }
            
            if((val_1 != (-972293646)) || ((System.String.op_Equality(a:  this.t, b:  "C")) == false))
            {
                goto label_69;
            }
            
            val_23 = 1;
            return (Royal.Player.Context.Units.RewardType)val_23;
            label_14:
            if(val_1 == (-1950874739))
            {
                goto label_35;
            }
            
            if(val_1 == (-1551951748))
            {
                goto label_36;
            }
            
            if((val_1 != (-1232946657)) || ((System.String.op_Equality(a:  this.t, b:  "Purple")) == false))
            {
                goto label_69;
            }
            
            val_23 = 18;
            return (Royal.Player.Context.Units.RewardType)val_23;
            label_19:
            if(val_1 == (-810903486))
            {
                goto label_40;
            }
            
            if(val_1 == (-787739837))
            {
                goto label_41;
            }
            
            if((val_1 != (-687074123)) || ((System.String.op_Equality(a:  this.t, b:  "R")) == false))
            {
                goto label_69;
            }
            
            val_23 = 13;
            return (Royal.Player.Context.Units.RewardType)val_23;
            label_4:
            if((System.String.op_Equality(a:  this.t, b:  "Medium")) == false)
            {
                goto label_69;
            }
            
            val_23 = 20;
            return (Royal.Player.Context.Units.RewardType)val_23;
            label_10:
            if((System.String.op_Equality(a:  this.t, b:  "Big")) == false)
            {
                goto label_69;
            }
            
            val_23 = 21;
            return (Royal.Player.Context.Units.RewardType)val_23;
            label_15:
            if((System.String.op_Equality(a:  this.t, b:  "UR")) == false)
            {
                goto label_69;
            }
            
            val_23 = 3;
            return (Royal.Player.Context.Units.RewardType)val_23;
            label_20:
            if((System.String.op_Equality(a:  this.t, b:  "L")) == false)
            {
                goto label_69;
            }
            
            val_23 = 12;
            return (Royal.Player.Context.Units.RewardType)val_23;
            label_21:
            if((System.String.op_Equality(a:  this.t, b:  "H")) == false)
            {
                goto label_69;
            }
            
            val_23 = 6;
            return (Royal.Player.Context.Units.RewardType)val_23;
            label_25:
            if((System.String.op_Equality(a:  this.t, b:  "Small")) == false)
            {
                goto label_69;
            }
            
            val_23 = 19;
            return (Royal.Player.Context.Units.RewardType)val_23;
            label_26:
            if((System.String.op_Equality(a:  this.t, b:  "Ca")) == false)
            {
                goto label_69;
            }
            
            val_23 = 8;
            return (Royal.Player.Context.Units.RewardType)val_23;
            label_30:
            if((System.String.op_Equality(a:  this.t, b:  "ULP")) == false)
            {
                goto label_69;
            }
            
            val_23 = 15;
            return (Royal.Player.Context.Units.RewardType)val_23;
            label_31:
            if((System.String.op_Equality(a:  this.t, b:  "A")) == false)
            {
                goto label_69;
            }
            
            val_23 = 7;
            return (Royal.Player.Context.Units.RewardType)val_23;
            label_35:
            if((System.String.op_Equality(a:  this.t, b:  "Pink")) == false)
            {
                goto label_69;
            }
            
            val_23 = 16;
            return (Royal.Player.Context.Units.RewardType)val_23;
            label_36:
            if((System.String.op_Equality(a:  this.t, b:  "Red")) == false)
            {
                goto label_69;
            }
            
            val_23 = 17;
            return (Royal.Player.Context.Units.RewardType)val_23;
            label_40:
            if((System.String.op_Equality(a:  this.t, b:  "ULB")) == false)
            {
                goto label_69;
            }
            
            val_23 = 5;
            return (Royal.Player.Context.Units.RewardType)val_23;
            label_41:
            if((System.String.op_Equality(a:  this.t, b:  "T")) != false)
            {
                    val_23 = 11;
                return (Royal.Player.Context.Units.RewardType)val_23;
            }
            
            label_69:
            val_23 = 0;
            return (Royal.Player.Context.Units.RewardType)val_23;
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
        public LadderOfferReward()
        {
        
        }
    
    }

}
