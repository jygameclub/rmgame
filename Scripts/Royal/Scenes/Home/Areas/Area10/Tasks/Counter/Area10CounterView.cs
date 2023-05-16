using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area10.Tasks.Counter
{
    public class Area10CounterView : AreaTaskViewAnimation
    {
        // Methods
        protected override bool HasIdle()
        {
            return true;
        }
        protected override int GetCreationStateHash()
        {
            return UnityEngine.Animator.StringToHash(name:  "Base Layer.Area10CounterAppearAnimation");
        }
        public override bool ShouldPauseIdleWhileBuildingAnotherTask()
        {
            return true;
        }
        protected override bool CanPauseIdle()
        {
            float val_3;
            var val_5;
            UnityEngine.AnimatorStateInfo val_1 = this.GetCurrentAnimatorStateInfo(layerIndex:  0);
            if( != this)
            {
                    if(val_3 < 0)
            {
                goto label_2;
            }
            
            }
            
            val_5 = 0;
            return (bool)val_5;
            label_2:
            val_5 = 1;
            return (bool)val_5;
        }
        public Area10CounterView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
