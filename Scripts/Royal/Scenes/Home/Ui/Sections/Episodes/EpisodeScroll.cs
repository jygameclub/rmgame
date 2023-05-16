using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Episodes
{
    public class EpisodeScroll : MonoBehaviour
    {
        // Fields
        public Royal.Infrastructure.UiComponents.Scroll.Content.UiOptimizedScrollContent content;
        public Royal.Infrastructure.UiComponents.Scroll.UiVerticalScroll scroll;
        public UnityEngine.BoxCollider2D boxCollider;
        private Royal.Scenes.Home.Context.Units.Area.AreaManager areaManager;
        private int currentEpisodeIndex;
        
        // Methods
        public void InitContent()
        {
            Royal.Scenes.Home.Context.Units.Area.AreaManager val_1 = Royal.Scenes.Home.Context.HomeContext.Get<Royal.Scenes.Home.Context.Units.Area.AreaManager>(id:  0);
            this.areaManager = val_1;
            val_1.add_OnTaskUpdate(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Episodes.EpisodeScroll::TaskUpdated()));
            this.areaManager.add_OnAreaUpdate(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Episodes.EpisodeScroll::PrepareContent()));
            this.PrepareContent();
        }
        private void TaskUpdated()
        {
            if(this.IsCompletedAllAreas() != false)
            {
                    this.PrepareContent();
                return;
            }
            
            this.content.RefreshIndex(index:  28 - this.currentEpisodeIndex);
        }
        private void PrepareContent()
        {
            Royal.Scenes.Home.Ui.Sections.Episodes.EpisodeState val_8;
            Royal.Scenes.Home.Ui.Sections.Episodes.EpisodeRowData val_9;
            var val_11;
            System.Collections.Generic.List<Royal.Scenes.Home.Ui.Sections.Episodes.EpisodeRowData> val_1 = new System.Collections.Generic.List<Royal.Scenes.Home.Ui.Sections.Episodes.EpisodeRowData>();
            this.currentEpisodeIndex = 28;
            var val_10 = 0;
            do
            {
                Royal.Scenes.Home.Context.Units.Area.Config.EpisodeRowConfig val_3 = this.areaManager.LoadRowConfig(id:  val_10 + 2);
                val_8 = val_3.GetStateForId(areaId:  val_3.areaId);
                if(val_8 == 1)
            {
                    this.currentEpisodeIndex = val_10 + 1;
            }
            
                val_1.Add(item:  new Royal.Scenes.Home.Ui.Sections.Episodes.EpisodeRowData(config:  val_3, episodeState:  val_8));
                val_10 = val_10 + 1;
            }
            while(val_10 < 27);
            
            if(this.IsCompletedAllAreas() != false)
            {
                    val_1.Add(item:  new Royal.Scenes.Home.Ui.Sections.Episodes.EpisodeRowData(state:  3));
            }
            
            Royal.Scenes.Home.Ui.Sections.Episodes.EpisodeRowData val_9 = null;
            val_9 = val_9;
            val_9 = new Royal.Scenes.Home.Ui.Sections.Episodes.EpisodeRowData(state:  4);
            val_1.Add(item:  val_9);
            if(val_10 < 0)
            {
                goto label_8;
            }
            
            val_11 = 524812287;
            val_8 = 1152921505131659262;
            goto label_9;
            label_12:
            val_11 = 524812286;
            val_8 = 1152921505131659261;
            label_9:
            val_9 = this.content;
            if(val_11 >= null)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_9.AddDataOnly(data:  Royal.Infrastructure.UiComponents.Scroll.Content.UiOptimizedScrollContent.__il2cppRuntimeField_byval_arg);
            if((val_8 & 2147483648) == 0)
            {
                goto label_12;
            }
            
            label_8:
            this.PrepareContentPosition();
        }
        private void PrepareContentPosition()
        {
            var val_10 = 28;
            val_10 = val_10 - this.currentEpisodeIndex;
            float val_2 = S10 + S11;
            val_2 = val_2 * ((float)(this.currentEpisodeIndex == 0) ? 27 : (val_10));
            val_2 = val_2 + (-1f);
            float val_3 = UnityEngine.Mathf.Clamp(value:  val_2, min:  V9.16B, max:  V8.16B);
            int val_4 = this.content.CalculateMinIndex(newLocation:  val_3);
            this.content = val_4;
            this.content = this.content.CalculateMaxIndex(newLocation:  val_3);
            var val_11 = 0;
            label_15:
            if(val_11 >= this.content.poolCount)
            {
                goto label_11;
            }
            
            int val_8 = val_4 + val_11;
            this.content.PopulateData(item:  UnityEngine.Object.Instantiate<Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem>(original:  X21, parent:  this.content.transform), position:  this.content.CalculateSizeForIndex(index:  val_8), index:  val_8);
            val_11 = val_11 + 1;
            if(this.content != null)
            {
                goto label_15;
            }
            
            label_11:
            if(this.currentEpisodeIndex != 0)
            {
                    return;
            }
            
            this.scroll.MoveContentToBottom(withAnimation:  false);
        }
        private Royal.Scenes.Home.Ui.Sections.Episodes.EpisodeState GetStateForId(int areaId)
        {
            var val_3 = 1;
            return (Royal.Scenes.Home.Ui.Sections.Episodes.EpisodeState);
        }
        public void SetSize(float width, float height)
        {
            UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  width, y:  height);
            this.boxCollider.size = new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
        }
        private bool IsCompletedAllAreas()
        {
            if(this.currentEpisodeIndex != 27)
            {
                    return false;
            }
            
            return AreAllTasksCompleted();
        }
        private bool IsAtLastArea()
        {
            return (bool)(this.currentEpisodeIndex == 27) ? 1 : 0;
        }
        public EpisodeScroll()
        {
        
        }
    
    }

}
