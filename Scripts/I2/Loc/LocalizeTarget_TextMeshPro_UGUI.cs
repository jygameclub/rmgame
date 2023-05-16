using UnityEngine;

namespace I2.Loc
{
    public class LocalizeTarget_TextMeshPro_UGUI : LocalizeTarget<TMPro.TextMeshProUGUI>
    {
        // Fields
        public TMPro.TextAlignmentOptions mAlignment_RTL;
        public TMPro.TextAlignmentOptions mAlignment_LTR;
        public bool mAlignmentWasRTL;
        public bool mInitializeAlignment;
        
        // Methods
        private static LocalizeTarget_TextMeshPro_UGUI()
        {
            I2.Loc.LocalizeTarget_TextMeshPro_UGUI.AutoRegister();
        }
        private static void AutoRegister()
        {
            mem[1152921528783943384] = 100;
            mem[1152921528783943376] = "TextMeshPro UGUI";
            I2.Loc.LocalizationManager.RegisterTarget(desc:  new I2.Loc.LocalizeTargetDesc_Type<TMPro.TextMeshProUGUI, I2.Loc.LocalizeTarget_TextMeshPro_UGUI>());
        }
        public override I2.Loc.eTermType GetPrimaryTermType(I2.Loc.Localize cmp)
        {
            return 0;
        }
        public override I2.Loc.eTermType GetSecondaryTermType(I2.Loc.Localize cmp)
        {
            return 9;
        }
        public override bool CanUseSecondaryTerm()
        {
            return true;
        }
        public override bool AllowMainTermToBeRTL()
        {
            return true;
        }
        public override bool AllowSecondTermToBeRTL()
        {
            return false;
        }
        public override void GetFinalTerms(I2.Loc.Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
        {
            string val_4;
            int val_5;
            bool val_1 = UnityEngine.Object.op_Implicit(exists:  static_value_02D64000);
            val_4 = 0;
            primaryTerm = val_4;
            if(mem[282584257676895] != 0)
            {
                    string val_3 = UnityEngine.Object.__il2cppRuntimeField_cctor_finished + 224.name;
            }
            else
            {
                    val_5 = System.String.alignConst;
            }
            
            secondaryTerm = val_5;
        }
        public override void DoLocalize(I2.Loc.Localize cmp, string mainTranslation, string secondaryTranslation)
        {
            TMPro.TMP_Text val_27;
            string val_28;
            var val_29;
            TMPro.TextAlignmentOptions val_30;
            TMPro.TextAlignmentOptions val_31;
            TMPro.TextAlignmentOptions val_32;
            TMPro.TextAlignmentOptions val_33;
            TMPro.TextAlignmentOptions val_34;
            string val_35;
            string val_2 = secondaryTranslation;
            string val_1 = mainTranslation;
            TMPro.TextAlignmentOptions val_23 = 0;
            TMPro.TMP_FontAsset val_3 = cmp.GetSecondaryTranslatedObj<TMPro.TMP_FontAsset>(mainTranslation: ref  val_1, secondaryTranslation: ref  val_2);
            val_27 = 1152921504784535552;
            if(val_3 != 0)
            {
                    I2.Loc.LocalizeTarget_TextMeshPro_Label.SetFont(label:  X22, newFont:  val_3);
            }
            else
            {
                    UnityEngine.Material val_5 = cmp.GetSecondaryTranslatedObj<UnityEngine.Material>(mainTranslation: ref  val_1, secondaryTranslation: ref  val_2);
                bool val_6 = UnityEngine.Object.op_Inequality(x:  val_5, y:  0);
                if((val_6 != false) && (val_6.fontMaterial != val_5))
            {
                    if((val_5.name.StartsWith(value:  UnityEngine.Object.__il2cppRuntimeField_cctor_finished.name, comparisonType:  4)) != true)
            {
                    if((val_2.EndsWith(value:  val_5.name, comparisonType:  4)) != false)
            {
                    val_28 = val_2;
            }
            else
            {
                    val_28 = val_5.name;
            }
            
                TMPro.TMP_FontAsset val_15 = I2.Loc.LocalizeTarget_TextMeshPro_Label.GetTMPFontFromMaterial(cmp:  cmp, matName:  val_28);
                if(val_15 != 0)
            {
                    I2.Loc.LocalizeTarget_TextMeshPro_Label.SetFont(label:  val_27, newFont:  val_15);
            }
            
            }
            
                I2.Loc.LocalizeTarget_TextMeshPro_Label.SetMaterial(label:  val_15, newMat:  val_5);
            }
            
            }
            
            if(this.mInitializeAlignment == false)
            {
                goto label_32;
            }
            
            this.mInitializeAlignment = false;
            val_29 = null;
            val_29 = null;
            this.mAlignmentWasRTL = I2.Loc.LocalizationManager.IsRight2Left;
            val_30 = alignment;
            val_27 = this.mAlignment_LTR;
            I2.Loc.LocalizeTarget_TextMeshPro_Label.InitAlignment_TMPro(isRTL:  (I2.Loc.LocalizationManager.IsRight2Left == true) ? 1 : 0, alignment:  val_30, alignLTR: out  val_27, alignRTL: out  this.mAlignment_RTL);
            goto label_38;
            label_32:
            I2.Loc.LocalizeTarget_TextMeshPro_Label.InitAlignment_TMPro(isRTL:  (this.mAlignmentWasRTL == true) ? 1 : 0, alignment:  val_15.alignment, alignLTR: out  val_23, alignRTL: out  val_23);
            if(this.mAlignmentWasRTL == false)
            {
                goto label_42;
            }
            
            val_31 = this;
            val_32 = 0;
            if(this.mAlignment_RTL == val_32)
            {
                goto label_45;
            }
            
            val_33 = 0;
            val_34 = this.mAlignment_LTR;
            goto label_44;
            label_42:
            val_34 = this;
            val_33 = 0;
            if(this.mAlignment_LTR == val_33)
            {
                goto label_45;
            }
            
            val_32 = 0;
            val_31 = this.mAlignment_RTL;
            label_44:
            this.mAlignment_LTR = val_33;
            val_31 = val_32;
            label_45:
            val_30 = 1152921505149231104;
            val_35 = null;
            val_35 = null;
            this.mAlignmentWasRTL = I2.Loc.LocalizationManager.IsRight2Left;
            label_38:
            if(val_1 == 0)
            {
                    return;
            }
            
            if((System.String.op_Inequality(a:  val_35, b:  val_1)) == false)
            {
                    return;
            }
            
            if((val_1 == 0) || (cmp.CorrectAlignmentForRTL == false))
            {
                    return;
            }
            
            val_30 = 1152921505149231104;
            var val_25 = (I2.Loc.LocalizationManager.IsRight2Left == false) ? 36 : 32;
            cmp.alignment = null;
            cmp.isRightToLeftText = I2.Loc.LocalizationManager.IsRight2Left;
            if(I2.Loc.LocalizationManager.IsRight2Left == false)
            {
                    return;
            }
            
            string val_26 = I2.Loc.I2Utils.ReverseText(source:  val_1);
        }
        public LocalizeTarget_TextMeshPro_UGUI()
        {
            this.mInitializeAlignment = true;
            this.mAlignment_RTL = 1.08858384102012E-311;
        }
    
    }

}
