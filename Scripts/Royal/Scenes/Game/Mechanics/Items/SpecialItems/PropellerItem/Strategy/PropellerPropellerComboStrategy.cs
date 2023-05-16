using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.Strategy
{
    public class PropellerPropellerComboStrategy : PropellerDefaultStrategy
    {
        // Fields
        private readonly float startAngle;
        
        // Methods
        public PropellerPropellerComboStrategy(float startAngle)
        {
            this.startAngle = startAngle;
        }
        public override Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerPilot.IPropellerPilot GetNewPilot()
        {
            return (Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerPilot.IPropellerPilot)new Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerPilot.PropellerPropellerComboPilot(angle:  this.startAngle);
        }
    
    }

}
