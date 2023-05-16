using UnityEngine;

namespace Royal.Infrastructure.UiComponents.Touch.Inputs
{
    public class AndroidInputHelper : MobileInputHelper
    {
        // Fields
        public readonly Royal.Infrastructure.Contexts.Units.App.BackButton.BackButtonListener backButtonListener;
        
        // Methods
        public AndroidInputHelper()
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
    
    }

}
