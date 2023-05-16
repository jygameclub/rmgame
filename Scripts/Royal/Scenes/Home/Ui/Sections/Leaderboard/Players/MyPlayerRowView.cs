using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Leaderboard.Players
{
    public class MyPlayerRowView : PlayersRowView
    {
        // Methods
        public void PrepareForMyPlayer(Royal.Scenes.Home.Ui.Sections.Leaderboard.Friends.LeaderboardRowData leaderboardRowData)
        {
            this.UpdateView(leaderboardRowData:  leaderboardRowData);
        }
        protected override void KeepMyViewTransform(bool keep, Royal.Scenes.Home.Ui.Sections.Leaderboard.Friends.LeaderboardRowData data)
        {
            data.scrollView = keep;
            data.scrollView = this.transform;
        }
        public MyPlayerRowView()
        {
        
        }
    
    }

}
