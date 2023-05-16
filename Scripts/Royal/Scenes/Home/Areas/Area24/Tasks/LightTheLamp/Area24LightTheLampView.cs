using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area24.Tasks.LightTheLamp
{
    public class Area24LightTheLampView : AreaTaskViewAnimation
    {
        // Fields
        public UnityEngine.ParticleSystem lampParticles;
        
        // Methods
        public override void PrepareAnimation()
        {
            this.PrepareAnimation();
            this.lampParticles.Stop();
        }
        public override void Show()
        {
            this.Show();
            this.lampParticles.Play();
        }
        public void StartParticlesForAnimation()
        {
            if(this.lampParticles != null)
            {
                    this.lampParticles.Play();
                return;
            }
            
            throw new NullReferenceException();
        }
        public Area24LightTheLampView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
