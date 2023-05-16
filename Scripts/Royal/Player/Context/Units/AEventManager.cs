using UnityEngine;

namespace Royal.Player.Context.Units
{
    public abstract class AEventManager
    {
        // Methods
        public virtual void ResetAutoDialogState()
        {
        
        }
        public virtual bool TryAddInfoDialog(string origin = "flow", bool isWin = False)
        {
            return false;
        }
        public virtual bool TryAddStartDialog(string origin = "flow")
        {
            return false;
        }
        public virtual bool TryAddClaimDialog(string origin = "flow")
        {
            return false;
        }
        public virtual bool TryAddAutoDialog(string origin = "flow", bool isWin = False)
        {
            bool val_6;
            var val_7;
            val_6 = isWin;
            if((Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).IsMainFlowPaused()) != false)
            {
                    if((System.String.op_Equality(a:  origin, b:  "icon")) != false)
            {
                    object[] val_4 = new object[2];
                val_4[0] = origin;
                val_4[1] = val_6;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  16, log:  "Origin:{0}, IsWin:{1}", values:  val_4);
                val_7 = 0;
                return false;
            }
            
            }
            
            isWin = val_6;
            val_6 = 1152921524144151024;
            val_7 = 1152921524144151024;
            return false;
        }
        protected AEventManager()
        {
        
        }
    
    }

}
