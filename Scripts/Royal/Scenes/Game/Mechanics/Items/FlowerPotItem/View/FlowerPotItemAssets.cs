using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.FlowerPotItem.View
{
    public class FlowerPotItemAssets : ItemAssets
    {
        // Fields
        protected Royal.Scenes.Game.Mechanics.Items.BushItem.View.GrassSpread.GrassSpreadAnimData[] grassSpreadAnimations;
        
        // Methods
        private Royal.Scenes.Game.Mechanics.Items.FlowerPotItem.View.FlowerPotItemView GetViewPrefab()
        {
            if(0 == 0)
            {
                    return 0;
            }
            
            return 0;
        }
        private Royal.Scenes.Game.Mechanics.Items.FlowerPotItem.View.FlowerPotItemExplodeParticles GetParticles()
        {
            if(185636 == 0)
            {
                    return 185636;
            }
            
            return 185636;
        }
        private Royal.Scenes.Game.Mechanics.Items.FlowerPotItem.PurpleGrassSpread.PurpleGrassSpreadAnimationView GetGrassSpreadPrefab()
        {
            if(1073741824 == 0)
            {
                    return 1073741824;
            }
            
            return 1073741824;
        }
        public UnityEngine.Sprite GetSpriteForLayer(int layer)
        {
            var val_2 = X8 + ((layer - 1) << 3);
            return (UnityEngine.Sprite)(X8 + ((layer - 1)) << 3) + 32;
        }
        public Royal.Scenes.Game.Mechanics.Items.BushItem.View.GrassSpread.GrassSpreadAnimData GetGrassAnimationData(int index)
        {
            return (Royal.Scenes.Game.Mechanics.Items.BushItem.View.GrassSpread.GrassSpreadAnimData)this.grassSpreadAnimations[index];
        }
        public UnityEngine.AudioClip GetFlowerSfx(int index)
        {
            var val_1 = X8 + (index << 3);
            return (UnityEngine.AudioClip)(X8 + (index) << 3) + 32;
        }
        protected override void CreateItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool, int amount)
        {
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.FlowerPotItem.View.FlowerPotItemView>(go:  this.GetViewPrefab(), amount:  amount);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.FlowerPotItem.View.FlowerPotItemExplodeParticles>(go:  this.GetParticles(), amount:  amount);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.FlowerPotItem.PurpleGrassSpread.PurpleGrassSpreadAnimationView>(go:  this.GetGrassSpreadPrefab(), amount:  amount + (amount << 2));
        }
        protected override void ClearItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool)
        {
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.FlowerPotItem.View.FlowerPotItemView>(go:  this.GetViewPrefab());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.FlowerPotItem.View.FlowerPotItemExplodeParticles>(go:  this.GetParticles());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.FlowerPotItem.PurpleGrassSpread.PurpleGrassSpreadAnimationView>(go:  this.GetGrassSpreadPrefab());
        }
        public FlowerPotItemAssets()
        {
        
        }
    
    }

}
