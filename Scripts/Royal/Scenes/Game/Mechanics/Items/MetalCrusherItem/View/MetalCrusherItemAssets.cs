using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View
{
    public class MetalCrusherItemAssets : ItemAssets
    {
        // Methods
        private Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View.MetalCrusherItemView GetViewPrefab()
        {
            if(0 == 0)
            {
                    return 0;
            }
            
            return 0;
        }
        private Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View.MetalCrusherParticles GetMetalMachineParticles()
        {
            if(185636 == 0)
            {
                    return 185636;
            }
            
            return 185636;
        }
        private Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View.MetalCrusherExplodeParticles GetMetalMachineExplodeParticles()
        {
            if(1073741824 == 0)
            {
                    return 1073741824;
            }
            
            return 1073741824;
        }
        public UnityEngine.Sprite GetMetalTileRight()
        {
            return (UnityEngine.Sprite)X8 + 32;
        }
        public UnityEngine.Sprite GetMetalTileUp()
        {
            return (UnityEngine.Sprite)X8 + 40;
        }
        public UnityEngine.Sprite GetFurnaceHorizontal()
        {
            return (UnityEngine.Sprite)X8 + 48;
        }
        public UnityEngine.Sprite GetFurnaceVertical()
        {
            return (UnityEngine.Sprite)X8 + 56;
        }
        public UnityEngine.Sprite GetFurnaceHeatedHorizontal()
        {
            return (UnityEngine.Sprite)X8 + 64;
        }
        public UnityEngine.Sprite GetFurnaceHeatedVertical()
        {
            return (UnityEngine.Sprite)X8 + 72;
        }
        public UnityEngine.Sprite GetFurnaceExtraHorizontal()
        {
            return (UnityEngine.Sprite)X8 + 80;
        }
        public UnityEngine.Sprite GetFurnaceExtraVertical()
        {
            return (UnityEngine.Sprite)X8 + 88;
        }
        public UnityEngine.Sprite GetFurnaceExtraHeatedHorizontal()
        {
            return (UnityEngine.Sprite)X8 + 96;
        }
        public UnityEngine.Sprite GetFurnaceExtraHeatedVertical()
        {
            return (UnityEngine.Sprite)X8 + 104;
        }
        public UnityEngine.Sprite GetMetalTileLeft()
        {
            return (UnityEngine.Sprite)X8 + 112;
        }
        public UnityEngine.Sprite GetMetalTileDown()
        {
            return (UnityEngine.Sprite)X8 + 120;
        }
        public UnityEngine.Sprite GetFurnaceVerticalDown()
        {
            return (UnityEngine.Sprite)X8 + 128;
        }
        public UnityEngine.Sprite GetFurnaceHeatedVerticalDown()
        {
            return (UnityEngine.Sprite)X8 + 136;
        }
        public UnityEngine.Sprite GetFurnaceExtraVerticalDown()
        {
            return (UnityEngine.Sprite)X8 + 144;
        }
        public UnityEngine.Sprite GetFurnaceExtraHeatedVerticalDown()
        {
            return (UnityEngine.Sprite)X8 + 152;
        }
        protected override void CreateItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool, int amount)
        {
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View.MetalCrusherItemView>(go:  this.GetViewPrefab(), amount:  amount);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View.MetalCrusherParticles>(go:  this.GetMetalMachineParticles(), amount:  amount << 1);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View.MetalCrusherExplodeParticles>(go:  this.GetMetalMachineExplodeParticles(), amount:  amount);
        }
        protected override void ClearItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool)
        {
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View.MetalCrusherItemView>(go:  this.GetViewPrefab());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View.MetalCrusherParticles>(go:  this.GetMetalMachineParticles());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View.MetalCrusherExplodeParticles>(go:  this.GetMetalMachineExplodeParticles());
        }
        public UnityEngine.AudioClip GetMetalCrusherExplodeClip()
        {
            return (UnityEngine.AudioClip)X8 + 32;
        }
        public UnityEngine.AudioClip GetMetalCrusherMeltClip()
        {
            return (UnityEngine.AudioClip)X8 + 40;
        }
        public MetalCrusherItemAssets()
        {
        
        }
    
    }

}
