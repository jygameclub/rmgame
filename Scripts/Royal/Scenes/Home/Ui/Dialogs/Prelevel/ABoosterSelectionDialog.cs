using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Prelevel
{
    public class ABoosterSelectionDialog : AbstractLevelDialog
    {
        // Fields
        public UnityEngine.GameObject tooltip;
        public Royal.Scenes.Home.Ui.Dialogs.Prelevel.PrelevelBoosterButton rocket;
        public Royal.Scenes.Home.Ui.Dialogs.Prelevel.PrelevelBoosterButton tnt;
        public Royal.Scenes.Home.Ui.Dialogs.Prelevel.PrelevelBoosterButton lightBall;
        
        // Methods
        protected void PrepareBoosters(Royal.Scenes.Start.Context.Units.Flow.DialogOriginType origin)
        {
            this.rocket.Init(type:  1, origin:  origin, onBuyBoosterClick:  new System.Action(object:  this, method:  typeof(Royal.Scenes.Home.Ui.Dialogs.Prelevel.ABoosterSelectionDialog).__il2cppRuntimeField_258));
            this.tnt.Init(type:  2, origin:  origin, onBuyBoosterClick:  new System.Action(object:  this, method:  typeof(Royal.Scenes.Home.Ui.Dialogs.Prelevel.ABoosterSelectionDialog).__il2cppRuntimeField_258));
            this.lightBall.Init(type:  3, origin:  origin, onBuyBoosterClick:  new System.Action(object:  this, method:  typeof(Royal.Scenes.Home.Ui.Dialogs.Prelevel.ABoosterSelectionDialog).__il2cppRuntimeField_258));
        }
        protected void AutoSelectBoostersIfHasTime()
        {
            this.rocket.AutoSelectIfHasTime();
            this.tnt.AutoSelectIfHasTime();
            this.lightBall.AutoSelectIfHasTime();
        }
        public void ShowToolTip(Royal.Infrastructure.UiComponents.Button.UiButton uiButton)
        {
            UnityEngine.Object val_11;
            Royal.Infrastructure.UiComponents.Dialog.DialogManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Dialog.DialogManager>(id:  13);
            UnityEngine.Transform val_4 = uiButton.transform.parent.parent;
            UnityEngine.Vector3 val_5 = val_4.position;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_11 = val_1.toolTipManager.ToggleTooltip(parent:  val_4, touchable:  uiButton, pos:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, toolTip:  this.tooltip);
            if(val_11 == 0)
            {
                    return;
            }
            
            val_11 = val_11.GetComponent<Royal.Scenes.Home.Ui.Dialogs.Prelevel.HardLevelTagTooltip>();
            val_11.Prepare(multiplier:  (Royal.Player.Context.Data.Session.__il2cppRuntimeField_2C == 1) ? 3 : 5);
        }
        public ABoosterSelectionDialog()
        {
            val_1 = new Royal.Infrastructure.UiComponents.Dialog.UiDialog();
        }
    
    }

}
