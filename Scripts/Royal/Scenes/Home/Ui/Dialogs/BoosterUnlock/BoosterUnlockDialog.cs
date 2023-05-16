using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.BoosterUnlock
{
    public class BoosterUnlockDialog : UiDialog
    {
        // Fields
        public UnityEngine.Transform boosterContainer;
        public TMPro.TextMeshPro infoText;
        public UnityEngine.GameObject backgroundShine;
        public UnityEngine.SpriteRenderer writeMask;
        public Royal.Infrastructure.Utils.Text.TextProOnAnAnimationCurve titleCurve;
        private Royal.Scenes.Game.Mechanics.Boosters.BoosterType boosterType;
        private UnityEngine.GameObject booster;
        
        // Methods
        public void Init(Royal.Scenes.Game.Mechanics.Boosters.BoosterType type)
        {
            this.boosterType = type;
            this.ArrangeTitle();
            if((type - 4) <= 3)
            {
                    var val_23 = 36587652 + ((type - 4)) << 2;
                val_23 = val_23 + 36587652;
            }
        
        }
        private void ArrangeTitle()
        {
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isGerman == false)
            {
                    return;
            }
            
            this.titleCurve = 1087373312;
            UnityEngine.Transform val_1 = this.titleCurve.transform;
            UnityEngine.Vector3 val_2 = val_1.localPosition;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  0.07f);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            val_1.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        }
        private void InitBooster(Royal.Scenes.Home.Ui.Dialogs.BoosterUnlock.BoosterUnlockData data)
        {
            UnityEngine.Object val_2 = UnityEngine.Object.Instantiate(original:  UnityEngine.Resources.Load(path:  data.name), parent:  this.boosterContainer, instantiateInWorldSpace:  false);
            if(val_2 != null)
            {
                    if(null != null)
            {
                goto label_4;
            }
            
            }
            
            this.booster = val_2;
            this.infoText.text = data.info;
            return;
            label_4:
        }
        public override Royal.Infrastructure.UiComponents.Dialog.DialogConfig GetConfig()
        {
            bool val_2;
            float val_3;
            bool val_4;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_0;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_1 = this.GetConfig();
            val_0.shouldCloseOnEscape = true;
            val_0.shouldCloseOnTouch = true;
            val_0.shouldHideBackground = val_2;
            val_0.backgroundFadeInDuration = val_3;
            val_0.shouldCloseOnSwipe = val_4;
            return val_0;
        }
        public override void OnClose(System.Action dialogClosed)
        {
            this.OnClose(dialogClosed:  dialogClosed);
            UnityEngine.Object.Destroy(obj:  this.booster);
            Royal.Scenes.Home.Context.Units.Tutorial.HomeTutorialManager.ClaimUnlockedBooster(boosterType:  this.boosterType);
        }
        public BoosterUnlockDialog()
        {
        
        }
    
    }

}
