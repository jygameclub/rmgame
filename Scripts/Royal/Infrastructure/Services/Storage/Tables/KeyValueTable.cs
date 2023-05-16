using UnityEngine;

namespace Royal.Infrastructure.Services.Storage.Tables
{
    public static class KeyValueTable
    {
        // Methods
        public static bool HasKey(Royal.Infrastructure.Services.Storage.DatabaseService db, string key)
        {
            var val_2;
            Royal.Infrastructure.Services.Storage.Tables.KeyValue val_1 = db.Find<Royal.Infrastructure.Services.Storage.Tables.KeyValue>(pk:  key);
            return (bool)(val_2 != 0) ? 1 : 0;
        }
        public static bool DeleteKey(Royal.Infrastructure.Services.Storage.DatabaseService db, string key)
        {
            return (bool)((db.Delete<Royal.Infrastructure.Services.Storage.Tables.KeyValue>(pk:  key)) > 0) ? 1 : 0;
        }
        public static bool SetString(Royal.Infrastructure.Services.Storage.DatabaseService db, string key, string value, bool synced = False)
        {
            bool val_1 = synced;
            return (bool)((db.InsertOrReplace(dto:  key)) > 0) ? 1 : 0;
        }
        public static string GetString(Royal.Infrastructure.Services.Storage.DatabaseService db, string key, string defaultValue)
        {
            var val_2;
            Royal.Infrastructure.Services.Storage.Tables.KeyValue val_1 = db.Find<Royal.Infrastructure.Services.Storage.Tables.KeyValue>(pk:  key);
            return (string)(val_2 == 0) ? defaultValue : (val_2);
        }
        public static bool SetInt(Royal.Infrastructure.Services.Storage.DatabaseService db, string key, int value, bool synced = False)
        {
            string val_1 = value.ToString();
            bool val_2 = synced;
            return (bool)((db.InsertOrReplace(dto:  key)) > 0) ? 1 : 0;
        }
        public static int GetInt(Royal.Infrastructure.Services.Storage.DatabaseService db, string key, int defaultValue)
        {
            string val_2;
            int val_3 = 0;
            Royal.Infrastructure.Services.Storage.Tables.KeyValue val_1 = db.Find<Royal.Infrastructure.Services.Storage.Tables.KeyValue>(pk:  key);
            return (int)((System.Int32.TryParse(s:  val_2, result: out  val_3)) != true) ? (val_3) : defaultValue;
        }
        public static bool SetLong(Royal.Infrastructure.Services.Storage.DatabaseService db, string key, long value, bool synced = False)
        {
            string val_1 = value.ToString();
            bool val_2 = synced;
            return (bool)((db.InsertOrReplace(dto:  key)) > 0) ? 1 : 0;
        }
        public static long GetLong(Royal.Infrastructure.Services.Storage.DatabaseService db, string key, long defaultValue)
        {
            string val_2;
            long val_3 = 0;
            Royal.Infrastructure.Services.Storage.Tables.KeyValue val_1 = db.Find<Royal.Infrastructure.Services.Storage.Tables.KeyValue>(pk:  key);
            return (long)((System.Int64.TryParse(s:  val_2, result: out  val_3)) != true) ? (val_3) : defaultValue;
        }
        public static bool SetSynced(Royal.Infrastructure.Services.Storage.DatabaseService db, string key, bool synced)
        {
            return (bool)((db.UpdateSynced(key:  key, synced:  synced)) > 0) ? 1 : 0;
        }
        public static void SetAllSynced(Royal.Infrastructure.Services.Storage.DatabaseService db, Royal.Infrastructure.Services.Storage.Tables.SyncRequiredCounts counts)
        {
            if(db != null)
            {
                    db.UpdateAllSynced(counts:  new Royal.Infrastructure.Services.Storage.Tables.SyncRequiredCounts() {<Basic>k__BackingField = counts.<Basic>k__BackingField, <Inventory>k__BackingField = counts.<Inventory>k__BackingField, <Area>k__BackingField = counts.<Area>k__BackingField, <Log>k__BackingField = counts.<Log>k__BackingField});
                return;
            }
            
            throw new NullReferenceException();
        }
        public static Royal.Infrastructure.Services.Storage.Tables.SyncRequiredCounts GetSyncRequiredCounts(Royal.Infrastructure.Services.Storage.DatabaseService db)
        {
            if(db != null)
            {
                    return db.GetSyncRequiredCounts();
            }
            
            throw new NullReferenceException();
        }
    
    }

}
