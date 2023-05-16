using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.View
{
    public class RocketItemAssets : ItemAssets
    {
        // Methods
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.View.RocketItemView GetViewPrefab()
        {
            if(0 == 0)
            {
                    return 0;
            }
            
            return 0;
        }
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.View.RocketItemParticles GetExplodePrefabs()
        {
            if(185636 == 0)
            {
                    return 185636;
            }
            
            return 185636;
        }
        public UnityEngine.Sprite GetHorizontalSprite()
        {
            return (UnityEngine.Sprite)X8 + 32;
        }
        public UnityEngine.Sprite GetHorizontalLeftSprite()
        {
            return (UnityEngine.Sprite)X8 + 40;
        }
        public UnityEngine.Sprite GetHorizontalRightSprite()
        {
            return (UnityEngine.Sprite)X8 + 48;
        }
        public UnityEngine.Sprite GetVerticalSprite()
        {
            return (UnityEngine.Sprite)X8 + 56;
        }
        public UnityEngine.Sprite GetVerticalBottomSprite()
        {
            return (UnityEngine.Sprite)X8 + 64;
        }
        public UnityEngine.Sprite GetVerticalTopSprite()
        {
            return (UnityEngine.Sprite)X8 + 72;
        }
        public UnityEngine.Sprite GetRocketShadow()
        {
            return (UnityEngine.Sprite)X8 + 80;
        }
        protected override void CreateItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool, int amount)
        {
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.View.RocketItemView>(go:  this.GetViewPrefab(), amount:  amount);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.View.RocketItemParticles>(go:  this.GetExplodePrefabs(), amount:  amount << 1);
        }
        protected override void ClearItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool)
        {
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.View.RocketItemView>(go:  this.GetViewPrefab());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.View.RocketItemParticles>(go:  this.GetExplodePrefabs());
        }
        public UnityEngine.AudioClip GetRocketCreationSfx()
        {
            return (UnityEngine.AudioClip)X8 + 32;
        }
        public UnityEngine.AudioClip GetRocketExplodeSfx()
        {
            return (UnityEngine.AudioClip)X8 + 40;
        }
        public RocketItemAssets()
        {
        
        }
    
    }

}
