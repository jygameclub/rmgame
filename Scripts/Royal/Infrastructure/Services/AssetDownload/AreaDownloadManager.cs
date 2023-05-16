using UnityEngine;

namespace Royal.Infrastructure.Services.AssetDownload
{
    public class AreaDownloadManager : IContextBehaviour, IContextUnit
    {
        // Fields
        private const int StartDownloadMinLevel = 10;
        private System.Action<int> OnAssetBundleDownloaded;
        private readonly System.Collections.Generic.LinkedList<Royal.Infrastructure.Services.AssetDownload.AreaDownloadManager.DownloadOperation> areaDownloadQueue;
        private bool areaDownloadDelayed;
        private UnityEngine.Coroutine timeoutCoroutine;
        private Royal.Infrastructure.Services.AssetDownload.AreaDownloader areaDownloader;
        private Royal.Infrastructure.Services.AssetDownload.AreaDownloadManager.DownloadOperation currentDownloadOperation;
        
        // Properties
        public int Id { get; }
        
        // Methods
        public void add_OnAssetBundleDownloaded(System.Action<int> value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnAssetBundleDownloaded, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnAssetBundleDownloaded != 1152921528667256064);
            
            return;
            label_2:
        }
        public void remove_OnAssetBundleDownloaded(System.Action<int> value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnAssetBundleDownloaded, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnAssetBundleDownloaded != 1152921528667392640);
            
            return;
            label_2:
        }
        public int get_Id()
        {
            return 23;
        }
        public void Bind()
        {
            Royal.Infrastructure.Services.AssetDownload.AreaDownloader.CreateDirectory();
            null.CopyAreasFromStreamingAssets();
            this.StartDownloadingNewAreas();
        }
        public void ManualUpdate()
        {
            if(this.currentDownloadOperation != null)
            {
                    return;
            }
            
            if(this.currentDownloadOperation < 1)
            {
                    return;
            }
            
            this.currentDownloadOperation = this.currentDownloadOperation;
            this.areaDownloadQueue.RemoveFirst();
            this.DownloadAreaToLocal();
        }
        private void StartDownloadingNewAreas()
        {
            this.areaDownloadDelayed = false;
            System.Action val_2 = static_value_02DC1B30;
            val_2 = new System.Action(object:  this, method:  System.Void Royal.Infrastructure.Services.AssetDownload.AreaDownloadManager::StartDownloadingNewAreas());
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Home.Context.HomeContext>(id:  10).remove_OnActivate(value:  val_2);
            this.SelectDownloadableAreas();
        }
        private void CopyAreasFromStreamingAssets()
        {
            if(Royal.Infrastructure.Utils.Native.DeviceHelper.IsDev != true)
            {
                    if(Royal.Infrastructure.Utils.Native.DeviceHelper.IsIos == false)
            {
                goto label_2;
            }
            
            }
            
            Royal.Infrastructure.Services.AssetDownload.AreaDownloader.CopyAreaFromStreamingAssets(areaId:  1, onlyAreaRequired:  false, isAndroidBundled:  true);
            Royal.Infrastructure.Services.AssetDownload.AreaDownloader.CopyAreaFromStreamingAssets(areaId:  2, onlyAreaRequired:  false, isAndroidBundled:  true);
            Royal.Infrastructure.Services.AssetDownload.AreaDownloader.CopyAreaFromStreamingAssets(areaId:  3, onlyAreaRequired:  false, isAndroidBundled:  true);
            label_2:
            if(Royal.Scenes.Home.Context.Units.AssetBundles.AssetBundleHelper.IsLastAreaBundled() == false)
            {
                    return;
            }
            
            Royal.Infrastructure.Services.AssetDownload.AreaDownloader.CopyAreaFromStreamingAssets(areaId:  28, onlyAreaRequired:  false, isAndroidBundled:  false);
        }
        private void SelectDownloadableAreas()
        {
            var val_14;
            var val_15;
            var val_16;
            val_14 = 0;
            val_15 = (Royal.Scenes.Home.Context.Units.AssetBundles.AssetBundleHelper.IsLastAreaBundled() != true) ? (27 + 1) : 27;
            if((Royal.Infrastructure.Services.AssetDownload.AreaDownloader.GetDownloadedAreaBundles().Contains(item:  Royal.Infrastructure.Services.AssetDownload.AreaDownloader.GetAreaBundleName(areaId:  Royal.Player.Context.Data.Persistent.UserAreaData.__il2cppRuntimeField_name - ((Royal.Player.Context.Data.Persistent.UserAreaData.__il2cppRuntimeField_name / val_4 != true ? (27 + 1) : 27) * val_4 != true ? (27 + 1) : 27)))) != true)
            {
                    this.DownloadArea(areaId:  Royal.Player.Context.Data.Persistent.UserAreaData.__il2cppRuntimeField_name - ((Royal.Player.Context.Data.Persistent.UserAreaData.__il2cppRuntimeField_name / val_4 != true ? (27 + 1) : 27) * val_4 != true ? (27 + 1) : 27), isRequiredForUser:  false, onCompleteCallback:  0);
                val_14 = val_14 + 1;
            }
            
            Royal.Infrastructure.Contexts.Units.App.AppManager val_10 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.App.AppManager>(id:  3);
            System.Action val_11 = static_value_02DC1B30;
            val_11 = new System.Action(object:  this, method:  System.Void Royal.Infrastructure.Services.AssetDownload.AreaDownloadManager::StartDownloadingNewAreas());
            val_10.remove_OnApplicationResume(value:  val_11);
            if( >= 1)
            {
                    System.Action val_12 = static_value_02DC1B30;
                val_12 = new System.Action(object:  this, method:  System.Void Royal.Infrastructure.Services.AssetDownload.AreaDownloadManager::StartDownloadingNewAreas());
                val_10.add_OnApplicationResume(value:  val_12);
                return;
            }
            
            val_16 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_16 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_16 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_16 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  22, log:  "All downloadable areas are already downloaded", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        public void DownloadArea(int areaId, bool isRequiredForUser, System.Action<bool> onCompleteCallback)
        {
            DownloadOperation val_12;
            DownloadOperation val_13;
            string val_14;
            val_13 = onCompleteCallback;
            if(UnityEngine.Application.internetReachability == 0)
            {
                goto label_1;
            }
            
            if(isRequiredForUser == false)
            {
                goto label_2;
            }
            
            if(this.currentDownloadOperation == null)
            {
                goto label_3;
            }
            
            if(this.currentDownloadOperation.areaId != areaId)
            {
                goto label_4;
            }
            
            this.currentDownloadOperation = 1;
            this.currentDownloadOperation = val_13;
            this.StartTimeoutCoroutine();
            val_13 = new object[1];
            val_13[0] = areaId;
            val_14 = "Area {0} (user) callback replaced";
            goto label_26;
            label_1:
            if(val_13 == null)
            {
                    return;
            }
            
            val_13.Invoke(obj:  false);
            return;
            label_2:
            if(this.currentDownloadOperation != null)
            {
                    if(this.currentDownloadOperation.areaId == areaId)
            {
                    return;
            }
            
            }
            
            if((this.IsInDownloadQueue(areaId:  areaId)) == true)
            {
                    return;
            }
            
            if((Royal.Infrastructure.Services.AssetDownload.AreaDownloader.IsAreaAndExtraBundleExistInFileSystem(areaId:  areaId)) == true)
            {
                    return;
            }
            
            AreaDownloadManager.DownloadOperation val_6 = null;
            val_12 = val_6;
            val_6 = new AreaDownloadManager.DownloadOperation();
            .areaId = areaId;
            .isRequiredNow = (Royal.Player.Context.Data.Persistent.UserAreaData.__il2cppRuntimeField_name == areaId) ? 1 : 0;
            .onComplete = val_13;
            System.Collections.Generic.LinkedListNode<T> val_7 = this.areaDownloadQueue.AddLast(value:  val_6);
            val_13 = new object[1];
            val_13[0] = areaId;
            val_14 = "Area {0} (auto) added to end of queue";
            goto label_26;
            label_3:
            if((this.areaDownloadQueue == null) || ((X9 + 16) != areaId))
            {
                goto label_33;
            }
            
            mem2[0] = 1;
            this.areaDownloadQueue = val_13;
            return;
            label_4:
            if(this.areaDownloader != null)
            {
                    this.areaDownloader.Abort();
            }
            
            label_33:
            this.RemoveDownloadOperation(areaId:  areaId);
            AreaDownloadManager.DownloadOperation val_9 = null;
            val_12 = val_9;
            val_9 = new AreaDownloadManager.DownloadOperation();
            .areaId = areaId;
            .isRequiredNow = true;
            .onComplete = val_13;
            System.Collections.Generic.LinkedListNode<T> val_10 = this.areaDownloadQueue.AddFirst(value:  val_9);
            object[] val_11 = new object[1];
            val_13 = val_11;
            val_13[0] = areaId;
            val_14 = "Area {0} (user) added to start of queue";
            label_26:
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  22, log:  val_14, values:  val_11);
        }
        private void RemoveDownloadOperation(int areaId)
        {
            System.Object[] val_3;
            do
            {
                if(1577 == 0)
            {
                    return;
            }
            
                System.Collections.Generic.LinkedListNode<T> val_1 = 1577.Next;
            }
            while((mem[-1729382237381591018]) != areaId);
            
            this.areaDownloadQueue.Remove(node:  1577);
            object[] val_2 = new object[1];
            val_3 = val_2;
            val_3[0] = areaId;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  22, log:  "Area {0} is removed from queue", values:  val_2);
        }
        private bool IsInDownloadQueue(int areaId)
        {
            var val_2;
            if(1575 == 0)
            {
                    return (bool)val_2;
            }
            
            label_5:
            if(mem[1279831535160080] == areaId)
            {
                goto label_4;
            }
            
            if(1575.Next != null)
            {
                goto label_5;
            }
            
            return (bool)val_2;
            label_4:
            val_2 = 1;
            return (bool)val_2;
        }
        private void DownloadAreaToLocal()
        {
            if(this.currentDownloadOperation.isRequiredNow != false)
            {
                    this.StartTimeoutCoroutine();
            }
            
            if(this.areaDownloader == null)
            {
                    this.areaDownloader = new Royal.Infrastructure.Services.AssetDownload.AreaDownloader(manager:  this);
            }
            
            object[] val_2 = new object[1];
            val_2[0] = this.currentDownloadOperation.areaId;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  22, log:  "Area {0} download started", values:  val_2);
            this.areaDownloader.Download(areaId:  this.currentDownloadOperation.areaId);
        }
        public void AreaAndExtraFilesSaved(bool success)
        {
            System.Object[] val_3;
            DownloadOperation val_4;
            var val_5;
            var val_6;
            this.StopTimeoutCoroutine();
            val_4 = this.currentDownloadOperation;
            if(val_4 == null)
            {
                    return;
            }
            
            if(success == false)
            {
                goto label_2;
            }
            
            if(this.OnAssetBundleDownloaded != null)
            {
                    this.OnAssetBundleDownloaded.Invoke(obj:  this.currentDownloadOperation.areaId);
                val_4 = this.currentDownloadOperation;
            }
            
            if(this.currentDownloadOperation.onComplete == null)
            {
                goto label_7;
            }
            
            val_5 = 1152921511197556976;
            val_6 = 1;
            goto label_6;
            label_2:
            if(this.currentDownloadOperation.onComplete == null)
            {
                goto label_7;
            }
            
            val_5 = 1152921511197556976;
            val_6 = 0;
            label_6:
            this.currentDownloadOperation.onComplete.Invoke(obj:  false);
            label_7:
            object[] val_1 = new object[2];
            val_3 = val_1;
            val_3[0] = this.currentDownloadOperation.areaId;
            val_3[1] = success;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  22, log:  "Area {0} download finished with success: {1}", values:  val_1);
            this.currentDownloadOperation = 0;
        }
        private void StartTimeoutCoroutine()
        {
            this.StopTimeoutCoroutine();
            this.timeoutCoroutine = Royal.Scenes.Start.Context.ApplicationContext.ManualStartCoroutine(iEnumerator:  this.TimeoutForUser());
        }
        private void StopTimeoutCoroutine()
        {
            if(this.timeoutCoroutine == null)
            {
                    return;
            }
            
            Royal.Scenes.Start.Context.ApplicationContext.ManualStopCoroutine(iEnumerator:  this.timeoutCoroutine);
            this.timeoutCoroutine = 0;
        }
        private System.Collections.IEnumerator TimeoutForUser()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new AreaDownloadManager.<TimeoutForUser>d__23();
        }
        public static bool IsAreaAndExtraBundleExistInFileSystem(int areaId)
        {
            return Royal.Infrastructure.Services.AssetDownload.AreaDownloader.IsAreaAndExtraBundleExistInFileSystem(areaId:  areaId);
        }
        public static string GetPersistentBundlePath(string bundleName, bool isAndroidBundled = False)
        {
            isAndroidBundled = isAndroidBundled;
            return Royal.Infrastructure.Services.AssetDownload.AreaDownloader.GetPersistentBundlePath(bundleName:  bundleName, isAndroidBundled:  isAndroidBundled);
        }
        public static string GetAreaBundleName(int areaId)
        {
            return Royal.Infrastructure.Services.AssetDownload.AreaDownloader.GetAreaBundleName(areaId:  areaId);
        }
        public static string GetExtraBundleName(int areaId)
        {
            return Royal.Infrastructure.Services.AssetDownload.AreaDownloader.GetExtraBundleName(areaId:  areaId);
        }
        public AreaDownloadManager()
        {
            this.areaDownloadQueue = new System.Collections.Generic.LinkedList<DownloadOperation>();
        }
    
    }

}
