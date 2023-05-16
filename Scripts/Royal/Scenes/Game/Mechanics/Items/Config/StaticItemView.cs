using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.Config
{
    public abstract class StaticItemView : MonoBehaviour, IPoolable
    {
        // Fields
        public UnityEngine.Rendering.SortingGroup sortingGroup;
        protected Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory;
        protected Royal.Scenes.Game.Levels.Units.Sfx.GameSfxManager sfxManager;
        private bool <IsHidden>k__BackingField;
        
        // Properties
        public bool IsHidden { get; set; }
        
        // Methods
        public bool get_IsHidden()
        {
            return (bool)this.<IsHidden>k__BackingField;
        }
        protected void set_IsHidden(bool value)
        {
            this.<IsHidden>k__BackingField = value;
        }
        protected virtual void Awake()
        {
            this.itemFactory = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1);
            this.sfxManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.Sfx.GameSfxManager>(contextId:  22);
        }
        protected void InitTransform(Royal.Scenes.Game.Mechanics.Board.Cell.StaticItemType type, UnityEngine.Vector3 position)
        {
            UnityEngine.Transform val_1 = this.transform;
            val_1.SetParent(p:  this.itemFactory.<ItemParent>k__BackingField);
            val_1.localPosition = new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z};
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
            val_1.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        }
        public virtual void UpdateSorting(Royal.Scenes.Game.Mechanics.Sortings.SortingData sortingData)
        {
            sortingData.sortEverything = sortingData.sortEverything & 4294967295;
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(group:  this.sortingGroup, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = sortingData.sortEverything});
        }
        public Royal.Scenes.Game.Mechanics.Sortings.SortingData GetSorting()
        {
            int val_1 = this.sortingGroup.sortingLayerID;
            int val_2 = this.sortingGroup.sortingOrder;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {sortEverything = false};
        }
        public void RecycleSelf()
        {
            this.itemFactory.Recycle<Royal.Scenes.Game.Mechanics.Items.Config.StaticItemView>(go:  this);
        }
        public abstract int GetPoolId(); // 0
        public abstract void OnSpawn(); // 0
        public abstract void OnRecycle(); // 0
        public virtual void Hide()
        {
            this.<IsHidden>k__BackingField = true;
            this.gameObject.SetActive(value:  false);
        }
        public virtual void Show()
        {
            this.<IsHidden>k__BackingField = false;
            this.gameObject.SetActive(value:  true);
        }
        protected StaticItemView()
        {
        
        }
    
    }

}
