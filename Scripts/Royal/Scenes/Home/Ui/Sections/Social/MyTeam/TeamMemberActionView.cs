using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Social.MyTeam
{
    public class TeamMemberActionView : MonoBehaviour
    {
        // Fields
        public UnityEngine.Transform body;
        public UnityEngine.SpriteRenderer leftPart;
        public UnityEngine.SpriteRenderer rightPart;
        public UnityEngine.GameObject promoteButton;
        public UnityEngine.GameObject demoteButton;
        public UnityEngine.Transform kickButton;
        public UnityEngine.Sprite upSprite;
        public UnityEngine.Sprite downSprite;
        private float posY;
        private long userId;
        private string userName;
        private int coLeaderCount;
        private float screenRefPosY;
        
        // Methods
        private void Awake()
        {
            UnityEngine.Vector2 val_2 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1).GetScreenSize();
            float val_3 = -0.5f;
            val_3 = val_2.y * val_3;
            this.screenRefPosY = val_3;
        }
        public void Init(long user, string uName, bool isCoLeader, int coLeaders)
        {
            UnityEngine.Transform val_18;
            UnityEngine.Transform val_20;
            float val_21;
            this.userId = user;
            this.userName = uName;
            this.coLeaderCount = coLeaders;
            if((Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.SocialManager>(id:  4).AmILeader()) != false)
            {
                    UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  6.149478f, y:  3.014286f);
                this.rightPart.size = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
                this.demoteButton.SetActive(value:  isCoLeader);
                this.promoteButton.SetActive(value:  (~isCoLeader) & 1);
                val_18 = this.kickButton;
            }
            else
            {
                    if(isCoLeader != false)
            {
                    Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListScroll.CloseMemberAction();
                return;
            }
            
                UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  2.721537f, y:  3.014286f);
                this.rightPart.size = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
                this.demoteButton.SetActive(value:  false);
                this.promoteButton.SetActive(value:  false);
                val_18 = this.kickButton;
            }
            
            val_18.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Vector3 val_8 = this.transform.position;
            val_8.y = val_8.y + (-3f);
            if(val_8.y < 0)
            {
                    this.UpdateSprite(sprite:  this.downSprite);
                this.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
                val_20 = this.body;
                val_21 = 3.08f;
            }
            else
            {
                    this.UpdateSprite(sprite:  this.upSprite);
                this.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
                val_20 = this.body;
                val_21 = 0f;
            }
            
            val_20.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_14 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  1f, duration:  0.17f), ease:  27);
            UnityEngine.Vector3 val_16 = this.transform.position;
            this.posY = val_16.y;
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16).PlaySound(type:  2, offset:  0.04f);
        }
        private void Update()
        {
            UnityEngine.Vector3 val_2 = this.transform.position;
            if((Royal.Infrastructure.Utils.Math.NumberExtensions.Approximately(a:  val_2.y, b:  this.posY, precision:  0.1f)) != false)
            {
                    return;
            }
            
            Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListScroll.CloseMemberAction();
        }
        public void Promote()
        {
            if(this.coLeaderCount < 3)
            {
                    this.UpdateMember(type:  4, title:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Make Co-leader"), message:  System.String.Format(format:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Are you sure you want to make X a Co-leader?"), arg0:  this.userName), yesString:  "Yes", noString:  "No");
                Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListScroll.CloseMemberAction();
                return;
            }
            
            Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListScroll.CloseMemberAction();
            Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.ShowText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "You already have 3 co-leaders."), position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, width:  5f, speed:  1f);
        }
        public void Demote()
        {
            this.UpdateMember(type:  5, title:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Demote Co-leader"), message:  this.GetDemoteCoLeaderTranslation(), yesString:  "Yes", noString:  "No");
            Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListScroll.CloseMemberAction();
        }
        private string GetDemoteCoLeaderTranslation()
        {
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isArabic == false)
            {
                    return System.String.Format(format:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Are you sure you want to demote X?"), arg0:  this.userName);
            }
            
            return I2.Loc.LocalizationManager.ApplyRTLfix(line:  "هل أنت متأكد \n من خفض الرتبة \n")(I2.Loc.LocalizationManager.ApplyRTLfix(line:  "هل أنت متأكد \n من خفض الرتبة \n")) + "؟" + this.userName;
        }
        public void Kick()
        {
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).Push(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), action:  new Royal.Scenes.Home.Ui.Dialogs.Confirm.ShowConfirmDialogAction(title:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Kick Out!"), message:  this.GetAreYouSureToKick(), onConfirm:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberActionView::<Kick>b__19_0())));
            Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListScroll.CloseMemberAction();
        }
        private string GetAreYouSureToKick()
        {
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isArabic == false)
            {
                    return System.String.Format(format:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Are you sure you want to kick X?"), arg0:  this.userName);
            }
            
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
            System.Text.StringBuilder val_2 = val_1.AppendLine(value:  "هل أنت متأكد");
            System.Text.StringBuilder val_3 = val_1.AppendLine(value:  "من طرد");
            System.Text.StringBuilder val_5 = val_1.AppendLine(value:  "؟" + this.userName);
            return I2.Loc.LocalizationManager.ApplyRTLfix(line:  val_1);
        }
        private string GetWontBeAbleToJoin()
        {
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isArabic == false)
            {
                    return System.String.Format(format:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "won\'t be able to join again."), arg0:  this.userName);
            }
            
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
            System.Text.StringBuilder val_2 = val_1.AppendLine(value:  this.userName);
            System.Text.StringBuilder val_3 = val_1.AppendLine(value:  "لن يستطيع");
            System.Text.StringBuilder val_4 = val_1.AppendLine(value:  "الانضمام مجددًا.");
            return I2.Loc.LocalizationManager.ApplyRTLfix(line:  val_1);
        }
        private void UpdateMember(Royal.Infrastructure.Services.Backend.Protocol.TeamMemberOperationType type, string title, string message, string yesString = "Yes", string noString = "No")
        {
            .<>4__this = this;
            .type = type;
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).Push(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), action:  new Royal.Scenes.Home.Ui.Dialogs.Confirm.ShowConfirmDialogAction(title:  title, message:  message, yesString:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  yesString), noString:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  noString), onConfirm:  new System.Action(object:  new TeamMemberActionView.<>c__DisplayClass22_0(), method:  System.Void TeamMemberActionView.<>c__DisplayClass22_0::<UpdateMember>b__0())));
        }
        private void UpdateSprite(UnityEngine.Sprite sprite)
        {
            this.leftPart.sprite = sprite;
            this.rightPart.sprite = sprite;
        }
        private static void TeamInfoReceived(bool isSuccess, Royal.Infrastructure.Services.Backend.Http.Command.Commands container)
        {
            if(isSuccess != false)
            {
                    Royal.Infrastructure.Services.Backend.Http.Command.BaseHttpCommand val_1 = container.FindCommandByType(responseType:  9);
                Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).PushToSameRunningFlowAction<Royal.Scenes.Home.Ui.Sections.Social.MyTeam.ShowTeamInfoPopupAction>(action:  new Royal.Scenes.Home.Ui.Sections.Social.MyTeam.ShowTeamInfoPopupAction(teamInfoResponse:  new Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoResponse() {__p = new FlatBuffers.Table() {bb_pos = 47587328, bb = X22}}, animate:  false));
                return;
            }
            
            Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberActionView.ActivateSpinner(activate:  false);
            Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.ShowConnectionProblem();
        }
        private static void ActivateSpinner(bool activate)
        {
            Royal.Infrastructure.Contexts.Units.CameraManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            if((val_1.camera.GetComponentInChildren<Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamInfoPopup>()) == 0)
            {
                    return;
            }
            
            if(activate != false)
            {
                    val_2.spinner.Show();
                return;
            }
            
            val_2.spinner.Hide();
        }
        public TeamMemberActionView()
        {
        
        }
        private void <Kick>b__19_0()
        {
            this.UpdateMember(type:  2, title:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Warning!"), message:  this.GetWontBeAbleToJoin(), yesString:  "Kick", noString:  "Cancel");
        }
    
    }

}
