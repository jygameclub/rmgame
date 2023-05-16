using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units
{
    public class CellGridManager : IGameContextUnit, IContextUnit
    {
        // Fields
        private System.Action OnCellGridInitialized;
        private System.Action OnCellGridViewsInitialized;
        private System.Action OnCellGridItemsInitialized;
        private Royal.Scenes.Game.Mechanics.Board.Grid.CellGrid grid;
        private Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory factory;
        private Royal.Scenes.Game.Levels.Units.State.GameStateManager gameState;
        private Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIteratorStrategy[] iterators;
        private Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator iterator;
        private Royal.Scenes.Game.Levels.Units.LevelRandomManager randomManager;
        private Royal.Infrastructure.Utils.Animation.ShakeAnimation gridTransformShakeAnimation;
        private Royal.Scenes.Game.Levels.Units.CellGridPositioner.GridPositioner gridPositioner;
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel[] cellCache;
        public int cellCacheCount;
        
        // Properties
        public int Id { get; }
        public int Height { get; }
        public int Width { get; }
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel Item { get; }
        
        // Methods
        public void add_OnCellGridInitialized(System.Action value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnCellGridInitialized, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnCellGridInitialized != 1152921523946644048);
            
            return;
            label_2:
        }
        public void remove_OnCellGridInitialized(System.Action value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnCellGridInitialized, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnCellGridInitialized != 1152921523946780624);
            
            return;
            label_2:
        }
        public void add_OnCellGridViewsInitialized(System.Action value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnCellGridViewsInitialized, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnCellGridViewsInitialized != 1152921523946917208);
            
            return;
            label_2:
        }
        public void remove_OnCellGridViewsInitialized(System.Action value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnCellGridViewsInitialized, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnCellGridViewsInitialized != 1152921523947053784);
            
            return;
            label_2:
        }
        public void add_OnCellGridItemsInitialized(System.Action value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnCellGridItemsInitialized, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnCellGridItemsInitialized != 1152921523947190368);
            
            return;
            label_2:
        }
        public void remove_OnCellGridItemsInitialized(System.Action value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnCellGridItemsInitialized, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnCellGridItemsInitialized != 1152921523947326944);
            
            return;
            label_2:
        }
        public int get_Id()
        {
            return 2;
        }
        public int get_Height()
        {
            if(this.grid != null)
            {
                    return (int)this.grid.height;
            }
            
            throw new NullReferenceException();
        }
        public int get_Width()
        {
            if(this.grid != null)
            {
                    return (int)this.grid.width;
            }
            
            throw new NullReferenceException();
        }
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel get_Item(Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint cellPoint)
        {
            if(this.grid != null)
            {
                    return this.grid.GetCell(point:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = cellPoint.x, y = cellPoint.y});
            }
            
            throw new NullReferenceException();
        }
        public CellGridManager()
        {
            this.cellCache = new Royal.Scenes.Game.Mechanics.Board.Cell.CellModel[100];
            this.InitIterators();
        }
        public void Bind()
        {
            var val_7;
            this.factory = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1);
            this.gameState = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14);
            this.randomManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.LevelRandomManager>(contextId:  0);
            if(Royal.Player.Context.Units.LevelManager.IsStoryLevel != false)
            {
                    val_7 = 1152921505122394112;
            }
            else
            {
                    val_7 = 1152921505122340864;
            }
            
            this.gridPositioner = new Royal.Scenes.Game.Levels.Units.CellGridPositioner.GridPositioner();
            this.add_OnCellGridInitialized(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Game.Levels.Units.CellGridManager::OnCellGridInitialization()));
        }
        private void OnCellGridInitialization()
        {
            Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIteratorStrategy val_1 = this.GetIteratorStrategy(iteratorType:  0);
            mem[1152921523948203736] = 0;
            this.iterator = 0;
        }
        private void InitIterators()
        {
            Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIteratorStrategy[] val_1 = new Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIteratorStrategy[4];
            this.iterators = val_1;
            val_1[0] = new Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.BottomLeftVerticalIteratorStrategy(gridManager:  this);
            this.iterators = new Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.BottomLeftHorizontalIteratorStrategy(gridManager:  this);
            this.iterators = new Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.TopLeftVerticalIteratorStrategy(gridManager:  this);
            this.iterators = new Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.TopLeftHorizontalIteratorStrategy(gridManager:  this);
        }
        public void CreateCells(Royal.Scenes.Game.Utils.LevelParser.LevelParser levelParser)
        {
            int val_15;
            Royal.Scenes.Game.Mechanics.Goal.GoalType val_16;
            Royal.Scenes.Game.Utils.LevelParser.TiledId val_17;
            var val_20;
            Royal.Scenes.Game.Mechanics.Board.Grid.CellGrid val_3 = new Royal.Scenes.Game.Mechanics.Board.Grid.CellGrid(width:  levelParser.GetWidth(), height:  levelParser.GetHeight());
            this.grid = val_3;
            val_20 = 0;
            label_29:
            if(val_20 >= (Royal.Scenes.Game.Mechanics.Board.Grid.CellGrid)[1152921523948881616].width)
            {
                goto label_3;
            }
            
            var val_20 = 0;
            label_27:
            if(val_20 >= (Royal.Scenes.Game.Mechanics.Board.Grid.CellGrid)[1152921523948881616].height)
            {
                goto label_5;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_4 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  0, y:  0);
            Royal.Scenes.Game.Utils.FlatLevel.FTiledCell val_5 = levelParser.GetCell(x:  0, y:  0);
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_8 = this.CreateCellAt(cellType:  Royal.Scenes.Game.Utils.LevelParser.TiledToTypeConverter.AsCellType(id:  levelParser.GetItemAtCell(x:  0, y:  0)), fillType:  val_5.__p.bb_pos, cellPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_4.x, y = val_4.x}, isPredefined:  false);
            if(val_5.__p.bb_pos != 0)
            {
                    Royal.Scenes.Game.Mechanics.Items.Config.StaticItemModel val_9 = this.factory.itemCreator.CreateStaticItemForStart(tileId:  val_5.__p.bb_pos);
                val_9.AddStaticItem(model:  val_9);
            }
            
            if(val_5.__p.bb_pos != 0)
            {
                    Royal.Scenes.Game.Mechanics.Items.Config.StaticItemModel val_10 = this.factory.itemCreator.CreateStaticItemForStart(tileId:  val_5.__p.bb_pos);
                val_10.AddStaticItem(model:  val_10);
            }
            
            if(val_5.__p.bb_pos != 0)
            {
                    Royal.Scenes.Game.Mechanics.Items.Config.StaticItemModel val_11 = this.factory.itemCreator.CreateStaticItemForStart(tileId:  val_5.__p.bb_pos);
                val_11.AddStaticItem(model:  val_11);
            }
            
            if((-2132850072) >= 1)
            {
                    Royal.Scenes.Game.Levels.Units.ItemCreation.ItemSettings val_14 = Royal.Scenes.Game.Levels.Units.ItemCreation.ItemCreator.GetSettingsForStaticTileId(tiledId:  Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.CurtainHelper>(contextId:  26).GetCurtainTiledIdById(curtainGroupId:  -2132850072));
                Royal.Scenes.Game.Mechanics.Items.Config.StaticItemModel val_19 = this.factory.itemCreator.CreateStaticItemForStart(itemSettings:  new Royal.Scenes.Game.Levels.Units.ItemCreation.ItemSettings() {tiledId = val_17, itemType = val_17, layerCount = val_15, matchType = val_15, goalType = val_16, staticItemType = val_16, isExtraPropeller = true, isCreatedByLightball = true, potionColors = val_17, curtainId = val_17, isDrillMaster = val_17});
                val_19.AddStaticItem(model:  val_19);
            }
            
            val_20 = val_20 + 1;
            if(this.grid != null)
            {
                goto label_27;
            }
            
            label_5:
            val_20 = val_20 + 1;
            if(val_3 != null)
            {
                goto label_29;
            }
            
            throw new NullReferenceException();
            label_3:
            this.CacheNeighbors();
            if(this.OnCellGridInitialized == null)
            {
                    return;
            }
            
            this.OnCellGridInitialized.Invoke();
        }
        public void CreateItems(Royal.Scenes.Game.Utils.LevelParser.LevelParser levelParser)
        {
            goto label_5;
            label_10:
            Royal.Scenes.Game.Utils.LevelParser.TiledId val_3 = Royal.Scenes.Game.Utils.LevelParser.TiledToTypeConverter.GetTiledIdFromInt(id:  levelParser.GetItemAtCell(x:  X22 + 24, y:  (X22 + 24) >> 32));
            if((((X22 + 16) != 0) && (val_3 != 0)) && (val_3 != 13))
            {
                    X22 + 32.ClearAllItems();
                X22 + 32.SetAllItems(itemModel:  this.factory.itemCreator.CreateItemModelForStart(tiledId:  val_3, cellModel:  X22));
            }
            
            label_5:
            if(this.iterator != 0)
            {
                goto label_10;
            }
            
            if(this.OnCellGridItemsInitialized == null)
            {
                    return;
            }
            
            this.OnCellGridItemsInitialized.Invoke();
        }
        private void CacheNeighbors()
        {
            var val_7;
            var val_8;
            if(this.grid.height < 1)
            {
                    return;
            }
            
            var val_9 = 0;
            label_21:
            var val_8 = 0;
            label_19:
            if(val_8 >= this.grid.width)
            {
                goto label_4;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_1 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  0, y:  0);
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_2 = this.grid.GetCell(point:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_1.x, y = val_1.x});
            if(val_2 == null)
            {
                goto label_6;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_7 = val_2;
            val_7 = 0;
            goto label_7;
            label_17:
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_3 = X23.GetPoint(myType:  Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors.AllNeighborTypes + 32);
            X23.Set(type:  Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors.AllNeighborTypes + 32, cellModel:  this.grid.GetCell(point:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_3.x, y = val_3.y}));
            val_7 = 1;
            label_7:
            val_8 = null;
            val_8 = null;
            if(val_7 < Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors.AllNeighborTypes.Length)
            {
                goto label_17;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_5 = this.GetFirstNormalBelow(model:  val_7);
            mem2[0] = val_5;
            val_7 = (val_5 == 0) ? 1 : 0;
            label_6:
            val_8 = val_8 + 1;
            if(this.grid != null)
            {
                goto label_19;
            }
            
            label_4:
            val_9 = val_9 + 1;
            if(val_9 < this.grid.height)
            {
                goto label_21;
            }
        
        }
        public void InitializeViews()
        {
            if(this.iterator != 0)
            {
                    do
            {
                X21.CreateView();
                if((X21 + 32.HasCurrentItem()) != false)
            {
                    Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_2 = X21 + 32.CurrentItem;
            }
            
                Royal.Scenes.Game.Mechanics.Items.Config.StaticItemModel val_3 = X21 + 64.GetStaticItem(itemType:  3);
                if(val_3 != null)
            {
                    val_3.HideItemsUnder();
            }
            
            }
            while(this.iterator != 0);
            
            }
            
            this.gridTransformShakeAnimation = this.factory.<CellParent>k__BackingField.GetComponent<Royal.Infrastructure.Utils.Animation.ShakeAnimation>();
            if(this.OnCellGridViewsInitialized == null)
            {
                    return;
            }
            
            this.OnCellGridViewsInitialized.Invoke();
        }
        public UnityEngine.Vector3 GetGridCenterPosition()
        {
            if(this.gridPositioner != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
        public UnityEngine.Vector3 GetGridTopCenterPosition()
        {
            if(this.gridPositioner != null)
            {
                    return this.gridPositioner.GetGridTopCenterPosition();
            }
            
            throw new NullReferenceException();
        }
        public UnityEngine.Vector3 GetGridTopCenterMaxPosition()
        {
            if(this.gridPositioner != null)
            {
                    return this.gridPositioner.GetGridTopCenterMaxPosition();
            }
            
            throw new NullReferenceException();
        }
        public UnityEngine.Vector3 GetGridBottomCenterPosition()
        {
            if(this.gridPositioner != null)
            {
                    return this.gridPositioner.GetGridBottomCenterPosition();
            }
            
            throw new NullReferenceException();
        }
        public void PrepareGridTransformAnimation(DG.Tweening.Sequence seq)
        {
            var val_8;
            DG.Tweening.TweenCallback val_10;
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_3 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOMove(target:  this.factory.<CellParent>k__BackingField.transform, endValue:  new UnityEngine.Vector3() {x = this.gridPositioner.gridTransformPosition}, duration:  0.4f, snapping:  false), ease:  27);
            val_3 = 1069547520;
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Insert(s:  seq, atPosition:  0.2f, t:  val_3);
            val_8 = null;
            val_8 = null;
            val_10 = CellGridManager.<>c.<>9__39_0;
            if(val_10 == null)
            {
                    DG.Tweening.TweenCallback val_5 = null;
                val_10 = val_5;
                val_5 = new DG.Tweening.TweenCallback(object:  CellGridManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Void CellGridManager.<>c::<PrepareGridTransformAnimation>b__39_0());
                CellGridManager.<>c.<>9__39_0 = val_10;
            }
            
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  seq, atPosition:  0.15f, callback:  val_5);
        }
        public void ShakeGrid(Royal.Infrastructure.Utils.Animation.ShakeAnimationConfig config)
        {
            this.gridTransformShakeAnimation.Shake(visitCenter:  (config.shouldVisitCenter == true) ? 1 : 0, delay:  config.delay, duration:  config.duration, min:  config.minVibrate, mid:  config.midVibrate, max:  config.maxVibrate);
            if(config.shouldScale == false)
            {
                    return;
            }
            
            this = this.factory.<GridParent>k__BackingField;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  0.9f);
            this.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
            DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this, endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  0.2f), ease:  27) = 1084227584;
        }
        private Royal.Scenes.Game.Mechanics.Board.Cell.CellModel GetFirstNormalBelow(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel model)
        {
            Royal.Scenes.Game.Mechanics.Board.Grid.CellGrid val_7;
            int val_8;
            int val_9;
            var val_10;
            val_7 = this.grid;
            val_8 = W9 - 1;
            val_9 = W8;
            goto label_1;
            label_5:
            if(val_7.IsNormalCell() == true)
            {
                    return (Royal.Scenes.Game.Mechanics.Board.Cell.CellModel)val_10;
            }
            
            if(val_7.IsFillingCell() == true)
            {
                goto label_3;
            }
            
            val_9 = this.grid.width;
            val_7 = this.grid;
            val_8 = this.grid.height - 1;
            label_1:
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_3 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  val_9, y:  val_8);
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_4 = val_7.GetCell(point:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_3.x, y = val_3.x});
            val_10 = val_4;
            if(val_4 != null)
            {
                goto label_5;
            }
            
            return (Royal.Scenes.Game.Mechanics.Board.Cell.CellModel)val_10;
            label_3:
            val_10 = 0;
            return (Royal.Scenes.Game.Mechanics.Board.Cell.CellModel)val_10;
        }
        private Royal.Scenes.Game.Mechanics.Board.Cell.CellModel CreateCellAt(Royal.Scenes.Game.Mechanics.Board.Cell.CellType cellType, Royal.Scenes.Game.Mechanics.Board.Cell.CellFillType fillType, Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint cellPoint, bool isPredefined = False)
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_4;
            if(fillType == 1)
            {
                    Royal.Scenes.Game.Mechanics.Board.Cell.FillingCellModel val_2 = null;
                val_4 = val_2;
                val_2 = new Royal.Scenes.Game.Mechanics.Board.Cell.FillingCellModel(gameState:  this.gameState, type:  cellType, fillType:  1, point:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = cellPoint.x, y = cellPoint.y}, isPredefined:  isPredefined);
            }
            else
            {
                    Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_3 = null;
                val_4 = val_3;
                val_3 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellModel(gameState:  this.gameState, type:  cellType, fillType:  fillType, point:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = cellPoint.x, y = cellPoint.y});
            }
            
            this.grid.SetCell(point:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = cellPoint.x, y = cellPoint.y}, value:  val_3);
            return val_4;
        }
        public void Clear(bool gameExit)
        {
            if(this.grid.width < 1)
            {
                goto label_1;
            }
            
            var val_4 = 0;
            label_7:
            var val_3 = 0;
            label_5:
            if(val_3 >= this.grid.height)
            {
                goto label_3;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_1 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  0, y:  0);
            this.grid.GetCell(point:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_1.x, y = val_1.x}).Reset();
            val_3 = val_3 + 1;
            if(this.grid != null)
            {
                goto label_5;
            }
            
            label_3:
            val_4 = val_4 + 1;
            if(val_4 < this.grid.width)
            {
                goto label_7;
            }
            
            label_1:
            if(gameExit == false)
            {
                    return;
            }
            
            this.OnCellGridInitialized = 0;
            this.OnCellGridViewsInitialized = 0;
            this.OnCellGridItemsInitialized = 0;
        }
        public Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator GetIterator(Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIteratorType iteratorType)
        {
            Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIteratorStrategy val_1 = this.GetIteratorStrategy(iteratorType:  iteratorType);
            val_0.didStart = false;
            mem[1152921523950941641] = 0;
            val_0.Cell = 0;
            val_0.strategy = 0;
        }
        private Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIteratorStrategy GetIteratorStrategy(Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIteratorType iteratorType)
        {
            return (Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIteratorStrategy)this.iterators[iteratorType];
        }
        public System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> GetCellsToThrowSpecialItem()
        {
            System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> val_1 = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel>();
            if(this.iterator != 0)
            {
                    do
            {
                if((this.iterator.IsCellReadyToThrowSpecialItem(cell:  X22)) != false)
            {
                    val_1.Add(item:  X22);
            }
            
            }
            while(this.iterator != 0);
            
            }
            
            object[] val_3 = new object[1];
            val_3[0] = 1152921505160379072;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  5, log:  "Available cell count with match item = {0}", values:  val_3);
            this.randomManager.ShuffleList<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel>(list:  val_1);
            return val_1;
        }
        public bool IsCellReadyToThrowSpecialItem(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            object val_11;
            if(HasCurrentItem() == false)
            {
                    return (bool)0 & 1;
            }
            
            val_11 = 1;
            if((System.Object.Equals(objA:  1, objB:  CurrentItem)) == false)
            {
                    return (bool)0 & 1;
            }
            
            val_11 = CurrentItem;
            if((val_11.Equals(obj:  NextItem)) != true)
            {
                    bool val_7 = HasNextItem();
                if(val_7 == true)
            {
                    return (bool)0 & 1;
            }
            
            }
            
            if(val_7.HasTouchBlockingItem() != false)
            {
                    return (bool)0 & 1;
            }
            
            bool val_11 = cell.IsReserved() ^ 1;
            return (bool)0 & 1;
        }
        public bool HasAnySpecialItemOnBoard()
        {
            var val_2;
            do
            {
                val_2 = this.iterator;
                if(val_2 == 0)
            {
                    return (bool)val_2;
            }
            
            }
            while(val_2.HasSpecialItem() == false);
            
            val_2 = 1;
            return (bool)val_2;
        }
    
    }

}
