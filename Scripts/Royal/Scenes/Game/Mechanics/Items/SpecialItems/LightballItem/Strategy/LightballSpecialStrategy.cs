using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.Strategy
{
    public abstract class LightballSpecialStrategy : LightballStrategy
    {
        // Fields
        protected readonly System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemModel> replacedItems;
        protected UnityEngine.Coroutine lightballShakeRoutine;
        protected Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballItemBg lightballBg;
        protected Royal.Scenes.Game.Mechanics.Board.Cell.CellModel lightballCell;
        private readonly System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemModel> nonConvertedMatchItems;
        
        // Properties
        protected virtual float ItemExplodeDelay { get; }
        protected virtual float ItemExplodeStartDelay { get; }
        
        // Methods
        protected virtual float get_ItemExplodeDelay()
        {
            return 0.07f;
        }
        protected virtual float get_ItemExplodeStartDelay()
        {
            return 0f;
        }
        public override void Start(Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.LightballItemModel lightballItem, Royal.Scenes.Game.Mechanics.Items.Config.ItemModel otherItem, Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            Royal.Scenes.Game.Mechanics.Items.Config.ItemType val_3;
            this.replacedItems.Clear();
            this.nonConvertedMatchItems.Clear();
            this.Init(lightballItem:  lightballItem);
            Royal.Scenes.Game.Mechanics.Matches.MatchType val_1 = this.FindMostCommonItem();
            mem[1152921520141721560] = val_1;
            this.FindItemsByType(match:  val_1);
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_2 = CurrentCell;
            val_2.FreezeFall();
            val_2.DisableTouch();
            val_2.ShuffleList<Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemModel>(list:  0);
            if(otherItem != null)
            {
                    val_3 = otherItem;
            }
            else
            {
                    val_3 = 0;
            }
            
            this.StartShakingLightball(otherItem:  val_3);
            this.StartSendingRays();
        }
        protected override void Reset()
        {
            this.Reset();
            this.replacedItems.Clear();
            this.nonConvertedMatchItems.Clear();
        }
        protected override void AddMatchItemToList(Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemModel itemModel)
        {
            22338.Add(item:  itemModel);
            itemModel.Reserve();
        }
        protected override void AllRaysComplete()
        {
            bool val_3 = true;
            var val_4 = 0;
            label_5:
            if(val_4 >= val_3)
            {
                goto label_2;
            }
            
            if(val_3 <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_3 = val_3 + 0;
            (true + 0) + 32.UnReserve();
            val_4 = val_4 + 1;
            if(this.nonConvertedMatchItems != null)
            {
                goto label_5;
            }
            
            throw new NullReferenceException();
            label_2:
            UnityEngine.Coroutine val_2 = Royal.Scenes.Game.Context.GameContext.ManualStartCoroutine(iEnumerator:  this.ExplodeItems());
        }
        protected override void StoppedLookingForNewItems()
        {
            this.RemoveLightball();
            goto typeof(Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.Strategy.LightballSpecialStrategy).__il2cppRuntimeField_260;
        }
        private void RemoveLightball()
        {
            this.lightballCell = this.RemoveLightballFromCell();
            this.Show();
            bool val_2 = this.lightballCell.Mediator.SetCurrentItem(item:  this);
            bool val_3 = this.lightballCell.Mediator.SetTargetItem(item:  this);
            this.replacedItems.Add(item:  this);
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_4 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetLightballRayItemSorting();
            bool val_5 = val_4.sortEverything & 4294967295;
            this.add_OnExplodeEvent(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.Strategy.LightballSpecialStrategy::LightballReplacedItemExploded()));
            SpecialItemCreated(createdItem:  this, position:  new UnityEngine.Vector3(), animationDelayInFrames:  10);
            if(this == 0)
            {
                    return;
            }
            
            mem[1152921520142406424] = 0;
        }
        protected Royal.Scenes.Game.Mechanics.Board.Cell.CellModel RemoveAnItemFromCell(Royal.Scenes.Game.Mechanics.Items.Config.ItemModel itemModel)
        {
            itemModel.itemMediator.ClearFromAllRegisteredCells();
            return (Royal.Scenes.Game.Mechanics.Board.Cell.CellModel)itemModel.CurrentCell;
        }
        private Royal.Scenes.Game.Mechanics.Board.Cell.CellModel RemoveLightballFromCell()
        {
            X8.ExplodeSelf();
            return (Royal.Scenes.Game.Mechanics.Board.Cell.CellModel)this.CurrentCell;
        }
        protected void PutItemToCell(Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemModel createdItem, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, System.Action onExplode)
        {
            bool val_2 = 22343.SetCurrentItem(item:  createdItem).SetTargetItem(item:  createdItem);
            this.replacedItems.Add(item:  createdItem);
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_3 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetLightballRayItemSorting();
            bool val_4 = val_3.sortEverything & 4294967295;
            createdItem.add_OnExplodeEvent(value:  onExplode);
        }
        protected abstract Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemModel GetReplacedItemForLightball(); // 0
        protected abstract void CreateBgForReplacedItemForLightball(); // 0
        protected void LightballReplacedItemExploded()
        {
            if(this.lightballShakeRoutine != null)
            {
                    Royal.Scenes.Game.Context.GameContext.ManualStopCoroutine(coroutine:  this.lightballShakeRoutine);
                this.lightballShakeRoutine = 0;
            }
            
            bool val_1 = UnityEngine.Object.op_Inequality(x:  this.lightballBg, y:  0);
            if(val_1 != false)
            {
                    val_1.Recycle<Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballItemBg>(go:  this.lightballBg);
                this.lightballBg = 0;
            }
            
            this.lightballCell.UnFreezeFall();
        }
        private System.Collections.IEnumerator ExplodeItems()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new LightballSpecialStrategy.<ExplodeItems>d__21();
        }
        protected void ExplodeChainAndResetMatchItem(Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemModel itemModel)
        {
            int val_3;
            int val_4;
            Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemModel val_9 = itemModel;
            this.nonConvertedMatchItems.Add(item:  val_9 = itemModel);
            Royal.Scenes.Game.Mechanics.Explode.ExplodeData val_2 = Royal.Scenes.Game.Mechanics.Explode.Exploder.Next(trigger:  15);
            bool val_5 = ExplodeTopMostAboveItem(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_4, y = val_4}, trigger = val_4, id = val_3});
            val_9.InvokeExplodeEvent();
            if((itemModel.<ItemView>k__BackingField) == 0)
            {
                    return;
            }
            
            val_9 = itemModel.<ItemView>k__BackingField;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_7 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetItemSorting(row:  val_9.CurrentCell, isReverseSort:  false);
            bool val_8 = val_7.sortEverything & 4294967295;
        }
        protected LightballSpecialStrategy()
        {
            this.replacedItems = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemModel>();
            this.nonConvertedMatchItems = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemModel>();
        }
    
    }

}
