using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.Strategy
{
    public class PropellerDefaultStrategy : IPropellerStrategy
    {
        // Fields
        private readonly Royal.Player.Context.Units.LevelManager levelManager;
        
        // Methods
        public PropellerDefaultStrategy()
        {
            this.levelManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LevelManager>(id:  2);
        }
        public virtual bool ExplodeNeighbors(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, Royal.Scenes.Game.Mechanics.Explode.Trigger trigger, Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.PropellerItemModel propellerItemModel)
        {
            int val_2;
            int val_3;
            var val_5;
            var val_6;
            Royal.Scenes.Game.Mechanics.Explode.ExplodeData val_1 = Royal.Scenes.Game.Mechanics.Explode.Exploder.Next(trigger:  8);
            ExplodeTopMostBelowItem(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_3, y = val_3}, trigger = val_3, id = val_2});
            if(trigger == 15)
            {
                    return true;
            }
            
            Royal.Scenes.Game.Mechanics.Explode.ExplodeData val_4 = Royal.Scenes.Game.Mechanics.Explode.Exploder.Next(trigger:  9);
            val_2 = val_5;
            val_3 = val_6;
            propellerItemModel = this;
            UnityEngine.Coroutine val_7 = Royal.Scenes.Game.Context.GameContext.ManualStartCoroutine(iEnumerator:  this);
            return true;
        }
        public virtual Royal.Scenes.Game.Mechanics.Explode.ExplodeData NextExploder(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            if(cell != null)
            {
                    return Royal.Scenes.Game.Mechanics.Explode.Exploder.Next(trigger:  8, point:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = cell, y = cell});
            }
            
            throw new NullReferenceException();
        }
        public virtual void OnTargetReached(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, Royal.Scenes.Game.Mechanics.Explode.ExplodeData exploder)
        {
            if(cell == null)
            {
                    return;
            }
            
            cell.ExplodeCurrentItem(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = exploder.point.x}, id = exploder.id});
        }
        public virtual Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerPilot.IPropellerPilot GetNewPilot()
        {
            return (Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerPilot.IPropellerPilot)new Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerPilot.DefaultPropellerPilot();
        }
        public virtual bool IsTntOrRocketCombo()
        {
            return false;
        }
        public virtual void OnTargetFound()
        {
        
        }
        public virtual void OnTargetCancelled()
        {
        
        }
        protected virtual System.Collections.IEnumerator ExplodeNeighbors(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, Royal.Scenes.Game.Mechanics.Explode.ExplodeData data, Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.PropellerItemModel propellerItemModel)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .cell = cell;
            .propellerItemModel = propellerItemModel;
            mem[1152921520115894984] = data.id;
            .data = data.point.x;
            return (System.Collections.IEnumerator)new PropellerDefaultStrategy.<ExplodeNeighbors>d__9();
        }
        private void TryRedirectForWinCondition(Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.PropellerItemModel propellerItemModel)
        {
            if(this.levelManager.isThereSoilInLevel == false)
            {
                    return;
            }
            
            System.Nullable<Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint> val_2 = Royal.Scenes.Game.Levels.LevelContext.GetLate<Royal.Scenes.Game.Mechanics.Items.SoilItem.SoilItemHelper>(contextId:  30).TryGetLastGroupsSoilCellPointWithOneLayer();
            if((0 & 255) != 0)
            {
                    return;
            }
            
            propellerItemModel = 1;
            propellerItemModel = 0;
        }
    
    }

}
