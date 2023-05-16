using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.HatItem.View
{
    public class HatThrowItemView : MonoBehaviour, IPoolable, IMatchItemViewDelegate, IItemViewDelegate
    {
        // Fields
        public UnityEngine.ParticleSystem tracer;
        public UnityEngine.ParticleSystem hitParticles;
        public UnityEngine.Renderer[] allParticlesRenderers;
        public UnityEngine.SpriteRenderer item;
        public UnityEngine.SpriteRenderer shadow;
        private Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell;
        private Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory;
        private Royal.Scenes.Game.Levels.Units.State.GameStateManager stateManager;
        private Royal.Scenes.Game.Levels.Units.GoalManager goalManager;
        private UnityEngine.Vector3 startPosition;
        private UnityEngine.Vector3 finalPosition;
        private UnityEngine.Vector3 curvePoint1;
        private UnityEngine.Vector3 curvePoint2;
        private Royal.Infrastructure.Utils.Randoming.RandomManager randomManager;
        private int index;
        private Royal.Scenes.Game.Levels.Units.Sfx.GameSfxManager sfxManager;
        private readonly int <Id>k__BackingField;
        private readonly Royal.Scenes.Game.Mechanics.Board.Cell.CellModel <CurrentCell>k__BackingField;
        
        // Properties
        public int Id { get; }
        public Royal.Scenes.Game.Mechanics.Items.Config.ItemType ItemType { get; }
        public Royal.Scenes.Game.Mechanics.Matches.MatchType MatchType { get; }
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel CurrentCell { get; }
        
        // Methods
        private void Awake()
        {
            this.itemFactory = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1);
            this.stateManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14);
            this.randomManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Utils.Randoming.RandomManager>(id:  5);
            this.sfxManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.Sfx.GameSfxManager>(contextId:  22);
            this.goalManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.GoalManager>(contextId:  11);
        }
        public void InitAndMove(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, int index, float delay, Royal.Scenes.Game.Mechanics.Sortings.SortingData patchSorting)
        {
            this.cell = cell;
            this.index = index;
            cell.Reserve();
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.Move(delay:  delay, patchSorting:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = patchSorting.layer, order = patchSorting.order, sortEverything = patchSorting.sortEverything & 4294967295}));
        }
        private void SquashStretch(Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemModel matchItemModel, float yScale = 0.9)
        {
            .matchItemModel = matchItemModel;
            .<>4__this = this;
            UnityEngine.Vector3 val_3 = matchItemModel.<ItemView>k__BackingField.baseView.transform.localPosition;
            UnityEngine.Bounds val_5 = matchItemModel.<ItemView>k__BackingField.baseView.sprite.bounds;
            UnityEngine.Transform val_9 = matchItemModel.<ItemView>k__BackingField.baseView.transform.parent;
            float val_10 = 1f - yScale;
            val_10 = val_10 * val_3.y;
            float val_25 = 0.5f;
            val_25 = val_10 * val_25;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            int val_26 = (HatThrowItemView.<>c__DisplayClass18_0)[1152921520292756336].matchItemModel.reserveCounter;
            val_26 = val_26 + 1;
            (HatThrowItemView.<>c__DisplayClass18_0)[1152921520292756336].matchItemModel = val_26;
            float val_12 = 1f / yScale;
            DG.Tweening.Sequence val_13 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_13, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_9, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  0.1f));
            DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_13, t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  val_9, endValue:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, duration:  0.05f, snapping:  false));
            DG.Tweening.Sequence val_19 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_13, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_9, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  0.05f));
            DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_13, t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  val_9, endValue:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, duration:  0.025f, snapping:  false));
            DG.Tweening.Sequence val_22 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_13, interval:  0.125f);
            DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_13, action:  new DG.Tweening.TweenCallback(object:  new HatThrowItemView.<>c__DisplayClass18_0(), method:  System.Void HatThrowItemView.<>c__DisplayClass18_0::<SquashStretch>b__0()));
        }
        private System.Collections.IEnumerator Move(float delay, Royal.Scenes.Game.Mechanics.Sortings.SortingData patchSorting)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .delay = delay;
            .patchSorting = patchSorting;
            mem[1152921520292958468] = patchSorting.sortEverything;
            return (System.Collections.IEnumerator)new HatThrowItemView.<Move>d__19();
        }
        private void FixItemSortings()
        {
            var val_5;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_1 = Royal.Infrastructure.Utils.Sprite.SpriteExtensions.GetSorting(renderer:  this.item);
            val_5 = null;
            val_5 = null;
            int val_2 = val_1.layer >> 32;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_3 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {sortEverything = false}, offset:  0);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.item, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {sortEverything = false});
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.shadow, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_3.layer, order = val_3.order, sortEverything = val_3.sortEverything & 4294967295});
        }
        private void FixParticleSortings()
        {
            var val_3;
            UnityEngine.Renderer val_4;
            var val_5;
            val_3 = 4;
            do
            {
                val_4 = val_3 - 4;
                if(val_4 >= (this.allParticlesRenderers.Length << ))
            {
                    return;
            }
            
                Royal.Scenes.Game.Mechanics.Sortings.SortingData val_1 = Royal.Infrastructure.Utils.Sprite.SpriteExtensions.GetSorting(renderer:  this.allParticlesRenderers[0]);
                val_5 = null;
                val_4 = this.allParticlesRenderers[0];
                val_5 = null;
                int val_2 = val_1.layer >> 32;
                Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  val_4, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {sortEverything = false});
                val_3 = val_3 + 1;
            }
            while(this.allParticlesRenderers != null);
            
            throw new NullReferenceException();
        }
        private void UpdateSortings(Royal.Scenes.Game.Mechanics.Sortings.SortingData itemSorting, Royal.Scenes.Game.Mechanics.Sortings.SortingData particleSorting, Royal.Scenes.Game.Mechanics.Sortings.SortingData shadowSorting)
        {
            bool val_4;
            itemSorting.sortEverything = itemSorting.sortEverything & 4294967295;
            val_4 = particleSorting.sortEverything;
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.item, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = itemSorting.layer, order = itemSorting.order, sortEverything = itemSorting.sortEverything});
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.shadow, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = shadowSorting.layer, order = shadowSorting.order, sortEverything = shadowSorting.sortEverything & 4294967295});
            var val_5 = 0;
            do
            {
                if(val_5 >= (this.allParticlesRenderers.Length << ))
            {
                    return;
            }
            
                val_4 = (val_4 & (-4294967296)) | (val_4 & 4294967295);
                Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.allParticlesRenderers[val_5], data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = particleSorting.layer, order = particleSorting.order, sortEverything = val_4});
                val_5 = val_5 + 1;
            }
            while(this.allParticlesRenderers != null);
            
            throw new NullReferenceException();
        }
        private void OnDrawGizmos()
        {
        
        }
        private void OnReachedToCell()
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_25;
            var val_26;
            if(this.cell.Mediator.HasCurrentItem() != false)
            {
                    if(this.cell.CurrentItem != 1)
            {
                goto label_6;
            }
            
            }
            
            val_25 = this.cell;
            val_26 = val_25;
            if(this.cell.Mediator.HasCurrentItem() != false)
            {
                    Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_4 = this.cell.CurrentItem;
                val_26 = val_4.itemMediator.NextCell;
                val_25 = val_4.itemMediator.TargetCell;
                val_4.itemMediator.ClearFromAllRegisteredCells();
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_7 = this.itemFactory.itemCreator.CreateItemAt(tiledId:  5, position:  new UnityEngine.Vector3());
            int val_25 = val_8.purpleOnBoard;
            val_25 = val_25 + 0;
            Royal.Scenes.Game.Levels.LevelContext.GetLate<Royal.Scenes.Game.Mechanics.Items.HatItem.HatItemHelper>(contextId:  27) = val_25;
            bool val_11 = this.cell.Mediator.SetCurrentItem(item:  val_7).SetNextItem(item:  val_7).SetTargetItem(item:  val_7);
            this.hitParticles.Play();
            this.Invoke(methodName:  "RecycleSelf", time:  1f);
            this.item.gameObject.SetActive(value:  false);
            this.shadow.gameObject.SetActive(value:  false);
            this.sfxManager.PlaySfx(type:  169, offset:  0.04f);
            this.SquashStretch(matchItemModel:  val_7, yScale:  0.9f);
            return;
            label_6:
            if(((this.goalManager.GetGoalIndex(goalType:  5)) & 2147483648) == 0)
            {
                    this.goalManager.DecreaseGoal(goalType:  5);
                this.stateManager.OperationStart(animationId:  5);
                UnityEngine.Vector3 val_15 = this.goalManager.GetGoalPosition(goalType:  5);
                this.goalManager.FlyingToBeCollected(goalType:  5);
                Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemView val_16 = this.itemFactory.Spawn<Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemView>(poolId:  2, activate:  true);
                val_16.Init(viewDelegate:  this, position:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
                val_25 = this.cell;
                val_16.CollectToGoal(goalPosition:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, cellModel:  val_25, collectData:  new Royal.Scenes.Game.Mechanics.Items.MatchItem.Collect.MatchCollectData() {orderedCells = new Royal.Scenes.Game.Mechanics.Matches.Cell14(), specialItemCreationCell = this.cell.point});
            }
            else
            {
                    if((Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LevelManager>(id:  2).IsThereDrillInLevel()) != false)
            {
                    Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillManager val_20 = Royal.Scenes.Game.Levels.LevelContext.GetLate<Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillHelper>(contextId:  31).GetDrillForMatchType(matchType:  5);
                if(val_20 != null)
            {
                    this.stateManager.OperationStart(animationId:  5);
                val_25 = this.itemFactory.Spawn<Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemView>(poolId:  2, activate:  true);
                val_25.Init(viewDelegate:  this, position:  new UnityEngine.Vector3());
                val_25.CollectToManager(collectManager:  val_20, cellModel:  this.cell, collectData:  new Royal.Scenes.Game.Mechanics.Items.MatchItem.Collect.MatchCollectData() {orderedCells = new Royal.Scenes.Game.Mechanics.Matches.Cell14()});
            }
            
            }
            
            }
            
            this.FinishOperation();
            this.Invoke(methodName:  "RecycleSelf", time:  1f);
            this.item.gameObject.SetActive(value:  false);
            this.shadow.gameObject.SetActive(value:  false);
            int val_26 = val_24.flyingPurple;
            val_26 = val_26 - 1;
            Royal.Scenes.Game.Levels.LevelContext.GetLate<Royal.Scenes.Game.Mechanics.Items.HatItem.HatItemHelper>(contextId:  27) = val_26;
        }
        private void FinishOperation()
        {
            this.stateManager.OperationFinish(animationId:  11);
            this.cell.UnReserve();
        }
        private void RecycleSelf()
        {
            this.itemFactory.Recycle<Royal.Scenes.Game.Mechanics.Items.HatItem.View.HatThrowItemView>(go:  this);
        }
        public int GetPoolId()
        {
            return 84;
        }
        public void OnSpawn()
        {
        
        }
        public void OnRecycle()
        {
            this.item.gameObject.SetActive(value:  true);
            this.shadow.gameObject.SetActive(value:  true);
        }
        public int get_Id()
        {
            return (int)this.<Id>k__BackingField;
        }
        public Royal.Scenes.Game.Mechanics.Items.Config.ItemType get_ItemType()
        {
            return 1;
        }
        public Royal.Scenes.Game.Mechanics.Matches.MatchType get_MatchType()
        {
            return 5;
        }
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel get_CurrentCell()
        {
            return (Royal.Scenes.Game.Mechanics.Board.Cell.CellModel)this.<CurrentCell>k__BackingField;
        }
        public bool IsUnderHoney()
        {
            return false;
        }
        public bool IsUnderCurtain()
        {
            return false;
        }
        public bool IsUnderChain()
        {
            return false;
        }
        public bool IsUnderOneLayeredChain()
        {
            return false;
        }
        public void CollectAnimationCompleted(Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemView itemView)
        {
            this.goalManager.DecreaseGoalUi(goalType:  5);
            this.stateManager.OperationFinish(animationId:  5);
            this.itemFactory.Recycle<Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemView>(go:  itemView);
            Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.Sfx.GameSfxManager>(contextId:  22).PlaySfx(type:  185, offset:  0.04f);
        }
        public void ManagerCollectCompleted(Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemView itemView, Royal.Scenes.Game.Mechanics.Items.MatchItem.Collect.ICollectManager collectManager, bool hitFromLeft)
        {
            var val_3;
            this.stateManager.OperationFinish(animationId:  5);
            val_3 = public System.Void Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory::Recycle<Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemView>(Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemView go);
            this.itemFactory.Recycle<Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemView>(go:  itemView);
            var val_3 = 0;
            if(mem[1152921505098203136] != null)
            {
                    val_3 = val_3 + 1;
                val_3 = 2;
            }
            else
            {
                    var val_4 = mem[1152921505098203144];
                val_4 = val_4 + 2;
                Royal.Scenes.Game.Mechanics.Items.MatchItem.Collect.ICollectManager val_1 = 1152921505098166272 + val_4;
            }
            
            collectManager.ItemReached(hitFromLeft:  hitFromLeft);
        }
        public HatThrowItemView()
        {
        
        }
    
    }

}
