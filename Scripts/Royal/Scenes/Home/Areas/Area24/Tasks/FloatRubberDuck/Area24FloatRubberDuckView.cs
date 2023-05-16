using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area24.Tasks.FloatRubberDuck
{
    public class Area24FloatRubberDuckView : AreaTaskViewAnimation
    {
        // Fields
        public UnityEngine.ParticleSystem[] candleParticles;
        public Royal.Scenes.Home.Areas.Area09.Idles.DistortionAnimation[] distortionAnimations;
        
        // Methods
        public override void PrepareAnimation()
        {
            this.PrepareAnimation();
            var val_2 = 0;
            do
            {
                if(val_2 >= this.candleParticles.Length)
            {
                    return;
            }
            
                this.candleParticles[val_2].Stop();
                val_2 = val_2 + 1;
            }
            while(this.candleParticles != null);
            
            throw new NullReferenceException();
        }
        public override void Show()
        {
            this.Show();
            this.StartParticlesForAnimation();
            var val_2 = 0;
            do
            {
                if(val_2 >= this.distortionAnimations.Length)
            {
                    return;
            }
            
                this.distortionAnimations[val_2].PlayDistortion();
                val_2 = val_2 + 1;
            }
            while(this.distortionAnimations != null);
            
            throw new NullReferenceException();
        }
        public override void HideAll()
        {
            var val_2 = 0;
            label_4:
            if(val_2 >= this.distortionAnimations.Length)
            {
                goto label_1;
            }
            
            this.distortionAnimations[val_2].StopDistortion();
            val_2 = val_2 + 1;
            if(this.distortionAnimations != null)
            {
                goto label_4;
            }
            
            throw new NullReferenceException();
            label_1:
            this.HideAll();
        }
        private void StartParticlesForAnimation()
        {
            var val_2 = 0;
            do
            {
                if(val_2 >= this.candleParticles.Length)
            {
                    return;
            }
            
                this.candleParticles[val_2].Play();
                val_2 = val_2 + 1;
            }
            while(this.candleParticles != null);
            
            throw new NullReferenceException();
        }
        public void StartParticlesForParticularAnimation(int index)
        {
            this.candleParticles[index].Play();
        }
        public Area24FloatRubberDuckView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
