using UnityEngine;
public class StoryItemCollection : MonoBehaviour
{
    // Fields
    public float speed;
    public UnityEngine.ParticleSystem hitParticles;
    private float duration;
    private float elapsed;
    private UnityEngine.Vector3 startPos;
    private UnityEngine.Vector3 delta;
    private UnityEngine.Transform collector;
    private bool willBeDestroyed;
    private Royal.Infrastructure.Utils.Randoming.RandomManager randomManager;
    private UnityEngine.Vector3 middlePoint;
    private UnityEngine.Vector3 perpendicularVector;
    private float sign;
    private float itemSpeed;
    
    // Methods
    public void Init()
    {
        null = null;
        this.collector = typeof(Royal.Scenes.Game.Ui.GameUi).__il2cppRuntimeField_28 + 112 + 136 + 56;
        this.transform.SetParent(parent:  typeof(Royal.Scenes.Game.Ui.GameUi).__il2cppRuntimeField_28 + 112 + 136.transform, worldPositionStays:  true);
        UnityEngine.Vector3 val_4 = this.transform.position;
        this.startPos = val_4;
        mem[1152921518882556948] = val_4.y;
        mem[1152921518882556952] = val_4.z;
        UnityEngine.Vector3 val_5 = this.collector.position;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        this.delta = val_6;
        mem[1152921518882556960] = val_6.y;
        mem[1152921518882556964] = val_6.z;
        val_6.x = val_6.x / this.speed;
        mem[1152921518882556936] = val_6.x;
        float val_28 = -20f;
        val_28 = this.delta * val_28;
        UnityEngine.Quaternion val_9 = UnityEngine.Quaternion.Euler(x:  0f, y:  0f, z:  val_28 * (UnityEngine.Random.Range(min:  0.7f, max:  1.3f)));
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = this.delta, y = val_9.y, z = val_9.z}, d:  3.3f);
        UnityEngine.Vector3 val_11 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_9.x, y = val_9.y, z = val_9.z, w = val_9.w}, point:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
        this.delta = val_11;
        mem[1152921518882556960] = val_11.y;
        mem[1152921518882556964] = val_11.z;
        this.elapsed = 0f;
        this.willBeDestroyed = false;
        Royal.Scenes.Game.Mechanics.Sortings.SortingData val_14 = Royal.Infrastructure.Utils.Sprite.SpriteExtensions.GetSorting(renderer:  typeof(Royal.Scenes.Game.Ui.GameUi).__il2cppRuntimeField_28 + 112 + 136 + 48.GetComponentInChildren<UnityEngine.SpriteRenderer>());
        val_14.sortEverything = val_14.sortEverything & 4294967295;
        Royal.Scenes.Game.Mechanics.Sortings.SortingData val_15 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_14.layer, order = val_14.order, sortEverything = val_14.sortEverything}, offset:  0);
        Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(group:  this.GetComponent<UnityEngine.Rendering.SortingGroup>(), data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_15.layer, order = val_15.order, sortEverything = val_15.sortEverything & 4294967295});
        Royal.Infrastructure.Utils.Randoming.RandomManager val_17 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Utils.Randoming.RandomManager>(id:  5);
        this.randomManager = val_17;
        float val_18 = val_17.Next(min:  0.1f, max:  0.8f);
        this.sign = (this.randomManager.NextBool() != true) ? -1f : 1f;
        UnityEngine.Vector3 val_21 = this.collector.position;
        UnityEngine.Vector3 val_22 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.startPos, y = val_9.z, z = val_9.w}, b:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z}, t:  val_18);
        this.middlePoint = val_22;
        mem[1152921518882556996] = val_22.y;
        mem[1152921518882557000] = val_22.z;
        UnityEngine.Vector3 val_23 = UnityEngine.Vector3.forward;
        UnityEngine.Quaternion val_24 = UnityEngine.Quaternion.AngleAxis(angle:  90f, axis:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z});
        UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z}, b:  new UnityEngine.Vector3() {x = this.startPos, y = val_9.z, z = val_9.w});
        UnityEngine.Vector3 val_26 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_24.x, y = val_24.y, z = val_24.z, w = val_24.w}, point:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z});
        float val_29 = this.sign;
        val_29 = val_18 * val_29;
        UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z}, d:  val_29);
        this.perpendicularVector = val_27;
        mem[1152921518882557008] = val_27.y;
        mem[1152921518882557012] = val_27.z;
        this.itemSpeed = 1f;
    }
    public void Update()
    {
        float val_14;
        var val_15;
        if(this.willBeDestroyed != false)
        {
                return;
        }
        
        val_14 = this.elapsed;
        if(val_14 < 0)
        {
                float val_1 = Royal.Scenes.Game.Levels.LevelContext.DeltaTime;
            val_1 = val_1 * this.itemSpeed;
            val_14 = val_14 + val_1;
            this.elapsed = val_14;
            float val_2 = UnityEngine.Mathf.Min(a:  val_14, b:  this.duration);
            this.elapsed = val_2;
            val_2 = val_2 / this.duration;
            float val_3 = UnityEngine.Mathf.Clamp(value:  val_2, min:  0f, max:  1f);
            this.itemSpeed = UnityEngine.Mathf.Lerp(a:  1f, b:  2f, t:  val_3);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.middlePoint, y = V12.16B, z = V11.16B}, b:  new UnityEngine.Vector3() {x = this.perpendicularVector, y = V10.16B, z = 1f});
            UnityEngine.Vector3 val_6 = this.collector.position;
            UnityEngine.Vector3 val_7 = this.collector.position;
            UnityEngine.Vector3 val_8 = Royal.Infrastructure.Utils.Animation.CubicBezierCurve.GetValue(t:  val_3, p0:  new UnityEngine.Vector3() {x = this.startPos, y = this.middlePoint, z = V14.16B}, p1:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, p2:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.z, z = val_7.x}, p3:  new UnityEngine.Vector3() {x = val_7.z, y = ???, z = ???});
            this.transform.position = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            UnityEngine.Vector3 val_11 = this.transform.position;
            val_14 = val_11.x;
            UnityEngine.Vector3 val_12 = this.collector.position;
            if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_14, y = val_11.y, z = val_11.z}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z})) >= 0)
        {
                return;
        }
        
            if(this.willBeDestroyed == true)
        {
                return;
        }
        
        }
        
        this.hitParticles.Play();
        this.willBeDestroyed = true;
        val_15 = null;
        val_15 = null;
        typeof(Royal.Scenes.Game.Ui.GameUi).__il2cppRuntimeField_28 + 112 + 136.Increment();
        this.Invoke(methodName:  "DestroyLate", time:  1f);
    }
    private void DestroyLate()
    {
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }
    public StoryItemCollection()
    {
        this.speed = 6.5f;
        this.duration = 0.6f;
    }

}
