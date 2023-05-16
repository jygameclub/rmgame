using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.LevelTutorials
{
    public class TutorialHandHelper
    {
        // Fields
        private readonly Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialViewAssets assets;
        private Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialHandView handView;
        
        // Methods
        public TutorialHandHelper(Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialViewAssets assets)
        {
            this.assets = assets;
        }
        public Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialHandView ShowHand()
        {
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialHandView val_3;
            if(this.handView == 0)
            {
                    this.handView = UnityEngine.Object.Instantiate<Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialHandView>(original:  this.assets.handView);
                return val_3;
            }
            
            val_3 = this.handView;
            return val_3;
        }
        public void HideHand()
        {
            if(this.handView == 0)
            {
                    return;
            }
            
            UnityEngine.Object.Destroy(obj:  this.handView.gameObject);
            this.handView = 0;
        }
    
    }

}
