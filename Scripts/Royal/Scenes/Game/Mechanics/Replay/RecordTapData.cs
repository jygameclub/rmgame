using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Replay
{
    [Serializable]
    public class RecordTapData
    {
        // Fields
        public int recordedFrame;
        public short cellX;
        public short cellY;
        
        // Methods
        public byte[] ToByteArray()
        {
            System.Collections.Generic.List<System.Byte> val_1 = new System.Collections.Generic.List<System.Byte>();
            val_1.AddRange(collection:  System.BitConverter.GetBytes(value:  this.recordedFrame));
            val_1.AddRange(collection:  System.BitConverter.GetBytes(value:  this.cellX));
            val_1.AddRange(collection:  System.BitConverter.GetBytes(value:  this.cellY));
            return val_1.ToArray();
        }
        public RecordTapData()
        {
        
        }
    
    }

}
