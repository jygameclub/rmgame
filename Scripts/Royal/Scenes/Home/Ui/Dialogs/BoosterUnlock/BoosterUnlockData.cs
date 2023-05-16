using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.BoosterUnlock
{
    public struct BoosterUnlockData
    {
        // Fields
        public string name;
        public string info;
        
        // Properties
        public static Royal.Scenes.Home.Ui.Dialogs.BoosterUnlock.BoosterUnlockData ArrowData { get; }
        public static Royal.Scenes.Home.Ui.Dialogs.BoosterUnlock.BoosterUnlockData CannonData { get; }
        public static Royal.Scenes.Home.Ui.Dialogs.BoosterUnlock.BoosterUnlockData HammerData { get; }
        public static Royal.Scenes.Home.Ui.Dialogs.BoosterUnlock.BoosterUnlockData JesterHatData { get; }
        
        // Methods
        public static Royal.Scenes.Home.Ui.Dialogs.BoosterUnlock.BoosterUnlockData get_ArrowData()
        {
            return new Royal.Scenes.Home.Ui.Dialogs.BoosterUnlock.BoosterUnlockData() {name = "ArrowBoosterUnlock", info = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "ArrowBoosterUnlock")};
        }
        public static Royal.Scenes.Home.Ui.Dialogs.BoosterUnlock.BoosterUnlockData get_CannonData()
        {
            return new Royal.Scenes.Home.Ui.Dialogs.BoosterUnlock.BoosterUnlockData() {name = "CannonBoosterUnlock", info = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "CannonBoosterUnlock")};
        }
        public static Royal.Scenes.Home.Ui.Dialogs.BoosterUnlock.BoosterUnlockData get_HammerData()
        {
            return new Royal.Scenes.Home.Ui.Dialogs.BoosterUnlock.BoosterUnlockData() {name = "HammerBoosterUnlock", info = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "HammerBoosterUnlock")};
        }
        public static Royal.Scenes.Home.Ui.Dialogs.BoosterUnlock.BoosterUnlockData get_JesterHatData()
        {
            return new Royal.Scenes.Home.Ui.Dialogs.BoosterUnlock.BoosterUnlockData() {name = "JesterHatBoosterUnlock", info = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "JesterHatBoosterUnlock")};
        }
    
    }

}
