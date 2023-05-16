using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Social.MyTeam
{
    public class TeamInfoPopup : UiPopup, IBackable
    {
        // Fields
        public UnityEngine.GameObject header;
        public UnityEngine.SpriteRenderer headerBackground;
        public UnityEngine.BoxCollider2D headerBackgroundBoxCollider2D;
        public UnityEngine.SpriteRenderer mainBackground;
        public UnityEngine.BoxCollider2D mainBackgroundBoxCollider2D;
        public UnityEngine.BoxCollider2D touchBlockerBoxCollider2D;
        public UnityEngine.Transform teamInfoTransform;
        public UnityEngine.SpriteRenderer[] teamInfoContainers;
        public Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListScroll teamMemberListScroll;
        public Royal.Infrastructure.UiComponents.UiSpinner spinner;
        public UnityEngine.GameObject[] teamActivity;
        public TMPro.TextMeshPro[] teamActivityTexts;
        public Royal.Scenes.Home.Ui.Sections.Social.Logo.TeamLogoView teamLogo;
        public TMPro.TextMeshPro teamName;
        public TMPro.TextMeshPro teamDesc;
        public TMPro.TextMeshPro teamCapacity;
        public TMPro.TextMeshPro teamScore;
        public TMPro.TextMeshPro teamLevel;
        public TMPro.TextMeshPro teamType;
        public UnityEngine.GameObject joinButton;
        public UnityEngine.GameObject editButton;
        public UnityEngine.GameObject leaveButton;
        private Royal.Infrastructure.UiComponents.Touch.UiTouchListener uiTouchListener;
        private Royal.Infrastructure.Contexts.Units.CameraManager camManager;
        private bool isMyTeam;
        private bool isLeader;
        private bool isCoLeader;
        private Royal.Infrastructure.Services.Backend.Http.Command.Commands container;
        private Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoResponse teamInfo;
        private long teamInfoTeamId;
        private int teamInfoLogo;
        private string teamInfoTeamName;
        private Royal.Infrastructure.Services.Backend.Protocol.TeamActivityLevel teamInfoActivity;
        public const float Duration = 0.4;
        public const float Overshoot = 0.75;
        public const DG.Tweening.Ease Easing = 27;
        
        // Methods
        public void Show(long teamId)
        {
            this.spinner.Show();
            this.teamInfoTransform.gameObject.SetActive(value:  false);
            this.camManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            this.uiTouchListener = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  this.camManager.cameraWidth, y:  this.camManager.cameraHeight);
            this.touchBlockerBoxCollider2D.size = new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
            this.mainBackgroundBoxCollider2D.size = new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
            this.mainBackground.size = new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
            this.PrepareHeader();
            UnityEngine.Vector3 val_6 = this.header.transform.position;
            float val_24 = val_6.y;
            UnityEngine.Bounds val_7 = this.headerBackground.bounds;
            float val_23 = val_6.y;
            UnityEngine.Vector2 val_10 = this.teamInfoContainers[0].size;
            UnityEngine.Vector3 val_11 = this.camManager.GetBottomCenterOfCamera();
            val_23 = (val_24 - val_23) - val_10.y;
            val_24 = val_23 - val_11.y;
            UnityEngine.Vector2 val_13 = new UnityEngine.Vector2(x:  this.camManager.cameraWidth, y:  val_24);
            this.teamMemberListScroll.boxCollider.size = new UnityEngine.Vector2() {x = val_13.x, y = val_13.y};
            float val_25 = -0.5f;
            val_25 = val_24 * val_25;
            UnityEngine.Vector2 val_16 = new UnityEngine.Vector2(x:  0f, y:  val_23 + val_25);
            UnityEngine.Vector3 val_17 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_16.x, y = val_16.y});
            this.teamMemberListScroll.transform.localPosition = new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z};
            this.teamMemberListScroll.scroll.UpdateMaskBounds();
            Royal.Infrastructure.Services.Backend.Http.Command.Commands val_19 = new Royal.Infrastructure.Services.Backend.Http.Command.Commands();
            this.container = val_19;
            val_19.Add(httpCommand:  new Royal.Infrastructure.Services.Backend.Http.Command.Social.GetTeamHttpCommand(teamId:  teamId, includeMembers:  true));
            this.container.add_OnComplete(value:  new Commands.ConnectionComplete(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamInfoPopup::TeamInfoReceived(bool isSuccess, Royal.Infrastructure.Services.Backend.Http.Command.Commands commands)));
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.BackendHttpService>(id:  7).SendImmediately(commandsToSend:  this.container, timeOut:  10f);
            this.UpdateInputFields(enable:  false);
        }
        private void TeamInfoReceived(bool isSuccess, Royal.Infrastructure.Services.Backend.Http.Command.Commands commands)
        {
            Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoResponse val_7;
            var val_8;
            val_7 = isSuccess;
            val_8 = this;
            if(this.spinner == 0)
            {
                    return;
            }
            
            this.spinner.Hide();
            if(val_7 != false)
            {
                    Royal.Infrastructure.Services.Backend.Http.Command.BaseHttpCommand val_2 = commands.FindCommandByType(responseType:  9);
                if( >= 1)
            {
                    val_8 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
                .teamInfoResponse = val_7;
                mem[1152921518977571880] = this.spinner;
                .animate = true;
                val_8.PushToSameRunningFlowAction<Royal.Scenes.Home.Ui.Sections.Social.MyTeam.ShowTeamInfoPopupAction>(action:  new Royal.Scenes.Home.Ui.Sections.Social.MyTeam.ShowTeamInfoPopupAction());
                return;
            }
            
            }
            
            Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.ShowConnectionProblem();
            if(this.teamInfoTransform.gameObject.activeSelf == true)
            {
                    return;
            }
            
            this.Close();
        }
        public void Show(Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoResponse info, bool animate)
        {
            var val_17;
            FlatBuffers.ByteBuffer val_18;
            var val_19;
            val_17 = this;
            this.teamInfo = info;
            mem[1152921518977758584] = info.__p.bb;
            mem[1152921518977758600] = info.__p.bb_pos;
            mem[1152921518977758592] = info.__p.bb_pos;
            mem[1152921518977758608] = info.__p.bb_pos;
            mem[1152921518977758616] = info.__p.bb_pos;
            this.isMyTeam = (Royal.Player.Context.Data.UserId.__il2cppRuntimeField_this_arg == 1152921518977758576) ? 1 : 0;
            Royal.Player.Context.Units.SocialManager val_2 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.SocialManager>(id:  4);
            val_18 = 0;
            bool val_3 = val_2.IsLeader(userId:  Royal.Player.Context.Data.UserId.__il2cppRuntimeField_name);
            this.isLeader = val_3;
            if(val_3 != true)
            {
                    val_18 = 0;
                this.isCoLeader = val_2.IsCoLeader(userId:  Royal.Player.Context.Data.UserId.__il2cppRuntimeField_name);
            }
            
            val_2.UpdateMyTeamInfo(teamInfo:  new Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoResponse() {__p = new FlatBuffers.Table() {bb_pos = this.teamInfo, bb = val_18}});
            this.teamLogo.InitById(logoId:  1485997392);
            this.teamLogo.background.enabled = true;
            this.teamLogo.logo.enabled = true;
            this.teamName.text = info.__p.bb_pos;
            this.teamDesc.text = Royal.Infrastructure.Utils.Text.EmojiHelper.ReplaceWithCustomEmojis(str:  info.__p.bb_pos);
            this.teamCapacity.text = info.__p.bb_pos + "/50"("/50");
            this.teamLevel.text = info.__p.bb_pos.ToString();
            this.teamType.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  Royal.Player.Context.Units.SocialManager.TeamType(type:  false));
            this.PrepareTeamActivity(activity:  80);
            this.PrepareLayout();
            int val_12 = this.teamMemberListScroll.PrepareContent(info:  new Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoResponse() {__p = new FlatBuffers.Table() {bb_pos = info.__p.bb_pos, bb = info.__p.bb}}, isUserTeam:  this.isMyTeam, isUserLeader:  this.isLeader, isUserCoLeader:  this.isCoLeader);
            this.teamScore.text = val_12.ToString();
            this.teamInfoTransform.gameObject.SetActive(value:  true);
            if(animate != false)
            {
                    this.PlayAnimation();
            }
            
            if((Royal.Infrastructure.Services.Storage.Tables.LeaderboardTable.UpdateTeam(teamId:  1152921518977758576, capacity:  1486009712, score:  val_12)) != false)
            {
                    val_19 = null;
                val_19 = null;
                Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_element_class.GetSectionFromType(type:  0).RefreshLeaderboards(friends:  false, players:  false, teams:  true);
            }
            
            this.UpdateInputFields(enable:  false);
        }
        private void PrepareTeamActivity(int activity)
        {
            int val_11 = this.teamActivity.Length;
            val_11 = val_11 + (~activity);
            UnityEngine.Transform val_1 = this.teamActivity[(long)val_11].transform;
            TMPro.TextMeshPro val_14 = this.teamActivityTexts[(long)val_11];
            this.teamActivity[(long)val_11].SetActive(value:  true);
            UnityEngine.Rect val_3 = val_14.rectTransform.rect;
            UnityEngine.Vector3 val_6 = val_1.localPosition;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.right;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  val_3.m_XMin - val_14.renderedWidth);
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, d:  2f);
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            val_1.localPosition = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
        }
        private void PrepareLayout()
        {
            this.camManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            this.uiTouchListener = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  this.camManager.cameraWidth, y:  this.camManager.cameraHeight);
            this.touchBlockerBoxCollider2D.size = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
            this.mainBackgroundBoxCollider2D.size = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
            this.mainBackground.size = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
            this.PrepareHeader();
            this.PrepareTeamInfo();
            UnityEngine.Vector3 val_5 = this.header.transform.position;
            float val_19 = val_5.y;
            UnityEngine.Bounds val_6 = this.headerBackground.bounds;
            float val_18 = val_5.y;
            UnityEngine.Vector2 val_9 = this.teamInfoContainers[0].size;
            UnityEngine.Vector3 val_10 = this.camManager.GetBottomCenterOfCamera();
            val_18 = (val_19 - val_18) - val_9.y;
            val_19 = val_18 - val_10.y;
            UnityEngine.Vector2 val_12 = new UnityEngine.Vector2(x:  this.camManager.cameraWidth, y:  val_19);
            this.teamMemberListScroll.boxCollider.size = new UnityEngine.Vector2() {x = val_12.x, y = val_12.y};
            float val_20 = -0.5f;
            val_20 = val_19 * val_20;
            UnityEngine.Vector2 val_15 = new UnityEngine.Vector2(x:  0f, y:  val_18 + val_20);
            UnityEngine.Vector3 val_16 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_15.x, y = val_15.y});
            this.teamMemberListScroll.transform.localPosition = new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z};
            this.teamMemberListScroll.scroll.UpdateMaskBounds();
        }
        private void PrepareHeader()
        {
            if(this.camManager.IsDeviceWide() != false)
            {
                    UnityEngine.Vector2 val_2 = this.headerBackground.size;
                UnityEngine.Vector2 val_3 = UnityEngine.Vector2.right;
                UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y}, d:  4f);
                UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, b:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
                this.headerBackground.size = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
                UnityEngine.Vector2 val_6 = this.headerBackground.size;
                this.headerBackgroundBoxCollider2D.size = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
            }
            
            UnityEngine.Vector3 val_9 = this.transform.position;
            UnityEngine.Vector3 val_10 = this.camManager.GetSafeTopCenterOfCamera();
            this.header.transform.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        private void PrepareTeamInfo()
        {
            var val_6;
            if(this.isMyTeam == false)
            {
                goto label_1;
            }
            
            if(this.isLeader != true)
            {
                    if(this.isCoLeader == false)
            {
                goto label_3;
            }
            
            }
            
            this.editButton.SetActive(value:  true);
            label_3:
            this.leaveButton.SetActive(value:  true);
            val_6 = 0;
            do
            {
                if(val_6 >= this.teamInfoContainers.Length)
            {
                    return;
            }
            
                UnityEngine.SpriteRenderer val_6 = this.teamInfoContainers[val_6];
                UnityEngine.Vector2 val_1 = val_6.size;
                UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  val_1.x, y:  5.95f);
                val_6.size = new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
                UnityEngine.Vector3 val_4 = UnityEngine.Vector3.up;
                UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  0.45f);
                val_6.transform.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
                val_6 = val_6 + 1;
            }
            while(this.teamInfoContainers != null);
            
            throw new NullReferenceException();
            label_1:
            this.joinButton.SetActive(value:  true);
        }
        private int PrepareMembers(Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoResponse info, bool isUserTeam, bool isUserLeader, bool isUserCoLeader)
        {
            if(this.teamMemberListScroll != null)
            {
                    return this.teamMemberListScroll.PrepareContent(info:  new Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoResponse() {__p = new FlatBuffers.Table() {bb_pos = info.__p.bb_pos, bb = info.__p.bb}}, isUserTeam:  isUserTeam, isUserLeader:  isUserLeader, isUserCoLeader:  isUserCoLeader);
            }
            
            throw new NullReferenceException();
        }
        private void PlayAnimation()
        {
            UnityEngine.Vector3 val_2 = this.teamInfoTransform.localPosition;
            val_2.x = (this.camManager.cameraWidth + 0.5f) + val_2.x;
            UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  val_2.x, y:  val_2.y);
            UnityEngine.Vector3 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
            this.teamInfoTransform.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            DG.Tweening.Sequence val_5 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_5, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamInfoPopup::<PlayAnimation>b__44_0()));
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_9 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMoveX(target:  this.teamInfoTransform, endValue:  val_2.x, duration:  0.4f, snapping:  false), ease:  27);
            val_9 = 1061158912;
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_5, t:  val_9);
            this.teamMemberListScroll.AnimateMembers();
        }
        public void Close()
        {
            if(this.container != null)
            {
                    this.container.remove_OnComplete(value:  new Commands.ConnectionComplete(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamInfoPopup::JoinTeamResponseReceived(bool isSuccess, Royal.Infrastructure.Services.Backend.Http.Command.Commands commands)));
            }
            
            this.UpdateInputFields(enable:  true);
            this.Destroy();
        }
        public void OnJoinClick()
        {
            this.Join();
        }
        private void Join()
        {
            object val_13;
            string val_14;
            val_13 = this;
            val_14 = "Your level is not enough to join this team.";
            Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.ShowText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  null), position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, width:  7f, speed:  1f);
        }
        private void SendJoinHttpCommandWithNewName()
        {
            this.SendJoinHttpCommand(newName:  typeof(Royal.Player.Context.Data.UserId).__il2cppRuntimeField_28, shouldLeaveCurrentTeam:  false);
        }
        private void SendJoinHttpCommand(string newName, bool shouldLeaveCurrentTeam = False)
        {
            Royal.Infrastructure.Services.Backend.Http.Command.Commands val_7;
            if(this.container != null)
            {
                    return;
            }
            
            if(this.spinner != 0)
            {
                    this.spinner.Show();
            }
            
            Royal.Infrastructure.Services.Backend.Http.Command.Commands val_3 = null;
            val_7 = val_3;
            val_3 = new Royal.Infrastructure.Services.Backend.Http.Command.Commands();
            this.container = val_7;
            if(shouldLeaveCurrentTeam != false)
            {
                    val_3.Add(httpCommand:  new Royal.Infrastructure.Services.Backend.Http.Command.Social.LeaveTeamHttpCommand(teamId:  Royal.Player.Context.Data.UserId.__il2cppRuntimeField_this_arg));
                val_7 = this.container;
            }
            
            val_7.Add(httpCommand:  new Royal.Infrastructure.Services.Backend.Http.Command.Social.JoinTeamHttpCommand(teamId:  this.teamInfoTeamId, userName:  newName));
            this.container.add_OnComplete(value:  new Commands.ConnectionComplete(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamInfoPopup::JoinTeamResponseReceived(bool isSuccess, Royal.Infrastructure.Services.Backend.Http.Command.Commands commands)));
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.BackendHttpService>(id:  7).SendImmediately(commandsToSend:  this.container, timeOut:  10f);
        }
        private void JoinTeamResponseReceived(bool isSuccess, Royal.Infrastructure.Services.Backend.Http.Command.Commands commands)
        {
            Royal.Infrastructure.UiComponents.UiSpinner val_8;
            string val_9;
            val_8 = this.spinner;
            if(val_8 == 0)
            {
                    return;
            }
            
            this.spinner.Hide();
            if(isSuccess == false)
            {
                goto label_5;
            }
            
            Royal.Infrastructure.Services.Backend.Http.Command.BaseHttpCommand val_2 = this.container.FindCommandByType(responseType:  11);
            if(0 != 1)
            {
                goto label_10;
            }
            
            if((-1) < 2)
            {
                goto label_11;
            }
            
            if(0 == 3)
            {
                goto label_12;
            }
            
            Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.ShowConnectionProblem();
            goto label_17;
            label_5:
            this.container = 0;
            Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.ShowConnectionProblem();
            return;
            label_10:
            if(( & 1) == 0)
            {
                goto label_15;
            }
            
            Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamInfoPopup.UpdateSearchList();
            label_12:
            val_9 = "Your join request has been sent. Waiting for approval.";
            goto label_16;
            label_11:
            val_9 = "You can\'t join this team.";
            label_16:
            Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.ShowText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  val_9), position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, width:  7f, speed:  1f);
            goto label_17;
            label_15:
            this.UpdateSectionsOnJoin();
            label_17:
            val_8 = this.teamInfoTeamId;
            string val_6 = this.teamInfoActivity.ToString();
            this.teamInfoActivity = null;
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Analytics.AnalyticsManager>(id:  17).TeamJoin(teamId:  val_8, name:  this.teamInfoTeamName, joinType:  "join", activity:  this.teamInfoActivity.ToString().ToLower());
            this.Close();
        }
        private static void UpdateSearchList()
        {
            var val_4;
            Royal.Scenes.Home.Ui.Sections.SectionType val_5;
            val_4 = null;
            val_4 = null;
            if((Royal.Scenes.Home.Context.HomeContext.<Controller>k__BackingField) == null)
            {
                    throw new NullReferenceException();
            }
            
            if(null == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_5 = 1;
            if((Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_element_class.GetSectionFromType(type:  val_5)) == null)
            {
                    throw new NullReferenceException();
            }
            
            val_5 = null;
            if(47587328 == 0)
            {
                    return;
            }
            
            bool val_3 = UnityEngine.Object.op_Inequality(x:  47587328, y:  0);
            if(val_3 == false)
            {
                    return;
            }
            
            val_3.Search();
        }
        public void CloseMemberActionView()
        {
            Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListScroll.CloseMemberAction();
        }
        public void EditTeam()
        {
            Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListScroll.CloseMemberAction();
            .teamInfoResponse = this.teamInfo;
            mem[1152921518980777704] = ???;
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).Push(type:  this.GetType(), action:  new Royal.Scenes.Home.Ui.Sections.Social.MyTeam.ShowTeamEditDialogAction());
        }
        public void PressBack()
        {
            this.Close();
        }
        public void LeaveTeam()
        {
            object val_11;
            object val_12;
            Royal.Scenes.Start.Context.Units.Flow.FlowAction val_13;
            val_11 = this;
            Royal.Scenes.Start.Context.Units.Flow.FlowManager val_2 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
            if((Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.TeamBattleManager>(id:  9).ShouldShowWarningInTeamLeave) == false)
            {
                goto label_6;
            }
            
            Royal.Scenes.Home.Ui.Sections.Social.MyTeam.ShowLeaveTeamWithWarningDialogAction val_6 = null;
            val_12 = val_6;
            val_6 = new Royal.Scenes.Home.Ui.Sections.Social.MyTeam.ShowLeaveTeamWithWarningDialogAction();
            .onConfirm = new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamInfoPopup::OnComplete());
            if(val_2 != null)
            {
                goto label_7;
            }
            
            throw new NullReferenceException();
            label_6:
            Royal.Scenes.Home.Ui.Dialogs.Confirm.ShowConfirmDialogAction val_10 = null;
            val_13 = val_10;
            val_10 = new Royal.Scenes.Home.Ui.Dialogs.Confirm.ShowConfirmDialogAction(title:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Leave Team?"), message:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Are you sure you want to leave your team?"), onConfirm:  new System.Action(object:  val_6, method:  System.Void Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamInfoPopup::OnComplete()));
            label_7:
            val_2.Push(type:  this.GetType(), action:  val_10);
        }
        private void OnComplete()
        {
            this.spinner.Show();
            Royal.Infrastructure.Services.Backend.Http.Command.Commands val_2 = new Royal.Infrastructure.Services.Backend.Http.Command.Commands();
            val_2.add_OnComplete(value:  new Commands.ConnectionComplete(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamInfoPopup::TeamLeft(bool isSuccess, Royal.Infrastructure.Services.Backend.Http.Command.Commands commands)));
            val_2.Add(httpCommand:  new Royal.Infrastructure.Services.Backend.Http.Command.Social.LeaveTeamHttpCommand(teamId:  Royal.Player.Context.Data.UserId.__il2cppRuntimeField_this_arg));
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.BackendHttpService>(id:  7).SendImmediately(commandsToSend:  val_2, timeOut:  10f);
        }
        private void TeamLeft(bool isSuccess, Royal.Infrastructure.Services.Backend.Http.Command.Commands commands)
        {
            if(this.spinner == 0)
            {
                    return;
            }
            
            this.spinner.Hide();
            if(isSuccess != false)
            {
                    this.UpdateSectionsOnLeave();
                this.Close();
                return;
            }
            
            Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.ShowConnectionProblem();
        }
        private void UpdateInputFields(bool enable)
        {
            var val_7;
            Royal.Scenes.Home.Ui.Sections.Social.SearchTeam.SearchTeamPopup val_1 = this.camManager.camera.GetComponentInChildren<Royal.Scenes.Home.Ui.Sections.Social.SearchTeam.SearchTeamPopup>();
            if(val_1 != 0)
            {
                    val_1.EnableQueryField(enable:  enable);
                return;
            }
            
            val_7 = null;
            val_7 = null;
            Royal.Scenes.Home.Ui.Sections.Section val_4 = Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_element_class.GetSectionFromType(type:  1);
            bool val_5 = UnityEngine.Object.op_Inequality(x:  1152921504784535552, y:  0);
            if(val_5 == false)
            {
                    return;
            }
            
            val_5.EnableQueryField(enable:  enable);
        }
        private void UpdateSectionsOnJoin()
        {
            var val_5;
            Royal.Scenes.Home.Ui.Sections.Social.MyTeam.ICanOpenTeamInfoPopupOnTop val_1 = this.camManager.camera.GetComponentInChildren<Royal.Scenes.Home.Ui.Sections.Social.MyTeam.ICanOpenTeamInfoPopupOnTop>();
            if(val_1 != null)
            {
                    var val_4 = 0;
                if(mem[1152921505024614400] != null)
            {
                    val_4 = val_4 + 1;
            }
            else
            {
                    Royal.Scenes.Home.Ui.Sections.Social.MyTeam.ICanOpenTeamInfoPopupOnTop val_2 = 1152921505024577536 + ((mem[1152921505024614408]) << 4);
            }
            
                val_1.Close();
            }
            
            val_5 = null;
            val_5 = null;
            Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_element_class.ChangeSection(type:  1);
            Royal.Infrastructure.Services.Storage.Tables.LeaderboardTable.UpdateMyTeam(teamId:  this.teamInfoTeamId, teamLogo:  this.teamInfoLogo, teamName:  this.teamInfoTeamName);
            Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_element_class.GetSectionFromType(type:  0).RefreshLeaderboards(friends:  true, players:  true, teams:  true);
        }
        private void UpdateSectionsOnLeave()
        {
            var val_5;
            Royal.Scenes.Home.Ui.Sections.Social.MyTeam.ICanOpenTeamInfoPopupOnTop val_1 = this.camManager.camera.GetComponentInChildren<Royal.Scenes.Home.Ui.Sections.Social.MyTeam.ICanOpenTeamInfoPopupOnTop>();
            if(val_1 != null)
            {
                    var val_4 = 0;
                if(mem[1152921505024614400] != null)
            {
                    val_4 = val_4 + 1;
            }
            else
            {
                    Royal.Scenes.Home.Ui.Sections.Social.MyTeam.ICanOpenTeamInfoPopupOnTop val_2 = 1152921505024577536 + ((mem[1152921505024614408]) << 4);
            }
            
                val_1.Close();
            }
            
            val_5 = null;
            val_5 = null;
            Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_element_class.ChangeSection(type:  1);
            Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_element_class.GetSectionFromType(type:  0).RefreshLeaderboards(friends:  true, players:  true, teams:  true);
        }
        public TeamInfoPopup()
        {
        
        }
        private void <PlayAnimation>b__44_0()
        {
            this.teamInfoTransform.gameObject.SetActive(value:  true);
        }
        private void <Join>b__47_0()
        {
            this.SendJoinHttpCommand(newName:  System.String.alignConst, shouldLeaveCurrentTeam:  true);
        }
    
    }

}
