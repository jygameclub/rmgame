using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Area
{
    public class AreaProgressBar : MonoBehaviour
    {
        // Fields
        private const float TotalLeftBarSize = 4.4754;
        public TMPro.TextMeshPro progressText;
        public UnityEngine.SpriteRenderer leftProgressBar;
        public UnityEngine.Transform rightProgressBar;
        
        // Methods
        public void EnableBarSprites()
        {
            this.leftProgressBar.gameObject.SetActive(value:  true);
            this.rightProgressBar.gameObject.SetActive(value:  true);
        }
        public void DisableBarSprites()
        {
            this.leftProgressBar.gameObject.SetActive(value:  false);
            this.rightProgressBar.gameObject.SetActive(value:  false);
            this.progressText.text = "0%";
        }
        public void PlayProgressBarAnimation(float oldPercentage, float newPercentage, System.Action onComplete)
        {
            UnityEngine.Coroutine val_2 = Royal.Scenes.Start.Context.ApplicationContext.ManualStartCoroutine(iEnumerator:  this.ProgressBarCoroutine(startProgress:  oldPercentage, endProgress:  newPercentage, duration:  0.5f, onComplete:  onComplete));
        }
        public void UpdateBarSize(float ratio)
        {
            float val_6 = ratio;
            val_6 = val_6 * 4.4754f;
            UnityEngine.Vector2 val_1 = this.leftProgressBar.size;
            UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  val_6, y:  val_1.y);
            this.leftProgressBar.size = new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
            UnityEngine.Vector3 val_3 = this.rightProgressBar.localPosition;
            float val_7 = 0.2f;
            val_7 = val_6 + val_7;
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  val_7, y:  val_3.y);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
            this.rightProgressBar.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        }
        public void UpdateBarText(float ratio)
        {
            float val_3 = 100f;
            val_3 = ratio * val_3;
            this.progressText.text = val_3.ToString(format:  "N0")(val_3.ToString(format:  "N0")) + "%"("%");
        }
        private System.Collections.IEnumerator ProgressBarCoroutine(float startProgress, float endProgress, float duration, System.Action onComplete)
        {
            .<>1__state = 0;
            .duration = duration;
            .startProgress = startProgress;
            .endProgress = endProgress;
            .<>4__this = this;
            .onComplete = onComplete;
            return (System.Collections.IEnumerator)new AreaProgressBar.<ProgressBarCoroutine>d__9();
        }
        public AreaProgressBar()
        {
        
        }
    
    }

}
