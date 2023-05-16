using UnityEngine;

namespace Royal.Scenes.Game.Context.Units
{
    public class GameTouchListener : IGameContextBehaviour, IGameContextUnit, IContextUnit, IContextBehaviour
    {
        // Fields
        private const float MinMoveDistanceForSwap = 0.5;
        private const float MaxMoveDistanceForTouch = 0.5;
        private readonly UnityEngine.LayerMask layerMask;
        private Royal.Infrastructure.Contexts.Units.CameraManager cameraManager;
        private Royal.Scenes.Game.Levels.Units.MoveManager moveManager;
        private Royal.Scenes.Game.Levels.Units.Booster.BoosterManager boosterManager;
        private bool isTouching;
        private UnityEngine.Vector2 startPosition;
        private Royal.Scenes.Game.Mechanics.Board.Cell.View.ITouchableCell selectedCell;
        private Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemView highlightedItem;
        private int isTouchDisabled;
        private Royal.Infrastructure.UiComponents.Touch.UiTouchListener uiTouchListener;
        private Royal.Scenes.Game.Levels.Units.Touch.LevelTouchManager touchManager;
        
        // Properties
        public int Id { get; }
        
        // Methods
        public int get_Id()
        {
            return 0;
        }
        public GameTouchListener()
        {
            string[] val_1 = new string[1];
            val_1[0] = "Level";
            UnityEngine.LayerMask val_3 = UnityEngine.LayerMask.op_Implicit(intVal:  UnityEngine.LayerMask.GetMask(layerNames:  val_1));
            this.layerMask = val_3;
        }
        public void Bind()
        {
            this.cameraManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            this.uiTouchListener = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            this.moveManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.MoveManager>(contextId:  10);
            this.boosterManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.Booster.BoosterManager>(contextId:  17);
            this.touchManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.Touch.LevelTouchManager>(contextId:  3);
        }
        public void Clear(bool gameExit)
        {
            this.isTouchDisabled = 0;
        }
        public void ManualUpdate()
        {
            if(this.uiTouchListener.Touching() != true)
            {
                    UnityEngine.Vector2 val_2 = this.GetMousePosition();
                if((this.IsTouchedBoosterBackground(mousePosition:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y})) != true)
            {
                    if(this.IsTouchDisabled() == false)
            {
                goto label_3;
            }
            
            }
            
            }
            
            this.TurnOffHighlight();
            return;
            label_3:
            if((UnityEngine.Input.GetMouseButtonDown(button:  0)) != false)
            {
                    UnityEngine.Vector2 val_6 = this.GetMousePosition();
                this.TouchDown(mousePosition:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
                return;
            }
            
            if((UnityEngine.Input.GetMouseButton(button:  0)) != false)
            {
                    UnityEngine.Vector2 val_8 = this.GetMousePosition();
                this.TouchMove(mousePosition:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y});
                return;
            }
            
            if((UnityEngine.Input.GetMouseButtonUp(button:  0)) == false)
            {
                    return;
            }
            
            UnityEngine.Vector2 val_10 = this.GetMousePosition();
            this.TouchUp(mousePosition:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y});
        }
        public bool IsTouchDisabled()
        {
            var val_3;
            if(this.isTouchDisabled > 0)
            {
                    val_3 = 1;
            }
            else
            {
                    bool val_1 = this.moveManager.CanUserMakeMove();
                val_3 = val_1 ^ 1;
            }
            
            val_1 = val_3;
            return (bool)val_1;
        }
        public void EnableTouch()
        {
            var val_1;
            int val_1 = this.isTouchDisabled;
            if(val_1 != 0)
            {
                    val_1 = val_1 - 1;
                this.isTouchDisabled = val_1;
                return;
            }
            
            val_1 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_1 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_1 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_1 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  5, log:  "Touch counter is already zero..", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        public void DisableTouch()
        {
            int val_1 = this.isTouchDisabled;
            val_1 = val_1 + 1;
            this.isTouchDisabled = val_1;
        }
        private void TurnOffHighlight()
        {
            if(this.highlightedItem == 0)
            {
                    return;
            }
            
            this.highlightedItem.Highlight(enable:  false);
            this.highlightedItem = 0;
        }
        private void TouchDown(UnityEngine.Vector2 mousePosition)
        {
            this.StopTouch();
            Royal.Scenes.Game.Mechanics.Board.Cell.View.ITouchableCell val_1 = this.GetTouchedCell(mousePosition:  new UnityEngine.Vector2() {x = mousePosition.x, y = mousePosition.y});
            if(val_1 == null)
            {
                    return;
            }
            
            this.StartTouch(position:  new UnityEngine.Vector2() {x = mousePosition.x, y = mousePosition.y}, cell:  val_1);
        }
        private void TouchMove(UnityEngine.Vector2 mousePosition)
        {
            if(this.boosterManager.selectedBooster != 0)
            {
                    return;
            }
            
            if(this.isTouching == false)
            {
                    return;
            }
            
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = mousePosition.x, y = mousePosition.y}, b:  new UnityEngine.Vector2() {x = this.startPosition, y = V10.16B});
            if(val_1.x < 0)
            {
                    return;
            }
            
            if((this.GetTowardsCell(delta:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y}, cellPoint: out  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint())) == false)
            {
                    return;
            }
            
            var val_5 = 0;
            if(mem[1152921505113804800] != null)
            {
                    val_5 = val_5 + 1;
            }
            else
            {
                    Royal.Scenes.Game.Mechanics.Board.Cell.View.ITouchableCell val_3 = 1152921505113767936 + ((mem[1152921505113804808]) << 4);
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_4 = this.selectedCell.CellPoint;
            this.TriggerOnCellsSwapped(cellFrom:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_4.x, y = val_4.y}, cellTo:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint());
            this.TurnOffHighlight();
            this.StopTouch();
            this.selectedCell = 0;
            this.isTouching = false;
        }
        private void TouchUp(UnityEngine.Vector2 mousePosition)
        {
            this.TurnOffHighlight();
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = mousePosition.x, y = mousePosition.y}, b:  new UnityEngine.Vector2() {x = this.startPosition, y = V10.16B});
            if(val_1.x > 0.5f)
            {
                    return;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.View.ITouchableCell val_2 = this.GetTouchedCell(mousePosition:  new UnityEngine.Vector2() {x = mousePosition.x, y = mousePosition.y});
            if(val_2 == this.selectedCell)
            {
                    var val_5 = 0;
                if(mem[1152921505113804800] != null)
            {
                    val_5 = val_5 + 1;
            }
            else
            {
                    Royal.Scenes.Game.Mechanics.Board.Cell.View.ITouchableCell val_3 = 1152921505113767936 + ((mem[1152921505113804808]) << 4);
            }
            
                Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_4 = val_2.CellPoint;
                this.TriggerOnTouchCell(cell:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_4.x, y = val_4.y});
            }
            
            this.StopTouch();
        }
        private void StopTouch()
        {
            this.TurnOffHighlight();
            this.isTouching = false;
            this.selectedCell = 0;
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            this.startPosition = val_1;
            mem[1152921524141371576] = val_1.y;
        }
        private void StartTouch(UnityEngine.Vector2 position, Royal.Scenes.Game.Mechanics.Board.Cell.View.ITouchableCell cell)
        {
            this.startPosition = position;
            mem[1152921524141487688] = position.y;
            this.isTouching = true;
            this.selectedCell = cell;
            var val_3 = 0;
            if(mem[1152921505113804800] != null)
            {
                    val_3 = val_3 + 1;
            }
            else
            {
                    var val_4 = mem[1152921505113804808];
                val_4 = val_4 + 2;
                Royal.Scenes.Game.Mechanics.Board.Cell.View.ITouchableCell val_1 = 1152921505113767936 + val_4;
            }
            
            this.highlightedItem = cell.HighlightMatchItem(enable:  true);
        }
        private bool GetTowardsCell(UnityEngine.Vector2 delta, out Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint cellPoint)
        {
            int val_7;
            int val_8;
            var val_9;
            delta.x = delta.y / delta.x;
            float val_1 = delta.x * 57.29578f;
            var val_6 = 0;
            if(mem[1152921505113804800] != null)
            {
                    val_6 = val_6 + 1;
            }
            else
            {
                    Royal.Scenes.Game.Mechanics.Board.Cell.View.ITouchableCell val_2 = 1152921505113767936 + ((mem[1152921505113804808]) << 4);
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_3 = this.selectedCell.CellPoint;
            float val_4 = (val_1 < 0) ? (-val_1) : (val_1);
            val_7 = val_3.x;
            val_8 = val_3.x >> 32;
            cellPoint.x = val_3.x;
            cellPoint.y = val_3.y;
            if(val_4 <= 30f)
            {
                goto label_8;
            }
            
            if(val_4 >= 60f)
            {
                goto label_9;
            }
            
            val_9 = 0;
            return (bool)val_9;
            label_8:
            if(delta.x <= 0f)
            {
                goto label_11;
            }
            
            val_7 = val_7 + 1;
            goto label_15;
            label_9:
            if(delta.y <= 0f)
            {
                goto label_13;
            }
            
            val_8 = val_8 + 1;
            goto label_14;
            label_11:
            val_7 = val_7 - 1;
            goto label_15;
            label_13:
            val_8 = val_8 - 1;
            label_14:
            label_15:
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_5 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  val_7, y:  val_8);
            val_9 = 1;
            cellPoint.x = val_5.x;
            return (bool)val_9;
        }
        private UnityEngine.Vector2 GetMousePosition()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Input.mousePosition;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            UnityEngine.Vector3 val_3 = this.cameraManager.ScreenToWorldPoint(screenCoordinates:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
            return UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        }
        private bool IsTouchedBoosterBackground(UnityEngine.Vector2 mousePosition)
        {
            UnityEngine.Object val_6 = this;
            if(this.boosterManager.selectedBooster == 0)
            {
                    return false;
            }
            
            val_6 = UnityEngine.Physics2D.OverlapPoint(point:  new UnityEngine.Vector2() {x = mousePosition.x, y = mousePosition.y}, layerMask:  UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = this.layerMask}));
            if(val_6 == 0)
            {
                    return false;
            }
            
            val_6 = val_6.GetComponent<Royal.Scenes.Game.Ui.Bottom.Boosters.BoosterUseBackground>();
            if(val_6 == 0)
            {
                    return false;
            }
            
            val_6.Touch();
            return false;
        }
        private Royal.Scenes.Game.Mechanics.Board.Cell.View.ITouchableCell GetTouchedCell(UnityEngine.Vector2 mousePosition)
        {
            UnityEngine.Collider2D val_2 = UnityEngine.Physics2D.OverlapPoint(point:  new UnityEngine.Vector2() {x = mousePosition.x, y = mousePosition.y}, layerMask:  UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = this.layerMask}));
            if(val_2 != 0)
            {
                    return val_2.GetComponent<Royal.Scenes.Game.Mechanics.Board.Cell.View.ITouchableCell>();
            }
            
            return 0;
        }
        public void TriggerOnCellsSwapped(Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint cellFrom, Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint cellTo)
        {
            object[] val_1 = new object[2];
            val_1[0] = cellFrom;
            val_1[1] = cellTo;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  5, log:  "Swap: {0} -> {1}", values:  val_1);
            this.touchManager.SwapCells(pointFrom:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = cellFrom.x, y = cellFrom.y}, pointTo:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = cellTo.x, y = cellTo.y});
        }
        public void TriggerOnTouchCell(Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint cell)
        {
            object[] val_1 = new object[1];
            val_1[0] = cell;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  5, log:  "Tap: {0}", values:  val_1);
            this.touchManager.TouchCell(cellPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = cell.x, y = cell.y});
        }
    
    }

}
