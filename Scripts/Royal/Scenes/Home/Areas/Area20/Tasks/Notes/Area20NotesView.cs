using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area20.Tasks.Notes
{
    public class Area20NotesView : AreaTaskViewAnimation
    {
        // Fields
        public UnityEngine.ParticleSystem idleWaterParticles;
        
        // Methods
        protected override bool HasIdle()
        {
            return true;
        }
        protected override int GetCreationStateHash()
        {
            return UnityEngine.Animator.StringToHash(name:  "Base Layer.Area20NotesAnimation");
        }
        public void PlayIdleWaterParticles()
        {
            if(this.idleWaterParticles != null)
            {
                    this.idleWaterParticles.Play();
                return;
            }
            
            throw new NullReferenceException();
        }
        public Area20NotesView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
