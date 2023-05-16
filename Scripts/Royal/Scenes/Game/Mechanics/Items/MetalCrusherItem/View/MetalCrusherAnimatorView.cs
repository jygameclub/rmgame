using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View
{
    public class MetalCrusherAnimatorView : MonoBehaviour
    {
        // Fields
        public Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View.MetalCrusherItemView metalCrusherItemView;
        
        // Methods
        public void DisablePipeHeat()
        {
            if(this.metalCrusherItemView != null)
            {
                    this.metalCrusherItemView.TogglePipeHeat(isEnabled:  false);
                return;
            }
            
            throw new NullReferenceException();
        }
        public MetalCrusherAnimatorView()
        {
        
        }
    
    }

}
