using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.Replay
{
    public class RecordManager : IGameContextBehaviour, IGameContextUnit, IContextUnit, IContextBehaviour
    {
        // Fields
        public const int FrameMultiplier = 10000;
        private int <Seed>k__BackingField;
        private Royal.Scenes.Game.Mechanics.Replay.RecordData recordData;
        private Royal.Scenes.Game.Levels.Units.Touch.LevelTouchManager touchListener;
        private Royal.Scenes.Game.Context.Units.GameManager gameManager;
        
        // Properties
        public int Id { get; }
        public int Seed { get; set; }
        
        // Methods
        public int get_Id()
        {
            return 9;
        }
        public int get_Seed()
        {
            return (int)this.<Seed>k__BackingField;
        }
        private void set_Seed(int value)
        {
            this.<Seed>k__BackingField = value;
        }
        public void Bind()
        {
            Royal.Scenes.Game.Context.Units.GameManager val_1 = Royal.Scenes.Game.Context.GameContext.Get<Royal.Scenes.Game.Context.Units.GameManager>(id:  1);
            this.gameManager = val_1;
            val_1.add_OnGameRestart(value:  new System.Action(object:  this, method:  public System.Void Royal.Scenes.Game.Levels.Units.Replay.RecordManager::SaveGame()));
            this.gameManager.add_OnGameExit(value:  new System.Action(object:  this, method:  public System.Void Royal.Scenes.Game.Levels.Units.Replay.RecordManager::SaveGame()));
            Royal.Scenes.Game.Levels.Units.Touch.LevelTouchManager val_4 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.Touch.LevelTouchManager>(contextId:  3);
            this.touchListener = val_4;
            val_4.add_OnSwap(value:  new System.Action<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel, System.Boolean>(object:  this, method:  System.Void Royal.Scenes.Game.Levels.Units.Replay.RecordManager::OnSwapCells(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel arg1, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel arg2, bool isValid)));
            this.touchListener.add_OnTap(value:  new System.Action<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel>(object:  this, method:  System.Void Royal.Scenes.Game.Levels.Units.Replay.RecordManager::OnTouchCell(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cellModel)));
        }
        public void Init(int seed)
        {
            this.<Seed>k__BackingField = seed;
            .gameVersion = UnityEngine.Application.version;
            .deltas = new System.Collections.Generic.List<System.Int16>();
            .randomSeed = this.<Seed>k__BackingField;
            .swapDataList = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Replay.RecordSwapData>();
            .tapDataList = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Replay.RecordTapData>();
            this.recordData = new Royal.Scenes.Game.Mechanics.Replay.RecordData();
            .levelName = "0";
        }
        public void Clear(bool gameExit)
        {
        
        }
        private void OnTouchCell(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cellModel)
        {
            .recordedFrame = Royal.Scenes.Game.Levels.LevelContext.FrameCount;
            .cellX = 1152921505085919232;
            .cellY = 1152921505085919232;
            this.recordData.tapDataList.Add(item:  new Royal.Scenes.Game.Mechanics.Replay.RecordTapData());
        }
        private void OnSwapCells(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel arg1, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel arg2, bool isValid)
        {
            if(arg1 == null)
            {
                    return;
            }
            
            if(arg2 == null)
            {
                    return;
            }
            
            .recordedFrame = Royal.Scenes.Game.Levels.LevelContext.FrameCount;
            .fromCellX = 1152921505085865984;
            .fromCellY = 1152921505085865984;
            .toCellX = 1152921505085865984;
            .toCellY = 1152921505085865984;
            this.recordData.swapDataList.Add(item:  new Royal.Scenes.Game.Mechanics.Replay.RecordSwapData());
        }
        private string ExportData()
        {
            this.recordData = Royal.Scenes.Game.Levels.LevelContext.FrameCount;
            return this.recordData.EncodeAsString();
        }
        public void SaveGame()
        {
        
        }
        public void ManualUpdate()
        {
            float val_3 = 10000f;
            val_3 = UnityEngine.Time.deltaTime * val_3;
            this.recordData.deltas.Add(item:  UnityEngine.Mathf.FloorToInt(f:  val_3));
        }
        public RecordManager()
        {
        
        }
    
    }

}
