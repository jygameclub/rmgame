using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Boosters.Hammer
{
    public class HammerBooster
    {
        // Fields
        private readonly Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory;
        private readonly Royal.Scenes.Game.Levels.Units.CellGridManager gridManager;
        private readonly Royal.Scenes.Game.Levels.Units.State.GameStateManager gameState;
        private UnityEngine.Vector3 startPosition;
        
        // Methods
        public HammerBooster()
        {
            this.itemFactory = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1);
            this.gridManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.CellGridManager>(contextId:  2);
            this.gameState = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14);
        }
        public bool Use(Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint toPoint)
        {
            int val_26;
            System.Action val_27;
            float val_29;
            float val_30;
            float val_31;
            var val_32;
            float val_35;
            float val_36;
            var val_37;
            val_26 = toPoint.x;
            .<>4__this = this;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_2 = this.gridManager.Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_26, y = toPoint.y}];
            .cell = val_2;
            bool val_3 = val_2.HasCurrentItem();
            if(val_3 != false)
            {
                    if((((HammerBooster.<>c__DisplayClass5_0)[1152921523899292336].cell.CurrentItem) & 1) == 0)
            {
                goto label_18;
            }
            
            }
            
            val_27 = (HammerBooster.<>c__DisplayClass5_0)[1152921523899292336].cell.<StaticMediator>k__BackingField.HasTouchBlockingItem();
            if((val_3 | val_27) != true)
            {
                    if(((HammerBooster.<>c__DisplayClass5_0)[1152921523899292336].cell.<StaticMediator>k__BackingField.HasBelowItem()) == false)
            {
                goto label_18;
            }
            
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.StaticItemModel val_8 = (HammerBooster.<>c__DisplayClass5_0)[1152921523899292336].cell.<StaticMediator>k__BackingField.GetTopMostAboveItem();
            if(val_8 != null)
            {
                    if((val_8 & 1) == 0)
            {
                goto label_18;
            }
            
            }
            
            this.gameState.OperationStart(animationId:  7);
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
            val_29 = this.startPosition;
            val_30 = V8.16B;
            val_31 = V9.16B;
            if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = val_29, y = val_30, z = val_31}, rhs:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z})) != false)
            {
                    val_32 = null;
                val_32 = null;
                UnityEngine.Vector3 val_12 = Royal.Scenes.Game.Ui.GameUi.__il2cppRuntimeField_byval_arg + 32 + 32.transform.position;
                val_29 = val_12.x;
                val_30 = val_12.y;
                val_31 = val_12.z;
                UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_29, y = val_30, z = val_31}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                this.startPosition = val_13;
                mem[1152921523899260380] = val_13.y;
                mem[1152921523899260384] = val_13.z;
            }
            
            UnityEngine.Vector2 val_14 = (HammerBooster.<>c__DisplayClass5_0)[1152921523899292336].cell.<CellView>k__BackingField.Position;
            val_35 = val_14.x;
            val_36 = val_14.y;
            if((val_27 | (~val_3)) != true)
            {
                    if((((HammerBooster.<>c__DisplayClass5_0)[1152921523899292336].cell.CurrentItem) & 1) == 0)
            {
                    val_30 = val_14.y;
                UnityEngine.Vector2 val_17 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_14.x, y = val_30, z = val_13.z});
                val_35 = val_17.x;
                val_36 = val_17.y;
            }
            
            }
            
            Royal.Scenes.Game.Mechanics.Boosters.Hammer.View.HammerBoosterView val_19 = UnityEngine.Object.Instantiate<Royal.Scenes.Game.Mechanics.Boosters.Hammer.View.HammerBoosterView>(original:  UnityEngine.Resources.Load<Royal.Scenes.Game.Mechanics.Boosters.Hammer.View.HammerBoosterView>(path:  "HammerBoosterPrefab"));
            val_26 = val_26 >> 32;
            val_19.Init(position:  new UnityEngine.Vector3() {x = this.startPosition, y = val_17.y, z = val_13.z}, overUi:  ((val_36 - val_17.y) < 0) ? 1 : 0, factory:  this.itemFactory);
            UnityEngine.Vector3 val_23 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_35, y = val_36});
            System.Action val_24 = null;
            val_27 = val_24;
            val_24 = new System.Action(object:  new HammerBooster.<>c__DisplayClass5_0(), method:  System.Void HammerBooster.<>c__DisplayClass5_0::<Use>b__0());
            val_19.PlayIn(toPosition:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, isTopCell:  (val_26 > 8) ? 1 : 0, onExplode:  val_24, onDestroy:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Game.Mechanics.Boosters.Hammer.HammerBooster::OnDestroy()));
            val_37 = 1;
            return (bool)val_37;
            label_18:
            val_37 = 0;
            return (bool)val_37;
        }
        private void OnExplode(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            float val_3;
            float val_4;
            cell.FreezeFallForDuration(duration:  0.3f);
            Royal.Scenes.Game.Mechanics.Explode.ExplodeData val_1 = Royal.Scenes.Game.Mechanics.Explode.Exploder.Next(trigger:  17);
            cell.ExplodeCurrentItem(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(), matchType = ???});
            Royal.Infrastructure.Utils.Animation.ShakeAnimationConfig val_2 = Royal.Infrastructure.Utils.Animation.ShakeAnimationConfig.HammerConfig;
            this.gridManager.ShakeGrid(config:  new Royal.Infrastructure.Utils.Animation.ShakeAnimationConfig() {delay = val_4, duration = val_4, minVibrate = val_4, midVibrate = val_4, maxVibrate = val_3, shouldScale = val_3, shouldVisitCenter = val_3});
        }
        private void OnDestroy()
        {
            if(this.gameState != null)
            {
                    this.gameState.OperationFinish(animationId:  7);
                return;
            }
            
            throw new NullReferenceException();
        }
    
    }

}
