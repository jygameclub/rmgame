using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Fall
{
    public class MasterFallComponent : IFallComponent
    {
        // Fields
        private const float FloatPrecision = 0.001;
        public const float InitialSpeed = 4;
        private const float StraightAcceleration = 0.5;
        private const float MaxSpeed = 20;
        private const float StraightFallOffset = 1.25;
        private const float CrossFallOffset = 1.7;
        private readonly Royal.Scenes.Game.Mechanics.Items.Config.MultipleItemModel item;
        private readonly Royal.Scenes.Game.Mechanics.Items.Config.ItemMediator itemMediator;
        private Royal.Scenes.Game.Mechanics.Fall.FallState currentFallState;
        private DG.Tweening.Sequence bounceSequence;
        private Royal.Scenes.Game.Levels.Units.Sfx.GameSfxManager sfxManager;
        private bool playedSound;
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
        public MasterFallComponent(Royal.Scenes.Game.Mechanics.Items.Config.MultipleItemModel currentItem)
        {
            this.item = currentItem;
            this.itemMediator = true;
            this.sfxManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.Sfx.GameSfxManager>(contextId:  22);
        }
        public void SetFillingCell(Royal.Scenes.Game.Mechanics.Board.Cell.FillingCellModel model)
        {
        
        }
        private void SetFallState(Royal.Scenes.Game.Mechanics.Fall.FallState state)
        {
            Royal.Scenes.Game.Mechanics.Items.Config.MultipleItemModel val_3;
            this.<CurrentSpeed>k__BackingField = 0f;
            if(this.currentFallState == state)
            {
                    val_3 = this.item;
            }
            else
            {
                    val_3 = this;
                mem[1152921523886121904] = Royal.Scenes.Game.Levels.LevelContext.Time;
                this.currentFallState = state;
                if(state == 1)
            {
                
            }
            
                int val_2 = this.item.GetExplodeScore();
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
            if(this.playedSound == true)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_3 = this.item.Position;
            UnityEngine.Vector3 val_5 = this.itemMediator.TargetCell.GetViewPosition();
            float val_6 = 0.05f;
            val_6 = val_5.y + val_6;
            if(val_3.y >= 0)
            {
                    return;
            }
            
            this.sfxManager.PlayFallHit();
            this.playedSound = true;
        }
        private void FallWithConstantSpeed()
        {
            if(this.itemMediator.CurrentCell != null)
            {
                    this.FallToNextCell();
                return;
            }
            
            this.SetFallState(state:  0);
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
            UnityEngine.Vector3 val_6 = this.item.GetViewPosition();
            if(val_1 == this.itemMediator.CurrentCell)
            {
                    val_17 = 0.001f;
                if((Royal.Infrastructure.Utils.Math.NumberExtensions.Approximately(a:  val_6.x, b:  val_3.x, precision:  val_17)) != false)
            {
                    if((Royal.Infrastructure.Utils.Math.NumberExtensions.Approximately(a:  val_6.y, b:  val_3.y, precision:  val_17)) == true)
            {
                    return;
            }
            
            }
            
            }
            
            val_17 = 0.001f;
            float val_10 = val_6.y - val_3.y;
            bool val_12 = Royal.Infrastructure.Utils.Math.NumberExtensions.Approximately(a:  val_6.x, b:  val_3.x, precision:  val_17);
            if((((val_10 > val_17) ? 1 : 0) & val_12) != true)
            {
                    if((Royal.Infrastructure.Utils.Math.NumberExtensions.Approximately(a:  val_6.x, b:  val_5.x, precision:  val_17)) == false)
            {
                    return;
            }
            
            }
            
            this.FallStraight(currentCellViewPos:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, nextCellViewPos:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, currentItemViewPos:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.z, z = ???}, isItemAboveCurrentCell:  (val_10 > val_17) ? 1 : 0, isInCurrentColumn:  val_12);
        }
        private void FallStraight(UnityEngine.Vector3 currentCellViewPos, UnityEngine.Vector3 nextCellViewPos, UnityEngine.Vector3 currentItemViewPos, bool isItemAboveCurrentCell, bool isInCurrentColumn)
        {
            float val_1;
            float val_22;
            float val_23;
            float val_24;
            float val_25;
            var val_26;
            float val_30;
            float val_31;
            float val_32;
            Royal.Scenes.Game.Mechanics.Items.Config.MultipleItemModel val_33;
            var val_35;
            bool val_23 = isInCurrentColumn;
            val_22 = currentCellViewPos.z;
            val_23 = currentCellViewPos.y;
            val_24 = currentCellViewPos.x;
            val_25 = currentItemViewPos.x;
            if((Royal.Infrastructure.Utils.Math.NumberExtensions.Approximately(a:  val_1, b:  val_23, precision:  0.001f)) != true)
            {
                    if(isItemAboveCurrentCell == false)
            {
                goto label_5;
            }
            
            }
            
            if(this.itemMediator.CurrentCell.IsFallFrozen() != false)
            {
                    val_25 = this.<CurrentSpeed>k__BackingField;
                val_26 = 1;
            }
            else
            {
                    label_5:
                val_26 = 0;
            }
            
            bool val_7 = isItemAboveCurrentCell & (~(Royal.Infrastructure.Utils.Math.NumberExtensions.Approximately(a:  val_25, b:  nextCellViewPos.x, precision:  0.001f)));
            val_7 = val_7 & val_23;
            val_23 = val_26 | val_7;
            if(val_23 != false)
            {
                
            }
            else
            {
                    val_24 = nextCellViewPos.x;
                val_22 = nextCellViewPos.z;
                val_23 = nextCellViewPos.y;
            }
            
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.MoveTowards(current:  new UnityEngine.Vector3() {x = currentItemViewPos.x, y = val_1, z = currentItemViewPos.y}, target:  new UnityEngine.Vector3() {x = val_24, y = val_23, z = val_22}, maxDistanceDelta:  this.GetAcceleratedSpeed() * Royal.Scenes.Game.Levels.LevelContext.DeltaTime);
            val_30 = val_11.x;
            val_31 = val_11.y;
            val_32 = val_11.z;
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_13 = this.itemMediator.NextCell.CurrentItem;
            if(val_13 == null)
            {
                goto label_18;
            }
            
            val_33 = this.item;
            if(val_33 == val_13)
            {
                goto label_17;
            }
            
            val_11.y = val_31 - val_11.y;
            val_11.y = val_11.y + (-1f);
            if(val_11.y < 0)
            {
                    var val_24 = 0;
                if(mem[1152921505110343680] != null)
            {
                    val_24 = val_24 + 1;
            }
            else
            {
                    var val_25 = mem[1152921505110343688];
                val_25 = val_25 + 1;
                Royal.Scenes.Game.Mechanics.Fall.IFallComponent val_14 = 1152921505110306816 + val_25;
            }
            
                float val_15 = val_13.fallComponent.CurrentSpeed;
                val_15 = val_15 * 0.9f;
                UnityEngine.Vector3 val_16 = this.item.GetViewPosition();
                val_30 = val_16.x;
                val_31 = val_16.y;
                val_32 = val_16.z;
            }
            
            label_18:
            val_33 = this.item;
            label_17:
            float val_17 = nextCellViewPos.y + (-0.001f);
            if(val_31 >= 0)
            {
                goto label_26;
            }
            
            val_30 = nextCellViewPos.x;
            val_32 = nextCellViewPos.z;
            val_35 = 1;
            if(val_33 != null)
            {
                goto label_27;
            }
            
            label_26:
            val_35 = 0;
            label_27:
            val_33.Position = new UnityEngine.Vector3() {x = val_30, y = val_31, z = val_32};
            if((val_35 & 1) == 0)
            {
                    this.<CurrentSpeed>k__BackingField = val_15;
            }
            
            if(this.itemMediator.CurrentCell == this.itemMediator.NextCell)
            {
                    return;
            }
            
            float val_26 = 0.5f;
            val_26 = nextCellViewPos.y + val_26;
            if(val_31 >= 0)
            {
                    return;
            }
            
            if(this.itemMediator.CurrentCell.IsFallFrozen() == true)
            {
                    return;
            }
            
            this.item.TrySetCellAsCurrent(currentCell:  this.itemMediator.NextCell);
        }
        private void SelectNextCell()
        {
            if(this.itemMediator.NextCell == this.itemMediator.TargetCell)
            {
                    return;
            }
            
            if(this.itemMediator.CurrentCell.IsFallFrozen() == true)
            {
                    return;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_6 = this.itemMediator.CurrentCell.Get(type:  5);
            if(this.itemMediator.NextCell == val_6)
            {
                    return;
            }
            
            if(X21.HasCurrentItem() != false)
            {
                    if(X21.CurrentItem == X21.NextItem)
            {
                    return;
            }
            
                Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_11 = X21.CurrentItem;
                UnityEngine.Vector3 val_12 = this.item.GetViewPosition();
                UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, b:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B});
                if(val_13.x < 0)
            {
                    this.<CurrentSpeed>k__BackingField = 0f;
                return;
            }
            
            }
            
            this.item.TrySetCellAsNext(nextCell:  val_6);
        }
        private float GetAcceleratedSpeed()
        {
            float val_1 = 0.5f;
            val_1 = (this.<CurrentSpeed>k__BackingField) + val_1;
            return UnityEngine.Mathf.Clamp(value:  val_1, min:  4f, max:  20f);
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
            
            if(this.itemMediator.HasCurrentCell() != false)
            {
                    Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_7 = this.itemMediator.CurrentCell;
                Royal.Scenes.Game.Mechanics.Sortings.SortingData val_9 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetItemSorting(row:  W21, isReverseSort:  this.item & 1);
                bool val_10 = val_9.sortEverything & 4294967295;
            }
            
            this.SetFallState(state:  0);
            this.playedSound = false;
        }
        public bool IsItemSteady()
        {
            return (bool)(this.currentFallState == 0) ? 1 : 0;
        }
    
    }

}
