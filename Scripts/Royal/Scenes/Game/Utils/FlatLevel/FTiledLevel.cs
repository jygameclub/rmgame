using UnityEngine;

namespace Royal.Scenes.Game.Utils.FlatLevel
{
    public struct FTiledLevel : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public string Name { get; }
        public int Move { get; }
        public int GoalsLength { get; }
        public System.Nullable<Royal.Scenes.Game.Utils.FlatLevel.FTiledGrid> Grid { get; }
        public int PredefinedLength { get; }
        public int SetsLength { get; }
        public int ColorsLength { get; }
        public int CountsLength { get; }
        public int PotionColorsLength { get; }
        public int LowMatchLength { get; }
        public int CurtainsLength { get; }
        public int CupShelvesLength { get; }
        public int SoilGroupsLength { get; }
        public int DrillsLength { get; }
        public int LightBulbColorOrderLength { get; }
        public int ChainCount { get; }
        public bool PropellerIgnoresChain { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Scenes.Game.Utils.FlatLevel.FTiledLevel GetRootAsFTiledLevel(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Scenes.Game.Utils.FlatLevel.FTiledLevel.GetRootAsFTiledLevel(_bb:  _bb, obj:  new Royal.Scenes.Game.Utils.FlatLevel.FTiledLevel() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Scenes.Game.Utils.FlatLevel.FTiledLevel GetRootAsFTiledLevel(FlatBuffers.ByteBuffer _bb, Royal.Scenes.Game.Utils.FlatLevel.FTiledLevel obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Scenes.Game.Utils.FlatLevel.FTiledLevel() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921519862258672] = _i;
            mem[1152921519862258680] = _bb;
        }
        public Royal.Scenes.Game.Utils.FlatLevel.FTiledLevel __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921519862378864] = _i;
            mem[1152921519862378872] = _bb;
            return new Royal.Scenes.Game.Utils.FlatLevel.FTiledLevel() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public string get_Name()
        {
        
        }
        public System.Nullable<System.ArraySegment<byte>> GetNameBytes()
        {
        
        }
        public byte[] GetNameArray()
        {
        
        }
        public int get_Move()
        {
        
        }
        public System.Nullable<Royal.Scenes.Game.Utils.FlatLevel.FGoalData> Goals(int j)
        {
        
        }
        public int get_GoalsLength()
        {
        
        }
        public System.Nullable<Royal.Scenes.Game.Utils.FlatLevel.FTiledGrid> get_Grid()
        {
        
        }
        public System.Nullable<Royal.Scenes.Game.Utils.FlatLevel.FTiledPredefined> Predefined(int j)
        {
        
        }
        public int get_PredefinedLength()
        {
        
        }
        public System.Nullable<Royal.Scenes.Game.Utils.FlatLevel.FTiledSet> Sets(int j)
        {
        
        }
        public int get_SetsLength()
        {
        
        }
        public int Colors(int j)
        {
        
        }
        public int get_ColorsLength()
        {
        
        }
        public System.Nullable<System.ArraySegment<byte>> GetColorsBytes()
        {
        
        }
        public int[] GetColorsArray()
        {
        
        }
        public System.Nullable<Royal.Scenes.Game.Utils.FlatLevel.FItemCount> Counts(int j)
        {
        
        }
        public int get_CountsLength()
        {
        
        }
        public System.Nullable<Royal.Scenes.Game.Utils.FlatLevel.FPotionColor> PotionColors(int j)
        {
        
        }
        public int get_PotionColorsLength()
        {
        
        }
        public int LowMatch(int j)
        {
        
        }
        public int get_LowMatchLength()
        {
        
        }
        public System.Nullable<System.ArraySegment<byte>> GetLowMatchBytes()
        {
        
        }
        public int[] GetLowMatchArray()
        {
        
        }
        public System.Nullable<Royal.Scenes.Game.Utils.FlatLevel.FCurtainData> Curtains(int j)
        {
        
        }
        public int get_CurtainsLength()
        {
        
        }
        public System.Nullable<Royal.Scenes.Game.Utils.FlatLevel.FCellGroupData> CupShelves(int j)
        {
        
        }
        public int get_CupShelvesLength()
        {
        
        }
        public System.Nullable<Royal.Scenes.Game.Utils.FlatLevel.FCellGroupData> SoilGroups(int j)
        {
        
        }
        public int get_SoilGroupsLength()
        {
        
        }
        public System.Nullable<Royal.Scenes.Game.Utils.FlatLevel.FDrillData> Drills(int j)
        {
        
        }
        public int get_DrillsLength()
        {
        
        }
        public int LightBulbColorOrder(int j)
        {
        
        }
        public int get_LightBulbColorOrderLength()
        {
        
        }
        public System.Nullable<System.ArraySegment<byte>> GetLightBulbColorOrderBytes()
        {
        
        }
        public int[] GetLightBulbColorOrderArray()
        {
        
        }
        public int get_ChainCount()
        {
        
        }
        public bool get_PropellerIgnoresChain()
        {
            throw 36626165;
        }
        public static FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FTiledLevel> CreateFTiledLevel(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset nameOffset, int move = 0, FlatBuffers.VectorOffset goalsOffset, FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FTiledGrid> gridOffset, FlatBuffers.VectorOffset predefinedOffset, FlatBuffers.VectorOffset setsOffset, FlatBuffers.VectorOffset colorsOffset, FlatBuffers.VectorOffset countsOffset, FlatBuffers.VectorOffset potion_colorsOffset, FlatBuffers.VectorOffset low_matchOffset, FlatBuffers.VectorOffset curtainsOffset, FlatBuffers.VectorOffset cup_shelvesOffset, FlatBuffers.VectorOffset soil_groupsOffset, FlatBuffers.VectorOffset drillsOffset, FlatBuffers.VectorOffset light_bulb_color_orderOffset, int chain_count = 0, bool propeller_ignores_chain = False)
        {
            bool val_1;
            int val_2;
            var val_3;
            var val_4;
            builder.StartObject(numfields:  17);
            Royal.Scenes.Game.Utils.FlatLevel.FTiledLevel.AddChainCount(builder:  builder, chainCount:  val_2);
            Royal.Scenes.Game.Utils.FlatLevel.FTiledLevel.AddLightBulbColorOrder(builder:  builder, lightBulbColorOrderOffset:  new FlatBuffers.VectorOffset() {Value = val_4 & 4294967295});
            Royal.Scenes.Game.Utils.FlatLevel.FTiledLevel.AddDrills(builder:  builder, drillsOffset:  new FlatBuffers.VectorOffset() {Value = val_3 & 4294967295});
            Royal.Scenes.Game.Utils.FlatLevel.FTiledLevel.AddSoilGroups(builder:  builder, soilGroupsOffset:  new FlatBuffers.VectorOffset() {Value = propeller_ignores_chain & 4294967295});
            Royal.Scenes.Game.Utils.FlatLevel.FTiledLevel.AddCupShelves(builder:  builder, cupShelvesOffset:  new FlatBuffers.VectorOffset() {Value = chain_count & 4294967295});
            Royal.Scenes.Game.Utils.FlatLevel.FTiledLevel.AddCurtains(builder:  builder, curtainsOffset:  new FlatBuffers.VectorOffset() {Value = drillsOffset.Value & 4294967295});
            Royal.Scenes.Game.Utils.FlatLevel.FTiledLevel.AddLowMatch(builder:  builder, lowMatchOffset:  new FlatBuffers.VectorOffset() {Value = cup_shelvesOffset.Value & 4294967295});
            Royal.Scenes.Game.Utils.FlatLevel.FTiledLevel.AddPotionColors(builder:  builder, potionColorsOffset:  new FlatBuffers.VectorOffset() {Value = low_matchOffset.Value & 4294967295});
            Royal.Scenes.Game.Utils.FlatLevel.FTiledLevel.AddCounts(builder:  builder, countsOffset:  new FlatBuffers.VectorOffset() {Value = countsOffset.Value & 4294967295});
            Royal.Scenes.Game.Utils.FlatLevel.FTiledLevel.AddColors(builder:  builder, colorsOffset:  new FlatBuffers.VectorOffset() {Value = colorsOffset.Value & 4294967295});
            Royal.Scenes.Game.Utils.FlatLevel.FTiledLevel.AddSets(builder:  builder, setsOffset:  new FlatBuffers.VectorOffset() {Value = setsOffset.Value & 4294967295});
            Royal.Scenes.Game.Utils.FlatLevel.FTiledLevel.AddPredefined(builder:  builder, predefinedOffset:  new FlatBuffers.VectorOffset() {Value = predefinedOffset.Value & 4294967295});
            Royal.Scenes.Game.Utils.FlatLevel.FTiledLevel.AddGrid(builder:  builder, gridOffset:  new FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FTiledGrid>() {Value = gridOffset.Value & 4294967295});
            Royal.Scenes.Game.Utils.FlatLevel.FTiledLevel.AddGoals(builder:  builder, goalsOffset:  new FlatBuffers.VectorOffset() {Value = goalsOffset.Value & 4294967295});
            Royal.Scenes.Game.Utils.FlatLevel.FTiledLevel.AddMove(builder:  builder, move:  move);
            Royal.Scenes.Game.Utils.FlatLevel.FTiledLevel.AddName(builder:  builder, nameOffset:  new FlatBuffers.StringOffset() {Value = nameOffset.Value & 4294967295});
            Royal.Scenes.Game.Utils.FlatLevel.FTiledLevel.AddPropellerIgnoresChain(builder:  builder, propellerIgnoresChain:  val_1);
            FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FTiledLevel> val_20 = Royal.Scenes.Game.Utils.FlatLevel.FTiledLevel.EndFTiledLevel(builder:  builder);
            val_20.Value = val_20.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FTiledLevel>)val_20.Value;
        }
        public static void StartFTiledLevel(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  17);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddName(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset nameOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  0, x:  nameOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddMove(FlatBuffers.FlatBufferBuilder builder, int move)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  1, x:  move, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddGoals(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.VectorOffset goalsOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  2, x:  goalsOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.VectorOffset CreateGoalsVector(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FGoalData>[] data)
        {
            var val_5;
            builder.StartVector(elemSize:  4, count:  data.Length, alignment:  4);
            if(<0)
            {
                goto label_4;
            }
            
            int val_2 = data.Length & 4294967295;
            val_5 = (long)data.Length - 1;
            int val_3 = data.Length - 2;
            label_5:
            builder.AddOffset(off:  data[val_5]);
            if((val_3 & 2147483648) != 0)
            {
                goto label_4;
            }
            
            val_5 = val_5 - 1;
            val_3 = val_3 - 1;
            if(val_5 < data.Length)
            {
                goto label_5;
            }
            
            throw new IndexOutOfRangeException();
            label_4:
            FlatBuffers.VectorOffset val_4 = builder.EndVector();
            val_4.Value = val_4.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_4.Value;
        }
        public static FlatBuffers.VectorOffset CreateGoalsVectorBlock(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FGoalData>[] data)
        {
            builder.StartVector(elemSize:  4, count:  data.Length, alignment:  4);
            builder.Add<FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FGoalData>>(x:  data);
            FlatBuffers.VectorOffset val_1 = builder.EndVector();
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_1.Value;
        }
        public static void StartGoalsVector(FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
            if(builder != null)
            {
                    builder.StartVector(elemSize:  4, count:  numElems, alignment:  4);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddGrid(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FTiledGrid> gridOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  3, x:  gridOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddPredefined(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.VectorOffset predefinedOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  4, x:  predefinedOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.VectorOffset CreatePredefinedVector(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FTiledPredefined>[] data)
        {
            var val_5;
            builder.StartVector(elemSize:  4, count:  data.Length, alignment:  4);
            if(<0)
            {
                goto label_4;
            }
            
            int val_2 = data.Length & 4294967295;
            val_5 = (long)data.Length - 1;
            int val_3 = data.Length - 2;
            label_5:
            builder.AddOffset(off:  data[val_5]);
            if((val_3 & 2147483648) != 0)
            {
                goto label_4;
            }
            
            val_5 = val_5 - 1;
            val_3 = val_3 - 1;
            if(val_5 < data.Length)
            {
                goto label_5;
            }
            
            throw new IndexOutOfRangeException();
            label_4:
            FlatBuffers.VectorOffset val_4 = builder.EndVector();
            val_4.Value = val_4.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_4.Value;
        }
        public static FlatBuffers.VectorOffset CreatePredefinedVectorBlock(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FTiledPredefined>[] data)
        {
            builder.StartVector(elemSize:  4, count:  data.Length, alignment:  4);
            builder.Add<FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FTiledPredefined>>(x:  data);
            FlatBuffers.VectorOffset val_1 = builder.EndVector();
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_1.Value;
        }
        public static void StartPredefinedVector(FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
            if(builder != null)
            {
                    builder.StartVector(elemSize:  4, count:  numElems, alignment:  4);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddSets(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.VectorOffset setsOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  5, x:  setsOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.VectorOffset CreateSetsVector(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FTiledSet>[] data)
        {
            var val_5;
            builder.StartVector(elemSize:  4, count:  data.Length, alignment:  4);
            if(<0)
            {
                goto label_4;
            }
            
            int val_2 = data.Length & 4294967295;
            val_5 = (long)data.Length - 1;
            int val_3 = data.Length - 2;
            label_5:
            builder.AddOffset(off:  data[val_5]);
            if((val_3 & 2147483648) != 0)
            {
                goto label_4;
            }
            
            val_5 = val_5 - 1;
            val_3 = val_3 - 1;
            if(val_5 < data.Length)
            {
                goto label_5;
            }
            
            throw new IndexOutOfRangeException();
            label_4:
            FlatBuffers.VectorOffset val_4 = builder.EndVector();
            val_4.Value = val_4.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_4.Value;
        }
        public static FlatBuffers.VectorOffset CreateSetsVectorBlock(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FTiledSet>[] data)
        {
            builder.StartVector(elemSize:  4, count:  data.Length, alignment:  4);
            builder.Add<FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FTiledSet>>(x:  data);
            FlatBuffers.VectorOffset val_1 = builder.EndVector();
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_1.Value;
        }
        public static void StartSetsVector(FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
            if(builder != null)
            {
                    builder.StartVector(elemSize:  4, count:  numElems, alignment:  4);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddColors(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.VectorOffset colorsOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  6, x:  colorsOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.VectorOffset CreateColorsVector(FlatBuffers.FlatBufferBuilder builder, int[] data)
        {
            var val_5;
            builder.StartVector(elemSize:  4, count:  data.Length, alignment:  4);
            if(<0)
            {
                goto label_4;
            }
            
            int val_2 = data.Length & 4294967295;
            val_5 = (long)data.Length - 1;
            int val_3 = data.Length - 2;
            label_5:
            builder.AddInt(x:  data[((long)(int)((data.Length - 1))) << 2]);
            if((val_3 & 2147483648) != 0)
            {
                goto label_4;
            }
            
            val_5 = val_5 - 1;
            val_3 = val_3 - 1;
            if(val_5 < data.Length)
            {
                goto label_5;
            }
            
            throw new IndexOutOfRangeException();
            label_4:
            FlatBuffers.VectorOffset val_4 = builder.EndVector();
            val_4.Value = val_4.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_4.Value;
        }
        public static FlatBuffers.VectorOffset CreateColorsVectorBlock(FlatBuffers.FlatBufferBuilder builder, int[] data)
        {
            builder.StartVector(elemSize:  4, count:  data.Length, alignment:  4);
            builder.Add<System.Int32>(x:  data);
            FlatBuffers.VectorOffset val_1 = builder.EndVector();
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_1.Value;
        }
        public static void StartColorsVector(FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
            if(builder != null)
            {
                    builder.StartVector(elemSize:  4, count:  numElems, alignment:  4);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddCounts(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.VectorOffset countsOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  7, x:  countsOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.VectorOffset CreateCountsVector(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FItemCount>[] data)
        {
            var val_5;
            builder.StartVector(elemSize:  4, count:  data.Length, alignment:  4);
            if(<0)
            {
                goto label_4;
            }
            
            int val_2 = data.Length & 4294967295;
            val_5 = (long)data.Length - 1;
            int val_3 = data.Length - 2;
            label_5:
            builder.AddOffset(off:  data[val_5]);
            if((val_3 & 2147483648) != 0)
            {
                goto label_4;
            }
            
            val_5 = val_5 - 1;
            val_3 = val_3 - 1;
            if(val_5 < data.Length)
            {
                goto label_5;
            }
            
            throw new IndexOutOfRangeException();
            label_4:
            FlatBuffers.VectorOffset val_4 = builder.EndVector();
            val_4.Value = val_4.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_4.Value;
        }
        public static FlatBuffers.VectorOffset CreateCountsVectorBlock(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FItemCount>[] data)
        {
            builder.StartVector(elemSize:  4, count:  data.Length, alignment:  4);
            builder.Add<FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FItemCount>>(x:  data);
            FlatBuffers.VectorOffset val_1 = builder.EndVector();
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_1.Value;
        }
        public static void StartCountsVector(FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
            if(builder != null)
            {
                    builder.StartVector(elemSize:  4, count:  numElems, alignment:  4);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddPotionColors(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.VectorOffset potionColorsOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  8, x:  potionColorsOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.VectorOffset CreatePotionColorsVector(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FPotionColor>[] data)
        {
            var val_5;
            builder.StartVector(elemSize:  4, count:  data.Length, alignment:  4);
            if(<0)
            {
                goto label_4;
            }
            
            int val_2 = data.Length & 4294967295;
            val_5 = (long)data.Length - 1;
            int val_3 = data.Length - 2;
            label_5:
            builder.AddOffset(off:  data[val_5]);
            if((val_3 & 2147483648) != 0)
            {
                goto label_4;
            }
            
            val_5 = val_5 - 1;
            val_3 = val_3 - 1;
            if(val_5 < data.Length)
            {
                goto label_5;
            }
            
            throw new IndexOutOfRangeException();
            label_4:
            FlatBuffers.VectorOffset val_4 = builder.EndVector();
            val_4.Value = val_4.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_4.Value;
        }
        public static FlatBuffers.VectorOffset CreatePotionColorsVectorBlock(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FPotionColor>[] data)
        {
            builder.StartVector(elemSize:  4, count:  data.Length, alignment:  4);
            builder.Add<FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FPotionColor>>(x:  data);
            FlatBuffers.VectorOffset val_1 = builder.EndVector();
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_1.Value;
        }
        public static void StartPotionColorsVector(FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
            if(builder != null)
            {
                    builder.StartVector(elemSize:  4, count:  numElems, alignment:  4);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddLowMatch(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.VectorOffset lowMatchOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  9, x:  lowMatchOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.VectorOffset CreateLowMatchVector(FlatBuffers.FlatBufferBuilder builder, int[] data)
        {
            var val_5;
            builder.StartVector(elemSize:  4, count:  data.Length, alignment:  4);
            if(<0)
            {
                goto label_4;
            }
            
            int val_2 = data.Length & 4294967295;
            val_5 = (long)data.Length - 1;
            int val_3 = data.Length - 2;
            label_5:
            builder.AddInt(x:  data[((long)(int)((data.Length - 1))) << 2]);
            if((val_3 & 2147483648) != 0)
            {
                goto label_4;
            }
            
            val_5 = val_5 - 1;
            val_3 = val_3 - 1;
            if(val_5 < data.Length)
            {
                goto label_5;
            }
            
            throw new IndexOutOfRangeException();
            label_4:
            FlatBuffers.VectorOffset val_4 = builder.EndVector();
            val_4.Value = val_4.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_4.Value;
        }
        public static FlatBuffers.VectorOffset CreateLowMatchVectorBlock(FlatBuffers.FlatBufferBuilder builder, int[] data)
        {
            builder.StartVector(elemSize:  4, count:  data.Length, alignment:  4);
            builder.Add<System.Int32>(x:  data);
            FlatBuffers.VectorOffset val_1 = builder.EndVector();
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_1.Value;
        }
        public static void StartLowMatchVector(FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
            if(builder != null)
            {
                    builder.StartVector(elemSize:  4, count:  numElems, alignment:  4);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddCurtains(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.VectorOffset curtainsOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  10, x:  curtainsOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.VectorOffset CreateCurtainsVector(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FCurtainData>[] data)
        {
            var val_5;
            builder.StartVector(elemSize:  4, count:  data.Length, alignment:  4);
            if(<0)
            {
                goto label_4;
            }
            
            int val_2 = data.Length & 4294967295;
            val_5 = (long)data.Length - 1;
            int val_3 = data.Length - 2;
            label_5:
            builder.AddOffset(off:  data[val_5]);
            if((val_3 & 2147483648) != 0)
            {
                goto label_4;
            }
            
            val_5 = val_5 - 1;
            val_3 = val_3 - 1;
            if(val_5 < data.Length)
            {
                goto label_5;
            }
            
            throw new IndexOutOfRangeException();
            label_4:
            FlatBuffers.VectorOffset val_4 = builder.EndVector();
            val_4.Value = val_4.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_4.Value;
        }
        public static FlatBuffers.VectorOffset CreateCurtainsVectorBlock(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FCurtainData>[] data)
        {
            builder.StartVector(elemSize:  4, count:  data.Length, alignment:  4);
            builder.Add<FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FCurtainData>>(x:  data);
            FlatBuffers.VectorOffset val_1 = builder.EndVector();
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_1.Value;
        }
        public static void StartCurtainsVector(FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
            if(builder != null)
            {
                    builder.StartVector(elemSize:  4, count:  numElems, alignment:  4);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddCupShelves(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.VectorOffset cupShelvesOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  11, x:  cupShelvesOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.VectorOffset CreateCupShelvesVector(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FCellGroupData>[] data)
        {
            var val_5;
            builder.StartVector(elemSize:  4, count:  data.Length, alignment:  4);
            if(<0)
            {
                goto label_4;
            }
            
            int val_2 = data.Length & 4294967295;
            val_5 = (long)data.Length - 1;
            int val_3 = data.Length - 2;
            label_5:
            builder.AddOffset(off:  data[val_5]);
            if((val_3 & 2147483648) != 0)
            {
                goto label_4;
            }
            
            val_5 = val_5 - 1;
            val_3 = val_3 - 1;
            if(val_5 < data.Length)
            {
                goto label_5;
            }
            
            throw new IndexOutOfRangeException();
            label_4:
            FlatBuffers.VectorOffset val_4 = builder.EndVector();
            val_4.Value = val_4.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_4.Value;
        }
        public static FlatBuffers.VectorOffset CreateCupShelvesVectorBlock(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FCellGroupData>[] data)
        {
            builder.StartVector(elemSize:  4, count:  data.Length, alignment:  4);
            builder.Add<FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FCellGroupData>>(x:  data);
            FlatBuffers.VectorOffset val_1 = builder.EndVector();
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_1.Value;
        }
        public static void StartCupShelvesVector(FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
            if(builder != null)
            {
                    builder.StartVector(elemSize:  4, count:  numElems, alignment:  4);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddSoilGroups(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.VectorOffset soilGroupsOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  12, x:  soilGroupsOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.VectorOffset CreateSoilGroupsVector(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FCellGroupData>[] data)
        {
            var val_5;
            builder.StartVector(elemSize:  4, count:  data.Length, alignment:  4);
            if(<0)
            {
                goto label_4;
            }
            
            int val_2 = data.Length & 4294967295;
            val_5 = (long)data.Length - 1;
            int val_3 = data.Length - 2;
            label_5:
            builder.AddOffset(off:  data[val_5]);
            if((val_3 & 2147483648) != 0)
            {
                goto label_4;
            }
            
            val_5 = val_5 - 1;
            val_3 = val_3 - 1;
            if(val_5 < data.Length)
            {
                goto label_5;
            }
            
            throw new IndexOutOfRangeException();
            label_4:
            FlatBuffers.VectorOffset val_4 = builder.EndVector();
            val_4.Value = val_4.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_4.Value;
        }
        public static FlatBuffers.VectorOffset CreateSoilGroupsVectorBlock(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FCellGroupData>[] data)
        {
            builder.StartVector(elemSize:  4, count:  data.Length, alignment:  4);
            builder.Add<FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FCellGroupData>>(x:  data);
            FlatBuffers.VectorOffset val_1 = builder.EndVector();
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_1.Value;
        }
        public static void StartSoilGroupsVector(FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
            if(builder != null)
            {
                    builder.StartVector(elemSize:  4, count:  numElems, alignment:  4);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddDrills(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.VectorOffset drillsOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  13, x:  drillsOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.VectorOffset CreateDrillsVector(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FDrillData>[] data)
        {
            var val_5;
            builder.StartVector(elemSize:  4, count:  data.Length, alignment:  4);
            if(<0)
            {
                goto label_4;
            }
            
            int val_2 = data.Length & 4294967295;
            val_5 = (long)data.Length - 1;
            int val_3 = data.Length - 2;
            label_5:
            builder.AddOffset(off:  data[val_5]);
            if((val_3 & 2147483648) != 0)
            {
                goto label_4;
            }
            
            val_5 = val_5 - 1;
            val_3 = val_3 - 1;
            if(val_5 < data.Length)
            {
                goto label_5;
            }
            
            throw new IndexOutOfRangeException();
            label_4:
            FlatBuffers.VectorOffset val_4 = builder.EndVector();
            val_4.Value = val_4.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_4.Value;
        }
        public static FlatBuffers.VectorOffset CreateDrillsVectorBlock(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FDrillData>[] data)
        {
            builder.StartVector(elemSize:  4, count:  data.Length, alignment:  4);
            builder.Add<FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FDrillData>>(x:  data);
            FlatBuffers.VectorOffset val_1 = builder.EndVector();
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_1.Value;
        }
        public static void StartDrillsVector(FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
            if(builder != null)
            {
                    builder.StartVector(elemSize:  4, count:  numElems, alignment:  4);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddLightBulbColorOrder(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.VectorOffset lightBulbColorOrderOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  14, x:  lightBulbColorOrderOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.VectorOffset CreateLightBulbColorOrderVector(FlatBuffers.FlatBufferBuilder builder, int[] data)
        {
            var val_5;
            builder.StartVector(elemSize:  4, count:  data.Length, alignment:  4);
            if(<0)
            {
                goto label_4;
            }
            
            int val_2 = data.Length & 4294967295;
            val_5 = (long)data.Length - 1;
            int val_3 = data.Length - 2;
            label_5:
            builder.AddInt(x:  data[((long)(int)((data.Length - 1))) << 2]);
            if((val_3 & 2147483648) != 0)
            {
                goto label_4;
            }
            
            val_5 = val_5 - 1;
            val_3 = val_3 - 1;
            if(val_5 < data.Length)
            {
                goto label_5;
            }
            
            throw new IndexOutOfRangeException();
            label_4:
            FlatBuffers.VectorOffset val_4 = builder.EndVector();
            val_4.Value = val_4.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_4.Value;
        }
        public static FlatBuffers.VectorOffset CreateLightBulbColorOrderVectorBlock(FlatBuffers.FlatBufferBuilder builder, int[] data)
        {
            builder.StartVector(elemSize:  4, count:  data.Length, alignment:  4);
            builder.Add<System.Int32>(x:  data);
            FlatBuffers.VectorOffset val_1 = builder.EndVector();
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_1.Value;
        }
        public static void StartLightBulbColorOrderVector(FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
            if(builder != null)
            {
                    builder.StartVector(elemSize:  4, count:  numElems, alignment:  4);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddChainCount(FlatBuffers.FlatBufferBuilder builder, int chainCount)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  15, x:  chainCount, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddPropellerIgnoresChain(FlatBuffers.FlatBufferBuilder builder, bool propellerIgnoresChain)
        {
            if(builder != null)
            {
                    builder.AddBool(o:  16, x:  propellerIgnoresChain, d:  false);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FTiledLevel> EndFTiledLevel(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
