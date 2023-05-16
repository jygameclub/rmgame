using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.ViewTeam
{
    public class ViewTeamButton : MonoBehaviour
    {
        // Fields
        public UnityEngine.Transform body;
        public Royal.Infrastructure.UiComponents.Button.UiButton button;
        public UnityEngine.SpriteRenderer leftPart;
        public UnityEngine.SpriteRenderer rightPart;
        public UnityEngine.Sprite upSprite;
        public UnityEngine.Sprite downSprite;
        private long teamId;
        private float screenRefPosY;
        private UnityEngine.Vector3 openPosition;
        private static Royal.Scenes.Home.Ui.Dialogs.ViewTeam.ViewTeamButton ActiveViewTeamButton;
        private static UnityEngine.Transform ActiveViewTeamButtonParent;
        
        // Methods
        private void Awake()
        {
            UnityEngine.Vector2 val_2 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1).GetScreenSize();
            float val_5 = -0.5f;
            val_5 = val_2.y * val_5;
            this.screenRefPosY = val_5;
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Scene.SceneChangeManager>(id:  2).add_SceneWillLoad(value:  new System.Action<System.Int32>(object:  0, method:  static System.Void Royal.Scenes.Home.Ui.Dialogs.ViewTeam.ViewTeamButton::SceneWillLoad(int scene)));
        }
        private static void SceneWillLoad(int scene)
        {
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Scene.SceneChangeManager>(id:  2).remove_SceneWillLoad(value:  new System.Action<System.Int32>(object:  0, method:  static System.Void Royal.Scenes.Home.Ui.Dialogs.ViewTeam.ViewTeamButton::SceneWillLoad(int scene)));
            Royal.Scenes.Home.Ui.Dialogs.ViewTeam.ViewTeamButton.ClearViewTeamButton();
        }
        private void OnEnable()
        {
            Royal.Infrastructure.UiComponents.Touch.UiTouchListener val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            val_1.remove_OnMouseDown(value:  new System.Action<Royal.Infrastructure.UiComponents.Touch.ITouchable>(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.ViewTeam.ViewTeamButton::CloseView(Royal.Infrastructure.UiComponents.Touch.ITouchable obj)));
            val_1.add_OnMouseDown(value:  new System.Action<Royal.Infrastructure.UiComponents.Touch.ITouchable>(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.ViewTeam.ViewTeamButton::CloseView(Royal.Infrastructure.UiComponents.Touch.ITouchable obj)));
        }
        private void OnDisable()
        {
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15).remove_OnMouseDown(value:  new System.Action<Royal.Infrastructure.UiComponents.Touch.ITouchable>(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.ViewTeam.ViewTeamButton::CloseView(Royal.Infrastructure.UiComponents.Touch.ITouchable obj)));
        }
        private void CloseView(Royal.Infrastructure.UiComponents.Touch.ITouchable obj)
        {
            if(this.gameObject.activeSelf == false)
            {
                    return;
            }
            
            if(this.button == obj)
            {
                    return;
            }
            
            if((Royal.Scenes.Home.Ui.Dialogs.ViewTeam.ViewTeamButton.ActiveViewTeamButtonParent.gameObject.GetComponentInChildren<Royal.Infrastructure.UiComponents.Button.UiButton>()) == obj)
            {
                    return;
            }
            
            Royal.Scenes.Home.Ui.Dialogs.ViewTeam.ViewTeamButton.CloseViewTeamButton();
        }
        private void Init(long team, float xPosition, float bottomOffset)
        {
            UnityEngine.Transform val_11;
            float val_12;
            this.teamId = team;
            UnityEngine.Vector3 val_2 = this.transform.position;
            val_2.y = val_2.y - bottomOffset;
            if(val_2.y < 0)
            {
                    this.UpdateSprite(sprite:  this.downSprite);
                this.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
                val_11 = this.body;
                val_12 = 3.08f;
            }
            else
            {
                    this.UpdateSprite(sprite:  this.upSprite);
                this.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
                val_11 = this.body;
                val_12 = 0f;
            }
            
            val_11.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Transform val_6 = this.transform;
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_8 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_6, endValue:  1f, duration:  0.17f), ease:  27);
            UnityEngine.Vector3 val_9 = val_6.position;
            this.openPosition = val_9;
            mem[1152921519153888200] = val_9.y;
            mem[1152921519153888204] = val_9.z;
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16).PlaySound(type:  2, offset:  0.04f);
        }
        private void Update()
        {
            UnityEngine.Vector3 val_2 = this.transform.position;
            if((Royal.Infrastructure.Utils.Math.NumberExtensions.Approximately(a:  val_2.y, b:  V3.16B, precision:  0.1f)) != false)
            {
                    return;
            }
            
            Royal.Scenes.Home.Ui.Dialogs.ViewTeam.ViewTeamButton.CloseViewTeamButton();
        }
        public void ViewTeam()
        {
            Royal.Scenes.Home.Ui.Dialogs.ViewTeam.ViewTeamButton.CloseViewTeamButton();
            Royal.Scenes.Start.Context.Units.Flow.FlowManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
            Royal.Scenes.Home.Ui.Sections.Social.MyTeam.ICanOpenTeamInfoPopupOnTop val_3 = this.transform.GetComponentInParent<Royal.Scenes.Home.Ui.Sections.Social.MyTeam.ICanOpenTeamInfoPopupOnTop>();
            if(val_3 != null)
            {
                    val_1.Push(type:  val_3.GetType(), action:  new Royal.Scenes.Home.Ui.Sections.Social.MyTeam.ShowTeamInfoPopupAction(teamId:  this.teamId));
                return;
            }
            
            val_1.Push(action:  new Royal.Scenes.Home.Ui.Sections.Social.MyTeam.ShowTeamInfoPopupAction(teamId:  this.teamId));
        }
        private void UpdateSprite(UnityEngine.Sprite sprite)
        {
            this.leftPart.sprite = sprite;
            this.rightPart.sprite = sprite;
        }
        private static void ShowViewTeamButton(long teamId, UnityEngine.Transform parent, float xPosition, float bottomOffset)
        {
            Royal.Scenes.Home.Ui.Dialogs.ViewTeam.ViewTeamButton val_6 = Royal.Scenes.Home.Ui.Dialogs.ViewTeam.ViewTeamButton.ActiveViewTeamButton;
            if(val_6 == 0)
            {
                    val_6 = UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Dialogs.ViewTeam.ViewTeamButton>(path:  "ViewTeamButton");
                Royal.Scenes.Home.Ui.Dialogs.ViewTeam.ViewTeamButton.ActiveViewTeamButton = UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Dialogs.ViewTeam.ViewTeamButton>(original:  val_6, parent:  parent, worldPositionStays:  false);
            }
            else
            {
                    Royal.Scenes.Home.Ui.Dialogs.ViewTeam.ViewTeamButton.ActiveViewTeamButton.transform.SetParent(parent:  parent, worldPositionStays:  false);
            }
            
            Royal.Scenes.Home.Ui.Dialogs.ViewTeam.ViewTeamButton.ActiveViewTeamButtonParent = parent;
            Royal.Scenes.Home.Ui.Dialogs.ViewTeam.ViewTeamButton.ActiveViewTeamButton.gameObject.SetActive(value:  true);
            Royal.Scenes.Home.Ui.Dialogs.ViewTeam.ViewTeamButton.ActiveViewTeamButton.Init(team:  teamId, xPosition:  xPosition, bottomOffset:  bottomOffset);
        }
        private static void CloseViewTeamButton()
        {
            if(Royal.Scenes.Home.Ui.Dialogs.ViewTeam.ViewTeamButton.ActiveViewTeamButton == 0)
            {
                    return;
            }
            
            if(Royal.Scenes.Home.Ui.Dialogs.ViewTeam.ViewTeamButton.ActiveViewTeamButton.gameObject.activeSelf == false)
            {
                    return;
            }
            
            Royal.Scenes.Home.Ui.Dialogs.ViewTeam.ViewTeamButton.ActiveViewTeamButtonParent = 0;
            Royal.Scenes.Home.Ui.Dialogs.ViewTeam.ViewTeamButton.ActiveViewTeamButton.gameObject.SetActive(value:  false);
        }
        public static void ToggleViewTeamButton(long teamId, UnityEngine.Transform parent, float xPosition, float bottomOffset = 3)
        {
            if(teamId >= 1)
            {
                    if(parent != Royal.Scenes.Home.Ui.Dialogs.ViewTeam.ViewTeamButton.ActiveViewTeamButtonParent)
            {
                goto label_4;
            }
            
            }
            
            Royal.Scenes.Home.Ui.Dialogs.ViewTeam.ViewTeamButton.CloseViewTeamButton();
            return;
            label_4:
            Royal.Scenes.Home.Ui.Dialogs.ViewTeam.ViewTeamButton.ShowViewTeamButton(teamId:  teamId, parent:  parent, xPosition:  xPosition, bottomOffset:  bottomOffset);
        }
        public static void ClearViewTeamButton()
        {
            Royal.Scenes.Home.Ui.Dialogs.ViewTeam.ViewTeamButton.ActiveViewTeamButton = 0;
            Royal.Scenes.Home.Ui.Dialogs.ViewTeam.ViewTeamButton.ActiveViewTeamButtonParent = 0;
        }
        public ViewTeamButton()
        {
        
        }
    
    }

}
