using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Leaderboard.Friends
{
    public class LeaderboardRowData : IUiScrollContentData
    {
        // Fields
        public readonly int rank;
        public readonly Royal.Infrastructure.Services.Storage.Tables.Leader leader;
        public readonly Royal.Scenes.Home.Ui.Sections.Leaderboard.AScrollView scrollView;
        private byte shouldDecreaseNameSize;
        private byte shouldDecreaseTeamSize;
        
        // Methods
        public LeaderboardRowData(int rank, Royal.Infrastructure.Services.Storage.Tables.Leader leader, Royal.Scenes.Home.Ui.Sections.Leaderboard.AScrollView scrollView)
        {
            this.rank = rank;
            this.scrollView = scrollView;
        }
        public bool IsUser(long userId)
        {
            return (bool)(X8 == userId) ? 1 : 0;
        }
        public bool IsTeam(long teamId)
        {
            return (bool)(X8 == teamId) ? 1 : 0;
        }
        public bool ShouldDecreaseNameSize()
        {
            if(this.shouldDecreaseNameSize != 0)
            {
                    return (bool)((val_1 & 255) == 2) ? 1 : 0;
            }
            
            byte val_1 = Royal.Scenes.Home.Ui.Sections.Leaderboard.Friends.LeaderboardRowData.ShouldDecreaseFontSize(text:  this.shouldDecreaseNameSize = this.shouldDecreaseNameSize);
            this.shouldDecreaseNameSize = val_1;
            return (bool)((val_1 & 255) == 2) ? 1 : 0;
        }
        public bool ShouldDecreaseTeamSize()
        {
            if(this.shouldDecreaseTeamSize != 0)
            {
                    return (bool)((val_1 & 255) == 2) ? 1 : 0;
            }
            
            byte val_1 = Royal.Scenes.Home.Ui.Sections.Leaderboard.Friends.LeaderboardRowData.ShouldDecreaseFontSize(text:  this.shouldDecreaseTeamSize = this.shouldDecreaseTeamSize);
            this.shouldDecreaseTeamSize = val_1;
            return (bool)((val_1 & 255) == 2) ? 1 : 0;
        }
        private static byte ShouldDecreaseFontSize(string text)
        {
            var val_5;
            var val_6;
            if(text.m_stringLength < 1)
            {
                goto label_2;
            }
            
            val_5 = 0;
            var val_5 = 0;
            label_7:
            if((System.Char.IsLower(c:  text.Chars[0])) == false)
            {
                goto label_5;
            }
            
            val_5 = val_5 + 1;
            if(val_5 >= (((text.m_stringLength < 0) ? (text.m_stringLength + 1) : text.m_stringLength) >> 1))
            {
                goto label_6;
            }
            
            label_5:
            val_5 = val_5 + 1;
            if(val_5 < text.m_stringLength)
            {
                goto label_7;
            }
            
            label_2:
            val_6 = 2;
            return (byte)val_6;
            label_6:
            val_6 = 1;
            return (byte)val_6;
        }
    
    }

}
