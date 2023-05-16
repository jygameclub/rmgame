using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area20.Tasks.Fish
{
    public class Area20FishView : AreaTaskViewAnimation
    {
        // Methods
        protected override bool HasIdle()
        {
            return true;
        }
        protected override int GetCreationStateHash()
        {
            return UnityEngine.Animator.StringToHash(name:  "Base Layer.Area20FishAnimation");
        }
        public Area20FishView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
