using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.VaseItem.View
{
    public class VaseItemAssets : ItemAssets
    {
        // Methods
        private Royal.Scenes.Game.Mechanics.Items.VaseItem.View.VaseItemView GetViewPrefab()
        {
            if(0 == 0)
            {
                    return 0;
            }
            
            return 0;
        }
        private Royal.Scenes.Game.Mechanics.Items.VaseItem.View.VaseItemExplodeParticles GetExplodePrefab()
        {
            if(185636 == 0)
            {
                    return 185636;
            }
            
            return 185636;
        }
        public UnityEngine.Sprite GetSpriteForLayer(int layer)
        {
            var val_2 = X8 + ((layer - 1) << 3);
            return (UnityEngine.Sprite)(X8 + ((layer - 1)) << 3) + 32;
        }
        public UnityEngine.AudioClip GetBreak1Sfx()
        {
            return (UnityEngine.AudioClip)X8 + 32;
        }
        public UnityEngine.AudioClip GetBreak2Sfx()
        {
            return (UnityEngine.AudioClip)X8 + 40;
        }
        public UnityEngine.AudioClip GetCrack1Sfx()
        {
            return (UnityEngine.AudioClip)X8 + 48;
        }
        public UnityEngine.AudioClip GetCrack2Sfx()
        {
            return (UnityEngine.AudioClip)X8 + 56;
        }
        protected override void CreateItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool, int amount)
        {
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.VaseItem.View.VaseItemView>(go:  this.GetViewPrefab(), amount:  amount);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.VaseItem.View.VaseItemExplodeParticles>(go:  this.GetExplodePrefab(), amount:  amount << 1);
        }
        protected override void ClearItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool)
        {
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.VaseItem.View.VaseItemView>(go:  this.GetViewPrefab());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.VaseItem.View.VaseItemExplodeParticles>(go:  this.GetExplodePrefab());
        }
        public VaseItemAssets()
        {
        
        }
    
    }

}
