using UnityEngine;

namespace Royal.Scenes.Start.Context.Units
{
    public class TweenManager : IContextBehaviour, IContextUnit
    {
        // Properties
        public int Id { get; }
        
        // Methods
        public int get_Id()
        {
            return 6;
        }
        public void Bind()
        {
        
        }
        public TweenManager()
        {
            this.InitializeDoTween();
            this.InitializeSpine();
            Royal.Infrastructure.Utils.Animation.QuadraticBezierPool.InitPool();
            Royal.Infrastructure.Utils.Animation.CubicBezierPool.InitPool();
        }
        private void InitializeDoTween()
        {
            var val_3;
            System.Func<UnityEngine.LogType, System.Object, System.Boolean> val_5;
            var val_6;
            DG.Tweening.IDOTweenInit val_1 = DG.Tweening.DOTween.Init(recycleAllByDefault:  new System.Nullable<System.Boolean>() {HasValue = false}, useSafeMode:  new System.Nullable<System.Boolean>() {HasValue = false}, logBehaviour:  new System.Nullable<DG.Tweening.LogBehaviour>() {HasValue = false});
            DG.Tweening.DOTween.SetTweensCapacity(tweenersCapacity:  184, sequencesCapacity:  200);
            DG.Tweening.DOTween.defaultUpdateType = 3;
            DG.Tweening.DOTween.useSafeMode = true;
            DG.Tweening.DOTween.logBehaviour = 0;
            val_3 = null;
            val_3 = null;
            val_5 = TweenManager.<>c.<>9__4_0;
            if(val_5 == null)
            {
                    System.Func<UnityEngine.LogType, System.Object, System.Boolean> val_2 = null;
                val_5 = val_2;
                val_2 = new System.Func<UnityEngine.LogType, System.Object, System.Boolean>(object:  TweenManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean TweenManager.<>c::<InitializeDoTween>b__4_0(UnityEngine.LogType type, object o));
                TweenManager.<>c.<>9__4_0 = val_5;
            }
            
            val_6 = null;
            val_6 = null;
            DG.Tweening.DOTween.onWillLog = val_5;
        }
        private void InitializeSpine()
        {
            float val_1 = Spine.MathUtils.Sin(radians:  1f);
        }
        private float GetDeltaTime()
        {
            if((Royal.Scenes.Game.Levels.LevelContext.<IsActive>k__BackingField) == false)
            {
                    return UnityEngine.Time.deltaTime;
            }
            
            return Royal.Scenes.Game.Levels.LevelContext.DeltaTime;
        }
        public void ManualUpdate()
        {
            float val_1 = this.GetDeltaTime();
            DG.Tweening.DOTween.ManualUpdate(deltaTime:  val_1, unscaledDeltaTime:  val_1);
        }
    
    }

}
