using UnityEngine;
private sealed class AreaView.<>c__DisplayClass17_1
{
    // Fields
    public Royal.Scenes.Home.Areas.Scripts.AreaTaskView areaTaskView;
    public bool isLast;
    public Royal.Scenes.Home.Areas.Scripts.AreaView.<>c__DisplayClass17_0 CS$<>8__locals1;
    public DG.Tweening.TweenCallback <>9__3;
    
    // Methods
    public AreaView.<>c__DisplayClass17_1()
    {
    
    }
    internal void <ReplayAnimations>b__2()
    {
        DG.Tweening.TweenCallback val_7;
        this.CS$<>8__locals1.areaPlayAnimations.Add(item:  this.areaTaskView);
        val_7 = this.<>9__3;
        if(val_7 == null)
        {
                DG.Tweening.TweenCallback val_2 = null;
            val_7 = val_2;
            val_2 = new DG.Tweening.TweenCallback(object:  this, method:  System.Void AreaView.<>c__DisplayClass17_1::<ReplayAnimations>b__3());
            this.<>9__3 = val_7;
        }
        
        DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  this.areaTaskView, atPosition:  this.areaTaskView.GetUiAppearTime(), callback:  val_2);
        if(this.isLast == false)
        {
                return;
        }
        
        DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  this.areaTaskView, atPosition:  this.areaTaskView.GetParticleStartTime(), callback:  new DG.Tweening.TweenCallback(object:  this.CS$<>8__locals1.<>4__this, method:  System.Void Royal.Scenes.Home.Areas.Scripts.AreaView::PlayAllFinalParticles()));
    }
    internal void <ReplayAnimations>b__3()
    {
        this.areaTaskView = 0;
        this.areaTaskView = 1;
    }

}
