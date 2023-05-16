using UnityEngine;

namespace Royal.Player.Context.Data.Session
{
    public struct SpendingData
    {
        // Fields
        private readonly int <CoinAmount>k__BackingField;
        private readonly string <SpendingName>k__BackingField;
        
        // Properties
        public int CoinAmount { get; }
        public string SpendingName { get; }
        
        // Methods
        public int get_CoinAmount()
        {
            return (int)this;
        }
        public string get_SpendingName()
        {
            return (string)this;
        }
        public SpendingData(string spendingName, int coinAmount)
        {
            mem[1152921524216511680] = coinAmount;
            mem[1152921524216511688] = spendingName;
        }
    
    }

}
