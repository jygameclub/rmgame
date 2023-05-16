using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.ItemCreation
{
    public class ItemFactory : IGameContextUnit, IContextUnit
    {
        // Fields
        private UnityEngine.Transform <GridParent>k__BackingField;
        private UnityEngine.Transform <CellParent>k__BackingField;
        private UnityEngine.Transform <ItemParent>k__BackingField;
        public readonly Royal.Scenes.Game.Levels.Units.ItemAssetsLibrary assetsLibrary;
        public Royal.Scenes.Game.Levels.Units.ItemCreation.ItemCreator itemCreator;
        public Royal.Scenes.Game.Levels.Units.ItemCreation.SpecialItemCreator specialItemCreator;
        private readonly Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool;
        private bool secondPartOfPermanentPoolsCreated;
        
        // Properties
        public int Id { get; }
        public UnityEngine.Transform GridParent { get; set; }
        public UnityEngine.Transform CellParent { get; set; }
        public UnityEngine.Transform ItemParent { get; set; }
        
        // Methods
        public int get_Id()
        {
            return 1;
        }
        public UnityEngine.Transform get_GridParent()
        {
            return (UnityEngine.Transform)this.<GridParent>k__BackingField;
        }
        private void set_GridParent(UnityEngine.Transform value)
        {
            this.<GridParent>k__BackingField = value;
        }
        public UnityEngine.Transform get_CellParent()
        {
            return (UnityEngine.Transform)this.<CellParent>k__BackingField;
        }
        private void set_CellParent(UnityEngine.Transform value)
        {
            this.<CellParent>k__BackingField = value;
        }
        public UnityEngine.Transform get_ItemParent()
        {
            return (UnityEngine.Transform)this.<ItemParent>k__BackingField;
        }
        private void set_ItemParent(UnityEngine.Transform value)
        {
            this.<ItemParent>k__BackingField = value;
        }
        public ItemFactory()
        {
            Royal.Scenes.Game.Levels.Units.ItemAssetsLibrary val_1 = new Royal.Scenes.Game.Levels.Units.ItemAssetsLibrary();
            this.assetsLibrary = val_1;
            this.pool = new Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool(assetsLibrary:  val_1);
        }
        public void Bind()
        {
            this.itemCreator = new Royal.Scenes.Game.Levels.Units.ItemCreation.ItemCreator(randomManager:  Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.LevelRandomManager>(contextId:  0));
            this.specialItemCreator = new Royal.Scenes.Game.Levels.Units.ItemCreation.SpecialItemCreator(itemFactory:  this);
        }
        public void CreateParentGameObjects()
        {
            int val_1 = UnityEngine.LayerMask.NameToLayer(layerName:  "Level");
            UnityEngine.Transform val_3 = new UnityEngine.GameObject().transform;
            this.<GridParent>k__BackingField = val_3;
            val_3.name = "GridParent";
            this.<GridParent>k__BackingField.gameObject.layer = val_1;
            UnityEngine.Transform val_6 = new UnityEngine.GameObject().transform;
            this.<CellParent>k__BackingField = val_6;
            val_6.name = "CellParent";
            this.<CellParent>k__BackingField.gameObject.layer = val_1;
            this.<CellParent>k__BackingField.SetParent(p:  this.<GridParent>k__BackingField);
            Royal.Infrastructure.Utils.Animation.ShakeAnimation val_9 = this.<CellParent>k__BackingField.gameObject.AddComponent<Royal.Infrastructure.Utils.Animation.ShakeAnimation>();
            UnityEngine.Transform val_11 = new UnityEngine.GameObject().transform;
            this.<ItemParent>k__BackingField = val_11;
            val_11.name = "ItemParent";
            this.<ItemParent>k__BackingField.gameObject.layer = val_1;
            this.<ItemParent>k__BackingField.SetParent(p:  this.<CellParent>k__BackingField);
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.zero;
            this.<ItemParent>k__BackingField.transform.localPosition = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
        }
        public long CreatePermanentPoolsFirstPart()
        {
            System.Diagnostics.Stopwatch val_1 = new System.Diagnostics.Stopwatch();
            val_1.Start();
            this.pool.InitializePermanentPoolsFirstPart();
            val_1.Stop();
            long val_2 = val_1.ElapsedMilliseconds;
            object[] val_3 = new object[1];
            val_3[0] = val_2;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  1, log:  "Pool creation first part finished in {0}.", values:  val_3);
            return val_2;
        }
        public void CreatePermanentPoolsSecondPart()
        {
            System.Diagnostics.Stopwatch val_1 = new System.Diagnostics.Stopwatch();
            val_1.Start();
            this.pool.InitializePermanentPoolsSecondPart();
            val_1.Stop();
            object[] val_2 = new object[1];
            val_2[0] = val_1.ElapsedMilliseconds;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  1, log:  "Pool creation second part finished in {0}.", values:  val_2);
            this.secondPartOfPermanentPoolsCreated = true;
        }
        public void CreateLevelPools(System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Goal.GoalType, Royal.Scenes.Game.Mechanics.Goal.GoalTuple> goals, System.Collections.Generic.Dictionary<int, int> counts, int curtainCellCount, int drillCount, int chainCount)
        {
            if(this.secondPartOfPermanentPoolsCreated != true)
            {
                    this.CreatePermanentPoolsSecondPart();
            }
            
            this.pool.InitializeLevelSpecificPools(goals:  goals, countsOnBoard:  counts, curtainCellCount:  curtainCellCount, drillCount:  drillCount, chainCount:  chainCount);
        }
        public void CreateMadnessPools(Royal.Scenes.Game.Mechanics.Items.Config.ItemType itemType)
        {
            if(this.pool != null)
            {
                    this.pool.InitializeMadnessPool(itemType:  itemType);
                return;
            }
            
            throw new NullReferenceException();
        }
        public void ClearPools()
        {
            if(this.pool != null)
            {
                    this.pool.ClearAllPools();
                return;
            }
            
            throw new NullReferenceException();
        }
        public void InitializeItemSpecificPool<T>(int amount)
        {
            if(this.pool != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
        public T Spawn<T>(int poolId, bool activate = True)
        {
            if(this.pool != null)
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
            if(this.pool != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
        public void Clear(bool gameExit)
        {
            this.specialItemCreator.Clear();
            this.itemCreator.Clear();
        }
    
    }

}
