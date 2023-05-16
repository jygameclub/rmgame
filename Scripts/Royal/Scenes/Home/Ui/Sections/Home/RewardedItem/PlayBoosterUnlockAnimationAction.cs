using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Home.RewardedItem
{
    public class PlayBoosterUnlockAnimationAction : AnimationAction
    {
        // Fields
        private const float ItemCreationDelay = 0.15;
        private Royal.Scenes.Game.Mechanics.Boosters.BoosterType boosterType;
        
        // Methods
        public PlayBoosterUnlockAnimationAction(Royal.Scenes.Game.Mechanics.Boosters.BoosterType boosterType)
        {
            this.boosterType = boosterType;
        }
        protected override float GetDurationForNextAction()
        {
            return 0.8f;
        }
        public override void Execute()
        {
            this.Execute();
            UnityEngine.Coroutine val_2 = Royal.Scenes.Home.Context.HomeContext.ManualStartCoroutine(iEnumerator:  this.CreationCoroutine());
        }
        private System.Collections.IEnumerator CreationCoroutine()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new PlayBoosterUnlockAnimationAction.<CreationCoroutine>d__5();
        }
        private void CreateItem(UnityEngine.Vector2 offset, int count)
        {
            UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Sections.Home.RewardedItem.RewardedItemView>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Sections.Home.RewardedItem.RewardedItemView>(path:  "RewardedItem")).Play(boosterType:  this.boosterType, offset:  new UnityEngine.Vector2() {x = offset.x, y = offset.y}, count:  count);
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
            this.Complete();
        }
        private UnityEngine.Vector2 GetOffsetForCount(int count)
        {
            float val_4;
            if(count == 2)
            {
                goto label_1;
            }
            
            if(count == 1)
            {
                goto label_2;
            }
            
            if(count != 0)
            {
                goto label_3;
            }
            
            val_4 = 2f;
            goto label_4;
            label_1:
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.one;
            return new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
            label_2:
            val_4 = 1f;
            label_4:
            UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  -1f, y:  val_4);
            return new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
            label_3:
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.zero;
            return new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
        }
    
    }

}
