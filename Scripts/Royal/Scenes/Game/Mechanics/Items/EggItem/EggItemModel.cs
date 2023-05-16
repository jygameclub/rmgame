using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.EggItem
{
    public class EggItemModel : ItemModel, IItemViewDelegate
    {
        // Fields
        private Royal.Scenes.Game.Mechanics.Items.EggItem.View.EggItemView itemView;
        
        // Properties
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType ItemType { get; }
        
        // Methods
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType get_ItemType()
        {
            return 9;
        }
        public override void CreateView(UnityEngine.Vector3 position)
        {
            Royal.Scenes.Game.Mechanics.Items.EggItem.View.EggItemView val_1 = 13630.Spawn<Royal.Scenes.Game.Mechanics.Items.EggItem.View.EggItemView>(poolId:  44, activate:  true);
            this.itemView = val_1;
            val_1.InitTransform(viewDelegate:  this, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
            goto typeof(Royal.Scenes.Game.Mechanics.Items.EggItem.EggItemModel).__il2cppRuntimeField_1E0;
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
            return true;
        }
        public override bool IsSwappable()
        {
            return true;
        }
        protected override void TryExplode(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            this.itemView.Explode();
            goto typeof(Royal.Scenes.Game.Mechanics.Items.EggItem.EggItemModel).__il2cppRuntimeField_350;
        }
        public EggItemModel()
        {
        
        }
    
    }

}
