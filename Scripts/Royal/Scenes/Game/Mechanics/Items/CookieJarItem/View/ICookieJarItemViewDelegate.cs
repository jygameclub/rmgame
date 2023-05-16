using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View
{
    public interface ICookieJarItemViewDelegate : IItemViewDelegate
    {
        // Methods
        public abstract void OnGoalReached(); // 0
        public abstract void FinalizeExplode(float freezeDuration = 0.15); // 0
    
    }

}
