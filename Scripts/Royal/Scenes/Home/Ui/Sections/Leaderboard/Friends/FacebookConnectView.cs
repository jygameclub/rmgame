using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Leaderboard.Friends
{
    public class FacebookConnectView : MonoBehaviour
    {
        // Fields
        private const float DefaultSectionHeight = 14.73185;
        private const float MaxBottomPosLocalPositionY = -9.8;
        public UnityEngine.Transform topPositioner;
        public UnityEngine.Transform bottomPositioner;
        public UnityEngine.Transform facebookButton;
        public UnityEngine.Transform king;
        public UnityEngine.Transform container;
        public UnityEngine.SpriteRenderer whiteContainerLeft;
        public UnityEngine.SpriteRenderer whiteContainerRight;
        public UnityEngine.SpriteRenderer blackContainerLeft;
        public UnityEngine.SpriteRenderer blackContainerRight;
        public UnityEngine.TextAsset facebookKingAsset;
        public UnityEngine.SpriteRenderer facebookKing;
        private Royal.Scenes.Home.Ui.Sections.Leaderboard.LeaderboardSection section;
        private Royal.Scenes.Home.Ui.Sections.Leaderboard.Friends.FriendsView friendsView;
        private Royal.Infrastructure.Contexts.Units.CameraManager camManager;
        
        // Methods
        public void Init(Royal.Scenes.Home.Ui.Sections.Leaderboard.LeaderboardSection section, Royal.Scenes.Home.Ui.Sections.Leaderboard.Friends.FriendsView friendsView)
        {
            this.facebookKing.sprite = Royal.Infrastructure.Utils.Sprite.SpriteExtensions.ToSprite(textAsset:  this.facebookKingAsset, width:  244, height:  114, format:  4);
            this.section = section;
            this.friendsView = friendsView;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            this.transform.localPosition = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            this.camManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            this.ArrangeSizes();
            this.ArrangePositions();
        }
        private void ArrangeSizes()
        {
            UnityEngine.Vector3 val_6 = this.bottomPositioner.transform.localPosition;
            float val_16 = val_6.y;
            val_6.y = val_16 - ((this.section.GetBottomYOfTabButtons() - this.section.TopYPositionOfBottomUi()) + (-14.73185f));
            float val_15 = UnityEngine.Mathf.Min(a:  -9.8f, b:  val_6.y);
            this.bottomPositioner.transform.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_15, z = val_6.z};
            UnityEngine.Vector2 val_9 = this.blackContainerLeft.size;
            val_15 = val_16 - val_15;
            val_16 = val_15 + val_9.y;
            this.blackContainerLeft.size = new UnityEngine.Vector2() {x = val_9.x, y = val_16};
            this.blackContainerRight.size = new UnityEngine.Vector2() {x = val_9.x, y = val_16};
            UnityEngine.Vector2 val_10 = this.whiteContainerLeft.size;
            float val_11 = val_15 + val_10.y;
            this.whiteContainerLeft.size = new UnityEngine.Vector2() {x = val_10.x, y = val_11};
            this.whiteContainerRight.size = new UnityEngine.Vector2() {x = val_10.x, y = val_11};
            UnityEngine.Vector3 val_13 = this.container.transform.position;
            float val_17 = -0.5f;
            val_17 = val_15 * val_17;
            val_13.y = val_13.y + val_17;
            this.container.transform.position = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
        }
        private void ArrangePositions()
        {
            float val_33;
            float val_34;
            float val_35;
            float val_36;
            float val_37;
            var val_38;
            float val_39;
            UnityEngine.Vector3 val_2 = this.transform.position;
            this.topPositioner.transform.position = new UnityEngine.Vector3() {x = val_2.x, y = this.section.GetBottomYOfTabButtons(), z = val_2.z};
            UnityEngine.Vector3 val_6 = this.bottomPositioner.transform.position;
            val_33 = val_6.x;
            val_34 = val_6.z;
            if(this.camManager.IsDeviceTall() == false)
            {
                goto label_8;
            }
            
            UnityEngine.Transform val_10 = this.transform;
            UnityEngine.Vector3 val_11 = val_10.localPosition;
            val_35 = val_11.x;
            if(this.camManager.HasBigNotch() == false)
            {
                goto label_12;
            }
            
            val_36 = 0.2f;
            goto label_22;
            label_8:
            if(this.camManager.IsDeviceWide() == false)
            {
                goto label_16;
            }
            
            UnityEngine.Transform val_14 = this.transform;
            val_37 = -0.46963f;
            val_38 = val_14;
            UnityEngine.Vector3 val_15 = val_14.localPosition;
            val_35 = val_15.y;
            val_39 = val_6.y + val_37;
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, d:  0.42f);
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_35, z = val_15.z}, b:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
            val_38.localPosition = new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z};
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.one;
            goto label_20;
            label_12:
            val_36 = 0.38f;
            label_22:
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, d:  val_36);
            val_37 = val_21.z;
            val_39 = val_6.y - ((this.camManager.HasBigNotch() != true) ? 1.58f : 2.08f);
            UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_35, y = val_11.y, z = val_11.z}, b:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_37});
            val_10.localPosition = new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z};
            val_34 = val_34;
            val_33 = val_33;
            goto label_25;
            label_16:
            UnityEngine.Transform val_23 = this.transform;
            val_37 = 0.029f;
            val_38 = val_23;
            UnityEngine.Vector3 val_24 = val_23.localPosition;
            val_35 = val_24.y;
            val_39 = val_6.y + val_37;
            UnityEngine.Vector3 val_25 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z}, d:  0.55f);
            UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_24.x, y = val_35, z = val_24.z}, b:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z});
            val_38.localPosition = new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z};
            UnityEngine.Vector3 val_28 = UnityEngine.Vector3.one;
            label_20:
            UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z}, d:  0.85f);
            val_38.localScale = new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z};
            label_25:
            this.facebookButton.transform.position = new UnityEngine.Vector3() {x = val_33, y = val_39, z = val_34};
        }
        public void TapFacebookButton()
        {
            if(this.friendsView != null)
            {
                    this.friendsView.LoginFacebook();
                return;
            }
            
            throw new NullReferenceException();
        }
        public FacebookConnectView()
        {
        
        }
    
    }

}
