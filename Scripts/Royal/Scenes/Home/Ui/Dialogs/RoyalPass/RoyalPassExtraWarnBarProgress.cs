using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass
{
    public class RoyalPassExtraWarnBarProgress : MonoBehaviour
    {
        // Fields
        private const float ProgressBarMaxThreshold = 0.92;
        private const float ProgressBarMinThreshold = 0.03;
        private float totalLeftBarSize;
        public UnityEngine.Transform leftContainerTransform;
        public UnityEngine.SpriteRenderer leftContainerSprite;
        public UnityEngine.Transform rightContainerTransform;
        public UnityEngine.SpriteRenderer leftProgressBarSprite;
        public UnityEngine.Transform leftProgressBarTransform;
        public UnityEngine.SpriteRenderer rightProgressBarSprite;
        public UnityEngine.Transform rightProgressBarTransform;
        public TMPro.TextMeshPro barText;
        private bool isRightProgressBarActive;
        private Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        private Royal.Player.Context.Units.RoyalPassManager royalPassManager;
        private int barCurrent;
        private int barTarget;
        
        // Methods
        public void FakeInit(float totalLeftBarSize, bool isShortBar)
        {
            float val_5 = totalLeftBarSize;
            if(isShortBar != false)
            {
                    val_5 = this.InitForShortBar(totalLeftBarSize:  val_5 = totalLeftBarSize);
            }
            
            this.totalLeftBarSize = val_5;
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
            this.royalPassManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.RoyalPassManager>(id:  12);
            int val_4 = this.GetTargetToShow();
            this.SetBarValues(current:  val_4, target:  val_4);
        }
        private float InitForShortBar(float totalLeftBarSize)
        {
            UnityEngine.Vector3 val_1 = this.rightContainerTransform.localPosition;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.left;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  0.1845f);
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            this.rightContainerTransform.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            UnityEngine.Vector3 val_5 = this.leftContainerTransform.localPosition;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.left;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  0.1845f);
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            this.leftContainerTransform.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            UnityEngine.Vector2 val_9 = this.leftContainerSprite.size;
            UnityEngine.Vector2 val_10 = UnityEngine.Vector2.left;
            UnityEngine.Vector2 val_11 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y}, d:  0.1843639f);
            UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y}, b:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y});
            this.leftContainerSprite.size = new UnityEngine.Vector2() {x = val_12.x, y = val_12.y};
            UnityEngine.Vector3 val_13 = this.rightProgressBarTransform.localPosition;
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.left;
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, d:  0.185f);
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, b:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
            this.rightProgressBarTransform.localPosition = new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z};
            UnityEngine.Vector2 val_17 = this.leftProgressBarSprite.size;
            UnityEngine.Vector2 val_18 = UnityEngine.Vector2.left;
            UnityEngine.Vector2 val_19 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_18.x, y = val_18.y}, d:  0.1747744f);
            UnityEngine.Vector2 val_20 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_17.x, y = val_17.y}, b:  new UnityEngine.Vector2() {x = val_19.x, y = val_19.y});
            this.leftProgressBarSprite.size = new UnityEngine.Vector2() {x = val_20.x, y = val_20.y};
            UnityEngine.Vector3 val_21 = this.leftProgressBarTransform.localPosition;
            UnityEngine.Vector3 val_22 = UnityEngine.Vector3.left;
            UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, d:  0.0048f);
            UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z}, b:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z});
            this.leftProgressBarTransform.localPosition = new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z};
            float val_25 = -0.1747744f;
            val_25 = totalLeftBarSize + val_25;
            return (float)val_25;
        }
        private int GetStepToShow()
        {
            return (int)Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_interopData;
        }
        private int GetTargetToShow()
        {
            bool val_1 = this.royalPassManager.IsLastStep();
            if(val_1 == false)
            {
                    return UnityEngine.Mathf.Max(a:  this.royalPassManager.GetTargetForStep(step:  val_1.GetStepToShow()), b:  1);
            }
            
            return 10;
        }
        private void SetBarValues(int current, int target)
        {
            this.SetBarText(current:  current, target:  target);
            if(current == target)
            {
                
            }
            else
            {
                    float val_2 = (float)current;
                val_2 = val_2 / (float)target;
                val_2 = val_2 * 0.89f;
                val_2 = val_2 + 0.03f;
            }
            
            this.UpdateBarSize(ratio:  (val_2 == 0f) ? 0f : (val_2));
        }
        private void UpdateBarSize(float ratio)
        {
            if(ratio > 0f)
            {
                    float val_1 = UnityEngine.Mathf.Min(a:  1f, b:  ratio);
                this.EnableLeftBarSprites();
                float val_2 = val_1 * this.totalLeftBarSize;
                UnityEngine.Vector2 val_3 = this.leftProgressBarSprite.size;
                UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  val_2, y:  val_3.y);
                this.leftProgressBarSprite.size = new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
                UnityEngine.Vector3 val_7 = this.rightProgressBarSprite.transform.localPosition;
                float val_10 = 0.2f;
                UnityEngine.Vector2 val_8;
                val_10 = val_2 + val_10;
                val_8 = new UnityEngine.Vector2(x:  val_10, y:  val_7.y);
                UnityEngine.Vector3 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y});
                this.rightProgressBarSprite.transform.localPosition = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
                this.EnableRightBarSprite(ratio:  val_1);
                return;
            }
            
            this.DisableBarSprites();
        }
        private void EnableLeftBarSprites()
        {
            this.leftProgressBarSprite.gameObject.SetActive(value:  true);
        }
        private void DisableBarSprites()
        {
            this.leftProgressBarSprite.gameObject.SetActive(value:  false);
            this.rightProgressBarSprite.gameObject.SetActive(value:  false);
        }
        private void EnableRightBarSprite(float ratio)
        {
            var val_5;
            UnityEngine.Vector2 val_1 = this.rightProgressBarSprite.size;
            if((this.totalLeftBarSize * ratio) < 0)
            {
                    if(this.isRightProgressBarActive == false)
            {
                    return;
            }
            
                this.isRightProgressBarActive = false;
                UnityEngine.GameObject val_3 = this.rightProgressBarSprite.gameObject;
                val_5 = 0;
            }
            else
            {
                    if(this.isRightProgressBarActive != false)
            {
                    return;
            }
            
                val_5 = 1;
            }
            
            this.rightProgressBarSprite.gameObject.SetActive(value:  true);
        }
        private float GetThresholdedRatio(float ratio)
        {
            ratio = ratio * 0.89f;
            ratio = ratio + 0.03f;
            return (float)(ratio == 0f) ? 0f : (ratio);
        }
        private void SetBarText(int current, int target)
        {
            int val_2 = current;
            if(this.barCurrent == val_2)
            {
                    if(this.barTarget == target)
            {
                    return;
            }
            
            }
            
            this.barCurrent = val_2;
            this.barTarget = target;
            val_2 = val_2;
            this.barText.text = System.String.Format(format:  "{0}/{1}", arg0:  val_2 = current, arg1:  target);
        }
        public RoyalPassExtraWarnBarProgress()
        {
            this.totalLeftBarSize = 3.010742f;
        }
    
    }

}
