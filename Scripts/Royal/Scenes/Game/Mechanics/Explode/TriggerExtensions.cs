using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Explode
{
    public static class TriggerExtensions
    {
        // Methods
        public static bool IsBooster(Royal.Scenes.Game.Mechanics.Explode.Trigger trigger)
        {
            return (bool)((trigger - 17) < 3) ? 1 : 0;
        }
    
    }

}
