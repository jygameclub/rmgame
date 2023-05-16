using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.Pool
{
    public class LevelGameObjectPool
    {
        // Fields
        private readonly Royal.Scenes.Game.Levels.Units.ItemAssetsLibrary assetsLibrary;
        private readonly Royal.Infrastructure.Utils.Pooling.GameObjectPool objectPool;
        private readonly System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.Config.ItemAssets> pooledLevelSpecificItemAssets;
        
        // Methods
        public LevelGameObjectPool(Royal.Scenes.Game.Levels.Units.ItemAssetsLibrary assetsLibrary)
        {
            this.assetsLibrary = assetsLibrary;
            this.objectPool = new Royal.Infrastructure.Utils.Pooling.GameObjectPool(poolIdType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            this.pooledLevelSpecificItemAssets = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.Config.ItemAssets>(capacity:  10);
        }
        public void InitializePermanentPoolsFirstPart()
        {
            this.CreatePoolsForItemAssets(itemAssets:  this.assetsLibrary.Load<Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemAssets>(), count:  110, levelSpecific:  false);
            this.CreatePoolsForItemAssets(itemAssets:  this.assetsLibrary.Load<Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntItemAssets>(), count:  20, levelSpecific:  false);
            this.InitializeItemSpecificPool<Royal.Scenes.Game.Mechanics.Items.CoinItem.View.CoinItemAssets>(amount:  10);
        }
        public void InitializePermanentPoolsSecondPart()
        {
            this.CreatePoolsForItemAssets(itemAssets:  this.assetsLibrary.Load<Royal.Scenes.Game.Mechanics.Board.Cell.View.CellAssets>(), count:  100, levelSpecific:  false);
            this.CreatePoolsForItemAssets(itemAssets:  this.assetsLibrary.Load<Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerItemAssets>(), count:  20, levelSpecific:  false);
            this.CreatePoolsForItemAssets(itemAssets:  this.assetsLibrary.Load<Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.View.RocketItemAssets>(), count:  20, levelSpecific:  false);
            this.CreatePoolsForItemAssets(itemAssets:  this.assetsLibrary.Load<Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballItemAssets>(), count:  5, levelSpecific:  false);
            UnityEngine.Resources.Load<Royal.Scenes.Game.Levels.Units.RemainingMoves.RemainingMovesAssets>(path:  "RemainingMovesAssets").CreatePools(pool:  this, amount:  10);
        }
        public void InitializeItemSpecificPool<T>(int amount)
        {
            this.CreatePoolsForItemAssets(itemAssets:  this.assetsLibrary, count:  amount, levelSpecific:  false);
        }
        public void InitializeMadnessPool(Royal.Scenes.Game.Mechanics.Items.Config.ItemType itemType)
        {
            var val_4;
            if(itemType == 0)
            {
                    return;
            }
            
            if(itemType == 1)
            {
                    Royal.Scenes.Game.Ui.Madness.MadnessMatchItemAnimationView val_1 = UnityEngine.Resources.Load<Royal.Scenes.Game.Ui.Madness.MadnessMatchItemAnimationView>(path:  "MadnessMatchItemAnimationView");
                val_4 = 1152921524011330368;
            }
            else
            {
                    val_4 = 1152921524011336624;
            }
            
            this.CreatePool<Royal.Scenes.Game.Ui.Madness.MadnessAnimationView>(go:  UnityEngine.Resources.Load<Royal.Scenes.Game.Ui.Madness.MadnessAnimationView>(path:  "MadnessAnimationView"), amount:  10);
        }
        public void ClearAllPools()
        {
            this.assetsLibrary.ClearAll();
            this.objectPool.ClearAllPools();
            this.pooledLevelSpecificItemAssets.Clear();
        }
        public void InitializeLevelSpecificPools(System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Goal.GoalType, Royal.Scenes.Game.Mechanics.Goal.GoalTuple> goals, System.Collections.Generic.Dictionary<int, int> countsOnBoard, int curtainCellCount, int drillCount, int chainCount)
        {
            var val_14;
            Royal.Scenes.Game.Mechanics.Items.Config.ItemType val_15;
            int val_22;
            System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.Config.ItemAssets> val_23;
            var val_24;
            var val_26;
            var val_27;
            var val_32;
            var val_33;
            int val_34;
            var val_35;
            val_23 = this.pooledLevelSpecificItemAssets;
            if(this.pooledLevelSpecificItemAssets == null)
            {
                    throw new NullReferenceException();
            }
            
            this.pooledLevelSpecificItemAssets.Clear();
            val_24 = null;
            val_24 = null;
            val_23 = LevelGameObjectPool.<>c.<>9__9_0;
            if(val_23 == null)
            {
                    System.Func<System.Collections.Generic.KeyValuePair<Royal.Scenes.Game.Mechanics.Goal.GoalType, Royal.Scenes.Game.Mechanics.Goal.GoalTuple>, Royal.Scenes.Game.Mechanics.Goal.GoalTuple> val_2 = null;
                val_23 = val_2;
                val_2 = new System.Func<System.Collections.Generic.KeyValuePair<Royal.Scenes.Game.Mechanics.Goal.GoalType, Royal.Scenes.Game.Mechanics.Goal.GoalTuple>, Royal.Scenes.Game.Mechanics.Goal.GoalTuple>(object:  LevelGameObjectPool.<>c.__il2cppRuntimeField_static_fields, method:  Royal.Scenes.Game.Mechanics.Goal.GoalTuple LevelGameObjectPool.<>c::<InitializeLevelSpecificPools>b__9_0(System.Collections.Generic.KeyValuePair<Royal.Scenes.Game.Mechanics.Goal.GoalType, Royal.Scenes.Game.Mechanics.Goal.GoalTuple> kvp));
                LevelGameObjectPool.<>c.<>9__9_0 = val_23;
            }
            
            val_27 = public static System.Collections.Generic.IEnumerable<TResult> System.Linq.Enumerable::Select<System.Collections.Generic.KeyValuePair<Royal.Scenes.Game.Mechanics.Goal.GoalType, Royal.Scenes.Game.Mechanics.Goal.GoalTuple>, Royal.Scenes.Game.Mechanics.Goal.GoalTuple>(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, TResult> selector);
            System.Collections.Generic.IEnumerable<TResult> val_3 = System.Linq.Enumerable.Select<System.Collections.Generic.KeyValuePair<Royal.Scenes.Game.Mechanics.Goal.GoalType, Royal.Scenes.Game.Mechanics.Goal.GoalTuple>, Royal.Scenes.Game.Mechanics.Goal.GoalTuple>(source:  goals, selector:  val_2);
            if(val_3 == null)
            {
                    throw new NullReferenceException();
            }
            
            var val_25 = 0;
            if(mem[1152921504684679168] != null)
            {
                    val_25 = val_25 + 1;
                val_27 = 0;
            }
            else
            {
                    System.Collections.Generic.IEnumerable<TResult> val_4 = 1152921504684642304 + ((mem[1152921504684679176]) << 4);
            }
            
            System.Collections.Generic.IEnumerator<T> val_5 = val_3.GetEnumerator();
            val_23 = val_5;
            if(val_5 == null)
            {
                goto label_12;
            }
            
            val_26 = 1152921504680542208;
            label_23:
            var val_26 = 0;
            if(mem[1152921504684732416] != null)
            {
                    val_26 = val_26 + 1;
                val_27 = 0;
            }
            else
            {
                    System.Collections.Generic.IEnumerator<T> val_6 = 1152921504684695552 + ((mem[1152921504684732424]) << 4);
            }
            
            if(val_23.MoveNext() == false)
            {
                goto label_17;
            }
            
            var val_27 = 0;
            if(mem[1152921504684732416] != null)
            {
                    val_27 = val_27 + 1;
                val_27 = 0;
            }
            else
            {
                    System.Collections.Generic.IEnumerator<T> val_8 = 1152921504684695552 + ((mem[1152921504684732424]) << 4);
            }
            
            if(val_23.Current == 0)
            {
                goto label_22;
            }
            
            this.CreatePool(goal:  val_9 + 16, goalCount:  val_9 + 16 + 4, countsOnBoard:  countsOnBoard);
            goto label_23;
            label_17:
            val_26 = 0;
            if(val_23 != null)
            {
                    var val_28 = 0;
                if(mem[1152921504684732416] != null)
            {
                    val_28 = val_28 + 1;
            }
            else
            {
                    System.Collections.Generic.IEnumerator<T> val_10 = 1152921504684695552 + ((mem[1152921504684732424]) << 4);
            }
            
                val_23.Dispose();
            }
            
            if(val_26 != 0)
            {
                goto label_29;
            }
            
            if(0 != 1)
            {
                    val_32;
                var val_11 = (114 == 114) ? 1 : 0;
                val_11 = ((0 >= 0) ? 1 : 0) & val_11;
                val_11 = 0 - val_11;
                val_11 = val_11 + 1;
                val_33 = (long)val_11;
            }
            else
            {
                    val_32;
                val_33 = 0;
            }
            
            if(countsOnBoard == null)
            {
                    throw new NullReferenceException();
            }
            
            Dictionary.Enumerator<TKey, TValue> val_13 = countsOnBoard.GetEnumerator();
            val_22 = 1152921524011633392;
            label_36:
            if(((-2069983920) & 1) == 0)
            {
                goto label_33;
            }
            
            val_23 = val_15;
            Royal.Scenes.Game.Mechanics.Goal.GoalType val_16 = Royal.Scenes.Game.Mechanics.Items.Config.ItemExtensions.ToGoalType(itemType:  val_15);
            if(goals == null)
            {
                    throw new NullReferenceException();
            }
            
            if((goals.ContainsKey(key:  val_16)) == true)
            {
                goto label_36;
            }
            
            this.CreatePool(goal:  val_16, goalCount:  val_23, countsOnBoard:  countsOnBoard);
            goto label_36;
            label_33:
            val_14.Dispose();
            val_34 = curtainCellCount;
            val_22 = drillCount;
            if(val_34 >= 1)
            {
                    if(this.assetsLibrary == null)
            {
                    throw new NullReferenceException();
            }
            
                this.CreatePoolsForItemAssets(itemAssets:  this.assetsLibrary.Load<Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View.CurtainItemAssets>(), count:  val_34, levelSpecific:  true);
            }
            
            if(val_22 >= 1)
            {
                    if(this.assetsLibrary == null)
            {
                    throw new NullReferenceException();
            }
            
                this.CreatePoolsForItemAssets(itemAssets:  this.assetsLibrary.Load<Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillItemAssets>(), count:  val_22, levelSpecific:  true);
            }
            
            if(chainCount >= 1)
            {
                    if(this.assetsLibrary == null)
            {
                    throw new NullReferenceException();
            }
            
                this.CreatePoolsForItemAssets(itemAssets:  this.assetsLibrary.Load<Royal.Scenes.Game.Mechanics.Items.StaticItems.ChainItem.View.ChainItemAssets>(), count:  chainCount, levelSpecific:  true);
            }
            
            if((System.Linq.Enumerable.ToList<Royal.Scenes.Game.Mechanics.Items.Config.ItemAssets>(source:  System.Linq.Enumerable.Except<Royal.Scenes.Game.Mechanics.Items.Config.ItemAssets>(first:  new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.Config.ItemAssets>(collection:  val_23), second:  this.pooledLevelSpecificItemAssets))) == null)
            {
                    throw new NullReferenceException();
            }
            
            if(1152921524011674352 < 1)
            {
                    return;
            }
            
            do
            {
                if(1152921524011674352 <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_22 = null;
                if(null == 0)
            {
                    throw new NullReferenceException();
            }
            
                ClearPools(pool:  this);
                if(this.assetsLibrary == null)
            {
                    throw new NullReferenceException();
            }
            
                bool val_24 = this.assetsLibrary.Clear(type:  GetType());
                val_34 = 0 + 1;
            }
            while(val_34 < 47797544);
            
            return;
            label_22:
            throw new NullReferenceException();
            label_12:
            throw new NullReferenceException();
            label_29:
            val_35 = X27;
            throw val_35;
        }
        private void CreatePool(Royal.Scenes.Game.Mechanics.Goal.GoalType goal, int goalCount, System.Collections.Generic.Dictionary<int, int> countsOnBoard)
        {
            int val_3 = 0;
            int val_5 = 0;
            int val_1 = System.Math.Min(val1:  goalCount, val2:  75);
            if((goal - 11) <= 30)
            {
                    var val_29 = 36588448 + ((goal - 11)) << 2;
                val_29 = val_29 + 36588448;
            }
            else
            {
                    if((countsOnBoard.TryGetValue(key:  22, value: out  null)) != false)
            {
                    this.CreatePoolsForItemAssets(itemAssets:  this.assetsLibrary.Load<Royal.Scenes.Game.Mechanics.Items.HatItem.View.HatItemAssets>(), count:  null, levelSpecific:  true);
            }
            
                if((countsOnBoard.TryGetValue(key:  35, value: out  null)) == false)
            {
                    return;
            }
            
                this.CreatePoolsForItemAssets(itemAssets:  this.assetsLibrary.Load<Royal.Scenes.Game.Mechanics.Items.CaldronItem.View.CaldronItemAssets>(), count:  null, levelSpecific:  true);
            }
        
        }
        private void CreateGrassAndBushPool(int grassCount, int bushCount)
        {
            int val_4 = bushCount;
            if(val_4 >= 1)
            {
                    this.CreatePoolsForItemAssets(itemAssets:  this.assetsLibrary.Load<Royal.Scenes.Game.Mechanics.Items.BushItem.View.BushItemAssets>(), count:  val_4, levelSpecific:  true);
            }
            
            val_4 = grassCount + (val_4 << 2);
            this.CreatePoolsForItemAssets(itemAssets:  this.assetsLibrary.Load<Royal.Scenes.Game.Mechanics.Items.StaticItems.GrassItem.View.GrassItemAssets>(), count:  System.Math.Min(val1:  val_4, val2:  100), levelSpecific:  true);
        }
        private void CreateGrassAndFlowerPotPool(int flowerPotCount)
        {
            int val_4 = flowerPotCount;
            if(val_4 >= 1)
            {
                    this.CreatePoolsForItemAssets(itemAssets:  this.assetsLibrary.Load<Royal.Scenes.Game.Mechanics.Items.FlowerPotItem.View.FlowerPotItemAssets>(), count:  val_4, levelSpecific:  true);
            }
            
            val_4 = val_4 << 1;
            this.CreatePoolsForItemAssets(itemAssets:  this.assetsLibrary.Load<Royal.Scenes.Game.Mechanics.Items.StaticItems.PurpleGrassItem.View.PurpleGrassItemAssets>(), count:  System.Math.Min(val1:  val_4, val2:  75), levelSpecific:  true);
        }
        private void CreatePoolsForItemAssets(Royal.Scenes.Game.Mechanics.Items.Config.ItemAssets itemAssets, int count, bool levelSpecific = True)
        {
            if(levelSpecific != false)
            {
                    this.pooledLevelSpecificItemAssets.Add(item:  itemAssets);
            }
            
            itemAssets.CreatePools(pool:  this, amount:  count);
        }
        public void ClearPool<T>(T go)
        {
            var val_3 = 0;
            if(mem[1152921505113645056] != null)
            {
                    val_3 = val_3 + 1;
            }
            else
            {
                    Royal.Scenes.Game.Mechanics.Board.Cell.View.CellView val_1 = 1152921505113608192 + ((mem[1152921505113645064]) << 4);
            }
            
            this.objectPool.ClearPool(poolId:  go.GetPoolId());
        }
        public void CreatePool<T>(T go, int amount)
        {
            if(this.objectPool != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
        public T Spawn<T>(int poolId, bool activate = True)
        {
            if(this.objectPool != null)
            {
                    bool val_1 = activate;
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
        public void Recycle<T>(T go)
        {
            if(this.objectPool != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
    
    }

}
