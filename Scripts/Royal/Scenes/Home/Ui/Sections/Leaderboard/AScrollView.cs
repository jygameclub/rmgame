using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Leaderboard
{
    public abstract class AScrollView : MonoBehaviour
    {
        // Fields
        public Royal.Infrastructure.UiComponents.Scroll.Content.UiOptimizedScrollContent content;
        public UnityEngine.BoxCollider2D boxCollider;
        public Royal.Infrastructure.UiComponents.Scroll.UiVerticalScroll verticalScroll;
        public Royal.Scenes.Home.Ui.Sections.Leaderboard.Friends.LeaderboardRowData myRowData;
        public int totalCount;
        public float contentPosition;
        public bool isMyViewInContent;
        public UnityEngine.Transform myViewTransformAtBottom;
        public bool isMyViewInScroll;
        public UnityEngine.Transform myViewTransformInScroll;
        private static int fullVisibleRowCount;
        
        // Methods
        private void Update()
        {
            if(this.isMyViewInContent == false)
            {
                    return;
            }
            
            if(this.isMyViewInScroll == false)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_3 = this.myViewTransformAtBottom.position;
            UnityEngine.Vector3 val_4 = this.myViewTransformInScroll.position;
            var val_5 = (val_3.y > val_4.y) ? 1 : 0;
            val_5 = this.myViewTransformAtBottom.gameObject.activeSelf ^ val_5;
            if(val_5 == false)
            {
                    return;
            }
            
            this.myViewTransformAtBottom.gameObject.SetActive(value:  (val_3.y > val_4.y) ? 1 : 0);
        }
        public void AutoScroll(bool toTop, bool animate = False)
        {
            var val_2;
            if(toTop == false)
            {
                goto label_0;
            }
            
            val_2 = 0f;
            if(this != null)
            {
                goto label_1;
            }
            
            label_0:
            label_1:
            this.contentPosition = ;
            if(toTop != false)
            {
                    this.verticalScroll.MoveContentToTop(withAnimation:  animate);
                return;
            }
            
            this.verticalScroll.MoveContentToBottom(withAnimation:  true);
        }
        public void AutoScrollToMyPosition()
        {
            if(this.myRowData == null)
            {
                    return;
            }
            
            this.verticalScroll.AnimateContent(distance:  this.MyScrollRowPositionInContent());
        }
        private float MyScrollRowPositionInContent()
        {
            float val_1 = (float)this.totalCount;
            val_1 = S2 / val_1;
            val_1 = val_1 * (float)this.myRowData.rank;
            val_1 = val_1 + (-2f);
            return (float)val_1;
        }
        public bool ShouldUpdateMyRowInBottom()
        {
            if(this.myRowData == null)
            {
                    return false;
            }
            
            float val_1 = this.MyScrollRowPositionInContent();
            return (bool)(this.contentPosition < 0) ? 1 : 0;
        }
        public void SetSize(float width, float height)
        {
            UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  width, y:  height);
            this.boxCollider.size = new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
        }
        public static int FullVisibleRowCount()
        {
            int val_4 = Royal.Scenes.Home.Ui.Sections.Leaderboard.AScrollView.fullVisibleRowCount;
            if(val_4 != 0)
            {
                    return val_4;
            }
            
            Royal.Scenes.Home.Ui.Sections.Leaderboard.AScrollView.fullVisibleRowCount = ((Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1).IsDeviceTall()) != true) ? 7 : 5;
            val_4 = Royal.Scenes.Home.Ui.Sections.Leaderboard.AScrollView.fullVisibleRowCount;
            return val_4;
        }
        public abstract void PrepareContent(System.Collections.Generic.List<Royal.Infrastructure.Services.Storage.Tables.Leader> members); // 0
        protected AScrollView()
        {
        
        }
    
    }

}
