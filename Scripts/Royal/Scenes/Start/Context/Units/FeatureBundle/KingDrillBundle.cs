using UnityEngine;

namespace Royal.Scenes.Start.Context.Units.FeatureBundle
{
    public class KingDrillBundle : AFeatureBundle
    {
        // Fields
        public static readonly string DrillMovementSfxName;
        public static readonly string DrillStopSfxName;
        public static readonly string DrillElectricSfxName;
        public static readonly string WallMovementSfxName;
        public static readonly string GamePlaySfxName;
        public static readonly string RedWarningSfxName;
        private UnityEngine.AssetBundle assetBundle;
        private UnityEngine.GameObject storyPrelevelBundledSubPrefab;
        private UnityEngine.GameObject storyFailDialogBundledSubPrefab;
        private UnityEngine.GameObject kingDrillRoomBundledSubPrefab;
        
        // Properties
        public UnityEngine.GameObject StoryPrelevelBundledSubPrefab { get; }
        public UnityEngine.GameObject StoryFailDialogBundledSubPrefab { get; }
        public UnityEngine.GameObject KingDrillRoomBundledSubPrefab { get; }
        public override Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleType BundleType { get; }
        public override string BundleName { get; }
        
        // Methods
        public KingDrillBundle()
        {
            this = new System.Object();
            if(Royal.Infrastructure.Utils.Native.DeviceHelper.IsIos == false)
            {
                    return;
            }
            
            Royal.Infrastructure.Services.AssetDownload.FileDownloader.CopyFileFromStreamingAssetsDir(fileName:  "kingdrill_v2", destinationPath:  this.GetPersistentPath());
        }
        public UnityEngine.GameObject get_StoryPrelevelBundledSubPrefab()
        {
            if(this.storyPrelevelBundledSubPrefab != 0)
            {
                    return (UnityEngine.GameObject)this.storyPrelevelBundledSubPrefab;
            }
            
            if(this.assetBundle == 0)
            {
                    return (UnityEngine.GameObject)this.storyPrelevelBundledSubPrefab;
            }
            
            this.storyPrelevelBundledSubPrefab = this.assetBundle.LoadAsset<UnityEngine.GameObject>(name:  "StoryPrelevelBundledSubPrefab");
            return (UnityEngine.GameObject)this.storyPrelevelBundledSubPrefab;
        }
        public UnityEngine.GameObject get_StoryFailDialogBundledSubPrefab()
        {
            if(this.storyFailDialogBundledSubPrefab != 0)
            {
                    return (UnityEngine.GameObject)this.storyFailDialogBundledSubPrefab;
            }
            
            if(this.assetBundle == 0)
            {
                    return (UnityEngine.GameObject)this.storyFailDialogBundledSubPrefab;
            }
            
            this.storyFailDialogBundledSubPrefab = this.assetBundle.LoadAsset<UnityEngine.GameObject>(name:  "StoryFailDialogBundledSubPrefab");
            return (UnityEngine.GameObject)this.storyFailDialogBundledSubPrefab;
        }
        public UnityEngine.GameObject get_KingDrillRoomBundledSubPrefab()
        {
            if(this.kingDrillRoomBundledSubPrefab != 0)
            {
                    return (UnityEngine.GameObject)this.kingDrillRoomBundledSubPrefab;
            }
            
            if(this.assetBundle == 0)
            {
                    return (UnityEngine.GameObject)this.kingDrillRoomBundledSubPrefab;
            }
            
            this.kingDrillRoomBundledSubPrefab = this.assetBundle.LoadAsset<UnityEngine.GameObject>(name:  "KingDrillRoomBundledSubPrefab");
            return (UnityEngine.GameObject)this.kingDrillRoomBundledSubPrefab;
        }
        public override Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleType get_BundleType()
        {
            return 3;
        }
        public override string get_BundleName()
        {
            return "kingdrill_v2";
        }
        public override void LoadBundle()
        {
            string val_8;
            var val_9;
            var val_10;
            if(this.assetBundle != 0)
            {
                    return;
            }
            
            UnityEngine.AssetBundle val_2 = this.LoadAssetBundle();
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
                Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  22, log:  "LoadKingDrill: KingDrill bundle is missing", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            }
            
            val_10 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_10 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_10 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_10 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  22, log:  "Asset bundle is loaded", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        private UnityEngine.AssetBundle LoadAssetBundle()
        {
            string[] val_1 = new string[1];
            val_1[0] = this.GetPersistentPath();
            return UnityEngine.AssetBundle.LoadFromFile(path:  System.IO.Path.Combine(paths:  val_1));
        }
        public override void UnloadBundle(bool unloadAllLoadedObjects = True)
        {
            if(this.assetBundle != 0)
            {
                    this.assetBundle.Unload(unloadAllLoadedObjects:  unloadAllLoadedObjects);
            }
            
            this.assetBundle = 0;
            mem[1152921518928070320] = 0;
        }
        public override UnityEngine.AudioClip LoadSfx(string sfxName)
        {
            var val_3 = 0;
            if(this.assetBundle == 0)
            {
                    return (UnityEngine.AudioClip)this.assetBundle.LoadAsset<UnityEngine.AudioClip>(name:  sfxName);
            }
            
            return (UnityEngine.AudioClip)this.assetBundle.LoadAsset<UnityEngine.AudioClip>(name:  sfxName);
        }
        public override bool ShouldQueueForDownload()
        {
            return (bool)(typeof(Royal.Player.Context.Data.Persistent.BasicUserData).__il2cppRuntimeField_14 > 2) ? 1 : 0;
        }
        public static string GetBundleName()
        {
            return "kingdrill_v2";
        }
        public void RemovePrelevelBundledSubPrefabReference()
        {
            this.storyPrelevelBundledSubPrefab = 0;
        }
        public void RemoveFailDialogBundledSubPrefabReference()
        {
            this.storyFailDialogBundledSubPrefab = 0;
        }
        public void RemoveKingDrillRoomBundledSubPrefabReference()
        {
            this.kingDrillRoomBundledSubPrefab = 0;
        }
        private static KingDrillBundle()
        {
            Royal.Scenes.Start.Context.Units.FeatureBundle.KingDrillBundle.DrillMovementSfxName = "king_rescue_level_drill_movement";
            Royal.Scenes.Start.Context.Units.FeatureBundle.KingDrillBundle.DrillStopSfxName = "king_rescue_level_drill_stop";
            Royal.Scenes.Start.Context.Units.FeatureBundle.KingDrillBundle.DrillElectricSfxName = "king_rescue_level_electric_zap";
            Royal.Scenes.Start.Context.Units.FeatureBundle.KingDrillBundle.WallMovementSfxName = "king_rescue_level_wall_movement";
            Royal.Scenes.Start.Context.Units.FeatureBundle.KingDrillBundle.GamePlaySfxName = "KingDrillMusic";
            Royal.Scenes.Start.Context.Units.FeatureBundle.KingDrillBundle.RedWarningSfxName = "red_warning";
        }
    
    }

}
