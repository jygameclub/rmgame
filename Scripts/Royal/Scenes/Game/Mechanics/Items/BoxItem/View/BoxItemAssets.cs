using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.BoxItem.View
{
    public class BoxItemAssets : ItemAssets
    {
        // Methods
        private Royal.Scenes.Game.Mechanics.Items.BoxItem.View.BoxItemView GetViewPrefab()
        {
            if(0 == 0)
            {
                    return 0;
            }
            
            return 0;
        }
        private Royal.Scenes.Game.Mechanics.Items.BoxItem.View.BoxItemExplodeParticles GetExplodePrefab()
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
        public UnityEngine.AudioClip GetBoxBreak1Sfx()
        {
            return (UnityEngine.AudioClip)X8 + 32;
        }
        public UnityEngine.AudioClip GetBoxBreak2Sfx()
        {
            return (UnityEngine.AudioClip)X8 + 40;
        }
        public UnityEngine.AudioClip GetBoxBreak3Sfx()
        {
            return (UnityEngine.AudioClip)X8 + 48;
        }
        public UnityEngine.AudioClip GetBoxLayerBreak1Sfx()
        {
            return (UnityEngine.AudioClip)X8 + 56;
        }
        public UnityEngine.AudioClip GetBoxLayerBreak2Sfx()
        {
            return (UnityEngine.AudioClip)X8 + 64;
        }
        public UnityEngine.AudioClip GetBoxLayerBreak3Sfx()
        {
            return (UnityEngine.AudioClip)X8 + 72;
        }
        protected override void CreateItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool, int amount)
        {
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.BoxItem.View.BoxItemView>(go:  this.GetViewPrefab(), amount:  amount);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.BoxItem.View.BoxItemExplodeParticles>(go:  this.GetExplodePrefab(), amount:  amount + (amount << 1));
        }
        protected override void ClearItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool)
        {
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.BoxItem.View.BoxItemView>(go:  this.GetViewPrefab());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.BoxItem.View.BoxItemExplodeParticles>(go:  this.GetExplodePrefab());
        }
        public BoxItemAssets()
        {
        
        }
    
    }

}
