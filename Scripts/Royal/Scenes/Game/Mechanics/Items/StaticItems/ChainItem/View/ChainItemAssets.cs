using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.StaticItems.ChainItem.View
{
    public class ChainItemAssets : ItemAssets
    {
        // Methods
        private Royal.Scenes.Game.Mechanics.Items.StaticItems.ChainItem.View.ChainItemView GetViewPrefab()
        {
            if(0 == 0)
            {
                    return 0;
            }
            
            return 0;
        }
        private Royal.Scenes.Game.Mechanics.Items.StaticItems.ChainItem.View.ChainItemExplodeParticles GetChainExplodeParticles()
        {
            if(185636 == 0)
            {
                    return 185636;
            }
            
            return 185636;
        }
        public UnityEngine.AudioClip GetChainBreakSfx1()
        {
            return (UnityEngine.AudioClip)X8 + 32;
        }
        public UnityEngine.AudioClip GetChainBreakSfx2()
        {
            return (UnityEngine.AudioClip)X8 + 40;
        }
        public UnityEngine.AudioClip GetChainWrongMoveSfx1()
        {
            return (UnityEngine.AudioClip)X8 + 48;
        }
        public UnityEngine.AudioClip GetChainWrongMoveSfx2()
        {
            return (UnityEngine.AudioClip)X8 + 56;
        }
        public UnityEngine.AudioClip GetChainWrongMoveSfx3()
        {
            return (UnityEngine.AudioClip)X8 + 64;
        }
        protected override void CreateItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool, int amount)
        {
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.StaticItems.ChainItem.View.ChainItemView>(go:  this.GetViewPrefab(), amount:  amount);
            float val_4 = (float)amount;
            val_4 = val_4 * 0.5f;
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.StaticItems.ChainItem.View.ChainItemExplodeParticles>(go:  this.GetChainExplodeParticles(), amount:  UnityEngine.Mathf.CeilToInt(f:  val_4));
        }
        protected override void ClearItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool)
        {
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.StaticItems.ChainItem.View.ChainItemView>(go:  this.GetViewPrefab());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.StaticItems.ChainItem.View.ChainItemExplodeParticles>(go:  this.GetChainExplodeParticles());
        }
        public ChainItemAssets()
        {
        
        }
    
    }

}
