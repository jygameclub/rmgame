using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Completed1000ThLevel.Actions
{
    public class ShowCompleted1000ThLevelPanelAction : FlowAction
    {
        // Fields
        private Royal.Scenes.Home.Ui.Dialogs.Completed1000ThLevel.Completed1000ThLevelPanel panel;
        
        // Properties
        public override int Type { get; }
        public override bool IsForClaim { get; }
        
        // Methods
        public ShowCompleted1000ThLevelPanelAction()
        {
            var val_3;
            Royal.Player.Context.Data.InventoryPackage val_1 = Royal.Player.Context.Data.InventoryPackage.Get1000ThLevelPackage();
            val_3 = null;
            val_3 = null;
            Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.LifeCollectAnimationData val_2 = new Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.LifeCollectAnimationData(minutes:  val_1.unlimitedLifetimeMin, count:  0);
            Royal.Scenes.Home.Ui.__il2cppRuntimeField_38.PrepareTextForAnimation(animationData:  new Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.LifeCollectAnimationData() {lifeCount = val_2.lifeCount, unlimitedMinutes = val_2.lifeCount});
            Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg + 48.Update(diff:  Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg + 40 + 24);
        }
        public override int get_Type()
        {
            return 0;
        }
        public override bool get_IsForClaim()
        {
            return true;
        }
        public override void Execute()
        {
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.identity;
            Royal.Scenes.Home.Ui.Dialogs.Completed1000ThLevel.Completed1000ThLevelPanel val_4 = UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Dialogs.Completed1000ThLevel.Completed1000ThLevelPanel>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Dialogs.Completed1000ThLevel.Completed1000ThLevelPanel>(path:  "Completed1000ThLevelPanel"), position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rotation:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w});
            this.panel = val_4;
            val_4.Show(onComplete:  new System.Action(object:  this, method:  public System.Void Royal.Scenes.Start.Context.Units.Flow.FlowAction::Complete()));
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
        
        }
    
    }

}
