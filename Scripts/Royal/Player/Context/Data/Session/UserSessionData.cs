using UnityEngine;

namespace Royal.Player.Context.Data.Session
{
    public class UserSessionData
    {
        // Fields
        public readonly Royal.Player.Context.Data.Session.UserPrelevelBoosterSelectionData prelevelSelection;
        public readonly Royal.Player.Context.Data.Session.UserActiveLevelData activeLevel;
        public readonly Royal.Player.Context.Data.Session.AnimationData animationData;
        public readonly Royal.Player.Context.Data.Session.OneSignalTagData oneSignalTagData;
        public float royalPassScrollPosition;
        
        // Methods
        public UserSessionData()
        {
            Royal.Player.Context.Data.Session.AnimationData val_1 = new Royal.Player.Context.Data.Session.AnimationData();
            this.animationData = val_1;
            this.activeLevel = new Royal.Player.Context.Data.Session.UserActiveLevelData(data:  val_1);
            this.prelevelSelection = new Royal.Player.Context.Data.Session.UserPrelevelBoosterSelectionData();
            this.oneSignalTagData = new Royal.Player.Context.Data.Session.OneSignalTagData();
            this.royalPassScrollPosition = -1f;
        }
        public void Reset()
        {
            this.activeLevel = 0;
            this.prelevelSelection = 0;
            this.prelevelSelection = 0;
            this.animationData.Reset();
            this.royalPassScrollPosition = -1f;
        }
        public void ResetOnSceneChange()
        {
            this.royalPassScrollPosition = -1f;
        }
    
    }

}
