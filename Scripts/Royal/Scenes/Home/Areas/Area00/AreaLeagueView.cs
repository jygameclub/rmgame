using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area00
{
    public class AreaLeagueView : AreaView
    {
        // Methods
        public override void ShowCompletedTasks()
        {
            if(this != null)
            {
                    this.ResetView();
                return;
            }
            
            throw new NullReferenceException();
        }
        public AreaLeagueView()
        {
        
        }
    
    }

}
