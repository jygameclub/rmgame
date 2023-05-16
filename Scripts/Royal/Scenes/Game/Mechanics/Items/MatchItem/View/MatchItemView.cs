using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.MatchItem.View
{
    public class MatchItemView : ItemView
    {
        // Fields
        public static float TargetSpecialItemExplodeTime;
        public static float ExplodeCompleteRatio;
        public static Royal.Infrastructure.Utils.Animation.ManualEasingType Easing;
        private UnityEngine.Coroutine mergeCoroutine;
        public UnityEngine.SpriteRenderer baseView;
        public UnityEngine.SpriteRenderer overlayView;
        public UnityEngine.SpriteRenderer shadowView;
        public UnityEngine.Transform shadowParent;
        private Royal.Scenes.Game.Mechanics.Items.MatchItem.View.IMatchItemViewDelegate itemViewDelegate;
        private Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemAssets itemAssets;
        private bool isHighlighted;
        
        // Methods
        public void Init(Royal.Scenes.Game.Mechanics.Items.MatchItem.View.IMatchItemViewDelegate viewDelegate, UnityEngine.Vector3 position)
        {
            this.itemViewDelegate = viewDelegate;
            Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemAssets val_1 = 185636.Load<Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemAssets>();
            this.itemAssets = val_1;
            var val_27 = 0;
            if(mem[1152921505097670656] != null)
            {
                    val_27 = val_27 + 1;
            }
            else
            {
                    var val_28 = mem[1152921505097670664];
                val_28 = val_28 + 2;
                Royal.Scenes.Game.Mechanics.Items.MatchItem.View.IMatchItemViewDelegate val_2 = 1152921505097633792 + val_28;
            }
            
            this.baseView.sprite = val_1.GetSprite(matchType:  this.itemViewDelegate.MatchType);
            var val_29 = 0;
            if(mem[1152921505097670656] != null)
            {
                    val_29 = val_29 + 1;
            }
            else
            {
                    var val_30 = mem[1152921505097670664];
                val_30 = val_30 + 2;
                Royal.Scenes.Game.Mechanics.Items.MatchItem.View.IMatchItemViewDelegate val_5 = 1152921505097633792 + val_30;
            }
            
            this.overlayView.sprite = this.itemAssets.GetSprite(matchType:  this.itemViewDelegate.MatchType);
            var val_31 = 0;
            if(mem[1152921505097670656] != null)
            {
                    val_31 = val_31 + 1;
            }
            else
            {
                    var val_32 = mem[1152921505097670664];
                val_32 = val_32 + 2;
                Royal.Scenes.Game.Mechanics.Items.MatchItem.View.IMatchItemViewDelegate val_8 = 1152921505097633792 + val_32;
            }
            
            this.shadowView.sprite = this.itemAssets.GetShadowSprite(matchType:  this.itemViewDelegate.MatchType);
            this.shadowParent.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            var val_33 = 0;
            if(mem[1152921505097670656] != null)
            {
                    val_33 = val_33 + 1;
            }
            else
            {
                    var val_34 = mem[1152921505097670664];
                val_34 = val_34 + 2;
                Royal.Scenes.Game.Mechanics.Items.MatchItem.View.IMatchItemViewDelegate val_12 = 1152921505097633792 + val_34;
            }
            
            if((this.itemViewDelegate.MatchType - 1) <= 4)
            {
                    var val_35 = 36605784 + ((val_13 - 1)) << 2;
                val_35 = val_35 + 36605784;
            }
            else
            {
                    UnityEngine.Quaternion val_26 = UnityEngine.Quaternion.identity;
                this.transform.localRotation = new UnityEngine.Quaternion() {x = val_26.x, y = val_26.y, z = val_26.z, w = val_26.w};
                this.overlayView.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
                this.shadowView.enabled = true;
                this.InitTransform(viewDelegate:  viewDelegate, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
            }
        
        }
        public override void UpdateSorting(Royal.Scenes.Game.Mechanics.Sortings.SortingData sortingData)
        {
            var val_6;
            sortingData.sortEverything = sortingData.sortEverything & 4294967295;
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.baseView, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = sortingData.sortEverything});
            int val_2 = (sortingData.layer >> 32) - 1;
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.shadowView, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {sortEverything = false});
            if(W9 != 0)
            {
                    val_6 = 0;
                Royal.Scenes.Game.Mechanics.Sortings.SortingData val_3 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetMatchItemOverlaySortingUnderChain();
            }
            else
            {
                    val_6 = 0;
                Royal.Scenes.Game.Mechanics.Sortings.SortingData val_4 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetMatchItemOverlaySorting();
            }
            
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.overlayView, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_4.layer, order = val_4.order, sortEverything = val_4.sortEverything & 4294967295});
        }
        public override Royal.Scenes.Game.Mechanics.Sortings.SortingData GetSorting()
        {
            int val_1 = this.baseView.sortingLayerID;
            int val_2 = this.baseView.sortingOrder;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {sortEverything = false};
        }
        public void SetSortingForCollect(int offset)
        {
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_1 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetMatchItemCollectSorting(offset:  offset);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.baseView, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_1.layer, order = val_1.order, sortEverything = val_1.sortEverything & 4294967295});
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_3 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetMatchItemCollectShadowSorting();
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.shadowView, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_3.layer, order = val_3.order, sortEverything = val_3.sortEverything & 4294967295});
        }
        public void SetSortingForCollectOnUi()
        {
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_2 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetMatchItemCollectUiSorting(order:  this.baseView.sortingOrder);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.baseView, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_2.layer, order = val_2.order, sortEverything = val_2.sortEverything & 4294967295});
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_5 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetMatchItemCollectUiSorting(order:  this.shadowView.sortingOrder);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.shadowView, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_5.layer, order = val_5.order, sortEverything = val_5.sortEverything & 4294967295});
        }
        public override int GetPoolId()
        {
            return 2;
        }
        public override void OnSpawn()
        {
        
        }
        public void Highlight(bool enable)
        {
            bool val_2 = enable;
            this.overlayView.gameObject.SetActive(value:  val_2);
            this.isHighlighted = val_2;
            if(enable == false)
            {
                    return;
            }
            
            this.SetHighlightRatio(ratio:  this.GetMaxHighlightRatio());
        }
        public void SetHighlightRatio(float ratio)
        {
            var val_3;
            if((ratio <= 0f) || (this.isHighlighted == true))
            {
                goto label_1;
            }
            
            val_3 = 1;
            goto label_2;
            label_1:
            if((this.isHighlighted == false) || ((Royal.Infrastructure.Utils.Math.NumberExtensions.Approximately(a:  ratio, b:  0f, precision:  0.001f)) == false))
            {
                goto label_4;
            }
            
            val_3 = 0;
            label_2:
            this.Highlight(enable:  false);
            label_4:
            UnityEngine.Color val_2 = this.overlayView.color;
            this.overlayView.color = new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = ratio};
        }
        public float GetHighlightRatio()
        {
            UnityEngine.Color val_1 = this.overlayView.color;
            return (float)val_1.a;
        }
        public override void OnRecycle()
        {
            this.Highlight(enable:  false);
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
            SetScale(vector:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            this.baseView.transform.localPosition = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            this.itemViewDelegate = 0;
            this.itemAssets = 0;
        }
        private System.Collections.IEnumerator ExplodeAnim(Royal.Scenes.Game.Mechanics.Explode.Trigger exploder)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .exploder = exploder;
            return (System.Collections.IEnumerator)new MatchItemView.<ExplodeAnim>d__22();
        }
        public void ExplodeItem(Royal.Scenes.Game.Mechanics.Explode.Trigger exploder)
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.ExplodeAnim(exploder:  exploder));
        }
        public void ExplodeAndMoveToPosition(UnityEngine.Vector3 targetPosition, int index, System.Action onComplete)
        {
            var val_5;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_1 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSpecialItemCreationSorting(negativeOffset:  index);
            bool val_2 = val_1.sortEverything & 4294967295;
            val_5 = null;
            val_5 = null;
            this.mergeCoroutine = Royal.Scenes.Game.Context.GameContext.ManualStartCoroutine(iEnumerator:  this.MergeCoroutine(endPosition:  new UnityEngine.Vector3() {x = targetPosition.x, y = targetPosition.y, z = targetPosition.z}, duration:  Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemView.TargetSpecialItemExplodeTime, easing:  Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemView.Easing, extrapolate:  true, onComplete:  onComplete));
        }
        public void CollectToGoal(UnityEngine.Vector3 goalPosition, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cellModel, Royal.Scenes.Game.Mechanics.Items.MatchItem.Collect.MatchCollectData collectData)
        {
            if((-1543842560) != 2)
            {
                    this.PlayParticle(extraEmit:  false);
            }
            
            UnityEngine.Coroutine val_2 = Royal.Scenes.Game.Context.GameContext.ManualStartCoroutine(iEnumerator:  Royal.Scenes.Game.Mechanics.Items.MatchItem.Collect.MatchBezierCollect.CollectToGoalAnimation(itemView:  this, itemViewDelegate:  this.itemViewDelegate, goalPosition:  new UnityEngine.Vector3() {x = goalPosition.x, y = goalPosition.y, z = goalPosition.z}, currentCell:  cellModel, collectData:  new Royal.Scenes.Game.Mechanics.Items.MatchItem.Collect.MatchCollectData() {orderedCells = new Royal.Scenes.Game.Mechanics.Matches.Cell14(), specialItemCreationCell = ???}));
        }
        public void CollectToManager(Royal.Scenes.Game.Mechanics.Items.MatchItem.Collect.ICollectManager collectManager, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cellModel, Royal.Scenes.Game.Mechanics.Items.MatchItem.Collect.MatchCollectData collectData)
        {
            if((-1543541936) != 2)
            {
                    this.PlayParticle(extraEmit:  false);
            }
            
            var val_4 = 0;
            if(mem[1152921505098203136] != null)
            {
                    val_4 = val_4 + 1;
            }
            else
            {
                    var val_5 = mem[1152921505098203144];
                val_5 = val_5 + 1;
                Royal.Scenes.Game.Mechanics.Items.MatchItem.Collect.ICollectManager val_1 = 1152921505098166272 + val_5;
            }
            
            collectManager.DecrementTarget();
            UnityEngine.Coroutine val_3 = Royal.Scenes.Game.Context.GameContext.ManualStartCoroutine(iEnumerator:  Royal.Scenes.Game.Mechanics.Items.MatchItem.Collect.MatchCollectManagerAnimation.Collect(itemView:  this, viewDelegate:  this.itemViewDelegate, collectManager:  collectManager, currentCell:  cellModel, collectData:  new Royal.Scenes.Game.Mechanics.Items.MatchItem.Collect.MatchCollectData() {orderedCells = new Royal.Scenes.Game.Mechanics.Matches.Cell14(), specialItemCreationCell = ???}));
        }
        private void PlayParticle(bool extraEmit)
        {
            Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory val_7 = 1;
            Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemExplodeParticles val_1 = 24029.Spawn<Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemExplodeParticles>(poolId:  4, activate:  true);
            var val_8 = 0;
            if(mem[1152921505097670656] != null)
            {
                    val_8 = val_8 + 1;
                val_7 = 2;
            }
            else
            {
                    var val_9 = mem[1152921505097670664];
                val_9 = val_9 + 2;
                Royal.Scenes.Game.Mechanics.Items.MatchItem.View.IMatchItemViewDelegate val_2 = 1152921505097633792 + val_9;
            }
            
            val_1.Init(type:  this.itemViewDelegate.MatchType, factory:  val_7 = 1);
            UnityEngine.Vector3 val_6 = this.transform.position;
            val_1.transform.position = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            val_1.Play(extraEmit:  extraEmit);
        }
        public float GetMaxHighlightRatio()
        {
            if(this.itemViewDelegate == null)
            {
                    return 1f;
            }
            
            var val_4 = 0;
            if(mem[1152921505097670656] != null)
            {
                    val_4 = val_4 + 1;
            }
            else
            {
                    var val_5 = mem[1152921505097670664];
                val_5 = val_5 + 2;
                Royal.Scenes.Game.Mechanics.Items.MatchItem.View.IMatchItemViewDelegate val_1 = 1152921505097633792 + val_5;
            }
            
            if((this.itemViewDelegate.MatchType - 1) <= 4)
            {
                    return 1f;
            }
            
            return 1f;
        }
        private System.Collections.IEnumerator MergeCoroutine(UnityEngine.Vector3 endPosition, float duration, Royal.Infrastructure.Utils.Animation.ManualEasingType easing, bool extrapolate, System.Action onComplete)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .duration = duration;
            .endPosition = endPosition;
            mem[1152921520243605588] = endPosition.y;
            mem[1152921520243605592] = endPosition.z;
            .easing = easing;
            .extrapolate = extrapolate;
            .onComplete = onComplete;
            return (System.Collections.IEnumerator)new MatchItemView.<MergeCoroutine>d__29();
        }
        public MatchItemView()
        {
        
        }
        private static MatchItemView()
        {
            Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemView.TargetSpecialItemExplodeTime = 0.2f;
            Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemView.ExplodeCompleteRatio = 0.85f;
            Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemView.Easing = 2;
        }
    
    }

}
