using UnityEngine;

namespace Royal.Infrastructure.UiComponents.Touch.Inputs
{
    public class EditorInputHelper : InputHelper
    {
        // Fields
        public readonly Royal.Infrastructure.Contexts.Units.App.BackButton.BackButtonListener backButtonListener;
        
        // Methods
        public EditorInputHelper()
        {
            this = new System.Object();
            this.backButtonListener = new Royal.Infrastructure.Contexts.Units.App.BackButton.BackButtonListener();
        }
        public override void Bind()
        {
            if(this.backButtonListener != null)
            {
                    this.backButtonListener.Bind();
                return;
            }
            
            throw new NullReferenceException();
        }
        public override void ManualUpdate()
        {
            if(this.backButtonListener != null)
            {
                    this.backButtonListener.ManualUpdate();
                return;
            }
            
            throw new NullReferenceException();
        }
        public override void AddBackable(Royal.Infrastructure.Contexts.Units.App.BackButton.IBackable backable)
        {
            if(this.backButtonListener != null)
            {
                    this.backButtonListener.AddBackable(backable:  backable);
                return;
            }
            
            throw new NullReferenceException();
        }
        public override void RemoveBackable(Royal.Infrastructure.Contexts.Units.App.BackButton.IBackable backable)
        {
            if(this.backButtonListener != null)
            {
                    this.backButtonListener.RemoveBackable(backable:  backable);
                return;
            }
            
            throw new NullReferenceException();
        }
        public override void EnableBackButton()
        {
            if(this.backButtonListener != null)
            {
                    this.backButtonListener.Enable();
                return;
            }
            
            throw new NullReferenceException();
        }
        public override void DisableBackButton()
        {
            if(this.backButtonListener != null)
            {
                    this.backButtonListener.Disable();
                return;
            }
            
            throw new NullReferenceException();
        }
        public override UnityEngine.Vector2 GetTouchPosition()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Input.mousePosition;
            return UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        }
        public override bool GetTouch()
        {
            return true;
        }
        public override bool GetTouchDown()
        {
            return UnityEngine.Input.GetMouseButtonDown(button:  0);
        }
        public override bool GetTouchMove()
        {
            return UnityEngine.Input.GetMouseButton(button:  0);
        }
        public override bool GetTouchUp()
        {
            return UnityEngine.Input.GetMouseButtonUp(button:  0);
        }
    
    }

}
