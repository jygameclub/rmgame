using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.DrillItem.Strategy
{
    public class VerticalDrillStrategy : DrillStrategy
    {
        // Methods
        public VerticalDrillStrategy(Royal.Scenes.Game.Mechanics.Items.DrillItem.View.DrillItemView view, Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory, Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillDirection direction)
        {
        
        }
        public override void Play(Royal.Scenes.Game.Mechanics.Explode.ExplodeData exploder, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, Royal.Scenes.Game.Mechanics.Matches.Cell14 cellsOnPath, Royal.Scenes.Game.Mechanics.Matches.Cell14 cellsOnDrill, Royal.Scenes.Game.Mechanics.Items.DrillItem.View.DrillTracerParticles particles)
        {
            Play(exploder:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = exploder.point.x}, id = exploder.id}, cell:  120, cellsOnPath:  new Royal.Scenes.Game.Mechanics.Matches.Cell14() {<Count>k__BackingField = cellsOnPath.<Count>k__BackingField, cell0 = cellsOnPath.cell0, cell1 = cellsOnPath.cell1, cell2 = cellsOnPath.cell2, cell3 = cellsOnPath.cell3, cell4 = cellsOnPath.cell4, cell5 = cellsOnPath.cell5, cell6 = cellsOnPath.cell6, cell7 = cellsOnPath.cell7, cell8 = cellsOnPath.cell8, cell9 = cellsOnPath.cell9, cell10 = cellsOnPath.cell10, cell11 = cellsOnPath.cell11, cell12 = cellsOnPath.cell12, cell13 = cellsOnPath.cell13}, cellsOnDrill:  new Royal.Scenes.Game.Mechanics.Matches.Cell14(), particles:  particles);
            UnityEngine.Coroutine val_2 = Royal.Scenes.Game.Context.GameContext.ManualStartCoroutine(iEnumerator:  this.PlayVerticalDrill(exploder:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = exploder.point.x}, id = exploder.id}, cellsOnPath:  new Royal.Scenes.Game.Mechanics.Matches.Cell14(), particles:  particles));
        }
        private System.Collections.IEnumerator PlayVerticalDrill(Royal.Scenes.Game.Mechanics.Explode.ExplodeData exploder, Royal.Scenes.Game.Mechanics.Matches.Cell14 cellsOnPath, Royal.Scenes.Game.Mechanics.Items.DrillItem.View.DrillTracerParticles particles)
        {
            .<>1__state = 0;
            .<>4__this = this;
            mem[1152921520367753976] = exploder.id;
            .exploder = exploder.point.x;
            .particles = particles;
            return (System.Collections.IEnumerator)new VerticalDrillStrategy.<PlayVerticalDrill>d__2();
        }
        private System.Collections.IEnumerator MoveToGlobalAndDestroy(Royal.Scenes.Game.Mechanics.Explode.ExplodeData exploder, UnityEngine.Transform trans, UnityEngine.Vector3 targetPosition, Royal.Scenes.Game.Mechanics.Matches.Cell14 cellList)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .trans = trans;
            .targetPosition = targetPosition;
            mem[1152921520368030400] = targetPosition.y;
            mem[1152921520368030404] = targetPosition.z;
            mem[1152921520368030392] = exploder.id;
            .exploder = exploder.point.x;
            return (System.Collections.IEnumerator)new VerticalDrillStrategy.<MoveToGlobalAndDestroy>d__3();
        }
        private bool ShouldCallExplode(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cellModel, UnityEngine.Vector3 currentPos)
        {
            if(W9 == 2)
            {
                    UnityEngine.Vector3 val_1 = UnityEngine.Vector3.up;
            }
            else
            {
                    UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            }
            
            UnityEngine.Vector3 val_3 = cellModel.GetViewPosition();
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = currentPos.x, y = currentPos.y, z = currentPos.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            return (bool)(System.Math.Abs(val_5.y) < 0) ? 1 : 0;
        }
    
    }

}
