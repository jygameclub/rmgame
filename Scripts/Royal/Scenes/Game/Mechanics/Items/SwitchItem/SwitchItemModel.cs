using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SwitchItem
{
    public class SwitchItemModel : ItemModel, ISwitchableDelegate, IItemViewDelegate
    {
        // Fields
        private Royal.Scenes.Game.Mechanics.Items.SwitchItem.View.SwitchItemView itemView;
        private bool isActive;
        
        // Properties
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType ItemType { get; }
        
        // Methods
        public SwitchItemModel(bool startState)
        {
            this.isActive = startState;
        }
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType get_ItemType()
        {
            return 34;
        }
        public override void CreateView(UnityEngine.Vector3 position)
        {
            Royal.Scenes.Game.Mechanics.Items.SwitchItem.View.SwitchItemView val_1 = 35583.Spawn<Royal.Scenes.Game.Mechanics.Items.SwitchItem.View.SwitchItemView>(poolId:  119, activate:  true);
            this.itemView = val_1;
            val_1 = this;
            val_1.PlayInitialState();
            val_1.InitTransform(viewDelegate:  val_1.viewDelegate, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
            Royal.Scenes.Game.Levels.LevelContext.GetLate<Royal.Scenes.Game.Mechanics.Items.SwitchItem.View.SwitchItemHelper>(contextId:  37).AddSwitch(switchItem:  this);
        }
        public void SetState(bool state)
        {
            this.isActive = state;
            if(this.itemView != null)
            {
                    this.itemView.RefreshState();
                return;
            }
            
            throw new NullReferenceException();
        }
        public void CollectCompleted()
        {
            goto typeof(Royal.Scenes.Game.Mechanics.Items.SwitchItem.SwitchItemModel).__il2cppRuntimeField_3C0;
        }
        public bool GetState()
        {
            return (bool)this.isActive;
        }
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemView GetItemView()
        {
            return (Royal.Scenes.Game.Mechanics.Items.Config.ItemView)this.itemView;
        }
        public override bool CanExplodeWithNearMatch()
        {
            return (bool)this.isActive;
        }
        public override bool IsFallable()
        {
            return true;
        }
        public override bool IsSwappable()
        {
            return true;
        }
        protected override void TryExplode(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            if((this.isActive != true) && ((1152921520011844576 & 1) == 0))
            {
                    if((Royal.Scenes.Game.Mechanics.Explode.TriggerExtensions.IsBooster(trigger:  -1774867536)) == false)
            {
                    return;
            }
            
            }
            
            Royal.Scenes.Game.Levels.LevelContext.GetLate<Royal.Scenes.Game.Mechanics.Items.SwitchItem.View.SwitchItemHelper>(contextId:  37).RemoveSwitch(switchItem:  this);
            this.itemView.Explode();
            this = ???;
            goto typeof(Royal.Scenes.Game.Mechanics.Items.SwitchItem.SwitchItemModel).__il2cppRuntimeField_350;
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
        public override int GetExplodeScore()
        {
            if(this.isActive == false)
            {
                    return 0;
            }
            
            return this.GetExplodeScore();
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
        public override void RevealFromCurtain()
        {
            this.RevealFromCurtain();
            this.itemView.PlayInitialState();
        }
        public override int RemainingExplodeCount()
        {
            if(this.isActive == false)
            {
                    return 0;
            }
            
            return this.RemainingExplodeCount();
        }
        public override bool WillCellBeFreed(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            if(cell.CurrentItem != this)
            {
                    return false;
            }
            
            if(this > 0)
            {
                    return false;
            }
            
            var val_2 = (this.isActive == true) ? 1 : 0;
            return false;
        }
    
    }

}
