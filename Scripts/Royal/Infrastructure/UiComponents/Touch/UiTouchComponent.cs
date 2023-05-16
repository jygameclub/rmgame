using UnityEngine;

namespace Royal.Infrastructure.UiComponents.Touch
{
    public abstract class UiTouchComponent : MonoBehaviour, ITouchable
    {
        // Fields
        public Royal.Infrastructure.UiComponents.Touch.ZIndex zIndex;
        
        // Properties
        public virtual Royal.Infrastructure.UiComponents.Touch.ZIndex ZIndex { get; set; }
        
        // Methods
        public virtual Royal.Infrastructure.UiComponents.Touch.ZIndex get_ZIndex()
        {
            return (Royal.Infrastructure.UiComponents.Touch.ZIndex)this.zIndex;
        }
        public virtual void set_ZIndex(Royal.Infrastructure.UiComponents.Touch.ZIndex value)
        {
            this.zIndex = value;
        }
        public abstract void TouchDown(UnityEngine.Vector2 position); // 0
        public abstract void TouchMove(UnityEngine.Vector2 position); // 0
        public abstract void TouchUp(UnityEngine.Vector2 position); // 0
        public abstract void CancelTouch(bool isTouchDisabled); // 0
        protected virtual void Reset()
        {
            if(UnityEngine.Application.isEditor == false)
            {
                    return;
            }
            
            if(UnityEngine.Application.isPlaying != false)
            {
                    return;
            }
            
            this.gameObject.tag = "Touchable";
            this.gameObject.layer = UnityEngine.LayerMask.NameToLayer(layerName:  "UI");
        }
        protected UiTouchComponent()
        {
        
        }
    
    }

}
