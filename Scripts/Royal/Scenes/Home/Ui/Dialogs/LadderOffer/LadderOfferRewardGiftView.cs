using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.LadderOffer
{
    public class LadderOfferRewardGiftView : LadderOfferRewardView
    {
        // Fields
        public UnityEngine.GameObject tooltipPrefab;
        
        // Methods
        public void OnInfoClick(Royal.Infrastructure.UiComponents.Button.UiButton button)
        {
            var val_12;
            Royal.Player.Context.Units.LadderOfferManager val_1 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LadderOfferManager>(id:  11);
            if(val_1.isBuyAnimationsPlaying == true)
            {
                    return;
            }
            
            UnityEngine.Transform val_2 = button.transform;
            val_12 = val_2;
            UnityEngine.Vector3 val_3 = val_2.position;
            Royal.Infrastructure.UiComponents.Dialog.DialogManager val_4 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Dialog.DialogManager>(id:  13);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.GameObject val_9 = val_4.toolTipManager.ToggleTooltip(parent:  val_12.parent.transform.parent, touchable:  button, pos:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, toolTip:  this.tooltipPrefab);
            if(val_9 == 0)
            {
                    return;
            }
            
            val_9.GetComponent<Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferRewardTooltip>().ArrangeRewards(ladderOfferStep:  public Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferRewardTooltip UnityEngine.GameObject::GetComponent<Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferRewardTooltip>());
        }
        public LadderOfferRewardGiftView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
