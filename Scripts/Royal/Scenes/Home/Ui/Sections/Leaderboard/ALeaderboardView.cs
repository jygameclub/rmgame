using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Leaderboard
{
    public abstract class ALeaderboardView : MonoBehaviour
    {
        // Fields
        public Royal.Scenes.Home.Ui.Sections.Leaderboard.WorldLocalBanner worldLocalBanner;
        public UnityEngine.Transform scrollTopPosition;
        public UnityEngine.Transform bottomBanner;
        public Royal.Scenes.Home.Ui.Sections.Leaderboard.AScrollView localMembers;
        public Royal.Scenes.Home.Ui.Sections.Leaderboard.AScrollView worldMembers;
        public TMPro.TextMeshPro localName;
        public UnityEngine.GameObject topButton;
        public UnityEngine.GameObject bottomButton;
        private Royal.Infrastructure.Contexts.Units.CameraManager cameraManager;
        private Royal.Scenes.Home.Ui.Sections.Leaderboard.LeaderboardSection leaderboardSection;
        private bool isVerticalScrollDragging;
        protected Royal.Scenes.Home.Ui.Sections.Leaderboard.AScrollView selectedScroll;
        
        // Methods
        private void Awake()
        {
            this.leaderboardSection = this.GetComponentInParent<Royal.Scenes.Home.Ui.Sections.Leaderboard.LeaderboardSection>();
            this.cameraManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            Royal.Player.Context.Units.LeaderboardManager val_3 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LeaderboardManager>(id:  6);
            this.localName.text = val_3.localName;
            this.worldLocalBanner.add_onSelectWorld(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Leaderboard.ALeaderboardView::SelectWorld()));
            this.worldLocalBanner.add_onSelectLocal(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Leaderboard.ALeaderboardView::SelectLocal()));
        }
        private void Start()
        {
            this.worldLocalBanner = 1;
            this.worldLocalBanner.ArrangeViewBySelection();
            this.SelectWorld();
            this.UpdateLeaderboards();
        }
        private void Update()
        {
            var val_3;
            if(this.localMembers.verticalScroll != null)
            {
                    if(this.isVerticalScrollDragging == true)
            {
                    return;
            }
            
                val_3 = 1;
            }
            else
            {
                    bool val_1 = (this.worldMembers.verticalScroll != 0) ? 1 : 0;
                if(val_1 == ((this.isVerticalScrollDragging == true) ? 1 : 0))
            {
                    return;
            }
            
            }
            
            this.isVerticalScrollDragging = val_1;
            this.CancelInvoke();
            if(this.isVerticalScrollDragging != false)
            {
                    this.EnableTopBottomButtons(enable:  true);
                return;
            }
            
            this.Invoke(methodName:  "HideTopBottomButtons", time:  3f);
        }
        private void HideTopBottomButtons()
        {
            var val_16;
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            int val_16 = val_2.Length;
            if(val_16 >= 1)
            {
                    var val_17 = 0;
                val_16 = val_16 & 4294967295;
                do
            {
                DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  null, endValue:  0f, duration:  0.2f));
                val_17 = val_17 + 1;
            }
            while(val_17 < (val_2.Length << ));
            
            }
            
            val_16 = 1152921518957865072;
            int val_18 = val_5.Length;
            if(val_18 >= 1)
            {
                    var val_19 = 0;
                val_18 = val_18 & 4294967295;
                do
            {
                DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  DG.Tweening.ShortcutExtensionsTMPText.DOFade(target:  null, endValue:  0f, duration:  0.2f));
                val_19 = val_19 + 1;
            }
            while(val_19 < (val_5.Length << ));
            
            }
            
            int val_20 = val_8.Length;
            if(val_20 >= 1)
            {
                    var val_21 = 0;
                val_20 = val_20 & 4294967295;
                do
            {
                DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  null, endValue:  0f, duration:  0.2f));
                val_21 = val_21 + 1;
            }
            while(val_21 < (val_8.Length << ));
            
            }
            
            int val_22 = val_11.Length;
            if(val_22 >= 1)
            {
                    var val_23 = 0;
                val_22 = val_22 & 4294967295;
                do
            {
                DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  DG.Tweening.ShortcutExtensionsTMPText.DOFade(target:  null, endValue:  0f, duration:  0.2f));
                val_23 = val_23 + 1;
            }
            while(val_23 < (val_11.Length << ));
            
            }
            
            DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_1, action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Leaderboard.ALeaderboardView::<HideTopBottomButtons>b__15_0()));
        }
        private void EnableTopBottomButtons(bool enable)
        {
            float val_11;
            float val_12;
            var val_13;
            UnityEngine.GameObject val_14;
            var val_15;
            val_11 = 0.79f;
            val_12 = 1f;
            if(enable == false)
            {
                goto label_1;
            }
            
            val_13 = this.selectedScroll.verticalScroll.IsAtTop ^ 1;
            if(this.topButton != null)
            {
                goto label_4;
            }
            
            label_1:
            val_13 = 0;
            label_4:
            this.topButton.SetActive(value:  val_13 & 1);
            val_14 = this.bottomButton;
            if(enable == false)
            {
                goto label_7;
            }
            
            val_15 = this.selectedScroll.verticalScroll.IsAtBottom ^ 1;
            if(val_14 != null)
            {
                goto label_10;
            }
            
            label_7:
            val_15 = 0;
            label_10:
            val_14.SetActive(value:  val_15 & 1);
            if(val_5.Length >= 1)
            {
                    do
            {
                val_11 = 0f;
                val_12 = 0f;
                this.topButton.GetComponentsInChildren<UnityEngine.SpriteRenderer>()[0].color = new UnityEngine.Color() {r = 0f, g = val_12, b = 0f, a = val_11};
                val_14 = 0 + 1;
            }
            while(val_14 < val_5.Length);
            
            }
            
            if(val_6.Length >= 1)
            {
                    var val_12 = 0;
                do
            {
                val_14 = this.topButton.GetComponentsInChildren<TMPro.TextMeshPro>()[val_12];
                UnityEngine.Color val_7 = UnityEngine.Color.white;
                val_12 = val_12 + 1;
            }
            while(val_12 < val_6.Length);
            
            }
            
            if(val_8.Length >= 1)
            {
                    do
            {
                this.bottomButton.GetComponentsInChildren<UnityEngine.SpriteRenderer>()[0].color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
                val_14 = 0 + 1;
            }
            while(val_14 < val_8.Length);
            
            }
            
            if(val_9.Length < 1)
            {
                    return;
            }
            
            do
            {
                T val_14 = this.bottomButton.GetComponentsInChildren<TMPro.TextMeshPro>()[0];
                UnityEngine.Color val_10 = UnityEngine.Color.white;
                val_14 = 0 + 1;
            }
            while(val_14 < val_9.Length);
        
        }
        public void UpdateLeaderboards()
        {
            Royal.Player.Context.Units.LeaderboardManager val_1 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LeaderboardManager>(id:  6);
            this.localName.text = val_1.localName;
            goto typeof(Royal.Scenes.Home.Ui.Sections.Leaderboard.ALeaderboardView).__il2cppRuntimeField_170;
        }
        public void Enable(bool enable)
        {
            this.gameObject.SetActive(value:  enable);
            if(enable == false)
            {
                    return;
            }
            
            this.ArrangeScrollSize();
            this.localMembers.AutoScroll(toTop:  true, animate:  false);
            this.worldMembers.AutoScroll(toTop:  true, animate:  false);
            if(this.selectedScroll == 0)
            {
                    return;
            }
            
            this = ???;
            goto typeof(Royal.Scenes.Home.Ui.Sections.Leaderboard.ALeaderboardView).__il2cppRuntimeField_170;
        }
        private void ArrangeScrollSize()
        {
            UnityEngine.Vector3 val_3 = this.leaderboardSection.transform.position;
            float val_23 = -0.052599f;
            UnityEngine.Vector2 val_5;
            val_23 = this.leaderboardSection.GetBottomYOfTabButtons() + val_23;
            val_5 = new UnityEngine.Vector2(x:  val_3.x, y:  val_23);
            UnityEngine.Vector3 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y});
            this.worldLocalBanner.transform.position = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            UnityEngine.Vector3 val_8 = this.bottomBanner.transform.position;
            this.bottomBanner.transform.position = new UnityEngine.Vector3() {x = val_8.x, y = this.leaderboardSection.TopYPositionOfBottomUi() + (-0.046942f), z = val_8.z};
            UnityEngine.Vector3 val_13 = this.scrollTopPosition.transform.position;
            float val_24 = val_13.y;
            UnityEngine.Vector3 val_16 = this.leaderboardSection.transform.position;
            val_24 = val_24 - this.leaderboardSection.TopYPositionOfBottomUi();
            UnityEngine.Vector3 val_17 = this.scrollTopPosition.position;
            float val_25 = -0.5f;
            val_25 = val_24 * val_25;
            val_17.y = val_17.y + val_25;
            UnityEngine.Vector2 val_18 = new UnityEngine.Vector2(x:  val_16.x, y:  val_17.y);
            this.localMembers.SetSize(width:  this.cameraManager.cameraWidth, height:  val_24);
            UnityEngine.Vector3 val_20 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_18.x, y = val_18.y});
            this.localMembers.transform.position = new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z};
            this.worldMembers.SetSize(width:  this.cameraManager.cameraWidth, height:  val_24);
            UnityEngine.Vector3 val_22 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_18.x, y = val_18.y});
            this.worldMembers.transform.position = new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z};
        }
        private void SelectLocal()
        {
            this.selectedScroll = this.localMembers;
            this.localMembers = 0;
            this.localMembers.gameObject.SetActive(value:  true);
            this.worldMembers.gameObject.SetActive(value:  false);
            this.localMembers.AutoScroll(toTop:  true, animate:  false);
            this.EnableTopBottomButtons(enable:  false);
        }
        private void SelectWorld()
        {
            this.selectedScroll = this.worldMembers;
            this.worldMembers = 0;
            this.localMembers.gameObject.SetActive(value:  false);
            this.worldMembers.gameObject.SetActive(value:  true);
            this.worldMembers.AutoScroll(toTop:  true, animate:  false);
            this.EnableTopBottomButtons(enable:  false);
        }
        public void Scroll(bool toTop)
        {
            if(toTop != false)
            {
                    this.selectedScroll = 0;
            }
            
            bool val_1 = toTop ^ 1;
            bool val_2 = val_1;
            this.selectedScroll.AutoScroll(toTop:  toTop, animate:  true);
            this.topButton.SetActive(value:  val_1);
            this.bottomButton.SetActive(value:  toTop);
            this.CancelInvoke();
            this.Invoke(methodName:  "HideTopBottomButtons", time:  3f);
        }
        public void ScrollToMyPosition()
        {
            if(this.selectedScroll != null)
            {
                    this.selectedScroll.AutoScrollToMyPosition();
                return;
            }
            
            throw new NullReferenceException();
        }
        protected abstract void PrepareMyMember(Royal.Scenes.Home.Ui.Sections.Leaderboard.Friends.LeaderboardRowData data, bool willScrollToBottom = False); // 0
        protected abstract void PrepareScrollContent(); // 0
        protected ALeaderboardView()
        {
        
        }
        private void <HideTopBottomButtons>b__15_0()
        {
            this.EnableTopBottomButtons(enable:  false);
        }
    
    }

}
