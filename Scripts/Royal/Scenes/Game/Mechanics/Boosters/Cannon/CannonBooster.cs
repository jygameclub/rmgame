using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Boosters.Cannon
{
    public class CannonBooster
    {
        // Fields
        private readonly Royal.Infrastructure.Contexts.Units.CameraManager cameraManager;
        private readonly Royal.Scenes.Game.Levels.Units.CellGridManager gridManager;
        private readonly Royal.Scenes.Game.Levels.Units.State.GameStateManager gameState;
        private int gridHeight;
        private readonly Royal.Scenes.Game.Mechanics.Boosters.Cannon.View.CannonBoosterView cannonView;
        private readonly Royal.Scenes.Game.Mechanics.Boosters.Cannon.View.CannonBoosterBallView ballView;
        
        // Methods
        public CannonBooster()
        {
            this.cameraManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            this.gameState = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14);
            Royal.Scenes.Game.Levels.Units.CellGridManager val_3 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.CellGridManager>(contextId:  2);
            this.gridManager = val_3;
            val_3.add_OnCellGridViewsInitialized(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Game.Mechanics.Boosters.Cannon.CannonBooster::OnCellGridViewInitialized()));
            Royal.Scenes.Game.Mechanics.Boosters.Cannon.View.CannonBoosterAssets val_5 = UnityEngine.Resources.Load<Royal.Scenes.Game.Mechanics.Boosters.Cannon.View.CannonBoosterAssets>(path:  "CannonBoosterAssets");
            Royal.Scenes.Game.Mechanics.Boosters.Cannon.View.CannonBoosterView val_6 = UnityEngine.Object.Instantiate<Royal.Scenes.Game.Mechanics.Boosters.Cannon.View.CannonBoosterView>(original:  val_5.cannonBoosterPrefab);
            this.cannonView = val_6;
            val_6.Hide();
            Royal.Scenes.Game.Mechanics.Boosters.Cannon.View.CannonBoosterBallView val_7 = UnityEngine.Object.Instantiate<Royal.Scenes.Game.Mechanics.Boosters.Cannon.View.CannonBoosterBallView>(original:  val_5.cannonBallPrefab);
            this.ballView = val_7;
            val_7.Hide();
        }
        private void OnCellGridViewInitialized()
        {
            this.gridHeight = this.gridManager.Height;
        }
        public bool Use(Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint cellPoint)
        {
            int val_9;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_10;
            var val_11;
            val_9 = cellPoint.x;
            val_10 = this.gridManager.Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_9, y = cellPoint.y}];
            if((mem[-6917529027624257768]) == 0)
            {
                goto label_5;
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_2 = val_10.CurrentItem;
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
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_5 = this.gridManager.Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_9 & 4294967295, y = val_9 & 4294967295}];
            val_10 = val_5;
            UnityEngine.Vector3 val_6 = val_5.GetViewPosition();
            if(this.gridHeight >= 9)
            {
                goto label_13;
            }
            
            int val_9 = this.gridHeight;
            float val_11 = 0.7f;
            val_9 = 9 - val_9;
            float val_10 = (float)val_9;
            val_10 = val_10 * 0.5f;
            val_11 = val_10 + val_11;
            val_6.y = val_6.y - val_11;
            goto label_14;
            label_10:
            val_11 = 0;
            return (bool)val_11;
            label_13:
            val_6.y = val_6.y + (-0.7f);
            label_14:
            val_9 = this.PlayAnimation(column:  val_9, startCell:  val_10, targetPosition:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            UnityEngine.Coroutine val_8 = Royal.Scenes.Game.Context.GameContext.ManualStartCoroutine(iEnumerator:  val_9);
            val_11 = 1;
            return (bool)val_11;
        }
        private System.Collections.IEnumerator PlayAnimation(int column, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel startCell, UnityEngine.Vector3 targetPosition)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .column = column;
            .startCell = startCell;
            .targetPosition = targetPosition;
            mem[1152921523902589836] = targetPosition.y;
            mem[1152921523902589840] = targetPosition.z;
            return (System.Collections.IEnumerator)new CannonBooster.<PlayAnimation>d__9();
        }
    
    }

}
