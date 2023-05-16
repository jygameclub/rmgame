using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Area
{
    public class AreaChest : MonoBehaviour
    {
        // Fields
        public UnityEngine.Vector3 chestTooltipPosition;
        public Royal.Infrastructure.UiComponents.Button.UiButton uiButton;
        public UnityEngine.GameObject chestTooltipPrefab;
        
        // Methods
        public void OnChest()
        {
            Royal.Infrastructure.UiComponents.Dialog.DialogManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Dialog.DialogManager>(id:  13);
            UnityEngine.Vector3 val_4 = this.transform.position;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = this.chestTooltipPosition, y = V11.16B, z = V10.16B});
            UnityEngine.GameObject val_6 = val_1.toolTipManager.ToggleTooltip(parent:  this.transform, touchable:  this.uiButton, pos:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, toolTip:  this.chestTooltipPrefab);
            if(val_6 == 0)
            {
                    return;
            }
            
            val_6.GetComponent<Royal.Scenes.Home.Ui.Dialogs.Area.AreaChestToolTip>().ArrangeRewardsForArea(areaId:  129259600);
        }
        public AreaChest()
        {
        
        }
    
    }

}
