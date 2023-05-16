using UnityEngine;

namespace I2.Loc
{
    public class CustomLocalizeCallback : MonoBehaviour
    {
        // Fields
        public UnityEngine.Events.UnityEvent _OnLocalize;
        
        // Methods
        public void OnEnable()
        {
            I2.Loc.LocalizationManager.remove_OnLocalizeEvent(value:  new LocalizationManager.OnLocalizeCallback(object:  this, method:  public System.Void I2.Loc.CustomLocalizeCallback::OnLocalize()));
            I2.Loc.LocalizationManager.add_OnLocalizeEvent(value:  new LocalizationManager.OnLocalizeCallback(object:  this, method:  public System.Void I2.Loc.CustomLocalizeCallback::OnLocalize()));
        }
        public void OnDisable()
        {
            I2.Loc.LocalizationManager.remove_OnLocalizeEvent(value:  new LocalizationManager.OnLocalizeCallback(object:  this, method:  public System.Void I2.Loc.CustomLocalizeCallback::OnLocalize()));
        }
        public void OnLocalize()
        {
            if(this._OnLocalize != null)
            {
                    this._OnLocalize.Invoke();
                return;
            }
            
            throw new NullReferenceException();
        }
        public CustomLocalizeCallback()
        {
            this._OnLocalize = new UnityEngine.Events.UnityEvent();
        }
    
    }

}
