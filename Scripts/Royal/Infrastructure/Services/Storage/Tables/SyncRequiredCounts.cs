using UnityEngine;

namespace Royal.Infrastructure.Services.Storage.Tables
{
    public struct SyncRequiredCounts
    {
        // Fields
        private int <Basic>k__BackingField;
        private int <Inventory>k__BackingField;
        private int <Area>k__BackingField;
        private int <Log>k__BackingField;
        
        // Properties
        public int Basic { get; set; }
        public int Inventory { get; set; }
        public int Area { get; set; }
        public int Log { get; set; }
        
        // Methods
        public int get_Basic()
        {
            return (int)this;
        }
        public void set_Basic(int value)
        {
            mem[1152921527549573984] = value;
        }
        public int get_Inventory()
        {
            return (int)this;
        }
        public void set_Inventory(int value)
        {
            mem[1152921527549797988] = value;
        }
        public int get_Area()
        {
            return (int)this;
        }
        public void set_Area(int value)
        {
            mem[1152921527550021992] = value;
        }
        public int get_Log()
        {
            return (int)this;
        }
        public void set_Log(int value)
        {
            mem[1152921527550245996] = value;
        }
        public int TotalCount()
        {
            return (int)S0;
        }
    
    }

}
