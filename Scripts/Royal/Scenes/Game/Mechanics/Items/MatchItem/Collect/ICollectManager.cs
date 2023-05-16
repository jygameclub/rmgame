using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.MatchItem.Collect
{
    public interface ICollectManager
    {
        // Methods
        public abstract UnityEngine.Vector3 GetCollectPosition(); // 0
        public abstract void DecrementTarget(); // 0
        public abstract void ItemReached(bool hitFromLeft); // 0
        public abstract Royal.Scenes.Start.Context.Units.Audio.AudioClipType GetCollectAudioClipType(); // 0
    
    }

}
