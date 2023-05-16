using UnityEngine;

namespace Royal.Infrastructure.Utils.Animation.Tween.Procedure
{
    public class PositionProcedure : AbstractTweenProcedure<UnityEngine.Vector3>
    {
        // Methods
        public PositionProcedure(Royal.Infrastructure.Utils.Animation.Tween.MTween<UnityEngine.Vector3> mTween)
        {
        
        }
        public override void Apply(UnityEngine.Vector3 startValue, UnityEngine.Vector3 endValue, float ratio)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.LerpUnclamped(a:  new UnityEngine.Vector3() {x = startValue.x, y = startValue.y, z = startValue.z}, b:  new UnityEngine.Vector3() {x = endValue.x, y = endValue.y, z = endValue.z}, t:  ratio);
            16824064.position = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
        }
    
    }

}
