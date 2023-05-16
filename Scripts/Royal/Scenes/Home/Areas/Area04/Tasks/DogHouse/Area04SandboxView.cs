using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area04.Tasks.DogHouse
{
    public class Area04SandboxView : MonoBehaviour
    {
        // Fields
        private static readonly int AtlasUv;
        private static readonly int DissolveValue;
        public UnityEngine.Animator animator;
        public UnityEngine.Material defaultSpriteMat;
        public UnityEngine.Material sandBoxMat;
        public float elapsed;
        public UnityEngine.SpriteRenderer sandBoxRenderer;
        public UnityEngine.SpriteRenderer shadowRenderer;
        private UnityEngine.MaterialPropertyBlock propBlock;
        private UnityEngine.MaterialPropertyBlock defaultPropBlock;
        private UnityEngine.ParticleSystem appearParticles;
        
        // Methods
        private void Awake()
        {
            if(this.sandBoxRenderer != null)
            {
                    this.sandBoxRenderer.material = this.defaultSpriteMat;
                return;
            }
            
            throw new NullReferenceException();
        }
        public void PrepareAnimation(UnityEngine.ParticleSystem prefab)
        {
            UnityEngine.ParticleSystem val_2 = UnityEngine.Object.Instantiate<UnityEngine.ParticleSystem>(original:  prefab, parent:  this.transform);
            this.appearParticles = val_2;
            val_2.name = val_2.name.Replace(oldValue:  "(Clone)", newValue:  System.String.alignConst);
        }
        public void PlayAnimation()
        {
            this.propBlock = new UnityEngine.MaterialPropertyBlock();
            UnityEngine.MaterialPropertyBlock val_2 = new UnityEngine.MaterialPropertyBlock();
            this.defaultPropBlock = val_2;
            this.sandBoxRenderer.GetPropertyBlock(properties:  val_2);
            UnityEngine.Vector4 val_4 = Royal.Infrastructure.Utils.Sprite.SpriteExtensions.GetAtlasUvFromUvs(sprite:  this.sandBoxRenderer.sprite);
            this.SetAtlasUv(atlasUv:  new UnityEngine.Vector4() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w});
            this.elapsed = 0f;
            this.SetDissolveValue(dissolveValue:  0f);
            this.sandBoxRenderer.material = this.sandBoxMat;
            this.animator.enabled = true;
            this.animator.Play(stateName:  "Area04Sandbox Animation", layer:  0, normalizedTime:  0f);
            this.appearParticles.Play();
            this.shadowRenderer.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_6 = DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.shadowRenderer, endValue:  1f, duration:  1f), delay:  0.5f);
            UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  this.UpdateForAnimation());
        }
        private System.Collections.IEnumerator UpdateForAnimation()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new Area04SandboxView.<UpdateForAnimation>d__14();
        }
        private void CompleteAnimation()
        {
            this.sandBoxRenderer.SetPropertyBlock(properties:  this.defaultPropBlock);
            this.sandBoxRenderer.sharedMaterial = this.defaultSpriteMat;
            this.animator.enabled = false;
        }
        private void UpdateDissolveValue()
        {
            this.SetDissolveValue(dissolveValue:  this.elapsed);
        }
        private void SetAtlasUv(UnityEngine.Vector4 atlasUv)
        {
            this.sandBoxRenderer.GetPropertyBlock(properties:  this.propBlock);
            this.propBlock.SetVector(nameID:  Royal.Scenes.Home.Areas.Area04.Tasks.DogHouse.Area04SandboxView.AtlasUv, value:  new UnityEngine.Vector4() {x = atlasUv.x, y = atlasUv.y, z = atlasUv.z, w = atlasUv.w});
            this.sandBoxRenderer.SetPropertyBlock(properties:  this.propBlock);
        }
        private void SetDissolveValue(float dissolveValue)
        {
            this.sandBoxRenderer.GetPropertyBlock(properties:  this.propBlock);
            this.propBlock.SetFloat(nameID:  Royal.Scenes.Home.Areas.Area04.Tasks.DogHouse.Area04SandboxView.DissolveValue, value:  dissolveValue);
            this.sandBoxRenderer.SetPropertyBlock(properties:  this.propBlock);
        }
        public void EndAnimation()
        {
            UnityEngine.Object.Destroy(obj:  this.appearParticles.gameObject);
            this.appearParticles = 0;
        }
        public Area04SandboxView()
        {
        
        }
        private static Area04SandboxView()
        {
            Royal.Scenes.Home.Areas.Area04.Tasks.DogHouse.Area04SandboxView.AtlasUv = UnityEngine.Shader.PropertyToID(name:  "_AtlasUV");
            Royal.Scenes.Home.Areas.Area04.Tasks.DogHouse.Area04SandboxView.DissolveValue = UnityEngine.Shader.PropertyToID(name:  "_DissolveValue");
        }
    
    }

}
