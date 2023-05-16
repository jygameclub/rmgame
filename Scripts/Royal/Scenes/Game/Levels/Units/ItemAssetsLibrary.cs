using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units
{
    public class ItemAssetsLibrary
    {
        // Fields
        private readonly System.Collections.Generic.Dictionary<System.Type, Royal.Scenes.Game.Mechanics.Items.Config.ItemAssets> assets;
        
        // Methods
        public ItemAssetsLibrary()
        {
            this.assets = new System.Collections.Generic.Dictionary<System.Type, Royal.Scenes.Game.Mechanics.Items.Config.ItemAssets>(capacity:  50);
        }
        public void ClearAll()
        {
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_2 = this.assets.Values.GetEnumerator();
            label_5:
            if(((-2120616696) & 1) == 0)
            {
                goto label_3;
            }
            
            if(0 == 0)
            {
                    throw new NullReferenceException();
            }
            
            0.ResetCreatedAmount();
            goto label_5;
            label_3:
            0.Dispose();
            this.assets.Clear();
        }
        public bool Clear(System.Type type)
        {
            return this.assets.Remove(key:  type);
        }
        public T Load<T>()
        {
            var val_4;
            System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48});
            if((this.assets.TryGetValue(key:  val_1, value: out  0)) != true)
            {
                    val_1.ResetCreatedAmount();
                this.assets.set_Item(key:  val_1, value:  val_1);
            }
            
            if(val_1 != 0)
            {
                    if(X0 == true)
            {
                    return (Royal.Scenes.Game.Mechanics.Board.Cell.View.CellAssets)val_4;
            }
            
            }
            
            val_4 = 0;
            return (Royal.Scenes.Game.Mechanics.Board.Cell.View.CellAssets)val_4;
        }
        public Royal.Scenes.Game.Mechanics.Goal.GoalAsset GetItemGoalAsset(Royal.Scenes.Game.Mechanics.Goal.GoalType goalType)
        {
            var val_8 = 0;
            if((goalType - 1) > 41)
            {
                    return (Royal.Scenes.Game.Mechanics.Goal.GoalAsset);
            }
            
            var val_8 = 36598180 + ((goalType - 1)) << 2;
            val_8 = val_8 + 36598180;
            goto (36598180 + ((goalType - 1)) << 2 + 36598180);
        }
    
    }

}
