using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.CellGridPositioner
{
    public class StoryGridPositioner : GridPositioner
    {
        // Methods
        public override void SetGridTransformPosition()
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_1 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  0, y:  0);
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_2 = GetCell(point:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_1.x, y = val_1.x});
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_5 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  (X21 + 40 + 24) - 1, y:  (X21 + 40 + 24 + 4) - 1);
            UnityEngine.Transform val_7 = X21 + 40.GetCell(point:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_5.x, y = val_5.x}).transform;
            UnityEngine.Vector3 val_8 = val_7.position;
            UnityEngine.Vector3 val_10 = val_7.transform.position;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, d:  2f);
            UnityEngine.Vector3 val_13 = 0.GetSafeBottomCenterOfCamera();
            var val_15 = (0.IsDeviceTall() != true) ? 3.05f : 1.05f;
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_13.y, z = val_12.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            mem[1152921524124921248] = val_16.x;
            mem[1152921524124921252] = val_16.y;
            mem[1152921524124921256] = val_16.z;
            UnityEngine.Vector3.__il2cppRuntimeField_cctor_finished + 24.position = new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z};
        }
        public override UnityEngine.Vector3 GetGridCenterPosition()
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_1 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  0, y:  0);
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_2 = GetCell(point:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_1.x, y = val_1.x});
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_5 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  (public static System.String UnityEngine.JsonUtility::ToJson(object obj).__il2cppRuntimeField_18 - 1)>>0&0xFFFFFFFF, y:  (public static System.String UnityEngine.JsonUtility::ToJson(object obj).__il2cppRuntimeField_1C - 1)>>0&0xFFFFFFFF);
            UnityEngine.Transform val_7 = GetCell(point:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_5.x, y = val_5.x}).transform;
            UnityEngine.Vector3 val_8 = val_7.position;
            UnityEngine.Vector3 val_10 = val_7.transform.position;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, d:  2f);
            return new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
        }
        public StoryGridPositioner()
        {
        
        }
    
    }

}
