using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.ItemCreation
{
    public struct ItemSettings
    {
        // Fields
        public readonly Royal.Scenes.Game.Utils.LevelParser.TiledId tiledId;
        public readonly Royal.Scenes.Game.Mechanics.Items.Config.ItemType itemType;
        public readonly int layerCount;
        public readonly Royal.Scenes.Game.Mechanics.Matches.MatchType matchType;
        public readonly Royal.Scenes.Game.Mechanics.Goal.GoalType goalType;
        public Royal.Scenes.Game.Mechanics.Board.Cell.StaticItemType staticItemType;
        public bool isExtraPropeller;
        public bool isCreatedByLightball;
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cellModel;
        public Royal.Scenes.Game.Mechanics.Matches.MatchType[][] potionColors;
        public int curtainId;
        public bool isDrillMaster;
        
        // Methods
        public ItemSettings(Royal.Scenes.Game.Utils.LevelParser.TiledId tiledId, Royal.Scenes.Game.Mechanics.Items.Config.ItemType itemType, int layerCount, Royal.Scenes.Game.Mechanics.Matches.MatchType matchType, Royal.Scenes.Game.Mechanics.Goal.GoalType goalType)
        {
            this.goalType = tiledId;
            this.staticItemType = itemType;
            this.isExtraPropeller = layerCount;
            mem[1152921524091271164] = matchType;
            this.potionColors = 0;
            this.curtainId = 0;
            this.isDrillMaster = false;
            mem[1152921524091271189] = 0;
            mem[1152921524091271192] = 0;
            this.cellModel = goalType;
            mem[1152921524091271172] = 0;
            mem[1152921524091271197] = 0;
        }
    
    }

}
