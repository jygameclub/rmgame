using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Sortings
{
    public struct SortingData
    {
        // Fields
        public readonly int layer;
        public readonly int order;
        public readonly bool sortEverything;
        
        // Methods
        public SortingData(int layer, int order, bool sortEverything = False)
        {
            mem[1152921519985443952] = layer;
            mem[1152921519985443956] = order;
            mem[1152921519985443960] = sortEverything;
        }
        public bool IsAboveOther(Royal.Scenes.Game.Mechanics.Sortings.SortingData other)
        {
            if(W8 > other.layer)
            {
                    return true;
            }
            
            if(W8 != other.layer)
            {
                    return false;
            }
            
            return (bool)(W8 > (other.layer >> 32)) ? 1 : 0;
        }
    
    }

}
