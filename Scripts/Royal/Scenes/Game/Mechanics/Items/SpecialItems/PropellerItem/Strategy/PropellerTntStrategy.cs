using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.Strategy
{
    public class PropellerTntStrategy : PropellerSpecialItemStrategy
    {
        // Methods
        public PropellerTntStrategy(Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemModel specialItemModel, bool isRightToLeft, bool isFromPropeller)
        {
            bool val_1 = isRightToLeft;
            bool val_2 = isFromPropeller;
        }
        public override Royal.Scenes.Game.Mechanics.Explode.ExplodeData NextExploder(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            if(cell != null)
            {
                    return Royal.Scenes.Game.Mechanics.Explode.Exploder.Next(trigger:  13, point:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = cell, y = cell});
            }
            
            throw new NullReferenceException();
        }
        public override bool IsTntOrRocketCombo()
        {
            return true;
        }
    
    }

}
