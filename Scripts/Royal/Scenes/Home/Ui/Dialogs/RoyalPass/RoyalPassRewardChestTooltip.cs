using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass
{
    public class RoyalPassRewardChestTooltip : UiPanel
    {
        // Fields
        public UnityEngine.GameObject upArrow;
        public UnityEngine.GameObject downArrow;
        public UnityEngine.BoxCollider2D tooltipCollider;
        public UnityEngine.GameObject[] items;
        public TMPro.TextMeshPro[] amountOrDurations;
        public UnityEngine.GameObject[] containers;
        public UnityEngine.Transform[] twoRewardsPositions;
        public UnityEngine.Transform[] threeRewardsPositions;
        public UnityEngine.Transform[] fourRewardsPositions;
        public UnityEngine.Transform[] fiveRewardsPositions;
        public UnityEngine.Transform[] sixRewardsPositions;
        public UnityEngine.Transform[] twoPlusPositions;
        public UnityEngine.Transform[] threePlusPositions;
        public UnityEngine.Transform[] fourPlusPositions;
        public UnityEngine.Transform[] fivePlusPositions;
        private UnityEngine.Transform[] positions;
        private System.Collections.Generic.List<UnityEngine.GameObject> rewardList;
        private System.Collections.Generic.List<TMPro.TextMeshPro> textList;
        private int containerIndex;
        
        // Methods
        public void Prepare(bool isFree, Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassReward[] rewards, int step)
        {
            UnityEngine.Transform[] val_66;
            float val_67;
            float val_68;
            float val_69;
            UnityEngine.Transform val_70;
            float val_71;
            float val_72;
            float val_73;
            this.rewardList = new System.Collections.Generic.List<UnityEngine.GameObject>();
            this.textList = new System.Collections.Generic.List<TMPro.TextMeshPro>();
            if(rewards.Length >= 1)
            {
                    var val_68 = 0;
                do
            {
                this.AddReward(rewardType:  rewards[val_68].GetRewardType(), reward:  rewards[0x0] + 32);
                val_68 = val_68 + 1;
            }
            while(val_68 < rewards.Length);
            
            }
            
            System.Collections.Generic.List<UnityEngine.GameObject> val_69 = this.rewardList;
            val_69 = val_69 - 2;
            this.containerIndex = val_69;
            if(val_69 > 3)
            {
                goto label_8;
            }
            
            var val_70 = 36595704;
            val_70 = (36595704 + ((this.rewardList - 2)) << 2) + val_70;
            goto (36595704 + ((this.rewardList - 2)) << 2 + 36595704);
            label_8:
            val_66 = this.sixRewardsPositions;
            this.positions = mem[this.fiveRewardsPositions];
            this.containers[val_69].SetActive(value:  true);
            bool val_4 = isFree;
            this.SetColliderSize(isFree:  val_4);
            this.SetTooltipVerticalDirection();
            this.SetHorizontalPosition(isFree:  val_4);
            var val_77 = 4;
            label_33:
            var val_5 = val_77 - 4;
            if(val_5 >= this.containers[val_69])
            {
                goto label_17;
            }
            
            if(this.containers[val_69] <= val_5)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            UnityEngine.Vector3 val_7 = this.positions[0].position;
            this.containers[val_69].transform.position = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            if(this.positions <= val_5)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            this.positions[0].transform.SetParent(p:  this.positions[0]);
            if(this.positions <= val_5)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            this.positions[0].SetActive(value:  true);
            val_77 = val_77 + 1;
            if(this.rewardList != null)
            {
                goto label_33;
            }
            
            label_17:
            if(step <= 15)
            {
                goto label_35;
            }
            
            if(step == 20)
            {
                goto label_36;
            }
            
            if(step != 25)
            {
                goto label_37;
            }
            
            if(isFree == false)
            {
                goto label_38;
            }
            
            UnityEngine.Transform val_78 = this.threeRewardsPositions[0];
            UnityEngine.Vector3 val_9 = val_78.localPosition;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.left;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, d:  0.12f);
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            val_78.localPosition = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
            UnityEngine.Transform val_79 = this.threeRewardsPositions[1];
            UnityEngine.Vector3 val_13 = val_79.localPosition;
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.right;
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, d:  0.044f);
            val_67 = val_13.x;
            val_68 = val_13.y;
            val_69 = val_13.z;
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_67, y = val_68, z = val_69}, b:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
            val_79.localPosition = new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z};
            val_70 = this.threePlusPositions[0];
            UnityEngine.Vector3 val_17 = val_70.localPosition;
            val_71 = val_17.x;
            val_72 = val_17.y;
            val_73 = val_17.z;
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.right;
            goto label_116;
            label_35:
            if(step == 5)
            {
                goto label_51;
            }
            
            if(step == 10)
            {
                goto label_52;
            }
            
            if(step != 15)
            {
                    return;
            }
            
            if(isFree == false)
            {
                goto label_54;
            }
            
            val_70 = this.twoRewardsPositions[0];
            UnityEngine.Vector3 val_19 = val_70.localPosition;
            val_71 = val_19.x;
            val_72 = val_19.y;
            val_73 = val_19.z;
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.right;
            goto label_116;
            label_36:
            if(isFree == true)
            {
                    return;
            }
            
            UnityEngine.Transform val_80 = this.fiveRewardsPositions[0];
            UnityEngine.Vector3 val_21 = val_80.localPosition;
            UnityEngine.Vector3 val_22 = UnityEngine.Vector3.right;
            UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, d:  0.1f);
            UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z}, b:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z});
            val_80.localPosition = new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z};
            UnityEngine.Transform val_81 = this.fiveRewardsPositions[3];
            UnityEngine.Vector3 val_25 = val_81.localPosition;
            UnityEngine.Vector3 val_26 = UnityEngine.Vector3.right;
            UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z}, d:  0.035f);
            val_67 = val_25.x;
            val_68 = val_25.y;
            val_69 = val_25.z;
            UnityEngine.Vector3 val_28 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_67, y = val_68, z = val_69}, b:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z});
            val_81.localPosition = new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z};
            val_70 = this.fivePlusPositions[3];
            UnityEngine.Vector3 val_29 = val_70.localPosition;
            val_71 = val_29.x;
            val_72 = val_29.y;
            val_73 = val_29.z;
            UnityEngine.Vector3 val_30 = UnityEngine.Vector3.right;
            goto label_116;
            label_37:
            if(step != 30)
            {
                    return;
            }
            
            if(isFree == false)
            {
                    return;
            }
            
            UnityEngine.Transform val_82 = this.fourRewardsPositions[0];
            UnityEngine.Vector3 val_31 = val_82.localPosition;
            UnityEngine.Vector3 val_32 = UnityEngine.Vector3.right;
            UnityEngine.Vector3 val_33 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_32.x, y = val_32.y, z = val_32.z}, d:  0.08f);
            val_67 = val_31.x;
            val_68 = val_31.y;
            val_69 = val_31.z;
            UnityEngine.Vector3 val_34 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_67, y = val_68, z = val_69}, b:  new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z});
            val_82.localPosition = new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_34.z};
            val_70 = this.fourRewardsPositions[2];
            UnityEngine.Vector3 val_35 = val_70.localPosition;
            val_71 = val_35.x;
            val_72 = val_35.y;
            val_73 = val_35.z;
            UnityEngine.Vector3 val_36 = UnityEngine.Vector3.right;
            goto label_116;
            label_51:
            if(isFree == false)
            {
                    return;
            }
            
            val_70 = this.twoPlusPositions[0];
            UnityEngine.Vector3 val_37 = val_70.localPosition;
            val_71 = val_37.x;
            val_72 = val_37.y;
            val_73 = val_37.z;
            UnityEngine.Vector3 val_38 = UnityEngine.Vector3.right;
            goto label_116;
            label_52:
            if(isFree == false)
            {
                goto label_92;
            }
            
            return;
            label_38:
            UnityEngine.Transform val_83 = this.fourRewardsPositions[0];
            UnityEngine.Vector3 val_39 = val_83.localPosition;
            UnityEngine.Vector3 val_40 = UnityEngine.Vector3.right;
            UnityEngine.Vector3 val_41 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_40.x, y = val_40.y, z = val_40.z}, d:  0.157f);
            UnityEngine.Vector3 val_42 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_39.x, y = val_39.y, z = val_39.z}, b:  new UnityEngine.Vector3() {x = val_41.x, y = val_41.y, z = val_41.z});
            val_83.localPosition = new UnityEngine.Vector3() {x = val_42.x, y = val_42.y, z = val_42.z};
            UnityEngine.Transform val_84 = this.fourRewardsPositions[1];
            UnityEngine.Vector3 val_43 = val_84.localPosition;
            UnityEngine.Vector3 val_44 = UnityEngine.Vector3.left;
            UnityEngine.Vector3 val_45 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_44.x, y = val_44.y, z = val_44.z}, d:  0.112f);
            UnityEngine.Vector3 val_46 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_43.x, y = val_43.y, z = val_43.z}, b:  new UnityEngine.Vector3() {x = val_45.x, y = val_45.y, z = val_45.z});
            val_84.localPosition = new UnityEngine.Vector3() {x = val_46.x, y = val_46.y, z = val_46.z};
            UnityEngine.Transform val_85 = this.fourRewardsPositions[2];
            UnityEngine.Vector3 val_47 = val_85.localPosition;
            UnityEngine.Vector3 val_48 = UnityEngine.Vector3.right;
            UnityEngine.Vector3 val_49 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_48.x, y = val_48.y, z = val_48.z}, d:  0.034f);
            val_67 = val_47.x;
            val_68 = val_47.y;
            val_69 = val_47.z;
            UnityEngine.Vector3 val_50 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_67, y = val_68, z = val_69}, b:  new UnityEngine.Vector3() {x = val_49.x, y = val_49.y, z = val_49.z});
            val_85.localPosition = new UnityEngine.Vector3() {x = val_50.x, y = val_50.y, z = val_50.z};
            val_70 = this.fourPlusPositions[2];
            UnityEngine.Vector3 val_51 = val_70.localPosition;
            val_71 = val_51.x;
            val_72 = val_51.y;
            val_73 = val_51.z;
            UnityEngine.Vector3 val_52 = UnityEngine.Vector3.right;
            goto label_116;
            label_54:
            UnityEngine.Transform val_86 = this.fourRewardsPositions[2];
            UnityEngine.Vector3 val_53 = val_86.localPosition;
            UnityEngine.Vector3 val_54 = UnityEngine.Vector3.right;
            UnityEngine.Vector3 val_55 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_54.x, y = val_54.y, z = val_54.z}, d:  0.11f);
            val_67 = val_53.x;
            val_68 = val_53.y;
            val_69 = val_53.z;
            UnityEngine.Vector3 val_56 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_67, y = val_68, z = val_69}, b:  new UnityEngine.Vector3() {x = val_55.x, y = val_55.y, z = val_55.z});
            val_86.localPosition = new UnityEngine.Vector3() {x = val_56.x, y = val_56.y, z = val_56.z};
            val_70 = this.fourPlusPositions[2];
            UnityEngine.Vector3 val_57 = val_70.localPosition;
            val_71 = val_57.x;
            val_72 = val_57.y;
            val_73 = val_57.z;
            UnityEngine.Vector3 val_58 = UnityEngine.Vector3.right;
            goto label_116;
            label_92:
            UnityEngine.Transform val_87 = this.fiveRewardsPositions[3];
            UnityEngine.Vector3 val_59 = val_87.localPosition;
            UnityEngine.Vector3 val_60 = UnityEngine.Vector3.right;
            UnityEngine.Vector3 val_61 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_60.x, y = val_60.y, z = val_60.z}, d:  0.065f);
            val_67 = val_59.x;
            val_68 = val_59.y;
            val_69 = val_59.z;
            UnityEngine.Vector3 val_62 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_67, y = val_68, z = val_69}, b:  new UnityEngine.Vector3() {x = val_61.x, y = val_61.y, z = val_61.z});
            val_87.localPosition = new UnityEngine.Vector3() {x = val_62.x, y = val_62.y, z = val_62.z};
            val_70 = this.fivePlusPositions[3];
            UnityEngine.Vector3 val_63 = val_70.localPosition;
            val_71 = val_63.x;
            val_72 = val_63.y;
            val_73 = val_63.z;
            UnityEngine.Vector3 val_64 = UnityEngine.Vector3.right;
            label_116:
            UnityEngine.Vector3 val_65 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_64.x, y = val_64.y, z = val_64.z}, d:  0.076f);
            UnityEngine.Vector3 val_66 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_71, y = val_72, z = val_73}, b:  new UnityEngine.Vector3() {x = val_65.x, y = val_65.y, z = val_65.z});
            val_70.localPosition = new UnityEngine.Vector3() {x = val_66.x, y = val_66.y, z = val_66.z};
        }
        private void SetTooltipVerticalDirection()
        {
            float val_29;
            float val_30;
            float val_31;
            UnityEngine.Vector3 val_3 = this.transform.position;
            UnityEngine.Vector3 val_4 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1).GetSafeTopCenterOfCamera();
            float val_29 = -12f;
            val_29 = val_4.y + val_29;
            if(val_3.y <= val_29)
            {
                goto label_6;
            }
            
            this.upArrow.SetActive(value:  true);
            this.downArrow.SetActive(value:  false);
            UnityEngine.Transform val_5 = this.transform;
            UnityEngine.Vector3 val_6 = val_5.localPosition;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  1.1f);
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            val_5.localPosition = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
            UnityEngine.Transform val_10 = this.containers[this.containerIndex].transform;
            UnityEngine.Vector3 val_11 = val_10.localPosition;
            if(this.containerIndex != 4)
            {
                goto label_15;
            }
            
            val_29 = 0.673f;
            goto label_30;
            label_6:
            this.upArrow.SetActive(value:  false);
            this.downArrow.SetActive(value:  true);
            UnityEngine.Transform val_12 = this.transform;
            UnityEngine.Vector3 val_13 = val_12.localPosition;
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, d:  1.1f);
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, b:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
            val_12.localPosition = new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z};
            UnityEngine.Transform val_17 = this.containers[this.containerIndex].transform;
            UnityEngine.Vector3 val_18 = val_17.localPosition;
            if(this.containerIndex != 4)
            {
                goto label_26;
            }
            
            val_30 = 2.124f;
            goto label_38;
            label_15:
            val_29 = 0.596f;
            label_30:
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, d:  val_29);
            UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, b:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z});
            val_10.localPosition = new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z};
            UnityEngine.Vector2 val_22 = this.tooltipCollider.offset;
            if(this.containerIndex != 4)
            {
                goto label_34;
            }
            
            val_31 = 2.5f;
            goto label_42;
            label_26:
            val_30 = 1.252f;
            label_38:
            UnityEngine.Vector3 val_23 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, d:  val_30);
            UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, b:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z});
            val_17.localPosition = new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z};
            return;
            label_34:
            val_31 = 1.35f;
            label_42:
            UnityEngine.Vector2 val_26 = UnityEngine.Vector2.down;
            UnityEngine.Vector2 val_27 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_26.x, y = val_26.y}, d:  val_31);
            UnityEngine.Vector2 val_28 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_22.x, y = val_22.y}, b:  new UnityEngine.Vector2() {x = val_27.x, y = val_27.y});
            this.tooltipCollider.offset = new UnityEngine.Vector2() {x = val_28.x, y = val_28.y};
        }
        private void SetHorizontalPosition(bool isFree)
        {
            UnityEngine.Transform val_1 = this.containers[this.containerIndex].transform;
            UnityEngine.Vector3 val_2 = val_1.localPosition;
            if(isFree != false)
            {
                    UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                val_1.localPosition = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
                return;
            }
            
            if(this.containerIndex == 2)
            {
                goto label_8;
            }
            
            if(this.containerIndex != 3)
            {
                goto label_9;
            }
            
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.left;
            goto label_15;
            label_8:
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.left;
            goto label_15;
            label_9:
            if(this.containerIndex != 4)
            {
                goto label_16;
            }
            
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.right;
            label_15:
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  0.836f);
            label_23:
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            val_1.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            return;
            label_16:
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
            goto label_23;
        }
        private void SetColliderSize(bool isFree)
        {
            if(this.containerIndex > 4)
            {
                    return;
            }
            
            var val_8 = 36595780 + (this.containerIndex) << 2;
            val_8 = val_8 + 36595780;
            goto (36595780 + (this.containerIndex) << 2 + 36595780);
        }
        public void AddReward(Royal.Player.Context.Units.RewardType rewardType, Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassReward reward)
        {
            var val_29;
            var val_30;
            val_29 = reward;
            val_30 = rewardType;
            if((val_30 - 1) > 14)
            {
                    return;
            }
            
            var val_29 = 36595720 + ((rewardType - 1)) << 2;
            val_29 = val_29 + 36595720;
            goto (36595720 + ((rewardType - 1)) << 2 + 36595720);
        }
        public void ArrangeText(TMPro.TextMeshPro text, UnityEngine.GameObject item, bool isHour = False)
        {
            var val_4;
            bool val_5;
            val_4 = item;
            T[] val_1 = val_4.GetComponentsInChildren<Royal.Infrastructure.Utils.Text.TextPositioner>();
            if(val_1 != null)
            {
                    val_4 = val_1;
                string val_2 = text.text;
                if(val_1.Length >= 1)
            {
                    var val_4 = 0;
                do
            {
                1152921506484931120.ArrangeTransformByCharCount(charCount:  (Royal.Infrastructure.Services.Localization.LocalizationHelper.isArabic == false) ? 2 : val_2.m_stringLength);
                val_4 = val_4 + 1;
            }
            while(val_4 < val_1.Length);
            
            }
            
            }
            
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isJapanese != false)
            {
                    val_5 = 1;
            }
            else
            {
                    val_5 = Royal.Infrastructure.Services.Localization.LocalizationHelper.isKorean;
            }
            
            val_5 = val_5 & isHour;
            if(val_5 == false)
            {
                    return;
            }
            
            text.enableAutoSizing = false;
            text.fontSize = 2.12f;
        }
        public RoyalPassRewardChestTooltip()
        {
        
        }
    
    }

}
