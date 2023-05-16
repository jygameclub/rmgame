using UnityEngine;
private sealed class MailGoalView.<>c__DisplayClass10_0
{
    // Fields
    public Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View.MailGoalView <>4__this;
    public UnityEngine.Vector3 targetPosition;
    public System.Action onComplete;
    
    // Methods
    public MailGoalView.<>c__DisplayClass10_0()
    {
    
    }
    internal void <InitAndMove>b__0()
    {
        this.<>4__this.viewParent.gameObject.SetActive(value:  true);
        this.<>4__this.PlayMailSpineAnimation();
        this.<>4__this.viewParent.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this.<>4__this.EnableTracerParticles();
    }
    internal void <InitAndMove>b__1()
    {
        UnityEngine.Coroutine val_2 = this.<>4__this.StartCoroutine(routine:  this.<>4__this.CurveToGoal(duration:  0.4f, targetPos:  new UnityEngine.Vector3() {x = this.targetPosition}, onComplete:  this.onComplete));
    }

}
