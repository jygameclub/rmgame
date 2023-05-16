using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Boosters.JesterHat.View
{
    public class JesterHatShuffleButton : MonoBehaviour
    {
        // Fields
        private System.Action OnShuffleClick;
        
        // Methods
        public void add_OnShuffleClick(System.Action value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnShuffleClick, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnShuffleClick != 1152921523897419608);
            
            return;
            label_2:
        }
        public void remove_OnShuffleClick(System.Action value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnShuffleClick, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnShuffleClick != 1152921523897556184);
            
            return;
            label_2:
        }
        public void ShuffleClick()
        {
            if(this.OnShuffleClick == null)
            {
                    return;
            }
            
            this.OnShuffleClick.Invoke();
        }
        private void OnDestroy()
        {
            this.OnShuffleClick = 0;
        }
        public JesterHatShuffleButton()
        {
        
        }
    
    }

}
