using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Actions
{
    public class PlayRoyalPassCollectAnimation : AnimationAction
    {
        // Fields
        private Royal.Player.Context.Units.RoyalPassManager royalPassManager;
        private Royal.Infrastructure.UiComponents.Touch.UiTouchListener touchListener;
        private Royal.Player.Context.Data.Session.RoyalPassLevelData royalPass;
        private int collectedAmount;
        private bool isThereAnyIconAnimationAfterwards;
        
        // Methods
        public PlayRoyalPassCollectAnimation()
        {
            bool val_2;
            this.royalPassManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.RoyalPassManager>(id:  12);
            this.royalPass = Royal.Player.Context.Data.Session.__il2cppRuntimeField_70 + 64;
            this.collectedAmount = (Royal.Player.Context.Data.Session.__il2cppRuntimeField_70 + 64 + 20 + 4 - Royal.Player.Context.Data.Session.__il2cppRuntimeField_70 + 64 + 20);
            val_2 = 1;
            this.isThereAnyIconAnimationAfterwards = ;
        }
        protected override float GetDurationForNextAction()
        {
            if(((Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).HasActionInFlow(actionType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != true) && (this.isThereAnyIconAnimationAfterwards != false))
            {
                    return (float)val_6;
            }
            
            float val_6 = 0.15f;
            val_6 = ((float)(Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Actions.PlayRoyalPassCollectAnimation.GetMaximumCountForAnimation(count:  this.collectedAmount)) - 1) * val_6;
            val_6 = val_6 + 2f;
            return (float)val_6;
        }
        public override void Execute()
        {
            System.Delegate val_12;
            if((this.royalPassManager.IsEventActive == false) || (this.royalPass == null))
            {
                goto label_4;
            }
            
            val_12 = 1152921505056579584;
            Royal.Scenes.Home.Context.Units.HomeSceneFlow val_2 = Royal.Scenes.Home.Context.HomeContext.Get<Royal.Scenes.Home.Context.Units.HomeSceneFlow>(id:  2);
            this.DisableTouchesIfNecessary(disableTouches:  val_2.<ShouldDisableTouchesAfterWin>k__BackingField);
            Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.RoyalPassCollect.RoyalPassCollectAnimation val_4 = UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.RoyalPassCollect.RoyalPassCollectAnimation>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.RoyalPassCollect.RoyalPassCollectAnimation>(path:  "RoyalPassCollectAnimation"));
            if(this.collectedAmount < 2)
            {
                goto label_11;
            }
            
            DG.Tweening.Sequence val_5 = val_4.Play(amount:  0, xOffset:  0f, yOffset:  0f, shouldPlayParticles:  false);
            UnityEngine.Coroutine val_8 = Royal.Scenes.Home.Context.HomeContext.ManualStartCoroutine(iEnumerator:  this.CollectExtraKeys(count:  this.collectedAmount - 1));
            goto label_14;
            label_4:
            this.Complete();
            return;
            label_11:
            System.Delegate val_11 = System.Delegate.Combine(a:  val_12, b:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Actions.PlayRoyalPassCollectAnimation::AnimateIcon()));
            if(val_11 != null)
            {
                    if(null != null)
            {
                goto label_17;
            }
            
            }
            
            val_4.Play(amount:  0, xOffset:  0f, yOffset:  0f, shouldPlayParticles:  true) = val_11;
            label_14:
            this.Execute();
            return;
            label_17:
        }
        private void AnimateIcon()
        {
            var val_8;
            var val_9;
            int val_2 = this.royalPassManager.GetTargetForProgressBar();
            val_8 = this.royalPassManager.GetCountForProgressBar();
            val_9 = null;
            val_9 = null;
            Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_byval_arg + 80.AnimateProgress(start:  this.royalPassManager.GetProgressBarStartValue(royalPassData:  this.royalPass), end:  ((this.royalPassManager.GetSafeKeyStage(key:  0)) > (this.royalPassManager.GetSafeKeyStage(key:  0))) ? (val_2) : (val_8), target:  val_2, onComplete:  0);
        }
        private System.Collections.IEnumerator CollectExtraKeys(int count)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .count = count;
            return (System.Collections.IEnumerator)new PlayRoyalPassCollectAnimation.<CollectExtraKeys>d__9();
        }
        private static int GetMaximumCountForAnimation(int count)
        {
            return UnityEngine.Mathf.Min(a:  10, b:  count);
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
            UnityEngine.Debug.Log(message:  "Cancel RP collect");
            this.Complete();
        }
    
    }

}
