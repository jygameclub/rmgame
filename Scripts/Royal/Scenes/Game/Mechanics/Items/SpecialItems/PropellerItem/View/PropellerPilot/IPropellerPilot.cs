using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerPilot
{
    public interface IPropellerPilot
    {
        // Properties
        public abstract bool ShouldPlaySfxInLoop { get; }
        public abstract Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerFlyState FlyState { get; }
        
        // Methods
        public abstract bool get_ShouldPlaySfxInLoop(); // 0
        public abstract Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerFlyState get_FlyState(); // 0
        public abstract void StartFlying(Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerItemView itemView, Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.IPropellerItemViewDelegate viewDelegate); // 0
        public abstract void TargetChanged(); // 0
        public abstract void Move(); // 0
    
    }

}
