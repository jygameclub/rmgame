using UnityEngine;

namespace Royal.Scenes.Game.Utils.LevelParser
{
    public class LevelSetElement
    {
        // Fields
        public readonly Royal.Scenes.Game.Utils.LevelParser.TiledId id;
        public readonly int createRatio;
        public bool isAvailableForFill;
        
        // Properties
        public bool IsBird { get; }
        public bool IsFrog { get; }
        
        // Methods
        public bool get_IsBird()
        {
            return (bool)(this.id == 35) ? 1 : 0;
        }
        public bool get_IsFrog()
        {
            return (bool)(this.id == 125) ? 1 : 0;
        }
        public LevelSetElement(Royal.Scenes.Game.Utils.LevelParser.TiledId id, int createRatio)
        {
            this.id = id;
            this.createRatio = createRatio;
        }
    
    }

}
