using UnityEngine;

namespace DG.Tweening
{
    public class DOTweenAnimation : ABSAnimationComponent
    {
        // Fields
        private static System.Action<DG.Tweening.DOTweenAnimation> OnReset;
        public bool targetIsSelf;
        public UnityEngine.GameObject targetGO;
        public bool tweenTargetIsTargetGO;
        public float delay;
        public float duration;
        public DG.Tweening.Ease easeType;
        public UnityEngine.AnimationCurve easeCurve;
        public DG.Tweening.LoopType loopType;
        public int loops;
        public string id;
        public bool isRelative;
        public bool isFrom;
        public bool isIndependentUpdate;
        public bool autoKill;
        public bool isActive;
        public bool isValid;
        public UnityEngine.Component target;
        public DG.Tweening.DOTweenAnimation.AnimationType animationType;
        public DG.Tweening.DOTweenAnimation.TargetType targetType;
        public DG.Tweening.DOTweenAnimation.TargetType forcedTargetType;
        public bool autoPlay;
        public bool useTargetAsV3;
        public float endValueFloat;
        public UnityEngine.Vector3 endValueV3;
        public UnityEngine.Vector2 endValueV2;
        public UnityEngine.Color endValueColor;
        public string endValueString;
        public UnityEngine.Rect endValueRect;
        public UnityEngine.Transform endValueTransform;
        public bool optionalBool0;
        public float optionalFloat0;
        public int optionalInt0;
        public DG.Tweening.RotateMode optionalRotationMode;
        public DG.Tweening.ScrambleMode optionalScrambleMode;
        public string optionalString;
        private bool _tweenCreated;
        private int _playCount;
        
        // Methods
        public static void add_OnReset(System.Action<DG.Tweening.DOTweenAnimation> value)
        {
            if((System.Delegate.Combine(a:  DG.Tweening.DOTweenAnimation.OnReset, b:  value)) == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
        
        }
        public static void remove_OnReset(System.Action<DG.Tweening.DOTweenAnimation> value)
        {
            if((System.Delegate.Remove(source:  DG.Tweening.DOTweenAnimation.OnReset, value:  value)) == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
        
        }
        private static void Dispatch_OnReset(DG.Tweening.DOTweenAnimation anim)
        {
            if(DG.Tweening.DOTweenAnimation.OnReset == null)
            {
                    return;
            }
            
            DG.Tweening.DOTweenAnimation.OnReset.Invoke(obj:  anim);
        }
        private void Awake()
        {
            if(this.isActive == false)
            {
                    return;
            }
            
            if(this.isValid == false)
            {
                    return;
            }
            
            if(this.animationType == 1)
            {
                    if(this.useTargetAsV3 == true)
            {
                    return;
            }
            
            }
            
            this.CreateTween();
            this._tweenCreated = true;
        }
        private void Start()
        {
            if(this._tweenCreated == true)
            {
                    return;
            }
            
            if(this.isActive == false)
            {
                    return;
            }
            
            if(this.isValid == false)
            {
                    return;
            }
            
            this.CreateTween();
            this._tweenCreated = true;
        }
        private void Reset()
        {
            DG.Tweening.DOTweenAnimation.Dispatch_OnReset(anim:  this);
        }
        private void OnDestroy()
        {
            if(this != null)
            {
                    bool val_1 = DG.Tweening.TweenExtensions.IsActive(t:  this);
                if(val_1 != false)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  val_1, complete:  false);
            }
            
            }
            
            mem[1152921528865508720] = 0;
        }
        public void CreateTween()
        {
            UnityEngine.GameObject val_92;
            UnityEngine.Component val_93;
            string val_95;
            bool val_99;
            UnityEngine.GameObject val_111;
            if(this.targetIsSelf != false)
            {
                    val_92 = this.gameObject;
            }
            else
            {
                    val_92 = this.targetGO;
            }
            
            val_93 = this.target;
            if(val_93 != 0)
            {
                    if(val_92 != 0)
            {
                goto label_8;
            }
            
            }
            
            if((this.targetIsSelf != false) && (this.target == 0))
            {
                    string val_6 = this.gameObject.name;
                val_95 = "{0} :: This DOTweenAnimation\'s target is NULL, because the animation was created with a DOTween Pro version older than 0.9.255. To fix this, exit Play mode then simply select this object, and it will update automatically";
            }
            else
            {
                    val_95 = "{0} :: This DOTweenAnimation\'s target/GameObject is unset: the tween will not be created.";
            }
            
            UnityEngine.Debug.LogWarning(message:  System.String.Format(format:  val_95, arg0:  this.gameObject.name), context:  this.gameObject);
            return;
            label_8:
            if(this.forcedTargetType == 0)
            {
                goto label_18;
            }
            
            label_33:
            this.targetType = this.forcedTargetType;
            goto label_19;
            label_18:
            if(this.targetType == 0)
            {
                goto label_20;
            }
            
            label_19:
            AnimationType val_92 = this.animationType;
            val_92 = val_92 - 1;
            if(val_92 > 19)
            {
                goto label_102;
            }
            
            var val_93 = 36599392 + ((this.animationType - 1)) << 2;
            val_93 = val_93 + 36599392;
            goto (36599392 + ((this.animationType - 1)) << 2 + 36599392);
            label_20:
            TargetType val_18 = DG.Tweening.DOTweenAnimation.TypeToDOTargetType(t:  this.target.GetType());
            goto label_33;
            label_102:
            if( == null)
            {
                    return;
            }
            
            val_99 = this.isRelative;
            if(this.isFrom != false)
            {
                    DG.Tweening.Tweener val_62 = DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  null, isRelative:  (val_99 == true) ? 1 : 0);
            }
            
            if(this.targetIsSelf == false)
            {
                goto label_137;
            }
            
            label_139:
            val_111 = this.gameObject;
            goto label_138;
            label_137:
            if(this.tweenTargetIsTargetGO == false)
            {
                goto label_139;
            }
            
            val_111 = this.targetGO;
            label_138:
            DG.Tweening.Tween val_69 = DG.Tweening.TweenSettingsExtensions.SetAutoKill<DG.Tweening.Tween>(t:  DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tween>(t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Tween>(t:  DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tween>(t:  DG.Tweening.TweenSettingsExtensions.SetRelative<DG.Tweening.Tween>(t:  null, isRelative:  (val_99 == true) ? 1 : 0), target:  val_111), delay:  this.delay), loops:  this.loops, loopType:  this.loopType), autoKillOnCompletion:  this.autoKill);
            DG.Tweening.TweenCallback val_70 = null;
            val_93 = val_70;
            val_70 = new DG.Tweening.TweenCallback(object:  this, method:  System.Void DG.Tweening.DOTweenAnimation::<CreateTween>b__47_0());
            if((public static DG.Tweening.Tween DG.Tweening.TweenSettingsExtensions::OnKill<DG.Tweening.Tween>(DG.Tweening.Tween t, DG.Tweening.TweenCallback action)) != 0)
            {
                    DG.Tweening.Tween val_72 = DG.Tweening.TweenSettingsExtensions.SetSpeedBased<DG.Tweening.Tween>(t:  DG.Tweening.TweenSettingsExtensions.OnKill<DG.Tweening.Tween>(t:  val_69, action:  val_70));
            }
            
            if(this.easeType == 37)
            {
                    DG.Tweening.Tween val_73 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tween>(t:  val_72, animCurve:  this.easeCurve);
            }
            else
            {
                    DG.Tweening.Tween val_74 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tween>(t:  val_72, ease:  this.easeType);
            }
            
            DG.Tweening.Tween val_77 = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tween>(t:  DG.Tweening.TweenSettingsExtensions.SetId<DG.Tweening.Tween>(t:  System.String.IsNullOrEmpty(value:  this.id), stringId:  this.id), isIndependentUpdate:  this.isIndependentUpdate);
            if((public static DG.Tweening.Tween DG.Tweening.TweenSettingsExtensions::SetUpdate<DG.Tweening.Tween>(DG.Tweening.Tween t, bool isIndependentUpdate)) == 0)
            {
                goto label_144;
            }
            
            if(val_69 == null)
            {
                goto label_146;
            }
            
            DG.Tweening.Tween val_79 = DG.Tweening.TweenSettingsExtensions.OnStart<DG.Tweening.Tween>(t:  val_70, action:  new DG.Tweening.TweenCallback(object:  val_69, method:  public System.Void UnityEngine.Events.UnityEvent::Invoke()));
            goto label_146;
            label_144:
            mem[1152921528866139816] = 0;
            label_146:
            if((public static DG.Tweening.Tween DG.Tweening.TweenSettingsExtensions::SetUpdate<DG.Tweening.Tween>(DG.Tweening.Tween t, bool isIndependentUpdate)) == 0)
            {
                goto label_147;
            }
            
            if(val_69 == null)
            {
                goto label_149;
            }
            
            DG.Tweening.Tween val_81 = DG.Tweening.TweenSettingsExtensions.OnPlay<DG.Tweening.Tween>(t:  val_70, action:  new DG.Tweening.TweenCallback(object:  val_69, method:  public System.Void UnityEngine.Events.UnityEvent::Invoke()));
            goto label_149;
            label_147:
            mem[1152921528866139824] = 0;
            label_149:
            if((public static DG.Tweening.Tween DG.Tweening.TweenSettingsExtensions::SetUpdate<DG.Tweening.Tween>(DG.Tweening.Tween t, bool isIndependentUpdate)) == 0)
            {
                goto label_150;
            }
            
            if(val_69 == null)
            {
                goto label_152;
            }
            
            DG.Tweening.Tween val_83 = DG.Tweening.TweenSettingsExtensions.OnUpdate<DG.Tweening.Tween>(t:  val_70, action:  new DG.Tweening.TweenCallback(object:  val_69, method:  public System.Void UnityEngine.Events.UnityEvent::Invoke()));
            goto label_152;
            label_150:
            mem[1152921528866139832] = 0;
            label_152:
            if((public static DG.Tweening.Tween DG.Tweening.TweenSettingsExtensions::SetUpdate<DG.Tweening.Tween>(DG.Tweening.Tween t, bool isIndependentUpdate)) == 0)
            {
                goto label_153;
            }
            
            if(val_69 == null)
            {
                goto label_155;
            }
            
            DG.Tweening.Tween val_85 = DG.Tweening.TweenSettingsExtensions.OnStepComplete<DG.Tweening.Tween>(t:  val_70, action:  new DG.Tweening.TweenCallback(object:  val_69, method:  public System.Void UnityEngine.Events.UnityEvent::Invoke()));
            goto label_155;
            label_153:
            mem[1152921528866139840] = 0;
            label_155:
            if((public static DG.Tweening.Tween DG.Tweening.TweenSettingsExtensions::SetUpdate<DG.Tweening.Tween>(DG.Tweening.Tween t, bool isIndependentUpdate)) == 0)
            {
                goto label_156;
            }
            
            if(val_69 == null)
            {
                goto label_158;
            }
            
            DG.Tweening.Tween val_87 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tween>(t:  val_70, action:  new DG.Tweening.TweenCallback(object:  val_69, method:  public System.Void UnityEngine.Events.UnityEvent::Invoke()));
            goto label_158;
            label_156:
            mem[1152921528866139848] = 0;
            label_158:
            if((public static DG.Tweening.Tween DG.Tweening.TweenSettingsExtensions::SetUpdate<DG.Tweening.Tween>(DG.Tweening.Tween t, bool isIndependentUpdate)) == 0)
            {
                goto label_159;
            }
            
            if(val_69 == null)
            {
                goto label_161;
            }
            
            DG.Tweening.Tween val_89 = DG.Tweening.TweenSettingsExtensions.OnRewind<DG.Tweening.Tween>(t:  val_70, action:  new DG.Tweening.TweenCallback(object:  val_69, method:  public System.Void UnityEngine.Events.UnityEvent::Invoke()));
            goto label_161;
            label_159:
            mem[1152921528866139864] = 0;
            label_161:
            if(this.autoPlay != false)
            {
                    DG.Tweening.Tween val_90 = DG.Tweening.TweenExtensions.Play<DG.Tweening.Tween>(t:  val_77);
            }
            else
            {
                    DG.Tweening.Tween val_91 = DG.Tweening.TweenExtensions.Pause<DG.Tweening.Tween>(t:  val_77);
            }
            
            if((public static DG.Tweening.Tween DG.Tweening.TweenExtensions::Pause<DG.Tweening.Tween>(DG.Tweening.Tween t)) == 0)
            {
                    return;
            }
            
            if(val_91 == null)
            {
                    return;
            }
            
            val_91.Invoke();
        }
        public override void DOPlay()
        {
            int val_2 = DG.Tweening.DOTween.Play(targetOrId:  this.gameObject);
        }
        public override void DOPlayBackwards()
        {
            int val_2 = DG.Tweening.DOTween.PlayBackwards(targetOrId:  this.gameObject);
        }
        public override void DOPlayForward()
        {
            int val_2 = DG.Tweening.DOTween.PlayForward(targetOrId:  this.gameObject);
        }
        public override void DOPause()
        {
            int val_2 = DG.Tweening.DOTween.Pause(targetOrId:  this.gameObject);
        }
        public override void DOTogglePause()
        {
            int val_2 = DG.Tweening.DOTween.TogglePause(targetOrId:  this.gameObject);
        }
        public override void DORewind()
        {
            this._playCount = 0;
            int val_3 = val_2.Length - 1;
            if(<0)
            {
                    return;
            }
            
            do
            {
                if((DG.Tweening.TweenExtensions.IsInitialized(t:  T[].__il2cppRuntimeField_generic_class)) != false)
            {
                    DG.Tweening.TweenExtensions.Rewind(t:  T[].__il2cppRuntimeField_generic_class, includeDelay:  true);
            }
            
                val_3 = val_3 - 1;
                if(val_3 < 0)
            {
                    return;
            }
            
                this.gameObject.GetComponents<DG.Tweening.DOTweenAnimation>()[val_3][32] = (this.gameObject.GetComponents<DG.Tweening.DOTweenAnimation>()[val_3][32]) - 8;
            }
            while(val_3 < val_2.Length);
            
            throw new IndexOutOfRangeException();
        }
        public override void DORestart()
        {
            goto typeof(DG.Tweening.DOTweenAnimation).__il2cppRuntimeField_1E0;
        }
        public override void DORestart(bool fromHere)
        {
            this._playCount = 0;
            if(true != 0)
            {
                    if((fromHere != false) && (this.isRelative != false))
            {
                    this.ReEvaluateRelativeTween();
            }
            
                int val_2 = DG.Tweening.DOTween.Restart(targetOrId:  this.gameObject, includeDelay:  true, changeDelayTo:  -1f);
                return;
            }
            
            if(DG.Tweening.Core.Debugger._LogPrefix < 2)
            {
                    return;
            }
            
            DG.Tweening.Core.Debugger.LogNullTween(t:  11089);
        }
        public override void DOComplete()
        {
            int val_2 = DG.Tweening.DOTween.Complete(targetOrId:  this.gameObject, withCallbacks:  false);
        }
        public override void DOKill()
        {
            int val_2 = DG.Tweening.DOTween.Kill(targetOrId:  this.gameObject, complete:  false);
            mem[1152921528867903968] = 0;
        }
        public void DOPlayById(string id)
        {
            int val_2 = DG.Tweening.DOTween.Play(target:  this.gameObject, id:  id);
        }
        public void DOPlayAllById(string id)
        {
            int val_1 = DG.Tweening.DOTween.Play(targetOrId:  id);
        }
        public void DOPauseAllById(string id)
        {
            int val_1 = DG.Tweening.DOTween.Pause(targetOrId:  id);
        }
        public void DOPlayBackwardsById(string id)
        {
            int val_2 = DG.Tweening.DOTween.PlayBackwards(target:  this.gameObject, id:  id);
        }
        public void DOPlayBackwardsAllById(string id)
        {
            int val_1 = DG.Tweening.DOTween.PlayBackwards(targetOrId:  id);
        }
        public void DOPlayForwardById(string id)
        {
            int val_2 = DG.Tweening.DOTween.PlayForward(target:  this.gameObject, id:  id);
        }
        public void DOPlayForwardAllById(string id)
        {
            int val_1 = DG.Tweening.DOTween.PlayForward(targetOrId:  id);
        }
        public void DOPlayNext()
        {
            int val_6 = val_1.Length;
            int val_7 = this._playCount;
            val_6 = val_6 - 1;
            if(val_7 >= val_6)
            {
                    return;
            }
            
            do
            {
                val_7 = val_7 + 1;
                this._playCount = val_7;
                if(((this.GetComponents<DG.Tweening.DOTweenAnimation>()[val_7]) != 0) && ((val_1[(this._playCount + 1)][0] + 96) != 0))
            {
                    if((DG.Tweening.TweenExtensions.IsPlaying(t:  val_1[(this._playCount + 1)][0] + 96)) != true)
            {
                    if((DG.Tweening.TweenExtensions.IsComplete(t:  val_1[(this._playCount + 1)][0] + 96)) == false)
            {
                goto label_10;
            }
            
            }
            
            }
            
                int val_9 = val_1.Length;
                val_9 = val_9 - 1;
            }
            while(this._playCount < val_9);
            
            return;
            label_10:
            DG.Tweening.Tween val_5 = DG.Tweening.TweenExtensions.Play<DG.Tweening.Tween>(t:  val_1[(this._playCount + 1)][0] + 96);
        }
        public void DORewindAndPlayNext()
        {
            this._playCount = 0;
            int val_2 = DG.Tweening.DOTween.Rewind(targetOrId:  this.gameObject, includeDelay:  true);
            this.DOPlayNext();
        }
        public void DORewindAllById(string id)
        {
            this._playCount = 0;
            int val_1 = DG.Tweening.DOTween.Rewind(targetOrId:  id, includeDelay:  true);
        }
        public void DORestartById(string id)
        {
            this._playCount = 0;
            int val_2 = DG.Tweening.DOTween.Restart(target:  this.gameObject, id:  id, includeDelay:  true, changeDelayTo:  -1f);
        }
        public void DORestartAllById(string id)
        {
            this._playCount = 0;
            int val_1 = DG.Tweening.DOTween.Restart(targetOrId:  id, includeDelay:  true, changeDelayTo:  -1f);
        }
        public System.Collections.Generic.List<DG.Tweening.Tween> GetTweens()
        {
            System.Collections.Generic.List<DG.Tweening.Tween> val_1 = new System.Collections.Generic.List<DG.Tweening.Tween>();
            if(val_2.Length < 1)
            {
                    return val_1;
            }
            
            var val_4 = 0;
            do
            {
                T val_3 = this.GetComponents<DG.Tweening.DOTweenAnimation>()[val_4];
                val_1.Add(item:  val_2[0x0][0] + 96);
                val_4 = val_4 + 1;
            }
            while(val_4 < val_2.Length);
            
            return val_1;
        }
        public static DG.Tweening.DOTweenAnimation.TargetType TypeToDOTargetType(System.Type t)
        {
            System.Type val_8 = t;
            string val_8 = ".";
            int val_1 = t.LastIndexOf(value:  val_8);
            if(val_1 != 1)
            {
                    val_8 = val_1 + 1;
                val_8 = val_8.Substring(startIndex:  val_8);
            }
            
            System.Enum.Parse(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  ((System.String.op_Inequality(a:  val_8, b:  "SpriteRenderer")) != true) ? "Renderer" : (val_8)).System.IDisposable.Dispose();
            return (TargetType)null;
        }
        public DG.Tweening.Tween CreateEditorPreview()
        {
            var val_2 = 0;
            if(UnityEngine.Application.isPlaying == true)
            {
                    return (DG.Tweening.Tween)this;
            }
            
            this.CreateTween();
            return (DG.Tweening.Tween)this;
        }
        private UnityEngine.GameObject GetTweenGO()
        {
            if(this.targetIsSelf == false)
            {
                    return (UnityEngine.GameObject)this.targetGO;
            }
            
            return this.gameObject;
        }
        private void ReEvaluateRelativeTween()
        {
            UnityEngine.GameObject val_13;
            if(this.targetIsSelf != false)
            {
                    val_13 = this.gameObject;
            }
            else
            {
                    val_13 = this.targetGO;
            }
            
            if(val_13 == 0)
            {
                    UnityEngine.Debug.LogWarning(message:  System.String.Format(format:  "{0} :: This DOTweenAnimation\'s target/GameObject is unset: the tween will not be created.", arg0:  this.gameObject.name), context:  this.gameObject);
                return;
            }
            
            if(this.animationType != 2)
            {
                    if(this.animationType != 1)
            {
                    return;
            }
            
                UnityEngine.Vector3 val_8 = val_13.transform.position;
            }
            else
            {
                    UnityEngine.Vector3 val_10 = val_13.transform.localPosition;
            }
            
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = this.endValueV3, y = V11.16B, z = V10.16B});
        }
        public DOTweenAnimation()
        {
            this.targetIsSelf = true;
            this.tweenTargetIsTargetGO = true;
            this.duration = 1f;
            this.easeType = 6;
            UnityEngine.Keyframe[] val_1 = new UnityEngine.Keyframe[2];
            val_1[0] = 0;
            val_1[0] = 0;
            val_1[1] = 0;
            val_1[1] = 0;
            this.easeCurve = new UnityEngine.AnimationCurve(keys:  val_1);
            this.loops = 1;
            this.autoKill = true;
            this.isActive = true;
            this.autoPlay = 1;
            this.id = "";
            this.endValueColor = 0;
            this.endValueString = "";
            this.endValueRect = 0;
            this._playCount = 0;
        }
        private void <CreateTween>b__47_0()
        {
            mem[1152921528870465248] = 0;
        }
    
    }

}
