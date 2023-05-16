using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Boosters.Cannon.View
{
    public class CannonBoosterAssets : ScriptableObject
    {
        // Fields
        public Royal.Scenes.Game.Mechanics.Boosters.Cannon.View.CannonBoosterView cannonBoosterPrefab;
        public Royal.Scenes.Game.Mechanics.Boosters.Cannon.View.CannonBoosterBallView cannonBallPrefab;
        
        // Methods
        public Royal.Scenes.Game.Mechanics.Boosters.Cannon.View.CannonBoosterView GetCannonPrefab()
        {
            return (Royal.Scenes.Game.Mechanics.Boosters.Cannon.View.CannonBoosterView)this.cannonBoosterPrefab;
        }
        public Royal.Scenes.Game.Mechanics.Boosters.Cannon.View.CannonBoosterBallView GetCannonBallPrefab()
        {
            return (Royal.Scenes.Game.Mechanics.Boosters.Cannon.View.CannonBoosterBallView)this.cannonBallPrefab;
        }
        public CannonBoosterAssets()
        {
        
        }
    
    }

}
