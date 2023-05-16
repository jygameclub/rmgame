using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Boosters.Hammer.View
{
    public class HammerBoosterView : MonoBehaviour
    {
        // Fields
        public UnityEngine.Animator animator;
        public UnityEngine.ParticleSystem explodeParticles;
        public UnityEngine.Transform rootView;
        public UnityEngine.SpriteRenderer baseView;
        public UnityEngine.SpriteRenderer shadow;
        public UnityEngine.SpriteRenderer topPart;
        public UnityEngine.SpriteRenderer handlePart;
        private UnityEngine.Vector3 originalPosition;
        private Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory;
        
        // Methods
        private void Awake()
        {
            if(this.animator != null)
            {
                    this.animator.enabled = false;
                return;
            }
            
            throw new NullReferenceException();
        }
        public void Init(UnityEngine.Vector3 position, bool overUi, Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory factory)
        {
            this.itemFactory = factory;
            this.originalPosition = position;
            mem[1152921523900124772] = position.y;
            mem[1152921523900124776] = position.z;
            UnityEngine.Vector3 val_3 = this.animator.transform.localPosition;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.originalPosition, y = position.y, z = position.x}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            this.transform.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            this.SetSorting(overUi:  overUi);
        }
        private void SetSorting(bool overUi)
        {
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_1 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetHammerBoosterUseSorting();
            if(overUi != false)
            {
                    0 = 0;
                Royal.Scenes.Game.Mechanics.Sortings.SortingData val_2 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetHammerBoosterUseSortingOverUi();
            }
            
            this.shadow.sortingLayerID = val_2.layer;
            this.shadow.sortingOrder = 0;
            this.baseView.sortingLayerID = val_2.layer;
            int val_3 = val_2.layer >> 32;
            this.baseView.sortingOrder = val_3;
            this.handlePart.sortingLayerID = val_2.layer;
            this.handlePart.sortingOrder = val_3 + 1;
            this.topPart.sortingLayerID = val_2.layer;
            this.topPart.sortingOrder = val_3 + 2;
        }
        public void PlayIn(UnityEngine.Vector3 toPosition, bool isTopCell, System.Action onExplode, System.Action onDestroy)
        {
            isTopCell = isTopCell;
            UnityEngine.Coroutine val_2 = Royal.Scenes.Game.Context.GameContext.ManualStartCoroutine(iEnumerator:  this.PlayInAnimation(toPosition:  new UnityEngine.Vector3() {x = toPosition.x, y = toPosition.y, z = toPosition.z}, isTopCell:  isTopCell, onExplode:  onExplode, onDestroy:  onDestroy));
        }
        private System.Collections.IEnumerator PlayInAnimation(UnityEngine.Vector3 toPosition, bool isTopCell, System.Action onExplode, System.Action onDestroy)
        {
            .<>1__state = 0;
            .onDestroy = onDestroy;
            .<>4__this = this;
            .toPosition = toPosition;
            mem[1152921523900627908] = toPosition.y;
            mem[1152921523900627912] = toPosition.z;
            .isTopCell = isTopCell;
            .onExplode = onExplode;
            return (System.Collections.IEnumerator)new HammerBoosterView.<PlayInAnimation>d__13();
        }
        public HammerBoosterView()
        {
        
        }
    
    }

}
