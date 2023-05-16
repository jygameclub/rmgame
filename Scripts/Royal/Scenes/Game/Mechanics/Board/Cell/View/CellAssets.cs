using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Board.Cell.View
{
    public class CellAssets : ItemAssets
    {
        // Methods
        private Royal.Scenes.Game.Mechanics.Board.Cell.View.CellView GetCellView()
        {
            if(0 == 0)
            {
                    return 0;
            }
            
            return 0;
        }
        private Royal.Scenes.Game.Mechanics.Board.Cell.View.SwapParticles GetSwapParticles()
        {
            if(185636 == 0)
            {
                    return 185636;
            }
            
            return 185636;
        }
        private Royal.Scenes.Game.Mechanics.Board.Cell.View.HintParticles GetHintParticles()
        {
            if(1073741824 == 0)
            {
                    return 1073741824;
            }
            
            return 1073741824;
        }
        public UnityEngine.Sprite GetOnePixel()
        {
            return (UnityEngine.Sprite)X8 + 32;
        }
        public UnityEngine.Sprite GetFillPart()
        {
            return (UnityEngine.Sprite)X8 + 40;
        }
        public UnityEngine.Sprite GetSidePart()
        {
            return (UnityEngine.Sprite)X8 + 48;
        }
        public UnityEngine.Sprite GetInnerCornerPart()
        {
            return (UnityEngine.Sprite)X8 + 56;
        }
        public UnityEngine.Sprite GetOuterCornerPart()
        {
            return (UnityEngine.Sprite)X8 + 64;
        }
        protected override void CreateItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool, int count)
        {
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Board.Cell.View.CellView>(go:  this.GetCellView(), amount:  count);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Board.Cell.View.SwapParticles>(go:  this.GetSwapParticles(), amount:  10);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Board.Cell.View.HintParticles>(go:  this.GetHintParticles(), amount:  10);
        }
        protected override void ClearItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool)
        {
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Board.Cell.View.CellView>(go:  this.GetCellView());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Board.Cell.View.SwapParticles>(go:  this.GetSwapParticles());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Board.Cell.View.HintParticles>(go:  this.GetHintParticles());
        }
        public CellAssets()
        {
        
        }
    
    }

}
