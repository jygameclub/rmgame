using UnityEngine;

namespace Royal.Infrastructure.Services.Storage.Tables
{
    public struct KeyValue
    {
        // Fields
        private string <Key>k__BackingField;
        private string <Value>k__BackingField;
        private int <Synced>k__BackingField;
        
        // Properties
        public string Key { get; set; }
        public string Value { get; set; }
        public int Synced { get; set; }
        
        // Methods
        public string get_Key()
        {
            return (string)this.<Synced>k__BackingField;
        }
        public void set_Key(string value)
        {
            this.<Synced>k__BackingField = value;
        }
        public string get_Value()
        {
            return (string)this;
        }
        public void set_Value(string value)
        {
            mem[1152921527539773496] = value;
        }
        public int get_Synced()
        {
            return (int)this;
        }
        public void set_Synced(int value)
        {
            mem[1152921527540001600] = value;
        }
    
    }

}
