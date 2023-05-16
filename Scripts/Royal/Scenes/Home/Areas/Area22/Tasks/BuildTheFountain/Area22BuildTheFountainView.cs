using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area22.Tasks.BuildTheFountain
{
    public class Area22BuildTheFountainView : AreaTaskViewAnimation
    {
        // Fields
        public Royal.Scenes.Home.Areas.Area09.Idles.DistortionAnimation poolDistortion;
        public UnityEngine.SpriteRenderer poolCaustics;
        private UnityEngine.Coroutine causticsRoutine;
        
        // Methods
        public override void Show()
        {
            this.Show();
            this.poolCaustics.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            this.poolDistortion.StopDistortion();
            this.poolDistortion.PlayDistortion();
            if(this.causticsRoutine != null)
            {
                    this.StopCoroutine(routine:  this.causticsRoutine);
                this.causticsRoutine = 0;
            }
            
            this.causticsRoutine = this.StartCoroutine(routine:  this.ShowPoolCaustics());
        }
        private System.Collections.IEnumerator ShowPoolCaustics()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new Area22BuildTheFountainView.<ShowPoolCaustics>d__4();
        }
        public override void PrepareAnimation()
        {
            if(this.causticsRoutine != null)
            {
                    this.StopCoroutine(routine:  this.causticsRoutine);
                this.causticsRoutine = 0;
            }
            
            this.poolCaustics.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            this.PrepareAnimation();
        }
        public Area22BuildTheFountainView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
