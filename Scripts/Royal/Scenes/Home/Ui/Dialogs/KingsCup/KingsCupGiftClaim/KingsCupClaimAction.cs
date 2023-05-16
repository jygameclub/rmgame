using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim
{
    public class KingsCupClaimAction : FlowAction
    {
        // Fields
        private readonly int rank;
        
        // Properties
        public override int Type { get; }
        
        // Methods
        public override int get_Type()
        {
            return 1;
        }
        public KingsCupClaimAction(int rank)
        {
            this.rank = rank;
        }
        public override void Execute()
        {
            string val_14;
            float val_15;
            float val_16;
            float val_17;
            System.Action val_19;
            object val_20;
            if((this.rank - 1) < 3)
            {
                    val_14 = mem[45230288 + ((this.rank - 1)) << 3];
                val_14 = 45230288 + ((this.rank - 1)) << 3;
            }
            else
            {
                    val_14 = "KingsCupParticipationClaim";
                if(this.rank >= 4)
            {
                    if(this.rank > 10)
            {
                    UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
                val_15 = val_4.x;
                val_16 = val_4.z;
                UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.identity;
                val_17 = val_5.y;
                Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupParticipationRewardPanel val_6 = UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupParticipationRewardPanel>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupParticipationRewardPanel>(path:  "KingsCupParticipationClaim"), position:  new UnityEngine.Vector3() {x = val_15, y = val_4.y, z = val_16}, rotation:  new UnityEngine.Quaternion() {x = val_5.x, y = val_17, z = val_5.z, w = val_5.w});
                System.Action val_7 = null;
                val_19 = val_7;
                val_20 = this;
                val_7 = new System.Action(object:  this, method:  public System.Void Royal.Scenes.Start.Context.Units.Flow.FlowAction::Complete());
                if(val_6 == null)
            {
                    throw new NullReferenceException();
            }
            
                val_6.Show(onComplete:  val_7);
                return;
            }
            
                val_14 = "KingsCupFourthGiftClaim";
            }
            
            }
            
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
            val_15 = val_9.x;
            val_16 = val_9.z;
            UnityEngine.Quaternion val_10 = UnityEngine.Quaternion.identity;
            val_17 = val_10.y;
            val_19 = UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftClaimPanel>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftClaimPanel>(path:  val_14), position:  new UnityEngine.Vector3() {x = val_15, y = val_9.y, z = val_16}, rotation:  new UnityEngine.Quaternion() {x = val_10.x, y = val_17, z = val_10.z, w = val_10.w});
            System.Action val_12 = null;
            val_20 = this;
            val_12 = new System.Action(object:  this, method:  public System.Void Royal.Scenes.Start.Context.Units.Flow.FlowAction::Complete());
            if(val_19 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_19.Show(onComplete:  val_12, inventoryPackage:  Royal.Player.Context.Data.InventoryPackage.GetKingsCupPackage(rank:  this.rank));
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
        
        }
    
    }

}
