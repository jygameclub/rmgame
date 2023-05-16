using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View
{
    public class TntItemAssets : ItemAssets
    {
        // Fields
        public UnityEngine.AnimationCurve rocketTntRotationEasing;
        
        // Methods
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntItemView GetViewPrefab()
        {
            if(0 == 0)
            {
                    return 0;
            }
            
            if((mem[-6917529027641081856]) == null)
            {
                    return 0;
            }
        
        }
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntItemExplodeParticles GetExplodePrefab()
        {
            if(185636 == 0)
            {
                    return 185636;
            }
            
            return 185636;
        }
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntItemFuseParticles GetFusePrefab()
        {
            if(1073741824 == 0)
            {
                    return 1073741824;
            }
            
            return 1073741824;
        }
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntTntCombo.TntTntComboView GetTntTntComboViewPrefab()
        {
            if(469778432 == 0)
            {
                    return 469778432;
            }
            
            return 469778432;
        }
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntTntCombo.Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.Combo.TntTntComboExplodeParticles GetTntTntComboExplodePrefab()
        {
            if(83886080 == 0)
            {
                    return 83886080;
            }
            
            if(((mem[83886080] + 200 + (Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntTntCombo.Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.Combo.TntTntComboExplodeParticles.__il2cppRuntime + -8) != null)
            {
                    throw new NullReferenceException();
            }
            
            return 83886080;
        }
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntTntCombo.TntTntComboFuseParticles GetTntTntComboFusePrefab()
        {
            if(0 == 0)
            {
                    return 0;
            }
            
            return 0;
        }
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntPropellerCombo.TntPropellerComboFuseParticles GetTntPropellerComboFusePrefab()
        {
            if(0 == 0)
            {
                    return 0;
            }
            
            return 0;
        }
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntRocketCombo.TntRocketComboParticles GetTntRocketComboParticlesPrefab()
        {
            if(0 == 0)
            {
                    return 0;
            }
            
            return 0;
        }
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntRocketCombo.TntRocketComboUseParticles GetTntRocketComboUseParticlesPrefab()
        {
            if(169028 == 0)
            {
                    return 169028;
            }
            
            return 169028;
        }
        public UnityEngine.Sprite GetSprite()
        {
            return (UnityEngine.Sprite)X8 + 32;
        }
        protected override void CreateItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool, int amount)
        {
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntItemView>(go:  this.GetViewPrefab(), amount:  amount);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntItemFuseParticles>(go:  this.GetFusePrefab(), amount:  amount);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntItemExplodeParticles>(go:  this.GetExplodePrefab(), amount:  amount);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntTntCombo.TntTntComboView>(go:  this.GetTntTntComboViewPrefab(), amount:  1);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntTntCombo.Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.Combo.TntTntComboExplodeParticles>(go:  this.GetTntTntComboExplodePrefab(), amount:  1);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntTntCombo.TntTntComboFuseParticles>(go:  this.GetTntTntComboFusePrefab(), amount:  1);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntPropellerCombo.TntPropellerComboFuseParticles>(go:  this.GetTntPropellerComboFusePrefab(), amount:  1);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntRocketCombo.TntRocketComboParticles>(go:  this.GetTntRocketComboParticlesPrefab(), amount:  1);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntRocketCombo.TntRocketComboUseParticles>(go:  this.GetTntRocketComboUseParticlesPrefab(), amount:  1);
        }
        protected override void ClearItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool)
        {
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntItemView>(go:  this.GetViewPrefab());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntItemFuseParticles>(go:  this.GetFusePrefab());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntItemExplodeParticles>(go:  this.GetExplodePrefab());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntTntCombo.TntTntComboView>(go:  this.GetTntTntComboViewPrefab());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntTntCombo.Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.Combo.TntTntComboExplodeParticles>(go:  this.GetTntTntComboExplodePrefab());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntTntCombo.TntTntComboFuseParticles>(go:  this.GetTntTntComboFusePrefab());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntPropellerCombo.TntPropellerComboFuseParticles>(go:  this.GetTntPropellerComboFusePrefab());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntRocketCombo.TntRocketComboParticles>(go:  this.GetTntRocketComboParticlesPrefab());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntRocketCombo.TntRocketComboUseParticles>(go:  this.GetTntRocketComboUseParticlesPrefab());
        }
        public UnityEngine.AudioClip GetTntCreationSfx()
        {
            return (UnityEngine.AudioClip)X8 + 32;
        }
        public UnityEngine.AudioClip GetTntExplodeSfx()
        {
            return (UnityEngine.AudioClip)X8 + 40;
        }
        public TntItemAssets()
        {
        
        }
    
    }

}
