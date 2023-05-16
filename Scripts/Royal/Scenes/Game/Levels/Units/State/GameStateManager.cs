using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.State
{
    public class GameStateManager : IGameContextUnit, IContextUnit
    {
        // Fields
        private const int StateNoGame = 0;
        private const int StatePlay = 1;
        private const int StateWin = 2;
        private const int StateEgo = 3;
        private const int StateFail = 4;
        private const int StateQuit = 5;
        private readonly Royal.Scenes.Game.Levels.Units.State.GameOperationContainer operations;
        private int gameState;
        private int ongoingSpecialOperationCount;
        
        // Properties
        public int Id { get; }
        
        // Methods
        public int get_Id()
        {
            return 14;
        }
        public GameStateManager()
        {
            this.operations = new Royal.Scenes.Game.Levels.Units.State.GameOperationContainer();
        }
        public void Bind()
        {
        
        }
        public void Clear(bool gameExit)
        {
            this.operations.Clear();
            this.ongoingSpecialOperationCount = 0;
        }
        public bool IsNoGame()
        {
            return (bool)(this.gameState == 0) ? 1 : 0;
        }
        public void StartLevel()
        {
            this.SetStateToPlay();
        }
        public bool IsPlaying()
        {
            return (bool)(this.gameState == 1) ? 1 : 0;
        }
        public bool IsWin()
        {
            return (bool)(this.gameState == 2) ? 1 : 0;
        }
        public bool IsEgo()
        {
            return (bool)(this.gameState == 3) ? 1 : 0;
        }
        public bool IsFail()
        {
            return (bool)(this.gameState == 4) ? 1 : 0;
        }
        public bool IsQuit()
        {
            return (bool)(this.gameState == 5) ? 1 : 0;
        }
        public void SetStateToQuit()
        {
            var val_2;
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).Clear(alsoRunningAction:  true);
            this.gameState = 5;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  7, log:  "State set to quit.", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        public void SetStateToFail()
        {
            var val_1;
            this.gameState = 4;
            val_1 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_1 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_1 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_1 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  7, log:  "State set to fail.", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        public void SetStateToEgo()
        {
            var val_1;
            this.gameState = 3;
            val_1 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_1 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_1 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_1 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  7, log:  "State set to ego.", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        public void SetStateToWin()
        {
            var val_1;
            this.gameState = 2;
            val_1 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_1 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_1 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_1 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  7, log:  "State set to win.", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        public void SetStateToPlay()
        {
            var val_1;
            this.gameState = 1;
            val_1 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_1 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_1 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_1 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  7, log:  "State set to play.", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        public void SetStateToNoGame()
        {
            var val_1;
            this.gameState = 0;
            val_1 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_1 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_1 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_1 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  7, log:  "State set to no game.", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        public void OperationReset(int animationId)
        {
            if(this.operations != null)
            {
                    this.operations.Reset(operationType:  animationId);
                return;
            }
            
            throw new NullReferenceException();
        }
        public void OperationStart(int animationId)
        {
            if(this.operations != null)
            {
                    this.operations.Start(operationType:  animationId);
                return;
            }
            
            throw new NullReferenceException();
        }
        public void OperationFinish(int animationId)
        {
            if(this.operations != null)
            {
                    this.operations.Finish(operationType:  animationId);
                return;
            }
            
            throw new NullReferenceException();
        }
        public bool HasOperation(int animationId)
        {
            if(this.operations != null)
            {
                    return this.operations.Has(operationType:  animationId);
            }
            
            throw new NullReferenceException();
        }
        public int GetOperationCount(int animationId)
        {
            if(this.operations != null)
            {
                    return this.operations.GetCount(operationType:  animationId);
            }
            
            throw new NullReferenceException();
        }
        public bool HasAnyOperation()
        {
            if(this.operations != null)
            {
                    return this.operations.HasAny();
            }
            
            throw new NullReferenceException();
        }
        public bool HasOnlyOperation(int first, int second)
        {
            if(this.operations != null)
            {
                    var val_2 = 1;
                val_2 = val_2 << second;
                first = val_2 | (val_2 << first);
                return this.operations.HasMask(mask:  first);
            }
            
            throw new NullReferenceException();
        }
        public override string ToString()
        {
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
            System.Text.StringBuilder val_2 = val_1.AppendFormat(format:  "Game State: {0}\n", arg0:  this.gameState);
            System.Text.StringBuilder val_3 = val_1.Append(value:  this.operations);
            return (string)val_1;
        }
        public void StartSpecialOperation()
        {
            int val_1 = this.ongoingSpecialOperationCount;
            val_1 = val_1 + 1;
            this.ongoingSpecialOperationCount = val_1;
        }
        public void FinishSpecialOperation()
        {
            int val_1 = this.ongoingSpecialOperationCount;
            val_1 = val_1 - 1;
            this.ongoingSpecialOperationCount = val_1;
        }
        public int GetSpecialOperationCount()
        {
            return (int)this.ongoingSpecialOperationCount;
        }
    
    }

}
