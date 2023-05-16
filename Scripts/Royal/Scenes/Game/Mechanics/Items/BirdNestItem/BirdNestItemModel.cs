using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.BirdNestItem
{
    public class BirdNestItemModel : MultipleCellItemModel, IItemViewDelegate
    {
        // Fields
        private Royal.Scenes.Game.Mechanics.Items.BirdNestItem.View.BirdNestItemView itemView;
        
        // Properties
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType ItemType { get; }
        
        // Methods
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType get_ItemType()
        {
            return 26;
        }
        public BirdNestItemModel(int layer = 1)
        {
        
        }
        public override void CreateView(UnityEngine.Vector3 position)
        {
            Royal.Scenes.Game.Mechanics.Items.BirdNestItem.View.BirdNestItemView val_1 = 6197.Spawn<Royal.Scenes.Game.Mechanics.Items.BirdNestItem.View.BirdNestItemView>(poolId:  98, activate:  true);
            this.itemView = val_1;
            val_1.Init(birdBoxItemModel:  this, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
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
            if()
            {
                    return;
            }
            
            mem[1152921523856537808] = val_1;
            this.itemView.Damage(newLayer:  val_1);
            if(W8 != 0)
            {
                    return;
            }
            
            this.itemView.Explode();
            this.FinalExplodeCompleted(freezeDuration:  0.15f);
        }
    
    }

}
