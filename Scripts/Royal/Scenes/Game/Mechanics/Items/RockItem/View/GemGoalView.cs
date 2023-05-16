using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.RockItem.View
{
    public class GemGoalView : MonoBehaviour, IPoolable
    {
        // Fields
        public UnityEngine.SpriteRenderer[] gems;
        public UnityEngine.SpriteRenderer[] gemShadows;
        public Royal.Scenes.Game.Levels.Units.RemainingMoves.RemainingMovesCoinTracer[] tracers;
        private Royal.Scenes.Game.Mechanics.Items.RockItem.View.IRockItemViewDelegate viewDelegate;
        private Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory;
        private Royal.Scenes.Game.Levels.Units.GoalManager goalManager;
        private Royal.Scenes.Game.Levels.Units.State.GameStateManager stateManager;
        private Royal.Infrastructure.Utils.Randoming.RandomManager randomManager;
        public static float StartSpeed;
        public static float MinSpeed;
        public static float MaxSpeed;
        
        // Methods
        public void Play(Royal.Scenes.Game.Mechanics.Items.RockItem.View.IRockItemViewDelegate viewDelegate)
        {
            this.viewDelegate = viewDelegate;
            this.itemFactory = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1);
            this.goalManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.GoalManager>(contextId:  11);
            this.stateManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14);
            this.randomManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Utils.Randoming.RandomManager>(id:  5);
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_7 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetPearlCollectSorting(offset:  1000 - (this.stateManager.GetOperationCount(animationId:  5)));
            this.UpdateSorting(sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_7.layer, order = val_7.order, sortEverything = val_7.sortEverything & 4294967295});
            this.goalManager.FlyingToBeCollected(goalType:  34);
            this.stateManager.OperationStart(animationId:  5);
            bool val_9 = this.randomManager.NextBool();
            bool val_10 = this.randomManager.NextBool();
            bool val_11 = this.randomManager.NextBool();
            bool val_12 = val_9 ^ val_11;
            val_12 = val_12 | val_10 ^ val_11;
            int val_16 = this.randomManager.Next(min:  0, max:  2);
            UnityEngine.Coroutine val_21 = this.StartCoroutine(routine:  this.CurveGemToGoal(isMain:  true, index:  0, inverseSign:  val_9, differentRandom:  false, randomStartFrameDelay:  0));
            UnityEngine.Coroutine val_24 = this.StartCoroutine(routine:  this.CurveGemToGoal(isMain:  false, index:  1, inverseSign:  val_10, differentRandom:  true, randomStartFrameDelay:  (val_16 == 1) ? (1 + 1) : 1));
            UnityEngine.Coroutine val_28 = this.StartCoroutine(routine:  this.CurveGemToGoal(isMain:  false, index:  2, inverseSign:  ((val_12 != true) ? (val_11) : (!val_9)) & 1, differentRandom:  val_9 ^ val_10, randomStartFrameDelay:  (val_16 != 1) ? (1 + 1) : 1));
        }
        public int GetPoolId()
        {
            return 103;
        }
        public void OnSpawn()
        {
        
        }
        public void OnRecycle()
        {
            UnityEngine.SpriteRenderer val_12 = this.gems[0];
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
            val_12.transform.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            val_12.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.SpriteRenderer val_13 = this.gems[1];
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  0.3663557f);
            val_13.transform.localScale = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            val_13.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.SpriteRenderer val_14 = this.gems[2];
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, d:  0.427721f);
            val_14.transform.localScale = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
            val_14.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            var val_16 = 0;
            label_21:
            if(val_16 >= (this.gems.Length << ))
            {
                goto label_19;
            }
            
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.ChangeAlpha(sprite:  this.gems[val_16], alpha:  1f);
            val_16 = val_16 + 1;
            if(this.gems != null)
            {
                goto label_21;
            }
            
            label_19:
            var val_18 = 0;
            do
            {
                if(val_18 >= (this.gemShadows.Length << ))
            {
                    return;
            }
            
                Royal.Infrastructure.Utils.Sprite.SpriteExtensions.ChangeAlpha(sprite:  this.gemShadows[val_18], alpha:  0.39216f);
                val_18 = val_18 + 1;
            }
            while(this.gemShadows != null);
            
            throw new NullReferenceException();
        }
        private void UpdateSorting(Royal.Scenes.Game.Mechanics.Sortings.SortingData sortingData)
        {
            bool val_14 = sortingData.sortEverything;
            val_14 = val_14 & 4294967295;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_1 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = val_14}, offset:  5);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.gems[0], data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_1.layer, order = val_1.order, sortEverything = val_1.sortEverything & 4294967295});
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_3 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = val_14}, offset:  4);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.gemShadows[0], data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_3.layer, order = val_3.order, sortEverything = val_3.sortEverything & 4294967295});
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_5 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = val_14}, offset:  3);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.gems[1], data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_5.layer, order = val_5.order, sortEverything = val_5.sortEverything & 4294967295});
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_7 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = val_14}, offset:  2);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.gemShadows[1], data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_7.layer, order = val_7.order, sortEverything = val_7.sortEverything & 4294967295});
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_9 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = val_14}, offset:  1);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.gems[2], data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_9.layer, order = val_9.order, sortEverything = val_9.sortEverything & 4294967295});
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_11 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = val_14}, offset:  0);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.gemShadows[2], data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_11.layer, order = val_11.order, sortEverything = val_11.sortEverything & 4294967295});
        }
        private System.Collections.IEnumerator CurveGemToGoal(bool isMain, int index, bool inverseSign, bool differentRandom, int randomStartFrameDelay)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .index = index;
            .isMain = isMain;
            .inverseSign = inverseSign;
            .differentRandom = differentRandom;
            .randomStartFrameDelay = randomStartFrameDelay;
            return (System.Collections.IEnumerator)new GemGoalView.<CurveGemToGoal>d__16();
        }
        public GemGoalView()
        {
        
        }
        private static GemGoalView()
        {
            Royal.Scenes.Game.Mechanics.Items.RockItem.View.GemGoalView.StartSpeed = 0.8f;
            Royal.Scenes.Game.Mechanics.Items.RockItem.View.GemGoalView.MinSpeed = 0.7f;
            Royal.Scenes.Game.Mechanics.Items.RockItem.View.GemGoalView.MaxSpeed = 1f;
        }
    
    }

}
