using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Replay
{
    public class RecordDataParser
    {
        // Fields
        private readonly byte[] data;
        private int currentIndex;
        
        // Methods
        public RecordDataParser(string encodedStr)
        {
            this.data = System.Convert.FromBase64String(s:  Royal.Infrastructure.Utils.Compressing.Compressor.UnzipStr(bytes:  System.Convert.FromBase64String(s:  encodedStr), encoding:  System.Text.Encoding.UTF8));
        }
        public Royal.Scenes.Game.Mechanics.Replay.RecordData Parse()
        {
            .frameCount = this.GetNextInt();
            .randomSeed = this.GetNextInt();
            .levelName = this.GetNextString();
            .gameVersion = this.GetNextString();
            .deltas = this.GetNextShortList();
            .swapDataList = this.GetNextSwapList();
            .tapDataList = this.GetNextTapList();
            return (Royal.Scenes.Game.Mechanics.Replay.RecordData)new Royal.Scenes.Game.Mechanics.Replay.RecordData();
        }
        private int GetNextInt()
        {
            return System.BitConverter.ToInt32(value:  this.GetBetween(length:  4), startIndex:  0);
        }
        private short GetNextShort()
        {
            return System.BitConverter.ToInt16(value:  this.GetBetween(length:  2), startIndex:  0);
        }
        private string GetNextString()
        {
            System.Byte[] val_2 = this.GetBetween(length:  this.GetNextInt());
            System.Text.Encoding val_3 = System.Text.Encoding.UTF8;
            goto typeof(System.Text.Encoding).__il2cppRuntimeField_360;
        }
        private System.Collections.Generic.List<short> GetNextShortList()
        {
            int val_1 = this.GetNextInt();
            System.Collections.Generic.List<System.Int16> val_2 = new System.Collections.Generic.List<System.Int16>();
            if(val_1 < 1)
            {
                    return val_2;
            }
            
            var val_4 = 0;
            do
            {
                val_2.Add(item:  this.GetNextShort());
                val_4 = val_4 + 1;
            }
            while(val_4 < val_1);
            
            return val_2;
        }
        private Royal.Scenes.Game.Mechanics.Replay.RecordSwapData GetNextSwapData()
        {
            .recordedFrame = this.GetNextInt();
            .fromCellX = this.GetNextShort();
            .fromCellY = this.GetNextShort();
            .toCellX = this.GetNextShort();
            .toCellY = this.GetNextShort();
            return (Royal.Scenes.Game.Mechanics.Replay.RecordSwapData)new Royal.Scenes.Game.Mechanics.Replay.RecordSwapData();
        }
        private System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Replay.RecordSwapData> GetNextSwapList()
        {
            int val_1 = this.GetNextInt();
            System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Replay.RecordSwapData> val_2 = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Replay.RecordSwapData>();
            if(val_1 < 1)
            {
                    return val_2;
            }
            
            var val_4 = 0;
            do
            {
                val_2.Add(item:  this.GetNextSwapData());
                val_4 = val_4 + 1;
            }
            while(val_4 < val_1);
            
            return val_2;
        }
        private Royal.Scenes.Game.Mechanics.Replay.RecordTapData GetNextTapData()
        {
            .recordedFrame = this.GetNextInt();
            .cellX = this.GetNextShort();
            .cellY = this.GetNextShort();
            return (Royal.Scenes.Game.Mechanics.Replay.RecordTapData)new Royal.Scenes.Game.Mechanics.Replay.RecordTapData();
        }
        private System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Replay.RecordTapData> GetNextTapList()
        {
            int val_1 = this.GetNextInt();
            System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Replay.RecordTapData> val_2 = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Replay.RecordTapData>();
            if(val_1 < 1)
            {
                    return val_2;
            }
            
            var val_4 = 0;
            do
            {
                val_2.Add(item:  this.GetNextTapData());
                val_4 = val_4 + 1;
            }
            while(val_4 < val_1);
            
            return val_2;
        }
        private byte[] GetBetween(int length)
        {
            int val_4 = this.currentIndex;
            val_4 = val_4 + length;
            this.currentIndex = val_4;
            return (System.Byte[])System.Linq.Enumerable.ToArray<System.Byte>(source:  System.Linq.Enumerable.Take<System.Byte>(source:  System.Linq.Enumerable.Skip<System.Byte>(source:  this.data, count:  this.currentIndex), count:  length));
        }
    
    }

}
