using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.FlowerPotItem
{
    public class FlowerPotItemModel : ItemModel, IItemViewDelegate
    {
        // Fields
        public const int ExpandRadius = 1;
        private Royal.Scenes.Game.Mechanics.Items.FlowerPotItem.View.FlowerPotItemView itemView;
        
        // Properties
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType ItemType { get; }
        
        // Methods
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType get_ItemType()
        {
            return 23;
        }
        public FlowerPotItemModel()
        {
        
        }
        public override void CreateView(UnityEngine.Vector3 position)
        {
            Royal.Scenes.Game.Mechanics.Items.FlowerPotItem.View.FlowerPotItemView val_1 = 16693.Spawn<Royal.Scenes.Game.Mechanics.Items.FlowerPotItem.View.FlowerPotItemView>(poolId:  85, activate:  true);
            this.itemView = val_1;
            val_1.Init(flowerPotItemModel:  this, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
            this.AddToPrerequisite(goalType:  30);
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
            return true;
        }
        public override bool IsSwappable()
        {
            return true;
        }
        protected override void TryExplode(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            int val_1 = true - 1;
            mem[1152921520321585696] = val_1;
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
            UnityEngine.Coroutine val_5 = Royal.Scenes.Game.Context.GameContext.ManualStartCoroutine(iEnumerator:  this.RemoveFromPrerequisitesDelayed(createdGrassCount:  this.CreateGrasses(point:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint())));
        }
        private System.Collections.IEnumerator RemoveFromPrerequisitesDelayed(int createdGrassCount)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .createdGrassCount = createdGrassCount;
            return (System.Collections.IEnumerator)new FlowerPotItemModel.<RemoveFromPrerequisitesDelayed>d__11();
        }
        public int CreateGrasses(Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint point)
        {
            var val_8;
            var val_9;
            var val_10 = 0;
            val_8 = 0;
            var val_9 = 0;
            do
            {
                val_9 = 0;
                var val_8 = 0;
                do
            {
                Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_4 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  val_9 + point.x, y:  val_8 + point.y);
                Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_5 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.CellGridManager>(contextId:  2).Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_4.x, y = val_4.x}];
                if(val_5 != null)
            {
                    val_8 = val_8 + (this.CreateGrassForCell(cell:  val_5, startPosition:  new UnityEngine.Vector3(), xIndex:  0, yIndex:  0));
                val_9 = val_9 + 1;
            }
            
                val_8 = val_8 + 1;
            }
            while(val_8 < 2);
            
                val_9 = val_9 + 1;
                val_10 = val_10 + 1;
            }
            while(val_9 <= 1);
            
            return (int)val_8;
        }
        private bool CreateGrassForCell(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, UnityEngine.Vector3 startPosition, int xIndex, int yIndex)
        {
            var val_5;
            if(cell.CanReceiveGrass() != false)
            {
                    DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
                DG.Tweening.DOTween.__il2cppRuntimeField_cctor_finished.Spawn<Royal.Scenes.Game.Mechanics.Items.FlowerPotItem.PurpleGrassSpread.PurpleGrassSpreadAnimationView>(poolId:  89, activate:  true).Play(startPosition:  new UnityEngine.Vector3() {x = startPosition.x, y = startPosition.y, z = startPosition.z}, endPosition:  new UnityEngine.Vector3() {x = startPosition.x, y = startPosition.y, z = startPosition.z}, cellModel:  cell, seq:  val_2, xIndex:  xIndex, yIndex:  yIndex);
                DG.Tweening.Sequence val_4 = DG.Tweening.TweenExtensions.Play<DG.Tweening.Sequence>(t:  val_2);
                val_5 = 1;
                return (bool)val_5;
            }
            
            val_5 = 0;
            return (bool)val_5;
        }
    
    }

}
