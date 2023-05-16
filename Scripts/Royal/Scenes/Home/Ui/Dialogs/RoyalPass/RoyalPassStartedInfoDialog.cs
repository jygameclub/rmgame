using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass
{
    public class RoyalPassStartedInfoDialog : UiDialog, ICounter
    {
        // Fields
        public TMPro.TextMeshPro remainingText;
        public Royal.Infrastructure.Utils.Time.CountdownAnimation countdownAnimation;
        public UnityEngine.Transform center;
        public Royal.Infrastructure.Utils.Text.TextProOnAnAnimationCurve titleCurve;
        private Royal.Player.Context.Units.RoyalPassManager royalPassManager;
        private bool timerTextFinished;
        private Royal.Scenes.Start.Context.Units.FeatureBundle.RoyalPassBundle royalPassBundle;
        private UnityEngine.GameObject royalPassStartedBundledGo;
        
        // Methods
        public void Init()
        {
            var val_2;
            this.LoadStartedBundledPrefab();
            this.royalPassManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.RoyalPassManager>(id:  12);
            this.UpdateSeconds();
            val_2 = null;
            val_2 = null;
            Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_this_arg.AddCounter(counter:  this, toBeginning:  false);
            this.royalPassManager.SetNewEventTutorialAsSeen();
            this.ArrangeTitle();
        }
        private void ArrangeTitle()
        {
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isGerman == false)
            {
                    return;
            }
            
            this.titleCurve = 1086324736;
            UnityEngine.Transform val_1 = this.titleCurve.transform;
            UnityEngine.Vector3 val_2 = val_1.localPosition;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  0.15f);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            val_1.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        }
        public void LoadStartedBundledPrefab()
        {
            Royal.Scenes.Start.Context.Units.FeatureBundle.RoyalPassBundle val_6;
            Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleManager>(id:  25);
            if(val_1 == null)
            {
                    throw new NullReferenceException();
            }
            
            Royal.Scenes.Start.Context.Units.FeatureBundle.AFeatureBundle val_2 = val_1.GetBundle(bundleType:  4);
            if(val_2 != null)
            {
                    this.royalPassBundle = val_2;
                val_6 = this.royalPassBundle;
                if(val_6 == null)
            {
                    throw new NullReferenceException();
            }
            
                this.royalPassStartedBundledGo = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_6.RoyalPassStartedBundledPrefab, parent:  this.transform);
                return;
            }
            
            this.royalPassBundle = val_2;
            throw new NullReferenceException();
        }
        public void UpdateSeconds()
        {
            if(this.timerTextFinished != false)
            {
                    this = ???;
            }
            else
            {
                    if((val_11 + 72.RemainingTimeInMs) < 1000)
            {
                    val_11 + 40.alignment = 2;
                string val_2 = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Finished");
                this = 1;
            }
            else
            {
                    string val_3 = Royal.Infrastructure.Utils.Time.TimeUtil.GetRemainingTimeInFormatWithHours(totalSeconds:  18446744073709551);
                if(((val_11 + 40.Chars[2]) & 65535) == (':'))
            {
                    val_11 + 40.alignment = 1;
            }
            
            }
            
                val_11 + 48.Rotate();
            }
        
        }
        public override void OnClose(System.Action dialogClosed)
        {
            null = null;
            Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_this_arg.RemoveCounter(counter:  this);
            this.OnClose(dialogClosed:  dialogClosed);
            this.royalPassBundle = 0;
        }
        public override Royal.Infrastructure.UiComponents.Dialog.DialogConfig GetConfig()
        {
            bool val_2;
            float val_3;
            bool val_4;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_0;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_1 = this.GetConfig();
            val_0.shouldCloseOnEscape = true;
            val_0.shouldCloseOnTouch = true;
            val_0.shouldHideBackground = val_2;
            val_0.backgroundFadeInDuration = val_3;
            val_0.shouldCloseOnSwipe = val_4;
            return val_0;
        }
        public RoyalPassStartedInfoDialog()
        {
        
        }
    
    }

}
