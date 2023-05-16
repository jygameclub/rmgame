using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.HatItem.View
{
    public class HatItemAssets : ItemAssets
    {
        // Methods
        private Royal.Scenes.Game.Mechanics.Items.HatItem.View.HatItemView GetViewPrefab()
        {
            if(0 == 0)
            {
                    return 0;
            }
            
            return 0;
        }
        private Royal.Scenes.Game.Mechanics.Items.HatItem.View.HatThrowItemView GetThrowViewPrefab()
        {
            if(185636 == 0)
            {
                    return 185636;
            }
            
            return 185636;
        }
        protected override void CreateItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool, int amount)
        {
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.HatItem.View.HatItemView>(go:  this.GetViewPrefab(), amount:  amount);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.HatItem.View.HatThrowItemView>(go:  this.GetThrowViewPrefab(), amount:  amount);
        }
        protected override void ClearItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool)
        {
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.HatItem.View.HatItemView>(go:  this.GetViewPrefab());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.HatItem.View.HatThrowItemView>(go:  this.GetThrowViewPrefab());
        }
        public UnityEngine.AudioClip GetSfx(int id)
        {
            var val_1 = X8 + (id << 3);
            return (UnityEngine.AudioClip)(X8 + (id) << 3) + 32;
        }
        public HatItemAssets()
        {
        
        }
    
    }

}
