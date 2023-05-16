using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.DrillItem.View
{
    public class DrillItemView : ItemView
    {
        // Fields
        private static readonly int DrillIdleAnimation;
        private static readonly int DrillHitAnimation;
        private static readonly int DrillStartAnimation;
        private static readonly int DrillSpinAnimation;
        public const float DrillSpeed = 13.5;
        public const float DrillAcceleration = 0.18;
        public UnityEngine.GameObject drillHolder;
        public UnityEngine.SpriteRenderer[] drillSprites;
        public UnityEngine.SpriteRenderer headSprite;
        public UnityEngine.SpriteRenderer startHead;
        public UnityEngine.Transform baseView;
        public Royal.Scenes.Game.Mechanics.Items.DrillItem.View.DrillCounter counter;
        public UnityEngine.Animator drillAnimator;
        private Royal.Scenes.Game.Levels.Units.CellGridManager cellGridManager;
        private Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillDirection direction;
        private Royal.Scenes.Game.Mechanics.Items.DrillItem.Strategy.DrillStrategy drillStrategy;
        private Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillHelper drillHelper;
        private Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillManager drillManager;
        private Royal.Scenes.Game.Levels.Units.State.GameStateManager stateManager;
        private Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillItemAssets itemAssets;
        private Royal.Scenes.Game.Mechanics.Items.DrillItem.View.IDrillItemViewDelegate viewDelegate;
        private UnityEngine.Coroutine drillHitRoutine;
        private bool playingStartAnimation;
        
        // Methods
        public void Init(Royal.Scenes.Game.Mechanics.Items.DrillItem.View.IDrillItemViewDelegate viewDelegate, UnityEngine.Vector3 position, Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillDirection direction, Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillManager drillManager, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel currentCell)
        {
            Royal.Scenes.Game.Mechanics.Items.DrillItem.Strategy.DrillStrategy val_9;
            this.direction = direction;
            this.viewDelegate = viewDelegate;
            this.drillManager = drillManager;
            this.stateManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14);
            this.cellGridManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.CellGridManager>(contextId:  2);
            this.InitTransform(viewDelegate:  viewDelegate, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
            this.itemAssets = Load<Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillItemAssets>();
            this.drillHelper = Royal.Scenes.Game.Levels.LevelContext.GetLate<Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillHelper>(contextId:  31);
            drillManager.Init(drillView:  this, drillDirection:  direction);
            this.drillAnimator.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.DrillItem.View.DrillItemView.DrillAcceleration);
            this.InitDrill(color:  drillManager.matchType, drillDirection:  direction);
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_5 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetDrillSorting(point:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = currentCell, y = currentCell});
            bool val_6 = val_5.sortEverything & 4294967295;
            if(direction <= 1)
            {
                    Royal.Scenes.Game.Mechanics.Items.DrillItem.Strategy.HorizontalDrillStrategy val_7 = null;
                val_9 = val_7;
                val_7 = new Royal.Scenes.Game.Mechanics.Items.DrillItem.Strategy.HorizontalDrillStrategy(view:  this, itemFactory:  currentCell, direction:  direction);
            }
            else
            {
                    Royal.Scenes.Game.Mechanics.Items.DrillItem.Strategy.VerticalDrillStrategy val_8 = null;
                val_9 = val_8;
                val_8 = new Royal.Scenes.Game.Mechanics.Items.DrillItem.Strategy.VerticalDrillStrategy(view:  this, itemFactory:  currentCell, direction:  direction);
            }
            
            this.drillStrategy = val_9;
            this.headSprite.enabled = true;
            this.startHead.enabled = false;
        }
        public override void UpdateSorting(Royal.Scenes.Game.Mechanics.Sortings.SortingData sortingData)
        {
            bool val_3 = sortingData.sortEverything;
            val_3 = val_3 & 4294967295;
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(group:  12854, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = val_3});
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_1 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = val_3}, offset:  110);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(textMeshPro:  this.counter.countText, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_1.layer, order = val_1.order, sortEverything = val_1.sortEverything & 4294967295});
        }
        private void InitDrill(Royal.Scenes.Game.Mechanics.Matches.MatchType color, Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillDirection drillDirection)
        {
            var val_41 = 0;
            label_6:
            if(val_41 >= this.drillSprites.Length)
            {
                goto label_2;
            }
            
            this.drillSprites[val_41].sprite = this.itemAssets.GetDrillSprite(matchType:  color);
            val_41 = val_41 + 1;
            if(this.drillSprites != null)
            {
                goto label_6;
            }
            
            throw new NullReferenceException();
            label_2:
            if(drillDirection <= 3)
            {
                    var val_42 = 36597248 + (drillDirection) << 2;
                val_42 = val_42 + 36597248;
            }
            else
            {
                    throw new System.ArgumentOutOfRangeException(paramName:  "drillDirection", actualValue:  ???, message:  0);
            }
        
        }
        public override int GetPoolId()
        {
            return 106;
        }
        public override void OnSpawn()
        {
        
        }
        public override void OnRecycle()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
            this.baseView.localScale = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            this.baseView.localPosition = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            this.headSprite.sprite = this.itemAssets.GetInitialHeadSprite();
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
            this.drillHolder.transform.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            Royal.Infrastructure.Utils.Text.TextMeshProExtensions.ChangeAlpha(tmp:  this.counter.countText, alpha:  1f);
            UnityEngine.Quaternion val_7 = UnityEngine.Quaternion.identity;
            this.drillHolder.transform.localRotation = new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w};
            this.playingStartAnimation = false;
        }
        public void StartDrill()
        {
            float val_3;
            var val_8;
            12851.PlaySfx(type:  103, offset:  0.04f);
            UnityEngine.AnimatorStateInfo val_1 = this.drillAnimator.GetCurrentAnimatorStateInfo(layerIndex:  0);
            val_8 = null;
            val_8 = null;
            if( != Royal.Scenes.Game.Mechanics.Items.DrillItem.View.DrillItemView.DrillHitAnimation)
            {
                goto label_5;
            }
            
            if(val_3 <= 0.4f)
            {
                goto label_6;
            }
            
            val_8 = null;
            label_5:
            this.drillAnimator.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.DrillItem.View.DrillItemView.DrillStartAnimation, layer:  0, normalizedTime:  0f);
            goto label_10;
            label_6:
            this.drillAnimator.CrossFade(stateHashName:  Royal.Scenes.Game.Mechanics.Items.DrillItem.View.DrillItemView.DrillStartAnimation, normalizedTransitionDuration:  0.1f, layer:  0, normalizedTimeOffset:  0.125f);
            label_10:
            this.Invoke(methodName:  "ShakeGrid", time:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  59f));
            UnityEngine.Coroutine val_7 = this.StartCoroutine(routine:  this.StartSpinAnimationAfterStartAnimationEnds());
        }
        private void ShakeGrid()
        {
            float val_2;
            float val_3;
            Royal.Infrastructure.Utils.Animation.ShakeAnimationConfig val_1 = Royal.Infrastructure.Utils.Animation.ShakeAnimationConfig.DrillConfig;
            this.cellGridManager.ShakeGrid(config:  new Royal.Infrastructure.Utils.Animation.ShakeAnimationConfig() {delay = val_3, duration = val_3, minVibrate = val_3, midVibrate = val_3, maxVibrate = val_2, shouldScale = val_2, shouldVisitCenter = val_2});
        }
        public void MoveDrill(Royal.Scenes.Game.Mechanics.Explode.ExplodeData exploder, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, Royal.Scenes.Game.Mechanics.Matches.Cell14 cellsOnPath, Royal.Scenes.Game.Mechanics.Matches.Cell14 cellsOnDrill, bool haveWaited)
        {
            haveWaited = haveWaited;
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.MoveDrillDelayed(exploder:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = exploder.point.x}, id = exploder.id}, cell:  cell, cellsOnPath:  new Royal.Scenes.Game.Mechanics.Matches.Cell14(), cellsOnDrill:  new Royal.Scenes.Game.Mechanics.Matches.Cell14(), haveWaited:  haveWaited));
        }
        private System.Collections.IEnumerator MoveDrillDelayed(Royal.Scenes.Game.Mechanics.Explode.ExplodeData exploder, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, Royal.Scenes.Game.Mechanics.Matches.Cell14 cellsOnPath, Royal.Scenes.Game.Mechanics.Matches.Cell14 cellsOnDrill, bool haveWaited)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .cell = cell;
            mem[1152921520358647296] = exploder.id;
            .exploder = exploder.point.x;
            .haveWaited = haveWaited;
            return (System.Collections.IEnumerator)new DrillItemView.<MoveDrillDelayed>d__32();
        }
        private System.Collections.IEnumerator StartSpinAnimationAfterStartAnimationEnds()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new DrillItemView.<StartSpinAnimationAfterStartAnimationEnds>d__33();
        }
        private int CalculateStartHeadIndex()
        {
            var val_3 = 0;
            label_9:
            if(val_3 >= (this.itemAssets.startSprites.Length << ))
            {
                goto label_4;
            }
            
            if(this.headSprite.sprite == this.itemAssets.startSprites[val_3])
            {
                    return (int)val_3;
            }
            
            val_3 = val_3 + 1;
            if(this.itemAssets != null)
            {
                goto label_9;
            }
            
            throw new NullReferenceException();
            label_4:
            val_3 = 0;
            return (int)val_3;
        }
        private Royal.Scenes.Game.Mechanics.Items.DrillItem.View.DrillTracerParticles CreateDrillTracerParticles()
        {
            Royal.Scenes.Game.Mechanics.Items.DrillItem.View.DrillTracerParticles val_1 = 12844.Spawn<Royal.Scenes.Game.Mechanics.Items.DrillItem.View.DrillTracerParticles>(poolId:  107, activate:  true);
            UnityEngine.Transform val_2 = val_1.transform;
            val_2.SetParent(p:  this.drillHolder.transform);
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  0f, y:  -0.5f);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
            val_2.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.identity;
            val_2.localRotation = new UnityEngine.Quaternion() {x = val_6.x, y = val_6.y, z = val_6.z, w = val_6.w};
            val_1.tracerParticle.Play();
            return val_1;
        }
        public void DrillEnd()
        {
            this.drillManager = 0;
            this.drillManager = 0;
            this.stateManager.OperationFinish(animationId:  12);
        }
        public void TryExplodeWaitingDrill()
        {
            if(this.drillHelper != null)
            {
                    this.drillHelper.TryExplodeWaitingDrill();
                return;
            }
            
            throw new NullReferenceException();
        }
        public void TryPlayHitAnimation()
        {
            float val_3;
            var val_5;
            var val_6;
            UnityEngine.AnimatorStateInfo val_1 = this.drillAnimator.GetCurrentAnimatorStateInfo(layerIndex:  0);
            val_5 = null;
            val_5 = null;
            if( != Royal.Scenes.Game.Mechanics.Items.DrillItem.View.DrillItemView.DrillHitAnimation)
            {
                goto label_6;
            }
            
            if(val_3 < 0)
            {
                    return;
            }
            
            if(val_3 >= 0)
            {
                goto label_6;
            }
            
            val_6 = 1;
            goto label_7;
            label_6:
            val_6 = 0;
            label_7:
            this.PlayHitAnimation(hitDuringAnimation:  false);
        }
        private void PlayHitAnimation(bool hitDuringAnimation)
        {
            this.headSprite.enabled = false;
            this.startHead.enabled = true;
            PlaySfx(type:  SelectRandomClip(from:  101, to:  102), offset:  0.04f);
            this.counter.hitParticles.sparkParticles.Play();
            this.drillAnimator.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.DrillItem.View.DrillItemView.DrillHitAnimation, layer:  0, normalizedTime:  0f);
            if(this.drillHitRoutine != null)
            {
                    this.StopCoroutine(routine:  this.drillHitRoutine);
                this.drillHitRoutine = 0;
            }
            
            this.drillHitRoutine = this.StartCoroutine(routine:  this.HitDrillHead(hitDuringAnimation:  hitDuringAnimation));
        }
        private System.Collections.IEnumerator HitDrillHead(bool hitDuringAnimation)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .hitDuringAnimation = hitDuringAnimation;
            return (System.Collections.IEnumerator)new DrillItemView.<HitDrillHead>d__40();
        }
        private int CalculateHitHeadIndex()
        {
            var val_3 = 0;
            label_9:
            if(val_3 >= (this.itemAssets.hitSprites.Length << ))
            {
                goto label_4;
            }
            
            if(this.startHead.sprite == this.itemAssets.hitSprites[val_3])
            {
                    return (int)val_3;
            }
            
            val_3 = val_3 + 1;
            if(this.itemAssets != null)
            {
                goto label_9;
            }
            
            throw new NullReferenceException();
            label_4:
            val_3 = 0;
            return (int)val_3;
        }
        public DrillItemView()
        {
        
        }
        private static DrillItemView()
        {
            Royal.Scenes.Game.Mechanics.Items.DrillItem.View.DrillItemView.DrillAcceleration = UnityEngine.Animator.StringToHash(name:  12855);
            Royal.Scenes.Game.Mechanics.Items.DrillItem.View.DrillItemView.DrillHitAnimation = UnityEngine.Animator.StringToHash(name:  "Base Layer.DrillHitAnimation");
            Royal.Scenes.Game.Mechanics.Items.DrillItem.View.DrillItemView.DrillStartAnimation = UnityEngine.Animator.StringToHash(name:  "Base Layer.DrillStartAnimation");
            Royal.Scenes.Game.Mechanics.Items.DrillItem.View.DrillItemView.DrillSpinAnimation = UnityEngine.Animator.StringToHash(name:  "Base Layer.DrillSpinAnimation");
        }
    
    }

}
