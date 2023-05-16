using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area28.Tasks.BuildSandCastle
{
    public class Area28BuildSandCastleView : AreaTaskViewAnimation
    {
        // Fields
        public UnityEngine.Transform particleParent;
        public UnityEngine.Animator crabAnimator;
        
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
        public override void Show()
        {
            this.Show();
            this.crabAnimator.enabled = true;
        }
        public override void HideAll()
        {
            this.crabAnimator.enabled = false;
            this.HideAll();
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
            this.RemoveParticleFromList(parent:  this.particleParent);
        }
        private void DisableAllParticles()
        {
            this.RemoveParticleFromList(parent:  this.particleParent);
        }
        public override float GetAnimationDelay()
        {
            return 0f;
        }
        private void CreateParticles()
        {
            Royal.Scenes.Home.Areas.Scripts.AreaTaskAssets val_1 = this.AreaTaskAssets;
            UnityEngine.GameObject val_2 = val_1.particles[0].gameObject;
            val_2.CreateParticleForList(prefab:  val_2, parent:  this.particleParent);
        }
        private void CreateParticleForList(UnityEngine.GameObject prefab, UnityEngine.Transform parent)
        {
            UnityEngine.GameObject val_1 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  prefab, parent:  parent);
        }
        private void RemoveParticles()
        {
            this.RemoveParticleFromList(parent:  this.particleParent);
        }
        private void RemoveParticleFromList(UnityEngine.Transform parent)
        {
            UnityEngine.Object.Destroy(obj:  parent.GetChild(index:  0).gameObject);
        }
        public Area28BuildSandCastleView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
