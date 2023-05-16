using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Social.SearchTeam
{
    public class SearchTeamPopup : UiPopup, IBackable, ICanOpenTeamInfoPopupOnTop
    {
        // Fields
        public UnityEngine.GameObject bottom;
        public TMPro.TMP_InputField queryField;
        public Royal.Infrastructure.UiComponents.UiSpinner spinner;
        public Royal.Scenes.Home.Ui.Sections.Social.NoTeam.TeamListScroll searchList;
        public UnityEngine.BoxCollider2D backgroundCollider;
        public UnityEngine.SpriteRenderer backgroundSprite;
        public UnityEngine.Transform root;
        private Royal.Infrastructure.UiComponents.Touch.UiTouchListener uiTouchListener;
        private bool hideMyTeam;
        
        // Methods
        public void Show()
        {
            this.uiTouchListener = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            this.ResizeBackground();
            this.PlayShowAnimation();
        }
        private void ResizeBackground()
        {
            Royal.Infrastructure.Contexts.Units.CameraManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  val_1.cameraWidth, y:  val_1.cameraHeight);
            this.backgroundCollider.size = new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
            this.backgroundSprite.size = new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
        }
        private void PlayShowAnimation()
        {
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
            UnityEngine.Vector2 val_3 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1).GetCenterPosition();
            UnityEngine.Vector3 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
            this.root.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  0.01f);
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            this.root.localScale = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            DG.Tweening.Sequence val_8 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, d:  0.02f);
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_8, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.root, endValue:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, duration:  0.05f), ease:  6));
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, d:  0.01f);
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
            DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_8, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.root, endValue:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, duration:  0.12f), ease:  6));
            DG.Tweening.Sequence val_23 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_8, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.root, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.065f), ease:  6));
        }
        public void Suggest()
        {
            this.hideMyTeam = true;
            this.SearchTeam(query:  System.String.alignConst);
        }
        public void Search()
        {
            if(val_1.m_stringLength > 2)
            {
                    this.hideMyTeam = false;
                this.SearchTeam(query:  this.queryField.m_Text.Trim());
                return;
            }
            
            Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.ShowText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Type at least three characters."), position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, width:  7f, speed:  1f);
        }
        public void Clear()
        {
            this.spinner.Hide();
            this.queryField.text = System.String.alignConst;
            this.bottom.SetActive(value:  true);
            this.searchList.gameObject.SetActive(value:  false);
            if(this.searchList.content.dataList == null)
            {
                    return;
            }
            
            this = ???;
            goto typeof(Royal.Infrastructure.UiComponents.Scroll.Content.UiOptimizedScrollContent).__il2cppRuntimeField_170;
        }
        private void SearchTeam(string query)
        {
            this.spinner.Show();
            this.searchList.gameObject.SetActive(value:  true);
            Royal.Infrastructure.Services.Backend.Http.Command.Commands val_3 = new Royal.Infrastructure.Services.Backend.Http.Command.Commands();
            val_3.Add(httpCommand:  new Royal.Infrastructure.Services.Backend.Http.Command.Social.SearchTeamHttpCommand(searchText:  query));
            val_3.add_OnComplete(value:  new Commands.ConnectionComplete(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Social.SearchTeam.SearchTeamPopup::SearchedTeamsReceived(bool isSuccess, Royal.Infrastructure.Services.Backend.Http.Command.Commands container)));
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.BackendHttpService>(id:  7).SendImmediately(commandsToSend:  val_3, timeOut:  10f);
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Analytics.AnalyticsManager>(id:  17).Search(query:  query);
        }
        private void SearchedTeamsReceived(bool isSuccess, Royal.Infrastructure.Services.Backend.Http.Command.Commands container)
        {
            if(this.spinner == 0)
            {
                    return;
            }
            
            this.spinner.Hide();
            if(isSuccess == false)
            {
                goto label_5;
            }
            
            Royal.Infrastructure.Services.Backend.Http.Command.BaseHttpCommand val_2 = container.FindCommandByType(responseType:  15);
            if( <= 0)
            {
                goto label_10;
            }
            
            this.bottom.SetActive(value:  false);
            this.searchList.PrepareContent(response:  new Royal.Infrastructure.Services.Backend.Protocol.SearchTeamResponse() {__p = new FlatBuffers.Table()}, hideMyTeam:  this.hideMyTeam, createSlowly:  false);
            return;
            label_5:
            Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.ShowConnectionProblem();
            return;
            label_10:
            Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.ShowText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "There are no results for this name."), position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, width:  7f, speed:  1f);
        }
        public void OnSelectField()
        {
            this.queryField.m_Placeholder.gameObject.SetActive(value:  false);
        }
        public void OnDeSelectField()
        {
            this.queryField.m_Placeholder.gameObject.SetActive(value:  true);
        }
        public void Close()
        {
            this.Destroy();
        }
        public void PressBack()
        {
            this.Close();
        }
        public void EnableQueryField(bool enable)
        {
            if(this.queryField != null)
            {
                    this.queryField.enabled = enable;
                return;
            }
            
            throw new NullReferenceException();
        }
        public SearchTeamPopup()
        {
        
        }
    
    }

}
