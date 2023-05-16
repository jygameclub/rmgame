using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.ItemCreation
{
    public class PredefinedItemContainer
    {
        // Fields
        private readonly Royal.Scenes.Game.Levels.Units.ItemCreation.ItemModelQueue[] allQueues;
        public readonly System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Items.Config.ItemType, int> initialItemCounts;
        
        // Methods
        public PredefinedItemContainer()
        {
            var val_4;
            this.allQueues = new Royal.Scenes.Game.Levels.Units.ItemCreation.ItemModelQueue[9];
            this.initialItemCounts = new System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Items.Config.ItemType, System.Int32>();
            val_4 = 0;
            do
            {
                if(val_4 >= this.allQueues.Length)
            {
                    return;
            }
            
                this.allQueues[val_4] = new Royal.Scenes.Game.Levels.Units.ItemCreation.ItemModelQueue();
                val_4 = val_4 + 1;
            }
            while(this.allQueues != null);
            
            throw new NullReferenceException();
        }
        public void Clear()
        {
            var val_2 = 0;
            label_5:
            if(val_2 >= this.allQueues.Length)
            {
                goto label_2;
            }
            
            this.allQueues[val_2].Clear();
            val_2 = val_2 + 1;
            if(this.allQueues != null)
            {
                goto label_5;
            }
            
            throw new NullReferenceException();
            label_2:
            this.initialItemCounts.Clear();
        }
        public void AddPredefinedItem(Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint cellPoint, Royal.Scenes.Game.Mechanics.Items.Config.ItemModel model)
        {
            this.allQueues[(cellPoint.x << 32) >> 29].Enqueue(id:  model);
            bool val_3 = this.initialItemCounts.TryGetValue(key:  model, value: out  0);
            this.initialItemCounts.set_Item(key:  model, value:  1);
        }
        public Royal.Scenes.Game.Mechanics.Items.Config.ItemModel GetPredefinedItem(Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint cellPoint)
        {
            return this.allQueues[(cellPoint.x << 32) >> 29].Dequeue();
        }
    
    }

}
