using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.BirdNestItem
{
    public class BirdNestItemAssets : ItemAssets
    {
        // Methods
        private Royal.Scenes.Game.Mechanics.Items.BirdNestItem.View.BirdNestItemView GetViewPrefab()
        {
            if(0 == 0)
            {
                    return 0;
            }
            
            return 0;
        }
        private Royal.Scenes.Game.Mechanics.Items.BirdNestItem.BirdNestDestroyParticles GetDestroyParticles()
        {
            if(185636 == 0)
            {
                    return 185636;
            }
            
            return 185636;
        }
        private Royal.Scenes.Game.Mechanics.Items.BirdNestItem.View.Bird.BirdNestBird GetBirdThrowItem()
        {
            if(1073741824 == 0)
            {
                    return 1073741824;
            }
            
            return 1073741824;
        }
        protected override void CreateItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool, int amount)
        {
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.BirdNestItem.View.BirdNestItemView>(go:  this.GetViewPrefab(), amount:  amount);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.BirdNestItem.BirdNestDestroyParticles>(go:  this.GetDestroyParticles(), amount:  amount);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.BirdNestItem.View.Bird.BirdNestBird>(go:  this.GetBirdThrowItem(), amount:  amount + (amount << 1));
        }
        protected override void ClearItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool)
        {
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.BirdNestItem.View.BirdNestItemView>(go:  this.GetViewPrefab());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.BirdNestItem.BirdNestDestroyParticles>(go:  this.GetDestroyParticles());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.BirdNestItem.View.Bird.BirdNestBird>(go:  this.GetBirdThrowItem());
        }
        public UnityEngine.AudioClip GetSfx(int layer)
        {
            var val_1 = X8 + (layer << 3);
            return (UnityEngine.AudioClip)(X8 + (layer) << 3) + 32;
        }
        public BirdNestItemAssets()
        {
        
        }
    
    }

}
