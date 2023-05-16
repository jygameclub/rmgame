using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.BoxItem
{
    public class BoxItemModel : ItemModel, IItemViewDelegate
    {
        // Fields
        private Royal.Scenes.Game.Mechanics.Items.BoxItem.View.BoxItemView itemView;
        
        // Properties
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType ItemType { get; }
        
        // Methods
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType get_ItemType()
        {
            return 6;
        }
        public BoxItemModel(int layerCount)
        {
        
        }
        public override void CreateView(UnityEngine.Vector3 position)
        {
            Royal.Scenes.Game.Mechanics.Items.BoxItem.View.BoxItemView val_1 = 6433.Spawn<Royal.Scenes.Game.Mechanics.Items.BoxItem.View.BoxItemView>(poolId:  31, activate:  true);
            this.itemView = val_1;
            val_1.Init(viewDelegate:  this, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, layer:  1);
            this.HasView = true;
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
        protected override void TryExplode(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            int val_1 = W8 - 1;
            mem[1152921523847135472] = val_1;
            if()
            {
                    this.itemView.Damage(damagedLayer:  val_1);
                return;
            }
            
            this.itemView.Explode();
            this.FinalExplodeCompleted(freezeDuration:  0.15f);
        }
    
    }

}
