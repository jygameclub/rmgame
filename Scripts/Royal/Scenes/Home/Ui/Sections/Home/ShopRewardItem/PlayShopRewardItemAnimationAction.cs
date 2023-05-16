using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Home.ShopRewardItem
{
    public class PlayShopRewardItemAnimationAction : AnimationAction
    {
        // Fields
        private const float SingleItemAnimationTime = 0.99;
        private const float ItemCreationDelay = 0.15;
        private const float DefaultDuration = 0.5;
        protected float durationForNextAction;
        protected bool disableUiTouch;
        protected float rewardVerticalPositionOffset;
        
        // Methods
        protected override float GetDurationForNextAction()
        {
            return (float)this.durationForNextAction;
        }
        public override void Execute()
        {
            var val_16;
            Royal.Infrastructure.UiComponents.Touch.UiTouchDisabler val_18;
            float val_19;
            val_16 = this;
            val_18 = 1152921505020530688;
            bool val_4 = ((this.disableUiTouch == true) ? 1 : 0) | (Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).HasAutoActionInTheFlow);
            this.disableUiTouch = val_4;
            if(val_4 != true)
            {
                    if(Royal.Scenes.Home.Context.Units.Tutorial.HomeTutorialManager.WillShowTutorial() == false)
            {
                goto label_11;
            }
            
            }
            
            float val_16 = 0.15f;
            val_16 = ((float)Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg + 72 + 24) * val_16;
            val_19 = val_16 + 0.99f;
            goto label_12;
            label_11:
            val_19 = 0.5f;
            label_12:
             = val_19;
            if((val_16 + 28) != 0)
            {
                    Royal.Infrastructure.UiComponents.Touch.UiTouchListener val_7 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
                val_18 = val_7.disabler;
                val_18.DisableTouch();
            }
            
            Execute();
            UnityEngine.Coroutine val_15 = Royal.Scenes.Home.Context.HomeContext.ManualStartCoroutine(iEnumerator:  CreationCoroutine(animationData:  null));
        }
        private System.Collections.IEnumerator CreationCoroutine(Royal.Player.Context.Data.Session.AnimationData animationData)
        {
            .<>1__state = 0;
            .animationData = animationData;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new PlayShopRewardItemAnimationAction.<CreationCoroutine>d__8();
        }
        protected virtual Royal.Scenes.Home.Ui.Sections.Home.ShopRewardItem.ShopRewardItemView CreateItem(Royal.Scenes.Game.Mechanics.Boosters.BoosterType boosterType, UnityEngine.Vector2 offset, int boosterCount, int count, int delayCount)
        {
            Royal.Scenes.Home.Ui.Sections.Home.ShopRewardItem.ShopRewardItemView val_2 = UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Sections.Home.ShopRewardItem.ShopRewardItemView>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Sections.Home.ShopRewardItem.ShopRewardItemView>(path:  "ShopRewardItem"));
            val_2.Play(boosterType:  boosterType, offset:  new UnityEngine.Vector2() {x = offset.x, y = offset.y}, boosterCount:  boosterCount, count:  count, delayCount:  delayCount);
            return val_2;
        }
        private void CreateUnlimitedItem(Royal.Scenes.Game.Mechanics.Boosters.BoosterType boosterType, UnityEngine.Vector2 offset, int minutes, int count, int delayCount)
        {
            string val_5;
            UnityEngine.Object val_6;
            if(boosterType == 3)
            {
                goto label_1;
            }
            
            if(boosterType == 2)
            {
                goto label_2;
            }
            
            if(boosterType != 1)
            {
                goto label_3;
            }
            
            val_5 = "ShopUnlimitedRocketReward";
            goto label_5;
            label_2:
            val_5 = "ShopUnlimitedTntReward";
            goto label_5;
            label_1:
            val_5 = "ShopUnlimitedLightballReward";
            label_5:
            val_6 = UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Sections.Home.ShopRewardItem.ShopUnlimitedBoosterItemView>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Sections.Home.ShopRewardItem.ShopUnlimitedBoosterItemView>(path:  val_5));
            goto label_8;
            label_3:
            val_6 = 0;
            label_8:
            if(val_6 == 0)
            {
                    object[] val_4 = new object[1];
                val_4[0] = boosterType;
                Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  5, log:  "Item is missing! {0}", values:  val_4);
                return;
            }
            
            val_6.Play(offset:  new UnityEngine.Vector2() {x = offset.x, y = offset.y}, minutes:  minutes, count:  count, delayCount:  delayCount);
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
            goto typeof(Royal.Scenes.Home.Ui.Sections.Home.ShopRewardItem.PlayShopRewardItemAnimationAction).__il2cppRuntimeField_1B0;
        }
        private UnityEngine.Vector2 GetOffsetForCount(int count)
        {
            if(count <= 6)
            {
                    var val_9 = 36597708 + (count) << 2;
                val_9 = val_9 + 36597708;
            }
            else
            {
                    UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
                return new UnityEngine.Vector2() {x = val_8.x, y = val_8.y};
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
        public PlayShopRewardItemAnimationAction()
        {
        
        }
    
    }

}
