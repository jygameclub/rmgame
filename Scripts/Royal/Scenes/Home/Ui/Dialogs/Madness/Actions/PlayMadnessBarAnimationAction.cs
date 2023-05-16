using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Madness.Actions
{
    public class PlayMadnessBarAnimationAction : AMadnessFlowAction
    {
        // Fields
        private readonly int start;
        private readonly int end;
        private readonly int target;
        private float completeDelay;
        
        // Methods
        public PlayMadnessBarAnimationAction(int eventId, int start, int end, int target)
        {
            this.start = start;
            this.end = UnityEngine.Mathf.Min(a:  end, b:  target);
            this.target = target;
        }
        public override bool SupportsMultiple()
        {
            return true;
        }
        public override void Execute()
        {
            object val_18;
            var val_19;
            var val_20;
            int val_21;
            int val_22;
            int val_23;
            int val_24;
            int val_25;
            System.Action val_26;
            var val_27;
            var val_28;
            val_18 = this;
            if(this.ShouldPlayAnimation() == false)
            {
                goto label_1;
            }
            
            if((this.DisableTouchesIfNecessary(force:  false)) == false)
            {
                goto label_2;
            }
            
            label_19:
            val_19 = null;
            val_19 = null;
            val_20 = mem[Royal.Scenes.Home.Ui.__il2cppRuntimeField_50 + 24];
            val_20 = Royal.Scenes.Home.Ui.__il2cppRuntimeField_50 + 24;
            val_21 = this.start;
            val_22 = this.target;
            val_23 = val_21;
            val_24 = this.end;
            val_25 = val_22;
            val_26 = new System.Action(object:  this, method:  typeof(Royal.Scenes.Home.Ui.Dialogs.Madness.Actions.PlayMadnessBarAnimationAction).__il2cppRuntimeField_1B8);
            goto label_14;
            label_1:
            val_18 = ???;
            val_22 = ???;
            goto typeof(Royal.Scenes.Home.Ui.Dialogs.Madness.Actions.PlayMadnessBarAnimationAction).__il2cppRuntimeField_1B0;
            label_2:
            val_27 = 0;
            if((Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).HasAutoActionInTheFlow) == false)
            {
                goto label_18;
            }
            
            val_27 = 1;
            if((val_18.DisableTouchesIfNecessary(force:  true)) == true)
            {
                goto label_19;
            }
            
            label_18:
            val_18 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  10f);
            val_28 = null;
            val_28 = null;
            val_20 = mem[Royal.Scenes.Home.Ui.__il2cppRuntimeField_50 + 24];
            val_20 = Royal.Scenes.Home.Ui.__il2cppRuntimeField_50 + 24;
            val_24 = mem[val_18 + 52];
            val_24 = val_18 + 52;
            val_25 = mem[val_18 + 52 + 4];
            val_25 = val_18 + 52 + 4;
            val_23 = mem[val_18 + 48];
            val_23 = val_18 + 48;
            val_26 = 0;
            label_14:
            UnityEngine.Coroutine val_17 = val_20.StartCoroutine(routine:  val_20.ProgressBarCoroutine(start:  val_23, end:  val_24, target:  val_25, onComplete:  val_26));
        }
        public override void Complete()
        {
            UnityEngine.Coroutine val_2 = Royal.Scenes.Home.Context.HomeContext.ManualStartCoroutine(iEnumerator:  this.CompleteAfterDelay());
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
        
        }
        private System.Collections.IEnumerator CompleteAfterDelay()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new PlayMadnessBarAnimationAction.<CompleteAfterDelay>d__9();
        }
        private void <>n__0()
        {
            this.Complete();
        }
    
    }

}
