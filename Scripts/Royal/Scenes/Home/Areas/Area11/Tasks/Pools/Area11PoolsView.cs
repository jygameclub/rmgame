using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area11.Tasks.Pools
{
    public class Area11PoolsView : AreaTaskViewAnimation
    {
        // Fields
        public UnityEngine.ParticleSystem leftParticles;
        public UnityEngine.ParticleSystem rightParticles;
        public UnityEngine.SpriteRenderer[] poolCaustics;
        
        // Methods
        public override void PrepareAnimation()
        {
            this.PrepareAnimation();
            this.leftParticles.Stop();
            this.rightParticles.Stop();
        }
        public override void Show()
        {
            this.Show();
            this.StartParticlesForAnimation();
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.ShowOceanCaustics());
        }
        public override void HideAll()
        {
            if(val_1.Length >= 1)
            {
                    var val_3 = 0;
                do
            {
                this.GetComponentsInChildren<Royal.Scenes.Home.Areas.Area09.Idles.DistortionAnimation>()[val_3].StopDistortion();
                val_3 = val_3 + 1;
            }
            while(val_3 < val_1.Length);
            
            }
            
            this.HideAll();
        }
        public void StartParticlesForAnimation()
        {
            this.leftParticles.Play();
            this.rightParticles.Play();
        }
        private System.Collections.IEnumerator ShowOceanCaustics()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new Area11PoolsView.<ShowOceanCaustics>d__7();
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
        public Area11PoolsView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
