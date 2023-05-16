using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.LogItem.View
{
    public class IceCrusherItemAssets : ItemAssets
    {
        // Methods
        private Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.View.IceCrusherItemView GetViewPrefab()
        {
            if(0 == 0)
            {
                    return 0;
            }
            
            return 0;
        }
        private Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.View.IceCrusherParticles GetIceMachineParticles()
        {
            if(185636 == 0)
            {
                    return 185636;
            }
            
            return 185636;
        }
        private Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.View.IceCrusherExplodeParticles GetIceMachineExplodeParticles()
        {
            if(1073741824 == 0)
            {
                    return 1073741824;
            }
            
            return 1073741824;
        }
        public UnityEngine.Sprite GetIceHorizontal()
        {
            return (UnityEngine.Sprite)X8 + 32;
        }
        public UnityEngine.Sprite GetIceVertical()
        {
            return (UnityEngine.Sprite)X8 + 40;
        }
        public UnityEngine.Sprite GetIceDownPatch()
        {
            return (UnityEngine.Sprite)X8 + 48;
        }
        protected override void CreateItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool, int amount)
        {
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.View.IceCrusherItemView>(go:  this.GetViewPrefab(), amount:  amount);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.View.IceCrusherParticles>(go:  this.GetIceMachineParticles(), amount:  amount << 1);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.View.IceCrusherExplodeParticles>(go:  this.GetIceMachineExplodeParticles(), amount:  amount);
        }
        protected override void ClearItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool)
        {
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.View.IceCrusherItemView>(go:  this.GetViewPrefab());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.View.IceCrusherParticles>(go:  this.GetIceMachineParticles());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.View.IceCrusherExplodeParticles>(go:  this.GetIceMachineExplodeParticles());
        }
        public UnityEngine.AudioClip GetIceCrusherExplode()
        {
            return (UnityEngine.AudioClip)X8 + 32;
        }
        public UnityEngine.AudioClip GetIceCrusherLoop()
        {
            return (UnityEngine.AudioClip)X8 + 40;
        }
        public UnityEngine.AudioClip GetIceCrusherLoopEnd()
        {
            return (UnityEngine.AudioClip)X8 + 48;
        }
        public IceCrusherItemAssets()
        {
        
        }
    
    }

}
