using UnityEngine;

namespace Royal.Scenes.Home.Context.Units.Area.Config
{
    [Serializable]
    public class AreaTaskConfig
    {
        // Fields
        public int id;
        public int price;
        public int dependency;
        public int[] dependencies;
        public Royal.Scenes.Home.Context.Units.Area.Config.AreaReplayConfig replayConfig;
        
        // Methods
        public string LocalizedStringKey(int areaId)
        {
            int val_3;
            object[] val_1 = new object[4];
            val_1[0] = "Area ";
            val_3 = val_1.Length;
            val_1[1] = areaId;
            val_3 = val_1.Length;
            val_1[2] = " - Task ";
            val_1[3] = this.id;
            return (string)+val_1;
        }
        public AreaTaskConfig()
        {
        
        }
    
    }

}
