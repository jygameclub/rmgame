using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Leaderboard.Teams
{
    public class TeamsRowView : ARowView
    {
        // Fields
        public UnityEngine.SpriteRenderer[] capacityBackgrounds;
        public UnityEngine.Sprite[] capacityBackgroundSprites;
        public TMPro.TextMeshPro score;
        public TMPro.TextMeshPro capacity;
        public TMPro.TextMeshPro scoreLabel;
        public long teamId;
        
        // Methods
        public override void Prepare(Royal.Infrastructure.UiComponents.Scroll.Content.IUiScrollContentData data, UnityEngine.Bounds maskBounds)
        {
            this.UpdateView(leaderboardRowData:  data);
        }
        public void UpdateView(Royal.Scenes.Home.Ui.Sections.Leaderboard.Friends.LeaderboardRowData leaderboardRowData)
        {
            var val_6;
            var val_8;
            byte val_9;
            this.KeepMyViewTransform(keep:  true, data:  leaderboardRowData);
            var val_6 = 0;
            do
            {
                Royal.Scenes.Home.Ui.Sections.Leaderboard.Teams.TeamsRowView.__il2cppRuntimeField_byval_arg.sprite = Royal.Scenes.Home.Ui.Sections.Leaderboard.Teams.__il2cppRuntimeField_28;
                val_6 = val_6 + 1;
            }
            while(null != null);
            
            this.KeepMyViewTransform(keep:  false, data:  leaderboardRowData);
            var val_7 = 0;
            do
            {
                Royal.Scenes.Home.Ui.Sections.Leaderboard.Teams.TeamsRowView.__il2cppRuntimeField_byval_arg.sprite = Royal.Scenes.Home.Ui.Sections.Leaderboard.Teams.__il2cppRuntimeField_20;
                val_7 = val_7 + 1;
            }
            while(null != null);
            
            var val_10 = 0;
            label_29:
            if(val_10 >= this.capacityBackgrounds.Length)
            {
                goto label_24;
            }
            
            this.capacityBackgrounds[val_10].sprite = this.capacityBackgroundSprites[1];
            val_10 = val_10 + 1;
            if(this.capacityBackgrounds != null)
            {
                goto label_29;
            }
            
            var val_13 = 0;
            label_37:
            if(val_13 >= this.capacityBackgrounds.Length)
            {
                goto label_32;
            }
            
            this.capacityBackgrounds[val_13].sprite = this.capacityBackgroundSprites[0];
            val_13 = val_13 + 1;
            if(this.capacityBackgrounds != null)
            {
                goto label_37;
            }
            
            label_24:
            val_6 = null;
            val_6 = null;
            goto label_43;
            label_32:
            val_8 = null;
            val_8 = null;
            label_43:
            this.scoreLabel.color = new UnityEngine.Color() {r = Royal.Scenes.Home.Ui.Sections.Leaderboard.ARowView.OtherLabelColor, g = Royal.Scenes.Home.Ui.Sections.Leaderboard.ARowView.MyColor.__il2cppRuntimeField_34, b = Royal.Scenes.Home.Ui.Sections.Leaderboard.ARowView.MyColor.__il2cppRuntimeField_38, a = Royal.Scenes.Home.Ui.Sections.Leaderboard.ARowView.MyColor.__il2cppRuntimeField_3C};
            this.SetRank(newRank:  leaderboardRowData.rank);
            this.score.text = Royal.Scenes.Home.Ui.Sections.Leaderboard.ARowView.__il2cppRuntimeField_static_fields.ToString();
            string val_2 = null + "/50"("/50");
            this.capacity.text = val_2;
            this.capacity.text = val_2;
            this.capacity.InitById(logoId:  val_2);
            val_9 = leaderboardRowData.shouldDecreaseTeamSize;
            if(val_9 == 0)
            {
                    byte val_3 = Royal.Scenes.Home.Ui.Sections.Leaderboard.Friends.LeaderboardRowData.ShouldDecreaseFontSize(text:  this.capacity);
                val_9 = val_3;
                leaderboardRowData = val_3;
            }
            
            byte val_4 = val_9 & 255;
            fontSizeMax = (val_4 == 2) ? 5f : 5.75f;
            this.teamId = val_4;
        }
        protected void SetRank(int newRank)
        {
            if(newRank <= 3)
            {
                    this.enabled = false;
                this.enabled = true;
                var val_2 = X8 + ((newRank - 1) << 3);
                this.sprite = (X8 + ((newRank - 1)) << 3) + 32;
                return;
            }
            
            this.enabled = true;
            this.enabled = false;
            string val_3 = newRank.ToString();
        }
        public void ShowAction()
        {
            Royal.Scenes.Home.Ui.Dialogs.ViewTeam.ViewTeamButton.ToggleViewTeamButton(teamId:  this.teamId, parent:  this.transform, xPosition:  -3.04f, bottomOffset:  5.5f);
        }
        public TeamsRowView()
        {
            this = new Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem();
        }
    
    }

}
