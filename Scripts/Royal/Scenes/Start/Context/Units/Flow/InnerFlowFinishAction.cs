using UnityEngine;

namespace Royal.Scenes.Start.Context.Units.Flow
{
    public class InnerFlowFinishAction : FlowAction
    {
        // Fields
        private readonly Royal.Scenes.Start.Context.Units.Flow.FlowManager flowManager;
        
        // Methods
        public InnerFlowFinishAction()
        {
            this = new System.Object();
            this.flowManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
        }
        public override void Execute()
        {
            this.flowManager.mainFlow.FinishInnerFlow();
            this.Complete();
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
            this.Complete();
        }
        public override bool SupportsMultiple()
        {
            return true;
        }
    
    }

}
