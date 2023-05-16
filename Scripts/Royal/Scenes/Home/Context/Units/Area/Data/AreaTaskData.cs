using UnityEngine;

namespace Royal.Scenes.Home.Context.Units.Area.Data
{
    public struct AreaTaskData
    {
        // Fields
        public int taskId;
        public readonly bool isCompleted;
        
        // Methods
        public AreaTaskData(int taskId, bool isCompleted)
        {
            mem[1152921519587922016] = taskId;
            mem[1152921519587922020] = isCompleted;
        }
    
    }

}
