using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.DrillItem
{
    public class DrillHelper : IGameContextUnit, IContextUnit, ILateContextUnit
    {
        // Fields
        private Royal.Scenes.Game.Levels.Units.State.GameStateManager gameStateManager;
        private readonly System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillManager>[] drillManagersByColor;
        private readonly System.Collections.Generic.Queue<int> drillPlayQueue;
        private bool isAnyDrillMoving;
        private bool isInitialized;
        private System.Action OnDrillActivated;
        
        // Properties
        public int Id { get; }
        
        // Methods
        public int get_Id()
        {
            return 31;
        }
        public void add_OnDrillActivated(System.Action value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnDrillActivated, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnDrillActivated != 1152921520347495408);
            
            return;
            label_2:
        }
        public void remove_OnDrillActivated(System.Action value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnDrillActivated, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnDrillActivated != 1152921520347631984);
            
            return;
            label_2:
        }
        public void Bind()
        {
            this.gameStateManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14);
        }
        private int GetIndexByMatchType(Royal.Scenes.Game.Mechanics.Matches.MatchType matchType)
        {
            return (int)matchType - 1;
        }
        public void InitDrills()
        {
            var val_4;
            if(this.isInitialized == true)
            {
                    return;
            }
            
            this.isInitialized = true;
            Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory val_1 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1);
            if(val_1.itemCreator < 1)
            {
                    return;
            }
            
            var val_6 = 0;
            do
            {
                if(val_6 >= val_1.itemCreator)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                this.AddDrill(matchType:  Royal.Scenes.Game.Levels.Units.ItemCreation.ItemCreator.__il2cppRuntimeField_byval_arg, order:  -1438719360, target:  -1438719360, masterX:  -1438719408, masterY:  -1438719408, managerId:  0);
                val_6 = val_6 + 1;
            }
            while(val_6 < val_4);
        
        }
        private void AddDrill(Royal.Scenes.Game.Mechanics.Matches.MatchType matchType, int order, int target, int masterX, int masterY, int managerId)
        {
            Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillManager val_1 = new Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillManager();
            .matchType = matchType;
            .order = order;
            .masterX = masterX;
            .masterY = masterY;
            .managerId = managerId;
            .leftTarget = target;
            System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillManager> val_4 = this.drillManagersByColor[matchType - 1];
            if(val_4 != null)
            {
                    val_1.AddDrillByOrder(drillManagers:  val_4, drillManager:  val_1);
                return;
            }
            
            System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillManager> val_3 = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillManager>();
            val_3.Add(item:  val_1);
            mem2[0] = val_3;
        }
        private void AddDrillByOrder(System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillManager> drillManagers, Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillManager drillManager)
        {
            bool val_1 = true;
            if(val_1 < 1)
            {
                goto label_2;
            }
            
            var val_2 = 0;
            label_7:
            if(val_1 <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + 0;
            if(drillManager.order < ((true + 0) + 32 + 20))
            {
                goto label_6;
            }
            
            val_2 = val_2 + 1;
            if(val_2 < ((true + 0) + 32 + 20))
            {
                goto label_7;
            }
            
            label_2:
            drillManagers.Add(item:  drillManager);
            return;
            label_6:
            drillManagers.Insert(index:  0, item:  drillManager);
        }
        public void Clear(bool gameExit)
        {
            this.OnDrillActivated = 0;
            this.isAnyDrillMoving = false;
            this.isInitialized = false;
            var val_1 = 0;
            label_4:
            if(val_1 >= (this.drillManagersByColor.Length << ))
            {
                goto label_2;
            }
            
            this.drillManagersByColor[val_1] = 0;
            val_1 = val_1 + 1;
            if(this.drillManagersByColor != null)
            {
                goto label_4;
            }
            
            throw new NullReferenceException();
            label_2:
            this.drillPlayQueue.Clear();
        }
        public Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillManager GetDrillForMatchType(Royal.Scenes.Game.Mechanics.Matches.MatchType matchType)
        {
            System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillManager> val_2;
            Royal.Scenes.Game.Mechanics.Matches.MatchType val_1 = matchType - 1;
            if((this.drillManagersByColor[val_1] == null) || (this.drillManagersByColor[val_1] < 1))
            {
                    return 0;
            }
            
            var val_3 = 0;
            label_12:
            if(this.drillManagersByColor[val_1] <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_2 = this.drillManagersByColor[val_1][val_3];
            if(val_1 >= 1)
            {
                goto label_11;
            }
            
            val_1 = this.drillManagersByColor[val_1][val_3] - 1;
            if(val_3 < val_1)
            {
                goto label_8;
            }
            
            if(this.drillManagersByColor[val_1][val_3] <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_2 = this.drillManagersByColor[val_1][val_3][0];
            }
            
            val_1 = this.drillManagersByColor.Length + val_1;
            if(val_1 >= 1)
            {
                goto label_11;
            }
            
            label_8:
            val_3 = val_3 + 1;
            if(val_3 < this.drillManagersByColor[val_1][val_3][0])
            {
                goto label_12;
            }
            
            return 0;
            label_11:
            if(this.drillManagersByColor[val_1][val_3] > val_3)
            {
                    return 0;
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillManager> val_4 = this.drillManagersByColor[val_1][val_3][0];
            return 0;
        }
        public Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillManager GetDrillManagerByPoint(Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint point)
        {
            var val_2;
            System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillManager> val_3;
            val_2 = 0;
            label_11:
            if(val_2 >= (this.drillManagersByColor.Length << ))
            {
                goto label_2;
            }
            
            if((this.drillManagersByColor[val_2] != null) && (this.drillManagersByColor[val_2] >= 1))
            {
                    var val_3 = 0;
                do
            {
                if(this.drillManagersByColor[val_2] <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_3 = this.drillManagersByColor[val_2][val_3];
                if(this.drillManagersByColor[val_2][val_3] == point.x)
            {
                    if(this.drillManagersByColor[val_2][val_3] == (point.x >> 32))
            {
                    return (Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillManager)val_3;
            }
            
            }
            
                val_3 = val_3 + 1;
            }
            while(val_3 < this.drillManagersByColor[val_2][val_3]);
            
            }
            
            val_2 = val_2 + 1;
            if(this.drillManagersByColor != null)
            {
                goto label_11;
            }
            
            throw new NullReferenceException();
            label_2:
            val_3 = 0;
            return (Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillManager)val_3;
        }
        private Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillManager GetDrillManagerById(int id)
        {
            var val_1;
            System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillManager> val_2;
            val_1 = 0;
            label_10:
            if(val_1 >= (this.drillManagersByColor.Length << ))
            {
                goto label_2;
            }
            
            if((this.drillManagersByColor[val_1] != null) && (this.drillManagersByColor[val_1] >= 1))
            {
                    var val_2 = 0;
                do
            {
                if(this.drillManagersByColor[val_1] <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_2 = this.drillManagersByColor[val_1][val_2];
                if(this.drillManagersByColor[val_1][val_2] == id)
            {
                    return (Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillManager)val_2;
            }
            
                val_2 = val_2 + 1;
            }
            while(val_2 < this.drillManagersByColor[val_1][val_2]);
            
            }
            
            val_1 = val_1 + 1;
            if(this.drillManagersByColor != null)
            {
                goto label_10;
            }
            
            throw new NullReferenceException();
            label_2:
            val_2 = 0;
            return (Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillManager)val_2;
        }
        public static Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillDirection GetDrillDirection(Royal.Scenes.Game.Utils.LevelParser.TiledId tiledId)
        {
            if(tiledId > 124)
            {
                    return (Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillDirection)(tiledId != 133) ? 1 : 0;
            }
            
            tiledId = (tiledId == 123) ? 2 : ((tiledId == 124) ? 3 : (0 + 1));
            return (Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillDirection)tiledId;
        }
        public void TryExplodeWaitingDrill()
        {
            this.isAnyDrillMoving = false;
            if(true == 0)
            {
                    return;
            }
            
            this.ExplodeByDrillManagerId(managerId:  this.drillPlayQueue.Dequeue(), haveWaited:  true);
        }
        public void OnDrillReadyToMove(int managerId)
        {
            this.GetDrillManagerById(id:  managerId) = 1;
            if(this.OnDrillActivated != null)
            {
                    this.OnDrillActivated.Invoke();
            }
            
            this.gameStateManager.OperationStart(animationId:  12);
            if(this.isAnyDrillMoving != false)
            {
                    this.drillPlayQueue.Enqueue(item:  managerId);
                return;
            }
            
            this.ExplodeByDrillManagerId(managerId:  managerId, haveWaited:  false);
        }
        public bool HasAnyPinkDrill()
        {
            var val_2;
            System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillManager> val_2 = this.drillManagersByColor[4];
            if(val_2 != null)
            {
                    var val_1 = (val_2 > 0) ? 1 : 0;
                return (bool)val_2;
            }
            
            val_2 = 0;
            return (bool)val_2;
        }
        public int GetAllPinkDrillsTotalLeftTarget()
        {
            var val_1;
            if((this.drillManagersByColor[4] != null) && (this.drillManagersByColor >= 1))
            {
                    var val_3 = 0;
                do
            {
                if(this.drillManagersByColor <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillManager> val_2 = this.drillManagersByColor[val_3];
                val_3 = val_3 + 1;
            }
            while(val_3 < this.drillManagersByColor[val_3]);
            
                return (int)val_1;
            }
            
            val_1 = 0;
            return (int)val_1;
        }
        private void ExplodeByDrillManagerId(int managerId, bool haveWaited)
        {
            this.isAnyDrillMoving = true;
            this.GetDrillManagerById(id:  managerId).MoveDrill(haveWaited:  haveWaited);
        }
        public bool IsBlockedByAnyActiveDrill(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cellModel)
        {
            var val_1;
            int val_2;
            System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillManager> val_8;
            System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillManager>[] val_9;
            var val_10;
            var val_11;
            val_9 = this.drillManagersByColor;
            val_10 = 0;
            label_24:
            if(val_10 >= (this.drillManagersByColor.Length << ))
            {
                goto label_7;
            }
            
            if((val_9[val_10] == null) || (val_9[val_10] < 1))
            {
                goto label_5;
            }
            
            var val_12 = 0;
            goto label_23;
            label_11:
            if((WillTargetCell(cellPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_2, y = val_2})) == true)
            {
                goto label_22;
            }
            
             =  + 1;
            if( < val_1)
            {
                goto label_11;
            }
            
            goto label_20;
            label_23:
            if(val_9[val_10] <= val_12)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_8 = val_9[val_12];
            if((val_9[val_12] == null) || (val_9[val_12] == null))
            {
                goto label_16;
            }
            
            if(cellModel.CurrentItem != null)
            {
                    Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_5 = cellModel.CurrentItem;
            }
            
            label_20:
            if((val_8.WillTargetCell(cellPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint())) == true)
            {
                goto label_22;
            }
            
            label_16:
            val_12 = val_12 + 1;
            if(val_12 < null)
            {
                goto label_23;
            }
            
            val_9 = this.drillManagersByColor;
            label_5:
            val_10 = val_10 + 1;
            if(val_9 != null)
            {
                goto label_24;
            }
            
            throw new NullReferenceException();
            label_22:
            val_11 = 1;
            return (bool)val_11;
            label_7:
            val_11 = 0;
            return (bool)val_11;
        }
        public DrillHelper()
        {
            this.drillManagersByColor = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillManager>[5];
            this.drillPlayQueue = new System.Collections.Generic.Queue<System.Int32>();
        }
    
    }

}
