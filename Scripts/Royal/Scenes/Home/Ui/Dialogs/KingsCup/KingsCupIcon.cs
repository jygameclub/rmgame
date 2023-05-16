using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.KingsCup
{
    public class KingsCupIcon : AIconView
    {
        // Fields
        public UnityEngine.GameObject icon;
        public TMPro.TextMeshPro rankText;
        public TMPro.TextMeshPro remainingText;
        public UnityEngine.Transform trophy;
        public UnityEngine.Transform trophyShine;
        public UnityEngine.GameObject notificationSign;
        private int rank;
        private bool finished;
        private bool isActive;
        private bool kingsCupInfoCalled;
        private Royal.Player.Context.Units.KingsCupManager kingsCupManager;
        private bool shouldShowAutoDialogWhenActivated;
        private Royal.Infrastructure.Utils.Text.CurvedSingleText curvedSingleText;
        
        // Methods
        public override void Init()
        {
            this.kingsCupManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.KingsCupManager>(id:  7);
            this.curvedSingleText = this.remainingText.GetComponent<Royal.Infrastructure.Utils.Text.CurvedSingleText>();
            bool val_3 = this.SetNotificationState();
        }
        public override bool IsVisible()
        {
            return (bool)this.isActive;
        }
        public void OnClick()
        {
            var val_8;
            var val_9;
            Royal.Scenes.Start.Context.Units.Flow.FlowAction val_10;
            val_8 = this;
            Royal.Scenes.Start.Context.Units.Flow.FlowManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
            if(this.kingsCupManager.IsInAGroup == false)
            {
                goto label_4;
            }
            
            if(this.finished != false)
            {
                    if(UnityEngine.Application.internetReachability == 0)
            {
                goto label_6;
            }
            
            }
            
            Royal.Scenes.Home.Ui.Dialogs.KingsCup.ShowKingsCupPopupAction val_4 = null;
            val_9 = val_4;
            val_4 = new Royal.Scenes.Home.Ui.Dialogs.KingsCup.ShowKingsCupPopupAction(isUserAction:  true, isForClaim:  false, type:  3);
            if(val_1 != null)
            {
                goto label_7;
            }
            
            throw new NullReferenceException();
            label_4:
            bool val_5 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetInt(key:  "KingsCupShowed", value:  1);
            bool val_6 = val_4.SetNotificationState();
            Royal.Scenes.Home.Ui.Dialogs.KingsCup.ShowKingsCupInfoDialogAction val_7 = null;
            val_10 = val_7;
            val_7 = new Royal.Scenes.Home.Ui.Dialogs.KingsCup.ShowKingsCupInfoDialogAction(userAction:  true);
            label_7:
            val_1.Push(action:  val_7);
            return;
            label_6:
            Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.ShowConnectionProblem();
        }
        public bool UpdateIcon()
        {
            var val_14;
            Royal.Player.Context.Units.KingsCupManager val_15;
            TMPro.TextMeshPro val_16;
            int val_17;
            bool val_18;
            if(this.kingsCupManager.ShouldShowIcon == false)
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
            if(this.shouldShowAutoDialogWhenActivated != false)
            {
                    bool val_2 = this.kingsCupManager.TryAddAutoDialog(origin:  "icon", isWin:  false);
            }
            
            this.isActive = true;
            val_14 = 1;
            this.icon.SetActive(value:  true);
            label_4:
            val_15 = this.kingsCupManager;
            if(this.rank == this.kingsCupManager.rank)
            {
                goto label_12;
            }
            
            val_16 = this.rankText;
            this.rank = this.kingsCupManager.rank;
            if(this.kingsCupManager.rank <= 0)
            {
                goto label_13;
            }
            
            val_17 = this.rank.ToString();
            if(val_16 != null)
            {
                goto label_14;
            }
            
            label_5:
            val_14 = 0;
            label_7:
            if(this.shouldShowAutoDialogWhenActivated == true)
            {
                    return (bool)val_14;
            }
            
            this.shouldShowAutoDialogWhenActivated = true;
            return (bool)val_14;
            label_13:
            val_17 = System.String.alignConst;
            label_14:
            val_16.text = val_17;
            val_15 = this.kingsCupManager;
            label_12:
            if((this.kingsCupManager.<JustClaimed>k__BackingField) == true)
            {
                    return (bool)val_14;
            }
            
            if(this.finished != false)
            {
                    if(val_15.IsRemainingTimeFinished == true)
            {
                goto label_23;
            }
            
            }
            
            val_16 = this.remainingText.text;
            if(this.kingsCupManager.RemainingTimeInMs < 1000)
            {
                    this.remainingText.alignment = 2;
                this.remainingText.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Finished");
                val_18 = 1;
                this.finished = true;
            }
            else
            {
                    this.remainingText.text = Royal.Infrastructure.Utils.Time.TimeUtil.GetRemainingTimeInFormatWithHours(totalSeconds:  18446744073709551);
                char val_11 = this.remainingText.text.Chars[2] & 65535;
                this.remainingText.alignment = (val_11 != (':')) ? (513 + 1) : 513;
                val_18 = (val_11 == (':')) ? 1 : 0;
            }
            
            this.ArrangeCurveText(isCurved:  val_18, previousText:  val_16);
            if(this.finished == false)
            {
                    return (bool)val_14;
            }
            
            label_23:
            this.TrySendKingsCupCommandIfNotPaused();
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
        private void TrySendKingsCupCommandIfNotPaused()
        {
            if((Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).IsMainFlowPaused()) != false)
            {
                    return;
            }
            
            this.TrySendKingsCupInfoCommand(container:  0);
        }
        public void TrySendEventEndRequest(Royal.Infrastructure.Services.Backend.Http.Command.Commands container)
        {
            if(this.kingsCupManager.ShouldShowIcon == false)
            {
                    return;
            }
            
            if(this.kingsCupManager.RemainingTimeInMs <= 999)
            {
                    this.finished = true;
            }
            else
            {
                    if(this.finished == false)
            {
                    return;
            }
            
            }
            
            this.TrySendKingsCupInfoCommand(container:  container);
        }
        public void HandleEventEndRequestFailed()
        {
            this.kingsCupInfoCalled = false;
        }
        private void TrySendKingsCupInfoCommand(Royal.Infrastructure.Services.Backend.Http.Command.Commands container)
        {
            if(this.kingsCupInfoCalled != false)
            {
                    return;
            }
            
            if(UnityEngine.Application.internetReachability == 0)
            {
                    return;
            }
            
            if((Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetInt(key:  "KingsCupShowed", defaultValue:  0)) == 3)
            {
                    return;
            }
            
            this.kingsCupInfoCalled = true;
            if(container != null)
            {
                    container.Add(httpCommand:  new Royal.Infrastructure.Services.Backend.Http.Command.KingsCup.GetKingsCupInfoHttpCommand());
                return;
            }
            
            this.SendKingsCupInfoCommand();
        }
        private void SendKingsCupInfoCommand()
        {
            this.DelayAutoActionsWhileWaitingResponse(wait:  true);
            bool val_4 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.BackendHttpService>(id:  7).Send(httpCommand:  new Royal.Infrastructure.Services.Backend.Http.Command.KingsCup.GetKingsCupInfoHttpCommand(), onComplete:  new Commands.ConnectionComplete(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupIcon::KingsCupInfoReceived(bool isSuccess, Royal.Infrastructure.Services.Backend.Http.Command.Commands commands)), syncRequired:  false);
        }
        private void KingsCupInfoReceived(bool isSuccess, Royal.Infrastructure.Services.Backend.Http.Command.Commands commands)
        {
            this.DelayAutoActionsWhileWaitingResponse(wait:  false);
            if(this == 0)
            {
                    return;
            }
            
            this.Invoke(methodName:  "StartDelayedActions", time:  0.1f);
            if(isSuccess != false)
            {
                    if(this.kingsCupManager.IsRemainingTimeFinished != false)
            {
                    this.AddKingsCupListPopupToFlow();
                return;
            }
            
                this.finished = false;
            }
            
            this.kingsCupInfoCalled = false;
        }
        private void AddKingsCupListPopupToFlow()
        {
            UnityEngine.Object val_6;
            Royal.Infrastructure.Contexts.Units.CameraManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            val_6 = val_1.camera.GetComponentInChildren<Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupListPopup>();
            object[] val_4 = new object[1];
            long val_5 = this.kingsCupManager.RemainingTimeInMs;
            if(val_6 != 0)
            {
                    val_4[0] = val_5;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  4, log:  "KingsCupInfoReceived - Refresh  existing popup - remainingTime: {0}", values:  val_4);
                val_6.RefreshByIcon();
                return;
            }
            
            val_6 = val_5;
            val_4[0] = val_6;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  4, log:  "KingsCupInfoReceived - Auto queued claim popup - remainingTime: {0}", values:  val_4);
        }
        public bool SetNotificationState()
        {
            var val_3;
            if(((Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetInt(key:  "KingsCupShowed", defaultValue:  0)) == 0) && ((Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetInt(key:  "KingsCupStartDialogShowCount", defaultValue:  0)) >= 10))
            {
                    val_3 = 1;
                this.notificationSign.SetActive(value:  true);
                return (bool)val_3;
            }
            
            this.notificationSign.SetActive(value:  false);
            val_3 = 0;
            return (bool)val_3;
        }
        public KingsCupIcon()
        {
        
        }
    
    }

}
