using UnityEngine;

namespace Royal.Scenes.Game.Ui.Dialogs.RemainingMoves
{
    public class RemainingMovesItemExploder
    {
        // Fields
        private Royal.Scenes.Game.Levels.Units.CellGridManager gridManager;
        private Royal.Scenes.Game.Levels.Units.State.GameStateManager gameState;
        private float lastOperationTime;
        private UnityEngine.Coroutine routine;
        private System.Action onComplete;
        private bool isSkipClicked;
        private bool isCompleteCalled;
        
        // Methods
        public RemainingMovesItemExploder()
        {
            this.gridManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.CellGridManager>(contextId:  2);
            this.gameState = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14);
        }
        public void SkipClicked()
        {
            var val_1;
            this.isSkipClicked = true;
            if(this.isCompleteCalled != true)
            {
                    if(this.routine != null)
            {
                    val_1 = null;
                val_1 = null;
                Royal.Scenes.Start.Context.ApplicationContext.controller.StopCoroutine(routine:  this.routine);
                this.routine = 0;
            }
            
                if(this.onComplete != null)
            {
                    this.onComplete.Invoke();
            }
            
            }
            
            this.isCompleteCalled = true;
        }
        public void ExplodeItemsOnBoard(System.Action onComplete)
        {
            if(this.isSkipClicked != false)
            {
                    onComplete.Invoke();
                return;
            }
            
            this.lastOperationTime = Royal.Scenes.Game.Levels.LevelContext.Time;
            this.isCompleteCalled = false;
            this.onComplete = onComplete;
            this.routine = Royal.Scenes.Start.Context.ApplicationContext.ManualStartCoroutine(iEnumerator:  this.ExplodeSpecialItems());
        }
        private System.Collections.IEnumerator ExplodeSpecialItems()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new RemainingMovesItemExploder.<ExplodeSpecialItems>d__10();
        }
        public int CalculateExtraCoinAmountOnBoard()
        {
            var val_3;
            var val_6;
            Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator val_1 = this.gridManager.GetIterator(iteratorType:  3);
            val_6 = 0;
            if(val_3 == 0)
            {
                    return (int)val_6;
            }
            
            goto label_13;
            label_12:
            val_6 = 34471396;
            goto label_11;
            label_13:
            if((((val_2 + 32.HasCurrentItem()) != false) && ((val_2 + 32.CurrentItem) != null)) && (null == 0))
            {
                    if(null != 0)
            {
                goto label_12;
            }
            
            }
            
            label_11:
            if(val_3 != 0)
            {
                goto label_13;
            }
            
            return (int)val_6;
        }
    
    }

}
