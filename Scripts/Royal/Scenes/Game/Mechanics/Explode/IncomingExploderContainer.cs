using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Explode
{
    public class IncomingExploderContainer
    {
        // Fields
        private readonly System.Collections.Generic.HashSet<int> incomingExploders;
        
        // Methods
        public int GetIncomingCount()
        {
            return 19700;
        }
        public void AddToIncoming(int id)
        {
            bool val_1 = this.incomingExploders.Add(item:  id);
        }
        public void RemoveFromIncoming(int id)
        {
            bool val_1 = this.incomingExploders.Remove(item:  id);
        }
        public IncomingExploderContainer()
        {
            this.incomingExploders = new System.Collections.Generic.HashSet<System.Int32>();
        }
    
    }

}
