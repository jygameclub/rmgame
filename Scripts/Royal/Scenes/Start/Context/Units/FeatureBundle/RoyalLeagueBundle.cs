using UnityEngine;

namespace Royal.Scenes.Start.Context.Units.FeatureBundle
{
    public class RoyalLeagueBundle : AFeatureBundle
    {
        // Fields
        private UnityEngine.AssetBundle assetBundle;
        private UnityEngine.GameObject enterLeaguePopupBundledPrefab;
        private UnityEngine.GameObject leagueAreaBundledPrefab;
        
        // Properties
        public UnityEngine.GameObject EnterLeaguePopupBundledPrefab { get; }
        public UnityEngine.GameObject LeagueAreaBundledPrefab { get; }
        public override Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleType BundleType { get; }
        public override string BundleName { get; }
        
        // Methods
        public UnityEngine.GameObject get_EnterLeaguePopupBundledPrefab()
        {
            if(this.enterLeaguePopupBundledPrefab != 0)
            {
                    return (UnityEngine.GameObject)this.enterLeaguePopupBundledPrefab;
            }
            
            if(this.assetBundle == 0)
            {
                    return (UnityEngine.GameObject)this.enterLeaguePopupBundledPrefab;
            }
            
            this.enterLeaguePopupBundledPrefab = this.assetBundle.LoadAsset<UnityEngine.GameObject>(name:  "EnterLeaguePopupBundledPrefab");
            return (UnityEngine.GameObject)this.enterLeaguePopupBundledPrefab;
        }
        public UnityEngine.GameObject get_LeagueAreaBundledPrefab()
        {
            if(this.leagueAreaBundledPrefab != 0)
            {
                    return (UnityEngine.GameObject)this.leagueAreaBundledPrefab;
            }
            
            if(this.assetBundle == 0)
            {
                    return (UnityEngine.GameObject)this.leagueAreaBundledPrefab;
            }
            
            this.leagueAreaBundledPrefab = this.assetBundle.LoadAsset<UnityEngine.GameObject>(name:  "area_00");
            return (UnityEngine.GameObject)this.leagueAreaBundledPrefab;
        }
        public override Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleType get_BundleType()
        {
            return 5;
        }
        public override string get_BundleName()
        {
            return "royalleague";
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
                Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  22, log:  "Royal league asset bundle is missing", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            }
            
            val_10 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_10 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_10 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_10 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  22, log:  "Royal league asset bundle is loaded", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        private UnityEngine.AssetBundle LoadAssetBundle()
        {
            return Royal.Scenes.Start.Context.Units.FeatureBundle.AFeatureBundle.LoadBundleFromGooglePlay(name:  "royalleague");
        }
        public override void UnloadBundle(bool unloadAllLoadedObjects = True)
        {
            this.enterLeaguePopupBundledPrefab = 0;
            this.leagueAreaBundledPrefab = 0;
            if(unloadAllLoadedObjects == false)
            {
                    return;
            }
            
            if(this.assetBundle == 0)
            {
                    return;
            }
            
            this.assetBundle.Unload(unloadAllLoadedObjects:  true);
            this.assetBundle = 0;
        }
        public override bool ShouldQueueForDownload()
        {
            return false;
        }
        public static string GetBundleName()
        {
            return "royalleague";
        }
        public RoyalLeagueBundle()
        {
            this = new System.Object();
        }
    
    }

}
