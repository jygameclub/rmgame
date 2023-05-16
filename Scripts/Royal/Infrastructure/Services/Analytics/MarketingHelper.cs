using UnityEngine;

namespace Royal.Infrastructure.Services.Analytics
{
    public class MarketingHelper
    {
        // Fields
        private readonly bool shouldCheckForSpendingEvent;
        private bool isAlreadyPayer;
        
        // Methods
        public MarketingHelper()
        {
            com.adjust.sdk.Adjust.start(adjustConfig:  Royal.Infrastructure.Services.Analytics.MarketingHelper.GetConfiguration());
            this.UpdateUserData();
            Royal.Infrastructure.Services.Analytics.MarketingHelper.SendSessionEvent();
            this.shouldCheckForSpendingEvent = (((Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.GetLong(key:  "InstallTime", defaultValue:  0)) + 86400000) > Royal.Infrastructure.Utils.Time.TimeUtil.CurrentTimeInMs()) ? 1 : 0;
        }
        public static void Initialize()
        {
            DeltaDNA.Singleton<DeltaDNA.DDNA>.Instance = "ANDROID";
            DeltaDNA.DDNA val_2 = DeltaDNA.Singleton<DeltaDNA.DDNA>.Instance;
            val_2.<AndroidNotifications>k__BackingField.enabled = false;
            DeltaDNA.DDNA val_3 = DeltaDNA.Singleton<DeltaDNA.DDNA>.Instance;
            val_3.<Settings>k__BackingField = 0;
            DeltaDNA.DDNA val_4 = DeltaDNA.Singleton<DeltaDNA.DDNA>.Instance;
            val_4.<Settings>k__BackingField = 0;
            DeltaDNA.DDNA val_5 = DeltaDNA.Singleton<DeltaDNA.DDNA>.Instance;
            val_5.<Settings>k__BackingField = 0;
            DeltaDNA.DDNA val_6 = DeltaDNA.Singleton<DeltaDNA.DDNA>.Instance;
            val_6.<Settings>k__BackingField = 0;
            DeltaDNA.Singleton<DeltaDNA.DDNA>.Instance.SetLoggingLevel(level:  3);
            DeltaDNA.Singleton<DeltaDNA.DDNA>.Instance.StartSDK(config:  Royal.Infrastructure.Services.Analytics.MarketingHelper.GetDeltaDnaSdkConfiguration());
        }
        private static DeltaDNA.Configuration GetDeltaDnaSdkConfiguration()
        {
            DeltaDNA.Configuration val_1 = UnityEngine.ScriptableObject.CreateInstance<DeltaDNA.Configuration>();
            var val_4 = val_1;
            val_1 = "89354295569886864863601134616170";
            val_1 = "89354308488169467647548656416170";
            val_1 = "https://collect21343rylmt.deltadna.net/collect/api";
            val_1 = "https://engage21343rylmt.deltadna.net";
            val_1 = "";
            val_4 = UnityEngine.Application.version;
            val_4 = false;
            int val_5 = ~Royal.Infrastructure.Utils.Native.DeviceHelper.IsDev;
            val_5 = val_5 & 1;
            val_4 = val_5;
            return (DeltaDNA.Configuration)val_4;
        }
        public void UpdateUserData()
        {
            this.isAlreadyPayer = IsPaidUser;
        }
        private static com.adjust.sdk.AdjustConfig GetConfiguration()
        {
            com.adjust.sdk.AdjustConfig val_1 = new com.adjust.sdk.AdjustConfig(appToken:  "w938ktn1x5a8", environment:  1);
            val_1.setAppSecret(secretId:  1, info1:  20, info2:  244, info3:  2, info4:  255);
            val_1.setLogLevel(logLevel:  5);
            return val_1;
        }
        public void SendPurchaseEvent(string productId, string transactionId, string receipt)
        {
            var val_9;
            var val_10;
            var val_11;
            object val_17;
            double val_18;
            string val_19;
            val_17 = this;
            if((System.String.IsNullOrEmpty(value:  productId)) != false)
            {
                    object[] val_2 = new object[1];
                val_2[0] = productId;
                Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  19, log:  "Cannot send purchase event to marketing because of product id: {0}", values:  val_2);
                return;
            }
            
            char[] val_3 = new char[1];
            val_3[0] = '.';
            double val_6 = System.Double.Parse(s:  productId.Split(separator:  val_3)[((-4294967296) + ((val_4.Length) << 32)) >> 29]);
            val_18 = val_6;
            val_19 = "USD";
            Royal.Infrastructure.Services.Analytics.MarketingHelper.SendExtraPurchaseEvents(usdPrice:  (int)val_6);
            Royal.Infrastructure.Services.Native.NativeService val_7 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Native.NativeService>(id:  19);
            Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct val_8 = val_7.purchaseManager.GetPurchaseProductOfProductId(productId:  productId);
            if(val_9 != 0)
            {
                    val_19 = val_11;
                val_18 = (double)val_10;
            }
            else
            {
                    object[] val_12 = new object[1];
                val_12[0] = productId;
                Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  19, log:  "Cannot find price and currency of product: {0}", values:  val_12);
            }
            
            com.adjust.sdk.AdjustEvent val_13 = new com.adjust.sdk.AdjustEvent(eventToken:  "a7wg06");
            val_13.setRevenue(amount:  val_18, currency:  val_19);
            .transactionId = transactionId;
            com.adjust.sdk.Adjust.trackEvent(adjustEvent:  val_13);
            decimal val_14 = System.Decimal.op_Explicit(value:  val_18);
            DeltaDNA.AudiencePinpointer.RecordPurchaseEvent(realCurrencyAmount:  DeltaDNA.Product<DeltaDNA.Product>.ConvertCurrency(code:  val_19, value:  new System.Decimal() {flags = val_14.flags, hi = val_14.hi, lo = val_14.lo, mid = val_14.mid}), realCurrencyType:  val_19, transactionID:  transactionId, transactionReceipt:  receipt);
            if(this.isAlreadyPayer == true)
            {
                    return;
            }
            
            this.isAlreadyPayer = true;
            com.adjust.sdk.AdjustEvent val_16 = null;
            val_17 = val_16;
            val_16 = new com.adjust.sdk.AdjustEvent(eventToken:  "9wi2y8");
            val_16.setRevenue(amount:  val_18, currency:  val_19);
            .transactionId = transactionId;
            com.adjust.sdk.Adjust.trackEvent(adjustEvent:  val_16);
        }
        private static void SendExtraPurchaseEvents(int usdPrice)
        {
            com.adjust.sdk.AdjustEvent val_9;
            string val_10;
            if((usdPrice - 2) <= 5)
            {
                    com.adjust.sdk.AdjustEvent val_2 = null;
                val_9 = val_2;
                val_2 = new com.adjust.sdk.AdjustEvent(eventToken:  "fibmx9");
                com.adjust.sdk.Adjust.trackEvent(adjustEvent:  val_2);
                val_10 = "in_app_purchase_2_to_7";
            }
            else
            {
                    if((usdPrice - 10) <= 10)
            {
                    com.adjust.sdk.AdjustEvent val_4 = null;
                val_9 = val_4;
                val_4 = new com.adjust.sdk.AdjustEvent(eventToken:  "ab7xdl");
                com.adjust.sdk.Adjust.trackEvent(adjustEvent:  val_4);
                val_10 = "in_app_purchase_10_to_20";
            }
            else
            {
                    if((usdPrice - 30) <= 25)
            {
                    com.adjust.sdk.AdjustEvent val_6 = null;
                val_9 = val_6;
                val_6 = new com.adjust.sdk.AdjustEvent(eventToken:  "kjdx85");
                com.adjust.sdk.Adjust.trackEvent(adjustEvent:  val_6);
                val_10 = "in_app_purchase_30_to_55";
            }
            else
            {
                    if((usdPrice - 80) > 20)
            {
                    return;
            }
            
                com.adjust.sdk.AdjustEvent val_8 = null;
                val_9 = val_8;
                val_8 = new com.adjust.sdk.AdjustEvent(eventToken:  "n94psh");
                com.adjust.sdk.Adjust.trackEvent(adjustEvent:  val_8);
                val_10 = "in_app_purchase_80_to_100";
            }
            
            }
            
            }
            
            Firebase.Analytics.FirebaseAnalytics.LogEvent(name:  val_10);
        }
        public static void SendLevelEndEvent(Royal.Player.Context.Data.Session.UserActiveLevelData levelData)
        {
            string val_8;
            string val_9;
            val_8 = levelData;
            if(val_8.IsWin == false)
            {
                    return;
            }
            
            if(val_8.IsLeague == true)
            {
                    return;
            }
            
            if(val_8.IsStory == true)
            {
                    return;
            }
            
            if(levelData.number > 40)
            {
                    return;
            }
            
            if(levelData.number <= 20)
            {
                goto label_6;
            }
            
            if(levelData.number <= 30)
            {
                goto label_7;
            }
            
            if(levelData.number == 35)
            {
                goto label_8;
            }
            
            if(levelData.number != 40)
            {
                    return;
            }
            
            val_9 = "5gdh49";
            goto label_22;
            label_6:
            if(levelData.number <= 10)
            {
                goto label_11;
            }
            
            if(levelData.number == 15)
            {
                goto label_12;
            }
            
            if(levelData.number != 20)
            {
                    return;
            }
            
            val_9 = "x2bisd";
            goto label_22;
            label_7:
            if(levelData.number == 25)
            {
                goto label_15;
            }
            
            if(levelData.number != 30)
            {
                    return;
            }
            
            val_9 = "breyad";
            goto label_22;
            label_11:
            int val_4 = levelData.number - 1;
            if(val_4 >= 10)
            {
                    return;
            }
            
            if(((535 >> val_4) & 1) == 0)
            {
                    return;
            }
            
            val_9 = mem[45230480 + ((levelData.number - 1)) << 3];
            val_9 = 45230480 + ((levelData.number - 1)) << 3;
            goto label_22;
            label_8:
            val_9 = "lw6dwc";
            goto label_22;
            label_12:
            val_9 = "8wefaz";
            goto label_22;
            label_15:
            val_9 = "sd145v";
            label_22:
            com.adjust.sdk.Adjust.trackEvent(adjustEvent:  new com.adjust.sdk.AdjustEvent(eventToken:  val_9));
            val_8 = "level_" + levelData.number;
            Firebase.Analytics.FirebaseAnalytics.LogEvent(name:  val_8);
        }
        private static void SendSessionEvent()
        {
            if((Royal.Infrastructure.Contexts.Units.App.AppManager.<SessionCount>k__BackingField) == 2)
            {
                goto label_2;
            }
            
            if((Royal.Infrastructure.Contexts.Units.App.AppManager.<SessionCount>k__BackingField) != 1)
            {
                goto label_4;
            }
            
            DeltaDNA.AudiencePinpointer.RecordInstallEvent();
            goto label_4;
            label_2:
            com.adjust.sdk.Adjust.trackEvent(adjustEvent:  new com.adjust.sdk.AdjustEvent(eventToken:  "tbll7h"));
            Firebase.Analytics.FirebaseAnalytics.LogEvent(name:  "second_session");
            label_4:
            DeltaDNA.AudiencePinpointer.RecordSessionEvent();
        }
        public void SendFirstDaySpendEvent(int newSpending)
        {
            com.adjust.sdk.AdjustEvent val_4;
            var val_5;
            val_4 = newSpending;
            if(this.shouldCheckForSpendingEvent == false)
            {
                    return;
            }
            
            int val_1 = UnityEngine.PlayerPrefs.GetInt(key:  "Spending");
            if((val_1 & 2147483648) != 0)
            {
                    return;
            }
            
            val_5 = val_1 + val_4;
            if(val_5 >= 3600)
            {
                    com.adjust.sdk.AdjustEvent val_2 = null;
                val_4 = val_2;
                val_2 = new com.adjust.sdk.AdjustEvent(eventToken:  "km1d20");
                com.adjust.sdk.Adjust.trackEvent(adjustEvent:  val_2);
                Firebase.Analytics.FirebaseAnalytics.LogEvent(name:  "day_1_spending_3600");
                val_5 = 0;
            }
            
            UnityEngine.PlayerPrefs.SetInt(key:  "Spending", value:  0);
        }
    
    }

}
