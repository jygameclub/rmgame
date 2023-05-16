using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.PiggyBank
{
    public class PiggyBankProgress : MonoBehaviour
    {
        // Fields
        private const float TotalLeftBarSize = 4.594419;
        private const float MaxRatioBarrier = 0.88;
        private const float ThresholdRatioBarrier = 0.48;
        public TMPro.TextMeshPro tooltipText;
        public UnityEngine.SpriteRenderer leftProgressBar;
        public UnityEngine.SpriteRenderer rightProgressBar;
        public UnityEngine.Transform coin;
        private bool isRightProgressBarActive;
        private Royal.Player.Context.Units.PiggyBankManager piggyBankManager;
        private Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        
        // Methods
        private void Awake()
        {
            this.piggyBankManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.PiggyBankManager>(id:  8);
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
            this.UpdateViews();
        }
        private void UpdateViews()
        {
            this.UpdateTexts();
            if(Royal.Player.Context.Units.PiggyBankManager.GetPiggy() > 4999)
            {
                    return;
            }
            
            this.AnimateBarSize();
        }
        private void UpdateBarSize(float ratio)
        {
            if(ratio > 0f)
            {
                    this.EnableLeftBarSprites();
                float val_1 = ratio * 4.594419f;
                UnityEngine.Vector2 val_2 = this.leftProgressBar.size;
                UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  val_1, y:  val_2.y);
                this.leftProgressBar.size = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
                UnityEngine.Vector3 val_6 = this.rightProgressBar.transform.localPosition;
                float val_9 = 0.2f;
                UnityEngine.Vector2 val_7;
                val_9 = val_1 + val_9;
                val_7 = new UnityEngine.Vector2(x:  val_9, y:  val_6.y);
                UnityEngine.Vector3 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y});
                this.rightProgressBar.transform.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
                this.EnableRightBarSprite(ratio:  ratio);
                return;
            }
            
            this.DisableBarSprites();
        }
        private float GetDisplayRatio(float actualRatio)
        {
            if(actualRatio > 0.48f)
            {
                    if(Royal.Player.Context.Units.PiggyBankManager.GetThresholdToMaxRatio() > ((double)actualRatio = actualRatio))
            {
                    return 0.48f;
            }
            
            }
            
            var val_2 = (actualRatio <= 1f) ? (actualRatio) : 0.88f;
            return 0.48f;
        }
        private void UpdateTexts()
        {
            var val_6;
            int val_1 = Royal.Player.Context.Units.PiggyBankManager.GetPiggy();
            if(val_1 >= 1000)
            {
                goto label_0;
            }
            
            if(val_1 >= 100)
            {
                goto label_1;
            }
            
            val_6 = this.coin.transform;
            if(val_1 >= 10)
            {
                goto label_3;
            }
            
            goto label_8;
            label_0:
            val_6 = this.coin.transform;
            goto label_6;
            label_1:
            val_6 = this.coin.transform;
            goto label_8;
            label_3:
            label_8:
            label_6:
            val_6.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.tooltipText.text = val_1.ToString();
        }
        private void AnimateBarSize()
        {
            float val_12;
            float val_13;
            float val_14;
            float val_15;
            val_12 = 0.48f;
            val_13 = (float)this.piggyBankManager.GetLastSeenProgressPercentage();
            float val_2 = val_13 / 100f;
            if(val_2 > val_12)
            {
                    if(Royal.Player.Context.Units.PiggyBankManager.GetThresholdToMaxRatio() > (double)val_2)
            {
                goto label_3;
            }
            
            }
            
            val_13 = 0.88f;
            var val_4 = (val_2 <= 1f) ? (val_2) : (val_13);
            goto label_4;
            label_3:
            val_14 = 0.48f;
            label_4:
            float val_5 = this.piggyBankManager.GetCurrentPiggyToMaxRatio();
            val_15 = val_5;
            if(val_5 > val_12)
            {
                    if(Royal.Player.Context.Units.PiggyBankManager.GetThresholdToMaxRatio() > (double)val_15)
            {
                goto label_7;
            }
            
            }
            
            float val_7 = (val_15 <= 1f) ? (val_15) : 0.88f;
            label_7:
            this.piggyBankManager.SetLastSeenProgressPercentage(percentage:  UnityEngine.Mathf.CeilToInt(f:  val_15 * 100f));
            if(val_7 > val_14)
            {
                    this.UpdateBarSize(ratio:  val_14);
                UnityEngine.Coroutine val_11 = this.StartCoroutine(routine:  this.ProgressBarCoroutine(displayStartProgress:  val_14, displayEndProgress:  val_7, duration:  0.5f, onComplete:  0));
                return;
            }
            
            this.UpdateBarSize(ratio:  val_7);
        }
        private void EnableLeftBarSprites()
        {
            this.leftProgressBar.gameObject.SetActive(value:  true);
        }
        private void DisableBarSprites()
        {
            this.leftProgressBar.gameObject.SetActive(value:  false);
            this.rightProgressBar.gameObject.SetActive(value:  false);
        }
        private void EnableRightBarSprite(float ratio)
        {
            var val_4;
            UnityEngine.Vector2 val_1 = this.rightProgressBar.size;
            float val_4 = 4.594419f;
            val_4 = ratio * val_4;
            if(val_4 < 0)
            {
                    if(this.isRightProgressBarActive == false)
            {
                    return;
            }
            
                this.isRightProgressBarActive = false;
                UnityEngine.GameObject val_2 = this.rightProgressBar.gameObject;
                val_4 = 0;
            }
            else
            {
                    if(this.isRightProgressBarActive != false)
            {
                    return;
            }
            
                val_4 = 1;
            }
            
            this.rightProgressBar.gameObject.SetActive(value:  true);
        }
        private System.Collections.IEnumerator ProgressBarCoroutine(float displayStartProgress, float displayEndProgress, float duration, System.Action onComplete)
        {
            .<>1__state = 0;
            .duration = duration;
            .displayStartProgress = displayStartProgress;
            .displayEndProgress = displayEndProgress;
            .<>4__this = this;
            .onComplete = onComplete;
            return (System.Collections.IEnumerator)new PiggyBankProgress.<ProgressBarCoroutine>d__19();
        }
        public PiggyBankProgress()
        {
        
        }
    
    }

}
