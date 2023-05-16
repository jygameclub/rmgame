using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View
{
    public class CurtainItemAssets : ItemAssets
    {
        // Fields
        public UnityEngine.Material[] tokenMaterials;
        
        // Methods
        private Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View.CurtainItemView GetViewPrefab()
        {
            if(0 == 0)
            {
                    return 0;
            }
            
            return 0;
        }
        public Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View.CurtainItemToken GetTokenForCurtainLength(int length)
        {
            bool val_2 = true;
            val_2 = val_2 + ((length - 1) << 3);
            if(((true + ((length - 1)) << 3) + 32) == 0)
            {
                    return (Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View.CurtainItemToken)(true + ((length - 1)) << 3) + 32;
            }
            
            return (Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View.CurtainItemToken)(true + ((length - 1)) << 3) + 32;
        }
        public Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View.CurtainHitParticles GetCurtainHitParticles()
        {
            if(100663296 == 0)
            {
                    return 100663296;
            }
            
            return 100663296;
        }
        private Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View.CurtainExplodeParticles GetCurtainExplodeParticles()
        {
            if(169028 == 0)
            {
                    return 169028;
            }
            
            return 169028;
        }
        private Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View.CurtainRevealParticles GetCurtainRevealParticles()
        {
            if(169284 == 0)
            {
                    return 169284;
            }
            
            return 169284;
        }
        public Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View.CurtainHitParticles GetCurtainFinalHitParticles()
        {
            if(169284 == 0)
            {
                    return 169284;
            }
            
            return 169284;
        }
        public Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View.CurtainTokenExplodeParticles GetCurtainTokenExplodeParticles()
        {
            if(16605 == 0)
            {
                    return 16605;
            }
            
            return 16605;
        }
        public UnityEngine.Sprite GetTokenSprite(Royal.Scenes.Game.Mechanics.Matches.MatchType matchType)
        {
            if((matchType - 1) > 3)
            {
                    return (UnityEngine.Sprite);
            }
            
            var val_2 = 36604760 + ((matchType - 1)) << 2;
            val_2 = val_2 + 36604760;
            goto (36604760 + ((matchType - 1)) << 2 + 36604760);
        }
        public UnityEngine.Material GetTokenMaterial(Royal.Scenes.Game.Mechanics.Matches.MatchType matchType)
        {
            if((matchType - 1) > 3)
            {
                    return (UnityEngine.Material)null;
            }
            
            var val_2 = 36604776 + ((matchType - 1)) << 2;
            val_2 = val_2 + 36604776;
            goto (36604776 + ((matchType - 1)) << 2 + 36604776);
        }
        public UnityEngine.Sprite GetTopEnd()
        {
            return (UnityEngine.Sprite)X8 + 64;
        }
        public UnityEngine.Sprite GetTopTile()
        {
            return (UnityEngine.Sprite)X8 + 72;
        }
        public UnityEngine.Sprite GetMidEnd()
        {
            return (UnityEngine.Sprite)X8 + 80;
        }
        public UnityEngine.Sprite GetMidTile()
        {
            return (UnityEngine.Sprite)X8 + 88;
        }
        public UnityEngine.Sprite GetBotEnd()
        {
            return (UnityEngine.Sprite)X8 + 96;
        }
        public UnityEngine.Sprite GetBotTile()
        {
            return (UnityEngine.Sprite)X8 + 104;
        }
        public UnityEngine.AudioClip GetCurtainCollectSfx()
        {
            return (UnityEngine.AudioClip)X8 + 32;
        }
        public UnityEngine.AudioClip GetCurtainDestroySfx()
        {
            return (UnityEngine.AudioClip)X8 + 40;
        }
        public UnityEngine.AudioClip GetCurtainChainSfx()
        {
            return (UnityEngine.AudioClip)X8 + 48;
        }
        public UnityEngine.AudioClip GetCurtainOpenSfx()
        {
            return (UnityEngine.AudioClip)X8 + 56;
        }
        protected override void CreateItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool, int amount)
        {
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View.CurtainItemView>(go:  this.GetViewPrefab(), amount:  amount);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View.CurtainExplodeParticles>(go:  this.GetCurtainExplodeParticles(), amount:  5);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View.CurtainRevealParticles>(go:  this.GetCurtainRevealParticles(), amount:  5);
        }
        protected override void ClearItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool)
        {
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View.CurtainItemView>(go:  this.GetViewPrefab());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View.CurtainExplodeParticles>(go:  this.GetCurtainExplodeParticles());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View.CurtainRevealParticles>(go:  this.GetCurtainRevealParticles());
        }
        public CurtainItemAssets()
        {
        
        }
    
    }

}
