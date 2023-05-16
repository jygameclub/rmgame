using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Boosters.JesterHat
{
    public class JesterHatBooster
    {
        // Fields
        public const int MaxTryCount = 500;
        private int originalItemsCount;
        private Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator gridIterator;
        private readonly Royal.Scenes.Game.Context.Units.GameTouchListener gameTouchListener;
        private readonly Royal.Scenes.Game.Levels.Units.Booster.BoosterManager boosterManager;
        private readonly Royal.Scenes.Game.Levels.Units.CellGridManager gridManager;
        private readonly Royal.Scenes.Game.Levels.Units.LevelRandomManager randomManager;
        private readonly Royal.Scenes.Game.Levels.Units.State.GameStateManager gameState;
        private readonly Royal.Scenes.Game.Mechanics.Board.Cell.CellModel[] cells;
        private readonly Royal.Scenes.Game.Mechanics.Items.Config.ItemModel[] items;
        private readonly Royal.Scenes.Game.Mechanics.Items.Config.ItemModel[] originalItems;
        private readonly System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Items.Config.ItemModel, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> cellsOfOriginalItemsAtStart;
        private Royal.Scenes.Game.Mechanics.Boosters.JesterHat.View.JesterHatShuffleButton shuffleButton;
        
        // Methods
        public JesterHatBooster()
        {
            this.gameTouchListener = Royal.Scenes.Game.Context.GameContext.Get<Royal.Scenes.Game.Context.Units.GameTouchListener>(id:  0);
            this.gameState = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14);
            Royal.Scenes.Game.Levels.Units.CellGridManager val_3 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.CellGridManager>(contextId:  2);
            this.gridManager = val_3;
            val_3.add_OnCellGridInitialized(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Game.Mechanics.Boosters.JesterHat.JesterHatBooster::OnCellGridInitialized()));
            Royal.Scenes.Game.Levels.Units.Booster.BoosterManager val_5 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.Booster.BoosterManager>(contextId:  17);
            this.boosterManager = val_5;
            val_5.add_OnBoosterSelected(value:  new System.Action<Royal.Scenes.Game.Mechanics.Boosters.BoosterType>(object:  this, method:  System.Void Royal.Scenes.Game.Mechanics.Boosters.JesterHat.JesterHatBooster::OnBoosterSelected(Royal.Scenes.Game.Mechanics.Boosters.BoosterType boosterType)));
            this.boosterManager.add_OnBoosterDeselected(value:  new System.Action<Royal.Scenes.Game.Mechanics.Boosters.BoosterType, System.Boolean>(object:  this, method:  System.Void Royal.Scenes.Game.Mechanics.Boosters.JesterHat.JesterHatBooster::OnBoosterDeselected(Royal.Scenes.Game.Mechanics.Boosters.BoosterType boosterType, bool used)));
            this.randomManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.LevelRandomManager>(contextId:  0);
            this.cells = new Royal.Scenes.Game.Mechanics.Board.Cell.CellModel[100];
            this.items = new Royal.Scenes.Game.Mechanics.Items.Config.ItemModel[100];
            this.originalItems = new Royal.Scenes.Game.Mechanics.Items.Config.ItemModel[100];
            this.cellsOfOriginalItemsAtStart = new System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Items.Config.ItemModel, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel>();
        }
        private void OnBoosterDeselected(Royal.Scenes.Game.Mechanics.Boosters.BoosterType boosterType, bool used)
        {
            if(boosterType != 7)
            {
                    return;
            }
            
            if(this.shuffleButton != 0)
            {
                    UnityEngine.Object.Destroy(obj:  this.shuffleButton.gameObject);
            }
            
            this.gameTouchListener.EnableTouch();
        }
        private void OnBoosterSelected(Royal.Scenes.Game.Mechanics.Boosters.BoosterType boosterType)
        {
            if(boosterType != 7)
            {
                    return;
            }
            
            Royal.Scenes.Game.Mechanics.Boosters.JesterHat.View.JesterHatShuffleButton val_2 = UnityEngine.Object.Instantiate<Royal.Scenes.Game.Mechanics.Boosters.JesterHat.View.JesterHatShuffleButton>(original:  UnityEngine.Resources.Load<Royal.Scenes.Game.Mechanics.Boosters.JesterHat.View.JesterHatShuffleButton>(path:  "JesterHatShuffleButtonPrefab"));
            this.shuffleButton = val_2;
            UnityEngine.Vector3 val_4 = this.gridManager.GetGridCenterPosition();
            val_2.transform.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            this.shuffleButton.add_OnShuffleClick(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Game.Mechanics.Boosters.JesterHat.JesterHatBooster::<OnBoosterSelected>b__15_0()));
            this.gameTouchListener.DisableTouch();
        }
        private void OnCellGridInitialized()
        {
            var val_2;
            Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator val_3;
            Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator val_1 = this.gridManager.GetIterator(iteratorType:  1);
            mem[1152921523893327576] = val_2;
            this.gridIterator = val_3;
        }
        public void Use()
        {
            this.gameTouchListener.DisableTouch();
            this.gameState.OperationStart(animationId:  6);
            this.gameState.OperationStart(animationId:  7);
            this.StartHatAnimation();
        }
        private void StartHatAnimation()
        {
            JesterHatBooster.<>c__DisplayClass18_0 val_1 = new JesterHatBooster.<>c__DisplayClass18_0();
            UnityEngine.Vector3 val_2 = this.gridManager.GetGridCenterPosition();
            .middlePosition = val_2;
            mem[1152921523893704444] = val_2.y;
            mem[1152921523893704448] = val_2.z;
            Royal.Scenes.Game.Mechanics.Boosters.JesterHat.View.JesterHatView val_4 = UnityEngine.Object.Instantiate<Royal.Scenes.Game.Mechanics.Boosters.JesterHat.View.JesterHatView>(original:  UnityEngine.Resources.Load<Royal.Scenes.Game.Mechanics.Boosters.JesterHat.View.JesterHatView>(path:  "JesterHatPrefab"));
            .jesterHatView = val_4;
            val_4.transform.position = new UnityEngine.Vector3() {x = (JesterHatBooster.<>c__DisplayClass18_0)[1152921523893704416].middlePosition, y = val_2.y, z = val_2.z};
            (JesterHatBooster.<>c__DisplayClass18_0)[1152921523893704416].jesterHatView.Init();
            DG.Tweening.Sequence val_6 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_6, atPosition:  0.01666667f, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void JesterHatBooster.<>c__DisplayClass18_0::<StartHatAnimation>b__0()));
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_6, atPosition:  0.1f, callback:  new DG.Tweening.TweenCallback(object:  (JesterHatBooster.<>c__DisplayClass18_0)[1152921523893704416].jesterHatView, method:  public System.Void Royal.Scenes.Game.Mechanics.Boosters.JesterHat.View.JesterHatView::PlayParticles()));
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_6, interval:  1.416667f);
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_6, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Game.Mechanics.Boosters.JesterHat.JesterHatBooster::ShuffleBoard()));
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_6, interval:  3f);
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_6, action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void JesterHatBooster.<>c__DisplayClass18_0::<StartHatAnimation>b__1()));
        }
        private void ShuffleBoard()
        {
            this.ShuffleBoardOnce(firstShuffle:  true);
            var val_3 = 0;
            do
            {
                val_3 = val_3 + 1;
                if((Royal.Scenes.Game.Levels.Units.Shuffle.PossibleMatchFinder.CheckBoard(iterator:  new Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator() {strategy = this.gridIterator.strategy, didStart = this.gridIterator.strategy, Cell = this.gridIterator.Cell})) != 0)
            {
                    if((val_3 > 98) || (this.WillAnyItemsMoveToSameCell() == false))
            {
                goto label_2;
            }
            
            }
            
                this.ShuffleBoardOnce(firstShuffle:  false);
            }
            while(val_3 <= 498);
            
            label_2:
            this.UpdateItems();
        }
        public bool ShouldTryAgain()
        {
            return (bool)((Royal.Scenes.Game.Levels.Units.Shuffle.PossibleMatchFinder.CheckBoard(iterator:  new Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator() {strategy = this.gridIterator, didStart = this.gridIterator, Cell = ???})) == 0) ? 1 : 0;
        }
        private bool WillAnyItemsMoveToSameCell()
        {
            var val_4;
            var val_5;
            if(this.originalItemsCount >= 1)
            {
                    val_4 = 0;
                do
            {
                Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_1 = 20704.CurrentItem;
                if((this.cellsOfOriginalItemsAtStart.ContainsKey(key:  val_1)) != false)
            {
                    if(this.cells[val_4] == this.cellsOfOriginalItemsAtStart.Item[val_1])
            {
                goto label_9;
            }
            
            }
            
                val_4 = val_4 + 1;
            }
            while(val_4 < this.originalItemsCount);
            
            }
            
            val_5 = 0;
            return (bool)val_5;
            label_9:
            val_5 = 1;
            return (bool)val_5;
        }
        private void ShuffleBoardOnce(bool firstShuffle)
        {
            int val_2 = this.PrepareCellsAndItems(firstShuffle:  firstShuffle);
            if(val_2 < 1)
            {
                    return;
            }
            
            var val_6 = 0;
            do
            {
                Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_4 = this.FindItemForCell(cell:  this.cells[val_6], totalCount: ref  val_2);
                if(val_4 != null)
            {
                    val_4.SetAllItems(itemModel:  val_4);
            }
            
                val_6 = val_6 + 1;
            }
            while(val_6 < (long)val_2);
        
        }
        private int PrepareCellsAndItems(bool firstShuffle)
        {
            var val_5;
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel[] val_6;
            if(firstShuffle != false)
            {
                    this.originalItemsCount = 0;
            }
            
            val_5 = 0;
            if(this.gridIterator == 0)
            {
                    return (int)val_5;
            }
            
            goto label_27;
            label_26:
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_1 = X23.CurrentItem;
            val_6 = 0;
            this.cells[val_6] = null;
            this.items[val_6] = val_1;
            if(firstShuffle != false)
            {
                    val_6 = this.originalItems;
                val_6[this.originalItemsCount] = val_1;
                this.cellsOfOriginalItemsAtStart.set_Item(key:  val_1, value:  X24);
                int val_5 = this.originalItemsCount;
                val_5 = val_5 + 1;
                this.originalItemsCount = val_5;
            }
            
            val_1.itemMediator.ClearFromAllRegisteredCells();
            X23.ClearAllItems();
            val_5 = 1;
            goto label_21;
            label_27:
            if(X24.CanEnterPossibleMatch() != false)
            {
                    if((((X24 + 32.CurrentItem) & 1) != 0) || (((X24 + 32.CurrentItem) & 1) != 0))
            {
                goto label_26;
            }
            
            }
            
            label_21:
            if(this.gridIterator != 0)
            {
                goto label_27;
            }
            
            return (int)val_5;
        }
        private Royal.Scenes.Game.Mechanics.Items.Config.ItemModel FindItemForCell(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, ref int totalCount)
        {
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_5;
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_6;
            int val_7;
            val_5 = cell;
            if(totalCount < 1)
            {
                goto label_2;
            }
            
            int val_5 = this.randomManager.Next(min:  0, max:  totalCount);
            var val_6 = 0;
            label_7:
            int val_2 = val_5 + val_6;
            val_5 = val_2 - ((val_2 / totalCount) * totalCount);
            val_6 = this.items[(long)val_5];
            if(this.cellsOfOriginalItemsAtStart.Item[val_6] != val_5)
            {
                goto label_6;
            }
            
            val_6 = val_6 + 1;
            if(val_6 < totalCount)
            {
                goto label_7;
            }
            
            return val_6;
            label_2:
            val_6 = 0;
            return val_6;
            label_6:
            int val_7 = totalCount;
            val_7 = this.items.Length;
            val_7 = val_7 - 1;
            val_5 = this.items[val_7];
            if(val_5 != null)
            {
                    val_7 = this.items.Length;
            }
            
            this.items[(long)val_5] = val_5;
            int val_8 = totalCount;
            val_8 = val_8 - 1;
            totalCount = val_8;
            return val_6;
        }
        private void UpdateItems()
        {
            UnityEngine.Coroutine val_2 = Royal.Scenes.Game.Context.GameContext.ManualStartCoroutine(iEnumerator:  this.MoveAllItems(duration:  1f));
        }
        private void ClearState()
        {
            this.originalItemsCount = 0;
            this.gameState.OperationFinish(animationId:  6);
            this.gameState.OperationFinish(animationId:  7);
        }
        private System.Collections.IEnumerator MoveAllItems(float duration)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .duration = duration;
            return (System.Collections.IEnumerator)new JesterHatBooster.<MoveAllItems>d__27();
        }
        private void <OnBoosterSelected>b__15_0()
        {
            this.boosterManager.UseBooster(cellPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint.Default, y = Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint.Default});
        }
    
    }

}
