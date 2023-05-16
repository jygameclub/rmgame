using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.BirdItem.View
{
    public class BirdItemAssets : ItemAssets
    {
        // Methods
        private Royal.Scenes.Game.Mechanics.Items.BirdItem.View.BirdItemView GetViewPrefab()
        {
            if(0 == 0)
            {
                    return 0;
            }
            
            return 0;
        }
        private Royal.Scenes.Game.Mechanics.Items.BirdItem.View.BirdItemCollectParticles GetCollectParticlePrefab()
        {
            if(185636 == 0)
            {
                    return 185636;
            }
            
            return 185636;
        }
        protected override void CreateItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool, int amount)
        {
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.BirdItem.View.BirdItemView>(go:  this.GetViewPrefab(), amount:  amount);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.BirdItem.View.BirdItemCollectParticles>(go:  this.GetCollectParticlePrefab(), amount:  4);
        }
        protected override void ClearItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool)
        {
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.BirdItem.View.BirdItemView>(go:  this.GetViewPrefab());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.BirdItem.View.BirdItemCollectParticles>(go:  this.GetCollectParticlePrefab());
        }
        public UnityEngine.AudioClip GetBirdCollect1Sfx()
        {
            return (UnityEngine.AudioClip)X8 + 32;
        }
        public UnityEngine.AudioClip GetBirdCollect2Sfx()
        {
            return (UnityEngine.AudioClip)X8 + 40;
        }
        public BirdItemAssets()
        {
        
        }
    
    }

}
