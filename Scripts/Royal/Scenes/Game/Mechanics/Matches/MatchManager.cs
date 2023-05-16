using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Matches
{
    public class MatchManager : IGameContextUnit, IContextUnit
    {
        // Fields
        private const int Capacity = 100;
        private readonly System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Matches.MatchGroup> allMatches;
        private readonly Royal.Scenes.Game.Mechanics.Matches.ExtensionCell[] extensions;
        private readonly System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.Config.ItemModel> collectSorter;
        private readonly System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> specialCreationSorter;
        private Royal.Player.Context.Units.LevelManager levelManager;
        private Royal.Scenes.Game.Levels.Units.CellGridManager gridManager;
        private Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory;
        private Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator bottomLeftIterator;
        private Royal.Scenes.Game.Utils.VisitMatrix visitMatrix;
        private Royal.Scenes.Game.Mechanics.Matches.TempMatch[] tempMatches;
        private Royal.Scenes.Game.Mechanics.Matches.PossibleMatchGroup[] possibleMatchGroups;
        private int currentTempMatchCount;
        private int currentPossibleMatchGroupCount;
        private Royal.Scenes.Game.Levels.Units.Sfx.GameSfxManager sfxManager;
        
        // Properties
        public int Id { get; }
        
        // Methods
        public int get_Id()
        {
            return 4;
        }
        public MatchManager()
        {
            var val_9;
            this.tempMatches = new Royal.Scenes.Game.Mechanics.Matches.TempMatch[100];
            this.possibleMatchGroups = new Royal.Scenes.Game.Mechanics.Matches.PossibleMatchGroup[100];
            this.allMatches = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Matches.MatchGroup>(capacity:  100);
            this.extensions = new Royal.Scenes.Game.Mechanics.Matches.ExtensionCell[10];
            this.collectSorter = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.Config.ItemModel>(capacity:  10);
            this.specialCreationSorter = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel>(capacity:  10);
            var val_9 = 0;
            label_6:
            if(val_9 >= this.tempMatches.Length)
            {
                goto label_2;
            }
            
            this.tempMatches[val_9] = new Royal.Scenes.Game.Mechanics.Matches.TempMatch();
            val_9 = val_9 + 1;
            if(this.tempMatches != null)
            {
                goto label_6;
            }
            
            label_2:
            val_9 = 0;
            do
            {
                if(val_9 >= this.possibleMatchGroups.Length)
            {
                    return;
            }
            
                this.possibleMatchGroups[val_9] = new Royal.Scenes.Game.Mechanics.Matches.PossibleMatchGroup();
                val_9 = val_9 + 1;
            }
            while(this.possibleMatchGroups != null);
            
            throw new NullReferenceException();
        }
        public void Bind()
        {
            this.levelManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LevelManager>(id:  2);
            this.gridManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.CellGridManager>(contextId:  2);
            this.itemFactory = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1);
            this.sfxManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.Sfx.GameSfxManager>(contextId:  22);
            this.gridManager.add_OnCellGridInitialized(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Game.Mechanics.Matches.MatchManager::OnCellGridInitialized()));
        }
        private void OnCellGridInitialized()
        {
            var val_5;
            Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator val_6;
            this.visitMatrix = new Royal.Scenes.Game.Utils.VisitMatrix(width:  this.gridManager.Width, height:  this.gridManager.Height);
            Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator val_4 = this.gridManager.GetIterator(iteratorType:  0);
            mem[1152921519996256536] = val_5;
            this.bottomLeftIterator = val_6;
        }
        public void Clear(bool gameExit)
        {
            this.allMatches.Clear();
            this.visitMatrix.Reset();
            if(this.tempMatches.Length >= 101)
            {
                    this.ResizeTempMatches(newSize:  100);
            }
            
            if(this.possibleMatchGroups.Length < 101)
            {
                    return;
            }
            
            this.ResizePossibleMatchGroups(newSize:  100);
        }
        public System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Matches.MatchGroup> FindAllMatches()
        {
            this.SearchGridForPatterns();
            this.ProcessExtensionsForAllMatches();
            return (System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Matches.MatchGroup>)this.allMatches;
        }
        public System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Matches.MatchGroup> FindMatchesInArea(Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint center, int radius, bool excludeFallingItems = False)
        {
            center.x = center.x - radius;
            int val_2 = center.x >> 32;
            int val_3 = this.gridManager.Width;
            val_3 = val_3 - 1;
            int val_8 = this.gridManager.Height;
            val_8 = val_8 - 1;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_11 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  UnityEngine.Mathf.Max(a:  0, b:  center.x), y:  UnityEngine.Mathf.Max(a:  0, b:  val_2 - radius));
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_12 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  UnityEngine.Mathf.Min(a:  val_3, b:  center.x + radius), y:  UnityEngine.Mathf.Min(a:  val_8, b:  val_2 + radius));
            this.SearchGridForPatterns(startPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_11.x, y = val_11.x}, endPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_12.x, y = val_12.x}, excludeFallingItems:  excludeFallingItems);
            return (System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Matches.MatchGroup>)this.allMatches;
        }
        public System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Matches.MatchGroup> FindExtensiveMatchesInArea(Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint center, int radius)
        {
            System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Matches.MatchGroup> val_1 = this.FindMatchesInArea(center:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = center.x, y = center.y}, radius:  radius, excludeFallingItems:  true);
            this.ProcessExtensionsForAllMatches();
            return (System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Matches.MatchGroup>)this.allMatches;
        }
        public bool IsThereAnyMatch(bool excludeFallingItems = False)
        {
            var val_22;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_23;
            if(this.bottomLeftIterator == 0)
            {
                goto label_0;
            }
            
            val_22 = 1;
            label_18:
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_1 = X22 + 40.Get(type:  3);
            val_23 = val_1;
            bool val_3 = val_1.IsValidToPatternSearch(cellModel:  X22, nextCellModel:  val_1, direction:  2, excludeFallingItems:  excludeFallingItems);
            if(val_3 == false)
            {
                goto label_3;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_4 = val_3.Get(type:  3);
            if((val_4.IsValidToPatternSearch(cellModel:  val_23, nextCellModel:  val_4, direction:  2, excludeFallingItems:  excludeFallingItems)) == true)
            {
                goto label_17;
            }
            
            label_3:
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_7 = X22 + 40.Get(type:  1);
            val_23 = val_7;
            bool val_9 = val_7.IsValidToPatternSearch(cellModel:  X22, nextCellModel:  val_7, direction:  1, excludeFallingItems:  excludeFallingItems);
            if(val_9 != false)
            {
                    Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_10 = val_9.Get(type:  1);
                if((val_10.IsValidToPatternSearch(cellModel:  val_23, nextCellModel:  val_10, direction:  1, excludeFallingItems:  excludeFallingItems)) == true)
            {
                    return (bool)val_22;
            }
            
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_13 = X22 + 40.Get(type:  1);
            if((val_13.IsValidToPatternSearch(cellModel:  X22, nextCellModel:  val_13, direction:  0, excludeFallingItems:  excludeFallingItems)) == false)
            {
                goto label_15;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_16 = X22 + 40.Get(type:  3);
            if((val_16.IsValidToPatternSearch(cellModel:  X22, nextCellModel:  val_16, direction:  0, excludeFallingItems:  excludeFallingItems)) == false)
            {
                goto label_15;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_19 = X22 + 40.Get(type:  2);
            if((val_19.IsValidToPatternSearch(cellModel:  X22, nextCellModel:  val_19, direction:  0, excludeFallingItems:  excludeFallingItems)) == true)
            {
                goto label_17;
            }
            
            label_15:
            if(this.bottomLeftIterator != 0)
            {
                goto label_18;
            }
            
            label_0:
            val_22 = 0;
            return (bool)val_22;
            label_17:
            val_22 = 1;
            return (bool)val_22;
        }
        private void SearchGridForPatterns(Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint startPoint, Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint endPoint, bool excludeFallingItems)
        {
            var val_6;
            int val_6 = startPoint.x;
            this.allMatches.Clear();
            this.visitMatrix.Reset();
            this.currentTempMatchCount = 0;
            this.currentPossibleMatchGroupCount = 0;
            if(val_6 <= endPoint.x)
            {
                    int val_1 = endPoint.x >> 32;
                int val_2 = val_6 >> 32;
                do
            {
                if(val_2 <= val_1)
            {
                    do
            {
                Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_4 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  val_6, y:  val_2);
                this.FindThreeMatchesAndPropellersForCell(currentCell:  this.gridManager.Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_4.x, y = val_4.x}], excludeFallingItems:  excludeFallingItems);
                val_6 = val_2 + 1;
            }
            while(val_6 <= val_1);
            
            }
            
                val_6 = val_6 + 1;
            }
            while(val_6 <= endPoint.x);
            
            }
            
            this.CreateMatchesFromThrees();
        }
        private void FindThreeMatchesAndPropellersForCell(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel currentCell, bool excludeFallingItems)
        {
            if(currentCell == null)
            {
                    return;
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_1 = 24047.CurrentItem;
            if(val_1 == null)
            {
                    return;
            }
            
            var val_2 = (((Royal.Scenes.Game.Mechanics.Items.Config.ItemModel.__il2cppRuntimeField_typeHierarchy + (Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemModel.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_1) : 0;
        }
        private void CreateMatchesFromThrees()
        {
            var val_67;
            var val_68;
            var val_70;
            var val_71;
            Royal.Scenes.Game.Mechanics.Matches.TempMatch val_72;
            int val_73;
            var val_74;
            bool val_75;
            Royal.Scenes.Game.Mechanics.Matches.MatchType val_76;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_77;
            Royal.Scenes.Game.Mechanics.Matches.PatternType val_78;
            Royal.Scenes.Game.Mechanics.Matches.MatchType val_79;
            Royal.Scenes.Game.Mechanics.Matches.TempMatch val_80;
            Royal.Scenes.Game.Mechanics.Matches.TempMatch val_81;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_82;
            Royal.Scenes.Game.Mechanics.Matches.MatchType val_83;
            Royal.Scenes.Game.Mechanics.Matches.Direction val_85;
            Royal.Scenes.Game.Mechanics.Matches.Direction val_86;
            if(this.currentTempMatchCount < 1)
            {
                goto label_1;
            }
            
            label_78:
            val_72 = 0;
            Royal.Scenes.Game.Mechanics.Matches.TempMatch val_73 = this.tempMatches[val_72];
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_2 = val_73.First().CurrentItem;
            this.AddPossibleMatchGroup(patternType:  1, matchType:  val_2.<MatchType>k__BackingField, tempMatch1:  this.tempMatches[val_72], tempMatch2:  0, firstIntersect:  0, secondIntersect:  0);
            if(this.tempMatches[0x0][0].direction == 0)
            {
                goto label_10;
            }
            
            val_73 = this.currentTempMatchCount;
            val_74 = 0 + 1;
            val_75 = val_74;
            if(val_74 < val_73)
            {
                goto label_77;
            }
            
            goto label_16;
            label_10:
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_4 = val_73.First().CurrentItem;
            this.AddPossibleMatchGroup(patternType:  2, matchType:  val_4.<MatchType>k__BackingField, tempMatch1:  val_73, tempMatch2:  0, firstIntersect:  0, secondIntersect:  0);
            val_73 = this.currentTempMatchCount;
            val_74 = 0 + 1;
            goto label_16;
            label_43:
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_7 = val_73.First().CurrentItem;
            val_76 = val_7.<MatchType>k__BackingField;
            label_50:
            val_77 = val_73.Middle();
            val_78 = (this.tempMatches[0x0][0].direction == 1) ? (3 + 1) : 3;
            val_79 = val_76;
            val_80 = val_73;
            val_81 = val_72;
            val_82 = val_73.First();
            goto label_20;
            label_55:
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_11 = val_73.First().CurrentItem;
            val_83 = val_11.<MatchType>k__BackingField;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_12 = val_73.Last();
            goto label_24;
            label_58:
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_14 = val_73.First().CurrentItem;
            val_83 = val_14.<MatchType>k__BackingField;
            label_32:
            val_82 = val_73.Middle();
            val_78 = 5;
            goto label_69;
            label_63:
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_17 = val_73.First().CurrentItem;
            goto label_32;
            label_77:
            val_72 = this.tempMatches[val_75];
            val_85 = this.tempMatches[(0 + 1)][0].direction;
            if(val_85 == 0)
            {
                goto label_46;
            }
            
            val_86 = this.tempMatches[0x0][0].direction;
            if(val_86 != val_85)
            {
                goto label_37;
            }
            
            if(val_73.First() == val_72.Last())
            {
                goto label_38;
            }
            
            val_86 = this.tempMatches[0x0][0].direction;
            val_85 = this.tempMatches[(0 + 1)][0].direction;
            label_37:
            if(val_86 != val_85)
            {
                goto label_39;
            }
            
            if(val_73.Last() == val_72.First())
            {
                goto label_40;
            }
            
            val_86 = this.tempMatches[0x0][0].direction;
            val_85 = this.tempMatches[(0 + 1)][0].direction;
            label_39:
            if(val_86 != val_85)
            {
                goto label_41;
            }
            
            label_64:
            if(val_73.First() == val_72.Middle())
            {
                    if(val_73.Middle() == val_72.Last())
            {
                goto label_43;
            }
            
            }
            
            label_65:
            if(((this.tempMatches[0x0][0].direction != (this.tempMatches[(0 + 1)][0].direction)) || (val_73.Middle() != val_72.First())) || (val_73.Last() != val_72.Middle()))
            {
                goto label_46;
            }
            
            var val_30 = (this.tempMatches[0x0][0].direction == 1) ? (3 + 1) : 3;
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_32 = val_73.First().CurrentItem;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_33 = val_73.Middle();
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_34 = val_73.Last();
            goto label_50;
            label_41:
            if((val_73.First() == val_72.First()) || (val_73.First() == val_72.Last()))
            {
                goto label_52;
            }
            
            if(this.tempMatches[0x0][0].direction == (this.tempMatches[(0 + 1)][0].direction))
            {
                goto label_64;
            }
            
            if((val_73.Last() == val_72.Last()) || (val_73.Last() == val_72.First()))
            {
                goto label_55;
            }
            
            if(this.tempMatches[0x0][0].direction == (this.tempMatches[(0 + 1)][0].direction))
            {
                goto label_64;
            }
            
            if((val_73.Middle() == val_72.First()) || (val_73.Middle() == val_72.Last()))
            {
                goto label_58;
            }
            
            if(this.tempMatches[0x0][0].direction == (this.tempMatches[(0 + 1)][0].direction))
            {
                goto label_64;
            }
            
            if((val_73.First() == val_72.Middle()) || (val_73.Last() == val_72.Middle()))
            {
                goto label_63;
            }
            
            if(this.tempMatches[0x0][0].direction == (this.tempMatches[(0 + 1)][0].direction))
            {
                goto label_64;
            }
            
            if(val_73.Middle() == val_72.Middle())
            {
                goto label_63;
            }
            
            if(this.tempMatches[0x0][0].direction == (this.tempMatches[(0 + 1)][0].direction))
            {
                goto label_64;
            }
            
            goto label_65;
            label_52:
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_54 = val_73.First().CurrentItem;
            val_83 = val_54.<MatchType>k__BackingField;
            label_24:
            val_82 = val_73.First();
            val_78 = 6;
            goto label_69;
            label_38:
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_57 = val_73.First().CurrentItem;
            val_83 = val_57.<MatchType>k__BackingField;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_58 = val_73.First();
            goto label_73;
            label_40:
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_60 = val_73.First().CurrentItem;
            val_83 = val_60.<MatchType>k__BackingField;
            label_73:
            val_82 = val_73.Last();
            val_78 = 7;
            label_69:
            val_79 = val_83;
            val_80 = val_73;
            val_81 = val_72;
            val_77 = 0;
            label_20:
            this.AddPossibleMatchGroup(patternType:  val_78, matchType:  val_79, tempMatch1:  val_80, tempMatch2:  val_81, firstIntersect:  val_82, secondIntersect:  val_77);
            label_46:
            val_73 = this.currentTempMatchCount;
            val_75 = val_75 + 1;
            if(val_75 < val_73)
            {
                goto label_77;
            }
            
            label_16:
            if(val_74 < val_73)
            {
                goto label_78;
            }
            
            label_1:
            if(this.currentPossibleMatchGroupCount == 0)
            {
                    return;
            }
            
            this.SortPossibleMatchGroups();
            if(this.currentPossibleMatchGroupCount < 1)
            {
                goto label_80;
            }
            
            val_75 = 1152921519998348000;
            label_88:
            if((System.Linq.Enumerable.Any<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel>(source:  this.possibleMatchGroups[0x0][0].tempMatch1.cellModels, predicate:  new System.Func<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel, System.Boolean>(object:  this, method:  System.Boolean Royal.Scenes.Game.Mechanics.Matches.MatchManager::<CreateMatchesFromThrees>b__27_0(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)))) != true)
            {
                    if(this.possibleMatchGroups[0x0][0].tempMatch2 != null)
            {
                    if((System.Linq.Enumerable.Any<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel>(source:  this.possibleMatchGroups[0x0][0].tempMatch2.cellModels, predicate:  new System.Func<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel, System.Boolean>(object:  this, method:  System.Boolean Royal.Scenes.Game.Mechanics.Matches.MatchManager::<CreateMatchesFromThrees>b__27_1(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)))) == true)
            {
                goto label_87;
            }
            
            }
            
                this.CreateAndAddMatchGroup(possibleMatchGroup:  this.possibleMatchGroups[0]);
            }
            
            label_87:
            val_76 = 0 + 1;
            if(val_76 < this.currentPossibleMatchGroupCount)
            {
                goto label_88;
            }
            
            label_80:
            var val_78 = 0;
            val_74 = 152;
            do
            {
                if(val_78 >= (-1788211008))
            {
                    return;
            }
            
                var val_76 = 2506756288;
                if(val_78 >= val_76)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_76 = val_76 + (val_78 * 152);
                var val_66 = val_76 + 32;
                if(val_67 >= 1)
            {
                    var val_77 = 0;
                do
            {
                val_76 = val_68.CurrentItem;
                val_75 = val_70;
                Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_72 = val_76 + 144;
                val_76 = val_75;
                val_76 = val_71;
                val_76 = 0;
                val_76 = 0;
                val_77 = val_77 + 1;
            }
            while(val_77 < val_67);
            
            }
            
                val_78 = val_78 + 1;
            }
            while(this.allMatches != null);
            
            throw new NullReferenceException();
        }
        private void SortPossibleMatchGroups()
        {
            int val_3;
            Royal.Scenes.Game.Mechanics.Matches.PossibleMatchGroup val_4;
            val_3 = this.currentPossibleMatchGroupCount;
            if(val_3 < 1)
            {
                    return;
            }
            
            var val_8 = 0;
            do
            {
                if((val_3 - 1) >= 1)
            {
                    var val_7 = 4;
                do
            {
                var val_2 = val_7 - 4;
                val_4 = this.possibleMatchGroups[0];
                if(this.possibleMatchGroups[0].patternType < (this.possibleMatchGroups[(4 - 3)][0].patternType))
            {
                    mem2[0] = val_4;
                val_4 = this.possibleMatchGroups;
                val_4 = this.possibleMatchGroups[val_7 - 3];
                val_3 = this.currentPossibleMatchGroupCount;
            }
            
                val_7 = val_7 + 1;
            }
            while((val_7 - 4) < (val_3 - 1));
            
            }
            
                val_8 = val_8 + 1;
            }
            while(val_8 < val_3);
        
        }
        private void AddPossibleMatchGroup(Royal.Scenes.Game.Mechanics.Matches.PatternType patternType, Royal.Scenes.Game.Mechanics.Matches.MatchType matchType, Royal.Scenes.Game.Mechanics.Matches.TempMatch tempMatch1, Royal.Scenes.Game.Mechanics.Matches.TempMatch tempMatch2, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel firstIntersect, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel secondIntersect)
        {
            Royal.Scenes.Game.Mechanics.Matches.PossibleMatchGroup[] val_6;
            int val_7;
            int val_8;
            val_6 = this.possibleMatchGroups;
            val_7 = this.currentPossibleMatchGroupCount;
            val_8 = this.possibleMatchGroups.Length;
            if(val_7 != val_8)
            {
                goto label_2;
            }
            
            val_8 = this.possibleMatchGroups.Length;
            this.ResizePossibleMatchGroups(newSize:  System.Math.Max(val1:  val_7 << 1, val2:  val_8 << 1));
            val_7 = this.currentPossibleMatchGroupCount;
            val_6 = this.possibleMatchGroups;
            this.currentPossibleMatchGroupCount = val_7 + 1;
            if(val_6 != null)
            {
                goto label_5;
            }
            
            label_2:
            this.currentPossibleMatchGroupCount = val_7 + 1;
            label_5:
            Royal.Scenes.Game.Mechanics.Matches.PossibleMatchGroup val_6 = val_6[val_7];
            val_6 = patternType;
            val_6 = matchType;
            val_6 = tempMatch1;
            val_6 = tempMatch2;
            val_6 = firstIntersect;
            val_6 = secondIntersect;
        }
        private void ResizePossibleMatchGroups(int newSize)
        {
            int val_3;
            Royal.Scenes.Game.Mechanics.Matches.PossibleMatchGroup[] val_1 = this.possibleMatchGroups;
            val_3 = this.possibleMatchGroups.Length;
            if(val_3 == newSize)
            {
                    return;
            }
            
            System.Array.Resize<Royal.Scenes.Game.Mechanics.Matches.PossibleMatchGroup>(array: ref  val_1, newSize:  newSize);
            if(val_3 > newSize)
            {
                    return;
            }
            
            val_3 = val_1;
            int val_3 = this.possibleMatchGroups.Length;
            do
            {
                if(val_3 >= this.possibleMatchGroups.Length)
            {
                    return;
            }
            
                val_3[val_3] = new Royal.Scenes.Game.Mechanics.Matches.PossibleMatchGroup();
                val_3 = val_1;
                val_3 = val_3 + 1;
            }
            while(val_3 != null);
            
            throw new NullReferenceException();
        }
        private void ResizeTempMatches(int newSize)
        {
            int val_3;
            Royal.Scenes.Game.Mechanics.Matches.TempMatch[] val_1 = this.tempMatches;
            val_3 = this.tempMatches.Length;
            if(val_3 == newSize)
            {
                    return;
            }
            
            System.Array.Resize<Royal.Scenes.Game.Mechanics.Matches.TempMatch>(array: ref  val_1, newSize:  newSize);
            if(val_3 > newSize)
            {
                    return;
            }
            
            val_3 = val_1;
            int val_3 = this.tempMatches.Length;
            do
            {
                if(val_3 >= this.tempMatches.Length)
            {
                    return;
            }
            
                val_3[val_3] = new Royal.Scenes.Game.Mechanics.Matches.TempMatch();
                val_3 = val_1;
                val_3 = val_3 + 1;
            }
            while(val_3 != null);
            
            throw new NullReferenceException();
        }
        private void SearchGridForPatterns()
        {
            this.allMatches.Clear();
            this.visitMatrix.Reset();
            this.currentTempMatchCount = 0;
            this.currentPossibleMatchGroupCount = 0;
            goto label_3;
            label_4:
            this.FindThreeMatchesAndPropellersForCell(currentCell:  0, excludeFallingItems:  false);
            label_3:
            if(this.bottomLeftIterator != 0)
            {
                goto label_4;
            }
            
            this.CreateMatchesFromThrees();
        }
        private void CreateAndAddMatchGroup(Royal.Scenes.Game.Mechanics.Matches.PossibleMatchGroup possibleMatchGroup)
        {
            var val_1;
            int val_2;
            var val_4;
            var val_5;
            val_4 = possibleMatchGroup;
            System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Matches.MatchGroup> val_4 = this.allMatches;
            val_4 = val_4 + 1;
            int val_5 = possibleMatchGroup.tempMatch1.cellModels.Length;
            if(val_5 >= 1)
            {
                    val_5 = val_5 & 4294967295;
                do
            {
                if(null != null)
            {
                
            }
            
                val_5 = 0 + 1;
            }
            while(val_5 < (possibleMatchGroup.tempMatch1.cellModels.Length << ));
            
            }
            
            if(possibleMatchGroup.tempMatch2 != null)
            {
                    int val_6 = possibleMatchGroup.tempMatch2.cellModels.Length;
                if(val_6 >= 1)
            {
                    val_6 = val_6 & 4294967295;
                do
            {
                if(((null != null) && (null != possibleMatchGroup.firstIntersect)) && (null != possibleMatchGroup.secondIntersect))
            {
                
            }
            
                val_5 = 0 + 1;
            }
            while(val_5 < (possibleMatchGroup.tempMatch2.cellModels.Length << ));
            
            }
            
            }
            
            if(val_1 >= 1)
            {
                    do
            {
                this.visitMatrix.SetAsVisited(x:  val_2, y:  val_2 >> 32, group:  val_4);
                val_4 = 0 + 1;
            }
            while(val_4 < val_1);
            
            }
            
            this.allMatches.Add(item:  new Royal.Scenes.Game.Mechanics.Matches.MatchGroup() {cell14 = new Royal.Scenes.Game.Mechanics.Matches.Cell14(), explosionCalculated = ???, canExplode = ???, exists = ???});
        }
        private bool IsValidToPatternSearch(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cellModel, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel nextCellModel, Royal.Scenes.Game.Mechanics.Matches.Direction direction, bool excludeFallingItems)
        {
            var val_7;
            var val_11;
            val_7 = 0;
            if(cellModel == null)
            {
                    return (bool)val_7;
            }
            
            if(nextCellModel == null)
            {
                    return (bool)val_7;
            }
            
            if((mem[-6917529027624257768]) != 0)
            {
                    bool val_1 = val_7.HasTouchBlockingItemExceptChain();
                if(val_1 != true)
            {
                    if(val_1.HasTouchBlockingItemExceptChain() == false)
            {
                goto label_16;
            }
            
            }
            
            }
            
            label_30:
            val_7 = 0;
            return (bool)val_7;
            label_16:
            if(excludeFallingItems == false)
            {
                goto label_17;
            }
            
            var val_7 = 0;
            val_7 = val_7 + 1;
            if((MatchItemModel.__il2cppRuntimeField_18 + 40.IsItemSteady()) == false)
            {
                goto label_30;
            }
            
            label_17:
            if(direction == 2)
            {
                goto label_27;
            }
            
            if(direction != 1)
            {
                goto label_28;
            }
            
            goto label_29;
            label_27:
            label_29:
            label_28:
            val_11 = mem[public System.Boolean Royal.Scenes.Game.Mechanics.Fall.IFallComponent::IsItemSteady().__il2cppRuntimeField_10 + 24];
            val_11 = public System.Boolean Royal.Scenes.Game.Mechanics.Fall.IFallComponent::IsItemSteady().__il2cppRuntimeField_10 + 24;
            val_11 = mem[public System.Boolean Royal.Scenes.Game.Mechanics.Fall.IFallComponent::IsItemSteady().__il2cppRuntimeField_10 + 24 + 200 + ((Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemModel.__il2cppRuntimeField_typeHierarchyDepth - 1)) << 3];
            val_11 = public System.Boolean Royal.Scenes.Game.Mechanics.Fall.IFallComponent::IsItemSteady().__il2cppRuntimeField_10 + 24 + 200 + ((Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemModel.__il2cppRuntimeField_typeHierarchyDepth - 1)) << 3;
            if(val_11 == null)
            {
                    val_11 = mem[public System.Boolean Royal.Scenes.Game.Mechanics.Fall.IFallComponent::IsItemSteady().__il2cppRuntimeField_10 + 24 + 200 + ((Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemModel.__il2cppRuntimeField_typeHierarchyDepth - 1)) << 3 + 16 + 24];
                val_11 = public System.Boolean Royal.Scenes.Game.Mechanics.Fall.IFallComponent::IsItemSteady().__il2cppRuntimeField_10 + 24 + 200 + ((Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemModel.__il2cppRuntimeField_typeHierarchyDepth - 1)) << 3 + 16 + 24;
                var val_6 = ((public System.Boolean Royal.Scenes.Game.Mechanics.Fall.IFallComponent::IsItemSteady().__il2cppRuntimeField_10 + 24 + 24) == (public System.Boolean Royal.Scenes.Game.Mechanics.Fall.IFallComponent::IsItemSteady().__il2cppRuntimeField_10 + 24 + 200 + ((Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemModel.__il2cppRuntimeField_typeHierarchyDepth - 1)) << 3 + 16 + 24 + 24)) ? 1 : 0;
                return (bool)val_7;
            }
        
        }
        private void ProcessExtensionsForAllMatches()
        {
            var val_1;
            bool val_2 = true;
            var val_3 = 0;
            val_1 = 32;
            do
            {
                if(val_3 >= val_2)
            {
                    return;
            }
            
                val_2 = val_2 & 4294967295;
                if(val_3 >= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_1 = val_2 + val_1;
                this.FindAndProcessExtensionCandidates(groupIndex:  0, group:  new Royal.Scenes.Game.Mechanics.Matches.MatchGroup() {cell14 = new Royal.Scenes.Game.Mechanics.Matches.Cell14(), explosionCalculated = ???, canExplode = ???, exists = ???});
                val_3 = val_3 + 1;
                val_1 = val_1 + 152;
            }
            while(this.allMatches != null);
            
            throw new NullReferenceException();
        }
        private void FindAndProcessExtensionCandidates(int groupIndex, Royal.Scenes.Game.Mechanics.Matches.MatchGroup group)
        {
            var val_14;
            int val_15;
            Royal.Scenes.Game.Mechanics.Matches.PatternType val_16;
            Royal.Scenes.Game.Mechanics.Matches.ExtensionCell val_17;
            int val_18;
            var val_19;
            var val_20;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_21;
            val_15 = groupIndex;
            if((-1785462784) < 1)
            {
                goto label_46;
            }
            
            val_16 = 0;
            var val_14 = 0;
            val_17 = 1152921520001245096;
            label_16:
            val_14 = 0;
            goto label_2;
            label_15:
            val_18 = mem[Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors.TouchingNeighborTypes + 32];
            val_18 = Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors.TouchingNeighborTypes + 32;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_1 = group.cell14.cell3.Get(type:  val_18);
            if((this.CanBeExtensionCandidateToGroup(cell:  val_1, group:  new Royal.Scenes.Game.Mechanics.Matches.MatchGroup() {cell14 = new Royal.Scenes.Game.Mechanics.Matches.Cell14(), explosionCalculated = false, canExplode = false, exists = false})) != false)
            {
                    val_16 = 1;
                this.extensions[0] = val_1;
                this.extensions[0] = val_18;
            }
            
            val_14 = 1;
            label_2:
            val_19 = null;
            val_19 = null;
            if(val_14 < Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors.TouchingNeighborTypes.Length)
            {
                goto label_15;
            }
            
            val_20 = -1785462784;
            val_14 = val_14 + 1;
            if(val_14 < val_20)
            {
                goto label_16;
            }
            
            if(val_16 < 1)
            {
                goto label_17;
            }
            
            val_18 = 0;
            var val_17 = 0;
            label_45:
            if((1152921520001245096 & 1) != 0)
            {
                goto label_41;
            }
            
            val_17 = this.extensions[val_18];
            int val_3 = Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighborType.OppositeNeighbor(type:  this.extensions[val_18]);
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_4 = mem[this.extensions[0x0][0] + 40].Get(type:  val_3);
            var val_5 = (val_4 == 0) ? 0 : (val_4);
            if(val_4 != null)
            {
                    val_21 = val_4 == null ? 0 : val_4 + 40.Get(type:  val_3);
            }
            else
            {
                    val_21 = 0;
            }
            
            if((this.CanBeExtensionToGroup(cell:  val_21, group:  new Royal.Scenes.Game.Mechanics.Matches.MatchGroup() {cell14 = new Royal.Scenes.Game.Mechanics.Matches.Cell14(), explosionCalculated = false, canExplode = false, exists = false})) == false)
            {
                goto label_27;
            }
            
            if((1152921520001245096 & 1) != 0)
            {
                goto label_28;
            }
            
            this.visitMatrix.SetAsVisited(x:  10360992, y:  0, group:  0);
            if((1152921520001245096 & 1) != 0)
            {
                goto label_41;
            }
            
            label_28:
            val_14 = 1;
            goto label_32;
            label_27:
            val_14 = 0;
            label_32:
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_8 = mem[this.extensions[0x0][0] + 40].Get(type:  this.extensions[val_18]);
            if((this.CanBeExtensionToGroup(cell:  val_8, group:  new Royal.Scenes.Game.Mechanics.Matches.MatchGroup() {cell14 = new Royal.Scenes.Game.Mechanics.Matches.Cell14(), explosionCalculated = false, canExplode = false, exists = false})) == false)
            {
                goto label_36;
            }
            
            if((1152921520001245096 & 1) != 0)
            {
                goto label_40;
            }
            
            this.visitMatrix.SetAsVisited(x:  val_8, y:  val_8 >> 32, group:  0);
            if((1152921520001245096 & 1) == 0)
            {
                goto label_40;
            }
            
            goto label_41;
            label_36:
            if(val_14 == 0)
            {
                goto label_43;
            }
            
            label_40:
            if((1152921520001245096 & 1) == 0)
            {
                    this.visitMatrix.SetAsVisited(x:  mem[this.extensions[0x0][0] + 24], y:  (mem[this.extensions[0x0][0] + 24]) >> 32, group:  0);
            }
            
            label_43:
            val_17 = val_17 + 1;
            val_18 = val_18 + 16;
            if(val_17 < val_16)
            {
                goto label_45;
            }
            
            label_41:
            val_20 = -1785462784;
            label_17:
            val_15 = val_15;
            if(val_20 > 0)
            {
                    val_14 = 1152921505097580544;
                var val_18 = 0;
                val_17 = 1152921520001245096;
                do
            {
                val_18 = group.cell14.cell2.CurrentItem;
                val_16 = group.<PatternType>k__BackingField;
                Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_13 = val_18 + 144;
                val_18 = 0;
                val_18 = val_16;
                val_18 = 0;
                val_18 = 0;
                val_18 = val_18 + 1;
            }
            while(val_18 < (-1785462784));
            
            }
            
            label_46:
            this.allMatches.set_Item(index:  val_15, value:  new Royal.Scenes.Game.Mechanics.Matches.MatchGroup() {cell14 = new Royal.Scenes.Game.Mechanics.Matches.Cell14(), explosionCalculated = false, canExplode = false, exists = false});
        }
        private bool CanBeExtensionCandidateToGroup(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, Royal.Scenes.Game.Mechanics.Matches.MatchGroup group)
        {
            var val_6;
            if(cell != null)
            {
                    bool val_1 = cell.CanEnterToMatch();
                if(val_1 != false)
            {
                    bool val_2 = val_1.HasCurrentItem();
                if(val_2 != false)
            {
                    Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_3 = val_2.CurrentItem;
                if((val_3.<MatchType>k__BackingField) == 268435459)
            {
                    val_6 = (this.visitMatrix.IsVisited(x:  0, y:  0)) ^ 1;
                return (bool)val_6 & 1;
            }
            
            }
            
            }
            
            }
            
            val_6 = 0;
            return (bool)val_6 & 1;
        }
        private bool CanBeExtensionToGroup(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, Royal.Scenes.Game.Mechanics.Matches.MatchGroup group)
        {
            if(cell == null)
            {
                    return false;
            }
            
            bool val_1 = cell.CanEnterToMatch();
            if(val_1 == false)
            {
                    return false;
            }
            
            bool val_2 = val_1.HasCurrentItem();
            if(val_2 == false)
            {
                    return false;
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_3 = val_2.CurrentItem;
            if((val_3.<MatchType>k__BackingField) == 268435459)
            {
                    if((this.visitMatrix.IsVisited(x:  0, y:  0)) == false)
            {
                    return false;
            }
            
                return this.visitMatrix.IsVisitedBy(x:  0, y:  0, group:  128);
            }
            
            return false;
        }
        public bool ExplodeMatchGroup(Royal.Scenes.Game.Mechanics.Matches.MatchGroup matchGroup, Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_23;
            var val_24;
            var val_25;
            var val_26;
            Royal.Scenes.Game.Mechanics.Matches.MatchType val_27;
            var val_28;
            int val_29;
            int val_30;
            var val_31;
            val_24 = 1152921520002487328;
            if(32 == 0)
            {
                goto label_1;
            }
            
            if(196 == 0)
            {
                goto label_2;
            }
            
            label_18:
            Royal.Scenes.Game.Mechanics.Items.MatchItem.Collect.MatchCollectData val_1 = this.CreateCollectData(matchGroup:  new Royal.Scenes.Game.Mechanics.Matches.MatchGroup() {cell14 = new Royal.Scenes.Game.Mechanics.Matches.Cell14(), explosionCalculated = false, canExplode = false, exists = false});
            Royal.Scenes.Game.Mechanics.Items.MatchItem.SpecialItemCreation.SpecialItemCreationData val_2 = this.CreateSpecialItemData(matchGroup:  new Royal.Scenes.Game.Mechanics.Matches.MatchGroup() {cell14 = new Royal.Scenes.Game.Mechanics.Matches.Cell14(), explosionCalculated = false, canExplode = false, exists = false});
            System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> val_3 = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel>();
            if((-1784294368) < 1)
            {
                goto label_3;
            }
            
            var val_22 = 0;
            val_25 = 100;
            val_26 = 0;
            do
            {
                if((matchGroup.cell14.cell6.HasStaticItem(itemType:  4)) != false)
            {
                    bool val_5 = matchGroup.cell14.cell6.ExplodeTopMostAboveItem(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id});
            }
            else
            {
                    Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_6 = matchGroup.cell14.cell2.CurrentItem;
                if(val_6 != null)
            {
                    val_6 = val_6 + 432;
                Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_8 = val_6 + 288;
                val_27 = 0;
                int val_9 = System.Math.Min(val1:  100, val2:  -1784286176);
                int val_10 = System.Math.Max(val1:  0, val2:  -1784286176);
                val_25 = System.Math.Min(val1:  100, val2:  268435459);
                val_26 = System.Math.Max(val1:  0, val2:  268435459);
                val_3.Add(item:  matchGroup.<MatchType>k__BackingField);
            }
            
            }
            
                val_22 = val_22 + 1;
            }
            while(val_22 < (-1784294368));
            
            goto label_17;
            label_1:
            mem[1152921520002413601] = 0;
            matchGroup.specialItemCreationCell = 1;
            if(1179403647 != 0)
            {
                goto label_18;
            }
            
            label_2:
            val_28 = 0;
            return (bool)val_28;
            label_3:
            val_25 = 100;
            val_26 = 0;
            label_17:
            if(GetCreationCell() != null)
            {
                    val_23 = GetCreationCell();
                mem[1152921520002381520] + 56.CreateSpecialItemForMatchGroup(group:  new Royal.Scenes.Game.Mechanics.Matches.MatchGroup() {cell14 = new Royal.Scenes.Game.Mechanics.Matches.Cell14(), explosionCalculated = data.point.x, canExplode = data.point.x, exists = data.point.x}, cell:  val_23);
                mem[1152921520002381520] + 56.DestroyTouchingItems(destroyedCells:  val_3, matchType:  268435459);
            }
            else
            {
                    if((-1784224592) == 2)
            {
                    val_29 = data.point.x;
            }
            else
            {
                    if(100 == val_26)
            {
                    val_30 = val_26;
                val_31 = ((100 < 0) ? (100 + 1) : 100) >> 1;
            }
            else
            {
                    var val_16 = 100 + val_26;
                val_31 = 100;
                val_30 = ((val_16 < 0) ? (val_16 + 1) : (val_16)) >> 1;
            }
            
                Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_18 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  100, y:  val_30);
                val_29 = val_18.x;
            }
            
                val_23 = mem[1152921520002381512].Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_29, y = val_29}];
                val_27 = 268435459;
                UnityEngine.Vector3 val_20 = val_23.GetViewPosition();
                TryCollectMadness(matchType:  val_27, originPosition:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, count:  -1784294368, animationDelayInFrames:  5, createdItem:  0, remainingMoves:  false);
                DestroyTouchingItems(destroyedCells:  val_3, matchType:  268435459);
                mem[1152921520002381584].PlayMatchExplode(userSwipe:  ((-1784224592) == 2) ? 1 : 0);
            }
            
            val_28 = 1;
            return (bool)val_28;
        }
        private Royal.Scenes.Game.Mechanics.Items.MatchItem.Collect.MatchCollectData CreateCollectData(Royal.Scenes.Game.Mechanics.Matches.MatchGroup matchGroup)
        {
            System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.Config.ItemModel> val_4;
            this.collectSorter.Clear();
            var val_1 = ((-1783765248) != 1) ? (1 + 1) : 1;
            if((-1783761152) >= 1)
            {
                    var val_4 = 0;
                do
            {
                this.collectSorter.Add(item:  matchGroup.cell14.cell2.CurrentItem);
                val_4 = val_4 + 1;
            }
            while(val_4 < (-1783761152));
            
            }
            
            this.collectSorter.Sort(comparer:  Royal.Scenes.Game.Mechanics.Board.Grid.Sorter.ItemSorter.BottomLeftHorizontalSorter);
            val_4 = this.collectSorter;
            var val_5 = 0;
            do
            {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                Add(cell:  Royal.Scenes.Game.Mechanics.Board.Grid.Sorter.ItemSorter.TopLeftHorizontalSorter.__il2cppRuntimeField_20.CurrentCell);
                val_4 = this.collectSorter;
                val_5 = val_5 + 1;
            }
            while(val_4 != null);
            
            throw new NullReferenceException();
        }
        private Royal.Scenes.Game.Mechanics.Items.MatchItem.SpecialItemCreation.SpecialItemCreationData CreateSpecialItemData(Royal.Scenes.Game.Mechanics.Matches.MatchGroup matchGroup)
        {
            var val_2;
            System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> val_3;
            var val_4;
            var val_5;
            byte val_6;
            Royal.Scenes.Game.Mechanics.Items.MatchItem.SpecialItemCreation.SpecialItemCreationData val_0;
            val_3 = 1152921520003400736;
            val_4 = val_0;
            val_5 = -1783311232;
            if(val_5 == 1)
            {
                    return val_0;
            }
            
            val_6 = matchGroup.<Id>k__BackingField;
            if(val_6 == 0)
            {
                    val_6 = matchGroup.<Id>k__BackingField;
            }
            
            this.specialCreationSorter.Clear();
            this.specialCreationSorter.Add(item:  val_6);
            if((-1783307136) < 1)
            {
                goto label_6;
            }
            
            label_21:
            if((1152921520003400744 == val_6) || ((matchGroup.cell14.cell6.HasStaticItem(itemType:  4)) == true))
            {
                goto label_19;
            }
            
            label_17:
            int val_2 = 5 - 4;
            if(val_2 >= (matchGroup.<Id>k__BackingField + 24))
            {
                goto label_13;
            }
            
            if((matchGroup.<Id>k__BackingField + 24) <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(V0.16B < 0)
            {
                goto label_16;
            }
            
            var val_3 = 5 + 1;
            if(this.specialCreationSorter != null)
            {
                goto label_17;
            }
            
            label_13:
            this.specialCreationSorter.Add(item:  matchGroup.<MatchType>k__BackingField);
            goto label_19;
            label_16:
            this.specialCreationSorter.Insert(index:  val_2, item:  matchGroup.<MatchType>k__BackingField);
            label_19:
            var val_4 = -1783307136;
            val_4 = 0 + 1;
            if(val_4 < val_4)
            {
                goto label_21;
            }
            
            label_6:
            val_3 = this.specialCreationSorter;
            val_2 = 0;
            do
            {
                if(val_2 >= val_4)
            {
                    return val_0;
            }
            
                val_4 = val_4 & 4294967295;
                if(val_2 >= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_5 = val_4 + 0;
                Add(cell:  ((-1783307136 & 4294967295) + 0) + 32);
                val_3 = this.specialCreationSorter;
                val_2 = val_2 + 1;
            }
            while(val_3 != null);
            
            throw new NullReferenceException();
        }
        private void DestroyTouchingItems(System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> destroyedCells, Royal.Scenes.Game.Mechanics.Matches.MatchType matchType)
        {
            int val_2;
            int val_3;
            var val_5;
            var val_7;
            var val_8;
            Royal.Scenes.Game.Mechanics.Explode.ExplodeData val_1 = Royal.Scenes.Game.Mechanics.Explode.Exploder.Next(trigger:  5, matchType:  matchType);
            int val_5 = val_2;
            if(val_5 < 1)
            {
                    return;
            }
            
            val_5 = 1152921505112170496;
            var val_6 = 0;
            label_16:
            if(val_6 >= val_5)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_7 = 0;
            val_5 = val_5 + 0;
            goto label_4;
            label_15:
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_4 = (val_2 + 0) + 32 + 40.Get(type:  Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors.TouchingNeighborTypes + 32);
            if(val_4 != null)
            {
                    val_4.ExplodeCurrentItemByNearMatch(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_3, y = val_3}, trigger = val_3, id = val_5});
            }
            
            val_7 = 1;
            label_4:
            val_8 = null;
            val_8 = null;
            if(val_7 < Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors.TouchingNeighborTypes.Length)
            {
                goto label_15;
            }
            
            val_6 = val_6 + 1;
            if(val_6 < Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors.TouchingNeighborTypes)
            {
                goto label_16;
            }
        
        }
        private bool <CreateMatchesFromThrees>b__27_0(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            if(cell == null)
            {
                    return false;
            }
            
            if(this.visitMatrix != null)
            {
                    return this.visitMatrix.IsVisited(x:  cell, y:  cell >> 32);
            }
            
            throw new NullReferenceException();
        }
        private bool <CreateMatchesFromThrees>b__27_1(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            if(cell == null)
            {
                    return false;
            }
            
            if(this.visitMatrix != null)
            {
                    return this.visitMatrix.IsVisited(x:  cell, y:  cell >> 32);
            }
            
            throw new NullReferenceException();
        }
    
    }

}
