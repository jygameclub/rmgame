using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass
{
    public class ShowRoyalPassSafeClaimDialogAction : DialogAction
    {
        // Fields
        private Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassSafeClaimPanel dialog;
        private readonly bool willClaimSafe;
        private readonly bool anyUnclaimed;
        
        // Properties
        public override int Type { get; }
        public override bool IsForClaim { get; }
        
        // Methods
        public override int get_Type()
        {
            return 3;
        }
        public override bool get_IsForClaim()
        {
            return true;
        }
        public ShowRoyalPassSafeClaimDialogAction(bool willClaimSafe, bool anyUnclaimed)
        {
            this.willClaimSafe = willClaimSafe;
            this.anyUnclaimed = anyUnclaimed;
        }
        public override void Execute()
        {
            var val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            if(this.willClaimSafe != false)
            {
                    Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  28, log:  "Will claim safe", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
                UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
                UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.identity;
                Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassSafeClaimPanel val_4 = UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassSafeClaimPanel>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassSafeClaimPanel>(path:  "RoyalPassSafeClaimPanel"), position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rotation:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w});
                this.dialog = val_4;
                val_4.Show(onComplete:  new System.Action(object:  this, method:  public System.Void Royal.Scenes.Start.Context.Units.Flow.FlowAction::Complete()), anyUnclaimed:  this.anyUnclaimed);
                return;
            }
            
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  28, log:  "Will not claim safe", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            this.Complete();
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
        
        }
    
    }

}
