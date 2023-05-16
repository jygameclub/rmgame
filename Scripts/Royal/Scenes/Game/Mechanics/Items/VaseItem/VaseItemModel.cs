using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.VaseItem
{
    public class VaseItemModel : ItemModel, IItemViewDelegate
    {
        // Fields
        private Royal.Scenes.Game.Mechanics.Items.VaseItem.View.VaseItemView itemView;
        
        // Properties
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType ItemType { get; }
        
        // Methods
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType get_ItemType()
        {
            return 7;
        }
        public VaseItemModel(int layerCount)
        {
        
        }
        public override void CreateView(UnityEngine.Vector3 position)
        {
            Royal.Scenes.Game.Mechanics.Items.VaseItem.View.VaseItemView val_1 = 41650.Spawn<Royal.Scenes.Game.Mechanics.Items.VaseItem.View.VaseItemView>(poolId:  33, activate:  true);
            this.itemView = val_1;
            val_1.Init(viewDelegate:  this, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, layer:  1);
            goto typeof(Royal.Scenes.Game.Mechanics.Items.VaseItem.VaseItemModel).__il2cppRuntimeField_1E0;
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
            int val_1 = W9 - 1;
            mem[1152921520006448032] = val_1;
            if()
            {
                    this.itemView.Damage(damagedLayer:  val_1, data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id});
                return;
            }
            
            this.itemView.Explode();
            goto typeof(Royal.Scenes.Game.Mechanics.Items.VaseItem.VaseItemModel).__il2cppRuntimeField_350;
        }
    
    }

}
