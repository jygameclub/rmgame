using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Leaderboard.Players
{
    public class PlayersView : ALeaderboardView
    {
        // Fields
        public Royal.Scenes.Home.Ui.Sections.Leaderboard.Players.MyPlayerRowView myPlayer;
        
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
            
            this.myPlayer.UpdateView(leaderboardRowData:  data);
            UnityEngine.GameObject val_3 = this.myPlayer.gameObject;
            val_6 = (~willScrollToBottom) & 1;
            goto label_9;
            label_0:
            label_3:
            mem2[0] = 0;
            val_6 = 0;
            label_9:
            this.myPlayer.gameObject.SetActive(value:  false);
        }
        protected override void PrepareScrollContent()
        {
            System.Collections.Generic.List<Royal.Infrastructure.Services.Storage.Tables.Leader> val_1 = Royal.Infrastructure.Services.Storage.Tables.UserLeaderboard.GetLeaderboard(type:  3);
            System.Collections.Generic.List<Royal.Infrastructure.Services.Storage.Tables.Leader> val_2 = Royal.Infrastructure.Services.Storage.Tables.AppLeaderboard.GetLeaderboard(type:  4);
            goto typeof(Royal.Scenes.Home.Ui.Sections.Leaderboard.Players.PlayersView).__il2cppRuntimeField_170;
        }
        public PlayersView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
