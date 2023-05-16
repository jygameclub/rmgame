using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SoilItem
{
    public class SoilItemHelper : IGameContextUnit, IContextUnit, ILateContextUnit
    {
        // Fields
        private readonly System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.SoilItem.SoilItemModel[]> soilGroups;
        private bool[] isGroupValid;
        private Royal.Scenes.Game.Levels.Units.LevelRandomManager levelRandomManager;
        private Royal.Player.Context.Units.LevelManager levelManager;
        private Royal.Scenes.Game.Levels.Units.CellGridManager gridManager;
        private Royal.Scenes.Game.Levels.Units.GoalManager goalManager;
        
        // Properties
        public int Id { get; }
        
        // Methods
        public int get_Id()
        {
            return 30;
        }
        public void Bind()
        {
            this.levelRandomManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.LevelRandomManager>(contextId:  0);
            this.levelManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LevelManager>(id:  2);
            this.gridManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.CellGridManager>(contextId:  2);
            this.goalManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.GoalManager>(contextId:  11);
        }
        public void Clear(bool gameExit)
        {
            this.soilGroups.Clear();
        }
        public bool IsLeader(int soilGroupId, int soilId)
        {
            bool val_2 = true;
            if(val_2 <= soilGroupId)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_2 = val_2 + (soilGroupId << 3);
            return (bool)(((true + (soilGroupId) << 3) + 32 + 32 + 16) == soilId) ? 1 : 0;
        }
        public void InitSoils()
        {
            var val_12;
            var val_13;
            var val_14;
            if(this.soilGroups > 0)
            {
                    return;
            }
            
            int val_1 = this.levelManager.parser.GetSoilGroupsLength();
            if(val_1 >= 1)
            {
                    Royal.Scenes.Game.Mechanics.Items.SoilItem.SoilItemModel val_13 = 0;
                do
            {
                System.Nullable<Royal.Scenes.Game.Utils.FlatLevel.FCellGroupData> val_2 = this.levelManager.parser.GetSoilGroupData(i:  0);
                Royal.Scenes.Game.Mechanics.Items.SoilItem.SoilItemModel[] val_5 = new Royal.Scenes.Game.Mechanics.Items.SoilItem.SoilItemModel[-1634227104];
                if(val_5.Length >= 1)
            {
                    var val_12 = 0;
                do
            {
                Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_6 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  -1634227120, y:  -1634227120);
                if((this.gridManager.Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_6.x, y = val_6.x}].CurrentItem) != null)
            {
                    val_12 = null;
                val_12 = null;
                val_13 = 0;
                val_14 = 0;
            }
            else
            {
                    val_14 = 0;
                val_13 = 0;
            }
            
                val_5[val_13] = ;
                 = val_13;
                val_5[0x0] + 32 = val_12;
                val_12 = val_12 + 1;
            }
            while(val_12 < val_5.Length);
            
            }
            
                this.soilGroups.Add(item:  val_5);
                val_13 = val_13 + 1;
            }
            while(val_13 < val_1);
            
            }
            
            bool[] val_10 = new bool[0];
            this.isGroupValid = val_10;
            var val_14 = 0;
            do
            {
                if(val_14 >= (val_10.Length << ))
            {
                    return;
            }
            
                val_10[val_14] = true;
                val_14 = val_14 + 1;
            }
            while(this.isGroupValid != null);
            
            throw new NullReferenceException();
        }
        public int GetMinRemainingExplodeCount(int soilId)
        {
            var val_3;
            bool val_3 = true;
            if(val_3 <= soilId)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_3 = val_3 + (soilId << 3);
            if(((true + (soilId) << 3) + 32 + 24) >= 1)
            {
                    var val_4 = 0;
                do
            {
                var val_1 = ((true + (soilId) << 3) + 32) + 0;
                val_4 = val_4 + 1;
                val_3 = UnityEngine.Mathf.Min(a:  ((true + (soilId) << 3) + 32 + 0) + 32, b:  5);
            }
            while(val_4 < ((true + (soilId) << 3) + 32 + 24));
            
                return 5;
            }
            
            val_3 = 5;
            return 5;
        }
        public bool IsGroupValid(int groupId)
        {
            return (bool)this.isGroupValid[groupId];
        }
        public void UpdateGroupValidity(int soilGroupId)
        {
            System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.SoilItem.SoilItemModel[]> val_2;
            bool val_2 = true;
            val_2 = this.soilGroups;
            if(val_2 <= soilGroupId)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_2 = val_2 + (soilGroupId << 3);
            if(((true + (soilGroupId) << 3) + 32 + 24) < 1)
            {
                    return;
            }
            
            var val_3 = 0;
            label_9:
            var val_1 = ((true + (soilGroupId) << 3) + 32) + 0;
            val_2 = mem[((true + (soilGroupId) << 3) + 32 + 0) + 32];
            val_2 = ((true + (soilGroupId) << 3) + 32 + 0) + 32;
            if(((val_2 & 1) == 0) || (val_2 <= 0))
            {
                goto label_8;
            }
            
            val_3 = val_3 + 1;
            if(val_3 < ((true + (soilGroupId) << 3) + 32 + 24))
            {
                goto label_9;
            }
            
            return;
            label_8:
            this.isGroupValid[(long)soilGroupId] = false;
        }
        private int GetValidSoilGroupCount()
        {
            var val_2;
            if((this.isGroupValid.Length << 32) >= 1)
            {
                    var val_2 = 0;
                do
            {
                val_2 = val_2 + 1;
                val_2 = 0 + 1152921505216448112;
            }
            while(val_2 < (long)this.isGroupValid.Length);
            
                return (int)val_2;
            }
            
            val_2 = 0;
            return (int)val_2;
        }
        public System.Nullable<Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint> TryGetLastGroupsSoilCellPointWithOneLayer()
        {
            var val_4;
            System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.SoilItem.SoilItemModel[]> val_5;
            var val_6;
            bool val_5 = this.IsOnlyRemainingGoalOneSoilGroup();
            val_4 = 0;
            if(val_5 == false)
            {
                    return (System.Nullable<Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint>)val_4;
            }
            
            val_5 = this.soilGroups;
            var val_7 = 0;
            val_6 = 2147483647;
            label_15:
            if(val_7 >= val_5)
            {
                goto label_3;
            }
            
            if(this.isGroupValid[val_7] != false)
            {
                    val_5 = val_5 & 4294967295;
                if(val_7 >= val_5)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_5 = val_5 + 0;
                if((((val_1 & 4294967295) + 0) + 32 + 24) >= 1)
            {
                    var val_6 = 0;
                do
            {
                var val_2 = (((val_1 & 4294967295) + 0) + 32) + 0;
                if(((((val_1 & 4294967295) + 0) + 32 + 0) + 32 + 80) < val_6)
            {
                    Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_3 = (((val_1 & 4294967295) + 0) + 32 + 0) + 32.CurrentCell;
                val_6 = (((val_1 & 4294967295) + 0) + 32 + 0) + 32 + 80;
            }
            
                val_6 = val_6 + 1;
            }
            while(val_6 < (((val_1 & 4294967295) + 0) + 32 + 24));
            
            }
            
                val_5 = this.soilGroups;
            }
            
            val_7 = val_7 + 1;
            if(val_5 != null)
            {
                goto label_15;
            }
            
            throw new NullReferenceException();
            label_3:
            if(val_6 == 1)
            {
                    val_4 = 0;
                return (System.Nullable<Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint>)val_4;
            }
            
            val_4 = 0;
            return (System.Nullable<Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint>)val_4;
        }
        private bool IsOnlyRemainingGoalOneSoilGroup()
        {
            var val_4;
            if(this.goalManager.goals.Length >= 1)
            {
                    var val_5 = 0;
                do
            {
                if((this.goalManager.goals[0x0][0].<GoalType>k__BackingField) != 35)
            {
                    if(this.goalManager.goals[val_5].IsGoalCompleted() == false)
            {
                goto label_6;
            }
            
            }
            
                val_5 = val_5 + 1;
            }
            while(val_5 < this.goalManager.goals.Length);
            
            }
            
            var val_3 = (this.GetValidSoilGroupCount() == 1) ? 1 : 0;
            return (bool)val_4;
            label_6:
            val_4 = 0;
            return (bool)val_4;
        }
        public Royal.Scenes.Game.Mechanics.Items.Config.ItemModel FindRedirectedSoil(Royal.Scenes.Game.Mechanics.Items.SoilItem.SoilItemModel mySoil)
        {
            return this.FindLowestLayerSoilInGroup(mySoil:  mySoil);
        }
        private Royal.Scenes.Game.Mechanics.Items.Config.ItemModel FindLowestLayerSoilInGroup(Royal.Scenes.Game.Mechanics.Items.SoilItem.SoilItemModel mySoil)
        {
            var val_2;
            var val_6;
            int val_7;
            var val_8;
            var val_9;
            val_6 = mySoil;
            val_7 = mySoil.<SoilGroupId>k__BackingField;
            val_9 = null;
            val_9 = null;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_8 = 0;
            val_7 = mem[((Royal.Scenes.Game.Mechanics.Matches.Cell14.__il2cppRuntimeField_cctor_finished + (mySoil.<SoilGroupId>k__BackingField) << 3) + 32 + 0) + 32];
            val_7 = ((Royal.Scenes.Game.Mechanics.Matches.Cell14.__il2cppRuntimeField_cctor_finished + (mySoil.<SoilGroupId>k__BackingField) << 3) + 32 + 0) + 32;
            if(val_2 <= 13)
            {
                    Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_3 = val_7.CurrentCell;
            }
            
            val_8 = val_8 + 1;
            if(val_2 < 1)
            {
                    return (Royal.Scenes.Game.Mechanics.Items.Config.ItemModel)val_6;
            }
            
            Royal.Scenes.Game.Mechanics.Matches.Cell14 val_4 = this.levelRandomManager.ShuffleCells(list:  new Royal.Scenes.Game.Mechanics.Matches.Cell14());
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_5 = CurrentItem;
            val_6 = val_5;
            if(val_5 == null)
            {
                    return (Royal.Scenes.Game.Mechanics.Items.Config.ItemModel)val_6;
            }
            
            return (Royal.Scenes.Game.Mechanics.Items.Config.ItemModel)val_6;
        }
        public void DestroySoilGroup(int soilGroupId, Royal.Scenes.Game.Mechanics.Items.SoilItem.SoilItemModel firstSoil)
        {
            if(true <= soilGroupId)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            int val_6 = this.isGroupValid.Length;
            val_6 = val_6 + (soilGroupId << 3);
            this.isGroupValid[(long)soilGroupId] = false;
            sbyte[] val_1 = new sbyte[0];
            if((val_1.Length << 32) >= 1)
            {
                    var val_7 = 0;
                do
            {
                mem2[0] = 255;
                val_7 = val_7 + 1;
            }
            while(val_7 < (long)val_1.Length);
            
            }
            
            val_1[firstSoil.<IndexAmongGroup>k__BackingField] = 0;
            if(val_1.Length >= 1)
            {
                    do
            {
                this.GetSoilPath(soilGroup:  (this.isGroupValid.Length + (soilGroupId) << 3) + 32, depths:  val_1, depth:  0);
                firstSoil = 0 + 1;
            }
            while((firstSoil & 255) < val_1.Length);
            
            }
            
            UnityEngine.Coroutine val_5 = Royal.Scenes.Game.Context.GameContext.ManualStartCoroutine(iEnumerator:  this.DestroySoilsByPath(soilGroupId:  soilGroupId, depths:  val_1));
        }
        private void GetSoilPath(Royal.Scenes.Game.Mechanics.Items.SoilItem.SoilItemModel[] soilGroup, sbyte[] depths, byte depth)
        {
            int val_12 = depths.Length;
            if(val_12 < 1)
            {
                    return;
            }
            
            byte val_1 = depth + 1;
            var val_19 = 0;
            byte val_2 = depth & 255;
            val_12 = val_12 & 4294967295;
            Royal.Scenes.Game.Mechanics.Items.SoilItem.SoilItemModel[] val_13 = soilGroup[32];
            System.SByte[] val_14 = depths[32];
            label_29:
            if(null != val_2)
            {
                goto label_28;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_3 = soilGroup[0x20] + 0.CurrentCell;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_7 = X21.Get(type:  3);
            Royal.Scenes.Game.Mechanics.Items.SoilItem.SoilItemModel val_8 = val_7.GetSoilInGroup(soilGroupId:  soilGroup[0x20] + 0 + 136, cell:  X21.Get(type:  1));
            Royal.Scenes.Game.Mechanics.Items.SoilItem.SoilItemModel val_9 = val_8.GetSoilInGroup(soilGroupId:  soilGroup[0x20] + 0 + 136, cell:  X21.Get(type:  5));
            Royal.Scenes.Game.Mechanics.Items.SoilItem.SoilItemModel val_10 = val_9.GetSoilInGroup(soilGroupId:  soilGroup[0x20] + 0 + 136, cell:  X21.Get(type:  7));
            if(val_8 == null)
            {
                goto label_9;
            }
            
            sbyte val_15 = depths[val_8.<IndexAmongGroup>k__BackingField];
            if((val_15 == 1) || (val_15 >= val_2))
            {
                goto label_12;
            }
            
            label_9:
            if(val_9 != null)
            {
                goto label_13;
            }
            
            goto label_15;
            label_12:
            mem2[0] = val_1;
            if(val_9 == null)
            {
                goto label_15;
            }
            
            label_13:
            sbyte val_16 = depths[val_9.<IndexAmongGroup>k__BackingField];
            if((val_16 == 1) || (val_16 >= val_2))
            {
                goto label_18;
            }
            
            label_15:
            if(val_10 != null)
            {
                goto label_19;
            }
            
            goto label_24;
            label_18:
            mem2[0] = val_1;
            if(val_10 == null)
            {
                goto label_24;
            }
            
            label_19:
            sbyte val_17 = depths[val_10.<IndexAmongGroup>k__BackingField];
            if(val_17 != 1)
            {
                    if(val_17 < val_2)
            {
                goto label_24;
            }
            
            }
            
            mem2[0] = val_1;
            label_24:
            if((val_10.GetSoilInGroup(soilGroupId:  soilGroup[0x20] + 0 + 136, cell:  val_7)) != null)
            {
                    sbyte val_18 = depths[val_11.<IndexAmongGroup>k__BackingField];
                if(val_18 != 1)
            {
                    if(val_18 < val_2)
            {
                goto label_28;
            }
            
            }
            
                mem2[0] = val_1;
            }
            
            label_28:
            val_19 = val_19 + 1;
            if(val_19 < (depths.Length << ))
            {
                goto label_29;
            }
        
        }
        private System.Collections.IEnumerator DestroySoilsByPath(int soilGroupId, sbyte[] depths)
        {
            .<>1__state = 0;
            .depths = depths;
            .<>4__this = this;
            .soilGroupId = soilGroupId;
            return (System.Collections.IEnumerator)new SoilItemHelper.<DestroySoilsByPath>d__22();
        }
        private Royal.Scenes.Game.Mechanics.Items.SoilItem.SoilItemModel GetSoilInGroup(int soilGroupId, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            var val_4;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_4 = cell;
            if((val_4 != null) && (val_4.CurrentItem != null))
            {
                    Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_2 = val_4.CurrentItem;
                if(val_2 != null)
            {
                    val_4 = (((Royal.Scenes.Game.Mechanics.Items.Config.ItemModel.__il2cppRuntimeField_typeHierarchy + (Royal.Scenes.Game.Mechanics.Items.SoilItem.SoilItemModel.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_2) : 0;
                var val_3 = (val_4 != 1) ? (val_4) : 0;
                return (Royal.Scenes.Game.Mechanics.Items.SoilItem.SoilItemModel)val_4;
            }
            
            }
            
            val_4 = 0;
            return (Royal.Scenes.Game.Mechanics.Items.SoilItem.SoilItemModel)val_4;
        }
        public SoilItemHelper()
        {
            this.soilGroups = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.SoilItem.SoilItemModel[]>();
        }
    
    }

}
