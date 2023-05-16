using UnityEngine;

namespace Royal.Infrastructure.Services.Remote
{
    [Serializable]
    public class RLevel
    {
        // Fields
        public int levelNo;
        public string filePath;
        public int maxAppVersion;
        public int minAppVersion;
        
        // Methods
        public RLevel()
        {
        
        }
    
    }

}
