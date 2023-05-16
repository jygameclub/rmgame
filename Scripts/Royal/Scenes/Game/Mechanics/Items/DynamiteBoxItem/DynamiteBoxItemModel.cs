using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem
{
    public class DynamiteBoxItemModel : MultipleCellItemModel, IDynamiteBoxItemDelegate, IItemViewDelegate
    {
        // Fields
        private Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.View.DynamiteBoxItemView itemView;
        private readonly System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Matches.MatchType> matchList;
        private readonly Royal.Scenes.Game.Levels.Units.LevelRandomManager levelRandomManager;
        private readonly Royal.Scenes.Game.Levels.Units.State.GameStateManager stateManger;
        private readonly Royal.Scenes.Game.Levels.Units.MoveManager moveManager;
        private static bool <IsRunning>k__BackingField;
        private static Royal.Scenes.Game.Mechanics.Explode.ExplodeData <ExplodeData>k__BackingField;
        
        // Properties
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType ItemType { get; }
        public override bool IsValidTarget { get; }
        public static bool IsRunning { get; set; }
        public static Royal.Scenes.Game.Mechanics.Explode.ExplodeData ExplodeData { get; set; }
        
        // Methods
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType get_ItemType()
        {
            return 24;
        }
        public override bool get_IsValidTarget()
        {
            var val_2;
            if((this & 1) != 0)
            {
                    var val_1 = (null > 0) ? 1 : 0;
                return (bool)val_2;
            }
            
            val_2 = 0;
            return (bool)val_2;
        }
        public static bool get_IsRunning()
        {
            return (bool)Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.DynamiteBoxItemModel.<IsRunning>k__BackingField;
        }
        private static void set_IsRunning(bool value)
        {
            Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.DynamiteBoxItemModel.<IsRunning>k__BackingField = value;
        }
        public static Royal.Scenes.Game.Mechanics.Explode.ExplodeData get_ExplodeData()
        {
            Royal.Scenes.Game.Mechanics.Explode.ExplodeData val_0;
            val_0.id = Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.DynamiteBoxItemModel.<IsRunning>k__BackingField.__il2cppRuntimeField_14;
            val_0.point.x = Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.DynamiteBoxItemModel.<ExplodeData>k__BackingField;
            return val_0;
        }
        private static void set_ExplodeData(Royal.Scenes.Game.Mechanics.Explode.ExplodeData value)
        {
            Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.DynamiteBoxItemModel.<IsRunning>k__BackingField.__il2cppRuntimeField_14 = value.id;
            Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.DynamiteBoxItemModel.<ExplodeData>k__BackingField = value.point.x;
        }
        public DynamiteBoxItemModel()
        {
            this.levelRandomManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.LevelRandomManager>(contextId:  0);
            this.stateManger = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14);
            this.moveManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.MoveManager>(contextId:  10);
            System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Matches.MatchType> val_4 = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Matches.MatchType>();
            val_4.Add(item:  1);
            val_4.Add(item:  1);
            val_4.Add(item:  2);
            val_4.Add(item:  2);
            val_4.Add(item:  3);
            val_4.Add(item:  3);
            val_4.Add(item:  4);
            val_4.Add(item:  4);
            this.matchList = val_4;
        }
        public override void CreateView(UnityEngine.Vector3 position)
        {
            Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.View.DynamiteBoxItemView val_1 = 13200.Spawn<Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.View.DynamiteBoxItemView>(poolId:  90, activate:  true);
            this.itemView = val_1;
            val_1.Init(viewDelegate:  this, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, items:  this.matchList);
            goto typeof(Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.DynamiteBoxItemModel).__il2cppRuntimeField_1E0;
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
        protected override void TryExplode(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            int val_11;
            var val_12;
            System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Matches.MatchType> val_13;
            val_12 = this;
            if(true == 0)
            {
                    return;
            }
            
            val_11 = data.id;
            if(val_11 != 0)
            {
                    val_13 = this.matchList;
            }
            else
            {
                    val_13 = this.matchList;
                val_11 = this.levelRandomManager.GetRandomItemFromList<Royal.Scenes.Game.Mechanics.Matches.MatchType>(list:  this.matchList);
            }
            
            if((this.matchList.SyncRoot.Remove(item:  val_11)) == false)
            {
                    return;
            }
            
            mem[1152921520334220240] = mem[this.matchList.SyncRoot + 24];
            this.itemView.Damage(matchType:  val_11, layer:  mem[this.matchList.SyncRoot + 24], isNearMatch:  ((-1452459952) == 5) ? 1 : 0);
            if((-1452459952) != 0)
            {
                    val_12 = ???;
                val_11 = ???;
            }
            else
            {
                    Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14).StartSpecialOperation();
                this.stateManger.OperationStart(animationId:  11);
            }
        
        }
        public void Explode()
        {
            this.stateManger.OperationFinish(animationId:  11);
            this.itemView.Explode();
            UnityEngine.Coroutine val_3 = Royal.Scenes.Game.Context.GameContext.ManualStartCoroutine(iEnumerator:  this.ExplodeCells(centerCell:  this.itemView.CurrentCell));
        }
        public override void ExplodeAll(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            var val_2 = 1152921520334574368;
            var val_1 = 0;
            do
            {
                val_1 = val_1 + 1;
                if(val_1 >= this.matchList)
            {
                    return;
            }
            
            }
            while(this.matchList != null);
            
            throw new NullReferenceException();
        }
        private System.Collections.IEnumerator ExplodeCells(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel centerCell)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .centerCell = centerCell;
            return (System.Collections.IEnumerator)new DynamiteBoxItemModel.<ExplodeCells>d__26();
        }
    
    }

}
