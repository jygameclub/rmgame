using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.GiantBirdItem.View
{
    public class GiantBirdItemAssets : ItemAssets
    {
        // Methods
        private Royal.Scenes.Game.Mechanics.Items.GiantBirdItem.View.GiantBirdItemView GetViewPrefab()
        {
            if(0 == 0)
            {
                    return 0;
            }
            
            return 0;
        }
        private Royal.Scenes.Game.Mechanics.Items.BirdItem.View.GiantBirdItemCollectParticles GetCollectParticles()
        {
            if(185636 == 0)
            {
                    return 185636;
            }
            
            if(mem[281479271743785] < (X1 + 296))
            {
                    throw new NullReferenceException();
            }
            
            var val_1 = mem[281479271743689];
            val_1 = val_1 + ((X1 + 296) << 3);
            if(((mem[281479271743689] + (X1 + 296) << 3) + -8) != X1)
            {
                    throw new NullReferenceException();
            }
            
            return 185636;
        }
        protected override void CreateItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool, int amount)
        {
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.GiantBirdItem.View.GiantBirdItemView>(go:  this.GetViewPrefab(), amount:  amount);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.BirdItem.View.GiantBirdItemCollectParticles>(go:  this.GetCollectParticles(), amount:  amount);
        }
        protected override void ClearItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool)
        {
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.GiantBirdItem.View.GiantBirdItemView>(go:  this.GetViewPrefab());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.BirdItem.View.GiantBirdItemCollectParticles>(go:  this.GetCollectParticles());
        }
        public GiantBirdItemAssets()
        {
        
        }
    
    }

}
