using UnityEngine;

namespace Royal.Scenes.Game.Ui.Bottom.Boosters
{
    public class BoosterSelectionBlocker : UiPanel
    {
        // Fields
        public UnityEngine.BoxCollider2D colliderBox;
        public Royal.Scenes.Game.Ui.Bottom.Boosters.InGameBoosterManager inGameBoosterManager;
        private bool isTouchDisabledForTutorial;
        
        // Methods
        public void Disable()
        {
            if(this.colliderBox != null)
            {
                    this.colliderBox.enabled = false;
                return;
            }
            
            throw new NullReferenceException();
        }
        public void Enable()
        {
            if(this.colliderBox != null)
            {
                    this.colliderBox.enabled = true;
                return;
            }
            
            throw new NullReferenceException();
        }
        public void DisableTouchForTutorial()
        {
            this.colliderBox.enabled = true;
            this.isTouchDisabledForTutorial = true;
            goto typeof(Royal.Scenes.Game.Ui.Bottom.Boosters.BoosterSelectionBlocker).__il2cppRuntimeField_1E0;
        }
        public void EnableTouchAfterTutorial()
        {
            this.colliderBox.enabled = false;
            this.isTouchDisabledForTutorial = false;
            goto typeof(Royal.Scenes.Game.Ui.Bottom.Boosters.BoosterSelectionBlocker).__il2cppRuntimeField_1E0;
        }
        public override void TouchUp(UnityEngine.Vector2 vector2)
        {
            if(this.isTouchDisabledForTutorial != false)
            {
                    return;
            }
            
            if(this.inGameBoosterManager != null)
            {
                    this.inGameBoosterManager.DeselectBooster();
                return;
            }
            
            throw new NullReferenceException();
        }
        public BoosterSelectionBlocker()
        {
        
        }
    
    }

}
