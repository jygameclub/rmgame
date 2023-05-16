using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.League
{
    public class SendCheckLeagueCommandAction : CommandAction
    {
        // Methods
        public override void Execute()
        {
            if((Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LeagueManager>(id:  5).ShouldCheckActiveLeague()) != false)
            {
                    Royal.Infrastructure.Services.Backend.Http.Command.League.CheckLeagueHttpCommand val_3 = new Royal.Infrastructure.Services.Backend.Http.Command.League.CheckLeagueHttpCommand();
                0 = val_3;
                bool val_4 = Send(httpCommand:  val_3, onComplete:  0, syncRequired:  false);
            }
            
            this.Complete();
        }
        public SendCheckLeagueCommandAction()
        {
        
        }
    
    }

}
