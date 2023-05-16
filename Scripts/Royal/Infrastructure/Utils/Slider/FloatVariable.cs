using UnityEngine;

namespace Royal.Infrastructure.Utils.Slider
{
    public class FloatVariable : ScriptableObject
    {
        // Fields
        private float value;
        private System.Action<float> OnChange;
        
        // Properties
        public float Value { get; }
        
        // Methods
        public float get_Value()
        {
            return (float)this.value;
        }
        public void add_OnChange(System.Action<float> value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnChange, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnChange != 1152921527463416544);
            
            return;
            label_2:
        }
        public void remove_OnChange(System.Action<float> value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnChange, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnChange != 1152921527463553120);
            
            return;
            label_2:
        }
        public void SetValue(float value)
        {
            this.value = value;
            if(this.OnChange == null)
            {
                    return;
            }
            
            this.OnChange.Invoke(obj:  value);
        }
        public FloatVariable()
        {
        
        }
    
    }

}
