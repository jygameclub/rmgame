using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Boosters.Arrow.View
{
    public class ArrowBoosterView : MonoBehaviour
    {
        // Fields
        private static readonly int ArrowFallAnimationStateId;
        private const float DefaultOffset = 1.715;
        private const float WideScreenOffset = 3.43;
        public UnityEngine.Animator animator;
        public UnityEngine.Transform arrow;
        public UnityEngine.Transform target;
        public UnityEngine.ParticleSystem particles;
        public UnityEngine.Rendering.SortingGroup sortingGroup;
        private float offset;
        private System.Action onComplete;
        private Royal.Scenes.Game.Mechanics.Explode.ExplodeData exploder;
        private System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> cellList;
        private System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> explodedCells;
        
        // Methods
        private void Awake()
        {
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            this.transform.localPosition = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            this.animator.enabled = false;
        }
        public void Init(int upOffset, float rightOffset, bool isWide)
        {
            this.offset = (isWide != true) ? 3.43f : 1.715f;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_2 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetArrowBoosterUseSorting();
            this.sortingGroup.sortingLayerID = val_2.layer;
            this.sortingGroup.sortingOrder = val_2.layer >> 32;
            UnityEngine.Transform val_4 = this.sortingGroup.transform;
            UnityEngine.Vector3 val_5 = val_4.localPosition;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  (float)upOffset);
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            val_4.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            UnityEngine.Vector3 val_9 = this.arrow.localPosition;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.left;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, d:  this.offset);
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            this.arrow.localPosition = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
            UnityEngine.Vector3 val_13 = this.target.localPosition;
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.right;
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, d:  rightOffset);
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, b:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
            this.target.localPosition = new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z};
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.zero;
            this.target.localScale = new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z};
            this.explodedCells = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel>(capacity:  10);
        }
        public void PlayIn(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data, System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> cells, System.Action onCompleteAction)
        {
            this.cellList = cells;
            mem[1152921523907838800] = data.id;
            this.exploder = data.point.x;
            this.onComplete = onCompleteAction;
            UnityEngine.Vector3 val_1 = this.target.localPosition;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.left;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  this.offset);
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            this.PlayTargetAnimation(targetPosition:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            this.PlayArrowAnimation(targetPosition:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        }
        private void PlayTargetAnimation(UnityEngine.Vector3 targetPosition)
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_2 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.21f);
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.target, endValue:  new UnityEngine.Vector3() {x = targetPosition.x, y = targetPosition.y, z = targetPosition.z}, duration:  0.1f, snapping:  false), ease:  27));
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.target, endValue:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, duration:  0.1f), ease:  27));
        }
        private void PlayArrowAnimation(UnityEngine.Vector3 targetPosition)
        {
            this.PrepareParticles();
            UnityEngine.Coroutine val_2 = Royal.Scenes.Game.Context.GameContext.ManualStartCoroutine(iEnumerator:  this.PlayArrowWithAnimator(targetPosition:  new UnityEngine.Vector3() {x = targetPosition.x, y = targetPosition.y, z = targetPosition.z}));
        }
        private System.Collections.IEnumerator PlayArrowWithAnimator(UnityEngine.Vector3 targetPosition)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .targetPosition = targetPosition;
            mem[1152921523908333684] = targetPosition.y;
            mem[1152921523908333688] = targetPosition.z;
            return (System.Collections.IEnumerator)new ArrowBoosterView.<PlayArrowWithAnimator>d__18();
        }
        private void PlaySound()
        {
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16).PlaySound(type:  7, offset:  0.04f);
        }
        private void PlayFallAnimation()
        {
            this.animator.speed = 1f;
            UnityEngine.Vector3 val_1 = this.arrow.localPosition;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.right;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            this.arrow.localPosition = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            this.animator.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Boosters.Arrow.View.ArrowBoosterView.WideScreenOffset, layer:  0, normalizedTime:  0f);
            DG.Tweening.Sequence val_4 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_4, interval:  0.15f);
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  20f);
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_4, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.animator.transform, endValue:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, duration:  0.5f, snapping:  false), ease:  5));
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_4, action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Game.Mechanics.Boosters.Arrow.View.ArrowBoosterView::<PlayFallAnimation>b__20_0()));
        }
        private void ExplodeRemainingCells()
        {
            if(W9 == this.explodedCells)
            {
                    return;
            }
            
            if(this.explodedCells < 1)
            {
                    return;
            }
            
            var val_2 = 0;
            do
            {
                if(val_2 >= this.explodedCells)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                if((this.explodedCells.Contains(item:  System.Collections.Generic.List<T>.__il2cppRuntimeField_byval_arg)) != true)
            {
                    this.ExplodeCell(cell:  System.Collections.Generic.List<T>.__il2cppRuntimeField_byval_arg);
            }
            
                val_2 = val_2 + 1;
            }
            while(val_2 < null);
        
        }
        private void ExplodeCell(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            cell.FreezeFall();
            this.explodedCells.Add(item:  cell);
            cell.ExplodeCurrentItem(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = this.exploder, y = this.exploder}, trigger = this.exploder, id = 1152921519913717856});
        }
        private void UnfreezeAll()
        {
            bool val_1 = true;
            var val_2 = 0;
            do
            {
                if(val_2 >= val_1)
            {
                    return;
            }
            
                if(val_1 <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_1 = val_1 + 0;
                (true + 0) + 32.UnFreezeFall();
                val_2 = val_2 + 1;
            }
            while(this.explodedCells != null);
            
            throw new NullReferenceException();
        }
        private static bool ShouldCallExplode(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cellModel, UnityEngine.Vector3 currentPos)
        {
            UnityEngine.Vector3 val_1 = cellModel.GetViewPosition();
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = currentPos.x, y = currentPos.y, z = currentPos.z});
            return (bool)(System.Math.Abs(val_2.x) < 0) ? 1 : 0;
        }
        private void PrepareParticles()
        {
            UnityEngine.Transform val_1 = this.particles.transform;
            val_1.SetParent(p:  this.arrow);
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.left;
            val_1.localPosition = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            this.particles.Play();
        }
        public ArrowBoosterView()
        {
        
        }
        private static ArrowBoosterView()
        {
            Royal.Scenes.Game.Mechanics.Boosters.Arrow.View.ArrowBoosterView.WideScreenOffset = UnityEngine.Animator.StringToHash(name:  "Base Layer.ArrowFallAnimation");
        }
        private void <PlayFallAnimation>b__20_0()
        {
            this.onComplete.Invoke();
            UnityEngine.Object.Destroy(obj:  this.gameObject);
        }
    
    }

}
