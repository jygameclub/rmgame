using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Madness.MadnessBar
{
    public class MadnessBarProgress : MonoBehaviour
    {
        // Fields
        private const float BarFullFrames = 90;
        private const int FastBarFillFrames = 7;
        private const float ProgressBarMaxThreshold = 0.92;
        private const float ProgressBarMinThreshold = 0.03;
        private float totalLeftBarSize;
        public UnityEngine.SpriteRenderer leftProgressBar;
        public UnityEngine.SpriteRenderer rightProgressBar;
        public TMPro.TextMeshPro barText;
        private bool isRightProgressBarActive;
        private Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        private int barCurrent;
        private int barTarget;
        
        // Methods
        public void Init()
        {
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
            Royal.Player.Context.Units.MadnessManager val_2 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.MadnessManager>(id:  10);
            int val_4 = UnityEngine.Mathf.Max(a:  val_2.GetCurrentTarget(), b:  1);
            this.SetBarValues(current:  UnityEngine.Mathf.Min(a:  val_2.GetCount(), b:  val_4), target:  val_4);
        }
        public void FakeInit(float totalLeftBarSize)
        {
            this.totalLeftBarSize = totalLeftBarSize;
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
            int val_4 = UnityEngine.Mathf.Max(a:  Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.MadnessManager>(id:  10).GetCurrentTarget(), b:  1);
            this.SetBarValues(current:  val_4, target:  val_4);
        }
        public void SetBarValues(int current, int target)
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
                UnityEngine.Vector2 val_3 = this.leftProgressBar.size;
                UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  val_2, y:  val_3.y);
                this.leftProgressBar.size = new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
                UnityEngine.Vector3 val_7 = this.rightProgressBar.transform.localPosition;
                float val_10 = 0.2f;
                UnityEngine.Vector2 val_8;
                val_10 = val_2 + val_10;
                val_8 = new UnityEngine.Vector2(x:  val_10, y:  val_7.y);
                UnityEngine.Vector3 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y});
                this.rightProgressBar.transform.localPosition = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
                this.EnableRightBarSprite(ratio:  val_1);
                return;
            }
            
            this.DisableBarSprites();
        }
        public void AnimateBar(int start, int end, int target, System.Action onComplete)
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.ProgressBarCoroutine(start:  start, end:  end, target:  target, onComplete:  onComplete));
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
            var val_5;
            UnityEngine.Vector2 val_1 = this.rightProgressBar.size;
            if((this.totalLeftBarSize * ratio) < 0)
            {
                    if(this.isRightProgressBarActive == false)
            {
                    return;
            }
            
                this.isRightProgressBarActive = false;
                UnityEngine.GameObject val_3 = this.rightProgressBar.gameObject;
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
            
            this.rightProgressBar.gameObject.SetActive(value:  true);
        }
        private float GetThresholdedRatio(float ratio)
        {
            ratio = ratio * 0.89f;
            ratio = ratio + 0.03f;
            return (float)(ratio == 0f) ? 0f : (ratio);
        }
        private System.Collections.IEnumerator ProgressBarCoroutine(int start, int end, int target, System.Action onComplete)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .target = target;
            .end = end;
            .start = start;
            .onComplete = onComplete;
            return (System.Collections.IEnumerator)new MadnessBarProgress.<ProgressBarCoroutine>d__21();
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
        public MadnessBarProgress()
        {
            this.totalLeftBarSize = 6.848492f;
        }
    
    }

}
