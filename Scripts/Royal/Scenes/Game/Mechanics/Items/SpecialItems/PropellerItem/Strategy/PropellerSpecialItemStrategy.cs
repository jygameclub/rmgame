using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.Strategy
{
    public abstract class PropellerSpecialItemStrategy : PropellerDefaultStrategy
    {
        // Fields
        protected readonly Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemModel specialItem;
        private readonly bool isRightToLeft;
        private readonly bool isFromPropeller;
        private Royal.Scenes.Game.Levels.Units.State.GameStateManager gameStateManager;
        
        // Methods
        protected PropellerSpecialItemStrategy(Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemModel specialItemModel, bool isRightToLeft, bool isFromPropeller)
        {
            this.specialItem = specialItemModel;
            this.isRightToLeft = isRightToLeft;
            this.isFromPropeller = isFromPropeller;
            this.gameStateManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14);
        }
        public override void OnTargetFound()
        {
            if(this.gameStateManager != null)
            {
                    this.gameStateManager.OperationStart(animationId:  9);
                return;
            }
            
            throw new NullReferenceException();
        }
        public override void OnTargetCancelled()
        {
            if(this.gameStateManager != null)
            {
                    this.gameStateManager.OperationFinish(animationId:  9);
                return;
            }
            
            throw new NullReferenceException();
        }
        public override void OnTargetReached(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, Royal.Scenes.Game.Mechanics.Explode.ExplodeData exploder)
        {
            int val_2;
            int val_3;
            Royal.Scenes.Game.Mechanics.Explode.ExplodeData val_1 = this.NextExploder(cell:  cell);
            exploder.id = val_2;
            exploder.point.x = val_3;
            UnityEngine.Coroutine val_5 = Royal.Scenes.Game.Context.GameContext.ManualStartCoroutine(iEnumerator:  this.FinishOperationWithDelay(dur:  0.5f));
        }
        protected System.Collections.IEnumerator FinishOperationWithDelay(float dur)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .dur = dur;
            return (System.Collections.IEnumerator)new PropellerSpecialItemStrategy.<FinishOperationWithDelay>d__8();
        }
        public override Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerPilot.IPropellerPilot GetNewPilot()
        {
            return (Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerPilot.IPropellerPilot)new Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerPilot.PropellerSpecialComboPilot(otherItem:  this.specialItem, isRightToLeft:  this.isRightToLeft, isFromPropeller:  this.isFromPropeller);
        }
    
    }

}
