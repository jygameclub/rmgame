using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SoilItem.View.Rock
{
    public class CrackHolder : RockHolder
    {
        // Methods
        public override bool Randomize(Royal.Scenes.Game.Mechanics.Items.SoilItem.View.SoilItemView soilItemView, Royal.Scenes.Game.Mechanics.Items.SoilItem.View.SoilItemAssets soilItemAssets, Royal.Infrastructure.Utils.Randoming.RandomManager randomManager, Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors cellNeighbors, int soilGroupId)
        {
            var val_13;
            if((randomManager.Next(min:  0f, max:  1f)) > 0.33f)
            {
                    randomManager.sprite = 0;
                val_13 = 0;
                return (bool)val_13;
            }
            
            this.CalculateEdgeStatus(randomManager:  randomManager, soilGroupId:  soilGroupId, neighbors:  cellNeighbors);
            var val_2 = (36532224 == 0) ? 112 : 104;
            float val_3 = randomManager.Next(min:  Royal.Scenes.Game.Mechanics.Items.SoilItem.View.SoilItemAssets.__il2cppRuntimeField_byval_arg, max:  typeof(Royal.Scenes.Game.Mechanics.Items.SoilItem.View.SoilItemAssets).__il2cppRuntimeField_24);
            UnityEngine.Transform val_5 = this.transform;
            UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.Euler(x:  0f, y:  0f, z:  randomManager.Next(min:  Royal.Scenes.Game.Mechanics.Items.SoilItem.View.SoilItemAssets.__il2cppRuntimeField_namespaze, max:  typeof(Royal.Scenes.Game.Mechanics.Items.SoilItem.View.SoilItemAssets).__il2cppRuntimeField_1C));
            val_5.localRotation = new UnityEngine.Quaternion() {x = val_6.x, y = val_6.y, z = val_6.z, w = val_6.w};
            UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  val_3, y:  val_3);
            UnityEngine.Vector3 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y});
            val_5.localScale = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            val_5.sprite = randomManager.RandomFromArray<UnityEngine.Sprite>(array:  Royal.Scenes.Game.Mechanics.Items.SoilItem.View.SoilItemAssets.__il2cppRuntimeField_name);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.ChangeAlpha(sprite:  val_5, alpha:  randomManager.Next(min:  soilItemAssets.minCrackAlpha, max:  soilItemAssets.maxCrackAlpha));
            this.RandomizeValidPosition(soilItemView:  soilItemView, randomManager:  randomManager, cellNeighbors:  cellNeighbors, soilGroupId:  soilGroupId, isEdgeConfig:  (1152921519970854432 != 0) ? 1 : 0);
            val_13 = 1;
            return (bool)val_13;
        }
        public CrackHolder()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
