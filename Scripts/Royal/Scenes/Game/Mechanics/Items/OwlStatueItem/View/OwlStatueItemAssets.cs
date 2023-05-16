using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.OwlStatueItem.View
{
    public class OwlStatueItemAssets : ItemAssets
    {
        // Methods
        private Royal.Scenes.Game.Mechanics.Items.OwlStatueItem.View.OwlStatueItemView GetViewPrefab()
        {
            if(0 == 0)
            {
                    return 0;
            }
            
            return 0;
        }
        private Royal.Scenes.Game.Mechanics.Items.OwlStatueItem.View.OwlStatueItemExplodeParticles GetExplodePrefab()
        {
            if(185636 == 0)
            {
                    return 185636;
            }
            
            return 185636;
        }
        public UnityEngine.Sprite GetSpriteForLayer(int layer)
        {
            var val_2 = X8 + ((layer - 1) << 3);
            return (UnityEngine.Sprite)(X8 + ((layer - 1)) << 3) + 32;
        }
        public UnityEngine.AudioClip GetOwlCrackSfx(int index)
        {
            var val_1 = X8 + (index << 3);
            return (UnityEngine.AudioClip)(X8 + (index) << 3) + 32;
        }
        public UnityEngine.AudioClip GetOwlBreakSfx()
        {
            return (UnityEngine.AudioClip)X8 + 32;
        }
        protected override void CreateItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool, int amount)
        {
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.OwlStatueItem.View.OwlStatueItemView>(go:  this.GetViewPrefab(), amount:  amount);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.OwlStatueItem.View.OwlStatueItemExplodeParticles>(go:  this.GetExplodePrefab(), amount:  amount + (amount << 1));
        }
        protected override void ClearItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool)
        {
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.OwlStatueItem.View.OwlStatueItemView>(go:  this.GetViewPrefab());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.OwlStatueItem.View.OwlStatueItemExplodeParticles>(go:  this.GetExplodePrefab());
        }
        public OwlStatueItemAssets()
        {
        
        }
    
    }

}
