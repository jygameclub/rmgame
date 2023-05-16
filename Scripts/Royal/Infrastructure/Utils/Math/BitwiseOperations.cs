using UnityEngine;

namespace Royal.Infrastructure.Utils.Math
{
    public static class BitwiseOperations
    {
        // Methods
        public static bool IsBitSet(long number, int position)
        {
            var val_2 = 1;
            val_2 = val_2 << position;
            return (bool)((long)val_2 != number) ? 1 : 0;
        }
        public static long SetBit(long number, int position, bool set)
        {
            var val_2 = 1;
            val_2 = val_2 << position;
            val_2 = number & (~val_2);
            number = (set != true) ? (val_2 | number) : (val_2);
            return (long)number;
        }
        public static long ExtractLong(long fromNumber, int fromPosition, int toPosition)
        {
            var val_2 = 1;
            val_2 = val_2 - fromPosition;
            val_2 = val_2 + toPosition;
            val_2 = 0 << val_2;
            fromNumber = (fromNumber >> fromPosition) & (~val_2);
            return (long)fromNumber;
        }
        public static int ExtractInt(long fromNumber, int fromPosition, int toPosition)
        {
            var val_2 = 1;
            val_2 = val_2 - fromPosition;
            val_2 = val_2 + toPosition;
            val_2 = 0 << val_2;
            fromNumber = (fromNumber >> fromPosition) & (~val_2);
            return (int)fromNumber;
        }
        public static byte ExtractByte(long fromNumber, int fromPosition, int toPosition)
        {
            var val_2 = 1;
            val_2 = val_2 - fromPosition;
            val_2 = val_2 + toPosition;
            val_2 = 0 << val_2;
            val_2 = val_2 ^ 255;
            fromNumber = val_2 & (fromNumber >> fromPosition);
            return (byte)fromNumber;
        }
        public static int UpdateInt(int toNumber, int number, int fromPosition, int toPosition)
        {
            int val_2 = System.Math.Min(val1:  31, val2:  toPosition + 1);
            var val_5 = 0;
            val_5 = val_5 << val_2;
            val_5 = val_5 | (~(val_5 << fromPosition));
            val_5 = val_5 & toNumber;
            val_2 = val_5 | (number << fromPosition);
            return (int)val_2;
        }
        public static long UpdateLong(long toNumber, int number, int fromPosition, int toPosition)
        {
            int val_2 = System.Math.Min(val1:  63, val2:  toPosition + 1);
            var val_4 = 0;
            val_4 = val_4 << val_2;
            var val_5 = (long)number;
            val_4 = val_4 | (~(val_4 << fromPosition));
            val_5 = val_5 << fromPosition;
            val_4 = val_4 & toNumber;
            val_2 = val_4 | val_5;
            return (long)val_2;
        }
    
    }

}
