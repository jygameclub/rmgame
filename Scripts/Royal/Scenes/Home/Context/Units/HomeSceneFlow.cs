using UnityEngine;

namespace Royal.Scenes.Home.Context.Units
{
    public class HomeSceneFlow : IContextUnit
    {
        // Fields
        private Royal.Scenes.Start.Context.Units.Scene.SceneChangeManager sceneManager;
        private Royal.Scenes.Start.Context.Units.Flow.FlowManager flowManager;
        private Royal.Player.Context.Data.Session.UserActiveLevelData lastLevel;
        private Royal.Scenes.Home.Context.Units.Tutorial.HomeTutorialManager homeTutorialManager;
        private Royal.Player.Context.Units.LeagueManager leagueManager;
        private Royal.Player.Context.Units.KingsCupManager kingsCupManager;
        private Royal.Player.Context.Units.TeamBattleManager teamBattleManager;
        private Royal.Player.Context.Units.MadnessManager madnessManager;
        private Royal.Player.Context.Units.LadderOfferManager ladderOfferManager;
        private Royal.Player.Context.Units.RoyalPassManager royalPassManager;
        private Royal.Infrastructure.Services.Native.Purchase.PurchaseManager purchaseManager;
        private bool focusInFlowDelayedForHomeSectionActivation;
        private bool <ShouldDisableTouchesForMadness>k__BackingField;
        private bool <ShouldDisableTouchesAfterWin>k__BackingField;
        private bool <RoyalPassInfoOrRevealDialogResult>k__BackingField;
        private bool <TeamBattleInfoDialogResult>k__BackingField;
        private bool <KingsCupInfoDialogResult>k__BackingField;
        private bool <LadderOfferStartDialogResult>k__BackingField;
        
        // Properties
        public bool ShouldDisableTouchesForMadness { get; set; }
        public bool ShouldDisableTouchesAfterWin { get; set; }
        public bool RoyalPassInfoOrRevealDialogResult { get; set; }
        public bool TeamBattleInfoDialogResult { get; set; }
        public bool KingsCupInfoDialogResult { get; set; }
        public bool LadderOfferStartDialogResult { get; set; }
        public int Id { get; }
        
        // Methods
        public bool get_ShouldDisableTouchesForMadness()
        {
            return (bool)this.<ShouldDisableTouchesForMadness>k__BackingField;
        }
        private void set_ShouldDisableTouchesForMadness(bool value)
        {
            this.<ShouldDisableTouchesForMadness>k__BackingField = value;
        }
        public bool get_ShouldDisableTouchesAfterWin()
        {
            return (bool)this.<ShouldDisableTouchesAfterWin>k__BackingField;
        }
        private void set_ShouldDisableTouchesAfterWin(bool value)
        {
            this.<ShouldDisableTouchesAfterWin>k__BackingField = value;
        }
        public bool get_RoyalPassInfoOrRevealDialogResult()
        {
            return (bool)this.<RoyalPassInfoOrRevealDialogResult>k__BackingField;
        }
        private void set_RoyalPassInfoOrRevealDialogResult(bool value)
        {
            this.<RoyalPassInfoOrRevealDialogResult>k__BackingField = value;
        }
        public bool get_TeamBattleInfoDialogResult()
        {
            return (bool)this.<TeamBattleInfoDialogResult>k__BackingField;
        }
        private void set_TeamBattleInfoDialogResult(bool value)
        {
            this.<TeamBattleInfoDialogResult>k__BackingField = value;
        }
        public bool get_KingsCupInfoDialogResult()
        {
            return (bool)this.<KingsCupInfoDialogResult>k__BackingField;
        }
        private void set_KingsCupInfoDialogResult(bool value)
        {
            this.<KingsCupInfoDialogResult>k__BackingField = value;
        }
        public bool get_LadderOfferStartDialogResult()
        {
            return (bool)this.<LadderOfferStartDialogResult>k__BackingField;
        }
        private void set_LadderOfferStartDialogResult(bool value)
        {
            this.<LadderOfferStartDialogResult>k__BackingField = value;
        }
        public int get_Id()
        {
            return 2;
        }
        public void Bind()
        {
            this.sceneManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Scene.SceneChangeManager>(id:  2);
            this.flowManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
            this.homeTutorialManager = Royal.Scenes.Home.Context.HomeContext.Get<Royal.Scenes.Home.Context.Units.Tutorial.HomeTutorialManager>(id:  3);
            this.leagueManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LeagueManager>(id:  5);
            this.kingsCupManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.KingsCupManager>(id:  7);
            this.teamBattleManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.TeamBattleManager>(id:  9);
            this.madnessManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.MadnessManager>(id:  10);
            this.ladderOfferManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LadderOfferManager>(id:  11);
            this.royalPassManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.RoyalPassManager>(id:  12);
            Royal.Infrastructure.Services.Native.NativeService val_10 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Native.NativeService>(id:  19);
            this.purchaseManager = val_10.purchaseManager;
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.App.AppManager>(id:  3).add_OnApplicationResume(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Context.Units.HomeSceneFlow::OnFocusIn()));
        }
        private void OnFocusIn()
        {
            if(this.sceneManager.IsLoadingScene == true)
            {
                    return;
            }
            
            if((this.sceneManager.<CurrentScene>k__BackingField) != 1)
            {
                    return;
            }
            
            this.StartFlowAfterFocusIn();
        }
        public void StartFlow(int previousScene)
        {
            this.lastLevel = Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_namespaze;
            if(previousScene == 2)
            {
                    return;
            }
            
            if(previousScene != 1)
            {
                    if(previousScene != 0)
            {
                    return;
            }
            
                this.StartFlowAfterLaunch();
                return;
            }
            
            this.StartFlowAfterForceHomeScene();
        }
        private void StartFlowAfterAdminLevel()
        {
        
        }
        private void StartFlowAfterLaunch()
        {
            this.flowManager.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.League.SendCheckLeagueCommandAction());
            this.flowManager.Push(action:  new Royal.Scenes.Home.Ui.Sections.Home.Buttons.PlayLeagueNotificationAction(playAnimation:  false, delay:  0f));
            if((this.homeTutorialManager.TryAddTutorialActions(levelWin:  false)) != false)
            {
                    return;
            }
            
            this.flowManager.Push(action:  new Royal.Scenes.Start.Context.Units.Flow.IntervalAction(duration:  0.5f, disableUiTouch:  true, flowType:  0));
            bool val_5 = this.madnessManager.TryAddBarAnimationsAndClaims();
            this.TryAddAutoDialogs();
        }
        private void StartFlowAfterFocusIn()
        {
            var val_2;
            this.flowManager.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.League.SendCheckLeagueCommandAction());
            val_2 = null;
            val_2 = null;
            Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_byval_arg.UpdateSeconds();
            this.TryAddAutoDialogs();
        }
        private void StartFlowAfterForceHomeScene()
        {
            this.flowManager.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.League.SendCheckLeagueCommandAction());
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Login.LoginService>(id:  20).ShowResultDialog();
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.TimeHelper>(id:  14).ShowLifeHackDialog();
            bool val_4 = this.madnessManager.TryAddBarAnimationsAndClaims();
            this.TryAddAutoDialogs();
        }
        private void StartFlowAfterLevelFail()
        {
            this.flowManager.Push(action:  new Royal.Scenes.Home.Ui.PlayHomeUiAnimationAction(appear:  true));
            this.flowManager.Push(action:  new Royal.Scenes.Home.Ui.Sections.Home.Buttons.PlayNotificationAnimationAction(delay:  0.1f));
            this.flowManager.Push(action:  new Royal.Scenes.Home.Ui.Sections.Home.Buttons.PlayLeagueNotificationAction(playAnimation:  true, delay:  0f));
            this.purchaseManager.ShowRetryPurchaseDialogIfNeeded();
            this.TryAddAutoDialogs();
        }
        private void StartFlowAfterLevelWin()
        {
            var val_8;
            var val_9;
            var val_10;
            if(UnityEngine.Application.internetReachability == 0)
            {
                goto label_1;
            }
            
            Royal.Infrastructure.Services.Backend.Http.Command.Commands val_2 = new Royal.Infrastructure.Services.Backend.Http.Command.Commands();
            val_2.add_OnComplete(value:  new Commands.ConnectionComplete(object:  this, method:  System.Void Royal.Scenes.Home.Context.Units.HomeSceneFlow::OnContainerComplete(bool isSuccess, Royal.Infrastructure.Services.Backend.Http.Command.Commands commands)));
            val_8 = null;
            val_8 = null;
            Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_byval_arg + 104.TrySendEventEndRequest(container:  val_2);
            Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_byval_arg + 56.TrySendEventEndRequest(container:  val_2);
            Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_byval_arg + 48.TrySendEventEndRequest(container:  val_2);
            val_9 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_9 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_9 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_9 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  4, log:  "TrySendEventEndRequestCount: "("TrySendEventEndRequestCount: ") + val_2.Size(), values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            if(val_2.Size() < 1)
            {
                goto label_20;
            }
            
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.BackendHttpService>(id:  7).SendImmediately(commandsToSend:  val_2, timeOut:  1f);
            return;
            label_1:
            val_10 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_10 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_10 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_10 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  11, log:  "StartFlowAfterLevelWin: Network is not reachable", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            this.AddLevelWinFlowActions();
            return;
            label_20:
            val_2.Complete();
        }
        private void OnContainerComplete(bool isSuccess, Royal.Infrastructure.Services.Backend.Http.Command.Commands commands)
        {
            var val_4;
            var val_5;
            val_4 = isSuccess;
            if(val_4 != true)
            {
                    val_5 = null;
                val_5 = null;
                if((commands.FindCommandByType(responseType:  18)) != null)
            {
                    Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_byval_arg + 104.HandleEventEndRequestFailed();
            }
            
                if((commands.FindCommandByType(responseType:  24)) != null)
            {
                    Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_byval_arg + 56.HandleEventEndRequestFailed();
            }
            
                if((commands.FindCommandByType(responseType:  23)) != null)
            {
                    Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_byval_arg + 48.HandleEventEndRequestFailed();
            }
            
            }
            
            this.AddLevelWinFlowActions();
        }
        private void AddLevelWinFlowActions()
        {
            Royal.Scenes.Start.Context.Units.Flow.FlowAction val_32;
            var val_33;
            var val_34;
            var val_35;
            bool val_36;
            bool val_37;
            Royal.Scenes.Home.Ui.HomeUi.EnableTouchStatic();
            mem[1152921519555978584] = 0;
            .<Type>k__BackingField = 1;
            this.flowManager.Push(action:  new Royal.Scenes.Home.Context.Units.DisableTouchesAfterWin());
            this.flowManager.Push(action:  new Royal.Scenes.Home.Ui.PlayHomeUiAnimationAction(appear:  true));
            if(Royal.Infrastructure.Utils.Native.DeviceHelper.IsAndroid != false)
            {
                    this.flowManager.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.Review.RequestStoreReviewAction());
            }
            
            if(this.lastLevel.IsLeague != false)
            {
                    this.flowManager.Push(action:  new Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LeagueCrownCollect.LeagueCrownCollectAction());
                val_32 = new Royal.Scenes.Home.Ui.Sections.Home.Buttons.PlayLeagueNotificationAction(playAnimation:  true, delay:  0.65f);
            }
            else
            {
                    val_33 = null;
                val_33 = null;
                Royal.Scenes.Game.Mechanics.Sortings.SortingData val_8 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetHomeWinStarSorting();
                Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.WinStar.PlayWinStarAnimationAction val_10 = new Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.WinStar.PlayWinStarAnimationAction(starInfoView:  Royal.Scenes.Home.Ui.__il2cppRuntimeField_40, sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_8.layer, order = val_8.order, sortEverything = val_8.sortEverything & 4294967295});
                val_32 = val_10;
            }
            
            this.flowManager.Push(action:  val_10);
            if(Royal.Infrastructure.Utils.Native.DeviceHelper.IsIos != false)
            {
                    this.flowManager.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.Review.RequestStoreReviewAction());
            }
            
            this.flowManager.Push(action:  new Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.CoinCollect.PlayCoinCollectAnimationAction(type:  0, forceDisableTouch:  false));
            mem[1152921519556044120] = 0;
            val_34 = 0;
            this.flowManager.Push(action:  new Royal.Scenes.Home.Context.Units.EnableTouchesAfterWin());
            if(this.lastLevel.animationData.completed1000ThLevelCoin.after > this.lastLevel.animationData.completed1000ThLevelCoin.before)
            {
                    val_34 = 0;
                this.flowManager.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.Completed1000ThLevel.Actions.ShowCompleted1000ThLevelPanelAction());
                val_35 = 1;
            }
            else
            {
                    val_35 = 0;
            }
            
            Royal.Player.Context.Units.MadnessManager val_32 = this.madnessManager;
            val_32 = val_32.TryAddBarAnimationsAndClaims();
            this.<ShouldDisableTouchesForMadness>k__BackingField = val_32;
            bool val_21 = this.AddClaimFlowActions();
            val_21 = val_35 | val_21;
            val_21 = val_21 | this.AddRoyalPassFlowActions();
            val_21 = val_21 | this.AddKingsCupFlowActions();
            val_36 = val_21 | this.AddTeamBattleFlowActions();
            bool val_25 = this.homeTutorialManager.TryAddTutorialActions(levelWin:  true);
            if(val_25 != true)
            {
                    val_34 = 0;
                this.flowManager.Push(action:  new Royal.Scenes.Home.Ui.Sections.Home.Buttons.PlayNotificationAnimationAction(delay:  0.1f));
                val_36 = val_36 | this.TryAddStartDialogs();
            }
            
            bool val_29 = val_25;
            if((((((this.<RoyalPassInfoOrRevealDialogResult>k__BackingField) != true) && ((this.<TeamBattleInfoDialogResult>k__BackingField) != true)) && (val_29 != true)) && (val_36 != true)) && ((this.<KingsCupInfoDialogResult>k__BackingField) != true))
            {
                    this.<LadderOfferStartDialogResult>k__BackingField = this.ladderOfferManager & 1;
            }
            
            val_37 = 1;
            if((val_29 != true) && (val_36 != true))
            {
                    val_37 = this.<LadderOfferStartDialogResult>k__BackingField;
            }
            
            this.<ShouldDisableTouchesAfterWin>k__BackingField = val_37;
            this.purchaseManager.ShowRetryPurchaseDialogIfNeeded();
            this.flowManager.ResumeMainFlow();
            object[] val_31 = new object[3];
            val_31[0] = val_29;
            val_31[1] = this.<ShouldDisableTouchesForMadness>k__BackingField;
            val_31[2] = val_36;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  4, log:  "Disable touches after win: {0} - {1} - {2}", values:  val_31);
        }
        private bool AddClaimFlowActions()
        {
            this.flowManager.Push(action:  new Royal.Scenes.Start.Context.Units.Flow.InnerFlowStartAction());
            this.flowManager.Push(action:  new Royal.Scenes.Start.Context.Units.Flow.InnerFlowFinishAction());
            this.flowManager.Push(action:  new Royal.Scenes.Start.Context.Units.Flow.InnerFlowStartAction());
            this.flowManager.Push(action:  new Royal.Scenes.Start.Context.Units.Flow.InnerFlowFinishAction());
            this.flowManager.Push(action:  new Royal.Scenes.Start.Context.Units.Flow.InnerFlowStartAction());
            this.flowManager.Push(action:  new Royal.Scenes.Start.Context.Units.Flow.InnerFlowFinishAction());
            this.flowManager.Push(action:  new Royal.Scenes.Start.Context.Units.Flow.InnerFlowStartAction());
            this.flowManager.Push(action:  new Royal.Scenes.Start.Context.Units.Flow.InnerFlowFinishAction());
            Royal.Player.Context.Units.LeagueManager val_9 = this.leagueManager | this.royalPassManager;
            val_9 = val_9 | this.teamBattleManager;
            val_9 = val_9 | this.kingsCupManager;
            return (bool)val_9 & 1;
        }
        private bool AddKingsCupFlowActions()
        {
            this.flowManager.Push(action:  new Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.KingsCupCollect.PlayKingsCupCollectAnimationAction());
            this.flowManager.Push(action:  new Royal.Scenes.Start.Context.Units.Flow.InnerFlowStartAction());
            bool val_4 = this.lastLevel.IsWin;
            this.<KingsCupInfoDialogResult>k__BackingField = this.kingsCupManager & 1;
            this.flowManager.Push(action:  new Royal.Scenes.Start.Context.Units.Flow.InnerFlowFinishAction());
            return (bool)this.<KingsCupInfoDialogResult>k__BackingField;
        }
        private bool AddTeamBattleFlowActions()
        {
            this.flowManager.Push(action:  new Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.TeamBattleCollect.PlayTeamBattleCollectAnimation());
            this.flowManager.Push(action:  new Royal.Scenes.Start.Context.Units.Flow.InnerFlowStartAction());
            this.<TeamBattleInfoDialogResult>k__BackingField = this.teamBattleManager & 1;
            this.flowManager.Push(action:  new Royal.Scenes.Start.Context.Units.Flow.InnerFlowFinishAction());
            return (bool)this.<TeamBattleInfoDialogResult>k__BackingField;
        }
        private bool AddRoyalPassFlowActions()
        {
            this.flowManager.Push(action:  new Royal.Scenes.Start.Context.Units.Flow.InnerFlowStartAction());
            this.<RoyalPassInfoOrRevealDialogResult>k__BackingField = this.royalPassManager.TryAddRewardRevealDialog(showPopup:  false);
            this.flowManager.Push(action:  new Royal.Scenes.Start.Context.Units.Flow.InnerFlowFinishAction());
            this.flowManager.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Actions.PlayRoyalPassCollectAnimation());
            this.flowManager.Push(action:  new Royal.Scenes.Start.Context.Units.Flow.InnerFlowStartAction());
            if((this.<RoyalPassInfoOrRevealDialogResult>k__BackingField) != false)
            {
                    this.<RoyalPassInfoOrRevealDialogResult>k__BackingField = true;
                this.flowManager.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.RoyalPass.ShowRoyalPassPopupAction(isUserAction:  false, isAfterPurchase:  true, type:  3));
            }
            else
            {
                    this.<RoyalPassInfoOrRevealDialogResult>k__BackingField = this.royalPassManager & 1;
            }
            
            this.flowManager.Push(action:  new Royal.Scenes.Start.Context.Units.Flow.InnerFlowFinishAction());
            return (bool)this.<RoyalPassInfoOrRevealDialogResult>k__BackingField;
        }
        private void TryAddAutoDialogs()
        {
            var val_7;
            var val_8;
            this.flowManager.DisableNextActionOnPush();
            val_7 = this.madnessManager.TryAddAutoDialog(origin:  "flow", isWin:  false);
            bool val_5 = (this.leagueManager.TryAddAutoDialog(origin:  "flow", isWin:  false)) | val_7;
            val_5 = val_5 | this.royalPassManager;
            val_5 = val_5 | (this.teamBattleManager.TryAddAutoDialog(origin:  "flow", isWin:  false));
            if((val_5 != true) && ((this.kingsCupManager.TryAddAutoDialog(origin:  "flow", isWin:  false)) != true))
            {
                    bool val_6 = this.ladderOfferManager.TryAddAutoDialog(origin:  "flow", isWin:  false);
            }
            else
            {
                    val_8 = null;
                val_8 = null;
                Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_byval_arg + 72.SetNotificationState();
            }
            
            this.flowManager.EnableNextActionOnPush();
        }
        private bool TryAddStartDialogs()
        {
            Royal.Player.Context.Units.RoyalPassManager val_2 = this.royalPassManager;
            Royal.Player.Context.Units.TeamBattleManager val_1 = this.teamBattleManager | this.kingsCupManager;
            val_1 = val_1 | this.madnessManager;
            val_1 = val_1 | val_2;
            val_2 = val_1 & 1;
            return (bool)val_2;
        }
        public HomeSceneFlow()
        {
        
        }
    
    }

}
