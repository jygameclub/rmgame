using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Explode
{
    public class ExploderContainer
    {
        // Fields
        public readonly System.Collections.Generic.HashSet<int> exploders;
        
        // Methods
        public void AddToExploders(int id)
        {
            bool val_1 = this.exploders.Add(item:  id);
        }
        public bool ContainsExploder(int id)
        {
            return this.exploders.Contains(item:  id);
        }
        public bool RemoveExploder(int id)
        {
            return this.exploders.Remove(item:  id);
        }
        public ExploderContainer()
        {
            this.exploders = new System.Collections.Generic.HashSet<System.Int32>();
        }
    
    }

}
