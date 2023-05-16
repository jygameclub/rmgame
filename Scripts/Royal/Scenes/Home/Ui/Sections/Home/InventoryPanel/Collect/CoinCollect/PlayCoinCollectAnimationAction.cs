using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.CoinCollect
{
    public class PlayCoinCollectAnimationAction : AnimationAction
    {
        // Fields
        protected float durationForNextAction;
        protected bool disableUiTouch;
        protected readonly bool forceDisableTouch;
        private bool shouldMadnessConsume;
        private readonly int <Type>k__BackingField;
        
        // Properties
        public override int Type { get; }
        
        // Methods
        public override int get_Type()
        {
            return (int)this.<Type>k__BackingField;
        }
        public PlayCoinCollectAnimationAction(int type = 0, bool forceDisableTouch = False)
        {
            this.<Type>k__BackingField = type;
            this.forceDisableTouch = forceDisableTouch;
            this.shouldMadnessConsume = Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg + 56 + 16;
        }
        protected override float GetDurationForNextAction()
        {
            return (float)this.durationForNextAction;
        }
        public override void Execute()
        {
            var val_15;
            float val_16;
            val_15 = this;
            if(this.shouldMadnessConsume != false)
            {
                    val_16 = 2.5f;
            }
            
            this.durationForNextAction = ((Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg + 48 + 16) == 0) ? 1.5f : 2.5f;
            this.disableUiTouch = this.forceDisableTouch;
            bool val_5 = ((this.forceDisableTouch == true) ? 1 : 0) | (Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).HasAutoActionInTheFlow);
            this.disableUiTouch = val_5;
            if(val_5 != false)
            {
                    UnityEngine.Debug.Log(message:  "Coin Collect Disable Touch: "("Coin Collect Disable Touch: ") + UnityEngine.Time.frameCount);
                Royal.Infrastructure.UiComponents.Touch.UiTouchListener val_9 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
                val_9.disabler.DisableTouch();
            }
            
            this.Execute();
            UnityEngine.Vector2 val_10 = UnityEngine.Vector2.down;
            UnityEngine.Vector2 val_11 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y}, d:  3.65f);
            UnityEngine.Vector3 val_14 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y});
            UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.CoinCollect.CoinCollectAnimation>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.CoinCollect.CoinCollectAnimation>(path:  "CoinCollectAnimation")).Play(data:  Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg + 40, startPosition:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
        }
        protected void ExecuteBase()
        {
            this.Execute();
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
            goto typeof(Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.CoinCollect.PlayCoinCollectAnimationAction).__il2cppRuntimeField_1B0;
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
