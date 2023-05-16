using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Leaderboard
{
    public class LeaderboardSection : Section
    {
        // Fields
        private const int FriendsState = 1;
        private const int PlayersState = 2;
        private const int TeamsState = 3;
        public UnityEngine.SpriteRenderer leaderboardTabsBackground;
        public UnityEngine.Transform leaderboardTabs;
        public Royal.Infrastructure.UiComponents.Button.UiSelectButton friendsButton;
        public Royal.Infrastructure.UiComponents.Button.UiSelectButton playersButton;
        public Royal.Infrastructure.UiComponents.Button.UiSelectButton teamsButton;
        public Royal.Infrastructure.UiComponents.UiSpinner spinner;
        private Royal.Scenes.Home.Ui.Sections.Leaderboard.Friends.FriendsView <FriendsView>k__BackingField;
        private Royal.Scenes.Home.Ui.Sections.Leaderboard.Players.PlayersView <PlayersView>k__BackingField;
        private Royal.Scenes.Home.Ui.Sections.Leaderboard.Teams.TeamsView <TeamsView>k__BackingField;
        private int currentState;
        private bool shouldFetchFromBackend;
        
        // Properties
        private Royal.Scenes.Home.Ui.Sections.Leaderboard.Friends.FriendsView FriendsView { get; set; }
        private Royal.Scenes.Home.Ui.Sections.Leaderboard.Players.PlayersView PlayersView { get; set; }
        private Royal.Scenes.Home.Ui.Sections.Leaderboard.Teams.TeamsView TeamsView { get; set; }
        
        // Methods
        private Royal.Scenes.Home.Ui.Sections.Leaderboard.Friends.FriendsView get_FriendsView()
        {
            return (Royal.Scenes.Home.Ui.Sections.Leaderboard.Friends.FriendsView)this.<FriendsView>k__BackingField;
        }
        private void set_FriendsView(Royal.Scenes.Home.Ui.Sections.Leaderboard.Friends.FriendsView value)
        {
            this.<FriendsView>k__BackingField = value;
        }
        private Royal.Scenes.Home.Ui.Sections.Leaderboard.Players.PlayersView get_PlayersView()
        {
            return (Royal.Scenes.Home.Ui.Sections.Leaderboard.Players.PlayersView)this.<PlayersView>k__BackingField;
        }
        private void set_PlayersView(Royal.Scenes.Home.Ui.Sections.Leaderboard.Players.PlayersView value)
        {
            this.<PlayersView>k__BackingField = value;
        }
        private Royal.Scenes.Home.Ui.Sections.Leaderboard.Teams.TeamsView get_TeamsView()
        {
            return (Royal.Scenes.Home.Ui.Sections.Leaderboard.Teams.TeamsView)this.<TeamsView>k__BackingField;
        }
        private void set_TeamsView(Royal.Scenes.Home.Ui.Sections.Leaderboard.Teams.TeamsView value)
        {
            this.<TeamsView>k__BackingField = value;
        }
        protected override void OnInitCompleted()
        {
            this.shouldFetchFromBackend = true;
            UnityEngine.Vector2 val_1 = 0.size;
            UnityEngine.Vector2 val_2 = this.leaderboardTabsBackground.size;
            float val_9 = -0.2f;
            val_9 = val_1.x + val_9;
            UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  val_9, y:  val_2.y);
            this.leaderboardTabsBackground.size = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
            UnityEngine.Transform val_4 = this.leaderboardTabsBackground.transform;
            UnityEngine.Vector3 val_5 = val_4.localPosition;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.right;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  0.1f);
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            val_4.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            this.currentState = 1;
            this.ArrangeViewsByState();
        }
        public override void OnActivate()
        {
            this.OnActivate();
            this.FetchLeaderboard();
        }
        private void OnApplicationPause(bool paused)
        {
            if(paused == true)
            {
                    return;
            }
            
            this.shouldFetchFromBackend = true;
            if(W8 == 0)
            {
                    return;
            }
            
            this.FetchLeaderboard();
        }
        public float GetBottomYOfTabButtons()
        {
            UnityEngine.Vector3 val_1 = this.leaderboardTabs.position;
            float val_2 = -0.83f;
            val_2 = val_1.y + val_2;
            return (float)val_2;
        }
        public void SelectFriends()
        {
            this.currentState = 1;
            this.ArrangeViewsByState();
        }
        public void SelectPlayers()
        {
            this.currentState = 2;
            this.ArrangeViewsByState();
        }
        public void SelectTeams()
        {
            this.currentState = 3;
            this.ArrangeViewsByState();
        }
        private void ArrangeViewsByState()
        {
            int val_37;
            float val_38;
            float val_39;
            float val_40;
            float val_41;
            this.friendsButton.Select(select:  (this.currentState == 1) ? 1 : 0);
            this.playersButton.Select(select:  (this.currentState == 2) ? 1 : 0);
            this.teamsButton.Select(select:  (this.currentState == 3) ? 1 : 0);
            val_37 = this.currentState;
            if(val_37 == 1)
            {
                    if((this.<FriendsView>k__BackingField) == 0)
            {
                    Royal.Scenes.Home.Ui.Sections.Leaderboard.Friends.FriendsView val_7 = UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Sections.Leaderboard.Friends.FriendsView>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Sections.Leaderboard.Friends.FriendsView>(path:  "FriendsView"), parent:  this.transform, worldPositionStays:  true);
                this.<FriendsView>k__BackingField = val_7;
                UnityEngine.Vector3 val_9 = UnityEngine.Vector3.right;
                val_38 = val_9.x;
                UnityEngine.Vector3 val_11 = this.transform.position;
                val_39 = val_38;
                val_40 = val_9.y;
                val_41 = val_9.z;
                UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_39, y = val_40, z = val_41}, d:  val_11.x);
                val_7.transform.position = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
            }
            
                val_37 = this.currentState;
            }
            
            if(val_37 == 2)
            {
                    if((this.<PlayersView>k__BackingField) == 0)
            {
                    Royal.Scenes.Home.Ui.Sections.Leaderboard.Players.PlayersView val_16 = UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Sections.Leaderboard.Players.PlayersView>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Sections.Leaderboard.Players.PlayersView>(path:  "PlayersView"), parent:  this.transform, worldPositionStays:  true);
                this.<PlayersView>k__BackingField = val_16;
                UnityEngine.Vector3 val_18 = UnityEngine.Vector3.right;
                val_38 = val_18.x;
                UnityEngine.Vector3 val_20 = this.transform.position;
                val_39 = val_38;
                val_40 = val_18.y;
                val_41 = val_18.z;
                UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_39, y = val_40, z = val_41}, d:  val_20.x);
                val_16.transform.position = new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z};
            }
            
            }
            
            if(this.currentState == 3)
            {
                    if((this.<TeamsView>k__BackingField) == 0)
            {
                    Royal.Scenes.Home.Ui.Sections.Leaderboard.Teams.TeamsView val_25 = UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Sections.Leaderboard.Teams.TeamsView>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Sections.Leaderboard.Teams.TeamsView>(path:  "TeamsView"), parent:  this.transform, worldPositionStays:  true);
                this.<TeamsView>k__BackingField = val_25;
                UnityEngine.Vector3 val_27 = UnityEngine.Vector3.right;
                val_38 = val_27.x;
                UnityEngine.Vector3 val_29 = this.transform.position;
                UnityEngine.Vector3 val_30 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_38, y = val_27.y, z = val_27.z}, d:  val_29.x);
                val_25.transform.position = new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z};
            }
            
            }
            
            if((this.<FriendsView>k__BackingField) != 0)
            {
                    this.<FriendsView>k__BackingField.Enable(enable:  (this.currentState == 1) ? 1 : 0);
            }
            
            if((this.<PlayersView>k__BackingField) != 0)
            {
                    this.<PlayersView>k__BackingField.Enable(enable:  (this.currentState == 2) ? 1 : 0);
            }
            
            if((this.<TeamsView>k__BackingField) == 0)
            {
                    return;
            }
            
            this.<TeamsView>k__BackingField.Enable(enable:  (this.currentState == 3) ? 1 : 0);
        }
        public void RefreshLeaderboards(bool friends = True, bool players = True, bool teams = True)
        {
            this.ReadLeaderboardsFromLocalDb(friends:  friends, players:  players, teams:  teams);
        }
        private void FetchLeaderboard()
        {
            if(this.shouldFetchFromBackend == false)
            {
                    return;
            }
            
            if(this.spinner.IsActive() != false)
            {
                    return;
            }
            
            this.spinner.Show();
            Royal.Infrastructure.Services.Backend.Http.Command.Commands val_3 = new Royal.Infrastructure.Services.Backend.Http.Command.Commands();
            val_3.Add(httpCommand:  new Royal.Infrastructure.Services.Backend.Http.Command.LeaderboardHttpCommand());
            val_3.add_OnComplete(value:  new Commands.ConnectionComplete(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Leaderboard.LeaderboardSection::LeaderboardReceived(bool isSuccess, Royal.Infrastructure.Services.Backend.Http.Command.Commands container)));
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.BackendHttpService>(id:  7).SendImmediately(commandsToSend:  val_3, timeOut:  10f);
        }
        private void LeaderboardReceived(bool isSuccess, Royal.Infrastructure.Services.Backend.Http.Command.Commands container)
        {
            if(this.spinner == 0)
            {
                    return;
            }
            
            this.spinner.Hide();
            if(isSuccess == false)
            {
                    return;
            }
            
            this.shouldFetchFromBackend = false;
            this.ReadLeaderboardsFromLocalDb(friends:  true, players:  true, teams:  true);
        }
        private void ReadLeaderboardsFromLocalDb(bool friends, bool players, bool teams)
        {
            bool val_4 = players;
            if(friends != false)
            {
                    if((this.<FriendsView>k__BackingField) != 0)
            {
                    this.<FriendsView>k__BackingField.PrepareLeaderboard();
            }
            
            }
            
            if(val_4 != false)
            {
                    val_4 = this.<PlayersView>k__BackingField;
                if(val_4 != 0)
            {
                    this.<PlayersView>k__BackingField.UpdateLeaderboards();
            }
            
            }
            
            if(teams == false)
            {
                    return;
            }
            
            if((this.<TeamsView>k__BackingField) == 0)
            {
                    return;
            }
            
            this.<TeamsView>k__BackingField.UpdateLeaderboards();
        }
        public LeaderboardSection()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
