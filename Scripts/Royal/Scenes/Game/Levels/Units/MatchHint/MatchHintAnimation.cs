using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.MatchHint
{
    public class MatchHintAnimation
    {
        // Fields
        private Royal.Scenes.Game.Levels.Units.MatchHint.MatchHintAnimation.AnimationState animationState;
        private Royal.Scenes.Game.Levels.Units.MatchHint.MatchHintAnimation.AnimationState nextState;
        private int pokeCount;
        private int count;
        private float elapsed;
        private float duration;
        private UnityEngine.Vector3 startPosition;
        private UnityEngine.Vector3 endPosition;
        private Royal.Scenes.Game.Mechanics.Items.Config.RootTransform mover;
        private UnityEngine.Vector3 direction;
        private float waitDurationAfterComplete;
        private const int MaxCellCount = 6;
        private const int MaxPokeCount = 2;
        private const float ShortWaitDuration = 0.2;
        private Royal.Scenes.Game.Levels.Units.MatchHint.Hint hint;
        private int hintableCellCount;
        private readonly Royal.Scenes.Game.Levels.Units.MatchHint.IHintable[] hintables;
        private readonly float[] startHighlightColors;
        private readonly float[] endHighlightColors;
        private readonly Royal.Scenes.Game.Levels.Units.MatchHint.HintAnimator hintAnimator;
        private float animationCompletionTime;
        
        // Methods
        public MatchHintAnimation(Royal.Scenes.Game.Levels.Units.MatchHint.HintAnimator hintAnimator)
        {
            this.hintAnimator = hintAnimator;
            this.hintables = new Royal.Scenes.Game.Levels.Units.MatchHint.IHintable[6];
            this.startHighlightColors = new float[6];
            this.endHighlightColors = new float[6];
        }
        public void StartAnimation(Royal.Scenes.Game.Levels.Units.MatchHint.Hint hint, float waitDurationAfterComplete)
        {
            this.waitDurationAfterComplete = waitDurationAfterComplete;
            this.PrepareHintables();
            this.count = 0;
            this.animationState = 1;
            this.hintAnimator.ShowParticles();
        }
        private void PrepareHintables()
        {
            var val_7;
            var val_10;
            float val_11;
            float val_12;
            Royal.Scenes.Game.Levels.Units.MatchHint.Hint val_13;
            Royal.Scenes.Game.Levels.Units.MatchHint.IHintable[] val_14;
            var val_16;
            var val_17;
            val_10 = 152;
            this.hintableCellCount = 0;
            val_11 = V0.16B;
            val_12 = V2.16B;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_11, y = V1.16B, z = val_12}, b:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B});
            this.direction = val_1;
            mem[1152921524025682252] = val_1.y;
            mem[1152921524025682256] = val_1.z;
            bool val_2 = UnityEngine.Vector3.__il2cppRuntimeField_cctor_finished + 32.HasCurrentItem();
            bool val_3 = mem[this.hint + 32].HasCurrentItem();
            val_12 = this.direction;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_12, y = val_11, z = V1.16B}, d:  -1f);
            val_13 = this.hint;
            this.direction = val_4;
            mem[1152921524025682252] = val_4.y;
            mem[1152921524025682256] = val_4.z;
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_5 = mem[this.hint + 32].CurrentItem;
            val_14 = this.hintables;
            this.mover = val_5.itemMediator;
            val_14 = null;
            var val_11 = 0;
            if(mem[1152921505116839936] != null)
            {
                    val_11 = val_11 + 1;
                val_10 = 2;
            }
            else
            {
                    var val_12 = mem[1152921505116839944];
                val_12 = val_12 + 2;
                Royal.Scenes.Game.Levels.Units.MatchHint.IHintable val_6 = 1152921505116803072 + val_12;
            }
            
            this.hintables[0].StartHintAnimation(changeSorting:  true);
            int val_13 = this.hintableCellCount;
            val_13 = val_13 + 1;
            this.hintableCellCount = val_13;
            if( < 1)
            {
                    return;
            }
            
            val_16 = 1;
            label_47:
            val_17 = 0;
            if(( == val_13) || ( == this.hint))
            {
                goto label_32;
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_8 = val_7.CurrentItem;
            int val_14 = this.hintableCellCount;
            val_14 = val_14 + 1;
            this.hintableCellCount = val_14;
            this.hintables[1] = null;
            var val_16 = 0;
            if(mem[1152921505116839936] == null)
            {
                goto label_43;
            }
            
            val_16 = val_16 + 1;
            val_17 = 2;
            goto label_45;
            label_32:
            val_16 = val_16 - 1;
            goto label_46;
            label_43:
            var val_17 = mem[1152921505116839944];
            val_17 = val_17 + 2;
            Royal.Scenes.Game.Levels.Units.MatchHint.IHintable val_9 = 1152921505116803072 + val_17;
            label_45:
            this.hintables[1].StartHintAnimation(changeSorting:  false);
            label_46:
            val_14 = 0 + 1;
            val_16 = val_16 + 1;
            if(val_14 < )
            {
                goto label_47;
            }
        
        }
        public void StopAnimationGently()
        {
            if(this.animationState == 0)
            {
                    return;
            }
            
            this.animationState = 7;
        }
        public void StopAnimationForced()
        {
            if(this.animationState == 0)
            {
                    return;
            }
            
            this.animationState = 0;
            this.RestoreHintables();
        }
        private void RestoreHintables()
        {
            int val_3;
            var val_4;
            val_3 = this.hintableCellCount;
            if(val_3 < 1)
            {
                goto label_1;
            }
            
            var val_7 = 0;
            label_10:
            Royal.Scenes.Game.Levels.Units.MatchHint.IHintable val_2 = this.hintables[val_7];
            var val_1 = (val_2 == 0) ? 0 : (val_2);
            if(val_2 == null)
            {
                goto label_4;
            }
            
            var val_6 = val_1;
            if((this.hintables[0] == null ? 0 : this.hintables[0x0][0] + 294) == 0)
            {
                goto label_9;
            }
            
            var val_3 = this.hintables[0] == null ? 0 : this.hintables[0x0][0] + 176;
            var val_4 = 0;
            val_3 = val_3 + 8;
            label_8:
            if(((this.hintables[0] == null ? 0 : this.hintables[0x0][0] + 176 + 8) + -8) == null)
            {
                goto label_7;
            }
            
            val_4 = val_4 + 1;
            val_3 = val_3 + 16;
            if(val_4 < (this.hintables[0] == null ? 0 : this.hintables[0x0][0] + 294))
            {
                goto label_8;
            }
            
            goto label_9;
            label_7:
            var val_5 = val_3;
            val_5 = val_5 + 3;
            val_6 = val_6 + val_5;
            val_4 = val_6 + 304;
            label_9:
            val_1.StopHintAnimation();
            val_3 = this.hintableCellCount;
            label_4:
            val_7 = val_7 + 1;
            if(val_7 < (val_3 << ))
            {
                goto label_10;
            }
            
            label_1:
            this.hintableCellCount = 0;
            this.pokeCount = 0;
        }
        public void ManualUpdate()
        {
            AnimationState val_19 = this.animationState;
            val_19 = val_19 - 1;
            if(val_19 > 7)
            {
                    return;
            }
            
            var val_20 = 36588416 + ((this.animationState - 1)) << 2;
            val_20 = val_20 + 36588416;
            goto (36588416 + ((this.animationState - 1)) << 2 + 36588416);
        }
        private void SetInterpolationVariables(float duration, UnityEngine.Vector3 moverPosition, UnityEngine.Vector3 startPosition, UnityEngine.Vector3 endPosition, float highlightRatio)
        {
            var val_1;
            float val_4;
            this.elapsed = 0f;
            this.duration = duration;
            val_4 = endPosition.x;
            this.mover.SetPosition(vector:  new UnityEngine.Vector3() {x = moverPosition.x, y = moverPosition.y, z = moverPosition.z});
            this.startPosition = startPosition;
            mem[1152921524026963244] = startPosition.y;
            mem[1152921524026963256] = val_1;
            mem[1152921524026963260] = endPosition.y;
            mem[1152921524026963248] = startPosition.z;
            this.endPosition = endPosition;
            if(this.hintableCellCount < 1)
            {
                    return;
            }
            
            val_4 = endPosition.z;
            var val_12 = 0;
            do
            {
                var val_7 = 0;
                if(mem[1152921505116839936] != null)
            {
                    val_7 = val_7 + 1;
            }
            else
            {
                    var val_8 = mem[1152921505116839944];
                val_8 = val_8 + 5;
                Royal.Scenes.Game.Levels.Units.MatchHint.IHintable val_2 = 1152921505116803072 + val_8;
            }
            
                this.startHighlightColors[0] = this.hintables[0].GetHighlightRatio();
                var val_10 = 0;
                if(mem[1152921505116839936] != null)
            {
                    val_10 = val_10 + 1;
            }
            else
            {
                    var val_11 = mem[1152921505116839944];
                val_11 = val_11 + 6;
                Royal.Scenes.Game.Levels.Units.MatchHint.IHintable val_4 = 1152921505116803072 + val_11;
            }
            
                float val_5 = this.hintables[0].GetMaxHighlightRatio();
                val_5 = val_5 * val_4;
                this.endHighlightColors[0] = val_5;
                val_12 = val_12 + 1;
            }
            while(val_12 < this.hintableCellCount);
        
        }
        public bool IsStopping()
        {
            if(this.animationState != 7)
            {
                    return (bool)(this.nextState == 8) ? 1 : 0;
            }
            
            return true;
        }
        public bool IsAnimating()
        {
            if(this.animationState != 0)
            {
                    return true;
            }
            
            if(this.nextState != 0)
            {
                    return true;
            }
            
            var val_2 = (UnityEngine.Time.time < 0) ? 1 : 0;
            return true;
        }
    
    }

}
