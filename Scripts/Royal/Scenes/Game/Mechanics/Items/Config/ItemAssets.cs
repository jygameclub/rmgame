using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.Config
{
    public abstract class ItemAssets : ScriptableObject
    {
        // Fields
        protected UnityEngine.MonoBehaviour[] prefabs;
        public UnityEngine.Sprite[] sprites;
        public UnityEngine.AudioClip[] audioClips;
        public Royal.Scenes.Game.Mechanics.Goal.GoalAsset[] goalAssets;
        private int createdAmount;
        
        // Methods
        public void CreatePools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool, int amount)
        {
            int val_3 = amount - this.createdAmount;
            if(val_3 < 1)
            {
                    return;
            }
            
            this.createdAmount = amount;
            object[] val_1 = new object[1];
            val_3 = val_3;
            val_1[0] = val_3;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  5, log:  "{0} item added pool.", values:  val_1);
        }
        public void ClearPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool)
        {
            this.createdAmount = 0;
            goto typeof(Royal.Scenes.Game.Mechanics.Items.Config.ItemAssets).__il2cppRuntimeField_180;
        }
        public void ResetCreatedAmount()
        {
            this.createdAmount = 0;
        }
        protected abstract void CreateItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool, int amount); // 0
        protected abstract void ClearItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool); // 0
        protected ItemAssets()
        {
        
        }
    
    }

}
