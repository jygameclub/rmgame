using UnityEngine;

namespace Royal.Infrastructure.Utils.Counters
{
    public class EnableCounter
    {
        // Fields
        private int counter;
        
        // Methods
        public bool IsEnabled()
        {
            return (bool)(this.counter == 0) ? 1 : 0;
        }
        public void Enable()
        {
            int val_1 = this.counter;
            if(val_1 == 0)
            {
                    return;
            }
            
            val_1 = val_1 - 1;
            this.counter = val_1;
        }
        public void Disable()
        {
            int val_1 = this.counter;
            val_1 = val_1 + 1;
            this.counter = val_1;
        }
        public void Reset()
        {
            this.counter = 0;
        }
        public EnableCounter()
        {
        
        }
    
    }

}
