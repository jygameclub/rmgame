using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.Explode
{
    public interface IExplodeTarget
    {
        // Properties
        public abstract bool IsValidTarget { get; }
        public abstract Royal.Scenes.Game.Mechanics.Board.Cell.CellModel CurrentCell { get; }
        
        // Methods
        public abstract bool get_IsValidTarget(); // 0
        public abstract Royal.Scenes.Game.Mechanics.Board.Cell.CellModel get_CurrentCell(); // 0
        public abstract UnityEngine.Vector3 GetViewPosition(); // 0
        public abstract UnityEngine.Vector3 GetMasterViewCenterPosition(); // 0
        public abstract void RemoveIncomingExploder(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data); // 0
    
    }

}
