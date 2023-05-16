using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.BuyBooster
{
    public struct BuyBoosterData
    {
        // Fields
        public string name;
        public int price;
        public string info;
        
        // Properties
        public static Royal.Scenes.Home.Ui.Dialogs.BuyBooster.BuyBoosterData RocketData { get; }
        public static Royal.Scenes.Home.Ui.Dialogs.BuyBooster.BuyBoosterData TntData { get; }
        public static Royal.Scenes.Home.Ui.Dialogs.BuyBooster.BuyBoosterData LightBallData { get; }
        public static Royal.Scenes.Home.Ui.Dialogs.BuyBooster.BuyBoosterData ArrowData { get; }
        public static Royal.Scenes.Home.Ui.Dialogs.BuyBooster.BuyBoosterData CannonData { get; }
        public static Royal.Scenes.Home.Ui.Dialogs.BuyBooster.BuyBoosterData HammerData { get; }
        public static Royal.Scenes.Home.Ui.Dialogs.BuyBooster.BuyBoosterData JesterHatData { get; }
        
        // Methods
        public static Royal.Scenes.Home.Ui.Dialogs.BuyBooster.BuyBoosterData get_RocketData()
        {
            Royal.Scenes.Home.Ui.Dialogs.BuyBooster.BuyBoosterData val_0;
            val_0.name = "BuyBoosterRocket";
            val_0.price = Royal.Scenes.Game.Mechanics.Boosters.BoosterTypeExtension.Price(boosterType:  1);
            mem[1152921519522041020] = 0;
            val_0.info = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "RocketBuyInfo");
            return val_0;
        }
        public static Royal.Scenes.Home.Ui.Dialogs.BuyBooster.BuyBoosterData get_TntData()
        {
            Royal.Scenes.Home.Ui.Dialogs.BuyBooster.BuyBoosterData val_0;
            val_0.name = "BuyBoosterTnt";
            val_0.price = Royal.Scenes.Game.Mechanics.Boosters.BoosterTypeExtension.Price(boosterType:  2);
            mem[1152921519522185788] = 0;
            val_0.info = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "TntBuyInfo");
            return val_0;
        }
        public static Royal.Scenes.Home.Ui.Dialogs.BuyBooster.BuyBoosterData get_LightBallData()
        {
            Royal.Scenes.Home.Ui.Dialogs.BuyBooster.BuyBoosterData val_0;
            val_0.name = "BuyBoosterLightBall";
            val_0.price = Royal.Scenes.Game.Mechanics.Boosters.BoosterTypeExtension.Price(boosterType:  3);
            mem[1152921519522330588] = 0;
            val_0.info = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "LightballBuyInfo");
            return val_0;
        }
        public static Royal.Scenes.Home.Ui.Dialogs.BuyBooster.BuyBoosterData get_ArrowData()
        {
            Royal.Scenes.Home.Ui.Dialogs.BuyBooster.BuyBoosterData val_0;
            val_0.name = "BuyBoosterArrow";
            val_0.price = Royal.Scenes.Game.Mechanics.Boosters.BoosterTypeExtension.Price(boosterType:  5);
            mem[1152921519522475388] = 0;
            val_0.info = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "ArrowBoosterUnlock");
            return val_0;
        }
        public static Royal.Scenes.Home.Ui.Dialogs.BuyBooster.BuyBoosterData get_CannonData()
        {
            Royal.Scenes.Home.Ui.Dialogs.BuyBooster.BuyBoosterData val_0;
            val_0.name = "BuyBoosterCannon";
            val_0.price = Royal.Scenes.Game.Mechanics.Boosters.BoosterTypeExtension.Price(boosterType:  6);
            mem[1152921519522620188] = 0;
            val_0.info = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "CannonBoosterUnlock");
            return val_0;
        }
        public static Royal.Scenes.Home.Ui.Dialogs.BuyBooster.BuyBoosterData get_HammerData()
        {
            Royal.Scenes.Home.Ui.Dialogs.BuyBooster.BuyBoosterData val_0;
            val_0.name = "BuyBoosterHammer";
            val_0.price = Royal.Scenes.Game.Mechanics.Boosters.BoosterTypeExtension.Price(boosterType:  4);
            mem[1152921519522764988] = 0;
            val_0.info = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "HammerBoosterUnlock");
            return val_0;
        }
        public static Royal.Scenes.Home.Ui.Dialogs.BuyBooster.BuyBoosterData get_JesterHatData()
        {
            Royal.Scenes.Home.Ui.Dialogs.BuyBooster.BuyBoosterData val_0;
            val_0.name = "BuyBoosterJesterHat";
            val_0.price = Royal.Scenes.Game.Mechanics.Boosters.BoosterTypeExtension.Price(boosterType:  7);
            mem[1152921519522909788] = 0;
            val_0.info = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "JesterHatBoosterUnlock");
            return val_0;
        }
    
    }

}
