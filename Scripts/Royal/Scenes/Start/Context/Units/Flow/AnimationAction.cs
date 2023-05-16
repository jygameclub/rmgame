using UnityEngine;

namespace Royal.Scenes.Start.Context.Units.Flow
{
    public abstract class AnimationAction : FlowAction
    {
        // Methods
        protected abstract float GetDurationForNextAction(); // 0
        public override void Execute()
        {
            var val_7;
            var val_8;
            val_7 = null;
            val_7 = null;
            if((Royal.Scenes.Home.Context.HomeContext.<Controller>k__BackingField) != 0)
            {
                    UnityEngine.Coroutine val_3 = Royal.Scenes.Home.Context.HomeContext.ManualStartCoroutine(iEnumerator:  this.CompleteAfterDelay());
                return;
            }
            
            val_8 = null;
            val_8 = null;
            if((Royal.Scenes.Game.Context.GameContext.<Controller>k__BackingField) != 0)
            {
                    UnityEngine.Coroutine val_6 = Royal.Scenes.Game.Context.GameContext.ManualStartCoroutine(iEnumerator:  this.CompleteAfterDelay());
            }
        
        }
        protected System.Collections.IEnumerator CompleteAfterDelay()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new AnimationAction.<CompleteAfterDelay>d__2();
        }
        protected void DisableTouchesIfNecessary(bool disableTouches)
        {
            if(disableTouches == false)
            {
                    return;
            }
            
            .touchListener = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            this.add_OnComplete(value:  new System.Action(object:  new AnimationAction.<>c__DisplayClass3_0(), method:  System.Void AnimationAction.<>c__DisplayClass3_0::<DisableTouchesIfNecessary>b__0()));
        }
        protected AnimationAction()
        {
            val_1 = new System.Object();
        }
    
    }

}
