using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.TeamBattleCollect
{
    public class PlayTeamBattleCollectAnimation : AnimationAction
    {
        // Fields
        private bool isThereAnyIconAnimationAfterwards;
        
        // Methods
        protected override float GetDurationForNextAction()
        {
            var val_7 = this;
            if((Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).HasActionInFlow(actionType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
            {
                    return (float)(this.isThereAnyIconAnimationAfterwards == false) ? 1f : 0.25f;
            }
            
            float val_7 = 0.15f;
            val_7 = ((float)(Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.TeamBattleCollect.PlayTeamBattleCollectAnimation.GetMaximumCountForAnimation(count:  Royal.Player.Context.Data.Session.__il2cppRuntimeField_70 + 32 + 24)) - 1) * val_7;
            val_7 = val_7 + 1f;
            return (float)(this.isThereAnyIconAnimationAfterwards == false) ? 1f : 0.25f;
        }
        public override void Execute()
        {
            Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.TeamBattleCollect.TeamBattleCollectAnimation val_10;
            bool val_11;
            val_10 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.TeamBattleManager>(id:  9);
            Royal.Scenes.Home.Context.Units.HomeSceneFlow val_2 = Royal.Scenes.Home.Context.HomeContext.Get<Royal.Scenes.Home.Context.Units.HomeSceneFlow>(id:  2);
            val_11 = val_2.<ShouldDisableTouchesAfterWin>k__BackingField;
            this.DisableTouchesIfNecessary(disableTouches:  val_11);
            val_11 = 0;
            if(val_10.ShouldPlayShieldCollect() != false)
            {
                    val_10 = UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.TeamBattleCollect.TeamBattleCollectAnimation>(path:  "TeamBattleCollectAnimation");
                UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.TeamBattleCollect.TeamBattleCollectAnimation>(original:  val_10).Play(amount:  0, xOffset:  0f, yOffset:  0f, shouldPlayParticles:  ((Royal.Player.Context.Data.Session.__il2cppRuntimeField_70 + 32 + 24) == 1) ? 1 : 0);
                this.isThereAnyIconAnimationAfterwards = true;
                val_10 = Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.TeamBattleCollect.PlayTeamBattleCollectAnimation.CollectExtraShields(count:  (Royal.Player.Context.Data.Session.__il2cppRuntimeField_70 + 32 + 24 - 1)>>0&0xFFFFFFFF);
                UnityEngine.Coroutine val_9 = Royal.Scenes.Home.Context.HomeContext.ManualStartCoroutine(iEnumerator:  val_10);
                this.Execute();
            }
            else
            {
                    this.Complete();
            }
            
            Royal.Player.Context.Data.Session.__il2cppRuntimeField_70 + 32.Consume();
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
            this.Complete();
        }
        private static System.Collections.IEnumerator CollectExtraShields(int count)
        {
            .<>1__state = 0;
            .count = count;
            return (System.Collections.IEnumerator)new PlayTeamBattleCollectAnimation.<CollectExtraShields>d__4();
        }
        private static int GetMaximumCountForAnimation(int count)
        {
            return UnityEngine.Mathf.Min(a:  10, b:  count);
        }
        public PlayTeamBattleCollectAnimation()
        {
        
        }
    
    }

}
