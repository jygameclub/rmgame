using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.MatchItem.View
{
    public class MatchItemAssets : ItemAssets
    {
        // Methods
        private Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemView GetViewPrefab()
        {
            if(0 == 0)
            {
                    return 0;
            }
            
            return 0;
        }
        private Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemExplodeParticles GetExplodePrefabs()
        {
            if(185636 == 0)
            {
                    return 185636;
            }
            
            return 185636;
        }
        private Royal.Scenes.Game.Mechanics.Items.MatchItem.View.SpecialItemCreationParticles GetSpecialItemCreationPrefabs()
        {
            if(1073741824 == 0)
            {
                    return 1073741824;
            }
            
            return 1073741824;
        }
        private Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemSwapParticles GetSwapParticlePrefabs()
        {
            if(469778432 == 0)
            {
                    return 469778432;
            }
            
            return 469778432;
        }
        private Royal.Scenes.Game.Mechanics.Items.MatchItem.View.PrelevelBoosterHitParticles GetPrelevelBoosterHitParticles()
        {
            if(83886080 == 0)
            {
                    return 83886080;
            }
            
            return 83886080;
        }
        public UnityEngine.Sprite GetSprite(Royal.Scenes.Game.Mechanics.Matches.MatchType matchType)
        {
            var val_3;
            if((matchType - 1) <= 5)
            {
                    var val_2 = 36605936 + ((matchType - 1)) << 2;
                val_2 = val_2 + 36605936;
            }
            else
            {
                    val_3 = 0;
                return (UnityEngine.Sprite);
            }
        
        }
        public UnityEngine.Sprite GetShadowSprite(Royal.Scenes.Game.Mechanics.Matches.MatchType matchType)
        {
            if((matchType - 1) > 5)
            {
                    return (UnityEngine.Sprite);
            }
            
            var val_2 = 36605960 + ((matchType - 1)) << 2;
            val_2 = val_2 + 36605960;
            goto (36605960 + ((matchType - 1)) << 2 + 36605960);
        }
        protected override void CreateItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool, int amount)
        {
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemView>(go:  this.GetViewPrefab(), amount:  amount);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemExplodeParticles>(go:  this.GetExplodePrefabs(), amount:  amount);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.MatchItem.View.SpecialItemCreationParticles>(go:  this.GetSpecialItemCreationPrefabs(), amount:  amount);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.MatchItem.View.PrelevelBoosterHitParticles>(go:  this.GetPrelevelBoosterHitParticles(), amount:  3);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemSwapParticles>(go:  this.GetSwapParticlePrefabs(), amount:  10);
        }
        protected override void ClearItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool)
        {
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemView>(go:  this.GetViewPrefab());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemExplodeParticles>(go:  this.GetExplodePrefabs());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.MatchItem.View.SpecialItemCreationParticles>(go:  this.GetSpecialItemCreationPrefabs());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.MatchItem.View.PrelevelBoosterHitParticles>(go:  this.GetPrelevelBoosterHitParticles());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemSwapParticles>(go:  this.GetSwapParticlePrefabs());
        }
        public MatchItemAssets()
        {
        
        }
    
    }

}
