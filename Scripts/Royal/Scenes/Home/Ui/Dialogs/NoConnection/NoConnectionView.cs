using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.NoConnection
{
    public class NoConnectionView : MonoBehaviour
    {
        // Fields
        public UnityEngine.GameObject noConnection;
        public UnityEngine.GameObject maintenance;
        
        // Methods
        public bool IsActive()
        {
            return this.gameObject.activeSelf;
        }
        public void SetActive(bool activate)
        {
            var val_7;
            this.gameObject.SetActive(value:  activate);
            if(activate != false)
            {
                    bool val_4 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.BackendHttpService>(id:  7).IsInMaintenance(checkAgain:  true);
                this.maintenance.SetActive(value:  val_4);
                val_7 = (~val_4) & 1;
            }
            else
            {
                    this.maintenance.SetActive(value:  false);
                val_7 = 0;
            }
            
            this.noConnection.SetActive(value:  false);
        }
        public static void CheckMaintenanceMode()
        {
            bool val_2 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.BackendHttpService>(id:  7).IsInMaintenance(checkAgain:  true);
        }
        public NoConnectionView()
        {
        
        }
    
    }

}
