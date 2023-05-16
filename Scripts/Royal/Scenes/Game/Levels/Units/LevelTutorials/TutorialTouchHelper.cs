using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.LevelTutorials
{
    public class TutorialTouchHelper
    {
        // Fields
        private Royal.Scenes.Game.Levels.Units.CellGridManager gridManager;
        private Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator gridIterator;
        private Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint[] zIndexChangedCells;
        
        // Methods
        public TutorialTouchHelper(Royal.Scenes.Game.Levels.Units.CellGridManager gridManager)
        {
            var val_2;
            Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator val_3;
            this.gridManager = gridManager;
            Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator val_1 = gridManager.GetIterator(iteratorType:  0);
            mem[1152921524034327448] = val_2;
            this.gridIterator = val_3;
        }
        public void DisableTouchExceptCells(Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint[] cellPoints)
        {
            if(this.gridIterator == 0)
            {
                    return;
            }
            
            do
            {
                if((System.Linq.Enumerable.Contains<Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint>(source:  cellPoints, value:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = X22 + 24, y = X22 + 24})) != true)
            {
                    X22.DisableTouch();
            }
            
            }
            while(this.gridIterator != 0);
        
        }
        public void EnableTouchForAllCells()
        {
            goto label_0;
            label_2:
            this.gridIterator.EnableTouch();
            label_0:
            if(this.gridIterator != 0)
            {
                goto label_2;
            }
        
        }
        public void DisableTouchForAllCells()
        {
            goto label_0;
            label_2:
            this.gridIterator.DisableTouch();
            label_0:
            if(this.gridIterator != 0)
            {
                goto label_2;
            }
        
        }
        public void SetZIndexForCells(Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint[] cellArray, int i)
        {
            this.zIndexChangedCells = cellArray;
            int val_6 = cellArray.Length;
            if(val_6 < 1)
            {
                    return;
            }
            
            var val_7 = 0;
            val_6 = val_6 & 4294967295;
            do
            {
                UnityEngine.Vector3 val_3 = this.gridManager.Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = 50564912, y = 268435457}].transform.position;
                this.gridManager.Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = 50564912, y = 268435457}].transform.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = (float)i};
                val_7 = val_7 + 1;
            }
            while(val_7 < (cellArray.Length << ));
        
        }
        public void ResetZIndexForCells()
        {
            if(this.zIndexChangedCells == null)
            {
                    return;
            }
            
            int val_6 = this.zIndexChangedCells.Length;
            if(val_6 >= 1)
            {
                    var val_7 = 0;
                val_6 = val_6 & 4294967295;
                do
            {
                UnityEngine.Vector3 val_3 = this.gridManager.Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = 50504816, y = 268435457}].transform.position;
                this.gridManager.Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = 50504816, y = 268435457}].transform.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = 0f};
                val_7 = val_7 + 1;
            }
            while(val_7 < (this.zIndexChangedCells.Length << ));
            
            }
            
            this.zIndexChangedCells = 0;
        }
    
    }

}
