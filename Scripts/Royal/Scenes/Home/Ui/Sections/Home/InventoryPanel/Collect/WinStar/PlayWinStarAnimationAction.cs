using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.WinStar
{
    public class PlayWinStarAnimationAction : AnimationAction
    {
        // Fields
        private int frameCount;
        private readonly Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.StarInfoView starInfoView;
        private readonly Royal.Scenes.Game.Mechanics.Sortings.SortingData sortingData;
        
        // Methods
        public PlayWinStarAnimationAction(Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.StarInfoView starInfoView, Royal.Scenes.Game.Mechanics.Sortings.SortingData sortingData)
        {
            this.starInfoView = starInfoView;
            this.sortingData = sortingData;
            mem[1152921519112165456] = sortingData.sortEverything;
        }
        protected override float GetDurationForNextAction()
        {
            return Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  (float)this.frameCount);
        }
        public override void Execute()
        {
            this.frameCount = ((Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg + 40 + 16) == 0) ? 85 : 27;
            this.Execute();
            UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.WinStar.WinStarView>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.WinStar.WinStarView>(path:  "WinStar")).Play(starInfoView:  this.starInfoView, sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = this.sortingData, order = this.sortingData, sortEverything = false});
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
            this.Complete();
        }
    
    }

}
