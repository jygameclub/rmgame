using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.BushItem.View.GrassSpread
{
    public class GrassSpreadAnimationView : MonoBehaviour, IPoolable
    {
        // Fields
        private static readonly int GrassSpreadAnimation;
        private static readonly int GrassSpreadEdgeAnimation;
        private const float InitialDelay = 0.05;
        private Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory;
        private Royal.Scenes.Game.Levels.Units.GoalManager goalManager;
        private Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cellModel;
        private bool isPlaying;
        private int groupNo;
        private int xIndex;
        private int yIndex;
        public UnityEngine.Animator animator;
        public UnityEngine.SpriteRenderer[] sortingOrders;
        private Royal.Scenes.Game.Mechanics.Items.BushItem.View.BushItemAssets bushItemAssets;
        private Royal.Scenes.Game.Levels.Units.State.GameStateManager gameStateManager;
        private Royal.Scenes.Game.Mechanics.Items.StaticItems.GrassItem.View.GrassItemAssets grassItemAssets;
        public UnityEngine.SpriteRenderer shadow;
        public UnityEngine.SpriteRenderer grassBg;
        public UnityEngine.SpriteRenderer topPatch;
        public UnityEngine.SpriteRenderer rightPatch;
        public GrassViewData grassViewData;
        
        // Methods
        private void Awake()
        {
            this.itemFactory = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1);
            this.goalManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.GoalManager>(contextId:  11);
            this.gameStateManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14);
            this.bushItemAssets = this.itemFactory.assetsLibrary.Load<Royal.Scenes.Game.Mechanics.Items.BushItem.View.BushItemAssets>();
            this.grassItemAssets = this.itemFactory.assetsLibrary.Load<Royal.Scenes.Game.Mechanics.Items.StaticItems.GrassItem.View.GrassItemAssets>();
        }
        public void Play(UnityEngine.Vector3 startPosition, UnityEngine.Vector3 endPosition, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cellModel, DG.Tweening.Sequence seq, int xIndex, int yIndex)
        {
            DG.Tweening.TweenCallback val_28;
            .<>4__this = this;
            this.xIndex = xIndex;
            this.yIndex = yIndex;
            this.grassBg.sprite = this.grassViewData;
            this.topPatch.sprite = this.grassViewData;
            this.rightPatch.sprite = this.grassViewData;
            this.topPatch.enabled = false;
            this.rightPatch.enabled = false;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = endPosition.x, y = endPosition.y, z = endPosition.z}, b:  new UnityEngine.Vector3() {x = startPosition.x, y = startPosition.y, z = startPosition.z});
            this.groupNo = val_2.x.GetIndexByDistance(distance:  val_2.x);
            UnityEngine.Transform val_4 = this.transform;
            val_4.SetParent(p:  this.itemFactory.<ItemParent>k__BackingField);
            val_4.localPosition = new UnityEngine.Vector3() {x = startPosition.x, y = startPosition.y, z = startPosition.z};
            .curveData = this.GetCurveForIndex();
            UnityEngine.Vector3 val_7 = this.GetScaleForIndex();
            this.PlayAnimationByIndex();
            float val_10 = this.GetDelayForIndex() + 0.05f;
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Insert(s:  seq, atPosition:  val_10, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = endPosition.x, y = endPosition.y, z = endPosition.z}, duration:  (GrassSpreadAnimationView.<>c__DisplayClass21_0)[1152921523843808080].curveData.duration, snapping:  false), animCurve:  (GrassSpreadAnimationView.<>c__DisplayClass21_0)[1152921523843808080].curveData.curve));
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.Insert(s:  seq, atPosition:  val_10, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, duration:  ((GrassSpreadAnimationView.<>c__DisplayClass21_0)[1152921523843808080].curveData.duration) / 3f));
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.one;
            float val_28 = (GrassSpreadAnimationView.<>c__DisplayClass21_0)[1152921523843808080].curveData.duration;
            val_28 = val_28 + val_28;
            val_28 = val_28 / 3f;
            float val_20 = ((GrassSpreadAnimationView.<>c__DisplayClass21_0)[1152921523843808080].curveData.duration) / 3f;
            val_20 = val_10 + val_20;
            DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.Insert(s:  seq, atPosition:  val_20, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, duration:  val_28));
            DG.Tweening.TweenCallback val_22 = null;
            val_28 = val_22;
            val_22 = new DG.Tweening.TweenCallback(object:  new GrassSpreadAnimationView.<>c__DisplayClass21_0(), method:  System.Void GrassSpreadAnimationView.<>c__DisplayClass21_0::<Play>b__0());
            DG.Tweening.Sequence val_23 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  seq, atPosition:  val_10, callback:  val_22);
            this.cellModel = cellModel;
            this.isPlaying = true;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_24 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetGrassSorting(point:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = seq, y = seq}, layer:  2);
            var val_30 = 0;
            label_24:
            if(val_30 >= (this.sortingOrders.Length << ))
            {
                goto label_20;
            }
            
            val_28 = (val_28 & (-4294967296)) | (val_24.sortEverything & 4294967295);
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_27 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_24.layer, order = val_24.order, sortEverything = val_28}, offset:  0);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.sortingOrders[val_30], data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_27.layer, order = val_27.order, sortEverything = xIndex});
            val_30 = val_30 + 1;
            if(this.sortingOrders != null)
            {
                goto label_24;
            }
            
            throw new NullReferenceException();
            label_20:
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.shadow, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_27.layer, order = val_27.order, sortEverything = xIndex});
            cellModel = this.sortingOrders[1];
            this.gameStateManager.OperationStart(animationId:  10);
        }
        private int GetIndexByDistance(float distance)
        {
            return (int)new UnityEngine.Mathf();
        }
        private void PlayAnimationByIndex()
        {
            var val_1;
            var val_2;
            var val_3;
            if((this.groupNo != 1) && (this.groupNo == 2))
            {
                    val_1 = null;
                val_1 = null;
                val_2 = 1152921505108127748;
            }
            else
            {
                    val_3 = null;
                val_3 = null;
            }
            
            this.animator.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.BushItem.View.GrassSpread.GrassSpreadAnimationView.__il2cppRuntimeField_static_fields, layer:  0, normalizedTime:  0f);
            this.animator.speed = 0f;
        }
        private float GetDelayForIndex()
        {
            int val_7;
            float val_8;
            var val_9;
            if(this.groupNo == 2)
            {
                goto label_0;
            }
            
            if(this.groupNo != 1)
            {
                    return (float)36608296 + this.yIndex == 0 ? 1 : 0;
            }
            
            if(this.xIndex == 2)
            {
                goto label_2;
            }
            
            if(this.xIndex == 1)
            {
                goto label_3;
            }
            
            if(this.xIndex != 0)
            {
                    return 0.025f;
            }
            
            float val_7 = 0.06f;
            float val_1 = (this.yIndex == 1) ? 0.125f : 0.025f;
            val_7 = val_1 + val_7;
            val_1 = (this.yIndex == 2) ? (val_7) : (val_1);
            return (float)val_1;
            label_0:
            if(this.xIndex == 0)
            {
                goto label_5;
            }
            
            if(this.xIndex != 3)
            {
                    return 0.025f;
            }
            
            val_7 = this.yIndex;
            val_8 = 0.05f;
            val_9 = 36608304;
            goto label_7;
            label_5:
            var val_2 = (this.yIndex == 0) ? 1 : 0;
            return (float)36608296 + this.yIndex == 0 ? 1 : 0;
            label_2:
            float val_8 = 0.05f;
            var val_3 = (this.yIndex == 0) ? 1 : 0;
            val_8 = (36597288 + this.yIndex == 0 ? 1 : 0) + val_8;
            return (float)(this.yIndex == 3) ? (val_8) : (36597288 + this.yIndex == 0 ? 1 : 0);
            label_3:
            val_7 = this.yIndex;
            val_8 = 0.1f;
            val_9 = 36597296;
            label_7:
            var val_5 = (val_7 == 0) ? 1 : 0;
            val_8 = (val_9 + val_7 == 0 ? 1 : 0) + val_8;
            return (float)(val_7 == 3) ? (val_8) : (val_9 + val_7 == 0 ? 1 : 0);
        }
        private Royal.Scenes.Game.Mechanics.Items.BushItem.View.GrassSpread.GrassSpreadAnimData GetCurveForIndex()
        {
            if(this.groupNo != 1)
            {
                    if(this.groupNo != 0)
            {
                    return this.bushItemAssets.GetGrassAnimationData(index:  1);
            }
            
                return this.bushItemAssets.GetGrassAnimationData(index:  0);
            }
            
            if(this.xIndex != 3)
            {
                    if(this.xIndex != 2)
            {
                    return this.bushItemAssets.GetGrassAnimationData(index:  1);
            }
            
                if(this.yIndex == 0)
            {
                    return this.bushItemAssets.GetGrassAnimationData(index:  2);
            }
            
                return this.bushItemAssets.GetGrassAnimationData(index:  1);
            }
            
            if(this.yIndex != 2)
            {
                    return this.bushItemAssets.GetGrassAnimationData(index:  1);
            }
            
            return this.bushItemAssets.GetGrassAnimationData(index:  2);
        }
        private UnityEngine.Vector3 GetScaleForIndex()
        {
            float val_1;
            if(this.groupNo != 0)
            {
                    val_1 = 1.8f;
            }
            else
            {
                    val_1 = 2.3f;
            }
            
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        private void Update()
        {
            this.HideIfCloseToView();
            this.UpdatePatches();
            this.CheckAnimationEnd();
        }
        private void HideIfCloseToView()
        {
            Royal.Scenes.Game.Mechanics.Items.Config.StaticItemModel val_1 = this.cellModel.<StaticMediator>k__BackingField.GetStaticItem(itemType:  1);
            if(val_1 == null)
            {
                    return;
            }
            
            var val_2 = (((Royal.Scenes.Game.Mechanics.Items.Config.StaticItemModel.__il2cppRuntimeField_typeHierarchy + (Royal.Scenes.Game.Mechanics.Items.StaticItems.GrassItem.GrassItemModel.__il2cppRuntimeField_typeHierarch + -8) == null) ? (val_1) : 0;
        }
        private void UpdatePatches()
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_1 = this.cellModel.neighbors.Get(type:  3);
            if(val_1 != null)
            {
                    Royal.Scenes.Game.Mechanics.Items.StaticItems.GrassItem.View.GrassItemView.ArrangePatch(neighbor:  val_1, patchRenderer:  this.rightPatch, itemAssets:  this.grassItemAssets, layer:  2);
            }
            else
            {
                    this.rightPatch.enabled = false;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_2 = this.cellModel.neighbors.Get(type:  1);
            if(val_2 != null)
            {
                    Royal.Scenes.Game.Mechanics.Items.StaticItems.GrassItem.View.GrassItemView.ArrangePatch(neighbor:  val_2, patchRenderer:  this.topPatch, itemAssets:  this.grassItemAssets, layer:  2);
                return;
            }
            
            this.topPatch.enabled = false;
        }
        private void CheckAnimationEnd()
        {
            float val_3;
            if(this.isPlaying == false)
            {
                    return;
            }
            
            UnityEngine.AnimatorStateInfo val_1 = this.animator.GetCurrentAnimatorStateInfo(layerIndex:  0);
            if(val_3 < 0)
            {
                    return;
            }
            
            this.isPlaying = false;
            this.Complete();
            this.itemFactory.Recycle<Royal.Scenes.Game.Mechanics.Items.BushItem.View.GrassSpread.GrassSpreadAnimationView>(go:  this);
        }
        private void Complete()
        {
            var val_5;
            Royal.Scenes.Game.Mechanics.Items.Config.StaticItemModel val_1 = this.cellModel.<StaticMediator>k__BackingField.GetStaticItem(itemType:  1);
            val_5 = 0;
            int val_5 = this.cellModel.incomingGrassCount;
            val_5 = val_5 - 1;
            this.cellModel = val_5;
            RefillLayers(grassViewData:  new GrassViewData() {baseData = new GrassSpriteData() {sorting = new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {sortEverything = false}, color = new UnityEngine.Color()}, patchData = new GrassSpriteData() {sorting = new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {sortEverything = false}, color = new UnityEngine.Color()}, shadowData = new GrassSpriteData() {sorting = new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {sortEverything = false}, color = new UnityEngine.Color()}});
            this.gameStateManager.OperationFinish(animationId:  10);
        }
        public int GetPoolId()
        {
            return 57;
        }
        public void OnSpawn()
        {
        
        }
        public void OnRecycle()
        {
            this.cellModel = 0;
        }
        public GrassSpreadAnimationView()
        {
        
        }
        private static GrassSpreadAnimationView()
        {
            Royal.Scenes.Game.Mechanics.Items.BushItem.View.GrassSpread.GrassSpreadAnimationView.InitialDelay = UnityEngine.Animator.StringToHash(name:  "Base Layer.GrassSpreadAnimation");
            Royal.Scenes.Game.Mechanics.Items.BushItem.View.GrassSpread.GrassSpreadAnimationView.GrassSpreadEdgeAnimation = UnityEngine.Animator.StringToHash(name:  "Base Layer.GrassSpreadEdgeAnimation");
        }
    
    }

}
