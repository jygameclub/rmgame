using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View
{
    public class MailBoxItemView : ItemView
    {
        // Fields
        private static readonly int MailBoxIdleState;
        private static readonly int MailBoxPlayState;
        private static readonly int MailBoxCloseState;
        public UnityEngine.Animator animator;
        private Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View.IMailBoxItemViewDelegate itemViewDelegate;
        private float disableAnimationStartedAt;
        private const float DisableDelay = 0.24;
        private Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View.MailBoxCollectHelper collectHelper;
        private Royal.Infrastructure.Utils.Randoming.RandomManager randomManager;
        
        // Properties
        public Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View.IMailBoxItemViewDelegate ItemViewDelegate { get; }
        
        // Methods
        public Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View.IMailBoxItemViewDelegate get_ItemViewDelegate()
        {
            return (Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View.IMailBoxItemViewDelegate)this.itemViewDelegate;
        }
        public void Init(Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View.IMailBoxItemViewDelegate viewDelegate, UnityEngine.Vector3 position)
        {
            this.itemViewDelegate = viewDelegate;
            this.animator.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View.MailBoxItemView.DisableDelay, layer:  0, normalizedTime:  0f);
            this.InitTransform(viewDelegate:  viewDelegate, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
            this.collectHelper = Royal.Scenes.Game.Levels.LevelContext.GetLate<Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View.MailBoxCollectHelper>(contextId:  19);
            this.randomManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Utils.Randoming.RandomManager>(id:  5);
        }
        public override int GetPoolId()
        {
            return 48;
        }
        public override void OnSpawn()
        {
        
        }
        public override void OnRecycle()
        {
            this.itemViewDelegate = 0;
            this.disableAnimationStartedAt = 0f;
            this.collectHelper = 0;
        }
        public void Explode()
        {
            23767.PlaySfx(type:  178, offset:  0.04f);
            this.animator.speed = 1.1f;
            this.animator.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View.MailBoxItemView.MailBoxPlayState, layer:  0, normalizedTime:  0f);
            this.animator.Update(deltaTime:  UnityEngine.Time.deltaTime);
            .itemView = this;
            this.collectHelper.Collect(mailCollectData:  new Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View.MailCollectData());
        }
        public void CollectAnimationCompleted()
        {
            var val_2 = 0;
            if(mem[1152921505098735616] != null)
            {
                    val_2 = val_2 + 1;
            }
            else
            {
                    Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View.IMailBoxItemViewDelegate val_1 = 1152921505098698752 + ((mem[1152921505098735624]) << 4);
            }
            
            this.itemViewDelegate.OnGoalReached();
        }
        public void ChangeToDisabledView()
        {
            this.disableAnimationStartedAt = Royal.Scenes.Game.Levels.LevelContext.Time;
            this.Invoke(methodName:  "DisableDelayed", time:  0.24f);
        }
        private void DisableDelayed()
        {
            this.Invoke(methodName:  "PlayMailboxCloseSound", time:  0.25f);
            this.animator.speed = 1f;
            this.animator.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View.MailBoxItemView.MailBoxCloseState, layer:  0, normalizedTime:  0f);
        }
        private void PlayMailboxCloseSound()
        {
            if(this != null)
            {
                    this.PlaySfx(type:  177, offset:  0.04f);
                return;
            }
            
            throw new NullReferenceException();
        }
        public bool CanPlayCollectAnimation()
        {
            var val_4;
            if((Royal.Infrastructure.Utils.Math.NumberExtensions.Approximately(a:  this.disableAnimationStartedAt, b:  0f, precision:  0.001f)) != false)
            {
                    val_4 = 1;
                return (bool)(val_2 < 0) ? 1 : 0;
            }
            
            float val_2 = Royal.Scenes.Game.Levels.LevelContext.Time;
            val_2 = val_2 - this.disableAnimationStartedAt;
            return (bool)(val_2 < 0) ? 1 : 0;
        }
        public override bool IsReverseSorted()
        {
            if(W8 == 0)
            {
                    return (bool)(W8 == 0) ? 1 : 0;
            }
            
            return false;
        }
        public MailBoxItemView()
        {
        
        }
        private static MailBoxItemView()
        {
            Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View.MailBoxItemView.DisableDelay = UnityEngine.Animator.StringToHash(name:  "Base Layer.mailbox_idle");
            Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View.MailBoxItemView.MailBoxPlayState = UnityEngine.Animator.StringToHash(name:  "Base Layer.mailbox_acik");
            Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View.MailBoxItemView.MailBoxCloseState = UnityEngine.Animator.StringToHash(name:  "Base Layer.mailbox_kapali");
        }
    
    }

}
