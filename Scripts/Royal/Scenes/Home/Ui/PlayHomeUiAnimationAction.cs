using UnityEngine;

namespace Royal.Scenes.Home.Ui
{
    public class PlayHomeUiAnimationAction : AnimationAction
    {
        // Fields
        private readonly bool appear;
        
        // Properties
        public override int Type { get; }
        
        // Methods
        public override int get_Type()
        {
            return 1;
        }
        public PlayHomeUiAnimationAction(bool appear = True)
        {
            this.appear = appear;
        }
        protected override float GetDurationForNextAction()
        {
            return Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  18f);
        }
        public override void Execute()
        {
            var val_1;
            var val_2;
            this.Execute();
            if(this.appear != false)
            {
                    val_1 = null;
                val_1 = null;
                Royal.Scenes.Home.Context.HomeContext.<Controller>k__BackingField.PlayHomeUiAppearAnimation();
                return;
            }
            
            val_2 = null;
            val_2 = null;
            Royal.Scenes.Home.Context.HomeContext.<Controller>k__BackingField.PlayHomeUiHideAnimation();
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
        
        }
    
    }

}
