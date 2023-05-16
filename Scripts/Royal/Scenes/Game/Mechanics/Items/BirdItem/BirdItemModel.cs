using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.BirdItem
{
    public class BirdItemModel : ItemModel, IBirdItemViewDelegate, IBirdItem, IItemViewDelegate
    {
        // Fields
        private Royal.Scenes.Game.Mechanics.Items.BirdItem.View.BirdItemView itemView;
        private Royal.Scenes.Game.Levels.Units.State.GameStateManager stateManager;
        private Royal.Scenes.Game.Mechanics.Items.BirdItem.BirdItemHelper birdItemHelper;
        
        // Properties
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType ItemType { get; }
        public Royal.Scenes.Game.Mechanics.Items.BirdItem.View.BirdItemView ItemView { get; }
        
        // Methods
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType get_ItemType()
        {
            return 16;
        }
        public Royal.Scenes.Game.Mechanics.Items.BirdItem.View.BirdItemView get_ItemView()
        {
            return (Royal.Scenes.Game.Mechanics.Items.BirdItem.View.BirdItemView)this.itemView;
        }
        public override void CreateView(UnityEngine.Vector3 position)
        {
            this.stateManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14);
            Royal.Scenes.Game.Mechanics.Items.BirdItem.BirdItemHelper val_2 = Royal.Scenes.Game.Levels.LevelContext.GetLate<Royal.Scenes.Game.Mechanics.Items.BirdItem.BirdItemHelper>(contextId:  23);
            this.birdItemHelper = val_2;
            val_2.AddBirdOnBoard(item:  this);
            Royal.Scenes.Game.Mechanics.Items.BirdItem.View.BirdItemView val_3 = val_2.Spawn<Royal.Scenes.Game.Mechanics.Items.BirdItem.View.BirdItemView>(poolId:  63, activate:  true);
            this.itemView = val_3;
            val_3.Init(viewDelegate:  this, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
            this.HasView = true;
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
            if(2084457008 == 6)
            {
                    this.itemView.PlayReactionAnimation();
                2084457008 = 2084457008;
            }
            
            if(2084457008 == 20)
            {
                    this.birdItemHelper.RemoveBirdOnBoard(item:  this);
                this.stateManager.OperationStart(animationId:  5);
                this.itemView.PlayCollectAnimation();
                this.FinalExplodeCompleted(freezeDuration:  0.15f);
                return;
            }
            
            this.itemView.CurrentCell.ExplodeTopMostBelowItem(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id});
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
            this.CollectAsGoalUi();
            this.stateManager.OperationFinish(animationId:  5);
            this.stateManager.Recycle<Royal.Scenes.Game.Mechanics.Items.BirdItem.View.BirdItemView>(go:  this.itemView);
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
                    this.itemView = 1;
                this.RevealFromHoney();
                return;
            }
            
            throw new NullReferenceException();
        }
        public override void RevealFromChain()
        {
            this.RevealFromChain();
            this.TryCollect();
        }
        public BirdItemModel()
        {
        
        }
    
    }

}
