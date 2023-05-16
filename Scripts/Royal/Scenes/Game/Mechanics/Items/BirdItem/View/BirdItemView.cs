using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.BirdItem.View
{
    public class BirdItemView : ItemView
    {
        // Fields
        private static readonly int BirdFallStart;
        private static readonly int BirdFallEnd;
        private static readonly int BirdItemDefault;
        private static readonly int BirdWink;
        private static readonly int BirdCollect;
        private static readonly int BirdReaction;
        private static readonly int BirdLookLeftAndRight;
        private Royal.Scenes.Game.Mechanics.Items.BirdItem.View.IBirdItemViewDelegate viewDelegate;
        public UnityEngine.Animator birdAnimator;
        public UnityEngine.SpriteRenderer shadowView;
        private Royal.Scenes.Game.Mechanics.Items.BirdItem.BirdItemHelper birdItemHelper;
        private bool isStartedCollecting;
        private bool isFalling;
        private bool isReverseSorted;
        private float nextIdleTime;
        private const float CollectDuration = 0.8;
        private const int CollectSortingMax = 1000;
        
        // Methods
        public void Init(Royal.Scenes.Game.Mechanics.Items.BirdItem.View.IBirdItemViewDelegate viewDelegate, UnityEngine.Vector3 position)
        {
            this.viewDelegate = viewDelegate;
            this.isReverseSorted = true;
            this.InitTransform(viewDelegate:  viewDelegate, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
            this.shadowView.enabled = false;
            this.birdAnimator.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.BirdItem.View.BirdItemView.BirdItemDefault, layer:  0, normalizedTime:  0f);
            this.birdItemHelper = Royal.Scenes.Game.Levels.LevelContext.GetLate<Royal.Scenes.Game.Mechanics.Items.BirdItem.BirdItemHelper>(contextId:  23);
            this.isStartedCollecting = false;
            float val_3 = UnityEngine.Random.value;
            float val_4 = 1f;
            val_4 = Royal.Scenes.Game.Levels.LevelContext.Time + val_4;
            val_3 = val_3 + val_3;
            val_3 = val_4 + val_3;
            this.nextIdleTime = val_3;
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
            if(this.isStartedCollecting != false)
            {
                    return;
            }
            
            if(this.isFalling == false)
            {
                goto label_2;
            }
            
            if(this.isReverseSorted == false)
            {
                    return;
            }
            
            var val_23 = 0;
            if(mem[1152921505109651456] == null)
            {
                goto label_6;
            }
            
            val_23 = val_23 + 1;
            goto label_8;
            label_2:
            UnityEngine.AnimatorStateInfo val_1 = this.birdAnimator.GetCurrentAnimatorStateInfo(layerIndex:  0);
            if(this.isReverseSorted == true)
            {
                goto label_40;
            }
            
            val_18 = null;
            val_18 = null;
            if(( != Royal.Scenes.Game.Mechanics.Items.BirdItem.View.BirdItemView.BirdFallEnd) || (val_3 < 0.3f))
            {
                goto label_40;
            }
            
            var val_24 = 0;
            if(mem[1152921505109651456] == null)
            {
                goto label_17;
            }
            
            val_24 = val_24 + 1;
            goto label_19;
            label_6:
            var val_25 = mem[1152921505109651464];
            val_25 = val_25 + 3;
            Royal.Scenes.Game.Mechanics.Items.BirdItem.View.IBirdItemViewDelegate val_5 = 1152921505109614592 + val_25;
            label_8:
            var val_26 = 0;
            if(mem[1152921505109651456] != null)
            {
                    val_26 = val_26 + 1;
            }
            else
            {
                    var val_27 = mem[1152921505109651464];
                val_27 = val_27 + 4;
                Royal.Scenes.Game.Mechanics.Items.BirdItem.View.IBirdItemViewDelegate val_7 = 1152921505109614592 + val_27;
            }
            
            if((this.viewDelegate.HasCurrentCellAboveItem() | this.viewDelegate.HasNextCellAboveItem()) == false)
            {
                    return;
            }
            
            this.isReverseSorted = false;
            var val_28 = 0;
            if(mem[1152921505109651456] != null)
            {
                    val_28 = val_28 + 1;
            }
            else
            {
                    var val_29 = mem[1152921505109651464];
                val_29 = val_29 + 3;
                Royal.Scenes.Game.Mechanics.Items.BirdItem.View.IBirdItemViewDelegate val_10 = 1152921505109614592 + val_29;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_11 = this.viewDelegate.CurrentCell;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_12 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetItemSorting(row:  this.viewDelegate, isReverseSort:  false);
            this.UpdateSorting(sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_12.layer, order = val_12.order, sortEverything = val_12.sortEverything & 4294967295});
            return;
            label_17:
            var val_30 = mem[1152921505109651464];
            val_30 = val_30 + 3;
            Royal.Scenes.Game.Mechanics.Items.BirdItem.View.IBirdItemViewDelegate val_14 = 1152921505109614592 + val_30;
            label_19:
            var val_31 = 0;
            if(mem[1152921505109651456] != null)
            {
                    val_31 = val_31 + 1;
            }
            else
            {
                    var val_32 = mem[1152921505109651464];
                val_32 = val_32 + 4;
                Royal.Scenes.Game.Mechanics.Items.BirdItem.View.IBirdItemViewDelegate val_16 = 1152921505109614592 + val_32;
            }
            
            if((this.viewDelegate.HasCurrentCellAboveItem() | this.viewDelegate.HasNextCellAboveItem()) != true)
            {
                    this.isReverseSorted = true;
                var val_33 = 0;
                if(mem[1152921505109651456] != null)
            {
                    val_33 = val_33 + 1;
            }
            else
            {
                    var val_34 = mem[1152921505109651464];
                val_34 = val_34 + 3;
                Royal.Scenes.Game.Mechanics.Items.BirdItem.View.IBirdItemViewDelegate val_19 = 1152921505109614592 + val_34;
            }
            
                Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_20 = this.viewDelegate.CurrentCell;
                Royal.Scenes.Game.Mechanics.Sortings.SortingData val_21 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetItemSorting(row:  this.viewDelegate, isReverseSort:  false);
                this.UpdateSorting(sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_21.layer, order = val_21.order, sortEverything = val_21.sortEverything & 4294967295});
            }
            
            label_40:
            if(val_3 < 1f)
            {
                    return;
            }
            
            val_24 = null;
            val_24 = null;
            if( != Royal.Scenes.Game.Mechanics.Items.BirdItem.View.BirdItemView.BirdFallEnd)
            {
                    val_25 = null;
                val_25 = null;
                if( != Royal.Scenes.Game.Mechanics.Items.BirdItem.View.BirdItemView.BirdWink)
            {
                    val_26 = null;
                val_26 = null;
                if( != Royal.Scenes.Game.Mechanics.Items.BirdItem.View.BirdItemView.BirdItemDefault)
            {
                    val_27 = null;
                val_27 = null;
                if( != Royal.Scenes.Game.Mechanics.Items.BirdItem.View.BirdItemView.BirdLookLeftAndRight)
            {
                    val_28 = null;
                val_28 = null;
                if( != Royal.Scenes.Game.Mechanics.Items.BirdItem.View.BirdItemView.BirdReaction)
            {
                    return;
            }
            
            }
            
            }
            
            }
            
            }
            
            this.PickRandomIdleAnimation(state:  new UnityEngine.AnimatorStateInfo() {m_Name = val_4, m_Path = val_4, m_FullPath = val_4, m_NormalizedTime = val_4, m_Length = val_3, m_Speed = val_3, m_SpeedMultiplier = val_3, m_Tag = val_3, m_Loop = val_2});
        }
        private void PickRandomIdleAnimation(UnityEngine.AnimatorStateInfo state)
        {
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            var val_10;
            int val_12;
            var val_13;
            if(this.nextIdleTime >= 0)
            {
                goto label_10;
            }
            
            val_5 = 1152921523874329280;
            val_6 = null;
            val_6 = null;
            if(val_5 == Royal.Scenes.Game.Mechanics.Items.BirdItem.View.BirdItemView.BirdWink)
            {
                goto label_7;
            }
            
            val_7 = null;
            val_5 = 1152921523874329280;
            val_7 = null;
            if(val_5 == Royal.Scenes.Game.Mechanics.Items.BirdItem.View.BirdItemView.BirdLookLeftAndRight)
            {
                goto label_7;
            }
            
            val_8 = null;
            val_5 = 1152921523874329280;
            val_8 = null;
            if(val_5 != Royal.Scenes.Game.Mechanics.Items.BirdItem.View.BirdItemView.BirdFallEnd)
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
                goto label_15;
            }
            
            if(this.isReverseSorted == false)
            {
                goto label_16;
            }
            
            goto label_19;
            label_15:
            val_12 = 1152921505109458952;
            goto label_24;
            label_16:
            val_10 = null;
            if(UnityEngine.Random.value <= 0.6f)
            {
                goto label_21;
            }
            
            val_10 = null;
            val_12 = 1152921505109458968;
            goto label_24;
            label_21:
            label_19:
            val_10 = null;
            val_12 = 1152921505109458956;
            label_24:
            val_10 = null;
            if(val_12 == Royal.Scenes.Game.Mechanics.Items.BirdItem.View.BirdItemView.BirdItemDefault)
            {
                    val_13 = null;
                val_13 = null;
                if(1152921523874329280 == Royal.Scenes.Game.Mechanics.Items.BirdItem.View.BirdItemView.BirdItemDefault)
            {
                    return;
            }
            
            }
            
            this.birdAnimator.Play(stateNameHash:  val_12, layer:  0, normalizedTime:  0f);
        }
        public override int GetPoolId()
        {
            return 63;
        }
        public override void OnSpawn()
        {
        
        }
        public override void OnRecycle()
        {
            this.birdItemHelper = 0;
        }
        public override void SwapAnimationStarted(bool isValid = True, Royal.Scenes.Game.Mechanics.Items.Config.ItemType otherItem = 0)
        {
            isValid = isValid;
            this.SwapAnimationStarted(isValid:  isValid, otherItem:  otherItem);
            this.birdAnimator.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.BirdItem.View.BirdItemView.BirdReaction, layer:  0, normalizedTime:  0f);
        }
        public override void SwapAnimationEnded()
        {
            this.SwapAnimationEnded();
            var val_6 = 0;
            if(mem[1152921505109651456] != null)
            {
                    val_6 = val_6 + 1;
            }
            else
            {
                    var val_7 = mem[1152921505109651464];
                val_7 = val_7 + 3;
                Royal.Scenes.Game.Mechanics.Items.BirdItem.View.IBirdItemViewDelegate val_1 = 1152921505109614592 + val_7;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_2 = this.viewDelegate.CurrentCell;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_3 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetItemSorting(row:  this.viewDelegate, isReverseSort:  false);
            this.UpdateSorting(sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_3.layer, order = val_3.order, sortEverything = val_3.sortEverything & 4294967295});
            var val_8 = 0;
            if(mem[1152921505109651456] != null)
            {
                    val_8 = val_8 + 1;
            }
            else
            {
                    var val_9 = mem[1152921505109651464];
                val_9 = val_9 + 2;
                Royal.Scenes.Game.Mechanics.Items.BirdItem.View.IBirdItemViewDelegate val_5 = 1152921505109614592 + val_9;
            }
            
            this.viewDelegate.TryCollect();
        }
        public override void FallStarted()
        {
            var val_7;
            var val_8;
            this.isFalling = true;
            UnityEngine.AnimatorStateInfo val_1 = this.birdAnimator.GetCurrentAnimatorStateInfo(layerIndex:  0);
            val_7 = null;
            val_8 = 0;
            if( == Royal.Scenes.Game.Mechanics.Items.BirdItem.View.BirdItemView.BirdItemDefault)
            {
                    this.birdAnimator.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.BirdItem.View.BirdItemView.CollectSortingMax, layer:  0, normalizedTime:  0f);
                return;
            }
            
            this.birdAnimator.CrossFade(stateHashName:  Royal.Scenes.Game.Mechanics.Items.BirdItem.View.BirdItemView.CollectSortingMax, normalizedTransitionDuration:  0.1f);
        }
        public override void FallEnded()
        {
            this.isFalling = false;
            var val_4 = 0;
            if(mem[1152921505109651456] != null)
            {
                    val_4 = val_4 + 1;
            }
            else
            {
                    var val_5 = mem[1152921505109651464];
                val_5 = val_5 + 3;
                Royal.Scenes.Game.Mechanics.Items.BirdItem.View.IBirdItemViewDelegate val_1 = 1152921505109614592 + val_5;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_2 = this.viewDelegate.CurrentCell;
            if((public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel Royal.Scenes.Game.Mechanics.Items.Config.IItemViewDelegate::get_CurrentCell()) == 0)
            {
                    this.birdAnimator.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.BirdItem.View.BirdItemView.BirdFallEnd, layer:  0, normalizedTime:  0f);
                this.nextIdleTime = -1f;
            }
            
            var val_6 = 0;
            if(mem[1152921505109651456] != null)
            {
                    val_6 = val_6 + 1;
            }
            else
            {
                    var val_7 = mem[1152921505109651464];
                val_7 = val_7 + 2;
                Royal.Scenes.Game.Mechanics.Items.BirdItem.View.IBirdItemViewDelegate val_3 = 1152921505109614592 + val_7;
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
            if(mem[1152921505109651456] != null)
            {
                    val_9 = val_9 + 1;
            }
            else
            {
                    var val_10 = mem[1152921505109651464];
                val_10 = val_10 + 3;
                Royal.Scenes.Game.Mechanics.Items.BirdItem.View.IBirdItemViewDelegate val_1 = 1152921505109614592 + val_10;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_2 = this.viewDelegate.CurrentCell;
            this.birdItemHelper.WillCollectAtColumn(column:  -46104560);
            var val_11 = 0;
            if(mem[1152921505109651456] != null)
            {
                    val_11 = val_11 + 1;
            }
            else
            {
                    Royal.Scenes.Game.Mechanics.Items.BirdItem.View.IBirdItemViewDelegate val_3 = 1152921505109614592 + ((mem[1152921505109651464]) << 4);
            }
            
            UnityEngine.Vector3 val_4 = this.viewDelegate.GetGoalPosition();
            var val_12 = 0;
            if(mem[1152921505109651456] != null)
            {
                    val_12 = val_12 + 1;
            }
            else
            {
                    var val_13 = mem[1152921505109651464];
                val_13 = val_13 + 3;
                Royal.Scenes.Game.Mechanics.Items.BirdItem.View.IBirdItemViewDelegate val_5 = 1152921505109614592 + val_13;
            }
            
            UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  this.CollectToGoalAnimation(goalPosition:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, currentCell:  this.viewDelegate.CurrentCell));
        }
        public System.Collections.IEnumerator CollectToGoalAnimation(UnityEngine.Vector3 goalPosition, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel currentCell)
        {
            .<>1__state = 0;
            .goalPosition = goalPosition;
            mem[1152921523875617444] = goalPosition.y;
            mem[1152921523875617448] = goalPosition.z;
            .<>4__this = this;
            .currentCell = currentCell;
            return (System.Collections.IEnumerator)new BirdItemView.<CollectToGoalAnimation>d__29();
        }
        private void SpawnParticle(Royal.Scenes.Game.Mechanics.Sortings.SortingData sortingData)
        {
            Royal.Scenes.Game.Mechanics.Items.BirdItem.View.BirdItemCollectParticles val_1 = 6159.Spawn<Royal.Scenes.Game.Mechanics.Items.BirdItem.View.BirdItemCollectParticles>(poolId:  64, activate:  true);
            val_1.Play(sorting:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = sortingData.sortEverything & 4294967295});
            UnityEngine.Vector3 val_5 = this.transform.position;
            val_1.transform.position = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        }
        public void PlayReactionAnimation()
        {
            if(this.isFalling == true)
            {
                    return;
            }
            
            if(this.isStartedCollecting != false)
            {
                    return;
            }
            
            this.birdAnimator.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.BirdItem.View.BirdItemView.BirdReaction, layer:  0, normalizedTime:  0f);
        }
        public void SetIsReverseSorted()
        {
            this.isReverseSorted = true;
        }
        public BirdItemView()
        {
        
        }
        private static BirdItemView()
        {
            Royal.Scenes.Game.Mechanics.Items.BirdItem.View.BirdItemView.CollectSortingMax = UnityEngine.Animator.StringToHash(name:  "Base Layer.BirdFallStart");
            Royal.Scenes.Game.Mechanics.Items.BirdItem.View.BirdItemView.BirdFallEnd = UnityEngine.Animator.StringToHash(name:  "Base Layer.BirdFallEnd");
            Royal.Scenes.Game.Mechanics.Items.BirdItem.View.BirdItemView.BirdItemDefault = UnityEngine.Animator.StringToHash(name:  "Base Layer.BirdItemDefaultAnimation");
            Royal.Scenes.Game.Mechanics.Items.BirdItem.View.BirdItemView.BirdWink = UnityEngine.Animator.StringToHash(name:  "Base Layer.BirdIdleAnimation");
            Royal.Scenes.Game.Mechanics.Items.BirdItem.View.BirdItemView.BirdCollect = UnityEngine.Animator.StringToHash(name:  "Base Layer.BirdCollect");
            Royal.Scenes.Game.Mechanics.Items.BirdItem.View.BirdItemView.BirdReaction = UnityEngine.Animator.StringToHash(name:  "Base Layer.BirdReaction");
            Royal.Scenes.Game.Mechanics.Items.BirdItem.View.BirdItemView.BirdLookLeftAndRight = UnityEngine.Animator.StringToHash(name:  "Base Layer.BirdIdle2");
        }
    
    }

}
