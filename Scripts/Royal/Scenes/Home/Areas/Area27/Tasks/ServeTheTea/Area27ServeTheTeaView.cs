using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area27.Tasks.ServeTheTea
{
    public class Area27ServeTheTeaView : AreaTaskViewAnimation
    {
        // Fields
        public UnityEngine.ParticleSystem[] vaporParticles;
        
        // Methods
        public override void PrepareAnimation()
        {
            this.PrepareAnimation();
            var val_2 = 0;
            do
            {
                if(val_2 >= this.vaporParticles.Length)
            {
                    return;
            }
            
                this.vaporParticles[val_2].Stop();
                val_2 = val_2 + 1;
            }
            while(this.vaporParticles != null);
            
            throw new NullReferenceException();
        }
        public override void Show()
        {
            this.Show();
            this.StartParticlesForAnimation();
        }
        public void StartParticlesForAnimation()
        {
            var val_2 = 0;
            do
            {
                if(val_2 >= this.vaporParticles.Length)
            {
                    return;
            }
            
                this.vaporParticles[val_2].Play();
                val_2 = val_2 + 1;
            }
            while(this.vaporParticles != null);
            
            throw new NullReferenceException();
        }
        public Area27ServeTheTeaView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
