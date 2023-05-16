using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area09.Idles
{
    public class DistortionAnimation : MonoBehaviour
    {
        // Fields
        private static readonly int DistortionUvWaveX1;
        private static readonly int DistortionUvWaveY1;
        private static readonly int DistortionUvDistanceX1;
        private static readonly int DistortionUvDistanceY1;
        private static readonly int DistortionUvSpeed1;
        private static readonly int EffectFade;
        public float waveX;
        public float waveY;
        public float distanceX;
        public float distanceY;
        public float speed;
        public float effectFade;
        public UnityEngine.Material distortionMaterial;
        public UnityEngine.SpriteRenderer spriteRenderer;
        private UnityEngine.MaterialPropertyBlock propBlock;
        private UnityEngine.MaterialPropertyBlock defaultPropBlock;
        private bool isPlayingDistortion;
        private UnityEngine.Coroutine distortionCoroutine;
        
        // Methods
        private void Awake()
        {
            this.spriteRenderer = this.GetComponent<UnityEngine.SpriteRenderer>();
            this.propBlock = new UnityEngine.MaterialPropertyBlock();
            UnityEngine.MaterialPropertyBlock val_3 = new UnityEngine.MaterialPropertyBlock();
            this.defaultPropBlock = val_3;
            this.spriteRenderer.GetPropertyBlock(properties:  val_3);
        }
        public void ChangeMaterial(UnityEngine.Material mat, UnityEngine.Color brightness)
        {
            this.isPlayingDistortion = false;
            this.spriteRenderer.material = mat;
            UnityEngine.Color val_1 = this.spriteRenderer.color;
            this.spriteRenderer.color = new UnityEngine.Color() {r = brightness.r, g = brightness.g, b = brightness.b, a = val_1.a};
        }
        public void PlayDistortion()
        {
            UnityEngine.SpriteRenderer val_4;
            if(this.isPlayingDistortion == true)
            {
                    return;
            }
            
            val_4 = this.spriteRenderer;
            this.isPlayingDistortion = true;
            val_4.material = this.distortionMaterial;
            if(((true & 2) != 0) && (true == 0))
            {
                    val_4 = null;
            }
            
            if(Royal.Scenes.Start.Context.ApplicationContext.controller == 0)
            {
                    return;
            }
            
            this.distortionCoroutine = Royal.Scenes.Start.Context.ApplicationContext.ManualStartCoroutine(iEnumerator:  this.StartDistortion());
        }
        public void StopDistortion()
        {
            if(this.distortionCoroutine == null)
            {
                    return;
            }
            
            this.isPlayingDistortion = false;
            this.SetValues(fade:  0f);
            Royal.Scenes.Start.Context.ApplicationContext.ManualStopCoroutine(iEnumerator:  this.distortionCoroutine);
        }
        private System.Collections.IEnumerator StartDistortion()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new DistortionAnimation.<StartDistortion>d__22();
        }
        public void SetValues(float fade)
        {
            this.spriteRenderer.GetPropertyBlock(properties:  this.propBlock);
            this.propBlock.SetFloat(nameID:  Royal.Scenes.Home.Areas.Area09.Idles.DistortionAnimation.DistortionUvWaveX1, value:  this.waveX);
            this.propBlock.SetFloat(nameID:  Royal.Scenes.Home.Areas.Area09.Idles.DistortionAnimation.DistortionUvWaveY1, value:  this.waveY);
            this.propBlock.SetFloat(nameID:  Royal.Scenes.Home.Areas.Area09.Idles.DistortionAnimation.DistortionUvDistanceX1, value:  this.distanceX);
            this.propBlock.SetFloat(nameID:  Royal.Scenes.Home.Areas.Area09.Idles.DistortionAnimation.DistortionUvDistanceY1, value:  this.distanceY);
            this.propBlock.SetFloat(nameID:  Royal.Scenes.Home.Areas.Area09.Idles.DistortionAnimation.DistortionUvSpeed1, value:  this.speed);
            this.propBlock.SetFloat(nameID:  Royal.Scenes.Home.Areas.Area09.Idles.DistortionAnimation.EffectFade, value:  fade);
            this.spriteRenderer.SetPropertyBlock(properties:  this.propBlock);
        }
        public DistortionAnimation()
        {
            this.waveX = 5f;
            this.waveY = 200f;
            this.distanceY = 0.01f;
            this.speed = 1f;
            this.effectFade = 1f;
        }
        private static DistortionAnimation()
        {
            Royal.Scenes.Home.Areas.Area09.Idles.DistortionAnimation.DistortionUvWaveX1 = UnityEngine.Shader.PropertyToID(name:  "DistortionUV_WaveX_1");
            Royal.Scenes.Home.Areas.Area09.Idles.DistortionAnimation.DistortionUvWaveY1 = UnityEngine.Shader.PropertyToID(name:  "DistortionUV_WaveY_1");
            Royal.Scenes.Home.Areas.Area09.Idles.DistortionAnimation.DistortionUvDistanceX1 = UnityEngine.Shader.PropertyToID(name:  "DistortionUV_DistanceX_1");
            Royal.Scenes.Home.Areas.Area09.Idles.DistortionAnimation.DistortionUvDistanceY1 = UnityEngine.Shader.PropertyToID(name:  "DistortionUV_DistanceY_1");
            Royal.Scenes.Home.Areas.Area09.Idles.DistortionAnimation.DistortionUvSpeed1 = UnityEngine.Shader.PropertyToID(name:  "DistortionUV_Speed_1");
            Royal.Scenes.Home.Areas.Area09.Idles.DistortionAnimation.EffectFade = UnityEngine.Shader.PropertyToID(name:  "_Effect_Fade");
        }
    
    }

}
