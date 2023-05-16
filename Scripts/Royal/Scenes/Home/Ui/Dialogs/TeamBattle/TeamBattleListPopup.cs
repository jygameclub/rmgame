using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.TeamBattle
{
    public class TeamBattleListPopup : UiPopup, IBackable, ICounter, ICanOpenTeamInfoPopupOnTop
    {
        // Fields
        private const int BattleState = 1;
        private const int MyTeamState = 2;
        private const int ContributionBoosterCount = 2;
        public UnityEngine.TextAsset teamListAsset;
        public UnityEngine.SpriteRenderer teamListImage;
        public UnityEngine.GameObject header;
        public UnityEngine.SpriteRenderer mainBackground;
        public UnityEngine.BoxCollider2D mainBackgroundBoxCollider2D;
        public UnityEngine.SpriteRenderer tabsBackground;
        public TMPro.TextMeshPro remainingText;
        public Royal.Infrastructure.Utils.Time.CountdownAnimation countdownAnimation;
        public Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattleTeamListScroll teamTeamListScroll;
        public Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattlePlayerListScroll myTeamListScroll;
        public UnityEngine.GameObject timerMode;
        public UnityEngine.GameObject claimMode;
        public TMPro.TextMeshPro rankText;
        public TMPro.TextMeshPro rewardText;
        public TMPro.TextMeshPro coinRewardText;
        public UnityEngine.SpriteRenderer coinRewardSprite;
        public UnityEngine.SpriteRenderer coinRewardExtraSprite;
        public UnityEngine.SpriteRenderer coinRewardReflectionSprite;
        public UnityEngine.GameObject coinRewardGo;
        public UnityEngine.Transform claimPanel;
        public TMPro.TextMeshPro claimButtonText;
        public Royal.Infrastructure.UiComponents.UiSpinner spinner;
        public UnityEngine.Transform myBottomRow;
        public UnityEngine.Transform myTeamBottomRow;
        public UnityEngine.GameObject infoButton;
        public Royal.Infrastructure.UiComponents.Button.UiSelectButton battleButton;
        public Royal.Infrastructure.UiComponents.Button.UiSelectButton myTeamButton;
        private bool timerTextFinished;
        private Royal.Infrastructure.Contexts.Units.CameraManager camManager;
        private Royal.Infrastructure.UiComponents.Touch.UiTouchListener uiTouchListener;
        private Royal.Player.Context.Units.TeamBattleManager teamBattleManager;
        private bool claimClicked;
        private int currentState;
        
        // Methods
        protected void Awake()
        {
            this.teamListImage.sprite = Royal.Infrastructure.Utils.Sprite.SpriteExtensions.ToSprite(textAsset:  this.teamListAsset, width:  120, height:  28, format:  4);
        }
        public void Show(bool isUserAction)
        {
            var val_36;
            var val_37;
            var val_38;
            var val_39;
            this.camManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            this.teamBattleManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.TeamBattleManager>(id:  9);
            this.uiTouchListener = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            object[] val_5 = new object[2];
            val_5[0] = isUserAction;
            val_5[1] = this.teamBattleManager.RemainingTimeInMs;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  4, log:  "TeamBattleListPopup - isUserAction: {0} - remainingTime: {1}", values:  val_5);
            UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  this.camManager.cameraWidth, y:  this.camManager.cameraHeight);
            this.mainBackgroundBoxCollider2D.size = new UnityEngine.Vector2() {x = val_7.x, y = val_7.y};
            UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  this.camManager.cameraWidth, y:  this.camManager.cameraHeight);
            this.mainBackground.size = new UnityEngine.Vector2() {x = val_8.x, y = val_8.y};
            this.PrepareHeader();
            UnityEngine.Vector3 val_10 = this.tabsBackground.transform.position;
            float val_36 = val_10.y;
            UnityEngine.Vector2 val_11 = this.tabsBackground.size;
            float val_35 = val_11.y;
            UnityEngine.Vector3 val_12 = this.camManager.GetBottomCenterOfCamera();
            float val_13 = val_35 * (-0.5f);
            val_13 = val_36 + val_13;
            val_35 = val_13 + (-0.1f);
            val_36 = val_35 - val_12.y;
            UnityEngine.Vector2 val_14 = new UnityEngine.Vector2(x:  this.camManager.cameraWidth, y:  val_36);
            this.teamTeamListScroll.boxCollider.size = new UnityEngine.Vector2() {x = val_14.x, y = val_14.y};
            val_35 = val_35 + (val_36 * (-0.5f));
            UnityEngine.Vector2 val_17 = new UnityEngine.Vector2(x:  0f, y:  val_35);
            UnityEngine.Vector3 val_18 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_17.x, y = val_17.y});
            this.teamTeamListScroll.transform.localPosition = new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z};
            UnityEngine.Vector2 val_19 = new UnityEngine.Vector2(x:  this.camManager.cameraWidth, y:  val_36);
            this.myTeamListScroll.boxCollider.size = new UnityEngine.Vector2() {x = val_19.x, y = val_19.y};
            UnityEngine.Vector2 val_21 = new UnityEngine.Vector2(x:  0f, y:  val_35);
            UnityEngine.Vector3 val_22 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_21.x, y = val_21.y});
            this.myTeamListScroll.transform.localPosition = new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z};
            UnityEngine.Vector3 val_24 = this.mainBackground.transform.position;
            UnityEngine.Vector3 val_25 = UnityEngine.Vector3.down;
            UnityEngine.Vector2 val_26 = this.mainBackground.size;
            val_26.y = val_26.y * 0.5f;
            UnityEngine.Vector3 val_28 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z}, d:  val_26.y + (-0.9f));
            UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z}, b:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z});
            this.myBottomRow.position = new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z};
            UnityEngine.Vector3 val_30 = this.myBottomRow.position;
            this.myTeamBottomRow.position = new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z};
            this.timerMode.SetActive(value:  true);
            this.claimMode.SetActive(value:  false);
            this.claimPanel.gameObject.SetActive(value:  false);
            val_36 = null;
            val_36 = null;
            Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_this_arg.AddCounter(counter:  this, toBeginning:  false);
            this.UpdateTimeAndRank();
            bool val_32 = this.teamBattleManager.IsRemainingTimeFinished;
            Royal.Infrastructure.Services.Backend.Http.TimeHelper val_33 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.TimeHelper>(id:  14);
            if(isUserAction == false)
            {
                goto label_58;
            }
            
            if(((this.teamBattleManager.<JustClaimed>k__BackingField) == true) || ((val_33.<IsTimeValidatedByBackend>k__BackingField) == false))
            {
                goto label_62;
            }
            
            if(val_32 != true)
            {
                    if(UnityEngine.Application.internetReachability == 0)
            {
                goto label_62;
            }
            
            }
            
            this.SendTeamBattleInfoCommand();
            goto label_63;
            label_58:
            val_37 = val_32;
            val_38 = 1;
            val_39 = 1;
            goto label_64;
            label_62:
            val_38 = 1;
            val_37 = 0;
            val_39 = 0;
            label_64:
            this.PrepareMembers(animate:  true, canClaim:  false, sendCommandIfEmpty:  false);
            label_63:
            this.currentState = 1;
            this.ArrangeViewsByState();
        }
        public void SelectBattle()
        {
            this.currentState = 1;
            this.ArrangeViewsByState();
        }
        public void SelectMyTeam()
        {
            this.currentState = 2;
            this.ArrangeViewsByState();
        }
        private void ArrangeViewsByState()
        {
            this.battleButton.Select(select:  (this.currentState == 1) ? 1 : 0);
            this.myTeamButton.Select(select:  (this.currentState == 2) ? 1 : 0);
            this.teamTeamListScroll.Enable(enable:  (this.currentState == 1) ? 1 : 0);
            this.myTeamListScroll.Enable(enable:  (this.currentState == 2) ? 1 : 0);
        }
        public void InfoButtonClicked()
        {
            .userAction = true;
            .<OriginType>k__BackingField = 5;
            .<Type>k__BackingField = 2;
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).Push(action:  new Royal.Scenes.Home.Ui.Dialogs.TeamBattle.ShowTeamBattleInfoDialogAction());
            this.Close();
        }
        public void CloseButtonClicked()
        {
            this.Close();
        }
        private void SendTeamBattleInfoCommand()
        {
            this.spinner.Show();
            Royal.Infrastructure.Services.Backend.Http.Command.Commands val_2 = new Royal.Infrastructure.Services.Backend.Http.Command.Commands();
            val_2.Add(httpCommand:  new Royal.Infrastructure.Services.Backend.Http.Command.TeamBattle.GetTeamBattleInfoHttpCommand());
            val_2.add_OnComplete(value:  new Commands.ConnectionComplete(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattleListPopup::TeamBattleInfoReceived(bool isSuccess, Royal.Infrastructure.Services.Backend.Http.Command.Commands commands)));
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.BackendHttpService>(id:  7).SendImmediately(commandsToSend:  val_2, timeOut:  10f);
        }
        private void TeamBattleInfoReceived(bool isSuccess, Royal.Infrastructure.Services.Backend.Http.Command.Commands commands)
        {
            Royal.Infrastructure.UiComponents.UiSpinner val_7 = this.spinner;
            if(val_7 == 0)
            {
                    return;
            }
            
            this.spinner.Hide();
            val_7 = this.teamBattleManager.IsRemainingTimeFinished;
            this.timerTextFinished = val_7;
            object[] val_4 = new object[3];
            val_4[0] = isSuccess;
            val_4[1] = val_7;
            val_4[2] = this.teamBattleManager.RemainingTimeInMs;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  25, log:  "TeamBattleInfoReceived: isSuccess{0} - isFinished:{1} - remainingTime:{2}", values:  val_4);
            if((val_7 != false) && (isSuccess != true))
            {
                    Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.ShowConnectionProblem();
                this.Close();
                return;
            }
            
            this.PrepareMembers(animate:  true, canClaim:  val_7, sendCommandIfEmpty:  false);
        }
        private void PrepareMembers(bool animate, bool canClaim, bool sendCommandIfEmpty = False)
        {
            var val_15;
            object val_16;
            TMPro.TextMeshPro val_17;
            var val_18;
            string val_19;
            val_15 = sendCommandIfEmpty;
            val_16 = this;
            bool val_1 = canClaim;
            int val_2 = this.teamTeamListScroll.PrepareContent(isBattleFinished:  val_1);
            val_17 = this.myTeamListScroll.PrepareContent(isBattleFinished:  val_1);
            if((val_2 == 0) || (val_17 == 0))
            {
                goto label_4;
            }
            
            this.teamTeamListScroll.AnimateMembers(animate:  animate);
            if(canClaim == false)
            {
                    return;
            }
            
            if(this.claimMode.activeSelf != true)
            {
                    this.infoButton.SetActive(value:  false);
                this.claimMode.SetActive(value:  true);
                this.timerMode.SetActive(value:  false);
                this.Invoke(methodName:  "ShowClaimPanel", time:  0.45f);
            }
            
            this.rankText.text = "#" + this.teamBattleManager.rank.ToString();
            if((this.teamBattleManager.rank > 5) || (this.teamBattleManager.myScore < 1))
            {
                goto label_16;
            }
            
            val_18 = null;
            val_18 = null;
            System.Int32[] val_16 = Royal.Player.Context.Units.TeamBattleManager.Rewards;
            int val_15 = this.teamBattleManager.rank;
            val_15 = val_15 - 1;
            val_16 = val_16 + (val_15 << 2);
            this.coinRewardGo.SetActive(value:  true);
            this.coinRewardExtraSprite.enabled = (this.teamBattleManager.rank == 1) ? 1 : 0;
            int val_17 = this.teamBattleManager.rank;
            val_17 = val_17 - 1;
            this.coinRewardSprite.sprite = this.teamTeamListScroll.coinSprites[val_17];
            int val_19 = this.teamBattleManager.rank;
            val_19 = val_19 - 1;
            this.coinRewardReflectionSprite.sprite = UnityEngine.Resources.Load<UnityEngine.Sprite>(path:  "coin_reflection_" + val_19);
            val_17 = this.claimButtonText;
            val_17.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Claim");
            this.coinRewardText.text = ToString();
            val_19 = "";
            goto label_31;
            label_4:
            if(val_15 != false)
            {
                    this.SendTeamBattleInfoCommand();
                return;
            }
            
            object[] val_13 = new object[2];
            val_15 = 1152921504619413504;
            val_13[0] = val_2;
            val_17 = val_17;
            val_13[1] = val_17;
            Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  25, log:  "Closing team battle list popup - teamCount: {0} - memberCount:{1}", values:  val_13);
            Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.ShowConnectionProblem();
            this.Close();
            return;
            label_16:
            this.coinRewardGo.SetActive(value:  false);
            this.rewardText.text = "-";
            val_16 = this.claimButtonText;
            val_19 = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Continue");
            label_31:
            val_16.text = val_19;
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
            
            if(this.teamBattleManager.RemainingTimeInMs < 1000)
            {
                    this.remainingText.alignment = 2;
                this.remainingText.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Finished");
                this.timerTextFinished = true;
                this.infoButton.SetActive(value:  false);
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
            val_2.Add(httpCommand:  new Royal.Infrastructure.Services.Backend.Http.Command.TeamBattle.ClaimTeamBattleHttpCommand(groupId:  this.teamBattleManager.groupId));
            .<SyncRequired>k__BackingField = true;
            val_2.add_OnComplete(value:  new Commands.ConnectionComplete(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattleListPopup::ClaimTeamBattleResponseReceived(bool isSuccess, Royal.Infrastructure.Services.Backend.Http.Command.Commands container)));
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.BackendHttpService>(id:  7).SendImmediately(commandsToSend:  val_2, timeOut:  10f);
        }
        private void ClaimTeamBattleResponseReceived(bool isSuccess, Royal.Infrastructure.Services.Backend.Http.Command.Commands container)
        {
            if(this.spinner == 0)
            {
                    return;
            }
            
            this.claimClicked = false;
            if(isSuccess == false)
            {
                goto label_4;
            }
            
            Royal.Infrastructure.Services.Backend.Http.Command.BaseHttpCommand val_2 = container.FindCommandByType(responseType:  25);
            if(224 != 1)
            {
                goto label_9;
            }
            
            label_4:
            Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.ShowConnectionProblem();
            return;
            label_9:
            this.PlayRewardAnimation(teamRank:  1676781536, myRankInList:  this.teamBattleManager.GetMyRank(), myScore:  this.teamBattleManager.myScore);
            this.Close();
        }
        private void PlayRewardAnimation(int teamRank, int myRankInList, int myScore)
        {
            UnityEngine.Transform val_14;
            int val_15;
            var val_16;
            var val_17;
            var val_18;
            val_15 = teamRank;
            if(myScore < 1)
            {
                    return;
            }
            
            Royal.Scenes.Start.Context.Units.Flow.FlowManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
            val_16 = null;
            val_16 = null;
            if(Royal.Player.Context.Units.TeamBattleManager.Rewards.Length >= val_15)
            {
                    this.coinRewardGo.transform.SetParent(parent:  0, worldPositionStays:  true);
                val_14 = this.coinRewardGo.transform;
                .reward = val_14;
                .rewardAmount = val_15;
                val_1.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattleCoinRewardClaimAction());
                val_17 = null;
                val_17 = null;
                System.Int32[] val_14 = Royal.Player.Context.Units.TeamBattleManager.Rewards;
                val_14 = val_14 + ((val_15 - 1) << 2);
                Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg.AddCoin(coins:  (Royal.Player.Context.Units.TeamBattleManager.Rewards + ((teamRank - 1)) << 2) + 32);
                val_18 = null;
                val_18 = null;
                Royal.Scenes.Home.Ui.__il2cppRuntimeField_30.PrepareCoinTextForAnimation();
                val_1.Push(action:  new Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.CoinCollect.PlayCoinCollectAnimationAction(type:  0, forceDisableTouch:  (myRankInList < 4) ? 1 : 0));
            }
            
            if(myRankInList > 3)
            {
                    return;
            }
            
            val_1.Push(action:  new Royal.Scenes.Start.Context.Units.Flow.IntervalAction(duration:  0.85f, disableUiTouch:  true, flowType:  0));
            int val_9 = myRankInList - 1;
            var val_15 = 4;
            val_15 = val_15 - myRankInList;
            .boosterType = (val_9 < 3) ? (val_15) : 0;
            .amount = 2;
            val_1.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattleContributionClaimAction());
            var val_16 = 4;
            val_16 = val_16 - myRankInList;
            Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg.AddBooster(booster:  (val_9 < 3) ? (val_16) : 0, count:  2);
            val_1.Push(action:  new Royal.Scenes.Home.Ui.Sections.Home.RewardedItem.PlayRewardedItemAnimationAction(type:  0, forceDisableTouch:  false, singleItemAnimationTime:  1.1f));
        }
        private Royal.Scenes.Game.Mechanics.Boosters.BoosterType GetBoosterByRank(int myRankInTeam)
        {
            if((myRankInTeam - 1) > 2)
            {
                    return 0;
            }
            
            return (Royal.Scenes.Game.Mechanics.Boosters.BoosterType)4 - myRankInTeam;
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
        public void RefreshByIcon()
        {
            this.PrepareMembers(animate:  false, canClaim:  true, sendCommandIfEmpty:  false);
        }
        public TeamBattleListPopup()
        {
        
        }
    
    }

}
