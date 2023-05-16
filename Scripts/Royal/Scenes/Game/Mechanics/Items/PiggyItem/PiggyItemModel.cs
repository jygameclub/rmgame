using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.PiggyItem
{
    public class PiggyItemModel : ItemModel, IItemViewDelegate, ITapItem
    {
        // Fields
        private Royal.Scenes.Game.Mechanics.Items.PiggyItem.View.PiggyItemView itemView;
        private bool <IsTapDisabled>k__BackingField;
        
        // Properties
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType ItemType { get; }
        public Royal.Scenes.Game.Levels.Units.Touch.MoveType GetMoveType { get; }
        public bool IsTapDisabled { get; set; }
        
        // Methods
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType get_ItemType()
        {
            return 20;
        }
        public Royal.Scenes.Game.Levels.Units.Touch.MoveType get_GetMoveType()
        {
            return 0;
        }
        public override void CreateView(UnityEngine.Vector3 position)
        {
            Royal.Scenes.Game.Mechanics.Items.PiggyItem.View.PiggyItemView val_1 = 27034.Spawn<Royal.Scenes.Game.Mechanics.Items.PiggyItem.View.PiggyItemView>(poolId:  75, activate:  true);
            this.itemView = val_1;
            val_1.InitTransform(viewDelegate:  this, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
            goto typeof(Royal.Scenes.Game.Mechanics.Items.PiggyItem.PiggyItemModel).__il2cppRuntimeField_1E0;
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
            return true;
        }
        public override bool IsSwappable()
        {
            return true;
        }
        protected override void TryExplode(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            this.itemView.Explode();
            goto typeof(Royal.Scenes.Game.Mechanics.Items.PiggyItem.PiggyItemModel).__il2cppRuntimeField_350;
        }
        public bool Tap(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            return false;
        }
        public bool get_IsTapDisabled()
        {
            return (bool)this.<IsTapDisabled>k__BackingField;
        }
        public void set_IsTapDisabled(bool value)
        {
            this.<IsTapDisabled>k__BackingField = value;
        }
        public PiggyItemModel()
        {
        
        }
    
    }

}
