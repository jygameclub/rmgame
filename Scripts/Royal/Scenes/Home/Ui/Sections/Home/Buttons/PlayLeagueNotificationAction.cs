using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Home.Buttons
{
    public class PlayLeagueNotificationAction : AnimationAction
    {
        // Fields
        private readonly float delay;
        private readonly bool playAnimation;
        
        // Methods
        public PlayLeagueNotificationAction(bool playAnimation = True, float delay = 0)
        {
            var val_4;
            this.delay = delay;
            this.playAnimation = playAnimation;
            val_4 = null;
            val_4 = null;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_this_arg + 160 + 56.transform.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
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
            null = null;
            if((Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetBool(key:  "LeagueButtonClicked", defaultValue:  false)) == true)
            {
                    return;
            }
            
            Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_this_arg + 160 + 56.gameObject.SetActive(value:  true);
            if(this.playAnimation != false)
            {
                    UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
                UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  0.83f);
                DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_7 = DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_this_arg + 160 + 56, endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  0.2f), ease:  27), delay:  this.delay);
                return;
            }
            
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, d:  0.83f);
            Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_this_arg + 160 + 56.transform.localScale = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
        }
    
    }

}
