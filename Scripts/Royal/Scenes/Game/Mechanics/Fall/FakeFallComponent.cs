using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Fall
{
    public class FakeFallComponent : IFallComponent
    {
        // Fields
        private readonly Royal.Scenes.Game.Mechanics.Items.Config.ItemModel masterItem;
        
        // Properties
        public float CurrentSpeed { get; set; }
        public float StateChangedTime { get; set; }
        
        // Methods
        public float get_CurrentSpeed()
        {
            var val_2 = 0;
            if(mem[1152921505110343680] != null)
            {
                    val_2 = val_2 + 1;
                return this.masterItem.fallComponent.CurrentSpeed;
            }
            
            var val_3 = mem[1152921505110343688];
            val_3 = val_3 + 1;
            Royal.Scenes.Game.Mechanics.Fall.IFallComponent val_1 = 1152921505110306816 + val_3;
            return this.masterItem.fallComponent.CurrentSpeed;
        }
        public void set_CurrentSpeed(float value)
        {
        
        }
        public float get_StateChangedTime()
        {
            var val_2 = 0;
            if(mem[1152921505110343680] != null)
            {
                    val_2 = val_2 + 1;
                return this.masterItem.fallComponent.CurrentSpeed;
            }
            
            var val_3 = mem[1152921505110343688];
            val_3 = val_3 + 1;
            Royal.Scenes.Game.Mechanics.Fall.IFallComponent val_1 = 1152921505110306816 + val_3;
            return this.masterItem.fallComponent.CurrentSpeed;
        }
        public void set_StateChangedTime(float value)
        {
        
        }
        public FakeFallComponent(Royal.Scenes.Game.Mechanics.Items.Config.ItemModel masterItem)
        {
            this.masterItem = masterItem;
        }
        public void SetFillingCell(Royal.Scenes.Game.Mechanics.Board.Cell.FillingCellModel model)
        {
        
        }
        public void ManualUpdate()
        {
        
        }
        public bool IsItemSteady()
        {
            var val_2 = 0;
            if(mem[1152921505110343680] != null)
            {
                    val_2 = val_2 + 1;
                return this.masterItem.fallComponent.IsItemSteady();
            }
            
            Royal.Scenes.Game.Mechanics.Fall.IFallComponent val_1 = 1152921505110306816 + ((mem[1152921505110343688]) << 4);
            return this.masterItem.fallComponent.IsItemSteady();
        }
    
    }

}
