using UnityEngine;

namespace DG.Tweening
{
    public static class ShortcutExtensionsTMPText
    {
        // Methods
        public static DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOColor(TMPro.TMP_Text target, UnityEngine.Color endValue, float duration)
        {
            ShortcutExtensionsTMPText.<>c__DisplayClass0_0 val_1 = new ShortcutExtensionsTMPText.<>c__DisplayClass0_0();
            .target = target;
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_4 = DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Color>(object:  val_1, method:  UnityEngine.Color ShortcutExtensionsTMPText.<>c__DisplayClass0_0::<DOColor>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Color>(object:  val_1, method:  System.Void ShortcutExtensionsTMPText.<>c__DisplayClass0_0::<DOColor>b__1(UnityEngine.Color x)), endValue:  new UnityEngine.Color() {r = endValue.r, g = endValue.g, b = endValue.b, a = endValue.a}, duration:  duration);
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_5 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  val_4, target:  (ShortcutExtensionsTMPText.<>c__DisplayClass0_0)[1152921528871426560].target);
            return val_4;
        }
        public static DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOFaceColor(TMPro.TMP_Text target, UnityEngine.Color32 endValue, float duration)
        {
            ShortcutExtensionsTMPText.<>c__DisplayClass1_0 val_1 = new ShortcutExtensionsTMPText.<>c__DisplayClass1_0();
            .target = target;
            UnityEngine.Color val_5 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = endValue.r & 4294967295, g = endValue.r & 4294967295, b = endValue.r & 4294967295, a = endValue.r & 4294967295});
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_6 = DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Color>(object:  val_1, method:  UnityEngine.Color ShortcutExtensionsTMPText.<>c__DisplayClass1_0::<DOFaceColor>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Color>(object:  val_1, method:  System.Void ShortcutExtensionsTMPText.<>c__DisplayClass1_0::<DOFaceColor>b__1(UnityEngine.Color x)), endValue:  new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a}, duration:  duration);
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_7 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  val_6, target:  (ShortcutExtensionsTMPText.<>c__DisplayClass1_0)[1152921528871597952].target);
            return val_6;
        }
        public static DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOOutlineColor(TMPro.TMP_Text target, UnityEngine.Color32 endValue, float duration)
        {
            ShortcutExtensionsTMPText.<>c__DisplayClass2_0 val_1 = new ShortcutExtensionsTMPText.<>c__DisplayClass2_0();
            .target = target;
            UnityEngine.Color val_5 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = endValue.r & 4294967295, g = endValue.r & 4294967295, b = endValue.r & 4294967295, a = endValue.r & 4294967295});
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_6 = DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Color>(object:  val_1, method:  UnityEngine.Color ShortcutExtensionsTMPText.<>c__DisplayClass2_0::<DOOutlineColor>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Color>(object:  val_1, method:  System.Void ShortcutExtensionsTMPText.<>c__DisplayClass2_0::<DOOutlineColor>b__1(UnityEngine.Color x)), endValue:  new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a}, duration:  duration);
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_7 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  val_6, target:  (ShortcutExtensionsTMPText.<>c__DisplayClass2_0)[1152921528871769344].target);
            return val_6;
        }
        public static DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOGlowColor(TMPro.TMP_Text target, UnityEngine.Color endValue, float duration, bool useSharedMaterial = False)
        {
            var val_4;
            if(useSharedMaterial != false)
            {
                    val_4 = target;
            }
            
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_2 = DG.Tweening.ShortcutExtensions.DOColor(target:  target.fontMaterial, endValue:  new UnityEngine.Color() {r = endValue.r, g = endValue.g, b = endValue.b, a = endValue.a}, property:  "_GlowColor", duration:  duration);
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_3 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  val_2, target:  target);
            return val_2;
        }
        public static DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOFade(TMPro.TMP_Text target, float endValue, float duration)
        {
            ShortcutExtensionsTMPText.<>c__DisplayClass4_0 val_1 = new ShortcutExtensionsTMPText.<>c__DisplayClass4_0();
            .target = target;
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_4 = DG.Tweening.DOTween.ToAlpha(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Color>(object:  val_1, method:  UnityEngine.Color ShortcutExtensionsTMPText.<>c__DisplayClass4_0::<DOFade>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Color>(object:  val_1, method:  System.Void ShortcutExtensionsTMPText.<>c__DisplayClass4_0::<DOFade>b__1(UnityEngine.Color x)), endValue:  endValue, duration:  duration);
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_5 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  val_4, target:  (ShortcutExtensionsTMPText.<>c__DisplayClass4_0)[1152921528872085600].target);
            return val_4;
        }
        public static DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOFaceFade(TMPro.TMP_Text target, float endValue, float duration)
        {
            ShortcutExtensionsTMPText.<>c__DisplayClass5_0 val_1 = new ShortcutExtensionsTMPText.<>c__DisplayClass5_0();
            .target = target;
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_4 = DG.Tweening.DOTween.ToAlpha(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Color>(object:  val_1, method:  UnityEngine.Color ShortcutExtensionsTMPText.<>c__DisplayClass5_0::<DOFaceFade>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Color>(object:  val_1, method:  System.Void ShortcutExtensionsTMPText.<>c__DisplayClass5_0::<DOFaceFade>b__1(UnityEngine.Color x)), endValue:  endValue, duration:  duration);
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_5 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  val_4, target:  (ShortcutExtensionsTMPText.<>c__DisplayClass5_0)[1152921528872256992].target);
            return val_4;
        }
        public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOScale(TMPro.TMP_Text target, float endValue, float duration)
        {
            ShortcutExtensionsTMPText.<>c__DisplayClass6_0 val_1 = new ShortcutExtensionsTMPText.<>c__DisplayClass6_0();
            .trans = target.transform;
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_5 = DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector3>(object:  val_1, method:  UnityEngine.Vector3 ShortcutExtensionsTMPText.<>c__DisplayClass6_0::<DOScale>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector3>(object:  val_1, method:  System.Void ShortcutExtensionsTMPText.<>c__DisplayClass6_0::<DOScale>b__1(UnityEngine.Vector3 x)), endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  duration);
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_6 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  val_5, target:  target);
            return val_5;
        }
        public static DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOFontSize(TMPro.TMP_Text target, float endValue, float duration)
        {
            ShortcutExtensionsTMPText.<>c__DisplayClass7_0 val_1 = new ShortcutExtensionsTMPText.<>c__DisplayClass7_0();
            .target = target;
            DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_4 = DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<System.Single>(object:  val_1, method:  System.Single ShortcutExtensionsTMPText.<>c__DisplayClass7_0::<DOFontSize>b__0()), setter:  new DG.Tweening.Core.DOSetter<System.Single>(object:  val_1, method:  System.Void ShortcutExtensionsTMPText.<>c__DisplayClass7_0::<DOFontSize>b__1(float x)), endValue:  endValue, duration:  duration);
            DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_5 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  val_4, target:  (ShortcutExtensionsTMPText.<>c__DisplayClass7_0)[1152921528872599776].target);
            return val_4;
        }
        public static DG.Tweening.Core.TweenerCore<int, int, DG.Tweening.Plugins.Options.NoOptions> DOMaxVisibleCharacters(TMPro.TMP_Text target, int endValue, float duration)
        {
            ShortcutExtensionsTMPText.<>c__DisplayClass8_0 val_1 = new ShortcutExtensionsTMPText.<>c__DisplayClass8_0();
            .target = target;
            DG.Tweening.Core.TweenerCore<System.Int32, System.Int32, DG.Tweening.Plugins.Options.NoOptions> val_4 = DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<System.Int32>(object:  val_1, method:  System.Int32 ShortcutExtensionsTMPText.<>c__DisplayClass8_0::<DOMaxVisibleCharacters>b__0()), setter:  new DG.Tweening.Core.DOSetter<System.Int32>(object:  val_1, method:  System.Void ShortcutExtensionsTMPText.<>c__DisplayClass8_0::<DOMaxVisibleCharacters>b__1(int x)), endValue:  endValue, duration:  duration);
            DG.Tweening.Core.TweenerCore<System.Int32, System.Int32, DG.Tweening.Plugins.Options.NoOptions> val_5 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<System.Int32, System.Int32, DG.Tweening.Plugins.Options.NoOptions>>(t:  val_4, target:  (ShortcutExtensionsTMPText.<>c__DisplayClass8_0)[1152921528872772192].target);
            return val_4;
        }
        public static DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions> DOText(TMPro.TMP_Text target, string endValue, float duration, bool richTextEnabled = True, DG.Tweening.ScrambleMode scrambleMode = 0, string scrambleChars)
        {
            ShortcutExtensionsTMPText.<>c__DisplayClass9_0 val_1 = new ShortcutExtensionsTMPText.<>c__DisplayClass9_0();
            .target = target;
            DG.Tweening.Core.TweenerCore<System.String, System.String, DG.Tweening.Plugins.Options.StringOptions> val_4 = DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<System.String>(object:  val_1, method:  System.String ShortcutExtensionsTMPText.<>c__DisplayClass9_0::<DOText>b__0()), setter:  new DG.Tweening.Core.DOSetter<System.String>(object:  val_1, method:  System.Void ShortcutExtensionsTMPText.<>c__DisplayClass9_0::<DOText>b__1(string x)), endValue:  endValue, duration:  duration);
            DG.Tweening.Tweener val_7 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  val_4, richTextEnabled:  richTextEnabled, scrambleMode:  scrambleMode, scrambleChars:  scrambleChars), target:  (ShortcutExtensionsTMPText.<>c__DisplayClass9_0)[1152921528872974304].target);
            return val_4;
        }
    
    }

}
