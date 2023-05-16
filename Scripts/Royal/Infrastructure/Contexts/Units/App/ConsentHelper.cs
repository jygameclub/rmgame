using UnityEngine;

namespace Royal.Infrastructure.Contexts.Units.App
{
    public class ConsentHelper
    {
        // Fields
        private const byte NotRequired = 0;
        public const byte RequiredNewInstall = 1;
        private const byte RequiredOther = 2;
        public bool requiresConsent;
        private bool reshowConsentOnResume;
        
        // Methods
        public void OnApplicationPause()
        {
            bool val_1 = Royal.Infrastructure.Utils.Native.DeviceHelper.IsAndroid;
            if(val_1 == false)
            {
                    return;
            }
            
            if(this.requiresConsent == false)
            {
                    return;
            }
            
            this.reshowConsentOnResume = true;
            val_1.HideConsent();
        }
        public void OnApplicationResume()
        {
            bool val_1 = Royal.Infrastructure.Utils.Native.DeviceHelper.IsAndroid;
            if(val_1 == false)
            {
                    return;
            }
            
            if(this.reshowConsentOnResume == false)
            {
                    return;
            }
            
            val_1.ShowConsent();
        }
        public System.Collections.IEnumerator WaitForConsent(System.Action onConsentGiven)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .onConsentGiven = onConsentGiven;
            return (System.Collections.IEnumerator)new ConsentHelper.<WaitForConsent>d__7();
        }
        public void InitConsent(bool newInstall)
        {
            this.requiresConsent = true;
            Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.SetInt(key:  "ConsentState", value:  ((newInstall & true) != 0) ? (true + 1) : true).ShowConsent();
        }
        public void GiveConsent(bool isShown = True)
        {
            if(isShown != false)
            {
                    Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Analytics.AnalyticsManager>(id:  17).ConsentGiven();
            }
            
            bool val_2 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.SetInt(key:  "ConsentState", value:  0);
            this.requiresConsent = false;
            this.reshowConsentOnResume = false;
        }
        private void ShowConsent()
        {
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Native.NativeService>(id:  19).ShowConsentMessage();
        }
        private void HideConsent()
        {
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Native.NativeService>(id:  19).HideConsentMessage();
        }
        public void Start(Royal.Infrastructure.Contexts.Units.App.VersionHelper versionHelper)
        {
            .firstStartAfterInstall = (versionHelper.versionState == 1) ? 1 : 0;
            int val_3 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.GetInt(key:  "ConsentState", defaultValue:  0);
            bool val_4 = (val_3 == 1) ? 1 : 0;
            .previousConsentState = val_3;
            val_4 = ((ConsentHelper.<>c__DisplayClass12_0)[1152921528710736160].firstStartAfterInstall) | val_4;
            .newInstall = val_4;
            if((((ConsentHelper.<>c__DisplayClass12_0)[1152921528710736160].firstStartAfterInstall) != true) && (val_3 == 0))
            {
                    Royal.Scenes.Start.Context.ApplicationContextController.OnConsentFinished(newInstall:  val_3);
                return;
            }
            
            this.InitConsent(newInstall:  (val_3 != 2) ? 1 : 0);
            System.Action val_6 = static_value_02DC1B30;
            val_6 = new System.Action(object:  new ConsentHelper.<>c__DisplayClass12_0(), method:  System.Void ConsentHelper.<>c__DisplayClass12_0::<Start>b__0());
            Royal.Scenes.Start.Context.ApplicationContext.ManualStartWaitForConsentCoroutine(onConsentGiven:  val_6);
        }
        public ConsentHelper()
        {
        
        }
    
    }

}
