using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.EggItem.View
{
    public class EggItemAssets : ItemAssets
    {
        // Methods
        private Royal.Scenes.Game.Mechanics.Items.EggItem.View.EggItemView GetViewPrefab()
        {
            if(0 == 0)
            {
                    return 0;
            }
            
            return 0;
        }
        private Royal.Scenes.Game.Mechanics.Items.EggItem.View.EggItemExplodeParticles GetExplodePrefab()
        {
            if(185636 == 0)
            {
                    return 185636;
            }
            
            return 185636;
        }
        public UnityEngine.Sprite GetSprite()
        {
            return (UnityEngine.Sprite)X8 + 32;
        }
        public UnityEngine.AudioClip GetEggBreak1Sfx()
        {
            return (UnityEngine.AudioClip)X8 + 32;
        }
        public UnityEngine.AudioClip GetEggBreak2Sfx()
        {
            return (UnityEngine.AudioClip)X8 + 40;
        }
        public UnityEngine.AudioClip GetEggBreak3Sfx()
        {
            return (UnityEngine.AudioClip)X8 + 48;
        }
        protected override void CreateItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool, int amount)
        {
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.EggItem.View.EggItemView>(go:  this.GetViewPrefab(), amount:  amount);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.EggItem.View.EggItemExplodeParticles>(go:  this.GetExplodePrefab(), amount:  amount);
        }
        protected override void ClearItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool)
        {
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.EggItem.View.EggItemView>(go:  this.GetViewPrefab());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.EggItem.View.EggItemExplodeParticles>(go:  this.GetExplodePrefab());
        }
        public EggItemAssets()
        {
        
        }
    
    }

}
