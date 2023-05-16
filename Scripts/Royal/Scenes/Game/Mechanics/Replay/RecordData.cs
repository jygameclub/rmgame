using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Replay
{
    [Serializable]
    public class RecordData
    {
        // Fields
        public int frameCount;
        public int randomSeed;
        public string levelName;
        public string gameVersion;
        public System.Collections.Generic.List<short> deltas;
        public System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Replay.RecordSwapData> swapDataList;
        public System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Replay.RecordTapData> tapDataList;
        
        // Methods
        private byte[] ToByteArray()
        {
            short val_6;
            var val_7;
            var val_16;
            var val_17;
            System.Collections.Generic.List<System.Byte> val_1 = new System.Collections.Generic.List<System.Byte>();
            val_1.AddRange(collection:  System.BitConverter.GetBytes(value:  this.frameCount));
            val_1.AddRange(collection:  System.BitConverter.GetBytes(value:  this.randomSeed));
            val_1.AddString(bytes:  val_1, str:  this.levelName);
            val_1.AddString(bytes:  val_1, str:  this.gameVersion);
            val_1.AddRange(collection:  System.BitConverter.GetBytes(value:  -1800638368));
            List.Enumerator<T> val_5 = this.deltas.GetEnumerator();
            label_9:
            if(((-1800682464) & 1) == 0)
            {
                goto label_6;
            }
            
            val_1.AddRange(collection:  System.BitConverter.GetBytes(value:  val_6));
            goto label_9;
            label_6:
            val_7.Dispose();
            val_1.AddRange(collection:  System.BitConverter.GetBytes(value:  this.frameCount));
            List.Enumerator<T> val_10 = this.swapDataList.GetEnumerator();
            label_16:
            val_16 = public System.Boolean List.Enumerator<Royal.Scenes.Game.Mechanics.Replay.RecordSwapData>::MoveNext();
            if(((-1800682496) & 1) == 0)
            {
                goto label_14;
            }
            
            val_17 = val_6;
            if(val_17 == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_1.AddRange(collection:  val_17.ToByteArray());
            goto label_16;
            label_14:
            val_7.Dispose();
            val_1.AddRange(collection:  System.BitConverter.GetBytes(value:  1152921519985861024));
            List.Enumerator<T> val_13 = this.tapDataList.GetEnumerator();
            label_23:
            val_16 = public System.Boolean List.Enumerator<Royal.Scenes.Game.Mechanics.Replay.RecordTapData>::MoveNext();
            if(((-1800682520) & 1) == 0)
            {
                goto label_21;
            }
            
            val_17 = 0;
            if(val_17 == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_1.AddRange(collection:  val_17.ToByteArray());
            goto label_23;
            label_21:
            0.Dispose();
            return (System.Byte[])val_1.ToArray();
        }
        public string EncodeAsString()
        {
            return System.Convert.ToBase64String(inArray:  Royal.Infrastructure.Utils.Compressing.Compressor.ZipStr(str:  System.Convert.ToBase64String(inArray:  this.ToByteArray()), encoding:  System.Text.Encoding.UTF8));
        }
        private void AddString(System.Collections.Generic.List<byte> bytes, string str)
        {
            bytes.AddRange(collection:  System.BitConverter.GetBytes(value:  val_1.dataItem));
            bytes.AddRange(collection:  System.Text.Encoding.UTF8);
        }
        public RecordData()
        {
        
        }
    
    }

}
