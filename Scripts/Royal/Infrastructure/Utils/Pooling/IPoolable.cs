using UnityEngine;

namespace Royal.Infrastructure.Utils.Pooling
{
    public interface IPoolable
    {
        // Methods
        public abstract int GetPoolId(); // 0
        public abstract void OnSpawn(); // 0
        public abstract void OnRecycle(); // 0
    
    }

}
