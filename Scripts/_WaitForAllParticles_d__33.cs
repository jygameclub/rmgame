using UnityEngine;
private sealed class KingDrillProgress.<WaitForAllParticles>d__33 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Story.KingDrillProgress <>4__this;
    private Royal.Scenes.Game.Story.KingDrillProgress.<>c__DisplayClass33_0 <>8__1;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public KingDrillProgress.<WaitForAllParticles>d__33(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        KingDrillProgress.<>c__DisplayClass33_0 val_46;
        int val_47;
        val_46 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        this.<>8__1 = new KingDrillProgress.<>c__DisplayClass33_0();
        .<>4__this = this.<>4__this;
        if((this.<>4__this) != null)
        {
            goto label_4;
        }
        
        label_1:
        this.<>1__state = 0;
        label_4:
        if((this.<>4__this.partialProgress) < 0)
        {
            goto label_7;
        }
        
        this.<>8__1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
        UnityEngine.Vector3 val_3 = this.<>8__1.camManager.GetPosition();
        this.<>8__1 = val_3.x;
        this.<>8__1 = val_3.y;
        this.<>8__1 = val_3.z;
        this.<>8__1 = 0;
        UnityEngine.Vector3 val_5 = this.<>4__this.stopButton.transform.position;
        float val_6 = UnityEngine.Mathf.Lerp(a:  val_5.x, b:  this.<>8__1.finalPos, t:  0.3f);
        float val_7 = val_5.y + 0.5f;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, d:  0.3f);
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.left;
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, d:  0.1f);
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.right;
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, d:  0.2f);
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_6, y = val_7, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.left;
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_6, y = val_7, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.<>8__1.finalPos, y = val_10.x, z = val_10.y}, b:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z});
        this.<>4__this.drillRoom.StopAllCoroutines();
        this.<>4__this.drillRoom.EndRedFrame(onCycleComplete:  0, delay:  0f);
        this.<>4__this.stopButton.GetComponent<UnityEngine.Rendering.SortingGroup>().enabled = true;
        this.<>4__this.stopHighlight.gameObject.SetActive(value:  true);
        UnityEngine.Vector2 val_24 = this.<>8__1.camManager.GetCenterPosition();
        UnityEngine.Vector3 val_25 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_24.x, y = val_24.y});
        this.<>4__this.stopHighlight.transform.position = new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z};
        UnityEngine.Vector2 val_26 = this.<>8__1.camManager.GetScreenSize();
        this.<>4__this.stopHighlight.size = new UnityEngine.Vector2() {x = val_26.x, y = val_26.y};
        UnityEngine.Vector2 val_28 = this.<>4__this.stopHighlight.size;
        this.<>4__this.stopHighlight.GetComponent<UnityEngine.BoxCollider2D>().size = new UnityEngine.Vector2() {x = val_28.x, y = val_28.y};
        DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_29 = DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.<>4__this.stopHighlight, endValue:  0.8f, duration:  0.4f);
        UnityEngine.Vector3 val_31 = UnityEngine.Vector3.zero;
        this.<>4__this.stopPressText.transform.localScale = new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z};
        DG.Tweening.Sequence val_32 = DG.Tweening.DOTween.Sequence();
        UnityEngine.Vector3[] val_33 = new UnityEngine.Vector3[6];
        val_33[0] = val_6;
        val_33[0] = val_7;
        val_33[1] = val_5.z;
        val_33[1] = val_13;
        val_33[2] = val_13.y;
        val_33[2] = val_13.z;
        val_33[3] = val_16;
        val_33[3] = val_16.y;
        val_33[4] = val_16.z;
        val_33[4] = this.<>8__1.finalPos;
        val_33[5] = val_10;
        val_33[5] = val_10.y;
        val_33[6] = val_18;
        val_33[6] = val_18.y;
        val_33[7] = val_18.z;
        val_33[7] = val_20;
        val_33[8] = val_20.y;
        val_33[8] = val_20.z;
        UnityEngine.Color val_34 = UnityEngine.Color.green;
        DG.Tweening.Sequence val_37 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_32, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>>(t:  DG.Tweening.ShortcutExtensions.DOPath(target:  this.<>4__this.stopButton, path:  val_33, duration:  0.65f, pathType:  2, pathMode:  1, resolution:  50, gizmoColor:  new System.Nullable<UnityEngine.Color>() {HasValue = true}), animCurve:  this.<>4__this.stopButtonEasing));
        DG.Tweening.Sequence val_40 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_32, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.<>4__this.stopButton, endValue:  1.7f, duration:  0.65f), ease:  2));
        DG.Tweening.Sequence val_42 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_32, atPosition:  0.55f, callback:  new DG.Tweening.TweenCallback(object:  this.<>8__1, method:  System.Void KingDrillProgress.<>c__DisplayClass33_0::<WaitForAllParticles>b__0()));
        val_46 = this.<>8__1;
        DG.Tweening.Sequence val_44 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_32, action:  new DG.Tweening.TweenCallback(object:  val_46, method:  System.Void KingDrillProgress.<>c__DisplayClass33_0::<WaitForAllParticles>b__1()));
        label_2:
        val_47 = 0;
        return (bool)val_47;
        label_7:
        val_47 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_47;
        return (bool)val_47;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.<>2__current;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        throw new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.<>2__current;
    }

}
