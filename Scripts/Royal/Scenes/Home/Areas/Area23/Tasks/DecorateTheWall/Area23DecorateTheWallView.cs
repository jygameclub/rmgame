using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area23.Tasks.DecorateTheWall
{
    public class Area23DecorateTheWallView : AreaTaskViewAnimation
    {
        // Fields
        private const string SPEED_PARAM = "speedParam";
        private UnityEngine.Coroutine idleCoroutine;
        
        // Methods
        protected override bool HasIdle()
        {
            return true;
        }
        protected override int GetCreationStateHash()
        {
            return UnityEngine.Animator.StringToHash(name:  "Base Layer.Area23DecorateTheWallAnimation");
        }
        public override bool ShouldPauseIdleWhileBuildingAnotherTask()
        {
            return false;
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
        public void TriggerIdleAnimation()
        {
            Play(stateNameHash:  UnityEngine.Animator.StringToHash(name:  "Second Layer.Area23RuloIdleAnimation"), layer:  1, normalizedTime:  0f);
            this.Accelerate();
        }
        public void Accelerate()
        {
            if(this.idleCoroutine != null)
            {
                    this.StopCoroutine(routine:  this.idleCoroutine);
                this.idleCoroutine = 0;
            }
            
            this.idleCoroutine = this.StartCoroutine(routine:  this.StartIdleAnim());
        }
        private System.Collections.IEnumerator StartIdleAnim()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new Area23DecorateTheWallView.<StartIdleAnim>d__8();
        }
        public override void Show()
        {
            this.Show();
            this.Accelerate();
        }
        public Area23DecorateTheWallView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
