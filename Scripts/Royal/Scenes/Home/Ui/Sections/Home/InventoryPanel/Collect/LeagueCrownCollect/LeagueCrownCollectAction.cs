using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LeagueCrownCollect
{
    public class LeagueCrownCollectAction : AnimationAction
    {
        // Fields
        private const float Delay = 0.15;
        private float durationForNextAction;
        
        // Methods
        protected override float GetDurationForNextAction()
        {
            if(this.durationForNextAction <= 0f)
            {
                    return (float)val_2;
            }
            
            float val_2 = 0.15f;
            val_2 = ((float)Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LeagueCrownCollect.LeagueCrownCollectAction.GetMaximumCountForAnimation(count:  Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg + 16 + 24)) * val_2;
            val_2 = this.durationForNextAction + val_2;
            return (float)val_2;
        }
        public override void Execute()
        {
            this.durationForNextAction = UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LeagueCrownCollect.LeagueCrownCollectView>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LeagueCrownCollect.LeagueCrownCollectView>(path:  "LeagueCrownCollect")).Play(index:  0, amount:  0, xOffset:  0f, yOffset:  0f, playInitialParticle:  true, playFinalParticle:  ((Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg + 16 + 24) == 1) ? 1 : 0);
            Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg + 16.Consume();
            UnityEngine.Coroutine val_7 = Royal.Scenes.Home.Context.HomeContext.ManualStartCoroutine(iEnumerator:  Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LeagueCrownCollect.LeagueCrownCollectAction.CollectExtraCrowns(count:  (Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg + 16 + 24 - 1)>>0&0xFFFFFFFF));
            this.Execute();
        }
        private static System.Collections.IEnumerator CollectExtraCrowns(int count)
        {
            .<>1__state = 0;
            .count = count;
            return (System.Collections.IEnumerator)new LeagueCrownCollectAction.<CollectExtraCrowns>d__4();
        }
        private static int GetMaximumCountForAnimation(int count)
        {
            return UnityEngine.Mathf.Min(a:  10, b:  count);
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
            this.Complete();
        }
        public LeagueCrownCollectAction()
        {
        
        }
    
    }

}
