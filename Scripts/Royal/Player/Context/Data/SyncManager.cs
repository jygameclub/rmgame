using UnityEngine;

namespace Royal.Player.Context.Data
{
    public static class SyncManager
    {
        // Fields
        private const int InitialCoins = 2000;
        
        // Methods
        public static void UpdateDataFromLocalStorage()
        {
            var val_20;
            var val_21;
            var val_22;
            FillFromLocal();
            typeof(Royal.Player.Context.Data.Persistent.BasicUserData).__il2cppRuntimeField_10 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetInt(key:  "SyncId", defaultValue:  0);
            typeof(Royal.Player.Context.Data.Persistent.BasicUserData).__il2cppRuntimeField_14 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetInt(key:  "Level", defaultValue:  1);
            typeof(Royal.Player.Context.Data.Persistent.BasicUserData).__il2cppRuntimeField_18 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetInt(key:  "LeagueLevel", defaultValue:  0);
            typeof(Royal.Player.Context.Data.Persistent.BasicUserData).__il2cppRuntimeField_20 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetLong(key:  "FullLivesTimeInMs", defaultValue:  Royal.Infrastructure.Utils.Time.TimeUtil.CurrentTimeInMs());
            typeof(Royal.Player.Context.Data.Persistent.BasicUserData).__il2cppRuntimeField_28 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetLong(key:  "UnlimitedLivesEndTimeInMs", defaultValue:  0);
            typeof(Royal.Player.Context.Data.Persistent.BasicUserData).__il2cppRuntimeField_30 = (long)Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetInt(key:  "UserData", defaultValue:  0);
            typeof(Royal.Player.Context.Data.Persistent.UserInventory).__il2cppRuntimeField_10 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetInt(key:  "Coins", defaultValue:  208);
            typeof(Royal.Player.Context.Data.Persistent.UserInventory).__il2cppRuntimeField_14 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetInt(key:  "Stars", defaultValue:  0);
            typeof(Royal.Player.Context.Data.Persistent.UserInventory).__il2cppRuntimeField_18 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetInt(key:  "Inbox", defaultValue:  0);
            typeof(Royal.Player.Context.Data.Persistent.UserInventory).__il2cppRuntimeField_1C = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetInt(key:  "Chest", defaultValue:  0);
            typeof(Royal.Player.Context.Data.Persistent.UserInventory).__il2cppRuntimeField_38 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetInt(key:  "RET", defaultValue:  0);
            typeof(Royal.Player.Context.Data.Persistent.UserInventory).__il2cppRuntimeField_3C = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetInt(key:  "TET", defaultValue:  0);
            typeof(Royal.Player.Context.Data.Persistent.UserInventory).__il2cppRuntimeField_40 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetInt(key:  "LET", defaultValue:  0);
            typeof(Royal.Player.Context.Data.Persistent.UserInventory).__il2cppRuntimeField_20 = Royal.Player.Context.Data.SyncManager.InitEventInventory();
            typeof(Royal.Player.Context.Data.Persistent.UserInventory).__il2cppRuntimeField_28 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetLong(key:  "InGameInventory", defaultValue:  0);
            typeof(Royal.Player.Context.Data.Persistent.UserInventory).__il2cppRuntimeField_30 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetLong(key:  "PreLevelInventory", defaultValue:  0);
            typeof(Royal.Player.Context.Data.Persistent.UserInventory).__il2cppRuntimeField_48 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetLong(key:  "RemainingBoosterTimes", defaultValue:  0);
            Royal.Player.Context.Data.Persistent.RoyalPassProgress val_19 = Royal.Player.Context.Data.SyncManager.InitRoyalPassProgress();
            typeof(Royal.Player.Context.Data.Persistent.UserInventory).__il2cppRuntimeField_60 = val_20;
            typeof(Royal.Player.Context.Data.Persistent.UserInventory).__il2cppRuntimeField_70 = val_21;
            typeof(Royal.Player.Context.Data.Persistent.UserInventory).__il2cppRuntimeField_50 = val_22;
            Royal.Scenes.Home.Context.Units.Area.Data.AreaDataParser.ParseAndSetFromLocalStorage();
        }
        private static long InitEventInventory()
        {
            long val_1 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetLong(key:  "EventInventory", defaultValue:  0);
            if(val_1 == 0)
            {
                    return Royal.Player.Context.Data.Persistent.MadnessProgress.GetDefaultMadness();
            }
            
            return val_1;
        }
        private static Royal.Player.Context.Data.Persistent.RoyalPassProgress InitRoyalPassProgress()
        {
            long val_1 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetLong(key:  "RoyalPassProgress", defaultValue:  0);
            long val_2 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetLong(key:  "RoyalPassFree", defaultValue:  0);
            long val_3 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetLong(key:  "RoyalPassGold", defaultValue:  0);
            val_0.step = 0;
            val_0.count = 0;
            val_0.tutorialState = 0;
            mem[1152921524205583756] = 0;
            val_0.<GoldProgress>k__BackingField = 0;
            val_0.isGold = false;
            mem[1152921524205583737] = 0;
            val_0.<PassProgress>k__BackingField = 0;
            val_0.<FreeProgress>k__BackingField = 0;
        }
        public static void SendDataToBackend(Royal.Infrastructure.Services.Backend.Http.BackendHttpService backendHttpService, bool forceToSend = False, bool forceScoreData = False)
        {
            int val_10;
            var val_11;
            Royal.Infrastructure.Services.Backend.Http.Command.BaseHttpCommand val_12;
            val_10 = forceToSend;
            if(val_10 != false)
            {
                    Royal.Infrastructure.Services.Backend.Http.Command.UpdateUserProgressHttpCommand val_2 = null;
                val_10 = val_2;
                val_2 = new Royal.Infrastructure.Services.Backend.Http.Command.UpdateUserProgressHttpCommand(updateBasicData:  true, updateInventory:  true, updateArea:  true, updateLogData:  true, forceScoreData:  forceScoreData);
                val_11 = 1;
                val_12 = val_10;
            }
            else
            {
                    Royal.Infrastructure.Services.Storage.Tables.SyncRequiredCounts val_3 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetSyncRequiredCounts();
                if( < 1)
            {
                    return;
            }
            
                val_10 = val_3.<Basic>k__BackingField;
                Royal.Infrastructure.Services.Backend.Http.Command.UpdateUserProgressHttpCommand val_8 = new Royal.Infrastructure.Services.Backend.Http.Command.UpdateUserProgressHttpCommand(updateBasicData:  (val_10 > 0) ? 1 : 0, updateInventory:  ((val_3.<Inventory>k__BackingField) > 0) ? 1 : 0, updateArea:  ((val_3.<Area>k__BackingField) > 0) ? 1 : 0, updateLogData:  ((val_3.<Log>k__BackingField) > 0) ? 1 : 0, forceScoreData:  false);
                val_11 = 1;
                val_12 = val_8;
            }
            
            bool val_9 = backendHttpService.Send(httpCommand:  val_8, onComplete:  0, syncRequired:  true);
        }
        public static void DataSyncedWithBackend(bool isBasicDataSynced, bool isInventorySynced, bool isAreaDataSynced, bool isLogDataSynced)
        {
            Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetAllSynced(counts:  new Royal.Infrastructure.Services.Storage.Tables.SyncRequiredCounts() {<Basic>k__BackingField = isBasicDataSynced, <Inventory>k__BackingField = isInventorySynced, <Area>k__BackingField = (isLogDataSynced != true) ? 4294967296 : isAreaDataSynced, <Log>k__BackingField = (isLogDataSynced != true) ? 4294967296 : isAreaDataSynced});
        }
        public static void UpdateInventoryFromBackend(int serverSyncId, Royal.Infrastructure.Services.Backend.Protocol.UserProgress serverUserProgress, bool updateSync = True)
        {
            System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.TimeHelper>(id:  14).ResetLifeHackValues();
            UpdateSyncId(newSyncId:  serverSyncId);
            UpdateFullLivesTimeInMs(newFullLivesTimeInMs:  null);
            UpdateUnlimitedLivesEndTimeInMs(newUnlimitedLivesEndTimeInMs:  null);
            UpdateUserData(newUserData:  null);
            UpdateCoins(newCoins:  -1875746240);
            UpdateChest(newChest:  -1875746240);
            UpdateRocketEndTime(endTime:  -1875746240);
            UpdateTntEndTime(endTime:  -1875746240);
            UpdateLightballEndTime(endTime:  -1875746240);
            UpdateRemainingBoosterTimes(newRemainingBoosterTimes:  null);
            UpdateRoyalPassFromServer(royalPassUserProgress:  new System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassUserProgress>() {HasValue = true});
            object[] val_5 = new object[2];
            val_5[0] = typeof(Royal.Player.Context.Data.Persistent.UserInventory).__il2cppRuntimeField_28;
            val_5[1] = serverUserProgress.__p.bb_pos;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClassType:  val_1, logTag:  9, log:  "InGame: {0} -> {1}", values:  val_5);
            UpdateInGameInventory(newInGameInventory:  null);
            object[] val_6 = new object[2];
            val_6[0] = Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_this_arg;
            val_6[1] = serverUserProgress.__p.bb_pos;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClassType:  val_1, logTag:  9, log:  "Prelevel: {0} -> {1}", values:  val_6);
            UpdatePreLevelInventory(newPreLevelInventory:  null);
            if(updateSync == false)
            {
                    return;
            }
            
            Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetAllSynced(counts:  new Royal.Infrastructure.Services.Storage.Tables.SyncRequiredCounts() {<Basic>k__BackingField = 1, <Inventory>k__BackingField = 1, <Log>k__BackingField = 1});
        }
        public static void RefreshProgressFromBackend(int serverSyncId, Royal.Infrastructure.Services.Backend.Protocol.UserProgress serverUserProgress)
        {
            var val_2;
            Royal.Player.Context.Data.SyncManager.UpdateInventoryFromBackend(serverSyncId:  serverSyncId, serverUserProgress:  new Royal.Infrastructure.Services.Backend.Protocol.UserProgress() {__p = new FlatBuffers.Table() {bb_pos = serverUserProgress.__p.bb_pos, bb = serverUserProgress.__p.bb}}, updateSync:  false);
            UpdateLevel(newLevel:  -1875574800);
            UpdateStars(newStars:  -1875574800);
            UpdateInbox(inboxItemCount:  -1875574800);
            UpdateEventInventory(newEventInventory:  null);
            Royal.Scenes.Home.Context.Units.Area.Data.AreaDataParser.ParseAndSetFromServer(userAreaData:  Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.<AreaData>k__BackingField, newAreaId:  -1875574800, newAreaTasks:  -1875574800, newStatus:  -1875574800);
            Royal.Player.Context.Data.SyncManager.UpdateSocialData(teamId:  null, name:  serverUserProgress.__p.bb_pos);
            if((Royal.Player.Context.Data.SyncManager.HasValidLeagueProgress(serverUserProgress:  new Royal.Infrastructure.Services.Backend.Protocol.UserProgress() {__p = new FlatBuffers.Table() {bb_pos = serverUserProgress.__p.bb_pos, bb = serverUserProgress.__p.bb}})) != false)
            {
                    Royal.Player.Context.Data.SyncManager.UpdateLeagueData(leagueProgress:  new Royal.Infrastructure.Services.Backend.Protocol.LeagueProgress() {__p = new FlatBuffers.Table() {bb_pos = -1875574848, bb = public Royal.Infrastructure.Services.Backend.Protocol.LeagueProgress System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.LeagueProgress>::get_Value()}});
                UpdateLeagueLevel(newLevel:  -1875574816);
            }
            else
            {
                    Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LeagueManager>(id:  5).ClearLeague();
            }
            
            var val_14 = val_2;
            val_14 = val_14 & 255;
            if(val_14 != 0)
            {
                    Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.TeamBattleManager>(id:  9).UpdateInfo(info:  new Royal.Infrastructure.Services.Backend.Protocol.TeamBattleInfo() {__p = new FlatBuffers.Table() {bb_pos = -1875574880, bb = public Royal.Infrastructure.Services.Backend.Protocol.TeamBattleInfo System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.TeamBattleInfo>::get_Value()}});
            }
            
            var val_15 = val_2;
            val_15 = val_15 & 255;
            if(val_15 != 0)
            {
                    Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.KingsCupManager>(id:  7).UpdateInfo(info:  new Royal.Infrastructure.Services.Backend.Protocol.KingsCupInfo() {__p = new FlatBuffers.Table() {bb_pos = -1875574912, bb = public Royal.Infrastructure.Services.Backend.Protocol.KingsCupInfo System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.KingsCupInfo>::get_Value()}});
            }
            
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.MadnessManager>(id:  10).UpdateInfo(info:  new System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.MadnessEventInfo>() {HasValue = true});
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LadderOfferManager>(id:  11).UpdateInfo(info:  new System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.LadderOfferInfo>() {HasValue = true});
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.RoyalPassManager>(id:  12).UpdateInfo(royalPassInfo:  new System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassInfo>() {HasValue = true});
            Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetAllSynced(counts:  new Royal.Infrastructure.Services.Storage.Tables.SyncRequiredCounts() {<Basic>k__BackingField = 1, <Inventory>k__BackingField = 1, <Area>k__BackingField = 1, <Log>k__BackingField = 1});
        }
        public static bool HasValidLeagueProgress(Royal.Infrastructure.Services.Backend.Protocol.UserProgress serverUserProgress)
        {
            var val_1;
            var val_3;
            if((-1875438192) <= 1001)
            {
                    var val_2 = (val_1 == true) ? 1 : 0;
                return (bool)val_3;
            }
            
            val_3 = 0;
            return (bool)val_3;
        }
        public static void UpdateLeagueData(Royal.Infrastructure.Services.Backend.Protocol.LeagueProgress leagueProgress)
        {
            var val_2;
            Royal.Player.Context.Units.LeagueManager val_1 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LeagueManager>(id:  5);
            val_1.UpdateGroupId(group:  null);
            val_1.UpdateRankAndDate(newRank:  -1875321072, remainingTime:  null);
            var val_4 = val_2;
            val_4 = val_4 & 255;
            if(val_4 == 0)
            {
                    return;
            }
            
            val_1.UpdateConfig(config:  new Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig() {__p = new FlatBuffers.Table() {bb_pos = -1875321104, bb = public Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig>::get_Value()}});
        }
        public static void UpdateSocialData(long teamId, string name)
        {
            UpdateName(newName:  name);
            UpdateTeam(teamId:  teamId);
        }
    
    }

}
