using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.CupboardItem
{
    public class CupboardItemRegistry : IGameContextUnit, IContextUnit, ILateContextUnit
    {
        // Fields
        private const int MaxItems = 16;
        private readonly System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.CupboardItem.CupboardItemModel> cupboardItems;
        
        // Properties
        public int Id { get; }
        
        // Methods
        public int get_Id()
        {
            return 20;
        }
        public void Bind()
        {
            Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.CellGridManager>(contextId:  2).add_OnCellGridViewsInitialized(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Game.Mechanics.Items.CupboardItem.CupboardItemRegistry::SortCupboardItems()));
        }
        public void Clear(bool gameExit)
        {
            this.cupboardItems.Clear();
        }
        private void SortCupboardItems()
        {
            this.cupboardItems.Sort(comparer:  new Royal.Scenes.Game.Mechanics.Items.CupboardItem.CupboardItemComparer());
        }
        public void Add(Royal.Scenes.Game.Mechanics.Items.CupboardItem.CupboardItemModel cupboardItem)
        {
            if(true == 16)
            {
                    return;
            }
            
            this.cupboardItems.Add(item:  cupboardItem);
        }
        public Royal.Scenes.Game.Mechanics.Items.CupboardItem.CupboardItemModel GetNearestAnimatedCupboardItem(Royal.Scenes.Game.Mechanics.Items.CupboardItem.CupboardItemModel cupboardItem)
        {
            var val_3;
            var val_4 = 1152921520373242688;
            int val_3 = this.cupboardItems.IndexOf(item:  cupboardItem);
            label_7:
            if(val_3 <= 0)
            {
                goto label_2;
            }
            
            val_3 = val_3 - 1;
            if(val_4 <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_4 = val_4 + (val_3 << 3);
            val_3 = mem[(1152921520373242688 + ((val_1 - 1)) << 3) + 32];
            val_3 = (1152921520373242688 + ((val_1 - 1)) << 3) + 32;
            var val_5 = (1152921520373242688 + ((val_1 - 1)) << 3) + 32 + 256 + 152;
            val_5 = Royal.Scenes.Game.Levels.LevelContext.FrameCount - val_5;
            if(val_5 >= 5)
            {
                goto label_7;
            }
            
            return (Royal.Scenes.Game.Mechanics.Items.CupboardItem.CupboardItemModel)val_3;
            label_2:
            val_3 = 0;
            return (Royal.Scenes.Game.Mechanics.Items.CupboardItem.CupboardItemModel)val_3;
        }
        public void Remove(Royal.Scenes.Game.Mechanics.Items.CupboardItem.CupboardItemModel cupboardItem)
        {
            bool val_1 = this.cupboardItems.Remove(item:  cupboardItem);
        }
        public CupboardItemRegistry()
        {
            this.cupboardItems = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.CupboardItem.CupboardItemModel>(capacity:  16);
        }
    
    }

}
