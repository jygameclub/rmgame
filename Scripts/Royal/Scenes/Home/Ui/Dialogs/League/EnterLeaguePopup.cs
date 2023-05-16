using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.League
{
    public class EnterLeaguePopup : UiPopup, IBackable
    {
        // Fields
        private Royal.Infrastructure.UiComponents.Touch.UiTouchListener uiTouchListener;
        private Royal.Infrastructure.Contexts.Units.CameraManager camManager;
        public UnityEngine.BoxCollider2D touchBlockerBoxCollider2D;
        public UnityEngine.SpriteRenderer[] backgrounds;
        public UnityEngine.Transform topUi;
        public UnityEngine.Transform bottomUi;
        private Royal.Scenes.Start.Context.Units.FeatureBundle.RoyalLeagueBundle royalLeagueBundle;
        private Royal.Scenes.Home.Ui.Dialogs.League.EnterLeaguePopupBundledView enterLeaguePopupBundledView;
        private bool enterClicked;
        
        // Methods
        public void Show(string prefabName)
        {
            this.uiTouchListener = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            Royal.Infrastructure.Contexts.Units.CameraManager val_2 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            this.camManager = val_2;
            UnityEngine.Vector2 val_3 = val_2.GetScreenSize();
            this.touchBlockerBoxCollider2D.size = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
            this.Prepare(prefabName:  prefabName);
        }
        private void Prepare(string prefabName)
        {
            this.LoadBundledPrefab(prefabName:  prefabName);
            UnityEngine.Vector3 val_1 = this.topUi.position;
            UnityEngine.Vector3 val_2 = this.camManager.GetSafeTopCenterOfCamera();
            val_2.y = val_2.y * 1.1f;
            this.topUi.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Vector3 val_3 = this.bottomUi.position;
            UnityEngine.Vector3 val_4 = this.camManager.GetSafeBottomCenterOfCamera();
            val_4.y = val_4.y * 1.05f;
            this.bottomUi.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.PrepareBackground();
        }
        private void LoadBundledPrefab(string prefabName)
        {
            Royal.Scenes.Start.Context.Units.FeatureBundle.RoyalLeagueBundle val_9;
            Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleManager>(id:  25);
            if(val_1 == null)
            {
                    throw new NullReferenceException();
            }
            
            Royal.Scenes.Start.Context.Units.FeatureBundle.AFeatureBundle val_2 = val_1.GetBundle(bundleType:  5);
            if(val_2 != null)
            {
                    this.royalLeagueBundle = val_2;
                val_9 = this.royalLeagueBundle;
                if(val_9 == null)
            {
                    throw new NullReferenceException();
            }
            
                UnityEngine.GameObject val_5 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_9.EnterLeaguePopupBundledPrefab, parent:  this.transform);
                if(val_5 == null)
            {
                    throw new NullReferenceException();
            }
            
                Royal.Scenes.Home.Ui.Dialogs.League.EnterLeaguePopupBundledView val_6 = val_5.GetComponent<Royal.Scenes.Home.Ui.Dialogs.League.EnterLeaguePopupBundledView>();
                this.enterLeaguePopupBundledView = val_6;
                if(val_6 == null)
            {
                    throw new NullReferenceException();
            }
            
                val_6.Prepare(prefabName:  prefabName);
                if(this.enterLeaguePopupBundledView == null)
            {
                    throw new NullReferenceException();
            }
            
                val_9 = this.enterLeaguePopupBundledView.topLeftRenderer;
                if(val_9 == null)
            {
                    throw new NullReferenceException();
            }
            
                UnityEngine.Transform val_7 = val_9.transform;
                if(val_7 == null)
            {
                    throw new NullReferenceException();
            }
            
                val_7.SetParent(p:  this.topUi);
                if(this.enterLeaguePopupBundledView == null)
            {
                    throw new NullReferenceException();
            }
            
                val_9 = this.enterLeaguePopupBundledView.topRightRenderer;
                if(val_9 == null)
            {
                    throw new NullReferenceException();
            }
            
                UnityEngine.Transform val_8 = val_9.transform;
                if(val_8 == null)
            {
                    throw new NullReferenceException();
            }
            
                val_8.SetParent(p:  this.topUi);
                return;
            }
            
            this.royalLeagueBundle = val_1;
            throw new NullReferenceException();
        }
        private void PrepareBackground()
        {
            var val_4 = 0;
            do
            {
                if(val_4 >= this.backgrounds.Length)
            {
                    return;
            }
            
                UnityEngine.SpriteRenderer val_3 = this.backgrounds[val_4];
                UnityEngine.Vector2 val_1 = val_3.size;
                UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  this.camManager.cameraWidth, y:  val_1.y);
                val_3.size = new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
                val_4 = val_4 + 1;
            }
            while(this.backgrounds != null);
            
            throw new NullReferenceException();
        }
        public void OnClickEnter()
        {
            if(this.enterClicked != false)
            {
                    return;
            }
            
            this.enterClicked = true;
            if(IsNameEnteredOnce() != false)
            {
                    if((System.String.IsNullOrEmpty(value:  typeof(Royal.Player.Context.Data.UserId).__il2cppRuntimeField_28)) == false)
            {
                goto label_7;
            }
            
            }
            
            Royal.Scenes.Home.Ui.Dialogs.EnterName.ShowEnterNameDialogAction val_4 = new Royal.Scenes.Home.Ui.Dialogs.EnterName.ShowEnterNameDialogAction(changeName:  false, controlName:  0);
            val_4.add_OnComplete(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.League.EnterLeaguePopup::SendEnterLeagueHttpCommandWithNewName()));
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).Push(type:  this.GetType(), action:  val_4);
            return;
            label_7:
            this.SendEnterLeagueHttpCommand(newName:  System.String.alignConst);
        }
        private void SendEnterLeagueHttpCommandWithNewName()
        {
            this.SendEnterLeagueHttpCommand(newName:  typeof(Royal.Player.Context.Data.UserId).__il2cppRuntimeField_28);
        }
        private void SendEnterLeagueHttpCommand(string newName)
        {
            Royal.Infrastructure.Services.Backend.Http.Command.Commands val_2 = new Royal.Infrastructure.Services.Backend.Http.Command.Commands();
            val_2.Add(httpCommand:  new Royal.Infrastructure.Services.Backend.Http.Command.League.EnterLeagueHttpCommand(userName:  newName));
            val_2.add_OnComplete(value:  new Commands.ConnectionComplete(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.League.EnterLeaguePopup::LeagueEntered(bool isSuccess, Royal.Infrastructure.Services.Backend.Http.Command.Commands container)));
            .<SyncRequired>k__BackingField = true;
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.BackendHttpService>(id:  7).SendImmediately(commandsToSend:  val_2, timeOut:  10f);
        }
        private void LeagueEntered(bool isSuccess, Royal.Infrastructure.Services.Backend.Http.Command.Commands container)
        {
            var val_3;
            this.enterClicked = false;
            if(isSuccess != false)
            {
                    val_3 = null;
                val_3 = null;
                Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_this_arg.PrepareLevelButton();
                Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LevelManager>(id:  2).ResourcesLoad();
                Royal.Scenes.Home.Context.HomeContext.Get<Royal.Scenes.Home.Context.Units.Area.AreaManager>(id:  0).RefreshArea();
                this.Close();
                return;
            }
            
            Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.ShowConnectionProblem();
        }
        private void Close()
        {
            this.royalLeagueBundle = 0;
            this.Destroy();
        }
        public void PressBack()
        {
        
        }
        public EnterLeaguePopup()
        {
        
        }
    
    }

}
