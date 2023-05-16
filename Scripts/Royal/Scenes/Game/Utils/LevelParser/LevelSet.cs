using UnityEngine;

namespace Royal.Scenes.Game.Utils.LevelParser
{
    public class LevelSet
    {
        // Fields
        private readonly string name;
        public readonly System.Collections.Generic.List<Royal.Scenes.Game.Utils.LevelParser.LevelSetElement> items;
        private readonly System.Collections.Generic.List<int> targetColumns;
        private readonly bool canFall;
        public readonly int createRatio;
        public int birdMax;
        public int frogMax;
        public bool isAvailableForFill;
        private int totalRatioForItems;
        private readonly Royal.Scenes.Game.Levels.Units.LevelRandomManager randomManager;
        private readonly Royal.Player.Context.Units.LevelManager levelManager;
        private Royal.Scenes.Game.Mechanics.Items.BirdItem.BirdItemHelper birdItemHelper;
        private Royal.Scenes.Game.Mechanics.Items.FrogItem.FrogItemHelper frogItemHelper;
        
        // Methods
        public LevelSet(string name, bool canFall, int createRatio, int birdMax, int frogMax)
        {
            this.items = new System.Collections.Generic.List<Royal.Scenes.Game.Utils.LevelParser.LevelSetElement>();
            this.targetColumns = new System.Collections.Generic.List<System.Int32>();
            this.name = name;
            this.createRatio = createRatio;
            this.birdMax = birdMax;
            this.frogMax = frogMax;
            this.canFall = canFall;
            this.levelManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LevelManager>(id:  2);
            this.randomManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.LevelRandomManager>(contextId:  0);
        }
        public void InitFillAvailability()
        {
            this.totalRatioForItems = 0;
            this.isAvailableForFill = this.canFall;
            var val_3 = 4;
            do
            {
                var val_1 = val_3 - 4;
                if(val_1 >= this.canFall)
            {
                    return;
            }
            
                if(this.canFall <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_2 = this.canFall + 32;
                val_2 = this.isAvailableForFill;
                if(val_2 <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                if((this.canFall + 32 + 32 + 16) != 35)
            {
                    this.birdMax = 0;
            }
            
                if((this.canFall + 32 + 32 + 16) <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                if((this.canFall + 32 + 32 + 16 + 32 + 16) != 125)
            {
                    this.frogMax = 0;
            }
            
                val_3 = val_3 + 1;
            }
            while(this.items != null);
            
            throw new NullReferenceException();
        }
        public void CalculateFillRatioForItems()
        {
            this.totalRatioForItems = 0;
            var val_3 = 4;
            do
            {
                var val_1 = val_3 - 4;
                if(val_1 >= true)
            {
                    return;
            }
            
                if(true <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                if((mem[-6917529027641081832]) != false)
            {
                    if((mem[-6917529027641081832]) <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                int val_2 = mem[-6917529027641081832] + 32 + 20;
                val_2 = val_2 + this.totalRatioForItems;
                this.totalRatioForItems = val_2;
            }
            
                this.items = this.items;
                val_3 = val_3 + 1;
            }
            while(this.items != null);
            
            throw new NullReferenceException();
        }
        public void UpdateFillAvailability()
        {
            bool val_1 = true;
            var val_2 = 0;
            label_6:
            if(val_2 >= val_1)
            {
                goto label_2;
            }
            
            if(val_1 <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + 0;
            if(((true + 0) + 32 + 24) != 0)
            {
                    return;
            }
            
            val_2 = val_2 + 1;
            if(this.items != null)
            {
                goto label_6;
            }
            
            throw new NullReferenceException();
            label_2:
            this.isAvailableForFill = false;
        }
        public void AddTargetColumn(int columnIndex)
        {
            this.targetColumns.Add(item:  columnIndex);
        }
        public bool HasAnyTargetColumn()
        {
            return (bool)(this.targetColumns != 0) ? 1 : 0;
        }
        public bool HasTargetColumn(int column)
        {
            return this.targetColumns.Contains(item:  column);
        }
        public bool ContainsMatchItem()
        {
            if(true != 0)
            {
                    return (bool)((Royal.Scenes.Game.Mechanics.Items.Config.ItemExtensions.ToMatchType(itemType:  mem[-6917529027641081840])) != 0) ? 1 : 0;
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            return (bool)((Royal.Scenes.Game.Mechanics.Items.Config.ItemExtensions.ToMatchType(itemType:  mem[-6917529027641081840])) != 0) ? 1 : 0;
        }
        public Royal.Scenes.Game.Utils.LevelParser.TiledId GetPrioritizedItem()
        {
            Royal.Player.Context.Units.LevelManager val_5;
            Royal.Scenes.Game.Mechanics.Items.BirdItem.BirdItemHelper val_6;
            var val_7;
            if(this.isAvailableForFill == false)
            {
                    return 0;
            }
            
            val_5 = this.levelManager;
            if(this.levelManager.isThereBirdInLevel != false)
            {
                    val_6 = this.birdItemHelper;
                if(val_6 == null)
            {
                    Royal.Scenes.Game.Mechanics.Items.BirdItem.BirdItemHelper val_1 = Royal.Scenes.Game.Levels.LevelContext.GetLate<Royal.Scenes.Game.Mechanics.Items.BirdItem.BirdItemHelper>(contextId:  23);
                this.birdItemHelper = val_1;
            }
            
                val_5 = this.levelManager;
                val_7 = val_1.CanFillNewBirdItem();
            }
            else
            {
                    val_7 = 0;
            }
            
            if(this.levelManager.isThereFrogInLevel == false)
            {
                goto label_8;
            }
            
            if(this.frogItemHelper == null)
            {
                goto label_9;
            }
            
            if((val_7 & 1) != 0)
            {
                    return this.GetRandomItem();
            }
            
            label_15:
            if(this.frogItemHelper.CanFillNewFrogItem() == false)
            {
                    return 0;
            }
            
            return this.GetRandomItem();
            label_8:
            if((val_7 & 1) != 0)
            {
                    return this.GetRandomItem();
            }
            
            return 0;
            label_9:
            this.frogItemHelper = Royal.Scenes.Game.Levels.LevelContext.GetLate<Royal.Scenes.Game.Mechanics.Items.FrogItem.FrogItemHelper>(contextId:  34);
            if((val_7 & 1) == 0)
            {
                goto label_15;
            }
            
            return this.GetRandomItem();
        }
        public Royal.Scenes.Game.Utils.LevelParser.TiledId GetRandomItem()
        {
            var val_3;
            var val_4;
            bool val_3 = true;
            var val_4 = 0;
            val_3 = 0;
            label_8:
            if(val_4 >= val_3)
            {
                goto label_3;
            }
            
            if(val_3 <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_3 = val_3 + 0;
            if(((true + 0) + 32 + 24) == 0)
            {
                goto label_6;
            }
            
            val_3 = ((true + 0) + 32 + 20) + val_3;
            if(val_3 >= ((this.randomManager.Next(min:  0, max:  this.totalRatioForItems)) + 1))
            {
                goto label_7;
            }
            
            label_6:
            val_4 = val_4 + 1;
            if(this.items != null)
            {
                goto label_8;
            }
            
            throw new NullReferenceException();
            label_3:
            val_4 = 0;
            return (Royal.Scenes.Game.Utils.LevelParser.TiledId)val_4;
            label_7:
            val_4 = mem[(true + 0) + 32 + 16];
            val_4 = (true + 0) + 32 + 16;
            return (Royal.Scenes.Game.Utils.LevelParser.TiledId)val_4;
        }
        public Royal.Scenes.Game.Utils.LevelParser.TiledId GetRandomItemExcept(System.Collections.Generic.List<Royal.Scenes.Game.Utils.LevelParser.TiledId> forbiddenIds)
        {
            System.Collections.Generic.List<Royal.Scenes.Game.Utils.LevelParser.LevelSetElement> val_5;
            var val_6;
            var val_7 = 0;
            var val_8 = 4;
            label_14:
            var val_1 = val_8 - 4;
            if(val_1 >= true)
            {
                goto label_2;
            }
            
            if(true <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if((forbiddenIds.Contains(item:  mem[-6917529027641081840])) != true)
            {
                    if(0 <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                if((mem[-6917529027641081824] + 24) != 0)
            {
                    if((mem[-6917529027641081824] + 24) <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_7 = (mem[-6917529027641081824] + 24 + 32 + 20) + val_7;
            }
            
            }
            
            val_8 = val_8 + 1;
            if(this.items != null)
            {
                goto label_14;
            }
            
            label_2:
            val_5 = this.items;
            val_6 = 0;
            var val_9 = 4;
            do
            {
                var val_5 = val_9 - 4;
                if(val_5 >= true)
            {
                    return this.GetRandomItem();
            }
            
                if(true <= val_5)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                if((mem[-6917529027641081832]) != false)
            {
                    if((mem[-6917529027641081832]) <= val_5)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                if((forbiddenIds.Contains(item:  mem[-6917529027641081832] + 32 + 16)) != true)
            {
                    val_6 = (mem[-6917529027641081836]) + val_6;
                if(val_6 >= ((this.randomManager.Next(min:  0, max:  0)) + 1))
            {
                    return (Royal.Scenes.Game.Utils.LevelParser.TiledId)mem[-6917529027641081840];
            }
            
            }
            
            }
            
                val_5 = this.items;
                val_9 = val_9 + 1;
            }
            while(val_5 != null);
            
            throw new NullReferenceException();
        }
        public bool ShouldPrioritize()
        {
            if(this.birdMax == 0)
            {
                    return (bool)(this.frogMax != 0) ? 1 : 0;
            }
            
            return true;
        }
        public void FillFourColors()
        {
            System.Collections.Generic.List<Royal.Scenes.Game.Utils.LevelParser.LevelSetElement> val_4;
            int val_5;
            System.Collections.Generic.List<Royal.Scenes.Game.Utils.LevelParser.TiledId> val_1 = new System.Collections.Generic.List<Royal.Scenes.Game.Utils.LevelParser.TiledId>();
            val_1.Add(item:  1);
            val_1.Add(item:  2);
            val_1.Add(item:  3);
            val_1.Add(item:  4);
            val_4 = this.items;
            if(1152921519840294256 >= 1)
            {
                    var val_4 = 0;
                do
            {
                if(1152921519840294256 <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                bool val_2 = val_1.Remove(item:  "(lower(".__il2cppRuntimeField_10);
                val_4 = this.items;
                val_4 = val_4 + 1;
            }
            while(val_4 < 47874880);
            
            }
            else
            {
                    val_5 = 1;
            }
            
            if(1152921519840294256 < 1)
            {
                goto label_9;
            }
            
            var val_5 = 0;
            goto label_10;
            label_13:
            val_4 = this.items;
            label_10:
            if(val_5 >= 1152921519840294256)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            .id = "(lower(";
            .createRatio = val_5;
            val_4.Add(item:  new Royal.Scenes.Game.Utils.LevelParser.LevelSetElement());
            val_5 = val_5 + 1;
            if(val_5 < 47874880)
            {
                goto label_13;
            }
            
            label_9:
            this.InitFillAvailability();
            this.CalculateFillRatioForItems();
        }
        public bool ContainsSpecialItem()
        {
            var val_1;
            bool val_1 = true;
            var val_3 = 0;
            label_11:
            if(val_3 >= val_1)
            {
                goto label_2;
            }
            
            if(val_1 <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + 0;
            if(((true + 0) + 32 + 16) > 20)
            {
                goto label_5;
            }
            
            val_1 = 1;
            if(((true + 0) + 32 + 16) == 10)
            {
                    return (bool)val_1;
            }
            
            if(((true + 0) + 32 + 16) != 20)
            {
                goto label_9;
            }
            
            return (bool)val_1;
            label_5:
            if(((true + 0) + 32 + 16) > 50)
            {
                goto label_9;
            }
            
            var val_2 = (true + 0) + 32 + 16;
            val_2 = 1 << val_2;
            if(val_2 != 1073741824)
            {
                goto label_10;
            }
            
            label_9:
            val_3 = val_3 + 1;
            if(this.items != null)
            {
                goto label_11;
            }
            
            throw new NullReferenceException();
            label_2:
            val_1 = 0;
            return (bool)val_1;
            label_10:
            val_1 = 1;
            return (bool)val_1;
        }
    
    }

}
