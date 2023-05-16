using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.ItemCreation
{
    public class ItemModelQueue
    {
        // Fields
        private readonly System.Collections.Generic.Queue<Royal.Scenes.Game.Mechanics.Items.Config.ItemModel> stack;
        
        // Methods
        public ItemModelQueue()
        {
            this.stack = new System.Collections.Generic.Queue<Royal.Scenes.Game.Mechanics.Items.Config.ItemModel>();
        }
        public void Enqueue(Royal.Scenes.Game.Mechanics.Items.Config.ItemModel id)
        {
            this.stack.Enqueue(item:  id);
        }
        public Royal.Scenes.Game.Mechanics.Items.Config.ItemModel Dequeue()
        {
            var val_3;
            if(this.IsEmpty() == false)
            {
                    return (Royal.Scenes.Game.Mechanics.Items.Config.ItemModel)this.stack.Dequeue();
            }
            
            val_3 = 0;
            return (Royal.Scenes.Game.Mechanics.Items.Config.ItemModel)this.stack.Dequeue();
        }
        public bool IsEmpty()
        {
            return (bool)(this.stack == 0) ? 1 : 0;
        }
        public void Clear()
        {
            this.stack.Clear();
        }
    
    }

}
