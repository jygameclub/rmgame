using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area01.Tasks.PlantTheFlowers
{
    public class Area01PlantTheFlowersView : AreaTaskViewAnimation
    {
        // Fields
        public UnityEngine.Transform[] group1Parents;
        public UnityEngine.Transform[] group2Parents;
        
        // Methods
        public override void PrepareAnimation()
        {
            this.PrepareAnimation();
            if(W8 != 0)
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
            this.RemoveParticleFromList(parents:  this.group2Parents);
        }
        private void DisableAllParticles()
        {
            this.RemoveParticleFromList(parents:  this.group1Parents);
            this.RemoveParticleFromList(parents:  this.group2Parents);
        }
        public override float GetAnimationDelay()
        {
            return 0f;
        }
        private void CreateParticles()
        {
            Royal.Scenes.Home.Areas.Scripts.AreaTaskAssets val_1 = this.AreaTaskAssets;
            Royal.Scenes.Home.Areas.Scripts.AreaTaskAssets val_2 = this.AreaTaskAssets;
            UnityEngine.GameObject val_3 = val_1.particles[0].gameObject;
            val_3.CreateParticleForList(prefab:  val_3, parents:  this.group1Parents);
            UnityEngine.GameObject val_4 = val_2.particles[1].gameObject;
            val_4.CreateParticleForList(prefab:  val_4, parents:  this.group2Parents);
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
            this.RemoveParticleFromList(parents:  this.group2Parents);
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
        public Area01PlantTheFlowersView()
        {
        
        }
    
    }

}
