using UnityEngine;

namespace Royal.Infrastructure.UiComponents.Scroll
{
    public interface IScrollable : IDraggable, ITouchable
    {
        // Properties
        public abstract Royal.Infrastructure.UiComponents.Scroll.Direction ScrollDirection { get; }
        
        // Methods
        public abstract Royal.Infrastructure.UiComponents.Scroll.Direction get_ScrollDirection(); // 0
    
    }

}
