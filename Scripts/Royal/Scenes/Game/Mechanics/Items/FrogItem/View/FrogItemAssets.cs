using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.FrogItem.View
{
    public class FrogItemAssets : ItemAssets
    {
        // Methods
        private Royal.Scenes.Game.Mechanics.Items.FrogItem.View.FrogItemView GetViewPrefab()
        {
            if(0 == 0)
            {
                    return 0;
            }
            
            return 0;
        }
        protected override void CreateItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool, int amount)
        {
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.FrogItem.View.FrogItemView>(go:  this.GetViewPrefab(), amount:  amount);
        }
        protected override void ClearItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool)
        {
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.FrogItem.View.FrogItemView>(go:  this.GetViewPrefab());
        }
        public UnityEngine.AudioClip GetFrogCollectSfx()
        {
            return (UnityEngine.AudioClip)X8 + 32;
        }
        public UnityEngine.AudioClip GetFrogJumpSfx()
        {
            return (UnityEngine.AudioClip)X8 + 40;
        }
        public UnityEngine.AudioClip GetFrogCollectJumpSfx()
        {
            return (UnityEngine.AudioClip)X8 + 48;
        }
        public UnityEngine.AudioClip GetFrogCollect2Sfx()
        {
            return (UnityEngine.AudioClip)X8 + 56;
        }
        public FrogItemAssets()
        {
        
        }
    
    }

}
