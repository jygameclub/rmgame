using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.Combo
{
    public class PropellerPropellerCombo : ICombo
    {
        // Fields
        private Royal.Scenes.Game.Mechanics.Board.Cell.CellModel fromCell;
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.PropellerItemModel to;
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.PropellerItemModel from;
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.PropellerItemModel extra;
        private float toAngle;
        private float fromAngle;
        private float extraAngle;
        
        // Properties
        public Royal.Scenes.Game.Levels.Units.Combo.ComboType ComboType { get; }
        
        // Methods
        public Royal.Scenes.Game.Levels.Units.Combo.ComboType get_ComboType()
        {
            return 10;
        }
        public void Prepare(Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemModel toItem, Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemModel fromItem)
        {
            this.fromCell = 28150.CurrentCell;
            this.to = toItem;
            this.from = fromItem;
            this.CreateExtraPropellers();
            this.CalculateAngleVariables();
        }
        private void CreateExtraPropellers()
        {
            int val_3;
            Royal.Scenes.Game.Utils.LevelParser.TiledId val_4;
            Royal.Scenes.Game.Mechanics.Goal.GoalType val_6;
            Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory val_1 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1);
            Royal.Scenes.Game.Levels.Units.ItemCreation.ItemSettings val_2 = Royal.Scenes.Game.Levels.Units.ItemCreation.ItemCreator.GetSettingsForTileId(tiledId:  10);
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_7 = 10.CurrentCell;
            this.extra = val_1.itemCreator.CreateItemWithSettings(settings:  new Royal.Scenes.Game.Levels.Units.ItemCreation.ItemSettings() {tiledId = val_4, itemType = val_4, layerCount = val_3, matchType = 1, goalType = val_6, staticItemType = val_6, isExtraPropeller = val_6, isCreatedByLightball = val_6, potionColors = val_6, curtainId = val_6, isDrillMaster = val_6}, position:  new UnityEngine.Vector3() {x = val_4, y = val_6, z = val_6});
        }
        private void CalculateAngleVariables()
        {
            double val_4;
            float val_5;
            UnityEngine.Vector3 val_2 = this.to.<ItemView>k__BackingField.transform.localPosition;
            if(val_2.x >= 0)
            {
                goto label_3;
            }
            
            val_4 = 21990232555520;
            goto label_4;
            label_3:
            if(val_2.x <= 7f)
            {
                goto label_5;
            }
            
            val_4 = 21990236959744;
            label_4:
            val_5 = 270f;
            this.toAngle = 180f;
            this.fromAngle = 90f;
            goto label_6;
            label_5:
            float val_3 = UnityEngine.Random.value;
            float val_4 = 360f;
            val_3 = val_3 * val_4;
            val_4 = val_3 + 120f;
            this.toAngle = val_3;
            this.fromAngle = val_4;
            val_5 = val_3 + 240f;
            label_6:
            this.extraAngle = val_5;
        }
        public void Explode(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            this.fromCell.FreezeFallForDuration(duration:  0.15f);
            this.to = new Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.Strategy.PropellerNoExplodeStrategy(startAngle:  this.toAngle);
            this.to.Explode(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id});
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.Strategy.PropellerPropellerComboStrategy val_2 = static_value_02DD03F8;
            val_2 = new Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.Strategy.PropellerPropellerComboStrategy(startAngle:  this.fromAngle);
            this.from = val_2;
            this.from.Explode(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id});
            this.extra = new Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.Strategy.PropellerExtraOneStrategy(startAngle:  this.extraAngle);
            this.extra.Explode(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id});
            this.fromCell = 0;
            this.from = 0;
        }
        private void Clear()
        {
            this.fromCell = 0;
            this.from = 0;
        }
        public PropellerPropellerCombo()
        {
        
        }
    
    }

}
