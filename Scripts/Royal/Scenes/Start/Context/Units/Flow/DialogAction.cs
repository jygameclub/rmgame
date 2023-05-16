using UnityEngine;

namespace Royal.Scenes.Start.Context.Units.Flow
{
    public abstract class DialogAction : FlowAction
    {
        // Fields
        private readonly Royal.Infrastructure.UiComponents.Dialog.DialogManager <DialogManager>k__BackingField;
        
        // Properties
        public Royal.Infrastructure.UiComponents.Dialog.DialogManager DialogManager { get; }
        public virtual Royal.Scenes.Start.Context.Units.Flow.DialogOriginType OriginType { get; }
        
        // Methods
        public Royal.Infrastructure.UiComponents.Dialog.DialogManager get_DialogManager()
        {
            return (Royal.Infrastructure.UiComponents.Dialog.DialogManager)this.<DialogManager>k__BackingField;
        }
        public virtual Royal.Scenes.Start.Context.Units.Flow.DialogOriginType get_OriginType()
        {
            return 0;
        }
        protected DialogAction()
        {
            this = new System.Object();
            this.<DialogManager>k__BackingField = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Dialog.DialogManager>(id:  13);
        }
    
    }

}
