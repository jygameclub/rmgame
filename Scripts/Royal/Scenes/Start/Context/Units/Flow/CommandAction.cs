using UnityEngine;

namespace Royal.Scenes.Start.Context.Units.Flow
{
    public abstract class CommandAction : FlowAction
    {
        // Fields
        protected readonly Royal.Infrastructure.Services.Backend.Http.BackendHttpService backendHttpService;
        
        // Methods
        protected CommandAction()
        {
            this = new System.Object();
            this.backendHttpService = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.BackendHttpService>(id:  7);
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
            goto typeof(Royal.Scenes.Start.Context.Units.Flow.CommandAction).__il2cppRuntimeField_1B0;
        }
    
    }

}
