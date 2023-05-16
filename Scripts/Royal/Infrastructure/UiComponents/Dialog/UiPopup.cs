using UnityEngine;

namespace Royal.Infrastructure.UiComponents.Dialog
{
    public class UiPopup : MonoBehaviour
    {
        // Fields
        private Royal.Scenes.Start.Context.Units.Flow.FlowAction action;
        
        // Methods
        public static T Instantiate<T>(string assetName, Royal.Scenes.Start.Context.Units.Flow.FlowAction action)
        {
            string val_4 = assetName;
            val_4 = action;
            object[] val_2 = new object[1];
            val_2[0] = val_4.GetType();
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClassType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), logTag:  4, log:  "Show: {0}", values:  val_2);
            return (Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferPopupView)val_4;
        }
        public static T Instantiate<T>(string assetName, UnityEngine.Transform parent, Royal.Scenes.Start.Context.Units.Flow.FlowAction action)
        {
            string val_4 = assetName;
            val_4 = action;
            object[] val_2 = new object[1];
            val_2[0] = val_4.GetType();
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClassType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), logTag:  4, log:  "Show: {0}", values:  val_2);
            return (Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupListPopup)val_4;
        }
        protected void Destroy()
        {
            object[] val_1 = new object[1];
            val_1[0] = this.GetType();
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  4, log:  "Close: {0}", values:  val_1);
            UnityEngine.Object.Destroy(obj:  this.gameObject);
            if(this.action == null)
            {
                    return;
            }
            
            this = ???;
            goto typeof(Royal.Scenes.Start.Context.Units.Flow.FlowAction).__il2cppRuntimeField_1B0;
        }
        public UiPopup()
        {
        
        }
    
    }

}
