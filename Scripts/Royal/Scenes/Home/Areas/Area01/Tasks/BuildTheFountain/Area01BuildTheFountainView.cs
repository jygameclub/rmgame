using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area01.Tasks.BuildTheFountain
{
    public class Area01BuildTheFountainView : AreaTaskViewAnimation
    {
        // Fields
        public Royal.Scenes.Home.Areas.Area09.Idles.DistortionAnimation[] distortionAnimations;
        public UnityEngine.SpriteRenderer[] poolCaustics;
        private UnityEngine.Coroutine causticRoutine;
        private UnityEngine.ParticleSystem fountainParticles;
        
        // Methods
        public override void PrepareAnimation()
        {
            if(this.causticRoutine != null)
            {
                    this.StopCoroutine(routine:  this.causticRoutine);
                this.causticRoutine = 0;
            }
            
            var val_3 = 0;
            label_6:
            if(val_3 >= this.poolCaustics.Length)
            {
                goto label_3;
            }
            
            this.poolCaustics[val_3].color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            val_3 = val_3 + 1;
            if(this.poolCaustics != null)
            {
                goto label_6;
            }
            
            throw new NullReferenceException();
            label_3:
            this.PrepareAnimation();
            if(this.poolCaustics == null)
            {
                    this.InitForAnimation();
            }
            
            if(this.fountainParticles == 0)
            {
                    return;
            }
            
            this.fountainParticles.Stop();
        }
        public override void PrepareReplay()
        {
            this.InitForAnimation();
        }
        private void InitForAnimation()
        {
            if(this.fountainParticles != 0)
            {
                    return;
            }
            
            this.CreateParticles();
        }
        private void CreateParticles()
        {
            Royal.Scenes.Home.Areas.Scripts.AreaTaskAssets val_1 = this.AreaTaskAssets;
            this.fountainParticles = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_1.particles[0].gameObject, parent:  this.transform).GetComponent<UnityEngine.ParticleSystem>();
        }
        public override void Show()
        {
            this.Show();
            var val_5 = 0;
            label_4:
            if(val_5 >= this.poolCaustics.Length)
            {
                goto label_1;
            }
            
            this.poolCaustics[val_5].color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            val_5 = val_5 + 1;
            if(this.poolCaustics != null)
            {
                goto label_4;
            }
            
            label_1:
            var val_8 = 4;
            label_13:
            if((val_8 - 4) >= this.distortionAnimations.Length)
            {
                goto label_7;
            }
            
            this.distortionAnimations[0].StopDistortion();
            this.distortionAnimations[0].PlayDistortion();
            val_8 = val_8 + 1;
            if(this.distortionAnimations != null)
            {
                goto label_13;
            }
            
            throw new NullReferenceException();
            label_7:
            if(this.causticRoutine != null)
            {
                    this.StopCoroutine(routine:  this.causticRoutine);
                this.causticRoutine = 0;
            }
            
            this.InitForAnimation();
            this.StartParticlesForAnimation();
            this.causticRoutine = this.StartCoroutine(routine:  this.ShowPoolCaustics());
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
            if(this.fountainParticles == 0)
            {
                    return;
            }
            
            this.fountainParticles.Play();
        }
        private System.Collections.IEnumerator ShowPoolCaustics()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new Area01BuildTheFountainView.<ShowPoolCaustics>d__11();
        }
        protected override string GetIdleSoundName()
        {
            return "area_1_fountain_idle";
        }
        protected override float GetIdleSoundVolume()
        {
            return 0.6f;
        }
        public Area01BuildTheFountainView()
        {
        
        }
    
    }

}
