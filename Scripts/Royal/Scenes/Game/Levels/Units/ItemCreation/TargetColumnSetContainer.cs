using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.ItemCreation
{
    public class TargetColumnSetContainer
    {
        // Fields
        private readonly System.Collections.Generic.List<Royal.Scenes.Game.Utils.LevelParser.LevelSet>[] columnSets;
        
        // Methods
        public void Clear()
        {
            var val_2 = 0;
            do
            {
                if(val_2 >= this.columnSets.Length)
            {
                    return;
            }
            
                this.columnSets[val_2] = new System.Collections.Generic.List<Royal.Scenes.Game.Utils.LevelParser.LevelSet>();
                val_2 = val_2 + 1;
            }
            while(this.columnSets != null);
            
            throw new NullReferenceException();
        }
        public void AddSetToColumn(Royal.Scenes.Game.Utils.LevelParser.LevelSet set, int columnIndex)
        {
            System.Collections.Generic.List<Royal.Scenes.Game.Utils.LevelParser.LevelSet>[] val_2;
            set.AddTargetColumn(columnIndex:  columnIndex);
            val_2 = this.columnSets;
            if(val_2[(long)columnIndex] == null)
            {
                    mem2[0] = new System.Collections.Generic.List<Royal.Scenes.Game.Utils.LevelParser.LevelSet>();
                val_2 = this.columnSets;
            }
            
            val_2[(long)columnIndex].Add(item:  set);
        }
        public System.Collections.Generic.List<Royal.Scenes.Game.Utils.LevelParser.LevelSet> GetSetsFromColumn(int columnIndex)
        {
            return (System.Collections.Generic.List<Royal.Scenes.Game.Utils.LevelParser.LevelSet>)this.columnSets[columnIndex];
        }
        public bool HasTarget(int columnIndex)
        {
            return (bool)(this.columnSets[columnIndex] != 0) ? 1 : 0;
        }
        public int GetTotalRatioForColumn(int columnIndex)
        {
            var val_3;
            int val_4;
            var val_5;
            val_4 = columnIndex;
            bool val_3 = true;
            System.Collections.Generic.List<Royal.Scenes.Game.Utils.LevelParser.LevelSet> val_1 = this.GetSetsFromColumn(columnIndex:  val_4);
            if(val_1 != null)
            {
                    val_4 = val_1;
                if(val_3 >= 1)
            {
                    var val_4 = 0;
                val_5 = 0;
                do
            {
                if(val_3 <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_3 = val_3 + 0;
                val_3 = mem[(true + 0) + 32];
                val_3 = (true + 0) + 32;
                if(((true + 0) + 32 + 56) != 0)
            {
                    if(val_3.ShouldPrioritize() != true)
            {
                    val_5 = ((true + 0) + 32 + 44) + val_5;
            }
            
            }
            
                val_4 = val_4 + 1;
            }
            while(val_4 < ((true + 0) + 32 + 44));
            
                return (int)val_5;
            }
            
            }
            
            val_5 = 0;
            return (int)val_5;
        }
        public TargetColumnSetContainer()
        {
            this.columnSets = new System.Collections.Generic.List<Royal.Scenes.Game.Utils.LevelParser.LevelSet>[9];
        }
    
    }

}
