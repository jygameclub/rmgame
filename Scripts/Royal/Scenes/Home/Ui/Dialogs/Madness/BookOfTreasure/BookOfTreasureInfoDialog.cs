using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Madness.BookOfTreasure
{
    public class BookOfTreasureInfoDialog : MadnessInfoDialog
    {
        // Fields
        private Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleManager bundleManager;
        
        // Methods
        protected override void LoadMadnessBundle()
        {
            var val_7;
            Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleManager>(id:  25);
            this.bundleManager = val_1;
            if((val_1.LoadBundle(bundleType:  this)) != false)
            {
                    Royal.Scenes.Start.Context.Units.FeatureBundle.AFeatureBundle val_3 = this.bundleManager.GetBundle(bundleType:  this);
                UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
                UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.bundleManager, parent:  this).transform.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
                return;
            }
            
            val_7 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_7 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_7 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_7 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  22, log:  "Bundle can\'t be loaded, closing dialog.", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            goto typeof(Royal.Scenes.Home.Ui.Dialogs.Madness.BookOfTreasure.BookOfTreasureInfoDialog).__il2cppRuntimeField_250;
        }
        protected override void UnloadMadnessBundle()
        {
            this.bundleManager.UnloadBundle(bundleType:  this);
        }
        protected override Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleType GetBundleType()
        {
            return 1;
        }
        public BookOfTreasureInfoDialog()
        {
        
        }
    
    }

}
