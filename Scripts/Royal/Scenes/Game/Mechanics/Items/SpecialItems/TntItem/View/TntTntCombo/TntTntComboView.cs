using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntTntCombo
{
    public class TntTntComboView : MonoBehaviour, IPoolable
    {
        // Fields
        public UnityEngine.Animator animator;
        public UnityEngine.Transform fuseTransform;
        public UnityEngine.Rendering.SortingGroup sortingGroup;
        private Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory;
        private System.Action onAnimationCompleted;
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntTntCombo.TntTntComboFuseParticles fuseParticles;
        
        // Methods
        public void Init(Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory factory, UnityEngine.Vector3 position, System.Action onComplete)
        {
            this.transform.position = new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z};
            this.itemFactory = factory;
            this.onAnimationCompleted = onComplete;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_2 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetTntTntExplodeSorting();
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(group:  this.sortingGroup, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_2.layer, order = val_2.order, sortEverything = val_2.sortEverything & 4294967295});
            this.StartFuseParticles();
        }
        private void StartFuseParticles()
        {
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntTntCombo.TntTntComboFuseParticles val_1 = this.itemFactory.Spawn<Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntTntCombo.TntTntComboFuseParticles>(poolId:  17, activate:  true);
            this.fuseParticles = val_1;
            UnityEngine.Transform val_2 = val_1.transform;
            val_2.SetParent(p:  this.fuseTransform);
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            val_2.localPosition = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        }
        private void Update()
        {
            if(this.onAnimationCompleted == null)
            {
                    return;
            }
            
            if(this.IsAnimationPlaying() != false)
            {
                    return;
            }
            
            this.PlayParticles();
            this.onAnimationCompleted.Invoke();
            this.itemFactory.Recycle<Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntTntCombo.TntTntComboFuseParticles>(go:  this.fuseParticles);
            this.itemFactory.Recycle<Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntTntCombo.TntTntComboView>(go:  this);
        }
        private bool IsAnimationPlaying()
        {
            float val_3;
            UnityEngine.AnimatorStateInfo val_1 = this.animator.GetCurrentAnimatorStateInfo(layerIndex:  0);
            return (bool)(val_3 < 0) ? 1 : 0;
        }
        private void PlayParticles()
        {
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntTntCombo.Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.Combo.TntTntComboExplodeParticles val_1 = this.itemFactory.Spawn<Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntTntCombo.Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.Combo.TntTntComboExplodeParticles>(poolId:  21, activate:  true);
            val_1.Play();
            UnityEngine.Vector3 val_4 = this.transform.position;
            val_1.transform.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        }
        public int GetPoolId()
        {
            return 14;
        }
        public void OnSpawn()
        {
        
        }
        public void OnRecycle()
        {
            this.onAnimationCompleted = 0;
        }
        public TntTntComboView()
        {
        
        }
    
    }

}
