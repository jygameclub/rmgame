using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.RemainingMoves
{
    public class RemainingMovesAssets : ScriptableObject
    {
        // Fields
        protected UnityEngine.MonoBehaviour[] prefabs;
        
        // Methods
        private Royal.Scenes.Game.Ui.Dialogs.RemainingMoves.RemainingMovesParticles GetRemainingMovesParticlesPrefab()
        {
            UnityEngine.MonoBehaviour val_1 = this.prefabs[0];
            if(val_1 == null)
            {
                    return (Royal.Scenes.Game.Ui.Dialogs.RemainingMoves.RemainingMovesParticles)val_1;
            }
            
            return (Royal.Scenes.Game.Ui.Dialogs.RemainingMoves.RemainingMovesParticles)val_1;
        }
        private Royal.Scenes.Game.Ui.Dialogs.RemainingMoves.RemainingMovesHitParticles GetRemainingMovesHitParticlesPrefab()
        {
            UnityEngine.MonoBehaviour val_1 = this.prefabs[1];
            if(val_1 == null)
            {
                    return (Royal.Scenes.Game.Ui.Dialogs.RemainingMoves.RemainingMovesHitParticles)val_1;
            }
            
            return (Royal.Scenes.Game.Ui.Dialogs.RemainingMoves.RemainingMovesHitParticles)val_1;
        }
        private Royal.Scenes.Game.Levels.Units.RemainingMoves.RemainingMovesSingleCoinPilot GetCoinPilotPrefab()
        {
            UnityEngine.MonoBehaviour val_1 = this.prefabs[2];
            if(val_1 == null)
            {
                    return (Royal.Scenes.Game.Levels.Units.RemainingMoves.RemainingMovesSingleCoinPilot)val_1;
            }
            
            return (Royal.Scenes.Game.Levels.Units.RemainingMoves.RemainingMovesSingleCoinPilot)val_1;
        }
        public void CreatePools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool, int amount)
        {
            pool.CreatePool<Royal.Scenes.Game.Ui.Dialogs.RemainingMoves.RemainingMovesParticles>(go:  this.GetRemainingMovesParticlesPrefab(), amount:  amount);
            pool.CreatePool<Royal.Scenes.Game.Ui.Dialogs.RemainingMoves.RemainingMovesHitParticles>(go:  this.GetRemainingMovesHitParticlesPrefab(), amount:  amount);
            pool.CreatePool<Royal.Scenes.Game.Levels.Units.RemainingMoves.RemainingMovesSingleCoinPilot>(go:  this.GetCoinPilotPrefab(), amount:  amount);
        }
        public RemainingMovesAssets()
        {
        
        }
    
    }

}
