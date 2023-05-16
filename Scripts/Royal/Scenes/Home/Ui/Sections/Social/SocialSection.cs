using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Social
{
    public class SocialSection : Section
    {
        // Fields
        private const int NoTeam = 1;
        private const int MyTeam = 2;
        private const int ReachLevel21 = 3;
        private const int JoinTeam = 4;
        public UnityEngine.SpriteRenderer noTeamBackground;
        public TMPro.TextMeshPro sectionBarTitle;
        public Royal.Infrastructure.UiComponents.Button.UiSelectButton joinButton;
        public Royal.Infrastructure.UiComponents.Button.UiSelectButton searchButton;
        public Royal.Infrastructure.UiComponents.Button.UiSelectButton createButton;
        private Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatView <ChatView>k__BackingField;
        private Royal.Scenes.Home.Ui.Sections.Social.NoTeam.SearchTeamView <SearchTeamView>k__BackingField;
        private Royal.Scenes.Home.Ui.Sections.Social.NoTeam.CreateTeamView <CreateTeamView>k__BackingField;
        public UnityEngine.GameObject noTeamsTab;
        public UnityEngine.GameObject socialSectionTitle;
        public UnityEngine.GameObject socialSettings;
        public Royal.Scenes.Home.Ui.Sections.Social.JoinTeam.JoinTeamPanel joinTeamPanel;
        public Royal.Scenes.Home.Ui.Sections.Social.NoTeam.TeamListScroll suggestList;
        public Royal.Scenes.Home.Ui.Sections.Social.NoTeam.TeamListScroll searchList;
        public Royal.Scenes.Home.Ui.Sections.Social.MyTeam.SocialNotification notification;
        private Royal.Scenes.Home.Ui.Sections.Social.NoTeam.SuggestTeamView suggestTeamView;
        private int state;
        private Royal.Player.Context.Units.SocialManager socialManager;
        
        // Properties
        public Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatView ChatView { get; set; }
        public Royal.Scenes.Home.Ui.Sections.Social.NoTeam.SearchTeamView SearchTeamView { get; set; }
        public Royal.Scenes.Home.Ui.Sections.Social.NoTeam.CreateTeamView CreateTeamView { get; set; }
        
        // Methods
        public Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatView get_ChatView()
        {
            return (Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatView)this.<ChatView>k__BackingField;
        }
        private void set_ChatView(Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatView value)
        {
            this.<ChatView>k__BackingField = value;
        }
        public Royal.Scenes.Home.Ui.Sections.Social.NoTeam.SearchTeamView get_SearchTeamView()
        {
            return (Royal.Scenes.Home.Ui.Sections.Social.NoTeam.SearchTeamView)this.<SearchTeamView>k__BackingField;
        }
        private void set_SearchTeamView(Royal.Scenes.Home.Ui.Sections.Social.NoTeam.SearchTeamView value)
        {
            this.<SearchTeamView>k__BackingField = value;
        }
        public Royal.Scenes.Home.Ui.Sections.Social.NoTeam.CreateTeamView get_CreateTeamView()
        {
            return (Royal.Scenes.Home.Ui.Sections.Social.NoTeam.CreateTeamView)this.<CreateTeamView>k__BackingField;
        }
        private void set_CreateTeamView(Royal.Scenes.Home.Ui.Sections.Social.NoTeam.CreateTeamView value)
        {
            this.<CreateTeamView>k__BackingField = value;
        }
        private void Awake()
        {
            this.socialManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.SocialManager>(id:  4);
            this.ArrangeSocialSectionTitle();
            if(IsWin == false)
            {
                    return;
            }
            
            this.socialManager = 1;
        }
        protected override void OnInitCompleted()
        {
            this.OnInitCompleted();
            UnityEngine.Vector2 val_1 = 0.size;
            UnityEngine.Vector2 val_2 = this.noTeamBackground.size;
            float val_26 = -0.2f;
            val_26 = val_1.x + val_26;
            UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  val_26, y:  val_2.y);
            this.noTeamBackground.size = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
            UnityEngine.Transform val_4 = this.noTeamBackground.transform;
            UnityEngine.Vector3 val_5 = val_4.localPosition;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.left;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  0.1f);
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            val_4.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            Royal.Infrastructure.Contexts.Units.CameraManager val_9 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            float val_27 = this.BottomYPositionOfNoTeamTabsUi();
            float val_11 = this.TopYPositionOfBottomUi();
            float val_12 = val_27 - val_11;
            UnityEngine.Vector2 val_13 = new UnityEngine.Vector2(x:  val_9.cameraWidth, y:  val_12);
            this.suggestList.boxCollider.size = new UnityEngine.Vector2() {x = val_13.x, y = val_13.y};
            UnityEngine.Vector2 val_17 = new UnityEngine.Vector2(x:  0f, y:  val_27 + (val_12 * (-0.5f)));
            UnityEngine.Vector3 val_18 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_17.x, y = val_17.y});
            this.suggestList.transform.localPosition = new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z};
            float val_19 = val_27 + (-2.5f);
            val_27 = val_19 - val_11;
            UnityEngine.Vector2 val_20 = new UnityEngine.Vector2(x:  val_9.cameraWidth, y:  val_27);
            this.searchList.boxCollider.size = new UnityEngine.Vector2() {x = val_20.x, y = val_20.y};
            UnityEngine.Vector2 val_24 = new UnityEngine.Vector2(x:  0f, y:  val_19 + (val_27 * (-0.5f)));
            UnityEngine.Vector3 val_25 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_24.x, y = val_24.y});
            this.searchList.transform.localPosition = new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z};
        }
        public override void OnActivate()
        {
            this.OnActivate();
            this.notification.Highlight(highlight:  true);
            if((this.socialManager.<IsKicked>k__BackingField) == false)
            {
                    return;
            }
            
            this.socialManager = 0;
            this.notification.gameObject.SetActive(value:  false);
        }
        public override void OnDeactivate()
        {
            this.OnDeactivate();
            this.notification.Highlight(highlight:  false);
            if(((this.<SearchTeamView>k__BackingField) != 0) && ((this.<SearchTeamView>k__BackingField.queryField.m_AllowInput) != false))
            {
                    this.<SearchTeamView>k__BackingField.queryField.DeactivateInputField(clearSelection:  false);
            }
            
            if((this.<CreateTeamView>k__BackingField) == 0)
            {
                    return;
            }
            
            if((this.<CreateTeamView>k__BackingField.nameField.m_AllowInput) != true)
            {
                    if((this.<CreateTeamView>k__BackingField.descField.m_AllowInput) == false)
            {
                    return;
            }
            
            }
            
            this.<CreateTeamView>k__BackingField.descField.DeactivateInputField(clearSelection:  false);
        }
        private void ArrangeSocialSectionTitle()
        {
            bool val_1 = Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.HasTeam();
            string val_3 = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  (val_1 != true) ? "myteam" : "Teams");
            if(val_4.Length >= 1)
            {
                    var val_8 = 0;
                do
            {
                T val_7 = this.socialSectionTitle.GetComponentsInChildren<TMPro.TextMeshPro>()[val_8];
                val_8 = val_8 + 1;
            }
            while(val_8 < val_4.Length);
            
            }
            
            this.sectionBarTitle.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  (val_1 != true) ? "Team" : "Teams");
        }
        private float BottomYPositionOfNoTeamTabsUi()
        {
            UnityEngine.Vector2 val_2 = this.noTeamBackground.size;
            return (float)this.BottomYPositionOfTopUi() - val_2.y;
        }
        public void Update()
        {
            int val_1 = this.GetState();
            if(this.state == val_1)
            {
                    return;
            }
            
            this.state = val_1;
            if((val_1 - 1) > 3)
            {
                    return;
            }
            
            var val_3 = 36531276 + ((val_1 - 1)) << 2;
            val_3 = val_3 + 36531276;
            goto (36531276 + ((val_1 - 1)) << 2 + 36531276);
        }
        private int GetState()
        {
            var val_4;
            if(Royal.Player.Context.Units.SocialManager.CanJoinTeam() != false)
            {
                    if((this.socialManager.<ShouldShowTeamTutorial>k__BackingField) == false)
            {
                    return (int)((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.HasTeam()) != true) ? (1 + 1) : 1;
            }
            
                val_4 = 4;
                return (int)((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.HasTeam()) != true) ? (1 + 1) : 1;
            }
            
            val_4 = 3;
            return (int)((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.HasTeam()) != true) ? (1 + 1) : 1;
        }
        private void ShowNoTeam()
        {
            this.ArrangeSocialSectionTitle();
            this.noTeamsTab.SetActive(value:  true);
            this.socialSettings.SetActive(value:  false);
            this.joinTeamPanel.gameObject.SetActive(value:  false);
            if((this.<ChatView>k__BackingField) != 0)
            {
                    this.<ChatView>k__BackingField.CloseView();
            }
            
            this.SelectJoin();
            if((this.socialManager.<IsKicked>k__BackingField) == false)
            {
                    return;
            }
            
            this.notification.ShowMark();
        }
        private void ShowMyTeam()
        {
            this.ArrangeSocialSectionTitle();
            this.noTeamsTab.SetActive(value:  false);
            this.joinTeamPanel.gameObject.SetActive(value:  false);
            this.socialSettings.SetActive(value:  true);
            if(this.suggestTeamView != 0)
            {
                    this.suggestTeamView.Enable(enable:  false);
                UnityEngine.Object.Destroy(obj:  this.suggestTeamView.gameObject);
            }
            
            if((this.<SearchTeamView>k__BackingField) != 0)
            {
                    this.<SearchTeamView>k__BackingField.Clear();
                this.<SearchTeamView>k__BackingField.Enable(enable:  false);
                UnityEngine.Object.Destroy(obj:  this.<SearchTeamView>k__BackingField.gameObject);
            }
            
            if((this.<CreateTeamView>k__BackingField) != 0)
            {
                    this.<CreateTeamView>k__BackingField.Reset();
                UnityEngine.Object.Destroy(obj:  this.<CreateTeamView>k__BackingField.gameObject);
            }
            
            if((this.<ChatView>k__BackingField) != 0)
            {
                    this.<ChatView>k__BackingField.CloseView();
            }
            
            Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatView val_11 = UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatView>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatView>(path:  "ChatView"), parent:  this.transform, worldPositionStays:  false);
            this.<ChatView>k__BackingField = val_11;
            val_11.Init(parent:  this);
        }
        private void ShowReachLevel21()
        {
            this.ArrangeSocialSectionTitle();
            this.noTeamsTab.SetActive(value:  false);
            this.socialSettings.SetActive(value:  false);
            this.joinTeamPanel.gameObject.SetActive(value:  true);
            this.joinTeamPanel.ArrangePanel(isTutorial:  false);
        }
        private void ShowJoinTeam()
        {
            this.ArrangeSocialSectionTitle();
            this.noTeamsTab.SetActive(value:  false);
            this.socialSettings.SetActive(value:  false);
            this.joinTeamPanel.gameObject.SetActive(value:  true);
            this.joinTeamPanel.ArrangePanel(isTutorial:  true);
        }
        public void SelectJoin()
        {
            this.joinButton.Select(select:  true);
            this.searchButton.Select(select:  false);
            this.createButton.Select(select:  false);
            if((this.<SearchTeamView>k__BackingField) != 0)
            {
                    this.<SearchTeamView>k__BackingField.Enable(enable:  false);
            }
            
            if((this.<CreateTeamView>k__BackingField) != 0)
            {
                    this.<CreateTeamView>k__BackingField.Enable(enable:  false);
            }
            
            if(this.suggestTeamView == 0)
            {
                    Royal.Scenes.Home.Ui.Sections.Social.NoTeam.SuggestTeamView val_6 = UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Sections.Social.NoTeam.SuggestTeamView>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Sections.Social.NoTeam.SuggestTeamView>(path:  "SuggestTeam"), parent:  this.transform, worldPositionStays:  true);
                this.suggestTeamView = val_6;
                UnityEngine.Vector3 val_8 = UnityEngine.Vector3.right;
                UnityEngine.Vector3 val_10 = this.transform.position;
                UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, d:  val_10.x);
                val_6.transform.position = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
            }
            
            this.suggestTeamView.Enable(enable:  true);
        }
        public void SelectSearch()
        {
            this.joinButton.Select(select:  false);
            this.searchButton.Select(select:  true);
            this.createButton.Select(select:  false);
            if((this.<CreateTeamView>k__BackingField) != 0)
            {
                    this.<CreateTeamView>k__BackingField.Enable(enable:  false);
            }
            
            if(this.suggestTeamView != 0)
            {
                    this.suggestTeamView.Enable(enable:  false);
            }
            
            if((this.<SearchTeamView>k__BackingField) == 0)
            {
                    this.<SearchTeamView>k__BackingField = UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Sections.Social.NoTeam.SearchTeamView>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Sections.Social.NoTeam.SearchTeamView>(path:  "SearchTeam"), parent:  this.transform, worldPositionStays:  true);
                UnityEngine.Vector2 val_10 = new UnityEngine.Vector2(x:  0f, y:  this.BottomYPositionOfNoTeamTabsUi() + (-1f));
                UnityEngine.Vector3 val_11 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y});
                this.<SearchTeamView>k__BackingField.transform.localPosition = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
            }
            
            this.<SearchTeamView>k__BackingField.Enable(enable:  true);
        }
        public void SelectCreate()
        {
            this.joinButton.Select(select:  false);
            this.searchButton.Select(select:  false);
            this.createButton.Select(select:  true);
            if(this.suggestTeamView != 0)
            {
                    this.suggestTeamView.Enable(enable:  false);
            }
            
            if((this.<SearchTeamView>k__BackingField) != 0)
            {
                    this.<SearchTeamView>k__BackingField.Enable(enable:  false);
            }
            
            if((this.<CreateTeamView>k__BackingField) == 0)
            {
                    Royal.Scenes.Home.Ui.Sections.Social.NoTeam.CreateTeamView val_6 = UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Sections.Social.NoTeam.CreateTeamView>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Sections.Social.NoTeam.CreateTeamView>(path:  "CreateTeam"), parent:  this.transform, worldPositionStays:  false);
                this.<CreateTeamView>k__BackingField = val_6;
                val_6.SetPosition(bottomYPositionOfTopUi:  this.BottomYPositionOfNoTeamTabsUi());
            }
            
            this.<CreateTeamView>k__BackingField.Enable(enable:  true);
        }
        public SocialSection()
        {
        
        }
    
    }

}
