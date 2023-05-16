using UnityEngine;

namespace Royal.Scenes.Game.Ui
{
    public class GameUi : MonoBehaviour
    {
        // Fields
        public Royal.Scenes.Game.Ui.Top.TopUi topUi;
        public Royal.Scenes.Game.Ui.Bottom.BottomUi bottomUi;
        public Royal.Scenes.Game.Story.KingDrillRoom drillRoom;
        
        // Methods
        private System.Collections.IEnumerator Start()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new GameUi.<Start>d__3();
        }
        public void StartLevelWithAnimation(bool initialAnimation = False)
        {
            initialAnimation = initialAnimation;
            if(Royal.Player.Context.Units.LevelManager.IsStoryLevel != false)
            {
                    this.StartStoryLevel(initialAnimation:  initialAnimation);
                return;
            }
            
            this.StartDefaultLevel(initialAnimation:  initialAnimation);
        }
        private void StartDefaultLevel(bool initialAnimation = False)
        {
            DG.Tweening.Sequence val_3 = DG.Tweening.DOTween.Sequence();
            if(initialAnimation != false)
            {
                    this.topUi.PrepareTransformAnimation(seq:  val_3);
                this.bottomUi.PrepareTransformAnimation(seq:  val_3);
            }
            
            Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.CellGridManager>(contextId:  2).PrepareGridTransformAnimation(seq:  val_3);
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_3, action:  new DG.Tweening.TweenCallback(object:  Royal.Scenes.Game.Context.GameContext.Get<Royal.Scenes.Game.Context.Units.GameManager>(id:  1), method:  public System.Void Royal.Scenes.Game.Context.Units.GameManager::GridAnimationCompleted()));
        }
        private void StartStoryLevel(bool initialAnimation = False)
        {
            Royal.Scenes.Game.Context.GameContext.Get<Royal.Scenes.Game.Context.Units.GameManager>(id:  1).GridAnimationCompleted();
            if(initialAnimation != false)
            {
                    return;
            }
            
            this.drillRoom.Init();
        }
        private void CreateKingDrill()
        {
            Royal.Scenes.Game.Story.KingDrillRoom val_2 = UnityEngine.Object.Instantiate<Royal.Scenes.Game.Story.KingDrillRoom>(original:  UnityEngine.Resources.Load<Royal.Scenes.Game.Story.KingDrillRoom>(path:  "KingDrillRoom"));
            this.drillRoom = val_2;
            val_2.Init();
        }
        public GameUi()
        {
        
        }
    
    }

}
