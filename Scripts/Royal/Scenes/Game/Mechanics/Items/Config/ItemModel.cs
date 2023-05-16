using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.Config
{
    public abstract class ItemModel : IExplodeTarget
    {
        // Fields
        private static int StaticId;
        private readonly int <Id>k__BackingField;
        private bool <HasView>k__BackingField;
        private Royal.Scenes.Game.Mechanics.Matches.MatchType <MatchType>k__BackingField;
        private Royal.Scenes.Game.Mechanics.Goal.GoalType <GoalType>k__BackingField;
        public readonly Royal.Scenes.Game.Mechanics.Items.Config.ItemMediator itemMediator;
        public Royal.Scenes.Game.Mechanics.Fall.IFallComponent fallComponent;
        private readonly Royal.Player.Context.Units.LevelManager levelManager;
        protected readonly Royal.Scenes.Game.Levels.Units.CellGridManager gridManager;
        protected readonly Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory;
        protected readonly Royal.Scenes.Game.Levels.Units.GoalManager goalManager;
        protected int layer;
        protected readonly Royal.Scenes.Game.Mechanics.Explode.ExploderContainer exploderContainer;
        protected readonly Royal.Scenes.Game.Mechanics.Explode.IncomingExploderContainer incomingContainer;
        public readonly Royal.Scenes.Game.Mechanics.Explode.ExtraIncomingExploderContainer extraIncomingContainer;
        protected readonly Royal.Scenes.Game.Levels.Units.State.GameStateManager gameStateManager;
        private System.Action OnExplodeEvent;
        
        // Properties
        public int Id { get; }
        public virtual bool HasView { get; set; }
        public abstract Royal.Scenes.Game.Mechanics.Items.Config.ItemType ItemType { get; }
        public Royal.Scenes.Game.Mechanics.Matches.MatchType MatchType { get; set; }
        public Royal.Scenes.Game.Mechanics.Goal.GoalType GoalType { get; set; }
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel CurrentCell { get; }
        public virtual bool IsValidTarget { get; }
        
        // Methods
        public int get_Id()
        {
            return (int)this.<Id>k__BackingField;
        }
        public virtual bool get_HasView()
        {
            return (bool)this.<HasView>k__BackingField;
        }
        protected virtual void set_HasView(bool value)
        {
            this.<HasView>k__BackingField = value;
        }
        public abstract Royal.Scenes.Game.Mechanics.Items.Config.ItemType get_ItemType(); // 0
        public Royal.Scenes.Game.Mechanics.Matches.MatchType get_MatchType()
        {
            return (Royal.Scenes.Game.Mechanics.Matches.MatchType)this.<MatchType>k__BackingField;
        }
        protected void set_MatchType(Royal.Scenes.Game.Mechanics.Matches.MatchType value)
        {
            this.<MatchType>k__BackingField = value;
        }
        public Royal.Scenes.Game.Mechanics.Goal.GoalType get_GoalType()
        {
            return (Royal.Scenes.Game.Mechanics.Goal.GoalType)this.<GoalType>k__BackingField;
        }
        public void set_GoalType(Royal.Scenes.Game.Mechanics.Goal.GoalType value)
        {
            this.<GoalType>k__BackingField = value;
        }
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel get_CurrentCell()
        {
            if(this.itemMediator != null)
            {
                    return this.itemMediator.CurrentCell;
            }
            
            throw new NullReferenceException();
        }
        public virtual bool get_IsValidTarget()
        {
            goto typeof(Royal.Scenes.Game.Mechanics.Items.Config.ItemModel).__il2cppRuntimeField_1D0;
        }
        public void add_OnExplodeEvent(System.Action value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnExplodeEvent, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnExplodeEvent != 1152921523788025096);
            
            return;
            label_2:
        }
        public void remove_OnExplodeEvent(System.Action value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnExplodeEvent, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnExplodeEvent != 1152921523788161672);
            
            return;
            label_2:
        }
        protected ItemModel(int layer = 1)
        {
            this.itemFactory = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1);
            this.goalManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.GoalManager>(contextId:  11);
            this.levelManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LevelManager>(id:  2);
            this.gridManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.CellGridManager>(contextId:  2);
            this.gameStateManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14);
            this.layer = layer;
            this.itemMediator = new Royal.Scenes.Game.Mechanics.Items.Config.ItemMediator();
            this.exploderContainer = new Royal.Scenes.Game.Mechanics.Explode.ExploderContainer();
            this.incomingContainer = new Royal.Scenes.Game.Mechanics.Explode.IncomingExploderContainer();
            this.extraIncomingContainer = new Royal.Scenes.Game.Mechanics.Explode.ExtraIncomingExploderContainer();
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel.StaticId = Royal.Scenes.Game.Mechanics.Items.Config.ItemModel.StaticId + 1;
            this.<Id>k__BackingField = Royal.Scenes.Game.Mechanics.Items.Config.ItemModel.StaticId;
        }
        public virtual void CreateFallComponent()
        {
            this.fallComponent = new Royal.Scenes.Game.Mechanics.Fall.FallComponent(currentItem:  this);
        }
        public abstract void CreateView(UnityEngine.Vector3 position); // 0
        public abstract Royal.Scenes.Game.Mechanics.Items.Config.ItemView GetItemView(); // 0
        public abstract bool CanExplodeWithNearMatch(); // 0
        public abstract bool IsFallable(); // 0
        public abstract bool IsSwappable(); // 0
        protected abstract void TryExplode(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data); // 0
        public virtual int GetExplodeScore()
        {
            int val_2 = this.GetFrogExtraScore();
            val_2 = val_2 + (Royal.Scenes.Game.Mechanics.Items.Config.ItemExtensions.ExplodeScore(itemType:  this));
            return (int)val_2;
        }
        protected int GetFrogExtraScore()
        {
            if((this.levelManager.isThereFrogInLevel == false) || (this.layer != 1))
            {
                    return 0;
            }
            
            if((this.itemMediator.CurrentCell == null) || (this.layer == 0))
            {
                    return 0;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_2 = this.itemMediator.CurrentCell;
            if((val_2 == null) || (val_2 == null))
            {
                    return 0;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_3 = val_2.Get(type:  1);
            if(val_3 == null)
            {
                    return 0;
            }
            
            this = val_3;
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_4 = val_3.CurrentItem;
            return 0;
        }
        public virtual bool IsAvailableForFall(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel toCell)
        {
            if((this & 1) != 0)
            {
                    if(null == null)
            {
                goto label_2;
            }
            
            }
            
            return (bool)0 & 1;
            label_2:
            if(this.itemMediator.CurrentCell == null)
            {
                    return (bool)0 & 1;
            }
            
            bool val_5 = this.itemMediator.CurrentCell.HasFallBlockingItem() ^ 1;
            return (bool)0 & 1;
        }
        public virtual bool IsAvailableForSwap()
        {
            var val_4;
            if((this & 1) != 0)
            {
                    var val_4 = 0;
                if(mem[1152921505110343680] != null)
            {
                    val_4 = val_4 + 1;
            }
            else
            {
                    Royal.Scenes.Game.Mechanics.Fall.IFallComponent val_1 = 1152921505110306816 + ((mem[1152921505110343688]) << 4);
            }
            
                if(this.fallComponent.IsItemSteady() != false)
            {
                    var val_3 = (null == 0) ? 1 : 0;
                return (bool)val_4;
            }
            
            }
            
            val_4 = 0;
            return (bool)val_4;
        }
        public virtual bool WillCellBeFreed(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            if(cell == null)
            {
                    cell = this.itemMediator.TargetCell;
            }
            
            if(this > 17)
            {
                goto label_2;
            }
            
            if(this > 17)
            {
                goto label_6;
            }
            
            if(0 != 198656)
            {
                    return false;
            }
            
            goto label_6;
            label_2:
            if(this <= 35)
            {
                    if(0 != (-2143289344))
            {
                    return false;
            }
            
            }
            
            label_6:
            if(cell.CurrentItem != this)
            {
                    if(cell.TargetItem != this)
            {
                    return false;
            }
            
            }
            
            var val_4 = (this < 1) ? 1 : 0;
            return false;
        }
        public virtual int FinalExplodeCount()
        {
            return UnityEngine.Mathf.Max(a:  0, b:  0);
        }
        public virtual int RemainingExplodeCount()
        {
            int val_1 = this.incomingContainer.GetIncomingCount();
            val_1 = this.layer - val_1;
            return (int)val_1;
        }
        public virtual int GetExtraExplodeCount()
        {
            return this.GetExtraExplodeCountInternal();
        }
        private int GetExtraExplodeCountInternal()
        {
            var val_39;
            var val_40;
            var val_41;
            var val_42;
            var val_43;
            var val_44;
            var val_45;
            var val_46;
            var val_47;
            var val_48;
            var val_49;
            if((mem[1152921523789704912].CurrentCell == null) || ((mem[1152921523789704992].HasOperation(animationId:  9)) == false))
            {
                goto label_4;
            }
            
            val_39 = 0;
            val_40 = 0;
            val_41 = 0;
            var val_41 = -2;
            label_17:
            var val_40 = 0;
            goto label_16;
            label_13:
            val_42 = 0;
            val_40 = X23;
            goto label_15;
            label_16:
            if(val_41 == W26)
            {
                    if(1152921523789704882 == val_40)
            {
                goto label_8;
            }
            
            }
            
            val_43 = mem[1152921523789704936];
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_4 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  2002988718, y:  val_41 + W26);
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_5 = val_43.Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_4.x, y = val_4.x}];
            if(val_5 == null)
            {
                goto label_11;
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_7 = val_5.CurrentItem;
            var val_8 = (val_7 == 0) ? (val_40) : (val_7);
            if(val_7 == null)
            {
                goto label_11;
            }
            
            val_43 = val_7;
            var val_9 = ((val_7 == null ? val_40 : val_7 + 104) == 0) ? (val_41) : (val_7 == null ? val_40 : val_7 + 104);
            if((val_7 == null ? val_40 : val_7 + 104) == 0)
            {
                goto label_13;
            }
            
            val_42 = 0;
            val_41 = val_7 == null ? val_40 : val_7 + 104;
            val_40 = val_43;
            val_44 = (val_5 == 0) ? 0 : (val_39);
            goto label_15;
            label_11:
            val_42 = 0;
            label_15:
            val_45 = val_39 + (((val_42 & 0) != 0) ? 0 : (val_42));
            label_8:
            val_40 = val_40 + 1;
            if((val_40 - 2) < 2)
            {
                goto label_16;
            }
            
            val_41 = val_41 + 1;
            if(val_41 <= 1)
            {
                goto label_17;
            }
            
            if((val_1 + 40) == 0)
            {
                    return (int)val_45;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_12 = val_1 + 40.Get(type:  7);
            if(val_12 == null)
            {
                goto label_25;
            }
            
            val_40 = val_12;
            val_43 = 0;
            label_27:
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_13 = val_40.CurrentItem;
            var val_14 = (val_13 == 0) ? 0 : (val_13);
            if(val_13 == null)
            {
                goto label_22;
            }
            
            var val_15 = ((val_13 == null ? 0 : val_13 + 104) == 0) ? 0 : (val_13 == null ? 0 : val_13 + 104);
            if((val_13 == null ? 0 : val_13 + 104) == 0)
            {
                goto label_22;
            }
            
            val_46 = 0;
            goto label_24;
            label_22:
            val_46 = 0;
            label_24:
            val_45 = (((val_46 & 0) != 0) ? 0 : (val_46)) + val_45;
            if(val_40 == 0)
            {
                goto label_25;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_18 = (val_40 == 0) ? (val_43) : (val_40).Get(type:  7);
            val_40 = val_18;
            val_43 = val_40;
            if(val_18 != null)
            {
                goto label_27;
            }
            
            label_25:
            if((val_1 + 40) == 0)
            {
                    return (int)val_45;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_19 = val_1 + 40.Get(type:  3);
            if(val_19 == null)
            {
                goto label_35;
            }
            
            val_40 = val_19;
            val_43 = 0;
            label_37:
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_20 = val_40.CurrentItem;
            var val_21 = (val_20 == 0) ? 0 : (val_20);
            if(val_20 == null)
            {
                goto label_32;
            }
            
            var val_22 = ((val_20 == null ? 0 : val_20 + 104) == 0) ? 0 : (val_20 == null ? 0 : val_20 + 104);
            if((val_20 == null ? 0 : val_20 + 104) == 0)
            {
                goto label_32;
            }
            
            val_47 = 0;
            goto label_34;
            label_32:
            val_47 = 0;
            label_34:
            val_45 = (((val_47 & 0) != 0) ? 0 : (val_47)) + val_45;
            if(val_40 == 0)
            {
                goto label_35;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_25 = (val_40 == 0) ? (val_43) : (val_40).Get(type:  3);
            val_40 = val_25;
            val_43 = val_40;
            if(val_25 != null)
            {
                goto label_37;
            }
            
            label_35:
            if((val_1 + 40) == 0)
            {
                    return (int)val_45;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_26 = val_1 + 40.Get(type:  1);
            if(val_26 == null)
            {
                goto label_45;
            }
            
            val_40 = val_26;
            val_43 = 0;
            label_47:
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_27 = val_40.CurrentItem;
            var val_28 = (val_27 == 0) ? 0 : (val_27);
            if(val_27 == null)
            {
                goto label_42;
            }
            
            var val_29 = ((val_27 == null ? 0 : val_27 + 104) == 0) ? 0 : (val_27 == null ? 0 : val_27 + 104);
            if((val_27 == null ? 0 : val_27 + 104) == 0)
            {
                goto label_42;
            }
            
            val_48 = 0;
            goto label_44;
            label_42:
            val_48 = 0;
            label_44:
            val_45 = (((val_48 & 0) != 0) ? 0 : (val_48)) + val_45;
            if(val_40 == 0)
            {
                goto label_45;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_32 = (val_40 == 0) ? (val_43) : (val_40).Get(type:  1);
            val_40 = val_32;
            val_43 = val_40;
            if(val_32 != null)
            {
                goto label_47;
            }
            
            label_45:
            if((val_1 + 40) == 0)
            {
                    return (int)val_45;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_33 = val_1 + 40.Get(type:  5);
            if(val_33 == null)
            {
                    return (int)val_45;
            }
            
            val_43 = 0;
            label_57:
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_34 = val_33.CurrentItem;
            var val_35 = (val_34 == 0) ? 0 : (val_34);
            if(val_34 == null)
            {
                goto label_52;
            }
            
            var val_36 = ((val_34 == null ? 0 : val_34 + 104) == 0) ? 0 : (val_34 == null ? 0 : val_34 + 104);
            if((val_34 == null ? 0 : val_34 + 104) == 0)
            {
                goto label_52;
            }
            
            val_49 = 0;
            goto label_54;
            label_52:
            val_49 = 0;
            label_54:
            val_45 = (((val_49 & 0) != 0) ? 0 : (val_49)) + val_45;
            if(val_40 == 0)
            {
                    return (int)val_45;
            }
            
            val_43 = val_40;
            if(((val_40 == 0) ? (val_43) : (val_40).Get(type:  5)) != null)
            {
                goto label_57;
            }
            
            return (int)val_45;
            label_4:
            val_45 = 0;
            return (int)val_45;
        }
        public virtual void AddIncomingExploder(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            this.incomingContainer.AddToIncoming(id:  268435460);
            this.extraIncomingContainer.AddToIncoming(id:  268435460, trigger:  2003218640);
        }
        public virtual void RemoveIncomingExploder(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            this.incomingContainer.RemoveFromIncoming(id:  268435460);
            this.extraIncomingContainer.RemoveFromIncoming(id:  268435460, trigger:  2003371504);
        }
        public virtual void Explode(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            if((this.exploderContainer.ContainsExploder(id:  268435460)) == true)
            {
                    return;
            }
            
            this.exploderContainer.AddToExploders(id:  268435460);
        }
        public virtual void ExplodeAll(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            int val_4;
            if((this.exploderContainer.ContainsExploder(id:  268435460)) == true)
            {
                    return;
            }
            
            this.exploderContainer.AddToExploders(id:  268435460);
            if(this.layer == 1)
            {
                    val_4 = data.id;
                return;
            }
            
            if(this.layer < 2)
            {
                    return;
            }
            
            this.layer = 1;
            val_4 = data.id;
        }
        protected virtual void FinalExplodeCompleted(float freezeDuration = 0.15)
        {
            this.itemMediator.CurrentCell.FreezeFallForDuration(duration:  freezeDuration);
            this.itemMediator.ClearFromAllRegisteredCells();
            if(this.OnExplodeEvent == null)
            {
                    return;
            }
            
            this.OnExplodeEvent.Invoke();
        }
        public void InvokeExplodeEvent()
        {
            if(this.OnExplodeEvent == null)
            {
                    return;
            }
            
            this.OnExplodeEvent.Invoke();
        }
        public virtual bool ShouldAddToGoalOnStart()
        {
            return true;
        }
        public virtual bool IsMatchItem()
        {
            return false;
        }
        public virtual bool IsSpecialItem()
        {
            return false;
        }
        public virtual UnityEngine.Vector3 GetViewPosition()
        {
            goto typeof(Royal.Scenes.Game.Mechanics.Items.Config.ItemModel).__il2cppRuntimeField_260;
        }
        public virtual UnityEngine.Vector3 GetMasterViewCenterPosition()
        {
            goto typeof(Royal.Scenes.Game.Mechanics.Items.Config.ItemModel).__il2cppRuntimeField_270;
        }
        public virtual void CollectAsGoal(bool updateUi = True)
        {
            this.goalManager.DecreaseGoal(goalType:  this.<GoalType>k__BackingField);
            if(updateUi == false)
            {
                    return;
            }
            
            this = ???;
            goto typeof(Royal.Scenes.Game.Mechanics.Items.Config.ItemModel).__il2cppRuntimeField_3C0;
        }
        protected virtual void CollectAsGoalUi()
        {
            if(this.goalManager != null)
            {
                    this.goalManager.DecreaseGoalUi(goalType:  this.<GoalType>k__BackingField);
                return;
            }
            
            throw new NullReferenceException();
        }
        public int GetGoalLeftCount()
        {
            if(this.goalManager != null)
            {
                    return this.goalManager.GetGoalLeftCount(goalType:  this.<GoalType>k__BackingField);
            }
            
            throw new NullReferenceException();
        }
        public virtual void RecycleView()
        {
            if((this & 1) == 0)
            {
                    return;
            }
            
            if(this == 0)
            {
                    return;
            }
            
            if(null != 0)
            {
                    this.itemMediator.ShowView();
            }
            
            this.itemFactory.Recycle<Royal.Scenes.Game.Mechanics.Items.Config.ItemView>(go:  this);
        }
        public virtual bool CanReceiveGrass()
        {
            return true;
        }
        public virtual void ReplaceItem()
        {
            this.itemFactory.Recycle<Royal.Scenes.Game.Mechanics.Items.Config.ItemView>(go:  this);
        }
        public virtual bool CanFallCross()
        {
            return false;
        }
        public virtual void RevealFromHoney()
        {
            var val_11 = this;
            this.SetIsUnderHoney(isUnder:  this.IsUnderHoney());
            if((val_11 & 1) == 0)
            {
                    return;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_3 = this.itemMediator.CurrentCell;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_4 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetItemSorting(row:  2005464496, isReverseSort:  false);
            bool val_5 = val_4.sortEverything & 4294967295;
            val_11 = ???;
            goto typeof(Royal.Scenes.Game.Mechanics.Items.Config.ItemModel).__il2cppRuntimeField_1F0;
        }
        public virtual void RevealFromChain()
        {
            var val_9;
            mem[1152921523792309121] = 0;
            val_9 = this;
            if((this & 1) == 0)
            {
                    return;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_1 = this.itemMediator.CurrentCell;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_2 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetItemSorting(row:  2005592880, isReverseSort:  false);
            bool val_3 = val_2.sortEverything & 4294967295;
            val_9 = ???;
            goto typeof(Royal.Scenes.Game.Mechanics.Items.Config.ItemModel).__il2cppRuntimeField_1F0;
        }
        public virtual void RevealFromCurtain()
        {
            var val_8;
            var val_9;
            var val_10;
            this.itemMediator.ShowView();
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_1 = this.itemMediator.CurrentCell;
            if(val_1 == null)
            {
                goto label_4;
            }
            
            if(val_1 == null)
            {
                goto label_5;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.StaticItemType val_8 = 4;
            val_8 = val_1.HasStaticItem(itemType:  val_8);
            var val_3 = (0 != 255) ? 1 : 0;
            var val_4 = (0 > 255) ? 1 : 0;
            goto label_6;
            label_4:
            val_10 = 1;
            goto label_7;
            label_5:
            val_8 = 0;
            val_9 = 0;
            label_6:
            val_8 = val_8 & val_9;
            val_10 = val_8 ^ 1;
            label_7:
            if(val_10 == 0)
            {
                    return;
            }
            
            if((this & 1) == 0)
            {
                    return;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_5 = this.itemMediator.CurrentCell;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_6 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetItemSorting(row:  2005733552, isReverseSort:  false);
            bool val_7 = val_6.sortEverything & 4294967295;
        }
        public virtual bool CanSelectByBooster()
        {
            return true;
        }
        public virtual bool ShouldTryRedirectForPropeller()
        {
            return false;
        }
        public virtual Royal.Scenes.Game.Mechanics.Items.Config.ItemModel TryRedirectForPropeller()
        {
            return (Royal.Scenes.Game.Mechanics.Items.Config.ItemModel)this;
        }
        public bool IsUnderHoney()
        {
            var val_6;
            if(this.itemMediator.CurrentCell != null)
            {
                    if((this.itemMediator.CurrentCell.HasStaticItem(itemType:  2)) != false)
            {
                    val_6 = 1;
                return (bool)val_6;
            }
            
            }
            
            if(this.itemMediator.NextCell == null)
            {
                    return (bool)val_6;
            }
            
            return this.itemMediator.NextCell.HasStaticItem(itemType:  2);
        }
        public bool IsUnderCurtain()
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_1 = this.itemMediator.CurrentCell;
            if(val_1 == null)
            {
                    return (bool)val_1;
            }
            
            return this.itemMediator.CurrentCell.HasStaticItem(itemType:  3);
        }
        public bool IsUnderChain()
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_1 = this.itemMediator.CurrentCell;
            if(val_1 == null)
            {
                    return (bool)val_1;
            }
            
            return this.itemMediator.CurrentCell.HasStaticItem(itemType:  4);
        }
        public bool IsUnderOneLayeredChain()
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_1 = this.itemMediator.CurrentCell;
            if(val_1 == null)
            {
                    return (bool)(val_2.layer == 1) ? 1 : 0;
            }
            
            if(val_1 == null)
            {
                    return (bool)(val_2.layer == 1) ? 1 : 0;
            }
            
            if((val_1.GetStaticItem(itemType:  4)) == null)
            {
                    return (bool)(val_2.layer == 1) ? 1 : 0;
            }
            
            return (bool)(val_2.layer == 1) ? 1 : 0;
        }
    
    }

}
