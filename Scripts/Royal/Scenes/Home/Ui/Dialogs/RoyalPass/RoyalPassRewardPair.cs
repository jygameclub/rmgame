using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass
{
    [Serializable]
    public class RoyalPassRewardPair
    {
        // Fields
        public string fn;
        public Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassReward[] f;
        public string gn;
        public Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassReward[] g;
        
        // Methods
        public Royal.Player.Context.Units.RewardName GetFreeChestName()
        {
            var val_2;
            if(this.fn != null)
            {
                    if((this.fn.StartsWith(value:  "Wood")) != false)
            {
                    val_2 = 7;
                return (Royal.Player.Context.Units.RewardName)val_2;
            }
            
            }
            
            val_2 = 0;
            return (Royal.Player.Context.Units.RewardName)val_2;
        }
        public string GetFreeChestRewardsPrefabName()
        {
            string val_8 = "WoodChestFirstRewards";
            if((System.String.op_Equality(a:  this.fn, b:  "WoodFirst")) == true)
            {
                    return (string)((System.String.op_Equality(a:  this.fn, b:  "WoodSixth")) != true) ? "WoodChestSixthRewards" : (val_8);
            }
            
            if((System.String.op_Equality(a:  this.fn, b:  "WoodSecond")) != false)
            {
                    val_8 = "WoodChestSecondRewards";
                return (string)((System.String.op_Equality(a:  this.fn, b:  "WoodSixth")) != true) ? "WoodChestSixthRewards" : (val_8);
            }
            
            if((System.String.op_Equality(a:  this.fn, b:  "WoodThird")) != false)
            {
                    val_8 = "WoodChestThirdRewards";
                return (string)((System.String.op_Equality(a:  this.fn, b:  "WoodSixth")) != true) ? "WoodChestSixthRewards" : (val_8);
            }
            
            if((System.String.op_Equality(a:  this.fn, b:  "WoodFourth")) != false)
            {
                    val_8 = "WoodChestFourthRewards";
                return (string)((System.String.op_Equality(a:  this.fn, b:  "WoodSixth")) != true) ? "WoodChestSixthRewards" : (val_8);
            }
            
            if((System.String.op_Equality(a:  this.fn, b:  "WoodFifth")) == false)
            {
                    return (string)((System.String.op_Equality(a:  this.fn, b:  "WoodSixth")) != true) ? "WoodChestSixthRewards" : (val_8);
            }
            
            val_8 = "WoodChestFifthRewards";
            return (string)((System.String.op_Equality(a:  this.fn, b:  "WoodSixth")) != true) ? "WoodChestSixthRewards" : (val_8);
        }
        public Royal.Player.Context.Units.RewardName GetGoldChestName()
        {
            var val_9;
            uint val_1 = _PrivateImplementationDetails_.ComputeStringHash(s:  this.gn);
            if(val_1 > 1114770351)
            {
                goto label_1;
            }
            
            if(val_1 == 163471254)
            {
                goto label_2;
            }
            
            if(val_1 == 760494712)
            {
                goto label_3;
            }
            
            if((val_1 != 1114770351) || ((System.String.op_Equality(a:  this.gn, b:  "Bone")) == false))
            {
                goto label_22;
            }
            
            val_9 = 8;
            return (Royal.Player.Context.Units.RewardName)val_9;
            label_1:
            if(val_1 > (-1454127268))
            {
                goto label_7;
            }
            
            if(val_1 == (-1993510855))
            {
                goto label_8;
            }
            
            if((val_1 != (-1454127268)) || ((System.String.op_Equality(a:  this.gn, b:  "Green")) == false))
            {
                goto label_22;
            }
            
            val_9 = 9;
            return (Royal.Player.Context.Units.RewardName)val_9;
            label_7:
            if(val_1 == (-1194237607))
            {
                goto label_12;
            }
            
            if((val_1 != (-538148656)) || ((System.String.op_Equality(a:  this.gn, b:  "Special")) == false))
            {
                goto label_22;
            }
            
            val_9 = 11;
            return (Royal.Player.Context.Units.RewardName)val_9;
            label_2:
            if((System.String.op_Equality(a:  this.gn, b:  "Medium")) == false)
            {
                goto label_22;
            }
            
            val_9 = 5;
            return (Royal.Player.Context.Units.RewardName)val_9;
            label_3:
            if((System.String.op_Equality(a:  this.gn, b:  "Safe")) == false)
            {
                goto label_22;
            }
            
            val_9 = 12;
            return (Royal.Player.Context.Units.RewardName)val_9;
            label_8:
            if((System.String.op_Equality(a:  this.gn, b:  "Fleur")) == false)
            {
                goto label_22;
            }
            
            val_9 = 10;
            return (Royal.Player.Context.Units.RewardName)val_9;
            label_12:
            if((System.String.op_Equality(a:  this.gn, b:  "Big")) != false)
            {
                    val_9 = 6;
                return (Royal.Player.Context.Units.RewardName)val_9;
            }
            
            label_22:
            val_9 = 0;
            return (Royal.Player.Context.Units.RewardName)val_9;
        }
        public bool IsChestReward()
        {
            var val_4;
            if((System.String.IsNullOrEmpty(value:  this.fn)) != false)
            {
                    val_4 = (System.String.IsNullOrEmpty(value:  this.gn)) ^ 1;
                return (bool)val_4 & 1;
            }
            
            val_4 = 1;
            return (bool)val_4 & 1;
        }
        public RoyalPassRewardPair()
        {
        
        }
    
    }

}
