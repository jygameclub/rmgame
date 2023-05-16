using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area06.Tasks.Pool
{
    public class Area06PoolView : AreaTaskView
    {
        // Fields
        private static readonly int Area06PoolRevealAnimation;
        private static readonly int DistortionUvWaveX1;
        private static readonly int DistortionUvWaveY1;
        private static readonly int DistortionUvDistanceX1;
        private static readonly int DistortionUvDistanceY1;
        private static readonly int DistortionUvSpeed1;
        private static readonly int EffectFade;
        public float distortionWaveX;
        public float distortionWaveY;
        public float distortionDistanceY;
        public float distortionSpeed;
        public float distortionFade;
        public UnityEngine.SpriteRenderer distortWater;
        private UnityEngine.Animator poolAnimator;
        public UnityEngine.SpriteMask[] poolMasks;
        public UnityEngine.SpriteRenderer[] poolMaskSprites;
        public UnityEngine.SpriteRenderer poolGround;
        
        // Methods
        protected override void Awake()
        {
            this.poolAnimator = this.GetComponent<UnityEngine.Animator>();
            this.UpdateDistortionValues();
            this.EnableMasks(enable:  false);
            this.poolGround.gameObject.SetActive(value:  false);
        }
        public override void PrepareAnimation()
        {
            this.PlayFinalParticles();
            this.EnableMasks(enable:  true);
            this.poolAnimator.gameObject.SetActive(value:  false);
            this.poolGround.gameObject.SetActive(value:  true);
        }
        public override DG.Tweening.Sequence PlayAnimation()
        {
            this.PlayDefaultAnimationSound();
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area06.Tasks.Pool.Area06PoolView::<PlayAnimation>b__19_0()));
            return val_1;
        }
        public override void EndAnimation()
        {
            this.EnableMasks(enable:  false);
            this.poolGround.gameObject.SetActive(value:  false);
        }
        private void Update()
        {
            if(this.poolAnimator.enabled == false)
            {
                    return;
            }
            
            this.UpdateDistortionValues();
        }
        private void UpdateDistortionValues()
        {
            UnityEngine.Material val_1 = this.distortWater.material;
            val_1.SetFloat(nameID:  Royal.Scenes.Home.Areas.Area06.Tasks.Pool.Area06PoolView.DistortionUvWaveX1, value:  this.distortionWaveX);
            val_1.SetFloat(nameID:  Royal.Scenes.Home.Areas.Area06.Tasks.Pool.Area06PoolView.DistortionUvWaveY1, value:  this.distortionWaveY);
            val_1.SetFloat(nameID:  Royal.Scenes.Home.Areas.Area06.Tasks.Pool.Area06PoolView.DistortionUvDistanceX1, value:  0f);
            val_1.SetFloat(nameID:  Royal.Scenes.Home.Areas.Area06.Tasks.Pool.Area06PoolView.DistortionUvDistanceY1, value:  this.distortionDistanceY);
            val_1.SetFloat(nameID:  Royal.Scenes.Home.Areas.Area06.Tasks.Pool.Area06PoolView.DistortionUvSpeed1, value:  this.distortionSpeed);
            val_1.SetFloat(nameID:  Royal.Scenes.Home.Areas.Area06.Tasks.Pool.Area06PoolView.EffectFade, value:  this.distortionFade);
        }
        private void EnableMasks(bool enable)
        {
            var val_4;
            var val_5 = 0;
            label_4:
            if(val_5 >= this.poolMaskSprites.Length)
            {
                goto label_1;
            }
            
            this.poolMaskSprites[val_5].maskInteraction = enable;
            val_5 = val_5 + 1;
            if(this.poolMaskSprites != null)
            {
                goto label_4;
            }
            
            label_1:
            val_4 = 0;
            do
            {
                if(val_4 >= this.poolMasks.Length)
            {
                    return;
            }
            
                this.poolMasks[val_4].gameObject.SetActive(value:  enable);
                val_4 = val_4 + 1;
            }
            while(this.poolMasks != null);
            
            throw new NullReferenceException();
        }
        public Area06PoolView()
        {
            this.distortionWaveX = ;
            this.distortionWaveY = ;
            this.distortionDistanceY = 0.15f;
            this.distortionSpeed = 0.6f;
            this.distortionFade = 0.05f;
            val_1 = new UnityEngine.MonoBehaviour();
        }
        private static Area06PoolView()
        {
            Royal.Scenes.Home.Areas.Area06.Tasks.Pool.Area06PoolView.Area06PoolRevealAnimation = UnityEngine.Animator.StringToHash(name:  "Base Layer.Area06PoolAppearAnimation");
            Royal.Scenes.Home.Areas.Area06.Tasks.Pool.Area06PoolView.DistortionUvWaveX1 = UnityEngine.Shader.PropertyToID(name:  "DistortionUV_WaveX_1");
            Royal.Scenes.Home.Areas.Area06.Tasks.Pool.Area06PoolView.DistortionUvWaveY1 = UnityEngine.Shader.PropertyToID(name:  "DistortionUV_WaveY_1");
            Royal.Scenes.Home.Areas.Area06.Tasks.Pool.Area06PoolView.DistortionUvDistanceX1 = UnityEngine.Shader.PropertyToID(name:  "DistortionUV_DistanceX_1");
            Royal.Scenes.Home.Areas.Area06.Tasks.Pool.Area06PoolView.DistortionUvDistanceY1 = UnityEngine.Shader.PropertyToID(name:  "DistortionUV_DistanceY_1");
            Royal.Scenes.Home.Areas.Area06.Tasks.Pool.Area06PoolView.DistortionUvSpeed1 = UnityEngine.Shader.PropertyToID(name:  "DistortionUV_Speed_1");
            Royal.Scenes.Home.Areas.Area06.Tasks.Pool.Area06PoolView.EffectFade = UnityEngine.Shader.PropertyToID(name:  "_Effect_Fade");
        }
        private void <PlayAnimation>b__19_0()
        {
            this.poolAnimator.enabled = true;
            this.poolAnimator.gameObject.SetActive(value:  true);
            this.poolAnimator.Play(stateNameHash:  Royal.Scenes.Home.Areas.Area06.Tasks.Pool.Area06PoolView.Area06PoolRevealAnimation, layer:  0, normalizedTime:  0f);
        }
    
    }

}
