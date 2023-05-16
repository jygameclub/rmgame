using UnityEngine;
private sealed class TntRocketCombo.<>c__DisplayClass21_0
{
    // Fields
    public Royal.Scenes.Game.Levels.Units.Combo.TntRocketCombo <>4__this;
    public UnityEngine.SpriteRenderer fromBaseView;
    public UnityEngine.SpriteRenderer toBaseView;
    public Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntRocketCombo.TntRocketComboUseParticles tntRocketUseParticles;
    
    // Methods
    public TntRocketCombo.<>c__DisplayClass21_0()
    {
    
    }
    internal void <AnimateWithTime>b__0()
    {
        this.<>4__this = 0;
        this.<>4__this.ArrangeSorting();
    }
    internal void <AnimateWithTime>b__1()
    {
        this.<>4__this = 1;
        this.<>4__this.ArrangeSorting();
    }
    internal void <AnimateWithTime>b__2()
    {
        float val_6;
        float val_7;
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        this.fromBaseView.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a};
        UnityEngine.Color val_2 = UnityEngine.Color.white;
        this.toBaseView.color = new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
        this.<>4__this.itemFactory.Recycle<Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntRocketCombo.TntRocketComboUseParticles>(go:  this.tntRocketUseParticles);
        Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntRocketCombo.TntRocketComboParticles val_3 = this.<>4__this.itemFactory.Spawn<Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntRocketCombo.TntRocketComboParticles>(poolId:  19, activate:  true);
        val_3.transform.position = new UnityEngine.Vector3() {x = val_2.r, y = val_2.g, z = val_2.b};
        val_3.Play();
        this.<>4__this.fromCell.UnFreezeFall();
        this.<>4__this.toCell.UnFreezeFall();
        this.<>4__this.fromCell.FreezeFallForDuration(duration:  0.1f);
        this.<>4__this.toCell.FreezeFallForDuration(duration:  0.1f);
        Royal.Infrastructure.Utils.Animation.ShakeAnimationConfig val_5 = Royal.Infrastructure.Utils.Animation.ShakeAnimationConfig.TntRocketConfig;
        this.<>4__this.gridManager.ShakeGrid(config:  new Royal.Infrastructure.Utils.Animation.ShakeAnimationConfig() {delay = val_7, duration = val_7, minVibrate = val_7, midVibrate = val_7, maxVibrate = val_6, shouldScale = val_6, shouldVisitCenter = val_6});
        this.<>4__this.AnimationCompleted();
    }

}
