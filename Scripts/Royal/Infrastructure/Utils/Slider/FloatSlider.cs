using UnityEngine;

namespace Royal.Infrastructure.Utils.Slider
{
    public class FloatSlider : MonoBehaviour, IFloatVariableHolder
    {
        // Fields
        public UnityEngine.UI.Slider slider;
        public Royal.Infrastructure.Utils.Slider.FloatVariable floatVariable;
        private float defaultValue;
        
        // Properties
        public Royal.Infrastructure.Utils.Slider.FloatVariable FloatVariable { get; set; }
        
        // Methods
        public Royal.Infrastructure.Utils.Slider.FloatVariable get_FloatVariable()
        {
            return (Royal.Infrastructure.Utils.Slider.FloatVariable)this.floatVariable;
        }
        public void set_FloatVariable(Royal.Infrastructure.Utils.Slider.FloatVariable value)
        {
            this.floatVariable = value;
        }
        private void Start()
        {
            this.slider.m_OnValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<System.Single>(object:  this, method:  System.Void Royal.Infrastructure.Utils.Slider.FloatSlider::ChangeValue(float value)));
            this.defaultValue = this.floatVariable.value;
            this.floatVariable.add_OnChange(value:  new System.Action<System.Single>(object:  this, method:  System.Void Royal.Infrastructure.Utils.Slider.FloatSlider::UpdateSlider(float value)));
            goto typeof(UnityEngine.UI.Slider).__il2cppRuntimeField_420;
        }
        private void ChangeValue(float value)
        {
            if(this.floatVariable != null)
            {
                    this.floatVariable.SetValue(value:  value);
                return;
            }
            
            throw new NullReferenceException();
        }
        private void UpdateSlider(float value)
        {
            if(this.slider != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
        public FloatSlider()
        {
        
        }
    
    }

}
