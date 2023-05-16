using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.Strategy
{
    public class DefaultLightballStrategy : LightballStrategy
    {
        // Fields
        private const float TriggerDelay = 0.5;
        private bool isUserAction;
        
        // Methods
        public override void Start(Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.LightballItemModel lightballItem, Royal.Scenes.Game.Mechanics.Items.Config.ItemModel otherItem, Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            System.Collections.IEnumerator val_14;
            var val_15;
            Royal.Scenes.Game.Mechanics.Matches.MatchType val_16;
            Royal.Scenes.Game.Mechanics.Matches.MatchType val_17;
            Royal.Scenes.Game.Mechanics.Items.Config.ItemType val_18;
            val_14 = 1152921520136089984;
            val_15 = this;
            this.Init(lightballItem:  lightballItem);
            if(otherItem != null)
            {
                    val_16 = otherItem.<MatchType>k__BackingField;
            }
            else
            {
                    val_16 = 0;
            }
            
            if((-1650622112) != 2)
            {
                goto label_3;
            }
            
            this.isUserAction = true;
            goto label_5;
            label_3:
            this.isUserAction = ((-1650622112) == 3) ? 1 : 0;
            if((-1650622112) == 3)
            {
                goto label_5;
            }
            
            this.CompleteMoveByType(moveType:  6);
            val_14 = this.SelectMatchTypeAndStartAfterDelay(delay:  0.5f, otherMatchType:  val_16, isTap:  false);
            val_17 = 0;
            UnityEngine.Coroutine val_3 = Royal.Scenes.Game.Context.GameContext.ManualStartCoroutine(iEnumerator:  val_14);
            if(otherItem != null)
            {
                goto label_9;
            }
            
            goto label_12;
            label_5:
            val_17 = val_16;
            if((this.SelectMatchTypeAndStart(otherMatchType:  val_17, isTap:  ((-1650622112) == 3) ? 1 : 0)) == false)
            {
                goto label_11;
            }
            
            if(otherItem == null)
            {
                goto label_12;
            }
            
            label_9:
            val_18 = otherItem;
            goto label_13;
            label_11:
            val_15 = ???;
            val_14 = ???;
            goto typeof(Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.Strategy.DefaultLightballStrategy).__il2cppRuntimeField_180;
            label_12:
            val_18 = 0;
            label_13:
            val_15.StartShakingLightball(otherItem:  val_18);
            val_15 + 104 + 32.CurrentCell.FreezeFall();
            val_15 + 24.DisableTouch();
        }
        private System.Collections.IEnumerator SelectMatchTypeAndStartAfterDelay(float delay, Royal.Scenes.Game.Mechanics.Matches.MatchType otherMatchType, bool isTap)
        {
            .<>4__this = this;
            .delay = delay;
            .otherMatchType = otherMatchType;
            .isTap = isTap;
            return (System.Collections.IEnumerator)new DefaultLightballStrategy.<SelectMatchTypeAndStartAfterDelay>d__3(<>1__state:  0);
        }
        private bool SelectMatchTypeAndStart(Royal.Scenes.Game.Mechanics.Matches.MatchType otherMatchType, bool isTap)
        {
            Royal.Scenes.Game.Mechanics.Matches.MatchType val_2;
            var val_3;
            val_2 = otherMatchType;
            if(val_2 == 0)
            {
                goto label_1;
            }
            
            label_4:
            if(this != null)
            {
                goto label_2;
            }
            
            if(val_2 != 0)
            {
                goto label_4;
            }
            
            label_1:
            val_2 = this.FindMostCommonItem();
            label_2:
            mem[1152921520136336376] = val_2;
            this.FindItemsByType(match:  val_2);
            if(true != 0)
            {
                    this.ShuffleList<Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemModel>(list:  val_2);
                this.StartSendingRays();
            }
            else
            {
                    if(isTap != false)
            {
                    val_3 = 0;
                return (bool)val_3;
            }
            
            }
            
            val_3 = 1;
            return (bool)val_3;
        }
        public override void SingleRayReached(Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballItemRay lightballRay, Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemModel itemModel)
        {
            Royal.Scenes.Game.Mechanics.Items.Config.ItemType val_17;
            var val_18;
            var val_19;
            val_17 = itemModel;
            val_19 = val_17;
            if(val_17 != null)
            {
                    val_18 = null;
            }
            
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_1 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetLightballRayItemSorting();
            UnityEngine.Vector3 val_4 = 1152921505097580544.transform.position;
            lightballRay.CreateItemBg(itemType:  val_17, position:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, parent:  val_1.sortEverything & 4294967295);
            lightballRay.ShakeItem(trans:  val_17);
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_5 = val_17.CurrentCell;
            if(val_5 == null)
            {
                    return;
            }
            
            if(val_5 == null)
            {
                    return;
            }
            
            if((val_5.GetStaticItem(itemType:  4)) == null)
            {
                    return;
            }
            
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_7 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetLightballRayItemSorting();
            val_7.sortEverything = val_7.sortEverything & 4294967295;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_8 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_7.layer, order = val_7.order, sortEverything = val_7.sortEverything}, offset:  100);
            val_17 = ???;
            val_19 = ???;
            bool val_9 = val_8.sortEverything & 4294967295;
            goto typeof(Royal.Scenes.Game.Mechanics.Items.Config.StaticItemModel).__il2cppRuntimeField_1B0;
        }
        protected override void AddMatchItemToList(Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemModel itemModel)
        {
            11285.Add(item:  itemModel);
            itemModel.Reserve();
        }
        protected override void StoppedLookingForNewItems()
        {
        
        }
        protected override void AllRaysComplete()
        {
            UnityEngine.Coroutine val_2 = Royal.Scenes.Game.Context.GameContext.ManualStartCoroutine(iEnumerator:  this.CompleteDelayed());
        }
        private System.Collections.IEnumerator CompleteDelayed()
        {
            .<>4__this = this;
            return (System.Collections.IEnumerator)new DefaultLightballStrategy.<CompleteDelayed>d__9(<>1__state:  0);
        }
        private void ExplodeParticles(Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemModel item)
        {
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballEffectedItemExplodeParticles val_1 = 11288.Spawn<Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballEffectedItemExplodeParticles>(poolId:  26, activate:  true);
            val_1.Play(matchType:  26);
            val_1.transform.position = new UnityEngine.Vector3();
        }
        private void ExplodeTouching(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            val_4 = 1152921520137285312;
            val_5 = 0;
            val_6 = 0;
            goto label_1;
            label_13:
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_1 = 0.Get(type:  Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors.TouchingNeighborTypes + 32);
            if(val_1 != null)
            {
                    (val_1 == 0) ? (val_6) : (val_1).ExplodeCurrentItemByNearMatch(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id});
            }
            
            val_5 = 1;
            label_1:
            val_7 = null;
            val_7 = null;
            if(val_5 < Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors.TouchingNeighborTypes.Length)
            {
                goto label_13;
            }
        
        }
        public DefaultLightballStrategy()
        {
        
        }
    
    }

}
