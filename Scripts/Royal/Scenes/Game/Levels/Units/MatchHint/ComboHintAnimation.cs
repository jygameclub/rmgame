using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.MatchHint
{
    public class ComboHintAnimation
    {
        // Fields
        private Royal.Scenes.Game.Levels.Units.MatchHint.ComboHintAnimation.AnimationState animationState;
        private Royal.Scenes.Game.Levels.Units.MatchHint.ComboHintAnimation.AnimationState nextState;
        private int pokeCount;
        private int count;
        private float elapsed;
        private float duration;
        private float waitDurationAfterComplete;
        private const int MaxPokeCount = 2;
        private Royal.Scenes.Game.Levels.Units.MatchHint.Hint hint;
        private int hintableCellCount;
        private UnityEngine.Vector3 direction;
        private readonly Royal.Scenes.Game.Levels.Units.MatchHint.IHintable[] hintables;
        private Royal.Scenes.Game.Levels.Units.MatchHint.HintDirection hintDirection;
        private UnityEngine.Vector3[] startPosition;
        private UnityEngine.Vector3[] endPosition;
        private DG.Tweening.Ease easingType;
        private UnityEngine.Quaternion startRotation;
        private UnityEngine.Quaternion endRotation;
        private readonly Royal.Scenes.Game.Mechanics.Items.Config.RootTransform[] tempTransforms;
        private readonly Royal.Scenes.Game.Mechanics.Matches.Cell14 tempParticleCells;
        private readonly Royal.Scenes.Game.Levels.Units.MatchHint.HintAnimator hintAnimator;
        private const float ShortWaitDuration = 0.2;
        private float animationCompletionTime;
        
        // Methods
        public ComboHintAnimation(Royal.Scenes.Game.Levels.Units.MatchHint.HintAnimator hintAnimator)
        {
            this.hintAnimator = hintAnimator;
            this.hintables = new Royal.Scenes.Game.Levels.Units.MatchHint.IHintable[2];
            this.tempTransforms = new Royal.Scenes.Game.Mechanics.Items.Config.RootTransform[2];
            this.startPosition = new UnityEngine.Vector3[2];
            this.endPosition = new UnityEngine.Vector3[2];
        }
        public void StartAnimation(Royal.Scenes.Game.Levels.Units.MatchHint.Hint hintParam, float waitDurationAfterComplete)
        {
            this.waitDurationAfterComplete = waitDurationAfterComplete;
            this.PrepareHintables();
            this.count = 0;
            this.animationState = 1;
            this.hintAnimator.ShowParticles();
        }
        private void PrepareHintables()
        {
            float val_19;
            float val_20;
            Royal.Scenes.Game.Levels.Units.MatchHint.IHintable[] val_21;
            Royal.Scenes.Game.Levels.Units.MatchHint.Hint val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            this.hintableCellCount = 0;
            val_19 = V0.16B;
            val_20 = V2.16B;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_19, y = V1.16B, z = val_20}, b:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B});
            this.direction = val_1;
            mem[1152921524014198968] = val_1.y;
            mem[1152921524014198972] = val_1.z;
            if((UnityEngine.Vector3.__il2cppRuntimeField_cctor_finished + 32.HasCurrentItem()) == false)
            {
                goto label_7;
            }
            
            val_21 = this;
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_3 = UnityEngine.Vector3.__il2cppRuntimeField_cctor_finished + 32.CurrentItem;
            this.hintables = null;
            if(this.hintables.Length != 0)
            {
                goto label_14;
            }
            
            label_7:
            if((mem[this.hint + 32].HasCurrentItem()) == false)
            {
                goto label_18;
            }
            
            val_20 = this.direction;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_20, y = val_19, z = V1.16B}, d:  -1f);
            val_21 = this;
            this.direction = val_5.x;
            mem[1152921524014198968] = val_5.y;
            mem[1152921524014198972] = val_5.z;
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_6 = mem[this.hint + 32].CurrentItem;
            this.hintables = null;
            val_22 = this.hint;
            label_14:
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_7 = mem[this.hint + 32].CurrentItem;
            this.tempTransforms = val_7.itemMediator;
            goto label_35;
            label_18:
            val_21 = this.hintables;
            label_35:
            var val_19 = mem[this.hintables] + 32;
            if((mem[this.hintables] + 32 + 294) == 0)
            {
                goto label_42;
            }
            
            var val_16 = mem[this.hintables] + 32 + 176;
            var val_17 = 0;
            val_16 = val_16 + 8;
            label_41:
            if(((mem[this.hintables] + 32 + 176 + 8) + -8) == null)
            {
                goto label_40;
            }
            
            val_17 = val_17 + 1;
            val_16 = val_16 + 16;
            if(val_17 < (mem[this.hintables] + 32 + 294))
            {
                goto label_41;
            }
            
            goto label_42;
            label_40:
            var val_18 = val_16;
            val_18 = val_18 + 2;
            val_19 = val_19 + val_18;
            val_23 = val_19 + 304;
            label_42:
            val_24 = public System.Void Royal.Scenes.Game.Levels.Units.MatchHint.IHintable::StartHintAnimation(bool changeSorting);
            mem[this.hintables] + 32.StartHintAnimation(changeSorting:  true);
            int val_20 = this.hintableCellCount;
            val_20 = val_20 + 1;
            this.hintableCellCount = val_20;
            if(((public System.Void Royal.Scenes.Game.Levels.Units.MatchHint.IHintable::StartHintAnimation(bool changeSorting).__il2cppRuntimeField_20.HasCurrentItem()) == false) || ((mem[this.hint + 32].HasCurrentItem()) == false))
            {
                goto label_48;
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_10 = mem[this.hint + 32].CurrentItem;
            this.tempTransforms = val_10.itemMediator;
            var val_21 = mem[this.hintables];
            val_21 = X0;
            var val_25 = mem[this.hintables] + 40;
            if((mem[this.hintables] + 40 + 294) == 0)
            {
                goto label_64;
            }
            
            var val_22 = mem[this.hintables] + 40 + 176;
            var val_23 = 0;
            val_22 = val_22 + 8;
            label_66:
            if(((mem[this.hintables] + 40 + 176 + 8) + -8) == null)
            {
                goto label_65;
            }
            
            val_23 = val_23 + 1;
            val_22 = val_22 + 16;
            if(val_23 < (mem[this.hintables] + 40 + 294))
            {
                goto label_66;
            }
            
            label_64:
            val_24 = 2;
            goto label_67;
            label_65:
            var val_24 = val_22;
            val_24 = val_24 + 2;
            val_25 = val_25 + val_24;
            val_25 = val_25 + 304;
            label_67:
            mem[this.hintables] + 40.StartHintAnimation(changeSorting:  false);
            int val_26 = this.hintableCellCount;
            val_26 = val_26 + 1;
            this.hintableCellCount = val_26;
            label_48:
            var val_30 = mem[this.hintables] + 32;
            if((mem[this.hintables] + 32 + 294) == 0)
            {
                goto label_74;
            }
            
            var val_27 = mem[this.hintables] + 32 + 176;
            var val_28 = 0;
            val_27 = val_27 + 8;
            label_73:
            if(((mem[this.hintables] + 32 + 176 + 8) + -8) == null)
            {
                goto label_72;
            }
            
            val_28 = val_28 + 1;
            val_27 = val_27 + 16;
            if(val_28 < (mem[this.hintables] + 32 + 294))
            {
                goto label_73;
            }
            
            goto label_74;
            label_72:
            var val_29 = val_27;
            val_29 = val_29 + 1;
            val_30 = val_30 + val_29;
            val_26 = val_30 + 304;
            label_74:
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_11 = mem[this.hintables] + 32.CurrentCell;
            var val_34 = mem[this.hintables] + 40;
            if((mem[this.hintables] + 40 + 294) == 0)
            {
                goto label_82;
            }
            
            var val_31 = mem[this.hintables] + 40 + 176;
            var val_32 = 0;
            val_31 = val_31 + 8;
            label_81:
            if(((mem[this.hintables] + 40 + 176 + 8) + -8) == null)
            {
                goto label_80;
            }
            
            val_32 = val_32 + 1;
            val_31 = val_31 + 16;
            if(val_32 < (mem[this.hintables] + 40 + 294))
            {
                goto label_81;
            }
            
            goto label_82;
            label_80:
            var val_33 = val_31;
            val_33 = val_33 + 1;
            val_34 = val_34 + val_33;
            val_27 = val_34 + 304;
            label_82:
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_12 = mem[this.hintables] + 40.CurrentCell;
            var val_13 = val_21 >> 32;
            if(val_13 == 0)
            {
                    var val_14 = (val_21 >= (public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel Royal.Scenes.Game.Levels.Units.MatchHint.IHintable::get_CurrentCell())) ? 1 : 0;
            }
            
            this.hintDirection = (val_13 >= 0) ? (2 + 1) : 2;
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
            Royal.Scenes.Game.Levels.Units.MatchHint.IHintable[] val_3;
            var val_4;
            var val_5;
            val_3 = this.hintables;
            val_4 = 0;
            label_10:
            if(val_4 >= (this.hintables.Length << ))
            {
                goto label_2;
            }
            
            Royal.Scenes.Game.Levels.Units.MatchHint.IHintable val_2 = val_3[val_4];
            var val_1 = (val_2 == 0) ? 0 : (val_2);
            if(val_2 == null)
            {
                goto label_4;
            }
            
            var val_6 = val_1;
            if((val_3[val_4] == null ? 0 : this.hintables[0x0][0] + 294) == 0)
            {
                goto label_9;
            }
            
            var val_3 = val_3[val_4] == null ? 0 : this.hintables[0x0][0] + 176;
            var val_4 = 0;
            val_3 = val_3 + 8;
            label_8:
            if(((val_3[val_4] == null ? 0 : this.hintables[0x0][0] + 176 + 8) + -8) == null)
            {
                goto label_7;
            }
            
            val_4 = val_4 + 1;
            val_3 = val_3 + 16;
            if(val_4 < (val_3[val_4] == null ? 0 : this.hintables[0x0][0] + 294))
            {
                goto label_8;
            }
            
            goto label_9;
            label_7:
            var val_5 = val_3;
            val_5 = val_5 + 3;
            val_6 = val_6 + val_5;
            val_5 = val_6 + 304;
            label_9:
            val_1.StopHintAnimation();
            val_3 = this.hintables;
            label_4:
            val_4 = val_4 + 1;
            if(val_3 != null)
            {
                goto label_10;
            }
            
            throw new NullReferenceException();
            label_2:
            this.hintableCellCount = 0;
            this.pokeCount = 0;
        }
        public void ManualUpdate()
        {
            AnimationState val_30 = this.animationState;
            val_30 = val_30 - 1;
            if(val_30 > 7)
            {
                    return;
            }
            
            var val_31 = 36588384 + ((this.animationState - 1)) << 2;
            val_31 = val_31 + 36588384;
            goto (36588384 + ((this.animationState - 1)) << 2 + 36588384);
        }
        private void SetInterpolationVariables(float dur, float offset)
        {
            this.elapsed = 0f;
            this.duration = dur;
            UnityEngine.Vector3 val_1 = this.tempTransforms[0].GetPosition();
            this.startPosition = val_1.x;
            this.startPosition = val_1.y;
            this.startPosition = val_1.z;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.direction, y = dur, z = V10.16B}, d:  offset);
            this.endPosition = val_2.x;
            this.endPosition = val_2.y;
            this.endPosition = val_2.z;
            UnityEngine.Vector3 val_3 = this.tempTransforms[1].GetPosition();
            this.startPosition = val_3.x;
            this.startPosition = val_3.y;
            this.startPosition = val_3.z;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = this.direction, y = val_3.y, z = val_3.z});
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  offset);
            this.endPosition = val_5.x;
            this.endPosition = val_5.y;
            this.endPosition = val_5.z;
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
