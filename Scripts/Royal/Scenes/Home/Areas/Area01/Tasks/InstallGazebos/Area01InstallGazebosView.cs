using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area01.Tasks.InstallGazebos
{
    public class Area01InstallGazebosView : AreaTaskViewAnimation
    {
        // Fields
        public UnityEngine.Transform[] group1Parents;
        
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
        public Area01InstallGazebosView()
        {
        
        }
    
    }

}
