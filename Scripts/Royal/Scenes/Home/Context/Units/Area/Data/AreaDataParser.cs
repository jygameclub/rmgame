using UnityEngine;

namespace Royal.Scenes.Home.Context.Units.Area.Data
{
    public class AreaDataParser
    {
        // Methods
        public static void ParseAndSetFromServer(Royal.Player.Context.Data.Persistent.UserAreaData userAreaData, int newAreaId, int newAreaTasks, int newStatus)
        {
            int val_4;
            int val_5;
            var val_6;
            val_4 = newStatus;
            val_5 = newAreaTasks;
            if(newAreaId < 29)
            {
                    val_6 = newAreaId;
            }
            else
            {
                    Royal.Scenes.Home.Context.Units.Area.Data.AreaDataParser.SaveRealAreaData(newAreaId:  newAreaId, newAreaTasks:  val_5, newStatus:  val_4);
                val_6 = 28;
                val_5 = 2147483647;
                val_4 = 1;
            }
            
            Royal.Scenes.Home.Context.Units.Area.AreaManager val_1 = Royal.Scenes.Home.Context.HomeContext.Get<Royal.Scenes.Home.Context.Units.Area.AreaManager>(id:  0);
            Royal.Scenes.Home.Context.Units.Area.Config.AreaConfig val_2 = val_1.configContainer.LoadAreaConfig(id:  28);
            userAreaData.UpdateAreaData(areaId:  28, status:  1, taskData:  Royal.Scenes.Home.Context.Units.Area.Data.AreaDataParser.ConvertAreaTaskDataToArray(taskData:  2147483647, tasksLength:  val_2.tasks.Length), realAreaId:  newAreaId);
        }
        public static void ParseAndSetFromLocalStorage()
        {
            Royal.Player.Context.Data.Persistent.UserAreaData val_21;
            int val_22;
            val_21 = mem[Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField + 40];
            val_21 = Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.<AreaData>k__BackingField;
            string val_1 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetString(key:  "Area", defaultValue:  System.String.alignConst);
            if((System.String.IsNullOrEmpty(value:  val_1)) != false)
            {
                    Royal.Scenes.Home.Context.Units.Area.Data.AreaDataParser.SetInitialValues(userAreaData:  val_21);
                return;
            }
            
            string val_3 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetString(key:  "NextArea", defaultValue:  0);
            val_22 = val_3;
            if((System.String.IsNullOrEmpty(value:  val_3)) != false)
            {
                    System.Byte[] val_5 = System.Convert.FromBase64String(s:  val_1);
                int val_6 = 0;
                int val_7 = Royal.Scenes.Home.Context.Units.Area.Data.AreaDataParser.GetNextInt(data:  val_5, currentIndex: ref  val_6);
                typeof(Royal.Player.Context.Data.Persistent.UserAreaData).__il2cppRuntimeField_10 = val_7;
                typeof(Royal.Player.Context.Data.Persistent.UserAreaData).__il2cppRuntimeField_14 = val_7;
                typeof(Royal.Player.Context.Data.Persistent.UserAreaData).__il2cppRuntimeField_18 = Royal.Scenes.Home.Context.Units.Area.Data.AreaDataParser.GetNextInt(data:  val_5, currentIndex: ref  val_6);
                Royal.Scenes.Home.Context.Units.Area.AreaManager val_10 = Royal.Scenes.Home.Context.HomeContext.Get<Royal.Scenes.Home.Context.Units.Area.AreaManager>(id:  0);
                Royal.Scenes.Home.Context.Units.Area.Config.AreaConfig val_11 = val_10.configContainer.LoadAreaConfig(id:  typeof(Royal.Player.Context.Data.Persistent.UserAreaData).__il2cppRuntimeField_10);
                typeof(Royal.Player.Context.Data.Persistent.UserAreaData).__il2cppRuntimeField_20 = Royal.Scenes.Home.Context.Units.Area.Data.AreaDataParser.ConvertAreaTaskDataToArray(taskData:  Royal.Scenes.Home.Context.Units.Area.Data.AreaDataParser.GetNextInt(data:  val_5, currentIndex: ref  val_6), tasksLength:  val_11.tasks.Length);
                return;
            }
            
            char[] val_13 = new char[1];
            val_13[0] = '§';
            System.String[] val_14 = val_22.Split(separator:  val_13);
            val_22 = System.Int32.Parse(s:  val_14[0]);
            Royal.Scenes.Home.Context.Units.Area.Data.AreaDataParser.ParseAndSetFromServer(userAreaData:  val_21, newAreaId:  val_22, newAreaTasks:  System.Int32.Parse(s:  val_14[1]), newStatus:  System.Int32.Parse(s:  val_14[2]));
            val_21 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Home.Context.Units.AssetBundles.AssetBundleHelper>(id:  8);
            if(((val_7 - 4)) <= 24)
            {
                    if((Royal.Infrastructure.Services.AssetDownload.AreaDownloadManager.IsAreaAndExtraBundleExistInFileSystem(areaId:  typeof(Royal.Player.Context.Data.Persistent.UserAreaData).__il2cppRuntimeField_10)) == false)
            {
                    return;
            }
            
            }
            
            Royal.Scenes.Home.Context.Units.Area.Data.AreaDataParser.RemoveSavedRealAreaData();
        }
        public static void ParseAndSetAvailableAreaFromLocalStorage()
        {
            var val_10;
            Royal.Scenes.Home.Context.Units.AssetBundles.AssetBundleHelper val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Home.Context.Units.AssetBundles.AssetBundleHelper>(id:  8);
            if(1152921509031073868 > 24)
            {
                    return;
            }
            
            if((Royal.Infrastructure.Services.AssetDownload.AreaDownloadManager.IsAreaAndExtraBundleExistInFileSystem(areaId:  129259600)) != false)
            {
                    return;
            }
            
            Royal.Scenes.Home.Context.Units.Area.Data.AreaDataParser.SaveRealAreaData(newAreaId:  129259600, newAreaTasks:  Royal.Scenes.Home.Context.Units.Area.Data.AreaDataParser.ConvertAreaTaskArrayToTaskData(tasks:  Royal.Player.Context.Data.Persistent.UserAreaData.__il2cppRuntimeField_byval_arg), newStatus:  129263696);
            val_10 = Royal.Player.Context.Data.Persistent.UserAreaData.__il2cppRuntimeField_name;
            goto label_11;
            label_14:
            if((Royal.Infrastructure.Services.AssetDownload.AreaDownloadManager.IsAreaAndExtraBundleExistInFileSystem(areaId:  129259600)) == true)
            {
                goto label_15;
            }
            
            label_13:
            val_10 = 1152921509031073871;
            label_11:
            if(val_10 > 28)
            {
                goto label_13;
            }
            
            if(1152921509031073867 <= 24)
            {
                goto label_14;
            }
            
            label_15:
            Royal.Scenes.Home.Context.Units.Area.AreaManager val_5 = Royal.Scenes.Home.Context.HomeContext.Get<Royal.Scenes.Home.Context.Units.Area.AreaManager>(id:  0);
            Royal.Scenes.Home.Context.Units.Area.Config.AreaConfig val_6 = val_5.configContainer.LoadAreaConfig(id:  1);
            UpdateAreaData(areaId:  1, status:  1, taskData:  Royal.Scenes.Home.Context.Units.Area.Data.AreaDataParser.ConvertAreaTaskDataToArray(taskData:  2147483647, tasksLength:  val_6.tasks.Length), realAreaId:  129259600);
            bool val_8 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetSynced(key:  "Area", synced:  true);
        }
        private static int ConvertAreaTaskArrayToTaskData(Royal.Scenes.Home.Context.Units.Area.Data.AreaTaskData[] tasks)
        {
            var val_1;
            int val_1 = tasks.Length;
            if(val_1 >= 1)
            {
                    val_1 = 0;
                var val_2 = 0;
                val_1 = val_1 & 4294967295;
                do
            {
                if(tasks[32][val_2] != null)
            {
                    val_1 = val_1 + 1;
            }
            
                val_2 = val_2 + 1;
            }
            while(val_2 < (tasks.Length << ));
            
                return (int)val_1;
            }
            
            val_1 = 0;
            return (int)val_1;
        }
        private static void SetInitialValues(Royal.Player.Context.Data.Persistent.UserAreaData userAreaData)
        {
            Royal.Scenes.Home.Context.Units.Area.Config.AreaConfig val_2 = new Royal.Scenes.Home.Context.Units.Area.Config.AreaConfigContainer().LoadAreaConfig(id:  1);
            userAreaData = 1;
            Royal.Scenes.Home.Context.Units.Area.Data.AreaTaskData[] val_3 = new Royal.Scenes.Home.Context.Units.Area.Data.AreaTaskData[0];
            userAreaData = val_3;
            Royal.Scenes.Home.Context.Units.Area.Data.AreaTaskData val_4 = 0;
            var val_5 = 32;
            do
            {
                if(val_4 >= (val_3.Length << ))
            {
                    return;
            }
            
                val_4 = val_4 + 1;
                val_3[0] = val_4;
                val_5 = val_5 + 8;
            }
            while((userAreaData.<Tasks>k__BackingField) != null);
            
            throw new NullReferenceException();
        }
        private static int GetNextInt(byte[] data, ref int currentIndex)
        {
            return System.BitConverter.ToInt32(value:  Royal.Scenes.Home.Context.Units.Area.Data.AreaDataParser.GetBetween(data:  data, length:  4, currentIndex: ref  1152921519586983808), startIndex:  0);
        }
        private static byte[] GetBetween(byte[] data, int length, ref int currentIndex)
        {
            int val_4 = currentIndex;
            val_4 = val_4 + length;
            currentIndex = val_4;
            return (System.Byte[])System.Linq.Enumerable.ToArray<System.Byte>(source:  System.Linq.Enumerable.Take<System.Byte>(source:  System.Linq.Enumerable.Skip<System.Byte>(source:  data, count:  currentIndex), count:  length));
        }
        private static void SaveRealAreaData(int newAreaId, int newAreaTasks, int newStatus)
        {
            System.Text.StringBuilder val_6 = new System.Text.StringBuilder(capacity:  10).Append(value:  newAreaId).Append(value:  '§').Append(value:  newAreaTasks).Append(value:  '§').Append(value:  newStatus);
            bool val_7 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetString(key:  "NextArea", value:  val_6);
            object[] val_9 = new object[1];
            val_9[0] = val_6;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClassType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), logTag:  10, log:  "Area content ({0}) is not in the device. Real area data saved.", values:  val_9);
        }
        private static Royal.Scenes.Home.Context.Units.Area.Data.AreaTaskData[] ConvertAreaTaskDataToArray(int taskData, int tasksLength)
        {
            int val_6 = val_1.Length;
            if(<0)
            {
                    return (Royal.Scenes.Home.Context.Units.Area.Data.AreaTaskData[])new IndexOutOfRangeException();
            }
            
            int val_3 = val_6 & 4294967295;
            var val_7 = (long)val_6 - 1;
            val_6 = val_6 - 2;
            do
            {
                val_3 = val_3 & 4294967295;
                var val_5 = ((1 << val_7) != taskData) ? 1 : 0;
                new Royal.Scenes.Home.Context.Units.Area.Data.AreaTaskData[0][val_7] = val_3;
                if((val_6 & 2147483648) != 0)
            {
                    return (Royal.Scenes.Home.Context.Units.Area.Data.AreaTaskData[])new IndexOutOfRangeException();
            }
            
                val_7 = val_7 - 1;
                val_6 = val_6 - 1;
            }
            while(val_7 < val_1.Length);
            
            throw new IndexOutOfRangeException();
        }
        private static void RemoveSavedRealAreaData()
        {
            var val_3;
            if((Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.DeleteKey(key:  "NextArea")) == false)
            {
                    return;
            }
            
            val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClassType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), logTag:  10, log:  "Area content is in the device. Real area data is removed.", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        public AreaDataParser()
        {
        
        }
    
    }

}
