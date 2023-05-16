using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem
{
    public class MetalCrusherFakeItemModel : FakeItemModel<Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.MetalCrusherItemModel>
    {
        // Fields
        private readonly Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View.MetalCrusherDirection <Direction>k__BackingField;
        
        // Properties
        public Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View.MetalCrusherDirection Direction { get; }
        public Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.MetalCrusherItemModel Master { get; }
        public override bool HasView { get; }
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType ItemType { get; }
        
        // Methods
        public Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View.MetalCrusherDirection get_Direction()
        {
            return (Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View.MetalCrusherDirection)this.<Direction>k__BackingField;
        }
        public Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.MetalCrusherItemModel get_Master()
        {
            return (Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.MetalCrusherItemModel)this;
        }
        public override bool get_HasView()
        {
            return (bool)(this.CurrentCell != 0) ? 1 : 0;
        }
        public MetalCrusherFakeItemModel(Royal.Scenes.Game.Levels.Units.ItemCreation.ItemSettings settings)
        {
            Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View.MetalCrusherDirection val_1;
            if(2724256242 <= 3)
            {
                    val_1 = mem[-1951271224];
            }
            else
            {
                    val_1 = 4;
            }
            
            this.<Direction>k__BackingField = val_1;
        }
        private Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View.MetalCrusherDirection ToMetalCrusherDirection(Royal.Scenes.Game.Utils.LevelParser.TiledId tiledId)
        {
            if((tiledId - 142) > 3)
            {
                    return 4;
            }
            
            return (Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View.MetalCrusherDirection)36605696 + ((tiledId - 142)) << 2;
        }
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType get_ItemType()
        {
            return 32;
        }
        public override bool CanAllCellsBeBlockedByDrill()
        {
            return false;
        }
        public void SetMaster(Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.MetalCrusherItemModel masterItem)
        {
            mem[1152921520216499328] = masterItem;
            masterItem.AddCell(cell:  this.CurrentCell);
        }
        public override UnityEngine.Vector3 GetMasterViewCenterPosition()
        {
            goto typeof(Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.MetalCrusherFakeItemModel).__il2cppRuntimeField_390;
        }
    
    }

}
