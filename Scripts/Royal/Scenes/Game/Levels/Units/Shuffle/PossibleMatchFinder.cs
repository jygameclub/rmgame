using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.Shuffle
{
    public static class PossibleMatchFinder
    {
        // Fields
        public const int NoPossibleMatch = 0;
        public const int OnlyLightballExists = 1;
        public const int PossibleMatchFound = 2;
        
        // Methods
        public static int CheckBoard(Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator iterator)
        {
            var val_8;
            var val_10;
            var val_11;
            var val_15;
            var val_16;
            val_15 = 0;
            do
            {
                label_24:
                if(iterator.strategy == null)
            {
                    return (int)val_15;
            }
            
            }
            while(iterator.Cell.Mediator.HasCurrentItem() == false);
            
            if((iterator.Cell.Mediator.CurrentItem & 1) != 0)
            {
                    if(iterator.Cell.CanEnterPossibleMatch() == true)
            {
                goto label_7;
            }
            
            }
            
            if(((iterator.Cell.Mediator.CurrentItem & 1) == 0) || (iterator.Cell.CanEnterPossibleMatchAcceptingChain() == false))
            {
                goto label_24;
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_6 = iterator.Cell.Mediator.CurrentItem;
            val_16 = null;
            val_16 = null;
            int val_14 = Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors.TouchingNeighborTypes.Length;
            if(val_14 < 1)
            {
                goto label_24;
            }
            
            var val_16 = 0;
            val_14 = val_14 & 4294967295;
            do
            {
                Royal.Scenes.Game.Levels.Units.Shuffle.PossibleMatch val_7 = Royal.Scenes.Game.Levels.Units.Shuffle.PossibleMatchFinder.CheckNeighborForPossibleMatches(cell:  iterator.Cell, matchType:  val_6.<MatchType>k__BackingField, direction:  X26 + 0);
                var val_15 = ~val_8;
                if(val_10 != true)
            {
                    val_15 = val_15 & 1;
                if(val_15 >= val_11)
            {
                    if(val_15 != 0)
            {
                goto label_23;
            }
            
            }
            
            }
            
                val_16 = val_16 + 1;
            }
            while(val_16 < (Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors.TouchingNeighborTypes.Length << ));
            
            goto label_24;
            label_7:
            if(iterator.Cell.Mediator.CurrentItem == 5)
            {
                    if((Royal.Scenes.Game.Levels.Units.Shuffle.PossibleMatchFinder.HasAnySpecialItemAround(cell:  iterator.Cell)) == false)
            {
                goto label_24;
            }
            
            }
            
            label_23:
            val_15 = 2;
            return (int)val_15;
        }
        private static bool HasAnySpecialItemAround(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            null = null;
            int val_4 = Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors.TouchingNeighborTypes.Length;
            if(val_4 < 1)
            {
                    return false;
            }
            
            var val_5 = 0;
            val_4 = val_4 & 4294967295;
            do
            {
                Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_1 = Get(type:  X23 + 0);
                if(val_1 != null)
            {
                    if(val_1.CanEnterPossibleMatch() != false)
            {
                    if((val_1.CurrentItem & 1) != 0)
            {
                    return false;
            }
            
            }
            
            }
            
                val_5 = val_5 + 1;
            }
            while(val_5 < (Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors.TouchingNeighborTypes.Length << ));
            
            return false;
        }
        public static Royal.Scenes.Game.Levels.Units.Shuffle.PossibleMatch CheckNeighborForPossibleMatches(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, Royal.Scenes.Game.Mechanics.Matches.MatchType matchType, int direction)
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_6;
            var val_7;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_1 = cell.Get(type:  direction);
            if(val_1 != null)
            {
                    bool val_2 = val_1.CanEnterPossibleMatchAcceptingChain();
                if(val_2 != false)
            {
                    if((val_3.<MatchType>k__BackingField) == matchType)
            {
                    Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_4 = val_2.CurrentItem.Get(type:  direction);
                val_7 = 2;
                return Royal.Scenes.Game.Levels.Units.Shuffle.PossibleMatchFinder.CheckNeighborsForMatchType(cell:  val_6 = val_1, matchType:  matchType, targetCount:  3, direction:  direction);
            }
            
            }
            
            }
            
            val_7 = 3;
            return Royal.Scenes.Game.Levels.Units.Shuffle.PossibleMatchFinder.CheckNeighborsForMatchType(cell:  val_6, matchType:  matchType, targetCount:  3, direction:  direction);
        }
        private static Royal.Scenes.Game.Levels.Units.Shuffle.PossibleMatch CheckNeighborsForMatchType(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, Royal.Scenes.Game.Mechanics.Matches.MatchType matchType, int targetCount, int direction)
        {
            bool val_15;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_16;
            var val_17;
            int val_18;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_19;
            Royal.Scenes.Game.Levels.Units.Shuffle.PossibleMatch val_0;
            if(cell == null)
            {
                goto label_1;
            }
            
            val_15 = cell.HasSpecialItem();
            bool val_2 = cell.IsNormalCell();
            val_16 = 0;
            if(val_2 == false)
            {
                goto label_32;
            }
            
            if(val_2.HasCurrentItem() == false)
            {
                goto label_4;
            }
            
            bool val_4 = cell.CanEnterPossibleMatch();
            val_16 = 0;
            if(val_4 == false)
            {
                goto label_32;
            }
            
            if((val_4.CurrentItem & 1) == 0)
            {
                goto label_12;
            }
            
            label_4:
            val_17 = null;
            val_17 = null;
            val_15 = val_15;
            int val_15 = Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors.TouchingNeighborTypes.Length;
            if(val_15 < 1)
            {
                goto label_12;
            }
            
            val_16 = 0;
            var val_17 = 0;
            val_15 = val_15 & 4294967295;
            label_31:
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_6 = Get(type:  X28 + 0);
            if(val_6 == null)
            {
                goto label_26;
            }
            
            bool val_7 = val_6.CanEnterPossibleMatchAcceptingChain();
            if(val_7 == false)
            {
                goto label_26;
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_8 = val_7.CurrentItem;
            if((val_8.<MatchType>k__BackingField) != matchType)
            {
                goto label_26;
            }
            
            if(targetCount == 3)
            {
                goto label_20;
            }
            
            if(targetCount != 2)
            {
                goto label_24;
            }
            
            val_18 = direction;
            int val_9 = Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighborType.OppositeNeighbor(type:  val_18);
            goto label_22;
            label_20:
            val_18 = direction;
            int val_10 = Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighborType.OppositeNeighbor(type:  val_18);
            val_15 = val_15;
            if((X28 + 0) == direction)
            {
                goto label_24;
            }
            
            label_22:
            if((X28 + 0) != val_10)
            {
                    if((val_10.HasStaticItem(itemType:  4)) == true)
            {
                goto label_26;
            }
            
            }
            
            label_24:
            if(((X28 + 0) - 1) > 6)
            {
                goto label_30;
            }
            
            var val_16 = 36589664 + ((X28 + 0 - 1)) << 2;
            val_16 = val_16 + 36589664;
            goto (36589664 + ((X28 + 0 - 1)) << 2 + 36589664);
            label_30:
            val_16 = cell;
            label_26:
            val_17 = val_17 + 1;
            if(val_17 < (Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors.TouchingNeighborTypes.Length << ))
            {
                goto label_31;
            }
            
            goto label_32;
            label_1:
            val_19 = 0;
            val_0.requiredCell = 0;
            val_0.minNeighborCount = 0;
            val_0.containsSpecialItem = false;
            val_0.bottomNeighbor = 0;
            val_0.leftNeighbor = 0;
            mem[1152921523991608751] = val_19;
            mem[1152921523991608749] = 0;
            val_0.topNeighbor = 0;
            val_0.rightNeighbor = 0;
            return val_0;
            label_12:
            val_16 = 0;
            label_32:
            val_0.containsSpecialItem = val_15;
            val_0.topNeighbor = 0;
            val_0.requiredCell = val_16;
            val_0.rightNeighbor = 0;
            val_0.bottomNeighbor = 0;
            val_19 = 0;
            val_0.minNeighborCount = targetCount;
            mem[1152921523991608751] = 0;
            mem[1152921523991608749] = 0;
            val_0.leftNeighbor = val_19;
            return val_0;
        }
    
    }

}
