using UnityEngine;

namespace Royal.Infrastructure.Services.Storage.Tables
{
    public static class AppKeyValue
    {
        // Fields
        private static Royal.Infrastructure.Services.Storage.DatabaseService DbService;
        
        // Properties
        private static Royal.Infrastructure.Services.Storage.DatabaseService DatabaseService { get; }
        
        // Methods
        private static Royal.Infrastructure.Services.Storage.DatabaseService get_DatabaseService()
        {
            if(Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.DbService != null)
            {
                    return val_1;
            }
            
            Royal.Infrastructure.Services.Storage.DatabaseService val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Storage.DatabaseService>(id:  4);
            Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.DbService = val_1;
            return val_1;
        }
        public static void Save()
        {
            Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.DatabaseService.Save();
        }
        public static bool HasKey(string key)
        {
            return Royal.Infrastructure.Services.Storage.Tables.KeyValueTable.HasKey(db:  Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.DatabaseService, key:  key);
        }
        public static bool DeleteKey(string key)
        {
            return Royal.Infrastructure.Services.Storage.Tables.KeyValueTable.DeleteKey(db:  Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.DatabaseService, key:  key);
        }
        public static bool SetString(string key, string value)
        {
            return Royal.Infrastructure.Services.Storage.Tables.KeyValueTable.SetString(db:  Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.DatabaseService, key:  key, value:  value, synced:  false);
        }
        public static string GetString(string key, string defaultValue)
        {
            return Royal.Infrastructure.Services.Storage.Tables.KeyValueTable.GetString(db:  Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.DatabaseService, key:  key, defaultValue:  defaultValue);
        }
        public static bool SetInt(string key, int value)
        {
            return Royal.Infrastructure.Services.Storage.Tables.KeyValueTable.SetInt(db:  Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.DatabaseService, key:  key, value:  value, synced:  false);
        }
        public static int GetInt(string key, int defaultValue = 0)
        {
            return Royal.Infrastructure.Services.Storage.Tables.KeyValueTable.GetInt(db:  Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.DatabaseService, key:  key, defaultValue:  defaultValue);
        }
        public static bool SetLong(string key, long value)
        {
            return Royal.Infrastructure.Services.Storage.Tables.KeyValueTable.SetLong(db:  Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.DatabaseService, key:  key, value:  value, synced:  false);
        }
        public static long GetLong(string key, long defaultValue = 0)
        {
            return Royal.Infrastructure.Services.Storage.Tables.KeyValueTable.GetLong(db:  Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.DatabaseService, key:  key, defaultValue:  defaultValue);
        }
        public static bool SetBool(string key, bool value)
        {
            return Royal.Infrastructure.Services.Storage.Tables.KeyValueTable.SetInt(db:  Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.DatabaseService, key:  key, value:  value, synced:  false);
        }
        public static bool GetBool(string key, bool defaultValue = False)
        {
            return (bool)((Royal.Infrastructure.Services.Storage.Tables.KeyValueTable.GetInt(db:  Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.DatabaseService, key:  key, defaultValue:  defaultValue)) == 1) ? 1 : 0;
        }
    
    }

}
