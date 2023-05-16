using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SafeItem.View
{
    public class SafeItemAssets : ItemAssets
    {
        // Methods
        private Royal.Scenes.Game.Mechanics.Items.SafeItem.View.SafeItemView GetViewPrefab()
        {
            if(0 == 0)
            {
                    return 0;
            }
            
            return 0;
        }
        private Royal.Scenes.Game.Mechanics.Items.SafeItem.View.SafeItemExplodeParticles GetExplodeParticlePrefab()
        {
            if(185636 == 0)
            {
                    return 185636;
            }
            
            return 185636;
        }
        private Royal.Scenes.Game.Mechanics.Items.SafeItem.View.SafeItemSingleExplodeParticles GetSingleExplodeParticlePrefab()
        {
            if(1073741824 == 0)
            {
                    return 1073741824;
            }
            
            return 1073741824;
        }
        public UnityEngine.AudioClip GetContainerBreakSfx()
        {
            return (UnityEngine.AudioClip)X8 + 32;
        }
        public UnityEngine.AudioClip GetDoorBreakSfx()
        {
            return (UnityEngine.AudioClip)X8 + 40;
        }
        public UnityEngine.AudioClip GetHandleBreakSfx()
        {
            return (UnityEngine.AudioClip)X8 + 48;
        }
        protected override void CreateItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool, int amount)
        {
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.SafeItem.View.SafeItemView>(go:  this.GetViewPrefab(), amount:  amount);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.SafeItem.View.SafeItemExplodeParticles>(go:  this.GetExplodeParticlePrefab(), amount:  amount);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.SafeItem.View.SafeItemSingleExplodeParticles>(go:  this.GetSingleExplodeParticlePrefab(), amount:  amount + (amount << 1));
        }
        protected override void ClearItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool)
        {
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.SafeItem.View.SafeItemView>(go:  this.GetViewPrefab());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.SafeItem.View.SafeItemExplodeParticles>(go:  this.GetExplodeParticlePrefab());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.SafeItem.View.SafeItemSingleExplodeParticles>(go:  this.GetSingleExplodeParticlePrefab());
        }
        public SafeItemAssets()
        {
        
        }
    
    }

}
