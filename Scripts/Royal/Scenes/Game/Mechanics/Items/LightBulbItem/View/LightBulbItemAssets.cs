using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.LightBulbItem.View
{
    public class LightBulbItemAssets : ItemAssets
    {
        // Methods
        private Royal.Scenes.Game.Mechanics.Items.LightBulbItem.View.LightBulbItemView GetViewPrefab()
        {
            if(0 == 0)
            {
                    return 0;
            }
            
            return 0;
        }
        private Royal.Scenes.Game.Mechanics.Items.LightBulbItem.View.LightBulbItemExplodeParticles GetExplodeParticlePrefab()
        {
            if(185636 == 0)
            {
                    return 185636;
            }
            
            return 185636;
        }
        private Royal.Scenes.Game.Mechanics.Items.LightBulbItem.View.LightBulbItemSingleExplodeParticles GetSingleExplodeParticlePrefab()
        {
            if(1073741824 == 0)
            {
                    return 1073741824;
            }
            
            return 1073741824;
        }
        public UnityEngine.AudioClip GetLightBulbShatterSfx(int index)
        {
            var val_1 = X8 + (index << 3);
            return (UnityEngine.AudioClip)(X8 + (index) << 3) + 32;
        }
        public UnityEngine.AudioClip GetLightBulbExplodeSfx()
        {
            return (UnityEngine.AudioClip)X8 + 56;
        }
        protected override void CreateItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool, int amount)
        {
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.LightBulbItem.View.LightBulbItemView>(go:  this.GetViewPrefab(), amount:  amount);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.LightBulbItem.View.LightBulbItemExplodeParticles>(go:  this.GetExplodeParticlePrefab(), amount:  amount);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.LightBulbItem.View.LightBulbItemSingleExplodeParticles>(go:  this.GetSingleExplodeParticlePrefab(), amount:  amount << 1);
        }
        protected override void ClearItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool)
        {
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.LightBulbItem.View.LightBulbItemView>(go:  this.GetViewPrefab());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.LightBulbItem.View.LightBulbItemExplodeParticles>(go:  this.GetExplodeParticlePrefab());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.LightBulbItem.View.LightBulbItemSingleExplodeParticles>(go:  this.GetSingleExplodeParticlePrefab());
        }
        public LightBulbItemAssets()
        {
        
        }
    
    }

}
