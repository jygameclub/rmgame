using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.KingsCupCollect
{
    public class PlayKingsCupCollectAnimationAction : AnimationAction
    {
        // Fields
        private bool isThereAnyIconAnimationAfterwards;
        
        // Methods
        public PlayKingsCupCollectAnimationAction()
        {
            this.isThereAnyIconAnimationAfterwards = Royal.Player.Context.Data.Session.__il2cppRuntimeField_70 + 32 + 16;
        }
        protected override float GetDurationForNextAction()
        {
            var val_6 = this;
            if(((Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).HasActionInFlow(actionType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != true) && (this.isThereAnyIconAnimationAfterwards != false))
            {
                    return (float)val_6;
            }
            
            float val_6 = 0.15f;
            val_6 = ((float)(Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.KingsCupCollect.PlayKingsCupCollectAnimationAction.GetMaximumCountForAnimation(count:  Royal.Player.Context.Data.Session.__il2cppRuntimeField_70 + 24 + 24)) - 1) * val_6;
            val_6 = val_6 + 1f;
            return (float)val_6;
        }
        public override void Execute()
        {
            bool val_10;
            Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.KingsCupCollect.KingsCupCollectAnimation val_11;
            Royal.Scenes.Home.Context.Units.HomeSceneFlow val_1 = Royal.Scenes.Home.Context.HomeContext.Get<Royal.Scenes.Home.Context.Units.HomeSceneFlow>(id:  2);
            val_10 = val_1.<ShouldDisableTouchesAfterWin>k__BackingField;
            this.DisableTouchesIfNecessary(disableTouches:  val_10);
            val_10 = 0;
            if((Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.KingsCupManager>(id:  7).IsRemainingTimeFinished) != false)
            {
                    this.Complete();
            }
            else
            {
                    val_11 = UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.KingsCupCollect.KingsCupCollectAnimation>(path:  "KingsCupCollectAnimation");
                UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.KingsCupCollect.KingsCupCollectAnimation>(original:  val_11).Play(amount:  0, xOffset:  0f, yOffset:  0f, shouldPlayParticles:  ((Royal.Player.Context.Data.Session.__il2cppRuntimeField_70 + 24 + 24) == 1) ? 1 : 0);
                this.isThereAnyIconAnimationAfterwards = true;
                val_11 = Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.KingsCupCollect.PlayKingsCupCollectAnimationAction.CollectExtraCups(count:  (Royal.Player.Context.Data.Session.__il2cppRuntimeField_70 + 24 + 24 - 1)>>0&0xFFFFFFFF);
                UnityEngine.Coroutine val_9 = Royal.Scenes.Home.Context.HomeContext.ManualStartCoroutine(iEnumerator:  val_11);
                this.Execute();
            }
            
            Royal.Player.Context.Data.Session.__il2cppRuntimeField_70 + 24.Consume();
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
            this.Complete();
        }
        private static System.Collections.IEnumerator CollectExtraCups(int count)
        {
            .<>1__state = 0;
            .count = count;
            return (System.Collections.IEnumerator)new PlayKingsCupCollectAnimationAction.<CollectExtraCups>d__5();
        }
        private static int GetMaximumCountForAnimation(int count)
        {
            return UnityEngine.Mathf.Min(a:  10, b:  count);
        }
    
    }

}
