using UnityEngine;

namespace Royal.Player.Context.Units
{
    public class TeamBattleManager : AEventManager, IContextUnit, IMultipliableFeature
    {
        // Fields
        private const long LastHours = 10800000;
        public static readonly int[] Rewards;
        private bool <JustClaimed>k__BackingField;
        public int eventId;
        public int myScore;
        public int rank;
        public long groupId;
        private long endDate;
        private Royal.Infrastructure.Services.Backend.Protocol.UserEventStatus status;
        private UnityEngine.Coroutine tryShowTeamBattleListPopupCoroutine;
        private long previousNotClaimedGroupId;
        
        // Properties
        public int Id { get; }
        public long RemainingTimeInMs { get; }
        public bool IsRemainingTimeFinished { get; }
        public bool IsParticipating { get; }
        public bool IsInAGroup { get; }
        public bool ShouldShowIcon { get; }
        public bool ShouldShowWarningInTeamLeave { get; }
        public bool JustClaimed { get; set; }
        
        // Methods
        public int get_Id()
        {
            return 9;
        }
        public long get_RemainingTimeInMs()
        {
            long val_1 = Royal.Infrastructure.Utils.Time.TimeUtil.CurrentLocalTimeInMs();
            val_1 = this.endDate - val_1;
            return (long)val_1;
        }
        public bool get_IsRemainingTimeFinished()
        {
            return (bool)(this.RemainingTimeInMs < 100) ? 1 : 0;
        }
        public bool get_IsParticipating()
        {
            int val_2 = this.myScore;
            val_2 = val_2 >> 31;
            return (bool)val_2 ^ 1;
        }
        public bool get_IsInAGroup()
        {
            return (bool)(this.groupId > 0) ? 1 : 0;
        }
        public bool get_ShouldShowIcon()
        {
            var val_3;
            if((this.RemainingTimeInMs < 10800001) || ((this.myScore & 2147483648) != 0))
            {
                    return (bool)(this.groupId > 0) ? 1 : 0;
            }
            
            val_3 = 1;
            return (bool)(this.groupId > 0) ? 1 : 0;
        }
        public bool get_ShouldShowWarningInTeamLeave()
        {
            var val_3;
            if((this.RemainingTimeInMs >= 100) && ((this.myScore & 2147483648) == 0))
            {
                    var val_2 = (this.groupId > 0) ? 1 : 0;
                return (bool)val_3;
            }
            
            val_3 = 0;
            return (bool)val_3;
        }
        public bool get_JustClaimed()
        {
            return (bool)this.<JustClaimed>k__BackingField;
        }
        private void set_JustClaimed(bool value)
        {
            this.<JustClaimed>k__BackingField = value;
        }
        public void Bind()
        {
            this.FillFromLocal();
            Royal.Infrastructure.Contexts.Units.App.AppManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.App.AppManager>(id:  3);
            val_1.add_OnApplicationPause(value:  new System.Action(object:  this, method:  System.Void Royal.Player.Context.Units.TeamBattleManager::ClaimSessionCompleted()));
            val_1.add_OnApplicationQuit(value:  new System.Action(object:  this, method:  System.Void Royal.Player.Context.Units.TeamBattleManager::ClaimSessionCompleted()));
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Game.Context.GameContext>(id:  11).add_OnActivate(value:  new System.Action(object:  this, method:  System.Void Royal.Player.Context.Units.TeamBattleManager::ClaimSessionCompleted()));
        }
        public void FillFromLocal()
        {
            string val_16;
            this.rank = 0;
            this.groupId = 0;
            mem[1152921524195103520] = 0;
            mem[1152921524195103548] = 0;
            mem[1152921524195103540] = 0;
            mem[1152921524195103568] = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetLong(key:  "TBCNF", defaultValue:  0);
            string val_2 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetString(key:  "TeamBattle", defaultValue:  0);
            if((System.String.IsNullOrEmpty(value:  val_2)) == true)
            {
                    return;
            }
            
            char[] val_4 = new char[1];
            if(val_4 == null)
            {
                    throw new NullReferenceException();
            }
            
            if(val_4.Length == 0)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_4[0] = '§';
            if(val_2 == null)
            {
                    throw new NullReferenceException();
            }
            
            System.String[] val_5 = val_2.Split(separator:  val_4);
            if(val_5.Length == 0)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_16 = val_5[0];
            bool val_7 = System.Int32.TryParse(s:  val_16, result: out  this.myScore);
            if(val_5.Length <= 1)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_16 = val_5[1];
            bool val_9 = System.Int32.TryParse(s:  val_16, result: out  1152921524195103532);
            if(val_5.Length <= 2)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_16 = val_5[2];
            bool val_11 = System.Int64.TryParse(s:  val_16, result: out  1152921524195103536);
            if(val_5.Length <= 3)
            {
                    throw new IndexOutOfRangeException();
            }
            
            bool val_13 = System.Int64.TryParse(s:  val_5[3], result: out  1152921524195103544);
            bool val_15 = System.Int32.TryParse(s:  val_5[4], result: out  this.eventId);
        }
        private static int ExtractEventIdFromGroupId(long id)
        {
            return Royal.Infrastructure.Utils.Math.BitwiseOperations.ExtractInt(fromNumber:  id, fromPosition:  48, toPosition:  63);
        }
        public bool ShouldPlayShieldCollect()
        {
            var val_3;
            if((this.RemainingTimeInMs >= 100) && ((this.myScore & 2147483648) == 0))
            {
                    var val_2 = (this.status == 0) ? 1 : 0;
                return (bool)val_3;
            }
            
            val_3 = 0;
            return (bool)val_3;
        }
        public void UpdateInfo(Royal.Infrastructure.Services.Backend.Protocol.TeamBattleInfo info)
        {
            var val_10;
            var val_11;
            if((this.<JustClaimed>k__BackingField) != false)
            {
                    object[] val_1 = new object[1];
                val_1[0] = ;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  25, log:  "Team Battle is just claimed, will not update info. groupId: {0} ", values:  val_1);
                return;
            }
            
            this.status = ;
            if(96 == 1)
            {
                goto label_7;
            }
            
            if(96 != 2)
            {
                goto label_8;
            }
            
            this.rank = 0;
            this.groupId = 0;
            var val_2 = (this.eventId != ) ? 1 : 0;
            this.endDate =  + Royal.Infrastructure.Utils.Time.TimeUtil.CurrentLocalTimeInMs();
            this.myScore = ;
            this.eventId = ;
            Royal.Infrastructure.Services.Notification.GameNotificationService.TryUpdateUserTeamBattleEventIdTag(eventId:  -1886173856);
            goto label_16;
            label_7:
            this.rank = ;
            this.groupId = ;
            this.endDate = Royal.Infrastructure.Utils.Time.TimeUtil.CurrentLocalTimeInMs();
            this.myScore = ;
            val_11 = 63;
            val_10 = 0;
            this.eventId = Royal.Infrastructure.Utils.Math.BitwiseOperations.ExtractInt(fromNumber:  this.groupId, fromPosition:  48, toPosition:  63);
            goto label_16;
            label_8:
            this.rank = ;
            this.groupId = ;
            this.endDate =  + Royal.Infrastructure.Utils.Time.TimeUtil.CurrentLocalTimeInMs();
            this.myScore = ;
            val_11 = 63;
            this.eventId = Royal.Infrastructure.Utils.Math.BitwiseOperations.ExtractInt(fromNumber:  this.groupId, fromPosition:  48, toPosition:  63);
            if((this.groupId == 0) && ((this.myScore & 2147483648) == 0))
            {
                    val_11 = 0;
                Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg.AddTeamBattle(difficulty:  Royal.Player.Context.Data.Session.__il2cppRuntimeField_2C>>0&0xFF);
            }
            
            val_10 = 0;
            label_16:
            this.UpdateTeamBattleData(resetAutoDialogState:  false);
            this.UpdateMembers(info:  new Royal.Infrastructure.Services.Backend.Protocol.TeamBattleInfo() {__p = new FlatBuffers.Table() {bb_pos = info.__p.bb_pos, bb = info.__p.bb}});
            this.TryClaimPreviousEvent();
        }
        private void TryClaimPreviousEvent()
        {
            if(this.previousNotClaimedGroupId == 0)
            {
                    return;
            }
            
            if(this.previousNotClaimedGroupId == this.groupId)
            {
                    return;
            }
            
            object[] val_1 = new object[1];
            val_1[0] = Royal.Infrastructure.Utils.Math.BitwiseOperations.ExtractInt(fromNumber:  this.previousNotClaimedGroupId, fromPosition:  48, toPosition:  63);
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  25, log:  "Send silent claim command for previous event: {0}", values:  val_1);
            this = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.BackendHttpService>(id:  7);
            bool val_5 = this.Send(httpCommand:  new Royal.Infrastructure.Services.Backend.Http.Command.TeamBattle.ClaimTeamBattleHttpCommand(groupId:  this.previousNotClaimedGroupId), onComplete:  0, syncRequired:  false);
        }
        private void UpdateTeamBattleData(bool resetAutoDialogState)
        {
            int val_6;
            int val_7;
            int val_8;
            int val_9;
            object val_10;
            int val_11;
            var val_12;
            object[] val_1 = new object[9];
            val_6 = val_1.Length;
            val_1[0] = this.myScore.ToString();
            val_6 = val_1.Length;
            val_1[1] = "§";
            val_7 = val_1.Length;
            val_1[2] = this.rank;
            val_7 = val_1.Length;
            val_1[3] = "§";
            val_8 = val_1.Length;
            val_1[4] = this.groupId;
            val_8 = val_1.Length;
            val_1[5] = "§";
            val_9 = val_1.Length;
            val_1[6] = this.endDate;
            val_9 = val_1.Length;
            val_1[7] = "§";
            val_1[8] = this.eventId;
            string val_3 = +val_1;
            object[] val_4 = new object[3];
            val_4[0] = this.eventId;
            val_10 = this.status;
            val_11 = val_4.Length;
            val_4[1] = val_10;
            if(val_3 != null)
            {
                    val_11 = val_4.Length;
            }
            
            val_4[2] = val_3;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  25, log:  "TeamBattle: {0} - {1} - {2}", values:  val_4);
            if((this.<JustClaimed>k__BackingField) != false)
            {
                    val_10 = public static T[] System.Array::Empty<System.Object>();
                val_12 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_12 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                val_12 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_12 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  25, log:  "Team battle is just claimed.", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            }
            
            bool val_5 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetString(key:  "TeamBattle", value:  val_3);
            if(resetAutoDialogState == false)
            {
                    return;
            }
        
        }
        public override void ResetAutoDialogState()
        {
            var val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  25, log:  "Resetting auto dialog state for team battle", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            bool val_1 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetInt(key:  "TeamBattleShowed", value:  0);
        }
        private void SetAutoDialogStateToFinished()
        {
            if(this.status != 1)
            {
                    return;
            }
            
            bool val_1 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetInt(key:  "TeamBattleShowed", value:  3);
        }
        private void UpdateMembers(Royal.Infrastructure.Services.Backend.Protocol.TeamBattleInfo info)
        {
            var val_3;
            if((-1885471856) < 1)
            {
                    return;
            }
            
            bool val_1 = Royal.Infrastructure.Services.Storage.Tables.UserLeaderboard.ClearLeaderboard(type:  8);
            if((-1885471856) >= 1)
            {
                    var val_5 = 0;
                do
            {
                val_3.UpdateMember(team:  new Royal.Infrastructure.Services.Backend.Protocol.TeamBattleTeam() {__p = new FlatBuffers.Table() {bb_pos = -1885471888, bb = public Royal.Infrastructure.Services.Backend.Protocol.TeamBattleTeam System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.TeamBattleTeam>::get_Value()}});
                val_5 = val_5 + 1;
            }
            while(val_5 < (-1885471856));
            
            }
            
            bool val_4 = Royal.Infrastructure.Services.Storage.Tables.UserLeaderboard.ClearLeaderboard(type:  9);
            if((-1885471856) >= 1)
            {
                    var val_6 = 0;
                do
            {
                val_3.UpdateMember(user:  new Royal.Infrastructure.Services.Backend.Protocol.TeamBattleUser() {__p = new FlatBuffers.Table() {bb_pos = -1885471920, bb = public Royal.Infrastructure.Services.Backend.Protocol.TeamBattleUser System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.TeamBattleUser>::get_Value()}});
                val_6 = val_6 + 1;
            }
            while(val_6 < (-1885471856));
            
            }
            
            this.SetAutoDialogStateToFinished();
        }
        public int GetMyRank()
        {
            return Royal.Infrastructure.Services.Storage.Tables.UserLeaderboard.GetMyRank(type:  9);
        }
        private void UpdateMember(Royal.Infrastructure.Services.Backend.Protocol.TeamBattleTeam team)
        {
            bool val_1 = Royal.Infrastructure.Services.Storage.Tables.UserLeaderboard.AddOrUpdateLeader(leader:  new Royal.Infrastructure.Services.Storage.Tables.Leader() {<Type>k__BackingField = 8, <TeamName>k__BackingField = team.__p.bb_pos, <LevelUpdateTime>k__BackingField = team.__p.bb_pos, <IsGold>k__BackingField = false});
        }
        private void UpdateMember(Royal.Infrastructure.Services.Backend.Protocol.TeamBattleUser user)
        {
            bool val_1 = Royal.Infrastructure.Services.Storage.Tables.UserLeaderboard.AddOrUpdateLeader(leader:  new Royal.Infrastructure.Services.Storage.Tables.Leader() {<Type>k__BackingField = 9, <UserName>k__BackingField = user.__p.bb_pos, <IsGold>k__BackingField = false});
        }
        public void UpdateRankLocally()
        {
            if(this.rank < 2)
            {
                    return;
            }
            
            int val_1 = Royal.Infrastructure.Services.Storage.Tables.UserLeaderboard.GetMyRank(type:  8);
            if(val_1 < 1)
            {
                    return;
            }
            
            if(val_1 >= this.rank)
            {
                    return;
            }
            
            this.rank = val_1;
        }
        public void ClaimTeamBattle(int syncId, Royal.Infrastructure.Services.Backend.Protocol.ClaimTeamBattleRewardResponse response)
        {
            var val_1;
            long val_13;
            var val_12 = val_1;
            val_12 = val_12 & 255;
            if(val_12 != 0)
            {
                    Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.UserManager>(id:  1).UpdateDataFromBackend(serverSyncId:  syncId, serverUserProgress:  new Royal.Infrastructure.Services.Backend.Protocol.UserProgress() {__p = new FlatBuffers.Table() {bb_pos = -1884895536, bb = public Royal.Infrastructure.Services.Backend.Protocol.UserProgress System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.UserProgress>::get_Value()}}, afterClaimOrPurchase:  true);
            }
            
            int val_4 = Royal.Infrastructure.Services.Storage.Tables.UserLeaderboard.GetMyRank(type:  9);
            int val_5 = Royal.Infrastructure.Services.Storage.Tables.UserLeaderboard.GetTeamLevel(type:  8);
            Royal.Player.Context.Data.InventoryPackage val_6 = Royal.Player.Context.Data.InventoryPackage.GetTeamBattlePackage(myRank:  val_4, teamRank:  -1884895504, myScore:  this.myScore);
            if(this.previousNotClaimedGroupId != 0)
            {
                    if(this.previousNotClaimedGroupId != this.groupId)
            {
                goto label_9;
            }
            
            }
            
            this.rank = response.__p.bb_pos;
            val_13 = this.groupId;
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Analytics.AnalyticsManager>(id:  17).TbClaim(tbId:  Royal.Infrastructure.Utils.Math.BitwiseOperations.ExtractInt(fromNumber:  val_13, fromPosition:  48, toPosition:  63), groupId:  this.groupId, rank:  this.rank, teamId:  Royal.Player.Context.Data.UserId.__il2cppRuntimeField_this_arg, package:  val_6, userRank:  val_4, teamShield:  val_5, userShield:  this.myScore);
            this.<JustClaimed>k__BackingField = true;
            this.status = 2;
            goto label_15;
            label_9:
            val_13 = this.previousNotClaimedGroupId;
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Analytics.AnalyticsManager>(id:  17).TbClaim(tbId:  Royal.Infrastructure.Utils.Math.BitwiseOperations.ExtractInt(fromNumber:  this.previousNotClaimedGroupId, fromPosition:  48, toPosition:  63), groupId:  val_13, rank:  -1884895504, teamId:  Royal.Player.Context.Data.UserId.__il2cppRuntimeField_this_arg, package:  val_6, userRank:  val_4, teamShield:  val_5, userShield:  this.myScore);
            label_15:
            this.previousNotClaimedGroupId = 0;
            bool val_11 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.DeleteKey(key:  "TBCNF");
        }
        public void ClaimNotFinished(long claimGroupId)
        {
            this.previousNotClaimedGroupId = claimGroupId;
            bool val_1 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetLong(key:  "TBCNF", value:  claimGroupId);
        }
        private void ClaimSessionCompleted()
        {
            Royal.Scenes.Home.Context.HomeContextController val_4;
            var val_5;
            var val_6;
            val_4 = this;
            if((this.<JustClaimed>k__BackingField) == false)
            {
                    return;
            }
            
            this.<JustClaimed>k__BackingField = false;
            this.rank = 0;
            this.groupId = 0;
            this.eventId = 0;
            bool val_1 = Royal.Infrastructure.Services.Storage.Tables.UserLeaderboard.ClearLeaderboard(type:  8);
            bool val_2 = Royal.Infrastructure.Services.Storage.Tables.UserLeaderboard.ClearLeaderboard(type:  9);
            this.UpdateTeamBattleData(resetAutoDialogState:  true);
            val_5 = null;
            val_5 = null;
            val_4 = Royal.Scenes.Home.Context.HomeContext.<Controller>k__BackingField;
            if(val_4 == 0)
            {
                    return;
            }
            
            val_6 = null;
            val_6 = null;
            Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_byval_arg.UpdateSeconds();
        }
        public void AfterLeaveTeam()
        {
            this.<JustClaimed>k__BackingField = false;
            this.groupId = 0;
            this.myScore = (this.groupId > 0) ? -1 : 0;
            this.rank = 0;
            bool val_2 = Royal.Infrastructure.Services.Storage.Tables.UserLeaderboard.ClearLeaderboard(type:  8);
            bool val_3 = Royal.Infrastructure.Services.Storage.Tables.UserLeaderboard.ClearLeaderboard(type:  9);
            this.UpdateTeamBattleData(resetAutoDialogState:  false);
        }
        public override bool TryAddStartDialog(string origin = "flow")
        {
            var val_7;
            object val_8;
            var val_9;
            val_8 = this;
            if(this.RemainingTimeInMs >= 10800001)
            {
                    if((this.myScore & 2147483648) == 0)
            {
                goto label_2;
            }
            
            }
            
            if(this.groupId >= 1)
            {
                    label_2:
                val_7 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
                val_9 = 0;
                if((Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetInt(key:  "TeamBattleShowed", defaultValue:  0)) != 0)
            {
                    return (bool)val_9;
            }
            
                if(this.groupId > 0)
            {
                    return (bool)val_9;
            }
            
                object[] val_4 = new object[1];
                val_4[0] = origin;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  25, log:  "Push info dialog by {0}", values:  val_4);
                bool val_5 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetInt(key:  "TeamBattleShowed", value:  1);
                Royal.Scenes.Home.Ui.Dialogs.TeamBattle.ShowTeamBattleInfoDialogAction val_6 = null;
                val_8 = val_6;
                val_6 = new Royal.Scenes.Home.Ui.Dialogs.TeamBattle.ShowTeamBattleInfoDialogAction(userAction:  false, originType:  0, type:  3);
                val_7.Push(action:  val_6);
                val_9 = 1;
                return (bool)val_9;
            }
            
            val_9 = 0;
            return (bool)val_9;
        }
        public override bool TryAddInfoDialog(string origin = "flow", bool isWin = False)
        {
            var val_11;
            var val_12;
            if(this.RemainingTimeInMs >= 10800001)
            {
                    if((this.myScore & 2147483648) == 0)
            {
                goto label_2;
            }
            
            }
            
            if(this.groupId >= 1)
            {
                    label_2:
                int val_2 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetInt(key:  "TeamBattleShowed", defaultValue:  0);
                val_11 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
                val_12 = 0;
                if(val_2 > 1)
            {
                    return (bool)val_12;
            }
            
                if(this.groupId < 1)
            {
                    return (bool)val_12;
            }
            
                bool val_4 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetInt(key:  "TeamBattleShowed", value:  2);
                if(this.RemainingTimeInMs >= 100)
            {
                    object[] val_6 = new object[1];
                val_6[0] = origin;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  25, log:  "Push list popup to flow by {0}", values:  val_6);
                if(val_2 == 0)
            {
                    if(val_11.IsInnerFlowInitializing() != true)
            {
                    val_11.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.TeamBattle.ShowTeamBattleInfoDialogAction(userAction:  false, originType:  0, type:  3));
                val_11.Push(action:  new Royal.Scenes.Start.Context.Units.Flow.IntervalAction(duration:  0.25f, disableUiTouch:  true, flowType:  3));
            }
            
            }
            
                val_11.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.TeamBattle.ShowTeamBattlePopupAction(isUserAction:  false, isForClaim:  false));
                val_12 = 1;
                return (bool)val_12;
            }
            
            }
            
            val_12 = 0;
            return (bool)val_12;
        }
        public override bool TryAddClaimDialog(string origin = "flow")
        {
            var val_8;
            object val_9;
            var val_10;
            val_9 = this;
            if(this.RemainingTimeInMs >= 10800001)
            {
                    if((this.myScore & 2147483648) == 0)
            {
                goto label_2;
            }
            
            }
            
            if(this.groupId >= 1)
            {
                    label_2:
                if(this.groupId >= 1)
            {
                    val_8 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
                if(this.RemainingTimeInMs <= 99)
            {
                    if((Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetInt(key:  "TeamBattleShowed", defaultValue:  0)) == 3)
            {
                    if(UnityEngine.Application.internetReachability != 0)
            {
                    object[] val_6 = new object[1];
                val_6[0] = origin;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  25, log:  "Push list popup to flow by {0}", values:  val_6);
                Royal.Scenes.Home.Ui.Dialogs.TeamBattle.ShowTeamBattlePopupAction val_7 = null;
                val_9 = val_7;
                val_7 = new Royal.Scenes.Home.Ui.Dialogs.TeamBattle.ShowTeamBattlePopupAction(isUserAction:  false, isForClaim:  true);
                val_8.Push(action:  val_7);
            }
            
            }
            
                val_10 = 1;
                return (bool)val_10;
            }
            
            }
            
            }
            
            val_10 = 0;
            return (bool)val_10;
        }
        public void GetFinishedEventDataFromBackend(Royal.Infrastructure.Services.Backend.Http.BackendHttpService backendHttpService)
        {
            if(this.groupId < 1)
            {
                    return;
            }
            
            if(this.RemainingTimeInMs > 99)
            {
                    return;
            }
            
            if((Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetInt(key:  "TeamBattleShowed", defaultValue:  0)) == 3)
            {
                    return;
            }
            
            bool val_4 = backendHttpService.Send(httpCommand:  new Royal.Infrastructure.Services.Backend.Http.Command.TeamBattle.GetTeamBattleInfoHttpCommand(), onComplete:  0, syncRequired:  false);
        }
        public bool CanMultiply()
        {
            var val_3;
            if((this.RemainingTimeInMs >= 100) && ((this.myScore & 2147483648) == 0))
            {
                    var val_2 = (this.status == 0) ? 1 : 0;
                return (bool)val_3;
            }
            
            val_3 = 0;
            return (bool)val_3;
        }
        public TeamBattleManager()
        {
        
        }
        private static TeamBattleManager()
        {
            Royal.Player.Context.Units.TeamBattleManager.Rewards = new int[5] {6000, 3000, 2000, 1500, 1000};
        }
    
    }

}
