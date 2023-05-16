using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.Replay
{
    public class ReplayManager : IGameContextBehaviour, IGameContextUnit, IContextUnit, IContextBehaviour
    {
        // Fields
        private readonly Royal.Scenes.Game.Mechanics.Replay.RecordData <RecordData>k__BackingField;
        private Royal.Scenes.Game.Context.Units.GameTouchListener touchListener;
        
        // Properties
        public int Id { get; }
        private Royal.Scenes.Game.Mechanics.Replay.RecordData RecordData { get; }
        
        // Methods
        public int get_Id()
        {
            return 8;
        }
        private Royal.Scenes.Game.Mechanics.Replay.RecordData get_RecordData()
        {
            return (Royal.Scenes.Game.Mechanics.Replay.RecordData)this.<RecordData>k__BackingField;
        }
        public ReplayManager()
        {
            this.<RecordData>k__BackingField = new Royal.Scenes.Game.Mechanics.Replay.RecordDataParser(encodedStr:  Royal.Scenes.Game.Levels.Units.Replay.ReplayManager.LoadReplayData()).Parse();
        }
        public void Bind()
        {
            Royal.Scenes.Game.Context.Units.GameTouchListener val_1 = Royal.Scenes.Game.Context.GameContext.Get<Royal.Scenes.Game.Context.Units.GameTouchListener>(id:  0);
            this.touchListener = val_1;
            val_1.DisableTouch();
        }
        public void ManualUpdate()
        {
            System.Collections.Generic.List<System.Int16> val_7 = this.<RecordData>k__BackingField.deltas;
            val_7 = val_7 - 5;
            if(Royal.Scenes.Game.Levels.LevelContext.FrameCount > val_7)
            {
                    Royal.Scenes.Game.Levels.Units.Replay.ReplayManager.LoadHomeScene();
                return;
            }
            
            if(val_7 >= 1)
            {
                    if(30 == Royal.Scenes.Game.Levels.LevelContext.FrameCount)
            {
                    this.<RecordData>k__BackingField.swapDataList.RemoveAt(index:  0);
                Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_3 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  0, y:  0);
                Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_4 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  -1704, y:  525);
                this.touchListener.TriggerOnCellsSwapped(cellFrom:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_3.x, y = val_3.x}, cellTo:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_4.x, y = val_4.x});
            }
            
            }
            
            if(val_7 < 1)
            {
                    return;
            }
            
            if(30 != Royal.Scenes.Game.Levels.LevelContext.FrameCount)
            {
                    return;
            }
            
            this.<RecordData>k__BackingField.tapDataList.RemoveAt(index:  0);
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_6 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  0, y:  0);
            this.touchListener.TriggerOnTouchCell(cell:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_6.x, y = val_6.x});
        }
        public void Clear(bool gameExit)
        {
            Royal.Scenes.Game.Context.Units.GameManager.<IsReplay>k__BackingField = false;
            this.touchListener.EnableTouch();
        }
        public int GetSeed()
        {
            if((this.<RecordData>k__BackingField) != null)
            {
                    return (int)this.<RecordData>k__BackingField.randomSeed;
            }
            
            throw new NullReferenceException();
        }
        public float GetDeltaTime()
        {
            Royal.Scenes.Game.Mechanics.Replay.RecordData val_2 = this.<RecordData>k__BackingField;
            int val_1 = Royal.Scenes.Game.Levels.LevelContext.FrameCount;
            if(val_2 <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            float val_3 = 10000f;
            val_2 = val_2 + (val_1 << 1);
            val_3 = ((float)(this.<RecordData>k__BackingField + (val_1) << 1).gameVersion) / val_3;
            return (float)val_3;
        }
        public static void LoadHomeScene()
        {
            Royal.Scenes.Game.Context.GameContext.Get<Royal.Scenes.Game.Context.Units.GameManager>(id:  1).ExitGameWhenPossible();
        }
        public static string LoadReplayData()
        {
            return Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.GetString(key:  "ReplayFile", defaultValue:  System.String.alignConst);
        }
    
    }

}
