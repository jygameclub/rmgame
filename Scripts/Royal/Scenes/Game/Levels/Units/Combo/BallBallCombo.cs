using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.Combo
{
    public class BallBallCombo : ICombo
    {
        // Fields
        public static int ExplosionSpeed;
        private Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cellTo;
        private Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cellFrom;
        private readonly Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory factory;
        private readonly Royal.Scenes.Game.Context.Units.GameTouchListener touchManager;
        private readonly Royal.Scenes.Game.Levels.Units.CellGridManager gridManager;
        private Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator iterator;
        private readonly System.Collections.Generic.SortedDictionary<int, System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint>> cellByRadius;
        private bool <IsRunning>k__BackingField;
        private Royal.Scenes.Game.Mechanics.Explode.ExplodeData <ExplodeData>k__BackingField;
        
        // Properties
        public Royal.Scenes.Game.Levels.Units.Combo.ComboType ComboType { get; }
        public bool IsRunning { get; set; }
        public Royal.Scenes.Game.Mechanics.Explode.ExplodeData ExplodeData { get; set; }
        
        // Methods
        public Royal.Scenes.Game.Levels.Units.Combo.ComboType get_ComboType()
        {
            return 1;
        }
        public bool get_IsRunning()
        {
            return (bool)this.<IsRunning>k__BackingField;
        }
        private void set_IsRunning(bool value)
        {
            this.<IsRunning>k__BackingField = value;
        }
        public Royal.Scenes.Game.Mechanics.Explode.ExplodeData get_ExplodeData()
        {
            Royal.Scenes.Game.Mechanics.Explode.ExplodeData val_0;
            val_0.id = ;
            val_0.point.x = this.<ExplodeData>k__BackingField;
            return val_0;
        }
        private void set_ExplodeData(Royal.Scenes.Game.Mechanics.Explode.ExplodeData value)
        {
            mem[1152921524109642300] = value.id;
            this.<ExplodeData>k__BackingField = value.point.x;
        }
        public BallBallCombo(Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory factory, Royal.Scenes.Game.Context.Units.GameTouchListener touchManager, Royal.Scenes.Game.Levels.Units.CellGridManager gridManager)
        {
            this.cellByRadius = new System.Collections.Generic.SortedDictionary<System.Int32, System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint>>();
            val_2 = new System.Object();
            this.factory = factory;
            this.touchManager = val_2;
            this.gridManager = gridManager;
        }
        public void Prepare(Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemModel toItem, Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemModel fromItem)
        {
            Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIteratorStrategy val_1 = this.gridManager.GetIteratorStrategy(iteratorType:  0);
            this.iterator = 0;
            mem[1152921524109953256] = 0;
            this.cellByRadius.Clear();
            this.cellTo = toItem.CurrentCell;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_3 = fromItem.CurrentCell;
            this.cellFrom = val_3;
            val_3.ClearFromAllRegisteredCells();
            this.factory.Recycle<Royal.Scenes.Game.Mechanics.Items.Config.ItemView>(go:  toItem);
            fromItem.CurrentCell.ClearAllItems();
            this.factory.Recycle<Royal.Scenes.Game.Mechanics.Items.Config.ItemView>(go:  fromItem);
        }
        public void Explode(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14).StartSpecialOperation();
            int val_7 = this.touchManager.isTouchDisabled;
            val_7 = val_7 + 1;
            this.touchManager = val_7;
            this.cellTo.FreezeFall();
            this.cellFrom.FreezeFall();
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_9 = this.cellFrom.point;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_8 = this.cellTo.point;
            if(val_9 == val_8)
            {
                    val_8 = val_8 >> 32;
                val_9 = val_9 >> 32;
                var val_2 = (val_9 < val_8) ? 1 : 0;
            }
            
            UnityEngine.Vector3 val_5 = this.cellFrom.GetViewPosition();
            this.factory.Spawn<Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.BallBallCombo.BallBallComboView>(poolId:  28, activate:  true).Init(factory:  this.factory, position:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, swipeType:  (val_9 >= val_8) ? (2 + 1) : 2, onComplete:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Game.Levels.Units.Combo.BallBallCombo::ShakeGridAndExplodeCells()));
        }
        private void ShakeGridAndExplodeCells()
        {
            float val_2;
            float val_3;
            Royal.Infrastructure.Utils.Animation.ShakeAnimationConfig val_1 = Royal.Infrastructure.Utils.Animation.ShakeAnimationConfig.BallBallConfig;
            this.gridManager.ShakeGrid(config:  new Royal.Infrastructure.Utils.Animation.ShakeAnimationConfig() {delay = val_3, duration = val_3, minVibrate = val_3, midVibrate = val_3, maxVibrate = val_2, shouldScale = val_2, shouldVisitCenter = val_2});
            UnityEngine.Coroutine val_5 = Royal.Scenes.Game.Context.GameContext.ManualStartCoroutine(iEnumerator:  this.ExplodeCells());
        }
        private System.Collections.IEnumerator ExplodeCells()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new BallBallCombo.<ExplodeCells>d__22();
        }
        private static BallBallCombo()
        {
            Royal.Scenes.Game.Levels.Units.Combo.BallBallCombo.ExplosionSpeed = 160;
        }
    
    }

}
