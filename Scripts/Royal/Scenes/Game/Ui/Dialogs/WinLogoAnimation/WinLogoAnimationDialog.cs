using UnityEngine;

namespace Royal.Scenes.Game.Ui.Dialogs.WinLogoAnimation
{
    public class WinLogoAnimationDialog : UiDialog
    {
        // Fields
        private static UnityEngine.GameObject ConfettiParticles;
        public Spine.Unity.AnimationReferenceAsset winLogoReference;
        public Spine.Unity.SkeletonAnimation winLogoSkeleton;
        public UnityEngine.GameObject fireworkParticles;
        public Spine.Unity.SkeletonPartsRenderer logoPart;
        public Spine.Unity.SkeletonPartsRenderer otherParts;
        public Royal.Scenes.Game.Ui.Dialogs.WinLogoAnimation.TapToSkip tapToSkip;
        public string leftTrumpetsBone;
        public string rightTrumpetsBone;
        private bool isHomeScene;
        private Royal.Infrastructure.Contexts.Units.CameraManager camManager;
        private Royal.Scenes.Game.Levels.Units.RemainingMoves.RemainingMovesManager remainingMovesManager;
        
        // Methods
        private void Awake()
        {
            this.remainingMovesManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.RemainingMoves.RemainingMovesManager>(contextId:  33);
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16).StopGameMusic();
            this.winLogoSkeleton.state.SetAnimation(trackIndex:  1, animation:  Spine.Unity.AnimationReferenceAsset.op_Implicit(asset:  this.winLogoReference), loop:  false) = 0;
            this.winLogoSkeleton.Update(deltaTime:  UnityEngine.Time.deltaTime);
            this.winLogoSkeleton.gameObject.SetActive(value:  false);
            this.camManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            this.isHomeScene = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Scene.SceneChangeManager>(id:  2).IsHomeScene;
            this.SetSortings();
            this.SetTrumpetsForScreen();
            this.tapToSkip.Hide();
        }
        private void SetTrumpetsForScreen()
        {
            if(this.camManager.IsDeviceWide() == false)
            {
                    return;
            }
            
            UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  -2.1f, y:  0f);
            this.SetPositionForBone(bone:  this.leftTrumpetsBone, offset:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
            UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  2f, y:  0f);
            this.SetPositionForBone(bone:  this.rightTrumpetsBone, offset:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
        }
        private void SetPositionForBone(string bone, UnityEngine.Vector2 offset)
        {
            Spine.Bone val_2 = this.winLogoSkeleton.Skeleton.FindBone(boneName:  bone);
            UnityEngine.Vector2 val_3 = Spine.Unity.SkeletonExtensions.GetLocalPosition(bone:  val_2);
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y}, b:  new UnityEngine.Vector2() {x = offset.x, y = offset.y});
            Spine.Unity.SkeletonExtensions.SetLocalPosition(bone:  val_2, position:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
        }
        private void SetSortings()
        {
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_2 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetDialogBackgroundSorting();
            val_2.sortEverything = val_2.sortEverything & 4294967295;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_3 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_2.layer, order = val_2.order, sortEverything = val_2.sortEverything}, offset:  232);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.logoPart.GetComponent<UnityEngine.Renderer>(), data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_3.layer, order = val_3.order, sortEverything = val_3.sortEverything & 4294967295});
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_6 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetDialogBackgroundSorting();
            val_6.sortEverything = val_6.sortEverything & 4294967295;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_7 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_6.layer, order = val_6.order, sortEverything = val_6.sortEverything}, offset:  231);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.otherParts.GetComponent<UnityEngine.Renderer>(), data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_7.layer, order = val_7.order, sortEverything = val_7.sortEverything & 4294967295});
        }
        public override void OnShow(UnityEngine.Vector3 position)
        {
        
        }
        public void PlayWinLogoAnimation()
        {
            this.winLogoSkeleton.gameObject.SetActive(value:  true);
            this.Invoke(methodName:  "Close", time:  3f);
            this.Invoke(methodName:  "PlayParticles", time:  1f);
            this.Invoke(methodName:  "AttachToTapToSkip", time:  2.5f);
        }
        private void AttachToTapToSkip()
        {
            this.tapToSkip.transform.SetParent(p:  0);
            this.remainingMovesManager = this.tapToSkip;
            this.remainingMovesManager.add_OnTapToSkip(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Game.Ui.Dialogs.WinLogoAnimation.WinLogoAnimationDialog::OnTapToSkip()));
            this.tapToSkip.EnableSkipWithoutText();
        }
        private void OnTapToSkip()
        {
            goto typeof(Royal.Scenes.Game.Ui.Dialogs.WinLogoAnimation.WinLogoAnimationDialog).__il2cppRuntimeField_250;
        }
        private void PlayParticles()
        {
            if(val_1.Length >= 1)
            {
                    var val_4 = 0;
                do
            {
                this.fireworkParticles.GetComponentsInChildren<UnityEngine.ParticleSystem>()[val_4].Play();
                val_4 = val_4 + 1;
            }
            while(val_4 < val_1.Length);
            
            }
            
            this.fireworkParticles.transform.SetParent(p:  0);
        }
        public override void OnClose(System.Action dialogClosed)
        {
            Royal.Scenes.Game.Levels.Units.RemainingMoves.RemainingMovesManager val_6 = this.remainingMovesManager;
            val_6.remove_OnTapToSkip(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Game.Ui.Dialogs.WinLogoAnimation.WinLogoAnimationDialog::OnTapToSkip()));
            this.OnClose(dialogClosed:  dialogClosed);
            if(val_2.Length >= 1)
            {
                    do
            {
                EmissionModule val_3 = this.fireworkParticles.GetComponentsInChildren<UnityEngine.ParticleSystem>()[0].emission;
                val_6 = 0 + 1;
            }
            while(val_6 < val_2.Length);
            
            }
            
            UnityEngine.Coroutine val_5 = Royal.Scenes.Start.Context.ApplicationContext.ManualStartCoroutine(iEnumerator:  this.DestroyFireworkParticles(fireworkParticles:  this.fireworkParticles));
        }
        private System.Collections.IEnumerator DestroyFireworkParticles(UnityEngine.GameObject fireworkParticles)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .fireworkParticles = fireworkParticles;
            return (System.Collections.IEnumerator)new WinLogoAnimationDialog.<DestroyFireworkParticles>d__22();
        }
        public override Royal.Infrastructure.UiComponents.Dialog.DialogConfig GetConfig()
        {
            float val_2;
            float val_3;
            bool val_4;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_0;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_1 = this.GetConfig();
            val_0.shouldSkipFastOnTouch = val_4;
            val_0.shouldCloseOnEscape = false;
            val_0.shouldCloseOnTouch = false;
            val_0.shouldCloseOnSwipe = false;
            val_0.backgroundFadeInDelay = 0f;
            val_0.backgroundFadeInDuration = 0.4f;
            val_0.shouldHideBackground = this.isHomeScene;
            val_0.backgroundFadeAlpha = val_2;
            val_0.backgroundFadeOutDuration = val_3;
            return val_0;
        }
        public WinLogoAnimationDialog()
        {
        
        }
    
    }

}
