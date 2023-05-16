using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View
{
    public class PropellerItemAssets : ItemAssets
    {
        // Methods
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerItemView GetViewPrefab()
        {
            if(0 == 0)
            {
                    return 0;
            }
            
            return 0;
        }
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerItemExplodeParticles GetExplodePrefabs()
        {
            if(185636 == 0)
            {
                    return 185636;
            }
            
            return 185636;
        }
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerTargetExplodeParticles GetTargetExplodePrefabs()
        {
            if(1073741824 == 0)
            {
                    return 1073741824;
            }
            
            return 1073741824;
        }
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerRocketComboParticles GetPropellerRocketComboParticlePrefab()
        {
            if(469778432 == 0)
            {
                    return 469778432;
            }
            
            return 469778432;
        }
        public UnityEngine.AudioClip GetPropellerCreationSfx()
        {
            return (UnityEngine.AudioClip)X8 + 32;
        }
        public UnityEngine.AudioClip GetPropellerFlySfx()
        {
            return (UnityEngine.AudioClip)X8 + 40;
        }
        public UnityEngine.AudioClip GetPropellerHitSfx()
        {
            return (UnityEngine.AudioClip)X8 + 48;
        }
        public UnityEngine.AudioClip GetPropellerTakeOffSfx()
        {
            return (UnityEngine.AudioClip)X8 + 56;
        }
        protected override void CreateItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool, int amount)
        {
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerItemView>(go:  this.GetViewPrefab(), amount:  amount);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerItemExplodeParticles>(go:  this.GetExplodePrefabs(), amount:  amount);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerTargetExplodeParticles>(go:  this.GetTargetExplodePrefabs(), amount:  amount);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerRocketComboParticles>(go:  this.GetPropellerRocketComboParticlePrefab(), amount:  1);
        }
        protected override void ClearItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool)
        {
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerItemView>(go:  this.GetViewPrefab());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerItemExplodeParticles>(go:  this.GetExplodePrefabs());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerTargetExplodeParticles>(go:  this.GetTargetExplodePrefabs());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerRocketComboParticles>(go:  this.GetPropellerRocketComboParticlePrefab());
        }
        public PropellerItemAssets()
        {
        
        }
    
    }

}
