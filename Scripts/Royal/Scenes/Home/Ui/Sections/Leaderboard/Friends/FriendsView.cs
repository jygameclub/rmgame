using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Leaderboard.Friends
{
    public class FriendsView : MonoBehaviour
    {
        // Fields
        public Royal.Scenes.Home.Ui.Sections.Leaderboard.Friends.FriendsScrollView scrollView;
        private Royal.Scenes.Home.Ui.Sections.Leaderboard.Friends.FacebookConnectView facebookConnectView;
        private Royal.Scenes.Home.Ui.Sections.Leaderboard.LeaderboardSection leaderboardSection;
        private Royal.Infrastructure.Contexts.Units.CameraManager cameraManager;
        private Royal.Infrastructure.Services.Login.LoginService loginService;
        private Royal.Player.Context.Units.LeaderboardManager leaderboardManager;
        
        // Methods
        private void Awake()
        {
            this.leaderboardSection = this.GetComponentInParent<Royal.Scenes.Home.Ui.Sections.Leaderboard.LeaderboardSection>();
            this.cameraManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            this.loginService = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Login.LoginService>(id:  20);
            Royal.Player.Context.Units.LeaderboardManager val_4 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LeaderboardManager>(id:  6);
            this.leaderboardManager = val_4;
            val_4.add_OnLeaderboardUpdated(value:  new System.Action(object:  this, method:  public System.Void Royal.Scenes.Home.Ui.Sections.Leaderboard.Friends.FriendsView::PrepareLeaderboard()));
            this.loginService.add_OnLoginChange(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Leaderboard.Friends.FriendsView::OnLoginChange()));
        }
        private void ArrangeScrollSize()
        {
            float val_9 = this.leaderboardSection.GetBottomYOfTabButtons();
            val_9 = val_9 - this.leaderboardSection.TopYPositionOfBottomUi();
            this.scrollView.SetSize(width:  this.cameraManager.cameraWidth, height:  val_9);
            UnityEngine.Vector3 val_5 = this.leaderboardSection.transform.position;
            float val_10 = -0.5f;
            val_10 = val_9 * val_10;
            val_10 = this.leaderboardSection.GetBottomYOfTabButtons() + val_10;
            UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  val_5.x, y:  val_10);
            UnityEngine.Vector3 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y});
            this.scrollView.transform.position = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        }
        public void Enable(bool enable)
        {
            this.gameObject.SetActive(value:  enable);
            if(enable == false)
            {
                    return;
            }
            
            this.ArrangeScrollSize();
            if((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.IsConnectedFacebook()) != false)
            {
                    this.scrollView.PrepareContent();
                return;
            }
            
            this.CreateFacebookConnectView();
        }
        public void PrepareLeaderboard()
        {
            if((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.IsConnectedFacebook()) == false)
            {
                    return;
            }
            
            this.scrollView.PrepareContent();
        }
        public void LoginFacebook()
        {
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).Push(action:  new Royal.Scenes.Home.Ui.Dialogs.NoConnection.InternetConnectionAction(shouldCheckMaintenance:  true, onInternetConnection:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Leaderboard.Friends.FriendsView::<LoginFacebook>b__10_0()), onComplete:  0));
        }
        private void OnLoginChange()
        {
            if((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.IsConnectedFacebook()) != false)
            {
                    if(this.facebookConnectView == 0)
            {
                    return;
            }
            
                UnityEngine.Object.Destroy(obj:  this.facebookConnectView.gameObject);
                this.facebookConnectView = 0;
                return;
            }
            
            this.CreateFacebookConnectView();
        }
        private void CreateFacebookConnectView()
        {
            if(this.facebookConnectView != 0)
            {
                    return;
            }
            
            Royal.Scenes.Home.Ui.Sections.Leaderboard.Friends.FacebookConnectView val_4 = UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Sections.Leaderboard.Friends.FacebookConnectView>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Sections.Leaderboard.Friends.FacebookConnectView>(path:  "FacebookConnectView"), parent:  this.transform);
            this.facebookConnectView = val_4;
            val_4.Init(section:  this.leaderboardSection, friendsView:  this);
        }
        private void OnDestroy()
        {
            this.loginService.remove_OnLoginChange(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Leaderboard.Friends.FriendsView::OnLoginChange()));
            this.leaderboardManager.remove_OnLeaderboardUpdated(value:  new System.Action(object:  this, method:  public System.Void Royal.Scenes.Home.Ui.Sections.Leaderboard.Friends.FriendsView::PrepareLeaderboard()));
        }
        public FriendsView()
        {
        
        }
        private void <LoginFacebook>b__10_0()
        {
            if(this.loginService != null)
            {
                    this.loginService.ConnectWithFacebook(origin:  1);
                return;
            }
            
            throw new NullReferenceException();
        }
    
    }

}
