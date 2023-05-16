using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.KingsCup
{
    public class KingsCupIconShine : MonoBehaviour
    {
        // Fields
        public UnityEngine.AnimationCurve curve;
        public float totalDuration;
        public float elapsedTime;
        public float delay;
        private bool isInDelay;
        private bool isEnabled;
        private static readonly int ShinyFxPos1;
        private static readonly int AtlasUv;
        private UnityEngine.MaterialPropertyBlock propBlock;
        private UnityEngine.SpriteRenderer sRenderer;
        
        // Methods
        private void Awake()
        {
            this.sRenderer = this.GetComponent<UnityEngine.SpriteRenderer>();
            this.propBlock = new UnityEngine.MaterialPropertyBlock();
            UnityEngine.Vector4 val_4 = Royal.Infrastructure.Utils.Sprite.SpriteExtensions.GetAtlasUvFromUvs(sprite:  this.sRenderer.sprite);
            this.SetAtlasUv(atlasUv:  new UnityEngine.Vector4() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w});
            this.elapsedTime = 0f;
            this.isEnabled = true;
        }
        private void Update()
        {
            if(this.isEnabled == false)
            {
                    return;
            }
            
            float val_1 = UnityEngine.Time.deltaTime;
            val_1 = this.elapsedTime + val_1;
            this.elapsedTime = val_1;
            if(this.isInDelay != false)
            {
                    if(val_1 <= this.delay)
            {
                    return;
            }
            
                this.isInDelay = false;
                this.elapsedTime = 0f;
                return;
            }
            
            if(val_1 > this.totalDuration)
            {
                    this.elapsedTime = 0f;
                this.isInDelay = true;
                return;
            }
            
            val_1 = val_1 / this.totalDuration;
            this.SetPositionValue(positionValue:  this.curve.Evaluate(time:  val_1));
        }
        private void StartShine()
        {
            this.elapsedTime = 0f;
            this.isEnabled = true;
        }
        private void StopShine()
        {
            this.elapsedTime = 0f;
            this.isEnabled = false;
        }
        private void SetPositionValue(float positionValue)
        {
            this.sRenderer.GetPropertyBlock(properties:  this.propBlock);
            this.propBlock.SetFloat(nameID:  Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupIconShine.ShinyFxPos1, value:  positionValue);
            this.sRenderer.SetPropertyBlock(properties:  this.propBlock);
        }
        private void SetAtlasUv(UnityEngine.Vector4 atlasUv)
        {
            this.sRenderer.GetPropertyBlock(properties:  this.propBlock);
            this.propBlock.SetVector(nameID:  Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupIconShine.AtlasUv, value:  new UnityEngine.Vector4() {x = atlasUv.x, y = atlasUv.y, z = atlasUv.z, w = atlasUv.w});
            this.sRenderer.SetPropertyBlock(properties:  this.propBlock);
        }
        public KingsCupIconShine()
        {
        
        }
        private static KingsCupIconShine()
        {
            Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupIconShine.ShinyFxPos1 = UnityEngine.Shader.PropertyToID(name:  "_ShinyFX_Pos_1");
            Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupIconShine.AtlasUv = UnityEngine.Shader.PropertyToID(name:  "_AtlasUV");
        }
    
    }

}
