using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Social.Chat
{
    public abstract class ChatScrollItemModel
    {
        // Fields
        public UnityEngine.Transform parent;
        public readonly long userId;
        public readonly long createDate;
        public readonly string userName;
        public readonly bool isMe;
        public Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatItemSortType itemSortType;
        public Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatItemPositionType itemPositionType;
        public float size;
        public Royal.Player.Context.Units.SocialManager socialManager;
        private UnityEngine.Vector3 localScale;
        private UnityEngine.Vector3 localPosition;
        public bool hasView;
        public bool isFake;
        private DG.Tweening.Sequence animationSequence;
        private System.Collections.Generic.List<DG.Tweening.Sequence> appendedSequences;
        
        // Properties
        public abstract Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatScrollItemView View { get; }
        public UnityEngine.Vector3 LocalScale { get; set; }
        public UnityEngine.Vector3 LocalPosition { get; set; }
        
        // Methods
        public abstract Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatScrollItemView get_View(); // 0
        public UnityEngine.Vector3 get_LocalScale()
        {
            return new UnityEngine.Vector3() {x = this.localScale};
        }
        public void set_LocalScale(UnityEngine.Vector3 value)
        {
            this.localScale = value;
            mem[1152921519016331772] = value.y;
            mem[1152921519016331776] = value.z;
            if(this.hasView == false)
            {
                    return;
            }
            
            this.transform.localScale = new UnityEngine.Vector3() {x = this.localScale, y = value.y, z = value.z};
        }
        public UnityEngine.Vector3 get_LocalPosition()
        {
            return new UnityEngine.Vector3() {x = this.localPosition};
        }
        public void set_LocalPosition(UnityEngine.Vector3 value)
        {
            this.localPosition = value;
            mem[1152921519016563976] = value.y;
            mem[1152921519016563980] = value.z;
            if(this.hasView == false)
            {
                    return;
            }
            
            this.transform.localPosition = new UnityEngine.Vector3() {x = this.localPosition, y = value.y, z = value.z};
        }
        public ChatScrollItemModel(UnityEngine.Transform parent, long userId, string userName, long createDate)
        {
            val_1 = new System.Object();
            this.parent = parent;
            this.userId = userId;
            this.createDate = createDate;
            this.userName = val_1;
            bool val_2 = Royal.Player.Context.Data.UserId.__il2cppRuntimeField_name.Equals(obj:  userId);
            Royal.Player.Context.Data.UserId.__il2cppRuntimeField_name = val_2;
            this.isMe = Royal.Player.Context.Data.UserId.__il2cppRuntimeField_name;
            this.itemPositionType = (val_2 != true) ? (1 + 1) : 1;
            this.socialManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.SocialManager>(id:  4);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
            this.LocalPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
            this.LocalScale = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        }
        public void SetLogicPosition(UnityEngine.Vector3 logicPos)
        {
            this.localPosition = logicPos;
            mem[1152921519016816648] = logicPos.y;
            mem[1152921519016816652] = logicPos.z;
        }
        public virtual bool RemoveOnChatDisabled()
        {
            return true;
        }
        public virtual void Show()
        {
            this.hasView = true;
            this.transform.localPosition = new UnityEngine.Vector3() {x = this.localPosition};
            this.transform.localScale = new UnityEngine.Vector3() {x = this.localScale};
        }
        public virtual void Hide()
        {
            this.hasView = false;
            this.SetSequence(animationSeq:  0);
        }
        public void SetSequence(DG.Tweening.Sequence animationSeq)
        {
            var val_1;
            bool val_1 = true;
            if(this.animationSequence != null)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  this.animationSequence, complete:  false);
                this.animationSequence = 0;
            }
            
            if(this.appendedSequences == null)
            {
                goto label_2;
            }
            
            val_1 = 0;
            label_5:
            if(val_1 >= val_1)
            {
                goto label_3;
            }
            
            val_1 = val_1 & 4294967295;
            if(val_1 >= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + 0;
            DG.Tweening.TweenExtensions.Kill(t:  ((true & 4294967295) + 0) + 32, complete:  false);
            val_1 = val_1 + 1;
            if(this.appendedSequences != null)
            {
                goto label_5;
            }
            
            throw new NullReferenceException();
            label_3:
            this.appendedSequences = 0;
            label_2:
            this.animationSequence = animationSeq;
        }
        public void AppendToSequence(DG.Tweening.Sequence tween)
        {
            System.Collections.Generic.List<DG.Tweening.Sequence> val_6;
            if(this.animationSequence != null)
            {
                    if((DG.Tweening.TweenExtensions.IsComplete(t:  this.animationSequence)) == false)
            {
                goto label_2;
            }
            
            }
            
            this.SetSequence(animationSeq:  DG.Tweening.TweenSettingsExtensions.Append(s:  DG.Tweening.DOTween.Sequence(), t:  tween));
            return;
            label_2:
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.animationSequence, t:  tween);
            val_6 = this.appendedSequences;
            if(val_6 == null)
            {
                    System.Collections.Generic.List<DG.Tweening.Sequence> val_5 = null;
                val_6 = val_5;
                val_5 = new System.Collections.Generic.List<DG.Tweening.Sequence>();
                this.appendedSequences = val_6;
            }
            
            val_5.Add(item:  tween);
        }
        public void KillSequence()
        {
            this.SetSequence(animationSeq:  0);
        }
    
    }

}
