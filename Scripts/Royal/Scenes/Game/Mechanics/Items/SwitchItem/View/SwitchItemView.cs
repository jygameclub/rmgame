using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SwitchItem.View
{
    public class SwitchItemView : ItemView
    {
        // Fields
        public UnityEngine.Animator viewAnimator;
        private static readonly int OpenAnimation;
        private static readonly int CloseAnimation;
        private static readonly int StartOpenAnimation;
        private static readonly int StartCloseAnimation;
        public Royal.Scenes.Game.Mechanics.Items.SwitchItem.View.ISwitchableDelegate viewDelegate;
        
        // Methods
        public override int GetPoolId()
        {
            return 119;
        }
        public override void OnSpawn()
        {
        
        }
        public override void OnRecycle()
        {
        
        }
        public void Init(Royal.Scenes.Game.Mechanics.Items.SwitchItem.View.ISwitchableDelegate theDelegate, UnityEngine.Vector3 pos)
        {
            this.viewDelegate = theDelegate;
            this.PlayInitialState();
            this.InitTransform(viewDelegate:  this.viewDelegate, position:  new UnityEngine.Vector3() {x = pos.x, y = pos.y, z = pos.z});
        }
        public void RefreshState()
        {
            UnityEngine.Animator val_5;
            int val_6;
            var val_5 = 0;
            if(mem[1152921505086861312] != null)
            {
                    val_5 = val_5 + 1;
            }
            else
            {
                    var val_6 = mem[1152921505086861320];
                val_6 = val_6 + 3;
                Royal.Scenes.Game.Mechanics.Items.SwitchItem.View.ISwitchableDelegate val_1 = 1152921505086824448 + val_6;
            }
            
            if(this.viewDelegate.HasCurrentCellAboveItem() != false)
            {
                    this.PlayInitialState();
                return;
            }
            
            var val_7 = 0;
            if(mem[1152921505086861312] != null)
            {
                    val_7 = val_7 + 1;
            }
            else
            {
                    Royal.Scenes.Game.Mechanics.Items.SwitchItem.View.ISwitchableDelegate val_3 = 1152921505086824448 + ((mem[1152921505086861320]) << 4);
            }
            
            if(this.viewDelegate.GetState() != false)
            {
                    PlaySfx(type:  25, offset:  0.04f);
                val_5 = this.viewAnimator;
                val_6 = Royal.Scenes.Game.Mechanics.Items.SwitchItem.View.SwitchItemView.OpenAnimation;
            }
            else
            {
                    PlaySfx(type:  26, offset:  0.04f);
                val_5 = this.viewAnimator;
                val_6 = Royal.Scenes.Game.Mechanics.Items.SwitchItem.View.SwitchItemView.CloseAnimation;
            }
            
            val_5.Play(stateNameHash:  val_6, layer:  0, normalizedTime:  0f);
        }
        public void Explode()
        {
            PlaySfx(type:  SelectRandomClip(from:  27, to:  28), offset:  0.04f);
            Royal.Scenes.Game.Mechanics.Items.SwitchItem.View.SwitchItemExplodeParticles val_2 = Spawn<Royal.Scenes.Game.Mechanics.Items.SwitchItem.View.SwitchItemExplodeParticles>(poolId:  120, activate:  true);
            UnityEngine.Vector3 val_5 = this.transform.position;
            val_2.transform.position = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            val_2.Play();
            Royal.Scenes.Game.Mechanics.Items.SwitchItem.View.SwitchGoalView val_6 = val_2.Spawn<Royal.Scenes.Game.Mechanics.Items.SwitchItem.View.SwitchGoalView>(poolId:  121, activate:  true);
            UnityEngine.Vector3 val_9 = this.transform.position;
            val_6.transform.position = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
            val_6.Play(viewDelegate:  this.viewDelegate);
            val_6.Recycle<Royal.Scenes.Game.Mechanics.Items.SwitchItem.View.SwitchItemView>(go:  this);
        }
        public override bool IsReverseSorted()
        {
            if(W8 == 0)
            {
                    return (bool)(W8 == 0) ? 1 : 0;
            }
            
            return false;
        }
        public void RevealFromCurtain()
        {
            this.PlayInitialState();
        }
        private void PlayInitialState()
        {
            var val_3;
            var val_4;
            int val_5;
            var val_6;
            var val_3 = 0;
            if(mem[1152921505086861312] != null)
            {
                    val_3 = val_3 + 1;
            }
            else
            {
                    Royal.Scenes.Game.Mechanics.Items.SwitchItem.View.ISwitchableDelegate val_1 = 1152921505086824448 + ((mem[1152921505086861320]) << 4);
            }
            
            val_3 = null;
            if(this.viewDelegate.GetState() == false)
            {
                goto label_6;
            }
            
            val_4 = null;
            val_5 = 1152921505087148040;
            if(this.viewAnimator != null)
            {
                goto label_9;
            }
            
            label_6:
            val_6 = null;
            val_5 = 1152921505087148044;
            label_9:
            this.viewAnimator.Play(stateNameHash:  val_5, layer:  0, normalizedTime:  0f);
        }
        public SwitchItemView()
        {
        
        }
        private static SwitchItemView()
        {
            Royal.Scenes.Game.Mechanics.Items.SwitchItem.View.SwitchItemView.OpenAnimation = UnityEngine.Animator.StringToHash(name:  "Base Layer.StateOpenAnimation");
            Royal.Scenes.Game.Mechanics.Items.SwitchItem.View.SwitchItemView.CloseAnimation = UnityEngine.Animator.StringToHash(name:  "Base Layer.StateCloseAnimation");
            Royal.Scenes.Game.Mechanics.Items.SwitchItem.View.SwitchItemView.StartOpenAnimation = UnityEngine.Animator.StringToHash(name:  "Base Layer.StartOpenAnimation");
            Royal.Scenes.Game.Mechanics.Items.SwitchItem.View.SwitchItemView.StartCloseAnimation = UnityEngine.Animator.StringToHash(name:  "Base Layer.StartCloseAnimation");
        }
    
    }

}
