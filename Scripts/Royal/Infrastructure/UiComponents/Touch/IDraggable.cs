using UnityEngine;

namespace Royal.Infrastructure.UiComponents.Touch
{
    public interface IDraggable : ITouchable
    {
        // Properties
        public abstract bool IsDragging { get; }
        
        // Methods
        public abstract bool get_IsDragging(); // 0
    
    }

}
