using UnityEngine;

namespace Royal.Scenes.Game.Utils.LevelParser
{
    public class LevelParser
    {
        // Fields
        private int <MoveCount>k__BackingField;
        private sbyte <Difficulty>k__BackingField;
        private bool <IsLevelRandomized>k__BackingField;
        private bool <IsBonusLevel>k__BackingField;
        private readonly Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory;
        private Royal.Scenes.Game.Utils.FlatLevel.FTiledLevel tiledLevel;
        private int[,] itemGrid;
        private Royal.Scenes.Game.Utils.LevelParser.LevelSet[] sets;
        private Royal.Scenes.Game.Mechanics.Matches.MatchType[] colors;
        private Royal.Scenes.Game.Mechanics.Matches.MatchType mustHaveColor;
        private Royal.Scenes.Game.Mechanics.Matches.MatchType replacedColor;
        
        // Properties
        public int MoveCount { get; set; }
        public sbyte Difficulty { get; set; }
        public bool IsLevelRandomized { get; set; }
        public bool IsBonusLevel { get; set; }
        public string LevelName { get; }
        
        // Methods
        public int get_MoveCount()
        {
            return (int)this.<MoveCount>k__BackingField;
        }
        public void set_MoveCount(int value)
        {
            this.<MoveCount>k__BackingField = value;
        }
        public sbyte get_Difficulty()
        {
            return (sbyte)this.<Difficulty>k__BackingField;
        }
        private void set_Difficulty(sbyte value)
        {
            this.<Difficulty>k__BackingField = value;
        }
        public bool get_IsLevelRandomized()
        {
            return (bool)this.<IsLevelRandomized>k__BackingField;
        }
        private void set_IsLevelRandomized(bool value)
        {
            this.<IsLevelRandomized>k__BackingField = value;
        }
        public bool get_IsBonusLevel()
        {
            return (bool)this.<IsBonusLevel>k__BackingField;
        }
        private void set_IsBonusLevel(bool value)
        {
            this.<IsBonusLevel>k__BackingField = value;
        }
        public string get_LevelName()
        {
        
        }
        public LevelParser(Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory)
        {
            this.itemFactory = itemFactory;
        }
        public int GetWidth()
        {
            return -1953150432;
        }
        public int GetHeight()
        {
            return -1953038432;
        }
        public System.Nullable<Royal.Scenes.Game.Utils.FlatLevel.FCurtainData> GetCurtain(int i)
        {
        
        }
        public int GetCurtainsLength()
        {
        
        }
        public System.Nullable<Royal.Scenes.Game.Utils.FlatLevel.FDrillData> GetDrill(int i)
        {
        
        }
        public int GetDrillLength()
        {
        
        }
        public System.Nullable<Royal.Scenes.Game.Utils.FlatLevel.FCellGroupData> GetCupShelfData(int i)
        {
        
        }
        public int GetCupShelvesLength()
        {
        
        }
        public System.Nullable<Royal.Scenes.Game.Utils.FlatLevel.FCellGroupData> GetSoilGroupData(int i)
        {
        
        }
        public int GetSoilGroupsLength()
        {
        
        }
        public bool GetPropellerIgnoresChain()
        {
        
        }
        public Royal.Scenes.Game.Utils.FlatLevel.FTiledCell GetCell(int x, int y)
        {
            int val_6 = y;
            val_6 = x + (this.GetWidth() * val_6);
            return new Royal.Scenes.Game.Utils.FlatLevel.FTiledCell() {__p = new FlatBuffers.Table() {bb_pos = -1951917456, bb = public Royal.Scenes.Game.Utils.FlatLevel.FTiledCell System.Nullable<Royal.Scenes.Game.Utils.FlatLevel.FTiledCell>::get_Value()}};
        }
        public int GetItemAtCell(int x, int y)
        {
            var val_1 = X9 + 16;
            val_1 = (long)y + (val_1 * (long)x);
            return (int)this.itemGrid[val_1];
        }
        public void Parse(int levelNo, byte[] rawData, out System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Goal.GoalType, Royal.Scenes.Game.Mechanics.Goal.GoalTuple> goalDict, out System.Collections.Generic.Dictionary<int, int> counts, out int curtainCellCount, out int drillCount, out int chainCount)
        {
            var val_9;
            var val_10;
            sbyte val_11;
            int val_12;
            val_9 = 1152921519835254032;
            val_10 = this;
            Royal.Scenes.Game.Utils.FlatLevel.FTiledLevel val_2 = Royal.Scenes.Game.Utils.FlatLevel.FTiledLevel.GetRootAsFTiledLevel(_bb:  new FlatBuffers.ByteBuffer(buffer:  rawData), obj:  new Royal.Scenes.Game.Utils.FlatLevel.FTiledLevel() {__p = new FlatBuffers.Table()});
            this.tiledLevel = val_2;
            mem[1152921519835181144] = val_2.__p.bb;
            System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Goal.GoalType, Royal.Scenes.Game.Mechanics.Goal.GoalTuple> val_3 = new System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Goal.GoalType, Royal.Scenes.Game.Mechanics.Goal.GoalTuple>();
            goalDict = val_3;
            this.ParseGoals(goalDict:  val_3);
            this.SelectReplaceColorForMustMatchItem(goalDict:  val_3);
            System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_4 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
            counts = val_4;
            this.ParseCounts(counts:  val_4);
            this.<MoveCount>k__BackingField = 1152921519835181136;
            if(levelNo < 39)
            {
                goto label_1;
            }
            
            if(0 != 5)
            {
                goto label_2;
            }
            
            val_11 = 1;
            goto label_9;
            label_1:
            val_11 = 0;
            label_9:
            this.<Difficulty>k__BackingField = val_11;
            if(1152921519835181136 >= 1)
            {
                    val_9 = 1152921519835156080;
                do
            {
                val_10 = 0 + 1;
            }
            while(val_10 < 1152921519835181136);
            
            }
            else
            {
                    val_12 = 0;
            }
            
            curtainCellCount = val_12;
            drillCount = 1152921519835181136;
            chainCount = 1152921519835181136;
            return;
            label_2:
            if((levelNo == 39) || (levelNo == 49))
            {
                goto label_9;
            }
            
            var val_7 = (0 == 9) ? 1 : 0;
            val_7 = val_7 << 1;
            goto label_9;
        }
        public bool ShouldForceReloadLevel()
        {
            var val_4;
            if((Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.MadnessManager>(id:  10).ShouldShowIcon) != false)
            {
                    var val_3 = ((val_1.<CollectMatchType>k__BackingField) != this.mustHaveColor) ? 1 : 0;
                return (bool)val_4;
            }
            
            val_4 = 0;
            return (bool)val_4;
        }
        private void SelectReplaceColorForMustMatchItem(System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Goal.GoalType, Royal.Scenes.Game.Mechanics.Goal.GoalTuple> goalDict)
        {
            Royal.Scenes.Game.Utils.LevelParser.TiledId val_7;
            var val_9;
            Royal.Scenes.Game.Mechanics.Matches.MatchType val_15;
            var val_16;
            Royal.Scenes.Game.Utils.LevelParser.LevelParser val_17;
            object val_18;
            var val_19;
            var val_20;
            var val_21;
            Royal.Player.Context.Units.MadnessManager val_1 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.MadnessManager>(id:  10);
            val_18 = val_1;
            if(val_1.ShouldShowIcon == false)
            {
                goto label_4;
            }
            
            val_15 = val_1.<CollectMatchType>k__BackingField;
            this.mustHaveColor = 0;
            if(val_15 == 0)
            {
                    return;
            }
            
            Royal.Scenes.Game.Mechanics.Matches.MatchType[] val_3 = this.ParseColors();
            if((System.Linq.Enumerable.Contains<Royal.Scenes.Game.Mechanics.Matches.MatchType>(source:  val_3, value:  val_15)) == true)
            {
                    return;
            }
            
            this.mustHaveColor = val_15;
            int val_16 = val_3.Length;
            if(val_16 < 1)
            {
                goto label_32;
            }
            
            var val_21 = 0;
            val_16 = val_16 & 4294967295;
            var val_18 = 0;
            goto label_31;
            label_4:
            this.mustHaveColor = 0;
            return;
            label_31:
            Royal.Scenes.Game.Mechanics.Matches.MatchType val_17 = val_3[0];
            Dictionary.Enumerator<TKey, TValue> val_6 = goalDict.GetEnumerator();
            label_17:
            if(((-1951150176) & 1) == 0)
            {
                goto label_16;
            }
            
            if((Royal.Scenes.Game.Mechanics.Items.Config.ItemExtensions.ToGoalType(matchType:  val_17)) != val_9)
            {
                goto label_17;
            }
            
            val_16 = 1;
            goto label_18;
            label_16:
            val_16 = 0;
            label_18:
            val_18 = val_18 + 1;
            val_19 = -1951150368;
            val_19 = 152;
            val_7.Dispose();
            if(val_18 != 1)
            {
                    var val_10 = ((val_19 + ((0 + 1)) << 2) == 152) ? 1 : 0;
                val_10 = ((val_18 >= 0) ? 1 : 0) & val_10;
                val_18 = val_18 - val_10;
            }
            
            if(1152921519835578176 >= 1)
            {
                    var val_20 = 0;
                do
            {
                var val_19 = val_9;
                val_19 = val_19 & 255;
                if(val_19 != 0)
            {
                    if((Royal.Scenes.Game.Utils.LevelParser.TiledToTypeConverter.GetColorForTiledId(tileId:  val_7)) == val_17)
            {
                goto label_22;
            }
            
            }
            
                val_20 = val_20 + 1;
            }
            while(val_20 < 1152921519835578176);
            
            }
            
            val_20 = 0;
            goto label_24;
            label_22:
            val_20 = 1;
            label_24:
            val_21 = 0;
            goto label_25;
            label_28:
            val_21 = 1;
            label_25:
            if(val_21 >= (-1951150272))
            {
                goto label_26;
            }
            
            if(((-1951150272) < 7) || ((Royal.Scenes.Game.Utils.LevelParser.TiledToTypeConverter.GetColorForTiledId(tileId:  val_7)) != val_17))
            {
                goto label_28;
            }
            
            goto label_29;
            label_26:
            if(((val_16 | val_20) & 1) == 0)
            {
                goto label_30;
            }
            
            label_29:
            val_21 = val_21 + 1;
            if(val_21 < (val_3.Length << ))
            {
                goto label_31;
            }
            
            goto label_32;
            label_30:
            mem[1152921519835578220] = val_17;
            label_32:
            object[] val_15 = new object[2];
            val_17 = this;
            val_15 = 1152921505086238720;
            val_7 = mem[1152921519835578220];
            val_15[0] = val_7;
            val_18 = val_15;
            val_15[1] = val_18;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  5, log:  "{0} will be replaced by {1}", values:  val_15);
        }
        private static sbyte PrepareDifficulty(int levelNo)
        {
            var val_3;
            if(levelNo < 39)
            {
                goto label_0;
            }
            
            if(0 != 5)
            {
                goto label_1;
            }
            
            val_3 = 1;
            return (sbyte)val_3;
            label_0:
            val_3 = 0;
            return (sbyte)val_3;
            label_1:
            if(levelNo == 39)
            {
                    return (sbyte)val_3;
            }
            
            if(levelNo == 49)
            {
                    return (sbyte)val_3;
            }
            
            return (sbyte)((0 == 9) ? 1 : 0) << 1;
        }
        public void PrepareGrid()
        {
            Royal.Scenes.Game.Utils.LevelParser.LevelSet[] val_1 = this.ParseSets();
            this.sets = val_1;
            this.itemFactory.itemCreator.AddAvailableSets(itemSets:  val_1);
            Royal.Scenes.Game.Mechanics.Matches.MatchType[] val_2 = this.ParseColors();
            this.colors = val_2;
            this.itemFactory.itemCreator = val_2;
            this.itemFactory.itemCreator = this.ParsePotionColors();
            this.itemFactory.itemCreator.UpdateLowMatchRatios(lowMatchRatios:  this.tiledLevel);
            this.itemFactory.itemCreator = this.ParseDrills();
            this.itemFactory.itemCreator = this.ParseLightBulbColorOrder();
            this.ParsePredefined();
            this.ParseCurtains();
            this.itemGrid = this.TransformToGridWithRandomMatchItems();
        }
        private void ParseCurtains()
        {
            Royal.Scenes.Game.Utils.LevelParser.TiledId val_3;
            if(this.tiledLevel == 0)
            {
                    return;
            }
            
            if(this.tiledLevel < 1)
            {
                    return;
            }
            
            var val_4 = 0;
            do
            {
                Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.CurtainHelper>(contextId:  26).AddCurtain(id:  -1950255008, curtainId:  val_3, order:  -1950255008, target:  -1950255008, width:  -1950255008, height:  -1950255008, minX:  -1950255008, minY:  val_3);
                val_4 = val_4 + 1;
            }
            while(val_4 < this.tiledLevel);
        
        }
        private System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint> ParseDrills()
        {
            System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint> val_1 = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint>();
            if(this.tiledLevel == 0)
            {
                    return val_1;
            }
            
            System.Collections.Generic.List<Royal.Scenes.Game.Utils.FlatLevel.FDrillData> val_2 = new System.Collections.Generic.List<Royal.Scenes.Game.Utils.FlatLevel.FDrillData>(capacity:  5);
            if(this.tiledLevel >= 1)
            {
                    var val_10 = 0;
                do
            {
                val_2.Add(item:  new Royal.Scenes.Game.Utils.FlatLevel.FDrillData() {__p = new FlatBuffers.Table() {bb_pos = -1950116416, bb = public Royal.Scenes.Game.Utils.FlatLevel.FDrillData System.Nullable<Royal.Scenes.Game.Utils.FlatLevel.FDrillData>::get_Value()}});
                Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_9 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  -1950116464, y:  -1950116464);
                val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_9.x, y = val_9.x});
                val_10 = val_10 + 1;
            }
            while(val_10 < this.tiledLevel);
            
            }
            
            this.itemFactory.itemCreator = val_2;
            return val_1;
        }
        private int[] ParseLowMatchRatios()
        {
        
        }
        private Royal.Scenes.Game.Mechanics.Matches.MatchType[] ParseColors()
        {
            Royal.Scenes.Game.Mechanics.Matches.MatchType val_2;
            Royal.Scenes.Game.Mechanics.Matches.MatchType[] val_1 = new Royal.Scenes.Game.Mechanics.Matches.MatchType[0];
            if(val_1.Length < 1)
            {
                    return val_1;
            }
            
            var val_2 = 0;
            label_7:
            if((this.replacedColor == 0) || (this.tiledLevel != this.replacedColor))
            {
                goto label_4;
            }
            
            val_2 = this.mustHaveColor;
            if(val_2 != 0)
            {
                goto label_5;
            }
            
            label_4:
            val_2 = this.tiledLevel;
            label_5:
            mem2[0] = val_2;
            val_2 = val_2 + 1;
            if(val_2 < (val_1.Length << ))
            {
                goto label_7;
            }
            
            return val_1;
        }
        private Royal.Scenes.Game.Mechanics.Matches.MatchType[] ParseLightBulbColorOrder()
        {
            Royal.Scenes.Game.Mechanics.Matches.MatchType[] val_1 = new Royal.Scenes.Game.Mechanics.Matches.MatchType[0];
            if(val_1.Length < 1)
            {
                    return val_1;
            }
            
            var val_2 = 0;
            do
            {
                mem2[0] = this.tiledLevel;
                val_2 = val_2 + 1;
            }
            while(val_2 < (val_1.Length << ));
            
            return val_1;
        }
        private Royal.Scenes.Game.Mechanics.Matches.MatchType[][] ParsePotionColors()
        {
            var val_2;
            var val_8;
            if(this.tiledLevel != 0)
            {
                    val_8 = new Royal.Scenes.Game.Mechanics.Matches.MatchType[][0];
                if(val_1.Length < 1)
            {
                    return (Royal.Scenes.Game.Mechanics.Matches.MatchType[][])val_8;
            }
            
                var val_9 = 0;
                do
            {
                var val_7 = val_2;
                val_7 = val_7 & 255;
                var val_4 = (val_7 != 0) ? -1949611040 : 0;
                Royal.Scenes.Game.Mechanics.Matches.MatchType[] val_5 = new Royal.Scenes.Game.Mechanics.Matches.MatchType[0];
                if((val_5.Length << 32) >= 1)
            {
                    var val_8 = 0;
                do
            {
                mem2[0] = val_7;
                val_8 = val_8 + 1;
            }
            while(val_8 < (long)val_5.Length);
            
            }
            
                val_9 = val_9 + 1;
                val_8[val_9] = val_5;
            }
            while(val_9 < (val_1.Length << ));
            
                return (Royal.Scenes.Game.Mechanics.Matches.MatchType[][])val_8;
            }
            
            val_8 = 0;
            return (Royal.Scenes.Game.Mechanics.Matches.MatchType[][])val_8;
        }
        private void ParsePredefined()
        {
            Royal.Scenes.Game.Utils.LevelParser.TiledId val_2;
            Royal.Scenes.Game.Utils.LevelParser.TiledId val_8;
            if(this.tiledLevel < 1)
            {
                    return;
            }
            
            var val_8 = 0;
            do
            {
                Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_3 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  -1949444736, y:  -1949444736);
                if((-1949444736) >= 1)
            {
                    var val_7 = 0;
                do
            {
                val_8;
                if((this.replacedColor != 0) && (this.mustHaveColor != 0))
            {
                    if((Royal.Scenes.Game.Mechanics.Items.Config.ItemExtensions.ToMatchType(itemType:  val_2)) == this.replacedColor)
            {
                    val_8 = Royal.Scenes.Game.Mechanics.Items.Config.ItemExtensions.ToTiledId(matchType:  this.mustHaveColor);
            }
            
            }
            
                this.itemFactory.itemCreator.AddPredefinedItem(point:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_3.x, y = val_3.x}, model:  this.itemFactory.itemCreator.CreateItemModelForStart(tiledId:  val_8, cellModel:  0));
                val_7 = val_7 + 1;
            }
            while(val_7 < (-1949444736));
            
            }
            
                val_8 = val_8 + 1;
            }
            while(val_8 < this.tiledLevel);
        
        }
        private Royal.Scenes.Game.Utils.LevelParser.LevelSet[] ParseSets()
        {
            string val_3;
            string val_11;
            int val_12;
            Royal.Scenes.Game.Utils.LevelParser.LevelSet val_13;
            Royal.Scenes.Game.Utils.LevelParser.TiledId val_14;
            Royal.Scenes.Game.Utils.LevelParser.LevelSet[] val_1 = new Royal.Scenes.Game.Utils.LevelParser.LevelSet[0];
            if(val_1.Length < 1)
            {
                    return val_1;
            }
            
            var val_10 = 0;
            do
            {
                val_11;
                val_12;
                Royal.Scenes.Game.Utils.LevelParser.LevelSet val_5 = null;
                val_13 = val_5;
                val_5 = new Royal.Scenes.Game.Utils.LevelParser.LevelSet(name:  val_3, canFall:  false, createRatio:  System.Math.Max(val1:  1, val2:  -1949239584), birdMax:  -1949239584, frogMax:  -1949239584);
                val_1[val_10] = val_13;
                if((-1949239584) >= 1)
            {
                    do
            {
                val_14;
                if((this.replacedColor != 0) && (this.mustHaveColor != 0))
            {
                    if((Royal.Scenes.Game.Mechanics.Items.Config.ItemExtensions.ToMatchType(itemType:  val_3)) == this.replacedColor)
            {
                    val_14 = Royal.Scenes.Game.Mechanics.Items.Config.ItemExtensions.ToTiledId(matchType:  this.mustHaveColor);
            }
            
            }
            
                val_13 = mem[val_1[0x0] + 32 + 24];
                val_13 = val_1[0x0] + 32 + 24;
                val_12 = System.Math.Max(val1:  1, val2:  -1949239632);
                .id = val_14;
                .createRatio = val_12;
                val_13.Add(item:  new Royal.Scenes.Game.Utils.LevelParser.LevelSetElement());
                val_11 = 0 + 1;
            }
            while(val_11 < (-1949239584));
            
            }
            
                if((-1949239584) >= 1)
            {
                    do
            {
                val_13 = mem[val_1[0x0] + 32];
                val_13 = val_1[0x0] + 32;
                this.itemFactory.itemCreator.AddSetToColumn(set:  val_13, columnIndex:  -1949239585);
                val_11 = 0 + 1;
            }
            while(val_11 < (-1949239584));
            
            }
            
                val_10 = val_10 + 1;
            }
            while(val_10 < val_1.Length);
            
            return val_1;
        }
        public void RandomizeTileGrid()
        {
            this.itemGrid = this.TransformToGridWithRandomMatchItems();
        }
        private void ParseGoals(System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Goal.GoalType, Royal.Scenes.Game.Mechanics.Goal.GoalTuple> goalDict)
        {
            Royal.Scenes.Game.Mechanics.Goal.GoalType val_2;
            mem[1152921519837841734] = 0;
            if(1152921519837841744 < 1)
            {
                    return;
            }
            
            var val_4 = 0;
            do
            {
                if((-1948886560) == 21)
            {
                    mem[1152921519837841734] = 1;
            }
            
                goalDict.Add(key:  val_2, value:  new Royal.Scenes.Game.Mechanics.Goal.GoalTuple(goalType:  val_2, targetCount:  -1948886560, isFromSettings:  false));
                val_4 = val_4 + 1;
            }
            while(val_4 < 1152921519837841744);
        
        }
        private void ParseCounts(System.Collections.Generic.Dictionary<int, int> counts)
        {
            var val_4;
            if(this.tiledLevel < 1)
            {
                    return;
            }
            
            do
            {
                counts.Add(key:  -1948760192, value:  -1948760192);
                val_4 = 0 + 1;
            }
            while(val_4 < this.tiledLevel);
        
        }
        private int GetChainCount()
        {
        
        }
        private int[,] TransformToGridWithRandomMatchItems()
        {
            int val_2;
            int val_18;
            var val_19;
            System.Int32[] val_20;
            Royal.Scenes.Game.Mechanics.Matches.MatchType val_21;
            var val_22;
            var val_23;
            var val_24;
            int val_12 = 0;
            int val_9 = 0;
            if((this.replacedColor == 0) || (this.mustHaveColor == 0))
            {
                goto label_2;
            }
            
            if((val_2 << 32) < 1)
            {
                goto label_8;
            }
            
            var val_19 = 0;
            do
            {
                val_19 = val_19 + 1;
            }
            while(val_19 < (long)val_2);
            
            goto label_8;
            label_2:
            label_8:
            val_18 = this.GetWidth();
            if(val_2.Clone() == null)
            {
                goto label_10;
            }
            
            val_19 = null;
            val_20 = X0;
            if(X0 == true)
            {
                goto label_11;
            }
            
            label_10:
            val_20 = 0;
            label_11:
            new Royal.Scenes.Game.Utils.LevelParser.LevelMatchItemRandomizer() = new Royal.Scenes.Game.Utils.LevelParser.LevelMatchItemRandomizer(data:  val_20, width:  val_18, sets:  this.sets);
            int val_8 = this.GetHeight();
            val_2 = (long)this.GetWidth();
            if(val_2 < 1)
            {
                goto label_12;
            }
            
            label_27:
            this.FindIndex(i:  0, x: out  val_9, y: out  val_9);
            val_21 = new Royal.Scenes.Game.Utils.LevelParser.LevelMatchItemRandomizer();
            int val_10 = new Royal.Scenes.Game.Utils.LevelParser.LevelMatchItemRandomizer().GetValue(index:  0);
            if(val_10 != 100)
            {
                goto label_14;
            }
            
            int val_11 = 0 - 1;
            this.FindIndex(i:  val_11, x: out  val_12, y: out  val_12);
            val_19 = 0;
            mem2[0] = new Royal.Scenes.Game.Utils.LevelParser.LevelMatchItemRandomizer().GetValue(index:  val_11, initialValue:  val_2);
            val_21 = new Royal.Scenes.Game.Utils.LevelParser.LevelMatchItemRandomizer();
            val_23 = 0;
            val_22 = 0;
            if((new Royal.Scenes.Game.Utils.LevelParser.LevelMatchItemRandomizer().GetValue(index:  0)) != 100)
            {
                goto label_19;
            }
            
            val_24 = mem[System.Int32[,].__il2cppRuntimeField_name + 16];
            val_24 = System.Int32[,].__il2cppRuntimeField_name + 16;
            val_21 = this.mustHaveColor;
            goto label_23;
            label_14:
            val_23 = 0;
            val_22 = 0;
            label_19:
            val_24 = mem[System.Int32[,].__il2cppRuntimeField_name + 16];
            val_24 = System.Int32[,].__il2cppRuntimeField_name + 16;
            label_23:
            long val_20 = 0;
            val_20 = val_24 * val_20;
            val_23 = val_20 + (val_23 << );
            mem2[0] = val_10;
            val_18 = 0 + 1;
            if(val_18 < val_2)
            {
                goto label_27;
            }
            
            goto label_28;
            label_12:
            label_28:
            this.<IsLevelRandomized>k__BackingField = new Royal.Scenes.Game.Utils.LevelParser.LevelMatchItemRandomizer().SecureAtLeastOnePossibleMatch(transformed:  null);
            return (System.Int32[,])null;
        }
        private void FindIndex(int i, out int x, out int y)
        {
            int val_1 = this.GetWidth();
            int val_2 = i / val_1;
            val_2 = i - (val_2 * val_1);
            x = val_2;
            float val_4 = (float)i;
            val_4 = val_4 / (float)this.GetWidth();
            y = null;
        }
        private int GetIndexFromPoint(int x, int y, int width)
        {
            return (int)x + (width * y);
        }
    
    }

}
