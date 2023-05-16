using UnityEngine;

namespace Royal.Scenes.Start.Context.Units.FeatureBundle
{
    public class BookOfTreasureBundle : AFeatureBundle
    {
        // Fields
        private UnityEngine.AssetBundle assetBundle;
        private UnityEngine.GameObject <AnimationPrefab>k__BackingField;
        
        // Properties
        public override Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleType BundleType { get; }
        public override string BundleName { get; }
        public UnityEngine.GameObject AnimationPrefab { get; set; }
        
        // Methods
        public override Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleType get_BundleType()
        {
            return 1;
        }
        public override string get_BundleName()
        {
            return "bookoftreasure.ab";
        }
        public UnityEngine.GameObject get_AnimationPrefab()
        {
            return (UnityEngine.GameObject)this.<AnimationPrefab>k__BackingField;
        }
        private void set_AnimationPrefab(UnityEngine.GameObject value)
        {
            this.<AnimationPrefab>k__BackingField = value;
        }
        public override void LoadBundle()
        {
            if(this.assetBundle != 0)
            {
                    return;
            }
            
            if(this.IsBundleDownloaded == false)
            {
                    return;
            }
            
            UnityEngine.AssetBundle val_4 = UnityEngine.AssetBundle.LoadFromFile(path:  this.GetPersistentPath());
            this.assetBundle = val_4;
            this.<AnimationPrefab>k__BackingField = val_4.LoadAsset<UnityEngine.GameObject>(name:  "BookOfTreasureBundleAnimation");
        }
        public override void UnloadBundle(bool unloadAllLoadedObjects = True)
        {
            this.<AnimationPrefab>k__BackingField = 0;
            this.assetBundle.Unload(unloadAllLoadedObjects:  unloadAllLoadedObjects);
            this.assetBundle = 0;
        }
        public override bool ShouldQueueForDownload()
        {
            return (bool)(typeof(Royal.Player.Context.Data.Persistent.BasicUserData).__il2cppRuntimeField_14 > 22) ? 1 : 0;
        }
        public static string GetBundleName()
        {
            return "bookoftreasure.ab";
        }
        public BookOfTreasureBundle()
        {
            this = new System.Object();
        }
    
    }

}
