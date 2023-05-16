using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.DrillItem
{
    public class DrillItemAssets : ItemAssets
    {
        // Fields
        public UnityEngine.Material counterMaterial;
        public UnityEngine.Sprite[] startSprites;
        public UnityEngine.Sprite[] startLoop;
        public UnityEngine.Sprite[] hitSprites;
        
        // Methods
        private Royal.Scenes.Game.Mechanics.Items.DrillItem.View.DrillItemView GetViewPrefab()
        {
            if(0 == 0)
            {
                    return 0;
            }
            
            return 0;
        }
        private Royal.Scenes.Game.Mechanics.Items.DrillItem.View.DrillTracerParticles GetTracerParticles()
        {
            if(185636 == 0)
            {
                    return 185636;
            }
            
            return 185636;
        }
        public UnityEngine.Sprite GetDrillSprite(Royal.Scenes.Game.Mechanics.Matches.MatchType matchType)
        {
            if((matchType - 1) > 4)
            {
                    return (UnityEngine.Sprite);
            }
            
            var val_2 = 36597212 + ((matchType - 1)) << 2;
            val_2 = val_2 + 36597212;
            goto (36597212 + ((matchType - 1)) << 2 + 36597212);
        }
        public UnityEngine.Sprite GetInitialHeadSprite()
        {
            return (UnityEngine.Sprite)X8 + 72;
        }
        public UnityEngine.AudioClip GetSfx(int index)
        {
            var val_1 = X8 + (index << 3);
            return (UnityEngine.AudioClip)(X8 + (index) << 3) + 32;
        }
        public UnityEngine.Material GetTokenMaterial()
        {
            return (UnityEngine.Material)this.counterMaterial;
        }
        protected override void CreateItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool, int amount)
        {
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.DrillItem.View.DrillItemView>(go:  this.GetViewPrefab(), amount:  amount);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.DrillItem.View.DrillTracerParticles>(go:  this.GetTracerParticles(), amount:  amount);
        }
        protected override void ClearItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool)
        {
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.DrillItem.View.DrillItemView>(go:  this.GetViewPrefab());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.DrillItem.View.DrillTracerParticles>(go:  this.GetTracerParticles());
        }
        public DrillItemAssets()
        {
        
        }
    
    }

}
