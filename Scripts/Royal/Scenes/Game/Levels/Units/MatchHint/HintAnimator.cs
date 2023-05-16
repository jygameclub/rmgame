using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.MatchHint
{
    public class HintAnimator
    {
        // Fields
        private const int MaxCellCount = 6;
        private readonly Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory;
        private Royal.Scenes.Game.Levels.Units.MatchHint.Hint hint;
        private int particleCellCount;
        private readonly Royal.Scenes.Game.Mechanics.Board.Cell.View.HintParticles[] particles;
        private readonly Royal.Scenes.Game.Mechanics.Matches.Cell14 tempParticleCells;
        private readonly Royal.Scenes.Game.Levels.Units.MatchHint.MatchHintAnimation specialHintAnimation;
        private readonly Royal.Scenes.Game.Levels.Units.MatchHint.ComboHintAnimation comboHintAnimation;
        
        // Methods
        public HintAnimator(Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory)
        {
            this.itemFactory = itemFactory;
            this.specialHintAnimation = new Royal.Scenes.Game.Levels.Units.MatchHint.MatchHintAnimation(hintAnimator:  this);
            this.comboHintAnimation = new Royal.Scenes.Game.Levels.Units.MatchHint.ComboHintAnimation(hintAnimator:  this);
            this.particles = static_value_02DC1CB0;
        }
        public void StartAnimation(Royal.Scenes.Game.Levels.Units.MatchHint.Hint hint, float waitDurationAfterComplete)
        {
            this.PrepareParticles();
            if(hint.matchGroup.explosionCalculated != false)
            {
                    this.comboHintAnimation.StartAnimation(hintParam:  new Royal.Scenes.Game.Levels.Units.MatchHint.Hint() {matchGroup = new Royal.Scenes.Game.Mechanics.Matches.MatchGroup() {cell14 = new Royal.Scenes.Game.Mechanics.Matches.Cell14(), explosionCalculated = false, canExplode = false, exists = false}, isCombo = false}, waitDurationAfterComplete:  waitDurationAfterComplete);
                return;
            }
            
            this.specialHintAnimation.StartAnimation(hint:  new Royal.Scenes.Game.Levels.Units.MatchHint.Hint() {matchGroup = new Royal.Scenes.Game.Mechanics.Matches.MatchGroup() {cell14 = new Royal.Scenes.Game.Mechanics.Matches.Cell14(), explosionCalculated = false, canExplode = false, exists = false}, isCombo = false}, waitDurationAfterComplete:  waitDurationAfterComplete);
        }
        public void StopAnimationGently()
        {
            if(W8 == 0)
            {
                goto label_0;
            }
            
            label_3:
            if(this.comboHintAnimation.animationState == 0)
            {
                    return;
            }
            
            this.comboHintAnimation = 7;
            return;
            label_0:
            if(this.specialHintAnimation != null)
            {
                goto label_3;
            }
            
            throw new NullReferenceException();
        }
        public void StopAnimationForced()
        {
            this.RecycleParticles();
            if(W8 != 0)
            {
                    if(this.comboHintAnimation.animationState == 0)
            {
                    return;
            }
            
                this.comboHintAnimation = 0;
                this.comboHintAnimation.RestoreHintables();
                return;
            }
            
            if(this.specialHintAnimation.animationState == 0)
            {
                    return;
            }
            
            this.specialHintAnimation = 0;
            this.specialHintAnimation.RestoreHintables();
        }
        private void PrepareParticles()
        {
            int val_1;
            this.particleCellCount = 0;
            if(W8 != 0)
            {
                
            }
            else
            {
                    if(W8 == 1)
            {
                    return;
            }
            
            }
            
            this.particleCellCount = val_1;
            if(val_1 < 1)
            {
                    return;
            }
            
            var val_3 = 0;
            do
            {
                this.particles[val_3] = this.GetHintParticles(cell:  val_1, list:  new Royal.Scenes.Game.Mechanics.Matches.Cell14());
                val_3 = val_3 + 1;
            }
            while(val_3 < this.particleCellCount);
        
        }
        private Royal.Scenes.Game.Mechanics.Board.Cell.View.HintParticles GetHintParticles(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, Royal.Scenes.Game.Mechanics.Matches.Cell14 list)
        {
            int val_5;
            var val_6;
            var val_7;
            var val_8;
            Royal.Scenes.Game.Mechanics.Board.Cell.View.HintParticles val_1 = this.itemFactory.Spawn<Royal.Scenes.Game.Mechanics.Board.Cell.View.HintParticles>(poolId:  39, activate:  true);
            UnityEngine.Transform val_2 = val_1.transform;
            UnityEngine.Vector3 val_3 = cell.GetViewPosition();
            val_2.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            val_5 = 0;
            val_6 = 8;
            goto label_5;
            label_19:
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_4 = val_2.Get(type:  Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors.TouchingNeighborTypes + 32);
            if((1152921524018678944 & 1) != 0)
            {
                    val_7 = null;
                val_7 = null;
                val_5 = (Royal.Scenes.Game.Mechanics.Board.Cell.View.HintParticles.Neighbors + 32) | val_5;
            }
            
            val_6 = 9;
            label_5:
            val_8 = null;
            val_8 = null;
            if((val_6 - 8) < Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors.TouchingNeighborTypes.Length)
            {
                goto label_19;
            }
            
            val_1.Prepare(sideData:  val_5);
            return val_1;
        }
        public void ShowParticles()
        {
            if(this.particleCellCount < 1)
            {
                    return;
            }
            
            var val_2 = 0;
            do
            {
                this.particles[val_2].Show();
                val_2 = val_2 + 1;
            }
            while(val_2 < this.particleCellCount);
        
        }
        public void HideParticles()
        {
            if(this.particleCellCount < 1)
            {
                    return;
            }
            
            var val_2 = 0;
            do
            {
                this.particles[val_2].Hide();
                val_2 = val_2 + 1;
            }
            while(val_2 < this.particleCellCount);
        
        }
        public void RecycleParticles()
        {
            if(this.particleCellCount >= 1)
            {
                    var val_2 = 0;
                do
            {
                this.itemFactory.Recycle<Royal.Scenes.Game.Mechanics.Board.Cell.View.HintParticles>(go:  this.particles[val_2]);
                val_2 = val_2 + 1;
            }
            while(val_2 < this.particleCellCount);
            
            }
            
            this.particleCellCount = 0;
        }
        public void ManualUpdate()
        {
            if(W8 != 0)
            {
                    this.comboHintAnimation.ManualUpdate();
                return;
            }
            
            this.specialHintAnimation.ManualUpdate();
        }
        public bool IsStopping()
        {
            if((this.comboHintAnimation.animationState == 7) || (this.comboHintAnimation.nextState == 8))
            {
                    return true;
            }
            
            if(this.specialHintAnimation.animationState == 7)
            {
                    return true;
            }
            
            var val_1 = (this.specialHintAnimation.nextState == 8) ? 1 : 0;
            return true;
        }
        public bool IsAnimating()
        {
            Royal.Scenes.Game.Levels.Units.MatchHint.MatchHintAnimation val_4;
            if((this.comboHintAnimation.animationState != 0) || (this.comboHintAnimation.nextState != 0))
            {
                    return true;
            }
            
            val_4 = this;
            if(UnityEngine.Time.time < 0)
            {
                    return true;
            }
            
            val_4 = this.specialHintAnimation;
            if(this.specialHintAnimation.animationState != 0)
            {
                    return true;
            }
            
            if(this.specialHintAnimation.nextState != 0)
            {
                    return true;
            }
            
            var val_3 = (UnityEngine.Time.time < 0) ? 1 : 0;
            return true;
        }
    
    }

}
