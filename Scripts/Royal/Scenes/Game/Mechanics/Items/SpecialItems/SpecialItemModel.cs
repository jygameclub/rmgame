using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SpecialItems
{
    public abstract class SpecialItemModel : ItemModel, ITapItem, IHintable
    {
        // Fields
        private bool isExploded;
        private bool isActive;
        private bool <IsTapDisabled>k__BackingField;
        private float activeSince;
        protected int remainingMoveCoins;
        private bool <IsSelectedAsHint>k__BackingField;
        
        // Properties
        public bool IsTapDisabled { get; set; }
        public abstract Royal.Scenes.Game.Levels.Units.Touch.MoveType GetMoveType { get; }
        public bool IsSelectedAsHint { get; set; }
        
        // Methods
        public bool get_IsTapDisabled()
        {
            return (bool)this.<IsTapDisabled>k__BackingField;
        }
        public void set_IsTapDisabled(bool value)
        {
            this.<IsTapDisabled>k__BackingField = value;
        }
        protected SpecialItemModel()
        {
            this.isActive = true;
        }
        public Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemView GetSpecialItemView()
        {
            if(this == null)
            {
                    return (Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemView)this;
            }
            
            return (Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemView)this;
        }
        public override void Explode(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            if(this.isExploded != false)
            {
                    return;
            }
            
            if(this.isActive == false)
            {
                    return;
            }
            
            if(null != null)
            {
                    return;
            }
            
            this.isExploded = true;
            if(((-1718489584) > 15) || ((0 & 32780) != 0))
            {
                goto label_5;
            }
            
            label_10:
            this.Explode(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id});
            return;
            label_5:
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_1 = this.CurrentCell;
            if(val_1 == null)
            {
                goto label_10;
            }
            
            val_1.ExplodeTopMostBelowItem(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id});
            goto label_10;
        }
        public override void ExplodeAll(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
        
        }
        public abstract Royal.Scenes.Game.Levels.Units.Touch.MoveType get_GetMoveType(); // 0
        public bool IsExploded()
        {
            return (bool)this.isExploded;
        }
        public override bool IsFallable()
        {
            return true;
        }
        public override bool IsSwappable()
        {
            return (bool)this.isActive;
        }
        public override bool IsSpecialItem()
        {
            return true;
        }
        public void SetSpecialItemActive(bool active)
        {
            this.isActive = active;
            if(active == false)
            {
                    return;
            }
            
            this.activeSince = Royal.Scenes.Game.Levels.LevelContext.Time;
        }
        public float GetActiveDuration()
        {
            float val_1 = Royal.Scenes.Game.Levels.LevelContext.Time;
            val_1 = val_1 - this.activeSince;
            return (float)val_1;
        }
        public bool IsActive()
        {
            return (bool)this.isActive;
        }
        public override bool ShouldAddToGoalOnStart()
        {
            return false;
        }
        public override int GetExplodeScore()
        {
            var val_13;
            int val_6 = 0;
            if((34665.GetGoalLeftCount(goalType:  null)) >= 1)
            {
                    val_13 = this.GetExplodeScore();
            }
            else
            {
                    val_13 = 0;
            }
            
            if((Royal.Scenes.Game.Levels.LevelContext.Has(contextId:  23)) != false)
            {
                    if((Royal.Scenes.Game.Levels.LevelContext.GetLate<Royal.Scenes.Game.Mechanics.Items.BirdItem.BirdItemHelper>(contextId:  23).GetAvailableBirdScoreAboveCell(cellModel:  this.CurrentCell, extra: out  val_6)) >= 1)
            {
                goto label_6;
            }
            
            }
            
            if(((Royal.Scenes.Game.Levels.LevelContext.Has(contextId:  34)) != false) && ((Royal.Scenes.Game.Levels.LevelContext.GetLate<Royal.Scenes.Game.Mechanics.Items.FrogItem.FrogItemHelper>(contextId:  34).GetAvailableFrogScoreAboveCell(cellModel:  this.CurrentCell, extra: out  val_6)) >= 1))
            {
                    label_6:
                var val_13 = val_6;
                val_13 = val_13 + val_13;
                val_13 = val_13 - 1;
            }
            
            int val_12 = this.GetFrogExtraScore();
            val_12 = val_12 + val_13;
            return (int)val_12;
        }
        public void ChangePosition(UnityEngine.Vector3 position)
        {
            this.ChangePosition(position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
        }
        public void Hide()
        {
            this.isActive = false;
            goto typeof(Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemModel).__il2cppRuntimeField_230;
        }
        public void Show()
        {
            this.isActive = true;
            this.Show();
        }
        public virtual bool CanSwapWith(Royal.Scenes.Game.Mechanics.Items.Config.ItemModel model)
        {
            return true;
        }
        public abstract void SwapWith(Royal.Scenes.Game.Mechanics.Items.Config.ItemModel item, Royal.Scenes.Game.Mechanics.Explode.ExplodeData data); // 0
        public abstract bool Tap(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data); // 0
        public bool get_IsSelectedAsHint()
        {
            return (bool)this.<IsSelectedAsHint>k__BackingField;
        }
        private void set_IsSelectedAsHint(bool value)
        {
            this.<IsSelectedAsHint>k__BackingField = value;
        }
        public void StartHintAnimation(bool changeSorting)
        {
            this.<IsSelectedAsHint>k__BackingField = true;
            if(changeSorting == false)
            {
                    return;
            }
            
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_1 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetHintSorting();
            this = ???;
            bool val_2 = val_1.sortEverything & 4294967295;
            goto typeof(Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemModel).__il2cppRuntimeField_1F0;
        }
        public void StopHintAnimation()
        {
            var val_5;
            if(this.CurrentCell == null)
            {
                    return;
            }
            
            val_5 = this;
            this.Reset(force:  false);
            if(null != null)
            {
                    return;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_2 = this.CurrentCell;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_3 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetItemSorting(row:  -1716419664, isReverseSort:  false);
            bool val_4 = val_3.sortEverything & 4294967295;
            goto typeof(Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemModel).__il2cppRuntimeField_1F0;
        }
        public void SetHighlightRatio(float ratio)
        {
        
        }
        public float GetHighlightRatio()
        {
            return 0f;
        }
        public float GetMaxHighlightRatio()
        {
            return 0f;
        }
        public override bool CanFallCross()
        {
            return true;
        }
        public int GetRemainingMovesCoin()
        {
            return (int)this.remainingMoveCoins;
        }
        public void SetRemainingMovesCoin(int coins)
        {
            this.remainingMoveCoins = coins;
        }
    
    }

}
