using UnityEngine;

namespace Royal.Infrastructure.Utils.Slider
{
    public interface IFloatVariableHolder
    {
        // Properties
        public abstract Royal.Infrastructure.Utils.Slider.FloatVariable FloatVariable { get; set; }
        
        // Methods
        public abstract Royal.Infrastructure.Utils.Slider.FloatVariable get_FloatVariable(); // 0
        public abstract void set_FloatVariable(Royal.Infrastructure.Utils.Slider.FloatVariable value); // 0
    
    }

}
