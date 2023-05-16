using UnityEngine;

namespace Royal.Scenes.Start.Context.Units.FeatureBundle
{
    public class PropellerMadnessBundle : AFeatureBundle
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
            return 2;
        }
        public override string get_BundleName()
        {
            return "propellermadness.ab";
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
            string val_11;
            var val_12;
            var val_13;
            if(this.assetBundle != 0)
            {
                    return;
            }
            
            val_11 = this.GetPersistentPath();
            if(this.IsBundleDownloaded == false)
            {
                    return;
            }
            
            System.Diagnostics.Stopwatch val_4 = new System.Diagnostics.Stopwatch();
            val_4.Start();
            this.assetBundle = UnityEngine.AssetBundle.LoadFromFile(path:  val_11);
            val_4.Stop();
            val_12 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_12 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_12 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_12 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  22, log:  "Propeller madness load from file: "("Propeller madness load from file: ") + val_4.ElapsedMilliseconds, values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            val_4.Reset();
            val_4.Start();
            this.<AnimationPrefab>k__BackingField = this.assetBundle.LoadAsset<UnityEngine.GameObject>(name:  "PropellerMadnessBundleAnimation");
            val_4.Stop();
            val_13 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_13 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_13 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_13 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_11 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30];
            val_11 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  22, log:  "Propeller madness load asset: "("Propeller madness load asset: ") + val_4.ElapsedMilliseconds, values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
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
            return "propellermadness.ab";
        }
        public PropellerMadnessBundle()
        {
            this = new System.Object();
        }
    
    }

}
