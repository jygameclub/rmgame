using UnityEngine;

namespace Royal.Player.Context
{
    public class UserContext : IContextBehaviour, IContextUnit
    {
        // Fields
        private static readonly Royal.Infrastructure.Contexts.ContextContainer<Royal.Infrastructure.Contexts.IContextUnit> Container;
        
        // Properties
        public int Id { get; }
        
        // Methods
        public int get_Id()
        {
            return 9;
        }
        public void Bind()
        {
            long val_1 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.GetLong(key:  "UserId", defaultValue:  0);
            object[] val_2 = new object[1];
            val_2[0] = val_1;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  9, log:  "UserId: {0}", values:  val_2);
            Royal.Player.Context.UserContext.Add<Royal.Infrastructure.Services.Storage.DatabaseService>(unit:  new Royal.Infrastructure.Services.Storage.DatabaseService(userId:  val_1));
            Royal.Player.Context.Units.UserManager.LoadUserFromLocalStorage(id:  val_1);
            Royal.Player.Context.UserContext.Add<Royal.Player.Context.Units.UserManager>(unit:  new Royal.Player.Context.Units.UserManager());
            Royal.Player.Context.UserContext.Add<Royal.Player.Context.Units.LevelManager>(unit:  new Royal.Player.Context.Units.LevelManager());
            Royal.Player.Context.UserContext.Add<Royal.Player.Context.Units.LifeHelper>(unit:  new Royal.Player.Context.Units.LifeHelper());
            Royal.Player.Context.UserContext.Add<Royal.Player.Context.Units.SocialManager>(unit:  new Royal.Player.Context.Units.SocialManager());
            Royal.Player.Context.UserContext.Add<Royal.Player.Context.Units.LeagueManager>(unit:  new Royal.Player.Context.Units.LeagueManager());
            Royal.Player.Context.UserContext.Add<Royal.Player.Context.Units.LeaderboardManager>(unit:  new Royal.Player.Context.Units.LeaderboardManager());
            Royal.Player.Context.UserContext.Add<Royal.Player.Context.Units.KingsCupManager>(unit:  new Royal.Player.Context.Units.KingsCupManager());
            Royal.Player.Context.UserContext.Add<Royal.Player.Context.Units.PiggyBankManager>(unit:  new Royal.Player.Context.Units.PiggyBankManager());
            Royal.Player.Context.UserContext.Add<Royal.Player.Context.Units.TeamBattleManager>(unit:  new Royal.Player.Context.Units.TeamBattleManager());
            Royal.Player.Context.UserContext.Add<Royal.Player.Context.Units.MadnessManager>(unit:  new Royal.Player.Context.Units.MadnessManager());
            Royal.Player.Context.UserContext.Add<Royal.Player.Context.Units.LadderOfferManager>(unit:  new Royal.Player.Context.Units.LadderOfferManager());
            Royal.Player.Context.UserContext.Add<Royal.Player.Context.Units.RoyalPassManager>(unit:  new Royal.Player.Context.Units.RoyalPassManager());
            Royal.Player.Context.UserContext.Container.BindAll();
        }
        public void ManualUpdate()
        {
            null = null;
            Royal.Player.Context.UserContext.Container.ManualUpdate();
        }
        public static void Add<T>(T unit)
        {
            null = null;
            Royal.Player.Context.UserContext.Container.Add(unit:  unit);
        }
        public static T Get<T>(Royal.Player.Context.UserContextId id)
        {
            null = null;
            goto __RuntimeMethodHiddenParam + 48;
        }
        public static Royal.Infrastructure.Contexts.ContextContainer<Royal.Infrastructure.Contexts.IContextUnit> GetContainer()
        {
            null = null;
            return (Royal.Infrastructure.Contexts.ContextContainer<Royal.Infrastructure.Contexts.IContextUnit>)Royal.Player.Context.UserContext.Container;
        }
        public static void Clear()
        {
            null = null;
            Royal.Player.Context.UserContext.Container.Clear();
        }
        public UserContext()
        {
        
        }
        private static UserContext()
        {
            System.String[] val_2 = System.Enum.GetNames(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            Royal.Player.Context.UserContext.Container = new Royal.Infrastructure.Contexts.ContextContainer<Royal.Infrastructure.Contexts.IContextUnit>(contextUnitCount:  val_2.Length);
        }
    
    }

}
