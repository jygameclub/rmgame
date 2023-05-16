using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.RemainingMoves
{
    public class RemainingMovesCoinCollectAnimation
    {
        // Fields
        private const int Count = 10;
        private Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory;
        private System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.CoinItem.View.CoinItemView> spawnedItems;
        private System.Collections.Generic.List<Royal.Scenes.Game.Levels.Units.RemainingMoves.RemainingMovesSingleCoinPilot> coinPilots;
        private Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        private Royal.Scenes.Game.Levels.Units.GoalManager goalManager;
        private Royal.Scenes.Game.Levels.Units.State.GameStateManager stateManager;
        private int totalItemsSent;
        private int totalItemsReached;
        
        // Methods
        public void Play(Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint cellPoint, UnityEngine.Vector3 startPosition, int coinAmount)
        {
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
            this.goalManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.GoalManager>(contextId:  11);
            this.stateManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14);
            this.itemFactory = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1);
            this.spawnedItems = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.CoinItem.View.CoinItemView>(capacity:  10);
            this.coinPilots = new System.Collections.Generic.List<Royal.Scenes.Game.Levels.Units.RemainingMoves.RemainingMovesSingleCoinPilot>(capacity:  10);
            this.PlayCollectAnimation(cellPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = cellPoint.x, y = cellPoint.y}, startPosition:  new UnityEngine.Vector3() {x = startPosition.x, y = startPosition.y, z = startPosition.z}, count:  coinAmount);
        }
        private void PlayCollectAnimation(Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint cellPoint, UnityEngine.Vector3 startPosition, int count)
        {
            UnityEngine.Vector3 val_1 = this.goalManager.GetGoalPosition(goalType:  21);
            UnityEngine.Color val_2 = UnityEngine.Color.white;
            this.PlayCoinAppearSound();
            if()
            {
                    return;
            }
            
            var val_16 = 0;
            do
            {
                Royal.Scenes.Game.Levels.Units.RemainingMoves.RemainingMovesSingleCoinPilot val_4 = this.itemFactory.Spawn<Royal.Scenes.Game.Levels.Units.RemainingMoves.RemainingMovesSingleCoinPilot>(poolId:  69, activate:  true);
                val_4.transform.position = new UnityEngine.Vector3() {x = startPosition.x, y = startPosition.y, z = startPosition.z};
                Royal.Scenes.Game.Mechanics.Items.CoinItem.View.CoinItemView val_6 = this.itemFactory.Spawn<Royal.Scenes.Game.Mechanics.Items.CoinItem.View.CoinItemView>(poolId:  61, activate:  true);
                val_6.transform.SetParent(p:  val_4.transform);
                this.spawnedItems.Add(item:  val_6);
                Royal.Scenes.Game.Mechanics.Sortings.SortingData val_9 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetPropellerFlyingSorting(isSpecialCombo:  true);
                val_6.UpdateSortingForAnimation(sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_9.layer, order = val_9.order, sortEverything = X24}, allowOtherSortingUpdates:  true);
                val_6.PlayFlipAnimation(time:  UnityEngine.Random.Range(min:  0f, max:  0.1f));
                val_6.shadowView.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
                UnityEngine.Transform val_11 = val_6.transform;
                UnityEngine.Vector3 val_12 = UnityEngine.Vector3.zero;
                val_11.localPosition = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
                UnityEngine.Vector3 val_13 = UnityEngine.Vector3.one;
                val_11.localScale = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
                val_6.baseView.color = new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
                this.goalManager.IncreaseGoal(goalType:  21);
                this.goalManager.FlyingToBeCollected(goalType:  21);
                this.stateManager.OperationStart(animationId:  5);
                this.coinPilots.Add(item:  val_4);
                UnityEngine.Vector3 val_14 = this.GetFirstPositionForCoin(cellPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = cellPoint.x, y = cellPoint.y}, startPosition:  new UnityEngine.Vector3() {x = startPosition.x, y = startPosition.y, z = startPosition.z}, index:  0, maxIndex:  count - 1);
                val_4.MoveToTarget(coinItemView:  val_6, firstTarget:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, finalTarget:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, index:  0, onComplete:  new System.Action<Royal.Scenes.Game.Levels.Units.RemainingMoves.RemainingMovesSingleCoinPilot>(object:  this, method:  System.Void Royal.Scenes.Game.Levels.Units.RemainingMoves.RemainingMovesCoinCollectAnimation::OnItemReached(Royal.Scenes.Game.Levels.Units.RemainingMoves.RemainingMovesSingleCoinPilot coinPilot)));
                val_16 = val_16 + 1;
            }
            while(val_16 < count);
        
        }
        private UnityEngine.Vector3 GetFirstPositionForCoin(Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint cellPoint, UnityEngine.Vector3 startPosition, int index, int maxIndex)
        {
            float val_12;
            float val_13;
            float val_17;
            if(maxIndex >= 4)
            {
                goto label_1;
            }
            
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            val_12 = 2.5f;
            val_13 = 2f;
            if(cellPoint.x <= 1)
            {
                goto label_4;
            }
            
            if(cellPoint.x >= 7)
            {
                goto label_5;
            }
            
            if(maxIndex == 1)
            {
                goto label_6;
            }
            
            if(maxIndex != 2)
            {
                goto label_7;
            }
            
            if(index == 2)
            {
                goto label_14;
            }
            
            if(index == 1)
            {
                goto label_17;
            }
            
            if(index == 0)
            {
                goto label_18;
            }
            
            goto label_31;
            label_1:
            UnityEngine.Vector3 val_3 = this.GetPositionForIndexOverThree(cellPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = cellPoint.x, y = cellPoint.y}, startPosition:  new UnityEngine.Vector3() {x = startPosition.x, y = startPosition.y, z = startPosition.z}, index:  index, maxIndex:  maxIndex);
            return new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            label_4:
            if(index == 2)
            {
                goto label_13;
            }
            
            if(index == 1)
            {
                goto label_14;
            }
            
            if(index == 0)
            {
                goto label_17;
            }
            
            goto label_31;
            label_5:
            if(index == 2)
            {
                goto label_17;
            }
            
            if(index == 1)
            {
                goto label_18;
            }
            
            if(index != 0)
            {
                goto label_31;
            }
            
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.left;
            goto label_31;
            label_17:
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.down;
            goto label_31;
            label_14:
            val_12 = 1f;
            goto label_33;
            label_13:
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.right;
            goto label_31;
            label_6:
            if(index == 1)
            {
                goto label_30;
            }
            
            if(index != 0)
            {
                goto label_31;
            }
            
            val_12 = -0.6f;
            goto label_33;
            label_7:
            val_12 = 0.1f;
            goto label_33;
            label_18:
            val_12 = -1f;
            val_17 = 0f;
            val_13 = val_12;
            goto label_34;
            label_30:
            val_12 = 0.6f;
            label_33:
            val_13 = -1f;
            val_17 = 0f;
            label_34:
            label_31:
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_12, y = val_13, z = val_17}, d:  (maxIndex == 0) ? (val_13) : (val_12));
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = startPosition.x, y = startPosition.y, z = startPosition.z}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            return new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        }
        private UnityEngine.Vector3 GetPositionForIndexOverThree(Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint cellPoint, UnityEngine.Vector3 startPosition, int index, int maxIndex)
        {
            float val_1 = (float)index / (float)maxIndex;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.forward;
            UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.AngleAxis(angle:  UnityEngine.Mathf.Lerp(a:  90f, b:  270f, t:  val_1), axis:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_6 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w}, point:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  2f);
            float val_8 = UnityEngine.Mathf.Lerp(a:  0f, b:  1f, t:  val_1);
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = startPosition.x, y = startPosition.y, z = startPosition.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            return new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
        }
        private void PlayCoinAppearSound()
        {
            if(this.audioManager != null)
            {
                    this.audioManager.PlaySound(type:  71, offset:  0.04f);
                return;
            }
            
            throw new NullReferenceException();
        }
        private void OnItemReached(Royal.Scenes.Game.Levels.Units.RemainingMoves.RemainingMovesSingleCoinPilot coinPilot)
        {
            bool val_1 = this.spawnedItems.Remove(item:  coinPilot.coinItemView);
            if(coinPilot.coinItemView != 0)
            {
                    this.itemFactory.Recycle<Royal.Scenes.Game.Mechanics.Items.CoinItem.View.CoinItemView>(go:  coinPilot.coinItemView);
            }
            
            bool val_3 = this.coinPilots.Remove(item:  coinPilot);
            coinPilot.Recycle();
            this.audioManager.PlaySound(type:  72, offset:  0.04f);
            this.goalManager.IncreaseGoalUi(goalType:  21);
            this.stateManager.OperationFinish(animationId:  5);
            this.audioManager.PlaySound(type:  72, offset:  0.04f);
        }
        public void TapToSkip()
        {
            var val_1;
            var val_1 = 0;
            if(<0)
            {
                    return;
            }
            
            val_1 = 33;
            do
            {
                if(true <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                0.TapToSkip();
                val_1 = val_1 - 1;
                if((val_1 & 2147483648) != 0)
            {
                    return;
            }
            
                val_1 = val_1 - 8;
            }
            while(this.coinPilots != null);
            
            throw new NullReferenceException();
        }
        public RemainingMovesCoinCollectAnimation()
        {
        
        }
    
    }

}
