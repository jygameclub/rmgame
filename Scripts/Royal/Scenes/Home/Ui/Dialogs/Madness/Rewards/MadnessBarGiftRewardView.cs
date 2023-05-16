using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Madness.Rewards
{
    public class MadnessBarGiftRewardView : MadnessRewardView
    {
        // Fields
        public int giftBoxNumber;
        public UnityEngine.GameObject tooltipPrefab;
        
        // Methods
        public void ShowToolTip(Royal.Infrastructure.UiComponents.Button.UiButton button)
        {
            UnityEngine.Transform val_1 = button.transform;
            UnityEngine.Vector3 val_2 = val_1.position;
            Royal.Infrastructure.UiComponents.Dialog.DialogManager val_3 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Dialog.DialogManager>(id:  13);
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.GameObject val_5 = val_3.toolTipManager.ToggleTooltip(parent:  val_1, touchable:  button, pos:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, toolTip:  this.tooltipPrefab);
            if(val_5 == 0)
            {
                    return;
            }
            
            val_5.GetComponent<Royal.Scenes.Home.Ui.Dialogs.Madness.Rewards.MadnessBarGiftRewardTooltip>().ArrangeRewards(boxNumber:  this.giftBoxNumber);
        }
        public MadnessBarGiftRewardView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
