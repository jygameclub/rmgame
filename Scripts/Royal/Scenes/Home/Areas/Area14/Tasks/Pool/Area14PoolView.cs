using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area14.Tasks.Pool
{
    public class Area14PoolView : AreaTaskViewAnimation
    {
        // Fields
        public Royal.Scenes.Home.Areas.Area09.Idles.DistortionAnimation poolDistortion;
        public UnityEngine.SpriteRenderer poolCaustics;
        private UnityEngine.Coroutine causticRoutine;
        
        // Methods
        public override void Show()
        {
            this.Show();
            this.poolCaustics.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            this.poolDistortion.StopDistortion();
            this.poolDistortion.PlayDistortion();
            if(this.causticRoutine != null)
            {
                    this.StopCoroutine(routine:  this.causticRoutine);
                this.causticRoutine = 0;
            }
            
            this.causticRoutine = this.StartCoroutine(routine:  this.ShowPoolCaustics());
        }
        private System.Collections.IEnumerator ShowPoolCaustics()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new Area14PoolView.<ShowPoolCaustics>d__4();
        }
        public override void PrepareAnimation()
        {
            if(this.causticRoutine != null)
            {
                    this.StopCoroutine(routine:  this.causticRoutine);
                this.causticRoutine = 0;
            }
            
            this.poolCaustics.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            this.PrepareAnimation();
        }
        public Area14PoolView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
