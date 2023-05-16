using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.DrillItem.Strategy
{
    public class HorizontalDrillStrategy : DrillStrategy
    {
        // Fields
        private readonly System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> explodedCells;
        
        // Methods
        public HorizontalDrillStrategy(Royal.Scenes.Game.Mechanics.Items.DrillItem.View.DrillItemView view, Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory, Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillDirection direction)
        {
            this.explodedCells = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel>(capacity:  10);
        }
        public override void Play(Royal.Scenes.Game.Mechanics.Explode.ExplodeData exploder, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, Royal.Scenes.Game.Mechanics.Matches.Cell14 cellsOnPath, Royal.Scenes.Game.Mechanics.Matches.Cell14 cellsOnDrill, Royal.Scenes.Game.Mechanics.Items.DrillItem.View.DrillTracerParticles particles)
        {
            Play(exploder:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = exploder.point.x}, id = exploder.id}, cell:  120, cellsOnPath:  new Royal.Scenes.Game.Mechanics.Matches.Cell14() {<Count>k__BackingField = cellsOnPath.<Count>k__BackingField, cell0 = cellsOnPath.cell0, cell1 = cellsOnPath.cell1, cell2 = cellsOnPath.cell2, cell3 = cellsOnPath.cell3, cell4 = cellsOnPath.cell4, cell5 = cellsOnPath.cell5, cell6 = cellsOnPath.cell6, cell7 = cellsOnPath.cell7, cell8 = cellsOnPath.cell8, cell9 = cellsOnPath.cell9, cell10 = cellsOnPath.cell10, cell11 = cellsOnPath.cell11, cell12 = cellsOnPath.cell12, cell13 = cellsOnPath.cell13}, cellsOnDrill:  new Royal.Scenes.Game.Mechanics.Matches.Cell14(), particles:  particles);
            UnityEngine.Coroutine val_2 = Royal.Scenes.Game.Context.GameContext.ManualStartCoroutine(iEnumerator:  this.PlayHorizontalDrill(exploder:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = exploder.point.x}, id = exploder.id}, cell:  cell, list:  new Royal.Scenes.Game.Mechanics.Matches.Cell14(), particles:  particles));
        }
        private System.Collections.IEnumerator PlayHorizontalDrill(Royal.Scenes.Game.Mechanics.Explode.ExplodeData exploder, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, Royal.Scenes.Game.Mechanics.Matches.Cell14 list, Royal.Scenes.Game.Mechanics.Items.DrillItem.View.DrillTracerParticles particles)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .cell = cell;
            mem[1152921520364830520] = exploder.id;
            .exploder = exploder.point.x;
            .particles = particles;
            return (System.Collections.IEnumerator)new HorizontalDrillStrategy.<PlayHorizontalDrill>d__3();
        }
        private System.Collections.IEnumerator MoveToGlobalAndDestroy(Royal.Scenes.Game.Mechanics.Explode.ExplodeData exploder, UnityEngine.Transform trans, UnityEngine.Vector3 targetPosition, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel drillCell, Royal.Scenes.Game.Mechanics.Matches.Cell14 cellOnPath)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .drillCell = drillCell;
            .trans = trans;
            .targetPosition = targetPosition;
            mem[1152921520365115208] = targetPosition.y;
            mem[1152921520365115212] = targetPosition.z;
            mem[1152921520365115200] = exploder.id;
            .exploder = exploder.point.x;
            return (System.Collections.IEnumerator)new HorizontalDrillStrategy.<MoveToGlobalAndDestroy>d__4();
        }
        private void UnfreezeAll()
        {
            bool val_1 = true;
            var val_2 = 0;
            do
            {
                if(val_2 >= val_1)
            {
                    return;
            }
            
                if(val_1 <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_1 = val_1 + 0;
                (true + 0) + 32.UnFreezeFall();
                val_2 = val_2 + 1;
            }
            while(this.explodedCells != null);
            
            throw new NullReferenceException();
        }
        private bool ShouldCallExplode(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cellModel, UnityEngine.Vector3 currentPos)
        {
            if(W9 != 0)
            {
                    UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            }
            else
            {
                    UnityEngine.Vector3 val_2 = UnityEngine.Vector3.right;
            }
            
            UnityEngine.Vector3 val_3 = cellModel.GetViewPosition();
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = currentPos.x, y = currentPos.y, z = currentPos.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            return (bool)(System.Math.Abs(val_5.x) < 0) ? 1 : 0;
        }
    
    }

}
