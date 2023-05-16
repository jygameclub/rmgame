using UnityEngine;

namespace Coffee.UIExtensions
{
    public interface IParameterTexture
    {
        // Properties
        public abstract int parameterIndex { get; set; }
        public abstract Coffee.UIExtensions.ParameterTexture ptex { get; }
        
        // Methods
        public abstract int get_parameterIndex(); // 0
        public abstract void set_parameterIndex(int value); // 0
        public abstract Coffee.UIExtensions.ParameterTexture get_ptex(); // 0
    
    }

}
