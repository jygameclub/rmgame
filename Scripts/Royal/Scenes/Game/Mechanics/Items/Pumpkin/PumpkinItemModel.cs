using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.Pumpkin
{
    public class PumpkinItemModel : ItemModel, IItemViewDelegate
    {
        // Fields
        private Royal.Scenes.Game.Mechanics.Items.Pumpkin.View.PumpkinItemView itemView;
        public const int LayerCount = 2;
        
        // Properties
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType ItemType { get; }
        
        // Methods
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType get_ItemType()
        {
            return 36;
        }
        public PumpkinItemModel()
        {
        
        }
        public override void CreateView(UnityEngine.Vector3 position)
        {
            Royal.Scenes.Game.Mechanics.Items.Pumpkin.View.PumpkinItemView val_1 = 28328.Spawn<Royal.Scenes.Game.Mechanics.Items.Pumpkin.View.PumpkinItemView>(poolId:  124, activate:  true);
            this.itemView = val_1;
            val_1.Init(viewDelegate:  this, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, layer:  1);
            goto typeof(Royal.Scenes.Game.Mechanics.Items.Pumpkin.PumpkinItemModel).__il2cppRuntimeField_1E0;
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
            int val_1 = true - 1;
            mem[1152921520185131904] = val_1;
            if()
            {
                    this.itemView.Damage(damagedLayer:  val_1, data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id});
                return;
            }
            
            this.itemView.Explode();
            Royal.Scenes.Game.Mechanics.Items.CaldronItem.CaldronItemHelper val_2 = Royal.Scenes.Game.Levels.LevelContext.GetLate<Royal.Scenes.Game.Mechanics.Items.CaldronItem.CaldronItemHelper>(contextId:  38);
            if(val_2 == null)
            {
                    return;
            }
            
            val_2.DecrementThrownItemOnBoard();
        }
    
    }

}
