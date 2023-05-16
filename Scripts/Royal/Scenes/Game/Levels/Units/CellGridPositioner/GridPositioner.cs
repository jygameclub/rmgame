using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.CellGridPositioner
{
    public class GridPositioner
    {
        // Fields
        public UnityEngine.Vector3 gridTransformPosition;
        protected UnityEngine.Vector3 gridPositionOffset;
        protected readonly Royal.Scenes.Game.Levels.Units.CellGridManager cellGridManager;
        protected readonly Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory factory;
        protected readonly Royal.Infrastructure.Contexts.Units.CameraManager cameraManager;
        
        // Methods
        public GridPositioner()
        {
            this.cellGridManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.CellGridManager>(contextId:  2);
            this.factory = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1);
            Royal.Infrastructure.Contexts.Units.CameraManager val_3 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            this.cameraManager = val_3;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(d:  (val_3.IsDeviceTall() != true) ? 1f : 0.75f, a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            this.gridPositionOffset = val_7;
            mem[1152921524124097712] = val_7.y;
            mem[1152921524124097716] = val_7.z;
        }
        public virtual void SetGridTransformPosition()
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_1 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  0, y:  0);
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_2 = this.cellGridManager.grid.GetCell(point:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_1.x, y = val_1.x});
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_5 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  this.cellGridManager.grid.width - 1, y:  this.cellGridManager.grid.height - 1);
            UnityEngine.Transform val_7 = this.cellGridManager.grid.GetCell(point:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_5.x, y = val_5.x}).transform;
            UnityEngine.Vector3 val_8 = val_7.position;
            UnityEngine.Vector3 val_10 = val_7.transform.position;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, d:  2f);
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, b:  new UnityEngine.Vector3() {x = this.gridPositionOffset, y = val_10.y, z = val_10.z});
            this.gridTransformPosition = val_13;
            mem[1152921524124267044] = val_13.y;
            mem[1152921524124267048] = val_13.z;
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.right;
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Multiply(d:  11.1f, a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, b:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
            this.factory.<CellParent>k__BackingField.position = new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z};
        }
        public virtual UnityEngine.Vector3 GetGridCenterPosition()
        {
            return new UnityEngine.Vector3() {x = this.gridPositionOffset};
        }
        public UnityEngine.Vector3 GetGridTopCenterPosition()
        {
            float val_2 = 0.5f;
            val_2 = (float)this.cellGridManager.grid.height * val_2;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            return new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
        }
        public UnityEngine.Vector3 GetGridTopCenterMaxPosition()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  5.5f);
            return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        }
        public UnityEngine.Vector3 GetGridBottomCenterPosition()
        {
            float val_2 = 0.5f;
            val_2 = (float)this.cellGridManager.grid.height * val_2;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            return new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
        }
    
    }

}
