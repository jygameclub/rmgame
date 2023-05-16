using UnityEngine;

namespace Royal.Scenes.Game.Story
{
    public class KingDrillRedFrame : MonoBehaviour
    {
        // Fields
        public UnityEngine.SpriteRenderer redFrame;
        public DG.Tweening.Sequence redSequence;
        private Royal.Infrastructure.Contexts.Units.CameraManager camManager;
        private Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        private float speedModifier;
        private float elapsedDelay;
        private float minDelay;
        private System.Action onComplete;
        private UnityEngine.AudioClip redWarningClip;
        
        // Methods
        private void Awake()
        {
            this.redWarningClip = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleManager>(id:  25).GetBundle(bundleType:  3);
        }
        public void Init()
        {
            this.redFrame.gameObject.SetActive(value:  true);
            this.redFrame.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
            this.camManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            UnityEngine.Vector2 val_5 = this.camManager.GetPositionVector2();
            UnityEngine.Vector3 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y});
            this.transform.position = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            this.minDelay = -1f;
            this.onComplete = 0;
            this.speedModifier = 1f;
            this.elapsedDelay = 0f;
        }
        public void Animate(float modifier = 1)
        {
            this.speedModifier = modifier;
            if(this.redSequence != null)
            {
                    this.redSequence = modifier;
            }
            
            this.redSequence = DG.Tweening.DOTween.Sequence();
            this.audioManager.PlayAudioClip(audioClip:  this.redWarningClip);
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.redSequence, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.redFrame, endValue:  0.8f, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  30f)), ease:  1));
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.redSequence, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.redFrame, endValue:  0f, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  15f)), ease:  2));
            this.redSequence = this.speedModifier;
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  this.redSequence, action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Game.Story.KingDrillRedFrame::<Animate>b__11_0()));
        }
        public void Update()
        {
            if(this.redSequence == null)
            {
                    return;
            }
            
            UnityEngine.Color val_1 = this.redFrame.color;
            float val_2 = val_1.a + (-0.4f);
            float val_6 = System.Math.Abs(val_2);
            float val_7 = val_6;
            float val_8 = (float)System.Math.Sign(value:  val_2);
            val_7 = val_7 * val_8;
            val_7 = val_7 / (-5f);
            val_6 = val_7 + 1f;
            val_7 = this.camManager.cameraWidth / val_6;
            val_8 = this.camManager.cameraHeight / val_6;
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  val_7, y:  val_8);
            this.redFrame.size = new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
            this = this.redFrame.transform;
            this.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        public void EndAfterLoop(System.Action onComplete, float minDelay = 0)
        {
            if(this.redSequence == null)
            {
                    return;
            }
            
            if((DG.Tweening.TweenExtensions.IsPlaying(t:  this.redSequence)) == false)
            {
                    return;
            }
            
            this.onComplete = onComplete;
            float val_3 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  40f);
            float val_4 = 1f;
            val_4 = val_4 - (DG.Tweening.TweenExtensions.ElapsedDirectionalPercentage(t:  this.redSequence));
            val_3 = val_4 * val_3;
            val_3 = val_3 / this.speedModifier;
            val_3 = 0.01f - val_3;
            this.elapsedDelay = val_3;
            this.minDelay = minDelay;
        }
        public void SetSpeedModifier(float modifier)
        {
            this.speedModifier = modifier;
            if(this.redSequence == null)
            {
                    return;
            }
            
            this.redSequence = modifier;
        }
        public void Hide()
        {
            if(this.redSequence == null)
            {
                    return;
            }
            
            if((DG.Tweening.TweenExtensions.IsPlaying(t:  this.redSequence)) == false)
            {
                    return;
            }
            
            DG.Tweening.TweenExtensions.Kill(t:  this.redSequence, complete:  false);
        }
        public KingDrillRedFrame()
        {
            this.speedModifier = 1f;
            this.minDelay = -1f;
        }
        private void <Animate>b__11_0()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            this.redSequence = val_1;
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Game.Story.KingDrillRedFrame::<Animate>b__11_1()));
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.redSequence, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.redFrame, endValue:  0.8f, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  20f)), ease:  3));
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.redSequence, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.redFrame, endValue:  0f, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  20f)), ease:  2));
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Sequence>(t:  this.redSequence, loops:  0);
            this.redSequence = this.speedModifier;
        }
        private void <Animate>b__11_1()
        {
            if(this.minDelay < 0f)
            {
                goto label_1;
            }
            
            float val_1 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  40f);
            val_1 = val_1 / this.speedModifier;
            val_1 = this.elapsedDelay + val_1;
            this.elapsedDelay = val_1;
            if(val_1 >= this.minDelay)
            {
                goto label_4;
            }
            
            label_1:
            this.audioManager.PlayAudioClip(audioClip:  this.redWarningClip);
            return;
            label_4:
            if(this.onComplete != null)
            {
                    this.onComplete.Invoke();
            }
            
            DG.Tweening.TweenExtensions.Kill(t:  this.redSequence, complete:  false);
            this.redSequence = 0;
            this.onComplete = 0;
        }
    
    }

}
