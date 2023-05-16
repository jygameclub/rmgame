using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Social.MyTeam
{
    public class TeamMemberListScroll : MonoBehaviour
    {
        // Fields
        public Royal.Infrastructure.UiComponents.Scroll.UiScroll scroll;
        public UnityEngine.BoxCollider2D boxCollider;
        public Royal.Infrastructure.UiComponents.Scroll.Content.UiOptimizedScrollContent content;
        private static int CoLeaderCount;
        private static bool <ShouldShowMemberActionView>k__BackingField;
        private static Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberActionView TeamMemberActionView;
        private static Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListRow ActiveTeamMemberListRow;
        
        // Properties
        public static bool ShouldShowMemberActionView { get; set; }
        
        // Methods
        public static bool get_ShouldShowMemberActionView()
        {
            return (bool)Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListScroll.<ShouldShowMemberActionView>k__BackingField;
        }
        private static void set_ShouldShowMemberActionView(bool value)
        {
            Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListScroll.<ShouldShowMemberActionView>k__BackingField = value;
        }
        public int PrepareContent(Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoResponse info, bool isUserTeam, bool isUserLeader, bool isUserCoLeader)
        {
            var val_3;
            var val_4;
            Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListScroll val_20;
            var val_21;
            System.Linq.IOrderedEnumerable<TSource> val_22;
            bool val_23;
            System.Collections.Generic.List<T> val_24;
            var val_25;
            var val_26;
            var val_27;
            System.Func<Royal.Scenes.Home.Ui.Sections.Social.MyTeam.MemberListRowData, System.Int32> val_29;
            var val_30;
            System.Func<Royal.Scenes.Home.Ui.Sections.Social.MyTeam.MemberListRowData, System.Int32> val_32;
            var val_33;
            System.Func<Royal.Scenes.Home.Ui.Sections.Social.MyTeam.MemberListRowData, System.Int64> val_35;
            var val_36;
            val_20 = this;
            val_21 = 1152921505025216512;
            bool val_1 = isUserLeader | isUserCoLeader;
            val_23 = val_1 & isUserTeam;
            Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListScroll.CoLeaderCount = info.__p.bb_pos;
            val_1 = val_23;
            Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListScroll.<ShouldShowMemberActionView>k__BackingField = val_1;
            if(this.content == null)
            {
                    throw new NullReferenceException();
            }
            
            if(1496791408 < 1)
            {
                goto label_3;
            }
            
            if(1496791408 <= 6)
            {
                    if(this.content == null)
            {
                    throw new NullReferenceException();
            }
            
                this.content = typeof(Royal.Infrastructure.UiComponents.Scroll.Content.UiOptimizedScrollContent).__il2cppRuntimeField_170;
            }
            
            System.Collections.Generic.List<Royal.Scenes.Home.Ui.Sections.Social.MyTeam.MemberListRowData> val_2 = null;
            val_24 = val_2;
            val_2 = new System.Collections.Generic.List<Royal.Scenes.Home.Ui.Sections.Social.MyTeam.MemberListRowData>(capacity:  1496791408);
            if(1496791408 < 1)
            {
                goto label_6;
            }
            
            val_25 = 0;
            var val_23 = 0;
            label_20:
            var val_21 = val_3;
            val_21 = val_21 & 255;
            if(val_21 == 0)
            {
                goto label_9;
            }
            
            if(isUserTeam != false)
            {
                    if((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField) == null)
            {
                    throw new NullReferenceException();
            }
            
                if(null == 0)
            {
                    throw new NullReferenceException();
            }
            
                var val_5 = ( == Royal.Player.Context.Data.UserId.__il2cppRuntimeField_name) ? 1 : 0;
            }
            else
            {
                    val_26 = 0;
            }
            
            if(( != ) && (1496791408 >= 1))
            {
                    var val_22 = 0;
                do
            {
                if( == 1496791408)
            {
                goto label_8;
            }
            
                val_22 = val_22 + 1;
            }
            while(val_22 < 1496791408);
            
            }
            
            label_8:
            var val_6 = ( == ) ? 1 : 0;
            val_21;
            val_22;
            bool val_7 = isUserTeam;
            val_24 = val_24;
            if(val_24 == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_25 = 2305843037977080448;
            val_3 = 0;
            val_4 = 0;
            val_2.Add(item:  new Royal.Scenes.Home.Ui.Sections.Social.MyTeam.MemberListRowData() {isMyTeam = false, isMyUser = false, isLeader = false, isCoLeader = false, isGold = false});
            val_20 = val_20;
            label_9:
            val_23 = val_23 + 1;
            if(val_23 < 1496791408)
            {
                goto label_20;
            }
            
            goto label_21;
            label_3:
            val_25 = 0;
            return (int)val_25;
            label_6:
            val_25 = 0;
            label_21:
            val_21 = 1152921505025269760;
            val_27 = null;
            val_27 = null;
            val_29 = TeamMemberListScroll.<>c.<>9__10_0;
            if(val_29 == null)
            {
                    System.Func<Royal.Scenes.Home.Ui.Sections.Social.MyTeam.MemberListRowData, System.Int32> val_8 = null;
                val_29 = val_8;
                val_8 = new System.Func<Royal.Scenes.Home.Ui.Sections.Social.MyTeam.MemberListRowData, System.Int32>(object:  TeamMemberListScroll.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 TeamMemberListScroll.<>c::<PrepareContent>b__10_0(Royal.Scenes.Home.Ui.Sections.Social.MyTeam.MemberListRowData member));
                TeamMemberListScroll.<>c.<>9__10_0 = val_29;
            }
            
            val_30 = null;
            val_30 = null;
            val_32 = TeamMemberListScroll.<>c.<>9__10_1;
            if(val_32 == null)
            {
                    System.Func<Royal.Scenes.Home.Ui.Sections.Social.MyTeam.MemberListRowData, System.Int32> val_10 = null;
                val_32 = val_10;
                val_10 = new System.Func<Royal.Scenes.Home.Ui.Sections.Social.MyTeam.MemberListRowData, System.Int32>(object:  TeamMemberListScroll.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 TeamMemberListScroll.<>c::<PrepareContent>b__10_1(Royal.Scenes.Home.Ui.Sections.Social.MyTeam.MemberListRowData member));
                TeamMemberListScroll.<>c.<>9__10_1 = val_32;
            }
            
            val_33 = null;
            val_22 = System.Linq.Enumerable.ThenByDescending<Royal.Scenes.Home.Ui.Sections.Social.MyTeam.MemberListRowData, System.Int32>(source:  System.Linq.Enumerable.OrderByDescending<Royal.Scenes.Home.Ui.Sections.Social.MyTeam.MemberListRowData, System.Int32>(source:  val_2, keySelector:  val_8), keySelector:  val_10);
            val_33 = null;
            val_35 = TeamMemberListScroll.<>c.<>9__10_2;
            if(val_35 == null)
            {
                    System.Func<Royal.Scenes.Home.Ui.Sections.Social.MyTeam.MemberListRowData, System.Int64> val_12 = null;
                val_35 = val_12;
                val_12 = new System.Func<Royal.Scenes.Home.Ui.Sections.Social.MyTeam.MemberListRowData, System.Int64>(object:  TeamMemberListScroll.<>c.__il2cppRuntimeField_static_fields, method:  System.Int64 TeamMemberListScroll.<>c::<PrepareContent>b__10_2(Royal.Scenes.Home.Ui.Sections.Social.MyTeam.MemberListRowData member));
                TeamMemberListScroll.<>c.<>9__10_2 = val_35;
            }
            
            val_36 = public static System.Linq.IOrderedEnumerable<TSource> System.Linq.Enumerable::ThenBy<Royal.Scenes.Home.Ui.Sections.Social.MyTeam.MemberListRowData, System.Int64>(System.Linq.IOrderedEnumerable<TSource> source, System.Func<TSource, TKey> keySelector);
            System.Linq.IOrderedEnumerable<TSource> val_13 = System.Linq.Enumerable.ThenBy<Royal.Scenes.Home.Ui.Sections.Social.MyTeam.MemberListRowData, System.Int64>(source:  val_22, keySelector:  val_12);
            if(val_13 == null)
            {
                    throw new NullReferenceException();
            }
            
            var val_24 = 0;
            if(mem[1152921504767746048] != null)
            {
                    val_24 = val_24 + 1;
                val_36 = 0;
            }
            else
            {
                    System.Linq.IOrderedEnumerable<TSource> val_14 = 1152921504767709184 + ((mem[1152921504767746056]) << 4);
            }
            
            val_22 = val_13.GetEnumerator();
            val_21 = 1152921504680542208;
            val_23 = 0;
            label_54:
            var val_25 = 0;
            if(mem[1152921504684732416] != null)
            {
                    val_25 = val_25 + 1;
                val_36 = 0;
            }
            else
            {
                    System.Collections.Generic.IEnumerator<T> val_16 = 1152921504684695552 + ((mem[1152921504684732424]) << 4);
            }
            
            if(val_22.MoveNext() == false)
            {
                goto label_48;
            }
            
            var val_26 = 0;
            if(mem[1152921504684732416] != null)
            {
                    val_26 = val_26 + 1;
                val_36 = 0;
            }
            else
            {
                    System.Collections.Generic.IEnumerator<T> val_18 = 1152921504684695552 + ((mem[1152921504684732424]) << 4);
            }
            
            T val_19 = val_22.Current;
            val_23 = val_23 + 1;
            if(this.content == null)
            {
                    throw new NullReferenceException();
            }
            
            goto label_54;
            label_48:
            val_21 = 0;
            if(val_22 != null)
            {
                    var val_27 = 0;
                if(mem[1152921504684732416] != null)
            {
                    val_27 = val_27 + 1;
            }
            else
            {
                    System.Collections.Generic.IEnumerator<T> val_20 = 1152921504684695552 + ((mem[1152921504684732424]) << 4);
            }
            
                val_22.Dispose();
            }
            
            if(val_21 != 0)
            {
                    throw val_21;
            }
            
            return (int)val_25;
        }
        public void AnimateMembers()
        {
            int val_2 = this.content.transform.childCount;
            if(val_2 < 1)
            {
                    return;
            }
            
            var val_5 = 0;
            do
            {
                UnityEngine.Transform val_4 = this.content.transform.GetChild(index:  0);
                val_4.AnimateItem(item:  val_4, order:  0, delay:  0.03f);
                val_5 = val_5 + 1;
            }
            while(val_5 < val_2);
        
        }
        private void AnimateItem(UnityEngine.Transform item, int order, float delay = 0.03)
        {
            .item = item;
            Royal.Infrastructure.Contexts.Units.CameraManager val_2 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            UnityEngine.Vector3 val_4 = (TeamMemberListScroll.<>c__DisplayClass12_0)[1152921518988958016].item.localPosition;
            val_4.x = (val_2.cameraWidth + 0.5f) + val_4.x;
            UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  val_4.x, y:  val_4.y);
            UnityEngine.Vector3 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y});
            (TeamMemberListScroll.<>c__DisplayClass12_0)[1152921518988958016].item.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            DG.Tweening.Sequence val_7 = DG.Tweening.DOTween.Sequence();
            float val_15 = (float)order + 1;
            val_15 = val_15 * delay;
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Sequence>(t:  val_7, delay:  val_15);
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_7, callback:  new DG.Tweening.TweenCallback(object:  new TeamMemberListScroll.<>c__DisplayClass12_0(), method:  System.Void TeamMemberListScroll.<>c__DisplayClass12_0::<AnimateItem>b__0()));
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_13 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMoveX(target:  (TeamMemberListScroll.<>c__DisplayClass12_0)[1152921518988958016].item, endValue:  val_4.x, duration:  0.4f, snapping:  false), ease:  27);
            val_13 = 1061158912;
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_7, t:  val_13);
        }
        private static void ShowMemberAction(long userId, string userName, bool isLeader, bool isCoLeader, Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListRow row)
        {
            UnityEngine.Transform val_9;
            var val_10;
            if((Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListScroll.<ShouldShowMemberActionView>k__BackingField) == false)
            {
                    return;
            }
            
            val_9 = 1152921504784535552;
            if(Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListScroll.TeamMemberActionView == 0)
            {
                    val_9 = row.transform;
                val_10 = null;
                Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListScroll.TeamMemberActionView = UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberActionView>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberActionView>(path:  "TeamMemberActionView"), parent:  val_9, worldPositionStays:  false);
            }
            else
            {
                    val_10 = 1152921505025216696;
            }
            
            Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListScroll.ActiveTeamMemberListRow = row;
            UnityEngine.GameObject val_5 = Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListScroll.TeamMemberActionView.gameObject;
            if(isLeader != false)
            {
                    val_5.SetActive(value:  false);
                return;
            }
            
            val_5.SetActive(value:  true);
            Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListScroll.TeamMemberActionView.transform.SetParent(parent:  row.transform, worldPositionStays:  false);
            Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListScroll.TeamMemberActionView.Init(user:  userId, uName:  userName, isCoLeader:  isCoLeader, coLeaders:  Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListScroll.CoLeaderCount);
        }
        public static void CloseMemberAction()
        {
            if(Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListScroll.TeamMemberActionView != 0)
            {
                    Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListScroll.TeamMemberActionView.gameObject.SetActive(value:  false);
            }
            
            Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListScroll.ActiveTeamMemberListRow = 0;
        }
        public static void ToggleMemberAction(long userId, string userName, bool isLeader, bool isCoLeader, Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListRow row)
        {
            if(row == Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListScroll.ActiveTeamMemberListRow)
            {
                    Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListScroll.CloseMemberAction();
                return;
            }
            
            isCoLeader = isCoLeader;
            Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListScroll.ShowMemberAction(userId:  userId, userName:  userName, isLeader:  isLeader, isCoLeader:  isCoLeader, row:  row);
        }
        public TeamMemberListScroll()
        {
        
        }
    
    }

}
