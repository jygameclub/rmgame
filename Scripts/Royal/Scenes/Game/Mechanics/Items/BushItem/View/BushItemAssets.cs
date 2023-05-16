using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.BushItem.View
{
    public class BushItemAssets : ItemAssets
    {
        // Fields
        protected Royal.Scenes.Game.Mechanics.Items.BushItem.View.GrassSpread.GrassSpreadAnimData[] grassSpreadAnimations;
        
        // Methods
        private Royal.Scenes.Game.Mechanics.Items.BushItem.View.BushItemView GetViewPrefab()
        {
            if(0 == 0)
            {
                    return 0;
            }
            
            return 0;
        }
        private Royal.Scenes.Game.Mechanics.Items.BushItem.View.BushItemExplodeParticles GetParticles()
        {
            if(185636 == 0)
            {
                    return 185636;
            }
            
            return 185636;
        }
        private Royal.Scenes.Game.Mechanics.Items.BushItem.View.GrassSpread.GrassSpreadAnimationView GetGrassSpreadPrefab()
        {
            if(1073741824 == 0)
            {
                    return 1073741824;
            }
            
            return 1073741824;
        }
        public Royal.Scenes.Game.Mechanics.Items.BushItem.View.GrassSpread.GrassSpreadAnimData GetGrassAnimationData(int index)
        {
            return (Royal.Scenes.Game.Mechanics.Items.BushItem.View.GrassSpread.GrassSpreadAnimData)this.grassSpreadAnimations[index];
        }
        public UnityEngine.AudioClip GetContainerBreakSfx()
        {
            return (UnityEngine.AudioClip)X8 + 32;
        }
        public UnityEngine.AudioClip GetFlowerClearSfx()
        {
            return (UnityEngine.AudioClip)X8 + 40;
        }
        public UnityEngine.AudioClip GetGrassClearSfx()
        {
            return (UnityEngine.AudioClip)X8 + 48;
        }
        public UnityEngine.AudioClip GetGrassClear2Sfx()
        {
            return (UnityEngine.AudioClip)X8 + 56;
        }
        public UnityEngine.AudioClip GetGrassSpreadSfx()
        {
            return (UnityEngine.AudioClip)X8 + 64;
        }
        protected override void CreateItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool, int amount)
        {
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.BushItem.View.BushItemView>(go:  this.GetViewPrefab(), amount:  amount);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.BushItem.View.BushItemExplodeParticles>(go:  this.GetParticles(), amount:  amount);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.BushItem.View.GrassSpread.GrassSpreadAnimationView>(go:  this.GetGrassSpreadPrefab(), amount:  (amount + (amount << 2)) << 1);
        }
        protected override void ClearItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool)
        {
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.BushItem.View.BushItemView>(go:  this.GetViewPrefab());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.BushItem.View.BushItemExplodeParticles>(go:  this.GetParticles());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.BushItem.View.GrassSpread.GrassSpreadAnimationView>(go:  this.GetGrassSpreadPrefab());
        }
        public BushItemAssets()
        {
        
        }
    
    }

}
