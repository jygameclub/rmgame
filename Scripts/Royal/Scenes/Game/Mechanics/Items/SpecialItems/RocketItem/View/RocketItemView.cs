using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.View
{
    public class RocketItemView : SpecialItemView
    {
        // Fields
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.View.IRocketItemViewDelegate viewDelegate;
        public const float RocketSpeed = 13.5;
        public const float RocketAcceleration = 0.18;
        public UnityEngine.Transform verticalAnimation;
        public UnityEngine.Transform horizontalAnimation;
        public UnityEngine.SpriteRenderer part1;
        public UnityEngine.SpriteRenderer part2;
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.Strategy.RocketStrategy rocketStrategy;
        private Royal.Scenes.Game.Levels.Units.State.GameStateManager stateManager;
        private bool creationAnimationFinished;
        
        // Methods
        public void Init(Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.View.IRocketItemViewDelegate viewDelegate, UnityEngine.Vector3 position)
        {
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.View.RocketItemView val_10;
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.Strategy.RocketStrategy val_11;
            this.viewDelegate = viewDelegate;
            this.stateManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14);
            this.InitTransform(viewDelegate:  viewDelegate, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.View.RocketItemAssets val_2 = Load<Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.View.RocketItemAssets>();
            var val_10 = 0;
            if(mem[1152921505090482176] != null)
            {
                    val_10 = val_10 + 1;
            }
            else
            {
                    Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.View.IRocketItemViewDelegate val_3 = 1152921505090445312 + ((mem[1152921505090482184]) << 4);
            }
            
            if(viewDelegate.Orientation != 0)
            {
                    Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.Strategy.VerticalRocketStrategy val_5 = null;
                val_10 = this;
                val_11 = val_5;
                val_5 = new Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.Strategy.VerticalRocketStrategy(view:  this, itemAssets:  val_2, itemFactory:  X22);
            }
            else
            {
                    Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.Strategy.HorizontalRocketStrategy val_6 = null;
                val_10 = this;
                val_11 = val_6;
                val_6 = new Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.Strategy.HorizontalRocketStrategy(view:  this, itemAssets:  val_2, itemFactory:  X22);
            }
            
            this.rocketStrategy = val_11;
            this.creationAnimationFinished = true;
            val_6.gameObject.SetActive(value:  true);
            this.horizontalAnimation.gameObject.SetActive(value:  false);
            this.verticalAnimation.gameObject.SetActive(value:  false);
        }
        private void Update()
        {
            if(this.creationAnimationFinished != false)
            {
                    return;
            }
            
            var val_3 = 0;
            if(mem[1152921505090482176] != null)
            {
                    val_3 = val_3 + 1;
            }
            else
            {
                    var val_4 = mem[1152921505090482184];
                val_4 = val_4 + 3;
                Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.View.IRocketItemViewDelegate val_1 = 1152921505090445312 + val_4;
            }
            
            if(this.viewDelegate.CurrentCell == null)
            {
                    return;
            }
            
            if((this.rocketStrategy & 1) != 0)
            {
                    return;
            }
            
            goto typeof(Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.View.RocketItemView).__il2cppRuntimeField_300;
        }
        public override Royal.Scenes.Game.Mechanics.Sortings.SortingData GetCreationSorting()
        {
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_1 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetRocketAnimationSorting();
            val_1.sortEverything = val_1.sortEverything & 4294967295;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_1.layer, order = val_1.order, sortEverything = val_1.sortEverything};
        }
        public override int GetPoolId()
        {
            return 7;
        }
        public override void OnSpawn()
        {
        
        }
        public override void OnRecycle()
        {
            this.viewDelegate = 0;
            if(this.rocketStrategy != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
        public override void PlayCreationAnimation(float normalizedStartTime = 0, bool playSound = True)
        {
            this.creationAnimationFinished = false;
            29905.gameObject.SetActive(value:  false);
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_2 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetRocketAnimationSorting();
            this.UpdateSortingForAnimation(sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_2.layer, order = val_2.order, sortEverything = val_2.sortEverything & 4294967295}, allowOtherSortingUpdates:  false);
            bool val_4 = playSound;
            goto typeof(Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.Strategy.RocketStrategy).__il2cppRuntimeField_180;
        }
        public override void PlayBoosterAnimation()
        {
            this.creationAnimationFinished = false;
            29904.gameObject.SetActive(value:  false);
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_2 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetBoosterSorting();
            this.UpdateSortingForAnimation(sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_2.layer, order = val_2.order, sortEverything = val_2.sortEverything & 4294967295}, allowOtherSortingUpdates:  false);
            goto typeof(Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.Strategy.RocketStrategy).__il2cppRuntimeField_180;
        }
        public override void StopCreationAnimation()
        {
            if(this.creationAnimationFinished != false)
            {
                    return;
            }
            
            this.creationAnimationFinished = true;
            if(this.viewDelegate != null)
            {
                    var val_10 = 0;
                if(mem[1152921505090482176] != null)
            {
                    val_10 = val_10 + 1;
            }
            else
            {
                    var val_11 = mem[1152921505090482184];
                val_11 = val_11 + 3;
                Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.View.IRocketItemViewDelegate val_1 = 1152921505090445312 + val_11;
            }
            
                if(this.viewDelegate.CurrentCell != null)
            {
                    var val_12 = 0;
                if(mem[1152921505090482176] != null)
            {
                    val_12 = val_12 + 1;
            }
            else
            {
                    var val_13 = mem[1152921505090482184];
                val_13 = val_13 + 3;
                Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.View.IRocketItemViewDelegate val_3 = 1152921505090445312 + val_13;
            }
            
                Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_4 = this.viewDelegate.CurrentCell;
                Royal.Scenes.Game.Mechanics.Sortings.SortingData val_5 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetItemSorting(row:  this.viewDelegate, isReverseSort:  false);
                this.UpdateSortingForAnimation(sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_5.layer, order = val_5.order, sortEverything = val_5.sortEverything & 4294967295}, allowOtherSortingUpdates:  true);
            }
            
            }
            
            this.gameObject.SetActive(value:  true);
            this.horizontalAnimation.gameObject.SetActive(value:  false);
            this.verticalAnimation.gameObject.SetActive(value:  false);
        }
        public void Play(Royal.Scenes.Game.Mechanics.Explode.ExplodeData exploder, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> firstList, System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> secondList)
        {
            this.creationAnimationFinished = false;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_1 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetRocketUseSorting();
            this.UpdateSortingForAnimation(sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_1.layer, order = val_1.order, sortEverything = val_1.sortEverything & 4294967295}, allowOtherSortingUpdates:  true);
        }
        public void RocketPartStart()
        {
            this.stateManager.OperationStart(animationId:  4);
            this.stateManager.StartSpecialOperation();
        }
        public void RocketPartEnd()
        {
            this.stateManager.OperationFinish(animationId:  4);
            this.stateManager.FinishSpecialOperation();
        }
        public void Recycle()
        {
            29907.Recycle<Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.View.RocketItemView>(go:  this);
        }
        public RocketItemView()
        {
            val_1 = new Royal.Scenes.Game.Mechanics.Items.Config.ItemView();
        }
    
    }

}
