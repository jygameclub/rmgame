using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Leaderboard.Teams
{
    public class MyTeamRowView : TeamsRowView
    {
        // Methods
        public void PrepareForMyTeam(Royal.Scenes.Home.Ui.Sections.Leaderboard.Friends.LeaderboardRowData data)
        {
            this.UpdateView(leaderboardRowData:  data);
        }
        protected override void KeepMyViewTransform(bool keep, Royal.Scenes.Home.Ui.Sections.Leaderboard.Friends.LeaderboardRowData data)
        {
            data.scrollView = keep;
            data.scrollView = this.transform;
        }
        public MyTeamRowView()
        {
        
        }
    
    }

}
