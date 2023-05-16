using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SoilItem.View.Rock
{
    public class SmallRockHolder : RockHolder
    {
        // Methods
        public override bool Randomize(Royal.Scenes.Game.Mechanics.Items.SoilItem.View.SoilItemView soilItemView, Royal.Scenes.Game.Mechanics.Items.SoilItem.View.SoilItemAssets soilItemAssets, Royal.Infrastructure.Utils.Randoming.RandomManager randomManager, Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors cellNeighbors, int soilGroupId)
        {
            var val_13;
            if((randomManager.Next(min:  0f, max:  1f)) > 0.15f)
            {
                    randomManager.sprite = 0;
                val_13 = 0;
                return (bool)val_13;
            }
            
            this.CalculateEdgeStatus(randomManager:  randomManager, soilGroupId:  soilGroupId, neighbors:  cellNeighbors);
            float val_2 = randomManager.Next(min:  soilItemAssets.smallRockConfig.minScale, max:  soilItemAssets.smallRockConfig.maxScale);
            UnityEngine.Transform val_4 = this.transform;
            UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  randomManager.Next(min:  -0.5f, max:  0.5f), y:  randomManager.Next(min:  -0.5f, max:  0.5f));
            UnityEngine.Vector3 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y});
            val_4.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            UnityEngine.Quaternion val_9 = UnityEngine.Quaternion.Euler(x:  0f, y:  0f, z:  randomManager.Next(min:  soilItemAssets.smallRockConfig.minZAngle, max:  soilItemAssets.smallRockConfig.maxZAngle));
            val_4.localRotation = new UnityEngine.Quaternion() {x = val_9.x, y = val_9.y, z = val_9.z, w = val_9.w};
            UnityEngine.Vector2 val_10 = new UnityEngine.Vector2(x:  val_2, y:  val_2);
            UnityEngine.Vector3 val_11 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y});
            val_4.localScale = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
            val_4.sprite = randomManager.RandomFromArray<UnityEngine.Sprite>(array:  soilItemAssets.smallRockConfig.sprites);
            this.RandomizeValidPosition(soilItemView:  soilItemView, randomManager:  randomManager, cellNeighbors:  cellNeighbors, soilGroupId:  soilGroupId, isEdgeConfig:  false);
            val_13 = 1;
            return (bool)val_13;
        }
        public SmallRockHolder()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
