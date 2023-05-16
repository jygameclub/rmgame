using UnityEngine;

namespace Royal.Player.Context.Units
{
    public class LeagueManager : AEventManager, IContextUnit, IMultipliableFeature
    {
        // Fields
        public int rank;
        public int version;
        public long groupId;
        public int userLeagueId;
        public Royal.Player.Context.Units.LeagueRewards rewards;
        private long endDate;
        private int rewardId;
        private int requiredLevel;
        private int activeLeagueId;
        private Royal.Player.Context.Units.LeagueLevel[] leagueLevels;
        private bool <IsActiveLeagueUpdatedOnline>k__BackingField;
        
        // Properties
        public int Id { get; }
        public long RemainingTimeInMs { get; }
        public bool IsRemainingTimeFinished { get; }
        public bool IsActiveLeagueUpdatedOnline { get; set; }
        
        // Methods
        public int get_Id()
        {
            return 5;
        }
        private int ExtractLeagueIdFromGroupId()
        {
            return Royal.Infrastructure.Utils.Math.BitwiseOperations.ExtractInt(fromNumber:  this.groupId, fromPosition:  32, toPosition:  63);
        }
        public LeagueManager()
        {
            this = new System.Object();
            this.requiredLevel = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.GetInt(key:  "RequiredLeagueLevel", defaultValue:  0);
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
        public bool get_IsActiveLeagueUpdatedOnline()
        {
            return (bool)this.<IsActiveLeagueUpdatedOnline>k__BackingField;
        }
        public void set_IsActiveLeagueUpdatedOnline(bool value)
        {
            this.<IsActiveLeagueUpdatedOnline>k__BackingField = value;
        }
        public void Bind()
        {
            this.FillFromLocal();
        }
        public void FillFromLocal()
        {
            var val_22;
            this.rank = 0;
            mem[1152921524154726392] = 0;
            mem[1152921524154726400] = 0;
            char[] val_2 = new char[1];
            val_2[0] = '§';
            System.String[] val_3 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.GetString(key:  "ActiveLeague", defaultValue:  "0§0").Split(separator:  val_2);
            bool val_5 = System.Int32.TryParse(s:  val_3[0], result: out  this.activeLeagueId);
            bool val_7 = System.Int32.TryParse(s:  val_3[1], result: out  this.version);
            long val_8 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetLong(key:  "LeagueGroup", defaultValue:  0);
            this.groupId = val_8;
            this.userLeagueId = Royal.Infrastructure.Utils.Math.BitwiseOperations.ExtractInt(fromNumber:  val_8, fromPosition:  32, toPosition:  63);
            char[] val_11 = new char[1];
            val_11[0] = '§';
            val_22 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetString(key:  "LeagueRank", defaultValue:  "0§0").Split(separator:  val_11);
            bool val_14 = System.Int32.TryParse(s:  val_22[0], result: out  1152921524154726384);
            bool val_16 = System.Int64.TryParse(s:  val_22[1], result: out  this.endDate);
            this.ParseLevelAndMoves(levelsString:  Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.GetString(key:  "LeagueLevels", defaultValue:  System.String.alignConst));
            string val_18 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetString(key:  "LeagueRewards", defaultValue:  0);
            if((System.String.IsNullOrEmpty(value:  val_18)) != false)
            {
                    this.version = 0;
                this.rewards = Royal.Player.Context.Units.LeagueRewards.DefaultRewards();
                return;
            }
            
            this.rewards = UnityEngine.JsonUtility.FromJson<Royal.Player.Context.Units.LeagueRewards>(json:  val_18);
            this.rewardId = val_21.id;
        }
        public bool ShouldCheckActiveLeague()
        {
            var val_2 = 0;
            return (bool);
        }
        public bool IsThereActiveLeague()
        {
            var val_2 = 0;
            return (bool);
        }
        public void UpdateActiveLeague(int league, int configVersion = 0)
        {
            this.activeLeagueId = league;
            mem[1152921524155201812] = configVersion;
            mem[1152921524155201872] = 1;
            string val_2 = this.activeLeagueId.ToString() + "§" + mem[1152921524155201812];
            bool val_3 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.SetString(key:  "ActiveLeague", value:  val_2);
            object[] val_4 = new object[1];
            val_4[0] = val_2;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  21, log:  "Active LeagueId = {0}", values:  val_4);
        }
        public void UpdateConfig(Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig config)
        {
            var val_2;
            this.UpdateActiveLeague(league:  -1926365216, configVersion:  -1926365216);
            this.ParseLevelAndMoves(levelsString:  config.__p.bb_pos);
            bool val_1 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.SetString(key:  "LeagueLevels", value:  config.__p.bb_pos);
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  21, log:  "LeagueLevels updated", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            this.UpdateRewards(rewardsListJson:  config.__p.bb_pos);
            this.UpdateRankAndDate(newRank:  this.rank, remainingTime:  null);
        }
        private void ParseLevelAndMoves(string levelsString)
        {
            Royal.Player.Context.Units.LeagueLevel[] val_4;
            char[] val_1 = new char[1];
            val_1[0] = ',';
            Royal.Player.Context.Units.LeagueLevel[] val_3 = new Royal.Player.Context.Units.LeagueLevel[0];
            this.leagueLevels = val_3;
            int val_6 = val_2.Length;
            if(val_6 < 1)
            {
                    return;
            }
            
            val_6 = val_6 & 4294967295;
            val_4 = val_3;
            var val_8 = 4;
            do
            {
                string val_7 = levelsString.Split(separator:  val_1)[0];
                var val_4 = val_8 - 4;
                var val_5 = val_8 - 3;
                val_4[0] = 0;
                if(val_5 >= (val_2.Length << ))
            {
                    return;
            }
            
                val_4 = this.leagueLevels;
                val_8 = val_8 + 1;
            }
            while(val_5 < val_2.Length);
            
            throw new IndexOutOfRangeException();
        }
        public void UpdateGroupId(long group)
        {
            if(this.groupId == group)
            {
                    return;
            }
            
            this.groupId = group;
            this.userLeagueId = Royal.Infrastructure.Utils.Math.BitwiseOperations.ExtractInt(fromNumber:  group, fromPosition:  32, toPosition:  63);
            bool val_2 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetLong(key:  "LeagueGroup", value:  this.groupId);
            object[] val_3 = new object[1];
            val_3[0] = this.groupId;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  21, log:  "LeagueGroup = {0}", values:  val_3);
            bool val_4 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetInt(key:  "LeagueLevel", value:  1);
        }
        public void UpdateMembers(Royal.Infrastructure.Services.Backend.Protocol.GetLeagueInfoResponse response)
        {
            int val_3;
            if((-1925827216) < 1)
            {
                    return;
            }
            
            bool val_1 = Royal.Infrastructure.Services.Storage.Tables.UserLeaderboard.ClearLeaderboard(type:  2);
            if((-1925827216) < 1)
            {
                    return;
            }
            
            int val_4 = 0;
            do
            {
                val_4 = val_4 + 1;
                this.rank = val_4;
                this.UpdateMember(member:  new Royal.Infrastructure.Services.Backend.Protocol.LeagueMember() {__p = new FlatBuffers.Table() {bb_pos = val_3, bb = public Royal.Infrastructure.Services.Backend.Protocol.LeagueMember System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.LeagueMember>::get_Value()}});
            }
            while(val_4 < (-1925827216));
        
        }
        public void UpdateMembers(Royal.Infrastructure.Services.Backend.Protocol.EnterLeagueResponse response)
        {
            int val_3;
            if((-1925715216) < 1)
            {
                    return;
            }
            
            bool val_1 = Royal.Infrastructure.Services.Storage.Tables.UserLeaderboard.ClearLeaderboard(type:  2);
            if((-1925715216) < 1)
            {
                    return;
            }
            
            int val_4 = 0;
            do
            {
                val_4 = val_4 + 1;
                this.rank = val_4;
                this.UpdateMember(member:  new Royal.Infrastructure.Services.Backend.Protocol.LeagueMember() {__p = new FlatBuffers.Table() {bb_pos = val_3, bb = public Royal.Infrastructure.Services.Backend.Protocol.LeagueMember System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.LeagueMember>::get_Value()}});
            }
            while(val_4 < (-1925715216));
        
        }
        private void UpdateMember(Royal.Infrastructure.Services.Backend.Protocol.LeagueMember member)
        {
            int val_3;
            if(this.rewardId != 0)
            {
                    val_3 = UnityEngine.Mathf.Min(a:  this.rewardId, b:  -1925603248);
            }
            
            this.rewardId = val_3;
            bool val_2 = Royal.Infrastructure.Services.Storage.Tables.UserLeaderboard.AddOrUpdateLeader(leader:  new Royal.Infrastructure.Services.Storage.Tables.Leader() {<Type>k__BackingField = 2, <UserName>k__BackingField = member.__p.bb_pos, <TeamName>k__BackingField = member.__p.bb_pos, <Level>k__BackingField = 1001, <IsGold>k__BackingField = false});
        }
        public void UpdateRankAndDate(int newRank, long remainingTime)
        {
            int val_7;
            this.rank = newRank;
            this.endDate = Royal.Infrastructure.Utils.Time.TimeUtil.CurrentLocalTimeInMs() + remainingTime;
            string val_4 = this.rank.ToString() + "§" + this.endDate;
            bool val_5 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetString(key:  "LeagueRank", value:  val_4);
            object[] val_6 = new object[3];
            val_6[0] = this.activeLeagueId;
            val_7 = val_6.Length;
            val_6[1] = this.groupId;
            if(val_4 != null)
            {
                    val_7 = val_6.Length;
            }
            
            val_6[2] = val_4;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  21, log:  "League = {0}§{1}§{2}", values:  val_6);
        }
        public void UpdateRankLocally()
        {
            if(this.rank < 2)
            {
                    return;
            }
            
            int val_1 = Royal.Infrastructure.Services.Storage.Tables.UserLeaderboard.GetMyRank(type:  2);
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
        private void UpdateRewards(string rewardsListJson)
        {
            string val_6;
            Royal.Player.Context.Units.LeagueRewards val_7;
            if((UnityEngine.JsonUtility.FromJson<Royal.Player.Context.Units.LeagueRewardsWrapper>(json:  rewardsListJson)) == null)
            {
                    throw new NullReferenceException();
            }
            
            if(val_1.rewards == null)
            {
                    throw new NullReferenceException();
            }
            
            if(val_1.rewards.Length < 1)
            {
                goto label_23;
            }
            
            var val_6 = 0;
            label_7:
            if(val_6 >= val_1.rewards.Length)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_7 = val_1.rewards[val_6];
            if(val_7 == null)
            {
                    throw new NullReferenceException();
            }
            
            if(this.rewardId == val_1.rewards[0x0][0].id)
            {
                goto label_6;
            }
            
            val_6 = val_6 + 1;
            if(val_6 < val_1.rewards.Length)
            {
                goto label_7;
            }
            
            label_23:
            this.version = 0;
            val_7 = Royal.Player.Context.Units.LeagueRewards.DefaultRewards();
            goto label_8;
            label_6:
            val_6 = UnityEngine.JsonUtility.ToJson(obj:  val_7);
            bool val_4 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetString(key:  "LeagueRewards", value:  val_6);
            object[] val_5 = new object[1];
            val_5[0] = val_6;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  21, log:  "LeagueRewards = {0}", values:  val_5);
            label_8:
            this.rewards = val_7;
        }
        public void UpdateRequiredLevel(int newRequiredLevel)
        {
            if(this.requiredLevel == newRequiredLevel)
            {
                    return;
            }
            
            this.requiredLevel = newRequiredLevel;
            bool val_1 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.SetInt(key:  "RequiredLeagueLevel", value:  newRequiredLevel);
            object[] val_2 = new object[1];
            val_2[0] = this.requiredLevel;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  21, log:  "Required league level is updated to value: {0}", values:  val_2);
        }
        public Royal.Player.Context.Units.LeagueLevel GetLeagueLevel(int levelIndex)
        {
            Royal.Player.Context.Units.LeagueLevel[] val_4 = this.leagueLevels;
            if(val_4 == null)
            {
                    this.ParseLevelAndMoves(levelsString:  Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.GetString(key:  "LeagueLevels", defaultValue:  System.String.alignConst));
                val_4 = this.leagueLevels;
            }
            
            int val_2 = levelIndex - 1;
            val_2 = val_2 - ((val_2 / this.leagueLevels.Length) * this.leagueLevels.Length);
            return new Royal.Player.Context.Units.LeagueLevel() {level = val_4[val_2], moves = val_4[val_2]};
        }
        public void ClaimLeague(int syncId, Royal.Infrastructure.Services.Backend.Protocol.ClaimLeagueRewardResponse response)
        {
            var val_1;
            var val_5 = val_1;
            val_5 = val_5 & 255;
            if(val_5 != 0)
            {
                    Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.UserManager>(id:  1).UpdateDataFromBackend(serverSyncId:  syncId, serverUserProgress:  new Royal.Infrastructure.Services.Backend.Protocol.UserProgress() {__p = new FlatBuffers.Table() {bb_pos = -1924577472, bb = public Royal.Infrastructure.Services.Backend.Protocol.UserProgress System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.UserProgress>::get_Value()}}, afterClaimOrPurchase:  true);
            }
            
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Analytics.AnalyticsManager>(id:  17).RlClaim(groupId:  this.groupId, rank:  this.rank, coins:  -1924577440, hammers:  -1924577440);
            this.ClearLeague();
        }
        public void ClearLeague()
        {
            this.rank = 0;
            this.groupId = 0;
            this.endDate = 0;
            this.userLeagueId = 0;
            this.activeLeagueId = 0;
            this.leagueLevels = 0;
            object[] val_1 = new object[1];
            val_1[0] = Royal.Player.Context.Data.Persistent.BasicUserData.__il2cppRuntimeField_namespaze;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  9, log:  "LeagueLevel: {0} -> 0", values:  val_1);
            UpdateLeagueLevel(newLevel:  0);
            bool val_2 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.DeleteKey(key:  "ActiveLeague");
            bool val_3 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.DeleteKey(key:  "LeagueRank");
            bool val_4 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.DeleteKey(key:  "LeagueGroup");
            bool val_5 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.DeleteKey(key:  "LeagueRewards");
            bool val_6 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.DeleteKey(key:  "LeagueShowed");
            bool val_7 = Royal.Infrastructure.Services.Storage.Tables.UserLeaderboard.ClearLeaderboard(type:  2);
        }
        private void SetDefaultRewards()
        {
            this.version = 0;
            this.rewards = Royal.Player.Context.Units.LeagueRewards.DefaultRewards();
        }
        public override bool TryAddClaimDialog(string origin = "flow")
        {
            object val_7;
            var val_8;
            val_7 = this;
            if((this.groupId != 0) && (this.RemainingTimeInMs <= 99))
            {
                    if((Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetInt(key:  "LeagueShowed", defaultValue:  0)) == 3)
            {
                    if(UnityEngine.Application.internetReachability != 0)
            {
                    object[] val_4 = new object[1];
                val_4[0] = origin;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  21, log:  "Push list popup to flow by {0}", values:  val_4);
                val_7 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
                val_7.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.League.ShowLeagueInfoPopupAction(isUserAction:  false));
            }
            
            }
            
                val_8 = 1;
                return (bool)val_8;
            }
            
            val_8 = 0;
            return (bool)val_8;
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
            
            if((Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetInt(key:  "LeagueShowed", defaultValue:  0)) == 3)
            {
                    return;
            }
            
            bool val_4 = backendHttpService.Send(httpCommand:  new Royal.Infrastructure.Services.Backend.Http.Command.League.GetLeagueInfoHttpCommand(), onComplete:  0, syncRequired:  false);
        }
        public bool CanMultiply()
        {
            var val_2 = (this.RemainingTimeInMs > 99) ? 1 : 0;
            return (bool);
        }
    
    }

}
