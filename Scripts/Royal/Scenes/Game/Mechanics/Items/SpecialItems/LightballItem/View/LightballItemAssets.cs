using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View
{
    public class LightballItemAssets : ItemAssets
    {
        // Methods
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballItemView GetViewPrefab()
        {
            if(0 == 0)
            {
                    return 0;
            }
            
            return 0;
        }
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballItemRay GetLightballItemRay()
        {
            if(185636 == 0)
            {
                    return 185636;
            }
            
            return 185636;
        }
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballItemExplodeParticles GetExplodePrefabs()
        {
            if(1073741824 == 0)
            {
                    return 1073741824;
            }
            
            return 1073741824;
        }
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballItemBg GetLightballItemBg()
        {
            if(469778432 == 0)
            {
                    return 469778432;
            }
            
            return 469778432;
        }
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballUseParticles GetLightballUseParticles()
        {
            if(83886080 == 0)
            {
                    return 83886080;
            }
            
            return 83886080;
        }
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballEffectedItemExplodeParticles GetLightballEffectedItemExplodeParticles()
        {
            if(0 == 0)
            {
                    return 0;
            }
            
            return 0;
        }
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.BallBallCombo.BallBallComboView GetBallBallComboViewPrefab()
        {
            if(0 == 0)
            {
                    return 0;
            }
            
            return 0;
        }
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.BallBallCombo.BallBallComboUseParticles GetBallBallComboUseParticles()
        {
            if(0 == 0)
            {
                    return 0;
            }
            
            return 0;
        }
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.BallBallCombo.BallBallComboExplodeParticles GetBallBallComboExplodeParticles()
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
            int val_11 = amount;
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballItemView>(go:  this.GetViewPrefab(), amount:  val_11);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballItemExplodeParticles>(go:  this.GetExplodePrefabs(), amount:  val_11);
            val_11 = (val_11 + (val_11 << 2)) << 1;
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballItemRay>(go:  this.GetLightballItemRay(), amount:  val_11);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballItemBg>(go:  this.GetLightballItemBg(), amount:  val_11);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballUseParticles>(go:  this.GetLightballUseParticles(), amount:  val_11);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballEffectedItemExplodeParticles>(go:  this.GetLightballEffectedItemExplodeParticles(), amount:  val_11);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.BallBallCombo.BallBallComboView>(go:  this.GetBallBallComboViewPrefab(), amount:  1);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.BallBallCombo.BallBallComboUseParticles>(go:  this.GetBallBallComboUseParticles(), amount:  1);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.BallBallCombo.BallBallComboExplodeParticles>(go:  this.GetBallBallComboExplodeParticles(), amount:  1);
        }
        protected override void ClearItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool)
        {
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballItemView>(go:  this.GetViewPrefab());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballItemExplodeParticles>(go:  this.GetExplodePrefabs());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballItemRay>(go:  this.GetLightballItemRay());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballItemBg>(go:  this.GetLightballItemBg());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballUseParticles>(go:  this.GetLightballUseParticles());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballEffectedItemExplodeParticles>(go:  this.GetLightballEffectedItemExplodeParticles());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.BallBallCombo.BallBallComboView>(go:  this.GetBallBallComboViewPrefab());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.BallBallCombo.BallBallComboUseParticles>(go:  this.GetBallBallComboUseParticles());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.BallBallCombo.BallBallComboExplodeParticles>(go:  this.GetBallBallComboExplodeParticles());
        }
        public UnityEngine.Sprite GetSpriteFromMatchType(Royal.Scenes.Game.Mechanics.Matches.MatchType type)
        {
            if((type - 1) > 5)
            {
                    return (UnityEngine.Sprite);
            }
            
            var val_2 = 36610224 + ((type - 1)) << 2;
            val_2 = val_2 + 36610224;
            goto (36610224 + ((type - 1)) << 2 + 36610224);
        }
        public UnityEngine.AudioClip GetLightballExplode()
        {
            return (UnityEngine.AudioClip)X8 + 32;
        }
        public UnityEngine.AudioClip GetLightballRay1()
        {
            return (UnityEngine.AudioClip)X8 + 40;
        }
        public UnityEngine.AudioClip GetLightballRay2()
        {
            return (UnityEngine.AudioClip)X8 + 48;
        }
        public UnityEngine.AudioClip GetLightballRay3()
        {
            return (UnityEngine.AudioClip)X8 + 56;
        }
        public UnityEngine.AudioClip GetLightballLightballCombo()
        {
            return (UnityEngine.AudioClip)X8 + 64;
        }
        public UnityEngine.AudioClip GetLightballCreation()
        {
            return (UnityEngine.AudioClip)X8 + 72;
        }
        public UnityEngine.AudioClip GetLightballStart()
        {
            return (UnityEngine.AudioClip)X8 + 80;
        }
        public LightballItemAssets()
        {
        
        }
    
    }

}
