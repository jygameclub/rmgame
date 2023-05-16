using UnityEngine;

namespace Royal.Infrastructure.Services.Storage.Tables
{
    public struct Inbox
    {
        // Fields
        private long <Id>k__BackingField;
        private long <AskId>k__BackingField;
        private long <HelpId>k__BackingField;
        private string <HelpName>k__BackingField;
        private bool <Used>k__BackingField;
        
        // Properties
        public long Id { get; set; }
        public long AskId { get; set; }
        public long HelpId { get; set; }
        public string HelpName { get; set; }
        public bool Used { get; set; }
        
        // Methods
        public long get_Id()
        {
            return (long)this.<HelpId>k__BackingField;
        }
        public void set_Id(long value)
        {
            this.<HelpId>k__BackingField = value;
        }
        public long get_AskId()
        {
            return (long)this.<HelpName>k__BackingField;
        }
        public void set_AskId(long value)
        {
            this.<HelpName>k__BackingField = value;
        }
        public long get_HelpId()
        {
            return (long)this.<Used>k__BackingField;
        }
        public void set_HelpId(long value)
        {
            this.<Used>k__BackingField = value;
        }
        public string get_HelpName()
        {
            return (string)this;
        }
        public void set_HelpName(string value)
        {
            mem[1152921527547100536] = value;
        }
        public bool get_Used()
        {
            return (bool)this;
        }
        public void set_Used(bool value)
        {
            mem[1152921527547328640] = value;
        }
    
    }

}
