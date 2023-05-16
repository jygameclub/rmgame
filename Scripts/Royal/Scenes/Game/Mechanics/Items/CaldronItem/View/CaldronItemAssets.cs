using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.CaldronItem.View
{
    public class CaldronItemAssets : ItemAssets
    {
        // Methods
        private Royal.Scenes.Game.Mechanics.Items.CaldronItem.View.CaldronItemView GetViewPrefab()
        {
            if(0 == 0)
            {
                    return 0;
            }
            
            return 0;
        }
        private Royal.Scenes.Game.Mechanics.Items.CaldronItem.View.CaldronThrowItemView GetThrowViewPrefab()
        {
            if(185636 == 0)
            {
                    return 185636;
            }
            
            return 185636;
        }
        protected override void CreateItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool, int amount)
        {
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.CaldronItem.View.CaldronItemView>(go:  this.GetViewPrefab(), amount:  amount);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.CaldronItem.View.CaldronThrowItemView>(go:  this.GetThrowViewPrefab(), amount:  amount);
        }
        protected override void ClearItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool)
        {
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.CaldronItem.View.CaldronItemView>(go:  this.GetViewPrefab());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.CaldronItem.View.CaldronThrowItemView>(go:  this.GetThrowViewPrefab());
        }
        public UnityEngine.AudioClip GetSfx(int id)
        {
            var val_1 = X8 + (id << 3);
            return (UnityEngine.AudioClip)(X8 + (id) << 3) + 32;
        }
        public CaldronItemAssets()
        {
            val_1 = new UnityEngine.ScriptableObject();
        }
    
    }

}
