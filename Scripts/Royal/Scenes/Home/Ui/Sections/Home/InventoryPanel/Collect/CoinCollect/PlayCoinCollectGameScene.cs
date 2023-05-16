using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.CoinCollect
{
    public class PlayCoinCollectGameScene : AnimationAction
    {
        // Fields
        private float durationForNextAction;
        private readonly Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.CoinInfoView coinInfoView;
        private System.Action onComplete;
        private UnityEngine.Vector3 targetPosition;
        
        // Methods
        public PlayCoinCollectGameScene(UnityEngine.Vector3 targetPosition, Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.CoinInfoView coinInfoView, System.Action onComplete)
        {
            this.targetPosition = targetPosition;
            mem[1152921519140532564] = targetPosition.y;
            mem[1152921519140532568] = targetPosition.z;
            this.coinInfoView = coinInfoView;
            this.onComplete = onComplete;
        }
        protected override float GetDurationForNextAction()
        {
            return (float)this.durationForNextAction;
        }
        public override void Execute()
        {
            this.durationForNextAction = 2.3f;
            this.Execute();
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.down;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y}, d:  3.65f);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
            UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.CoinCollect.CoinCollectAnimation>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.CoinCollect.CoinCollectAnimation>(path:  "CoinCollectAnimation")).Play(data:  Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg + 40, startPosition:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, targetPosition:  new UnityEngine.Vector3() {x = this.targetPosition}, infoView:  this.coinInfoView);
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
            goto typeof(Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.CoinCollect.PlayCoinCollectGameScene).__il2cppRuntimeField_1B0;
        }
        public override void Complete()
        {
            this.Complete();
            this.onComplete.Invoke();
        }
    
    }

}
