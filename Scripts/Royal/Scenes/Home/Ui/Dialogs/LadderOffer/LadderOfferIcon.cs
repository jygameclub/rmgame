using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.LadderOffer
{
    public class LadderOfferIcon : AIconView
    {
        // Fields
        public UnityEngine.GameObject icon;
        public TMPro.TextMeshPro remainingText;
        public UnityEngine.GameObject notificationSign;
        private int rank;
        private bool finished;
        private bool isActive;
        private bool ladderOfferInfoCalled;
        private Royal.Player.Context.Units.LadderOfferManager ladderOfferManager;
        private bool shouldShowAutoDialogWhenActivated;
        private Royal.Infrastructure.Utils.Text.CurvedSingleText curvedSingleText;
        private readonly Royal.Scenes.Home.Ui.Sections.Shop.PurchaseStrategy purchaseStrategy;
        private Royal.Scenes.Start.Context.Units.Flow.FlowManager flowManager;
        
        // Methods
        public override void Init()
        {
            this.flowManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
            this.ladderOfferManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LadderOfferManager>(id:  11);
            this.curvedSingleText = this.remainingText.GetComponent<Royal.Infrastructure.Utils.Text.CurvedSingleText>();
            this.SetNotificationState();
        }
        public override bool IsVisible()
        {
            return (bool)this.isActive;
        }
        public void OnClick()
        {
            bool val_1 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetInt(key:  "LadderOfferAutoDialogState", value:  1);
            System.DateTime val_2 = System.DateTime.Today;
            bool val_3 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetLong(key:  "LadderOfferAutoDialogLastSeenDate", value:  null);
            this.SetNotificationState();
            .<Type>k__BackingField = 0;
            .enableTouches = false;
            this.flowManager.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.LadderOffer.Actions.ShowLadderOfferPopupViewAction());
        }
        public bool UpdateIcon()
        {
            var val_14;
            string val_15;
            var val_16;
            bool val_17;
            if(this.ladderOfferManager.ShouldShowIcon == false)
            {
                goto label_2;
            }
            
            if(this.isActive == false)
            {
                goto label_3;
            }
            
            val_14 = 0;
            goto label_4;
            label_2:
            if(this.isActive == false)
            {
                goto label_5;
            }
            
            this.isActive = false;
            this.icon.SetActive(value:  false);
            val_14 = 1;
            goto label_7;
            label_3:
            if(this.shouldShowAutoDialogWhenActivated == false)
            {
                goto label_17;
            }
            
            if(this.flowManager.HasAutoActionInTheFlow == false)
            {
                goto label_10;
            }
            
            val_15 = public static T[] System.Array::Empty<System.Object>();
            val_16 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_16 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_16 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_16 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  27, log:  "Can\'t show ladder offer auto dialog.", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            goto label_17;
            label_5:
            val_14 = 0;
            label_7:
            if(this.shouldShowAutoDialogWhenActivated == true)
            {
                    return (bool)val_14;
            }
            
            this.shouldShowAutoDialogWhenActivated = true;
            return (bool)val_14;
            label_10:
            bool val_3 = this.ladderOfferManager.TryAddAutoDialog(origin:  "icon", isWin:  false);
            label_17:
            this.isActive = true;
            val_14 = 1;
            this.icon.SetActive(value:  true);
            this.SetNotificationState();
            label_4:
            if(this.finished != false)
            {
                    if(this.ladderOfferManager.IsRemainingTimeFinished == true)
            {
                    return (bool)val_14;
            }
            
            }
            
            val_15 = this.remainingText.text;
            if(this.ladderOfferManager.RemainingTimeInMs < 1000)
            {
                    this.remainingText.alignment = 2;
                this.remainingText.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Finished");
                val_17 = 1;
                this.finished = true;
            }
            else
            {
                    this.remainingText.text = Royal.Infrastructure.Utils.Time.TimeUtil.GetRemainingTimeInFormatWithHours(totalSeconds:  18446744073709551);
                char val_11 = this.remainingText.text.Chars[2] & 65535;
                this.remainingText.alignment = (val_11 != (':')) ? (513 + 1) : 513;
                val_17 = (val_11 == (':')) ? 1 : 0;
            }
            
            this.ArrangeCurveText(isCurved:  val_17, previousText:  val_15);
            return (bool)val_14;
        }
        private void ArrangeCurveText(bool isCurved, string previousText)
        {
            if((System.String.op_Equality(a:  this.remainingText.text, b:  previousText)) != false)
            {
                    return;
            }
            
            this.curvedSingleText = (isCurved != true) ? 0.03f : 0f;
            this.curvedSingleText.ForceUpdate();
        }
        public void SetNotificationState()
        {
            var val_2;
            if((Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetInt(key:  "LadderOfferAutoDialogState", defaultValue:  0)) != 0)
            {
                    val_2 = 0;
            }
            else
            {
                    val_2 = 1;
            }
            
            this.notificationSign.SetActive(value:  true);
        }
        public LadderOfferIcon()
        {
        
        }
    
    }

}
