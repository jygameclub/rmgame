using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.PreviousArea
{
    public class PreviousAreaDialog : UiDialog
    {
        // Fields
        public UnityEngine.Transform bottomUi;
        public UnityEngine.Transform areaParent;
        public Royal.Scenes.Home.Ui.Sections.Home.Pinch.DialogPinch dialogPinch;
        private Royal.Scenes.Home.Areas.Scripts.AreaView areaView;
        private Royal.Scenes.Home.Ui.Sections.Episodes.EpisodesSection episodesSection;
        private Royal.Scenes.Home.Areas.Scripts.AreaView.OnReplayKilled onReplayKilled;
        
        // Methods
        public void Init(Royal.Scenes.Home.Areas.Scripts.AreaView areaView, Royal.Scenes.Home.Areas.Scripts.AreaView.OnReplayKilled onReplayKilled)
        {
            null = null;
            this.areaView = areaView;
            this.episodesSection = Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_element_class.GetSectionFromType(type:  -2);
            this.onReplayKilled = onReplayKilled;
            UnityEngine.Transform val_2 = areaView.transform;
            val_2.SetParent(p:  this.areaParent);
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            val_2.localPosition = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            this.dialogPinch = val_2;
            UnityEngine.Vector3 val_4 = this.bottomUi.position;
            UnityEngine.Vector3 val_6 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1).GetSafeBottomCenterOfCamera();
            this.bottomUi.position = new UnityEngine.Vector3() {x = val_4.x, y = val_6.y, z = val_4.z};
        }
        public override void OnShow(UnityEngine.Vector3 position)
        {
            this.episodesSection.EnableScroll(enable:  false);
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
            UnityEngine.Transform val_2 = this.transform;
            val_2.position = new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z};
            val_2.localScale = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
            this.dialogPinch = val_2;
            goto typeof(Royal.Scenes.Home.Ui.Dialogs.PreviousArea.PreviousAreaDialog).__il2cppRuntimeField_280;
        }
        public override void OnClose(System.Action dialogClosed)
        {
            this.areaView.areaViewBackgroundSounds.StopReplaySounds();
            this.onReplayKilled.Invoke();
            this.episodesSection.EnableScroll(enable:  true);
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Home.Context.Units.AssetBundles.AssetBundleHelper>(id:  8).UnloadAreaBundle(areaNo:  this.areaView.<AreaId>k__BackingField);
            UnityEngine.Object.Destroy(obj:  this.areaView.gameObject);
            this.OnClose(dialogClosed:  dialogClosed);
        }
        public override Royal.Infrastructure.UiComponents.Dialog.DialogConfig GetConfig()
        {
            bool val_2;
            float val_3;
            bool val_4;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_0;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_1 = this.GetConfig();
            val_0.shouldCloseOnEscape = true;
            val_0.shouldCloseOnTouch = false;
            val_0.shouldHideBackground = val_2;
            val_0.backgroundFadeInDuration = val_3;
            val_0.shouldCloseOnSwipe = val_4;
            return val_0;
        }
        public PreviousAreaDialog()
        {
        
        }
    
    }

}
