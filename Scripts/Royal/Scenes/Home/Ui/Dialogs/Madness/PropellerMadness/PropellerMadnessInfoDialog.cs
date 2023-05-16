using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Madness.PropellerMadness
{
    public class PropellerMadnessInfoDialog : MadnessInfoDialog
    {
        // Fields
        public UnityEngine.Material causticsMat;
        public UnityEngine.Material distortionMat;
        public UnityEngine.Transform grandPrize;
        public UnityEngine.RectTransform[] prizeCurves;
        private Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleManager bundleManager;
        
        // Methods
        protected override void LoadMadnessBundle()
        {
            var val_9;
            this.ArrangeGrandPrizeText();
            Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleManager>(id:  25);
            this.bundleManager = val_1;
            if((val_1.LoadBundle(bundleType:  this)) != false)
            {
                    Royal.Scenes.Start.Context.Units.FeatureBundle.AFeatureBundle val_3 = this.bundleManager.GetBundle(bundleType:  this);
                UnityEngine.GameObject val_4 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.bundleManager, parent:  X21);
                UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
                val_4.transform.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
                Royal.Scenes.Home.Ui.Dialogs.Madness.PropellerMadness.PropellerMadnessBundleAnimation val_7 = val_4.GetComponent<Royal.Scenes.Home.Ui.Dialogs.Madness.PropellerMadness.PropellerMadnessBundleAnimation>();
                val_7.causticsRenderer.material = this.causticsMat;
                val_7.seaRenderer.material = this.distortionMat;
                this.grandPrize.SetParent(p:  val_7.rightPropellerBottom);
                UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
                this.grandPrize.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
                return;
            }
            
            val_9 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_9 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_9 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_9 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  22, log:  "Bundle can\'t be loaded, closing dialog.", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            goto typeof(Royal.Scenes.Home.Ui.Dialogs.Madness.PropellerMadness.PropellerMadnessInfoDialog).__il2cppRuntimeField_250;
        }
        protected override void UnloadMadnessBundle()
        {
            this.bundleManager.UnloadBundle(bundleType:  this);
        }
        private void ArrangeGrandPrizeText()
        {
            UnityEngine.RectTransform val_4;
            UnityEngine.RectTransform[] val_5;
            val_4 = this;
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isJapanese == false)
            {
                    return;
            }
            
            val_5 = this.prizeCurves;
            var val_5 = 0;
            label_7:
            if(val_5 >= (this.prizeCurves.Length - 1))
            {
                goto label_3;
            }
            
            val_5[val_5].gameObject.SetActive(value:  false);
            val_5 = this.prizeCurves;
            val_5 = val_5 + 1;
            if(val_5 != null)
            {
                goto label_7;
            }
            
            throw new NullReferenceException();
            label_3:
            val_4 = val_5[3];
            UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  2.89f, y:  1.13f);
            val_4.sizeDelta = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
        }
        protected override Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleType GetBundleType()
        {
            return 2;
        }
        public PropellerMadnessInfoDialog()
        {
        
        }
    
    }

}
