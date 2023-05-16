using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.Strategy
{
    public interface IPropellerStrategy
    {
        // Methods
        public abstract bool ExplodeNeighbors(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, Royal.Scenes.Game.Mechanics.Explode.Trigger trigger, Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.PropellerItemModel propellerItemModel); // 0
        public abstract Royal.Scenes.Game.Mechanics.Explode.ExplodeData NextExploder(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell); // 0
        public abstract void OnTargetReached(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, Royal.Scenes.Game.Mechanics.Explode.ExplodeData exploder); // 0
        public abstract Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerPilot.IPropellerPilot GetNewPilot(); // 0
        public abstract bool IsTntOrRocketCombo(); // 0
        public abstract void OnTargetFound(); // 0
        public abstract void OnTargetCancelled(); // 0
    
    }

}
