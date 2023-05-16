using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.Explode
{
    public class AutoExplodeManager : IGameContextBehaviour, IGameContextUnit, IContextUnit, IContextBehaviour
    {
        // Fields
        private const int FrameLimitToStop = 10;
        private bool <IsThereAWaitingMatch>k__BackingField;
        private Royal.Scenes.Game.Mechanics.Matches.MatchManager matchManager;
        private Royal.Scenes.Game.Levels.Units.State.GameStateManager gameState;
        private float hasNoOperationSinceFrame;
        private readonly Royal.Infrastructure.Utils.Counters.EnableCounter enabler;
        
        // Properties
        public int Id { get; }
        public bool IsThereAWaitingMatch { get; set; }
        
        // Methods
        public int get_Id()
        {
            return 6;
        }
        public bool get_IsThereAWaitingMatch()
        {
            return (bool)this.<IsThereAWaitingMatch>k__BackingField;
        }
        private void set_IsThereAWaitingMatch(bool value)
        {
            this.<IsThereAWaitingMatch>k__BackingField = value;
        }
        public void Bind()
        {
            this.matchManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Mechanics.Matches.MatchManager>(contextId:  4);
            this.gameState = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14);
        }
        public void Enable()
        {
            if(this.enabler != null)
            {
                    this.enabler.Enable();
                return;
            }
            
            throw new NullReferenceException();
        }
        public void Disable()
        {
            if(this.enabler != null)
            {
                    this.enabler.Disable();
                return;
            }
            
            throw new NullReferenceException();
        }
        public void ManualUpdate()
        {
            float val_5;
            if(this.enabler.IsEnabled() == false)
            {
                    return;
            }
            
            if((this.gameState.HasOperation(animationId:  6)) != false)
            {
                    this.hasNoOperationSinceFrame = -1f;
                return;
            }
            
            this.<IsThereAWaitingMatch>k__BackingField = false;
            if(this.gameState.HasAnyOperation() == false)
            {
                goto label_5;
            }
            
            val_5 = -1f;
            goto label_6;
            label_5:
            int val_4 = Royal.Scenes.Game.Levels.LevelContext.FrameCount;
            if(this.hasNoOperationSinceFrame >= 0)
            {
                goto label_7;
            }
            
            val_5 = (float)val_4;
            label_6:
            this.hasNoOperationSinceFrame = val_5;
            label_9:
            this.DestroyAllMatches();
            return;
            label_7:
            float val_5 = this.hasNoOperationSinceFrame;
            val_5 = (float)val_4 - val_5;
            if(val_5 > 10f)
            {
                    return;
            }
            
            goto label_9;
        }
        private void DestroyAllMatches()
        {
            int val_3;
            bool val_4;
            System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Matches.MatchGroup> val_1 = this.matchManager.FindAllMatches();
            if(true >= 1)
            {
                    var val_9 = 0;
                var val_10 = 32;
                do
            {
                Royal.Scenes.Game.Mechanics.Explode.ExplodeData val_2 = Royal.Scenes.Game.Mechanics.Explode.Exploder.Next(trigger:  4);
                if(val_9 >= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_5 = val_3 + val_10;
                val_9 = val_9 + 1;
                val_10 = val_10 + 152;
                bool val_7 = ((this.<IsThereAWaitingMatch>k__BackingField) == true) ? 1 : 0;
                val_7 = val_7 | (~(this.matchManager.ExplodeMatchGroup(matchGroup:  new Royal.Scenes.Game.Mechanics.Matches.MatchGroup() {cell14 = new Royal.Scenes.Game.Mechanics.Matches.Cell14(), explosionCalculated = val_4, canExplode = val_4, exists = val_4}, data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_4, y = val_4}, trigger = val_4, id = val_3})));
                bool val_8 = val_7;
                this.<IsThereAWaitingMatch>k__BackingField = val_8;
            }
            while(val_9 < val_8);
            
            }
            
            if((this.<IsThereAWaitingMatch>k__BackingField) == false)
            {
                    return;
            }
            
            this.hasNoOperationSinceFrame = -1f;
        }
        public void Clear(bool gameExit)
        {
            this.hasNoOperationSinceFrame = 0f;
            this.<IsThereAWaitingMatch>k__BackingField = false;
            if(this.enabler != null)
            {
                    this.enabler.Reset();
                return;
            }
            
            throw new NullReferenceException();
        }
        public AutoExplodeManager()
        {
            this.enabler = new Royal.Infrastructure.Utils.Counters.EnableCounter();
        }
    
    }

}
