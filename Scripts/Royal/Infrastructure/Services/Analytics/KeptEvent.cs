using UnityEngine;

namespace Royal.Infrastructure.Services.Analytics
{
    public struct KeptEvent
    {
        // Fields
        public readonly string eventName;
        public readonly Firebase.Analytics.Parameter[] eventParams;
        
        // Methods
        public KeptEvent(string eventName, Firebase.Analytics.Parameter[] eventParams)
        {
            mem[1152921528697687264] = eventName;
            mem[1152921528697687272] = eventParams;
        }
    
    }

}
