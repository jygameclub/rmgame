using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.PotionItem.View
{
    public class PotionItemAssets : ItemAssets
    {
        // Methods
        public UnityEngine.Sprite GetLiquidASprite(Royal.Scenes.Game.Mechanics.Matches.MatchType matchType)
        {
            return this.GetLiquid(matchType:  matchType, startIndex:  0);
        }
        public UnityEngine.Sprite GetLiquidBSprite(Royal.Scenes.Game.Mechanics.Matches.MatchType matchType)
        {
            return this.GetLiquid(matchType:  matchType, startIndex:  5);
        }
        public UnityEngine.Sprite GetSplashSprite(Royal.Scenes.Game.Mechanics.Matches.MatchType matchType)
        {
            return this.GetLiquid(matchType:  matchType, startIndex:  10);
        }
        public UnityEngine.Sprite GetDropSprite(Royal.Scenes.Game.Mechanics.Matches.MatchType matchType)
        {
            return this.GetLiquid(matchType:  matchType, startIndex:  15);
        }
        public UnityEngine.Sprite GetLiquidCSprite(Royal.Scenes.Game.Mechanics.Matches.MatchType matchType)
        {
            return this.GetLiquid(matchType:  matchType, startIndex:  20);
        }
        private UnityEngine.Sprite GetLiquid(Royal.Scenes.Game.Mechanics.Matches.MatchType matchType, int startIndex)
        {
            if((matchType - 1) <= 4)
            {
                    var val_2 = 36613916 + ((matchType - 1)) << 2;
                val_2 = val_2 + 36613916;
            }
            else
            {
                    if(((36613916 + ((matchType - 1)) << 2 + 36613916) + 24) <= startIndex)
            {
                    throw new IndexOutOfRangeException();
            }
            
                 =  + ( << 3);
                return (UnityEngine.Sprite)(new IndexOutOfRangeException() + 32 + (((((startIndex + 4) + 2) + 1) + 3)) << 3) + 32;
            }
        
        }
        private Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionItemView GetViewPrefab()
        {
            if(0 == 0)
            {
                    return 0;
            }
            
            return 0;
        }
        private Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionBottleView GetBottlePrefab()
        {
            if(185636 == 0)
            {
                    return 185636;
            }
            
            return 185636;
        }
        private Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionItemExplodeParticles GetExplodeParticlePrefab()
        {
            if(1073741824 == 0)
            {
                    return 1073741824;
            }
            
            return 1073741824;
        }
        private Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionItemSingleExplodeParticles GetSingleExplodeParticlePrefab()
        {
            if(469778432 == 0)
            {
                    return 469778432;
            }
            
            return 469778432;
        }
        protected override void CreateItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool, int amount)
        {
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionItemView>(go:  this.GetViewPrefab(), amount:  amount);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionItemExplodeParticles>(go:  this.GetExplodeParticlePrefab(), amount:  amount);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionBottleView>(go:  this.GetBottlePrefab(), amount:  amount << 2);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionItemSingleExplodeParticles>(go:  this.GetSingleExplodeParticlePrefab(), amount:  amount << 1);
        }
        protected override void ClearItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool)
        {
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionItemView>(go:  this.GetViewPrefab());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionItemExplodeParticles>(go:  this.GetExplodeParticlePrefab());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionBottleView>(go:  this.GetBottlePrefab());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionItemSingleExplodeParticles>(go:  this.GetSingleExplodeParticlePrefab());
        }
        public UnityEngine.AudioClip GetPotionBottle1Break()
        {
            return (UnityEngine.AudioClip)X8 + 32;
        }
        public UnityEngine.AudioClip GetPotionBottle2Break()
        {
            return (UnityEngine.AudioClip)X8 + 40;
        }
        public UnityEngine.AudioClip GetPotionContainerBreak()
        {
            return (UnityEngine.AudioClip)X8 + 48;
        }
        public PotionItemAssets()
        {
        
        }
    
    }

}
