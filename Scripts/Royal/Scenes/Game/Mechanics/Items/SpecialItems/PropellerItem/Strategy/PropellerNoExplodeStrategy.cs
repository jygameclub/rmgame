using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.Strategy
{
    public class PropellerNoExplodeStrategy : PropellerPropellerComboStrategy
    {
        // Methods
        public PropellerNoExplodeStrategy(float startAngle)
        {
            val_1 = new Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.Strategy.PropellerDefaultStrategy();
            mem[1152921520117231976] = startAngle;
        }
        public override bool ExplodeNeighbors(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, Royal.Scenes.Game.Mechanics.Explode.Trigger trigger, Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.PropellerItemModel propellerItemModel)
        {
            return false;
        }
    
    }

}
