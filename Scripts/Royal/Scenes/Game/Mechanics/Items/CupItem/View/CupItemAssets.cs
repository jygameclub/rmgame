using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.CupItem.View
{
    public class CupItemAssets : ItemAssets
    {
        // Methods
        private Royal.Scenes.Game.Mechanics.Items.CupItem.View.CupItemView GetViewPrefab()
        {
            if(0 == 0)
            {
                    return 0;
            }
            
            return 0;
        }
        private Royal.Scenes.Game.Mechanics.Items.CupItem.View.CupItemExplodeParticles GetCupParticles()
        {
            if(185636 == 0)
            {
                    return 185636;
            }
            
            return 185636;
        }
        private Royal.Scenes.Game.Mechanics.Items.CupItem.View.CupShelfDestroyParticles GetCupShelfDestroyParticles()
        {
            if(1073741824 == 0)
            {
                    return 1073741824;
            }
            
            return 1073741824;
        }
        public UnityEngine.Sprite GetSprite(int order)
        {
            var val_1 = X8 + (order << 3);
            return (UnityEngine.Sprite)(X8 + (order) << 3) + 32;
        }
        public UnityEngine.Sprite GetCupShadowNormal()
        {
            return (UnityEngine.Sprite)X8 + 120;
        }
        public UnityEngine.Sprite GetCupShadowBottom()
        {
            return (UnityEngine.Sprite)X8 + 128;
        }
        protected override void CreateItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool, int amount)
        {
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.CupItem.View.CupItemView>(go:  this.GetViewPrefab(), amount:  amount);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.CupItem.View.CupItemExplodeParticles>(go:  this.GetCupParticles(), amount:  amount);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.CupItem.View.CupShelfDestroyParticles>(go:  this.GetCupShelfDestroyParticles(), amount:  amount);
        }
        protected override void ClearItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool)
        {
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.CupItem.View.CupItemView>(go:  this.GetViewPrefab());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.CupItem.View.CupItemExplodeParticles>(go:  this.GetCupParticles());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.CupItem.View.CupShelfDestroyParticles>(go:  this.GetCupShelfDestroyParticles());
        }
        public UnityEngine.AudioClip GetSfx(int i)
        {
            var val_1 = X8 + (i << 3);
            return (UnityEngine.AudioClip)(X8 + (i) << 3) + 32;
        }
        public CupItemAssets()
        {
            val_1 = new UnityEngine.ScriptableObject();
        }
    
    }

}
