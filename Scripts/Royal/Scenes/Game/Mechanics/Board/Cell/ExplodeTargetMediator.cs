using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Board.Cell
{
    public class ExplodeTargetMediator
    {
        // Fields
        private int frame;
        private int score;
        private readonly Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell;
        
        // Methods
        public ExplodeTargetMediator(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cellModel)
        {
            this.frame = 0;
            this.score = 0;
            this.cell = cellModel;
        }
        public int GetScore()
        {
            int val_5;
            if(this.cell.IsBlockedByAnyDrill() != false)
            {
                    val_5 = 0;
                return val_4;
            }
            
            if(this.frame == Royal.Scenes.Game.Levels.LevelContext.FrameCount)
            {
                    val_5 = this.score;
                return val_4;
            }
            
            this.frame = Royal.Scenes.Game.Levels.LevelContext.FrameCount;
            val_5 = this;
            int val_4 = this.CalculateScore();
            this.score = val_4;
            return val_4;
        }
        private int CalculateScore()
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_9;
            var val_10;
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_11;
            var val_12;
            Royal.Scenes.Game.Mechanics.Items.Config.ItemType val_13;
            val_9 = this.cell;
            if()
            {
                    val_10 = val_9 + ((W10 - 1) << 3);
            }
            else
            {
                    val_11 = this.cell.Mediator.current.<Item>k__BackingField;
                if(val_11 != null)
            {
                    val_12 = 0;
                if((Royal.Scenes.Game.Mechanics.Items.Config.ItemExtensions.IsObstacle(itemType:  val_11)) == true)
            {
                goto label_17;
            }
            
                val_9 = this.cell;
            }
            
            }
            
            val_12 = mem[val_2 + 600];
            val_12 = val_2 + 600;
            label_17:
            val_13 = ???;
            goto val_2 + 592;
        }
        public int RemainingExplodeCount()
        {
            var val_6;
            if((this.cell.<StaticMediator>k__BackingField) >= 1)
            {
                    var val_5 = 0;
                do
            {
                if((this.cell.<StaticMediator>k__BackingField) <= val_5)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_5 = val_5 + 1;
                val_6 = Royal.Scenes.Game.Mechanics.Board.Cell.StaticItemMediator.__il2cppRuntimeField_byval_arg.RemainingExplodeCount() + 0;
            }
            while(val_5 < null);
            
            }
            else
            {
                    val_6 = 0;
            }
            
            if((this.cell.Mediator.current.<Item>k__BackingField) != null)
            {
                    bool val_2 = Royal.Scenes.Game.Mechanics.Items.Config.ItemExtensions.IsObstacle(itemType:  this.cell.Mediator.current.<Item>k__BackingField);
            }
            
            if((this.cell.<StaticMediator>k__BackingField) < 1)
            {
                goto label_17;
            }
            
            var val_6 = 0;
            do
            {
                if((this.cell.<StaticMediator>k__BackingField) <= val_6)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_6 = val_6 + 1;
                val_6 = Royal.Scenes.Game.Mechanics.Board.Cell.StaticItemMediator.__il2cppRuntimeField_byval_arg.RemainingExplodeCount() + 1152921505105940480;
            }
            while(val_6 < null);
            
            if((this.cell.Mediator.current.<Item>k__BackingField) == null)
            {
                    return 1152921505105940480;
            }
            
            label_25:
            if(0 == 0)
            {
                    return 1152921505105940480;
            }
            
            if((Royal.Scenes.Game.Mechanics.Items.Config.ItemExtensions.IsObstacle(itemType:  this.cell.Mediator.current.<Item>k__BackingField)) == true)
            {
                    return 1152921505105940480;
            }
            
            val_6 = (this.cell.Mediator.current.<Item>k__BackingField) + val_6;
            return 1152921505105940480;
            label_17:
            if((this.cell.Mediator.current.<Item>k__BackingField) != null)
            {
                goto label_25;
            }
            
            return 1152921505105940480;
        }
        public Royal.Scenes.Game.Levels.Units.Explode.IExplodeTarget AddIncomingExploder(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            var val_6;
            System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.Config.StaticItemModel> val_7;
            var val_8;
            var val_9;
            int val_11;
            int val_13;
            val_6 = 1152921523925410752;
            val_7 = this;
            if((this.cell.<StaticMediator>k__BackingField) < 1)
            {
                goto label_4;
            }
            
            var val_5 = 0;
            label_8:
            if((this.cell.<StaticMediator>k__BackingField) <= val_5)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_9 = 0;
            if(Royal.Scenes.Game.Mechanics.Board.Cell.StaticItemMediator.__il2cppRuntimeField_byval_arg.RemainingExplodeCount() >= 1)
            {
                goto label_7;
            }
            
            val_5 = val_5 + 1;
            if(val_5 < null)
            {
                goto label_8;
            }
            
            label_4:
            if((this.cell.Mediator.current.<Item>k__BackingField) == null)
            {
                goto label_14;
            }
            
            val_9 = 0;
            if(((Royal.Scenes.Game.Mechanics.Items.Config.ItemExtensions.IsObstacle(itemType:  this.cell.Mediator.current.<Item>k__BackingField)) == false) || ((this.cell.Mediator.current.<Item>k__BackingField) < 1))
            {
                goto label_14;
            }
            
            val_11 = data.id;
            goto label_15;
            label_14:
            val_7 = this.cell.<StaticMediator>k__BackingField.belowItems;
            if((this.cell.<StaticMediator>k__BackingField) < 1)
            {
                goto label_19;
            }
            
            var val_6 = 0;
            label_23:
            if((this.cell.<StaticMediator>k__BackingField) <= val_6)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_9 = 0;
            if(Royal.Scenes.Game.Mechanics.Board.Cell.StaticItemMediator.__il2cppRuntimeField_byval_arg.RemainingExplodeCount() >= 1)
            {
                goto label_22;
            }
            
            val_6 = val_6 + 1;
            if(val_6 < null)
            {
                goto label_23;
            }
            
            label_19:
            if((this.cell.Mediator.current.<Item>k__BackingField) == null)
            {
                goto label_26;
            }
            
            val_8 = 0;
            if((Royal.Scenes.Game.Mechanics.Items.Config.ItemExtensions.IsObstacle(itemType:  this.cell.Mediator.current.<Item>k__BackingField)) == true)
            {
                    return (Royal.Scenes.Game.Levels.Units.Explode.IExplodeTarget)Royal.Scenes.Game.Mechanics.Board.Cell.StaticItemMediator.__il2cppRuntimeField_byval_arg;
            }
            
            if((this.cell.Mediator.current.<Item>k__BackingField) < 1)
            {
                goto label_26;
            }
            
            val_11 = data.id;
            label_15:
            val_8 = this.cell.Mediator.current.<Item>k__BackingField;
            return (Royal.Scenes.Game.Levels.Units.Explode.IExplodeTarget)Royal.Scenes.Game.Mechanics.Board.Cell.StaticItemMediator.__il2cppRuntimeField_byval_arg;
            label_7:
            val_13 = data.id;
            return (Royal.Scenes.Game.Levels.Units.Explode.IExplodeTarget)Royal.Scenes.Game.Mechanics.Board.Cell.StaticItemMediator.__il2cppRuntimeField_byval_arg;
            label_26:
            val_8 = 0;
            return (Royal.Scenes.Game.Levels.Units.Explode.IExplodeTarget)Royal.Scenes.Game.Mechanics.Board.Cell.StaticItemMediator.__il2cppRuntimeField_byval_arg;
            label_22:
            val_13 = data.id;
            return (Royal.Scenes.Game.Levels.Units.Explode.IExplodeTarget)Royal.Scenes.Game.Mechanics.Board.Cell.StaticItemMediator.__il2cppRuntimeField_byval_arg;
        }
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel TryRedirect()
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_3;
            if(((this.cell.Mediator.current.<Item>k__BackingField) != null) && (((this.cell.Mediator.current.<Item>k__BackingField) & 1) != 0))
            {
                    Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_1 = this.cell.Mediator.current.<Item>k__BackingField.CurrentCell;
                if(val_1 != this.cell)
            {
                    val_3 = val_1;
                if(val_1.RemainingExplodeCount() > 0)
            {
                    return val_3;
            }
            
            }
            
            }
            
            val_3 = this.cell;
            return val_3;
        }
    
    }

}
