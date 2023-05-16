using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Leaderboard.Friends
{
    public class FriendsRowView : ARowView
    {
        // Fields
        public UnityEngine.SpriteRenderer[] leagueContainers;
        public UnityEngine.Sprite[] leagueContainerSprites;
        public UnityEngine.Sprite[] goldFrames;
        public UnityEngine.SpriteRenderer[] frameRenderers;
        public UnityEngine.ParticleSystem goldParticles;
        public Royal.Scenes.Home.Ui.Dialogs.RoyalPass.GoldNickName goldNickName;
        public TMPro.TextMeshPro levelLabel;
        public TMPro.TextMeshPro levelNo;
        public TMPro.TextMeshPro leagueLevelNo;
        public UnityEngine.GameObject leagueContainer;
        public UnityEngine.SpriteRenderer profilePicture;
        private static readonly UnityEngine.Vector3 UserNameWithTeamPosition;
        private static readonly UnityEngine.Vector3 UserNameWithNoTeamPosition;
        public long facebookId;
        private long teamId;
        private Royal.Infrastructure.Services.Login.LoginService loginService;
        
        // Methods
        public void Awake()
        {
            this.loginService = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Login.LoginService>(id:  20);
        }
        public override void Prepare(Royal.Infrastructure.UiComponents.Scroll.Content.IUiScrollContentData data, UnityEngine.Bounds maskBounds)
        {
            this.UpdateData(leaderboardRowData:  data);
            this.LoadProfilePicture();
        }
        public void UpdateData(Royal.Scenes.Home.Ui.Sections.Leaderboard.Friends.LeaderboardRowData leaderboardRowData)
        {
            int val_12;
            var val_13;
            UnityEngine.Color val_14;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            this.facebookId = true;
            this.teamId = true;
            this.SetRank(newRank:  leaderboardRowData.rank);
            string val_1 = true.ToString();
            this.levelNo.text = val_1;
            this.levelNo.text = val_1;
            if(null >= 1)
            {
                    this.leagueContainer.SetActive(value:  true);
                this.leagueLevelNo.text = null.ToString();
            }
            else
            {
                    this.leagueContainer.SetActive(value:  false);
            }
            
            var val_12 = 0;
            label_18:
            if(val_12 >= (Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.<BasicData>k__BackingField))
            {
                goto label_13;
            }
            
            sprite = typeof(Royal.Player.Context.Data.Persistent.BasicUserData).__il2cppRuntimeField_28;
            val_12 = val_12 + 1;
            if((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField) != null)
            {
                goto label_18;
            }
            
            var val_13 = 0;
            label_26:
            if(val_13 >= (Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.<BasicData>k__BackingField))
            {
                goto label_21;
            }
            
            sprite = Royal.Player.Context.Data.Persistent.BasicUserData.__il2cppRuntimeField_byval_arg;
            val_13 = val_13 + 1;
            if((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField) != null)
            {
                goto label_26;
            }
            
            label_13:
            var val_16 = 0;
            label_34:
            if(val_16 >= this.leagueContainers.Length)
            {
                goto label_29;
            }
            
            this.leagueContainers[val_16].sprite = this.leagueContainerSprites[1];
            val_16 = val_16 + 1;
            if(this.leagueContainers != null)
            {
                goto label_34;
            }
            
            label_21:
            var val_19 = 0;
            label_42:
            if(val_19 >= this.leagueContainers.Length)
            {
                goto label_37;
            }
            
            this.leagueContainers[val_19].sprite = this.leagueContainerSprites[0];
            val_19 = val_19 + 1;
            if(this.leagueContainers != null)
            {
                goto label_42;
            }
            
            label_29:
            val_13 = null;
            val_13 = null;
            val_14 = Royal.Scenes.Home.Ui.Sections.Leaderboard.ARowView.MyColor;
            this.levelLabel.color = new UnityEngine.Color() {r = Royal.Scenes.Home.Ui.Sections.Leaderboard.ARowView.MyLabelColor, g = Royal.Scenes.Home.Ui.Sections.Leaderboard.ARowView.MyColor.__il2cppRuntimeField_24, b = Royal.Scenes.Home.Ui.Sections.Leaderboard.ARowView.MyColor.__il2cppRuntimeField_28, a = Royal.Scenes.Home.Ui.Sections.Leaderboard.ARowView.MyColor.__il2cppRuntimeField_2C};
            this.levelLabel.color = new UnityEngine.Color() {r = Royal.Scenes.Home.Ui.Sections.Leaderboard.ARowView.MyLabelColor, g = Royal.Scenes.Home.Ui.Sections.Leaderboard.ARowView.MyColor.__il2cppRuntimeField_24, b = Royal.Scenes.Home.Ui.Sections.Leaderboard.ARowView.MyColor.__il2cppRuntimeField_28, a = Royal.Scenes.Home.Ui.Sections.Leaderboard.ARowView.MyColor.__il2cppRuntimeField_2C};
            this.teamId = Royal.Player.Context.Data.UserId.__il2cppRuntimeField_this_arg;
            Royal.Player.Context.Units.SocialManager val_3 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.SocialManager>(id:  4);
            val_12 = val_3.<MyTeamLogo>k__BackingField;
            goto label_53;
            label_37:
            val_18 = null;
            val_18 = null;
            val_14 = Royal.Scenes.Home.Ui.Sections.Leaderboard.ARowView.OtherColor;
            this.levelLabel.color = new UnityEngine.Color() {r = Royal.Scenes.Home.Ui.Sections.Leaderboard.ARowView.OtherLabelColor, g = Royal.Scenes.Home.Ui.Sections.Leaderboard.ARowView.MyColor.__il2cppRuntimeField_34, b = Royal.Scenes.Home.Ui.Sections.Leaderboard.ARowView.MyColor.__il2cppRuntimeField_38, a = Royal.Scenes.Home.Ui.Sections.Leaderboard.ARowView.MyColor.__il2cppRuntimeField_3C};
            this.levelLabel.color = new UnityEngine.Color() {r = Royal.Scenes.Home.Ui.Sections.Leaderboard.ARowView.OtherLabelColor, g = Royal.Scenes.Home.Ui.Sections.Leaderboard.ARowView.MyColor.__il2cppRuntimeField_34, b = Royal.Scenes.Home.Ui.Sections.Leaderboard.ARowView.MyColor.__il2cppRuntimeField_38, a = Royal.Scenes.Home.Ui.Sections.Leaderboard.ARowView.MyColor.__il2cppRuntimeField_3C};
            label_53:
            this.goldNickName.SetNickName(nickName:  public System.Void TMPro.TMP_Text::set_color(UnityEngine.Color value), isGold:  (Royal.Scenes.Home.Ui.Sections.Leaderboard.ARowView.__il2cppRuntimeField_static_fields != 0) ? 1 : 0, nickColor:  new UnityEngine.Color() {r = val_14, g = Royal.Scenes.Home.Ui.Sections.Leaderboard.ARowView.MyColor.__il2cppRuntimeField_14, b = Royal.Scenes.Home.Ui.Sections.Leaderboard.ARowView.MyColor.__il2cppRuntimeField_18, a = Royal.Scenes.Home.Ui.Sections.Leaderboard.ARowView.MyColor.__il2cppRuntimeField_1C}, borderType:  0);
            this.SetGoldFrame(isGold:  (Royal.Scenes.Home.Ui.Sections.Leaderboard.ARowView.__il2cppRuntimeField_static_fields != 0) ? 1 : 0);
            if(this.teamId >= 1)
            {
                    this.InitById(logoId:  47587328);
                val_19 = 1152921505029582848;
                val_20 = this.goldNickName.transform;
                val_21 = null;
                val_21 = null;
            }
            else
            {
                    this.InitWithEmptyYellowBackground();
                val_19 = 1152921505029582848;
                val_20 = this.goldNickName.transform;
                val_22 = null;
                val_22 = null;
            }
            
            val_20.localPosition = new UnityEngine.Vector3() {x = Royal.Scenes.Home.Ui.Sections.Leaderboard.Friends.FriendsRowView.UserNameWithNoTeamPosition, y = Royal.Scenes.Home.Ui.Sections.Leaderboard.Friends.FriendsRowView.UserNameWithTeamPosition.__il2cppRuntimeField_10, z = Royal.Scenes.Home.Ui.Sections.Leaderboard.Friends.FriendsRowView.UserNameWithTeamPosition.__il2cppRuntimeField_14};
            this.SetScrollButtonScaleDown(enable:  (this.teamId > 0) ? 1 : 0);
            this.renderer.enabled = (~(System.String.IsNullOrEmpty(value:  this.teamId))) & 1;
        }
        private void SetGoldFrame(bool isGold)
        {
            var val_7 = 0;
            bool val_2 = isGold;
            label_6:
            if(val_7 >= this.frameRenderers.Length)
            {
                goto label_1;
            }
            
            this.frameRenderers[val_7].sprite = this.goldFrames[isGold];
            val_7 = val_7 + 1;
            if(this.frameRenderers != null)
            {
                goto label_6;
            }
            
            label_1:
            this.goldParticles.gameObject.SetActive(value:  isGold);
            if(isGold == false)
            {
                    return;
            }
            
            this.goldParticles.Play();
        }
        private void LoadProfilePicture()
        {
            UnityEngine.Texture2D val_13;
            System.Byte[] val_14;
            UnityEngine.SpriteRenderer val_15;
            this.profilePicture.sprite = 0;
            string val_2 = Royal.Infrastructure.Services.Login.FacebookConnect.GetLocalProfilePicturePath(fbId:  this.facebookId.ToString());
            if((System.IO.File.Exists(path:  val_2)) != false)
            {
                    UnityEngine.Texture2D val_5 = new UnityEngine.Texture2D(width:  2, height:  2);
                val_13 = val_5;
                val_14 = System.IO.File.ReadAllBytes(path:  val_2);
                bool val_6 = UnityEngine.ImageConversion.LoadImage(tex:  val_5, data:  val_14);
                if(val_5 == null)
            {
                    throw new NullReferenceException();
            }
            
                val_15 = this.profilePicture;
                int val_7 = val_5.width;
                int val_8 = val_5.height;
                UnityEngine.Vector2 val_9 = new UnityEngine.Vector2(x:  0.5f, y:  0.5f);
                val_14 = UnityEngine.Sprite.Create(texture:  val_5, rect:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, pivot:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y});
                if(val_15 == null)
            {
                    throw new NullReferenceException();
            }
            
                val_15.sprite = val_14;
                return;
            }
            
            System.Action<System.Int64> val_11 = null;
            val_15 = val_11;
            val_14 = this;
            val_11 = new System.Action<System.Int64>(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Leaderboard.Friends.FriendsRowView::OnFbPictureDownloaded(long pictureOwner));
            if(this.loginService == null)
            {
                    throw new NullReferenceException();
            }
            
            this.loginService.add_OnFbPictureDownloaded(value:  val_11);
        }
        private void OnFbPictureDownloaded(long pictureOwner)
        {
            if(this.facebookId != pictureOwner)
            {
                    return;
            }
            
            this.loginService.remove_OnFbPictureDownloaded(value:  new System.Action<System.Int64>(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Leaderboard.Friends.FriendsRowView::OnFbPictureDownloaded(long pictureOwner)));
            this.LoadProfilePicture();
        }
        private void OnDestroy()
        {
            this.loginService.remove_OnFbPictureDownloaded(value:  new System.Action<System.Int64>(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Leaderboard.Friends.FriendsRowView::OnFbPictureDownloaded(long pictureOwner)));
        }
        private void SetRank(int newRank)
        {
            UnityEngine.Renderer val_1 = this.renderer;
            if(newRank <= 3)
            {
                    val_1.enabled = false;
                val_1.enabled = true;
                var val_3 = X8 + ((newRank - 1) << 3);
                val_1.sprite = (X8 + ((newRank - 1)) << 3) + 32;
                return;
            }
            
            val_1.enabled = true;
            val_1.enabled = false;
            string val_4 = newRank.ToString();
        }
        public void ShowAction()
        {
            Royal.Scenes.Home.Ui.Dialogs.ViewTeam.ViewTeamButton.ToggleViewTeamButton(teamId:  this.teamId, parent:  this.transform, xPosition:  -1.922f, bottomOffset:  5.5f);
        }
        public FriendsRowView()
        {
            this = new Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem();
        }
        private static FriendsRowView()
        {
            Royal.Scenes.Home.Ui.Sections.Leaderboard.Friends.FriendsRowView.UserNameWithTeamPosition = 0;
            Royal.Scenes.Home.Ui.Sections.Leaderboard.Friends.FriendsRowView.UserNameWithTeamPosition.__il2cppRuntimeField_8 = 0;
            Royal.Scenes.Home.Ui.Sections.Leaderboard.Friends.FriendsRowView.UserNameWithNoTeamPosition = 0;
            Royal.Scenes.Home.Ui.Sections.Leaderboard.Friends.FriendsRowView.UserNameWithTeamPosition.__il2cppRuntimeField_14 = 0;
        }
    
    }

}
