using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.OwlStatueItem
{
    public class OwlStatueItemModel : ItemModel, IItemViewDelegate
    {
        // Fields
        private Royal.Scenes.Game.Mechanics.Items.OwlStatueItem.View.OwlStatueItemView itemView;
        
        // Properties
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType ItemType { get; }
        
        // Methods
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType get_ItemType()
        {
            return 10;
        }
        public OwlStatueItemModel(int layer)
        {
        
        }
        public override void CreateView(UnityEngine.Vector3 position)
        {
            Royal.Scenes.Game.Mechanics.Items.OwlStatueItem.View.OwlStatueItemView val_1 = 26386.Spawn<Royal.Scenes.Game.Mechanics.Items.OwlStatueItem.View.OwlStatueItemView>(poolId:  46, activate:  true);
            this.itemView = val_1;
            val_1.Init(viewDelegate:  this, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, layer:  1);
            goto typeof(Royal.Scenes.Game.Mechanics.Items.OwlStatueItem.OwlStatueItemModel).__il2cppRuntimeField_1E0;
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
            return false;
        }
        public override bool IsSwappable()
        {
            return false;
        }
        protected override void TryExplode(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            int val_1 = W8 - 1;
            mem[1152921520213010912] = val_1;
            if()
            {
                    this.itemView.Damage(damagedLayer:  val_1);
                return;
            }
            
            this.itemView.Explode();
            goto typeof(Royal.Scenes.Game.Mechanics.Items.OwlStatueItem.OwlStatueItemModel).__il2cppRuntimeField_350;
        }
    
    }

}
