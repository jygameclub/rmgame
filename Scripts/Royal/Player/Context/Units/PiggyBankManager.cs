using UnityEngine;

namespace Royal.Player.Context.Units
{
    public class PiggyBankManager : IContextUnit
    {
        // Fields
        public const int CoinPurchaseThreshold = 3000;
        public const int CoinMax = 5000;
        public const int CoinMultiplier = 7;
        public const int PiggyBankUnlockLevel = 15;
        private Royal.Scenes.Start.Context.Units.Flow.FlowManager flowManager;
        
        // Properties
        public int Id { get; }
        public bool ShouldShowIcon { get; }
        public bool CanSkipPiggyAnimation { get; }
        
        // Methods
        public int get_Id()
        {
            return 8;
        }
        public void Bind()
        {
            this.flowManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
        }
        public bool get_ShouldShowIcon()
        {
            var val_3;
            if(Royal.Player.Context.Data.Persistent.AbTestData.IsPiggyBankEnabled() != false)
            {
                    var val_2 = (typeof(Royal.Player.Context.Data.Persistent.BasicUserData).__il2cppRuntimeField_14 > 15) ? 1 : 0;
                return (bool)val_3;
            }
            
            val_3 = 0;
            return (bool)val_3;
        }
        public bool get_CanSkipPiggyAnimation()
        {
            return (bool)(typeof(Royal.Player.Context.Data.Persistent.BasicUserData).__il2cppRuntimeField_14 > 18) ? 1 : 0;
        }
        public static int GetPiggy()
        {
            return GetPiggy();
        }
        public static double GetThresholdToMaxRatio()
        {
            return 0.6;
        }
        public float GetCurrentPiggyToMaxRatio()
        {
            float val_2 = 5000f;
            val_2 = (float)Royal.Player.Context.Units.PiggyBankManager.GetPiggy() / val_2;
            return (float)val_2;
        }
        public bool CanPurchase()
        {
            return (bool)(Royal.Player.Context.Units.PiggyBankManager.GetPiggy() > 2999) ? 1 : 0;
        }
        public static Royal.Player.Context.Units.PiggyBankStatusDialogType GetPiggyBankStatusDialogTypeByAmount()
        {
            if(Royal.Player.Context.Units.PiggyBankManager.GetPiggy() >= 3000)
            {
                    return (Royal.Player.Context.Units.PiggyBankStatusDialogType)(Royal.Player.Context.Units.PiggyBankManager.GetPiggy() >= 5000) ? (2 + 1) : 2;
            }
            
            return 1;
        }
        public Royal.Player.Context.Units.PiggyBankAutoDialogState GetPiggyBankAutoDialogState()
        {
            return Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetInt(key:  "PiggyBankAutoDialogState", defaultValue:  0);
        }
        private void CalculatePiggyBankAutoDialogStateAfterWin()
        {
            var val_5;
            if(Royal.Player.Context.Data.Persistent.AbTestData.IsPiggyBankEnabled() == false)
            {
                    return;
            }
            
            bool val_2 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetInt(key:  "PiggyBankAutoDialogState", value:  1);
            val_5 = mem[Royal.Player.Context.Data.Session.__il2cppRuntimeField_68 + 20];
            val_5 = Royal.Player.Context.Data.Session.__il2cppRuntimeField_68 + 20;
            if(val_5 > 4999)
            {
                    return;
            }
            
            bool val_3 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetInt(key:  "PiggyBankAutoDialogState", value:  3);
            val_5 = mem[Royal.Player.Context.Data.Session.__il2cppRuntimeField_68 + 20];
            val_5 = Royal.Player.Context.Data.Session.__il2cppRuntimeField_68 + 20;
            if(val_5 > 2999)
            {
                    return;
            }
            
            bool val_4 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetInt(key:  "PiggyBankAutoDialogState", value:  2);
        }
        private void ResetPiggyBankAutoDialogState()
        {
            bool val_1 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetInt(key:  "PiggyBankAutoDialogState", value:  0);
        }
        public bool TryAddPiggyBankAutoDialog(bool canShowInCurrentFlow)
        {
            Royal.Scenes.Start.Context.Units.Flow.FlowManager val_3;
            Royal.Scenes.Start.Context.Units.Flow.FlowAction val_4;
            var val_5;
            var val_6;
            var val_7;
            val_3 = this;
            this.CalculatePiggyBankAutoDialogStateAfterWin();
            if(canShowInCurrentFlow == false)
            {
                goto label_4;
            }
            
            Royal.Player.Context.Units.PiggyBankAutoDialogState val_1 = this.GetPiggyBankAutoDialogState();
            val_1.ResetPiggyBankAutoDialogState();
            if((val_1 == 3) || (val_1 == 2))
            {
                goto label_3;
            }
            
            if(val_1 != 1)
            {
                goto label_4;
            }
            
            val_3 = this.flowManager;
            val_4 = new Royal.Scenes.Home.Ui.Dialogs.PiggyBank.ShowPiggyBankStatusDialogAction();
            val_5 = 1;
            val_6 = 0;
            goto label_5;
            label_4:
            val_7 = 0;
            return (bool)val_7;
            label_3:
            val_3 = this.flowManager;
            Royal.Scenes.Home.Ui.Dialogs.PiggyBank.ShowPiggyBankStatusDialogAction val_2 = null;
            val_4 = val_2;
            val_6 = 0;
            val_5 = 0;
            label_5:
            val_2 = new Royal.Scenes.Home.Ui.Dialogs.PiggyBank.ShowPiggyBankStatusDialogAction(disableTouch:  false, newPiggy:  false, fromAnotherDialog:  false);
            val_3.Push(action:  val_2);
            val_7 = 1;
            return (bool)val_7;
        }
        public void SetLastSeenProgressPercentage(int percentage)
        {
            bool val_1 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetInt(key:  "PiggyBankLastSeenRatio", value:  percentage);
        }
        public int GetLastSeenProgressPercentage()
        {
            return Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetInt(key:  "PiggyBankLastSeenRatio", defaultValue:  0);
        }
        public static int CalculateExtraPiggyCoins(int currentPiggy, int newCoins)
        {
            newCoins = (newCoins << 3) - newCoins;
            return UnityEngine.Mathf.Min(a:  5000 - currentPiggy, b:  newCoins);
        }
        public static string GetTextFromAmount(int amount)
        {
            if(amount > 4999)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Full");
            }
            
            return (string)amount.ToString();
        }
        public PiggyBankManager()
        {
        
        }
    
    }

}
