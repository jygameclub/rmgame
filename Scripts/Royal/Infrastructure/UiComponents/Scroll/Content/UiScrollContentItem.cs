using UnityEngine;

namespace Royal.Infrastructure.UiComponents.Scroll.Content
{
    public abstract class UiScrollContentItem : MonoBehaviour
    {
        // Fields
        public bool hidden;
        
        // Methods
        public abstract void Prepare(Royal.Infrastructure.UiComponents.Scroll.Content.IUiScrollContentData data, UnityEngine.Bounds maskBounds); // 0
        public virtual void UpdateSorting(Royal.Scenes.Game.Mechanics.Sortings.SortingData sorting)
        {
        
        }
        protected UiScrollContentItem()
        {
        
        }
    
    }

}
