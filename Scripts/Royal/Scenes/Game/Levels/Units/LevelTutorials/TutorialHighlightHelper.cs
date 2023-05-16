using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.LevelTutorials
{
    public class TutorialHighlightHelper
    {
        // Fields
        private readonly Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialViewAssets assets;
        private Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialBlackView blackView;
        private readonly Royal.Scenes.Game.Ui.GameUi gameUi;
        private readonly System.Collections.Generic.List<Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialCellMaskView> masks;
        private readonly Royal.Scenes.Game.Levels.Units.CellGridManager gridManager;
        private readonly Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory;
        private Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint[] highlightedObstaclePoints;
        private bool highlightAboveStaticItem;
        private bool isGridHighlighted;
        private Royal.Scenes.Game.Ui.Bottom.Boosters.InGameBoosterButton highlightedButton;
        
        // Methods
        public TutorialHighlightHelper(Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialViewAssets assets)
        {
            var val_4;
            this.assets = assets;
            val_4 = null;
            val_4 = null;
            this.gameUi = Royal.Scenes.Game.Context.GameContext.<Controller>k__BackingField.gameUi;
            this.gridManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.CellGridManager>(contextId:  2);
            this.itemFactory = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1);
            this.masks = new System.Collections.Generic.List<Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialCellMaskView>();
        }
        public void BringObstaclesFront(Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint[] cellPoints, bool showBlack = True, bool highlightAboveStaticItem = False)
        {
            bool val_12;
            var val_16;
            this.highlightAboveStaticItem = highlightAboveStaticItem;
            this.highlightedObstaclePoints = cellPoints;
            if(showBlack != false)
            {
                    this.ShowBlack();
                this.HighlightKing();
            }
            
            int val_15 = cellPoints.Length;
            if(val_15 < 1)
            {
                    return;
            }
            
            var val_16 = 0;
            val_15 = val_15 & 4294967295;
            label_25:
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_3 = this.gridManager.Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = 50564912, y = 268435457}].CurrentItem;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_4 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetTutorialBlackSorting();
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_5 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_4.layer, order = val_4.order, sortEverything = false}, offset:  10);
            bool val_6 = val_5.sortEverything & 4294967295;
            if(highlightAboveStaticItem == false)
            {
                goto label_18;
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.StaticItemModel val_8 = this.gridManager.Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = 50564912, y = 268435457}].GetTopMostAboveItem();
            val_16 = val_8;
            var val_9 = (val_8 == 0) ? 0 : (val_8);
            if(val_16 == null)
            {
                goto label_18;
            }
            
            var val_10 = (val_9 == 0) ? 0 : (val_9);
            if(val_9 == 0)
            {
                goto label_24;
            }
            
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_11 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetTutorialBlackSorting();
            val_12 = val_12;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_13 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_11.layer, order = val_11.order, sortEverything = val_12}, offset:  100);
            bool val_14 = val_13.sortEverything & 4294967295;
            goto label_24;
            label_18:
            val_16 = 0;
            label_24:
            val_16 = val_16 + 1;
            if(val_16 < (cellPoints.Length << ))
            {
                goto label_25;
            }
        
        }
        private void SendObstaclesBack(Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint[] cellPoints)
        {
            var val_12;
            var val_13;
            int val_12 = cellPoints.Length;
            if(val_12 < 1)
            {
                    return;
            }
            
            var val_13 = 0;
            var val_14 = 0;
            val_12 = val_12 & 4294967295;
            label_25:
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_2 = this.gridManager.Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = 50564912, y = 268435457}].CurrentItem;
            if((val_2 != null) && ((val_2 & 1) != 0))
            {
                    Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_3 = val_2.CurrentCell;
                Royal.Scenes.Game.Mechanics.Sortings.SortingData val_5 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetItemSorting(row:  W23, isReverseSort:  val_2 & 1);
                bool val_6 = val_5.sortEverything & 4294967295;
            }
            
            if(this.highlightAboveStaticItem == false)
            {
                goto label_18;
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.StaticItemModel val_8 = this.gridManager.Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = 50564912, y = 268435457}].GetTopMostAboveItem();
            val_12 = val_8;
            var val_9 = (val_8 == 0) ? (val_13) : (val_8);
            if(val_12 == null)
            {
                goto label_18;
            }
            
            val_13 = (val_9 == 0) ? 0 : (val_9);
            if(val_9 == 0)
            {
                goto label_24;
            }
            
            val_13 = val_9;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_10 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetChainSorting(point:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = 50564912, y = 268435457});
            bool val_11 = val_10.sortEverything & 4294967295;
            goto label_24;
            label_18:
            val_12 = val_13;
            label_24:
            val_14 = val_14 + 1;
            if(val_14 < (cellPoints.Length << ))
            {
                goto label_25;
            }
        
        }
        public void HighlightCells(Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint[] cellPoints)
        {
            this.ShowBlack();
            int val_3 = cellPoints.Length;
            if(val_3 >= 1)
            {
                    var val_6 = 0;
                val_3 = val_3 & 4294967295;
                do
            {
                UnityEngine.Vector3 val_2 = this.gridManager.Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = cellPoints[val_6], y = cellPoints[val_6]}].GetViewPosition();
                this.CreateCellMask(position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, point:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = cellPoints[val_6], y = cellPoints[val_6]}, allPoints:  cellPoints);
                val_6 = val_6 + 1;
            }
            while(val_6 < (cellPoints.Length << ));
            
            }
            
            this.HighlightKing();
        }
        public void HighlightGoalUi()
        {
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_2 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetTutorialBlackSorting();
            val_2.sortEverything = val_2.sortEverything & 4294967295;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_3 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_2.layer, order = val_2.order, sortEverything = val_2.sortEverything}, offset:  10);
            this.gameUi.topUi.ChangeTargetPanelParent(parent:  this.gameUi.transform, sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_3.layer, order = val_3.order, sortEverything = val_3.sortEverything & 4294967295});
            this.ShowBlack();
        }
        private void HighlightKing()
        {
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_2 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetTutorialBlackSorting();
            val_2.sortEverything = val_2.sortEverything & 4294967295;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_3 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_2.layer, order = val_2.order, sortEverything = val_2.sortEverything}, offset:  10);
            this.gameUi.topUi.ChangeKingPanelParent(parent:  this.gameUi.transform, sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_3.layer, order = val_3.order, sortEverything = val_3.sortEverything & 4294967295});
            this.ShowBlack();
        }
        public void HighlightAllGrid()
        {
            this.isGridHighlighted = true;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_3 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetTutorialBlackSorting();
            val_3.sortEverything = val_3.sortEverything & 4294967295;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_4 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_3.layer, order = val_3.order, sortEverything = val_3.sortEverything}, offset:  1);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(group:  this.itemFactory.<GridParent>k__BackingField.gameObject.AddComponent<UnityEngine.Rendering.SortingGroup>(), data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_4.layer, order = val_4.order, sortEverything = val_4.sortEverything & 4294967295});
            this.ShowBlack();
            this.HighlightKing();
        }
        public void HighlightButtonForTutorial(Royal.Scenes.Game.Ui.Bottom.Boosters.InGameBoosterButton button, bool showFreeText = True)
        {
            this.highlightedButton = button;
            if(button != null)
            {
                    button.HighlightForTutorial(showFreeText:  showFreeText);
                return;
            }
            
            throw new NullReferenceException();
        }
        private void CreateCellMask(UnityEngine.Vector3 position, Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint point, Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint[] allPoints)
        {
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialCellMaskView val_2 = UnityEngine.Object.Instantiate<Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialCellMaskView>(original:  this.assets.tutorialCellMaskView, parent:  this.blackView.renderParent.transform, worldPositionStays:  true);
            this.masks.Add(item:  val_2);
            val_2.ArrangeMaskPatches(position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, cellPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = point.x, y = point.y}, points:  allPoints);
        }
        public void DisableHighlight()
        {
            if(this.blackView != 0)
            {
                    UnityEngine.Object.Destroy(obj:  this.blackView.gameObject);
                this.blackView = 0;
            }
            
            var val_7 = 0;
            label_13:
            if(val_7 >= null)
            {
                goto label_8;
            }
            
            if(null <= val_7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            UnityEngine.Object.Destroy(obj:  UnityEngine.Object.__il2cppRuntimeField_byval_arg.gameObject);
            val_7 = val_7 + 1;
            if(this.masks != null)
            {
                goto label_13;
            }
            
            label_8:
            this.masks.Clear();
            this.gameUi.topUi.ResetTargetPanelParent();
            this.gameUi.topUi.ResetKingPanelParent();
            if(this.highlightedObstaclePoints != null)
            {
                    this.SendObstaclesBack(cellPoints:  this.highlightedObstaclePoints);
                this.highlightedObstaclePoints = 0;
            }
            
            if(this.isGridHighlighted != false)
            {
                    this.isGridHighlighted = false;
                UnityEngine.Object.Destroy(obj:  this.itemFactory.<GridParent>k__BackingField.gameObject.GetComponent<UnityEngine.Rendering.SortingGroup>());
            }
            
            if(this.highlightedButton == 0)
            {
                    return;
            }
            
            this.highlightedButton.DeHighlightForTutorial();
        }
        public void ShowBlack()
        {
            if(this.blackView != 0)
            {
                    return;
            }
            
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialBlackView val_2 = UnityEngine.Object.Instantiate<Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialBlackView>(original:  this.assets.blackView);
            this.blackView = val_2;
            val_2.Show();
        }
    
    }

}
