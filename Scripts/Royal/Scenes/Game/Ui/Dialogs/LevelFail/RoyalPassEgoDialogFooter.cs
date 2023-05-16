using UnityEngine;

namespace Royal.Scenes.Game.Ui.Dialogs.LevelFail
{
    public class RoyalPassEgoDialogFooter : MonoBehaviour
    {
        // Fields
        public Royal.Scenes.Game.Ui.Dialogs.LevelFail.EgoDialog dialog;
        public UnityEngine.Transform backgroundDecoratorTransform;
        public UnityEngine.SpriteRenderer backgroundDecoratorSprite;
        public UnityEngine.GameObject decoratorMask;
        public UnityEngine.Transform backgroundLeftTransform;
        public UnityEngine.SpriteRenderer backgroundLeftSprite;
        public UnityEngine.Transform backgroundRightTransform;
        public UnityEngine.SpriteRenderer backgroundRightSprite;
        public UnityEngine.Transform titleBackgroundTransform;
        public UnityEngine.SpriteRenderer titleBackgroundSprite;
        public TMPro.TextMeshPro title;
        public UnityEngine.Transform centerLeftTransform;
        public UnityEngine.Transform centerRightTransform;
        public TMPro.TextMeshPro infoText;
        public UnityEngine.Transform bundle;
        public UnityEngine.RectTransform buttonText;
        
        // Methods
        public void OnActivateOnButton()
        {
            this.dialog = 4;
            goto typeof(Royal.Scenes.Game.Ui.Dialogs.LevelFail.EgoDialog).__il2cppRuntimeField_250;
        }
        public void Close()
        {
            if(this.dialog != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
        public void ArrangeRoyalPassFooterForScreens(UnityEngine.Vector2 rootPositionDiffOnRoyalPass)
        {
            bool val_74;
            float val_75;
            float val_76;
            float val_77;
            float val_78;
            float val_79;
            float val_80;
            var val_82;
            float val_83;
            float val_84;
            Royal.Infrastructure.Contexts.Units.CameraManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            UnityEngine.Transform val_2 = this.transform;
            val_74 = val_2;
            UnityEngine.Vector3 val_3 = val_2.localPosition;
            val_75 = val_3.x;
            val_76 = val_3.z;
            UnityEngine.Vector2 val_4 = val_1.GetSafeCenterPosition();
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y}, b:  new UnityEngine.Vector2() {x = rootPositionDiffOnRoyalPass.x, y = rootPositionDiffOnRoyalPass.y});
            UnityEngine.Vector3 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y});
            val_77 = val_6.x;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_75, y = val_3.y, z = val_76}, b:  new UnityEngine.Vector3() {x = val_77, y = val_6.y, z = val_6.z});
            val_74.localPosition = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            if(val_1.IsDeviceTall() != false)
            {
                    UnityEngine.Transform val_9 = this.transform;
                UnityEngine.Vector3 val_10 = val_9.localPosition;
                UnityEngine.Vector3 val_11 = UnityEngine.Vector3.down;
                UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, d:  0.2f);
                UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
                val_9.localPosition = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
                UnityEngine.Vector3 val_14 = this.backgroundDecoratorTransform.localPosition;
                UnityEngine.Vector3 val_15 = UnityEngine.Vector3.up;
                UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, d:  0.0719f);
                UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, b:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
                this.backgroundDecoratorTransform.localPosition = new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z};
                UnityEngine.Vector2 val_18 = this.backgroundDecoratorSprite.size;
                UnityEngine.Vector2 val_19 = new UnityEngine.Vector2(x:  1f, y:  -0.12513f);
                UnityEngine.Vector2 val_20 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_18.x, y = val_18.y}, b:  new UnityEngine.Vector2() {x = val_19.x, y = val_19.y});
                this.backgroundDecoratorSprite.size = new UnityEngine.Vector2() {x = val_20.x, y = val_20.y};
                this.decoratorMask.SetActive(value:  true);
                this.backgroundDecoratorSprite.maskInteraction = 1;
                UnityEngine.Vector3 val_21 = UnityEngine.Vector3.up;
                UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z}, d:  0.0738001f);
                UnityEngine.Vector3 val_23 = this.backgroundLeftTransform.localPosition;
                UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, b:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z});
                this.backgroundLeftTransform.localPosition = new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z};
                UnityEngine.Vector3 val_25 = this.backgroundRightTransform.localPosition;
                UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z}, b:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z});
                this.backgroundRightTransform.localPosition = new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z};
                UnityEngine.Vector2 val_27 = new UnityEngine.Vector2(x:  0.2f, y:  -0.147549f);
                UnityEngine.Vector2 val_28 = this.backgroundLeftSprite.size;
                UnityEngine.Vector2 val_29 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_28.x, y = val_28.y}, b:  new UnityEngine.Vector2() {x = val_27.x, y = val_27.y});
                this.backgroundLeftSprite.size = new UnityEngine.Vector2() {x = val_29.x, y = val_29.y};
                UnityEngine.Vector2 val_30 = this.backgroundRightSprite.size;
                UnityEngine.Vector2 val_31 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_30.x, y = val_30.y}, b:  new UnityEngine.Vector2() {x = val_27.x, y = val_27.y});
                this.backgroundRightSprite.size = new UnityEngine.Vector2() {x = val_31.x, y = val_31.y};
                UnityEngine.Vector3 val_32 = this.titleBackgroundTransform.localPosition;
                UnityEngine.Vector3 val_33 = UnityEngine.Vector3.left;
                UnityEngine.Vector3 val_34 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z}, d:  0.2784f);
                UnityEngine.Vector3 val_35 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_32.x, y = val_32.y, z = val_32.z}, b:  new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_34.z});
                this.titleBackgroundTransform.localPosition = new UnityEngine.Vector3() {x = val_35.x, y = val_35.y, z = val_35.z};
                UnityEngine.Vector2 val_36 = this.titleBackgroundSprite.size;
                UnityEngine.Vector2 val_37 = UnityEngine.Vector2.left;
                UnityEngine.Vector2 val_38 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_37.x, y = val_37.y}, d:  0.160778f);
                UnityEngine.Vector2 val_39 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_36.x, y = val_36.y}, b:  new UnityEngine.Vector2() {x = val_38.x, y = val_38.y});
                this.titleBackgroundSprite.size = new UnityEngine.Vector2() {x = val_39.x, y = val_39.y};
                UnityEngine.RectTransform val_40 = this.title.rectTransform;
                UnityEngine.Vector3 val_41 = val_40.localPosition;
                UnityEngine.Vector3 val_42 = UnityEngine.Vector3.left;
                UnityEngine.Vector3 val_43 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_42.x, y = val_42.y, z = val_42.z}, d:  0.282f);
                UnityEngine.Vector3 val_44 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_41.x, y = val_41.y, z = val_41.z}, b:  new UnityEngine.Vector3() {x = val_43.x, y = val_43.y, z = val_43.z});
                val_40.localPosition = new UnityEngine.Vector3() {x = val_44.x, y = val_44.y, z = val_44.z};
                UnityEngine.RectTransform val_45 = this.title.rectTransform;
                UnityEngine.Vector2 val_46 = val_45.sizeDelta;
                UnityEngine.Vector2 val_47 = UnityEngine.Vector2.left;
                UnityEngine.Vector2 val_48 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_47.x, y = val_47.y}, d:  0.409239f);
                UnityEngine.Vector2 val_49 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_46.x, y = val_46.y}, b:  new UnityEngine.Vector2() {x = val_48.x, y = val_48.y});
                val_45.sizeDelta = new UnityEngine.Vector2() {x = val_49.x, y = val_49.y};
                UnityEngine.Vector3 val_50 = this.centerLeftTransform.localScale;
                UnityEngine.Vector3 val_51 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_50.x, y = val_50.y, z = val_50.z}, d:  0.95f);
                this.centerLeftTransform.localScale = new UnityEngine.Vector3() {x = val_51.x, y = val_51.y, z = val_51.z};
                UnityEngine.Vector3 val_52 = this.centerLeftTransform.localPosition;
                UnityEngine.Vector3 val_53 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_52.x, y = val_52.y, z = val_52.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                this.centerLeftTransform.localPosition = new UnityEngine.Vector3() {x = val_53.x, y = val_53.y, z = val_53.z};
                UnityEngine.Vector3 val_54 = this.centerRightTransform.localScale;
                UnityEngine.Vector3 val_55 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_54.x, y = val_54.y, z = val_54.z}, d:  0.95f);
                this.centerRightTransform.localScale = new UnityEngine.Vector3() {x = val_55.x, y = val_55.y, z = val_55.z};
                UnityEngine.Vector3 val_56 = this.centerRightTransform.localPosition;
                UnityEngine.Vector3 val_57 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_56.x, y = val_56.y, z = val_56.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                this.centerRightTransform.localPosition = new UnityEngine.Vector3() {x = val_57.x, y = val_57.y, z = val_57.z};
                val_74 = Royal.Infrastructure.Services.Localization.LocalizationHelper.isJapanese;
                UnityEngine.RectTransform val_58 = this.infoText.rectTransform;
                UnityEngine.Vector3 val_59 = val_58.localPosition;
                if(val_74 != false)
            {
                    val_78 = 0f;
                val_79 = val_59.x;
                val_80 = val_59.y;
                UnityEngine.Vector3 val_60 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_79, y = val_80, z = val_59.z}, b:  new UnityEngine.Vector3() {x = 0f, y = val_78, z = 0f});
                val_58.localPosition = new UnityEngine.Vector3() {x = val_60.x, y = val_60.y, z = val_60.z};
                UnityEngine.RectTransform val_61 = this.infoText.rectTransform;
                val_82 = val_61;
                UnityEngine.Vector2 val_62 = val_61.sizeDelta;
                val_83 = val_62.x;
                val_84 = val_62.y;
                UnityEngine.Vector2 val_63 = UnityEngine.Vector2.right;
            }
            else
            {
                    val_78 = 0f;
                val_79 = val_59.x;
                val_80 = val_59.y;
                UnityEngine.Vector3 val_64 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_79, y = val_80, z = val_59.z}, b:  new UnityEngine.Vector3() {x = 0f, y = val_78, z = 0f});
                val_58.localPosition = new UnityEngine.Vector3() {x = val_64.x, y = val_64.y, z = val_64.z};
                UnityEngine.RectTransform val_65 = this.infoText.rectTransform;
                val_82 = val_65;
                UnityEngine.Vector2 val_66 = val_65.sizeDelta;
                val_83 = val_66.x;
                val_84 = val_66.y;
                UnityEngine.Vector2 val_67 = UnityEngine.Vector2.right;
            }
            
                UnityEngine.Vector2 val_68 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_67.x, y = val_67.y}, d:  0.17f);
                UnityEngine.Vector2 val_69 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_83, y = val_84}, b:  new UnityEngine.Vector2() {x = val_68.x, y = val_68.y});
                val_82.sizeDelta = new UnityEngine.Vector2() {x = val_69.x, y = val_69.y};
                val_69.x = val_69.x + 0.2f;
                this.infoText.fontSizeMax = val_69.x;
                UnityEngine.Vector3 val_70 = this.bundle.localScale;
                val_76 = val_70.z;
                UnityEngine.Vector3 val_71 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_70.x, y = val_70.y, z = val_76}, d:  0.95f);
                this.bundle.localScale = new UnityEngine.Vector3() {x = val_71.x, y = val_71.y, z = val_71.z};
                UnityEngine.Vector3 val_72 = this.bundle.localPosition;
                val_77 = val_72.x;
                val_75 = val_72.y;
                UnityEngine.Vector3 val_73 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_77, y = val_75, z = val_72.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                this.bundle.localPosition = new UnityEngine.Vector3() {x = val_73.x, y = val_73.y, z = val_73.z};
            }
            
            this.ArrangeForLocalization();
        }
        private void ArrangeForLocalization()
        {
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isArabic == false)
            {
                    return;
            }
            
            UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  2.6923f, y:  0.8f);
            this.buttonText.sizeDelta = new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
            this = this.buttonText;
            UnityEngine.Vector3 val_2 = this.localPosition;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  0.034f);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            this.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        }
        public RoyalPassEgoDialogFooter()
        {
        
        }
    
    }

}
