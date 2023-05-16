using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.FrogItem.View
{
    public class FrogItemView : ItemView
    {
        // Fields
        private static readonly int FrogDefault;
        private static readonly int FrogIdleWink;
        private static readonly int FrogIdleLookDown;
        private static readonly int FrogJumpStart;
        private static readonly int FrogJumpStart2;
        private static readonly int FrogJumpStartFast;
        private static readonly int FrogJumpEnd;
        private static readonly int FrogJumpEnd2;
        private static readonly int FrogFallStart;
        private static readonly int FrogFallEndCollect;
        private static readonly int FrogFallEnd;
        private static readonly int FrogFallAfter;
        private static readonly int FrogJumpReference;
        private static readonly int FrogJumpReference2;
        private static readonly int FrogReaction;
        public UnityEngine.Animator frogAnimator;
        public Spine.Unity.SkeletonMecanim skeletonMecanim;
        public UnityEngine.SpriteRenderer jumpShadowView;
        private Royal.Scenes.Game.Mechanics.Items.FrogItem.View.IFrogItemViewDelegate viewDelegate;
        private Royal.Scenes.Game.Mechanics.Items.FrogItem.FrogItemHelper frogItemHelper;
        private Royal.Scenes.Game.Levels.Units.MoveManager moveManager;
        private Royal.Scenes.Game.Mechanics.Matches.MatchManager matchManager;
        private Royal.Scenes.Game.Levels.Units.Combo.ComboManager comboManager;
        private Royal.Scenes.Game.Levels.Units.CellGridManager gridManager;
        private Royal.Scenes.Game.Levels.Units.Touch.LevelTouchManager levelTouchManager;
        private Royal.Scenes.Game.Levels.Units.State.GameStateManager gameStateManager;
        private Royal.Scenes.Game.Levels.Units.Touch.FrogSwapAction frogSwapAction;
        public int autoSwapCounter;
        public UnityEngine.AnimationCurve frogScaleCurve;
        private UnityEngine.Coroutine waitForAutoSwapCoroutine;
        private int runningLightballCounter;
        private bool isStartedCollecting;
        private bool isBeingVerticallyValidSwapped;
        private bool isFalling;
        private bool isReverseSorted;
        private int fallBlockingStaticItemCounter;
        private bool fallEndCollectAnimationStarted;
        private float nextIdleTime;
        private const float CollectDuration = 0.7;
        private const int CollectSortingMax = 1000;
        public static float yOffset;
        
        // Methods
        public void Init(Royal.Scenes.Game.Mechanics.Items.FrogItem.View.IFrogItemViewDelegate viewDelegate, UnityEngine.Vector3 position)
        {
            this.viewDelegate = viewDelegate;
            this.isReverseSorted = true;
            this.InitTransform(viewDelegate:  viewDelegate, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
            this.frogItemHelper = Royal.Scenes.Game.Levels.LevelContext.GetLate<Royal.Scenes.Game.Mechanics.Items.FrogItem.FrogItemHelper>(contextId:  34);
            this.moveManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.MoveManager>(contextId:  10);
            this.matchManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Mechanics.Matches.MatchManager>(contextId:  4);
            this.comboManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.Combo.ComboManager>(contextId:  13);
            this.gridManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.CellGridManager>(contextId:  2);
            this.levelTouchManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.Touch.LevelTouchManager>(contextId:  3);
            this.gameStateManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14);
            this.jumpShadowView.enabled = false;
            this.frogAnimator.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.FrogItem.View.FrogItemView.CollectSortingMax, layer:  0, normalizedTime:  0f);
            this.fallEndCollectAnimationStarted = false;
            this.fallBlockingStaticItemCounter = 0;
            this.isFalling = false;
            this.isStartedCollecting = false;
            this.isBeingVerticallyValidSwapped = false;
            this.runningLightballCounter = 0;
            float val_9 = UnityEngine.Random.value;
            float val_17 = 1f;
            val_9 = val_9 + val_9;
            val_17 = Royal.Scenes.Game.Levels.LevelContext.Time + val_17;
            val_9 = val_17 + val_9;
            this.nextIdleTime = val_9;
            this.moveManager.add_OnMoveCompleted(value:  new System.Action<Royal.Scenes.Game.Levels.Units.Touch.MoveType>(object:  this, method:  System.Void Royal.Scenes.Game.Mechanics.Items.FrogItem.View.FrogItemView::OnMoveCompleted(Royal.Scenes.Game.Levels.Units.Touch.MoveType moveType)));
            this.levelTouchManager.add_OnSwap(value:  new System.Action<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel, System.Boolean>(object:  this, method:  System.Void Royal.Scenes.Game.Mechanics.Items.FrogItem.View.FrogItemView::OnSwap(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel from, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel to, bool isValid)));
            this.frogSwapAction = new Royal.Scenes.Game.Levels.Units.Touch.FrogSwapAction(matchManager:  this.matchManager, comboManager:  this.comboManager, moveManager:  this.moveManager, levelTouchManager:  this.levelTouchManager);
            this.autoSwapCounter = 0;
            var val_18 = 0;
            if(mem[1152921505101344768] != null)
            {
                    val_18 = val_18 + 1;
            }
            else
            {
                    var val_19 = mem[1152921505101344776];
                val_19 = val_19 + 6;
                Royal.Scenes.Game.Mechanics.Items.FrogItem.View.IFrogItemViewDelegate val_13 = 1152921505101307904 + val_19;
            }
            
            if(viewDelegate.IsUnderChain() != false)
            {
                    int val_20 = this.fallBlockingStaticItemCounter;
                val_20 = val_20 + 1;
                this.fallBlockingStaticItemCounter = val_20;
            }
            
            var val_21 = 0;
            if(mem[1152921505101344768] != null)
            {
                    val_21 = val_21 + 1;
            }
            else
            {
                    var val_22 = mem[1152921505101344776];
                val_22 = val_22 + 5;
                Royal.Scenes.Game.Mechanics.Items.FrogItem.View.IFrogItemViewDelegate val_15 = 1152921505101307904 + val_22;
            }
            
            if(viewDelegate.IsUnderCurtain() == false)
            {
                    return;
            }
            
            int val_23 = this.fallBlockingStaticItemCounter;
            val_23 = val_23 + 1;
            this.fallBlockingStaticItemCounter = val_23;
        }
        private void Update()
        {
            int val_2;
            float val_3;
            int val_4;
            var val_18;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            if(this.isStartedCollecting == true)
            {
                    return;
            }
            
            if(this.isStartedCollecting != false)
            {
                    return;
            }
            
            if(this.isFalling == false)
            {
                goto label_3;
            }
            
            if(this.isReverseSorted == false)
            {
                    return;
            }
            
            var val_23 = 0;
            if(mem[1152921505101344768] == null)
            {
                goto label_7;
            }
            
            val_23 = val_23 + 1;
            goto label_9;
            label_3:
            UnityEngine.AnimatorStateInfo val_1 = this.frogAnimator.GetCurrentAnimatorStateInfo(layerIndex:  0);
            if(this.isReverseSorted == true)
            {
                goto label_41;
            }
            
            val_18 = null;
            val_18 = null;
            if(( != Royal.Scenes.Game.Mechanics.Items.FrogItem.View.FrogItemView.FrogFallEnd) || (val_3 < 0.3f))
            {
                goto label_41;
            }
            
            var val_24 = 0;
            if(mem[1152921505101344768] == null)
            {
                goto label_18;
            }
            
            val_24 = val_24 + 1;
            goto label_20;
            label_7:
            var val_25 = mem[1152921505101344776];
            val_25 = val_25 + 3;
            Royal.Scenes.Game.Mechanics.Items.FrogItem.View.IFrogItemViewDelegate val_5 = 1152921505101307904 + val_25;
            label_9:
            var val_26 = 0;
            if(mem[1152921505101344768] != null)
            {
                    val_26 = val_26 + 1;
            }
            else
            {
                    var val_27 = mem[1152921505101344776];
                val_27 = val_27 + 4;
                Royal.Scenes.Game.Mechanics.Items.FrogItem.View.IFrogItemViewDelegate val_7 = 1152921505101307904 + val_27;
            }
            
            if((this.viewDelegate.HasCurrentCellAboveItem() | this.viewDelegate.HasNextCellAboveItem()) == false)
            {
                    return;
            }
            
            this.isReverseSorted = false;
            var val_28 = 0;
            if(mem[1152921505101344768] != null)
            {
                    val_28 = val_28 + 1;
            }
            else
            {
                    var val_29 = mem[1152921505101344776];
                val_29 = val_29 + 3;
                Royal.Scenes.Game.Mechanics.Items.FrogItem.View.IFrogItemViewDelegate val_10 = 1152921505101307904 + val_29;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_11 = this.viewDelegate.CurrentCell;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_12 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetItemSorting(row:  this.viewDelegate, isReverseSort:  false);
            bool val_13 = val_12.sortEverything & 4294967295;
            return;
            label_18:
            var val_30 = mem[1152921505101344776];
            val_30 = val_30 + 3;
            Royal.Scenes.Game.Mechanics.Items.FrogItem.View.IFrogItemViewDelegate val_14 = 1152921505101307904 + val_30;
            label_20:
            var val_31 = 0;
            if(mem[1152921505101344768] != null)
            {
                    val_31 = val_31 + 1;
            }
            else
            {
                    var val_32 = mem[1152921505101344776];
                val_32 = val_32 + 4;
                Royal.Scenes.Game.Mechanics.Items.FrogItem.View.IFrogItemViewDelegate val_16 = 1152921505101307904 + val_32;
            }
            
            if((this.viewDelegate.HasCurrentCellAboveItem() | this.viewDelegate.HasNextCellAboveItem()) != true)
            {
                    this.isReverseSorted = true;
                var val_33 = 0;
                if(mem[1152921505101344768] != null)
            {
                    val_33 = val_33 + 1;
            }
            else
            {
                    var val_34 = mem[1152921505101344776];
                val_34 = val_34 + 3;
                Royal.Scenes.Game.Mechanics.Items.FrogItem.View.IFrogItemViewDelegate val_19 = 1152921505101307904 + val_34;
            }
            
                Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_20 = this.viewDelegate.CurrentCell;
                Royal.Scenes.Game.Mechanics.Sortings.SortingData val_21 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetItemSorting(row:  this.viewDelegate, isReverseSort:  false);
                bool val_22 = val_21.sortEverything & 4294967295;
            }
            
            label_41:
            if(val_3 < 1f)
            {
                    return;
            }
            
            val_24 = null;
            val_24 = null;
            if( != Royal.Scenes.Game.Mechanics.Items.FrogItem.View.FrogItemView.FrogFallEnd)
            {
                    val_25 = null;
                val_25 = null;
                if( != Royal.Scenes.Game.Mechanics.Items.FrogItem.View.FrogItemView.FrogIdleWink)
            {
                    val_26 = null;
                val_26 = null;
                if( != Royal.Scenes.Game.Mechanics.Items.FrogItem.View.FrogItemView.FrogIdleLookDown)
            {
                    val_27 = null;
                val_27 = null;
                if( != Royal.Scenes.Game.Mechanics.Items.FrogItem.View.FrogItemView.CollectSortingMax)
            {
                    val_28 = null;
                val_28 = null;
                if( != Royal.Scenes.Game.Mechanics.Items.FrogItem.View.FrogItemView.FrogJumpEnd)
            {
                    val_29 = null;
                val_29 = null;
                if( != Royal.Scenes.Game.Mechanics.Items.FrogItem.View.FrogItemView.FrogJumpEnd2)
            {
                    val_30 = null;
                val_30 = null;
                if( != Royal.Scenes.Game.Mechanics.Items.FrogItem.View.FrogItemView.FrogReaction)
            {
                    return;
            }
            
            }
            
            }
            
            }
            
            }
            
            }
            
            }
            
            this.PickRandomIdleAnimation(state:  new UnityEngine.AnimatorStateInfo() {m_Name = val_4, m_Path = val_4, m_FullPath = val_4, m_NormalizedTime = val_4, m_Length = val_3, m_Speed = val_3, m_SpeedMultiplier = val_3, m_Tag = val_3, m_Loop = val_2});
        }
        public override int GetPoolId()
        {
            return 111;
        }
        public override void OnSpawn()
        {
        
        }
        public override void OnRecycle()
        {
            this.moveManager.remove_OnMoveCompleted(value:  new System.Action<Royal.Scenes.Game.Levels.Units.Touch.MoveType>(object:  this, method:  System.Void Royal.Scenes.Game.Mechanics.Items.FrogItem.View.FrogItemView::OnMoveCompleted(Royal.Scenes.Game.Levels.Units.Touch.MoveType moveType)));
            this.levelTouchManager.remove_OnSwap(value:  new System.Action<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel, System.Boolean>(object:  this, method:  System.Void Royal.Scenes.Game.Mechanics.Items.FrogItem.View.FrogItemView::OnSwap(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel from, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel to, bool isValid)));
            this.frogItemHelper = 0;
            this.autoSwapCounter = 0;
            if(this.waitForAutoSwapCoroutine == null)
            {
                    return;
            }
            
            this.StopCoroutine(routine:  this.waitForAutoSwapCoroutine);
            this.waitForAutoSwapCoroutine = 0;
        }
        public void AutoSwapStarted(System.Action onFrogReadyToJump)
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.PlayJumpAnimations(onFrogReadyToJump:  onFrogReadyToJump));
        }
        private System.Collections.IEnumerator PlayJumpAnimations(System.Action onFrogReadyToJump)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .onFrogReadyToJump = onFrogReadyToJump;
            return (System.Collections.IEnumerator)new FrogItemView.<PlayJumpAnimations>d__44();
        }
        public override void SwapAnimationStarted(bool isValid = True, Royal.Scenes.Game.Mechanics.Items.Config.ItemType otherItem = 0)
        {
            var val_23;
            var val_24;
            int val_25;
            var val_26;
            Royal.Scenes.Game.Mechanics.Items.FrogItem.View.IFrogItemViewDelegate val_29;
            var val_31;
            var val_33;
            val_23 = this;
            isValid = isValid;
            this.SwapAnimationStarted(isValid:  isValid, otherItem:  otherItem);
            val_24 = null;
            val_24 = null;
            val_25 = Royal.Scenes.Game.Mechanics.Items.FrogItem.View.FrogItemView.FrogReaction;
            this.frogAnimator.CrossFade(stateHashName:  val_25, normalizedTransitionDuration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  3f));
            var val_25 = 0;
            val_26 = 1152921505101344776;
            if(mem[1152921505101344768] != null)
            {
                    val_25 = val_25 + 1;
                val_26 = 1152921505101344792;
            }
            else
            {
                    var val_26 = mem[1152921505101344776];
                val_26 = val_26 + 3;
                Royal.Scenes.Game.Mechanics.Items.FrogItem.View.IFrogItemViewDelegate val_2 = 1152921505101307904 + val_26;
            }
            
            if(this.isReverseSorted == false)
            {
                    return;
            }
            
            if(this.viewDelegate.HasCurrentCellAboveItem() == false)
            {
                goto label_12;
            }
            
            this.isReverseSorted = false;
            var val_27 = 0;
            val_26 = 1152921505101344776;
            if(mem[1152921505101344768] == null)
            {
                goto label_15;
            }
            
            val_27 = val_27 + 1;
            val_26 = 1152921505101344792;
            goto label_17;
            label_12:
            val_29 = this.viewDelegate;
            val_25 = 1152921505105674240;
            val_31 = null;
            var val_28 = 0;
            val_26 = 1152921505101344776;
            if(mem[1152921505101344768] == val_31)
            {
                goto label_20;
            }
            
            val_28 = val_28 + 1;
            goto label_22;
            label_15:
            var val_29 = mem[1152921505101344776];
            val_29 = val_29 + 3;
            Royal.Scenes.Game.Mechanics.Items.FrogItem.View.IFrogItemViewDelegate val_4 = 1152921505101307904 + val_29;
            label_17:
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_5 = this.viewDelegate.CurrentCell;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_6 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetItemSorting(row:  this.viewDelegate, isReverseSort:  false);
            bool val_7 = val_6.sortEverything & 4294967295;
            val_31 = val_6.layer;
            val_29 = ???;
            val_23 = ???;
            val_25 = ???;
            goto typeof(Royal.Scenes.Game.Mechanics.Items.FrogItem.View.FrogItemView).__il2cppRuntimeField_1F0;
            label_20:
            var val_30 = mem[1152921505101344776];
            val_30 = val_30 + 3;
            Royal.Scenes.Game.Mechanics.Items.FrogItem.View.FrogItemView val_8 = 1152921505101094912 + val_30;
            label_22:
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_9 = val_29.CurrentCell;
            if(val_9 == null)
            {
                    return;
            }
            
            if(val_9 == null)
            {
                    return;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_10 = val_9.Get(type:  5);
            if(val_10 == null)
            {
                    return;
            }
            
            if(val_10.HasTouchBlockingItem() == true)
            {
                    return;
            }
            
            var val_34 = val_23 + 112;
            if((val_23 + 112 + 294) == 0)
            {
                goto label_35;
            }
            
            var val_31 = val_23 + 112 + 176;
            var val_32 = 0;
            val_31 = val_31 + 8;
            label_34:
            if(((val_23 + 112 + 176 + 8) + -8) == val_25)
            {
                goto label_33;
            }
            
            val_32 = val_32 + 1;
            val_31 = val_31 + 16;
            if(val_32 < (val_23 + 112 + 294))
            {
                goto label_34;
            }
            
            goto label_35;
            label_33:
            var val_33 = val_31;
            val_33 = val_33 + 3;
            val_34 = val_34 + val_33;
            val_33 = val_34 + 304;
            label_35:
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_12 = val_23 + 112 + 40.Get(type:  1);
            if(val_12 == null)
            {
                    return;
            }
            
            if(val_12.HasSpecialItem() == false)
            {
                    return;
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_14 = val_12.CurrentItem;
            if(val_14 == null)
            {
                    return;
            }
            
            var val_15 = (((Royal.Scenes.Game.Mechanics.Items.Config.ItemModel.__il2cppRuntimeField_typeHierarchy + (Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemModel.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_14) : 0;
        }
        public override void SwapAnimationEnded()
        {
            Royal.Scenes.Game.Mechanics.Items.FrogItem.View.IFrogItemViewDelegate val_10;
            var val_12;
            var val_13;
            this.SwapAnimationEnded();
            var val_10 = 0;
            if(mem[1152921505101344768] != null)
            {
                    val_10 = val_10 + 1;
            }
            else
            {
                    var val_11 = mem[1152921505101344776];
                val_11 = val_11 + 2;
                Royal.Scenes.Game.Mechanics.Items.FrogItem.View.IFrogItemViewDelegate val_1 = 1152921505101307904 + val_11;
            }
            
            this.viewDelegate.TryCollect();
            var val_12 = 0;
            if(mem[1152921505101344768] != null)
            {
                    val_12 = val_12 + 1;
            }
            else
            {
                    var val_13 = mem[1152921505101344776];
                val_13 = val_13 + 3;
                Royal.Scenes.Game.Mechanics.Items.FrogItem.View.IFrogItemViewDelegate val_2 = 1152921505101307904 + val_13;
            }
            
            if(this.isReverseSorted == false)
            {
                goto label_11;
            }
            
            var val_14 = 0;
            if(mem[1152921505101344768] == null)
            {
                goto label_14;
            }
            
            val_14 = val_14 + 1;
            goto label_16;
            label_11:
            if(this.viewDelegate.HasCurrentCellAboveItem() == true)
            {
                    return;
            }
            
            val_10 = this.viewDelegate;
            this.isReverseSorted = true;
            val_12 = null;
            var val_15 = 0;
            val_13 = 1152921505101344776;
            if(mem[1152921505101344768] == val_12)
            {
                goto label_26;
            }
            
            val_15 = val_15 + 1;
            goto label_28;
            label_14:
            var val_16 = mem[1152921505101344776];
            val_16 = val_16 + 3;
            Royal.Scenes.Game.Mechanics.Items.FrogItem.View.IFrogItemViewDelegate val_4 = 1152921505101307904 + val_16;
            label_16:
            if(this.viewDelegate.CurrentCell == null)
            {
                    return;
            }
            
            val_10 = this.viewDelegate;
            val_12 = null;
            var val_17 = 0;
            val_13 = 1152921505101344776;
            if(mem[1152921505101344768] == val_12)
            {
                goto label_26;
            }
            
            val_17 = val_17 + 1;
            goto label_28;
            label_26:
            var val_18 = mem[1152921505101344776];
            val_18 = val_18 + 3;
            Royal.Scenes.Game.Mechanics.Items.FrogItem.View.IFrogItemViewDelegate val_6 = 1152921505101307904 + val_18;
            label_28:
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_7 = val_10.CurrentCell;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_8 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetItemSorting(row:  val_10, isReverseSort:  false);
            bool val_9 = val_8.sortEverything & 4294967295;
            goto typeof(Royal.Scenes.Game.Mechanics.Items.FrogItem.View.FrogItemView).__il2cppRuntimeField_1F0;
        }
        public override void FallStarted()
        {
            var val_8;
            var val_9;
            this.FallStarted();
            this.isFalling = true;
            this.autoSwapCounter = 0;
            if(this.waitForAutoSwapCoroutine != null)
            {
                    this.StopCoroutine(routine:  this.waitForAutoSwapCoroutine);
                this.waitForAutoSwapCoroutine = 0;
            }
            
            UnityEngine.AnimatorStateInfo val_1 = this.frogAnimator.GetCurrentAnimatorStateInfo(layerIndex:  0);
            val_8 = null;
            val_9 = 0;
            if( == Royal.Scenes.Game.Mechanics.Items.FrogItem.View.FrogItemView.CollectSortingMax)
            {
                    this.frogAnimator.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.FrogItem.View.FrogItemView.FrogFallStart, layer:  0, normalizedTime:  0f);
                return;
            }
            
            this.frogAnimator.CrossFade(stateHashName:  Royal.Scenes.Game.Mechanics.Items.FrogItem.View.FrogItemView.FrogFallStart, normalizedTransitionDuration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  2f));
        }
        public override void FallEnded()
        {
            UnityEngine.Animator val_4;
            int val_5;
            this.isFalling = false;
            var val_4 = 0;
            if(mem[1152921505101344768] != null)
            {
                    val_4 = val_4 + 1;
            }
            else
            {
                    var val_5 = mem[1152921505101344776];
                val_5 = val_5 + 3;
                Royal.Scenes.Game.Mechanics.Items.FrogItem.View.IFrogItemViewDelegate val_1 = 1152921505101307904 + val_5;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_2 = this.viewDelegate.CurrentCell;
            if((public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel Royal.Scenes.Game.Mechanics.Items.Config.IItemViewDelegate::get_CurrentCell()) != 0)
            {
                    this.fallEndCollectAnimationStarted = true;
                val_4 = this.frogAnimator;
                val_5 = Royal.Scenes.Game.Mechanics.Items.FrogItem.View.FrogItemView.FrogFallEndCollect;
            }
            else
            {
                    val_4 = this.frogAnimator;
                val_5 = Royal.Scenes.Game.Mechanics.Items.FrogItem.View.FrogItemView.FrogFallEnd;
            }
            
            val_4.Play(stateNameHash:  val_5, layer:  0, normalizedTime:  0f);
            this.nextIdleTime = -1f;
            var val_6 = 0;
            if(mem[1152921505101344768] != null)
            {
                    val_6 = val_6 + 1;
            }
            else
            {
                    var val_7 = mem[1152921505101344776];
                val_7 = val_7 + 2;
                Royal.Scenes.Game.Mechanics.Items.FrogItem.View.IFrogItemViewDelegate val_3 = 1152921505101307904 + val_7;
            }
            
            this.viewDelegate.TryCollect();
        }
        public override bool IsReverseSorted()
        {
            if(this.isReverseSorted == false)
            {
                    return false;
            }
            
            return (bool)(this.isReverseSorted == false) ? 1 : 0;
        }
        public void PlayCollectAnimation()
        {
            this.isStartedCollecting = true;
            var val_9 = 0;
            if(mem[1152921505101344768] != null)
            {
                    val_9 = val_9 + 1;
            }
            else
            {
                    var val_10 = mem[1152921505101344776];
                val_10 = val_10 + 3;
                Royal.Scenes.Game.Mechanics.Items.FrogItem.View.IFrogItemViewDelegate val_1 = 1152921505101307904 + val_10;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_2 = this.viewDelegate.CurrentCell;
            this.frogItemHelper.WillCollectAtColumn(column:  -46104560);
            var val_11 = 0;
            if(mem[1152921505101344768] != null)
            {
                    val_11 = val_11 + 1;
            }
            else
            {
                    Royal.Scenes.Game.Mechanics.Items.FrogItem.View.IFrogItemViewDelegate val_3 = 1152921505101307904 + ((mem[1152921505101344776]) << 4);
            }
            
            UnityEngine.Vector3 val_4 = this.viewDelegate.GetGoalPosition();
            var val_12 = 0;
            if(mem[1152921505101344768] != null)
            {
                    val_12 = val_12 + 1;
            }
            else
            {
                    var val_13 = mem[1152921505101344776];
                val_13 = val_13 + 3;
                Royal.Scenes.Game.Mechanics.Items.FrogItem.View.IFrogItemViewDelegate val_5 = 1152921505101307904 + val_13;
            }
            
            UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  this.CollectToGoalAnimation(goalPosition:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, currentCell:  this.viewDelegate.CurrentCell));
        }
        private System.Collections.IEnumerator CollectToGoalAnimation(UnityEngine.Vector3 goalPosition, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel currentCell)
        {
            .<>1__state = 0;
            .currentCell = currentCell;
            .<>4__this = this;
            .goalPosition = goalPosition;
            mem[1152921520315661188] = goalPosition.y;
            mem[1152921520315661192] = goalPosition.z;
            return (System.Collections.IEnumerator)new FrogItemView.<CollectToGoalAnimation>d__54();
        }
        private void StartSwapDelayed(float delay)
        {
            this.autoSwapCounter = this.autoSwapCounter + 1;
            if(this.autoSwapCounter != 0)
            {
                    return;
            }
            
            if(this.waitForAutoSwapCoroutine != null)
            {
                    this.StopCoroutine(routine:  this.waitForAutoSwapCoroutine);
                this.waitForAutoSwapCoroutine = 0;
            }
            
            this.waitForAutoSwapCoroutine = this.StartCoroutine(routine:  this.StartSwapCoroutine(delay:  delay));
        }
        private bool WillFall()
        {
            Royal.Scenes.Game.Mechanics.Items.FrogItem.View.IFrogItemViewDelegate val_13;
            var val_15;
            var val_16;
            val_13 = this.viewDelegate;
            var val_14 = 0;
            if(mem[1152921505101344768] != null)
            {
                    val_14 = val_14 + 1;
            }
            else
            {
                    var val_15 = mem[1152921505101344776];
                val_15 = val_15 + 3;
                Royal.Scenes.Game.Mechanics.Items.FrogItem.View.IFrogItemViewDelegate val_1 = 1152921505101307904 + val_15;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_3 = val_13.CurrentCell.Get(type:  5);
            if(val_3 == null)
            {
                    return (bool)val_15;
            }
            
            val_13 = val_3;
            bool val_4 = val_3.IsSwappableEmptyCell();
            if(val_4 == true)
            {
                goto label_17;
            }
            
            label_22:
            if(val_4.HasFallBlockingItem() == true)
            {
                goto label_20;
            }
            
            if(val_13.IsNormalCell() == false)
            {
                goto label_12;
            }
            
            if(val_13.CurrentItem == null)
            {
                goto label_13;
            }
            
            val_16 = (~val_13.CurrentItem) & 1;
            goto label_16;
            label_12:
            val_16 = 0;
            goto label_16;
            label_13:
            val_16 = 1;
            label_16:
            val_16 = val_16 | val_13.WillBeFreed();
            if(val_16 == true)
            {
                goto label_17;
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_11 = val_13.CurrentItem;
            var val_12 = (val_11 == 0) ? 0 : (val_11);
            if(val_11 != null)
            {
                    if((val_12 & 1) == 0)
            {
                goto label_20;
            }
            
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_13 = val_12.Get(type:  5);
            val_13 = val_13;
            if(val_13 != null)
            {
                goto label_22;
            }
            
            return (bool)val_15;
            label_17:
            val_15 = 1;
            return (bool)val_15;
            label_20:
            val_15 = 0;
            return (bool)val_15;
        }
        private void OnMoveCompleted(Royal.Scenes.Game.Levels.Units.Touch.MoveType moveType)
        {
            int val_5;
            var val_5 = 0;
            if(mem[1152921505101344768] != null)
            {
                    val_5 = val_5 + 1;
            }
            else
            {
                    var val_6 = mem[1152921505101344776];
                val_6 = val_6 + 3;
                Royal.Scenes.Game.Mechanics.Items.FrogItem.View.IFrogItemViewDelegate val_1 = 1152921505101307904 + val_6;
            }
            
            if(this.viewDelegate.CurrentCell == null)
            {
                    return;
            }
            
            bool val_3 = Royal.Scenes.Game.Levels.Units.Touch.MoveTypeExtensions.IsFrogMove(moveType:  moveType);
            if(val_3 == false)
            {
                    return;
            }
            
            if(this.fallBlockingStaticItemCounter > 0)
            {
                    return;
            }
            
            if(moveType > 9)
            {
                goto label_12;
            }
            
            var val_7 = 1;
            val_7 = val_7 << moveType;
            if(val_7 != 680)
            {
                goto label_10;
            }
            
            if(val_7 != 68)
            {
                goto label_11;
            }
            
            var val_8 = 1;
            val_8 = val_8 << moveType;
            if((val_8 & 272) == 0)
            {
                    int val_9 = this.runningLightballCounter;
                val_9 = val_9 + 1;
                this.runningLightballCounter = val_9;
            }
            
            label_12:
            if(this.isBeingVerticallyValidSwapped == false)
            {
                goto label_13;
            }
            
            this.isBeingVerticallyValidSwapped = false;
            return;
            label_10:
            val_5 = this.runningLightballCounter - 1;
            goto label_15;
            label_11:
            val_5 = this.runningLightballCounter + 1;
            label_15:
            this.runningLightballCounter = val_5;
            return;
            label_13:
            this.StartSwapDelayed(delay:  val_3.GetDelayByMoveType(moveType:  moveType));
        }
        private void OnSwap(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel from, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel to, bool isValid)
        {
            var val_7;
            var val_8;
            var val_10;
            var val_11;
            if(from == null)
            {
                    return;
            }
            
            if(to == null)
            {
                    return;
            }
            
            if(isValid == false)
            {
                    return;
            }
            
            var val_8 = 0;
            if(mem[1152921505101344768] != null)
            {
                    val_8 = val_8 + 1;
                val_8 = 3;
            }
            else
            {
                    var val_9 = mem[1152921505101344776];
                val_9 = val_9 + 3;
                Royal.Scenes.Game.Mechanics.Items.FrogItem.View.IFrogItemViewDelegate val_1 = 1152921505101307904 + val_9;
            }
            
            if(this.viewDelegate.CurrentCell != null)
            {
                    val_8 = public System.Void System.Nullable<Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint>::.ctor(Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint value);
            }
            
            val_7 = true;
            val_10 = public System.Boolean System.ValueType::Equals(object obj);
            true.System.IDisposable.Dispose();
            if((true.Equals(obj:  0)) != false)
            {
                    val_11 = 1;
            }
            else
            {
                    var val_10 = 0;
                if(mem[1152921505101344768] != null)
            {
                    val_10 = val_10 + 1;
                val_10 = 3;
            }
            else
            {
                    var val_11 = mem[1152921505101344776];
                val_11 = val_11 + 3;
                Royal.Scenes.Game.Mechanics.Items.FrogItem.View.IFrogItemViewDelegate val_4 = 1152921505101307904 + val_11;
            }
            
                if(this.viewDelegate.CurrentCell != null)
            {
                    val_10 = public System.Void System.Nullable<Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint>::.ctor(Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint value);
            }
            
                val_7 = null;
                null.System.IDisposable.Dispose();
                val_11 = null.Equals(obj:  0);
            }
            
            if((val_11 & (((public System.Boolean System.ValueType::Equals(object obj)) != val_10) ? 1 : 0)) != 0)
            {
                    return;
            }
            
            this.isBeingVerticallyValidSwapped = true;
        }
        private float GetDelayByMoveType(Royal.Scenes.Game.Levels.Units.Touch.MoveType moveType)
        {
            if((moveType - 10) >= 5)
            {
                    return Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  3f);
            }
            
            return (float)36597376 + ((moveType - 10)) << 2;
        }
        private bool CanNotAutoSwap()
        {
            if(this.isStartedCollecting != false)
            {
                    return true;
            }
            
            var val_4 = 0;
            if(mem[1152921505101344768] != null)
            {
                    val_4 = val_4 + 1;
            }
            else
            {
                    var val_5 = mem[1152921505101344776];
                val_5 = val_5 + 3;
                Royal.Scenes.Game.Mechanics.Items.FrogItem.View.IFrogItemViewDelegate val_1 = 1152921505101307904 + val_5;
            }
            
            if(this.viewDelegate.CurrentCell == null)
            {
                    return true;
            }
            
            if(this.isFalling == true)
            {
                    return true;
            }
            
            if(this.WillFall() == true)
            {
                    return true;
            }
            
            return this.IsTopItemFrog();
        }
        private bool IsTopItemFrog()
        {
            var val_6;
            var val_6 = 0;
            if(mem[1152921505101344768] != null)
            {
                    val_6 = val_6 + 1;
            }
            else
            {
                    var val_7 = mem[1152921505101344776];
                val_7 = val_7 + 3;
                Royal.Scenes.Game.Mechanics.Items.FrogItem.View.IFrogItemViewDelegate val_1 = 1152921505101307904 + val_7;
            }
            
            val_6 = this.viewDelegate;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_2 = val_6.CurrentCell;
            if(val_2 == null)
            {
                    return (bool);
            }
            
            if(val_2 == null)
            {
                    return (bool);
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_3 = val_2.Get(type:  1);
            if(val_3 == null)
            {
                    return (bool);
            }
            
            if(val_3.CurrentItem == null)
            {
                    return (bool);
            }
            
            val_6 = 0;
            return (bool);
        }
        private System.Collections.IEnumerator StartSwapCoroutine(float delay)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .delay = delay;
            return (System.Collections.IEnumerator)new FrogItemView.<StartSwapCoroutine>d__62();
        }
        private void TryNextAutoSwap()
        {
            UnityEngine.Coroutine val_3;
            if(this.autoSwapCounter >= 1)
            {
                    UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.StartSwapCoroutine(delay:  0.1f));
            }
            else
            {
                    val_3 = 0;
                this.autoSwapCounter = 0;
            }
            
            this.waitForAutoSwapCoroutine = val_3;
        }
        public override void EnableFillMask()
        {
            this.EnableFillMask();
            this.skeletonMecanim = 2;
        }
        public override void DisableFillMask()
        {
            this.DisableFillMask();
            this.skeletonMecanim = 0;
        }
        private void PickRandomIdleAnimation(UnityEngine.AnimatorStateInfo state)
        {
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            var val_10;
            int val_12;
            var val_14;
            if(this.nextIdleTime >= 0)
            {
                goto label_10;
            }
            
            val_5 = 1152921520317279744;
            val_6 = null;
            val_6 = null;
            if(val_5 == Royal.Scenes.Game.Mechanics.Items.FrogItem.View.FrogItemView.FrogIdleWink)
            {
                goto label_7;
            }
            
            val_7 = null;
            val_5 = 1152921520317279744;
            val_7 = null;
            if(val_5 == Royal.Scenes.Game.Mechanics.Items.FrogItem.View.FrogItemView.FrogIdleLookDown)
            {
                goto label_7;
            }
            
            val_8 = null;
            val_5 = 1152921520317279744;
            val_8 = null;
            if(val_5 != Royal.Scenes.Game.Mechanics.Items.FrogItem.View.FrogItemView.FrogFallEnd)
            {
                goto label_10;
            }
            
            label_7:
            float val_2 = UnityEngine.Random.value;
            float val_5 = 1.5f;
            val_5 = Royal.Scenes.Game.Levels.LevelContext.Time + val_5;
            val_2 = val_5 + val_2;
            this.nextIdleTime = val_2;
            return;
            label_10:
            if(Royal.Scenes.Game.Levels.LevelContext.Time < 0)
            {
                    return;
            }
            
            this.nextIdleTime = -1f;
            val_10 = null;
            val_10 = null;
            if(this.isReverseSorted == false)
            {
                goto label_23;
            }
            
            if(this.isReverseSorted == false)
            {
                goto label_16;
            }
            
            goto label_19;
            label_16:
            val_10 = null;
            if(UnityEngine.Random.value <= 0.6f)
            {
                goto label_20;
            }
            
            val_10 = null;
            val_12 = 1152921505101099016;
            goto label_23;
            label_20:
            label_19:
            val_10 = null;
            val_12 = 1152921505101099012;
            label_23:
            val_10 = null;
            if(val_12 == Royal.Scenes.Game.Mechanics.Items.FrogItem.View.FrogItemView.CollectSortingMax)
            {
                    val_14 = null;
                val_14 = null;
                if(1152921520317279744 == Royal.Scenes.Game.Mechanics.Items.FrogItem.View.FrogItemView.CollectSortingMax)
            {
                    return;
            }
            
            }
            
            this.frogAnimator.Play(stateNameHash:  val_12, layer:  0, normalizedTime:  0f);
        }
        public void PlayReactionAnimation()
        {
            var val_2;
            if(this.isFalling == true)
            {
                    return;
            }
            
            if(this.isStartedCollecting != false)
            {
                    return;
            }
            
            val_2 = null;
            val_2 = null;
            this.frogAnimator.CrossFade(stateHashName:  Royal.Scenes.Game.Mechanics.Items.FrogItem.View.FrogItemView.FrogReaction, normalizedTransitionDuration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  3f));
        }
        public void SetIsReverseSorted()
        {
            this.isReverseSorted = true;
        }
        public void RevealFromCurtain()
        {
            this.Invoke(methodName:  "DecrementFallBlockingStaticItem", time:  0.5f);
        }
        public void RevealFromChain()
        {
            this.Invoke(methodName:  "DecrementFallBlockingStaticItem", time:  0.5f);
        }
        private void DecrementFallBlockingStaticItem()
        {
            int val_1 = this.fallBlockingStaticItemCounter;
            val_1 = val_1 - 1;
            this.fallBlockingStaticItemCounter = val_1;
        }
        public FrogItemView()
        {
        
        }
        private static FrogItemView()
        {
            Royal.Scenes.Game.Mechanics.Items.FrogItem.View.FrogItemView.CollectSortingMax = UnityEngine.Animator.StringToHash(name:  "Base Layer.Default");
            Royal.Scenes.Game.Mechanics.Items.FrogItem.View.FrogItemView.FrogIdleWink = UnityEngine.Animator.StringToHash(name:  "Base Layer.IdleWink");
            Royal.Scenes.Game.Mechanics.Items.FrogItem.View.FrogItemView.FrogIdleLookDown = UnityEngine.Animator.StringToHash(name:  "Base Layer.IdleLookDown");
            Royal.Scenes.Game.Mechanics.Items.FrogItem.View.FrogItemView.FrogJumpStart = UnityEngine.Animator.StringToHash(name:  "Base Layer.JumpStart");
            Royal.Scenes.Game.Mechanics.Items.FrogItem.View.FrogItemView.FrogJumpStart2 = UnityEngine.Animator.StringToHash(name:  "Base Layer.JumpStart2");
            Royal.Scenes.Game.Mechanics.Items.FrogItem.View.FrogItemView.FrogJumpStartFast = UnityEngine.Animator.StringToHash(name:  "Base Layer.JumpStartFast");
            Royal.Scenes.Game.Mechanics.Items.FrogItem.View.FrogItemView.FrogJumpEnd = UnityEngine.Animator.StringToHash(name:  "Base Layer.JumpEnd");
            Royal.Scenes.Game.Mechanics.Items.FrogItem.View.FrogItemView.FrogJumpEnd2 = UnityEngine.Animator.StringToHash(name:  "Base Layer.JumpEnd2");
            Royal.Scenes.Game.Mechanics.Items.FrogItem.View.FrogItemView.FrogFallStart = UnityEngine.Animator.StringToHash(name:  "Base Layer.FallStart");
            Royal.Scenes.Game.Mechanics.Items.FrogItem.View.FrogItemView.FrogFallEndCollect = UnityEngine.Animator.StringToHash(name:  "Base Layer.FallEndCollect");
            Royal.Scenes.Game.Mechanics.Items.FrogItem.View.FrogItemView.FrogFallEnd = UnityEngine.Animator.StringToHash(name:  "Base Layer.FallEnd");
            Royal.Scenes.Game.Mechanics.Items.FrogItem.View.FrogItemView.FrogFallAfter = UnityEngine.Animator.StringToHash(name:  "Base Layer.FallAfter");
            Royal.Scenes.Game.Mechanics.Items.FrogItem.View.FrogItemView.FrogJumpReference = UnityEngine.Animator.StringToHash(name:  "Base Layer.JumpReference");
            Royal.Scenes.Game.Mechanics.Items.FrogItem.View.FrogItemView.FrogJumpReference2 = UnityEngine.Animator.StringToHash(name:  "Base Layer.JumpReference2");
            Royal.Scenes.Game.Mechanics.Items.FrogItem.View.FrogItemView.FrogReaction = UnityEngine.Animator.StringToHash(name:  "Base Layer.Swipe");
            Royal.Scenes.Game.Mechanics.Items.FrogItem.View.FrogItemView.yOffset = 2.5f;
        }
    
    }

}
