using UnityEngine;

namespace Royal.Infrastructure.Services.Notification
{
    public struct GameNotification
    {
        // Fields
        private readonly string <Title>k__BackingField;
        private readonly string <Text>k__BackingField;
        private System.DateTime <FireTime>k__BackingField;
        
        // Properties
        public string Title { get; }
        public string Text { get; }
        public System.DateTime FireTime { get; set; }
        
        // Methods
        public string get_Title()
        {
            return (string)this.<FireTime>k__BackingField;
        }
        public string get_Text()
        {
            return (string)this;
        }
        public System.DateTime get_FireTime()
        {
            return (System.DateTime)this;
        }
        public void set_FireTime(System.DateTime value)
        {
            mem[1152921527558782960] = value.dateData;
        }
        public GameNotification(string text, System.DateTime fireTime, string title)
        {
            this.<FireTime>k__BackingField = title;
            mem[1152921527558903144] = text;
            mem[1152921527558903152] = fireTime.dateData;
        }
        public override string ToString()
        {
            var val_1 = X1;
            mem2[0] = this.<FireTime>k__BackingField.dateData;
            mem2[0] = mem[this.<FireTime>k__BackingField + 8];
            mem2[0] = mem[this.<FireTime>k__BackingField + 16];
            val_1 = mem[this.<FireTime>k__BackingField + 24];
            val_1 = mem[this.<FireTime>k__BackingField + 32];
            return (string)mem[this.<FireTime>k__BackingField + 24];
        }
    
    }

}
