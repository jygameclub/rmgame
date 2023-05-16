using UnityEngine;

namespace Royal.Infrastructure.Contexts
{
    public interface IContextUnit
    {
        // Properties
        public abstract int Id { get; }
        
        // Methods
        public abstract int get_Id(); // 0
        public abstract void Bind(); // 0
    
    }

}
