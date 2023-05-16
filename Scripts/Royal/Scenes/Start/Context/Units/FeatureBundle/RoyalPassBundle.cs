using UnityEngine;

namespace Royal.Scenes.Start.Context.Units.FeatureBundle
{
    public class RoyalPassBundle : AFeatureBundle
    {
        // Fields
        private UnityEngine.AssetBundle assetBundle;
        private UnityEngine.GameObject safeClaimPrefab;
        private UnityEngine.GameObject royalPassPurchaseBundledPrefab;
        private UnityEngine.GameObject royalPassPurchaseSuccessBundledPrefab;
        private UnityEngine.GameObject royalPassStartedBundledPrefab;
        
        // Properties
        public UnityEngine.GameObject SafeClaimPrefab { get; }
        public UnityEngine.GameObject RoyalPassPurchaseBundledPrefab { get; }
        public UnityEngine.GameObject RoyalPassPurchaseSuccessBundledPrefab { get; }
        public UnityEngine.GameObject RoyalPassStartedBundledPrefab { get; }
        public override Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleType BundleType { get; }
        public override string BundleName { get; }
        
        // Methods
        public UnityEngine.GameObject get_SafeClaimPrefab()
        {
            if(this.safeClaimPrefab != 0)
            {
                    return (UnityEngine.GameObject)this.safeClaimPrefab;
            }
            
            if(this.assetBundle == 0)
            {
                    return (UnityEngine.GameObject)this.safeClaimPrefab;
            }
            
            this.safeClaimPrefab = this.assetBundle.LoadAsset<UnityEngine.GameObject>(name:  "RoyalPassSafeBundledPrefab");
            return (UnityEngine.GameObject)this.safeClaimPrefab;
        }
        public UnityEngine.GameObject get_RoyalPassPurchaseBundledPrefab()
        {
            if(this.royalPassPurchaseBundledPrefab != 0)
            {
                    return (UnityEngine.GameObject)this.royalPassPurchaseBundledPrefab;
            }
            
            if(this.assetBundle == 0)
            {
                    return (UnityEngine.GameObject)this.royalPassPurchaseBundledPrefab;
            }
            
            this.royalPassPurchaseBundledPrefab = this.assetBundle.LoadAsset<UnityEngine.GameObject>(name:  "RoyalPassPurchaseBundledPrefab");
            return (UnityEngine.GameObject)this.royalPassPurchaseBundledPrefab;
        }
        public UnityEngine.GameObject get_RoyalPassPurchaseSuccessBundledPrefab()
        {
            if(this.royalPassPurchaseSuccessBundledPrefab != 0)
            {
                    return (UnityEngine.GameObject)this.royalPassPurchaseSuccessBundledPrefab;
            }
            
            if(this.assetBundle == 0)
            {
                    return (UnityEngine.GameObject)this.royalPassPurchaseSuccessBundledPrefab;
            }
            
            this.royalPassPurchaseSuccessBundledPrefab = this.assetBundle.LoadAsset<UnityEngine.GameObject>(name:  "RoyalPassPurchaseSuccessBundledPrefab");
            return (UnityEngine.GameObject)this.royalPassPurchaseSuccessBundledPrefab;
        }
        public UnityEngine.GameObject get_RoyalPassStartedBundledPrefab()
        {
            if(this.royalPassStartedBundledPrefab != 0)
            {
                    return (UnityEngine.GameObject)this.royalPassStartedBundledPrefab;
            }
            
            if(this.assetBundle == 0)
            {
                    return (UnityEngine.GameObject)this.royalPassStartedBundledPrefab;
            }
            
            this.royalPassStartedBundledPrefab = this.assetBundle.LoadAsset<UnityEngine.GameObject>(name:  "RoyalPassStartedBundledPrefab");
            return (UnityEngine.GameObject)this.royalPassStartedBundledPrefab;
        }
        public override Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleType get_BundleType()
        {
            return 4;
        }
        public override string get_BundleName()
        {
            return "royalpass";
        }
        public override void LoadBundle()
        {
            string val_8;
            var val_9;
            var val_10;
            bool val_1 = UnityEngine.Object.op_Inequality(x:  this.assetBundle, y:  0);
            if(val_1 == true)
            {
                    return;
            }
            
            UnityEngine.AssetBundle val_2 = val_1.LoadAssetBundle();
            if(val_2 == 0)
            {
                    val_8 = "";
            }
            else
            {
                    val_8 = val_2.name;
            }
            
            if(val_2 == 0)
            {
                    return;
            }
            
            if((val_8.Equals(value:  val_8)) == false)
            {
                    return;
            }
            
            this.assetBundle = val_2;
            if(val_2 == 0)
            {
                    val_9 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_9 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                val_9 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_9 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  22, log:  "RoyalPass asset bundle is missing", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            }
            
            val_10 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_10 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_10 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_10 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  22, log:  "RoyalPass asset bundle is loaded", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        private UnityEngine.AssetBundle LoadAssetBundle()
        {
            return Royal.Scenes.Start.Context.Units.FeatureBundle.AFeatureBundle.LoadBundleFromGooglePlay(name:  "royalpass");
        }
        public override void UnloadBundle(bool unloadAllLoadedObjects = True)
        {
            this.safeClaimPrefab = 0;
            if(this.assetBundle != 0)
            {
                    this.assetBundle.Unload(unloadAllLoadedObjects:  unloadAllLoadedObjects);
            }
            
            this.assetBundle = 0;
        }
        public override bool ShouldQueueForDownload()
        {
            return false;
        }
        public static string GetBundleName()
        {
            return "royalpass";
        }
        public RoyalPassBundle()
        {
            this = new System.Object();
        }
    
    }

}
