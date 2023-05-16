using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View
{
    public interface IPropellerItemViewDelegate : IItemViewDelegate
    {
        // Methods
        public abstract bool IsTargetValid(); // 0
        public abstract UnityEngine.Vector3 GetTargetPosition(); // 0
        public abstract Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerPilot.IPropellerPilot GetNewPilot(); // 0
    
    }

}
