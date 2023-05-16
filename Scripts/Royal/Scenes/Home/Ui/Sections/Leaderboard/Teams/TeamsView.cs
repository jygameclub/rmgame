using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Leaderboard.Teams
{
    public class TeamsView : ALeaderboardView
    {
        // Fields
        public Royal.Scenes.Home.Ui.Sections.Leaderboard.Teams.MyTeamRowView myTeam;
        
        // Methods
        protected override void PrepareMyMember(Royal.Scenes.Home.Ui.Sections.Leaderboard.Friends.LeaderboardRowData data, bool willScrollToBottom = False)
        {
            var val_6;
            int val_1 = Royal.Scenes.Home.Ui.Sections.Leaderboard.AScrollView.FullVisibleRowCount();
            if(data == null)
            {
                goto label_0;
            }
            
            if(((X22 + 56) <= val_1) || (data.rank <= val_1))
            {
                goto label_3;
            }
            
            if((X22 + 48) == 0)
            {
                    return;
            }
            
            float val_2 = X22.MyScrollRowPositionInContent();
            if((X22 + 60) >= 0)
            {
                    return;
            }
            
            this.myTeam.UpdateView(leaderboardRowData:  data);
            UnityEngine.GameObject val_3 = this.myTeam.gameObject;
            val_6 = (~willScrollToBottom) & 1;
            goto label_9;
            label_0:
            label_3:
            mem2[0] = 0;
            val_6 = 0;
            label_9:
            this.myTeam.gameObject.SetActive(value:  false);
        }
        protected override void PrepareScrollContent()
        {
            System.Collections.Generic.List<Royal.Infrastructure.Services.Storage.Tables.Leader> val_1 = Royal.Infrastructure.Services.Storage.Tables.UserLeaderboard.GetLeaderboard(type:  5);
            System.Collections.Generic.List<Royal.Infrastructure.Services.Storage.Tables.Leader> val_2 = Royal.Infrastructure.Services.Storage.Tables.AppLeaderboard.GetLeaderboard(type:  6);
            goto typeof(Royal.Scenes.Home.Ui.Sections.Leaderboard.Teams.TeamsView).__il2cppRuntimeField_170;
        }
        public TeamsView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
