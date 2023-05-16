using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SoilItem
{
    public class SoilItemModel : ItemModel, IItemViewDelegate
    {
        // Fields
        private Royal.Scenes.Game.Mechanics.Items.SoilItem.View.SoilItemView itemView;
        private int <SoilGroupId>k__BackingField;
        private int <IndexAmongGroup>k__BackingField;
        private Royal.Scenes.Game.Mechanics.Items.SoilItem.SoilItemHelper soilItemHelper;
        
        // Properties
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType ItemType { get; }
        public int SoilGroupId { get; set; }
        public int IndexAmongGroup { get; set; }
        
        // Methods
        public SoilItemModel(int layerCount)
        {
        
        }
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType get_ItemType()
        {
            return 28;
        }
        public int get_SoilGroupId()
        {
            return (int)this.<SoilGroupId>k__BackingField;
        }
        public void set_SoilGroupId(int value)
        {
            this.<SoilGroupId>k__BackingField = value;
        }
        public int get_IndexAmongGroup()
        {
            return (int)this.<IndexAmongGroup>k__BackingField;
        }
        public void set_IndexAmongGroup(int value)
        {
            this.<IndexAmongGroup>k__BackingField = value;
        }
        public override void CreateView(UnityEngine.Vector3 position)
        {
            Royal.Scenes.Game.Mechanics.Items.SoilItem.SoilItemHelper val_1 = Royal.Scenes.Game.Levels.LevelContext.GetLate<Royal.Scenes.Game.Mechanics.Items.SoilItem.SoilItemHelper>(contextId:  30);
            this.soilItemHelper = val_1;
            val_1.InitSoils();
            Royal.Scenes.Game.Mechanics.Items.SoilItem.View.SoilItemView val_2 = val_1.Spawn<Royal.Scenes.Game.Mechanics.Items.SoilItem.View.SoilItemView>(poolId:  104, activate:  true);
            this.itemView = val_2;
            val_2.Init(itemModel:  this, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, cell:  this.CurrentCell, soilGroupId:  this.<SoilGroupId>k__BackingField);
            goto typeof(Royal.Scenes.Game.Mechanics.Items.SoilItem.SoilItemModel).__il2cppRuntimeField_1E0;
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
        public int GetLayer()
        {
            return (int)this;
        }
        public bool IsLeader()
        {
            if(this.soilItemHelper != null)
            {
                    return this.soilItemHelper.IsLeader(soilGroupId:  this.<SoilGroupId>k__BackingField, soilId:  0);
            }
            
            throw new NullReferenceException();
        }
        protected override void TryExplode(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            int val_1 = true - 1;
            mem[1152921520157675968] = val_1;
            if(val_1 >= 1)
            {
                    this.itemView.Damage(damagedLayer:  val_1);
                return;
            }
            
            Royal.Scenes.Game.Levels.LevelContext.GetLate<Royal.Scenes.Game.Mechanics.Items.SoilItem.SoilItemHelper>(contextId:  30).DestroySoilGroup(soilGroupId:  this.<SoilGroupId>k__BackingField, firstSoil:  this);
        }
        public override bool WillCellBeFreed(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            var val_4;
            if(this.CurrentCell == cell)
            {
                    return (bool)((this.soilItemHelper.GetMinRemainingExplodeCount(soilId:  this.<SoilGroupId>k__BackingField)) < 1) ? 1 : 0;
            }
            
            val_4 = 0;
            return (bool)((this.soilItemHelper.GetMinRemainingExplodeCount(soilId:  this.<SoilGroupId>k__BackingField)) < 1) ? 1 : 0;
        }
        public override int RemainingExplodeCount()
        {
            if((this.soilItemHelper.IsGroupValid(groupId:  this.<SoilGroupId>k__BackingField)) == false)
            {
                    return 0;
            }
            
            return this.RemainingExplodeCount();
        }
        public override void AddIncomingExploder(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            this.AddIncomingExploder(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id});
            this.soilItemHelper.UpdateGroupValidity(soilGroupId:  this.<SoilGroupId>k__BackingField);
        }
        public override bool ShouldTryRedirectForPropeller()
        {
            return true;
        }
        public void Destroy()
        {
            this.itemView.Explode();
            goto typeof(Royal.Scenes.Game.Mechanics.Items.SoilItem.SoilItemModel).__il2cppRuntimeField_350;
        }
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemModel TryRedirectForPropeller()
        {
            if(this.soilItemHelper != null)
            {
                    return this.soilItemHelper.FindLowestLayerSoilInGroup(mySoil:  this);
            }
            
            throw new NullReferenceException();
        }
    
    }

}
