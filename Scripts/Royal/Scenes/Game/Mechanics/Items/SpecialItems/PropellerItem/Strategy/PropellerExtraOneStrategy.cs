using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.Strategy
{
    public class PropellerExtraOneStrategy : PropellerPropellerComboStrategy
    {
        // Methods
        public PropellerExtraOneStrategy(float startAngle)
        {
            val_1 = new Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.Strategy.PropellerDefaultStrategy();
            mem[1152921520116838824] = startAngle;
        }
        public override Royal.Scenes.Game.Mechanics.Explode.ExplodeData NextExploder(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            return Royal.Scenes.Game.Mechanics.Explode.Exploder.Next(trigger:  8);
        }
        public override bool ExplodeNeighbors(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, Royal.Scenes.Game.Mechanics.Explode.Trigger dataTrigger, Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.PropellerItemModel propellerItemModel)
        {
            return false;
        }
    
    }

}
