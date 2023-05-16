using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.TeamBattle
{
    public class TeamBattleIcon : AIconView
    {
        // Fields
        public UnityEngine.GameObject icon;
        public TMPro.TextMeshPro rankText;
        public TMPro.TextMeshPro remainingText;
        public UnityEngine.GameObject shield;
        public UnityEngine.Transform emptyShield;
        public UnityEngine.Transform emptyShieldShine;
        private int rank;
        private bool finished;
        private bool isActive;
        private bool teamBattleInfoCalled;
        private Royal.Player.Context.Units.TeamBattleManager teamBattleManager;
        private bool shouldShowAutoDialogWhenActivated;
        private Royal.Infrastructure.Utils.Text.CurvedSingleText curvedSingleText;
        
        // Methods
        public override void Init()
        {
            this.teamBattleManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.TeamBattleManager>(id:  9);
            this.curvedSingleText = this.remainingText.GetComponent<Royal.Infrastructure.Utils.Text.CurvedSingleText>();
        }
        public override bool IsVisible()
        {
            return (bool)this.isActive;
        }
        public void OnClick()
        {
            Royal.Scenes.Start.Context.Units.Flow.FlowAction val_6;
            Royal.Scenes.Start.Context.Units.Flow.FlowManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
            if(this.teamBattleManager.IsInAGroup == false)
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
            
            Royal.Scenes.Home.Ui.Dialogs.TeamBattle.ShowTeamBattlePopupAction val_4 = null;
            val_6 = val_4;
            val_4 = new Royal.Scenes.Home.Ui.Dialogs.TeamBattle.ShowTeamBattlePopupAction();
            .isUserAction = true;
            .<Type>k__BackingField = 2;
            .<IsForClaim>k__BackingField = false;
            if(val_1 != null)
            {
                goto label_8;
            }
            
            label_4:
            Royal.Scenes.Home.Ui.Dialogs.TeamBattle.ShowTeamBattleInfoDialogAction val_5 = null;
            val_6 = val_5;
            val_5 = new Royal.Scenes.Home.Ui.Dialogs.TeamBattle.ShowTeamBattleInfoDialogAction();
            .userAction = true;
            .<OriginType>k__BackingField = 0;
            .<Type>k__BackingField = 2;
            label_8:
            val_1.Push(action:  val_5);
            return;
            label_6:
            Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.ShowConnectionProblem();
        }
        public bool UpdateIcon()
        {
            var val_16;
            string val_17;
            Royal.Player.Context.Units.TeamBattleManager val_18;
            bool val_19;
            if(this.teamBattleManager.ShouldShowIcon == false)
            {
                goto label_2;
            }
            
            if(this.isActive == false)
            {
                goto label_3;
            }
            
            val_16 = 0;
            goto label_4;
            label_2:
            if(this.isActive == false)
            {
                goto label_5;
            }
            
            this.isActive = false;
            this.icon.SetActive(value:  false);
            val_16 = 1;
            goto label_7;
            label_3:
            if(this.shouldShowAutoDialogWhenActivated != false)
            {
                    bool val_2 = this.teamBattleManager.TryAddAutoDialog(origin:  "icon", isWin:  false);
            }
            
            this.isActive = true;
            val_16 = 1;
            this.icon.SetActive(value:  true);
            label_4:
            val_17 = this;
            val_18 = this.teamBattleManager;
            if(this.rank == this.teamBattleManager.rank)
            {
                goto label_20;
            }
            
            if(this.rank == 0)
            {
                    this.shield.SetActive(value:  false);
                this.emptyShieldShine.gameObject.SetActive(value:  true);
                val_18 = this.teamBattleManager;
            }
            
            this.rank = this.teamBattleManager.rank;
            if(this.teamBattleManager.rank == 0)
            {
                goto label_18;
            }
            
            this.rankText.text = this.rank.ToString();
            goto label_20;
            label_5:
            val_16 = 0;
            label_7:
            if(this.shouldShowAutoDialogWhenActivated == true)
            {
                    return (bool)val_16;
            }
            
            this.shouldShowAutoDialogWhenActivated = true;
            return (bool)val_16;
            label_18:
            this.rankText.text = System.String.alignConst;
            this.shield.SetActive(value:  true);
            this.emptyShieldShine.gameObject.SetActive(value:  false);
            label_20:
            if((this.teamBattleManager.<JustClaimed>k__BackingField) == true)
            {
                    return (bool)val_16;
            }
            
            if(this.finished != false)
            {
                    if(this.teamBattleManager.IsRemainingTimeFinished == true)
            {
                goto label_30;
            }
            
            }
            
            val_17 = this.remainingText.text;
            if(this.teamBattleManager.RemainingTimeInMs < 1000)
            {
                    this.remainingText.alignment = 2;
                this.remainingText.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Finished");
                val_19 = 1;
                this.finished = true;
            }
            else
            {
                    this.remainingText.text = Royal.Infrastructure.Utils.Time.TimeUtil.GetRemainingTimeInFormatWithHours(totalSeconds:  18446744073709551);
                char val_13 = this.remainingText.text.Chars[2] & 65535;
                this.remainingText.alignment = (val_13 != (':')) ? (513 + 1) : 513;
                val_19 = (val_13 == (':')) ? 1 : 0;
            }
            
            this.ArrangeCurveText(isCurved:  val_19, previousText:  val_17);
            if(this.finished == false)
            {
                    return (bool)val_16;
            }
            
            label_30:
            this.TrySendTeamBattleCommandIfNotPaused();
            return (bool)val_16;
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
        private void TrySendTeamBattleCommandIfNotPaused()
        {
            if((Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).IsMainFlowPaused()) != false)
            {
                    return;
            }
            
            this.TrySendTeamBattleInfoCommand(container:  0);
        }
        public void TrySendEventEndRequest(Royal.Infrastructure.Services.Backend.Http.Command.Commands container)
        {
            if(this.teamBattleManager.ShouldShowIcon == false)
            {
                    return;
            }
            
            if(this.teamBattleManager.RemainingTimeInMs <= 999)
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
            
            this.TrySendTeamBattleInfoCommand(container:  container);
        }
        public void HandleEventEndRequestFailed()
        {
            this.teamBattleInfoCalled = false;
        }
        private void TrySendTeamBattleInfoCommand(Royal.Infrastructure.Services.Backend.Http.Command.Commands container)
        {
            if(this.teamBattleInfoCalled != false)
            {
                    return;
            }
            
            if(UnityEngine.Application.internetReachability == 0)
            {
                    return;
            }
            
            if((Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetInt(key:  "TeamBattleShowed", defaultValue:  0)) == 3)
            {
                    return;
            }
            
            this.teamBattleInfoCalled = true;
            if(container != null)
            {
                    container.Add(httpCommand:  new Royal.Infrastructure.Services.Backend.Http.Command.TeamBattle.GetTeamBattleInfoHttpCommand());
                return;
            }
            
            this.SendTeamBattleInfoCommand();
        }
        private void SendTeamBattleInfoCommand()
        {
            this.DelayAutoActionsWhileWaitingResponse(wait:  true);
            bool val_4 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.BackendHttpService>(id:  7).Send(httpCommand:  new Royal.Infrastructure.Services.Backend.Http.Command.TeamBattle.GetTeamBattleInfoHttpCommand(), onComplete:  new Commands.ConnectionComplete(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattleIcon::TeamBattleInfoReceived(bool isSuccess, Royal.Infrastructure.Services.Backend.Http.Command.Commands commands)), syncRequired:  false);
        }
        private void TeamBattleInfoReceived(bool isSuccess, Royal.Infrastructure.Services.Backend.Http.Command.Commands commands)
        {
            this.DelayAutoActionsWhileWaitingResponse(wait:  false);
            if(this == 0)
            {
                    return;
            }
            
            this.Invoke(methodName:  "StartDelayedActions", time:  0.1f);
            if(isSuccess != false)
            {
                    if(this.teamBattleManager.IsRemainingTimeFinished != false)
            {
                    this.AddTeamBattleListPopupToFlow();
                return;
            }
            
                this.finished = false;
            }
            
            this.teamBattleInfoCalled = false;
        }
        private void AddTeamBattleListPopupToFlow()
        {
            Royal.Infrastructure.Contexts.Units.CameraManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattleListPopup val_2 = val_1.camera.GetComponentInChildren<Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattleListPopup>();
            object[] val_4 = new object[1];
            long val_5 = this.teamBattleManager.RemainingTimeInMs;
            if(val_2 != 0)
            {
                    val_4[0] = val_5;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  4, log:  "TeamBattleInfoReceived - Refresh  existing popup - remainingTime: {0}", values:  val_4);
                val_2.PrepareMembers(animate:  false, canClaim:  true, sendCommandIfEmpty:  false);
                return;
            }
            
            val_4[0] = val_5;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  4, log:  "TeamBattleInfoReceived - Auto queued claim popup - remainingTime: {0}", values:  val_4);
        }
        public TeamBattleIcon()
        {
        
        }
    
    }

}
