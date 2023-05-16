using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.RockItem
{
    public class RockItemModel : ItemModel, IRockItemViewDelegate, IItemViewDelegate
    {
        // Fields
        private Royal.Scenes.Game.Mechanics.Items.RockItem.View.RockItemView itemView;
        
        // Properties
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType ItemType { get; }
        
        // Methods
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType get_ItemType()
        {
            return 27;
        }
        public RockItemModel(int layerCount)
        {
        
        }
        public override void CreateView(UnityEngine.Vector3 position)
        {
            Royal.Scenes.Game.Mechanics.Items.RockItem.View.RockItemView val_1 = 29884.Spawn<Royal.Scenes.Game.Mechanics.Items.RockItem.View.RockItemView>(poolId:  101, activate:  true);
            this.itemView = val_1;
            val_1.Init(viewDelegate:  this, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, layer:  1);
            goto typeof(Royal.Scenes.Game.Mechanics.Items.RockItem.RockItemModel).__il2cppRuntimeField_1E0;
        }
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemView GetItemView()
        {
            return (Royal.Scenes.Game.Mechanics.Items.Config.ItemView)this.itemView;
        }
        public override bool CanExplodeWithNearMatch()
        {
            return (bool)(W8 == 1) ? 1 : 0;
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
            int val_1 = W9 - 1;
            mem[1152921520176423104] = val_1;
            if()
            {
                    this.itemView.Damage(damagedLayer:  val_1, data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id});
                return;
            }
            
            this.itemView.CollectToGoal();
            goto typeof(Royal.Scenes.Game.Mechanics.Items.RockItem.RockItemModel).__il2cppRuntimeField_350;
        }
        public override void CollectAsGoal(bool updateUi = True)
        {
            if(this != null)
            {
                    this.DecreaseGoal(goalType:  updateUi);
                return;
            }
            
            throw new NullReferenceException();
        }
        public void CollectCompleted()
        {
            goto typeof(Royal.Scenes.Game.Mechanics.Items.RockItem.RockItemModel).__il2cppRuntimeField_3C0;
        }
    
    }

}
