using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Boosters.Cannon.View
{
    public class CannonBoosterBallView : MonoBehaviour
    {
        // Fields
        public UnityEngine.SpriteRenderer ball;
        public UnityEngine.ParticleSystem particles;
        
        // Methods
        public void UpdateSorting(Royal.Scenes.Game.Mechanics.Sortings.SortingData sorting)
        {
            sorting.sortEverything = sorting.sortEverything & 4294967295;
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(group:  this.GetComponent<UnityEngine.Rendering.SortingGroup>(), data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sorting.layer, order = sorting.order, sortEverything = sorting.sortEverything});
        }
        public void Play(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data, UnityEngine.Vector3 ballTarget, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel startCell)
        {
            this.particles.Play();
            UnityEngine.Coroutine val_3 = Royal.Scenes.Game.Context.GameContext.ManualStartCoroutine(iEnumerator:  this.MoveToGlobalAndDestroy(exploder:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id}, trans:  this.transform, targetPosition:  new UnityEngine.Vector3() {x = ballTarget.x, y = ballTarget.y, z = ballTarget.z}, startCell:  startCell));
        }
        private System.Collections.IEnumerator MoveToGlobalAndDestroy(Royal.Scenes.Game.Mechanics.Explode.ExplodeData exploder, UnityEngine.Transform trans, UnityEngine.Vector3 targetPosition, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel startCell)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .targetPosition = targetPosition;
            mem[1152921523904311536] = targetPosition.y;
            mem[1152921523904311540] = targetPosition.z;
            .exploder = exploder.point.x;
            mem[1152921523904311528] = exploder.id;
            .trans = trans;
            .startCell = startCell;
            return (System.Collections.IEnumerator)new CannonBoosterBallView.<MoveToGlobalAndDestroy>d__4();
        }
        protected bool ShouldCallExplode(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cellModel, UnityEngine.Vector3 currentPos)
        {
            UnityEngine.Vector3 val_1 = cellModel.GetViewPosition();
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = currentPos.x, y = currentPos.y, z = currentPos.z});
            return (bool)(System.Math.Abs(val_2.y) < 0) ? 1 : 0;
        }
        public void Hide()
        {
            this.gameObject.SetActive(value:  false);
        }
        public void Show()
        {
            this.gameObject.SetActive(value:  true);
        }
        public CannonBoosterBallView()
        {
        
        }
    
    }

}
