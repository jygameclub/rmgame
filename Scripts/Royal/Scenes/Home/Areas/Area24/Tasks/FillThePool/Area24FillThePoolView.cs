using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area24.Tasks.FillThePool
{
    public class Area24FillThePoolView : AreaTaskViewAnimation
    {
        // Fields
        public UnityEngine.ParticleSystem[] fountainParticles;
        public Royal.Scenes.Home.Areas.Area09.Idles.DistortionAnimation[] distortionAnimations;
        public UnityEngine.SpriteRenderer poolCaustics;
        
        // Methods
        public override void PrepareAnimation()
        {
            this.PrepareAnimation();
            var val_2 = 0;
            do
            {
                if(val_2 >= this.fountainParticles.Length)
            {
                    return;
            }
            
                this.fountainParticles[val_2].Stop();
                val_2 = val_2 + 1;
            }
            while(this.fountainParticles != null);
            
            throw new NullReferenceException();
        }
        public override void Show()
        {
            this.Show();
            this.StartParticlesForAnimation();
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.ShowPoolCaustics());
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
        public void StartParticlesForAnimation()
        {
            var val_2 = 0;
            do
            {
                if(val_2 >= this.fountainParticles.Length)
            {
                    return;
            }
            
                this.fountainParticles[val_2].Play();
                val_2 = val_2 + 1;
            }
            while(this.fountainParticles != null);
            
            throw new NullReferenceException();
        }
        private System.Collections.IEnumerator ShowPoolCaustics()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new Area24FillThePoolView.<ShowPoolCaustics>d__7();
        }
        private float GetAverageOfDeltaTimes(float[] lastFloats)
        {
            float val_3;
            int val_1 = lastFloats.Length & 4294967295;
            if((val_1 << 32) >= 1)
            {
                    var val_3 = 0;
                do
            {
                val_3 = val_3 + 1;
                val_3 = 0f + null;
            }
            while(val_3 < (long)val_1);
            
            }
            else
            {
                    val_3 = 0f;
            }
            
            val_3 = val_3 / (float)lastFloats.Length;
            return (float)val_3;
        }
        protected override string GetIdleSoundName()
        {
            return "area_1_fountain_idle";
        }
        protected override float GetIdleSoundVolume()
        {
            return 0.2f;
        }
        public Area24FillThePoolView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
