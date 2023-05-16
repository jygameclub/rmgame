using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.GiantBirdItem
{
    public class GiantBirdItemModel : MultipleItemModel, IBirdItemViewDelegate, IBirdItem, IItemViewDelegate
    {
        // Fields
        private Royal.Scenes.Game.Mechanics.Items.GiantBirdItem.View.GiantBirdItemView itemView;
        private Royal.Scenes.Game.Levels.Units.State.GameStateManager stateManager;
        private Royal.Scenes.Game.Mechanics.Items.BirdItem.BirdItemHelper birdItemHelper;
        
        // Properties
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType ItemType { get; }
        
        // Methods
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType get_ItemType()
        {
            return 17;
        }
        public override void CreateFallComponent()
        {
            mem[1152921520301059256] = new Royal.Scenes.Game.Mechanics.Fall.MasterFallComponent(currentItem:  this);
        }
        public override void CreateView(UnityEngine.Vector3 position)
        {
            this.stateManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14);
            Royal.Scenes.Game.Mechanics.Items.BirdItem.BirdItemHelper val_2 = Royal.Scenes.Game.Levels.LevelContext.GetLate<Royal.Scenes.Game.Mechanics.Items.BirdItem.BirdItemHelper>(contextId:  23);
            this.birdItemHelper = val_2;
            val_2.AddBirdOnBoard(item:  this);
            Royal.Scenes.Game.Mechanics.Items.GiantBirdItem.View.GiantBirdItemView val_3 = val_2.Spawn<Royal.Scenes.Game.Mechanics.Items.GiantBirdItem.View.GiantBirdItemView>(poolId:  65, activate:  true);
            this.itemView = val_3;
            val_3.Init(viewDelegate:  this, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
            goto typeof(Royal.Scenes.Game.Mechanics.Items.GiantBirdItem.GiantBirdItemModel).__il2cppRuntimeField_1E0;
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
            return false;
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
        protected override void TryExplode(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            var val_5;
            Royal.Scenes.Game.Mechanics.Items.BirdItem.IBirdItem val_6;
            val_5 = -1484360752;
            val_6 = this;
            if(2810606544 == 6)
            {
                    this.itemView.PlayReactionAnimation();
                val_5 = -1484360752;
            }
            
            if(val_5 != 20)
            {
                    return;
            }
            
            this.birdItemHelper.RemoveBirdOnBoard(item:  this);
            this.stateManager.OperationStart(animationId:  5);
            this.itemView.PlayCollectAnimation();
            val_6 = ???;
            goto typeof(Royal.Scenes.Game.Mechanics.Items.GiantBirdItem.GiantBirdItemModel).__il2cppRuntimeField_350;
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
            this.stateManager.Recycle<Royal.Scenes.Game.Mechanics.Items.GiantBirdItem.View.GiantBirdItemView>(go:  this.itemView);
            Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.Sfx.GameSfxManager>(contextId:  22).PlaySfx(type:  185, offset:  0.04f);
        }
        public bool IsInSameColumn(int column)
        {
            var val_5;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_1 = this.CurrentCell;
            if(W8 == column)
            {
                    val_5 = 1;
                return (bool)(W8 == column) ? 1 : 0;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_3 = this.GetSideMaster().CurrentCell;
            return (bool)(W8 == column) ? 1 : 0;
        }
        public bool IsAbove(Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint point)
        {
            var val_9;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_1 = this.CurrentCell;
            if(point.x == W8)
            {
                    if((point.x >> 32) < (X8 >> 32))
            {
                    val_9 = 1;
                return (bool)val_9;
            }
            
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_5 = this.GetSideMaster().CurrentCell;
            if(point.x == W8)
            {
                    var val_8 = ((point.x >> 32) < (X8 >> 32)) ? 1 : 0;
                return (bool)val_9;
            }
            
            val_9 = 0;
            return (bool)val_9;
        }
        public GiantBirdItemModel()
        {
        
        }
    
    }

}
