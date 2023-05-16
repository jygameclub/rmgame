using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.Config
{
    public abstract class FakeItemModel<T> : MultipleCellItemModel
    {
        // Fields
        protected T master;
        
        // Properties
        public override bool HasView { get; }
        
        // Methods
        public override bool get_HasView()
        {
            if(this != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
        protected FakeItemModel<T>(Royal.Scenes.Game.Levels.Units.ItemCreation.ItemSettings settings)
        {
            null = null;
            if(==0)
            {
                    return;
            }
            
            AddCell(cell:  settings.goalType);
            settings.goalType.add_OnExplodeEvent(value:  new System.Action(object:  this, method:  __RuntimeMethodHiddenParam + 24 + 192 + 16));
        }
        protected virtual void FindMaster(Royal.Scenes.Game.Utils.LevelParser.TiledId tiledId, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
        
        }
        protected void SetMaster(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, int neighborType)
        {
            var val_3;
            if((this.Get(type:  neighborType).CurrentItem) != null)
            {
                    if(X0 == true)
            {
                goto label_5;
            }
            
            }
            
            val_3 = 0;
            label_5:
            mem[1152921523779440096] = val_3;
        }
        public override bool WillCellBeFreed(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            if(this != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
        public override int GetExtraExplodeCount()
        {
            if(this != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
        public override Royal.Scenes.Game.Mechanics.Matches.Cell14 GetAllCells()
        {
            if(this != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
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
            if(this != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
        public override bool CanExplodeWithNearMatch()
        {
            if(this != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
        public override int GetExplodeScore()
        {
            if(this != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
        public override bool IsFallable()
        {
            return false;
        }
        public override bool IsAvailableForFall(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel toCell)
        {
            if(this != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
        public override bool IsSwappable()
        {
            if(this != null)
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
        public override void ExplodeAll(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
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
            if(this != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
        public override void AddIncomingExploder(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            if((1995053792 > 13) || ((0 & 11264) != 0))
            {
                    return;
            }
            
            this.AddNonExtraIncomingExploder(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id});
            this.AddToIncoming(id:  268435460, trigger:  1995053792);
        }
        public override void RemoveIncomingExploder(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            if((1995190304 > 13) || ((0 & 11264) != 0))
            {
                    return;
            }
            
            this.RemoveNonExtraIncomingExploder(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id});
            this.RemoveFromIncoming(id:  268435460, trigger:  1995190304);
        }
        public override int RemainingExplodeCount()
        {
            if(this != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
        public override bool CanReceiveGrass()
        {
            if(this != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
        private void <.ctor>b__3_0()
        {
            if(this != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
    
    }

}
