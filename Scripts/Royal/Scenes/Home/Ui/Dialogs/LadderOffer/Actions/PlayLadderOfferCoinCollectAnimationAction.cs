using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.LadderOffer.Actions
{
    public class PlayLadderOfferCoinCollectAnimationAction : PlayCoinCollectAnimationAction
    {
        // Fields
        private readonly float delay;
        private readonly Royal.Player.Context.Data.Session.BeforeAfterData beforeAfterData;
        
        // Methods
        public PlayLadderOfferCoinCollectAnimationAction(float delay, Royal.Player.Context.Data.Session.BeforeAfterData beforeAfterData)
        {
            float val_1 = this.delay;
            this.beforeAfterData = beforeAfterData;
            val_1 = val_1 + delay;
            this.delay = val_1;
        }
        public override void Execute()
        {
            var val_14;
            mem[1152921519449446136] = 1075838976;
            if(this.beforeAfterData.shouldConsume != false)
            {
                    val_14 = null;
                val_14 = null;
                Royal.Scenes.Home.Ui.__il2cppRuntimeField_30.PrepareCoinTextForAnimation(beforeAfterData:  this.beforeAfterData);
                mem[1152921519449446140] = 1152921505056579584;
                bool val_4 = ((1152921505056579584 != 0) ? 1 : 0) | (Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).HasAutoActionInTheFlow);
                mem[1152921519449446140] = val_4;
                if(val_4 != false)
            {
                    UnityEngine.Debug.Log(message:  "Coin Collect Disable Touch: "("Coin Collect Disable Touch: ") + UnityEngine.Time.frameCount);
                Royal.Infrastructure.UiComponents.Touch.UiTouchListener val_8 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
                val_8.disabler.DisableTouch();
            }
            
                this.ExecuteBase();
                UnityEngine.Vector2 val_9 = UnityEngine.Vector2.down;
                UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y}, d:  3.65f);
                UnityEngine.Vector3 val_13 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y});
                UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.CoinCollect.CoinCollectAnimation>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.CoinCollect.CoinCollectAnimation>(path:  "CoinCollectAnimation")).Play(data:  this.beforeAfterData, startPosition:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
                return;
            }
            
            this.Complete();
        }
        protected override float GetDurationForNextAction()
        {
            return (float)S0 + this.delay;
        }
    
    }

}
