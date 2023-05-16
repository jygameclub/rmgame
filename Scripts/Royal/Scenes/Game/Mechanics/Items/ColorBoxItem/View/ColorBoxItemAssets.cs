using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.ColorBoxItem.View
{
    public class ColorBoxItemAssets : ItemAssets
    {
        // Methods
        private Royal.Scenes.Game.Mechanics.Items.ColorBoxItem.View.ColorBoxItemView GetViewPrefab()
        {
            if(0 == 0)
            {
                    return 0;
            }
            
            return 0;
        }
        private Royal.Scenes.Game.Mechanics.Items.ColorBoxItem.View.ColorBoxItemExplodeParticles GetExplodePrefab()
        {
            if(185636 == 0)
            {
                    return 185636;
            }
            
            return 185636;
        }
        public UnityEngine.Sprite GetSpriteForColor(Royal.Scenes.Game.Mechanics.Matches.MatchType matchType, int layer)
        {
            layer = (layer == 1) ? 0 : ((layer == 2) ? 5 : 10);
            return this.GetLiquid(matchType:  matchType, startIndex:  layer);
        }
        public UnityEngine.Sprite GetCap03(Royal.Scenes.Game.Mechanics.Matches.MatchType matchType)
        {
            return this.GetLiquid(matchType:  matchType, startIndex:  15);
        }
        public UnityEngine.Sprite GetPart02(Royal.Scenes.Game.Mechanics.Matches.MatchType matchType)
        {
            return this.GetLiquid(matchType:  matchType, startIndex:  20);
        }
        public UnityEngine.Sprite GetPart03(Royal.Scenes.Game.Mechanics.Matches.MatchType matchType)
        {
            return this.GetLiquid(matchType:  matchType, startIndex:  25);
        }
        public UnityEngine.Sprite GetPart05(Royal.Scenes.Game.Mechanics.Matches.MatchType matchType)
        {
            return this.GetLiquid(matchType:  matchType, startIndex:  30);
        }
        public UnityEngine.Sprite GetSmall02(Royal.Scenes.Game.Mechanics.Matches.MatchType matchType)
        {
            return this.GetLiquid(matchType:  matchType, startIndex:  35);
        }
        public UnityEngine.Sprite GetSmall03(Royal.Scenes.Game.Mechanics.Matches.MatchType matchType)
        {
            return this.GetLiquid(matchType:  matchType, startIndex:  40);
        }
        public UnityEngine.Sprite GetSmall05(Royal.Scenes.Game.Mechanics.Matches.MatchType matchType)
        {
            return this.GetLiquid(matchType:  matchType, startIndex:  45);
        }
        public UnityEngine.Sprite GetBoxBottomPart(Royal.Scenes.Game.Mechanics.Matches.MatchType matchType)
        {
            return this.GetLiquid(matchType:  matchType, startIndex:  50);
        }
        private UnityEngine.Sprite GetLiquid(Royal.Scenes.Game.Mechanics.Matches.MatchType matchType, int startIndex)
        {
            if((matchType - 1) <= 4)
            {
                    var val_2 = 36616584 + ((matchType - 1)) << 2;
                val_2 = val_2 + 36616584;
            }
            else
            {
                    if(((36616584 + ((matchType - 1)) << 2 + 36616584) + 24) <= startIndex)
            {
                    throw new IndexOutOfRangeException();
            }
            
                 =  + ( << 3);
                return (UnityEngine.Sprite)(new IndexOutOfRangeException() + 32 + (((((startIndex + 4) + 2) + 1) + 3)) << 3) + 32;
            }
        
        }
        public UnityEngine.AudioClip GetBoxBreak1Sfx()
        {
            return (UnityEngine.AudioClip)X8 + 32;
        }
        public UnityEngine.AudioClip GetBoxBreak2Sfx()
        {
            return (UnityEngine.AudioClip)X8 + 40;
        }
        public UnityEngine.AudioClip GetBoxBreak3Sfx()
        {
            return (UnityEngine.AudioClip)X8 + 48;
        }
        public UnityEngine.AudioClip GetBoxLayerBreak1Sfx()
        {
            return (UnityEngine.AudioClip)X8 + 56;
        }
        public UnityEngine.AudioClip GetBoxLayerBreak2Sfx()
        {
            return (UnityEngine.AudioClip)X8 + 64;
        }
        public UnityEngine.AudioClip GetBoxLayerBreak3Sfx()
        {
            return (UnityEngine.AudioClip)X8 + 72;
        }
        protected override void CreateItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool, int amount)
        {
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.ColorBoxItem.View.ColorBoxItemView>(go:  this.GetViewPrefab(), amount:  amount);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.ColorBoxItem.View.ColorBoxItemExplodeParticles>(go:  this.GetExplodePrefab(), amount:  amount + (amount << 1));
        }
        protected override void ClearItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool)
        {
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.ColorBoxItem.View.ColorBoxItemView>(go:  this.GetViewPrefab());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.ColorBoxItem.View.ColorBoxItemExplodeParticles>(go:  this.GetExplodePrefab());
        }
        public ColorBoxItemAssets()
        {
            val_1 = new UnityEngine.ScriptableObject();
        }
    
    }

}
