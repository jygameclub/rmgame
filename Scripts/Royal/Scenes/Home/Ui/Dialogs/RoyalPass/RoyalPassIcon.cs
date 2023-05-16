using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass
{
    public class RoyalPassIcon : AIconView
    {
        // Fields
        public UnityEngine.GameObject icon;
        public TMPro.TextMeshPro remainingText;
        public UnityEngine.GameObject notificationSign;
        public Royal.Infrastructure.UiComponents.Button.UiButton royalPassButton;
        public UnityEngine.UI.Image progressImage;
        public UnityEngine.Transform progressOffset;
        private bool isActive;
        private bool finished;
        private bool shouldShowAutoDialogWhenActivated;
        private Royal.Player.Context.Units.RoyalPassManager royalPassManager;
        private Royal.Infrastructure.Utils.Text.CurvedSingleText curvedSingleText;
        private Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassIconViewState currentNotificationState;
        private Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassIconViewState nextNotificationState;
        private bool shouldTryClaim;
        private int eventId;
        private const float BarFullFrames = 60;
        private const float ProgressFirstThresholdStart = 0.069;
        private const float ProgressFirstThresholdEnd = 0.35;
        private const float ProgressSecondThresholdStart = 0.583;
        private const float ProgressSecondThresholdEnd = 0.74;
        private const float FirstThresholdDif = 0.281;
        private const float SecondThresholdDif = 0.157;
        private const float ThresholdRatio = 0.5;
        private System.Action OnRoyalPassIconClick;
        
        // Methods
        private void Awake()
        {
            this.royalPassManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.RoyalPassManager>(id:  12);
            this.curvedSingleText = this.remainingText.GetComponent<Royal.Infrastructure.Utils.Text.CurvedSingleText>();
            this.SetNotificationState(forceUpdate:  true);
            this.eventId = this.royalPassManager.<EventId>k__BackingField;
        }
        public override void Init()
        {
            this.TryFixStepAndCount();
            this.SetProgressValues(current:  this.royalPassManager.GetProgressBarStartValue(royalPassData:  Royal.Player.Context.Data.Session.__il2cppRuntimeField_70 + 64), target:  this.royalPassManager.GetTargetForProgressBar());
        }
        private void TryFixStepAndCount()
        {
            var val_5;
            int val_6;
            if(this.royalPassManager.IsLastStep() == true)
            {
                    return;
            }
            
            val_5 = 0;
            var val_5 = 3;
            val_6 = this.royalPassManager.GetTargetForProgressBar();
            int val_3 = UnityEngine.Mathf.Max(a:  val_6, b:  1);
            val_6 = this.royalPassManager;
            val_6.UpdateStep(newStep:  1);
            val_5 = val_5 - 1;
            val_5 = 1;
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.UserManager>(id:  1).SendDataToBackend(forceToSend:  false, forceScoreData:  false);
        }
        public void SetProgressValues(int current, int target)
        {
            if(current < target)
            {
                    float val_2 = (float)current;
                val_2 = val_2 / (float)target;
                float val_1 = this.GetThresholdedRatio(ratio:  val_2);
            }
            
            this.UpdateProgressSize(ratio:  1f);
        }
        private void UpdateProgressSize(float ratio)
        {
            this.progressImage.fillAmount = ratio;
            if(ratio > 0f)
            {
                    this.progressOffset.gameObject.SetActive(value:  true);
                UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.Euler(x:  0f, y:  0f, z:  (UnityEngine.Mathf.Min(a:  ratio, b:  1f)) * (-360f));
                this.progressOffset.localRotation = new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w};
                return;
            }
            
            this.progressOffset.gameObject.SetActive(value:  false);
        }
        private float GetThresholdedRatio(float ratio)
        {
            if(ratio <= 0f)
            {
                    return (float)val_1;
            }
            
            float val_1 = UnityEngine.Mathf.Min(a:  ratio, b:  1f);
            if(val_1 > 0.5f)
            {
                    val_1 = val_1 + (-0.5f);
                val_1 = val_1 * 0.157f;
                val_1 = val_1 + val_1;
                val_1 = val_1 + 0.583f;
                return (float)val_1;
            }
            
            val_1 = val_1 * 0.281f;
            val_1 = val_1 + val_1;
            val_1 = val_1 + 0.069f;
            return (float)val_1;
        }
        public void AnimateProgress(int start, int end, int target, System.Action onComplete)
        {
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.ProgressCoroutine(start:  start, end:  UnityEngine.Mathf.Min(a:  end, b:  target), target:  target, onComplete:  onComplete));
        }
        private System.Collections.IEnumerator ProgressCoroutine(int start, int end, int target, System.Action onComplete)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .target = target;
            .end = end;
            .start = start;
            .onComplete = onComplete;
            return (System.Collections.IEnumerator)new RoyalPassIcon.<ProgressCoroutine>d__30();
        }
        private void SetNotificationState(bool forceUpdate = False)
        {
            var val_3;
            bool val_1 = this.royalPassManager.IsThereAnyUnclaimedAvailableRewards();
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassIconViewState val_2 = (val_1 != true) ? 3 : 0;
            this.nextNotificationState = val_2;
            if(this.currentNotificationState == val_2)
            {
                    if(forceUpdate == false)
            {
                    return;
            }
            
            }
            
            if(val_1 != false)
            {
                    val_3 = 1;
            }
            else
            {
                    val_3 = 0;
            }
            
            this.notificationSign.SetActive(value:  false);
            this.currentNotificationState = this.nextNotificationState;
        }
        public override bool IsVisible()
        {
            return (bool)this.isActive;
        }
        public void OnClick()
        {
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).Push(action:  new Royal.Scenes.Home.Ui.Dialogs.RoyalPass.ShowRoyalPassPopupAction(isUserAction:  true, isAfterPurchase:  false, type:  3));
            if(this.OnRoyalPassIconClick == null)
            {
                    return;
            }
            
            this.OnRoyalPassIconClick.Invoke();
        }
        public void add_OnRoyalPassIconClick(System.Action value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnRoyalPassIconClick, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnRoyalPassIconClick != 1152921519205437584);
            
            return;
            label_2:
        }
        public void remove_OnRoyalPassIconClick(System.Action value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnRoyalPassIconClick, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnRoyalPassIconClick != 1152921519205574160);
            
            return;
            label_2:
        }
        public bool UpdateIcon()
        {
            var val_12;
            bool val_13;
            if(this.royalPassManager.IsIconActive() == false)
            {
                goto label_2;
            }
            
            this.SetNotificationState(forceUpdate:  false);
            if(this.shouldTryClaim != false)
            {
                    this.shouldTryClaim = false;
            }
            
            if(this.isActive == false)
            {
                goto label_5;
            }
            
            val_12 = 0;
            goto label_6;
            label_2:
            if(this.isActive == false)
            {
                goto label_7;
            }
            
            this.isActive = false;
            this.icon.SetActive(value:  false);
            val_12 = 1;
            goto label_9;
            label_5:
            this.isActive = true;
            val_12 = 1;
            this.icon.SetActive(value:  true);
            label_6:
            if(this.shouldShowAutoDialogWhenActivated == false)
            {
                goto label_11;
            }
            
            if(this.royalPassManager != null)
            {
                goto label_12;
            }
            
            label_7:
            val_12 = 0;
            label_9:
            if(this.shouldShowAutoDialogWhenActivated == true)
            {
                    return (bool)val_12;
            }
            
            this.shouldShowAutoDialogWhenActivated = true;
            return (bool)val_12;
            label_11:
            if(this.eventId == (this.royalPassManager.<EventId>k__BackingField))
            {
                goto label_17;
            }
            
            label_12:
            this.shouldShowAutoDialogWhenActivated = false;
            this.eventId = this.royalPassManager.<EventId>k__BackingField;
            label_17:
            if(this.finished != false)
            {
                    if(this.royalPassManager.IsRemainingTimeFinished == true)
            {
                    return (bool)val_12;
            }
            
            }
            
            if(this.royalPassManager.RemainingTimeInMs < 1000)
            {
                    this.remainingText.alignment = 2;
                this.remainingText.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Finished");
                val_13 = 1;
                this.finished = true;
                this.shouldTryClaim = true;
            }
            else
            {
                    this.remainingText.text = Royal.Infrastructure.Utils.Time.TimeUtil.GetRemainingTimeInFormatWithHours(totalSeconds:  18446744073709551);
                char val_9 = this.remainingText.text.Chars[2] & 65535;
                this.remainingText.alignment = (val_9 != (':')) ? (513 + 1) : 513;
                val_13 = (val_9 == (':')) ? 1 : 0;
            }
            
            this.ArrangeCurvedText(isCurved:  val_13, previousText:  this.remainingText.text);
            return (bool)val_12;
        }
        private void ArrangeCurvedText(bool isCurved, string previousText)
        {
            if((System.String.op_Equality(a:  this.remainingText.text, b:  previousText)) != false)
            {
                    return;
            }
            
            this.curvedSingleText = (isCurved != true) ? 0.03f : 0f;
            this.curvedSingleText.ForceUpdate();
        }
        public RoyalPassIcon()
        {
        
        }
    
    }

}
