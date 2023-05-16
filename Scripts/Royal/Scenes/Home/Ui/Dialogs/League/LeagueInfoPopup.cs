using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.League
{
    public class LeagueInfoPopup : UiPopup, IBackable, ICounter, ICanOpenTeamInfoPopupOnTop
    {
        // Fields
        public UnityEngine.GameObject header;
        public UnityEngine.SpriteRenderer mainBackground;
        public UnityEngine.BoxCollider2D mainBackgroundBoxCollider2D;
        public UnityEngine.SpriteRenderer headerContainer;
        public TMPro.TextMeshPro remainingText;
        public Royal.Infrastructure.Utils.Time.CountdownAnimation countdownAnimation;
        public Royal.Scenes.Home.Ui.Dialogs.League.LeagueMemberListScroll memberListScroll;
        public UnityEngine.GameObject timerMode;
        public UnityEngine.GameObject claimMode;
        public TMPro.TextMeshPro rankText;
        public TMPro.TextMeshPro rewardText;
        public UnityEngine.GameObject coinsReward;
        public UnityEngine.GameObject hammerReward;
        public UnityEngine.Transform claimPanel;
        public TMPro.TextMeshPro claimButtonText;
        public Royal.Infrastructure.UiComponents.UiSpinner spinner;
        public UnityEngine.Transform myBottomRow;
        private bool timerTextFinished;
        private Royal.Infrastructure.Contexts.Units.CameraManager camManager;
        private Royal.Player.Context.Units.LeagueManager leagueManager;
        private Royal.Infrastructure.UiComponents.Touch.UiTouchListener uiTouchListener;
        private bool claimClicked;
        
        // Methods
        public void Show(bool isUserAction)
        {
            var val_28;
            var val_29;
            var val_30;
            this.camManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            this.leagueManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LeagueManager>(id:  5);
            this.uiTouchListener = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            object[] val_5 = new object[2];
            val_5[0] = isUserAction;
            val_5[1] = this.leagueManager.RemainingTimeInMs;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  4, log:  "LeagueInfoPopup - isUserAction: {0} - remainingTime: {1}", values:  val_5);
            UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  this.camManager.cameraWidth, y:  this.camManager.cameraHeight);
            this.mainBackgroundBoxCollider2D.size = new UnityEngine.Vector2() {x = val_7.x, y = val_7.y};
            UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  this.camManager.cameraWidth, y:  this.camManager.cameraHeight);
            this.mainBackground.size = new UnityEngine.Vector2() {x = val_8.x, y = val_8.y};
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.down;
            UnityEngine.Vector2 val_10 = this.mainBackground.size;
            val_10.y = val_10.y * 0.5f;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, d:  val_10.y + (-0.9f));
            this.myBottomRow.localPosition = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
            this.PrepareHeader();
            UnityEngine.Vector3 val_14 = this.header.transform.position;
            float val_28 = val_14.y;
            UnityEngine.Vector2 val_15 = this.headerContainer.size;
            float val_27 = val_15.y;
            UnityEngine.Vector3 val_16 = this.camManager.GetBottomCenterOfCamera();
            val_27 = (val_28 - val_27) + (-1f);
            val_28 = val_27 - val_16.y;
            UnityEngine.Vector2 val_18 = new UnityEngine.Vector2(x:  this.camManager.cameraWidth, y:  val_28);
            this.memberListScroll.boxCollider.size = new UnityEngine.Vector2() {x = val_18.x, y = val_18.y};
            float val_29 = -0.5f;
            val_29 = val_28 * val_29;
            UnityEngine.Vector2 val_21 = new UnityEngine.Vector2(x:  0f, y:  val_27 + val_29);
            UnityEngine.Vector3 val_22 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_21.x, y = val_21.y});
            this.memberListScroll.transform.localPosition = new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z};
            this.timerMode.SetActive(value:  true);
            this.claimMode.SetActive(value:  false);
            this.claimPanel.gameObject.SetActive(value:  false);
            val_28 = null;
            val_28 = null;
            Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_this_arg.AddCounter(counter:  this, toBeginning:  false);
            this.UpdateTimeAndRank();
            bool val_24 = this.leagueManager.IsRemainingTimeFinished;
            Royal.Infrastructure.Services.Backend.Http.TimeHelper val_25 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.TimeHelper>(id:  14);
            if(isUserAction == false)
            {
                goto label_49;
            }
            
            if((val_25.<IsTimeValidatedByBackend>k__BackingField) == false)
            {
                goto label_52;
            }
            
            if(val_24 != true)
            {
                    if(UnityEngine.Application.internetReachability == 0)
            {
                goto label_52;
            }
            
            }
            
            this.SendLeagueInfoCommand();
            return;
            label_49:
            val_29 = val_24;
            val_30 = 1;
            goto label_54;
            label_52:
            val_30 = 1;
            val_29 = 0;
            label_54:
            this.PrepareMembers(animate:  true, canClaim:  false);
        }
        private void SendLeagueInfoCommand()
        {
            this.spinner.Show();
            Royal.Infrastructure.Services.Backend.Http.Command.Commands val_2 = new Royal.Infrastructure.Services.Backend.Http.Command.Commands();
            val_2.Add(httpCommand:  new Royal.Infrastructure.Services.Backend.Http.Command.League.GetLeagueInfoHttpCommand());
            val_2.add_OnComplete(value:  new Commands.ConnectionComplete(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.League.LeagueInfoPopup::LeagueInfoReceived(bool isSuccess, Royal.Infrastructure.Services.Backend.Http.Command.Commands commands)));
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.BackendHttpService>(id:  7).SendImmediately(commandsToSend:  val_2, timeOut:  10f);
        }
        private void LeagueInfoReceived(bool isSuccess, Royal.Infrastructure.Services.Backend.Http.Command.Commands commands)
        {
            Royal.Infrastructure.UiComponents.UiSpinner val_8 = this.spinner;
            if(val_8 == 0)
            {
                    return;
            }
            
            this.spinner.Hide();
            bool val_2 = this.leagueManager.IsRemainingTimeFinished;
            bool val_3 = val_2;
            this.timerTextFinished = val_3;
            val_8 = val_2;
            object[] val_4 = new object[2];
            val_4[0] = val_3;
            val_4[1] = this.leagueManager.RemainingTimeInMs;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  4, log:  "LeagueInfoReceived: isFinished:{0} - remainingTime:{1}", values:  val_4);
            if((val_8 & (~isSuccess)) != false)
            {
                    Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.ShowConnectionProblem();
                this.Close();
                return;
            }
            
            this.PrepareMembers(animate:  true, canClaim:  val_8);
        }
        private void PrepareMembers(bool animate, bool canClaim)
        {
            TMPro.TextMeshPro val_9 = this;
            this.memberListScroll.PrepareContent(isLeagueFinished:  canClaim);
            if(animate != false)
            {
                    this.memberListScroll.AnimateMembers();
            }
            
            if(canClaim == false)
            {
                    return;
            }
            
            if(this.claimMode.activeSelf != true)
            {
                    this.claimMode.SetActive(value:  true);
                this.timerMode.SetActive(value:  false);
                this.Invoke(methodName:  "ShowClaimPanel", time:  0.45f);
            }
            
            this.rankText.text = this.leagueManager.rank.ToString();
            if(this.leagueManager.rank <= this.leagueManager.rewards.amounts.Length)
            {
                goto label_14;
            }
            
            this.coinsReward.SetActive(value:  true);
            this.hammerReward.SetActive(value:  false);
            this.rewardText.text = "-";
            val_9 = this.claimButtonText;
            string val_4 = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Continue");
            if(val_9 != null)
            {
                goto label_18;
            }
            
            label_14:
            this.coinsReward.SetActive(value:  (this.leagueManager.rank < 4) ? 1 : 0);
            this.hammerReward.SetActive(value:  (this.leagueManager.rank > 3) ? 1 : 0);
            this.claimButtonText.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Claim");
            int val_9 = this.leagueManager.rank;
            val_9 = val_9 - 1;
            val_9 = this.rewardText;
            label_18:
            val_9.text = this.leagueManager.rewards.amounts[val_9][32].ToString();
        }
        private void PrepareHeader()
        {
            UnityEngine.Vector3 val_3 = this.transform.position;
            UnityEngine.Vector3 val_4 = this.camManager.GetSafeTopCenterOfCamera();
            val_4.y = val_4.y + (-1f);
            this.header.transform.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        public void UpdateSeconds()
        {
            this.UpdateTimeAndRank();
        }
        private void UpdateTimeAndRank()
        {
            if(this.timerTextFinished != false)
            {
                    return;
            }
            
            if(this.leagueManager.RemainingTimeInMs < 1000)
            {
                    this.remainingText.alignment = 2;
                this.remainingText.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Finished");
                this.timerTextFinished = true;
            }
            else
            {
                    this.remainingText.text = Royal.Infrastructure.Utils.Time.TimeUtil.GetRemainingTimeInFormatWithHours(totalSeconds:  18446744073709551);
                if((this.remainingText.text.Chars[2] & 65535) == (':'))
            {
                    this.remainingText.alignment = 1;
            }
            
            }
            
            this.countdownAnimation.Rotate();
        }
        public void Claim()
        {
            if(this.claimClicked != false)
            {
                    return;
            }
            
            this.claimClicked = true;
            this.SendClaimHttpCommand();
        }
        private void SendClaimHttpCommand()
        {
            this.spinner.Show();
            Royal.Infrastructure.Services.Backend.Http.Command.Commands val_2 = new Royal.Infrastructure.Services.Backend.Http.Command.Commands();
            val_2.Add(httpCommand:  new Royal.Infrastructure.Services.Backend.Http.Command.League.ClaimLeagueHttpCommand());
            .<SyncRequired>k__BackingField = true;
            val_2.add_OnComplete(value:  new Commands.ConnectionComplete(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.League.LeagueInfoPopup::ClaimLeagueResponseReceived(bool isSuccess, Royal.Infrastructure.Services.Backend.Http.Command.Commands container)));
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.BackendHttpService>(id:  7).SendImmediately(commandsToSend:  val_2, timeOut:  10f);
        }
        private void ClaimLeagueResponseReceived(bool isSuccess, Royal.Infrastructure.Services.Backend.Http.Command.Commands container)
        {
            var val_5;
            var val_6;
            val_5 = isSuccess;
            if(this.spinner == 0)
            {
                    return;
            }
            
            this.claimClicked = false;
            this.spinner.Hide();
            if(val_5 == false)
            {
                goto label_5;
            }
            
            Royal.Infrastructure.Services.Backend.Http.Command.BaseHttpCommand val_2 = container.FindCommandByType(responseType:  21);
            if(64 != 1)
            {
                goto label_10;
            }
            
            label_5:
            Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.ShowConnectionProblem();
            return;
            label_10:
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LevelManager>(id:  2).ResourcesLoad();
            val_6 = null;
            val_6 = null;
            Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_this_arg.PrepareLevelButton();
            Royal.Scenes.Home.Context.HomeContext.Get<Royal.Scenes.Home.Context.Units.Area.AreaManager>(id:  0).RefreshArea();
            Royal.Scenes.Home.Ui.Dialogs.League.LeagueInfoPopup.PlayRewardAnimation(coins:  1907483456, hammers:  1907483456);
            this.Close();
        }
        private static void PlayRewardAnimation(int coins, int hammers)
        {
            var val_5;
            var val_6;
            Royal.Scenes.Start.Context.Units.Flow.FlowAction val_7;
            if(coins < 1)
            {
                goto label_1;
            }
            
            Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg.AddCoin(coins:  coins);
            val_5 = null;
            val_5 = null;
            Royal.Scenes.Home.Ui.__il2cppRuntimeField_30.PrepareCoinTextForAnimation();
            val_6 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
            Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.CoinCollect.PlayCoinCollectAnimationAction val_2 = null;
            val_7 = val_2;
            val_2 = new Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.CoinCollect.PlayCoinCollectAnimationAction(type:  1, forceDisableTouch:  false);
            if(val_6 != null)
            {
                goto label_17;
            }
            
            label_1:
            if(hammers < 1)
            {
                    return;
            }
            
            Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg.AddBooster(booster:  4, count:  hammers);
            val_6 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
            Royal.Scenes.Home.Ui.Sections.Home.RewardedItem.PlayRewardedItemAnimationAction val_4 = null;
            val_7 = val_4;
            val_4 = new Royal.Scenes.Home.Ui.Sections.Home.RewardedItem.PlayRewardedItemAnimationAction(type:  1, forceDisableTouch:  false, singleItemAnimationTime:  1.1f);
            label_17:
            val_6.Push(action:  val_4);
        }
        public void Close()
        {
            null = null;
            Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_this_arg.RemoveCounter(counter:  this);
            this.Destroy();
        }
        public void PressBack()
        {
            if(this.timerMode.activeSelf == false)
            {
                    return;
            }
            
            this.Close();
        }
        public void RefreshByButton()
        {
            this.PrepareMembers(animate:  false, canClaim:  true);
        }
        private void ShowClaimPanel()
        {
            this.claimPanel.gameObject.SetActive(value:  true);
            UnityEngine.Vector3 val_2 = this.camManager.GetSafeBottomCenterOfCamera();
            float val_3 = val_2.y + (-0.63f);
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(d:  4f, a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 0f, y = val_3, z = 0.3f}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            this.claimPanel.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            DG.Tweening.Sequence val_7 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(d:  0.4f, a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 0f, y = val_3, z = 0.3f}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_7, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.claimPanel, endValue:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, duration:  0.2f, snapping:  false), ease:  3));
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Multiply(d:  0.1f, a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 0f, y = val_3, z = 0.3f}, b:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
            DG.Tweening.Sequence val_19 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_7, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.claimPanel, endValue:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, duration:  0.13f, snapping:  false), ease:  3));
            DG.Tweening.Sequence val_22 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_7, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.claimPanel, endValue:  new UnityEngine.Vector3() {x = 0f, y = val_3, z = 0.3f}, duration:  0.08f, snapping:  false), ease:  3));
        }
        public LeagueInfoPopup()
        {
        
        }
    
    }

}
