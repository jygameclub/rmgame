using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.DrillItem
{
    public class DrillManager : ICollectManager
    {
        // Fields
        public readonly Royal.Scenes.Game.Mechanics.Matches.MatchType matchType;
        public readonly int order;
        private int leftTarget;
        private int incomingCount;
        private int extraIncomingCount;
        private Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillDirection drillDirection;
        public readonly int masterX;
        public readonly int masterY;
        public readonly int managerId;
        public Royal.Scenes.Game.Mechanics.Matches.Cell14 targetCells;
        private Royal.Scenes.Game.Mechanics.Items.DrillItem.View.DrillItemView drillView;
        private Royal.Scenes.Game.Levels.Units.CellGridManager gridManager;
        private Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillHelper drillHelper;
        public bool isBlocking;
        public bool isActive;
        
        // Methods
        public DrillManager(Royal.Scenes.Game.Mechanics.Matches.MatchType matchType, int order, int initialTarget, int masterX, int masterY, int managerId)
        {
            this.matchType = matchType;
            this.order = order;
            this.masterX = masterX;
            this.masterY = masterY;
            this.managerId = managerId;
            this.leftTarget = initialTarget;
        }
        public void Init(Royal.Scenes.Game.Mechanics.Items.DrillItem.View.DrillItemView drillView, Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillDirection drillDirection)
        {
            this.drillView = drillView;
            this.drillDirection = drillDirection;
            this.isActive = true;
            this.gridManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.CellGridManager>(contextId:  2);
            this.drillHelper = Royal.Scenes.Game.Levels.LevelContext.GetLate<Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillHelper>(contextId:  31);
            drillView.counter.UpdateTokenCount(count:  this.leftTarget, isInitial:  true);
            drillView.counter.UpdateTokenSprite();
            this.CalculateTargetCells();
        }
        public UnityEngine.Vector3 GetCollectPosition()
        {
            return this.drillView.counter.countText.transform.position;
        }
        public int GetLeftTarget()
        {
            return (int)this.leftTarget;
        }
        public void DecrementTarget()
        {
            int val_2 = this.leftTarget;
            if(val_2 != 0)
            {
                    val_2 = val_2 - 1;
                this.leftTarget = val_2;
                this.incomingCount = this.incomingCount + 1;
                return;
            }
            
            int val_3 = this.extraIncomingCount;
            val_3 = val_3 + 1;
            this.extraIncomingCount = val_3;
        }
        public void ItemReached(bool hitFromLeft)
        {
            int val_3 = this.incomingCount - 1;
            if()
            {
                    this.incomingCount = val_3;
            }
            else
            {
                    int val_2 = this.extraIncomingCount;
                val_2 = val_2 - 1;
                this.extraIncomingCount = val_2;
                val_3 = this.incomingCount;
            }
            
            this.drillView.counter.UpdateTokenCount(count:  this.leftTarget + val_3, isInitial:  false);
            if((this.leftTarget == 0) && (this.incomingCount == 0))
            {
                    if(this.extraIncomingCount == 0)
            {
                goto label_6;
            }
            
            }
            
            this.drillView.TryPlayHitAnimation();
            return;
            label_6:
            this.StartDrill();
            this.drillHelper.OnDrillReadyToMove(managerId:  this.managerId);
        }
        public bool HasTargetLeftVisual()
        {
            int val_2 = this.leftTarget;
            val_2 = this.incomingCount + val_2;
            return (bool)(val_2 > 0) ? 1 : 0;
        }
        public bool HasTargetLeftLogic()
        {
            return (bool)(this.leftTarget > 0) ? 1 : 0;
        }
        private void StartDrill()
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_1 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  this.masterX, y:  this.masterY);
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_3 = this.gridManager.Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_1.x, y = val_1.x}].CurrentItem;
            if(val_3 == null)
            {
                    return;
            }
            
            val_3.StartDrill();
        }
        public void MoveDrill(bool haveWaited)
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_1 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  this.masterX, y:  this.masterY);
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_3 = this.gridManager.Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_1.x, y = val_1.x}].CurrentItem;
            if(val_3 == null)
            {
                    return;
            }
            
            val_3.MoveDrill(haveWaited:  haveWaited);
        }
        public bool WillTargetCell(Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint cellPoint)
        {
            if(this.drillDirection > 3)
            {
                    throw new System.ArgumentOutOfRangeException();
            }
            
            var val_6 = 36597196 + (this.drillDirection) << 2;
            val_6 = val_6 + 36597196;
            goto (36597196 + (this.drillDirection) << 2 + 36597196);
        }
        private void CalculateTargetCells()
        {
            Royal.Scenes.Game.Mechanics.Matches.Cell14 val_7;
            var val_10;
            val_7 = this;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_1 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  this.masterX, y:  this.masterY);
            if(this.drillDirection <= 3)
            {
                    var val_7 = 36597232 + (this.drillDirection) << 2;
                val_7 = val_7 + 36597232;
            }
            else
            {
                    val_10 = 5;
                if((this.gridManager.Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_1.x, y = val_1.x}]) == null)
            {
                    return;
            }
            
                Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_4 = Get(type:  1);
                if(val_4 == null)
            {
                    return;
            }
            
                val_7 = this.targetCells;
                do
            {
                bool val_5 = val_4.IsNormalCell();
            }
            while((val_7.Get(type:  1)) != null);
            
            }
        
        }
        public Royal.Scenes.Start.Context.Units.Audio.AudioClipType GetCollectAudioClipType()
        {
            return 100;
        }
    
    }

}
