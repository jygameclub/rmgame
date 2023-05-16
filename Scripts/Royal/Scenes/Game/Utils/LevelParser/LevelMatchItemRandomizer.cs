using UnityEngine;

namespace Royal.Scenes.Game.Utils.LevelParser
{
    public class LevelMatchItemRandomizer
    {
        // Fields
        public const int Failed = -100;
        private const byte Blue = 1;
        private const byte Green = 2;
        private const byte Red = 4;
        private const byte Yellow = 8;
        private const byte Pink = 16;
        private const byte Orange = 32;
        private readonly int[] data;
        private readonly int width;
        private readonly int[] masks;
        private readonly Royal.Scenes.Game.Levels.Units.LevelRandomManager randomManager;
        private readonly int[] typeCounts;
        private readonly System.Collections.Generic.List<byte> matchItems;
        
        // Methods
        public LevelMatchItemRandomizer(int[] data, int width, Royal.Scenes.Game.Utils.LevelParser.LevelSet[] sets)
        {
            System.Int32[] val_6;
            this.data = data;
            this.width = width;
            this.randomManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.LevelRandomManager>(contextId:  0);
            this.matchItems = new System.Collections.Generic.List<System.Byte>(capacity:  6);
            val_6 = 1152921505165927152;
            this.typeCounts = new int[6];
            int[] val_4 = new int[0];
            this.masks = val_4;
            int val_6 = sets.Length;
            if(val_6 < 1)
            {
                    return;
            }
            
            val_6 = val_6 & 4294967295;
            val_6 = val_4;
            var val_7 = 0;
            do
            {
                val_6[0] = Royal.Scenes.Game.Utils.LevelParser.LevelMatchItemRandomizer.GetMask(set:  null);
                val_7 = val_7 + 1;
                if(val_7 >= (sets.Length << ))
            {
                    return;
            }
            
                val_6 = this.masks;
            }
            while(val_7 < sets.Length);
            
            throw new IndexOutOfRangeException();
        }
        private int InitialMask(int value)
        {
            var val_2;
            if(value == 16)
            {
                goto label_0;
            }
            
            if(value == 15)
            {
                goto label_1;
            }
            
            if(value != 14)
            {
                goto label_2;
            }
            
            return (int)val_2;
            label_1:
            return (int)val_2;
            label_0:
            return (int)val_2;
            label_2:
            val_2 = 0;
            return (int)val_2;
        }
        public int GetValue(int index, int initialValue)
        {
            this.data[index] = initialValue;
            this.data[index] = this.data[index] - 1;
            this.data[index] = 1 << this.data[index];
            return this.ReturnRandomValue(index:  index, value:  initialValue, mask:  (this.InitialMask(value:  initialValue)) & (~this.data[index]));
        }
        public int GetValue(int index)
        {
            int val_2 = this.data[index];
            return this.ReturnRandomValue(index:  index, value:  val_2, mask:  this.InitialMask(value:  val_2));
        }
        private int ReturnRandomValue(int index, int value, int mask)
        {
            int val_4 = value;
            if(mask == 0)
            {
                goto label_0;
            }
            
            int val_1 = this.GetRandomMatchItem(index:  index, mask:  mask);
            if(val_1 != 100)
            {
                goto label_1;
            }
            
            val_4 = 99;
            return (int)val_4;
            label_0:
            if((val_4 - 1) > 5)
            {
                    return (int)val_4;
            }
            
            this.IncreaseCount(matchItem:  val_4 = value);
            return (int)val_4;
            label_1:
            if((val_1 - 1) > 5)
            {
                    return (int)val_4;
            }
            
            val_4 = val_1;
            this.data[index] = val_1;
            return (int)val_4;
        }
        public bool SecureAtLeastOnePossibleMatch(int[,] transformed)
        {
            int val_9;
            object val_10;
            object val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            if(this.typeCounts.Length < 1)
            {
                goto label_2;
            }
            
            val_10 = 0;
            label_10:
            int val_10 = this.typeCounts[0];
            if(val_10 > 2)
            {
                goto label_27;
            }
            
            if(val_10 == 0)
            {
                goto label_5;
            }
            
            if(val_10 == 0)
            {
                goto label_6;
            }
            
            var val_3 = (val_10 <= (this.typeCounts[val_10 - 1])) ? (val_10) : (0 + 1);
            val_11 = 0 + 1;
            goto label_9;
            label_5:
            val_11 = 0 + 1;
            goto label_9;
            label_6:
            val_11 = 0 + 1;
            val_10 = val_11;
            label_9:
            if(val_11 < this.typeCounts.Length)
            {
                goto label_10;
            }
            
            if(val_10 == 0)
            {
                goto label_11;
            }
            
            label_32:
            val_11 = val_10 - 1;
            val_9 = this.typeCounts[val_11];
            if((transformed.GetLength(dimension:  0)) < 1)
            {
                goto label_30;
            }
            
            var val_14 = 0;
            val_12 = 3 - val_9;
            label_29:
            if((transformed.GetLength(dimension:  1)) < 1)
            {
                goto label_15;
            }
            
            val_13 = 0;
            label_28:
            var val_12 = 256;
            val_12 = val_13 + (val_14 * val_12);
            int val_13 = transformed[val_12];
            if((val_13 == val_10) || ((val_13 - 1) > 5))
            {
                goto label_19;
            }
            
            mem2[0] = val_10;
            object[] val_7 = new object[2];
            val_9 = val_7;
            val_9[0] = val_13;
            val_9[1] = val_10;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  5, log:  "At least one possible match is secured by changing {0} with {1}", values:  val_7);
            val_12 = val_12 - 1;
            if(val_7.Length == 1)
            {
                goto label_27;
            }
            
            label_19:
            val_13 = val_13 + 1;
            if(val_13 < ((transformed.GetLength(dimension:  1)) << ))
            {
                goto label_28;
            }
            
            label_15:
            val_14 = val_14 + 1;
            if(val_14 < ((transformed.GetLength(dimension:  0)) << ))
            {
                goto label_29;
            }
            
            goto label_30;
            label_27:
            val_14 = 1;
            return (bool)val_14;
            label_2:
            val_10 = 0;
            if(val_10 != 0)
            {
                goto label_32;
            }
            
            label_11:
            val_9 = public static T[] System.Array::Empty<System.Object>();
            val_15 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_15 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_15 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_15 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  5, log:  "There is no randomized match item.", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            label_30:
            val_14 = 0;
            return (bool)val_14;
        }
        private static int GetMask(Royal.Scenes.Game.Utils.LevelParser.LevelSet set)
        {
            var val_1;
            var val_2;
            bool val_1 = true;
            val_1 = 0;
            val_2 = 0;
            label_7:
            if(val_1 >= val_1)
            {
                    return (int)val_2;
            }
            
            if(val_1 <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + 0;
            var val_2 = (true + 0) + 32 + 16;
            val_2 = val_2 - 1;
            if(val_2 > 5)
            {
                goto label_6;
            }
            
            val_2 = 1 << val_2;
            val_2 = val_2 | val_2;
            val_1 = val_1 + 1;
            if(set.items != null)
            {
                goto label_7;
            }
            
            throw new NullReferenceException();
            label_6:
            val_2 = 0;
            return (int)val_2;
        }
        private static bool IsMatchItem(int value)
        {
            return (bool)((value - 1) < 6) ? 1 : 0;
        }
        private int GetRandomMatchItem(int index, int mask)
        {
            int val_12;
            int val_1 = index - 2;
            int val_2 = index - 1;
            if(val_1 >= 1)
            {
                    int val_12 = this.data[val_2];
                this.data[val_2] = val_12 - 1;
                if(this.data[val_2] <= 5)
            {
                    if(val_12 == this.data[val_1])
            {
                    var val_14 = 1;
                val_14 = val_14 << this.data[val_2];
                val_12 = mask & (~val_14);
            }
            
            }
            
            }
            
            int val_25 = this.width;
            int val_3 = index - (val_25 << 1);
            int val_4 = index - val_25;
            if(val_3 >= 1)
            {
                    int val_15 = this.data[val_4];
                this.data[val_4] = val_15 - 1;
                if(this.data[val_4] <= 5)
            {
                    if(val_15 == this.data[val_3])
            {
                    var val_17 = 1;
                val_17 = val_17 << this.data[val_4];
                val_12 = val_12 & (~val_17);
            }
            
            }
            
            }
            
            if((val_2 < 1) || (val_2 < 1))
            {
                goto label_13;
            }
            
            int val_18 = this.data[val_4 - 1];
            if(val_18 != this.data[val_4])
            {
                goto label_21;
            }
            
            int val_6 = val_18 - 1;
            if(val_6 > 5)
            {
                goto label_21;
            }
            
            if(val_18 != this.data[val_2])
            {
                goto label_21;
            }
            
            var val_21 = 1;
            val_21 = val_21 << val_6;
            val_12 = val_12 & (~val_21);
            goto label_21;
            label_13:
            label_21:
            int val_7 = index + 2;
            int val_8 = index + 1;
            if(val_7 < this.data.Length)
            {
                    int val_22 = this.data[val_8];
                this.data[val_8] = val_22 - 1;
                if(this.data[val_8] <= 5)
            {
                    if(val_22 == this.data[val_7])
            {
                    var val_24 = 1;
                val_24 = val_24 << this.data[val_8];
                val_12 = val_12 & (~val_24);
            }
            
            }
            
            }
            
            int val_9 = val_25 << 1;
            val_9 = val_9 + index;
            val_25 = val_25 + index;
            if(val_9 < this.data.Length)
            {
                    int val_26 = this.data[val_25];
                this.data[val_25] = val_26 - 1;
                if(this.data[val_25] <= 5)
            {
                    if(val_26 == this.data[val_9])
            {
                    var val_28 = 1;
                val_28 = val_28 << this.data[val_25];
                val_12 = val_12 & (~val_28);
            }
            
            }
            
            }
            
            int val_10 = val_25 + 1;
            if(val_10 >= this.data.Length)
            {
                    return this.GetRandomMatchItemValue(mask:  val_12 = val_12 & (~val_32));
            }
            
            int val_29 = this.data[val_10];
            if(val_29 != this.data[val_25])
            {
                    return this.GetRandomMatchItemValue(mask:  val_12);
            }
            
            int val_11 = val_29 - 1;
            if(val_11 > 5)
            {
                    return this.GetRandomMatchItemValue(mask:  val_12);
            }
            
            if(val_29 != this.data[val_8])
            {
                    return this.GetRandomMatchItemValue(mask:  val_12);
            }
            
            var val_32 = 1;
            val_32 = val_32 << val_11;
            return this.GetRandomMatchItemValue(mask:  val_12);
        }
        private int GetRandomMatchItemValue(int mask)
        {
            int val_3;
            this.matchItems.Clear();
            this.ShouldAddMatchItem(mask:  mask, matchItem:  1, tiledId:  1);
            this.ShouldAddMatchItem(mask:  mask, matchItem:  2, tiledId:  2);
            this.ShouldAddMatchItem(mask:  mask, matchItem:  4, tiledId:  3);
            this.ShouldAddMatchItem(mask:  mask, matchItem:  8, tiledId:  4);
            this.ShouldAddMatchItem(mask:  mask, matchItem:  16, tiledId:  5);
            this.ShouldAddMatchItem(mask:  mask, matchItem:  32, tiledId:  6);
            if(1152921519831639952 >= 1)
            {
                    val_3 = (this.randomManager.GetRandomItemFromList<System.Byte>(list:  this.matchItems)) & 255;
                this.IncreaseCount(matchItem:  val_3);
                return (int)val_3;
            }
            
            val_3 = 99;
            return (int)val_3;
        }
        private void IncreaseCount(int matchItem)
        {
            int val_2 = this.typeCounts[matchItem - 1];
            val_2 = val_2 + 1;
            this.typeCounts[matchItem - 1] = val_2;
        }
        private void ShouldAddMatchItem(int mask, byte matchItem, Royal.Scenes.Game.Utils.LevelParser.TiledId tiledId)
        {
            if((matchItem & (~mask)) != 255)
            {
                    return;
            }
            
            this.matchItems.Add(item:  tiledId);
        }
        private static int ExcludeId(int gid, int mask)
        {
            int val_1 = gid - 1;
            val_1 = 1 << val_1;
            gid = mask & (~val_1);
            return (int)gid;
        }
        private static int IncludeId(int gid, int mask)
        {
            int val_1 = gid - 1;
            val_1 = 1 << val_1;
            gid = val_1 | mask;
            return (int)gid;
        }
        private static int TiledIdToMask(int gid)
        {
            gid = 1 << (gid - 1);
            return (int)gid;
        }
    
    }

}
