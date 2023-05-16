using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area11.Tasks.BathTub
{
    public class Area11BathTubView : AreaTaskViewAnimation
    {
        // Fields
        public UnityEngine.ParticleSystem foamIdleParticles;
        
        // Methods
        public override void PrepareAnimation()
        {
            this.PrepareAnimation();
            this.foamIdleParticles.Stop();
        }
        public override void Show()
        {
            this.Show();
            this.foamIdleParticles.Play();
        }
        public void PlayIdleFoamParticles()
        {
            if(this.foamIdleParticles != null)
            {
                    this.foamIdleParticles.Play();
                return;
            }
            
            throw new NullReferenceException();
        }
        public Area11BathTubView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
