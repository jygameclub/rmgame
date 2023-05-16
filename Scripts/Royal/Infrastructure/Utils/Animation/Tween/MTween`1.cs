using UnityEngine;

namespace Royal.Infrastructure.Utils.Animation.Tween
{
    public class MTween<T>
    {
        // Fields
        public UnityEngine.Transform target;
        public DG.Tweening.Ease easeType;
        public Royal.Infrastructure.Utils.Animation.Tween.Procedure.AbstractTweenProcedure<T> procedure;
        public float duration;
        public float easeOverShoot;
        public float easePeriod;
        public T startValue;
        public T endValue;
        public System.Action onComplete;
        public DG.Tweening.EaseFunction customEase;
        private float time;
        
        // Methods
        private float GetEasedTime()
        {
            return DG.Tweening.Core.Easing.EaseManager.Evaluate(easeType:  W8, customEase:  __RuntimeMethodHiddenParam, time:  null, duration:  null, overshootOrAmplitude:  null, period:  null);
        }
        private void ApplyTween()
        {
            goto X21 + 368;
        }
        public void Start()
        {
            null = null;
            UnityEngine.Coroutine val_1 = Royal.Infrastructure.Utils.Animation.Tween.MTweenPlayer.Instance.StartCoroutine(routine:  this);
        }
        private System.Collections.IEnumerator Play()
        {
            var val_1 = __RuntimeMethodHiddenParam + 24 + 192 + 24;
            val_1 = this;
            return (System.Collections.IEnumerator)val_1;
        }
        private static float GetDeltaTime()
        {
            if((Royal.Scenes.Game.Levels.LevelContext.<IsActive>k__BackingField) == false)
            {
                    return UnityEngine.Time.deltaTime;
            }
            
            return Royal.Scenes.Game.Levels.LevelContext.DeltaTime;
        }
        public MTween<T>()
        {
            mem[1152921527494833676] = 1071238496;
            if(this != null)
            {
                    return;
            }
            
            throw new NullReferenceException();
        }
    
    }

}
