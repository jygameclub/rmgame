using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.LightBulbItem.View
{
    public interface ILightBulbItemViewDelegate : IItemViewDelegate
    {
        // Methods
        public abstract Royal.Scenes.Game.Mechanics.Matches.MatchType ChangeColor(); // 0
        public abstract Royal.Scenes.Game.Mechanics.Matches.MatchType GetColor(); // 0
    
    }

}
