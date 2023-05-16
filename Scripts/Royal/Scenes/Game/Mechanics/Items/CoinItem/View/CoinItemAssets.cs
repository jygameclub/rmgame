using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.CoinItem.View
{
    public class CoinItemAssets : ItemAssets
    {
        // Methods
        private Royal.Scenes.Game.Mechanics.Items.CoinItem.View.CoinItemView GetViewPrefab()
        {
            if(0 == 0)
            {
                    return 0;
            }
            
            return 0;
        }
        private Royal.Scenes.Game.Mechanics.Items.CoinItem.View.CoinItemExplodeParticles GetExplodePrefab()
        {
            if(185636 == 0)
            {
                    return 185636;
            }
            
            return 185636;
        }
        public UnityEngine.AudioClip GetCoinCollectSfx()
        {
            return (UnityEngine.AudioClip)X8 + 32;
        }
        public UnityEngine.AudioClip GetCoinHitSfx()
        {
            return (UnityEngine.AudioClip)X8 + 40;
        }
        protected override void CreateItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool, int amount)
        {
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.CoinItem.View.CoinItemView>(go:  this.GetViewPrefab(), amount:  amount);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.CoinItem.View.CoinItemExplodeParticles>(go:  this.GetExplodePrefab(), amount:  amount);
        }
        protected override void ClearItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool)
        {
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.CoinItem.View.CoinItemView>(go:  this.GetViewPrefab());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.CoinItem.View.CoinItemExplodeParticles>(go:  this.GetExplodePrefab());
        }
        public CoinItemAssets()
        {
            val_1 = new UnityEngine.ScriptableObject();
        }
    
    }

}
