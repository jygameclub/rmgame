using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.IceCrusherItem
{
    public class IceCrusherFakeItemModel : FakeItemModel<Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.IceCrusherItemModel>
    {
        // Fields
        private readonly Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.View.IceCrusherDirection <Direction>k__BackingField;
        
        // Properties
        public Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.View.IceCrusherDirection Direction { get; }
        public Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.IceCrusherItemModel Master { get; }
        public override bool HasView { get; }
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType ItemType { get; }
        
        // Methods
        public Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.View.IceCrusherDirection get_Direction()
        {
            return (Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.View.IceCrusherDirection)this.<Direction>k__BackingField;
        }
        public Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.IceCrusherItemModel get_Master()
        {
            return (Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.IceCrusherItemModel)this;
        }
        public override bool get_HasView()
        {
            return (bool)(this.CurrentCell != 0) ? 1 : 0;
        }
        public IceCrusherFakeItemModel(Royal.Scenes.Game.Levels.Units.ItemCreation.ItemSettings settings)
        {
            Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.View.IceCrusherDirection val_1;
            if(2782424060 <= 3)
            {
                    val_1 = mem[-1718599952];
            }
            else
            {
                    val_1 = 4;
            }
            
            this.<Direction>k__BackingField = val_1;
        }
        private Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.View.IceCrusherDirection ToLogDirection(Royal.Scenes.Game.Utils.LevelParser.TiledId tiledId)
        {
            if((tiledId - 36) > 3)
            {
                    return 4;
            }
            
            return (Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.View.IceCrusherDirection)36605696 + ((tiledId - 36)) << 2;
        }
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType get_ItemType()
        {
            return 19;
        }
        public override bool CanAllCellsBeBlockedByDrill()
        {
            return false;
        }
        public void SetMaster(Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.IceCrusherItemModel masterItem)
        {
            mem[1152921520274667040] = masterItem;
            masterItem.AddCell(cell:  this.CurrentCell);
        }
        public override UnityEngine.Vector3 GetMasterViewCenterPosition()
        {
            goto typeof(Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.IceCrusherFakeItemModel).__il2cppRuntimeField_390;
        }
    
    }

}
