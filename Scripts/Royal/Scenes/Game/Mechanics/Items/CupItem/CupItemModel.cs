using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.CupItem
{
    public class CupItemModel : ItemModel, IItemViewDelegate
    {
        // Fields
        private Royal.Scenes.Game.Mechanics.Items.CupItem.View.CupItemView itemView;
        private int <CupShelfId>k__BackingField;
        
        // Properties
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType ItemType { get; }
        public int CupShelfId { get; set; }
        public bool IsDamaged { get; }
        public override bool IsValidTarget { get; }
        
        // Methods
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType get_ItemType()
        {
            return 25;
        }
        public int get_CupShelfId()
        {
            return (int)this.<CupShelfId>k__BackingField;
        }
        public void set_CupShelfId(int value)
        {
            this.<CupShelfId>k__BackingField = value;
        }
        public bool get_IsDamaged()
        {
            return (bool)(W8 == 0) ? 1 : 0;
        }
        public override bool get_IsValidTarget()
        {
            return (bool)(W8 != 0) ? 1 : 0;
        }
        public override void CreateView(UnityEngine.Vector3 position)
        {
            Royal.Scenes.Game.Mechanics.Items.CupItem.CupItemHelper val_1 = Royal.Scenes.Game.Levels.LevelContext.GetLate<Royal.Scenes.Game.Mechanics.Items.CupItem.CupItemHelper>(contextId:  28);
            val_1.InitCups();
            Royal.Scenes.Game.Mechanics.Items.CupItem.View.CupItemView val_2 = val_1.Spawn<Royal.Scenes.Game.Mechanics.Items.CupItem.View.CupItemView>(poolId:  93, activate:  true);
            this.itemView = val_2;
            val_2.Init(itemModel:  this, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, cell:  CurrentCell, cupId:  this.<CupShelfId>k__BackingField);
            goto typeof(Royal.Scenes.Game.Mechanics.Items.CupItem.CupItemModel).__il2cppRuntimeField_1E0;
        }
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemView GetItemView()
        {
            return (Royal.Scenes.Game.Mechanics.Items.Config.ItemView)this.itemView;
        }
        public override bool CanExplodeWithNearMatch()
        {
            return true;
        }
        public override bool IsFallable()
        {
            return false;
        }
        public override bool IsSwappable()
        {
            return false;
        }
        public override bool WillCellBeFreed(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            var val_5;
            if(9869.CurrentCell == cell)
            {
                    return (bool)((Royal.Scenes.Game.Levels.LevelContext.GetLate<Royal.Scenes.Game.Mechanics.Items.CupItem.CupItemHelper>(contextId:  28).GetTotalRemainingExplodeCount(cupShelfId:  this.<CupShelfId>k__BackingField)) < 1) ? 1 : 0;
            }
            
            val_5 = 0;
            return (bool)((Royal.Scenes.Game.Levels.LevelContext.GetLate<Royal.Scenes.Game.Mechanics.Items.CupItem.CupItemHelper>(contextId:  28).GetTotalRemainingExplodeCount(cupShelfId:  this.<CupShelfId>k__BackingField)) < 1) ? 1 : 0;
        }
        protected override void TryExplode(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            bool val_6 = true;
            if(val_6 == 0)
            {
                    return;
            }
            
            val_6 = val_6 - 1;
            mem[1152921523758037552] = val_6;
            this.itemView.Damage();
            Royal.Scenes.Game.Mechanics.Items.CupItem.CupItemHelper val_1 = Royal.Scenes.Game.Levels.LevelContext.GetLate<Royal.Scenes.Game.Mechanics.Items.CupItem.CupItemHelper>(contextId:  28);
            val_1.DamageCup(cupShelfId:  this.<CupShelfId>k__BackingField);
            val_1.DecreaseGoal(goalType:  this.<CupShelfId>k__BackingField);
            this = ???;
            goto typeof(Royal.Scenes.Game.Mechanics.Items.CupItem.CupItemModel).__il2cppRuntimeField_3C0;
        }
        public void Destroy()
        {
            this.itemView.Explode();
            goto typeof(Royal.Scenes.Game.Mechanics.Items.CupItem.CupItemModel).__il2cppRuntimeField_350;
        }
        public override void CollectAsGoal(bool updateUi = True)
        {
        
        }
        public override int GetExplodeScore()
        {
            if(W8 == 0)
            {
                    return 0;
            }
            
            return this.GetExplodeScore();
        }
        public override bool CanSelectByBooster()
        {
            return (bool)(W8 != 0) ? 1 : 0;
        }
        public CupItemModel()
        {
        
        }
    
    }

}
