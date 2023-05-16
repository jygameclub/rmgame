using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Matches
{
    public class TempMatch
    {
        // Fields
        private Royal.Scenes.Game.Mechanics.Matches.Direction direction;
        private readonly Royal.Scenes.Game.Mechanics.Board.Cell.CellModel[] cellModels;
        
        // Methods
        public void Init(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel c1, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel c2, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel c3, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel c4, Royal.Scenes.Game.Mechanics.Matches.Direction direction = 0)
        {
            this.cellModels = c1;
            this.cellModels = c2;
            this.cellModels = c3;
            this.cellModels = c4;
            this.direction = direction;
        }
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel First()
        {
            return (Royal.Scenes.Game.Mechanics.Board.Cell.CellModel)this.cellModels[0];
        }
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel Middle()
        {
            return (Royal.Scenes.Game.Mechanics.Board.Cell.CellModel)this.cellModels[1];
        }
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel Last()
        {
            return (Royal.Scenes.Game.Mechanics.Board.Cell.CellModel)this.cellModels[2];
        }
        public Royal.Scenes.Game.Mechanics.Matches.Direction Direction()
        {
            return (Royal.Scenes.Game.Mechanics.Matches.Direction)this.direction;
        }
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel[] Cells()
        {
            return (Royal.Scenes.Game.Mechanics.Board.Cell.CellModel[])this.cellModels;
        }
        public TempMatch()
        {
            this.cellModels = new Royal.Scenes.Game.Mechanics.Board.Cell.CellModel[4];
        }
    
    }

}
