using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.MatchItem.View
{
    public interface IMatchItemViewDelegate : IItemViewDelegate
    {
        // Methods
        public abstract void CollectAnimationCompleted(Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemView itemView); // 0
        public abstract void ManagerCollectCompleted(Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemView itemView, Royal.Scenes.Game.Mechanics.Items.MatchItem.Collect.ICollectManager collectManager, bool hitFromLeft); // 0
    
    }

}
