using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Social.NoTeam
{
    public class TeamListScroll : MonoBehaviour
    {
        // Fields
        public UnityEngine.BoxCollider2D boxCollider;
        public Royal.Infrastructure.UiComponents.Scroll.Content.UiOptimizedScrollContent content;
        private UnityEngine.Coroutine creationRoutine;
        
        // Methods
        public void PrepareContent(Royal.Infrastructure.Services.Backend.Protocol.SearchTeamResponse response, bool hideMyTeam, bool createSlowly = False)
        {
            int val_3;
            long val_4;
            bool val_17;
            System.Collections.Generic.IEnumerable<Royal.Scenes.Home.Ui.Sections.Social.NoTeam.TeamListRowData> val_18;
            Royal.Scenes.Home.Ui.Sections.Social.NoTeam.TeamListScroll val_19;
            Royal.Scenes.Home.Ui.Sections.Social.NoTeam.TeamListScroll val_20;
            var val_21;
            bool val_22;
            var val_23;
            System.Func<Royal.Scenes.Home.Ui.Sections.Social.NoTeam.TeamListRowData, System.Int32> val_25;
            var val_26;
            Royal.Scenes.Home.Ui.Sections.Social.NoTeam.TeamListScroll val_27;
            val_17 = createSlowly;
            val_18 = hideMyTeam;
            val_19 = this;
            if(mem[1152921518969697560] != 0)
            {
                    this.StopCoroutine(routine:  mem[1152921518969697560]);
                mem[1152921518969697560] = 0;
            }
            
            if(mem[1152921518969697552] == 0)
            {
                    throw new NullReferenceException();
            }
            
            if(1477936496 < 1)
            {
                    return;
            }
            
            if(val_18 != false)
            {
                    if((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField) == null)
            {
                    throw new NullReferenceException();
            }
            
                if(null == 0)
            {
                    throw new NullReferenceException();
            }
            
            }
            else
            {
                    val_17 = 0;
            }
            
            Royal.Scenes.Home.Ui.Sections.Social.Logo.TeamLogoCatalog val_1 = Royal.Scenes.Home.Ui.Sections.Social.Logo.TeamLogoCatalog.GetConfig();
            val_21;
            System.Collections.Generic.List<Royal.Scenes.Home.Ui.Sections.Social.NoTeam.TeamListRowData> val_2 = new System.Collections.Generic.List<Royal.Scenes.Home.Ui.Sections.Social.NoTeam.TeamListRowData>(capacity:  1477936496);
            if(1477936496 >= 1)
            {
                    val_21 = 1152921518969644784;
                var val_19 = 0;
                do
            {
                var val_18 = val_3;
                val_18 = val_18 & 255;
                if((val_18 != 0) && (1477936448 != val_17))
            {
                    if(response.__p.bb_pos >= 1)
            {
                    val_22 = Royal.Scenes.Home.Ui.Sections.Social.NoTeam.TeamListScroll.IsPending(teamId:  1152921518969685312, response:  new Royal.Infrastructure.Services.Backend.Protocol.SearchTeamResponse() {__p = new FlatBuffers.Table() {bb_pos = response.__p.bb_pos, bb = response.__p.bb}});
            }
            else
            {
                    val_22 = false;
            }
            
                if(val_1 == null)
            {
                    throw new NullReferenceException();
            }
            
                if(val_2 == null)
            {
                    throw new NullReferenceException();
            }
            
                val_4 = ;
                val_3 = ;
                val_2.Add(item:  new Royal.Scenes.Home.Ui.Sections.Social.NoTeam.TeamListRowData() {id = val_4, name = val_4, capacity = val_3, isPending = val_22, logoConfig = val_1.GetLogoById(id:  1477936448)});
                val_21 = 1152921518969644784;
            }
            
                val_19 = val_19 + 1;
            }
            while(val_19 < 1477936496);
            
            }
            
            val_23 = null;
            val_23 = null;
            val_25 = TeamListScroll.<>c.<>9__3_0;
            if(val_25 == null)
            {
                    System.Func<Royal.Scenes.Home.Ui.Sections.Social.NoTeam.TeamListRowData, System.Int32> val_7 = null;
                val_25 = val_7;
                val_7 = new System.Func<Royal.Scenes.Home.Ui.Sections.Social.NoTeam.TeamListRowData, System.Int32>(object:  TeamListScroll.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 TeamListScroll.<>c::<PrepareContent>b__3_0(Royal.Scenes.Home.Ui.Sections.Social.NoTeam.TeamListRowData team));
                TeamListScroll.<>c.<>9__3_0 = val_25;
            }
            
            val_26 = public static System.Linq.IOrderedEnumerable<TSource> System.Linq.Enumerable::OrderBy<Royal.Scenes.Home.Ui.Sections.Social.NoTeam.TeamListRowData, System.Int32>(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, TKey> keySelector);
            val_18 = System.Linq.Enumerable.OrderBy<Royal.Scenes.Home.Ui.Sections.Social.NoTeam.TeamListRowData, System.Int32>(source:  val_2, keySelector:  val_7);
            if(val_17 != false)
            {
                    val_27 = this;
                mem[1152921518969697560] = this.StartCoroutine(routine:  this.CreateContentSlowly(sortedTeams:  val_18));
                return;
            }
            
            val_20 = this;
            if(val_18 == null)
            {
                    throw new NullReferenceException();
            }
            
            var val_20 = 0;
            if(mem[1152921504767746048] != null)
            {
                    val_20 = val_20 + 1;
                val_26 = 0;
            }
            else
            {
                    System.Linq.IOrderedEnumerable<TSource> val_11 = 1152921504767709184 + ((mem[1152921504767746056]) << 4);
            }
            
            val_17 = val_18.GetEnumerator();
            val_21 = 1152921504684695552;
            label_40:
            var val_21 = 0;
            if(mem[1152921504684732416] != null)
            {
                    val_21 = val_21 + 1;
                val_26 = 0;
            }
            else
            {
                    System.Collections.Generic.IEnumerator<T> val_13 = 1152921504684695552 + ((mem[1152921504684732424]) << 4);
            }
            
            if(val_17.MoveNext() == false)
            {
                goto label_34;
            }
            
            var val_22 = 0;
            if(mem[1152921504684732416] != null)
            {
                    val_22 = val_22 + 1;
                val_26 = 0;
            }
            else
            {
                    System.Collections.Generic.IEnumerator<T> val_15 = 1152921504684695552 + ((mem[1152921504684732424]) << 4);
            }
            
            T val_16 = val_17.Current;
            if(mem[1152921518969697552] == 0)
            {
                    throw new NullReferenceException();
            }
            
            goto label_40;
            label_34:
            val_19 = 0;
            if(val_17 != null)
            {
                    var val_23 = 0;
                if(mem[1152921504684732416] != null)
            {
                    val_23 = val_23 + 1;
            }
            else
            {
                    System.Collections.Generic.IEnumerator<T> val_17 = 1152921504684695552 + ((mem[1152921504684732424]) << 4);
            }
            
                val_17.Dispose();
            }
            
            if(val_19 != 0)
            {
                    throw val_19;
            }
        
        }
        private System.Collections.IEnumerator CreateContentSlowly(System.Collections.Generic.IEnumerable<Royal.Scenes.Home.Ui.Sections.Social.NoTeam.TeamListRowData> sortedTeams)
        {
            .<>1__state = 0;
            .sortedTeams = sortedTeams;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new TeamListScroll.<CreateContentSlowly>d__4();
        }
        private static bool IsPending(long teamId, Royal.Infrastructure.Services.Backend.Protocol.SearchTeamResponse response)
        {
            var val_1;
            if( < 1)
            {
                goto label_0;
            }
            
            var val_1 = 0;
            label_2:
            if( == teamId)
            {
                goto label_1;
            }
            
            val_1 = val_1 + 1;
            if(val_1 < )
            {
                goto label_2;
            }
            
            label_0:
            val_1 = 0;
            return (bool)val_1;
            label_1:
            val_1 = 1;
            return (bool)val_1;
        }
        public TeamListScroll()
        {
        
        }
    
    }

}
