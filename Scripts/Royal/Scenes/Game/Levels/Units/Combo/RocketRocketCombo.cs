using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.Combo
{
    public class RocketRocketCombo : ICombo
    {
        // Fields
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.RocketItemModel to;
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.RocketItemModel from;
        private Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint toPoint;
        private Royal.Scenes.Game.Mechanics.Board.Cell.CellModel emptyCell;
        
        // Properties
        public Royal.Scenes.Game.Levels.Units.Combo.ComboType ComboType { get; }
        
        // Methods
        public Royal.Scenes.Game.Levels.Units.Combo.ComboType get_ComboType()
        {
            return 7;
        }
        public void Prepare(Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemModel toItem, Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemModel fromItem)
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_1 = 29910.CurrentCell;
            this.emptyCell = val_1;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_2 = val_1.CurrentCell;
            this.toPoint = true;
            this.to = toItem;
            this.from = fromItem;
            val_2.ClearFromAllRegisteredCells();
            val_2.ClearFromAllRegisteredCells();
        }
        public void Explode(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            int val_3;
            Royal.Scenes.Game.Mechanics.Explode.Trigger val_4;
            int val_6;
            Royal.Scenes.Game.Mechanics.Matches.MatchType val_7;
            this.emptyCell.FreezeFallForDuration(duration:  0.15f);
            data.point.x = this.toPoint;
            this.from.ChangeOrientation(orientation:  Royal.Scenes.Game.Mechanics.Items.Config.ItemOrientationExtensions.Opposite(orientation:  this.to.<Orientation>k__BackingField));
            this.from.ChangePosition(position:  new UnityEngine.Vector3() {x = 0.15f});
            Royal.Scenes.Game.Mechanics.Explode.ExplodeData val_2 = Royal.Scenes.Game.Mechanics.Explode.Exploder.Next(trigger:  7);
            Royal.Scenes.Game.Mechanics.Explode.ExplodeData val_5 = Royal.Scenes.Game.Mechanics.Explode.Exploder.Next(trigger:  6);
            this.from.ExplodeWithPresetData(trigger:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = this.toPoint, y = this.toPoint}, trigger = val_4, id = val_3, matchType = val_7}, presetData:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_7, y = val_7}, trigger = val_7, id = val_6, matchType = this.toPoint});
            this.to.ExplodeWithPresetData(trigger:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = this.toPoint, y = this.toPoint}, trigger = val_4, id = val_3, matchType = val_7}, presetData:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_7, y = val_7}, trigger = val_7, id = val_6, matchType = this.toPoint});
            this.emptyCell = 0;
            this.to = 0;
            this.from = 0;
        }
        private void Clear()
        {
            this.emptyCell = 0;
            this.to = 0;
            this.from = 0;
        }
        public RocketRocketCombo()
        {
        
        }
    
    }

}
