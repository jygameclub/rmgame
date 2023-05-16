using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Boosters.Arrow
{
    public class ArrowBooster
    {
        // Fields
        private readonly Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory;
        private readonly Royal.Infrastructure.Contexts.Units.CameraManager cameraManager;
        private readonly Royal.Scenes.Game.Levels.Units.CellGridManager gridManager;
        private readonly Royal.Scenes.Game.Levels.Units.State.GameStateManager gameState;
        
        // Methods
        public ArrowBooster()
        {
            this.itemFactory = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1);
            this.gridManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.CellGridManager>(contextId:  2);
            this.gameState = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14);
            this.cameraManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
        }
        public bool Use(Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint cellPoint)
        {
            int val_16;
            int val_17;
            var val_19;
            var val_20;
            val_19 = this.gridManager.Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = cellPoint.x, y = cellPoint.y}];
            if((mem[-6917529027624257768]) == 0)
            {
                goto label_5;
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_2 = val_19.CurrentItem;
            if((val_2 & 1) == 0)
            {
                goto label_10;
            }
            
            label_5:
            Royal.Scenes.Game.Mechanics.Items.Config.StaticItemModel val_3 = val_2.GetTopMostAboveItem();
            if(val_3 != null)
            {
                    if((val_3 & 1) == 0)
            {
                goto label_10;
            }
            
            }
            
            this.gameState.operations.Start(operationType:  7);
            val_19 = UnityEngine.Object.Instantiate<Royal.Scenes.Game.Mechanics.Boosters.Arrow.View.ArrowBoosterView>(original:  UnityEngine.Resources.Load<Royal.Scenes.Game.Mechanics.Boosters.Arrow.View.ArrowBoosterView>(path:  "ArrowBoosterPrefab"), parent:  this.itemFactory.<CellParent>k__BackingField);
            float val_18 = (float)9 - this.gridManager.Width;
            val_18 = val_18 * (-0.5f);
            val_18 = this.cameraManager.cameraWidth + val_18;
            val_19.Init(upOffset:  cellPoint.x >> 32, rightOffset:  val_18, isWide:  this.cameraManager.IsDeviceWide());
            Royal.Scenes.Game.Mechanics.Explode.ExplodeData val_14 = Royal.Scenes.Game.Mechanics.Explode.Exploder.Next(trigger:  18);
            val_19.PlayIn(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_17, y = val_17}, trigger = val_17, id = val_16}, cells:  Royal.Scenes.Game.Mechanics.Boosters.Arrow.ArrowBooster.PrepareCells(cell:  this.gridManager.Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = cellPoint.x & (-4294967296), y = cellPoint.x & (-4294967296)}]), onCompleteAction:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Game.Mechanics.Boosters.Arrow.ArrowBooster::OnComplete()));
            val_20 = 1;
            return (bool)val_20;
            label_10:
            val_20 = 0;
            return (bool)val_20;
        }
        private static System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> PrepareCells(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_3 = cell;
            System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> val_1 = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel>();
            if(val_3 == null)
            {
                    return val_1;
            }
            
            do
            {
                val_1.Add(item:  val_3 = cell);
                Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_2 = val_1.Get(type:  3);
                val_3 = val_2;
            }
            while(val_2 != null);
            
            return val_1;
        }
        private void OnComplete()
        {
            this.gameState.operations.Finish(operationType:  7);
        }
    
    }

}
