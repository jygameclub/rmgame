using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.PiggyBank
{
    public class PiggyBankIconShine : MonoBehaviour
    {
        // Fields
        public UnityEngine.AnimationCurve curve;
        public float totalDuration;
        public float elapsedTime;
        public float delay;
        private bool isInDelay;
        private bool isEnabled;
        private static readonly int ShinyFxPos1;
        private UnityEngine.MaterialPropertyBlock propBlock;
        private UnityEngine.SpriteRenderer sRenderer;
        
        // Methods
        public void Enable(bool isActive)
        {
            bool val_1 = isActive;
            this.elapsedTime = 0f;
            this.isEnabled = val_1;
            this.gameObject.SetActive(value:  val_1);
        }
        private void Awake()
        {
            this.sRenderer = this.GetComponent<UnityEngine.SpriteRenderer>();
            this.propBlock = new UnityEngine.MaterialPropertyBlock();
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
            this.propBlock.SetFloat(nameID:  Royal.Scenes.Home.Ui.Dialogs.PiggyBank.PiggyBankIconShine.ShinyFxPos1, value:  positionValue);
            this.sRenderer.SetPropertyBlock(properties:  this.propBlock);
        }
        public PiggyBankIconShine()
        {
        
        }
        private static PiggyBankIconShine()
        {
            Royal.Scenes.Home.Ui.Dialogs.PiggyBank.PiggyBankIconShine.ShinyFxPos1 = UnityEngine.Shader.PropertyToID(name:  "_ShinyFX_Pos_1");
        }
    
    }

}
