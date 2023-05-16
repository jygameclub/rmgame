using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem
{
    public class CurtainItemModel : StaticItemModel
    {
        // Fields
        private Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View.CurtainItemView <ItemView>k__BackingField;
        private readonly int <CurtainId>k__BackingField;
        private bool isItemHidden;
        
        // Properties
        public Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View.CurtainItemView ItemView { get; set; }
        public int CurtainId { get; }
        
        // Methods
        public Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View.CurtainItemView get_ItemView()
        {
            return (Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View.CurtainItemView)this.<ItemView>k__BackingField;
        }
        private void set_ItemView(Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View.CurtainItemView value)
        {
            this.<ItemView>k__BackingField = value;
        }
        public int get_CurtainId()
        {
            return (int)this.<CurtainId>k__BackingField;
        }
        public CurtainItemModel(int curtainId)
        {
            this.<CurtainId>k__BackingField = curtainId;
        }
        public override void CreateView(UnityEngine.Vector3 position)
        {
            Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View.CurtainItemView val_1 = 9949.Spawn<Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View.CurtainItemView>(poolId:  77, activate:  true);
            this.<ItemView>k__BackingField = val_1;
            val_1.Init(position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, cell:  77);
            mem[1152921520045451872] = 1;
        }
        public override Royal.Scenes.Game.Mechanics.Items.Config.StaticItemView GetItemView()
        {
            return (Royal.Scenes.Game.Mechanics.Items.Config.StaticItemView)this.<ItemView>k__BackingField;
        }
        protected override void TryExplode(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            if((-1740975632) != 22)
            {
                    return;
            }
            
            this.<ItemView>k__BackingField.Explode();
            this.<ItemView>k__BackingField = 0;
            this.RevealItemsUnder();
            this.FinalExplodeCompleted();
        }
        public override bool DoesBlockTouch()
        {
            return true;
        }
        public override bool DoesBlockVisibility()
        {
            return true;
        }
        public override bool DoesBlockFall()
        {
            return true;
        }
        public override bool DoesBlockPropeller()
        {
            return true;
        }
        public void HideItemsUnder()
        {
            var val_3;
            var val_4;
            val_3 = this;
            if(this.isItemHidden == true)
            {
                    return;
            }
            
            this.isItemHidden = true;
            val_4 = 0;
            if((this.isItemHidden + 32.HasCurrentItem()) != false)
            {
                    Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_2 = this.isItemHidden + 32.CurrentItem;
            }
            
            var val_3 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_4 = mem[(Royal.Scenes.Game.Mechanics.Items.Config.ItemModel.__il2cppRuntimeField_element_class + 48 + 16 + 0) + 32 + 496 + 8];
            val_4 = (Royal.Scenes.Game.Mechanics.Items.Config.ItemModel.__il2cppRuntimeField_element_class + 48 + 16 + 0) + 32 + 496 + 8;
            val_3 = val_3 + 1;
            val_3 = mem[Royal.Scenes.Game.Mechanics.Items.Config.ItemModel.__il2cppRuntimeField_element_class + 48 + 24 + 64 + 56];
            val_3 = Royal.Scenes.Game.Mechanics.Items.Config.ItemModel.__il2cppRuntimeField_element_class + 48 + 24 + 64 + 56;
            var val_4 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_4 = val_4 + 1;
        }
        public void RevealItemsUnder()
        {
            var val_3;
            var val_4;
            val_3 = this;
            if(this.isItemHidden == false)
            {
                    return;
            }
            
            this.isItemHidden = false;
            val_4 = 0;
            bool val_1 = this.isItemHidden + 32.HasCurrentItem();
            if(val_1 != false)
            {
                    Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_2 = val_1.CurrentItem;
            }
            
            var val_3 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_4 = mem[(Royal.Scenes.Game.Mechanics.Items.Config.ItemModel.__il2cppRuntimeField_element_class + 48 + 16 + 0) + 32 + 520];
            val_4 = (Royal.Scenes.Game.Mechanics.Items.Config.ItemModel.__il2cppRuntimeField_element_class + 48 + 16 + 0) + 32 + 520;
            val_3 = val_3 + 1;
            val_3 = mem[Royal.Scenes.Game.Mechanics.Items.Config.ItemModel.__il2cppRuntimeField_element_class + 48 + 24 + 64 + 56];
            val_3 = Royal.Scenes.Game.Mechanics.Items.Config.ItemModel.__il2cppRuntimeField_element_class + 48 + 24 + 64 + 56;
            var val_4 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_4 = val_4 + 1;
        }
        public override bool CanSelectByBooster()
        {
            return false;
        }
    
    }

}
