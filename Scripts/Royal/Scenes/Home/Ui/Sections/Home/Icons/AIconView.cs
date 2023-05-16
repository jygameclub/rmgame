using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Home.Icons
{
    public class AIconView : MonoBehaviour
    {
        // Fields
        public const string AutoDialogOriginIcon = "icon";
        public const string AutoDialogOriginFlow = "flow";
        
        // Methods
        public virtual void Init()
        {
        
        }
        public virtual bool IsVisible()
        {
            return true;
        }
        protected void DelayAutoActionsWhileWaitingResponse(bool wait)
        {
            var val_3;
            bool val_1 = wait;
            val_3 = null;
            val_3 = null;
            Royal.Scenes.Home.Context.HomeContext.ShouldDelayAutoActionsToWaitFinishedEventResponse = val_1;
            object[] val_2 = new object[1];
            val_2[0] = val_1;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  4, log:  "ShouldDelayAutoActionsToWaitFinishedEventResponse = {0}", values:  val_2);
        }
        protected void StartDelayedActions()
        {
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).PushDelayedAutoActions(executeAfter:  0f);
        }
        public AIconView()
        {
        
        }
    
    }

}
