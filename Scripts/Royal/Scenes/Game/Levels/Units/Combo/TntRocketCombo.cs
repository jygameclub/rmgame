using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.Combo
{
    public class TntRocketCombo : ICombo
    {
        // Fields
        private readonly Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory;
        private readonly Royal.Scenes.Game.Levels.Units.CellGridManager gridManager;
        private readonly Royal.Scenes.Game.Context.Units.GameTouchListener touchListener;
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.TntItemModel tnt;
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.RocketItemModel rocket;
        private Royal.Scenes.Game.Mechanics.Board.Cell.CellModel toCell;
        private Royal.Scenes.Game.Mechanics.Board.Cell.CellModel fromCell;
        private Royal.Scenes.Game.Levels.Units.Combo.SwipeType swipeType;
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemModel fromItem;
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemModel toItem;
        private readonly UnityEngine.AnimationCurve rotateAnimationEasing;
        private bool isFromAtFront;
        private Royal.Scenes.Game.Levels.Units.Combo.SwipeType fromRotationType;
        
        // Properties
        public Royal.Scenes.Game.Levels.Units.Combo.ComboType ComboType { get; }
        
        // Methods
        public Royal.Scenes.Game.Levels.Units.Combo.ComboType get_ComboType()
        {
            return 6;
        }
        public TntRocketCombo(Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory, Royal.Scenes.Game.Context.Units.GameTouchListener touchListener, Royal.Scenes.Game.Levels.Units.CellGridManager gridManager)
        {
            val_1 = new System.Object();
            this.itemFactory = itemFactory;
            this.gridManager = gridManager;
            this.touchListener = val_1;
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntItemAssets val_2 = itemFactory.assetsLibrary.Load<Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntItemAssets>();
            this.rotateAnimationEasing = val_2.rocketTntRotationEasing;
        }
        public void Prepare(Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemModel to, Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemModel from)
        {
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemModel val_9;
            this.fromItem = from;
            this.toItem = to;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_1 = 37972.CurrentCell;
            this.toCell = val_1;
            this.fromCell = val_1.CurrentCell;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_3 = this.fromItem.CurrentCell;
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemModel val_8 = this.toItem;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_4 = val_8.CurrentCell;
            if(from == val_8)
            {
                    val_8 = val_8 >> 32;
                var val_6 = ((from >> 32) < val_8) ? 1 : 0;
            }
            
            this.swipeType = (from >= val_8) ? (2 + 1) : 2;
            val_9 = this.toItem;
            if(this.toItem != 2)
            {
                goto label_12;
            }
            
            this.rocket = val_9;
            val_9 = this.fromItem;
            this.tnt = val_9;
            if(val_9 != null)
            {
                goto label_19;
            }
            
            label_12:
            this.tnt = val_9;
            this.rocket = this.fromItem;
            label_19:
            this.fromItem.ClearFromAllRegisteredCells();
            this.fromItem.ClearFromAllRegisteredCells();
        }
        public void Explode(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14).StartSpecialOperation();
            UnityEngine.Coroutine val_3 = Royal.Scenes.Game.Context.GameContext.ManualStartCoroutine(iEnumerator:  this.AnimateWithTime());
            Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.Sfx.GameSfxManager>(contextId:  22).PlaySfx(type:  236, offset:  0.04f);
        }
        private void AnimationCompleted()
        {
            int val_2;
            int val_3;
            int val_5;
            int val_6;
            int val_8;
            int val_9;
            this.touchListener.EnableTouch();
            Royal.Scenes.Game.Mechanics.Explode.ExplodeData val_1 = Royal.Scenes.Game.Mechanics.Explode.Exploder.Next(trigger:  12);
            Royal.Scenes.Game.Mechanics.Explode.ExplodeData val_4 = Royal.Scenes.Game.Mechanics.Explode.Exploder.Next(trigger:  6);
            Royal.Scenes.Game.Mechanics.Explode.ExplodeData val_7 = Royal.Scenes.Game.Mechanics.Explode.Exploder.Next(trigger:  6);
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_11 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  this.toCell.point - 1, y:  0);
            this.CreateAndExplodeAt(id:  20, point:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_11.x, y = val_11.x}, comboData:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_3, y = val_3}, trigger = val_3, id = val_2}, presetData:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_9, y = val_9}, trigger = val_9, id = val_8});
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_12 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  20, y:  val_11.x);
            this.CreateAndExplodeAt(id:  20, point:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_12.x, y = val_12.x}, comboData:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_3, y = val_3}, trigger = val_3, id = val_2, matchType = val_12.x}, presetData:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_9, y = val_9}, trigger = val_9, id = val_8});
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_13 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  this.toCell.point, y:  val_12.x);
            this.CreateAndExplodeAt(id:  20, point:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_13.x, y = val_13.x}, comboData:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_3, y = val_3}, trigger = val_3, id = val_2, matchType = val_13.x}, presetData:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_9, y = val_9}, trigger = val_9, id = val_8});
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_14 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  this.toCell.point, y:  val_13.x);
            this.CreateAndExplodeAt(id:  30, point:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_14.x, y = val_14.x}, comboData:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_3, y = val_3}, trigger = val_3, id = val_2, matchType = val_14.x}, presetData:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_6, y = val_6}, trigger = val_6, id = val_5});
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_16 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  this.toCell.point, y:  val_5 - 1);
            this.CreateAndExplodeAt(id:  30, point:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_16.x, y = val_16.x}, comboData:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_3, y = val_3}, trigger = val_3, id = val_2, matchType = val_16.x}, presetData:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_6, y = val_6}, trigger = val_6, id = val_5});
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_18 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  this.toCell.point, y:  val_5 + 1);
            this.CreateAndExplodeAt(id:  30, point:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_18.x, y = val_18.x}, comboData:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_3, y = val_3}, trigger = val_3, id = val_2, matchType = val_18.x}, presetData:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_6, y = val_6}, trigger = val_6, id = val_5});
            Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14).FinishSpecialOperation();
            this.Clear();
        }
        private void CreateAndExplodeAt(Royal.Scenes.Game.Utils.LevelParser.TiledId id, Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint point, Royal.Scenes.Game.Mechanics.Explode.ExplodeData comboData, Royal.Scenes.Game.Mechanics.Explode.ExplodeData presetData)
        {
            presetData.point.x = point.x;
            presetData.point.y = point.y;
            comboData.point.x = point.x;
            comboData.point.y = point.y;
            this.itemFactory.itemCreator.CreateItemAt(tiledId:  id, position:  new UnityEngine.Vector3()).ExplodeWithPresetData(trigger:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = comboData.point.x, y = point.y}, id = comboData.id}, presetData:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = presetData.point.x, y = point.y}, id = presetData.id});
        }
        private void Clear()
        {
            this.tnt.<ItemView>k__BackingField.Recycle();
            this.rocket.<ItemView>k__BackingField.Recycle();
            this.tnt = 0;
            this.rocket = 0;
            mem[1152921524120181608] = 0;
        }
        private System.Collections.IEnumerator AnimateWithTime()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new TntRocketCombo.<AnimateWithTime>d__21();
        }
        private void ArrangeSorting()
        {
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_3 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetPropellerFlyingSorting(isSpecialCombo:  true);
            bool val_4 = val_3.sortEverything & 4294967295;
            this.fromItem.GetSpecialItemView().UpdateSortingForAnimation(sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_3.layer, order = val_3.order, sortEverything = val_4}, allowOtherSortingUpdates:  false);
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_6 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_3.layer, order = val_3.order, sortEverything = val_4}, offset:  (this.isFromAtFront == true) ? (-10) : 10);
            this.toItem.GetSpecialItemView().UpdateSortingForAnimation(sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_6.layer, order = val_6.order, sortEverything = val_6.sortEverything & 4294967295}, allowOtherSortingUpdates:  false);
        }
    
    }

}
