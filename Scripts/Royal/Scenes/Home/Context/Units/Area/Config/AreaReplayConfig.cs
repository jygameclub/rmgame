using UnityEngine;

namespace Royal.Scenes.Home.Context.Units.Area.Config
{
    [Serializable]
    public class AreaReplayConfig
    {
        // Fields
        public int order;
        public float blending;
        public bool hasAudio;
        
        // Methods
        public AreaReplayConfig(int order, float blending, bool hasAudio)
        {
            this.order = order;
            this.blending = blending;
            this.hasAudio = hasAudio;
        }
    
    }

}
