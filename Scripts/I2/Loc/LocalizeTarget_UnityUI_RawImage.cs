using UnityEngine;

namespace I2.Loc
{
    public class LocalizeTarget_UnityUI_RawImage : LocalizeTarget<UnityEngine.UI.RawImage>
    {
        // Methods
        private static LocalizeTarget_UnityUI_RawImage()
        {
            I2.Loc.LocalizeTarget_UnityUI_RawImage.AutoRegister();
        }
        private static void AutoRegister()
        {
            mem[1152921528795099976] = 100;
            mem[1152921528795099968] = "RawImage";
            I2.Loc.LocalizationManager.RegisterTarget(desc:  new I2.Loc.LocalizeTargetDesc_Type<UnityEngine.UI.RawImage, I2.Loc.LocalizeTarget_UnityUI_RawImage>());
        }
        public override I2.Loc.eTermType GetPrimaryTermType(I2.Loc.Localize cmp)
        {
            return 2;
        }
        public override I2.Loc.eTermType GetSecondaryTermType(I2.Loc.Localize cmp)
        {
            return 0;
        }
        public override bool CanUseSecondaryTerm()
        {
            return false;
        }
        public override bool AllowMainTermToBeRTL()
        {
            return false;
        }
        public override bool AllowSecondTermToBeRTL()
        {
            return false;
        }
        public override void GetFinalTerms(I2.Loc.Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
        {
            string val_3;
            bool val_1 = UnityEngine.Object.op_Implicit(exists:  23274);
            if(val_1 != false)
            {
                    string val_2 = val_1.name;
            }
            else
            {
                    val_3 = "";
            }
            
            primaryTerm = val_3;
            secondaryTerm = 0;
        }
        public override void DoLocalize(I2.Loc.Localize cmp, string mainTranslation, string secondaryTranslation)
        {
            if(176857 != 0)
            {
                    if((System.String.op_Inequality(a:  176857.name, b:  mainTranslation)) == false)
            {
                    return;
            }
            
            }
            
            this.texture = cmp.FindTranslatedObject<UnityEngine.Texture>(value:  mainTranslation);
        }
        public LocalizeTarget_UnityUI_RawImage()
        {
        
        }
    
    }

}
