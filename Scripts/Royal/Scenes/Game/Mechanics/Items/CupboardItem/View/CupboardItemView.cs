using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.CupboardItem.View
{
    public class CupboardItemView : ItemView
    {
        // Fields
        private static readonly int CupboardIdleAnimation;
        private static readonly int CupboardShakeAnimation1;
        private static readonly int CupboardShakeAnimation2;
        private static readonly int PlateAnimation1;
        private static readonly int PlateAnimation2;
        private static readonly int PlateAnimation3;
        private static readonly int PlateAnimation4;
        private static readonly int PlateAnimation5;
        public UnityEngine.GameObject doorView;
        public UnityEngine.GameObject[] plateViews;
        public UnityEngine.SpriteRenderer cupboardContainerLeft;
        public UnityEngine.SpriteRenderer cupboardContainerRight;
        public UnityEngine.GameObject cupboardMask;
        public UnityEngine.Animator cupboardAnimator;
        public UnityEngine.Animator platesUpAnimator;
        public UnityEngine.Animator platesDownAnimator;
        public Royal.Scenes.Game.Mechanics.Items.CupboardItem.View.Animation.CupboardItemShakeAnimationData shakeAnimationData;
        private int lastTriggerId;
        private Royal.Scenes.Game.Levels.Units.LevelRandomManager randomManager;
        
        // Methods
        public void Init(Royal.Scenes.Game.Mechanics.Items.Config.IItemViewDelegate viewDelegate, UnityEngine.Vector3 position)
        {
            this.randomManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.LevelRandomManager>(contextId:  0);
            this.doorView.SetActive(value:  true);
            var val_3 = 0;
            label_6:
            if(val_3 >= this.plateViews.Length)
            {
                goto label_3;
            }
            
            this.plateViews[val_3].SetActive(value:  true);
            val_3 = val_3 + 1;
            if(this.plateViews != null)
            {
                goto label_6;
            }
            
            throw new NullReferenceException();
            label_3:
            this.cupboardAnimator.speed = 0.9f;
            this.platesUpAnimator.speed = 0.8f;
            this.platesDownAnimator.speed = 0.8f;
            this.cupboardAnimator.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.CupboardItem.View.CupboardItemView.CupboardIdleAnimation, layer:  0, normalizedTime:  0f);
            this.InitTransform(viewDelegate:  viewDelegate, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
            this.ShowHead();
        }
        public void HideHead()
        {
            if(this.cupboardMask.activeInHierarchy != false)
            {
                    return;
            }
            
            this.cupboardContainerLeft.maskInteraction = 2;
            this.cupboardContainerRight.maskInteraction = 2;
            this.cupboardMask.SetActive(value:  true);
        }
        public void ShowHead()
        {
            if(this.cupboardMask.activeInHierarchy == false)
            {
                    return;
            }
            
            this.cupboardContainerLeft.maskInteraction = 0;
            this.cupboardContainerRight.maskInteraction = 0;
            this.cupboardMask.SetActive(value:  false);
        }
        public override bool IsOneCellItem()
        {
            return false;
        }
        public override int GetPoolId()
        {
            return 40;
        }
        public override void OnSpawn()
        {
        
        }
        public override void OnRecycle()
        {
            this.lastTriggerId = 0;
            this.shakeAnimationData = 0;
        }
        public void RemoveDoor(Royal.Scenes.Game.Mechanics.Items.CupboardItem.View.Animation.CupboardItemShakeAnimationData nearestShakeAnimationData)
        {
            9921.PlaySfx(type:  86, offset:  0.04f);
            this.PlayCupboardAnimation(nearestShakeAnimationData:  new Royal.Scenes.Game.Mechanics.Items.CupboardItem.View.Animation.CupboardItemShakeAnimationData() {startedFrame = nearestShakeAnimationData.startedFrame, selectedAnimation = nearestShakeAnimationData.selectedAnimation});
            this.PlayPlateAnimation(index:  10);
            Royal.Scenes.Game.Mechanics.Items.CupboardItem.View.CupboardItemDoorExplodeParticles val_1 = this.Spawn<Royal.Scenes.Game.Mechanics.Items.CupboardItem.View.CupboardItemDoorExplodeParticles>(poolId:  41, activate:  true);
            val_1.Play();
            UnityEngine.Vector3 val_4 = this.doorView.transform.position;
            val_1.transform.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            this.doorView.SetActive(value:  false);
        }
        public void Damage(int index, Royal.Scenes.Game.Mechanics.Items.CupboardItem.View.Animation.CupboardItemShakeAnimationData nearestShakeAnimationData, Royal.Scenes.Game.Mechanics.Explode.ExplodeData trigger)
        {
            int val_6;
            var val_7;
            val_6 = this.lastTriggerId;
            if(val_6 != 268435459)
            {
                    this.PlayCupboardAnimation(nearestShakeAnimationData:  new Royal.Scenes.Game.Mechanics.Items.CupboardItem.View.Animation.CupboardItemShakeAnimationData() {startedFrame = nearestShakeAnimationData.startedFrame, selectedAnimation = nearestShakeAnimationData.selectedAnimation});
                val_6 = 268435459;
            }
            
            this.lastTriggerId = 268435459;
            int val_1 = this.randomManager.Next(min:  0, max:  3);
            if(val_1 == 2)
            {
                goto label_3;
            }
            
            if(val_1 == 1)
            {
                goto label_4;
            }
            
            if(val_1 != 0)
            {
                goto label_5;
            }
            
            val_7 = 87;
            goto label_9;
            label_4:
            val_7 = 88;
            goto label_9;
            label_3:
            val_7 = 89;
            label_9:
            val_1.PlaySfx(type:  89, offset:  0.04f);
            label_5:
            this.PlayPlateAnimation(index:  index);
            UnityEngine.GameObject val_6 = this.plateViews[index];
            Royal.Scenes.Game.Mechanics.Items.CupboardItem.View.CupboardItemSingleExplodeParticles val_2 = this.Spawn<Royal.Scenes.Game.Mechanics.Items.CupboardItem.View.CupboardItemSingleExplodeParticles>(poolId:  42, activate:  true);
            val_2.Play();
            UnityEngine.Vector3 val_5 = val_6.transform.position;
            val_2.transform.position = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            val_6.SetActive(value:  false);
        }
        public void Explode()
        {
            Royal.Scenes.Game.Mechanics.Items.CupboardItem.View.CupboardItemExplodeParticles val_1 = 9916.Spawn<Royal.Scenes.Game.Mechanics.Items.CupboardItem.View.CupboardItemExplodeParticles>(poolId:  43, activate:  true);
            val_1.Play();
            UnityEngine.Transform val_2 = val_1.transform;
            UnityEngine.Vector3 val_4 = this.transform.position;
            val_2.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            val_2.PlaySfx(type:  85, offset:  0.04f);
            val_2.Recycle<Royal.Scenes.Game.Mechanics.Items.CupboardItem.View.CupboardItemView>(go:  this);
        }
        private void PlayCupboardAnimation(Royal.Scenes.Game.Mechanics.Items.CupboardItem.View.Animation.CupboardItemShakeAnimationData nearestShakeAnimationData)
        {
            var val_4;
            var val_6;
            var val_10;
            var val_11;
            int val_12;
            var val_13;
            int val_3 = nearestShakeAnimationData.startedFrame;
            this.shakeAnimationData = Royal.Scenes.Game.Levels.LevelContext.FrameCount;
            val_3 = val_3 >> 32;
            val_4 = null;
            val_6 = 0;
            if(Royal.Scenes.Game.Mechanics.Items.CupboardItem.View.CupboardItemView.CupboardShakeAnimation1 != val_3)
            {
                goto label_4;
            }
            
            goto label_7;
            label_4:
            val_4 = null;
            if(Royal.Scenes.Game.Mechanics.Items.CupboardItem.View.CupboardItemView.CupboardShakeAnimation2 != val_3)
            {
                goto label_10;
            }
            
            goto label_13;
            label_10:
            val_10 = null;
            if(UnityEngine.Random.value >= 0)
            {
                goto label_14;
            }
            
            val_11 = null;
            label_13:
            val_12 = 1152921505104187396;
            goto label_17;
            label_14:
            val_13 = null;
            label_7:
            val_12 = 1152921505104187400;
            label_17:
            mem[1152921520377981820] = val_12;
            this.cupboardAnimator.Play(stateNameHash:  val_12, layer:  0, normalizedTime:  0f);
        }
        private void PlayPlateAnimation(int index)
        {
            if((index - 1) > 9)
            {
                    return;
            }
            
            var val_7 = 36597156 + ((index - 1)) << 2;
            val_7 = val_7 + 36597156;
            goto (36597156 + ((index - 1)) << 2 + 36597156);
        }
        public override UnityEngine.Vector3 GetMasterViewCenterPosition()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  0.5f);
            return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        }
        public override bool IsReverseSorted()
        {
            return true;
        }
        public CupboardItemView()
        {
        
        }
        private static CupboardItemView()
        {
            int val_1 = UnityEngine.Animator.StringToHash(name:  "Base Layer.CupboardIdleAnimation");
            Royal.Scenes.Game.Mechanics.Items.CupboardItem.View.CupboardItemView.CupboardIdleAnimation = val_1;
            Royal.Scenes.Game.Mechanics.Items.CupboardItem.View.CupboardItemView.CupboardShakeAnimation1 = UnityEngine.Animator.StringToHash(name:  val_1);
            Royal.Scenes.Game.Mechanics.Items.CupboardItem.View.CupboardItemView.CupboardShakeAnimation2 = UnityEngine.Animator.StringToHash(name:  "Base Layer.CupboardShakeAnimation2");
            Royal.Scenes.Game.Mechanics.Items.CupboardItem.View.CupboardItemView.PlateAnimation1 = UnityEngine.Animator.StringToHash(name:  "Base Layer.PlateAnimation1");
            Royal.Scenes.Game.Mechanics.Items.CupboardItem.View.CupboardItemView.PlateAnimation2 = UnityEngine.Animator.StringToHash(name:  "Base Layer.PlateAnimation2");
            Royal.Scenes.Game.Mechanics.Items.CupboardItem.View.CupboardItemView.PlateAnimation3 = UnityEngine.Animator.StringToHash(name:  "Base Layer.PlateAnimation3");
            Royal.Scenes.Game.Mechanics.Items.CupboardItem.View.CupboardItemView.PlateAnimation4 = UnityEngine.Animator.StringToHash(name:  "Base Layer.PlateAnimation4");
            Royal.Scenes.Game.Mechanics.Items.CupboardItem.View.CupboardItemView.PlateAnimation5 = UnityEngine.Animator.StringToHash(name:  "Base Layer.PlateAnimation5");
        }
    
    }

}
