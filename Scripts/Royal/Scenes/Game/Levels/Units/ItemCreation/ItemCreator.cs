using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.ItemCreation
{
    public class ItemCreator
    {
        // Fields
        public Royal.Scenes.Game.Utils.LevelParser.LevelSet prioritizedSet;
        private Royal.Scenes.Game.Utils.LevelParser.LevelSet[] sets;
        private Royal.Scenes.Game.Mechanics.Matches.MatchType[] colors;
        private Royal.Scenes.Game.Mechanics.Matches.MatchType[][] potionColors;
        private System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint> drillMasterCellPoints;
        private Royal.Scenes.Game.Mechanics.Matches.MatchType[] lightBulbColorOrder;
        private System.Collections.Generic.List<Royal.Scenes.Game.Utils.FlatLevel.FDrillData> levelDrillData;
        private System.Collections.Generic.List<Royal.Scenes.Game.Utils.FlatLevel.FCurtainData> levelCurtainData;
        private readonly Royal.Scenes.Game.Levels.Units.LevelRandomManager levelRandomManager;
        private readonly Royal.Scenes.Game.Levels.Units.ItemCreation.ItemModelFactory itemModelFactory;
        private readonly Royal.Scenes.Game.Levels.Units.ItemCreation.PredefinedItemContainer predefinedContainer;
        private readonly Royal.Scenes.Game.Levels.Units.ItemCreation.TargetColumnSetContainer targetColumnSetContainer;
        private readonly Royal.Scenes.Game.Levels.Units.GoalManager goalManager;
        private readonly System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Items.Config.ItemType, int> createdSetItemCountExceptMatchItem;
        private int totalRatioForSetSelection;
        private readonly System.Collections.Generic.List<Royal.Scenes.Game.Utils.LevelParser.TiledId> lowMatchTileIds;
        private bool isLowMatchEnabled;
        private int[] lowMatchRatios;
        private int lowMatchTotalRatio;
        
        // Methods
        public ItemCreator(Royal.Scenes.Game.Levels.Units.LevelRandomManager randomManager)
        {
            this.levelRandomManager = randomManager;
            this.itemModelFactory = new Royal.Scenes.Game.Levels.Units.ItemCreation.ItemModelFactory();
            this.predefinedContainer = new Royal.Scenes.Game.Levels.Units.ItemCreation.PredefinedItemContainer();
            this.targetColumnSetContainer = new Royal.Scenes.Game.Levels.Units.ItemCreation.TargetColumnSetContainer();
            this.createdSetItemCountExceptMatchItem = new System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Items.Config.ItemType, System.Int32>();
            this.goalManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.GoalManager>(contextId:  11);
            this.lowMatchTileIds = new System.Collections.Generic.List<Royal.Scenes.Game.Utils.LevelParser.TiledId>();
        }
        public void Clear()
        {
            this.lowMatchTileIds.Clear();
            this.predefinedContainer.Clear();
            this.targetColumnSetContainer.Clear();
            this.totalRatioForSetSelection = 0;
            this.createdSetItemCountExceptMatchItem.Clear();
        }
        public void ClearCreatedItemsCountExceptPredefined()
        {
            this.goalManager.ClearPrerequisiteItems();
            this.createdSetItemCountExceptMatchItem.Clear();
            Dictionary.Enumerator<TKey, TValue> val_1 = this.predefinedContainer.initialItemCounts.GetEnumerator();
            label_7:
            if(( & 1) == 0)
            {
                goto label_5;
            }
            
            if(this.createdSetItemCountExceptMatchItem == null)
            {
                    throw new NullReferenceException();
            }
            
            this.createdSetItemCountExceptMatchItem.Add(key:  0, value:  0);
            goto label_7;
            label_5:
            0.Dispose();
        }
        public System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Matches.MatchType> GetColors()
        {
            var val_5;
            if((this.colors != null) && (this.colors.Length != 0))
            {
                    val_5 = System.Linq.Enumerable.ToList<Royal.Scenes.Game.Mechanics.Matches.MatchType>(source:  this.colors);
                return (System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Matches.MatchType>)val_5;
            }
            
            System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Matches.MatchType> val_2 = null;
            val_5 = val_2;
            val_2 = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Matches.MatchType>();
            var val_7 = 0;
            do
            {
                if(val_7 >= this.sets.Length)
            {
                    return (System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Matches.MatchType>)val_5;
            }
            
                Royal.Scenes.Game.Utils.LevelParser.LevelSet val_5 = this.sets[val_7];
                if(val_5 >= 1)
            {
                    var val_6 = 0;
                if(val_5 <= val_6)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                Royal.Scenes.Game.Mechanics.Matches.MatchType val_3 = Royal.Scenes.Game.Mechanics.Items.Config.ItemExtensions.ToMatchType(itemType:  Royal.Scenes.Game.Utils.LevelParser.LevelSet.__il2cppRuntimeField_byval_arg + 16);
                if((val_2.Contains(item:  val_3)) != true)
            {
                    val_2.Add(item:  val_3);
            }
            
                val_6 = val_6 + 1;
            }
            
                val_7 = val_7 + 1;
            }
            while(this.sets != null);
            
            throw new NullReferenceException();
        }
        public void AddAvailableColors(Royal.Scenes.Game.Mechanics.Matches.MatchType[] colors)
        {
            this.colors = colors;
        }
        public void AddAvailablePotionColors(Royal.Scenes.Game.Mechanics.Matches.MatchType[][] colors)
        {
            this.potionColors = colors;
        }
        public void AddAvailableSets(Royal.Scenes.Game.Utils.LevelParser.LevelSet[] itemSets)
        {
            this.sets = itemSets;
            this.SetupAvailableFillItems();
        }
        private void SetupAvailableFillItems()
        {
            this.createdSetItemCountExceptMatchItem.Clear();
            var val_3 = 0;
            label_7:
            if(val_3 >= this.sets.Length)
            {
                goto label_3;
            }
            
            Royal.Scenes.Game.Utils.LevelParser.LevelSet val_2 = this.sets[val_3];
            val_2.InitFillAvailability();
            if(val_2.ShouldPrioritize() != false)
            {
                    this.prioritizedSet = val_2;
            }
            
            val_3 = val_3 + 1;
            if(this.sets != null)
            {
                goto label_7;
            }
            
            throw new NullReferenceException();
            label_3:
            this.CalculateRandomFactors();
        }
        public void AddPredefinedItem(Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint point, Royal.Scenes.Game.Mechanics.Items.Config.ItemModel model)
        {
            if(this.predefinedContainer != null)
            {
                    this.predefinedContainer.AddPredefinedItem(cellPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = point.x, y = point.y}, model:  model);
                return;
            }
            
            throw new NullReferenceException();
        }
        public Royal.Scenes.Game.Mechanics.Items.Config.StaticItemModel CreateStaticItemForStart(Royal.Scenes.Game.Utils.LevelParser.TiledId tileId)
        {
            Royal.Scenes.Game.Levels.Units.ItemCreation.ItemSettings val_1 = Royal.Scenes.Game.Levels.Units.ItemCreation.ItemCreator.GetSettingsForStaticTileId(tiledId:  tileId);
            return (Royal.Scenes.Game.Mechanics.Items.Config.StaticItemModel)this.CreateStaticItemForStart(itemSettings:  new Royal.Scenes.Game.Levels.Units.ItemCreation.ItemSettings() {isExtraPropeller = false, isCreatedByLightball = false, isDrillMaster = false});
        }
        public Royal.Scenes.Game.Mechanics.Items.Config.StaticItemModel CreateStaticItemForStart(Royal.Scenes.Game.Levels.Units.ItemCreation.ItemSettings itemSettings)
        {
            return (Royal.Scenes.Game.Mechanics.Items.Config.StaticItemModel)this.CreateStaticItem(settings:  new Royal.Scenes.Game.Levels.Units.ItemCreation.ItemSettings() {tiledId = itemSettings.tiledId, itemType = itemSettings.tiledId, layerCount = itemSettings.layerCount, goalType = itemSettings.goalType, staticItemType = itemSettings.goalType, isExtraPropeller = itemSettings.isExtraPropeller, isCreatedByLightball = false, potionColors = itemSettings.tiledId, curtainId = -2001431376, isDrillMaster = true});
        }
        public Royal.Scenes.Game.Mechanics.Items.Config.ItemModel CreateItemModelForStart(Royal.Scenes.Game.Utils.LevelParser.TiledId tiledId, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cellModel)
        {
            Royal.Scenes.Game.Utils.LevelParser.TiledId val_4;
            int val_5;
            var val_8;
            var val_9;
            bool val_10;
            var val_11;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_16;
            Royal.Scenes.Game.Utils.LevelParser.TiledId val_17;
            Royal.Scenes.Game.Mechanics.Matches.MatchType[][] val_19;
            bool val_20;
            bool val_21;
            val_16 = cellModel;
            val_17 = 0;
            if((Royal.Scenes.Game.Utils.LevelParser.TiledToTypeConverter.IsASet(tiledId:  tiledId)) != false)
            {
                    val_17 = tiledId;
                Royal.Scenes.Game.Levels.Units.ItemCreation.ItemSettings val_3 = Royal.Scenes.Game.Levels.Units.ItemCreation.ItemCreator.GetSettingsForTileId(tiledId:  this.GetRandomItemTypeFromSet(setId:  val_17));
                val_16 = val_8;
                val_19 = val_9;
                val_20 = val_10;
                val_21 = val_11;
            }
            else
            {
                    Royal.Scenes.Game.Levels.Units.ItemCreation.ItemSettings val_12 = Royal.Scenes.Game.Levels.Units.ItemCreation.ItemCreator.GetSettingsForTileId(tiledId:  tiledId);
                val_20 = val_10;
                val_21 = val_11;
                val_19 = this.potionColors;
                if(val_16 != null)
            {
                    val_17 = cellModel.point;
                val_21 = this.drillMasterCellPoints.Contains(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_17, y = val_17});
            }
            
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_14 = Royal.Scenes.Game.Levels.Units.ItemCreation.ItemModelFactory.CreateItem(settings:  new Royal.Scenes.Game.Levels.Units.ItemCreation.ItemSettings() {tiledId = val_4, itemType = val_4, layerCount = val_5, matchType = val_5, goalType = val_16, staticItemType = val_19, isExtraPropeller = val_20, isCreatedByLightball = val_20, isDrillMaster = false});
            this.OnNewItemCreated(itemType:  val_14);
            return val_14;
        }
        private Royal.Scenes.Game.Utils.LevelParser.TiledId GetRandomItemTypeFromSet(Royal.Scenes.Game.Utils.LevelParser.TiledId setId)
        {
            Royal.Scenes.Game.Utils.LevelParser.LevelSet val_3 = this.sets[Royal.Scenes.Game.Utils.LevelParser.TiledToTypeConverter.GetSetIndex(tiledId:  setId)];
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            return (Royal.Scenes.Game.Utils.LevelParser.TiledId)(typeof(System.Random).__il2cppRuntimeField_190 + (this.levelRandomManager.random) << 3) + 32 + 16;
        }
        public Royal.Scenes.Game.Mechanics.Items.Config.ItemModel CreateItemForFillingCellAt(Royal.Scenes.Game.Mechanics.Board.Cell.FillingCellModel fillingCell, UnityEngine.Vector3 position)
        {
            var val_10;
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_11;
            if((fillingCell.<IsPredefined>k__BackingField) == false)
            {
                goto label_1;
            }
            
            val_10 = fillingCell;
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_1 = this.predefinedContainer.GetPredefinedItem(cellPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = fillingCell, y = fillingCell});
            if(val_1 == null)
            {
                goto label_3;
            }
            
            val_11 = val_1;
            goto label_4;
            label_1:
            val_10 = fillingCell + 24;
            label_3:
            if((this.targetColumnSetContainer.HasTarget(columnIndex:  506441728)) != false)
            {
                    if((this.GetRandomTargetColumnItem(fillingCell:  fillingCell, column:  0)) != 0)
            {
                goto label_8;
            }
            
            }
            
            if((this.GetRandomFillItem(fillingCell:  fillingCell)) == 0)
            {
                    Royal.Scenes.Game.Utils.LevelParser.TiledId val_5 = this.GetRandomColor();
            }
            
            label_8:
            Royal.Scenes.Game.Levels.Units.ItemCreation.ItemSettings val_6 = Royal.Scenes.Game.Levels.Units.ItemCreation.ItemCreator.GetSettingsForTileId(tiledId:  val_5);
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_7 = val_5.CreateItemWithSettings(settings:  new Royal.Scenes.Game.Levels.Units.ItemCreation.ItemSettings() {isExtraPropeller = false, isCreatedByLightball = false, isDrillMaster = false}, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
            val_11 = val_7;
            this.OnNewItemCreated(itemType:  val_7);
            label_4:
            fillingCell.AddCreatedItem(item:  val_11);
            return val_11;
        }
        public Royal.Scenes.Game.Mechanics.Items.Config.ItemModel CreateItemAt(Royal.Scenes.Game.Utils.LevelParser.TiledId tiledId, UnityEngine.Vector3 position)
        {
            Royal.Scenes.Game.Levels.Units.ItemCreation.ItemSettings val_1 = Royal.Scenes.Game.Levels.Units.ItemCreation.ItemCreator.GetSettingsForTileId(tiledId:  tiledId);
            return (Royal.Scenes.Game.Mechanics.Items.Config.ItemModel)tiledId.CreateItemWithSettings(settings:  new Royal.Scenes.Game.Levels.Units.ItemCreation.ItemSettings() {isExtraPropeller = false, isCreatedByLightball = false, isDrillMaster = false}, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
        }
        public Royal.Scenes.Game.Mechanics.Items.Config.ItemModel CreateItemAtCell(Royal.Scenes.Game.Utils.LevelParser.TiledId tiledId, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            Royal.Scenes.Game.Levels.Units.ItemCreation.ItemSettings val_1 = Royal.Scenes.Game.Levels.Units.ItemCreation.ItemCreator.GetSettingsForTileId(tiledId:  tiledId);
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_2 = tiledId.CreateItemWithSettings(settings:  new Royal.Scenes.Game.Levels.Units.ItemCreation.ItemSettings() {isExtraPropeller = false, isCreatedByLightball = false, isDrillMaster = false}, position:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B});
            0.ClearAllItems();
            0.SetAllItems(itemModel:  val_2);
            return val_2;
        }
        public static Royal.Scenes.Game.Levels.Units.ItemCreation.ItemSettings GetSettingsForTileId(Royal.Scenes.Game.Utils.LevelParser.TiledId tiledId)
        {
            Royal.Scenes.Game.Levels.Units.ItemCreation.ItemSettings val_0;
            Royal.Scenes.Game.Mechanics.Items.Config.ItemType val_1 = Royal.Scenes.Game.Utils.LevelParser.TiledToTypeConverter.AsItemType(id:  tiledId);
            Royal.Scenes.Game.Mechanics.Matches.MatchType val_3 = Royal.Scenes.Game.Mechanics.Items.Config.ItemExtensions.ToMatchType(itemType:  tiledId);
            if(val_3 != 0)
            {
                    Royal.Scenes.Game.Mechanics.Goal.GoalType val_4 = Royal.Scenes.Game.Mechanics.Items.Config.ItemExtensions.ToGoalType(matchType:  val_3);
            }
            
            val_0.isExtraPropeller = false;
            val_0.isCreatedByLightball = false;
            mem[1152921524082084386] = 0;
            val_0.tiledId = 0;
            val_0.layerCount = 0;
            mem[1152921524082084356] = 0;
            val_0.goalType = 0;
            val_0.tiledId = tiledId;
            mem[1152921524082084340] = val_1;
            val_0.itemType = Royal.Scenes.Game.Utils.LevelParser.TiledToTypeConverter.AsLayerCount(id:  tiledId);
            mem[1152921524082084348] = val_3;
            val_0.layerCount = Royal.Scenes.Game.Mechanics.Items.Config.ItemExtensions.ToGoalType(itemType:  val_1);
            mem[1152921524082084356] = 0;
            val_0.matchType = 0;
            mem[1152921524082084381] = 0;
            return val_0;
        }
        public static Royal.Scenes.Game.Levels.Units.ItemCreation.ItemSettings GetSettingsForStaticTileId(Royal.Scenes.Game.Utils.LevelParser.TiledId tiledId)
        {
            Royal.Scenes.Game.Levels.Units.ItemCreation.ItemSettings val_0;
            Royal.Scenes.Game.Mechanics.Board.Cell.StaticItemType val_1 = Royal.Scenes.Game.Utils.LevelParser.TiledToTypeConverter.AsStaticItemType(id:  tiledId);
            val_0.tiledId = tiledId;
            mem[1152921524082359988] = 0;
            val_0.itemType = Royal.Scenes.Game.Utils.LevelParser.TiledToTypeConverter.AsLayerCount(id:  tiledId);
            mem[1152921524082359996] = 0;
            val_0.layerCount = Royal.Scenes.Game.Mechanics.Items.Config.ItemExtensions.ToGoalType(itemType:  val_1);
            mem[1152921524082360004] = val_1;
            val_0.matchType = 0;
            mem[1152921524082360039] = 0;
            mem[1152921524082360021] = 0;
            mem[1152921524082360010] = 0;
            mem[1152921524082360037] = 0;
            return val_0;
        }
        public Royal.Scenes.Game.Mechanics.Items.Config.ItemModel CreateItemWithSettings(Royal.Scenes.Game.Levels.Units.ItemCreation.ItemSettings settings, UnityEngine.Vector3 position)
        {
            return (Royal.Scenes.Game.Mechanics.Items.Config.ItemModel)Royal.Scenes.Game.Levels.Units.ItemCreation.ItemModelFactory.CreateItem(settings:  new Royal.Scenes.Game.Levels.Units.ItemCreation.ItemSettings() {tiledId = settings.tiledId, itemType = settings.tiledId, layerCount = settings.layerCount, goalType = settings.goalType, staticItemType = settings.goalType, isExtraPropeller = settings.isExtraPropeller, isCreatedByLightball = false, potionColors = ???, curtainId = ???, isDrillMaster = ???});
        }
        private void OnNewItemCreated(Royal.Scenes.Game.Mechanics.Items.Config.ItemType itemType)
        {
            Royal.Scenes.Game.Utils.LevelParser.LevelSet val_8;
            if((Royal.Scenes.Game.Mechanics.Items.Config.ItemExtensions.IsFillingObstacle(itemType:  itemType)) == false)
            {
                    return;
            }
            
            bool val_3 = this.createdSetItemCountExceptMatchItem.TryGetValue(key:  itemType, value: out  0);
            this.createdSetItemCountExceptMatchItem.set_Item(key:  itemType, value:  1);
            val_8 = this.createdSetItemCountExceptMatchItem.Item[itemType];
            if(val_8 != (this.goalManager.GetGoalTargetCount(goalType:  Royal.Scenes.Game.Mechanics.Items.Config.ItemExtensions.ToGoalType(itemType:  itemType))))
            {
                    return;
            }
            
            var val_10 = 0;
            label_21:
            if(val_10 >= this.sets.Length)
            {
                goto label_8;
            }
            
            val_8 = this.sets[val_10];
            if(this.sets[val_10] < 1)
            {
                goto label_18;
            }
            
            var val_9 = 0;
            label_16:
            if(this.sets[val_10] <= val_9)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            Royal.Scenes.Game.Utils.LevelParser.LevelSet val_8 = this.sets[val_10][val_9];
            if((Royal.Scenes.Game.Utils.LevelParser.TiledToTypeConverter.AsItemType(id:  this.sets[0x0][0x0][0].name)) == itemType)
            {
                goto label_15;
            }
            
            val_9 = val_9 + 1;
            if(val_9 < val_8)
            {
                goto label_16;
            }
            
            goto label_18;
            label_15:
            if((val_9 & 2147483648) == 0)
            {
                    if(val_8 <= val_9)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                Royal.Scenes.Game.Utils.LevelParser.LevelSet.__il2cppRuntimeField_byval_arg.__unknownFiledOffset_18 = 0;
                val_8.UpdateFillAvailability();
            }
            
            label_18:
            val_10 = val_10 + 1;
            if(this.sets != null)
            {
                goto label_21;
            }
            
            throw new NullReferenceException();
            label_8:
            this.CalculateRandomFactors();
        }
        private void CalculateRandomFactors()
        {
            this.totalRatioForSetSelection = 0;
            var val_4 = 0;
            do
            {
                if(val_4 >= this.sets.Length)
            {
                    return;
            }
            
                Royal.Scenes.Game.Utils.LevelParser.LevelSet val_2 = this.sets[val_4];
                val_2.CalculateFillRatioForItems();
                if((Royal.Scenes.Game.Levels.Units.ItemCreation.ItemCreator.IsAvailableForFill(set:  val_2)) != false)
            {
                    int val_3 = this.totalRatioForSetSelection;
                val_3 = this.sets[0x0][0].createRatio + val_3;
                this.totalRatioForSetSelection = val_3;
            }
            
                val_4 = val_4 + 1;
            }
            while(this.sets != null);
            
            throw new NullReferenceException();
        }
        private Royal.Scenes.Game.Utils.LevelParser.TiledId GetRandomTargetColumnItem(Royal.Scenes.Game.Mechanics.Board.Cell.FillingCellModel fillingCell, int column)
        {
            int val_8;
            Royal.Scenes.Game.Levels.Units.ItemCreation.TargetColumnSetContainer val_9;
            val_8 = column;
            if(this.prioritizedSet != null)
            {
                    if((this.prioritizedSet.HasTargetColumn(column:  val_8)) != false)
            {
                    if(this.prioritizedSet.GetPrioritizedItem() != 0)
            {
                    return (Royal.Scenes.Game.Utils.LevelParser.TiledId)val_9;
            }
            
            }
            
            }
            
            val_9 = this.targetColumnSetContainer;
            if((val_9.GetTotalRatioForColumn(columnIndex:  val_8)) == 0)
            {
                    return (Royal.Scenes.Game.Utils.LevelParser.TiledId)val_9;
            }
            
            val_8 = this.targetColumnSetContainer.GetSetsFromColumn(columnIndex:  val_8);
            if(null >= 1)
            {
                    var val_8 = 0;
                System.Random val_5 = this.levelRandomManager.random + 1;
                if(null <= val_8)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                bool val_6 = System.Random.__il2cppRuntimeField_byval_arg.ShouldPrioritize();
                val_8 = val_8 + 1;
            }
            
            val_9 = 0;
            return (Royal.Scenes.Game.Utils.LevelParser.TiledId)val_9;
        }
        private Royal.Scenes.Game.Utils.LevelParser.TiledId GetRandomFillItem(Royal.Scenes.Game.Mechanics.Board.Cell.FillingCellModel fillingCell)
        {
            var val_5;
            var val_6;
            if(this.prioritizedSet != null)
            {
                    if(this.prioritizedSet.GetPrioritizedItem() != 0)
            {
                    return (Royal.Scenes.Game.Utils.LevelParser.TiledId)val_5;
            }
            
            }
            
            var val_6 = 0;
            val_6 = 0;
            label_10:
            if(val_6 >= (this.sets.Length << ))
            {
                goto label_5;
            }
            
            Royal.Scenes.Game.Utils.LevelParser.LevelSet val_5 = this.sets[val_6];
            if((Royal.Scenes.Game.Levels.Units.ItemCreation.ItemCreator.IsAvailableForFill(set:  val_5)) == false)
            {
                goto label_7;
            }
            
            val_6 = this.sets[0x0][0].createRatio + val_6;
            if(val_6 >= (this.levelRandomManager.random + 1))
            {
                goto label_9;
            }
            
            label_7:
            val_6 = val_6 + 1;
            if(this.sets != null)
            {
                goto label_10;
            }
            
            throw new NullReferenceException();
            label_5:
            val_5 = 0;
            return (Royal.Scenes.Game.Utils.LevelParser.TiledId)val_5;
            label_9:
            if(this.isLowMatchEnabled == false)
            {
                    return val_5.GetRandomItem();
            }
            
            if(val_5.ContainsMatchItem() == false)
            {
                    return val_5.GetRandomItem();
            }
            
            return this.GetTunedItem(levelSet:  val_5, fillingCell:  fillingCell);
        }
        private Royal.Scenes.Game.Utils.LevelParser.TiledId GetRandomColor()
        {
            object[] val_1 = new object[1];
            val_1[0] = this.totalRatioForSetSelection;
            Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  5, log:  "Couldn\'t find any item from set, returning random match item. Total:{0}", values:  val_1);
            return (Royal.Scenes.Game.Utils.LevelParser.TiledId)this.levelRandomManager.random;
        }
        private static bool IsAvailableForFill(Royal.Scenes.Game.Utils.LevelParser.LevelSet set)
        {
            bool val_4 = set.isAvailableForFill;
            if(val_4 != false)
            {
                    if(set.ShouldPrioritize() != false)
            {
                    val_4 = 0;
            }
            else
            {
                    bool val_2 = set.HasAnyTargetColumn();
                val_4 = val_2 ^ 1;
            }
            
            }
            
            val_2 = val_4;
            return (bool)val_2;
        }
        private int GetLowMatchNeighborCount()
        {
            var val_2;
            int val_2 = this.lowMatchRatios[0];
            if(this.levelRandomManager.random < val_2)
            {
                    val_2 = 0;
                return (int)(this.levelRandomManager.random >= val_3) ? (1 + 1) : 1;
            }
            
            int val_3 = this.lowMatchRatios[1];
            val_3 = val_3 + val_2;
            return (int)(this.levelRandomManager.random >= val_3) ? (1 + 1) : 1;
        }
        private Royal.Scenes.Game.Utils.LevelParser.TiledId GetTunedItem(Royal.Scenes.Game.Utils.LevelParser.LevelSet levelSet, Royal.Scenes.Game.Mechanics.Board.Cell.FillingCellModel fillingCell)
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_11;
            Royal.Scenes.Game.Utils.LevelParser.TiledId val_12;
            Royal.Scenes.Game.Utils.LevelParser.TiledId val_13;
            val_11 = fillingCell;
            int val_1 = this.GetLowMatchNeighborCount();
            if(val_1 == 0)
            {
                    return levelSet.GetRandomItem();
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_2 = val_1.Get(type:  5);
            if(val_2 == null)
            {
                goto label_6;
            }
            
            label_8:
            bool val_3 = val_2.HasTargetItem();
            if(val_3 == true)
            {
                goto label_6;
            }
            
            val_11 = val_2;
            if((val_3.Get(type:  5)) != null)
            {
                goto label_8;
            }
            
            label_6:
            this.lowMatchTileIds.Clear();
            if(val_1 == 1)
            {
                    Royal.Scenes.Game.Utils.LevelParser.TiledId val_5 = this.lowMatchTileIds.GetForbiddenTypeForOneNeighbor(targetCell:  val_11, neighborType:  5);
                val_12 = val_5;
                Royal.Scenes.Game.Utils.LevelParser.TiledId val_6 = val_5.GetForbiddenTypeForOneNeighbor(targetCell:  val_11, neighborType:  7);
                val_13 = val_6;
                Royal.Scenes.Game.Utils.LevelParser.TiledId val_7 = val_6.GetForbiddenTypeForOneNeighbor(targetCell:  val_11, neighborType:  3);
            }
            else
            {
                    Royal.Scenes.Game.Utils.LevelParser.TiledId val_8 = this.lowMatchTileIds.GetForbiddenTypeForTwoNeighbors(targetCell:  val_11, neighborType:  5);
                val_12 = val_8;
                Royal.Scenes.Game.Utils.LevelParser.TiledId val_9 = val_8.GetForbiddenTypeForTwoNeighbors(targetCell:  val_11, neighborType:  7);
                val_13 = val_9;
                Royal.Scenes.Game.Utils.LevelParser.TiledId val_10 = val_9.GetForbiddenTypeForTwoNeighbors(targetCell:  val_11, neighborType:  3);
            }
            
            if(val_12 != 0)
            {
                    this.lowMatchTileIds.Add(item:  val_12);
            }
            
            if(val_13 != 0)
            {
                    this.lowMatchTileIds.Add(item:  val_13);
            }
            
            if(val_10 == 0)
            {
                    return levelSet.GetRandomItemExcept(forbiddenIds:  this.lowMatchTileIds);
            }
            
            this.lowMatchTileIds.Add(item:  val_10);
            return levelSet.GetRandomItemExcept(forbiddenIds:  this.lowMatchTileIds);
        }
        private Royal.Scenes.Game.Utils.LevelParser.TiledId GetForbiddenTypeForTwoNeighbors(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel targetCell, int neighborType)
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_1 = this.Get(type:  neighborType);
            if(val_1 == null)
            {
                    return 0;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_2 = val_1.Get(type:  neighborType);
            if(val_2 == null)
            {
                    return 0;
            }
            
            bool val_3 = val_2.HasTargetItem();
            if(val_3 == false)
            {
                    return 0;
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_4 = val_3.TargetItem;
            if((val_4 & 1) == 0)
            {
                    return 0;
            }
            
            bool val_5 = val_4.HasTargetItem();
            if(val_5 == false)
            {
                    return 0;
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_6 = val_5.TargetItem;
            if((val_6 & 1) == 0)
            {
                    return 0;
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_7 = val_6.TargetItem;
            if((val_7.<MatchType>k__BackingField) != (val_8.<MatchType>k__BackingField))
            {
                    return 0;
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_9 = 1152921505105940480.TargetItem.TargetItem;
            return Royal.Scenes.Game.Mechanics.Items.Config.ItemExtensions.ToTiledId(matchType:  val_9.<MatchType>k__BackingField);
        }
        private Royal.Scenes.Game.Utils.LevelParser.TiledId GetForbiddenTypeForOneNeighbor(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel targetCell, int neighborType)
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_1 = this.Get(type:  neighborType);
            if(val_1 == null)
            {
                    return 0;
            }
            
            bool val_2 = val_1.HasTargetItem();
            if(val_2 == false)
            {
                    return 0;
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_3 = val_2.TargetItem;
            if((val_3 & 1) == 0)
            {
                    return 0;
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_4 = val_3.TargetItem;
            return Royal.Scenes.Game.Mechanics.Items.Config.ItemExtensions.ToTiledId(matchType:  val_4.<MatchType>k__BackingField);
        }
        public void AddSetToColumn(Royal.Scenes.Game.Utils.LevelParser.LevelSet set, int columnIndex)
        {
            if(this.targetColumnSetContainer != null)
            {
                    this.targetColumnSetContainer.AddSetToColumn(set:  set, columnIndex:  columnIndex);
                return;
            }
            
            throw new NullReferenceException();
        }
        public void UpdateLowMatchRatios(int[] lowMatchRatios)
        {
            var val_3;
            if((lowMatchRatios != null) && (lowMatchRatios.Length > 2))
            {
                    object[] val_1 = new object[3];
                val_1[0] = lowMatchRatios[0];
                val_1[1] = lowMatchRatios[0];
                val_1[2] = lowMatchRatios[1];
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  5, log:  "Lowmatch Enabled: [{0},{1},{2}]", values:  val_1);
                this.isLowMatchEnabled = true;
                this.lowMatchTotalRatio = 0;
                if(lowMatchRatios.Length >= 1)
            {
                    var val_6 = 0;
                int val_2 = lowMatchRatios.Length & 4294967295;
                do
            {
                val_6 = val_6 + 1;
                this.lowMatchTotalRatio = 0;
            }
            while(val_6 < (lowMatchRatios.Length << ));
            
            }
            
                this.lowMatchRatios = lowMatchRatios;
                return;
            }
            
            this.isLowMatchEnabled = false;
            this.lowMatchTotalRatio = 0;
            this.lowMatchRatios = 0;
            val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  5, log:  "Lowmatch Disabled", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        public void RemainingMovesStarted()
        {
            var val_4 = 0;
            do
            {
                if(val_4 >= this.sets.Length)
            {
                    return;
            }
            
                Royal.Scenes.Game.Utils.LevelParser.LevelSet val_3 = this.sets[val_4];
                if(val_3.ContainsMatchItem() != false)
            {
                    val_3.FillFourColors();
            }
            
                if(val_3.ContainsSpecialItem() != false)
            {
                    val_3 = 0;
            }
            
                val_4 = val_4 + 1;
            }
            while(this.sets != null);
            
            throw new NullReferenceException();
        }
        public void AddDrillMasters(System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint> masterPoints)
        {
            this.drillMasterCellPoints = masterPoints;
        }
        public void AddDrillData(System.Collections.Generic.List<Royal.Scenes.Game.Utils.FlatLevel.FDrillData> drillDatas)
        {
            this.levelDrillData = drillDatas;
        }
        public System.Collections.Generic.List<Royal.Scenes.Game.Utils.FlatLevel.FDrillData> GetDrillData()
        {
            return (System.Collections.Generic.List<Royal.Scenes.Game.Utils.FlatLevel.FDrillData>)this.levelDrillData;
        }
        public void AddCurtainData(System.Collections.Generic.List<Royal.Scenes.Game.Utils.FlatLevel.FCurtainData> curtainDatas)
        {
            this.levelCurtainData = curtainDatas;
        }
        public System.Collections.Generic.List<Royal.Scenes.Game.Utils.FlatLevel.FCurtainData> GetCurtainData()
        {
            return (System.Collections.Generic.List<Royal.Scenes.Game.Utils.FlatLevel.FCurtainData>)this.levelCurtainData;
        }
        public void AddLightBulbColorOrder(Royal.Scenes.Game.Mechanics.Matches.MatchType[] colorOrder)
        {
            this.lightBulbColorOrder = colorOrder;
        }
        public Royal.Scenes.Game.Mechanics.Matches.MatchType[] GetLightBulbColorOrder()
        {
            if(this.lightBulbColorOrder == null)
            {
                    return (Royal.Scenes.Game.Mechanics.Matches.MatchType[])System.Linq.Enumerable.ToArray<Royal.Scenes.Game.Mechanics.Matches.MatchType>(source:  System.Linq.Enumerable.OrderBy<Royal.Scenes.Game.Mechanics.Matches.MatchType, System.Int32>(source:  this.GetColors(), keySelector:  new System.Func<Royal.Scenes.Game.Mechanics.Matches.MatchType, System.Int32>(object:  this, method:  System.Int32 Royal.Scenes.Game.Levels.Units.ItemCreation.ItemCreator::GetLightBulbNaturalColorOrder(Royal.Scenes.Game.Mechanics.Matches.MatchType matchType))));
            }
            
            if(this.lightBulbColorOrder.Length != 0)
            {
                    return (Royal.Scenes.Game.Mechanics.Matches.MatchType[])System.Linq.Enumerable.ToArray<Royal.Scenes.Game.Mechanics.Matches.MatchType>(source:  System.Linq.Enumerable.OrderBy<Royal.Scenes.Game.Mechanics.Matches.MatchType, System.Int32>(source:  this.GetColors(), keySelector:  new System.Func<Royal.Scenes.Game.Mechanics.Matches.MatchType, System.Int32>(object:  this, method:  System.Int32 Royal.Scenes.Game.Levels.Units.ItemCreation.ItemCreator::GetLightBulbNaturalColorOrder(Royal.Scenes.Game.Mechanics.Matches.MatchType matchType))));
            }
            
            return (Royal.Scenes.Game.Mechanics.Matches.MatchType[])System.Linq.Enumerable.ToArray<Royal.Scenes.Game.Mechanics.Matches.MatchType>(source:  System.Linq.Enumerable.OrderBy<Royal.Scenes.Game.Mechanics.Matches.MatchType, System.Int32>(source:  this.GetColors(), keySelector:  new System.Func<Royal.Scenes.Game.Mechanics.Matches.MatchType, System.Int32>(object:  this, method:  System.Int32 Royal.Scenes.Game.Levels.Units.ItemCreation.ItemCreator::GetLightBulbNaturalColorOrder(Royal.Scenes.Game.Mechanics.Matches.MatchType matchType))));
        }
        private int GetLightBulbNaturalColorOrder(Royal.Scenes.Game.Mechanics.Matches.MatchType matchType)
        {
            if((matchType - 1) > 4)
            {
                    return 5;
            }
            
            return (int)36598880 + ((matchType - 1)) << 2;
        }
    
    }

}
