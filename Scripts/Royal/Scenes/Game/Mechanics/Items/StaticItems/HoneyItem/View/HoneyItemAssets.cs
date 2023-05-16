using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.StaticItems.HoneyItem.View
{
    public class HoneyItemAssets : ItemAssets
    {
        // Fields
        public UnityEngine.Sprite[] corners;
        public UnityEngine.Sprite[] sides;
        public UnityEngine.Sprite[] cornerSides;
        public UnityEngine.Sprite[] insideCorners;
        private Royal.Scenes.Game.Levels.Units.LevelRandomManager randomManager;
        
        // Methods
        private Royal.Scenes.Game.Mechanics.Items.StaticItems.HoneyItem.View.HoneyItemView GetViewPrefab()
        {
            if(0 == 0)
            {
                    return 0;
            }
            
            return 0;
        }
        private Royal.Scenes.Game.Mechanics.Items.StaticItems.HoneyItem.View.HoneyItemExplodeParticles GetExplodePrefab()
        {
            if(185636 == 0)
            {
                    return 185636;
            }
            
            return 185636;
        }
        public UnityEngine.Sprite GetInnerFill()
        {
            return (UnityEngine.Sprite)X8 + 32;
        }
        public UnityEngine.Sprite GetConnect()
        {
            return (UnityEngine.Sprite)X8 + 40;
        }
        public UnityEngine.Sprite GetFirstCorner()
        {
            return (UnityEngine.Sprite)X8 + 48;
        }
        public UnityEngine.Sprite GetCornerSide()
        {
            this.randomManager.ShuffleArray<UnityEngine.Sprite>(array:  this.cornerSides);
            return (UnityEngine.Sprite)this.cornerSides[0];
        }
        public UnityEngine.Sprite GetInnerCorner()
        {
            this.randomManager.ShuffleArray<UnityEngine.Sprite>(array:  this.insideCorners);
            return (UnityEngine.Sprite)this.insideCorners[0];
        }
        public UnityEngine.Sprite GetCorner()
        {
            this.randomManager.ShuffleArray<UnityEngine.Sprite>(array:  this.corners);
            return (UnityEngine.Sprite)this.corners[0];
        }
        public UnityEngine.Sprite GetSide()
        {
            this.randomManager.ShuffleArray<UnityEngine.Sprite>(array:  this.sides);
            return (UnityEngine.Sprite)this.sides[0];
        }
        public UnityEngine.AudioClip GetClear1Sfx()
        {
            return (UnityEngine.AudioClip)X8 + 32;
        }
        public UnityEngine.AudioClip GetClear2Sfx()
        {
            return (UnityEngine.AudioClip)X8 + 40;
        }
        protected override void CreateItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool, int amount)
        {
            this.randomManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.LevelRandomManager>(contextId:  0);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.StaticItems.HoneyItem.View.HoneyItemView>(go:  this.GetViewPrefab(), amount:  amount);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.StaticItems.HoneyItem.View.HoneyItemExplodeParticles>(go:  this.GetExplodePrefab(), amount:  (amount < 25) ? amount : 25);
        }
        protected override void ClearItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool)
        {
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.StaticItems.HoneyItem.View.HoneyItemView>(go:  this.GetViewPrefab());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.StaticItems.HoneyItem.View.HoneyItemExplodeParticles>(go:  this.GetExplodePrefab());
        }
        public HoneyItemAssets()
        {
        
        }
    
    }

}
