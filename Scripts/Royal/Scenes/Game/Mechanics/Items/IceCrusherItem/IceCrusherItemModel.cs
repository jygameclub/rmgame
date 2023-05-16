using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.IceCrusherItem
{
    public class IceCrusherItemModel : MultipleCellItemModel, IIceCrusherItemViewDelegate, IItemViewDelegate
    {
        // Fields
        private Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.IceCrusherItemHelper iceCrusherHelper;
        private Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.View.IceCrusherItemView itemView;
        private Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.View.IceCrusherDirection iceCrusherDirection;
        
        // Properties
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType ItemType { get; }
        
        // Methods
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType get_ItemType()
        {
            return 19;
        }
        public IceCrusherItemModel(int layer = 0)
        {
            layer.add_OnCellGridItemsInitialized(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.IceCrusherItemModel::GridInitialized()));
        }
        public override bool WillCellBeFreed(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            var val_7;
            Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.View.IceCrusherDirection val_7 = this.iceCrusherDirection;
            if((val_7 - 3) >= 2)
            {
                    val_7 = val_7 - 1;
                if(val_7 > 1)
            {
                    return (bool)((UnityEngine.Mathf.Abs(value:  47595520 - cell)) > this) ? 1 : 0;
            }
            
                Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_2 = this.CurrentCell;
                val_7 = 1152921504781234176;
            }
            else
            {
                    Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_3 = this.CurrentCell;
                val_7 = 1152921504781234176;
            }
            
            return (bool)((UnityEngine.Mathf.Abs(value:  47595520 - cell)) > this) ? 1 : 0;
        }
        private void GridInitialized()
        {
            remove_OnCellGridItemsInitialized(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.IceCrusherItemModel::GridInitialized()));
            this.FindDirection();
            this.FindFakeItems();
            Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.IceCrusherItemHelper val_2 = Royal.Scenes.Game.Levels.LevelContext.GetLate<Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.IceCrusherItemHelper>(contextId:  25);
            this.iceCrusherHelper = val_2;
            val_2.Add(item:  this);
        }
        private void FindDirection()
        {
            var val_5;
            var val_6;
            var val_7;
            val_5 = 0;
            goto label_1;
            label_20:
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_2 = this.CurrentCell.Get(type:  Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors.TouchingNeighborTypes + 32);
            if(((val_2 == null) || (val_2.HasCurrentItem() == false)) || (val_2.CurrentItem == null))
            {
                goto label_13;
            }
            
            if(1152921505099816959 <= 3)
            {
                    val_6 = mem[2008485644];
            }
            else
            {
                    val_6 = 1;
            }
            
            if(val_6 == (Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors.TouchingNeighborTypes + 32))
            {
                goto label_16;
            }
            
            label_13:
            val_5 = 1;
            label_1:
            val_7 = null;
            val_7 = null;
            if(val_5 < Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors.TouchingNeighborTypes.Length)
            {
                goto label_20;
            }
            
            return;
            label_16:
            this.iceCrusherDirection = null;
        }
        private void FindFakeItems()
        {
            var val_6;
            var val_7;
            Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.View.IceCrusherDirection val_6 = this.iceCrusherDirection;
            val_6 = val_6 - 1;
            if(val_6 <= 3)
            {
                    val_6 = mem[36605712 + ((this.iceCrusherDirection - 1)) << 2];
                val_6 = 36605712 + ((this.iceCrusherDirection - 1)) << 2;
            }
            else
            {
                    val_6 = 1;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_2 = this.CurrentCell.Get(type:  1);
            if(val_2 == null)
            {
                    return;
            }
            
            val_7 = val_2;
            do
            {
                if(val_2.HasCurrentItem() == false)
            {
                    return;
            }
            
                Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_4 = val_7.CurrentItem;
                if((val_4 != null) && (null == this.iceCrusherDirection))
            {
                    val_4.SetMaster(masterItem:  this);
                mem[1152921520276694384] = 1152921505099816961;
            }
            
                Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_5 = val_4.Get(type:  1);
                val_7 = val_5;
            }
            while(val_5 != null);
        
        }
        private int ConvertToNeighborType(Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.View.IceCrusherDirection direction)
        {
            if((direction - 1) > 3)
            {
                    return 1;
            }
            
            return (int)36605712 + ((direction - 1)) << 2;
        }
        public override void CreateView(UnityEngine.Vector3 position)
        {
            Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.View.IceCrusherItemView val_1 = 19479.Spawn<Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.View.IceCrusherItemView>(poolId:  72, activate:  true);
            this.itemView = val_1;
            val_1.Init(viewDelegate:  this, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, layer:  1, iceCrusherDirection:  this.iceCrusherDirection);
            goto typeof(Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.IceCrusherItemModel).__il2cppRuntimeField_1E0;
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
        public override bool CanAllCellsBeBlockedByDrill()
        {
            return false;
        }
        protected override void TryExplode(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            if(data.point.x == 0)
            {
                    return;
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_1 = CurrentItem;
            if(val_1 != null)
            {
                    val_1.CurrentCell.FreezeFall();
                val_1.itemMediator.ClearFromAllRegisteredCells();
            }
            
            mem[1152921520277677376] = ((Royal.Scenes.Game.Mechanics.Items.Config.ItemModel.__il2cppRuntimeField_typeHierarchy + (Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.IceCrusherFakeItemModel.__il2cppRuntimeField_typeHierarchyDe;
            this.itemView = (float)((Royal.Scenes.Game.Mechanics.Items.Config.ItemModel.__il2cppRuntimeField_typeHierarchy + (Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.IceCrusherFakeItemModel.__il2cppRuntimeField_typeHierarchyDe;
        }
        public override void ExplodeAll(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
        
        }
        public void FinalExplode()
        {
            this.iceCrusherHelper.Remove(item:  this);
            goto typeof(Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.IceCrusherItemModel).__il2cppRuntimeField_350;
        }
        public void UnfreezeLayer(int layerIndex)
        {
            int val_2;
            var val_3;
            var val_5;
            HashSet.Enumerator<T> val_1 = 16824064.GetEnumerator();
            label_7:
            if(((-1508653648) & 1) == 0)
            {
                goto label_3;
            }
            
            if(==0)
            {
                    throw new NullReferenceException();
            }
            
            if(val_2 == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_5 = mem[val_2 + 40];
            val_5 = val_2 + 40;
            if(val_5 == 0)
            {
                    throw new NullReferenceException();
            }
            
            bool val_4 = val_5.RemoveExploder(id:  val_2);
            goto label_7;
            label_3:
            val_3.Dispose();
            UnFreezeFall();
        }
        public bool IsVertical()
        {
            Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.View.IceCrusherDirection val_2 = this.iceCrusherDirection;
            val_2 = val_2 - 3;
            return (bool)(val_2 < 2) ? 1 : 0;
        }
        public int GetLayer()
        {
            return (int)this;
        }
        public bool IsHorizontal()
        {
            Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.View.IceCrusherDirection val_2 = this.iceCrusherDirection;
            val_2 = val_2 - 1;
            return (bool)(val_2 < 2) ? 1 : 0;
        }
    
    }

}
