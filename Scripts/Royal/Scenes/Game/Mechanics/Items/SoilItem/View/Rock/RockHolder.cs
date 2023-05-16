using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SoilItem.View.Rock
{
    public abstract class RockHolder : MonoBehaviour
    {
        // Fields
        protected const int NotEdge = 0;
        protected const int LeftEdge = 1;
        protected const int RightEdge = 2;
        public int edgeStatus;
        public UnityEngine.SpriteRenderer spriteRenderer;
        
        // Methods
        public void UpdateSorting(Royal.Scenes.Game.Mechanics.Sortings.SortingData sortingData)
        {
            sortingData.sortEverything = sortingData.sortEverything & 4294967295;
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.spriteRenderer, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = sortingData.sortEverything});
        }
        public virtual bool Randomize(Royal.Scenes.Game.Mechanics.Items.SoilItem.View.SoilItemView soilItemView, Royal.Scenes.Game.Mechanics.Items.SoilItem.View.SoilItemAssets soilItemAssets, Royal.Infrastructure.Utils.Randoming.RandomManager randomManager, Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors cellNeighbors, int soilGroupId)
        {
            this.CalculateEdgeStatus(randomManager:  randomManager, soilGroupId:  soilGroupId, neighbors:  cellNeighbors);
            return false;
        }
        protected void RandomizeValidPosition(Royal.Scenes.Game.Mechanics.Items.SoilItem.View.SoilItemView soilItemView, Royal.Infrastructure.Utils.Randoming.RandomManager randomManager, Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors cellNeighbors, int soilGroupId, bool isEdgeConfig)
        {
            var val_34;
            float val_36;
            float val_37;
            bool val_1 = this.NeighborIsSoil(soilGroupId:  soilGroupId, cellNeighbors:  cellNeighbors, cellNeighborType:  7);
            bool val_2 = val_1.NeighborIsSoil(soilGroupId:  soilGroupId, cellNeighbors:  cellNeighbors, cellNeighborType:  3);
            bool val_3 = val_2.NeighborIsSoil(soilGroupId:  soilGroupId, cellNeighbors:  cellNeighbors, cellNeighborType:  5);
            bool val_4 = val_3.NeighborIsSoil(soilGroupId:  soilGroupId, cellNeighbors:  cellNeighbors, cellNeighborType:  1);
            bool val_5 = val_4.NeighborIsSoil(soilGroupId:  soilGroupId, cellNeighbors:  cellNeighbors, cellNeighborType:  0);
            bool val_6 = val_5.NeighborIsSoil(soilGroupId:  soilGroupId, cellNeighbors:  cellNeighbors, cellNeighborType:  2);
            bool val_7 = val_6.NeighborIsSoil(soilGroupId:  soilGroupId, cellNeighbors:  cellNeighbors, cellNeighborType:  6);
            float val_11 = (val_3 != true) ? -0.5f : -0.3f;
            val_34 = 0;
            var val_34 = 0;
            float val_12 = (val_4 != true) ? 0.5f : 0.3f;
            goto label_25;
            label_5:
            val_36 = randomManager.Next(min:  ((val_7.NeighborIsSoil(soilGroupId:  soilGroupId, cellNeighbors:  cellNeighbors, cellNeighborType:  4)) != true) ? -0.4f : (val_11), max:  (val_6 != true) ? 0.4f : (val_12));
            val_34 = 1;
            val_37 = 0.5f;
            goto label_8;
            label_25:
            if(isEdgeConfig == false)
            {
                goto label_6;
            }
            
            if(this.edgeStatus == 2)
            {
                goto label_5;
            }
            
            if(this.edgeStatus != 1)
            {
                goto label_6;
            }
            
            val_36 = randomManager.Next(min:  (val_7 != true) ? -0.4f : (val_11), max:  (val_5 != true) ? 0.4f : (val_12));
            val_37 = -0.5f;
            goto label_8;
            label_6:
            val_37 = randomManager.Next(min:  (val_1 != true) ? -0.5f : -0.3f, max:  (val_2 != true) ? 0.5f : 0.3f);
            val_36 = randomManager.Next(min:  val_11, max:  val_12);
            label_8:
            this.spriteRenderer.flipX = val_34 & 1;
            UnityEngine.Vector2 val_23 = new UnityEngine.Vector2(x:  val_37, y:  val_36);
            UnityEngine.Vector3 val_24 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_23.x, y = val_23.y});
            this.spriteRenderer.transform.localPosition = new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z};
            if((((((((this.IntersectsWithBounds(bounds:  soilItemView.bounds)) != true) && ((this.IntersectsWithNeighbor(cellNeighbors:  cellNeighbors, cellNeighborType:  7)) != true)) && ((this.IntersectsWithNeighbor(cellNeighbors:  cellNeighbors, cellNeighborType:  0)) != true)) && ((this.IntersectsWithNeighbor(cellNeighbors:  cellNeighbors, cellNeighborType:  1)) != true)) && ((this.IntersectsWithNeighbor(cellNeighbors:  cellNeighbors, cellNeighborType:  2)) != true)) && ((this.IntersectsWithNeighbor(cellNeighbors:  cellNeighbors, cellNeighborType:  3)) != true)) && ((this.IntersectsWithNeighbor(cellNeighbors:  cellNeighbors, cellNeighborType:  4)) != true))
            {
                    if((this.IntersectsWithNeighbor(cellNeighbors:  cellNeighbors, cellNeighborType:  5)) != true)
            {
                    if((this.IntersectsWithNeighbor(cellNeighbors:  cellNeighbors, cellNeighborType:  6)) == false)
            {
                    return;
            }
            
            }
            
            }
            
            val_34 = val_34 + 1;
            if(val_34 < 9)
            {
                goto label_25;
            }
            
            this.spriteRenderer.sprite = 0;
        }
        private bool NeighborIsSoil(int soilGroupId, Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors cellNeighbors, int cellNeighborType)
        {
            var val_5;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_1 = cellNeighbors.Get(type:  cellNeighborType);
            if(val_1 == null)
            {
                    return (bool)val_5;
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_2 = val_1.CurrentItem;
            if(val_2 == null)
            {
                    return (bool)val_5;
            }
            
            var val_3 = (((Royal.Scenes.Game.Mechanics.Items.Config.ItemModel.__il2cppRuntimeField_typeHierarchy + (Royal.Scenes.Game.Mechanics.Items.SoilItem.SoilItemModel.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_2) : 0;
            val_5 = 0;
            return (bool)val_5;
        }
        private bool IntersectsWithSelf(Royal.Scenes.Game.Mechanics.Items.SoilItem.View.SoilItemView soilItemView)
        {
            if(soilItemView != null)
            {
                    return this.IntersectsWithBounds(bounds:  soilItemView.bounds);
            }
            
            throw new NullReferenceException();
        }
        private bool IntersectsWithNeighbor(Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors cellNeighbors, int cellNeighborType)
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_1 = cellNeighbors.Get(type:  cellNeighborType);
            return this.IntersectsWithBounds(bounds:  val_1.GetNeighborBounds(neighbor:  val_1));
        }
        private bool IntersectsWithBounds(UnityEngine.Bounds[] bounds)
        {
            if((bounds == null) || (bounds.Length < 1))
            {
                    return false;
            }
            
            var val_7 = 0;
            do
            {
                if(this.spriteRenderer.sprite != 0)
            {
                    UnityEngine.Bounds val_3 = this.spriteRenderer.bounds;
                if((bounds[32] & 1) != 0)
            {
                    return false;
            }
            
            }
            
                val_7 = val_7 + 1;
            }
            while(val_7 < bounds.Length);
            
            return false;
        }
        private void CalculateEdgeStatus(Royal.Infrastructure.Utils.Randoming.RandomManager randomManager, int soilGroupId, Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors neighbors)
        {
            int val_5;
            bool val_1 = this.NeighborIsSoil(soilGroupId:  soilGroupId, cellNeighbors:  neighbors, cellNeighborType:  7);
            bool val_2 = val_1.NeighborIsSoil(soilGroupId:  soilGroupId, cellNeighbors:  neighbors, cellNeighborType:  3);
            if((val_1 == true) || (val_2 == true))
            {
                goto label_1;
            }
            
            var val_4 = ((randomManager.NextBool() & true) != 0) ? (1 + 1) : 1;
            goto label_8;
            label_1:
            if(val_1 == false)
            {
                goto label_5;
            }
            
            if(val_2 == false)
            {
                goto label_6;
            }
            
            this.edgeStatus = 0;
            return;
            label_5:
            val_5 = 1;
            goto label_8;
            label_6:
            val_5 = 2;
            label_8:
            this.edgeStatus = val_5;
        }
        protected UnityEngine.Bounds[] GetNeighborBounds(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel neighbor)
        {
            var val_3;
            if(neighbor != null)
            {
                    Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_1 = neighbor.CurrentItem;
                if(val_1 == null)
            {
                    return (UnityEngine.Bounds[])val_3;
            }
            
                if(val_1 == null)
            {
                    return (UnityEngine.Bounds[])val_3;
            }
            
            }
            
            val_3 = 0;
            return (UnityEngine.Bounds[])val_3;
        }
        protected bool NeighborHasMediumLargeRock(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel neighbor, int soilGroupId, bool nonSoilDefaultsTo)
        {
            bool val_4 = nonSoilDefaultsTo;
            if(neighbor == null)
            {
                    return (bool) & 1;
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_1 = neighbor.CurrentItem;
            if((val_1 == null) || (val_1 == null))
            {
                    return (bool) & 1;
            }
            
            var val_2 = (((Royal.Scenes.Game.Mechanics.Items.Config.ItemModel.__il2cppRuntimeField_typeHierarchy + (Royal.Scenes.Game.Mechanics.Items.SoilItem.View.SoilItemView.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_1) : 0;
            var val_3 = (((Royal.Scenes.Game.Mechanics.Items.Config.ItemModel.__il2cppRuntimeField_typeHierarchy + (Royal.Scenes.Game.Mechanics.Items.SoilItem.View.SoilItemView.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? val_1 : 0 + 137) != 0) ? 1 : 0;
            return (bool) & 1;
        }
        protected RockHolder()
        {
        
        }
    
    }

}
