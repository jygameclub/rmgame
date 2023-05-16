using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area26.Tasks.PrepareIceRink
{
    public class Area26PrepareIceRinkView : AreaTaskViewAnimation
    {
        // Fields
        public UnityEngine.SpriteRenderer waterCaustics;
        private UnityEngine.Coroutine causticsRoutine;
        
        // Methods
        public void StartCausticEffect()
        {
            if(this.causticsRoutine != null)
            {
                    this.StopCoroutine(routine:  this.causticsRoutine);
                this.causticsRoutine = 0;
            }
            
            this.causticsRoutine = this.StartCoroutine(routine:  this.ShowWaterCaustics());
        }
        private System.Collections.IEnumerator ShowWaterCaustics()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new Area26PrepareIceRinkView.<ShowWaterCaustics>d__3();
        }
        public Area26PrepareIceRinkView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
