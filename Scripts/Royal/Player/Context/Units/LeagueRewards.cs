using UnityEngine;

namespace Royal.Player.Context.Units
{
    [Serializable]
    public class LeagueRewards
    {
        // Fields
        public int id;
        public int[] amounts;
        
        // Methods
        public static Royal.Player.Context.Units.LeagueRewards DefaultRewards()
        {
            .amounts = new int[10] {5000, 3000, 2000, 3, 3, 3, 3, 3, 3, 3};
            return (Royal.Player.Context.Units.LeagueRewards)new Royal.Player.Context.Units.LeagueRewards();
        }
        public LeagueRewards()
        {
        
        }
    
    }

}
