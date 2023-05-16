using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area04.Tasks.Pool
{
    public class Area04PoolView : AreaTaskView
    {
        // Fields
        private static readonly int DistortionUvWaveX1;
        private static readonly int DistortionUvWaveY1;
        private static readonly int DistortionUvDistanceX1;
        private static readonly int DistortionUvDistanceY1;
        private static readonly int DistortionUvSpeed1;
        private static readonly int EffectFade;
        private static readonly int AtlasUv;
        private static readonly int DissolveValue;
        public float distortionWaveX;
        public float distortionWaveY;
        public float distortionDistanceY;
        public float distortionSpeed;
        public float distortionFade;
        public UnityEngine.SpriteRenderer distortWater;
        public UnityEngine.SpriteRenderer appearWater;
        public float appearElapsed;
        private UnityEngine.Animator poolAnimator;
        private UnityEngine.MaterialPropertyBlock propBlock;
        
        // Methods
        protected override void Awake()
        {
            this.Awake();
            UnityEngine.Animator val_1 = this.GetComponent<UnityEngine.Animator>();
            this.poolAnimator = val_1;
            val_1.enabled = false;
            this.UpdateDistortionValues();
            this.appearWater.gameObject.SetActive(value:  false);
        }
        public override void PrepareAnimation()
        {
            this.PrepareAnimation();
            this.propBlock = new UnityEngine.MaterialPropertyBlock();
            UnityEngine.Vector4 val_3 = Royal.Infrastructure.Utils.Sprite.SpriteExtensions.GetAtlasUvFromUvs(sprite:  this.appearWater.sprite);
            this.SetAtlasUv(atlasUv:  new UnityEngine.Vector4() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w});
            this.poolAnimator.gameObject.SetActive(value:  false);
        }
        public override DG.Tweening.Sequence PlayAnimation()
        {
            this.PlayDefaultAnimationSound();
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area04.Tasks.Pool.Area04PoolView::<PlayAnimation>b__20_0()));
            return val_1;
        }
        public override void EndAnimation()
        {
            this.EndAnimation();
            this.poolAnimator.enabled = false;
            this.appearWater.gameObject.SetActive(value:  false);
        }
        private void Update()
        {
            if(this.poolAnimator.enabled == false)
            {
                    return;
            }
            
            this.UpdateDistortionValues();
            this.SetDissolveValue(dissolveValue:  this.appearElapsed);
        }
        private void UpdateDistortionValues()
        {
            UnityEngine.Material val_1 = this.distortWater.material;
            val_1.SetFloat(nameID:  Royal.Scenes.Home.Areas.Area04.Tasks.Pool.Area04PoolView.DistortionUvWaveX1, value:  this.distortionWaveX);
            val_1.SetFloat(nameID:  Royal.Scenes.Home.Areas.Area04.Tasks.Pool.Area04PoolView.DistortionUvWaveY1, value:  this.distortionWaveY);
            val_1.SetFloat(nameID:  Royal.Scenes.Home.Areas.Area04.Tasks.Pool.Area04PoolView.DistortionUvDistanceX1, value:  0f);
            val_1.SetFloat(nameID:  Royal.Scenes.Home.Areas.Area04.Tasks.Pool.Area04PoolView.DistortionUvDistanceY1, value:  this.distortionDistanceY);
            val_1.SetFloat(nameID:  Royal.Scenes.Home.Areas.Area04.Tasks.Pool.Area04PoolView.DistortionUvSpeed1, value:  this.distortionSpeed);
            val_1.SetFloat(nameID:  Royal.Scenes.Home.Areas.Area04.Tasks.Pool.Area04PoolView.EffectFade, value:  this.distortionFade);
        }
        private void SetAtlasUv(UnityEngine.Vector4 atlasUv)
        {
            this.appearWater.GetPropertyBlock(properties:  this.propBlock);
            this.propBlock.SetVector(nameID:  Royal.Scenes.Home.Areas.Area04.Tasks.Pool.Area04PoolView.AtlasUv, value:  new UnityEngine.Vector4() {x = atlasUv.x, y = atlasUv.y, z = atlasUv.z, w = atlasUv.w});
            this.appearWater.SetPropertyBlock(properties:  this.propBlock);
        }
        private void SetDissolveValue(float dissolveValue)
        {
            if((this.appearWater.material.name.StartsWith(value:  "PoolAppearMat")) == false)
            {
                    return;
            }
            
            if(this.propBlock == null)
            {
                    return;
            }
            
            this.appearWater.GetPropertyBlock(properties:  this.propBlock);
            this.propBlock.SetFloat(nameID:  Royal.Scenes.Home.Areas.Area04.Tasks.Pool.Area04PoolView.DissolveValue, value:  dissolveValue);
            this.appearWater.SetPropertyBlock(properties:  this.propBlock);
        }
        public Area04PoolView()
        {
            this.distortionWaveX = ;
            this.distortionWaveY = ;
            this.distortionDistanceY = 0.15f;
            this.distortionSpeed = 0.6f;
            this.distortionFade = 0.05f;
        }
        private static Area04PoolView()
        {
            Royal.Scenes.Home.Areas.Area04.Tasks.Pool.Area04PoolView.DistortionUvWaveX1 = UnityEngine.Shader.PropertyToID(name:  "DistortionUV_WaveX_1");
            Royal.Scenes.Home.Areas.Area04.Tasks.Pool.Area04PoolView.DistortionUvWaveY1 = UnityEngine.Shader.PropertyToID(name:  "DistortionUV_WaveY_1");
            Royal.Scenes.Home.Areas.Area04.Tasks.Pool.Area04PoolView.DistortionUvDistanceX1 = UnityEngine.Shader.PropertyToID(name:  "DistortionUV_DistanceX_1");
            Royal.Scenes.Home.Areas.Area04.Tasks.Pool.Area04PoolView.DistortionUvDistanceY1 = UnityEngine.Shader.PropertyToID(name:  "DistortionUV_DistanceY_1");
            Royal.Scenes.Home.Areas.Area04.Tasks.Pool.Area04PoolView.DistortionUvSpeed1 = UnityEngine.Shader.PropertyToID(name:  "DistortionUV_Speed_1");
            Royal.Scenes.Home.Areas.Area04.Tasks.Pool.Area04PoolView.EffectFade = UnityEngine.Shader.PropertyToID(name:  "_Effect_Fade");
            Royal.Scenes.Home.Areas.Area04.Tasks.Pool.Area04PoolView.AtlasUv = UnityEngine.Shader.PropertyToID(name:  "_AtlasUV");
            Royal.Scenes.Home.Areas.Area04.Tasks.Pool.Area04PoolView.DissolveValue = UnityEngine.Shader.PropertyToID(name:  "_DissolveValue");
        }
        private void <PlayAnimation>b__20_0()
        {
            this.appearWater.gameObject.SetActive(value:  true);
            this.poolAnimator.enabled = true;
            this.poolAnimator.gameObject.SetActive(value:  true);
            this.poolAnimator.Play(stateName:  "Area04PoolAppearAnimation", layer:  0, normalizedTime:  0f);
        }
    
    }

}
