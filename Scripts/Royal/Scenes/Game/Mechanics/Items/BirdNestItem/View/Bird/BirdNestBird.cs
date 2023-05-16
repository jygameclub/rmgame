using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.BirdNestItem.View.Bird
{
    public class BirdNestBird : MonoBehaviour, IPoolable
    {
        // Fields
        public const float BirdScale = 0.83;
        private static readonly int BirdDefault;
        private static readonly int BirdAppear;
        private static readonly int BirdIdle1;
        private static readonly int BirdIdle2;
        public UnityEngine.Animator birdAnimator;
        public UnityEngine.SpriteRenderer foreShadow;
        public UnityEngine.SpriteRenderer shadow;
        public UnityEngine.Rendering.SortingGroup sortingGroup;
        public UnityEngine.GameObject root;
        private float nextIdleTime;
        private Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell;
        private Royal.Scenes.Game.Levels.Units.State.GameStateManager stateManager;
        private Royal.Infrastructure.Utils.Randoming.RandomManager randomManager;
        private Royal.Scenes.Game.Levels.Units.Sfx.GameSfxManager sfxManager;
        private Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory;
        private bool isMoving;
        
        // Methods
        protected void Awake()
        {
            this.stateManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14);
            this.randomManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Utils.Randoming.RandomManager>(id:  5);
            this.sfxManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.Sfx.GameSfxManager>(contextId:  22);
            this.itemFactory = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1);
        }
        public int GetPoolId()
        {
            return 99;
        }
        public void OnSpawn()
        {
        
        }
        public void PlayAppearAnimation(int index, Royal.Scenes.Game.Mechanics.Items.BirdNestItem.View.Crack.BirdNestCrack crack)
        {
            this.birdAnimator.gameObject.SetActive(value:  false);
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.DelayAppear(index:  index, crack:  crack));
        }
        private System.Collections.IEnumerator DelayAppear(int index, Royal.Scenes.Game.Mechanics.Items.BirdNestItem.View.Crack.BirdNestCrack crack)
        {
            .<>1__state = 0;
            .index = index;
            .<>4__this = this;
            .crack = crack;
            return (System.Collections.IEnumerator)new BirdNestBird.<DelayAppear>d__21();
        }
        private void Update()
        {
            int val_4;
            float val_5;
            int val_6;
            var val_8;
            if(this.birdAnimator.gameObject.activeSelf == false)
            {
                    return;
            }
            
            UnityEngine.AnimatorStateInfo val_3 = this.birdAnimator.GetCurrentAnimatorStateInfo(layerIndex:  0);
            val_8 = null;
            val_8 = null;
            if( == Royal.Scenes.Game.Mechanics.Items.BirdNestItem.View.Bird.BirdNestBird.BirdAppear)
            {
                    if(val_5 <= 1f)
            {
                    return;
            }
            
            }
            
            if(val_5 < 1f)
            {
                    return;
            }
            
            this.PickRandomIdleAnimation(state:  new UnityEngine.AnimatorStateInfo() {m_Name = val_6, m_Path = val_6, m_FullPath = val_6, m_NormalizedTime = val_6, m_Length = val_5, m_Speed = val_5, m_SpeedMultiplier = val_5, m_Tag = val_5, m_Loop = val_4});
        }
        private void PickRandomIdleAnimation(UnityEngine.AnimatorStateInfo state)
        {
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            int val_10;
            var val_11;
            if(this.nextIdleTime >= 0)
            {
                goto label_7;
            }
            
            val_5 = 1152921523863348672;
            val_6 = null;
            val_6 = null;
            if(val_5 == Royal.Scenes.Game.Mechanics.Items.BirdNestItem.View.Bird.BirdNestBird.BirdIdle1)
            {
                goto label_4;
            }
            
            val_7 = null;
            val_7 = null;
            if(1152921523863348672 != Royal.Scenes.Game.Mechanics.Items.BirdNestItem.View.Bird.BirdNestBird.BirdIdle2)
            {
                goto label_7;
            }
            
            label_4:
            float val_2 = UnityEngine.Random.value;
            float val_5 = 1.5f;
            val_5 = Royal.Scenes.Game.Levels.LevelContext.Time + val_5;
            val_2 = val_5 + val_2;
            this.nextIdleTime = val_2;
            return;
            label_7:
            if(Royal.Scenes.Game.Levels.LevelContext.Time < 0)
            {
                    return;
            }
            
            this.nextIdleTime = -1f;
            val_8 = null;
            if(UnityEngine.Random.value > 0.6f)
            {
                    val_9 = null;
                val_10 = 1152921505108979720;
            }
            else
            {
                    val_11 = null;
                val_10 = 1152921505108979724;
            }
            
            this.birdAnimator.Play(stateNameHash:  val_10, layer:  0, normalizedTime:  0f);
        }
        public void OnRecycle()
        {
            this.isMoving = false;
            this.shadow.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            this.shadow.transform.localPosition = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            this.cell = 0;
        }
        public void UpdateSorting(Royal.Scenes.Game.Mechanics.Sortings.SortingData sorting)
        {
            sorting.sortEverything = sorting.sortEverything & 4294967295;
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(group:  this.sortingGroup, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sorting.layer, order = sorting.order, sortEverything = sorting.sortEverything});
        }
        public void Move(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, int index)
        {
            this.cell = cell;
            cell.Reserve();
            this.transform.SetParent(p:  0);
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.Move(index:  index, delay:  0.05f));
        }
        private System.Collections.IEnumerator Move(int index, float delay)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .index = index;
            .delay = delay;
            return (System.Collections.IEnumerator)new BirdNestBird.<Move>d__27();
        }
        private void OnReachedToCell()
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_10;
            var val_11;
            val_10 = this.cell;
            val_11 = val_10;
            if(this.cell.Mediator.HasCurrentItem() != false)
            {
                    Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_2 = this.cell.CurrentItem;
                val_11 = val_2.itemMediator.NextCell;
                val_10 = val_2.itemMediator.TargetCell;
                val_2.itemMediator.ClearFromAllRegisteredCells();
            }
            
            if(this.cell != null)
            {
                    if(this.cell.HasCreatedItem != false)
            {
                    X23 + 32.ClearFromAllRegisteredCells();
                this.cell.RemoveCreatedItem();
            }
            
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_6 = this.itemFactory.itemCreator.CreateItemAt(tiledId:  35, position:  new UnityEngine.Vector3());
            bool val_9 = this.cell.Mediator.SetCurrentItem(item:  val_6).SetNextItem(item:  val_6).SetTargetItem(item:  val_6);
            this.sfxManager.PlaySfx(type:  21, offset:  0.04f);
            this.SquashStretch(birdItemModel:  val_6, cell:  this.cell, yScale:  0.9f);
            this.itemFactory.Recycle<Royal.Scenes.Game.Mechanics.Items.BirdNestItem.View.Bird.BirdNestBird>(go:  this);
        }
        private void SquashStretch(Royal.Scenes.Game.Mechanics.Items.BirdItem.BirdItemModel birdItemModel, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, float yScale = 0.9)
        {
            BirdNestBird.<>c__DisplayClass29_0 val_1 = new BirdNestBird.<>c__DisplayClass29_0();
            .<>4__this = this;
            .birdItemModel = birdItemModel;
            .cell = cell;
            UnityEngine.Transform val_2 = val_1.transform;
            UnityEngine.Vector3 val_4 = val_2.transform.localPosition;
            float val_20 = 0.5f;
            val_20 = (1f - yScale) * val_20;
            float val_6 = 1f / yScale;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            DG.Tweening.Sequence val_8 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_8, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_2, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  0.1f));
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_8, t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  val_2, endValue:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, duration:  0.05f, snapping:  false));
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_8, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_2, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  0.05f));
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_8, t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  val_2, endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  0.025f, snapping:  false));
            DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_8, interval:  0.125f);
            DG.Tweening.Sequence val_19 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_8, action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void BirdNestBird.<>c__DisplayClass29_0::<SquashStretch>b__0()));
        }
        private void FinishOperation(Royal.Scenes.Game.Mechanics.Items.BirdItem.BirdItemModel itemModel, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            this.stateManager.OperationFinish(animationId:  11);
            cell.UnReserve();
            itemModel.TryCollect();
        }
        public void CollectImmediately()
        {
            var val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  5, log:  "Couldn\'t find a cell for bird, so collect it immediately.", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            this.itemFactory.Recycle<Royal.Scenes.Game.Mechanics.Items.BirdNestItem.View.Bird.BirdNestBird>(go:  this);
            object val_1 = Royal.Scenes.Game.Levels.LevelContext.Get<System.Object>(contextId:  11);
            val_1.DecreaseGoal(goalType:  23);
            val_1.DecreaseGoalUi(goalType:  23);
        }
        public BirdNestBird()
        {
        
        }
        private static BirdNestBird()
        {
            Royal.Scenes.Game.Mechanics.Items.BirdNestItem.View.Bird.BirdNestBird.BirdDefault = UnityEngine.Animator.StringToHash(name:  "Base Layer.BirdDefault");
            Royal.Scenes.Game.Mechanics.Items.BirdNestItem.View.Bird.BirdNestBird.BirdAppear = UnityEngine.Animator.StringToHash(name:  "Base Layer.BirdAppear");
            Royal.Scenes.Game.Mechanics.Items.BirdNestItem.View.Bird.BirdNestBird.BirdIdle1 = UnityEngine.Animator.StringToHash(name:  "Base Layer.BirdWink");
            Royal.Scenes.Game.Mechanics.Items.BirdNestItem.View.Bird.BirdNestBird.BirdIdle2 = UnityEngine.Animator.StringToHash(name:  "Base Layer.BirdLook");
        }
    
    }

}
