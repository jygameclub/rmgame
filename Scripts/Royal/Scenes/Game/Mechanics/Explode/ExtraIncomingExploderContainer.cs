using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Explode
{
    public class ExtraIncomingExploderContainer
    {
        // Fields
        private readonly System.Collections.Generic.HashSet<int> incomingExploders;
        private int tntPropellerCount;
        private int horizontalRocketPropeller;
        private int verticalRocketPropeller;
        
        // Methods
        public int GetTntPropellerCount()
        {
            return (int)this.tntPropellerCount;
        }
        public int GetHorizontalRocketPropellerCount()
        {
            return (int)this.horizontalRocketPropeller;
        }
        public int GetVerticalRocketPropellerCount()
        {
            return (int)this.verticalRocketPropeller;
        }
        public void AddToIncoming(int id, Royal.Scenes.Game.Mechanics.Explode.Trigger trigger)
        {
            if((this.incomingExploders.Add(item:  id)) == false)
            {
                    return;
            }
            
            if(trigger != 10)
            {
                    if(trigger != 11)
            {
                    if(trigger != 13)
            {
                    return;
            }
            
                int val_2 = this.tntPropellerCount;
                val_2 = val_2 + 1;
                this.tntPropellerCount = val_2;
                return;
            }
            
                int val_3 = this.horizontalRocketPropeller;
                val_3 = val_3 + 1;
                this.horizontalRocketPropeller = val_3;
                return;
            }
            
            int val_4 = this.verticalRocketPropeller;
            val_4 = val_4 + 1;
            this.verticalRocketPropeller = val_4;
        }
        public void RemoveFromIncoming(int id, Royal.Scenes.Game.Mechanics.Explode.Trigger trigger)
        {
            if((this.incomingExploders.Remove(item:  id)) == false)
            {
                    return;
            }
            
            if(trigger != 10)
            {
                    if(trigger != 11)
            {
                    if(trigger != 13)
            {
                    return;
            }
            
                int val_2 = this.tntPropellerCount;
                val_2 = val_2 - 1;
                this.tntPropellerCount = val_2;
                return;
            }
            
                int val_3 = this.horizontalRocketPropeller;
                val_3 = val_3 - 1;
                this.horizontalRocketPropeller = val_3;
                return;
            }
            
            int val_4 = this.verticalRocketPropeller;
            val_4 = val_4 - 1;
            this.verticalRocketPropeller = val_4;
        }
        public ExtraIncomingExploderContainer()
        {
            this.incomingExploders = new System.Collections.Generic.HashSet<System.Int32>();
        }
    
    }

}
