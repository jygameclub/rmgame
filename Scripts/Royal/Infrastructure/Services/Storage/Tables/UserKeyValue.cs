using UnityEngine;

namespace Royal.Infrastructure.Services.Storage.Tables
{
    public static class UserKeyValue
    {
        // Fields
        private static Royal.Infrastructure.Services.Storage.DatabaseService DbService;
        
        // Properties
        private static Royal.Infrastructure.Services.Storage.DatabaseService DatabaseService { get; }
        
        // Methods
        private static Royal.Infrastructure.Services.Storage.DatabaseService get_DatabaseService()
        {
            if(Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.DbService != null)
            {
                    return val_1;
            }
            
            Royal.Infrastructure.Services.Storage.DatabaseService val_1 = Royal.Player.Context.UserContext.Get<Royal.Infrastructure.Services.Storage.DatabaseService>(id:  0);
            Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.DbService = val_1;
            return val_1;
        }
        public static void ResetConnection()
        {
            Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.DbService = 0;
        }
        public static void Save()
        {
            Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.DatabaseService.Save();
        }
        public static bool HasKey(string key)
        {
            return Royal.Infrastructure.Services.Storage.Tables.KeyValueTable.HasKey(db:  Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.DatabaseService, key:  key);
        }
        public static bool DeleteKey(string key)
        {
            return Royal.Infrastructure.Services.Storage.Tables.KeyValueTable.DeleteKey(db:  Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.DatabaseService, key:  key);
        }
        public static bool SetString(string key, string value)
        {
            return Royal.Infrastructure.Services.Storage.Tables.KeyValueTable.SetString(db:  Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.DatabaseService, key:  key, value:  value, synced:  false);
        }
        public static string GetString(string key, string defaultValue)
        {
            return Royal.Infrastructure.Services.Storage.Tables.KeyValueTable.GetString(db:  Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.DatabaseService, key:  key, defaultValue:  defaultValue);
        }
        public static bool SetInt(string key, int value)
        {
            return Royal.Infrastructure.Services.Storage.Tables.KeyValueTable.SetInt(db:  Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.DatabaseService, key:  key, value:  value, synced:  false);
        }
        public static int GetInt(string key, int defaultValue = 0)
        {
            return Royal.Infrastructure.Services.Storage.Tables.KeyValueTable.GetInt(db:  Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.DatabaseService, key:  key, defaultValue:  defaultValue);
        }
        public static bool SetLong(string key, long value)
        {
            return Royal.Infrastructure.Services.Storage.Tables.KeyValueTable.SetLong(db:  Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.DatabaseService, key:  key, value:  value, synced:  false);
        }
        public static long GetLong(string key, long defaultValue = 0)
        {
            return Royal.Infrastructure.Services.Storage.Tables.KeyValueTable.GetLong(db:  Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.DatabaseService, key:  key, defaultValue:  defaultValue);
        }
        public static bool SetBool(string key, bool value)
        {
            return Royal.Infrastructure.Services.Storage.Tables.KeyValueTable.SetInt(db:  Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.DatabaseService, key:  key, value:  value, synced:  false);
        }
        public static bool GetBool(string key, bool defaultValue = False)
        {
            return (bool)((Royal.Infrastructure.Services.Storage.Tables.KeyValueTable.GetInt(db:  Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.DatabaseService, key:  key, defaultValue:  defaultValue)) == 1) ? 1 : 0;
        }
        public static bool SetSynced(string key, bool synced)
        {
            return Royal.Infrastructure.Services.Storage.Tables.KeyValueTable.SetSynced(db:  Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.DatabaseService, key:  key, synced:  synced);
        }
        public static void SetAllSynced(Royal.Infrastructure.Services.Storage.Tables.SyncRequiredCounts counts)
        {
            Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.DatabaseService.UpdateAllSynced(counts:  new Royal.Infrastructure.Services.Storage.Tables.SyncRequiredCounts() {<Basic>k__BackingField = counts.<Basic>k__BackingField, <Inventory>k__BackingField = counts.<Inventory>k__BackingField, <Area>k__BackingField = counts.<Area>k__BackingField, <Log>k__BackingField = counts.<Log>k__BackingField});
        }
        public static Royal.Infrastructure.Services.Storage.Tables.SyncRequiredCounts GetSyncRequiredCounts()
        {
            return Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.DatabaseService.GetSyncRequiredCounts();
        }
    
    }

}
