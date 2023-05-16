using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.PiggyItem.View
{
    public class PiggyItemAssets : ItemAssets
    {
        // Methods
        private Royal.Scenes.Game.Mechanics.Items.PiggyItem.View.PiggyItemView GetViewPrefab()
        {
            if(0 == 0)
            {
                    return 0;
            }
            
            return 0;
        }
        private Royal.Scenes.Game.Mechanics.Items.PiggyItem.View.PiggyItemExplodeParticles GetExplodePrefab()
        {
            if(185636 == 0)
            {
                    return 185636;
            }
            
            return 185636;
        }
        public UnityEngine.AudioClip GetBreak1Sfx()
        {
            return (UnityEngine.AudioClip)X8 + 32;
        }
        public UnityEngine.AudioClip GetBreak2Sfx()
        {
            return (UnityEngine.AudioClip)X8 + 40;
        }
        public UnityEngine.AudioClip GetBreak3Sfx()
        {
            return (UnityEngine.AudioClip)X8 + 48;
        }
        protected override void CreateItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool, int amount)
        {
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.PiggyItem.View.PiggyItemView>(go:  this.GetViewPrefab(), amount:  amount);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.PiggyItem.View.PiggyItemExplodeParticles>(go:  this.GetExplodePrefab(), amount:  amount);
        }
        protected override void ClearItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool)
        {
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.PiggyItem.View.PiggyItemView>(go:  this.GetViewPrefab());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.PiggyItem.View.PiggyItemExplodeParticles>(go:  this.GetExplodePrefab());
        }
        public PiggyItemAssets()
        {
        
        }
    
    }

}
