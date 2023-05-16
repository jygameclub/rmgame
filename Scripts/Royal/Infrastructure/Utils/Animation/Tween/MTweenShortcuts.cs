using UnityEngine;

namespace Royal.Infrastructure.Utils.Animation.Tween
{
    public static class MTweenShortcuts
    {
        // Methods
        public static Royal.Infrastructure.Utils.Animation.Tween.MTween<UnityEngine.Vector3> MtLocalMove(UnityEngine.Transform transform, UnityEngine.Vector3 endPosition, float duration)
        {
            Royal.Infrastructure.Utils.Animation.Tween.MTween<UnityEngine.Vector3> val_1 = new Royal.Infrastructure.Utils.Animation.Tween.MTween<UnityEngine.Vector3>();
            mem[1152921527495917680] = transform;
            UnityEngine.Vector3 val_2 = transform.localPosition;
            mem[1152921527495917716] = val_2.x;
            mem[1152921527495917720] = val_2.y;
            mem[1152921527495917724] = val_2.z;
            mem[1152921527495917728] = endPosition.x;
            mem[1152921527495917732] = endPosition.y;
            mem[1152921527495917736] = endPosition.z;
            mem[1152921527495917704] = duration;
            mem[1152921527495917696] = new Royal.Infrastructure.Utils.Animation.Tween.Procedure.LocalPositionProcedure(mTween:  val_1);
            return val_1;
        }
        public static Royal.Infrastructure.Utils.Animation.Tween.MTween<UnityEngine.Vector3> MtMove(UnityEngine.Transform transform, UnityEngine.Vector3 endPosition, float duration)
        {
            Royal.Infrastructure.Utils.Animation.Tween.MTween<UnityEngine.Vector3> val_1 = new Royal.Infrastructure.Utils.Animation.Tween.MTween<UnityEngine.Vector3>();
            mem[1152921527496054256] = transform;
            UnityEngine.Vector3 val_2 = transform.position;
            mem[1152921527496054292] = val_2.x;
            mem[1152921527496054296] = val_2.y;
            mem[1152921527496054300] = val_2.z;
            mem[1152921527496054304] = endPosition.x;
            mem[1152921527496054308] = endPosition.y;
            mem[1152921527496054312] = endPosition.z;
            mem[1152921527496054280] = duration;
            mem[1152921527496054272] = new Royal.Infrastructure.Utils.Animation.Tween.Procedure.PositionProcedure(mTween:  val_1);
            return val_1;
        }
        public static Royal.Infrastructure.Utils.Animation.Tween.MTween<UnityEngine.Vector3> MtLocalScale(UnityEngine.Transform transform, UnityEngine.Vector3 endScale, float duration)
        {
            Royal.Infrastructure.Utils.Animation.Tween.MTween<UnityEngine.Vector3> val_1 = new Royal.Infrastructure.Utils.Animation.Tween.MTween<UnityEngine.Vector3>();
            mem[1152921527496190832] = transform;
            UnityEngine.Vector3 val_2 = transform.localScale;
            mem[1152921527496190868] = val_2.x;
            mem[1152921527496190872] = val_2.y;
            mem[1152921527496190876] = val_2.z;
            mem[1152921527496190880] = endScale.x;
            mem[1152921527496190884] = endScale.y;
            mem[1152921527496190888] = endScale.z;
            mem[1152921527496190856] = duration;
            mem[1152921527496190848] = new Royal.Infrastructure.Utils.Animation.Tween.Procedure.LocalScaleProcedure(mTween:  val_1);
            return val_1;
        }
        public static Royal.Infrastructure.Utils.Animation.Tween.MTween<T> SetEase<T>(Royal.Infrastructure.Utils.Animation.Tween.MTween<T> tween, DG.Tweening.Ease easeType)
        {
            if(tween != null)
            {
                    mem2[0] = easeType;
                return (Royal.Infrastructure.Utils.Animation.Tween.MTween<T>)tween;
            }
            
            throw new NullReferenceException();
        }
        public static Royal.Infrastructure.Utils.Animation.Tween.MTween<T> SetEase<T>(Royal.Infrastructure.Utils.Animation.Tween.MTween<T> tween, UnityEngine.AnimationCurve animCurve)
        {
            tween = 37;
            tween = new DG.Tweening.EaseFunction(object:  new DG.Tweening.Core.Easing.EaseCurve(animCurve:  animCurve), method:  public System.Single DG.Tweening.Core.Easing.EaseCurve::Evaluate(float time, float duration, float unusedOvershoot, float unusedPeriod));
            return (Royal.Infrastructure.Utils.Animation.Tween.MTween<T>)tween;
        }
        public static Royal.Infrastructure.Utils.Animation.Tween.MTween<T> SetOnComplete<T>(Royal.Infrastructure.Utils.Animation.Tween.MTween<T> tween, System.Action onComplete)
        {
            if(tween != null)
            {
                    mem2[0] = onComplete;
                return (Royal.Infrastructure.Utils.Animation.Tween.MTween<T>)tween;
            }
            
            throw new NullReferenceException();
        }
        public static Royal.Infrastructure.Utils.Animation.Tween.MTween<T> SetEaseOvershoot<T>(Royal.Infrastructure.Utils.Animation.Tween.MTween<T> tween, float easeOverShoot)
        {
            if(tween != null)
            {
                    mem2[0] = easeOverShoot;
                return (Royal.Infrastructure.Utils.Animation.Tween.MTween<T>)tween;
            }
            
            throw new NullReferenceException();
        }
        public static Royal.Infrastructure.Utils.Animation.Tween.MTween<T> SetEasePeriod<T>(Royal.Infrastructure.Utils.Animation.Tween.MTween<T> tween, float easePeriod)
        {
            if(tween != null)
            {
                    mem2[0] = easePeriod;
                return (Royal.Infrastructure.Utils.Animation.Tween.MTween<T>)tween;
            }
            
            throw new NullReferenceException();
        }
    
    }

}
