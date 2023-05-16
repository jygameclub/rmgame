using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.Strategy
{
    public class PropellerRocketStrategy : PropellerSpecialItemStrategy
    {
        // Methods
        public PropellerRocketStrategy(Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemModel specialItemModel, bool isRightToLeft, bool isFromPropeller)
        {
            bool val_1 = isRightToLeft;
            bool val_2 = isFromPropeller;
        }
        public override void OnTargetReached(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, Royal.Scenes.Game.Mechanics.Explode.ExplodeData exploder)
        {
            UnityEngine.Coroutine val_2 = Royal.Scenes.Game.Context.GameContext.ManualStartCoroutine(iEnumerator:  this.FinishOperationWithDelay(dur:  0.5f));
            UnityEngine.Coroutine val_4 = Royal.Scenes.Game.Context.GameContext.ManualStartCoroutine(iEnumerator:  this.ExplodeWithDelay(cell:  cell, exploder:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = exploder.point.x}, id = exploder.id}));
            Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14).StartSpecialOperation();
        }
        private System.Collections.IEnumerator ExplodeWithDelay(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, Royal.Scenes.Game.Mechanics.Explode.ExplodeData exploder)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .cell = cell;
            mem[1152921520118087432] = exploder.id;
            .exploder = exploder.point.x;
            return (System.Collections.IEnumerator)new PropellerRocketStrategy.<ExplodeWithDelay>d__2();
        }
        public override Royal.Scenes.Game.Mechanics.Explode.ExplodeData NextExploder(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            return Royal.Scenes.Game.Mechanics.Explode.Exploder.Next(trigger:  (0 == 0) ? (10 + 1) : 10, point:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = 483545088, y = 268435456});
        }
        public override bool IsTntOrRocketCombo()
        {
            return true;
        }
    
    }

}
