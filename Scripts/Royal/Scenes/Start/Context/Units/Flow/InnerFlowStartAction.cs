using UnityEngine;

namespace Royal.Scenes.Start.Context.Units.Flow
{
    public class InnerFlowStartAction : FlowAction
    {
        // Fields
        private readonly Royal.Scenes.Start.Context.Units.Flow.FlowManager flowManager;
        private readonly System.Guid <Id>k__BackingField;
        
        // Properties
        public System.Guid Id { get; }
        
        // Methods
        public System.Guid get_Id()
        {
            return new System.Guid() {_a = this.<Id>k__BackingField, _b = this.<Id>k__BackingField, _c = this.<Id>k__BackingField};
        }
        public InnerFlowStartAction()
        {
            this = new System.Object();
            System.Guid val_2 = System.Guid.NewGuid();
            this.<Id>k__BackingField = val_2;
            mem[1152921518919352056] = val_2._d;
            mem[1152921518919352057] = val_2._e;
            mem[1152921518919352058] = val_2._f;
            mem[1152921518919352059] = val_2._g;
            mem[1152921518919352060] = val_2._h;
            mem[1152921518919352061] = val_2._i;
            mem[1152921518919352062] = val_2._j;
            mem[1152921518919352063] = val_2._k;
            this.flowManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
        }
        public override void Execute()
        {
            this.flowManager.mainFlow.StartInnerFlow(id:  new System.Guid() {_a = this.<Id>k__BackingField, _b = this.<Id>k__BackingField, _c = this.<Id>k__BackingField});
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
