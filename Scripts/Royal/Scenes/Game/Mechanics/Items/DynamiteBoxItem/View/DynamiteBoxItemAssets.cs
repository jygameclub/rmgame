using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.View
{
    public class DynamiteBoxItemAssets : ItemAssets
    {
        // Methods
        private Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.View.DynamiteBoxItemView GetViewPrefab()
        {
            if(0 == 0)
            {
                    return 0;
            }
            
            return 0;
        }
        private Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.View.DynamiteSparkParticles GetSingleExplodeParticles()
        {
            if(185636 == 0)
            {
                    return 185636;
            }
            
            return 185636;
        }
        private Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.View.DynamiteBoxItemExplodeParticles GetDynamiteBoxItemExplodeParticles()
        {
            if(1073741824 == 0)
            {
                    return 1073741824;
            }
            
            return 1073741824;
        }
        protected override void CreateItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool, int amount)
        {
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.View.DynamiteBoxItemView>(go:  this.GetViewPrefab(), amount:  amount);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.View.DynamiteSparkParticles>(go:  this.GetSingleExplodeParticles(), amount:  amount << 2);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.View.DynamiteBoxItemExplodeParticles>(go:  this.GetDynamiteBoxItemExplodeParticles(), amount:  amount);
        }
        protected override void ClearItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool)
        {
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.View.DynamiteBoxItemView>(go:  this.GetViewPrefab());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.View.DynamiteSparkParticles>(go:  this.GetSingleExplodeParticles());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.View.DynamiteBoxItemExplodeParticles>(go:  this.GetDynamiteBoxItemExplodeParticles());
        }
        public UnityEngine.AudioClip GetSfx(int layer)
        {
            var val_1 = X8 + (layer << 3);
            return (UnityEngine.AudioClip)(X8 + (layer) << 3) + 32;
        }
        public DynamiteBoxItemAssets()
        {
        
        }
    
    }

}
