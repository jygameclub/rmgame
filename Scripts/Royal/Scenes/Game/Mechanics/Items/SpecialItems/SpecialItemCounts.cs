using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SpecialItems
{
    public class SpecialItemCounts
    {
        // Fields
        private readonly System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Items.Config.ItemType, int> itemCreation;
        private readonly System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Items.Config.ItemType, int> itemUse;
        private readonly System.Collections.Generic.Dictionary<Royal.Scenes.Game.Levels.Units.Combo.ComboType, int> comboDict;
        
        // Methods
        public void Reset()
        {
            this.itemCreation.Clear();
            this.itemUse.Clear();
            this.comboDict.Clear();
        }
        public static void IncrementItemUse(Royal.Scenes.Game.Mechanics.Items.Config.ItemType id)
        {
            Royal.Player.Context.Data.Session.__il2cppRuntimeField_78.IncrementItemUseCount(id:  id);
        }
        public static void IncrementItemCreation(Royal.Scenes.Game.Mechanics.Items.Config.ItemType id)
        {
            Royal.Player.Context.Data.Session.__il2cppRuntimeField_78.IncrementItemCreationCount(id:  id);
        }
        public static void IncrementComboUse(Royal.Scenes.Game.Levels.Units.Combo.ComboType comboType)
        {
            Royal.Player.Context.Data.Session.__il2cppRuntimeField_78.IncrementComboCount(comboType:  comboType);
        }
        private void IncrementItemCreationCount(Royal.Scenes.Game.Mechanics.Items.Config.ItemType id)
        {
            if((this.itemCreation.TryGetValue(key:  id, value: out  0)) != false)
            {
                    this.itemCreation.set_Item(key:  id, value:  1);
                return;
            }
            
            this.itemCreation.Add(key:  id, value:  1);
        }
        public int GetItemCreationCount(Royal.Scenes.Game.Mechanics.Items.Config.ItemType id)
        {
            int val_1 = 0;
            return (int)((this.itemCreation.TryGetValue(key:  id, value: out  val_1)) != true) ? (val_1) : 0;
        }
        private void IncrementItemUseCount(Royal.Scenes.Game.Mechanics.Items.Config.ItemType id)
        {
            if((this.itemUse.TryGetValue(key:  id, value: out  0)) != false)
            {
                    this.itemUse.set_Item(key:  id, value:  1);
                return;
            }
            
            this.itemUse.Add(key:  id, value:  1);
        }
        private int GetItemUseCount(Royal.Scenes.Game.Mechanics.Items.Config.ItemType id)
        {
            int val_1 = 0;
            return (int)((this.itemUse.TryGetValue(key:  id, value: out  val_1)) != true) ? (val_1) : 0;
        }
        private void IncrementComboCount(Royal.Scenes.Game.Levels.Units.Combo.ComboType comboType)
        {
            if((this.comboDict.TryGetValue(key:  comboType, value: out  0)) != false)
            {
                    this.comboDict.set_Item(key:  comboType, value:  1);
                return;
            }
            
            this.comboDict.Add(key:  comboType, value:  1);
        }
        private int GetComboCount(Royal.Scenes.Game.Levels.Units.Combo.ComboType comboType)
        {
            int val_1 = 0;
            return (int)((this.comboDict.TryGetValue(key:  comboType, value: out  val_1)) != true) ? (val_1) : 0;
        }
        public Royal.Infrastructure.Services.Analytics.SpecialItemCountsJson Serialize()
        {
            .rocket_creation = this.GetItemCreationCount(id:  2);
            .tnt_creation = this.GetItemCreationCount(id:  4);
            .lb_creation = this.GetItemCreationCount(id:  5);
            .propeller_creation = this.GetItemCreationCount(id:  3);
            .rocket_use = this.GetItemUseCount(id:  2);
            .tnt_use = this.GetItemUseCount(id:  4);
            .lb_use = this.GetItemUseCount(id:  5);
            .propeller_use = this.GetItemUseCount(id:  3);
            .rocket_rocket = this.GetComboCount(comboType:  7);
            .rocket_propeller = this.GetComboCount(comboType:  9);
            .tnt_rocket = this.GetComboCount(comboType:  6);
            .lb_rocket = this.GetComboCount(comboType:  4);
            .propeller_propeller = this.GetComboCount(comboType:  10);
            .tnt_propeller = this.GetComboCount(comboType:  8);
            .lb_propeller = this.GetComboCount(comboType:  3);
            .tnt_tnt = this.GetComboCount(comboType:  5);
            .lb_tnt = this.GetComboCount(comboType:  2);
            .lb_lb = this.GetComboCount(comboType:  1);
            return (Royal.Infrastructure.Services.Analytics.SpecialItemCountsJson)new Royal.Infrastructure.Services.Analytics.SpecialItemCountsJson();
        }
        public SpecialItemCounts()
        {
            this.itemCreation = new System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Items.Config.ItemType, System.Int32>();
            this.itemUse = new System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Items.Config.ItemType, System.Int32>();
            this.comboDict = new System.Collections.Generic.Dictionary<Royal.Scenes.Game.Levels.Units.Combo.ComboType, System.Int32>();
        }
    
    }

}
