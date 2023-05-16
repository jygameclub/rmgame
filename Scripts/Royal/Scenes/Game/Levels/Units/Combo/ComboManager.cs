using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.Combo
{
    public class ComboManager : IGameContextUnit, IContextUnit
    {
        // Fields
        private Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory;
        private Royal.Scenes.Game.Context.Units.GameTouchListener touchManager;
        private Royal.Scenes.Game.Levels.Units.CellGridManager gridManager;
        private Royal.Scenes.Game.Levels.Units.Combo.PropellerPropellerCombo propellerPropeller;
        private Royal.Scenes.Game.Levels.Units.Combo.PropellerRocketCombo propellerRocket;
        private Royal.Scenes.Game.Levels.Units.Combo.TntPropellerCombo tntPropeller;
        private Royal.Scenes.Game.Levels.Units.Combo.LightballRocketCombo lightballRocket;
        private Royal.Scenes.Game.Levels.Units.Combo.LightballTntCombo lightballTnt;
        private Royal.Scenes.Game.Levels.Units.Combo.BallBallCombo ballBall;
        private Royal.Scenes.Game.Levels.Units.Combo.TntTntCombo tntTnt;
        private Royal.Scenes.Game.Levels.Units.Combo.RocketRocketCombo rocketRocket;
        private Royal.Scenes.Game.Levels.Units.Combo.TntRocketCombo tntRocket;
        private Royal.Scenes.Game.Levels.Units.Combo.LightballPropellerCombo lightballPropeller;
        
        // Properties
        public int Id { get; }
        public Royal.Scenes.Game.Levels.Units.Combo.BallBallCombo BallBall { get; }
        
        // Methods
        public int get_Id()
        {
            return 13;
        }
        public Royal.Scenes.Game.Levels.Units.Combo.BallBallCombo get_BallBall()
        {
            return (Royal.Scenes.Game.Levels.Units.Combo.BallBallCombo)this.ballBall;
        }
        public void Bind()
        {
            this.touchManager = Royal.Scenes.Game.Context.GameContext.Get<Royal.Scenes.Game.Context.Units.GameTouchListener>(id:  0);
            this.itemFactory = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1);
            this.gridManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.CellGridManager>(contextId:  2);
            this.propellerPropeller = new Royal.Scenes.Game.Levels.Units.Combo.PropellerPropellerCombo();
            this.propellerRocket = new Royal.Scenes.Game.Levels.Units.Combo.PropellerRocketCombo();
            this.tntPropeller = new Royal.Scenes.Game.Levels.Units.Combo.TntPropellerCombo();
            this.lightballRocket = new Royal.Scenes.Game.Levels.Units.Combo.LightballRocketCombo();
            this.lightballTnt = new Royal.Scenes.Game.Levels.Units.Combo.LightballTntCombo();
            this.lightballPropeller = new Royal.Scenes.Game.Levels.Units.Combo.LightballPropellerCombo();
            .factory = this.itemFactory;
            this.tntTnt = new Royal.Scenes.Game.Levels.Units.Combo.TntTntCombo();
            this.rocketRocket = new Royal.Scenes.Game.Levels.Units.Combo.RocketRocketCombo();
            this.tntRocket = new Royal.Scenes.Game.Levels.Units.Combo.TntRocketCombo(itemFactory:  this.itemFactory, touchListener:  this.touchManager, gridManager:  this.gridManager);
            this.ballBall = new Royal.Scenes.Game.Levels.Units.Combo.BallBallCombo(factory:  this.itemFactory, touchManager:  this.touchManager, gridManager:  this.gridManager);
        }
        public void Explode(Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemModel toItem, Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemModel fromItem, Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            object val_14;
            if((Royal.Scenes.Game.Levels.Units.Combo.ComboManager.IsCombo(to:  toItem, from:  fromItem, comboType:  10)) != false)
            {
                    this.propellerPropeller.Prepare(toItem:  toItem, fromItem:  fromItem);
                this.propellerPropeller.Explode(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id});
                val_14 = 10;
            }
            else
            {
                    if((Royal.Scenes.Game.Levels.Units.Combo.ComboManager.IsCombo(to:  toItem, from:  fromItem, comboType:  9)) != false)
            {
                    this.propellerRocket.Prepare(toItem:  toItem, fromItem:  fromItem);
                this.propellerRocket.Explode(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id});
                val_14 = 9;
            }
            else
            {
                    if((Royal.Scenes.Game.Levels.Units.Combo.ComboManager.IsCombo(to:  toItem, from:  fromItem, comboType:  8)) != false)
            {
                    this.tntPropeller.Prepare(toItem:  toItem, fromItem:  fromItem);
                this.tntPropeller.Explode(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id});
                val_14 = 8;
            }
            else
            {
                    if((Royal.Scenes.Game.Levels.Units.Combo.ComboManager.IsCombo(to:  toItem, from:  fromItem, comboType:  4)) != false)
            {
                    this.lightballRocket.Prepare(toItem:  toItem, fromItem:  fromItem);
                this.lightballRocket.Explode(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id});
                val_14 = 4;
            }
            else
            {
                    if((Royal.Scenes.Game.Levels.Units.Combo.ComboManager.IsCombo(to:  toItem, from:  fromItem, comboType:  2)) != false)
            {
                    this.lightballTnt.Prepare(toItem:  toItem, fromItem:  fromItem);
                this.lightballTnt.Explode(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id});
                val_14 = 2;
            }
            else
            {
                    if((Royal.Scenes.Game.Levels.Units.Combo.ComboManager.IsCombo(to:  toItem, from:  fromItem, comboType:  1)) != false)
            {
                    this.ballBall.Prepare(toItem:  toItem, fromItem:  fromItem);
                this.ballBall.Explode(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = toItem, y = toItem}, trigger = toItem, id = toItem, matchType = toItem});
                val_14 = 1;
            }
            else
            {
                    if((Royal.Scenes.Game.Levels.Units.Combo.ComboManager.IsCombo(to:  toItem, from:  fromItem, comboType:  5)) != false)
            {
                    Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.Sfx.GameSfxManager>(contextId:  22).PlaySfx(type:  1, offset:  0.04f);
                this.tntTnt.Prepare(toItem:  toItem, fromItem:  fromItem);
                this.tntTnt.Explode(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id});
                val_14 = 5;
            }
            else
            {
                    if((Royal.Scenes.Game.Levels.Units.Combo.ComboManager.IsCombo(to:  toItem, from:  fromItem, comboType:  7)) != false)
            {
                    this.rocketRocket.Prepare(toItem:  toItem, fromItem:  fromItem);
                this.rocketRocket.Explode(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id});
                val_14 = 7;
            }
            else
            {
                    if((Royal.Scenes.Game.Levels.Units.Combo.ComboManager.IsCombo(to:  toItem, from:  fromItem, comboType:  6)) != false)
            {
                    this.tntRocket.Prepare(to:  toItem, from:  fromItem);
                this.tntRocket.Explode(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = toItem, y = toItem}, trigger = toItem, id = toItem, matchType = toItem});
                val_14 = 6;
            }
            else
            {
                    if((Royal.Scenes.Game.Levels.Units.Combo.ComboManager.IsCombo(to:  toItem, from:  fromItem, comboType:  3)) != false)
            {
                    this.lightballPropeller.Prepare(toItem:  toItem, fromItem:  fromItem);
                this.lightballPropeller.Explode(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id});
                val_14 = 3;
            }
            else
            {
                    val_14 = 0;
            }
            
            }
            
            }
            
            }
            
            }
            
            }
            
            }
            
            }
            
            }
            
            }
            
            object[] val_12 = new object[1];
            val_12[0] = val_14;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  5, log:  "Made combo: {0}", values:  val_12);
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemCounts.IncrementComboUse(comboType:  val_14);
        }
        public static bool IsCombo(Royal.Scenes.Game.Mechanics.Items.Config.ItemModel to, Royal.Scenes.Game.Mechanics.Items.Config.ItemModel from, Royal.Scenes.Game.Levels.Units.Combo.ComboType comboType)
        {
            var val_3 = 0;
            if(to == null)
            {
                    return (bool)val_3;
            }
            
            if(from == null)
            {
                    return (bool)val_3;
            }
            
            if((comboType - 1) <= 9)
            {
                    if((to == (36588080 + ((comboType - 1)) << 2)) && (from == (36588032 + ((comboType - 1)) << 2)))
            {
                    val_3 = 1;
                return (bool)val_3;
            }
            
                if(to == (36588032 + ((comboType - 1)) << 2))
            {
                    var val_2 = (from == (36588080 + ((comboType - 1)) << 2)) ? 1 : 0;
                return (bool)val_3;
            }
            
            }
            
            val_3 = 0;
            return (bool)val_3;
        }
        public static bool IsAnyCombo(Royal.Scenes.Game.Mechanics.Items.Config.ItemModel to, Royal.Scenes.Game.Mechanics.Items.Config.ItemModel from)
        {
            if(to == null)
            {
                    return false;
            }
            
            if(from == null)
            {
                    return false;
            }
            
            if((to & 1) == 0)
            {
                    return false;
            }
            
            goto typeof(Royal.Scenes.Game.Mechanics.Items.Config.ItemModel).__il2cppRuntimeField_380;
        }
        public static Royal.Scenes.Game.Levels.Units.Combo.SwipeType GetSwipeTypeFromPoints(Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint from, Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint to)
        {
            if(from.x != to.x)
            {
                    return (Royal.Scenes.Game.Levels.Units.Combo.SwipeType)(from.x >= to.x) ? (2 + 1) : 2;
            }
            
            return (Royal.Scenes.Game.Levels.Units.Combo.SwipeType)((from.x >> 32) < (to.x >> 32)) ? 1 : 0;
        }
        public void Clear(bool gameExit)
        {
        
        }
        public ComboManager()
        {
        
        }
    
    }

}
