using UnityEngine;

namespace Royal.Infrastructure.UiComponents.Touch
{
    public interface ITouchable
    {
        // Properties
        public abstract Royal.Infrastructure.UiComponents.Touch.ZIndex ZIndex { get; set; }
        
        // Methods
        public abstract Royal.Infrastructure.UiComponents.Touch.ZIndex get_ZIndex(); // 0
        public abstract void set_ZIndex(Royal.Infrastructure.UiComponents.Touch.ZIndex value); // 0
        public abstract void TouchDown(UnityEngine.Vector2 position); // 0
        public abstract void TouchMove(UnityEngine.Vector2 position); // 0
        public abstract void TouchUp(UnityEngine.Vector2 position); // 0
        public abstract void CancelTouch(bool isTouchDisabled = False); // 0
    
    }

}
