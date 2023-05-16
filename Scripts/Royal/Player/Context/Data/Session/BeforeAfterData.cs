using UnityEngine;

namespace Royal.Player.Context.Data.Session
{
    public class BeforeAfterData
    {
        // Fields
        public bool shouldConsume;
        public int before;
        public int after;
        
        // Methods
        public void Init(int start)
        {
            this.shouldConsume = false;
            this.before = start;
            this.after = start;
        }
        public void Update(int diff)
        {
            if(this.shouldConsume == false)
            {
                    return;
            }
            
            int val_1 = this.before;
            val_1 = V1.2S + val_1;
            this.before = val_1;
        }
        public void Add(int add)
        {
            int val_1 = this.before;
            this.shouldConsume = true;
            val_1 = val_1 + add;
            this.after = val_1;
        }
        public void AddExtra(int add)
        {
            int val_1 = this.after;
            this.shouldConsume = true;
            val_1 = val_1 + add;
            this.after = val_1;
        }
        public void Consume()
        {
            this.shouldConsume = false;
        }
        public int GetCollectedAmount()
        {
            return (int)this.after - this.before;
        }
        public BeforeAfterData()
        {
        
        }
    
    }

}
