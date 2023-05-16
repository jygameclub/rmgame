using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.CupboardItem
{
    public class CupboardItemComparer : IComparer<Royal.Scenes.Game.Mechanics.Items.CupboardItem.CupboardItemModel>
    {
        // Methods
        public int Compare(Royal.Scenes.Game.Mechanics.Items.CupboardItem.CupboardItemModel cim1, Royal.Scenes.Game.Mechanics.Items.CupboardItem.CupboardItemModel cim2)
        {
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_2 = 0.CurrentCell;
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y});
            float val_4 = UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y}, b:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.zero;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_6 = 0.CurrentCell;
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_3.x});
            return (int)(val_4 >= 0) ? ((val_4 > (UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y}, b:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y}))) ? 1 : 0) : (!0);
        }
        public CupboardItemComparer()
        {
        
        }
    
    }

}
