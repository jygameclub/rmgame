using UnityEngine;

namespace Royal.Player.Context.Units
{
    public class UserManager : IContextUnit
    {
        // Fields
        public const long TempUserId = 0;
        public const long TempTeamId = 1;
        private static Royal.Player.Context.Data.User <CurrentUser>k__BackingField;
        private Royal.Infrastructure.Services.Storage.DatabaseService dbService;
        private Royal.Infrastructure.Services.Backend.Http.BackendHttpService backendHttpService;
        private Royal.Player.Context.Units.LevelManager levelManager;
        private UnityEngine.Coroutine cloudCoroutine;
        
        // Properties
        public static Royal.Player.Context.Data.User CurrentUser { get; set; }
        public int Id { get; }
        
        // Methods
        public static Royal.Player.Context.Data.User get_CurrentUser()
        {
            return (Royal.Player.Context.Data.User)Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField;
        }
        private static void set_CurrentUser(Royal.Player.Context.Data.User value)
        {
            Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField = value;
        }
        public int get_Id()
        {
            return 1;
        }
        public UserManager(long id)
        {
            Royal.Player.Context.Units.UserManager.LoadUserFromLocalStorage(id:  id);
        }
        public void Bind()
        {
            this.dbService = Royal.Player.Context.UserContext.Get<Royal.Infrastructure.Services.Storage.DatabaseService>(id:  0);
            this.backendHttpService = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.BackendHttpService>(id:  7);
            this.levelManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LevelManager>(id:  2);
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.AssetDownload.AreaDownloadManager>(id:  23).add_OnAssetBundleDownloaded(value:  new System.Action<System.Int32>(object:  0, method:  static System.Void Royal.Player.Context.Units.UserManager::OnAssetBundleDownloaded(int downloadedAreaId)));
        }
        private static void OnAssetBundleDownloaded(int downloadedAreaId)
        {
            if((Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Scene.SceneChangeManager>(id:  2).IsHomeScene) == false)
            {
                    return;
            }
            
            if(IsUsingRealArea() != false)
            {
                    return;
            }
            
            Royal.Scenes.Home.Context.Units.Area.Data.AreaDataParser.ParseAndSetFromLocalStorage();
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Scene.SceneChangeManager>(id:  2).ForceLoadHomeSceneWhenPossible();
        }
        public bool RegisterIfNeeded()
        {
            var val_4;
            if((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.HasToken) != false)
            {
                    val_4 = 0;
                return (bool)val_4;
            }
            
            if(this.cloudCoroutine == null)
            {
                    this.cloudCoroutine = Royal.Scenes.Start.Context.ApplicationContext.ManualStartCoroutine(iEnumerator:  this.GetCloudBackupAndSendRegister());
            }
            
            val_4 = 1;
            return (bool)val_4;
        }
        private System.Collections.IEnumerator GetCloudBackupAndSendRegister()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new UserManager.<GetCloudBackupAndSendRegister>d__16();
        }
        private void SendRegisterCommand()
        {
            this.cloudCoroutine = 0;
            Royal.Infrastructure.Services.Backend.Http.Command.Commands val_1 = new Royal.Infrastructure.Services.Backend.Http.Command.Commands();
            val_1.Add(httpCommand:  new Royal.Infrastructure.Services.Backend.Http.Command.RegisterHttpCommand());
            val_1.Add(httpCommand:  new Royal.Infrastructure.Services.Backend.Http.Command.PingHttpCommand());
            this.backendHttpService.SendImmediately(commandsToSend:  val_1, timeOut:  10f);
        }
        private static void LoadUserFromLocalStorage(long id)
        {
            Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField = new Royal.Player.Context.Data.User(userId:  new Royal.Player.Context.Data.UserId(id:  id, token:  Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.GetString(key:  "Token", defaultValue:  System.String.alignConst)));
            Royal.Player.Context.Data.SyncManager.UpdateDataFromLocalStorage();
        }
        public void MigrateTempUser(long newId, string newToken)
        {
            Royal.Player.Context.Data.User val_2;
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            System.Object[] val_7;
            var val_9;
            object val_10;
            if(newId != 0)
            {
                    Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.UpdateUserId(newId:  newId, newToken:  newToken);
                val_2 = public static T[] System.Array::Empty<System.Object>();
                val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184];
                val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184;
                val_5 = "Same userId updated.";
            }
            else
            {
                    val_2 = public static T[] System.Array::Empty<System.Object>();
                val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184];
                val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184;
                val_5 = "Temp user couldn\'t migrated.";
            }
            
            val_7 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184];
            val_7 = val_4;
            val_9 = 9;
            val_10 = this;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  9, log:  null, values:  null);
        }
        public void ChangeUserToLocalOldUser(long guestId, string guestToken)
        {
            this.ChangeCurrentUser(newId:  guestId, newToken:  guestToken);
            Royal.Player.Context.Units.UserManager.LoadUserFromLocalStorage(id:  guestId);
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LeagueManager>(id:  5).FillFromLocal();
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.KingsCupManager>(id:  7).FillFromLocal();
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.TeamBattleManager>(id:  9).FillFromLocal();
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LeaderboardManager>(id:  6).FillFromLocal();
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LadderOfferManager>(id:  11).FillFromLocal();
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.RoyalPassManager>(id:  12).FillFromLocal();
        }
        public void ChangeUserToBackendDecidedUser(long id, string token, int syncId, System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.UserProgress> progress)
        {
            this.ChangeCurrentUser(newId:  id, newToken:  token);
            if((progress.HasValue + 16) != 0)
            {
                    this.UpdateDataFromBackend(serverSyncId:  syncId, serverUserProgress:  new Royal.Infrastructure.Services.Backend.Protocol.UserProgress() {__p = new FlatBuffers.Table() {bb_pos = progress.HasValue, bb = public Royal.Infrastructure.Services.Backend.Protocol.UserProgress System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.UserProgress>::get_Value()}}, afterClaimOrPurchase:  false);
            }
            
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.KingsCupManager>(id:  7).FillFromLocal();
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.TeamBattleManager>(id:  9).FillFromLocal();
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LadderOfferManager>(id:  11).FillFromLocal();
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.RoyalPassManager>(id:  12).FillFromLocal();
        }
        private void ChangeCurrentUser(long newId, string newToken)
        {
            long val_15;
            var val_16;
            val_15 = newId;
            bool val_1 = Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.IsConnectedToAnyPlatform();
            var val_2 = (typeof(Royal.Player.Context.Data.Persistent.BasicUserData).__il2cppRuntimeField_14 < 10) ? 1 : 0;
            Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.UpdateUserId(newId:  val_15, newToken:  newToken);
            bool val_4 = val_2 | val_1;
            bool val_7 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.DeleteKey(key:  "GuestId");
            bool val_8 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.DeleteKey(key:  "GuestToken");
            this.dbService.CreateNewDbFile(newName:  val_15, deleteOldOne:  val_4);
            Royal.Infrastructure.Services.Storage.Tables.UserInbox.ResetConnection();
            Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.ResetConnection();
            Royal.Infrastructure.Services.Storage.Tables.UserLeaderboard.ResetConnection();
            object[] val_14 = new object[4];
            val_16 = 1152921504615206912;
            val_15 = val_14;
            val_15[0] = val_4;
            val_15[1] = val_2 & val_1 ^ 1;
            val_15[2] = Royal.Player.Context.Data.UserId.__il2cppRuntimeField_name;
            val_15[3] = Royal.Player.Context.Data.UserId.__il2cppRuntimeField_name;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  9, log:  "Current user ({0}-{1}) changed: {2} -> {3}", values:  val_14);
        }
        public void SendDataToBackend(bool forceToSend = False, bool forceScoreData = False)
        {
            this.dbService.Save();
            forceScoreData = forceToSend & forceScoreData;
            Royal.Player.Context.Data.SyncManager.SendDataToBackend(backendHttpService:  this.backendHttpService, forceToSend:  forceToSend, forceScoreData:  forceScoreData);
        }
        public void DataSyncedWithBackend(bool isBasicDataSynced, bool isInventorySynced, bool isAreaDataSynced, bool isLogDataSynced)
        {
            Royal.Player.Context.Data.SyncManager.DataSyncedWithBackend(isBasicDataSynced:  isBasicDataSynced, isInventorySynced:  isInventorySynced, isAreaDataSynced:  isAreaDataSynced, isLogDataSynced:  isLogDataSynced);
        }
        public bool TryUpdateDataFromBackend(int serverSyncId, System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.UserProgress> serverUserProgress, long oldUserId = -1, sbyte trigger = 0)
        {
            var val_12;
            bool val_13;
            System.Object[] val_14;
            var val_15;
            var val_16;
            val_12 = oldUserId;
            val_13 = serverUserProgress.HasValue;
            if((serverUserProgress.HasValue + 16) == 0)
            {
                goto label_1;
            }
            
            Royal.Player.Context.Data.SyncManager.UpdateSocialData(teamId:  null, name:  val_13);
            val_13 = mem[Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField + 24];
            val_13 = Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.<BasicData>k__BackingField;
            object[] val_1 = new object[2];
            val_1[0] = Royal.Player.Context.Data.Persistent.BasicUserData.__il2cppRuntimeField_name;
            val_1[1] = serverSyncId;
            val_14 = val_1;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  9, log:  "SyncId Client/Server: {0} / {1}", values:  val_1);
            if((val_2.<IsLifeHackDetected>k__BackingField) == false)
            {
                goto label_16;
            }
            
            if((Royal.Player.Context.Data.SyncManager.HasValidLeagueProgress(serverUserProgress:  new Royal.Infrastructure.Services.Backend.Protocol.UserProgress() {__p = new FlatBuffers.Table() {bb_pos = val_13, bb = public Royal.Infrastructure.Services.Backend.Protocol.UserProgress System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.UserProgress>::get_Value()}})) == false)
            {
                goto label_17;
            }
            
            val_15;
            goto label_18;
            label_1:
            label_27:
            this.SendDataToBackend(forceToSend:  false, forceScoreData:  false);
            return false;
            label_16:
            object[] val_5 = new object[2];
            val_5[0] = typeof(Royal.Player.Context.Data.Persistent.BasicUserData).__il2cppRuntimeField_14;
            val_5[1] = val_13;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  9, log:  "Level Client/Server: {0} / {1}", values:  val_5);
            UpdateSyncId(newSyncId:  serverSyncId);
            goto label_27;
            label_17:
            val_15 = 0;
            label_18:
            val_14 = 0;
            if((Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.TimeHelper>(id:  14).IsLevelIncreased(serverLevel:  -1881260656, serverLeagueLevel:  0)) == false)
            {
                    return false;
            }
            
            if((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.IsInLeague()) != false)
            {
                    val_16 = -1152921509027013200;
            }
            
            this.UpdateDataFromBackend(serverSyncId:  serverSyncId, serverUserProgress:  new Royal.Infrastructure.Services.Backend.Protocol.UserProgress() {__p = new FlatBuffers.Table() {bb_pos = val_13, bb = public Royal.Infrastructure.Services.Backend.Protocol.UserProgress System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.UserProgress>::get_Value()}}, afterClaimOrPurchase:  false);
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Analytics.AnalyticsManager>(id:  17).RefreshProgress(oldUserId:  Royal.Player.Context.Data.UserId.__il2cppRuntimeField_name, oldUserLevel:  typeof(Royal.Player.Context.Data.Persistent.BasicUserData).__il2cppRuntimeField_14, trigger:  (int)trigger & 255);
            return false;
        }
        public void UpdateDataFromBackend(int serverSyncId, Royal.Infrastructure.Services.Backend.Protocol.UserProgress serverUserProgress, bool afterClaimOrPurchase = False)
        {
            if(afterClaimOrPurchase != false)
            {
                    Royal.Player.Context.Data.SyncManager.UpdateInventoryFromBackend(serverSyncId:  serverSyncId, serverUserProgress:  new Royal.Infrastructure.Services.Backend.Protocol.UserProgress() {__p = new FlatBuffers.Table() {bb_pos = serverUserProgress.__p.bb_pos, bb = serverUserProgress.__p.bb}}, updateSync:  true);
            }
            else
            {
                    Royal.Player.Context.Data.SyncManager.RefreshProgressFromBackend(serverSyncId:  serverSyncId, serverUserProgress:  new Royal.Infrastructure.Services.Backend.Protocol.UserProgress() {__p = new FlatBuffers.Table() {bb_pos = serverUserProgress.__p.bb_pos, bb = serverUserProgress.__p.bb}});
            }
            
            object[] val_1 = new object[1];
            val_1[0] = serverSyncId;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  9, log:  "User progress synced with server: {0}", values:  val_1);
            if(afterClaimOrPurchase == true)
            {
                    return;
            }
            
            Reset();
            Reset();
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Scene.SceneChangeManager>(id:  2).ForceLoadHomeSceneWhenPossible();
        }
        public void LevelEnd()
        {
            object val_20;
            Royal.Player.Context.Data.Persistent.BasicUserData val_21;
            Royal.Player.Context.Data.Persistent.UserInventory val_22;
            val_20 = this;
            val_22 = mem[Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField + 32];
            val_22 = Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.<Inventory>k__BackingField;
            Royal.Player.Context.Units.LeagueManager val_1 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LeagueManager>(id:  5);
            Royal.Player.Context.Units.TeamBattleManager val_19 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.TeamBattleManager>(id:  9);
            Royal.Player.Context.Units.KingsCupManager val_3 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.KingsCupManager>(id:  7);
            val_1.GetFinishedEventDataFromBackend(backendHttpService:  this.backendHttpService);
            val_19.GetFinishedEventDataFromBackend(backendHttpService:  this.backendHttpService);
            val_3.GetFinishedEventDataFromBackend(backendHttpService:  this.backendHttpService);
            if(IsWin == false)
            {
                goto label_10;
            }
            
            this.levelManager.<LevelEpisodeHelper>k__BackingField.IncrementTryCount();
            this.levelManager.<LevelEpisodeHelper>k__BackingField.UpdateUserSkill();
            val_21 = mem[Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField + 24];
            val_21 = Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.<BasicData>k__BackingField;
            IncrementLevel(levelData:  Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_namespaze);
            UpdateCoins(newCoins:  Royal.Player.Context.Data.Session.__il2cppRuntimeField_70 + 40 + 20 + 4);
            if(IsStory == false)
            {
                goto label_22;
            }
            
            label_10:
            this.SendDataToBackend(forceToSend:  false, forceScoreData:  false);
            return;
            label_22:
            UpdateCloche(amount:  Royal.Player.Context.Data.Session.__il2cppRuntimeField_60 + 24);
            UpdateStars(newStars:  Royal.Player.Context.Data.Session.__il2cppRuntimeField_58 + 24);
            Royal.Player.Context.Units.UserManager.AddInventoryPackage(package:  Royal.Player.Context.Data.InventoryPackage.Get1000ThLevelPackage());
            if((Royal.Player.Context.Data.Session.__il2cppRuntimeField_70 + 56.IsEventValid()) != false)
            {
                    if((Royal.Player.Context.Data.Session.__il2cppRuntimeField_70 + 56.GetCollectedAmount()) >= 1)
            {
                    Royal.Player.Context.Data.Persistent.MadnessProgress val_9 = GetMadness();
                UpdateMadness(madness:  new Royal.Player.Context.Data.Persistent.MadnessProgress() {step = val_9.step, count = val_9.count, eventId = val_9.eventId & 4294967295});
                object[] val_11 = new object[1];
                val_11[0] = ;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  26, log:  "LevelEnd: {0}", values:  val_11);
            }
            
            }
            
            val_21 = mem[Royal.Player.Context.Data.Session.__il2cppRuntimeField_70 + 64];
            val_21 = Royal.Player.Context.Data.Session.__il2cppRuntimeField_70 + 64;
            if(val_21.IsEventValid() != false)
            {
                    if(val_21.GetCollectedAmount() >= 1)
            {
                    UpdateRoyalPass(royalPassProgress:  new Royal.Player.Context.Data.Persistent.RoyalPassProgress() {<GoldProgress>k__BackingField = Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_generic_class, isGold = Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_generic_class, eventId = Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_generic_class});
            }
            
            }
            
            if(IsLeague != false)
            {
                    val_1.UpdateRankLocally();
            }
            else
            {
                    Royal.Infrastructure.Services.Notification.GameNotificationService.UpdateUserLevelTag();
                if(val_1.ShouldCheckActiveLeague() != false)
            {
                    val_20 = this.backendHttpService;
                bool val_17 = val_20.Send(httpCommand:  new Royal.Infrastructure.Services.Backend.Http.Command.League.CheckLeagueHttpCommand(), onComplete:  0, syncRequired:  false);
            }
            
            }
            
            if(val_2.rank >= 2)
            {
                    int val_18 = Royal.Infrastructure.Services.Storage.Tables.UserLeaderboard.GetMyRank(type:  8);
                if((val_18 >= 1) && (val_18 < val_2.rank))
            {
                    val_19 = val_18;
            }
            
            }
            
            val_3.UpdateRankLocally();
        }
        public void RemainingMovesEnd()
        {
            int val_6;
            AddCoins(delta:  Royal.Player.Context.Data.Session.__il2cppRuntimeField_4C>>0&0xFFFFFFFF);
            UpdatePiggy(newPiggy:  Royal.Player.Context.Data.Session.__il2cppRuntimeField_68 + 24);
            Royal.Player.Context.Data.Persistent.MadnessProgress val_1 = GetMadness();
            val_6 = val_1.eventId;
            if((Royal.Player.Context.Data.Session.__il2cppRuntimeField_70 + 56.IsEventValid()) != false)
            {
                    int val_3 = val_1.step >> 32;
                UpdateMadness(madness:  new Royal.Player.Context.Data.Persistent.MadnessProgress() {step = val_1.step, count = val_1.count, eventId = val_6 & 4294967295});
                object[] val_5 = new object[1];
                val_6 = ;
                val_5[0] = val_6;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  26, log:  "RemainingMovesEnd: {0}", values:  val_5);
            }
            
            this.SendDataToBackend(forceToSend:  false, forceScoreData:  false);
        }
        public static bool BuyBooster(Royal.Scenes.Game.Mechanics.Boosters.BoosterType boosterType)
        {
            var val_7;
            string val_1 = boosterType.ToString();
            string val_2 = boosterType.ToString();
            int val_3 = Royal.Scenes.Game.Mechanics.Boosters.BoosterTypeExtension.Price(boosterType:  null);
            if((SpendCoins(spendingData:  new Royal.Player.Context.Data.Session.SpendingData())) != false)
            {
                    Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16).PlaySound(type:  75, offset:  0.04f);
                AddBooster(type:  null, delta:  Royal.Scenes.Game.Mechanics.Boosters.BoosterTypeExtension.Amount(boosterType:  null));
                val_7 = 1;
                return (bool)val_7;
            }
            
            val_7 = 0;
            return (bool)val_7;
        }
        public static void AddInventoryPackage(Royal.Player.Context.Data.InventoryPackage package)
        {
            var val_2;
            Royal.Scenes.Game.Mechanics.Boosters.BoosterType val_3;
            AddCoins(delta:  package.coins);
            Dictionary.Enumerator<TKey, TValue> val_1 = package.boosters.GetEnumerator();
            label_7:
            if(((-1880447216) & 1) == 0)
            {
                goto label_6;
            }
            
            AddBooster(type:  val_3, delta:  val_3);
            goto label_7;
            label_6:
            val_2.Dispose();
            if(package.unlimitedBoosters == null)
            {
                goto label_23;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_4 = package.unlimitedBoosters.GetEnumerator();
            label_12:
            if(((-1880447216) & 1) == 0)
            {
                goto label_9;
            }
            
            AddTime(boosterType:  val_3, deltaSeconds:  Royal.Infrastructure.Utils.Time.TimeUtil.ConvertMinToSec(min:  val_3));
            goto label_12;
            label_9:
            val_2.Dispose();
            label_23:
            if(package.unlimitedLifetimeMin < 1)
            {
                    return;
            }
            
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LifeHelper>(id:  3).AddUnlimitedLivesInMinutes(deltaMinutes:  package.unlimitedLifetimeMin);
        }
    
    }

}
