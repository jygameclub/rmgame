using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SoilItem.View.Rock
{
    public class MediumLargeRockHolder : RockHolder
    {
        // Methods
        public override bool Randomize(Royal.Scenes.Game.Mechanics.Items.SoilItem.View.SoilItemView soilItemView, Royal.Scenes.Game.Mechanics.Items.SoilItem.View.SoilItemAssets soilItemAssets, Royal.Infrastructure.Utils.Randoming.RandomManager randomManager, Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors cellNeighbors, int soilGroupId)
        {
            float val_14;
            var val_15;
            val_14 = 0;
            float val_4 = randomManager.Next(min:  0f, max:  1f);
            if((((this.MustPut(neighbors:  cellNeighbors, soilGroupId:  soilGroupId)) != true) ? 1 : 0.33) < 0)
            {
                    randomManager.sprite = 0;
                val_15 = 0;
                return (bool)val_15;
            }
            
            this.CalculateEdgeStatus(randomManager:  randomManager, soilGroupId:  soilGroupId, neighbors:  cellNeighbors);
            var val_6 = (randomManager.NextBool() != true) ? 88 : 96;
            val_14 = randomManager.Next(min:  Royal.Scenes.Game.Mechanics.Items.SoilItem.View.SoilItemAssets.__il2cppRuntimeField_byval_arg, max:  typeof(Royal.Scenes.Game.Mechanics.Items.SoilItem.View.SoilItemAssets).__il2cppRuntimeField_24);
            UnityEngine.Transform val_9 = this.transform;
            UnityEngine.Quaternion val_10 = UnityEngine.Quaternion.Euler(x:  0f, y:  0f, z:  randomManager.Next(min:  Royal.Scenes.Game.Mechanics.Items.SoilItem.View.SoilItemAssets.__il2cppRuntimeField_namespaze, max:  typeof(Royal.Scenes.Game.Mechanics.Items.SoilItem.View.SoilItemAssets).__il2cppRuntimeField_1C));
            val_9.localRotation = new UnityEngine.Quaternion() {x = val_10.x, y = val_10.y, z = val_10.z, w = val_10.w};
            UnityEngine.Vector2 val_11 = new UnityEngine.Vector2(x:  val_14, y:  val_14);
            UnityEngine.Vector3 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y});
            val_9.localScale = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
            val_9.sprite = randomManager.RandomFromArray<UnityEngine.Sprite>(array:  Royal.Scenes.Game.Mechanics.Items.SoilItem.View.SoilItemAssets.__il2cppRuntimeField_name);
            this.RandomizeValidPosition(soilItemView:  soilItemView, randomManager:  randomManager, cellNeighbors:  cellNeighbors, soilGroupId:  soilGroupId, isEdgeConfig:  false);
            val_15 = 1;
            return (bool)val_15;
        }
        private bool MustPut(Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors neighbors, int soilGroupId)
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_10;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_12;
            var val_13;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_1 = neighbors.Get(type:  7);
            if((val_1 != null) && (val_1 != null))
            {
                    val_10 = val_1.Get(type:  7);
            }
            else
            {
                    val_10 = 0;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_3 = neighbors.Get(type:  5);
            if((val_3 != null) && (val_3 != null))
            {
                    val_12 = val_3.Get(type:  5);
            }
            else
            {
                    val_12 = 0;
            }
            
            bool val_5 = val_3.NeighborHasMediumLargeRock(neighbor:  val_1, soilGroupId:  soilGroupId, nonSoilDefaultsTo:  true);
            if(val_5 == true)
            {
                goto label_7;
            }
            
            val_13 = 1;
            bool val_6 = val_5.NeighborHasMediumLargeRock(neighbor:  val_10, soilGroupId:  soilGroupId, nonSoilDefaultsTo:  true);
            if(val_6 == false)
            {
                goto label_10;
            }
            
            label_7:
            bool val_7 = val_6.NeighborHasMediumLargeRock(neighbor:  val_3, soilGroupId:  soilGroupId, nonSoilDefaultsTo:  true);
            if(val_7 != false)
            {
                    val_13 = 0;
            }
            else
            {
                    bool val_8 = val_7.NeighborHasMediumLargeRock(neighbor:  val_12, soilGroupId:  soilGroupId, nonSoilDefaultsTo:  true);
                val_13 = val_8 ^ 1;
            }
            
            label_10:
            val_8 = val_13;
            return (bool)val_8;
        }
        private bool CantPut(Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors neighbors, int soilGroupId)
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_8 = neighbors.Get(type:  4);
            bool val_9 = val_8.NeighborHasMediumLargeRock(neighbor:  neighbors.Get(type:  7), soilGroupId:  soilGroupId, nonSoilDefaultsTo:  false);
            if(val_9 == true)
            {
                    return true;
            }
            
            bool val_10 = val_9.NeighborHasMediumLargeRock(neighbor:  neighbors.Get(type:  3), soilGroupId:  soilGroupId, nonSoilDefaultsTo:  false);
            if(val_10 == true)
            {
                    return true;
            }
            
            bool val_11 = val_10.NeighborHasMediumLargeRock(neighbor:  neighbors.Get(type:  1), soilGroupId:  soilGroupId, nonSoilDefaultsTo:  false);
            if(val_11 == true)
            {
                    return true;
            }
            
            bool val_12 = val_11.NeighborHasMediumLargeRock(neighbor:  neighbors.Get(type:  5), soilGroupId:  soilGroupId, nonSoilDefaultsTo:  false);
            if(val_12 == true)
            {
                    return true;
            }
            
            bool val_13 = val_12.NeighborHasMediumLargeRock(neighbor:  neighbors.Get(type:  0), soilGroupId:  soilGroupId, nonSoilDefaultsTo:  false);
            if(val_13 == true)
            {
                    return true;
            }
            
            bool val_14 = val_13.NeighborHasMediumLargeRock(neighbor:  neighbors.Get(type:  2), soilGroupId:  soilGroupId, nonSoilDefaultsTo:  false);
            if(val_14 == true)
            {
                    return true;
            }
            
            bool val_15 = val_14.NeighborHasMediumLargeRock(neighbor:  neighbors.Get(type:  6), soilGroupId:  soilGroupId, nonSoilDefaultsTo:  false);
            if(val_15 == false)
            {
                    return val_15.NeighborHasMediumLargeRock(neighbor:  val_8, soilGroupId:  soilGroupId, nonSoilDefaultsTo:  false);
            }
            
            return true;
        }
        public MediumLargeRockHolder()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
