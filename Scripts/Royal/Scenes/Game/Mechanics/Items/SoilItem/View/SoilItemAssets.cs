using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SoilItem.View
{
    public class SoilItemAssets : ItemAssets
    {
        // Fields
        public UnityEngine.Sprite[] bombSprites;
        public UnityEngine.Sprite[] dirtGroupSprites;
        public Royal.Scenes.Game.Mechanics.Items.SoilItem.View.SoilItemAssets.RockConfig smallRockConfig;
        public Royal.Scenes.Game.Mechanics.Items.SoilItem.View.SoilItemAssets.RockConfig mediumRockConfig;
        public Royal.Scenes.Game.Mechanics.Items.SoilItem.View.SoilItemAssets.RockConfig largeRockConfig;
        public Royal.Scenes.Game.Mechanics.Items.SoilItem.View.SoilItemAssets.RockConfig edgeCrackConfig;
        public Royal.Scenes.Game.Mechanics.Items.SoilItem.View.SoilItemAssets.RockConfig nonEdgeCrackConfig;
        public float minCrackAlpha;
        public float maxCrackAlpha;
        
        // Methods
        private Royal.Scenes.Game.Mechanics.Items.SoilItem.View.SoilItemView GetViewPrefab()
        {
            if(0 == 0)
            {
                    return 0;
            }
            
            return 0;
        }
        private Royal.Scenes.Game.Mechanics.Items.SoilItem.View.SoilExplodeParticles GetSoilExplodeParticles()
        {
            if(185636 == 0)
            {
                    return 185636;
            }
            
            return 185636;
        }
        public UnityEngine.AudioClip GetSfx(int layer)
        {
            var val_1 = X8 + (layer << 3);
            return (UnityEngine.AudioClip)(X8 + (layer) << 3) + 32;
        }
        public UnityEngine.Sprite GetSprite(int order)
        {
            var val_1 = X8 + (order << 3);
            return (UnityEngine.Sprite)(X8 + (order) << 3) + 32;
        }
        public UnityEngine.Sprite GetDirtGroup(int index)
        {
            return (UnityEngine.Sprite)this.dirtGroupSprites[index];
        }
        public UnityEngine.Sprite GetBombSpriteForLayer(int layer)
        {
            return (UnityEngine.Sprite)this.bombSprites[layer - 1];
        }
        protected override void CreateItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool, int amount)
        {
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.SoilItem.View.SoilItemView>(go:  this.GetViewPrefab(), amount:  amount);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.SoilItem.View.SoilExplodeParticles>(go:  this.GetSoilExplodeParticles(), amount:  amount);
        }
        protected override void ClearItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool)
        {
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.SoilItem.View.SoilItemView>(go:  this.GetViewPrefab());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.SoilItem.View.SoilExplodeParticles>(go:  this.GetSoilExplodeParticles());
        }
        public SoilItemAssets()
        {
        
        }
    
    }

}
