using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Home.Buttons
{
    public class PlayNotificationAnimationAction : AnimationAction
    {
        // Fields
        private readonly float delay;
        private readonly UnityEngine.Transform tasksButtonNotification;
        
        // Properties
        public override int Type { get; }
        
        // Methods
        public override int get_Type()
        {
            return 1;
        }
        public PlayNotificationAnimationAction(float delay = 0.1)
        {
            null = null;
            this.tasksButtonNotification = Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_this_arg + 144;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_this_arg + 144.transform.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            this.delay = delay;
        }
        protected override float GetDurationForNextAction()
        {
            return 0f;
        }
        public override void Execute()
        {
            this.Execute();
            this.PlayTaskNotificationBadge();
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
        
        }
        private void PlayTaskNotificationBadge()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  0.83f);
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_5 = DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.tasksButtonNotification, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.2f), ease:  27), delay:  this.delay);
        }
    
    }

}
