using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.RockItem.View
{
    public class RockItemAssets : ItemAssets
    {
        // Methods
        private Royal.Scenes.Game.Mechanics.Items.RockItem.View.RockItemView GetViewPrefab()
        {
            if(0 == 0)
            {
                    return 0;
            }
            
            return 0;
        }
        private Royal.Scenes.Game.Mechanics.Items.RockItem.View.RockItemExplodeParticles GetExplodePrefab()
        {
            if(185636 == 0)
            {
                    return 185636;
            }
            
            return 185636;
        }
        private Royal.Scenes.Game.Mechanics.Items.RockItem.View.GemGoalView GetGoalPrefab()
        {
            if(1073741824 == 0)
            {
                    return 1073741824;
            }
            
            return 1073741824;
        }
        public UnityEngine.Sprite GetSpriteForLayer(int layer)
        {
            var val_2 = X8 + ((layer - 1) << 3);
            return (UnityEngine.Sprite)(X8 + ((layer - 1)) << 3) + 32;
        }
        public UnityEngine.AudioClip GetRockBreak1Sfx()
        {
            return (UnityEngine.AudioClip)X8 + 32;
        }
        public UnityEngine.AudioClip GetRockBreak2Sfx()
        {
            return (UnityEngine.AudioClip)X8 + 40;
        }
        public UnityEngine.AudioClip GetRockGemBreak1Sfx()
        {
            return (UnityEngine.AudioClip)X8 + 48;
        }
        public UnityEngine.AudioClip GetRockGemBreak2Sfx()
        {
            return (UnityEngine.AudioClip)X8 + 56;
        }
        protected override void CreateItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool, int amount)
        {
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.RockItem.View.RockItemView>(go:  this.GetViewPrefab(), amount:  amount);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.RockItem.View.RockItemExplodeParticles>(go:  this.GetExplodePrefab(), amount:  amount);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.RockItem.View.GemGoalView>(go:  this.GetGoalPrefab(), amount:  amount);
        }
        protected override void ClearItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool)
        {
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.RockItem.View.RockItemView>(go:  this.GetViewPrefab());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.RockItem.View.RockItemExplodeParticles>(go:  this.GetExplodePrefab());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.RockItem.View.GemGoalView>(go:  this.GetGoalPrefab());
        }
        public RockItemAssets()
        {
        
        }
    
    }

}
