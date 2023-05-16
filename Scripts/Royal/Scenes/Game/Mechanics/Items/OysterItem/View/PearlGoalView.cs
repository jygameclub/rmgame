using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.OysterItem.View
{
    public class PearlGoalView : MonoBehaviour, IPoolable
    {
        // Fields
        public UnityEngine.SpriteRenderer pearl;
        public UnityEngine.SpriteRenderer[] pearlShadows;
        public UnityEngine.Transform pearlShadow;
        private Royal.Scenes.Game.Mechanics.Items.OysterItem.View.IOysterItemViewDelegate viewDelegate;
        private Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory;
        private Royal.Scenes.Game.Levels.Units.GoalManager goalManager;
        private Royal.Scenes.Game.Levels.Units.State.GameStateManager stateManager;
        
        // Methods
        public void Play(Royal.Scenes.Game.Mechanics.Items.OysterItem.View.IOysterItemViewDelegate viewDelegate)
        {
            this.viewDelegate = viewDelegate;
            this.itemFactory = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1);
            this.goalManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.GoalManager>(contextId:  11);
            this.stateManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
            this.transform.localScale = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            UnityEngine.Coroutine val_7 = this.StartCoroutine(routine:  this.CurveToGoal());
        }
        public int GetPoolId()
        {
            return 82;
        }
        public void OnSpawn()
        {
        
        }
        public void OnRecycle()
        {
        
        }
        private void UpdateSorting(Royal.Scenes.Game.Mechanics.Sortings.SortingData sortingData)
        {
            bool val_5 = sortingData.sortEverything;
            val_5 = val_5 & 4294967295;
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.pearl, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = val_5});
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_1 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = val_5}, offset:  0);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.pearlShadows[0], data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_1.layer, order = val_1.order, sortEverything = val_1.sortEverything & 4294967295});
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_3 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = val_5}, offset:  0);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.pearlShadows[1], data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_3.layer, order = val_3.order, sortEverything = val_3.sortEverything & 4294967295});
        }
        private System.Collections.IEnumerator CurveToGoal()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new PearlGoalView.<CurveToGoal>d__12();
        }
        public PearlGoalView()
        {
        
        }
    
    }

}
