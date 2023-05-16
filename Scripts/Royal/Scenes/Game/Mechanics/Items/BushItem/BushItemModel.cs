using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.BushItem
{
    public class BushItemModel : MultipleCellItemModel, IBushItemViewDelegate, IItemViewDelegate
    {
        // Fields
        public const int ExpandRadius = 2;
        private Royal.Scenes.Game.Mechanics.Items.BushItem.View.BushItemView itemView;
        
        // Properties
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType ItemType { get; }
        
        // Methods
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType get_ItemType()
        {
            return 13;
        }
        public BushItemModel(int layer)
        {
            this.AddToPrerequisite(goalType:  13);
        }
        public int GetLayerCount()
        {
            return (int)this;
        }
        public override void CreateView(UnityEngine.Vector3 position)
        {
            Royal.Scenes.Game.Mechanics.Items.BushItem.View.BushItemView val_1 = 6677.Spawn<Royal.Scenes.Game.Mechanics.Items.BushItem.View.BushItemView>(poolId:  55, activate:  true);
            this.itemView = val_1;
            val_1.Init(bushItemModel:  this, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
            this.HasView = true;
        }
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemView GetItemView()
        {
            return (Royal.Scenes.Game.Mechanics.Items.Config.ItemView)this.itemView;
        }
        public override bool CanExplodeWithNearMatch()
        {
            return true;
        }
        public override bool IsFallable()
        {
            return false;
        }
        public override bool IsSwappable()
        {
            return false;
        }
        public override bool CanReceiveGrass()
        {
            return false;
        }
        protected override void TryExplode(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            int val_1 = true - 1;
            mem[1152921523838127040] = val_1;
            if(<0)
            {
                    return;
            }
            
            this.itemView.Damage(damagedLayer:  val_1);
            if(true != 0)
            {
                    return;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_2 = this.CurrentCell;
            this.FinalExplodeCompleted(freezeDuration:  0.15f);
            this.itemView.Explode(point:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = 47599616});
            UnityEngine.Coroutine val_4 = Royal.Scenes.Game.Context.GameContext.ManualStartCoroutine(iEnumerator:  this.RemoveFromPrerequisitesDelayed());
        }
        private System.Collections.IEnumerator RemoveFromPrerequisitesDelayed()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new BushItemModel.<RemoveFromPrerequisitesDelayed>d__13();
        }
        public void CreateGrasses(Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint point)
        {
            var val_10 = 0;
            var val_9 = 0;
            do
            {
                var val_7 = 0;
                var val_8 = 0;
                do
            {
                Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_4 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  val_9 + point.x, y:  val_8 + point.y);
                Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_5 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.CellGridManager>(contextId:  2).Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_4.x, y = val_4.x}];
                if(val_5 != null)
            {
                    UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                this.CreateGrassForCell(cell:  val_5, startPosition:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, xIndex:  0, yIndex:  0);
                val_7 = val_7 + 1;
            }
            
                val_8 = val_8 + 1;
            }
            while(val_8 < 3);
            
                val_9 = val_9 + 1;
                val_10 = val_10 + 1;
            }
            while(val_9 <= 2);
        
        }
        private void CreateGrassForCell(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, UnityEngine.Vector3 startPosition, int xIndex, int yIndex)
        {
            if((6675.GetStaticItem(itemType:  1)) != null)
            {
                    if(val_1.layer == 2)
            {
                    return;
            }
            
            }
            
            if(cell.CanReceiveGrass() == false)
            {
                    return;
            }
            
            DG.Tweening.Sequence val_3 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.DOTween.__il2cppRuntimeField_cctor_finished.Spawn<Royal.Scenes.Game.Mechanics.Items.BushItem.View.GrassSpread.GrassSpreadAnimationView>(poolId:  57, activate:  true).Play(startPosition:  new UnityEngine.Vector3() {x = startPosition.x, y = startPosition.y, z = startPosition.z}, endPosition:  new UnityEngine.Vector3() {x = startPosition.x, y = startPosition.y, z = startPosition.z}, cellModel:  cell, seq:  val_3, xIndex:  xIndex, yIndex:  yIndex);
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenExtensions.Play<DG.Tweening.Sequence>(t:  val_3);
        }
    
    }

}
