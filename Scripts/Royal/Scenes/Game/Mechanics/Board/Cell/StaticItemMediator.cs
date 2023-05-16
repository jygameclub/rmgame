using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Board.Cell
{
    public class StaticItemMediator
    {
        // Fields
        private readonly Royal.Scenes.Game.Mechanics.Items.Config.StaticItemModel[] items;
        private readonly Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell;
        public readonly Royal.Scenes.Game.Mechanics.Explode.ExploderContainer aboveExploderContainer;
        public readonly Royal.Scenes.Game.Mechanics.Explode.ExploderContainer belowExploderContainer;
        private readonly System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.Config.StaticItemModel> aboveItems;
        private readonly System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.Config.StaticItemModel> belowItems;
        
        // Methods
        public StaticItemMediator(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cellModel)
        {
            System.String[] val_2 = System.Enum.GetNames(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            int val_3 = val_2.Length - 1;
            this.items = new Royal.Scenes.Game.Mechanics.Items.Config.StaticItemModel[0];
            this.cell = cellModel;
            this.aboveExploderContainer = new Royal.Scenes.Game.Mechanics.Explode.ExploderContainer();
            this.belowExploderContainer = new Royal.Scenes.Game.Mechanics.Explode.ExploderContainer();
            this.aboveItems = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.Config.StaticItemModel>();
            this.belowItems = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.Config.StaticItemModel>();
        }
        public System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.Config.StaticItemModel> GetAboveItems()
        {
            return (System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.Config.StaticItemModel>)this.aboveItems;
        }
        public System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.Config.StaticItemModel> GetBelowItems()
        {
            return (System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.Config.StaticItemModel>)this.belowItems;
        }
        public Royal.Scenes.Game.Mechanics.Items.Config.StaticItemModel GetTopMostAboveItem()
        {
            var val_2;
            System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.Config.StaticItemModel> val_2 = this.aboveItems;
            if(W9 != 0)
            {
                    val_2 = val_2 + ((W9 - 1) << 3);
                return (Royal.Scenes.Game.Mechanics.Items.Config.StaticItemModel)val_2;
            }
            
            val_2 = 0;
            return (Royal.Scenes.Game.Mechanics.Items.Config.StaticItemModel)val_2;
        }
        public Royal.Scenes.Game.Mechanics.Items.Config.StaticItemModel GetTopMostBelowItem()
        {
            var val_2;
            System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.Config.StaticItemModel> val_2 = this.belowItems;
            if(W9 != 0)
            {
                    val_2 = val_2 + ((W9 - 1) << 3);
                return (Royal.Scenes.Game.Mechanics.Items.Config.StaticItemModel)val_2;
            }
            
            val_2 = 0;
            return (Royal.Scenes.Game.Mechanics.Items.Config.StaticItemModel)val_2;
        }
        public bool ExplodeTopMostAboveItem(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            if((this.aboveExploderContainer.ContainsExploder(id:  268435460)) == true)
            {
                    return true;
            }
            
            System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.Config.StaticItemModel> val_3 = this.aboveItems;
            if(W9 == 0)
            {
                    return true;
            }
            
            val_3 = val_3 + ((W9 - 1) << 3);
            if((47599616 & 1) == 0)
            {
                    if(2140632112 == 5)
            {
                    return true;
            }
            
            }
            
            this.aboveExploderContainer.AddToExploders(id:  268435460);
            this.belowExploderContainer.AddToExploders(id:  268435460);
            this.ExplodeStaticItem(itemType:  mem[47599636], explodeData:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id});
            return true;
        }
        public void ExplodeAllAboveItems(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            var val_1;
            var val_2;
            val_1 = 1152921523927509376;
            val_2 = 0;
            if(<0)
            {
                goto label_5;
            }
            
            var val_1 = 33;
            label_6:
            if(true <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            this.ExplodeStaticItem(itemType:  mem[2639109381639110676], explodeData:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id});
            val_2 = val_2 - 1;
            if((val_2 & 2147483648) != 0)
            {
                goto label_5;
            }
            
            val_1 = val_1 - 8;
            if(this.aboveItems != null)
            {
                goto label_6;
            }
            
            label_5:
            this.aboveExploderContainer.AddToExploders(id:  268435460);
        }
        public void ExplodeTopMostBelowItem(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            if((this.belowExploderContainer.ContainsExploder(id:  268435460)) == true)
            {
                    return;
            }
            
            if(W9 == 0)
            {
                    return;
            }
            
            this.belowExploderContainer.AddToExploders(id:  268435460);
            this.ExplodeStaticItem(itemType:  mem[47599636], explodeData:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id});
        }
        public void ExplodeAllBelowItems(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            var val_1;
            var val_2;
            val_1 = 1152921523927831488;
            val_2 = 0;
            if(<0)
            {
                goto label_5;
            }
            
            var val_1 = 33;
            label_6:
            if(true <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            this.ExplodeStaticItem(itemType:  mem[2639109381639110676], explodeData:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id});
            val_2 = val_2 - 1;
            if((val_2 & 2147483648) != 0)
            {
                goto label_5;
            }
            
            val_1 = val_1 - 8;
            if(this.belowItems != null)
            {
                goto label_6;
            }
            
            label_5:
            this.belowExploderContainer.AddToExploders(id:  268435460);
        }
        public bool HasBelowItem()
        {
            return (bool)(this.belowItems > 0) ? 1 : 0;
        }
        public bool HasTouchBlockingItemExceptChain()
        {
            var val_1;
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
            if((((true + 0) + 32) & 1) != 0)
            {
                goto label_5;
            }
            
            val_2 = val_2 + 1;
            if(this.aboveItems != null)
            {
                goto label_6;
            }
            
            throw new NullReferenceException();
            label_2:
            val_1 = 0;
            return (bool)val_1;
            label_5:
            val_1 = 1;
            return (bool)val_1;
        }
        public bool HasTouchBlockingItem()
        {
            var val_1;
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
            if((((true + 0) + 32) & 1) != 0)
            {
                goto label_5;
            }
            
            val_2 = val_2 + 1;
            if(this.aboveItems != null)
            {
                goto label_6;
            }
            
            throw new NullReferenceException();
            label_2:
            val_1 = 0;
            return (bool)val_1;
            label_5:
            val_1 = 1;
            return (bool)val_1;
        }
        public bool HasPropellerBlockingItem()
        {
            var val_1;
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
            if((((true + 0) + 32) & 1) != 0)
            {
                goto label_5;
            }
            
            val_2 = val_2 + 1;
            if(this.aboveItems != null)
            {
                goto label_6;
            }
            
            throw new NullReferenceException();
            label_2:
            val_1 = 0;
            return (bool)val_1;
            label_5:
            val_1 = 1;
            return (bool)val_1;
        }
        public bool HasFallBlockingItem()
        {
            var val_1;
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
            if((((true + 0) + 32) & 1) != 0)
            {
                goto label_5;
            }
            
            val_2 = val_2 + 1;
            if(this.aboveItems != null)
            {
                goto label_6;
            }
            
            throw new NullReferenceException();
            label_2:
            val_1 = 0;
            return (bool)val_1;
            label_5:
            val_1 = 1;
            return (bool)val_1;
        }
        public bool HasStaticItem(Royal.Scenes.Game.Mechanics.Board.Cell.StaticItemType itemType)
        {
            return (bool)((this.GetStaticItem(itemType:  itemType)) != 0) ? 1 : 0;
        }
        public Royal.Scenes.Game.Mechanics.Items.Config.StaticItemModel GetStaticItem(Royal.Scenes.Game.Mechanics.Board.Cell.StaticItemType itemType)
        {
            return (Royal.Scenes.Game.Mechanics.Items.Config.StaticItemModel)this.items[itemType];
        }
        public void TryPlayInvalidMoveAnimationForTopMostAboveItem()
        {
            if(this.GetTopMostAboveItem() == null)
            {
                    return;
            }
            
            goto typeof(Royal.Scenes.Game.Mechanics.Items.Config.StaticItemModel).__il2cppRuntimeField_200;
        }
        public void AddStaticItem(Royal.Scenes.Game.Mechanics.Items.Config.StaticItemModel model)
        {
            this.items[model.<StaticItemType>k__BackingField] = model;
            model = this.cell;
            if((model & 1) == 0)
            {
                goto label_5;
            }
            
            if(this.aboveItems != null)
            {
                goto label_6;
            }
            
            throw new NullReferenceException();
            label_5:
            label_6:
            this.belowItems.Add(item:  model);
        }
        public void ClearStaticItem(Royal.Scenes.Game.Mechanics.Board.Cell.StaticItemType itemType)
        {
            Royal.Scenes.Game.Mechanics.Items.Config.StaticItemModel val_2 = this.items[itemType];
            if(val_2 == null)
            {
                    return;
            }
            
            mem2[0] = 0;
            val_2 = 0;
            if((val_2 & 1) == 0)
            {
                goto label_4;
            }
            
            if(this.aboveItems != null)
            {
                goto label_5;
            }
            
            throw new NullReferenceException();
            label_4:
            label_5:
            bool val_1 = this.belowItems.Remove(item:  val_2);
        }
        private void ExplodeStaticItem(Royal.Scenes.Game.Mechanics.Board.Cell.StaticItemType itemType, Royal.Scenes.Game.Mechanics.Explode.ExplodeData explodeData)
        {
            Royal.Scenes.Game.Mechanics.Items.Config.StaticItemModel val_1 = this.items[itemType];
            if((1152921523929561072 & 1) != 0)
            {
                    if(val_1 == null)
            {
                    return;
            }
            
                return;
            }
            
            if(val_1 == null)
            {
                    return;
            }
        
        }
        public void CreateViews()
        {
            Royal.Scenes.Game.Mechanics.Items.Config.StaticItemModel[] val_2 = this.items;
            var val_3 = 0;
            do
            {
                if(val_3 >= (this.items.Length << ))
            {
                    return;
            }
            
                Royal.Scenes.Game.Mechanics.Items.Config.StaticItemModel val_2 = val_2[val_3];
                var val_1 = (val_2 == 0) ? 0 : (val_2);
                if(val_2 != null)
            {
                    val_2 = this.items;
            }
            
                val_3 = val_3 + 1;
            }
            while(val_2 != null);
            
            throw new NullReferenceException();
        }
        public void Reset()
        {
            Royal.Scenes.Game.Mechanics.Items.Config.StaticItemModel[] val_2 = this.items;
            var val_3 = 0;
            label_7:
            if(val_3 >= (this.items.Length << ))
            {
                goto label_2;
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.StaticItemModel val_2 = val_2[val_3];
            if(val_2 != null)
            {
                    if(val_2 != null)
            {
                    (val_2 == 0) ? 0 : (val_2).RecycleSelf();
            }
            
                val_2 = 0;
                val_2 = this.items;
            }
            
            val_3 = val_3 + 1;
            if(val_2 != null)
            {
                goto label_7;
            }
            
            throw new NullReferenceException();
            label_2:
            this.aboveItems.Clear();
            this.belowItems.Clear();
        }
    
    }

}
