using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Prelevel
{
    public class HardLevelTagTooltip : UiPanel
    {
        // Fields
        public TMPro.TextMeshPro info;
        public TMPro.TextMeshPro[] amounts;
        public UnityEngine.GameObject[] items;
        public UnityEngine.GameObject propeller;
        public UnityEngine.GameObject book;
        
        // Methods
        public void Prepare(int multiplier)
        {
            var val_21;
            if(multiplier != 3)
            {
                    this.info.text = this.info.text.Replace(oldChar:  '3', newChar:  '5');
            }
            
            var val_23 = 0;
            label_8:
            if(val_23 >= this.amounts.Length)
            {
                goto label_5;
            }
            
            this.amounts[val_23].text = "x" + multiplier;
            val_23 = val_23 + 1;
            if(this.amounts != null)
            {
                goto label_8;
            }
            
            throw new NullReferenceException();
            label_5:
            bool val_28 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.KingsCupManager>(id:  7).ShouldShowIcon;
            bool val_8 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.TeamBattleManager>(id:  9).ShouldShowIcon;
            bool val_9 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.MadnessManager>(id:  10).ShouldShowIcon;
            if((Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.RoyalPassManager>(id:  12).IsEventActive) != false)
            {
                    val_21 = (Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.RoyalPassManager>(id:  12).IsSafeFull()) ^ 1;
            }
            else
            {
                    val_21 = 0;
            }
            
            this.InitForMadnessEventType(madnessManagerType:  val_4.type);
            this.items[0].SetActive(value:  val_28);
            this.items[1].SetActive(value:  val_8);
            this.items[2].SetActive(value:  val_9);
            bool val_17 = val_28;
            val_17 = val_8 + val_17;
            val_17 = val_17 + val_9;
            val_28 = val_17 + (val_21 & 1);
            this.items[3].SetActive(value:  val_21 & 1);
            val_17 = val_28 - 1;
            if(val_17 > true)
            {
                    return;
            }
            
            var val_29 = 36530420 + ((((((val_8 & 1) + (val_6 & 1)) + (val_9 & 1)) + (val_21 & 1)) - 1)) << 2;
            val_29 = val_29 + 36530420;
            goto (36530420 + ((((((val_8 & 1) + (val_6 & 1)) + (val_9 & 1)) + (val_21 & 1)) - 1)) << 2 + 36530420);
        }
        private void InitForMadnessEventType(Royal.Infrastructure.Services.Backend.Protocol.MadnessEventType madnessManagerType)
        {
            if((madnessManagerType & 255) != 3)
            {
                goto label_0;
            }
            
            if(this.book != null)
            {
                goto label_1;
            }
            
            throw new NullReferenceException();
            label_0:
            label_1:
            this.book.SetActive(value:  true);
        }
        private void SetPositionForOne()
        {
            var val_9 = 4;
            label_6:
            if((val_9 - 4) >= this.items.Length)
            {
                    return;
            }
            
            if(this.items[0].activeSelf == true)
            {
                goto label_5;
            }
            
            val_9 = val_9 + 1;
            if(this.items != null)
            {
                goto label_6;
            }
            
            throw new NullReferenceException();
            label_5:
            UnityEngine.Transform val_3 = this.items[0].transform;
            UnityEngine.Vector3 val_4 = val_3.localPosition;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.left;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  2f);
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            val_3.localPosition = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
        }
        private void SetPositionForTwo()
        {
            var val_15 = 4;
            label_13:
            if((val_15 - 4) >= this.items.Length)
            {
                    return;
            }
            
            if(this.items[0].activeSelf == false)
            {
                goto label_5;
            }
            
            if(0 != 0)
            {
                goto label_6;
            }
            
            UnityEngine.Transform val_3 = this.items[0].transform;
            UnityEngine.Vector3 val_4 = val_3.localPosition;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.left;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  2.928f);
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            val_3.localPosition = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            label_5:
            val_15 = val_15 + 1;
            if(this.items != null)
            {
                goto label_13;
            }
            
            throw new NullReferenceException();
            label_6:
            UnityEngine.Transform val_8 = this.items[0].transform;
            UnityEngine.Vector3 val_9 = val_8.localPosition;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.left;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, d:  1.278f);
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            val_8.localPosition = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
        }
        private void SetPositionForThree()
        {
            float val_17;
            var val_21 = 4;
            label_21:
            if((val_21 - 4) >= this.items.Length)
            {
                    return;
            }
            
            if(this.items[0].activeSelf == false)
            {
                goto label_14;
            }
            
            if(0 == 1)
            {
                goto label_6;
            }
            
            if(0 != 0)
            {
                goto label_7;
            }
            
            UnityEngine.Transform val_3 = this.items[0].transform;
            UnityEngine.Vector3 val_4 = val_3.localPosition;
            val_17 = val_4.x;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.left;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  3.79f);
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_17, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            val_3.localPosition = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            goto label_14;
            label_6:
            UnityEngine.Transform val_8 = this.items[0].transform;
            UnityEngine.Vector3 val_9 = val_8.localPosition;
            val_17 = val_9.x;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.left;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, d:  2.2f);
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_17, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            val_8.localPosition = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
            label_14:
            val_21 = val_21 + 1;
            if(this.items != null)
            {
                goto label_21;
            }
            
            throw new NullReferenceException();
            label_7:
            UnityEngine.Transform val_13 = this.items[0].transform;
            UnityEngine.Vector3 val_14 = val_13.localPosition;
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.left;
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, d:  0.55f);
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, b:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
            val_13.localPosition = new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z};
        }
        private void SetPositionForFour()
        {
            float val_22;
            var val_27 = 4;
            label_29:
            if((val_27 - 4) >= this.items.Length)
            {
                    return;
            }
            
            if(this.items[0].activeSelf == false)
            {
                goto label_22;
            }
            
            if(0 == 2)
            {
                goto label_6;
            }
            
            if(0 == 1)
            {
                goto label_7;
            }
            
            if(0 != 0)
            {
                goto label_8;
            }
            
            UnityEngine.Transform val_3 = this.items[0].transform;
            UnityEngine.Vector3 val_4 = val_3.localPosition;
            val_22 = val_4.y;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.left;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  4.27f);
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_22, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            val_3.localPosition = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            goto label_22;
            label_7:
            UnityEngine.Transform val_8 = this.items[0].transform;
            UnityEngine.Vector3 val_9 = val_8.localPosition;
            val_22 = val_9.y;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.left;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, d:  2.76f);
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_22, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            val_8.localPosition = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
            goto label_22;
            label_6:
            UnityEngine.Transform val_13 = this.items[0].transform;
            UnityEngine.Vector3 val_14 = val_13.localPosition;
            val_22 = val_14.y;
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.left;
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, d:  1.14f);
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_22, z = val_14.z}, b:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
            val_13.localPosition = new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z};
            label_22:
            val_27 = val_27 + 1;
            if(this.items != null)
            {
                goto label_29;
            }
            
            throw new NullReferenceException();
            label_8:
            UnityEngine.Transform val_18 = this.items[0].transform;
            UnityEngine.Vector3 val_19 = val_18.localPosition;
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.right;
            UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, d:  0.29f);
            UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, b:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z});
            val_18.localPosition = new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z};
        }
        public HardLevelTagTooltip()
        {
        
        }
    
    }

}
