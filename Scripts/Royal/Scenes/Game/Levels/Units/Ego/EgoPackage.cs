using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.Ego
{
    public class EgoPackage
    {
        // Fields
        private readonly int <Price>k__BackingField;
        private readonly byte <Moves>k__BackingField;
        private readonly byte <DifferentRewardCount>k__BackingField;
        private byte[] specialItems;
        private readonly Royal.Scenes.Game.Mechanics.Items.Config.ItemType <FirstItemType>k__BackingField;
        private readonly Royal.Scenes.Game.Mechanics.Items.Config.ItemType <SecondItemType>k__BackingField;
        
        // Properties
        public int Price { get; }
        public byte Moves { get; }
        public byte DifferentRewardCount { get; }
        public Royal.Scenes.Game.Mechanics.Items.Config.ItemType FirstItemType { get; }
        public Royal.Scenes.Game.Mechanics.Items.Config.ItemType SecondItemType { get; }
        
        // Methods
        public int get_Price()
        {
            return (int)this.<Price>k__BackingField;
        }
        public byte get_Moves()
        {
            return (byte)this.<Moves>k__BackingField;
        }
        public byte get_DifferentRewardCount()
        {
            return (byte)this.<DifferentRewardCount>k__BackingField;
        }
        public Royal.Scenes.Game.Mechanics.Items.Config.ItemType get_FirstItemType()
        {
            return (Royal.Scenes.Game.Mechanics.Items.Config.ItemType)this.<FirstItemType>k__BackingField;
        }
        public Royal.Scenes.Game.Mechanics.Items.Config.ItemType get_SecondItemType()
        {
            return (Royal.Scenes.Game.Mechanics.Items.Config.ItemType)this.<SecondItemType>k__BackingField;
        }
        public EgoPackage(int price, byte moves, byte rocketCount = 0, byte tntCount = 0, byte lightballCount = 0, Royal.Scenes.Game.Mechanics.Items.Config.ItemType firstItemType = 0, Royal.Scenes.Game.Mechanics.Items.Config.ItemType secondItemType = 0)
        {
            this.<Price>k__BackingField = price;
            this.<Moves>k__BackingField = moves;
            byte[] val_1 = new byte[3];
            this.specialItems = val_1;
            val_1[0] = rocketCount;
            this.specialItems = tntCount;
            this.specialItems = lightballCount;
            byte val_2 = rocketCount + tntCount;
            val_2 = val_2 + lightballCount;
            val_2 = val_2 + 1;
            this.<DifferentRewardCount>k__BackingField = val_2;
            this.<FirstItemType>k__BackingField = firstItemType;
            this.<SecondItemType>k__BackingField = secondItemType;
        }
        public byte GetRocketCount()
        {
            return (byte)this.specialItems[0];
        }
        public byte GetTntCount()
        {
            return (byte)this.specialItems[0];
        }
        public byte GetLightballCount()
        {
            return (byte)this.specialItems[0];
        }
    
    }

}
