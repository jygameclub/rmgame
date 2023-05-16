using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.BirdNestItem
{
    public class GridColumnData
    {
        // Fields
        public Royal.Scenes.Game.Levels.Units.CellGridManager gridManager;
        public Royal.Scenes.Game.Mechanics.Items.BirdNestItem.GridColumn[] columns;
        
        // Methods
        public void InitColumns()
        {
            Royal.Scenes.Game.Levels.Units.CellGridManager val_1 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.CellGridManager>(contextId:  2);
            this.gridManager = val_1;
            int val_2 = val_1.Width;
            this.columns = new Royal.Scenes.Game.Mechanics.Items.BirdNestItem.GridColumn[0];
            var val_12 = 0;
            label_20:
            if(val_12 >= (this.gridManager.Width << ))
            {
                    return;
            }
            
            this.columns[val_12] = new Royal.Scenes.Game.Mechanics.Items.BirdNestItem.GridColumn();
            var val_10 = 0;
            var val_11 = 0;
            label_18:
            if(val_11 >= this.gridManager.Height)
            {
                goto label_9;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_7 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  0, y:  0);
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_8 = this.gridManager.Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_7.x, y = val_7.x}];
            if(val_8.IsNormalCell() == false)
            {
                goto label_12;
            }
            
            val_10 = val_10 + 1;
            if(val_10 > 3)
            {
                    if((Royal.Scenes.Game.Mechanics.Items.BirdNestItem.GridColumn)[1152921523855325872].topCells != null)
            {
                goto label_15;
            }
            
            }
            
            label_15:
            (Royal.Scenes.Game.Mechanics.Items.BirdNestItem.GridColumn)[1152921523855325872].bottomCells.Insert(index:  0, item:  val_8);
            label_12:
            val_11 = val_11 + 1;
            if(this.gridManager != null)
            {
                goto label_18;
            }
            
            label_9:
            val_12 = val_12 + 1;
            if(this.gridManager != null)
            {
                goto label_20;
            }
            
            throw new NullReferenceException();
        }
        public GridColumnData()
        {
        
        }
    
    }

}
