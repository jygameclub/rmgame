using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Fall
{
    public class FallComponent : IFallComponent
    {
        // Fields
        private const float FloatPrecision = 0.001;
        public const float InitialSpeed = 4;
        private const float MinimumCrossSpeed = 4;
        private const float StraightAcceleration = 0.5;
        private const float CrossAcceleration = 0.5;
        private const float MaxSpeed = 20;
        private const float FillItemFallOffset = 1.5;
        private const float StraightFallOffset = 1.25;
        private const float CrossFallOffset = 1.7;
        private const float SpeedMultiplierOnRefill = 0.8;
        private readonly Royal.Scenes.Game.Mechanics.Items.Config.ItemModel item;
        private readonly Royal.Scenes.Game.Mechanics.Items.Config.ItemMediator itemMediator;
        private Royal.Scenes.Game.Mechanics.Board.Cell.FillingCellModel fillingCell;
        private Royal.Scenes.Game.Mechanics.Fall.FallState currentFallState;
        private DG.Tweening.Sequence bounceSequence;
        private bool isFallingCross;
        private Royal.Scenes.Game.Levels.Units.Sfx.GameSfxManager sfxManager;
        private Royal.Player.Context.Units.LevelManager levelManager;
        private bool playedSound;
        private bool hasEverFallCross;
        private float <CurrentSpeed>k__BackingField;
        private float <StateChangedTime>k__BackingField;
        
        // Properties
        public float CurrentSpeed { get; set; }
        public float StateChangedTime { get; set; }
        
        // Methods
        public float get_CurrentSpeed()
        {
            return (float)this.<CurrentSpeed>k__BackingField;
        }
        public void set_CurrentSpeed(float value)
        {
            this.<CurrentSpeed>k__BackingField = value;
        }
        public float get_StateChangedTime()
        {
            return (float)this.<StateChangedTime>k__BackingField;
        }
        public void set_StateChangedTime(float value)
        {
            this.<StateChangedTime>k__BackingField = value;
        }
        public FallComponent(Royal.Scenes.Game.Mechanics.Items.Config.ItemModel currentItem)
        {
            this.item = currentItem;
            this.itemMediator = currentItem.itemMediator;
            this.sfxManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.Sfx.GameSfxManager>(contextId:  22);
            this.levelManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LevelManager>(id:  2);
        }
        public void SetFillingCell(Royal.Scenes.Game.Mechanics.Board.Cell.FillingCellModel model)
        {
            this.fillingCell = model;
        }
        private void SetFallState(Royal.Scenes.Game.Mechanics.Fall.FallState state)
        {
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_2;
            this.<CurrentSpeed>k__BackingField = 0f;
            if(this.currentFallState == state)
            {
                    val_2 = this.item;
            }
            else
            {
                    val_2 = this;
                mem[1152921523882311528] = Royal.Scenes.Game.Levels.LevelContext.Time;
                this.currentFallState = state;
                if(state == 1)
            {
                
            }
            
            }
        
        }
        public void ManualUpdate()
        {
            if(this.currentFallState == 0)
            {
                goto label_0;
            }
            
            this.StopIfReached();
            if(this.currentFallState == 1)
            {
                goto label_5;
            }
            
            label_0:
            if(this.itemMediator.CurrentCell != this.itemMediator.TargetCell)
            {
                    this.SetFallState(state:  1);
            }
            else
            {
                    if(this.currentFallState == 0)
            {
                    return;
            }
            
            }
            
            label_5:
            this.FallWithConstantSpeed();
            if(this.playedSound == false)
            {
                goto label_7;
            }
            
            label_15:
            this.ArrangeIsUnderHoney();
            return;
            label_7:
            if(this.hasEverFallCross == false)
            {
                goto label_15;
            }
            
            UnityEngine.Vector3 val_3 = this.item.Position;
            UnityEngine.Vector3 val_5 = this.itemMediator.TargetCell.GetViewPosition();
            float val_6 = 0.05f;
            val_6 = val_5.y + val_6;
            if(val_3.y >= 0)
            {
                goto label_15;
            }
            
            this.sfxManager.PlayFallHit();
            this.playedSound = true;
            goto label_15;
        }
        private void FallWithConstantSpeed()
        {
            if(this.itemMediator.CurrentCell != null)
            {
                    this.FallToNextCell();
                return;
            }
            
            if(this.fillingCell != null)
            {
                    this.FallToFillingCell();
                return;
            }
            
            this.SetFallState(state:  0);
        }
        private void FallToFillingCell()
        {
            float val_13;
            if(this.fillingCell.IsFallFrozen() == true)
            {
                    return;
            }
            
            float val_15 = V1.16B;
            val_13 = this.GetAcceleratedSpeed(isFallStraight:  true);
            if(this.CurrentItem == null)
            {
                goto label_6;
            }
            
            var val_13 = 0;
            if(mem[1152921505110343680] != null)
            {
                    val_13 = val_13 + 1;
            }
            else
            {
                    var val_14 = mem[1152921505110343688];
                val_14 = val_14 + 1;
                Royal.Scenes.Game.Mechanics.Fall.IFallComponent val_5 = 1152921505110306816 + val_14;
            }
            
            val_13 = val_3.fallComponent.CurrentSpeed * 0.8f;
            if((val_15 - S1) < 0)
            {
                goto label_12;
            }
            
            label_6:
            float val_7 = Royal.Scenes.Game.Levels.LevelContext.DeltaTime;
            val_7 = val_13 * val_7;
            val_15 = val_15 - val_7;
            UnityEngine.Vector3 val_8 = this.fillingCell.GetViewPosition();
            float val_16 = 0.5f;
            val_16 = val_8.y + val_16;
            if(val_15 < 0)
            {
                    if((this.fillingCell.SetCurrentItem(item:  this.item)) != false)
            {
                    this.fillingCell.RemoveCreatedItem();
                bool val_10 = this.fillingCell.SetNextItem(item:  this.item);
            }
            
            }
            
            UnityEngine.Vector3 val_11 = this.fillingCell.GetViewPosition();
            if(val_15 < 0)
            {
                    UnityEngine.Vector3 val_12 = this.fillingCell.GetViewPosition();
                this.item.Position = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
                return;
            }
            
            this.item.Position = new UnityEngine.Vector3() {x = V0.16B, y = val_15, z = V2.16B};
            label_12:
            this.<CurrentSpeed>k__BackingField = val_13;
        }
        private void FallToNextCell()
        {
            float val_17;
            this.SelectNextCell();
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_1 = this.itemMediator.NextCell;
            if(val_1 == null)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_3 = this.itemMediator.CurrentCell.GetViewPosition();
            UnityEngine.Vector3 val_5 = this.itemMediator.NextCell.GetViewPosition();
            if(val_1 == this.itemMediator.CurrentCell)
            {
                    val_17 = val_3.x;
                if((Royal.Infrastructure.Utils.Math.NumberExtensions.Approximately(a:  val_5.x, b:  val_17, precision:  0.001f)) != false)
            {
                    val_17 = val_3.y;
                if((Royal.Infrastructure.Utils.Math.NumberExtensions.Approximately(a:  val_5.y, b:  val_17, precision:  0.001f)) == true)
            {
                    return;
            }
            
            }
            
            }
            
            float val_9 = val_5.y - val_3.y;
            bool val_11 = Royal.Infrastructure.Utils.Math.NumberExtensions.Approximately(a:  val_5.x, b:  val_3.x, precision:  0.001f);
            if(((((val_9 > 0.001f) ? 1 : 0) & val_11) != true) && ((Royal.Infrastructure.Utils.Math.NumberExtensions.Approximately(a:  val_5.x, b:  val_5.x, precision:  0.001f)) != true))
            {
                    this.FallCross(currentCellViewPos:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, nextCellViewPos:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, currentItemViewPos:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.z, z = ???}, isItemAboveCurrentCell:  (val_9 > 0.001f) ? 1 : 0);
                return;
            }
            
            this.FallStraight(currentCellViewPos:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, nextCellViewPos:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, currentItemViewPos:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.z, z = ???}, isItemAboveCurrentCell:  (val_9 > 0.001f) ? 1 : 0, isInCurrentColumn:  val_11);
        }
        private void FallStraight(UnityEngine.Vector3 currentCellViewPos, UnityEngine.Vector3 nextCellViewPos, UnityEngine.Vector3 currentItemViewPos, bool isItemAboveCurrentCell, bool isInCurrentColumn)
        {
            float val_1;
            float val_27;
            float val_28;
            float val_29;
            float val_30;
            var val_31;
            float val_32;
            float val_33;
            float val_34;
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_35;
            var val_37;
            bool val_27 = isInCurrentColumn;
            val_27 = currentCellViewPos.z;
            val_28 = currentCellViewPos.y;
            val_29 = currentCellViewPos.x;
            if(this.isFallingCross != false)
            {
                    this.isFallingCross = false;
                Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_2 = this.itemMediator.CurrentCell;
                Royal.Scenes.Game.Mechanics.Sortings.SortingData val_4 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetItemSorting(row:  47599616, isReverseSort:  this.item & 1);
                bool val_5 = val_4.sortEverything & 4294967295;
            }
            
            if((Royal.Infrastructure.Utils.Math.NumberExtensions.Approximately(a:  val_1, b:  val_28, precision:  0.001f)) != true)
            {
                    if(isItemAboveCurrentCell == false)
            {
                goto label_14;
            }
            
            }
            
            if(this.itemMediator.CurrentCell.IsFallFrozen() != false)
            {
                    val_30 = this.<CurrentSpeed>k__BackingField;
                val_31 = 1;
            }
            else
            {
                    label_14:
                val_30 = this.GetAcceleratedSpeed(isFallStraight:  true);
                val_31 = 0;
            }
            
            bool val_11 = isItemAboveCurrentCell & (~(Royal.Infrastructure.Utils.Math.NumberExtensions.Approximately(a:  currentItemViewPos.x, b:  nextCellViewPos.x, precision:  0.001f)));
            val_11 = val_11 & val_27;
            val_27 = val_31 | val_11;
            if(val_27 != false)
            {
                
            }
            else
            {
                    val_29 = nextCellViewPos.x;
                val_27 = nextCellViewPos.z;
                val_28 = nextCellViewPos.y;
            }
            
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.MoveTowards(current:  new UnityEngine.Vector3() {x = currentItemViewPos.x, y = val_1, z = currentItemViewPos.y}, target:  new UnityEngine.Vector3() {x = val_29, y = val_28, z = val_27}, maxDistanceDelta:  val_30 * Royal.Scenes.Game.Levels.LevelContext.DeltaTime);
            val_32 = val_15.x;
            val_33 = val_15.y;
            val_34 = val_15.z;
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_17 = this.itemMediator.NextCell.CurrentItem;
            if(val_17 == null)
            {
                goto label_27;
            }
            
            val_35 = this.item;
            if(val_35 == val_17)
            {
                goto label_26;
            }
            
            val_15.y = val_33 - val_15.y;
            val_15.y = val_15.y + (-1f);
            if(val_15.y < 0)
            {
                    var val_28 = 0;
                if(mem[1152921505110343680] != null)
            {
                    val_28 = val_28 + 1;
            }
            else
            {
                    var val_29 = mem[1152921505110343688];
                val_29 = val_29 + 1;
                Royal.Scenes.Game.Mechanics.Fall.IFallComponent val_18 = 1152921505110306816 + val_29;
            }
            
                float val_19 = val_17.fallComponent.CurrentSpeed;
                val_30 = val_19 * 0.9f;
                val_32 = val_19;
                val_33 = 0.9f;
                val_34 = -1f;
            }
            
            label_27:
            val_35 = this.item;
            label_26:
            float val_20 = nextCellViewPos.y + (-0.001f);
            if(val_33 >= 0)
            {
                goto label_35;
            }
            
            val_32 = nextCellViewPos.x;
            val_34 = nextCellViewPos.z;
            val_37 = 1;
            if(val_35 != null)
            {
                goto label_36;
            }
            
            label_35:
            val_37 = 0;
            label_36:
            val_35.Position = new UnityEngine.Vector3() {x = val_32, y = val_33, z = val_34};
            if((val_37 & 1) == 0)
            {
                    this.<CurrentSpeed>k__BackingField = val_30;
            }
            
            if(this.itemMediator.CurrentCell == this.itemMediator.NextCell)
            {
                    return;
            }
            
            float val_30 = 0.5f;
            val_30 = nextCellViewPos.y + val_30;
            if(val_33 >= 0)
            {
                    return;
            }
            
            if(this.itemMediator.CurrentCell.IsFallFrozen() == true)
            {
                    return;
            }
            
            bool val_26 = this.itemMediator.NextCell.SetCurrentItem(item:  this.item);
        }
        private void FallCross(UnityEngine.Vector3 currentCellViewPos, UnityEngine.Vector3 nextCellViewPos, UnityEngine.Vector3 currentItemViewPos, bool isItemAboveCurrentCell)
        {
            float val_3;
            var val_34;
            float val_35;
            var val_36;
            float val_37;
            float val_38;
            float val_42;
            float val_43;
            float val_44;
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_45;
            var val_47;
            if(this.isFallingCross != true)
            {
                    this.hasEverFallCross = true;
                this.isFallingCross = true;
                Royal.Scenes.Game.Mechanics.Sortings.SortingData val_1 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetCrossSorting(item:  this.item);
                bool val_2 = val_1.sortEverything & 4294967295;
            }
            
            if((Royal.Infrastructure.Utils.Math.NumberExtensions.Approximately(a:  val_3, b:  currentCellViewPos.y, precision:  0.001f)) != true)
            {
                    if(isItemAboveCurrentCell == false)
            {
                goto label_10;
            }
            
            }
            
            if(this.itemMediator.CurrentCell.IsFallFrozen() != false)
            {
                    val_34 = 1;
            }
            else
            {
                    label_10:
                float val_7 = this.GetAcceleratedSpeed(isFallStraight:  true);
                val_34 = 0;
            }
            
            UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = currentItemViewPos.x, y = val_3, z = currentItemViewPos.y});
            UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = currentCellViewPos.x, y = currentCellViewPos.y, z = currentCellViewPos.z});
            UnityEngine.Vector2 val_11 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = currentItemViewPos.x, y = val_3, z = currentItemViewPos.y});
            UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = nextCellViewPos.x, y = nextCellViewPos.y, z = nextCellViewPos.z});
            val_35 = val_11.x;
            if(isItemAboveCurrentCell != false)
            {
                    val_35 = this.AngleTo(pos:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y}, target:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y});
                val_36 = (~(Royal.Infrastructure.Utils.Math.NumberExtensions.Approximately(a:  val_35, b:  this.AngleTo(pos:  new UnityEngine.Vector2() {x = val_35, y = val_11.y}, target:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y}), precision:  0.001f))) & 1;
            }
            else
            {
                    val_36 = 0;
            }
            
            if((val_36 | val_34) != 0)
            {
                    val_37 = currentCellViewPos.z;
                val_38 = val_7;
                val_37 = currentCellViewPos.z;
                val_37 = currentCellViewPos.z;
            }
            else
            {
                    val_37 = nextCellViewPos.z;
                val_38 = val_7;
                val_37 = nextCellViewPos.z;
                val_37 = nextCellViewPos.z;
            }
            
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.MoveTowards(current:  new UnityEngine.Vector3() {x = currentItemViewPos.x, y = val_3, z = currentItemViewPos.y}, target:  new UnityEngine.Vector3() {x = nextCellViewPos.x, y = nextCellViewPos.y, z = val_37}, maxDistanceDelta:  val_38 * Royal.Scenes.Game.Levels.LevelContext.DeltaTime);
            val_42 = val_18.x;
            val_43 = val_18.y;
            val_44 = val_18.z;
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_20 = this.itemMediator.NextCell.CurrentItem;
            if(val_20 == null)
            {
                goto label_29;
            }
            
            val_45 = this.item;
            if(val_45 == val_20)
            {
                goto label_26;
            }
            
            UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = currentCellViewPos.x, y = currentCellViewPos.y, z = currentCellViewPos.z}, b:  new UnityEngine.Vector3() {x = nextCellViewPos.x, y = nextCellViewPos.y, z = nextCellViewPos.z});
            UnityEngine.Vector2 val_22 = new UnityEngine.Vector2(x:  val_21.x, y:  val_21.y);
            val_37 = val_21.z;
            UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_42, y = val_43, z = val_44}, b:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_37});
            val_23.x = val_23.x - val_21.x;
            if(val_23.x < 0)
            {
                    var val_35 = 0;
                if(mem[1152921505110343680] != null)
            {
                    val_35 = val_35 + 1;
            }
            else
            {
                    var val_36 = mem[1152921505110343688];
                val_36 = val_36 + 1;
                Royal.Scenes.Game.Mechanics.Fall.IFallComponent val_24 = 1152921505110306816 + val_36;
            }
            
                float val_25 = val_20.fallComponent.CurrentSpeed;
                val_38 = val_25 * 0.9f;
                val_42 = val_25;
                val_43 = 0.9f;
                val_44 = val_23.z;
            }
            
            label_29:
            val_45 = this.item;
            label_26:
            float val_26 = nextCellViewPos.y + (-0.001f);
            if(val_43 < 0)
            {
                    val_42 = nextCellViewPos.x;
                val_44 = nextCellViewPos.z;
                val_47 = 1;
            }
            else
            {
                    val_47 = 0;
            }
            
            val_45.Position = new UnityEngine.Vector3() {x = val_42, y = val_43, z = val_44};
            if((val_47 & 1) == 0)
            {
                    this.<CurrentSpeed>k__BackingField = val_38;
            }
            
            if(this.itemMediator.CurrentCell == this.itemMediator.NextCell)
            {
                    return;
            }
            
            if(this.itemMediator.CurrentCell.IsFallFrozen() == true)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_31 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = currentCellViewPos.x, y = currentCellViewPos.y, z = currentCellViewPos.z}, b:  new UnityEngine.Vector3() {x = nextCellViewPos.x, y = nextCellViewPos.y, z = nextCellViewPos.z}, t:  0.5f);
            float val_32 = val_31.y + (-0.001f);
            if(val_43 >= 0)
            {
                    return;
            }
            
            bool val_34 = this.itemMediator.NextCell.SetCurrentItem(item:  this.item);
        }
        private float AngleTo(UnityEngine.Vector2 pos, UnityEngine.Vector2 target)
        {
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = target.x, y = target.y}, b:  new UnityEngine.Vector2() {x = pos.x, y = pos.y});
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.right;
            return UnityEngine.Vector2.Angle(from:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, to:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
        }
        private void SelectNextCell()
        {
            var val_19;
            var val_20;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_1 = this.itemMediator.NextCell;
            if(val_1 == this.itemMediator.TargetCell)
            {
                    return;
            }
            
            if(this.itemMediator.CurrentCell.IsFallFrozen() == true)
            {
                    return;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_5 = this.itemMediator.TargetCell;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_6 = this.itemMediator.CurrentCell;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_8 = val_1 - W21;
            if(val_8 != null)
            {
                    var val_9 = (val_8 < 1) ? 6 : 4;
            }
            else
            {
                    val_20 = 5;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_10 = this.itemMediator.CurrentCell.Get(type:  5);
            if(this.itemMediator.NextCell == val_10)
            {
                    return;
            }
            
            if(val_10.HasCurrentItem() != false)
            {
                    val_19 = val_10.CurrentItem;
                if(val_19 == val_10.NextItem)
            {
                    return;
            }
            
                Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_15 = val_10.CurrentItem;
                UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B}, b:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B});
                float val_17 = (val_8 != 0) ? 1.7f : 1.25f;
                if(val_16.x < 0)
            {
                    this.<CurrentSpeed>k__BackingField = 0f;
                return;
            }
            
            }
            
            bool val_18 = val_10.SetNextItem(item:  this.item);
        }
        private float GetAcceleratedSpeed(bool isFallStraight)
        {
            return UnityEngine.Mathf.Clamp(value:  (this.<CurrentSpeed>k__BackingField) + 0.5f, min:  4f, max:  20f);
        }
        private void StopIfReached()
        {
            UnityEngine.Vector3 val_1 = this.item.Position;
            UnityEngine.Vector3 val_3 = this.itemMediator.TargetCell.GetViewPosition();
            float val_11 = 0.001f;
            val_11 = val_3.y + val_11;
            if(val_1.y > val_11)
            {
                    return;
            }
            
            if(this.itemMediator.CurrentCell != this.itemMediator.TargetCell)
            {
                    return;
            }
            
            this.isFallingCross = false;
            if(this.itemMediator.HasCurrentCell() != false)
            {
                    Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_7 = this.itemMediator.CurrentCell;
                Royal.Scenes.Game.Mechanics.Sortings.SortingData val_9 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetItemSorting(row:  W21, isReverseSort:  this.item & 1);
                bool val_10 = val_9.sortEverything & 4294967295;
                this.ArrangeIsUnderHoney();
            }
            
            this.SetFallState(state:  0);
            this.playedSound = false;
            this.hasEverFallCross = false;
        }
        public bool IsItemSteady()
        {
            return (bool)(this.currentFallState == 0) ? 1 : 0;
        }
        private void ArrangeIsUnderHoney()
        {
            bool val_10;
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_11;
            if(this.levelManager.isThereHoneyInLevel == false)
            {
                    return;
            }
            
            bool val_1 = this.itemMediator.HasCurrentCell();
            if((val_1 != true) && (this.fillingCell != null))
            {
                    val_10 = val_1.HasStaticItem(itemType:  2);
                val_11 = this.item;
            }
            else
            {
                    val_11 = this.item;
                if(this.itemMediator.HasCurrentCell() != false)
            {
                    UnityEngine.Vector3 val_4 = mem[this.item].Position;
                UnityEngine.Vector3 val_6 = this.itemMediator.CurrentCell.GetViewPosition();
                float val_10 = 0.001f;
                val_10 = val_6.y + val_10;
                if(val_4.y > val_10)
            {
                    return;
            }
            
            }
            
                val_10 = mem[this.item].IsUnderHoney();
            }
            
            var val_8 = ((mem[this.item] + 80) != 0) ? 1 : 0;
            val_8 = val_10 ^ val_8;
            if(val_8 == false)
            {
                    return;
            }
            
            mem[this.item].SetIsUnderHoney(isUnder:  val_10);
        }
    
    }

}
