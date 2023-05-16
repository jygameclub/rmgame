using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Replay
{
    [Serializable]
    public class RecordSwapData
    {
        // Fields
        public int recordedFrame;
        public short fromCellX;
        public short fromCellY;
        public short toCellX;
        public short toCellY;
        
        // Methods
        public byte[] ToByteArray()
        {
            System.Collections.Generic.List<System.Byte> val_1 = new System.Collections.Generic.List<System.Byte>();
            val_1.AddRange(collection:  System.BitConverter.GetBytes(value:  this.recordedFrame));
            val_1.AddRange(collection:  System.BitConverter.GetBytes(value:  this.fromCellX));
            val_1.AddRange(collection:  System.BitConverter.GetBytes(value:  this.fromCellY));
            val_1.AddRange(collection:  System.BitConverter.GetBytes(value:  this.toCellX));
            val_1.AddRange(collection:  System.BitConverter.GetBytes(value:  this.toCellY));
            return val_1.ToArray();
        }
        public RecordSwapData()
        {
        
        }
    
    }

}
