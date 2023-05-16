using UnityEngine;

namespace Royal.Scenes.Home.Context.Units.Area.Config
{
    public class AreaConfig : ScriptableObject
    {
        // Fields
        public int areaId;
        public string areaName;
        public Royal.Scenes.Home.Context.Units.Area.Config.AreaTaskConfig[] tasks;
        public float tallDeviceReplayDelay;
        
        // Methods
        public Royal.Scenes.Home.Context.Units.Area.Config.AreaTaskConfig GetConfigForTaskId(int taskId)
        {
            Royal.Scenes.Home.Context.Units.Area.Config.AreaTaskConfig val_1;
            if(this.tasks.Length >= 1)
            {
                    var val_1 = 0;
                do
            {
                val_1 = this.tasks[val_1];
                if(this.tasks[0x0][0].id == taskId)
            {
                    return (Royal.Scenes.Home.Context.Units.Area.Config.AreaTaskConfig)val_1;
            }
            
                val_1 = val_1 + 1;
            }
            while(val_1 < this.tasks.Length);
            
            }
            
            val_1 = 0;
            return (Royal.Scenes.Home.Context.Units.Area.Config.AreaTaskConfig)val_1;
        }
        public Royal.Scenes.Home.Context.Units.Area.Config.AreaTaskConfig[] GetReplayOrderedTasks()
        {
            var val_3;
            System.Comparison<Royal.Scenes.Home.Context.Units.Area.Config.AreaTaskConfig> val_5;
            System.Collections.Generic.List<TSource> val_1 = System.Linq.Enumerable.ToList<Royal.Scenes.Home.Context.Units.Area.Config.AreaTaskConfig>(source:  this.tasks);
            val_3 = null;
            val_3 = null;
            val_5 = AreaConfig.<>c.<>9__5_0;
            if(val_5 == null)
            {
                    System.Comparison<Royal.Scenes.Home.Context.Units.Area.Config.AreaTaskConfig> val_2 = null;
                val_5 = val_2;
                val_2 = new System.Comparison<Royal.Scenes.Home.Context.Units.Area.Config.AreaTaskConfig>(object:  AreaConfig.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 AreaConfig.<>c::<GetReplayOrderedTasks>b__5_0(Royal.Scenes.Home.Context.Units.Area.Config.AreaTaskConfig t1, Royal.Scenes.Home.Context.Units.Area.Config.AreaTaskConfig t2));
                AreaConfig.<>c.<>9__5_0 = val_5;
            }
            
            val_1.Sort(comparison:  val_2);
            return val_1.ToArray();
        }
        public AreaConfig()
        {
        
        }
    
    }

}
