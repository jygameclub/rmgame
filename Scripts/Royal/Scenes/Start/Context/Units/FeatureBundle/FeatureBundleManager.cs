using UnityEngine;

namespace Royal.Scenes.Start.Context.Units.FeatureBundle
{
    public class FeatureBundleManager : IContextUnit
    {
        // Fields
        private readonly System.Collections.Generic.Dictionary<Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleType, Royal.Scenes.Start.Context.Units.FeatureBundle.AFeatureBundle> featureBundles;
        private readonly System.Collections.Generic.List<Royal.Scenes.Start.Context.Units.FeatureBundle.AFeatureBundle> downloads;
        private Royal.Scenes.Start.Context.Units.FeatureBundle.AFeatureBundle currentDownload;
        private bool isAllDownloaded;
        private Royal.Infrastructure.Contexts.Units.App.AppManager appManager;
        private Royal.Scenes.Home.Context.HomeContext homeContext;
        
        // Properties
        public int Id { get; }
        
        // Methods
        public int get_Id()
        {
            return 25;
        }
        public void Bind()
        {
            var val_6;
            var val_7;
            val_6 = null;
            val_6 = null;
            if((System.IO.Directory.Exists(path:  Royal.Scenes.Start.Context.Units.FeatureBundle.AFeatureBundle.FeatureDownloadUrl)) != true)
            {
                    val_7 = null;
                val_7 = null;
                System.IO.DirectoryInfo val_2 = System.IO.Directory.CreateDirectory(path:  Royal.Scenes.Start.Context.Units.FeatureBundle.AFeatureBundle.FeatureDownloadUrl);
            }
            
            this.AddBundle(bundleType:  3, featureBundle:  new Royal.Scenes.Start.Context.Units.FeatureBundle.KingDrillBundle());
            this.AddBundle(bundleType:  4, featureBundle:  new Royal.Scenes.Start.Context.Units.FeatureBundle.RoyalPassBundle());
            this.AddBundle(bundleType:  5, featureBundle:  new Royal.Scenes.Start.Context.Units.FeatureBundle.RoyalLeagueBundle());
            this.RegisterEvents();
        }
        private void RegisterEvents()
        {
            Royal.Infrastructure.Contexts.Units.App.AppManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.App.AppManager>(id:  3);
            this.appManager = val_1;
            val_1.remove_OnApplicationStart(value:  new System.Action(object:  this, method:  public System.Void Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleManager::QueueAndStartDownload()));
            this.appManager.add_OnApplicationStart(value:  new System.Action(object:  this, method:  public System.Void Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleManager::QueueAndStartDownload()));
            Royal.Scenes.Home.Context.HomeContext val_4 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Home.Context.HomeContext>(id:  10);
            this.homeContext = val_4;
            val_4.remove_OnActivate(value:  new System.Action(object:  this, method:  public System.Void Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleManager::QueueAndStartDownload()));
            this.homeContext.add_OnActivate(value:  new System.Action(object:  this, method:  public System.Void Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleManager::QueueAndStartDownload()));
        }
        private void DeregisterEvents()
        {
            Royal.Infrastructure.Contexts.Units.App.AppManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.App.AppManager>(id:  3);
            this.appManager = val_1;
            val_1.remove_OnApplicationStart(value:  new System.Action(object:  this, method:  public System.Void Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleManager::QueueAndStartDownload()));
            Royal.Scenes.Home.Context.HomeContext val_3 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Home.Context.HomeContext>(id:  10);
            this.homeContext = val_3;
            val_3.remove_OnActivate(value:  new System.Action(object:  this, method:  public System.Void Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleManager::QueueAndStartDownload()));
        }
        public void QueueAndStartDownload()
        {
            Royal.Scenes.Start.Context.Units.FeatureBundle.AFeatureBundle val_3;
            var val_4;
            System.Collections.Generic.Dictionary<Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleType, Royal.Scenes.Start.Context.Units.FeatureBundle.AFeatureBundle> val_8;
            var val_9;
            val_8 = this.featureBundles;
            if(val_8 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_9 = public Dictionary.ValueCollection<TKey, TValue> System.Collections.Generic.Dictionary<Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleType, Royal.Scenes.Start.Context.Units.FeatureBundle.AFeatureBundle>::get_Values();
            Dictionary.ValueCollection<TKey, TValue> val_1 = val_8.Values;
            if(val_1 == null)
            {
                    throw new NullReferenceException();
            }
            
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_2 = val_1.GetEnumerator();
            label_12:
            val_9 = public System.Boolean Dictionary.ValueCollection.Enumerator<Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleType, Royal.Scenes.Start.Context.Units.FeatureBundle.AFeatureBundle>::MoveNext();
            if((1433295152 & 1) == 0)
            {
                goto label_3;
            }
            
            if(val_3 == 0)
            {
                    throw new NullReferenceException();
            }
            
            if(val_3.IsBundleDownloaded == true)
            {
                goto label_12;
            }
            
            if((val_3 + 24) != 0)
            {
                    if((val_3 + 24 + 32) != 0)
            {
                goto label_12;
            }
            
            }
            
            val_9 = mem[val_3 + 432 + 8];
            val_9 = val_3 + 432 + 8;
            if((val_3 & 1) == 0)
            {
                goto label_12;
            }
            
            val_8 = this.downloads;
            if(val_8 == null)
            {
                    throw new NullReferenceException();
            }
            
            if((val_8.Contains(item:  val_3)) == true)
            {
                goto label_12;
            }
            
            this.downloads.Add(item:  val_3);
            goto label_12;
            label_3:
            val_4.Dispose();
            if(this.currentDownload != null)
            {
                    return;
            }
            
            this.DownloadNextBundle();
            this.CheckIfAllDownloaded();
        }
        private void CheckIfAllDownloaded()
        {
            var val_4;
            bool val_5;
            if(this.isAllDownloaded == true)
            {
                    return;
            }
            
            if(this.currentDownload != null)
            {
                    return;
            }
            
            if(this.downloads != null)
            {
                    return;
            }
            
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_2 = this.featureBundles.Values.GetEnumerator();
            val_4 = 1152921518925015728;
            label_9:
            if((1433444056 & 1) == 0)
            {
                goto label_7;
            }
            
            if(0 == 0)
            {
                    throw new NullReferenceException();
            }
            
            if(0.IsBundleDownloaded == true)
            {
                goto label_9;
            }
            
            val_5 = 0;
            goto label_10;
            label_7:
            val_5 = true;
            label_10:
            0.Dispose();
            this.isAllDownloaded = val_5;
            if(val_5 == 0)
            {
                    return;
            }
            
            this.DeregisterEvents();
        }
        public void AddBundle(Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleType bundleType, Royal.Scenes.Start.Context.Units.FeatureBundle.AFeatureBundle featureBundle)
        {
            if((bundleType != 0) && ((this.featureBundles.ContainsKey(key:  bundleType)) != true))
            {
                    this.featureBundles.Add(key:  bundleType, value:  featureBundle);
                return;
            }
            
            object[] val_2 = new object[1];
            val_2[0] = bundleType;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  22, log:  "Feature Bundle is already added: {0}", values:  val_2);
        }
        private void DownloadNextBundle()
        {
            System.Collections.Generic.List<Royal.Scenes.Start.Context.Units.FeatureBundle.AFeatureBundle> val_2;
            if(true < 1)
            {
                    return;
            }
            
            this.isAllDownloaded = false;
            val_2 = this.downloads;
            if(true == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_2 = this.downloads;
            }
            
            this.currentDownload = 0;
            val_2.RemoveAt(index:  0);
            this.currentDownload.StartDownload(onComplete:  new System.Action<Royal.Scenes.Start.Context.Units.FeatureBundle.AFeatureBundle>(object:  this, method:  System.Void Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleManager::DownloadComplete(Royal.Scenes.Start.Context.Units.FeatureBundle.AFeatureBundle bundle)));
        }
        private void DownloadComplete(Royal.Scenes.Start.Context.Units.FeatureBundle.AFeatureBundle bundle)
        {
            this.currentDownload = 0;
            this.DownloadNextBundle();
        }
        public Royal.Scenes.Start.Context.Units.FeatureBundle.AFeatureBundle GetBundle(Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleType bundleType)
        {
            var val_3;
            if((this.featureBundles.ContainsKey(key:  bundleType)) != false)
            {
                    Royal.Scenes.Start.Context.Units.FeatureBundle.AFeatureBundle val_2 = this.featureBundles.Item[bundleType];
                return (Royal.Scenes.Start.Context.Units.FeatureBundle.AFeatureBundle)val_3;
            }
            
            val_3 = 0;
            return (Royal.Scenes.Start.Context.Units.FeatureBundle.AFeatureBundle)val_3;
        }
        public void PrioritizeBundleDownload(Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleType bundleType)
        {
            Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleType val_7;
            var val_8;
            val_7 = bundleType;
            FeatureBundleManager.<>c__DisplayClass17_0 val_1 = null;
            val_8 = 0;
            val_1 = new FeatureBundleManager.<>c__DisplayClass17_0();
            .bundleType = val_7;
            if(val_7 == 0)
            {
                    return;
            }
            
            if(this.currentDownload != null)
            {
                    val_7 = (FeatureBundleManager.<>c__DisplayClass17_0)[1152921518926025648].bundleType;
                if(this.currentDownload == val_7)
            {
                    return;
            }
            
            }
            
            if(this.currentDownload == ((FeatureBundleManager.<>c__DisplayClass17_0)[1152921518926025648].bundleType))
            {
                    return;
            }
            
            Royal.Scenes.Start.Context.Units.FeatureBundle.AFeatureBundle val_3 = System.Linq.Enumerable.FirstOrDefault<Royal.Scenes.Start.Context.Units.FeatureBundle.AFeatureBundle>(source:  this.downloads, predicate:  new System.Func<Royal.Scenes.Start.Context.Units.FeatureBundle.AFeatureBundle, System.Boolean>(object:  val_1, method:  System.Boolean FeatureBundleManager.<>c__DisplayClass17_0::<PrioritizeBundleDownload>b__0(Royal.Scenes.Start.Context.Units.FeatureBundle.AFeatureBundle t)));
            if(val_3 != null)
            {
                    bool val_4 = this.downloads.Remove(item:  val_3);
                this.downloads.Insert(index:  0, item:  val_3);
                object[] val_5 = new object[1];
                val_7 = val_5;
                val_7[0] = (FeatureBundleManager.<>c__DisplayClass17_0)[1152921518926025648].bundleType;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  22, log:  "Bundle prioritized: {0}", values:  val_5);
                return;
            }
            
            val_7 = (FeatureBundleManager.<>c__DisplayClass17_0)[1152921518926025648].bundleType;
            Royal.Scenes.Start.Context.Units.FeatureBundle.AFeatureBundle val_6 = this.GetBundle(bundleType:  val_7);
            if((val_6 & 1) == 0)
            {
                    return;
            }
            
            this.downloads.Insert(index:  0, item:  val_6);
            if(this.currentDownload != null)
            {
                    return;
            }
            
            this.DownloadNextBundle();
        }
        public bool LoadBundle(Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleType bundleType)
        {
            System.Object[] val_6;
            var val_7;
            if(bundleType != 0)
            {
                    val_6 = this.GetBundle(bundleType:  bundleType);
                if((val_1.fileDownloader != null) && ((val_1.fileDownloader.<IsDownloading>k__BackingField) != false))
            {
                    object[] val_2 = new object[1];
                val_6 = val_2;
                val_6[0] = bundleType;
                Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  22, log:  "Can\'t load bundle because downloading: {0}", values:  val_2);
            }
            else
            {
                    if(val_6.IsBundleDownloaded != false)
            {
                    val_7 = 1;
                return (bool)val_7;
            }
            
                object[] val_4 = new object[1];
                val_6 = val_4;
                val_6[0] = bundleType;
                Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  22, log:  "Can\'t load bundle because not downloaded: {0}", values:  val_4);
                this.PrioritizeBundleDownload(bundleType:  bundleType);
            }
            
            }
            
            val_7 = 0;
            return (bool)val_7;
        }
        public bool IsDownloaded(Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleType bundleType)
        {
            if(bundleType == 0)
            {
                    return false;
            }
            
            return this.GetBundle(bundleType:  bundleType).IsBundleDownloaded;
        }
        public void UnloadBundle(Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleType bundleType)
        {
            if(bundleType == 0)
            {
                    return;
            }
            
            if((this.GetBundle(bundleType:  bundleType)) == null)
            {
                    return;
            }
            
            goto typeof(Royal.Scenes.Start.Context.Units.FeatureBundle.AFeatureBundle).__il2cppRuntimeField_1A0;
        }
        public FeatureBundleManager()
        {
            this.featureBundles = new System.Collections.Generic.Dictionary<Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleType, Royal.Scenes.Start.Context.Units.FeatureBundle.AFeatureBundle>();
            this.downloads = new System.Collections.Generic.List<Royal.Scenes.Start.Context.Units.FeatureBundle.AFeatureBundle>();
        }
    
    }

}
