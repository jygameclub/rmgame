using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.LightBulbItem.View
{
    public class LightBulbItemView : ItemView
    {
        // Fields
        public Spine.Unity.SkeletonAnimation skeletonAnimation;
        public Spine.Unity.AnimationReferenceAsset idleAnimationRef;
        public Spine.Unity.AnimationReferenceAsset shakeAnimationRef;
        public Spine.Unity.BoneFollower[] boneFollowers;
        public UnityEngine.AnimationCurve redGreenAlternativeCurve;
        private readonly Royal.Scenes.Game.Mechanics.Items.LightBulbItem.View.LightBulbItemView.LightBulbData[] lightBulbs;
        private readonly bool[] isDestroyed;
        private readonly int[] fixedDestroyIndexOrder;
        private Royal.Scenes.Game.Levels.Units.MoveManager moveManager;
        private Royal.Scenes.Game.Mechanics.Items.LightBulbItem.View.ILightBulbItemViewDelegate viewDelegate;
        private bool isChangingColor;
        
        // Methods
        public void Init(Royal.Scenes.Game.Mechanics.Items.LightBulbItem.View.ILightBulbItemViewDelegate viewDelegate, UnityEngine.Vector3 position, Royal.Scenes.Game.Mechanics.Matches.MatchType initialColor)
        {
            this.viewDelegate = viewDelegate;
            Royal.Scenes.Game.Levels.Units.MoveManager val_1 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.MoveManager>(contextId:  10);
            this.moveManager = val_1;
            val_1.add_OnMoveCompleted(value:  new System.Action<Royal.Scenes.Game.Levels.Units.Touch.MoveType>(object:  this, method:  System.Void Royal.Scenes.Game.Mechanics.Items.LightBulbItem.View.LightBulbItemView::OnMoveCompleted(Royal.Scenes.Game.Levels.Units.Touch.MoveType moveType)));
            this.InitTransform(viewDelegate:  viewDelegate, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
            this.InitLightBulbs(initialColor:  initialColor);
            this.PlayAnimation(animRef:  Spine.Unity.AnimationReferenceAsset.op_Implicit(asset:  this.idleAnimationRef));
        }
        private void InitLightBulbs(Royal.Scenes.Game.Mechanics.Matches.MatchType initialColor)
        {
            object val_13;
            var val_14 = 0;
            do
            {
                if(0 >= this.lightBulbs.Length)
            {
                    return;
            }
            
                val_13 = 0 + 1;
                int val_13 = val_13 - 1;
                this.lightBulbs[val_14] = X21.FindSlot(slotName:  val_13 + "_Ampul_On");
                this.lightBulbs[val_14] = X22.FindSlot(slotName:  val_13 + "_Ampul_Arka");
                this.lightBulbs[val_14] = X23.FindSlot(slotName:  val_13 + "_Ampul_Alternative");
                this.lightBulbs[val_14] = X24.FindSlot(slotName:  val_13 + "_Ampul_S");
                this.lightBulbs[val_14] = X25.FindSlot(slotName:  val_13 + "_Kablo");
                this.lightBulbs[val_14] = X26.FindSlot(slotName:  val_13 + "_Kablo_S");
                this.SetFrontAttachment(index:  val_13, color:  initialColor);
                val_14 = val_14 + 48;
                var val_14 = val_13 + 1;
            }
            while(this.lightBulbs != null);
            
            throw new NullReferenceException();
        }
        private void SetFrontAttachment(int index, Royal.Scenes.Game.Mechanics.Matches.MatchType color)
        {
            int val_1 = index + 1;
            string val_4 = val_1 + "_Ampul" + val_1.GetColorSuffix(color:  color)(val_1.GetColorSuffix(color:  color));
            val_4.SetAttachment(slotName:  val_1 + "_Ampul_On", attachmentName:  val_4);
        }
        private void SetBackAttachment(int index, Royal.Scenes.Game.Mechanics.Matches.MatchType color)
        {
            int val_1 = index + 1;
            string val_4 = val_1 + "_Ampul" + val_1.GetColorSuffix(color:  color)(val_1.GetColorSuffix(color:  color));
            val_4.SetAttachment(slotName:  val_1 + "_Ampul_Arka", attachmentName:  val_4);
        }
        private void SetAlternativeAttachment(int index, Royal.Scenes.Game.Mechanics.Matches.MatchType color)
        {
            int val_1 = index + 1;
            string val_4 = val_1 + "_Ampul" + val_1.GetColorSuffix(color:  color)(val_1.GetColorSuffix(color:  color));
            val_4.SetAttachment(slotName:  val_1 + "_Ampul_Alternative", attachmentName:  val_4);
        }
        private string GetColorSuffix(Royal.Scenes.Game.Mechanics.Matches.MatchType color)
        {
            var val_2;
            if((color - 1) <= 3)
            {
                    val_2 = mem[45230816 + ((color - 1)) << 3];
                val_2 = 45230816 + ((color - 1)) << 3;
                return (string)val_2;
            }
            
            val_2 = "_Pembe";
            return (string)val_2;
        }
        private UnityEngine.Vector3 ExplodeLightBulbByIndex(int index)
        {
            LightBulbData[] val_2 = this.lightBulbs;
            val_2 = val_2 + ((long)index * 48);
            this.isDestroyed[(long)index] = true;
            ((long)(int)(index) * 48) + this.lightBulbs + 32 = 0;
            ((long)(int)(index) * 48) + this.lightBulbs + 32 + 8 = 0;
            ((long)(int)(index) * 48) + this.lightBulbs + 48 = 0;
            ((long)(int)(index) * 48) + this.lightBulbs + 48 + 8 = 0;
            ((long)(int)(index) * 48) + this.lightBulbs + 64 = 0;
            ((long)(int)(index) * 48) + this.lightBulbs + 64 + 8 = 0;
            return this.boneFollowers[(long)index].transform.position;
        }
        private UnityEngine.AnimationCurve InitAlternativeBulbForColorChange(Royal.Scenes.Game.Mechanics.Matches.MatchType oldColor, Royal.Scenes.Game.Mechanics.Matches.MatchType newColor, Spine.Slot alternativeBulb, int index)
        {
            UnityEngine.AnimationCurve val_1;
            if(oldColor == 2)
            {
                goto label_0;
            }
            
            if((oldColor != 3) || (newColor != 2))
            {
                goto label_2;
            }
            
            label_5:
            alternativeBulb.r2 = 0f;
            alternativeBulb.g2 = 0f;
            alternativeBulb.r = 1;
            alternativeBulb.b = 1f;
            alternativeBulb.b2 = 0f;
            this.SetAlternativeAttachment(index:  index, color:  alternativeBulb.g2);
            val_1 = this.redGreenAlternativeCurve;
            return (UnityEngine.AnimationCurve)val_1;
            label_0:
            if(newColor == 3)
            {
                goto label_5;
            }
            
            label_2:
            val_1 = 0;
            return (UnityEngine.AnimationCurve)val_1;
        }
        private void ChangeColor(Royal.Scenes.Game.Mechanics.Matches.MatchType oldColor, Royal.Scenes.Game.Mechanics.Matches.MatchType newColor)
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.ChangeColorCoroutine(oldColor:  oldColor, newColor:  newColor));
        }
        private System.Collections.IEnumerator ChangeColorCoroutine(Royal.Scenes.Game.Mechanics.Matches.MatchType oldColor, Royal.Scenes.Game.Mechanics.Matches.MatchType newColor)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .newColor = newColor;
            .oldColor = oldColor;
            return (System.Collections.IEnumerator)new LightBulbItemView.<ChangeColorCoroutine>d__21();
        }
        public override bool IsOneCellItem()
        {
            return false;
        }
        public override bool IsReverseSorted()
        {
            return true;
        }
        public override int GetPoolId()
        {
            return 108;
        }
        public override void OnSpawn()
        {
        
        }
        public override void OnRecycle()
        {
            this.moveManager.remove_OnMoveCompleted(value:  new System.Action<Royal.Scenes.Game.Levels.Units.Touch.MoveType>(object:  this, method:  System.Void Royal.Scenes.Game.Mechanics.Items.LightBulbItem.View.LightBulbItemView::OnMoveCompleted(Royal.Scenes.Game.Levels.Units.Touch.MoveType moveType)));
            var val_9 = 0;
            var val_8 = 0;
            label_21:
            if(val_8 >= this.lightBulbs.Length)
            {
                goto label_3;
            }
            
            this.lightBulbs[val_9] = 1065353216;
            this.lightBulbs[val_9] = 1065353216;
            this.lightBulbs[val_9].Attachment = 0;
            this.lightBulbs[val_9] = 1065353216;
            this.lightBulbs[val_9] = 1065353216;
            this.lightBulbs[val_9] = 1065353216;
            val_8 = val_8 + 1;
            val_9 = val_9 + 48;
            if(this.lightBulbs != null)
            {
                goto label_21;
            }
            
            label_3:
            var val_10 = 0;
            label_26:
            if(val_10 >= (this.isDestroyed.Length << ))
            {
                goto label_24;
            }
            
            this.isDestroyed[val_10] = false;
            val_10 = val_10 + 1;
            if(this.isDestroyed != null)
            {
                goto label_26;
            }
            
            throw new NullReferenceException();
            label_24:
            this.isChangingColor = false;
        }
        private void OnMoveCompleted(Royal.Scenes.Game.Levels.Units.Touch.MoveType moveType)
        {
            if((Royal.Scenes.Game.Levels.Units.Touch.MoveTypeExtensions.IsLightBulbMove(moveType:  moveType)) == false)
            {
                    return;
            }
            
            if(this.isChangingColor != false)
            {
                    return;
            }
            
            this.isChangingColor = true;
            var val_8 = 0;
            if(mem[1152921505099374592] != null)
            {
                    val_8 = val_8 + 1;
            }
            else
            {
                    var val_9 = mem[1152921505099374600];
                val_9 = val_9 + 1;
                Royal.Scenes.Game.Mechanics.Items.LightBulbItem.View.ILightBulbItemViewDelegate val_2 = 1152921505099337728 + val_9;
            }
            
            var val_10 = 0;
            if(mem[1152921505099374592] != null)
            {
                    val_10 = val_10 + 1;
            }
            else
            {
                    Royal.Scenes.Game.Mechanics.Items.LightBulbItem.View.ILightBulbItemViewDelegate val_4 = 1152921505099337728 + ((mem[1152921505099374600]) << 4);
            }
            
            UnityEngine.Coroutine val_7 = this.StartCoroutine(routine:  this.ChangeColorCoroutine(oldColor:  this.viewDelegate.GetColor(), newColor:  this.viewDelegate.ChangeColor()));
        }
        public override UnityEngine.Vector3 GetMasterViewCenterPosition()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
            return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B}, b:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        }
        public void Damage(Royal.Scenes.Game.Mechanics.Matches.MatchType matchType, int layer)
        {
            this.PlayAnimation(animRef:  Spine.Unity.AnimationReferenceAsset.op_Implicit(asset:  this.shakeAnimationRef));
            this.ExplodeLightBulb(matchType:  matchType, layer:  layer);
        }
        public void Explode()
        {
            22274.PlaySfx(type:  158, offset:  0.04f);
            Royal.Scenes.Game.Mechanics.Items.LightBulbItem.View.LightBulbItemExplodeParticles val_1 = 22274.Spawn<Royal.Scenes.Game.Mechanics.Items.LightBulbItem.View.LightBulbItemExplodeParticles>(poolId:  110, activate:  true);
            val_1.Play();
            UnityEngine.Transform val_2 = val_1.transform;
            UnityEngine.Vector3 val_4 = this.transform.position;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  2f);
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            val_2.position = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            val_2.Recycle<Royal.Scenes.Game.Mechanics.Items.LightBulbItem.View.LightBulbItemView>(go:  this);
        }
        private void ExplodeLightBulb(Royal.Scenes.Game.Mechanics.Matches.MatchType matchType, int layer)
        {
            int val_1 = this.GetLightBulbIndexForDestroy(layer:  layer);
            PlaySfx(type:  SelectRandomClip(from:  159, to:  161), offset:  0.04f);
            UnityEngine.Vector3 val_3 = this.ExplodeLightBulbByIndex(index:  val_1);
            Royal.Scenes.Game.Mechanics.Items.LightBulbItem.View.LightBulbItemSingleExplodeParticles val_4 = this.Spawn<Royal.Scenes.Game.Mechanics.Items.LightBulbItem.View.LightBulbItemSingleExplodeParticles>(poolId:  109, activate:  true);
            val_4.Play(matchType:  matchType, index:  val_1);
            val_4.transform.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        }
        private int GetLightBulbIndexForDestroy(int layer)
        {
            return (int)this.fixedDestroyIndexOrder[9 - layer];
        }
        private void PlayAnimation(Spine.Animation animRef)
        {
            this.skeletonAnimation.state.SetAnimation(trackIndex:  0, animation:  animRef, loop:  false) = animRef.duration;
        }
        public LightBulbItemView()
        {
            this.lightBulbs = new LightBulbData[9];
            this.isDestroyed = new bool[9];
            this.fixedDestroyIndexOrder = new int[9] {1, 6, 2, 7, 0, 5, 3, 8, 4};
        }
    
    }

}
