using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.Combo
{
    public class TntTntCombo : ICombo
    {
        // Fields
        private readonly Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory factory;
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.TntItemModel to;
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.TntItemModel from;
        
        // Properties
        public Royal.Scenes.Game.Levels.Units.Combo.ComboType ComboType { get; }
        
        // Methods
        public Royal.Scenes.Game.Levels.Units.Combo.ComboType get_ComboType()
        {
            return 5;
        }
        public TntTntCombo(Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory factory)
        {
            this.factory = factory;
        }
        public void Prepare(Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemModel toItem, Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemModel fromItem)
        {
            this.to = toItem;
            this.from = fromItem;
        }
        public void Explode(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            mem[1152921524123558840] = data.id;
            .data = data.point.x;
            this.to.DisableExplosion();
            this.from.IncreaseExplosion();
            .tntToBeExploded = this.from;
            .cellTo = this.to.CurrentCell;
            .cellFrom = this.from.CurrentCell;
            (TntTntCombo.<>c__DisplayClass7_0)[1152921524123558800].tntToBeExploded.SetSpecialItemActive(active:  false);
            (TntTntCombo.<>c__DisplayClass7_0)[1152921524123558800].cellTo.FreezeFall();
            (TntTntCombo.<>c__DisplayClass7_0)[1152921524123558800].cellFrom.FreezeFall();
            Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14).StartSpecialOperation();
            UnityEngine.Vector3 val_6 = (TntTntCombo.<>c__DisplayClass7_0)[1152921524123558800].cellFrom.GetViewPosition();
            this.factory.Spawn<Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntTntCombo.TntTntComboView>(poolId:  14, activate:  true).Init(factory:  this.factory, position:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, onComplete:  new System.Action(object:  new TntTntCombo.<>c__DisplayClass7_0(), method:  System.Void TntTntCombo.<>c__DisplayClass7_0::<Explode>b__0()));
            this.to = 0;
            this.from = 0;
        }
        private void Clear()
        {
            this.to = 0;
            this.from = 0;
        }
    
    }

}
