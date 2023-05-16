using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.FrogItem
{
    public class FrogItemModel : ItemModel, IFrogItemViewDelegate, IBirdItem, IItemViewDelegate
    {
        // Fields
        private Royal.Scenes.Game.Mechanics.Items.FrogItem.View.FrogItemView itemView;
        private Royal.Scenes.Game.Levels.Units.State.GameStateManager stateManager;
        private Royal.Scenes.Game.Mechanics.Items.FrogItem.FrogItemHelper frogItemHelper;
        
        // Properties
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType ItemType { get; }
        
        // Methods
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType get_ItemType()
        {
            return 31;
        }
        public override void CreateView(UnityEngine.Vector3 position)
        {
            this.stateManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14);
            Royal.Scenes.Game.Mechanics.Items.FrogItem.FrogItemHelper val_2 = Royal.Scenes.Game.Levels.LevelContext.GetLate<Royal.Scenes.Game.Mechanics.Items.FrogItem.FrogItemHelper>(contextId:  34);
            this.frogItemHelper = val_2;
            val_2.AddFrogOnBoard(item:  this);
            Royal.Scenes.Game.Mechanics.Items.FrogItem.View.FrogItemView val_3 = val_2.Spawn<Royal.Scenes.Game.Mechanics.Items.FrogItem.View.FrogItemView>(poolId:  111, activate:  true);
            this.itemView = val_3;
            val_3.Init(viewDelegate:  this, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
            goto typeof(Royal.Scenes.Game.Mechanics.Items.FrogItem.FrogItemModel).__il2cppRuntimeField_1E0;
        }
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemView GetItemView()
        {
            return (Royal.Scenes.Game.Mechanics.Items.Config.ItemView)this.itemView;
        }
        public override bool CanExplodeWithNearMatch()
        {
            return false;
        }
        public override bool IsFallable()
        {
            return true;
        }
        public override bool IsSwappable()
        {
            return true;
        }
        public override bool WillCellBeFreed(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            var val_3;
            if(this.TargetCell == cell)
            {
                    return (bool)(W8 != 0) ? 1 : 0;
            }
            
            val_3 = 0;
            return (bool)(W8 != 0) ? 1 : 0;
        }
        public override int RemainingExplodeCount()
        {
            return 0;
        }
        public void TryCollect()
        {
            int val_4;
            int val_5;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_1 = this.CurrentCell;
            if(W8 == 0)
            {
                    return;
            }
            
            Royal.Scenes.Game.Mechanics.Explode.ExplodeData val_3 = Royal.Scenes.Game.Mechanics.Explode.Exploder.Next(trigger:  20);
            this.CurrentCell.ExplodeCurrentItem(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_5, y = val_5}, trigger = val_5, id = val_4});
        }
        protected override void TryExplode(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            var val_7;
            int val_8;
            Royal.Scenes.Game.Mechanics.Items.FrogItem.FrogItemModel val_9;
            val_7 = -1475629552;
            val_8 = 1152921520311082560;
            val_9 = this;
            if(2819337744 == 6)
            {
                    this.itemView.PlayReactionAnimation();
                val_7 = -1475629552;
            }
            
            if(val_7 == 20)
            {
                    this.frogItemHelper.RemoveFrogOnBoard(item:  this);
                this.stateManager.OperationStart(animationId:  5);
                this.itemView.PlayCollectAnimation();
                val_8 = ???;
                val_9 = ???;
            }
            else
            {
                    val_9 + 32.CurrentCell.ExplodeTopMostBelowItem(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_8, y = val_8}, trigger = val_8, id = val_8 + 16});
            }
        
        }
        public override void CollectAsGoal(bool updateUi = True)
        {
            if(this != null)
            {
                    this.DecreaseGoal(goalType:  updateUi);
                return;
            }
            
            throw new NullReferenceException();
        }
        public UnityEngine.Vector3 GetGoalPosition()
        {
            if(this != null)
            {
                    return this.GetGoalPosition(goalType:  null);
            }
            
            throw new NullReferenceException();
        }
        public void CollectAnimationCompleted()
        {
            this.stateManager.OperationFinish(animationId:  5);
            this.stateManager.Recycle<Royal.Scenes.Game.Mechanics.Items.FrogItem.View.FrogItemView>(go:  this.itemView);
            Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.Sfx.GameSfxManager>(contextId:  22).PlaySfx(type:  185, offset:  0.04f);
        }
        public bool IsInSameColumn(int column)
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_1 = this.CurrentCell;
            return (bool)(W8 == column) ? 1 : 0;
        }
        public bool IsAbove(Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint point)
        {
            var val_6;
            if(this.CurrentCell == null)
            {
                    return (bool)val_6;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_2 = this.CurrentCell;
            if(point.x == W8)
            {
                    var val_5 = ((point.x >> 32) < (X8 >> 32)) ? 1 : 0;
                return (bool)val_6;
            }
            
            val_6 = 0;
            return (bool)val_6;
        }
        public override bool CanSelectByBooster()
        {
            var val_3;
            if(this.CurrentCell == null)
            {
                    return (bool)val_3;
            }
            
            if(X19.HasBelowItem() == false)
            {
                    return X19.HasTouchBlockingItem();
            }
            
            val_3 = 1;
            return (bool)val_3;
        }
        public bool HasCurrentCellAboveItem()
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_1 = this.CurrentCell;
            if(val_1 == null)
            {
                    return (bool)val_1;
            }
            
            return this.CurrentCell.HasTouchBlockingItem();
        }
        public bool HasNextCellAboveItem()
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_1 = this.NextCell;
            if(val_1 == null)
            {
                    return (bool)val_1;
            }
            
            return val_1.NextCell.HasTouchBlockingItem();
        }
        public override void RevealFromHoney()
        {
            if(this.itemView != null)
            {
                    if(W9 != 0)
            {
                    return;
            }
            
                this.itemView = 1;
                this.RevealFromHoney();
                return;
            }
            
            throw new NullReferenceException();
        }
        public override void RevealFromCurtain()
        {
            this.itemView.RevealFromCurtain();
            this.RevealFromCurtain();
        }
        public override void RevealFromChain()
        {
            this.itemView.RevealFromChain();
            this.RevealFromChain();
            this.TryCollect();
        }
        public FrogItemModel()
        {
        
        }
    
    }

}
