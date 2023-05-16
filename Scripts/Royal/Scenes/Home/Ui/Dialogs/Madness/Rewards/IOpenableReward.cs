using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Madness.Rewards
{
    public interface IOpenableReward
    {
        // Methods
        public abstract void SetPackage(Royal.Player.Context.Data.InventoryPackage inventoryPackage); // 0
        public abstract void PlayOpenAnimation(System.Action onComplete); // 0
    
    }

}
