using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.GiantBirdItem
{
    public class GiantBirdFakeItemModel : ItemModel
    {
        // Fields
        protected Royal.Scenes.Game.Mechanics.Items.GiantBirdItem.GiantBirdItemModel master;
        
        // Properties
        public override bool HasView { get; }
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType ItemType { get; }
        
        // Methods
        public override bool get_HasView()
        {
            if(this.master != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType get_ItemType()
        {
            if(this.master != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
        public GiantBirdFakeItemModel(Royal.Scenes.Game.Levels.Units.ItemCreation.ItemSettings settings)
        {
            this.FindMaster(tiledId:  -1488814608, cell:  settings.goalType);
            if((-1488814608) == 89)
            {
                goto label_1;
            }
            
            if((-1488814608) != 90)
            {
                goto label_2;
            }
            
            1 = 2;
            if(this.master != null)
            {
                goto label_3;
            }
            
            label_2:
            label_1:
            label_3:
            this.master.AddItem(neighborType:  ((-1488814608) == 100) ? 3 : 0, itemModel:  this);
            this.master.add_OnExplodeEvent(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Game.Mechanics.Items.GiantBirdItem.GiantBirdFakeItemModel::<.ctor>b__5_0()));
        }
        private int GetNeighborTypeByTiledId(Royal.Scenes.Game.Utils.LevelParser.TiledId tiledId)
        {
            if(tiledId == 89)
            {
                    return 1;
            }
            
            if(tiledId != 90)
            {
                    return (int)(tiledId == 100) ? 3 : 0;
            }
            
            return 2;
        }
        public override void CreateFallComponent()
        {
            mem[1152921520298183704] = new Royal.Scenes.Game.Mechanics.Fall.FakeFallComponent(masterItem:  this.master);
        }
        protected void FindMaster(Royal.Scenes.Game.Utils.LevelParser.TiledId tiledId, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            var val_2;
            if(tiledId == 89)
            {
                goto label_1;
            }
            
            if(tiledId == 90)
            {
                goto label_2;
            }
            
            if(tiledId != 100)
            {
                    throw new System.ArgumentOutOfRangeException();
            }
            
            val_2 = 7;
            goto label_5;
            label_2:
            val_2 = 6;
            goto label_5;
            label_1:
            val_2 = 5;
            label_5:
            this.SetMaster(cell:  cell, neighborType:  5);
        }
        protected void SetMaster(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, int neighborType)
        {
            this.master = 17651.Get(type:  neighborType).CurrentItem;
        }
        public override void CreateView(UnityEngine.Vector3 position)
        {
        
        }
        public override UnityEngine.Vector3 GetViewPosition()
        {
            return this.CurrentCell.GetViewPosition();
        }
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemView GetItemView()
        {
            if(this.master != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
        public override bool CanExplodeWithNearMatch()
        {
            if(this.master != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
        public override int GetExplodeScore()
        {
            if(this.master != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
        public override bool IsFallable()
        {
            return true;
        }
        public override bool IsAvailableForFall(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel toCell)
        {
            return false;
        }
        public override bool IsSwappable()
        {
            if(this.master != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
        protected override void TryExplode(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
        
        }
        public override void Explode(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
        
        }
        protected void BaseExplode(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            this.Explode(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id});
        }
        protected override void FinalExplodeCompleted(float freezeDuration = 0.15)
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_1 = this.CurrentCell;
            val_1.FreezeFallForDuration(duration:  freezeDuration);
            val_1.ClearFromAllRegisteredCells();
        }
        public override void RecycleView()
        {
            if(this.master != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
        public override void AddIncomingExploder(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
        
        }
        public override void RemoveIncomingExploder(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
        
        }
        public override int RemainingExplodeCount()
        {
            if(this.master != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
        public override bool CanReceiveGrass()
        {
            if(this.master != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
        public override bool CanFallCross()
        {
            if(this.master != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
        private void <.ctor>b__5_0()
        {
            goto typeof(Royal.Scenes.Game.Mechanics.Items.GiantBirdItem.GiantBirdFakeItemModel).__il2cppRuntimeField_350;
        }
    
    }

}
