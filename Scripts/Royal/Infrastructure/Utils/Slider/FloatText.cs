using UnityEngine;

namespace Royal.Infrastructure.Utils.Slider
{
    public class FloatText : MonoBehaviour, IFloatVariableHolder
    {
        // Fields
        public TMPro.TextMeshProUGUI text;
        public string textFormat;
        public Royal.Infrastructure.Utils.Slider.FloatVariable floatVariable;
        
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
            this.floatVariable.add_OnChange(value:  new System.Action<System.Single>(object:  this, method:  System.Void Royal.Infrastructure.Utils.Slider.FloatText::ChangeValue(float value)));
            this.ChangeValue(value:  this.floatVariable.value);
        }
        private void ChangeValue(float value)
        {
            this.text.text = value.ToString(format:  this.textFormat);
        }
        public FloatText()
        {
            this.textFormat = "N2";
        }
    
    }

}
