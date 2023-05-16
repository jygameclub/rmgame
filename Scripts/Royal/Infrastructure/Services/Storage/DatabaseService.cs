using UnityEngine;

namespace Royal.Infrastructure.Services.Storage
{
    public class DatabaseService : IContextBehaviour, IContextUnit
    {
        // Fields
        public Plugins.Sqlite.SQLiteConnection database;
        private readonly int saveInterval;
        private bool shouldSave;
        private readonly int <Id>k__BackingField;
        
        // Properties
        public int Id { get; }
        
        // Methods
        public int get_Id()
        {
            return (int)this.<Id>k__BackingField;
        }
        public DatabaseService()
        {
            this.<Id>k__BackingField = 4;
            this.database = new Plugins.Sqlite.SQLiteConnection(databasePath:  Royal.Infrastructure.Services.Storage.DbFileHelper.GetAppDbPath(), storeDateTimeAsTicks:  false);
            this.saveInterval = 67;
            this.CreateAppTables();
        }
        public DatabaseService(long userId)
        {
            this.<Id>k__BackingField = 0;
            this.database = new Plugins.Sqlite.SQLiteConnection(databasePath:  Royal.Infrastructure.Services.Storage.DbFileHelper.GetUserDbPath(userId:  userId), storeDateTimeAsTicks:  false);
            this.saveInterval = 61;
            this.CreateUserTables();
        }
        public void Bind()
        {
        
        }
        public void ManualUpdate()
        {
            if(this.shouldSave == false)
            {
                    return;
            }
            
            int val_1 = UnityEngine.Time.frameCount;
            int val_3 = this.saveInterval;
            val_3 = val_1 - ((val_1 / val_3) * val_3);
            if(val_3 != 0)
            {
                    return;
            }
            
            this.Save();
        }
        private void CreateAppTables()
        {
            this.CreateTable<Royal.Infrastructure.Services.Storage.Tables.KeyValue>();
            this.CreateTable<Royal.Infrastructure.Services.Storage.Tables.Leader>();
        }
        private void CreateUserTables()
        {
            this.CreateTable<Royal.Infrastructure.Services.Storage.Tables.KeyValue>();
            this.CreateTable<Royal.Infrastructure.Services.Storage.Tables.Inbox>();
            this.CreateTable<Royal.Infrastructure.Services.Storage.Tables.Leader>();
        }
        public void OnApplicationResume()
        {
            if(this.database != null)
            {
                    this.database.BeginTransaction();
                return;
            }
            
            throw new NullReferenceException();
        }
        public void OnApplicationPause()
        {
            if(this.database != null)
            {
                    this.database.Commit();
                return;
            }
            
            throw new NullReferenceException();
        }
        public void OnApplicationQuit()
        {
            if(this.database != null)
            {
                    this.database.Commit();
                return;
            }
            
            throw new NullReferenceException();
        }
        public void ChangeDbFileName(long newName)
        {
            this.database.Commit();
            this.database.Close();
            this.shouldSave = false;
            Plugins.Sqlite.SQLiteConnection val_2 = new Plugins.Sqlite.SQLiteConnection(databasePath:  Royal.Infrastructure.Services.Storage.DbFileHelper.MoveDbFile(currentPath:  this.database.<DatabasePath>k__BackingField, newName:  newName), storeDateTimeAsTicks:  false);
            this.database = val_2;
            val_2.BeginTransaction();
        }
        public void CreateNewDbFile(long newName, bool deleteOldOne)
        {
            this.database.Commit();
            this.database.Close();
            if(deleteOldOne != false)
            {
                    if((System.IO.File.Exists(path:  this.database.<DatabasePath>k__BackingField)) != false)
            {
                    System.IO.File.Delete(path:  this.database.<DatabasePath>k__BackingField);
            }
            
            }
            
            this.shouldSave = false;
            this.database = new Plugins.Sqlite.SQLiteConnection(databasePath:  Royal.Infrastructure.Services.Storage.DbFileHelper.GetUserDbPath(userId:  newName), storeDateTimeAsTicks:  false);
            this.CreateUserTables();
        }
        public T Find<T>(object pk)
        {
            if(this.database != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
        public void Save()
        {
            this.shouldSave = false;
            this.database.Commit();
            this.database.BeginTransaction();
        }
        private void CreateTable<T>()
        {
            this.shouldSave = true;
            if(this.database != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
        public int Insert(object dto)
        {
            this.shouldSave = true;
            if(this.database != null)
            {
                    return this.database.Insert(obj:  dto);
            }
            
            throw new NullReferenceException();
        }
        public int InsertOrReplace(object dto)
        {
            this.shouldSave = true;
            if(this.database != null)
            {
                    return this.database.InsertOrReplace(obj:  dto);
            }
            
            throw new NullReferenceException();
        }
        public int UpdateSynced(string key, int synced)
        {
            int val_4;
            this.shouldSave = true;
            object[] val_1 = new object[2];
            val_4 = val_1.Length;
            val_1[0] = synced;
            if(key != null)
            {
                    val_4 = val_1.Length;
            }
            
            val_1[1] = key;
            return (int)this.database.CreateCommand(cmdText:  "UPDATE KeyValue SET Synced = ? WHERE Key = ?", ps:  val_1).ExecuteNonQuery();
        }
        public void UpdateAllSynced(Royal.Infrastructure.Services.Storage.Tables.SyncRequiredCounts counts)
        {
            Plugins.Sqlite.SQLiteConnection val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            val_11 = counts.<Basic>k__BackingField;
            this.shouldSave = true;
            if(val_11 >= 1)
            {
                    val_12 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_12 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                val_12 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_12 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                val_13 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30];
                val_13 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30;
                int val_2 = this.database.CreateCommand(cmdText:  "UPDATE KeyValue SET Synced = 1 WHERE Key in (\'Level\',\'LeagueLevel\',\'FullLivesTimeInMs\',\'UnlimitedLivesEndTimeInMs\',\'UserData\')", ps:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184).ExecuteNonQuery();
            }
            
            if((val_11 >> 32) >= 1)
            {
                    val_11 = this.database;
                val_13 = public static T[] System.Array::Empty<System.Object>();
                val_14 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_14 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                val_14 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_14 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                int val_5 = val_11.CreateCommand(cmdText:  "UPDATE KeyValue SET Synced = 1 WHERE Key in (\'Coins\',\'Stars\',\'Inbox\',\'Chest\',\'RET\',\'TET\',\'LET\',\'EventInventory\',\'InGameInventory\',\'PreLevelInventory\',\'RoyalPassProgress\',\'RoyalPassFree\',\'RoyalPassGold\')", ps:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184).ExecuteNonQuery();
            }
            
            if((counts.<Area>k__BackingField) >= 1)
            {
                    val_11 = this.database;
                val_13 = public static T[] System.Array::Empty<System.Object>();
                val_15 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_15 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                val_15 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_15 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                int val_7 = val_11.CreateCommand(cmdText:  "UPDATE KeyValue SET Synced = 1 WHERE Key in (\'Area\')", ps:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184).ExecuteNonQuery();
            }
            
            if(((counts.<Area>k__BackingField) >> 32) < 1)
            {
                    return;
            }
            
            val_16 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_16 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_16 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_16 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            int val_10 = this.database.CreateCommand(cmdText:  "UPDATE KeyValue SET Synced = 1 WHERE Key in (\'LWM\')", ps:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184).ExecuteNonQuery();
        }
        public Royal.Infrastructure.Services.Storage.Tables.SyncRequiredCounts GetSyncRequiredCounts()
        {
            var val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            System.Collections.Generic.List<T> val_2 = this.database.CreateCommand(cmdText:  "Select (SELECT Count(Key) FROM KeyValue WHERE Key in (\'Level\',\'LeagueLevel\',\'FullLivesTimeInMs\',\'UnlimitedLivesEndTimeInMs\',\'UserData\') and Synced = 0) Basic, (SELECT Count(Key) FROM KeyValue WHERE Key in (\'Coins\',\'Stars\',\'Inbox\',\'Chest\',\'RET\',\'TET\',\'LET\',\'EventInventory\',\'InGameInventory\',\'PreLevelInventory\',\'RoyalPassProgress\',\'RoyalPassFree\',\'RoyalPassGold\') and Synced = 0) Inventory, (SELECT Count(Key) FROM KeyValue WHERE Key in (\'Area\') and Synced = 0) Area, (SELECT Count(Key) FROM KeyValue WHERE Key in (\'LWM\') and Synced = 0) Log", ps:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184).ExecuteQuery<Royal.Infrastructure.Services.Storage.Tables.SyncRequiredCounts>();
            if((public System.Collections.Generic.List<T> Plugins.Sqlite.SQLiteCommand::ExecuteQuery<Royal.Infrastructure.Services.Storage.Tables.SyncRequiredCounts>()) != 0)
            {
                    return new Royal.Infrastructure.Services.Storage.Tables.SyncRequiredCounts() {<Basic>k__BackingField = 1453102576, <Inventory>k__BackingField = 268435461, <Area>k__BackingField = 1389613984, <Log>k__BackingField = 268435459};
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            return new Royal.Infrastructure.Services.Storage.Tables.SyncRequiredCounts() {<Basic>k__BackingField = 1453102576, <Inventory>k__BackingField = 268435461, <Area>k__BackingField = 1389613984, <Log>k__BackingField = 268435459};
        }
        public int Delete<T>(object pk)
        {
            this.shouldSave = true;
            if(this.database != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
    
    }

}
