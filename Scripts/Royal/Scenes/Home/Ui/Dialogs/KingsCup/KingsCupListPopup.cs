using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.KingsCup
{
    public class KingsCupListPopup : UiPopup, IBackable, ICounter, ICanOpenTeamInfoPopupOnTop
    {
        // Fields
        public UnityEngine.TextAsset allGiftsAsset;
        public UnityEngine.SpriteRenderer allGifts;
        public UnityEngine.GameObject header;
        public UnityEngine.SpriteRenderer mainBackground;
        public UnityEngine.BoxCollider2D mainBackgroundBoxCollider2D;
        public UnityEngine.SpriteRenderer headerContainer;
        public TMPro.TextMeshPro remainingText;
        public Royal.Infrastructure.Utils.Time.CountdownAnimation countdownAnimation;
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupListScroll memberListScroll;
        public UnityEngine.GameObject timerMode;
        public UnityEngine.GameObject claimMode;
        public TMPro.TextMeshPro rankText;
        public TMPro.TextMeshPro rewardText;
        public UnityEngine.Transform claimPanel;
        public TMPro.TextMeshPro claimButtonText;
        public Royal.Infrastructure.UiComponents.UiSpinner spinner;
        public UnityEngine.Transform myBottomRow;
        public UnityEngine.GameObject[] giftBoxes;
        public UnityEngine.GameObject infoButton;
        private bool timerTextFinished;
        private Royal.Infrastructure.Contexts.Units.CameraManager camManager;
        private Royal.Infrastructure.UiComponents.Touch.UiTouchListener uiTouchListener;
        private Royal.Player.Context.Units.KingsCupManager kingsCupManager;
        private bool claimClicked;
        
        // Methods
        public void Show(bool isUserAction)
        {
            var val_29;
            var val_30;
            var val_31;
            this.allGifts.sprite = Royal.Infrastructure.Utils.Sprite.SpriteExtensions.ToSprite(textAsset:  this.allGiftsAsset, width:  76, height:  77, format:  4);
            this.camManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            this.kingsCupManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.KingsCupManager>(id:  7);
            this.uiTouchListener = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            object[] val_6 = new object[2];
            val_6[0] = isUserAction;
            val_6[1] = this.kingsCupManager.RemainingTimeInMs;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  4, log:  "KingsCupListPopup - isUserAction: {0} - remainingTime: {1}", values:  val_6);
            UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  this.camManager.cameraWidth, y:  this.camManager.cameraHeight);
            this.mainBackgroundBoxCollider2D.size = new UnityEngine.Vector2() {x = val_8.x, y = val_8.y};
            UnityEngine.Vector2 val_9 = new UnityEngine.Vector2(x:  this.camManager.cameraWidth, y:  this.camManager.cameraHeight);
            this.mainBackground.size = new UnityEngine.Vector2() {x = val_9.x, y = val_9.y};
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.down;
            UnityEngine.Vector2 val_11 = this.mainBackground.size;
            val_11.y = val_11.y * 0.5f;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, d:  val_11.y + (-0.9f));
            this.myBottomRow.localPosition = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
            this.PrepareHeader();
            UnityEngine.Vector3 val_15 = this.header.transform.position;
            float val_29 = val_15.y;
            UnityEngine.Vector2 val_16 = this.headerContainer.size;
            float val_28 = val_16.y;
            UnityEngine.Vector3 val_17 = this.camManager.GetBottomCenterOfCamera();
            val_28 = (val_29 - val_28) + (-1f);
            val_29 = val_28 - val_17.y;
            UnityEngine.Vector2 val_19 = new UnityEngine.Vector2(x:  this.camManager.cameraWidth, y:  val_29);
            this.memberListScroll.boxCollider.size = new UnityEngine.Vector2() {x = val_19.x, y = val_19.y};
            float val_30 = -0.5f;
            val_30 = val_29 * val_30;
            UnityEngine.Vector2 val_22 = new UnityEngine.Vector2(x:  0f, y:  val_28 + val_30);
            UnityEngine.Vector3 val_23 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_22.x, y = val_22.y});
            this.memberListScroll.transform.localPosition = new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z};
            this.timerMode.SetActive(value:  true);
            this.claimMode.SetActive(value:  false);
            this.claimPanel.gameObject.SetActive(value:  false);
            val_29 = null;
            val_29 = null;
            Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_this_arg.AddCounter(counter:  this, toBeginning:  false);
            this.UpdateTimeAndRank();
            bool val_25 = this.kingsCupManager.IsRemainingTimeFinished;
            Royal.Infrastructure.Services.Backend.Http.TimeHelper val_26 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.TimeHelper>(id:  14);
            if(isUserAction == false)
            {
                goto label_51;
            }
            
            if(((this.kingsCupManager.<JustClaimed>k__BackingField) == true) || ((val_26.<IsTimeValidatedByBackend>k__BackingField) == false))
            {
                goto label_55;
            }
            
            if(val_25 != true)
            {
                    if(UnityEngine.Application.internetReachability == 0)
            {
                goto label_55;
            }
            
            }
            
            this.SendKingsCupInfoCommand();
            return;
            label_51:
            val_30 = val_25;
            val_31 = 1;
            goto label_57;
            label_55:
            val_31 = 1;
            val_30 = 0;
            label_57:
            this.PrepareMembers(animate:  true, canClaim:  false);
        }
        public void ShowKingsCupInfo()
        {
            .userAction = true;
            .<Type>k__BackingField = 2;
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).Push(action:  new Royal.Scenes.Home.Ui.Dialogs.KingsCup.ShowKingsCupInfoDialogAction());
            this.Close();
        }
        private void SendKingsCupInfoCommand()
        {
            this.spinner.Show();
            Royal.Infrastructure.Services.Backend.Http.Command.Commands val_2 = new Royal.Infrastructure.Services.Backend.Http.Command.Commands();
            val_2.Add(httpCommand:  new Royal.Infrastructure.Services.Backend.Http.Command.KingsCup.GetKingsCupInfoHttpCommand());
            val_2.add_OnComplete(value:  new Commands.ConnectionComplete(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupListPopup::KingsCupInfoReceived(bool isSuccess, Royal.Infrastructure.Services.Backend.Http.Command.Commands commands)));
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.BackendHttpService>(id:  7).SendImmediately(commandsToSend:  val_2, timeOut:  10f);
        }
        private void KingsCupInfoReceived(bool isSuccess, Royal.Infrastructure.Services.Backend.Http.Command.Commands commands)
        {
            Royal.Infrastructure.UiComponents.UiSpinner val_8 = this.spinner;
            if(val_8 == 0)
            {
                    return;
            }
            
            this.spinner.Hide();
            bool val_2 = this.kingsCupManager.IsRemainingTimeFinished;
            bool val_3 = val_2;
            this.timerTextFinished = val_3;
            val_8 = val_2;
            object[] val_4 = new object[2];
            val_4[0] = val_3;
            val_4[1] = this.kingsCupManager.RemainingTimeInMs;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  4, log:  "KingsCupInfoReceived: isFinished:{0} - remainingTime:{1}", values:  val_4);
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
            TMPro.TextMeshPro val_8;
            string val_9;
            val_8 = this;
            if((this.memberListScroll.PrepareContent(isCupFinished:  canClaim)) == 0)
            {
                goto label_2;
            }
            
            this.memberListScroll.AnimateMembers(animate:  animate);
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
            
            this.rankText.text = "#" + this.kingsCupManager.rank.ToString();
            int val_8 = this.kingsCupManager.rank;
            if(val_8 <= 3)
            {
                goto label_11;
            }
            
            if(val_8 <= 10)
            {
                goto label_12;
            }
            
            this.rewardText.text = "-";
            val_8 = this.claimButtonText;
            val_9 = "Continue";
            goto label_14;
            label_2:
            Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.ShowConnectionProblem();
            this.Close();
            return;
            label_11:
            val_8 = val_8 - 1;
            if(this.giftBoxes[val_8] != null)
            {
                goto label_18;
            }
            
            label_12:
            label_18:
            this.giftBoxes[3].SetActive(value:  true);
            val_8 = this.claimButtonText;
            val_9 = "Claim";
            label_14:
            val_8.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  val_9);
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
            
            if(this.kingsCupManager.RemainingTimeInMs < 1000)
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
            val_2.Add(httpCommand:  new Royal.Infrastructure.Services.Backend.Http.Command.KingsCup.ClaimKingsCupHttpCommand(groupId:  this.kingsCupManager.groupId));
            .<SyncRequired>k__BackingField = true;
            val_2.add_OnComplete(value:  new Commands.ConnectionComplete(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupListPopup::ClaimKingsCupResponseReceived(bool isSuccess, Royal.Infrastructure.Services.Backend.Http.Command.Commands container)));
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.BackendHttpService>(id:  7).SendImmediately(commandsToSend:  val_2, timeOut:  10f);
        }
        private void ClaimKingsCupResponseReceived(bool isSuccess, Royal.Infrastructure.Services.Backend.Http.Command.Commands container)
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
            
            Royal.Infrastructure.Services.Backend.Http.Command.BaseHttpCommand val_2 = container.FindCommandByType(responseType:  22);
            if(160 != 1)
            {
                goto label_9;
            }
            
            label_4:
            Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.ShowConnectionProblem();
            return;
            label_9:
            Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupListPopup.PlayRewardAnimation(rank:  1973545888);
            this.Close();
        }
        private static void PlayRewardAnimation(int rank)
        {
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).Push(action:  new Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupClaimAction(rank:  rank));
        }
        public void Close()
        {
            null = null;
            Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_this_arg.RemoveCounter(counter:  this);
            if(this.timerMode.activeSelf != false)
            {
                    if(IsNameEnteredOnce() != false)
            {
                    if((System.String.IsNullOrEmpty(value:  typeof(Royal.Player.Context.Data.UserId).__il2cppRuntimeField_28)) == false)
            {
                goto label_19;
            }
            
            }
            
                Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).Push(action:  new Royal.Scenes.Home.Ui.Dialogs.EnterName.ShowEnterNameDialogAction(origin:  "KingsCup", type:  1));
            }
            
            label_19:
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
            this.PrepareMembers(animate:  false, canClaim:  true);
        }
        public void ShowToolTip(Royal.Infrastructure.UiComponents.Button.UiButton button)
        {
            if(this.kingsCupManager.rank > 10)
            {
                    return;
            }
            
            UnityEngine.Transform val_1 = button.transform;
            UnityEngine.Vector3 val_2 = val_1.position;
            Royal.Infrastructure.UiComponents.Dialog.DialogManager val_3 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Dialog.DialogManager>(id:  13);
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.left;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  0.63f);
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  0.8f);
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            UnityEngine.GameObject val_10 = val_3.toolTipManager.ToggleTooltip(parent:  val_1, touchable:  button, pos:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, toolTip:  this.memberListScroll.tooltipPrefab);
            if(val_10 == 0)
            {
                    return;
            }
            
            val_10.GetComponent<Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftBoxToolTip>().ArrangeRewards(rank:  this.kingsCupManager.rank, atDown:  true);
        }
        public KingsCupListPopup()
        {
        
        }
    
    }

}
