using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.Touch
{
    public class SwapAction
    {
        // Fields
        public const float FrogSwapDuration = 0.25;
        private const float Duration = 0.135;
        private const float ImpossibleDuration = 0.075;
        public bool isRunning;
        private System.Action OnSwapAnimationStart;
        private System.Action<Royal.Scenes.Game.Levels.Units.Touch.MoveType> OnSwapAnimationEnd;
        private readonly Royal.Scenes.Game.Mechanics.Matches.MatchManager matchManager;
        private readonly Royal.Scenes.Game.Levels.Units.Combo.ComboManager comboManager;
        private readonly Royal.Scenes.Game.Levels.Units.Touch.LevelTouchManager levelTouchManager;
        internal readonly Royal.Scenes.Game.Levels.Units.Sfx.GameSfxManager sfxManager;
        private readonly Royal.Scenes.Game.Levels.Units.MoveManager moveManager;
        private readonly Royal.Scenes.Game.Levels.Units.CellGridManager cellGridManager;
        internal Royal.Scenes.Game.Mechanics.Board.Cell.CellModel fromCell;
        internal Royal.Scenes.Game.Mechanics.Board.Cell.CellModel toCell;
        private Royal.Scenes.Game.Mechanics.Matches.MatchGroup fromCellMatchGroup;
        private Royal.Scenes.Game.Mechanics.Matches.MatchGroup toCellMatchGroup;
        
        // Methods
        public void add_OnSwapAnimationStart(System.Action value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnSwapAnimationStart, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnSwapAnimationStart != 1152921523977907240);
            
            return;
            label_2:
        }
        public void remove_OnSwapAnimationStart(System.Action value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnSwapAnimationStart, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnSwapAnimationStart != 1152921523978043816);
            
            return;
            label_2:
        }
        public void add_OnSwapAnimationEnd(System.Action<Royal.Scenes.Game.Levels.Units.Touch.MoveType> value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnSwapAnimationEnd, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnSwapAnimationEnd != 1152921523978180400);
            
            return;
            label_2:
        }
        public void remove_OnSwapAnimationEnd(System.Action<Royal.Scenes.Game.Levels.Units.Touch.MoveType> value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnSwapAnimationEnd, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnSwapAnimationEnd != 1152921523978316976);
            
            return;
            label_2:
        }
        public SwapAction(Royal.Scenes.Game.Mechanics.Matches.MatchManager matchManager, Royal.Scenes.Game.Levels.Units.Combo.ComboManager comboManager, Royal.Scenes.Game.Levels.Units.MoveManager moveManager, Royal.Scenes.Game.Levels.Units.Touch.LevelTouchManager levelTouchManager)
        {
            val_1 = new System.Object();
            this.matchManager = matchManager;
            this.comboManager = val_1;
            this.levelTouchManager = levelTouchManager;
            this.moveManager = moveManager;
            this.sfxManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.Sfx.GameSfxManager>(contextId:  22);
            this.cellGridManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.CellGridManager>(contextId:  2);
        }
        public bool StartSwapAnimation(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel from, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel to)
        {
            var val_2;
            this.fromCell = from;
            this.toCell = to;
            if((this.ShouldPlaySwapAnimation(ignoreMatchRequirement:  false)) != false)
            {
                    this.PlayValidSwapAnimation();
                val_2 = 1;
                return (bool)val_2;
            }
            
            this.PlayWrongSwapAnimation();
            val_2 = 0;
            return (bool)val_2;
        }
        public void Clear()
        {
            var val_2;
            var val_3;
            this.fromCell = 0;
            this.toCell = 0;
            val_2 = null;
            val_3 = 0;
            val_2 = null;
            val_2 = null;
        }
        internal bool ShouldPlaySwapAnimation(bool ignoreMatchRequirement = False)
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_12;
            var val_13;
            val_12 = this.toCell;
            if((this.toCell.Mediator.current.<Item>k__BackingField) != null)
            {
                    Royal.Scenes.Game.Levels.Units.Touch.SwapAction.SetAllItems(cell:  this.fromCell, item:  this.toCell.Mediator.current.<Item>k__BackingField);
                val_12 = this.toCell;
            }
            
            Royal.Scenes.Game.Levels.Units.Touch.SwapAction.SetAllItems(cell:  val_12, item:  this.fromCell.Mediator.current.<Item>k__BackingField);
            val_13 = this.matchManager.FindExtensiveMatchesInArea(center:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = this.toCell.point, y = this.toCell.point}, radius:  3);
            if(this.toCell < 1)
            {
                goto label_11;
            }
            
            var val_12 = 0;
            var val_13 = 32;
            label_24:
            if(val_12 >= this.toCell)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(this.toCell.CurrentItem == null)
            {
                goto label_17;
            }
            
            if(( & 1) == 0)
            {
                goto label_17;
            }
            
            mem[1152921523978970136] = this.toCell;
            goto label_23;
            label_17:
            if(this.fromCell.CurrentItem != null)
            {
                    if(( & 1) != 0)
            {
                    mem[1152921523978969984] = this.fromCell;
            }
            
            }
            
            label_23:
            val_12 = val_12 + 1;
            val_13 = val_13 + 152;
            if(val_12 < this.fromCell)
            {
                goto label_24;
            }
            
            label_11:
            if(this.fromCell.HasSpecialItem() != false)
            {
                    val_13 = this.fromCell.CurrentItem;
                Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_6 = this.toCell.CurrentItem;
                if((val_13 & 1) != 0)
            {
                    return true;
            }
            
            }
            
            if(this.toCell.HasSpecialItem() != false)
            {
                    val_13 = this.toCell.CurrentItem;
                Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_10 = this.fromCell.CurrentItem;
                if((val_13 & 1) != 0)
            {
                    return true;
            }
            
            }
            
            if((this.levelTouchManager.<SwapHackEnabled>k__BackingField) != true)
            {
                    if((this.levelTouchManager.<SwapHackEnabled>k__BackingField) == false)
            {
                goto label_47;
            }
            
            }
            
            return true;
            label_47:
            if((this.levelTouchManager.<SwapHackEnabled>k__BackingField) == true)
            {
                    return true;
            }
            
            if(ignoreMatchRequirement == true)
            {
                    return true;
            }
            
            Royal.Scenes.Game.Levels.Units.Touch.SwapAction.SetAllItems(cell:  this.fromCell, item:  this.fromCell.Mediator.current.<Item>k__BackingField);
            if((this.toCell.Mediator.current.<Item>k__BackingField) == null)
            {
                    return true;
            }
            
            Royal.Scenes.Game.Levels.Units.Touch.SwapAction.SetAllItems(cell:  this.toCell, item:  this.toCell.Mediator.current.<Item>k__BackingField);
            return true;
        }
        private void PlayValidSwapAnimation()
        {
            int val_4;
            int val_5;
            Royal.Infrastructure.Utils.Animation.Tween.MTween<T> val_35;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_36;
            SwapAction.<>c__DisplayClass24_0 val_1 = new SwapAction.<>c__DisplayClass24_0();
            .<>4__this = this;
            this.sfxManager.PlaySfx(type:  186, offset:  0.04f);
            .fromItem = this.toCell.Mediator.current.<Item>k__BackingField;
            .toItem = this.fromCell.Mediator.current.<Item>k__BackingField;
            if((Royal.Scenes.Game.Levels.Units.Combo.ComboManager.IsCombo(to:  this.fromCell.Mediator.current.<Item>k__BackingField, from:  this.toCell.Mediator.current.<Item>k__BackingField, comboType:  6)) != false)
            {
                    Royal.Scenes.Game.Mechanics.Explode.ExplodeData val_3 = Royal.Scenes.Game.Mechanics.Explode.Exploder.Next(trigger:  2);
                this.comboManager.Explode(toItem:  (SwapAction.<>c__DisplayClass24_0)[1152921523979525344].toItem, fromItem:  (SwapAction.<>c__DisplayClass24_0)[1152921523979525344].fromItem, data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_5, y = val_5}, trigger = val_5, id = val_4});
                this.moveManager.CompleteMoveByType(moveType:  12);
                return;
            }
            
            if((Royal.Scenes.Game.Levels.Units.Combo.ComboManager.IsCombo(to:  (SwapAction.<>c__DisplayClass24_0)[1152921523979525344].toItem, from:  (SwapAction.<>c__DisplayClass24_0)[1152921523979525344].fromItem, comboType:  10)) != true)
            {
                    if((Royal.Scenes.Game.Levels.Units.Combo.ComboManager.IsCombo(to:  (SwapAction.<>c__DisplayClass24_0)[1152921523979525344].toItem, from:  (SwapAction.<>c__DisplayClass24_0)[1152921523979525344].fromItem, comboType:  9)) != true)
            {
                    if((Royal.Scenes.Game.Levels.Units.Combo.ComboManager.IsCombo(to:  (SwapAction.<>c__DisplayClass24_0)[1152921523979525344].toItem, from:  (SwapAction.<>c__DisplayClass24_0)[1152921523979525344].fromItem, comboType:  8)) == false)
            {
                goto label_21;
            }
            
            }
            
            }
            
            this.PlayPropellerComboSwapAnimation();
            return;
            label_21:
            this.isRunning = true;
            val_35 = this.fromCell.<CellView>k__BackingField.transform;
            .fromItemView = (SwapAction.<>c__DisplayClass24_0)[1152921523979525344].fromItem;
            val_36 = this.toCell.point;
            this.fromCell.SwapStarted();
            this.toCell.SwapStarted();
            if(this.OnSwapAnimationStart != null)
            {
                    val_36 = 0;
                this.OnSwapAnimationStart.Invoke();
            }
            
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_12 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSwapStartSorting();
            .isCombo = false;
            if(((SwapAction.<>c__DisplayClass24_0)[1152921523979525344].toItem) != null)
            {
                    .CS$<>8__locals1 = val_1;
                .toItemView = (SwapAction.<>c__DisplayClass24_0)[1152921523979525344].toItem;
                Royal.Scenes.Game.Mechanics.Sortings.SortingData val_15 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_12.layer, order = val_12.order, sortEverything = val_12.sortEverything & 4294967295}, offset:  99);
                bool val_16 = val_15.sortEverything & 4294967295;
                (SwapAction.<>c__DisplayClass24_1)[1152921523979672752].CS$<>8__locals1 = Royal.Scenes.Game.Levels.Units.Combo.ComboManager.IsAnyCombo(to:  (SwapAction.<>c__DisplayClass24_1)[1152921523979672752].CS$<>8__locals1.toItem, from:  (SwapAction.<>c__DisplayClass24_1)[1152921523979672752].CS$<>8__locals1.fromItem);
                if(((SwapAction.<>c__DisplayClass24_1)[1152921523979672752].CS$<>8__locals1.isCombo) != false)
            {
                    if((this.levelTouchManager.<SwapHackEnabled>k__BackingField) == false)
            {
                goto label_47;
            }
            
            }
            
                Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemSwapParticles val_20 = this.PlaySwapParticle(itemView:  (SwapAction.<>c__DisplayClass24_1)[1152921523979672752].toItemView, neighborType:  this.toCell.neighbors.GetNeighborType(otherCellPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = this.fromCell.point, y = this.fromCell.point}));
                UnityEngine.Vector3 val_22 = val_35.localPosition;
                val_35 = Royal.Infrastructure.Utils.Animation.Tween.MTweenShortcuts.MtLocalMove(transform:  (SwapAction.<>c__DisplayClass24_1)[1152921523979672752].toItemView.transform, endPosition:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, duration:  0.135f);
                Royal.Infrastructure.Utils.Animation.Tween.MTween<T> val_25 = Royal.Infrastructure.Utils.Animation.Tween.MTweenShortcuts.SetOnComplete<UnityEngine.Vector3>(tween:  val_35, onComplete:  new System.Action(object:  new SwapAction.<>c__DisplayClass24_1(), method:  System.Void SwapAction.<>c__DisplayClass24_1::<PlayValidSwapAnimation>b__1()));
                val_25.Start();
            }
            
            label_47:
            .swapMoveType = val_25.GetSwapMoveTypeFromItems(toItem:  (SwapAction.<>c__DisplayClass24_0)[1152921523979525344].toItem, fromItem:  (SwapAction.<>c__DisplayClass24_0)[1152921523979525344].fromItem);
            if(((SwapAction.<>c__DisplayClass24_0)[1152921523979525344].toItem) != null)
            {
                    if(((SwapAction.<>c__DisplayClass24_0)[1152921523979525344].fromItemView) != null)
            {
                goto label_55;
            }
            
            }
            
            label_55:
            bool val_27 = val_12.sortEverything & 4294967295;
            Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemSwapParticles val_28 = this.PlaySwapParticle(itemView:  (SwapAction.<>c__DisplayClass24_0)[1152921523979525344].fromItemView, neighborType:  this.fromCell.neighbors.GetNeighborType(otherCellPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_36, y = val_36}));
            UnityEngine.Vector3 val_30 = this.toCell.<CellView>k__BackingField.transform.localPosition;
            Royal.Infrastructure.Utils.Animation.Tween.MTweenShortcuts.SetOnComplete<UnityEngine.Vector3>(tween:  Royal.Infrastructure.Utils.Animation.Tween.MTweenShortcuts.MtLocalMove(transform:  (SwapAction.<>c__DisplayClass24_0)[1152921523979525344].fromItemView.transform, endPosition:  new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z}, duration:  0.135f), onComplete:  new System.Action(object:  val_1, method:  System.Void SwapAction.<>c__DisplayClass24_0::<PlayValidSwapAnimation>b__0())).Start();
        }
        private Royal.Scenes.Game.Levels.Units.Touch.MoveType GetSwapMoveTypeFromItems(Royal.Scenes.Game.Mechanics.Items.Config.ItemModel toItem, Royal.Scenes.Game.Mechanics.Items.Config.ItemModel fromItem)
        {
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_10;
            var val_11;
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_12;
            val_10 = fromItem;
            if((Royal.Scenes.Game.Levels.Units.Combo.ComboManager.IsAnyCombo(to:  toItem, from:  val_10)) != true)
            {
                    if(toItem != null)
            {
                    if(toItem == 5)
            {
                goto label_2;
            }
            
            }
            
                if(fromItem == 5)
            {
                    label_2:
                val_11 = 4;
                return (Royal.Scenes.Game.Levels.Units.Touch.MoveType)val_11;
            }
            
            }
            
            val_12 = fromItem;
            if((Royal.Scenes.Game.Levels.Units.Combo.ComboManager.IsAnyCombo(to:  toItem, from:  val_12)) != true)
            {
                    if(toItem != null)
            {
                    if(toItem == 2)
            {
                goto label_8;
            }
            
            }
            
                if(fromItem == 2)
            {
                    label_8:
                val_11 = 13;
                return (Royal.Scenes.Game.Levels.Units.Touch.MoveType)val_11;
            }
            
            }
            
            if((Royal.Scenes.Game.Levels.Units.Combo.ComboManager.IsCombo(to:  toItem, from:  fromItem, comboType:  1)) != false)
            {
                    val_11 = 10;
                return (Royal.Scenes.Game.Levels.Units.Touch.MoveType)val_11;
            }
            
            if((Royal.Scenes.Game.Levels.Units.Combo.ComboManager.IsCombo(to:  toItem, from:  fromItem, comboType:  5)) != false)
            {
                    val_11 = 14;
                return (Royal.Scenes.Game.Levels.Units.Touch.MoveType)val_11;
            }
            
            if((Royal.Scenes.Game.Levels.Units.Combo.ComboManager.IsCombo(to:  toItem, from:  fromItem, comboType:  7)) != false)
            {
                    val_11 = 11;
                return (Royal.Scenes.Game.Levels.Units.Touch.MoveType)val_11;
            }
            
            if((Royal.Scenes.Game.Levels.Units.Combo.ComboManager.IsCombo(to:  toItem, from:  fromItem, comboType:  3)) != false)
            {
                    val_11 = 8;
                return (Royal.Scenes.Game.Levels.Units.Touch.MoveType)val_11;
            }
            
            val_11 = 8;
            if((Royal.Scenes.Game.Levels.Units.Combo.ComboManager.IsCombo(to:  toItem, from:  fromItem, comboType:  4)) != false)
            {
                    return (Royal.Scenes.Game.Levels.Units.Touch.MoveType)val_11;
            }
            
            var val_9 = ((Royal.Scenes.Game.Levels.Units.Combo.ComboManager.IsCombo(to:  toItem, from:  fromItem, comboType:  2)) != true) ? (val_11) : (0 + 1);
            return (Royal.Scenes.Game.Levels.Units.Touch.MoveType)val_11;
        }
        private void PlayPropellerComboSwapAnimation()
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_15;
            Royal.Scenes.Game.Mechanics.Items.Config.ItemView val_16;
            .<>4__this = this;
            .fromItem = this.toCell.Mediator.current.<Item>k__BackingField;
            .toItem = this.fromCell.Mediator.current.<Item>k__BackingField;
            this.isRunning = true;
            .fromItemView = (SwapAction.<>c__DisplayClass26_0)[1152921523980176304].fromItem;
            val_15 = this.toCell.point;
            this.fromCell.SwapStarted();
            this.toCell.SwapStarted();
            if(this.OnSwapAnimationStart != null)
            {
                    val_15 = 0;
                this.OnSwapAnimationStart.Invoke();
            }
            
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_4 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSwapStartSorting();
            if(((SwapAction.<>c__DisplayClass26_0)[1152921523980176304].toItem) == null)
            {
                goto label_18;
            }
            
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_6 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_4.layer, order = val_4.order, sortEverything = val_4.sortEverything & 4294967295}, offset:  99);
            (SwapAction.<>c__DisplayClass26_0)[1152921523980176304].toItem.UpdateSortingForAnimation(sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_6.layer, order = val_6.order, sortEverything = val_6.sortEverything & 4294967295}, allowOtherSortingUpdates:  true);
            val_16 = (SwapAction.<>c__DisplayClass26_0)[1152921523980176304].fromItemView;
            if(((SwapAction.<>c__DisplayClass26_0)[1152921523980176304].toItem) == null)
            {
                goto label_23;
            }
            
            if(val_16 != null)
            {
                goto label_24;
            }
            
            label_18:
            val_16 = (SwapAction.<>c__DisplayClass26_0)[1152921523980176304].fromItemView;
            label_23:
            label_24:
            bool val_8 = val_4.sortEverything & 4294967295;
            Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemSwapParticles val_9 = this.PlaySwapParticle(itemView:  (SwapAction.<>c__DisplayClass26_0)[1152921523980176304].fromItemView, neighborType:  this.fromCell.neighbors.GetNeighborType(otherCellPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_15, y = val_15}));
            UnityEngine.Vector3 val_11 = this.toCell.<CellView>k__BackingField.transform.localPosition;
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_14 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  (SwapAction.<>c__DisplayClass26_0)[1152921523980176304].fromItemView.transform, endValue:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, duration:  0.135f, snapping:  false), action:  new DG.Tweening.TweenCallback(object:  new SwapAction.<>c__DisplayClass26_0(), method:  System.Void SwapAction.<>c__DisplayClass26_0::<PlayPropellerComboSwapAnimation>b__0()));
        }
        private void PlayWrongSwapAnimation()
        {
            Royal.Scenes.Game.Mechanics.Items.Config.ItemView val_22;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_23;
            SwapAction.<>c__DisplayClass27_0 val_1 = new SwapAction.<>c__DisplayClass27_0();
            .<>4__this = this;
            this.sfxManager.PlaySfx(type:  186, offset:  0.04f);
            this.isRunning = true;
            .fromItem = this.fromCell.Mediator.current.<Item>k__BackingField;
            .toItem = this.toCell.Mediator.current.<Item>k__BackingField;
            .fromItemView = (SwapAction.<>c__DisplayClass27_0)[1152921523980597552].fromItem;
            if(((SwapAction.<>c__DisplayClass27_0)[1152921523980597552].toItem) != null)
            {
                    val_22 = (SwapAction.<>c__DisplayClass27_0)[1152921523980597552].toItem;
            }
            else
            {
                    val_22 = 0;
            }
            
            .toItemView = val_22;
            UnityEngine.Vector3 val_4 = this.toCell.<CellView>k__BackingField.transform.localPosition;
            .toPosition = val_4;
            mem[1152921523980597652] = val_4.y;
            mem[1152921523980597656] = val_4.z;
            UnityEngine.Vector3 val_5 = this.fromCell.<CellView>k__BackingField.transform.localPosition;
            .fromPosition = val_5;
            mem[1152921523980597604] = val_5.y;
            mem[1152921523980597608] = val_5.z;
            val_23 = this.toCell.point;
            this.fromCell.SwapStarted();
            this.toCell.SwapStarted();
            if(this.OnSwapAnimationStart != null)
            {
                    val_23 = 0;
                this.OnSwapAnimationStart.Invoke();
            }
            
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_7 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSwapStartSorting();
            bool val_8 = val_7.sortEverything & 4294967295;
            .fromSwapParticles = this.PlaySwapParticle(itemView:  (SwapAction.<>c__DisplayClass27_0)[1152921523980597552].fromItemView, neighborType:  this.fromCell.neighbors.GetNeighborType(otherCellPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_23, y = val_23}));
            Royal.Infrastructure.Utils.Animation.Tween.MTweenShortcuts.SetOnComplete<UnityEngine.Vector3>(tween:  Royal.Infrastructure.Utils.Animation.Tween.MTweenShortcuts.MtLocalMove(transform:  (SwapAction.<>c__DisplayClass27_0)[1152921523980597552].fromItemView.transform, endPosition:  new UnityEngine.Vector3() {x = (SwapAction.<>c__DisplayClass27_0)[1152921523980597552].toPosition, y = val_5.y, z = val_5.z}, duration:  0.135f), onComplete:  new System.Action(object:  val_1, method:  System.Void SwapAction.<>c__DisplayClass27_0::<PlayWrongSwapAnimation>b__0())).Start();
            if(((SwapAction.<>c__DisplayClass27_0)[1152921523980597552].toItemView) == 0)
            {
                    return;
            }
            
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_16 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSwapStartSorting();
            .toSwapSorting = val_16;
            mem[1152921523980597632] = val_16.sortEverything;
            .toSwapParticles = this.PlaySwapParticle(itemView:  (SwapAction.<>c__DisplayClass27_0)[1152921523980597552].toItemView, neighborType:  this.toCell.neighbors.GetNeighborType(otherCellPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = this.fromCell.point, y = this.fromCell.point}));
            Royal.Infrastructure.Utils.Animation.Tween.MTweenShortcuts.SetOnComplete<UnityEngine.Vector3>(tween:  Royal.Infrastructure.Utils.Animation.Tween.MTweenShortcuts.MtLocalMove(transform:  (SwapAction.<>c__DisplayClass27_0)[1152921523980597552].toItemView.transform, endPosition:  new UnityEngine.Vector3() {x = (SwapAction.<>c__DisplayClass27_0)[1152921523980597552].fromPosition, y = val_5.y, z = val_5.z}, duration:  0.135f), onComplete:  new System.Action(object:  val_1, method:  System.Void SwapAction.<>c__DisplayClass27_0::<PlayWrongSwapAnimation>b__1())).Start();
        }
        private Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemSwapParticles PlaySwapParticle(Royal.Scenes.Game.Mechanics.Items.Config.ItemView itemView, int neighborType)
        {
            Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory val_1 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1);
            Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemSwapParticles val_2 = val_1.Spawn<Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemSwapParticles>(poolId:  3, activate:  true);
            val_2.Init(factory:  val_1, parent:  itemView.transform);
            val_2.UpdateSwapParticleSorting(swapParticle:  val_2, itemSortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = itemView, order = itemView, sortEverything = (typeof(Royal.Scenes.Game.Mechanics.Items.Config.ItemView).__il2cppRuntimeField_208 & 4294967295)});
            UnityEngine.Vector3 val_6 = itemView.transform.position;
            val_2.transform.position = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            val_2.Play(neighborType:  neighborType);
            return val_2;
        }
        private void UpdateSwapParticleSorting(Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemSwapParticles swapParticle, Royal.Scenes.Game.Mechanics.Sortings.SortingData itemSortingData)
        {
            itemSortingData.layer = (itemSortingData.layer >> 32) + 1;
            swapParticle.UpdateSorting(sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {sortEverything = false});
        }
        public void StartImpossibleSwapAnimation(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel from, Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint pointTo)
        {
            float val_35;
            float val_36;
            SwapAction.<>c__DisplayClass30_0 val_1 = new SwapAction.<>c__DisplayClass30_0();
            .<>4__this = this;
            this.sfxManager.PlaySfx(type:  137, offset:  0.04f);
            this.fromCell = from;
            this.isRunning = true;
            .fromItem = mem[-6917529027624257768];
            .fromItemView = (SwapAction.<>c__DisplayClass30_0)[1152921523981292976].fromItem;
            UnityEngine.Vector3 val_3 = this.fromCell.<CellView>k__BackingField.transform.localPosition;
            .fromPosition = val_3;
            mem[1152921523981293008] = val_3.y;
            mem[1152921523981293012] = val_3.z;
            UnityEngine.Vector3 val_5 = (SwapAction.<>c__DisplayClass30_0)[1152921523981292976].fromItem.transform.localScale;
            .fromScale = val_5;
            mem[1152921523981293068] = val_5.y;
            mem[1152921523981293072] = val_5.z;
            int val_6 = Royal.Infrastructure.Utils.Math.NumberExtensions.Compare(a:  this.fromCell.point, b:  pointTo.x);
            .toVector = 0;
            mem[1152921523981293024] = 0;
            mem[1152921523981293016] = (float)val_6;
            mem[1152921523981293020] = (float)Royal.Infrastructure.Utils.Math.NumberExtensions.Compare(a:  val_6, b:  pointTo.x >> 32);
            mem[1152921523981293024] = val_5.z;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_9 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSwapStartSorting();
            bool val_10 = val_9.sortEverything & 4294967295;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = (SwapAction.<>c__DisplayClass30_0)[1152921523981292976].toVector, y = V13.16B, z = V11.16B}, d:  0.12f);
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = (SwapAction.<>c__DisplayClass30_0)[1152921523981292976].fromPosition, y = V9.16B, z = V8.16B}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            .toPosition = val_12;
            mem[1152921523981292996] = val_12.y;
            mem[1152921523981293000] = val_12.z;
            Royal.Infrastructure.Utils.Animation.Tween.MTweenShortcuts.SetOnComplete<UnityEngine.Vector3>(tween:  Royal.Infrastructure.Utils.Animation.Tween.MTweenShortcuts.SetEase<UnityEngine.Vector3>(tween:  Royal.Infrastructure.Utils.Animation.Tween.MTweenShortcuts.MtLocalMove(transform:  (SwapAction.<>c__DisplayClass30_0)[1152921523981292976].fromItemView.transform, endPosition:  new UnityEngine.Vector3() {x = (SwapAction.<>c__DisplayClass30_0)[1152921523981292976].toPosition, y = val_12.y, z = val_12.z}, duration:  0.075f), easeType:  3), onComplete:  new System.Action(object:  val_1, method:  System.Void SwapAction.<>c__DisplayClass30_0::<StartImpossibleSwapAnimation>b__0())).Start();
            UnityEngine.Vector2 val_18 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = (SwapAction.<>c__DisplayClass30_0)[1152921523981292976].fromScale, y = V9.16B, z = (SwapAction.<>c__DisplayClass30_0)[1152921523981292976].fromPosition});
            UnityEngine.Vector2 val_19 = new UnityEngine.Vector2(x:  1.05f, y:  0.96f);
            UnityEngine.Vector2 val_20 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_18.x, y = val_18.y}, b:  new UnityEngine.Vector2() {x = val_19.x, y = val_19.y});
            val_35 = val_20.x;
            val_36 = val_20.y;
            UnityEngine.Vector2 val_21 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = (SwapAction.<>c__DisplayClass30_0)[1152921523981292976].fromScale, y = val_19.y, z = val_19.x});
            UnityEngine.Vector2 val_22 = new UnityEngine.Vector2(x:  0.95f, y:  1.04f);
            UnityEngine.Vector2 val_23 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_21.x, y = val_21.y}, b:  new UnityEngine.Vector2() {x = val_22.x, y = val_22.y});
            .toScale2 = val_23;
            mem[1152921523981293060] = val_23.y;
            if((Royal.Infrastructure.Utils.Math.NumberExtensions.Approximately(a:  System.Math.Abs((SwapAction.<>c__DisplayClass30_0)[1152921523981292976].toVector), b:  1f, precision:  0.001f)) != false)
            {
                    UnityEngine.Vector2 val_25 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                val_35 = val_25.x;
                val_36 = val_25.y;
                UnityEngine.Vector2 val_26 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                .toScale2 = val_26;
                mem[1152921523981293060] = val_26.y;
            }
            
            UnityEngine.Vector3 val_28 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_35, y = val_36});
            Royal.Infrastructure.Utils.Animation.Tween.MTweenShortcuts.SetOnComplete<UnityEngine.Vector3>(tween:  Royal.Infrastructure.Utils.Animation.Tween.MTweenShortcuts.SetEase<UnityEngine.Vector3>(tween:  Royal.Infrastructure.Utils.Animation.Tween.MTweenShortcuts.MtLocalScale(transform:  (SwapAction.<>c__DisplayClass30_0)[1152921523981292976].fromItemView.transform, endScale:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z}, duration:  0.075f), easeType:  3), onComplete:  new System.Action(object:  val_1, method:  System.Void SwapAction.<>c__DisplayClass30_0::<StartImpossibleSwapAnimation>b__1())).Start();
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_33 = this.cellGridManager.Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = pointTo.x, y = pointTo.y}];
            if(val_33 == null)
            {
                    return;
            }
            
            if(val_33 == null)
            {
                    return;
            }
            
            if(val_33.GetTopMostAboveItem() == null)
            {
                    return;
            }
        
        }
        internal void ExplodeMatchGroups(Royal.Scenes.Game.Mechanics.Items.Config.ItemModel toItem, Royal.Scenes.Game.Mechanics.Items.Config.ItemModel fromItem)
        {
            int val_2;
            bool val_3;
            Royal.Scenes.Game.Mechanics.Matches.MatchGroup val_7;
            object val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            val_8 = this;
            if(true == 0)
            {
                goto label_1;
            }
            
            val_7 = this.fromCellMatchGroup;
            if((fromItem != null) && (this.fromCellMatchGroup == 1))
            {
                    if(fromItem == 5)
            {
                goto label_7;
            }
            
            }
            
            Royal.Scenes.Game.Mechanics.Explode.ExplodeData val_1 = Royal.Scenes.Game.Mechanics.Explode.Exploder.Next(trigger:  2);
            if((this.matchManager.ExplodeMatchGroup(matchGroup:  new Royal.Scenes.Game.Mechanics.Matches.MatchGroup() {cell14 = new Royal.Scenes.Game.Mechanics.Matches.Cell14(), explosionCalculated = val_3, canExplode = val_3, exists = val_3}, data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = this.fromCell.point, y = this.fromCell.point}, trigger = val_3, id = val_2})) != true)
            {
                    val_9 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_9 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                val_9 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_9 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  5, log:  "Valid swap couldn\'t explode match group.", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            }
            
            label_7:
            val_10 = null;
            val_10 = null;
            label_1:
            if(Royal.Scenes.Game.Mechanics.Matches.MatchGroup.topItems == null)
            {
                    return;
            }
            
            val_7 = this.toCellMatchGroup;
            if((toItem != null) && (this.toCellMatchGroup == 1))
            {
                    if(toItem == 5)
            {
                goto label_25;
            }
            
            }
            
            Royal.Scenes.Game.Mechanics.Explode.ExplodeData val_5 = Royal.Scenes.Game.Mechanics.Explode.Exploder.Next(trigger:  2);
            if((this.matchManager.ExplodeMatchGroup(matchGroup:  new Royal.Scenes.Game.Mechanics.Matches.MatchGroup() {cell14 = new Royal.Scenes.Game.Mechanics.Matches.Cell14(), explosionCalculated = this.fromCell.point, canExplode = this.fromCell.point, exists = this.fromCell.point}, data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = this.toCell.point, y = this.toCell.point}, trigger = val_3, id = val_2})) != true)
            {
                    val_11 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_11 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                val_11 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_11 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  5, log:  "Valid swap couldn\'t explode match group.", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            }
            
            label_25:
            val_8 = 1152921505086132224;
            val_12 = null;
            val_12 = null;
        }
        private bool ShouldExplodeMatchGroup(Royal.Scenes.Game.Mechanics.Items.Config.ItemModel swappedItem, Royal.Scenes.Game.Mechanics.Matches.MatchGroup mGroup)
        {
            var val_2;
            if((swappedItem != null) && (swappedItem == 5))
            {
                    var val_1 = ((-2099871408) != 1) ? 1 : 0;
                return (bool)val_2;
            }
            
            val_2 = 1;
            return (bool)val_2;
        }
        private void ExplodeSpecialItems(Royal.Scenes.Game.Mechanics.Items.Config.ItemModel toItem, Royal.Scenes.Game.Mechanics.Items.Config.ItemModel fromItem)
        {
            int val_2;
            int val_3;
            var val_7;
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemModel val_8;
            var val_9;
            var val_10;
            Royal.Scenes.Game.Mechanics.Items.Config.ItemType val_11;
            if((this.levelTouchManager.<SwapHackEnabled>k__BackingField) == true)
            {
                    return;
            }
            
            Royal.Scenes.Game.Mechanics.Explode.ExplodeData val_1 = Royal.Scenes.Game.Mechanics.Explode.Exploder.Next(trigger:  2);
            val_7 = 0;
            if(fromItem == null)
            {
                
            }
            
            val_8 = 0;
            if(val_8 != 0)
            {
                    val_2 = val_2;
                val_3 = val_3;
                this.comboManager.Explode(toItem:  null, fromItem:  val_8, data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_3, y = val_3}, trigger = val_3, id = val_2});
                return;
            }
            
            val_2 = val_2;
            val_3 = val_3;
            val_9 = fromItem;
            val_10 = mem[(Royal.Scenes.Game.Mechanics.Items.Config.ItemModel.__il2cppRuntimeField_typeHierarchy + (Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemModel.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? toItem : 0];
            val_10 = ;
            val_11 = ;
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemCounts.IncrementItemUse(id:  val_11);
        }
        private bool HasMatchGroup()
        {
            if(W8 == 0)
            {
                    return (bool)(W8 != 0) ? 1 : 0;
            }
            
            return true;
        }
        private static void SetAllItems(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, Royal.Scenes.Game.Mechanics.Items.Config.ItemModel item)
        {
            item.itemMediator.ClearFromAllRegisteredCells();
            item.itemMediator.ClearAllItems();
            item.itemMediator.SetAllItems(itemModel:  item);
        }
    
    }

}
