using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Episodes
{
    public class EpisodesSection : Section
    {
        // Fields
        public Royal.Scenes.Home.Ui.Sections.Episodes.EpisodeScroll scrollView;
        
        // Methods
        protected override void OnInitCompleted()
        {
            Royal.Infrastructure.Contexts.Units.CameraManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            float val_8 = this.BottomYPositionOfTopUi();
            val_8 = val_8 - this.TopYPositionOfBottomUi();
            this.scrollView.SetSize(width:  val_1.cameraWidth, height:  val_8);
            float val_9 = -0.5f;
            val_9 = val_8 * val_9;
            val_9 = this.BottomYPositionOfTopUi() + val_9;
            UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  0f, y:  val_9);
            UnityEngine.Vector3 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
            this.scrollView.transform.localPosition = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            this.scrollView.InitContent();
        }
        public void EnableScroll(bool enable)
        {
            this.enabled = enable;
            this.scrollView.scroll = enable;
            if(enable == false)
            {
                    return;
            }
            
            this.scrollView.scroll = 0;
        }
        public EpisodesSection()
        {
        
        }
    
    }

}
