using UnityEngine;

namespace Royal.Infrastructure.Services.Storage.Tables
{
    public static class UserInbox
    {
        // Fields
        public const int MaxInboxCount = 15;
        private static Royal.Infrastructure.Services.Storage.DatabaseService DbService;
        
        // Properties
        private static Royal.Infrastructure.Services.Storage.DatabaseService DatabaseService { get; }
        
        // Methods
        private static Royal.Infrastructure.Services.Storage.DatabaseService get_DatabaseService()
        {
            if(Royal.Infrastructure.Services.Storage.Tables.UserInbox.DbService != null)
            {
                    return val_1;
            }
            
            Royal.Infrastructure.Services.Storage.DatabaseService val_1 = Royal.Player.Context.UserContext.Get<Royal.Infrastructure.Services.Storage.DatabaseService>(id:  0);
            Royal.Infrastructure.Services.Storage.Tables.UserInbox.DbService = val_1;
            return val_1;
        }
        public static void ResetConnection()
        {
            Royal.Infrastructure.Services.Storage.Tables.UserInbox.DbService = 0;
        }
        public static System.Collections.Generic.List<Royal.Infrastructure.Services.Storage.Tables.Inbox> GetAllHelps()
        {
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            int val_1 = Royal.Infrastructure.Services.Storage.Tables.UserInbox.ClearUsedHelps();
            typeof(Royal.Player.Context.Data.Persistent.UserInventory).__il2cppRuntimeField_18 = 15;
            Royal.Infrastructure.Services.Storage.DatabaseService val_2 = Royal.Infrastructure.Services.Storage.Tables.UserInbox.DatabaseService;
            val_14 = public static T[] System.Array::Empty<System.Object>();
            val_15 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_15 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_15 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_15 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            System.Collections.Generic.List<T> val_4 = val_2.database.CreateCommand(cmdText:  "SELECT * FROM Inbox WHERE Used = 0", ps:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184).ExecuteQuery<Royal.Infrastructure.Services.Storage.Tables.Inbox>();
            val_16 = typeof(Royal.Player.Context.Data.Persistent.UserInventory).__il2cppRuntimeField_18;
            var val_6 = val_16 - ("SELECT * FROM Inbox WHERE Used = 0");
            if(val_6 >= 1)
            {
                    do
            {
                int val_10 = Royal.Infrastructure.Services.Storage.Tables.UserInbox.DatabaseService.InsertOrReplace(dto:  (Royal.Player.Context.Units.SocialManager.UniqueAskId(time:  Royal.Infrastructure.Utils.Time.TimeUtil.CurrentTimeInMs(), userId:  Royal.Player.Context.Data.UserId.__il2cppRuntimeField_name)) + 0);
                val_14 = 0 + 1;
            }
            while(val_14 < (long)val_6);
            
                val_16 = typeof(Royal.Player.Context.Data.Persistent.UserInventory).__il2cppRuntimeField_18;
            }
            
            Royal.Infrastructure.Services.Storage.DatabaseService val_12 = Royal.Infrastructure.Services.Storage.Tables.UserInbox.DatabaseService;
            val_17 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_17 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_17 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_17 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            return (System.Collections.Generic.List<Royal.Infrastructure.Services.Storage.Tables.Inbox>)val_12.database.CreateCommand(cmdText:  "SELECT * FROM Inbox WHERE Used = 0 LIMIT "("SELECT * FROM Inbox WHERE Used = 0 LIMIT ") + 15, ps:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184).ExecuteQuery<Royal.Infrastructure.Services.Storage.Tables.Inbox>();
        }
        private static int ClearUsedHelps()
        {
            string val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            val_8 = "SELECT AskId FROM Inbox GROUP BY AskId ORDER BY AskId DESC";
            Royal.Infrastructure.Services.Storage.DatabaseService val_1 = Royal.Infrastructure.Services.Storage.Tables.UserInbox.DatabaseService;
            val_9 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_9 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_9 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_9 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_10 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30];
            val_10 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30;
            System.Collections.Generic.List<T> val_3 = val_1.database.CreateCommand(cmdText:  val_8, ps:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184).ExecuteQuery<System.Int64>();
            if(1152921527545682848 >= 2)
            {
                    val_8 = "DELETE FROM Inbox WHERE AskId != "("DELETE FROM Inbox WHERE AskId != ") + System.Single ShortcutExtensions.<>c__DisplayClass23_0::<DOFloat>b__0()(System.Single ShortcutExtensions.<>c__DisplayClass23_0::<DOFloat>b__0()) + " AND Used = 1"(" AND Used = 1");
                Royal.Infrastructure.Services.Storage.DatabaseService val_5 = Royal.Infrastructure.Services.Storage.Tables.UserInbox.DatabaseService;
                val_11 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_11 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                val_11 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_11 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                val_10 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30];
                val_10 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30;
                int val_7 = val_5.database.CreateCommand(cmdText:  val_8, ps:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184).ExecuteNonQuery();
                return (int)val_12;
            }
            
            val_12 = 0;
            return (int)val_12;
        }
        public static bool AddHelp(long time, long userId, string name)
        {
            long val_4;
            System.Type val_14;
            System.Object[] val_15;
            object val_16;
            int val_17;
            string val_18;
            int val_20;
            Royal.Infrastructure.Services.Storage.Tables.Inbox val_3 = Royal.Infrastructure.Services.Storage.Tables.UserInbox.DatabaseService.Find<Royal.Infrastructure.Services.Storage.Tables.Inbox>(pk:  Royal.Player.Context.Units.SocialManager.UniqueAskId(time:  time, userId:  userId));
            if(val_4 < 1)
            {
                goto label_6;
            }
            
            val_14 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_15 = new object[3];
            val_4 = time;
            val_16 = val_4;
            val_17 = val_6.Length;
            val_15[0] = val_16;
            if(name != null)
            {
                    val_17 = val_6.Length;
            }
            
            val_15[1] = name;
            val_15[2] = userId;
            val_18 = "Can\'t add life ({0}) to inbox from user ({1} - {2}) [Error: Message with same id already exists.]";
            label_47:
            Royal.Infrastructure.Services.Logs.Log.Error(callerClassType:  null, logTag:  20, log:  null, values:  null);
            return false;
            label_6:
            val_4 = Royal.Player.Context.Units.SocialManager.UniqueAskId(time:  time, userId:  userId);
            if((Royal.Infrastructure.Services.Storage.Tables.UserInbox.DatabaseService.Insert(dto:  val_4)) >= 1)
            {
                    AddInbox(delta:  1);
                return false;
            }
            
            System.Type val_12 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            object[] val_13 = new object[3];
            val_4 = time;
            val_20 = val_13.Length;
            val_13[0] = val_4;
            if(name != null)
            {
                    val_20 = val_13.Length;
            }
            
            val_13[1] = name;
            val_13[2] = userId;
            goto label_47;
        }
        public static bool UseHelp(long id)
        {
            long val_5;
            var val_6;
            var val_7;
            val_5 = id;
            val_5 = "UPDATE Inbox SET Used = 1 WHERE Id = "("UPDATE Inbox SET Used = 1 WHERE Id = ") + val_5;
            Royal.Infrastructure.Services.Storage.DatabaseService val_2 = Royal.Infrastructure.Services.Storage.Tables.UserInbox.DatabaseService;
            val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            if((val_2.database.CreateCommand(cmdText:  val_5, ps:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184).ExecuteNonQuery()) >= 1)
            {
                    AddInbox(delta:  0);
                val_7 = 1;
                return (bool)val_7;
            }
            
            val_7 = 0;
            return (bool)val_7;
        }
    
    }

}
