using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem
{
    public class TntItemModel : SpecialItemModel, IItemViewDelegate
    {
        // Fields
        public const int DefaultExplodeRadius = 2;
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.TntExplosionConfig config;
        private readonly bool isCreatedByLightball;
        public Royal.Scenes.Game.Mechanics.Explode.ExplodeData lightBallExplodeData;
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntItemView <ItemView>k__BackingField;
        
        // Properties
        public Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntItemView ItemView { get; set; }
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType ItemType { get; }
        public override Royal.Scenes.Game.Levels.Units.Touch.MoveType GetMoveType { get; }
        
        // Methods
        public Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntItemView get_ItemView()
        {
            return (Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntItemView)this.<ItemView>k__BackingField;
        }
        private void set_ItemView(Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntItemView value)
        {
            this.<ItemView>k__BackingField = value;
        }
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType get_ItemType()
        {
            return 4;
        }
        public override Royal.Scenes.Game.Levels.Units.Touch.MoveType get_GetMoveType()
        {
            return 1;
        }
        public TntItemModel(bool isCreatedByLightball)
        {
            mem[1152921520072154161] = 1;
            val_1 = new Royal.Scenes.Game.Mechanics.Items.Config.ItemModel(layer:  1);
            this.isCreatedByLightball = isCreatedByLightball;
            mem[1152921520072154168] = 3;
        }
        public override void CreateView(UnityEngine.Vector3 position)
        {
            var val_3;
            var val_4;
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntItemView val_1 = 37936.Spawn<Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntItemView>(poolId:  13, activate:  true);
            this.<ItemView>k__BackingField = val_1;
            val_1.Init(tntViewDelegate:  this, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
            Royal.Infrastructure.Utils.Animation.ShakeAnimationConfig val_2 = Royal.Infrastructure.Utils.Animation.ShakeAnimationConfig.TntConfig;
            this.config = 2;
            mem[1152921520072275396] = 2;
            mem[1152921520072275388] = 5.23869069478378E-11;
            mem[1152921520072275400] = ;
            mem[1152921520072275380] = val_4;
            mem[1152921520072275364] = val_3;
            mem[1152921520072275416] = 1028443341;
        }
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemView GetItemView()
        {
            return (Royal.Scenes.Game.Mechanics.Items.Config.ItemView)this.<ItemView>k__BackingField;
        }
        public override bool CanExplodeWithNearMatch()
        {
            return false;
        }
        public override void Explode(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            if(this.isCreatedByLightball != false)
            {
                    if((-1714040304) != 15)
            {
                    return;
            }
            
            }
            
            this.Explode(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id});
        }
        protected override void TryExplode(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            37941.StartSpecialOperation();
            if((-1713895632) == 14)
            {
                    UnityEngine.Coroutine val_2 = Royal.Scenes.Game.Context.GameContext.ManualStartCoroutine(iEnumerator:  this.WaitAndExplodeViews(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id}));
                return;
            }
            
            this.ExplodeViews(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id});
        }
        private System.Collections.IEnumerator WaitAndExplodeViews(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            .<>4__this = this;
            mem[1152921520072977544] = data.id;
            .data = data.point.x;
            return (System.Collections.IEnumerator)new TntItemModel.<WaitAndExplodeViews>d__18(<>1__state:  0);
        }
        private void ExplodeViews(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            if(this.config >= 1)
            {
                    UnityEngine.Coroutine val_2 = Royal.Scenes.Game.Context.GameContext.ManualStartCoroutine(iEnumerator:  this.ExplodeCells(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id}));
            }
            else
            {
                    37939.FinishSpecialOperation();
            }
            
            if(this.config == 2)
            {
                    this.<ItemView>k__BackingField.Explode();
            }
            else
            {
                    this.<ItemView>k__BackingField.Recycle();
            }
            
            if((this.<ItemView>k__BackingField.CurrentCell) == null)
            {
                    return;
            }
            
            this = ???;
            goto typeof(Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.TntItemModel).__il2cppRuntimeField_350;
        }
        private System.Collections.IEnumerator ExplodeCells(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            .<>1__state = 0;
            .<>4__this = this;
            mem[1152921520073291464] = data.id;
            .data = data.point.x;
            return (System.Collections.IEnumerator)new TntItemModel.<ExplodeCells>d__20();
        }
        private void ExplodeOrImpactOuterCells(int radius, int xOffset, int yOffset, Royal.Scenes.Game.Mechanics.Explode.ExplodeData tntData)
        {
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.TntExplosionConfig val_1 = W9 + this.config;
            if(val_1 < (-val_1))
            {
                    return;
            }
            
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.TntExplosionConfig val_11 = -val_1;
            label_12:
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.TntExplosionConfig val_10 = -val_1;
            label_11:
            if((val_10 | val_11) != 0)
            {
                    int val_4 = UnityEngine.Mathf.Abs(value:  val_11);
                int val_5 = UnityEngine.Mathf.Abs(value:  val_10);
                if((UnityEngine.Mathf.Max(a:  val_4, b:  val_5)) == radius)
            {
                    Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_8 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  val_11 + xOffset, y:  yOffset + val_10);
                Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_9 = X21.Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_8.x, y = val_8.x}];
                if((val_9 != null) && (val_4 <= this.config))
            {
                    if(val_4 != val_5)
            {
                    if(val_5 > this.config)
            {
                goto label_10;
            }
            
            }
            
                Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.TntItemModel.ExplodeOuterCell(cellModel:  val_9, data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = tntData.point.x, y = tntData.point.x}, trigger = tntData.point.x, id = tntData.point.x + 16, matchType = val_8.x});
            }
            
            }
            
            }
            
            label_10:
            val_10 = val_10 + 1;
            if(val_10 <= val_1)
            {
                goto label_11;
            }
            
            val_11 = val_11 + 1;
            if(val_11 <= val_1)
            {
                goto label_12;
            }
        
        }
        private static void ExplodeOuterCell(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cellModel, Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            cellModel.FreezeFallForDuration(duration:  0.25f);
            cellModel.ExplodeCurrentItem(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id});
        }
        private void ImpactOuterCell(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cellModel, int radius, int x, int y, Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint tntPoint)
        {
            var val_10;
            float val_11;
            bool val_1 = 37940.HasCurrentItem();
            if(val_1 == false)
            {
                    return;
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_2 = val_1.CurrentItem;
            val_10 = val_2;
            if((val_2 & 1) == 0)
            {
                    return;
            }
            
            val_10 = val_10;
            if((val_2.<MatchType>k__BackingField) != 0)
            {
                    return;
            }
            
            float val_12 = V2.16B;
            float val_3 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = val_12}, b:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B});
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.TntExplosionConfig val_10 = this.config;
            val_3 = val_3 * val_3;
            val_10 = radius - val_10;
            var val_4 = (val_10 == 1) ? 192 : 196;
            val_11 = V1.16B / val_3;
            float val_5 = val_12 * (float)val_10;
            val_5 = val_11 * val_5;
            int val_8 = (UnityEngine.Mathf.Abs(value:  x)) - (UnityEngine.Mathf.Abs(value:  y));
            val_8 = val_8 + 2;
            if(val_8 <= 4)
            {
                    var val_11 = 36610384 + (((val_6 - val_7) + 2)) << 2;
                val_11 = val_11 + 36610384;
            }
            else
            {
                    float val_13 = (float)x;
                val_12 =  * (float)y;
                 =  * val_13;
                if(val_12 > 0f)
            {
                    val_13 = val_13 + 0.15f;
                cellModel.FreezeFallForDuration(duration:  val_13);
            }
            
                val_10.Impact(xDiff:  null, yDiff:  val_12, firstSpeed:  val_5, lastSpeed:  null * val_5);
            }
        
        }
        public override void SwapWith(Royal.Scenes.Game.Mechanics.Items.Config.ItemModel item, Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
        
        }
        public override bool Tap(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            return true;
        }
        private void PrepareConfig()
        {
            var val_2;
            var val_3;
            Royal.Infrastructure.Utils.Animation.ShakeAnimationConfig val_1 = Royal.Infrastructure.Utils.Animation.ShakeAnimationConfig.TntConfig;
            this.config = 2;
            mem[1152921520074086948] = 2;
            mem[1152921520074086940] = 5.23869069478378E-11;
            mem[1152921520074086952] = ;
            mem[1152921520074086932] = val_3;
            mem[1152921520074086916] = val_2;
            mem[1152921520074086968] = 1028443341;
        }
        public void IncreaseExplosion()
        {
            var val_2;
            var val_3;
            Royal.Infrastructure.Utils.Animation.ShakeAnimationConfig val_1 = Royal.Infrastructure.Utils.Animation.ShakeAnimationConfig.TntTntConfig;
            this.config = 4;
            mem[1152921520074207060] = val_2;
            mem[1152921520074207068] = 5.23869069478378E-11;
            mem[1152921520074207080] = ;
            mem[1152921520074207076] = 2;
            mem[1152921520074207044] = val_3;
            mem[1152921520074207096] = 1041865114;
        }
        public void DisableExplosion()
        {
            this.config = 0;
        }
    
    }

}
