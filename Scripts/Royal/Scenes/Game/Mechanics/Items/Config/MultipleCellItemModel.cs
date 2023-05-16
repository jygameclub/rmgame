using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.Config
{
    public abstract class MultipleCellItemModel : ItemModel
    {
        // Fields
        protected Royal.Scenes.Game.Mechanics.Matches.Cell14 allCells;
        private bool isCurrentCellAdded;
        
        // Methods
        protected MultipleCellItemModel(int layer = 1)
        {
        
        }
        public virtual Royal.Scenes.Game.Mechanics.Matches.Cell14 GetAllCells()
        {
        
        }
        public virtual bool CanAllCellsBeBlockedByDrill()
        {
            return true;
        }
        public void AddCell(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            Royal.Scenes.Game.Mechanics.Matches.Cell14 val_2;
            if(this.isCurrentCellAdded != false)
            {
                    val_2 = this.allCells;
                throw new NullReferenceException();
            }
            
            val_2 = this.allCells;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_1 = this.CurrentCell;
            this.isCurrentCellAdded = true;
            throw new NullReferenceException();
        }
        public void AddNonExtraIncomingExploder(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            if(this != null)
            {
                    this.AddToIncoming(id:  268435460);
                return;
            }
            
            throw new NullReferenceException();
        }
        public void RemoveNonExtraIncomingExploder(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            if(this != null)
            {
                    this.RemoveFromIncoming(id:  268435460);
                return;
            }
            
            throw new NullReferenceException();
        }
        protected Royal.Scenes.Game.Mechanics.Board.Cell.CellModel GetLeftBottom()
        {
            var val_5;
            if(this.allCells >= 1)
            {
                    var val_5 = 0;
                val_5 = 0;
                do
            {
                if(100 >= this.allCells)
            {
                    Royal.Scenes.Game.Mechanics.Matches.Cell14 val_1 = this.allCells >> 32;
                var val_2 = (100 < val_1) ? (val_5) : (val_5);
                var val_3 = (100 < val_1) ? 100 : (val_1);
                var val_4 = (100 < val_1) ? 100 : this.allCells;
            }
            
                val_5 = val_5 + 1;
            }
            while(val_5 < this.allCells);
            
                throw new NullReferenceException();
            }
            
            val_5 = 0;
            throw new NullReferenceException();
        }
        protected Royal.Scenes.Game.Mechanics.Board.Cell.CellModel GetRightTop()
        {
            var val_5;
            if(this.allCells >= 1)
            {
                    var val_5 = 0;
                val_5 = 0;
                do
            {
                if(0 <= this.allCells)
            {
                    Royal.Scenes.Game.Mechanics.Matches.Cell14 val_1 = this.allCells >> 32;
                var val_2 = (0 > val_1) ? (val_5) : (val_5);
                var val_3 = (0 > val_1) ? 0 : (val_1);
                var val_4 = (0 > val_1) ? 0 : this.allCells;
            }
            
                val_5 = val_5 + 1;
            }
            while(val_5 < this.allCells);
            
                throw new NullReferenceException();
            }
            
            val_5 = 0;
            throw new NullReferenceException();
        }
        public override bool WillCellBeFreed(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            if((this.allCells & 1) == 0)
            {
                    return false;
            }
            
            if(this > 17)
            {
                goto label_1;
            }
            
            if(this > 17)
            {
                goto label_6;
            }
            
            if(0 != 198656)
            {
                    return false;
            }
            
            goto label_6;
            label_1:
            if((this <= 35) && ((0 & (-2143289344)) == 0))
            {
                    return false;
            }
            
            label_6:
            var val_2 = (this.FinalExplodeCount() < 1) ? 1 : 0;
            return false;
        }
        public override int GetExtraExplodeCount()
        {
            var val_61;
            var val_62;
            var val_63;
            int val_64;
            var val_65;
            var val_66;
            var val_67;
            var val_68;
            var val_69;
            var val_70;
            var val_71;
            Royal.Scenes.Game.Mechanics.Items.Config.MultipleCellItemModel val_72;
            var val_73;
            var val_74;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_1 = 24886.CurrentCell;
            if((val_1 == null) || ((val_1.HasOperation(animationId:  9)) == false))
            {
                goto label_4;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_60 = this.GetLeftBottom();
            val_62 = this.GetRightTop();
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_6 = true.CurrentCell.CurrentCell;
            val_63 = 0;
            val_64 = W9 - 2;
            if(val_64 > 3)
            {
                goto label_11;
            }
            
            val_65 = 0;
            val_62 = 0;
            val_61 = 0;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_8 = val_60 - 2;
            label_26:
            if(val_8 > (W10 + 2))
            {
                goto label_12;
            }
            
            if(((val_64 <= true) && (val_8 <= W10)) && (val_64 >= W9))
            {
                    if(val_8 >= val_60)
            {
                goto label_16;
            }
            
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_9 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  val_8, y:  val_64);
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_10 = X27.Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_9.x, y = val_9.x}];
            if(val_10 == null)
            {
                goto label_19;
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_12 = val_10.CurrentItem;
            var val_13 = (val_12 == 0) ? (val_62) : (val_12);
            if(val_12 == null)
            {
                goto label_19;
            }
            
            var val_14 = ((val_12 == null ? val_62 : val_12 + 104) == 0) ? (val_61) : (val_12 == null ? val_62 : val_12 + 104);
            if((val_12 == null ? val_62 : val_12 + 104) == 0)
            {
                goto label_21;
            }
            
            val_66 = 0;
            val_67 = (val_10 == 0) ? (val_65) : (val_63);
            goto label_23;
            label_19:
            val_66 = 0;
            goto label_24;
            label_21:
            val_66 = 0;
            label_23:
            label_24:
            val_63 = val_63 + (((val_66 & 0) != 0) ? 0 : (val_66));
            label_16:
            val_8 = val_8 + 1;
            goto label_26;
            label_12:
            val_64 = val_64 + 1;
            if(val_64 <= 3)
            {
                goto label_26;
            }
            
            label_11:
            if(W9 > true)
            {
                goto label_27;
            }
            
            val_68 = 0;
            val_61 = 0;
            label_57:
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_16 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  val_60, y:  W9);
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_17 = mem[1152921523800224264].Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_16.x, y = val_16.x}];
            var val_18 = (val_17 == 0) ? 0 : (val_17);
            if(val_17 == null)
            {
                goto label_42;
            }
            
            val_62 = mem[val_17 == null ? 0 : val_17 + 40];
            val_62 = val_17 == null ? 0 : val_17 + 40;
            if(val_62 == 0)
            {
                goto label_42;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_20 = (val_62 == 0) ? 0 : (val_62).Get(type:  7);
            if(val_20 == null)
            {
                goto label_33;
            }
            
            label_41:
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_21 = val_20.CurrentItem;
            var val_22 = (val_21 == 0) ? 0 : (val_21);
            if(val_21 == null)
            {
                goto label_36;
            }
            
            var val_23 = ((val_21 == null ? 0 : val_21 + 104) == 0) ? 0 : (val_21 == null ? 0 : val_21 + 104);
            if((val_21 == null ? 0 : val_21 + 104) == 0)
            {
                goto label_36;
            }
            
            val_69 = 0;
            goto label_38;
            label_36:
            val_69 = 0;
            label_38:
            val_70 = (((val_69 & 0) != 0) ? 0 : (val_69)) + val_63;
            if(val_18 != 0)
            {
                    if(((val_18 == 0) ? 0 : (val_18).Get(type:  7)) != null)
            {
                goto label_41;
            }
            
            }
            
            val_65 = val_18;
            goto label_42;
            label_33:
            label_42:
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_27 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  ???, y:  W9);
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_28 = mem[1152921523800224264].Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_27.x, y = val_27.x}];
            var val_29 = (val_28 == 0) ? 0 : (val_28);
            if(val_28 == null)
            {
                goto label_46;
            }
            
            val_62 = mem[val_28 == null ? 0 : val_28 + 40];
            val_62 = val_28 == null ? 0 : val_28 + 40;
            if(val_62 == 0)
            {
                goto label_46;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_31 = (val_62 == 0) ? 0 : (val_62).Get(type:  3);
            if(val_31 == null)
            {
                goto label_54;
            }
            
            label_56:
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_32 = val_31.CurrentItem;
            var val_33 = (val_32 == 0) ? (val_68) : (val_32);
            if(val_32 == null)
            {
                goto label_51;
            }
            
            var val_34 = ((val_32 == null ? val_68 : val_32 + 104) == 0) ? 0 : (val_32 == null ? val_68 : val_32 + 104);
            if((val_32 == null ? val_68 : val_32 + 104) == 0)
            {
                goto label_51;
            }
            
            val_71 = 0;
            goto label_53;
            label_51:
            val_71 = 0;
            label_53:
            val_70 = (((val_71 & 0) != 0) ? 0 : (val_71)) + val_63;
            if(val_18 == 0)
            {
                goto label_54;
            }
            
            if(((val_18 == 0) ? (val_61) : (val_18).Get(type:  3)) != null)
            {
                goto label_56;
            }
            
            val_61 = val_18;
            label_54:
            val_65 = val_18;
            label_46:
            val_64 = W9 + 1;
            if(val_64 <= true)
            {
                goto label_57;
            }
            
            label_27:
            if(val_60 > (???))
            {
                    return (int)val_70;
            }
            
            val_72 = this;
            val_62 = 0;
            val_68 = 0;
            val_65 = 0;
            val_61 = 0;
            label_89:
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_38 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  val_60, y:  ???);
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_39 = mem[1152921523800224264].Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_38.x, y = val_38.x}];
            var val_40 = (val_39 == 0) ? 0 : (val_39);
            if(val_39 == null)
            {
                goto label_73;
            }
            
            val_62 = mem[val_39 == null ? 0 : val_39 + 40];
            val_62 = val_39 == null ? 0 : val_39 + 40;
            if(val_62 == 0)
            {
                goto label_62;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_42 = (val_62 == 0) ? (val_62) : (val_62).Get(type:  1);
            if(val_42 == null)
            {
                goto label_70;
            }
            
            label_72:
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_43 = val_42.CurrentItem;
            var val_44 = (val_43 == 0) ? (val_68) : (val_43);
            if(val_43 == null)
            {
                goto label_67;
            }
            
            var val_45 = ((val_43 == null ? val_68 : val_43 + 104) == 0) ? 0 : (val_43 == null ? val_68 : val_43 + 104);
            if((val_43 == null ? val_68 : val_43 + 104) == 0)
            {
                goto label_67;
            }
            
            val_73 = 0;
            goto label_69;
            label_67:
            val_73 = 0;
            label_69:
            val_70 = (((val_73 & 0) != 0) ? 0 : (val_73)) + val_70;
            if(this == null)
            {
                goto label_70;
            }
            
            if(((val_72 == 0) ? (val_65) : (val_72).Get(type:  1)) != null)
            {
                goto label_72;
            }
            
            val_65 = val_72;
            label_70:
            val_72 = this;
            goto label_73;
            label_62:
            val_62 = val_62;
            label_73:
            val_64 = mem[1152921523800224264];
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_49 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  val_60, y:  1);
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_50 = val_64.Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_49.x, y = val_49.x}];
            var val_51 = (val_50 == 0) ? 0 : (val_50);
            if(val_50 == null)
            {
                goto label_75;
            }
            
            if((val_50 == null ? 0 : val_50 + 40) == 0)
            {
                goto label_77;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_53 = ((val_50 == null ? 0 : val_50 + 40) == 0) ? 0 : (val_50 == null ? 0 : val_50 + 40).Get(type:  5);
            if(val_53 == null)
            {
                goto label_85;
            }
            
            val_64 = val_53;
            label_87:
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_54 = val_64.CurrentItem;
            var val_55 = (val_54 == 0) ? 0 : (val_54);
            if(val_54 == null)
            {
                goto label_82;
            }
            
            var val_56 = ((val_54 == null ? 0 : val_54 + 104) == 0) ? 0 : (val_54 == null ? 0 : val_54 + 104);
            if((val_54 == null ? 0 : val_54 + 104) == 0)
            {
                goto label_82;
            }
            
            val_74 = 0;
            goto label_84;
            label_82:
            val_74 = 0;
            label_84:
            val_70 = (((val_74 & 0) != 0) ? 0 : (val_74)) + val_70;
            if(this == null)
            {
                goto label_85;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_59 = (val_72 == 0) ? (val_61) : (val_72).Get(type:  5);
            val_64 = val_59;
            if(val_59 != null)
            {
                goto label_87;
            }
            
            val_61 = val_72;
            goto label_88;
            label_85:
            label_88:
            label_77:
            val_62 = val_62;
            label_75:
            val_60 = val_60 + 1;
            if(val_60 <= (???))
            {
                goto label_89;
            }
            
            return (int)val_70;
            label_4:
            val_70 = 0;
            return (int)val_70;
        }
    
    }

}
