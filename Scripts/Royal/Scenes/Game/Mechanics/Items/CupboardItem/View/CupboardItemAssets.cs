using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.CupboardItem.View
{
    public class CupboardItemAssets : ItemAssets
    {
        // Methods
        private Royal.Scenes.Game.Mechanics.Items.CupboardItem.View.CupboardItemView GetViewPrefab()
        {
            if(0 == 0)
            {
                    return 0;
            }
            
            return 0;
        }
        private Royal.Scenes.Game.Mechanics.Items.CupboardItem.View.CupboardItemExplodeParticles GetExplodeParticlePrefab()
        {
            if(185636 == 0)
            {
                    return 185636;
            }
            
            return 185636;
        }
        private Royal.Scenes.Game.Mechanics.Items.CupboardItem.View.CupboardItemDoorExplodeParticles GetDoorExplodeParticlePrefab()
        {
            if(1073741824 == 0)
            {
                    return 1073741824;
            }
            
            return 1073741824;
        }
        private Royal.Scenes.Game.Mechanics.Items.CupboardItem.View.CupboardItemSingleExplodeParticles GetSingleExplodeParticlePrefab()
        {
            if(469778432 == 0)
            {
                    return 469778432;
            }
            
            return 469778432;
        }
        public UnityEngine.AudioClip GetDoorBreakSfx()
        {
            return (UnityEngine.AudioClip)X8 + 32;
        }
        public UnityEngine.AudioClip GetPlate1Sfx()
        {
            return (UnityEngine.AudioClip)X8 + 40;
        }
        public UnityEngine.AudioClip GetPlate2Sfx()
        {
            return (UnityEngine.AudioClip)X8 + 48;
        }
        public UnityEngine.AudioClip GetPlate3Sfx()
        {
            return (UnityEngine.AudioClip)X8 + 56;
        }
        public UnityEngine.AudioClip GetContainerBreakSfx()
        {
            return (UnityEngine.AudioClip)X8 + 64;
        }
        protected override void CreateItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool, int amount)
        {
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.CupboardItem.View.CupboardItemView>(go:  this.GetViewPrefab(), amount:  amount);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.CupboardItem.View.CupboardItemExplodeParticles>(go:  this.GetExplodeParticlePrefab(), amount:  amount);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.CupboardItem.View.CupboardItemDoorExplodeParticles>(go:  this.GetDoorExplodeParticlePrefab(), amount:  amount);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.CupboardItem.View.CupboardItemSingleExplodeParticles>(go:  this.GetSingleExplodeParticlePrefab(), amount:  amount << 2);
        }
        protected override void ClearItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool)
        {
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.CupboardItem.View.CupboardItemView>(go:  this.GetViewPrefab());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.CupboardItem.View.CupboardItemExplodeParticles>(go:  this.GetExplodeParticlePrefab());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.CupboardItem.View.CupboardItemDoorExplodeParticles>(go:  this.GetDoorExplodeParticlePrefab());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.CupboardItem.View.CupboardItemSingleExplodeParticles>(go:  this.GetSingleExplodeParticlePrefab());
        }
        public CupboardItemAssets()
        {
        
        }
    
    }

}
