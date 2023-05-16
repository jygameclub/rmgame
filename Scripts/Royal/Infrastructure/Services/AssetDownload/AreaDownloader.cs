using UnityEngine;

namespace Royal.Infrastructure.Services.AssetDownload
{
    public class AreaDownloader
    {
        // Fields
        private const string AreaDownloadUrl = "http://cdn.royal.drmgms.com/prod/asset-bundles/area/android/";
        private const string AreaPrefix = "area";
        private const string ExtraPrefix = "extra";
        private const string BundleSuffix = ".ab";
        private const string VersionPrefix = "_v";
        private static readonly string AreaAssetBundlesDirectory;
        private readonly Royal.Infrastructure.Services.AssetDownload.AreaDownloadManager manager;
        private readonly Royal.Infrastructure.Services.AssetDownload.FileDownloader areaDownloader;
        private readonly Royal.Infrastructure.Services.AssetDownload.FileDownloader extraDownloader;
        
        // Properties
        public bool IsDownloading { get; }
        public bool IsSuccess { get; }
        
        // Methods
        public AreaDownloader(Royal.Infrastructure.Services.AssetDownload.AreaDownloadManager manager)
        {
            this.manager = manager;
            this.areaDownloader = new Royal.Infrastructure.Services.AssetDownload.FileDownloader();
            this.extraDownloader = new Royal.Infrastructure.Services.AssetDownload.FileDownloader();
        }
        public bool get_IsDownloading()
        {
            var val_2;
            if((this.areaDownloader.<IsDownloading>k__BackingField) == false)
            {
                    return (bool)((this.extraDownloader.<IsDownloading>k__BackingField) == true) ? 1 : 0;
            }
            
            val_2 = 1;
            return (bool)((this.extraDownloader.<IsDownloading>k__BackingField) == true) ? 1 : 0;
        }
        public bool get_IsSuccess()
        {
            var val_2;
            if((this.areaDownloader.<IsSuccess>k__BackingField) != false)
            {
                    var val_1 = ((this.extraDownloader.<IsSuccess>k__BackingField) == true) ? 1 : 0;
                return (bool)val_2;
            }
            
            val_2 = 0;
            return (bool)val_2;
        }
        public void Abort()
        {
            if(this.areaDownloader.httpRequest != null)
            {
                    this.areaDownloader.httpRequest.Abort();
            }
            
            if(this.extraDownloader.httpRequest == null)
            {
                    return;
            }
            
            this.extraDownloader.httpRequest.Abort();
        }
        public void Download(int areaId)
        {
            var val_9;
            var val_10;
            string val_1 = Royal.Infrastructure.Services.AssetDownload.AreaDownloader.GetAreaBundleName(areaId:  areaId);
            if((Royal.Infrastructure.Services.AssetDownload.AreaDownloader.IsBundleExistInFileSystem(bundleName:  val_1, isAndroidBundled:  false)) != false)
            {
                    this.areaDownloader = 0;
                this.areaDownloader = 256;
            }
            else
            {
                    val_9 = null;
                val_9 = null;
                this.areaDownloader.Download(fileName:  val_1, url:  "http://cdn.royal.drmgms.com/prod/asset-bundles/area/android/"("http://cdn.royal.drmgms.com/prod/asset-bundles/area/android/") + val_1, saveDirectory:  Royal.Infrastructure.Services.AssetDownload.AreaDownloader.AreaAssetBundlesDirectory, onSaveComplete:  new System.Action<System.Boolean>(object:  this, method:  System.Void Royal.Infrastructure.Services.AssetDownload.AreaDownloader::OnFileSaveCompleted(bool downloaded)));
            }
            
            string val_5 = Royal.Infrastructure.Services.AssetDownload.AreaDownloader.GetExtraBundleName(areaId:  areaId);
            if((Royal.Infrastructure.Services.AssetDownload.AreaDownloader.IsBundleExistInFileSystem(bundleName:  val_5, isAndroidBundled:  false)) != false)
            {
                    this.extraDownloader = 0;
                this.extraDownloader = 256;
                return;
            }
            
            val_10 = null;
            val_10 = null;
            this.extraDownloader.Download(fileName:  val_5, url:  "http://cdn.royal.drmgms.com/prod/asset-bundles/area/android/"("http://cdn.royal.drmgms.com/prod/asset-bundles/area/android/") + val_5, saveDirectory:  Royal.Infrastructure.Services.AssetDownload.AreaDownloader.AreaAssetBundlesDirectory, onSaveComplete:  new System.Action<System.Boolean>(object:  this, method:  System.Void Royal.Infrastructure.Services.AssetDownload.AreaDownloader::OnFileSaveCompleted(bool downloaded)));
        }
        private void OnFileSaveCompleted(bool downloaded)
        {
            if(this.IsDownloading != false)
            {
                    return;
            }
            
            this.manager.AreaAndExtraFilesSaved(success:  this.IsSuccess);
        }
        public static void CreateDirectory()
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            if((System.IO.Directory.Exists(path:  Royal.Infrastructure.Services.AssetDownload.AreaDownloader.AreaAssetBundlesDirectory)) != false)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            System.IO.DirectoryInfo val_2 = System.IO.Directory.CreateDirectory(path:  Royal.Infrastructure.Services.AssetDownload.AreaDownloader.AreaAssetBundlesDirectory);
        }
        private static bool IsBundleExistInFileSystem(string bundleName, bool isAndroidBundled = False)
        {
            isAndroidBundled = isAndroidBundled;
            return System.IO.File.Exists(path:  Royal.Infrastructure.Services.AssetDownload.AreaDownloader.GetPersistentBundlePath(bundleName:  bundleName, isAndroidBundled:  isAndroidBundled));
        }
        public static System.Collections.Generic.HashSet<string> GetDownloadedAreaBundles()
        {
            System.String[] val_1 = Royal.Infrastructure.Services.AssetDownload.AreaDownloader.GetFilesInAssetBundlesFolder();
            System.Collections.Generic.HashSet<System.String> val_2 = new System.Collections.Generic.HashSet<System.String>();
            if(val_1.Length < 1)
            {
                    return val_2;
            }
            
            var val_7 = 0;
            do
            {
                string val_6 = val_1[val_7];
                if((val_6.StartsWith(value:  "area")) != false)
            {
                    if((Royal.Infrastructure.Services.AssetDownload.AreaDownloader.HasExtraBundleOfAreaFile(areaFileName:  val_6, downloadedFiles:  val_1)) != false)
            {
                    bool val_5 = val_2.Add(item:  val_6);
            }
            
            }
            
                val_7 = val_7 + 1;
            }
            while(val_7 < val_1.Length);
            
            return val_2;
        }
        private static bool HasExtraBundleOfAreaFile(string areaFileName, string[] downloadedFiles)
        {
            string val_2 = areaFileName.Replace(oldValue:  "area", newValue:  "extra");
            .extraFileName = val_2;
            int val_3 = val_2.IndexOf(value:  "_v", comparisonType:  4);
            if((val_3 & 2147483648) != 0)
            {
                    return System.Linq.Enumerable.Any<System.String>(source:  downloadedFiles, predicate:  new System.Func<System.String, System.Boolean>(object:  new AreaDownloader.<>c__DisplayClass20_0(), method:  System.Boolean AreaDownloader.<>c__DisplayClass20_0::<HasExtraBundleOfAreaFile>b__0(string t)));
            }
            
            .extraFileName = (AreaDownloader.<>c__DisplayClass20_0)[1152921528672410960].extraFileName.Substring(startIndex:  0, length:  val_3);
            return System.Linq.Enumerable.Any<System.String>(source:  downloadedFiles, predicate:  new System.Func<System.String, System.Boolean>(object:  new AreaDownloader.<>c__DisplayClass20_0(), method:  System.Boolean AreaDownloader.<>c__DisplayClass20_0::<HasExtraBundleOfAreaFile>b__0(string t)));
        }
        private static string[] GetFilesInAssetBundlesFolder()
        {
            null = null;
            string[] val_3 = new string[0];
            if(val_2.Length < 1)
            {
                    return (System.String[])val_3;
            }
            
            var val_4 = 0;
            do
            {
                mem2[0] = 1152921505485126928;
                val_4 = val_4 + 1;
            }
            while(val_4 < val_2.Length);
            
            return (System.String[])val_3;
        }
        public static bool IsAreaAndExtraBundleExistInFileSystem(int areaId)
        {
            bool val_1 = Royal.Scenes.Home.Context.Units.AssetBundles.AssetBundleHelper.IsAndroidBundled(areaId:  areaId);
            if((Royal.Infrastructure.Services.AssetDownload.AreaDownloader.IsBundleExistInFileSystem(bundleName:  Royal.Infrastructure.Services.AssetDownload.AreaDownloader.GetAreaBundleName(areaId:  areaId), isAndroidBundled:  val_1)) == false)
            {
                    return false;
            }
            
            return Royal.Infrastructure.Services.AssetDownload.AreaDownloader.IsBundleExistInFileSystem(bundleName:  Royal.Infrastructure.Services.AssetDownload.AreaDownloader.GetExtraBundleName(areaId:  areaId), isAndroidBundled:  val_1);
        }
        public static string GetPersistentBundlePath(string bundleName, bool isAndroidBundled = False)
        {
            string val_3;
            var val_4;
            val_3 = bundleName;
            if(((val_3.EndsWith(value:  ".ab")) != true) && (isAndroidBundled != true))
            {
                    val_3 = val_3 + ".ab";
            }
            
            val_4 = null;
            val_4 = null;
            return System.IO.Path.Combine(path1:  Royal.Infrastructure.Services.AssetDownload.AreaDownloader.AreaAssetBundlesDirectory, path2:  val_3);
        }
        public static string GetAreaBundleName(int areaId)
        {
            var val_6;
            object val_7;
            if(areaId < 10)
            {
                    val_6 = "0";
            }
            
            val_7 = "area" + System.String.__il2cppRuntimeField_static_fields + areaId;
            if((areaId != 13) && (areaId != 16))
            {
                    if((areaId - 21) >= 3)
            {
                goto label_7;
            }
            
            }
            
            val_7 = val_7 + "_v" + 2;
            label_7:
            if((Royal.Scenes.Home.Context.Units.AssetBundles.AssetBundleHelper.IsAndroidBundled(areaId:  areaId)) == true)
            {
                    return (string)val_7;
            }
            
            val_7 = val_7 + ".ab";
            return (string)val_7;
        }
        private static int GetVersion(int areaId)
        {
            if(areaId == 13)
            {
                    return 2;
            }
            
            if(areaId != 16)
            {
                    return (int)((areaId - 21) < 3) ? (1 + 1) : 1;
            }
            
            return 2;
        }
        public static string GetExtraBundleName(int areaId)
        {
            var val_4;
            string val_5;
            if(areaId < 10)
            {
                    val_4 = "0";
            }
            
            val_5 = "extra" + System.String.__il2cppRuntimeField_static_fields + areaId;
            if((Royal.Scenes.Home.Context.Units.AssetBundles.AssetBundleHelper.IsAndroidBundled(areaId:  areaId)) == true)
            {
                    return (string)val_5;
            }
            
            val_5 = val_5 + ".ab";
            return (string)val_5;
        }
        public static void CopyAreaFromStreamingAssets(int areaId, bool onlyAreaRequired = False, bool isAndroidBundled = False)
        {
            string val_1 = Royal.Infrastructure.Services.AssetDownload.AreaDownloader.GetAreaBundleName(areaId:  areaId);
            Royal.Infrastructure.Services.AssetDownload.FileDownloader.CopyFileFromStreamingAssetsDir(fileName:  val_1, destinationPath:  Royal.Infrastructure.Services.AssetDownload.AreaDownloader.GetPersistentBundlePath(bundleName:  val_1, isAndroidBundled:  isAndroidBundled));
            if(onlyAreaRequired != false)
            {
                    return;
            }
            
            string val_4 = Royal.Infrastructure.Services.AssetDownload.AreaDownloader.GetExtraBundleName(areaId:  areaId);
            Royal.Infrastructure.Services.AssetDownload.FileDownloader.CopyFileFromStreamingAssetsDir(fileName:  val_4, destinationPath:  Royal.Infrastructure.Services.AssetDownload.AreaDownloader.GetPersistentBundlePath(bundleName:  val_4, isAndroidBundled:  isAndroidBundled));
        }
        private static AreaDownloader()
        {
            Royal.Infrastructure.Services.AssetDownload.AreaDownloader.AreaAssetBundlesDirectory = System.IO.Path.Combine(path1:  UnityEngine.Application.persistentDataPath, path2:  "AssetBundles/Areas");
        }
    
    }

}
