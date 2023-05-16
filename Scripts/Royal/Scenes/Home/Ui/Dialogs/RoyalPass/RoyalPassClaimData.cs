using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass
{
    public struct RoyalPassClaimData
    {
        // Fields
        public readonly int step;
        public readonly bool isFree;
        
        // Methods
        public RoyalPassClaimData(int step, bool isFree)
        {
            mem[1152921519257102864] = step;
            mem[1152921519257102868] = isFree;
        }
    
    }

}
