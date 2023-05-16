using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View
{
    public interface ITntFuseParticles
    {
        // Properties
        public abstract UnityEngine.Transform Transform { get; }
        
        // Methods
        public abstract void Play(); // 0
        public abstract void Stop(); // 0
        public abstract void Recycle(); // 0
        public abstract UnityEngine.Transform get_Transform(); // 0
        public abstract void UpdateSorting(Royal.Scenes.Game.Mechanics.Sortings.SortingData sortingData); // 0
    
    }

}
