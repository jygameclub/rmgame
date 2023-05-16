using UnityEngine;

namespace Royal.Scenes.Start.Context.Units.Flow
{
    public abstract class FlowAction
    {
        // Fields
        public const int Last = 0;
        public const int First = 1;
        public const int Interrupt = 2;
        public const int Auto = 3;
        private System.Action OnComplete;
        
        // Properties
        public virtual int Type { get; }
        public virtual bool IsForClaim { get; }
        
        // Methods
        public virtual int get_Type()
        {
            return 0;
        }
        public virtual bool get_IsForClaim()
        {
            return false;
        }
        public void add_OnComplete(System.Action value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnComplete, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnComplete != 1152921518910650528);
            
            return;
            label_2:
        }
        public void remove_OnComplete(System.Action value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnComplete, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnComplete != 1152921518910787104);
            
            return;
            label_2:
        }
        public abstract void Execute(); // 0
        public abstract void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction); // 0
        public virtual void Complete()
        {
            if(this.OnComplete == null)
            {
                    return;
            }
            
            this.OnComplete.Invoke();
        }
        public virtual void Replace(Royal.Scenes.Start.Context.Units.Flow.FlowAction newAction)
        {
        
        }
        public virtual bool SupportsMultiple()
        {
            return false;
        }
        public virtual bool SupportsOneExceptRunning()
        {
            return false;
        }
        protected FlowAction()
        {
        
        }
    
    }

}
