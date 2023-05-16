using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.OysterItem.View
{
    public class OysterItemAssets : ItemAssets
    {
        // Methods
        private Royal.Scenes.Game.Mechanics.Items.OysterItem.View.OysterItemView GetViewPrefab()
        {
            if(0 == 0)
            {
                    return 0;
            }
            
            return 0;
        }
        private Royal.Scenes.Game.Mechanics.Items.OysterItem.View.OysterExplodeParticles GetExplodePrefab()
        {
            if(185636 == 0)
            {
                    return 185636;
            }
            
            return 185636;
        }
        private Royal.Scenes.Game.Mechanics.Items.OysterItem.View.PearlGoalView GetPearlGoalView()
        {
            if(1073741824 == 0)
            {
                    return 1073741824;
            }
            
            return 1073741824;
        }
        protected override void CreateItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool, int amount)
        {
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.OysterItem.View.OysterItemView>(go:  this.GetViewPrefab(), amount:  amount);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.OysterItem.View.OysterExplodeParticles>(go:  this.GetExplodePrefab(), amount:  amount);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.OysterItem.View.PearlGoalView>(go:  this.GetPearlGoalView(), amount:  amount);
        }
        protected override void ClearItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool)
        {
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.OysterItem.View.OysterItemView>(go:  this.GetViewPrefab());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.OysterItem.View.OysterExplodeParticles>(go:  this.GetExplodePrefab());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.OysterItem.View.PearlGoalView>(go:  this.GetPearlGoalView());
        }
        public UnityEngine.AudioClip GetSfxForLayer(int layer)
        {
            var val_2 = X8 + ((layer - 1) << 3);
            return (UnityEngine.AudioClip)(X8 + ((layer - 1)) << 3) + 32;
        }
        public OysterItemAssets()
        {
        
        }
    
    }

}
