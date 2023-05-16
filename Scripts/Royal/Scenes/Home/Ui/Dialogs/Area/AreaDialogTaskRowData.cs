using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Area
{
    public class AreaDialogTaskRowData : IUiScrollContentData
    {
        // Fields
        public readonly Royal.Scenes.Home.Context.Units.Area.Config.AreaTaskConfig config;
        public readonly Royal.Scenes.Home.Context.Units.Area.Data.AreaTaskData taskData;
        public readonly Royal.Scenes.Home.Ui.Dialogs.Area.AreaDialog areaDialog;
        public readonly bool isHidden;
        public readonly int lastCompletedTaskId;
        
        // Properties
        public bool IsLastCompleted { get; }
        
        // Methods
        public bool get_IsLastCompleted()
        {
            return (bool)(this.taskData == this.lastCompletedTaskId) ? 1 : 0;
        }
        public AreaDialogTaskRowData(Royal.Scenes.Home.Context.Units.Area.Config.AreaTaskConfig config, Royal.Scenes.Home.Context.Units.Area.Data.AreaTaskData taskData, Royal.Scenes.Home.Ui.Dialogs.Area.AreaDialog areaDialog, bool isHidden, int lastCompletedTaskId)
        {
            this.config = config;
            this.taskData = taskData;
            this.areaDialog = areaDialog;
            this.isHidden = isHidden;
            this.lastCompletedTaskId = lastCompletedTaskId;
        }
    
    }

}
