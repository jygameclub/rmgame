using UnityEngine;

namespace Royal.Infrastructure.Utils.Animation.Tween.Procedure
{
    public abstract class AbstractTweenProcedure<T>
    {
        // Fields
        protected readonly Royal.Infrastructure.Utils.Animation.Tween.MTween<T> mTween;
        
        // Methods
        public AbstractTweenProcedure<T>(Royal.Infrastructure.Utils.Animation.Tween.MTween<T> mTween)
        {
            mem[1152921527496925040] = mTween;
        }
        public abstract void Apply(T startValue, T endValue, float ratio); // 0
    
    }

}
