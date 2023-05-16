using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Madness
{
    public abstract class MadnessInfoDialog : UiDialog, ICounter
    {
        // Fields
        private const float TotalLeftBarSize = 4.594419;
        private const float ProgressBarMaxThreshold = 0.89;
        private const float ProgressBarMinThreshold = 0.06;
        public UnityEngine.SpriteRenderer leftProgressBar;
        public UnityEngine.SpriteRenderer rightProgressBar;
        public TMPro.TextMeshPro buttonText;
        public TMPro.TextMeshPro barText;
        public TMPro.TextMeshPro remainingText;
        public TMPro.TextMeshPro infoText;
        public Royal.Scenes.Home.Ui.Dialogs.Madness.MadnessBar.MadnessBarRewardView rewardIcon;
        public Royal.Infrastructure.Utils.Time.CountdownAnimation countdownAnimation;
        public UnityEngine.Transform center;
        private Royal.Player.Context.Units.MadnessManager madnessManager;
        private bool timerTextFinished;
        private readonly UnityEngine.Vector3 longRemainingTextPosition;
        
        // Methods
        public void Init(Royal.Infrastructure.Services.Backend.Protocol.MadnessEventType madnessEventType)
        {
            float val_24;
            var val_25;
            this.buttonText.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  ((Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).HasAutoActionInTheFlow) != true) ? "Continue" : "Play");
            this.madnessManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.MadnessManager>(id:  10);
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isArabic != false)
            {
                    this.infoText.isRightToLeftText = false;
            }
            
            this.infoText.text = System.String.Format(format:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  ((madnessEventType & 255) == 3) ? "BookofTreasureInfo" : "PropellerMadnessInfo"), arg0:  this.madnessManager.GetCurrentTarget());
            this.rewardIcon.SetupForInfoDialog(madnessStep:  this.madnessManager.GetCurrentStep());
            this.barText.text = System.String.Format(format:  "{0}/{1}", arg0:  UnityEngine.Mathf.Min(a:  this.madnessManager.GetCount(), b:  this.madnessManager.GetCurrentTarget()), arg1:  this.madnessManager.GetCurrentTarget());
            val_24 = (float)this.madnessManager.GetCount() / (float)this.madnessManager.GetCurrentTarget();
            if((val_24 < 0) && (this.madnessManager.GetCount() >= 1))
            {
                    float val_22 = (float)this.madnessManager.GetCount();
                val_22 = val_22 / (float)this.madnessManager.GetCurrentTarget();
                val_22 = val_22 * 0.83f;
                val_24 = val_22 + 0.06f;
            }
            
            this.UpdateBarSize(ratio:  val_24);
            this.UpdateSeconds();
            val_25 = null;
            val_25 = null;
            Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_this_arg.AddCounter(counter:  this, toBeginning:  false);
        }
        protected abstract void LoadMadnessBundle(); // 0
        protected abstract void UnloadMadnessBundle(); // 0
        protected abstract Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleType GetBundleType(); // 0
        public void UpdateSeconds()
        {
            if(this.timerTextFinished != false)
            {
                    this = ???;
            }
            else
            {
                    if((val_11 + 112.RemainingTimeInMs) < 1000)
            {
                    val_11 + 72.alignment = 2;
                string val_2 = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Finished");
                this = 1;
            }
            else
            {
                    string val_3 = Royal.Infrastructure.Utils.Time.TimeUtil.GetRemainingTimeInFormatWithHours(totalSeconds:  18446744073709551);
                if(((val_11 + 72.Chars[2]) & 65535) == (':'))
            {
                    val_11 + 72.alignment = 1;
            }
            else
            {
                    this.SetTextPosition();
            }
            
            }
            
                val_11 + 96.Rotate();
            }
        
        }
        private void SetTextPosition()
        {
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isJapanese != true)
            {
                    if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isKorean == false)
            {
                    return;
            }
            
            }
            
            this.remainingText.transform.localPosition = new UnityEngine.Vector3() {x = this.longRemainingTextPosition};
        }
        public void ContinueClicked()
        {
            Royal.Scenes.Start.Context.Units.Flow.FlowManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
            if(val_1.HasAutoActionInTheFlow != true)
            {
                    val_1.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.Prelevel.ShowPrelevelDialogAction(clearBoosterSelectionData:  true));
            }
        
        }
        private void UpdateBarSize(float ratio)
        {
            if(ratio > 0f)
            {
                    float val_13 = UnityEngine.Mathf.Min(a:  1f, b:  ratio);
                this.leftProgressBar.gameObject.SetActive(value:  true);
                val_13 = val_13 * 4.594419f;
                UnityEngine.Vector2 val_3 = this.leftProgressBar.size;
                UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  val_13, y:  val_3.y);
                this.leftProgressBar.size = new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
                UnityEngine.Vector3 val_7 = this.rightProgressBar.transform.localPosition;
                float val_14 = 0.2f;
                val_14 = val_13 + val_14;
                UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  val_14, y:  val_7.y);
                UnityEngine.Vector3 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y});
                this.rightProgressBar.transform.localPosition = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
                UnityEngine.Vector2 val_11 = this.rightProgressBar.size;
                this.rightProgressBar.gameObject.SetActive(value:  (val_13 > val_11.x) ? 1 : 0);
                return;
            }
            
            this.DisableBarSprites();
        }
        private void DisableBarSprites()
        {
            this.leftProgressBar.gameObject.SetActive(value:  false);
            this.rightProgressBar.gameObject.SetActive(value:  false);
        }
        public override void OnClose(System.Action dialogClosed)
        {
            null = null;
            Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_this_arg.RemoveCounter(counter:  this);
            this.OnClose(dialogClosed:  dialogClosed);
        }
        private void OnDestroy()
        {
            goto typeof(Royal.Scenes.Home.Ui.Dialogs.Madness.MadnessInfoDialog).__il2cppRuntimeField_2F0;
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
        protected MadnessInfoDialog()
        {
            this.longRemainingTextPosition = 0;
            mem[1152921519347312228] = 0;
        }
    
    }

}
