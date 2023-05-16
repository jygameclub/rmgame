using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Review
{
    public class RequestStoreReviewAction : FlowAction
    {
        // Methods
        public override void Execute()
        {
            var val_3;
            if(Royal.Scenes.Home.Ui.Dialogs.Review.RequestStoreReviewAction.ShouldRequest() != false)
            {
                    val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  13, log:  "Store review request will be asked to user.", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
                Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Native.NativeService>(id:  19).RequestStoreReview();
            }
            
            this.Complete();
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
            this.Complete();
        }
        private static bool ShouldRequest()
        {
            var val_5 = 1;
            var val_4 = ((typeof(Royal.Player.Context.Data.Persistent.BasicUserData).__il2cppRuntimeField_14 == 233) ? 1 : 0) | ((typeof(Royal.Player.Context.Data.Persistent.BasicUserData).__il2cppRuntimeField_14 == 263) ? 1 : 0);
            return (bool);
        }
        public RequestStoreReviewAction()
        {
        
        }
    
    }

}
