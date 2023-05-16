using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area05.Tasks.Statues
{
    public class Area05SingleStatueView : MonoBehaviour
    {
        // Fields
        private static readonly int Area05SingleStatueRevealAnimation;
        public UnityEngine.Animator animator;
        
        // Methods
        private void Awake()
        {
            if(this.animator != null)
            {
                    this.animator.enabled = false;
                return;
            }
            
            throw new NullReferenceException();
        }
        public void PlayAnimation()
        {
            this.animator.enabled = true;
            this.animator.Play(stateNameHash:  Royal.Scenes.Home.Areas.Area05.Tasks.Statues.Area05SingleStatueView.Area05SingleStatueRevealAnimation, layer:  0, normalizedTime:  0f);
        }
        private void OnDisable()
        {
            if(this.animator != null)
            {
                    this.animator.enabled = false;
                return;
            }
            
            throw new NullReferenceException();
        }
        public Area05SingleStatueView()
        {
        
        }
        private static Area05SingleStatueView()
        {
            Royal.Scenes.Home.Areas.Area05.Tasks.Statues.Area05SingleStatueView.Area05SingleStatueRevealAnimation = UnityEngine.Animator.StringToHash(name:  "Base Layer.Area05SingleStatueRevealAnimation");
        }
    
    }

}
