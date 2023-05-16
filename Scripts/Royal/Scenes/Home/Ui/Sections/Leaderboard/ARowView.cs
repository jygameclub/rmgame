using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Leaderboard
{
    public abstract class ARowView : UiScrollContentItem
    {
        // Fields
        public UnityEngine.SpriteRenderer[] backgrounds;
        public UnityEngine.SpriteRenderer medal;
        public UnityEngine.Sprite[] backgroundSprites;
        public UnityEngine.Sprite[] medalSprites;
        public TMPro.TextMeshPro rank;
        public TMPro.TextMeshPro teamName;
        public Royal.Scenes.Home.Ui.Sections.Social.Logo.TeamLogoView teamLogoView;
        public Royal.Infrastructure.UiComponents.Button.UiScrollButton scrollButton;
        private const float DefaultMaxFontSize = 5.75;
        private const float SmallMaxFontSize = 5;
        protected static readonly UnityEngine.Color MyColor;
        protected static readonly UnityEngine.Color OtherColor;
        protected static readonly UnityEngine.Color MyLabelColor;
        protected static readonly UnityEngine.Color OtherLabelColor;
        
        // Methods
        protected static void UpdateFontSize(bool shouldDecrease, TMPro.TextMeshPro tmp)
        {
            if(tmp != null)
            {
                    tmp.fontSizeMax = (shouldDecrease != true) ? 5f : 5.75f;
                return;
            }
            
            throw new NullReferenceException();
        }
        protected virtual void KeepMyViewTransform(bool keep, Royal.Scenes.Home.Ui.Sections.Leaderboard.Friends.LeaderboardRowData data)
        {
            data.scrollView = keep;
            data.scrollView = this.transform;
        }
        protected void SetScrollButtonScaleDown(bool enable)
        {
            if(this.scrollButton == 0)
            {
                    return;
            }
            
            this.scrollButton = enable;
        }
        protected ARowView()
        {
        
        }
        private static ARowView()
        {
            Royal.Scenes.Home.Ui.Sections.Leaderboard.ARowView.MyColor = 0;
            Royal.Scenes.Home.Ui.Sections.Leaderboard.ARowView.OtherColor = 0;
            Royal.Scenes.Home.Ui.Sections.Leaderboard.ARowView.MyLabelColor = 0;
            Royal.Scenes.Home.Ui.Sections.Leaderboard.ARowView.OtherLabelColor = 0;
        }
    
    }

}
