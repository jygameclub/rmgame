using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.CupboardItem
{
    public class CupboardItemModel : MultipleCellItemModel, IItemViewDelegate
    {
        // Fields
        private bool hasDoor;
        private int doorExploderId;
        private Royal.Scenes.Game.Mechanics.Items.CupboardItem.View.CupboardItemView itemView;
        private Royal.Scenes.Game.Mechanics.Items.CupboardItem.CupboardItemRegistry itemRegistry;
        
        // Properties
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType ItemType { get; }
        
        // Methods
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType get_ItemType()
        {
            return 8;
        }
        public CupboardItemModel(int layer)
        {
            this.hasDoor = true;
            val_1 = new Royal.Scenes.Game.Mechanics.Items.Config.ItemModel(layer:  layer);
        }
        public override void CreateView(UnityEngine.Vector3 position)
        {
            Royal.Scenes.Game.Mechanics.Items.CupboardItem.View.CupboardItemView val_1 = 9905.Spawn<Royal.Scenes.Game.Mechanics.Items.CupboardItem.View.CupboardItemView>(poolId:  40, activate:  true);
            this.itemView = val_1;
            val_1.Init(viewDelegate:  this, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
            Royal.Scenes.Game.Mechanics.Items.CupboardItem.CupboardItemRegistry val_2 = Royal.Scenes.Game.Levels.LevelContext.GetLate<Royal.Scenes.Game.Mechanics.Items.CupboardItem.CupboardItemRegistry>(contextId:  20);
            this.itemRegistry = val_2;
            val_2.Add(cupboardItem:  this);
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
        public override int GetExtraExplodeCount()
        {
            var val_68;
            int val_69;
            var val_70;
            var val_71;
            var val_72;
            var val_73;
            var val_74;
            var val_75;
            var val_76;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_1 = 9906.CurrentCell;
            if(val_1 == null)
            {
                    return 0;
            }
            
            if((val_1.HasOperation(animationId:  9)) == false)
            {
                    return 0;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_3 = this.GetLeftBottom();
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_4 = this.GetRightTop();
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_6 = true.CurrentCell.CurrentCell;
            val_68 = 0;
            var val_70 = -1;
            var val_7 = W9 + 2;
            if(val_70 <= val_7)
            {
                    var val_8 = W11 + 4;
                val_8 = val_8 - W10;
                var val_9 = W10 - 2;
                var val_10 = W11 + 2;
                do
            {
                if(val_9 <= val_10)
            {
                    var val_69 = 0;
                do
            {
                int val_12 = val_9 + val_69;
                if((((val_70 <= (???)) && (val_12 <= (???))) && (val_70 >= true)) && (val_12 >= (???)))
            {
                    Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_13 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  val_12, y:  -1);
                Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_15 = X26.Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_13.x, y = val_13.x}].CurrentItem;
                int val_68 = val_15.extraIncomingContainer.tntPropellerCount;
                val_68 = val_68 + (val_68 << 1);
                val_68 = val_68 + val_68;
                val_68 = val_68 + val_15.extraIncomingContainer.verticalRocketPropeller;
                val_68 = val_68 + val_15.extraIncomingContainer.horizontalRocketPropeller;
            }
            else
            {
                    Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_16 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  val_12, y:  -1);
                Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_17 = X26.Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_16.x, y = val_16.x}];
                if(val_17 != null)
            {
                    Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_19 = (val_17 == 0) ? 0 : (val_17).CurrentItem;
                var val_20 = (val_19 == 0) ? 0 : (val_19);
                if(val_19 != null)
            {
                    var val_21 = ((val_19 == null ? 0 : val_19 + 104) == 0) ? 0 : (val_19 == null ? 0 : val_19 + 104);
                if((val_19 == null ? 0 : val_19 + 104) != 0)
            {
                    if(((0 & 0) == 0) && (0 >= 1))
            {
                    var val_22 = (val_8 != val_69) ? (1 + 1) : 1;
                val_22 = val_22 * ((val_70 != val_7) ? (1 + 1) : 1);
                val_68 = val_68 + (val_22 * 0);
            }
            
            }
            
            }
            
            }
            
            }
            
                val_69 = val_69 + 1;
            }
            while((val_9 + val_69) <= val_10);
            
            }
            
                val_70 = val_70 + 1;
            }
            while(val_70 <= val_7);
            
            }
            
            bool val_71 = true;
            if(val_71 <= (???))
            {
                goto label_33;
            }
            
            val_69 = ???;
            goto label_34;
            label_33:
            val_69 = ???;
            val_70 = 0;
            label_66:
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_24 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  val_69, y:  1);
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_25 = val_17.Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_24.x, y = val_24.x}];
            var val_26 = (val_25 == 0) ? 0 : (val_25);
            if(val_25 == null)
            {
                goto label_49;
            }
            
            val_70 = mem[val_25 == null ? 0 : val_25 + 40];
            val_70 = val_25 == null ? 0 : val_25 + 40;
            if(val_70 == 0)
            {
                goto label_38;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_28 = (val_70 == 0) ? (val_70) : (val_70).Get(type:  7);
            if(val_28 == null)
            {
                goto label_46;
            }
            
            label_48:
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_29 = val_28.CurrentItem;
            var val_30 = (val_29 == 0) ? 0 : (val_29);
            if(val_29 == null)
            {
                goto label_43;
            }
            
            var val_31 = ((val_29 == null ? 0 : val_29 + 104) == 0) ? 0 : (val_29 == null ? 0 : val_29 + 104);
            if((val_29 == null ? 0 : val_29 + 104) == 0)
            {
                goto label_43;
            }
            
            val_71 = 0;
            goto label_45;
            label_43:
            val_71 = 0;
            label_45:
            val_68 = (((val_71 & 0) != 0) ? 0 : 0) + val_68;
            if(val_69 != 0)
            {
                    if(((val_69 == 0) ? 0 : (val_69).Get(type:  7)) != null)
            {
                goto label_48;
            }
            
            }
            
            label_46:
            val_69 = ???;
            goto label_49;
            label_38:
            val_70 = val_70;
            label_49:
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_35 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  ???, y:  1);
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_36 = val_17.Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_35.x, y = val_35.x}];
            var val_37 = (val_36 == 0) ? 0 : (val_36);
            if(val_36 == null)
            {
                goto label_65;
            }
            
            if((val_36 == null ? 0 : val_36 + 40) == 0)
            {
                goto label_53;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_39 = ((val_36 == null ? 0 : val_36 + 40) == 0) ? 0 : (val_36 == null ? 0 : val_36 + 40).Get(type:  3);
            if(val_39 == null)
            {
                goto label_61;
            }
            
            label_63:
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_40 = val_39.CurrentItem;
            var val_41 = (val_40 == 0) ? 0 : (val_40);
            if(val_40 == null)
            {
                goto label_58;
            }
            
            var val_42 = ((val_40 == null ? 0 : val_40 + 104) == 0) ? 0 : (val_40 == null ? 0 : val_40 + 104);
            if((val_40 == null ? 0 : val_40 + 104) == 0)
            {
                goto label_58;
            }
            
            val_72 = 0;
            goto label_60;
            label_58:
            val_72 = 0;
            label_60:
            val_68 = (((val_72 & 0) != 0) ? 0 : 0) + val_68;
            if(val_69 == 0)
            {
                goto label_61;
            }
            
            if(((val_69 == 0) ? 0 : (val_69).Get(type:  3)) != null)
            {
                goto label_63;
            }
            
            goto label_64;
            label_61:
            label_64:
            val_69 = ???;
            label_53:
            label_65:
            val_71 = val_71 + 1;
            if(val_71 <= (???))
            {
                goto label_66;
            }
            
            label_34:
            val_73 = ???;
            if(val_69 > val_73)
            {
                    return 0;
            }
            
            val_74 = 0;
            label_98:
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_46 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  val_69, y:  1);
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_47 = mem[1152921520371446680].Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_46.x, y = val_46.x}];
            var val_48 = (val_47 == 0) ? 0 : (val_47);
            if(val_47 == null)
            {
                goto label_69;
            }
            
            if((val_47 == null ? 0 : val_47 + 40) == 0)
            {
                goto label_71;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_50 = ((val_47 == null ? 0 : val_47 + 40) == 0) ? 0 : (val_47 == null ? 0 : val_47 + 40).Get(type:  1);
            if(val_50 == null)
            {
                goto label_79;
            }
            
            label_81:
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_51 = val_50.CurrentItem;
            var val_52 = (val_51 == 0) ? 0 : (val_51);
            if(val_51 == null)
            {
                goto label_76;
            }
            
            var val_53 = ((val_51 == null ? 0 : val_51 + 104) == 0) ? 0 : (val_51 == null ? 0 : val_51 + 104);
            if((val_51 == null ? 0 : val_51 + 104) == 0)
            {
                goto label_76;
            }
            
            val_75 = 0;
            goto label_78;
            label_76:
            val_75 = 0;
            label_78:
            val_68 = (((val_75 & 0) != 0) ? 0 : 0) + val_68;
            if(val_69 != 0)
            {
                    if(((val_69 == 0) ? 0 : (val_69).Get(type:  1)) != null)
            {
                goto label_81;
            }
            
            }
            
            label_79:
            val_73 = ???;
            val_69 = val_69;
            label_71:
            val_74 = val_74;
            label_69:
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_57 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  val_69, y:  ???);
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_58 = mem[1152921520371446680].Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_57.x, y = val_57.x}];
            var val_59 = (val_58 == 0) ? (val_74) : (val_58);
            if(val_58 == null)
            {
                goto label_97;
            }
            
            if((val_58 == null ? val_74 : val_58 + 40) == 0)
            {
                goto label_85;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_61 = ((val_58 == null ? val_74 : val_58 + 40) == 0) ? 0 : (val_58 == null ? val_74 : val_58 + 40).Get(type:  5);
            if(val_61 == null)
            {
                goto label_93;
            }
            
            label_95:
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_62 = val_61.CurrentItem;
            var val_63 = (val_62 == 0) ? 0 : (val_62);
            if(val_62 == null)
            {
                goto label_90;
            }
            
            var val_64 = ((val_62 == null ? 0 : val_62 + 104) == 0) ? 0 : (val_62 == null ? 0 : val_62 + 104);
            if((val_62 == null ? 0 : val_62 + 104) == 0)
            {
                goto label_90;
            }
            
            val_76 = 0;
            goto label_92;
            label_90:
            val_76 = 0;
            label_92:
            val_68 = (((val_76 & 0) != 0) ? 0 : 0) + val_68;
            if(val_69 == 0)
            {
                goto label_93;
            }
            
            if(((val_69 == 0) ? 0 : (val_69).Get(type:  5)) != null)
            {
                goto label_95;
            }
            
            goto label_96;
            label_93:
            label_96:
            val_69 = val_69;
            val_73 = ???;
            label_85:
            label_97:
            val_69 = val_69 + 1;
            if(val_69 <= val_73)
            {
                goto label_98;
            }
            
            return 0;
        }
        protected override void TryExplode(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            int val_1 = W8 - 1;
            mem[1152921520371689728] = val_1;
            Royal.Scenes.Game.Mechanics.Items.CupboardItem.View.Animation.CupboardItemShakeAnimationData val_2 = this.NearestCupboardItemShakeAnimationData();
            this.itemView.Damage(index:  val_1, nearestShakeAnimationData:  new Royal.Scenes.Game.Mechanics.Items.CupboardItem.View.Animation.CupboardItemShakeAnimationData() {startedFrame = val_2.startedFrame, selectedAnimation = val_2.selectedAnimation}, trigger:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id});
            if(data.id != 0)
            {
                    return;
            }
            
            this.itemRegistry.Remove(cupboardItem:  this);
            this.itemView.Explode();
        }
        public void FakeExplode(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            if((this.TryExplodingDoor(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id})) == true)
            {
                    return;
            }
        
        }
        public override void Explode(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            if((this.TryExplodingDoor(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id})) == true)
            {
                    return;
            }
            
            if((-1414705216) == 5)
            {
                    return;
            }
            
            this.Explode(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id});
        }
        public override void ExplodeAll(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            bool val_1 = this.ContainsExploder(id:  268435459);
            if(val_1 == true)
            {
                    return;
            }
            
            val_1.AddToExploders(id:  268435459);
            if(W8 == 1)
            {
                    return;
            }
            
            if(this.hasDoor != false)
            {
                    bool val_2 = this.TryExplodingDoor(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id});
            }
            
            mem[1152921520372111456] = 1;
            Royal.Scenes.Game.Mechanics.Items.CupboardItem.CupboardItemModel val_3 = 1152921505103810559;
            if(val_3 < 1)
            {
                    return;
            }
            
            do
            {
                val_3 = val_3 - 1;
            }
            while(val_3 != 1);
        
        }
        private bool TryExplodingDoor(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            var val_3;
            bool val_3 = this.hasDoor;
            if(val_3 == false)
            {
                    return (bool)(this.doorExploderId == 268435459) ? 1 : 0;
            }
            
            this.hasDoor = false;
            val_3 = val_3 - 1;
            mem[1152921520372252032] = val_3;
            this.doorExploderId = 268435459;
            Royal.Scenes.Game.Mechanics.Items.CupboardItem.View.Animation.CupboardItemShakeAnimationData val_1 = this.NearestCupboardItemShakeAnimationData();
            this.itemView.RemoveDoor(nearestShakeAnimationData:  new Royal.Scenes.Game.Mechanics.Items.CupboardItem.View.Animation.CupboardItemShakeAnimationData() {startedFrame = val_1.startedFrame, selectedAnimation = val_1.selectedAnimation});
            val_3 = 1;
            return (bool)(this.doorExploderId == 268435459) ? 1 : 0;
        }
        public Royal.Scenes.Game.Mechanics.Items.CupboardItem.View.Animation.CupboardItemShakeAnimationData CupboardItemShakeAnimationData()
        {
            if(this.itemView != null)
            {
                    return new Royal.Scenes.Game.Mechanics.Items.CupboardItem.View.Animation.CupboardItemShakeAnimationData() {startedFrame = this.itemView.shakeAnimationData, selectedAnimation = this.itemView.shakeAnimationData};
            }
            
            throw new NullReferenceException();
        }
        private Royal.Scenes.Game.Mechanics.Items.CupboardItem.View.Animation.CupboardItemShakeAnimationData NearestCupboardItemShakeAnimationData()
        {
            Royal.Scenes.Game.Mechanics.Items.CupboardItem.View.Animation.CupboardItemShakeAnimationData val_2;
            if((this.itemRegistry.GetNearestAnimatedCupboardItem(cupboardItem:  this)) == null)
            {
                    return new Royal.Scenes.Game.Mechanics.Items.CupboardItem.View.Animation.CupboardItemShakeAnimationData() {startedFrame = val_2, selectedAnimation = val_2};
            }
            
            val_2 = val_1.itemView.shakeAnimationData;
            return new Royal.Scenes.Game.Mechanics.Items.CupboardItem.View.Animation.CupboardItemShakeAnimationData() {startedFrame = val_2, selectedAnimation = val_2};
        }
    
    }

}
