using UnityEngine;

namespace Royal.Scenes.Game.Story.WallDrill
{
    public class WallDrillView : MonoBehaviour
    {
        // Fields
        private UnityEngine.Vector3 startPosition;
        private UnityEngine.Vector3 endPosition;
        public float initialDelay;
        public DigitalRuby.LightningBolt.LightningBoltScript lightning;
        public UnityEngine.Animator wallAnimator;
        public UnityEngine.Transform mover;
        private bool shouldPlaySound;
        private static Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        private static long drillMoveSoundKey;
        private long electricSoundKey;
        private float elapsedTime;
        private float totalDuration;
        private bool isGoingForward;
        private float delayPassedTime;
        private Royal.Infrastructure.Utils.Animation.ManualEasing.Easer easing;
        private bool isAnimating;
        private bool isLightningEnabled;
        private float lightningDuration;
        private UnityEngine.AudioClip storyElectricSound;
        private UnityEngine.AudioClip drillMovementSound;
        private UnityEngine.AudioClip drillStopSound;
        
        // Methods
        private void Awake()
        {
            var val_14;
            int val_15;
            var val_16;
            var val_17;
            this.easing = Royal.Infrastructure.Utils.Animation.ManualEasing.GetEase(easeType:  4);
            UnityEngine.Transform val_3 = this.transform.Find(n:  "Mover/Animator/body");
            val_14 = null;
            val_14 = null;
            val_15 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.DefaultLayerId;
            if(val_3 != 0)
            {
                    Royal.Scenes.Game.Mechanics.Sortings.SortingData val_6 = Royal.Infrastructure.Utils.Sprite.SpriteExtensions.GetSorting(renderer:  val_3.GetComponent<UnityEngine.SpriteRenderer>());
                val_15 = val_6.layer;
                var val_8 = (val_6.sortEverything != true) ? 1 : 0;
                val_17 = (val_15 + 21474836480) & (-4294967296);
            }
            else
            {
                    val_16 = 0;
                val_17 = 21474836480000;
            }
            
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.lightning.GetComponent<UnityEngine.LineRenderer>(), data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = 21474836480000 | val_15, order = 21474836480000 | val_15, sortEverything = false});
            this.lightning = 1;
            Royal.Scenes.Start.Context.Units.FeatureBundle.AFeatureBundle val_12 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleManager>(id:  25).GetBundle(bundleType:  3);
            this.storyElectricSound = val_12;
            this.drillMovementSound = val_12;
            this.drillStopSound = val_12;
        }
        public void Init()
        {
            Royal.Scenes.Game.Story.WallDrill.WallDrillView.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
            Royal.Scenes.Game.Story.WallDrill.WallDrillView.drillMoveSoundKey = 0;
            this.electricSoundKey = 0;
            this.isAnimating = false;
            this.mover.localPosition = new UnityEngine.Vector3() {x = this.startPosition};
            this.wallAnimator.speed = 0f;
        }
        public void StartAnimation()
        {
            this.shouldPlaySound = true;
            if((Royal.Scenes.Game.Story.WallDrill.WallDrillView.drillMoveSoundKey & 9223372036854775808) != 0)
            {
                    Royal.Scenes.Game.Story.WallDrill.WallDrillView.drillMoveSoundKey = Royal.Scenes.Game.Story.WallDrill.WallDrillView.audioManager.PlayStoppableSound(audioClip:  this.drillMovementSound, loop:  true, volume:  1f);
            }
            
            this.isAnimating = true;
            this.elapsedTime = 0f;
            this.delayPassedTime = 0f;
            this.isGoingForward = true;
            this.lightningDuration = 0f;
            this.wallAnimator.speed = 1f;
        }
        private void Update()
        {
            float val_10;
            UnityEngine.Vector3 val_12;
            UnityEngine.Vector3 val_13;
            float val_15;
            float val_16;
            float val_17;
            var val_18;
            float val_19;
            float val_20;
            float val_21;
            if(this.isAnimating == false)
            {
                    return;
            }
            
            val_10 = this.delayPassedTime;
            if(val_10 < 0)
            {
                    float val_1 = UnityEngine.Time.deltaTime;
                val_1 = val_10 + val_1;
                this.delayPassedTime = val_1;
                return;
            }
            
            float val_10 = this.elapsedTime;
            float val_2 = UnityEngine.Time.deltaTime;
            val_2 = val_10 + val_2;
            val_10 = val_2 / this.totalDuration;
            this.elapsedTime = val_2;
            if(this.isGoingForward != false)
            {
                    val_12 = this.endPosition;
                val_15 = this.easing.Invoke(t:  val_10);
                val_16 = this.startPosition;
            }
            else
            {
                    val_13 = this.endPosition;
                val_15 = this.easing.Invoke(t:  val_10);
                val_16 = val_13;
            }
            
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_16, y = V13.16B, z = V12.16B}, b:  new UnityEngine.Vector3() {x = this.startPosition, y = V10.16B, z = V9.16B}, t:  val_15);
            this.mover.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            if(val_10 > 1f)
            {
                    bool val_11 = this.isGoingForward;
                this.elapsedTime = 0f;
                val_11 = val_11 ^ 1;
                this.isGoingForward = val_11;
            }
            
            val_10 = this.lightningDuration;
            if(val_10 > 0f)
            {
                goto label_14;
            }
            
            this.isLightningEnabled = this.isLightningEnabled ^ 1;
            if(this.isLightningEnabled != false)
            {
                    val_17 = 2f;
                val_18 = 0;
                val_19 = val_17;
            }
            else
            {
                    if(this.shouldPlaySound == false)
            {
                goto label_21;
            }
            
                val_19 = 1f;
                val_20 = val_19;
                val_17 = 0.5f;
            }
            
            this.electricSoundKey = Royal.Scenes.Game.Story.WallDrill.WallDrillView.audioManager.PlayStoppableSound(audioClip:  this.storyElectricSound, loop:  false, volume:  val_20);
            label_21:
            val_21 = UnityEngine.Random.value * val_17;
            val_10 = val_21 + val_19;
            this.lightningDuration = val_10;
            label_14:
            if(this.isLightningEnabled != false)
            {
                    this.lightning.Trigger();
                val_10 = this.lightningDuration;
            }
            
            float val_9 = UnityEngine.Time.deltaTime;
            val_9 = val_10 - val_9;
            this.lightningDuration = val_9;
        }
        public void StopAllRelatedSound()
        {
            var val_1;
            this.shouldPlaySound = false;
            val_1 = null;
            if(Royal.Scenes.Game.Story.WallDrill.WallDrillView.drillMoveSoundKey >= 1)
            {
                    Royal.Scenes.Game.Story.WallDrill.WallDrillView.audioManager.StopSound(key:  Royal.Scenes.Game.Story.WallDrill.WallDrillView.drillMoveSoundKey);
                val_1 = null;
                Royal.Scenes.Game.Story.WallDrill.WallDrillView.drillMoveSoundKey = 0;
            }
            
            if(this.electricSoundKey < 1)
            {
                    return;
            }
            
            Royal.Scenes.Game.Story.WallDrill.WallDrillView.audioManager.StopSound(key:  this.electricSoundKey);
            this.electricSoundKey = 0;
        }
        public void CutAnimation()
        {
            this.isAnimating = false;
            if(Royal.Scenes.Game.Story.WallDrill.WallDrillView.drillMoveSoundKey >= 1)
            {
                    Royal.Scenes.Game.Story.WallDrill.WallDrillView.audioManager.StopSound(key:  Royal.Scenes.Game.Story.WallDrill.WallDrillView.drillMoveSoundKey);
                Royal.Scenes.Game.Story.WallDrill.WallDrillView.drillMoveSoundKey = 0;
            }
            
            this.wallAnimator.speed = 0f;
        }
        public void StopAnimation()
        {
            this.isAnimating = false;
            if(Royal.Scenes.Game.Story.WallDrill.WallDrillView.drillMoveSoundKey >= 1)
            {
                    Royal.Scenes.Game.Story.WallDrill.WallDrillView.audioManager.StopSound(key:  Royal.Scenes.Game.Story.WallDrill.WallDrillView.drillMoveSoundKey);
                Royal.Scenes.Game.Story.WallDrill.WallDrillView.drillMoveSoundKey = 0;
                Royal.Scenes.Game.Story.WallDrill.WallDrillView.audioManager.PlayAudioClip(audioClip:  this.drillStopSound);
            }
            
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.startPosition, y = V12.16B, z = V11.16B}, b:  new UnityEngine.Vector3() {x = this.endPosition, y = V10.16B, z = V8.16B}, t:  0.9f);
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_3 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.mover, endValue:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, duration:  1.5f, snapping:  false), ease:  3);
            DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_7 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<System.Single>(object:  this, method:  System.Single Royal.Scenes.Game.Story.WallDrill.WallDrillView::<StopAnimation>b__27_0()), setter:  new DG.Tweening.Core.DOSetter<System.Single>(object:  this, method:  System.Void Royal.Scenes.Game.Story.WallDrill.WallDrillView::<StopAnimation>b__27_1(float newSpeed)), endValue:  0f, duration:  1.5f), ease:  3);
        }
        public WallDrillView()
        {
            this.startPosition = 0;
            mem[1152921519975857840] = 0;
            this.totalDuration = 0.85f;
            this.endPosition = 0;
            mem[1152921519975857852] = 0;
            this.isGoingForward = true;
        }
        private float <StopAnimation>b__27_0()
        {
            if(this.wallAnimator != null)
            {
                    return this.wallAnimator.speed;
            }
            
            throw new NullReferenceException();
        }
        private void <StopAnimation>b__27_1(float newSpeed)
        {
            if(this.wallAnimator != null)
            {
                    this.wallAnimator.speed = newSpeed;
                return;
            }
            
            throw new NullReferenceException();
        }
    
    }

}
