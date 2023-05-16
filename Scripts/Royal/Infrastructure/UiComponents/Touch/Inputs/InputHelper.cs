using UnityEngine;

namespace Royal.Infrastructure.UiComponents.Touch.Inputs
{
    public abstract class InputHelper
    {
        // Methods
        public virtual void Bind()
        {
        
        }
        public virtual void ManualUpdate()
        {
        
        }
        public abstract UnityEngine.Vector2 GetTouchPosition(); // 0
        public abstract bool GetTouch(); // 0
        public abstract bool GetTouchDown(); // 0
        public abstract bool GetTouchMove(); // 0
        public abstract bool GetTouchUp(); // 0
        public virtual void AddBackable(Royal.Infrastructure.Contexts.Units.App.BackButton.IBackable backable)
        {
        
        }
        public virtual void RemoveBackable(Royal.Infrastructure.Contexts.Units.App.BackButton.IBackable backable)
        {
        
        }
        public virtual void EnableBackButton()
        {
        
        }
        public virtual void DisableBackButton()
        {
        
        }
        protected InputHelper()
        {
        
        }
    
    }

}
