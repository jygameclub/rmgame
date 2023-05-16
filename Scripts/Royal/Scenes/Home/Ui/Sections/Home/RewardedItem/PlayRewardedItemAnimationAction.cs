using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Home.RewardedItem
{
    public class PlayRewardedItemAnimationAction : AnimationAction
    {
        // Fields
        private const float ItemCreationDelay = 0.15;
        private const float DefaultDuration = 0.5;
        private readonly float singleItemAnimationTime;
        private float durationForNextAction;
        private bool disableUiTouch;
        private readonly bool forceDisableTouch;
        private readonly int <Type>k__BackingField;
        
        // Properties
        public override int Type { get; }
        
        // Methods
        public override int get_Type()
        {
            return (int)this.<Type>k__BackingField;
        }
        public PlayRewardedItemAnimationAction(int type, bool forceDisableTouch = False, float singleItemAnimationTime = 1.1)
        {
            this.<Type>k__BackingField = type;
            this.forceDisableTouch = forceDisableTouch;
            this.singleItemAnimationTime = singleItemAnimationTime;
        }
        protected override float GetDurationForNextAction()
        {
            return (float)this.durationForNextAction;
        }
        public override void Execute()
        {
            var val_18;
            Royal.Infrastructure.UiComponents.Touch.UiTouchDisabler val_20;
            float val_21;
            val_18 = this;
            this.disableUiTouch = this.forceDisableTouch;
            val_20 = 1152921505020530688;
            bool val_4 = ((this.forceDisableTouch == true) ? 1 : 0) | (Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).HasAutoActionInTheFlow);
            this.disableUiTouch = val_4;
            if(val_4 != true)
            {
                    if(Royal.Scenes.Home.Context.Units.Tutorial.HomeTutorialManager.WillShowTutorial() == false)
            {
                goto label_12;
            }
            
            }
            
            float val_18 = 0.15f;
            val_18 = ((float)(Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg + 80 + 24 + Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg + 72 + 24)) * val_18;
            val_21 = val_18 + this.singleItemAnimationTime;
            goto label_13;
            label_12:
            val_21 = 0.5f;
            label_13:
             = val_21;
            if((val_18 + 32) != 0)
            {
                    Royal.Infrastructure.UiComponents.Touch.UiTouchListener val_8 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
                val_20 = val_8.disabler;
                val_20.DisableTouch();
            }
            
            Execute();
            UnityEngine.Coroutine val_17 = Royal.Scenes.Home.Context.HomeContext.ManualStartCoroutine(iEnumerator:  CreationCoroutine(animationData:  null));
        }
        private System.Collections.IEnumerator CreationCoroutine(Royal.Player.Context.Data.Session.AnimationData animationData)
        {
            .<>1__state = 0;
            .animationData = animationData;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new PlayRewardedItemAnimationAction.<CreationCoroutine>d__12();
        }
        private void CreateItem(Royal.Scenes.Game.Mechanics.Boosters.BoosterType boosterType, UnityEngine.Vector2 offset, int count)
        {
            UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Sections.Home.RewardedItem.RewardedItemView>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Sections.Home.RewardedItem.RewardedItemView>(path:  "RewardedItem")).Play(boosterType:  boosterType, offset:  new UnityEngine.Vector2() {x = offset.x, y = offset.y}, count:  count);
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
            goto typeof(Royal.Scenes.Home.Ui.Sections.Home.RewardedItem.PlayRewardedItemAnimationAction).__il2cppRuntimeField_1B0;
        }
        private UnityEngine.Vector2 GetOffsetForCount(int count)
        {
            if(count <= 6)
            {
                    var val_4 = 36597648 + (count) << 2;
                val_4 = val_4 + 36597648;
            }
            else
            {
                    UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
                return new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
            }
        
        }
        public override void Complete()
        {
            if(this.disableUiTouch != false)
            {
                    Royal.Infrastructure.UiComponents.Touch.UiTouchListener val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
                val_1.disabler.EnableTouch();
            }
            
            this.Complete();
        }
    
    }

}
