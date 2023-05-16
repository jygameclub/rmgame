using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Board.Cell.View
{
    public class CellBorder : MonoBehaviour
    {
        // Fields
        public Royal.Scenes.Game.Mechanics.Board.Cell.View.CellView cellView;
        public UnityEngine.SpriteRenderer[] borderRenderers;
        public UnityEngine.SpriteRenderer[] fillRenderers;
        private static readonly UnityEngine.Vector2 SideBorderSize;
        private static readonly UnityEngine.Vector3 TopSideBorderPosition;
        private static readonly UnityEngine.Vector3 RightSideBorderPosition;
        private static readonly UnityEngine.Vector3 BottomSideBorderPosition;
        private static readonly UnityEngine.Vector3 LeftSideBorderPosition;
        private const float SideBorderDecreaseForOuterCorner = 0.05714312;
        private static readonly UnityEngine.Vector2 SideBorderSizeForOuterCorner;
        private const float SideBorderDecreaseForInnerCorner = 0.5;
        private static readonly UnityEngine.Vector2 SideBorderSizeForInnerCorner;
        private Royal.Scenes.Game.Mechanics.Board.Cell.View.CellAssets cellAssets;
        
        // Methods
        public void Init(Royal.Scenes.Game.Mechanics.Board.Cell.View.CellAssets assets)
        {
            this.cellAssets = assets;
        }
        public void ClearCellAssets()
        {
            this.cellAssets = 0;
        }
        public void HideParts()
        {
            var val_3 = 0;
            do
            {
                if(val_3 >= this.borderRenderers.Length)
            {
                    return;
            }
            
                this.borderRenderers[val_3].gameObject.SetActive(value:  false);
                val_3 = val_3 + 1;
            }
            while(this.borderRenderers != null);
            
            throw new NullReferenceException();
        }
        public void ShowParts()
        {
            UnityEngine.Object val_8;
            var val_9;
            var val_10;
            var val_11;
            val_8 = 0;
            goto label_1;
            label_23:
            UnityEngine.SpriteRenderer val_8 = this.borderRenderers[Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors.AllNeighborTypes + 32];
            val_8.gameObject.SetActive(value:  true);
            val_8.enabled = false;
            val_9 = null;
            val_9 = null;
            val_8.size = new UnityEngine.Vector2() {x = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellBorder.SideBorderDecreaseForInnerCorner, y = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellBorder.SideBorderDecreaseForInnerCorner.__il2cppRuntimeField_4};
            if((Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors.AllNeighborTypes + 32) > 7)
            {
                goto label_19;
            }
            
            var val_2 = (Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors.AllNeighborTypes + 32) & 4294967295;
            var val_9 = 36611168 + ((Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors.AllNeighborTypes + 32 & 4294967295)) << 2;
            val_9 = val_9 + 36611168;
            goto (36611168 + ((Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors.AllNeighborTypes + 32 & 4294967295)) << 2 + 36611168);
            label_19:
            val_8 = 1;
            label_1:
            val_10 = null;
            val_10 = null;
            if(val_8 < Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors.AllNeighborTypes.Length)
            {
                goto label_23;
            }
            
            var val_13 = 4;
            label_40:
            if((val_13 - 4) >= this.borderRenderers.Length)
            {
                    return;
            }
            
            UnityEngine.GameObject val_4 = this.borderRenderers[0].gameObject;
            val_8 = this.borderRenderers[0].sprite;
            if(val_8 == 0)
            {
                goto label_33;
            }
            
            val_11 = this.borderRenderers[0].enabled;
            if(val_4 != null)
            {
                goto label_37;
            }
            
            label_33:
            val_11 = 0;
            label_37:
            val_4.SetActive(value:  false);
            val_13 = val_13 + 1;
            if(this.borderRenderers != null)
            {
                goto label_40;
            }
            
            throw new NullReferenceException();
        }
        private void PrepareBorderForTop(UnityEngine.SpriteRenderer part)
        {
            var val_16;
            var val_18;
            var val_20;
            var val_22;
            var val_24;
            var val_20 = 0;
            if(mem[1152921505113751552] != null)
            {
                    val_20 = val_20 + 1;
            }
            else
            {
                    var val_21 = mem[1152921505113751560];
                val_21 = val_21 + 1;
                Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate val_1 = 1152921505113714688 + val_21;
            }
            
            if((this.cellView.<ViewDelegate>k__BackingField.Neighbors.Get(type:  1)) != null)
            {
                    if(null == 1)
            {
                    return;
            }
            
            }
            
            part.enabled = true;
            val_16 = null;
            val_16 = null;
            var val_22 = 0;
            if(mem[1152921505113751552] != null)
            {
                    val_22 = val_22 + 1;
            }
            else
            {
                    var val_23 = mem[1152921505113751560];
                val_23 = val_23 + 1;
                Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate val_4 = 1152921505113714688 + val_23;
            }
            
            if((this.cellView.<ViewDelegate>k__BackingField.Neighbors.Get(type:  7)) != null)
            {
                    var val_7 = ((public Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate::get_Neighbors()) == 1) ? 1 : 0;
            }
            else
            {
                    val_18 = 0;
            }
            
            var val_24 = 0;
            if(mem[1152921505113751552] != null)
            {
                    val_24 = val_24 + 1;
            }
            else
            {
                    var val_25 = mem[1152921505113751560];
                val_25 = val_25 + 1;
                Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate val_8 = 1152921505113714688 + val_25;
            }
            
            if((this.cellView.<ViewDelegate>k__BackingField.Neighbors.Get(type:  3)) != null)
            {
                    var val_11 = ((public Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate::get_Neighbors()) == 1) ? 1 : 0;
            }
            else
            {
                    val_20 = 0;
            }
            
            var val_26 = 0;
            if(mem[1152921505113751552] != null)
            {
                    val_26 = val_26 + 1;
            }
            else
            {
                    var val_27 = mem[1152921505113751560];
                val_27 = val_27 + 1;
                Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate val_12 = 1152921505113714688 + val_27;
            }
            
            if((this.cellView.<ViewDelegate>k__BackingField.Neighbors.Get(type:  0)) != null)
            {
                    var val_15 = ((public Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate::get_Neighbors()) == 1) ? 1 : 0;
            }
            else
            {
                    val_22 = 0;
            }
            
            var val_28 = 0;
            if(mem[1152921505113751552] != null)
            {
                    val_28 = val_28 + 1;
            }
            else
            {
                    var val_29 = mem[1152921505113751560];
                val_29 = val_29 + 1;
                Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate val_16 = 1152921505113714688 + val_29;
            }
            
            if((this.cellView.<ViewDelegate>k__BackingField.Neighbors.Get(type:  2)) != null)
            {
                    var val_19 = ((public Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate::get_Neighbors()) == 1) ? 1 : 0;
            }
            else
            {
                    val_24 = 0;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.View.CellBorder.PrepareTopBottom(part:  part, position:  new UnityEngine.Vector3() {x = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellBorder.TopSideBorderPosition, y = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellBorder.SideBorderDecreaseForInnerCorner.__il2cppRuntimeField_C, z = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellBorder.SideBorderDecreaseForInnerCorner.__il2cppRuntimeField_10}, neighbor1:  false, neighbor2:  false, neighbor3:  false, neighbor4:  false);
        }
        private void PrepareBorderForBottom(UnityEngine.SpriteRenderer part)
        {
            var val_16;
            var val_18;
            var val_20;
            var val_22;
            var val_24;
            var val_20 = 0;
            if(mem[1152921505113751552] != null)
            {
                    val_20 = val_20 + 1;
            }
            else
            {
                    var val_21 = mem[1152921505113751560];
                val_21 = val_21 + 1;
                Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate val_1 = 1152921505113714688 + val_21;
            }
            
            if((this.cellView.<ViewDelegate>k__BackingField.Neighbors.Get(type:  5)) != null)
            {
                    if(null == 1)
            {
                    return;
            }
            
            }
            
            part.enabled = true;
            val_16 = null;
            val_16 = null;
            var val_22 = 0;
            if(mem[1152921505113751552] != null)
            {
                    val_22 = val_22 + 1;
            }
            else
            {
                    var val_23 = mem[1152921505113751560];
                val_23 = val_23 + 1;
                Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate val_4 = 1152921505113714688 + val_23;
            }
            
            if((this.cellView.<ViewDelegate>k__BackingField.Neighbors.Get(type:  7)) != null)
            {
                    var val_7 = ((public Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate::get_Neighbors()) == 1) ? 1 : 0;
            }
            else
            {
                    val_18 = 0;
            }
            
            var val_24 = 0;
            if(mem[1152921505113751552] != null)
            {
                    val_24 = val_24 + 1;
            }
            else
            {
                    var val_25 = mem[1152921505113751560];
                val_25 = val_25 + 1;
                Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate val_8 = 1152921505113714688 + val_25;
            }
            
            if((this.cellView.<ViewDelegate>k__BackingField.Neighbors.Get(type:  3)) != null)
            {
                    var val_11 = ((public Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate::get_Neighbors()) == 1) ? 1 : 0;
            }
            else
            {
                    val_20 = 0;
            }
            
            var val_26 = 0;
            if(mem[1152921505113751552] != null)
            {
                    val_26 = val_26 + 1;
            }
            else
            {
                    var val_27 = mem[1152921505113751560];
                val_27 = val_27 + 1;
                Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate val_12 = 1152921505113714688 + val_27;
            }
            
            if((this.cellView.<ViewDelegate>k__BackingField.Neighbors.Get(type:  6)) != null)
            {
                    var val_15 = ((public Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate::get_Neighbors()) == 1) ? 1 : 0;
            }
            else
            {
                    val_22 = 0;
            }
            
            var val_28 = 0;
            if(mem[1152921505113751552] != null)
            {
                    val_28 = val_28 + 1;
            }
            else
            {
                    var val_29 = mem[1152921505113751560];
                val_29 = val_29 + 1;
                Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate val_16 = 1152921505113714688 + val_29;
            }
            
            if((this.cellView.<ViewDelegate>k__BackingField.Neighbors.Get(type:  4)) != null)
            {
                    var val_19 = ((public Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate::get_Neighbors()) == 1) ? 1 : 0;
            }
            else
            {
                    val_24 = 0;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.View.CellBorder.PrepareTopBottom(part:  part, position:  new UnityEngine.Vector3() {x = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellBorder.BottomSideBorderPosition, y = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellBorder.SideBorderDecreaseForInnerCorner.__il2cppRuntimeField_24, z = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellBorder.SideBorderDecreaseForInnerCorner.__il2cppRuntimeField_28}, neighbor1:  false, neighbor2:  false, neighbor3:  false, neighbor4:  false);
        }
        private void PrepareBorderForLeft(UnityEngine.SpriteRenderer part)
        {
            var val_16;
            var val_18;
            var val_20;
            var val_22;
            var val_24;
            var val_20 = 0;
            if(mem[1152921505113751552] != null)
            {
                    val_20 = val_20 + 1;
            }
            else
            {
                    var val_21 = mem[1152921505113751560];
                val_21 = val_21 + 1;
                Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate val_1 = 1152921505113714688 + val_21;
            }
            
            if((this.cellView.<ViewDelegate>k__BackingField.Neighbors.Get(type:  7)) != null)
            {
                    if(null == 1)
            {
                    return;
            }
            
            }
            
            part.enabled = true;
            val_16 = null;
            val_16 = null;
            var val_22 = 0;
            if(mem[1152921505113751552] != null)
            {
                    val_22 = val_22 + 1;
            }
            else
            {
                    var val_23 = mem[1152921505113751560];
                val_23 = val_23 + 1;
                Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate val_4 = 1152921505113714688 + val_23;
            }
            
            if((this.cellView.<ViewDelegate>k__BackingField.Neighbors.Get(type:  1)) != null)
            {
                    var val_7 = ((public Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate::get_Neighbors()) == 1) ? 1 : 0;
            }
            else
            {
                    val_18 = 0;
            }
            
            var val_24 = 0;
            if(mem[1152921505113751552] != null)
            {
                    val_24 = val_24 + 1;
            }
            else
            {
                    var val_25 = mem[1152921505113751560];
                val_25 = val_25 + 1;
                Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate val_8 = 1152921505113714688 + val_25;
            }
            
            if((this.cellView.<ViewDelegate>k__BackingField.Neighbors.Get(type:  5)) != null)
            {
                    var val_11 = ((public Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate::get_Neighbors()) == 1) ? 1 : 0;
            }
            else
            {
                    val_20 = 0;
            }
            
            var val_26 = 0;
            if(mem[1152921505113751552] != null)
            {
                    val_26 = val_26 + 1;
            }
            else
            {
                    var val_27 = mem[1152921505113751560];
                val_27 = val_27 + 1;
                Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate val_12 = 1152921505113714688 + val_27;
            }
            
            if((this.cellView.<ViewDelegate>k__BackingField.Neighbors.Get(type:  0)) != null)
            {
                    var val_15 = ((public Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate::get_Neighbors()) == 1) ? 1 : 0;
            }
            else
            {
                    val_22 = 0;
            }
            
            var val_28 = 0;
            if(mem[1152921505113751552] != null)
            {
                    val_28 = val_28 + 1;
            }
            else
            {
                    var val_29 = mem[1152921505113751560];
                val_29 = val_29 + 1;
                Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate val_16 = 1152921505113714688 + val_29;
            }
            
            if((this.cellView.<ViewDelegate>k__BackingField.Neighbors.Get(type:  6)) != null)
            {
                    var val_19 = ((public Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate::get_Neighbors()) == 1) ? 1 : 0;
            }
            else
            {
                    val_24 = 0;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.View.CellBorder.PrepareLeftRight(part:  part, position:  new UnityEngine.Vector3() {x = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellBorder.LeftSideBorderPosition, y = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellBorder.SideBorderDecreaseForInnerCorner.__il2cppRuntimeField_30, z = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellBorder.SideBorderDecreaseForInnerCorner.__il2cppRuntimeField_34}, neighbor1:  false, neighbor2:  false, neighbor3:  false, neighbor4:  false);
        }
        private void PrepareBorderForRight(UnityEngine.SpriteRenderer part)
        {
            var val_16;
            var val_18;
            var val_20;
            var val_22;
            var val_24;
            var val_20 = 0;
            if(mem[1152921505113751552] != null)
            {
                    val_20 = val_20 + 1;
            }
            else
            {
                    var val_21 = mem[1152921505113751560];
                val_21 = val_21 + 1;
                Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate val_1 = 1152921505113714688 + val_21;
            }
            
            if((this.cellView.<ViewDelegate>k__BackingField.Neighbors.Get(type:  3)) != null)
            {
                    if(null == 1)
            {
                    return;
            }
            
            }
            
            part.enabled = true;
            val_16 = null;
            val_16 = null;
            var val_22 = 0;
            if(mem[1152921505113751552] != null)
            {
                    val_22 = val_22 + 1;
            }
            else
            {
                    var val_23 = mem[1152921505113751560];
                val_23 = val_23 + 1;
                Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate val_4 = 1152921505113714688 + val_23;
            }
            
            if((this.cellView.<ViewDelegate>k__BackingField.Neighbors.Get(type:  1)) != null)
            {
                    var val_7 = ((public Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate::get_Neighbors()) == 1) ? 1 : 0;
            }
            else
            {
                    val_18 = 0;
            }
            
            var val_24 = 0;
            if(mem[1152921505113751552] != null)
            {
                    val_24 = val_24 + 1;
            }
            else
            {
                    var val_25 = mem[1152921505113751560];
                val_25 = val_25 + 1;
                Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate val_8 = 1152921505113714688 + val_25;
            }
            
            if((this.cellView.<ViewDelegate>k__BackingField.Neighbors.Get(type:  5)) != null)
            {
                    var val_11 = ((public Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate::get_Neighbors()) == 1) ? 1 : 0;
            }
            else
            {
                    val_20 = 0;
            }
            
            var val_26 = 0;
            if(mem[1152921505113751552] != null)
            {
                    val_26 = val_26 + 1;
            }
            else
            {
                    var val_27 = mem[1152921505113751560];
                val_27 = val_27 + 1;
                Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate val_12 = 1152921505113714688 + val_27;
            }
            
            if((this.cellView.<ViewDelegate>k__BackingField.Neighbors.Get(type:  2)) != null)
            {
                    var val_15 = ((public Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate::get_Neighbors()) == 1) ? 1 : 0;
            }
            else
            {
                    val_22 = 0;
            }
            
            var val_28 = 0;
            if(mem[1152921505113751552] != null)
            {
                    val_28 = val_28 + 1;
            }
            else
            {
                    var val_29 = mem[1152921505113751560];
                val_29 = val_29 + 1;
                Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate val_16 = 1152921505113714688 + val_29;
            }
            
            if((this.cellView.<ViewDelegate>k__BackingField.Neighbors.Get(type:  4)) != null)
            {
                    var val_19 = ((public Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate::get_Neighbors()) == 1) ? 1 : 0;
            }
            else
            {
                    val_24 = 0;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.View.CellBorder.PrepareLeftRight(part:  part, position:  new UnityEngine.Vector3() {x = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellBorder.RightSideBorderPosition, y = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellBorder.SideBorderDecreaseForInnerCorner.__il2cppRuntimeField_18, z = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellBorder.SideBorderDecreaseForInnerCorner.__il2cppRuntimeField_1C}, neighbor1:  false, neighbor2:  false, neighbor3:  false, neighbor4:  false);
        }
        private void PrepareBorderForTopLeft(UnityEngine.SpriteRenderer part)
        {
            var val_11;
            var val_13;
            var val_15;
            var val_13 = 0;
            if(mem[1152921505113751552] != null)
            {
                    val_13 = val_13 + 1;
            }
            else
            {
                    var val_14 = mem[1152921505113751560];
                val_14 = val_14 + 1;
                Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate val_1 = 1152921505113714688 + val_14;
            }
            
            val_11 = this.cellView.<ViewDelegate>k__BackingField.Neighbors.Get(type:  1);
            var val_15 = 0;
            if(mem[1152921505113751552] != null)
            {
                    val_15 = val_15 + 1;
            }
            else
            {
                    var val_16 = mem[1152921505113751560];
                val_16 = val_16 + 1;
                Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate val_5 = 1152921505113714688 + val_16;
            }
            
            if((this.cellView.<ViewDelegate>k__BackingField.Neighbors.Get(type:  7)) != null)
            {
                    var val_8 = ((public Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate::get_Neighbors()) == 1) ? 1 : 0;
            }
            else
            {
                    val_13 = 0;
            }
            
            var val_17 = 0;
            if(mem[1152921505113751552] != null)
            {
                    val_17 = val_17 + 1;
            }
            else
            {
                    var val_18 = mem[1152921505113751560];
                val_18 = val_18 + 1;
                Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate val_9 = 1152921505113714688 + val_18;
            }
            
            if((this.cellView.<ViewDelegate>k__BackingField.Neighbors.Get(type:  0)) != null)
            {
                    var val_12 = ((public Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate::get_Neighbors()) == 1) ? 1 : 0;
            }
            else
            {
                    val_15 = 0;
            }
            
            UnityEngine.SpriteRenderer val_19 = this.fillRenderers[0];
            val_19.flipX = true;
            val_19.flipY = true;
            val_19.enabled = false;
            this.PrepareCorner(part:  part, fill:  val_19, neighbor1:  (null == 1) ? 1 : 0, neighbor2:  false, corner:  false);
        }
        private void PrepareBorderForTopRight(UnityEngine.SpriteRenderer part)
        {
            var val_11;
            var val_13;
            var val_15;
            var val_13 = 0;
            if(mem[1152921505113751552] != null)
            {
                    val_13 = val_13 + 1;
            }
            else
            {
                    var val_14 = mem[1152921505113751560];
                val_14 = val_14 + 1;
                Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate val_1 = 1152921505113714688 + val_14;
            }
            
            val_11 = this.cellView.<ViewDelegate>k__BackingField.Neighbors.Get(type:  1);
            var val_15 = 0;
            if(mem[1152921505113751552] != null)
            {
                    val_15 = val_15 + 1;
            }
            else
            {
                    var val_16 = mem[1152921505113751560];
                val_16 = val_16 + 1;
                Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate val_5 = 1152921505113714688 + val_16;
            }
            
            if((this.cellView.<ViewDelegate>k__BackingField.Neighbors.Get(type:  3)) != null)
            {
                    var val_8 = ((public Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate::get_Neighbors()) == 1) ? 1 : 0;
            }
            else
            {
                    val_13 = 0;
            }
            
            var val_17 = 0;
            if(mem[1152921505113751552] != null)
            {
                    val_17 = val_17 + 1;
            }
            else
            {
                    var val_18 = mem[1152921505113751560];
                val_18 = val_18 + 1;
                Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate val_9 = 1152921505113714688 + val_18;
            }
            
            if((this.cellView.<ViewDelegate>k__BackingField.Neighbors.Get(type:  2)) != null)
            {
                    var val_12 = ((public Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate::get_Neighbors()) == 1) ? 1 : 0;
            }
            else
            {
                    val_15 = 0;
            }
            
            UnityEngine.SpriteRenderer val_19 = this.fillRenderers[1];
            val_19.flipX = false;
            val_19.flipY = true;
            val_19.enabled = false;
            this.PrepareCorner(part:  part, fill:  val_19, neighbor1:  (null == 1) ? 1 : 0, neighbor2:  false, corner:  false);
        }
        private void PrepareBorderForBottomRight(UnityEngine.SpriteRenderer part)
        {
            var val_11;
            var val_13;
            var val_15;
            var val_13 = 0;
            if(mem[1152921505113751552] != null)
            {
                    val_13 = val_13 + 1;
            }
            else
            {
                    var val_14 = mem[1152921505113751560];
                val_14 = val_14 + 1;
                Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate val_1 = 1152921505113714688 + val_14;
            }
            
            val_11 = this.cellView.<ViewDelegate>k__BackingField.Neighbors.Get(type:  5);
            var val_15 = 0;
            if(mem[1152921505113751552] != null)
            {
                    val_15 = val_15 + 1;
            }
            else
            {
                    var val_16 = mem[1152921505113751560];
                val_16 = val_16 + 1;
                Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate val_5 = 1152921505113714688 + val_16;
            }
            
            if((this.cellView.<ViewDelegate>k__BackingField.Neighbors.Get(type:  3)) != null)
            {
                    var val_8 = ((public Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate::get_Neighbors()) == 1) ? 1 : 0;
            }
            else
            {
                    val_13 = 0;
            }
            
            var val_17 = 0;
            if(mem[1152921505113751552] != null)
            {
                    val_17 = val_17 + 1;
            }
            else
            {
                    var val_18 = mem[1152921505113751560];
                val_18 = val_18 + 1;
                Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate val_9 = 1152921505113714688 + val_18;
            }
            
            if((this.cellView.<ViewDelegate>k__BackingField.Neighbors.Get(type:  4)) != null)
            {
                    var val_12 = ((public Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate::get_Neighbors()) == 1) ? 1 : 0;
            }
            else
            {
                    val_15 = 0;
            }
            
            UnityEngine.SpriteRenderer val_19 = this.fillRenderers[2];
            val_19.flipX = false;
            val_19.flipY = false;
            val_19.enabled = false;
            this.PrepareCorner(part:  part, fill:  val_19, neighbor1:  (null == 1) ? 1 : 0, neighbor2:  false, corner:  false);
        }
        private void PrepareBorderForBottomLeft(UnityEngine.SpriteRenderer part)
        {
            var val_11;
            var val_13;
            var val_15;
            var val_13 = 0;
            if(mem[1152921505113751552] != null)
            {
                    val_13 = val_13 + 1;
            }
            else
            {
                    var val_14 = mem[1152921505113751560];
                val_14 = val_14 + 1;
                Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate val_1 = 1152921505113714688 + val_14;
            }
            
            val_11 = this.cellView.<ViewDelegate>k__BackingField.Neighbors.Get(type:  5);
            var val_15 = 0;
            if(mem[1152921505113751552] != null)
            {
                    val_15 = val_15 + 1;
            }
            else
            {
                    var val_16 = mem[1152921505113751560];
                val_16 = val_16 + 1;
                Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate val_5 = 1152921505113714688 + val_16;
            }
            
            if((this.cellView.<ViewDelegate>k__BackingField.Neighbors.Get(type:  7)) != null)
            {
                    var val_8 = ((public Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate::get_Neighbors()) == 1) ? 1 : 0;
            }
            else
            {
                    val_13 = 0;
            }
            
            var val_17 = 0;
            if(mem[1152921505113751552] != null)
            {
                    val_17 = val_17 + 1;
            }
            else
            {
                    var val_18 = mem[1152921505113751560];
                val_18 = val_18 + 1;
                Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate val_9 = 1152921505113714688 + val_18;
            }
            
            if((this.cellView.<ViewDelegate>k__BackingField.Neighbors.Get(type:  6)) != null)
            {
                    var val_12 = ((public Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate::get_Neighbors()) == 1) ? 1 : 0;
            }
            else
            {
                    val_15 = 0;
            }
            
            UnityEngine.SpriteRenderer val_19 = this.fillRenderers[3];
            val_19.flipX = true;
            val_19.flipY = false;
            val_19.enabled = false;
            this.PrepareCorner(part:  part, fill:  val_19, neighbor1:  (null == 1) ? 1 : 0, neighbor2:  false, corner:  false);
        }
        private void PrepareCorner(UnityEngine.SpriteRenderer part, UnityEngine.SpriteRenderer fill, bool neighbor1, bool neighbor2, bool corner)
        {
            var val_14;
            var val_15;
            part.flipX = (~fill.flipX) & 1;
            part.flipY = (~fill.flipY) & 1;
            if(((neighbor1 == false) || (neighbor2 == false)) || (corner == true))
            {
                goto label_5;
            }
            
            fill.enabled = true;
            val_14 = null;
            val_14 = null;
            fill.color = new UnityEngine.Color() {r = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellView.MainColor, g = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellView.MainColor.__il2cppRuntimeField_4, b = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellView.MainColor.__il2cppRuntimeField_8, a = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellView.MainColor.__il2cppRuntimeField_C};
            part.enabled = true;
            part.flipX = fill.flipX;
            goto label_11;
            label_5:
            if(neighbor1 == true)
            {
                    return;
            }
            
            if(neighbor2 == true)
            {
                    return;
            }
            
            if(corner == false)
            {
                goto label_14;
            }
            
            fill.enabled = true;
            fill.flipX = (~fill.flipX) & 1;
            val_15 = null;
            val_15 = null;
            fill.color = new UnityEngine.Color() {r = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellView.AltColor, g = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellView.MainColor.__il2cppRuntimeField_14, b = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellView.MainColor.__il2cppRuntimeField_18, a = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellView.MainColor.__il2cppRuntimeField_1C};
            part.enabled = true;
            label_11:
            part.flipY = fill.flipY;
            label_22:
            part.sprite = this.cellAssets.GetInnerCornerPart();
            return;
            label_14:
            part.enabled = true;
            UnityEngine.Sprite val_12 = this.cellAssets.GetOuterCornerPart();
            goto label_22;
        }
        private static void PrepareTopBottom(UnityEngine.SpriteRenderer part, UnityEngine.Vector3 position, bool neighbor1, bool neighbor2, bool neighbor3, bool neighbor4)
        {
            var val_17;
            var val_18;
            float val_19;
            float val_20;
            var val_21;
            float val_25;
            float val_28;
            var val_29;
            var val_30;
            var val_31;
            float val_32;
            float val_33;
            var val_34;
            float val_35;
            var val_36;
            float val_38;
            float val_39;
            var val_40;
            var val_41;
            val_17 = neighbor4;
            val_18 = neighbor1;
            val_19 = position.x;
            if((neighbor3 == true) || (val_17 == true))
            {
                goto label_2;
            }
            
            if(val_18 != true)
            {
                    UnityEngine.Vector2 val_1 = part.size;
                val_18 = 1152921505113501696;
                val_20 = val_1.y;
                val_21 = null;
                val_21 = null;
                UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_1.x, y = val_20}, b:  new UnityEngine.Vector2() {x = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellBorder.SideBorderSizeForOuterCorner, y = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellBorder.SideBorderDecreaseForInnerCorner.__il2cppRuntimeField_3C});
                part.size = new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
                val_25 = val_19 + 0.02857156f;
            }
            
            if(neighbor2 == true)
            {
                goto label_34;
            }
            
            UnityEngine.Vector2 val_3 = part.size;
            val_28 = val_3.x;
            val_20 = val_3.y;
            val_29 = null;
            val_29 = null;
            val_30 = null;
            goto label_13;
            label_2:
            if(neighbor3 == false)
            {
                goto label_14;
            }
            
            UnityEngine.Vector2 val_4 = part.size;
            val_20 = val_4.y;
            val_31 = null;
            val_31 = null;
            val_32 = val_20;
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_4.x, y = val_32}, b:  new UnityEngine.Vector2() {x = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellBorder.SideBorderSizeForInnerCorner, y = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellBorder.SideBorderDecreaseForInnerCorner.__il2cppRuntimeField_44});
            part.size = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
            val_33 = 0.25f;
            val_25 = val_19 + val_33;
            if(val_17 == true)
            {
                goto label_20;
            }
            
            if((val_18 != true) && (neighbor2 != true))
            {
                    UnityEngine.Vector2 val_6 = part.size;
                val_34 = null;
                val_20 = val_6.y;
                val_34 = null;
                val_32 = val_20;
                UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_6.x, y = val_32}, b:  new UnityEngine.Vector2() {x = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellBorder.SideBorderSizeForOuterCorner, y = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellBorder.SideBorderDecreaseForInnerCorner.__il2cppRuntimeField_3C});
                part.size = new UnityEngine.Vector2() {x = val_7.x, y = val_7.y};
                val_33 = -0.02857156f;
                val_25 = val_25 + val_33;
            }
            
            if((val_18 == false) || (neighbor2 == true))
            {
                goto label_48;
            }
            
            UnityEngine.Vector2 val_8 = part.size;
            val_29 = null;
            val_28 = val_8.x;
            val_20 = val_8.y;
            val_29 = null;
            val_30 = null;
            label_13:
            UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_28, y = val_20}, b:  new UnityEngine.Vector2() {x = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellBorder.SideBorderSizeForOuterCorner, y = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellBorder.SideBorderDecreaseForInnerCorner.__il2cppRuntimeField_3C});
            part.size = new UnityEngine.Vector2() {x = val_9.x, y = val_9.y};
            label_53:
            val_35 = val_25 + (-0.02857156f);
            goto label_48;
            label_14:
            if(val_17 == false)
            {
                goto label_34;
            }
            
            label_20:
            UnityEngine.Vector2 val_10 = part.size;
            val_17 = 1152921505113501696;
            val_20 = val_10.y;
            val_36 = null;
            val_36 = null;
            val_38 = val_20;
            UnityEngine.Vector2 val_11 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_10.x, y = val_38}, b:  new UnityEngine.Vector2() {x = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellBorder.SideBorderSizeForInnerCorner, y = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellBorder.SideBorderDecreaseForInnerCorner.__il2cppRuntimeField_44});
            part.size = new UnityEngine.Vector2() {x = val_11.x, y = val_11.y};
            val_39 = -0.25f;
            val_35 = val_19 + val_39;
            if(neighbor3 == true)
            {
                goto label_48;
            }
            
            if((val_18 != true) && (neighbor2 != false))
            {
                    UnityEngine.Vector2 val_12 = part.size;
                val_40 = null;
                val_20 = val_12.y;
                val_40 = null;
                val_38 = val_20;
                UnityEngine.Vector2 val_13 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_12.x, y = val_38}, b:  new UnityEngine.Vector2() {x = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellBorder.SideBorderSizeForOuterCorner, y = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellBorder.SideBorderDecreaseForInnerCorner.__il2cppRuntimeField_3C});
                part.size = new UnityEngine.Vector2() {x = val_13.x, y = val_13.y};
                val_39 = 0.02857156f;
                val_35 = val_35 + val_39;
            }
            
            if((val_18 == true) || (neighbor2 == true))
            {
                goto label_48;
            }
            
            UnityEngine.Vector2 val_14 = part.size;
            val_41 = null;
            val_41 = null;
            UnityEngine.Vector2 val_15 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_14.x, y = val_14.y}, b:  new UnityEngine.Vector2() {x = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellBorder.SideBorderSizeForOuterCorner, y = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellBorder.SideBorderDecreaseForInnerCorner.__il2cppRuntimeField_3C});
            part.size = new UnityEngine.Vector2() {x = val_15.x, y = val_15.y};
            goto label_53;
            label_34:
            label_48:
            part.transform.localPosition = new UnityEngine.Vector3() {x = val_25, y = position.y, z = position.z};
        }
        private static void PrepareLeftRight(UnityEngine.SpriteRenderer part, UnityEngine.Vector3 position, bool neighbor1, bool neighbor2, bool neighbor3, bool neighbor4)
        {
            var val_17;
            var val_18;
            float val_19;
            float val_20;
            var val_21;
            float val_25;
            float val_28;
            var val_29;
            var val_30;
            var val_31;
            float val_32;
            float val_33;
            var val_34;
            float val_35;
            var val_36;
            float val_38;
            float val_39;
            var val_40;
            var val_41;
            val_17 = neighbor4;
            val_18 = neighbor1;
            val_19 = position.y;
            if((neighbor3 == true) || (val_17 == true))
            {
                goto label_2;
            }
            
            if(val_18 != true)
            {
                    UnityEngine.Vector2 val_1 = part.size;
                val_18 = 1152921505113501696;
                val_20 = val_1.y;
                val_21 = null;
                val_21 = null;
                UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_1.x, y = val_20}, b:  new UnityEngine.Vector2() {x = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellBorder.SideBorderSizeForOuterCorner, y = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellBorder.SideBorderDecreaseForInnerCorner.__il2cppRuntimeField_3C});
                part.size = new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
                val_25 = val_19 + (-0.02857156f);
            }
            
            if(neighbor2 == true)
            {
                goto label_34;
            }
            
            UnityEngine.Vector2 val_3 = part.size;
            val_28 = val_3.x;
            val_20 = val_3.y;
            val_29 = null;
            val_29 = null;
            val_30 = null;
            goto label_13;
            label_2:
            if(neighbor3 == false)
            {
                goto label_14;
            }
            
            UnityEngine.Vector2 val_4 = part.size;
            val_20 = val_4.y;
            val_31 = null;
            val_31 = null;
            val_32 = val_20;
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_4.x, y = val_32}, b:  new UnityEngine.Vector2() {x = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellBorder.SideBorderSizeForInnerCorner, y = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellBorder.SideBorderDecreaseForInnerCorner.__il2cppRuntimeField_44});
            part.size = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
            val_33 = -0.25f;
            val_25 = val_19 + val_33;
            if(val_17 == true)
            {
                goto label_20;
            }
            
            if((val_18 != true) && (neighbor2 != true))
            {
                    UnityEngine.Vector2 val_6 = part.size;
                val_34 = null;
                val_20 = val_6.y;
                val_34 = null;
                val_32 = val_20;
                UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_6.x, y = val_32}, b:  new UnityEngine.Vector2() {x = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellBorder.SideBorderSizeForOuterCorner, y = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellBorder.SideBorderDecreaseForInnerCorner.__il2cppRuntimeField_3C});
                part.size = new UnityEngine.Vector2() {x = val_7.x, y = val_7.y};
                val_33 = 0.02857156f;
                val_25 = val_25 + val_33;
            }
            
            if((val_18 == false) || (neighbor2 == true))
            {
                goto label_48;
            }
            
            UnityEngine.Vector2 val_8 = part.size;
            val_29 = null;
            val_28 = val_8.x;
            val_20 = val_8.y;
            val_29 = null;
            val_30 = null;
            label_13:
            UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_28, y = val_20}, b:  new UnityEngine.Vector2() {x = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellBorder.SideBorderSizeForOuterCorner, y = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellBorder.SideBorderDecreaseForInnerCorner.__il2cppRuntimeField_3C});
            part.size = new UnityEngine.Vector2() {x = val_9.x, y = val_9.y};
            label_53:
            val_35 = val_25 + 0.02857156f;
            goto label_48;
            label_14:
            if(val_17 == false)
            {
                goto label_34;
            }
            
            label_20:
            UnityEngine.Vector2 val_10 = part.size;
            val_17 = 1152921505113501696;
            val_20 = val_10.y;
            val_36 = null;
            val_36 = null;
            val_38 = val_20;
            UnityEngine.Vector2 val_11 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_10.x, y = val_38}, b:  new UnityEngine.Vector2() {x = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellBorder.SideBorderSizeForInnerCorner, y = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellBorder.SideBorderDecreaseForInnerCorner.__il2cppRuntimeField_44});
            part.size = new UnityEngine.Vector2() {x = val_11.x, y = val_11.y};
            val_39 = 0.25f;
            val_35 = val_19 + val_39;
            if(neighbor3 == true)
            {
                goto label_48;
            }
            
            if((val_18 != true) && (neighbor2 != true))
            {
                    UnityEngine.Vector2 val_12 = part.size;
                val_40 = null;
                val_20 = val_12.y;
                val_40 = null;
                val_38 = val_20;
                UnityEngine.Vector2 val_13 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_12.x, y = val_38}, b:  new UnityEngine.Vector2() {x = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellBorder.SideBorderSizeForOuterCorner, y = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellBorder.SideBorderDecreaseForInnerCorner.__il2cppRuntimeField_3C});
                part.size = new UnityEngine.Vector2() {x = val_13.x, y = val_13.y};
                val_39 = -0.02857156f;
                val_35 = val_35 + val_39;
            }
            
            if((val_18 == true) || (neighbor2 == false))
            {
                goto label_48;
            }
            
            UnityEngine.Vector2 val_14 = part.size;
            val_41 = null;
            val_41 = null;
            UnityEngine.Vector2 val_15 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_14.x, y = val_14.y}, b:  new UnityEngine.Vector2() {x = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellBorder.SideBorderSizeForOuterCorner, y = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellBorder.SideBorderDecreaseForInnerCorner.__il2cppRuntimeField_3C});
            part.size = new UnityEngine.Vector2() {x = val_15.x, y = val_15.y};
            goto label_53;
            label_34:
            label_48:
            part.transform.localPosition = new UnityEngine.Vector3() {x = position.x, y = val_25, z = position.z};
        }
        private static bool DoesCellExistAndNormal(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            if(cell == null)
            {
                    return (bool)(W8 == 1) ? 1 : 0;
            }
            
            return (bool)(W8 == 1) ? 1 : 0;
        }
        public CellBorder()
        {
        
        }
        private static CellBorder()
        {
            UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  1f, y:  0.3f);
            Royal.Scenes.Game.Mechanics.Board.Cell.View.CellBorder.SideBorderDecreaseForInnerCorner = val_1.x;
            Royal.Scenes.Game.Mechanics.Board.Cell.View.CellBorder.TopSideBorderPosition = 0;
            Royal.Scenes.Game.Mechanics.Board.Cell.View.CellBorder.SideBorderDecreaseForInnerCorner.__il2cppRuntimeField_10 = 0;
            Royal.Scenes.Game.Mechanics.Board.Cell.View.CellBorder.RightSideBorderPosition = 0;
            Royal.Scenes.Game.Mechanics.Board.Cell.View.CellBorder.SideBorderDecreaseForInnerCorner.__il2cppRuntimeField_1C = 0;
            Royal.Scenes.Game.Mechanics.Board.Cell.View.CellBorder.BottomSideBorderPosition = 0;
            Royal.Scenes.Game.Mechanics.Board.Cell.View.CellBorder.SideBorderDecreaseForInnerCorner.__il2cppRuntimeField_28 = 0;
            Royal.Scenes.Game.Mechanics.Board.Cell.View.CellBorder.LeftSideBorderPosition = 0;
            Royal.Scenes.Game.Mechanics.Board.Cell.View.CellBorder.SideBorderDecreaseForInnerCorner.__il2cppRuntimeField_34 = 0;
            UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  0.05714312f, y:  0f);
            UnityEngine.Vector2 val_3;
            Royal.Scenes.Game.Mechanics.Board.Cell.View.CellBorder.SideBorderSizeForOuterCorner = val_2.x;
            val_3 = new UnityEngine.Vector2(x:  0.5f, y:  0f);
            Royal.Scenes.Game.Mechanics.Board.Cell.View.CellBorder.SideBorderSizeForInnerCorner = val_3.x;
        }
    
    }

}
