using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View
{
    public class CookieJarItemAssets : ItemAssets
    {
        // Methods
        private Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.CookieJarItemView GetViewPrefab()
        {
            if(0 == 0)
            {
                    return 0;
            }
            
            return 0;
        }
        private Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.CookieGoalView GetGoalPrefab()
        {
            if(185636 == 0)
            {
                    return 185636;
            }
            
            return 185636;
        }
        private Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.CookieTracerParticles GetTracerPrefab()
        {
            if(1073741824 == 0)
            {
                    return 1073741824;
            }
            
            return 1073741824;
        }
        private Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.CookieJarItemExplodeParticles GetExplodeParticles()
        {
            if(469778432 == 0)
            {
                    return 469778432;
            }
            
            return 469778432;
        }
        public UnityEngine.AudioClip GetMailDestroySfx()
        {
            return (UnityEngine.AudioClip)X8 + 32;
        }
        public UnityEngine.AudioClip GetMailExitSfx()
        {
            return (UnityEngine.AudioClip)X8 + 40;
        }
        protected override void CreateItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool, int amount)
        {
            int val_5 = amount;
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.CookieJarItemView>(go:  this.GetViewPrefab(), amount:  val_5);
            val_5 = val_5 << 1;
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.CookieJarItemExplodeParticles>(go:  this.GetExplodeParticles(), amount:  val_5);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.CookieGoalView>(go:  this.GetGoalPrefab(), amount:  val_5);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.CookieTracerParticles>(go:  this.GetTracerPrefab(), amount:  val_5);
        }
        protected override void ClearItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool)
        {
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.CookieJarItemView>(go:  this.GetViewPrefab());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.CookieJarItemExplodeParticles>(go:  this.GetExplodeParticles());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.CookieGoalView>(go:  this.GetGoalPrefab());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.CookieTracerParticles>(go:  this.GetTracerPrefab());
        }
        public CookieJarItemAssets()
        {
            val_1 = new UnityEngine.ScriptableObject();
        }
    
    }

}
