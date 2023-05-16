using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area01.Tasks.BuildCastle
{
    public class Area01BuildCastleView : AreaTaskViewAnimation
    {
        // Fields
        public Royal.Scenes.Home.Areas.Area09.Idles.DistortionAnimation[] poolDistortion;
        public UnityEngine.SpriteRenderer[] poolCaustics;
        private UnityEngine.Coroutine causticRoutine;
        public UnityEngine.Transform[] group1Parents;
        public Royal.Scenes.Home.Areas.Area01.Tasks.BuildCastle.Area01CastleFlags castleFlags;
        
        // Methods
        public void PlayRevealAnimations()
        {
            if(this.castleFlags != null)
            {
                    this.castleFlags.PlayRevealAnimations();
                return;
            }
            
            throw new NullReferenceException();
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
            if((val_8 - 4) >= this.poolDistortion.Length)
            {
                goto label_7;
            }
            
            this.poolDistortion[0].StopDistortion();
            this.poolDistortion[0].PlayDistortion();
            val_8 = val_8 + 1;
            if(this.poolDistortion != null)
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
            
            this.causticRoutine = this.StartCoroutine(routine:  this.ShowPoolCaustics());
        }
        private System.Collections.IEnumerator ShowPoolCaustics()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new Area01BuildCastleView.<ShowPoolCaustics>d__7();
        }
        public override void PrepareAnimation()
        {
            if(this.causticRoutine != null)
            {
                    this.StopCoroutine(routine:  this.causticRoutine);
                this.causticRoutine = 0;
            }
            
            var val_2 = 0;
            label_5:
            if(val_2 >= this.poolCaustics.Length)
            {
                goto label_2;
            }
            
            this.poolCaustics[val_2].color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            val_2 = val_2 + 1;
            if(this.poolCaustics != null)
            {
                goto label_5;
            }
            
            throw new NullReferenceException();
            label_2:
            this.PrepareAnimation();
            this.castleFlags.DisableFlags();
            if(this.poolCaustics != null)
            {
                    return;
            }
            
            this.CreateParticles();
        }
        public override void PrepareReplay()
        {
            this.CreateParticles();
        }
        private void InitForAnimation()
        {
            this.CreateParticles();
        }
        public override void EndAnimation()
        {
            this.EndAnimation();
            this.RemoveParticleFromList(parents:  this.group1Parents);
        }
        private void DisableAllParticles()
        {
            this.RemoveParticleFromList(parents:  this.group1Parents);
        }
        public override float GetAnimationDelay()
        {
            return 0f;
        }
        private void CreateParticles()
        {
            Royal.Scenes.Home.Areas.Scripts.AreaTaskAssets val_1 = this.AreaTaskAssets;
            UnityEngine.GameObject val_2 = val_1.particles[0].gameObject;
            val_2.CreateParticleForList(prefab:  val_2, parents:  this.group1Parents);
        }
        private void CreateParticleForList(UnityEngine.GameObject prefab, UnityEngine.Transform[] parents)
        {
            int val_2 = parents.Length;
            if(val_2 < 1)
            {
                    return;
            }
            
            var val_3 = 0;
            val_2 = val_2 & 4294967295;
            do
            {
                UnityEngine.GameObject val_1 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  prefab, parent:  1152921508158637376);
                val_3 = val_3 + 1;
            }
            while(val_3 < (parents.Length << ));
        
        }
        private void RemoveParticles()
        {
            this.RemoveParticleFromList(parents:  this.group1Parents);
        }
        private void RemoveParticleFromList(UnityEngine.Transform[] parents)
        {
            if(parents.Length < 1)
            {
                    return;
            }
            
            var val_4 = 0;
            do
            {
                UnityEngine.Object.Destroy(obj:  parents[val_4].GetChild(index:  0).gameObject);
                val_4 = val_4 + 1;
            }
            while(val_4 < parents.Length);
        
        }
        public Area01BuildCastleView()
        {
        
        }
    
    }

}
