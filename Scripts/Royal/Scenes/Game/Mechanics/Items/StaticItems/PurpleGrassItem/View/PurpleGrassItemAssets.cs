using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.StaticItems.PurpleGrassItem.View
{
    public class PurpleGrassItemAssets : ItemAssets
    {
        // Fields
        public UnityEngine.Sprite[] bases;
        private Royal.Scenes.Game.Levels.Units.LevelRandomManager randomManager;
        
        // Methods
        private Royal.Scenes.Game.Mechanics.Items.StaticItems.PurpleGrassItem.View.PurpleGrassItemView GetViewPrefab()
        {
            if(0 == 0)
            {
                    return 0;
            }
            
            return 0;
        }
        private Royal.Scenes.Game.Mechanics.Items.StaticItems.PurpleGrassItem.View.PurpleGrassItemExplodeParticles GetExplodePrefab()
        {
            if(185636 == 0)
            {
                    return 185636;
            }
            
            return 185636;
        }
        public UnityEngine.Sprite GetBase(int layer)
        {
            return (UnityEngine.Sprite)this.bases[0];
        }
        public UnityEngine.Sprite GetShadow()
        {
            return (UnityEngine.Sprite)X8 + 32;
        }
        public UnityEngine.Sprite GetPatch(int layer)
        {
            var val_1 = X8 + (layer << 3);
            return (UnityEngine.Sprite)(X8 + (layer) << 3) + 32;
        }
        public UnityEngine.AudioClip GetGrassClear1Sfx()
        {
            return (UnityEngine.AudioClip)X8 + 32;
        }
        public UnityEngine.AudioClip GetGrassClear2Sfx()
        {
            return (UnityEngine.AudioClip)X8 + 40;
        }
        protected override void CreateItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool, int amount)
        {
            this.randomManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.LevelRandomManager>(contextId:  0);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.StaticItems.PurpleGrassItem.View.PurpleGrassItemView>(go:  this.GetViewPrefab(), amount:  amount);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.StaticItems.PurpleGrassItem.View.PurpleGrassItemExplodeParticles>(go:  this.GetExplodePrefab(), amount:  amount << 1);
        }
        protected override void ClearItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool)
        {
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.StaticItems.PurpleGrassItem.View.PurpleGrassItemView>(go:  this.GetViewPrefab());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.StaticItems.PurpleGrassItem.View.PurpleGrassItemExplodeParticles>(go:  this.GetExplodePrefab());
        }
        public PurpleGrassItemAssets()
        {
        
        }
    
    }

}
