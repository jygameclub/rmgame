using UnityEngine;

namespace Royal.Infrastructure.Utils.Slider
{
    public class FloatButton : MonoBehaviour, IFloatVariableHolder
    {
        // Fields
        public UnityEngine.UI.Button button;
        public Royal.Infrastructure.Utils.Slider.FloatVariable floatVariable;
        public float incrementValue;
        public float maxValue;
        
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
            this.button.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void Royal.Infrastructure.Utils.Slider.FloatButton::ChangeValue()));
        }
        private void ChangeValue()
        {
            this.floatVariable.SetValue(value:  UnityEngine.Mathf.Clamp(value:  this.floatVariable.value + this.incrementValue, min:  0f, max:  this.maxValue));
        }
        public FloatButton()
        {
            this.maxValue = 1f;
        }
    
    }

}
