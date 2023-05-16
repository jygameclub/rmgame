using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Home.Buttons
{
    public class LeagueInfoButton : AIconView
    {
        // Fields
        public TMPro.TextMeshPro rankText;
        public TMPro.TextMeshPro remainingText;
        public Royal.Infrastructure.Utils.Time.CountdownAnimation countdownAnimation;
        public UnityEngine.Transform crownTransform;
        public UnityEngine.Transform notification;
        public TMPro.TextMeshPro notificationText;
        private int rank;
        private bool finished;
        private bool leagueInfoCalled;
        private Royal.Player.Context.Units.LeagueManager leagueManager;
        private bool isActive;
        private UnityEngine.Vector3 originalCrownScale;
        
        // Methods
        private void Awake()
        {
            UnityEngine.Vector3 val_2 = this.crownTransform.transform.localScale;
            this.originalCrownScale = val_2;
            mem[1152921519143447392] = val_2.y;
            mem[1152921519143447396] = val_2.z;
        }
        public override bool IsVisible()
        {
            return this.gameObject.activeSelf;
        }
        public void Activate(bool enable)
        {
            var val_7;
            if(enable != false)
            {
                    this.rank = 0;
                this.finished = false;
                this.leagueInfoCalled = false;
                this.leagueManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LeagueManager>(id:  5);
                this.gameObject.SetActive(value:  true);
                val_7 = this;
                this.isActive = true;
                this.notification.gameObject.SetActive(value:  (~(Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetBool(key:  "LeagueButtonClicked", defaultValue:  false))) & 1);
            }
            else
            {
                    val_7 = this;
                this.isActive = false;
                this.gameObject.SetActive(value:  false);
                this.remainingText.text = System.String.alignConst;
                this.leagueManager = 0;
            }
            
            if(this.isActive == false)
            {
                    return;
            }
            
            this.UpdateTexts();
        }
        public void UpdateIcon()
        {
            if(this.isActive == false)
            {
                    return;
            }
            
            this.UpdateTexts();
        }
        private void UpdateTexts()
        {
            if(this.rank != this.leagueManager.rank)
            {
                    this.rank = this.leagueManager.rank;
                this.rankText.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Rank")(Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Rank")) + ": <size=5>"(": <size=5>") + this.rank;
            }
            
            if(this.finished != false)
            {
                    this.TrySendLeagueCommandIfNotPaused();
                return;
            }
            
            if(this.leagueManager.RemainingTimeInMs >= 1000)
            {
                goto label_7;
            }
            
            this.remainingText.alignment = 2;
            this.remainingText.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Finished");
            this.finished = true;
            goto label_10;
            label_7:
            this.remainingText.text = Royal.Infrastructure.Utils.Time.TimeUtil.GetRemainingTimeInFormatWithHours(totalSeconds:  18446744073709551);
            this.remainingText.alignment = ((this.remainingText.text.Chars[2] & 65535) != (':')) ? (513 + 1) : 513;
            if(this.finished == false)
            {
                goto label_16;
            }
            
            label_10:
            this.TrySendLeagueCommandIfNotPaused();
            label_16:
            this.countdownAnimation.Rotate();
        }
        private void TrySendLeagueCommandIfNotPaused()
        {
            if((Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).IsMainFlowPaused()) != false)
            {
                    return;
            }
            
            this.TrySendLeagueInfoCommand(container:  0);
        }
        public void TrySendEventEndRequest(Royal.Infrastructure.Services.Backend.Http.Command.Commands container)
        {
            if(this.isActive == false)
            {
                    return;
            }
            
            Royal.Player.Context.Units.LeagueManager val_1 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LeagueManager>(id:  5);
            this.leagueManager = val_1;
            if(val_1.RemainingTimeInMs <= 999)
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
            
            this.TrySendLeagueInfoCommand(container:  container);
        }
        private void TrySendLeagueInfoCommand(Royal.Infrastructure.Services.Backend.Http.Command.Commands container)
        {
            if(this.leagueInfoCalled != false)
            {
                    return;
            }
            
            if(UnityEngine.Application.internetReachability == 0)
            {
                    return;
            }
            
            if((Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetInt(key:  "LeagueShowed", defaultValue:  0)) == 3)
            {
                    return;
            }
            
            this.leagueInfoCalled = true;
            if(container != null)
            {
                    container.Add(httpCommand:  new Royal.Infrastructure.Services.Backend.Http.Command.League.GetLeagueInfoHttpCommand());
                return;
            }
            
            this.SendLeagueInfoCommand();
        }
        public void HandleEventEndRequestFailed()
        {
            this.leagueInfoCalled = false;
        }
        public void OnClickButton()
        {
            if(this.finished != false)
            {
                    if(UnityEngine.Application.internetReachability == 0)
            {
                goto label_2;
            }
            
            }
            
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).Push(action:  new Royal.Scenes.Home.Ui.Dialogs.League.ShowLeagueInfoPopupAction(isUserAction:  true));
            if((Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetBool(key:  "LeagueButtonClicked", defaultValue:  false)) != true)
            {
                    bool val_5 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetBool(key:  "LeagueButtonClicked", value:  true);
            }
            
            this.HideNotification();
            return;
            label_2:
            Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.ShowConnectionProblem();
        }
        private void SendLeagueInfoCommand()
        {
            this.DelayAutoActionsWhileWaitingResponse(wait:  true);
            bool val_4 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.BackendHttpService>(id:  7).Send(httpCommand:  new Royal.Infrastructure.Services.Backend.Http.Command.League.GetLeagueInfoHttpCommand(), onComplete:  new Commands.ConnectionComplete(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Home.Buttons.LeagueInfoButton::LeagueInfoReceived(bool isSuccess, Royal.Infrastructure.Services.Backend.Http.Command.Commands commands)), syncRequired:  false);
        }
        private void LeagueInfoReceived(bool isSuccess, Royal.Infrastructure.Services.Backend.Http.Command.Commands commands)
        {
            this.DelayAutoActionsWhileWaitingResponse(wait:  false);
            if(this == 0)
            {
                    return;
            }
            
            this.Invoke(methodName:  "StartDelayedActions", time:  0.1f);
            if(isSuccess == false)
            {
                goto label_4;
            }
            
            if(this.leagueManager.IsRemainingTimeFinished == false)
            {
                goto label_6;
            }
            
            this.AddLeagueInfoPopupToFlow();
            return;
            label_4:
            this.leagueInfoCalled = false;
            return;
            label_6:
            this.finished = false;
            this.leagueInfoCalled = false;
        }
        private void AddLeagueInfoPopupToFlow()
        {
            UnityEngine.Object val_6;
            Royal.Infrastructure.Contexts.Units.CameraManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            val_6 = val_1.camera.GetComponentInChildren<Royal.Scenes.Home.Ui.Dialogs.League.LeagueInfoPopup>();
            object[] val_4 = new object[1];
            long val_5 = this.leagueManager.RemainingTimeInMs;
            if(val_6 != 0)
            {
                    val_4[0] = val_5;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  4, log:  "LeagueInfoReceived - Refresh  existing popup - remainingTime: {0}", values:  val_4);
                val_6.RefreshByButton();
                return;
            }
            
            val_6 = val_5;
            val_4[0] = val_6;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  4, log:  "LeagueInfoReceived - Auto queued claim popup - remainingTime: {0}", values:  val_4);
        }
        public void PlayCrownAnimation()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            float val_8 = 0.9f;
            float val_2 = this.originalCrownScale * val_8;
            val_8 = S8 * val_8;
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.crownTransform, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  0.08f));
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.crownTransform, endValue:  new UnityEngine.Vector3() {x = this.originalCrownScale, y = V8.16B, z = V9.16B}, duration:  0.11f));
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenExtensions.Play<DG.Tweening.Sequence>(t:  val_1);
        }
        public void HideNotification()
        {
            this.notification.gameObject.SetActive(value:  false);
        }
        public LeagueInfoButton()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
