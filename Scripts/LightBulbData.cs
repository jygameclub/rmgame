using UnityEngine;
private struct LightBulbItemView.LightBulbData
{
    // Fields
    public readonly Spine.Slot bulbFront;
    public readonly Spine.Slot bulbBack;
    public readonly Spine.Slot bulbAlternative;
    public readonly Spine.Slot bulbShadowSlot;
    public readonly Spine.Slot cableSlot;
    public readonly Spine.Slot cableShadowSlot;
    
    // Methods
    public LightBulbItemView.LightBulbData(Spine.Slot bulbFront, Spine.Slot bulbBack, Spine.Slot bulbAlternative, Spine.Slot bulbShadowSlot, Spine.Slot cableSlot, Spine.Slot cableShadowSlot)
    {
        this.bulbAlternative = bulbFront;
        this.bulbShadowSlot = bulbBack;
        this.cableSlot = bulbAlternative;
        this.cableShadowSlot = bulbShadowSlot;
        mem[1152921520269993520] = cableSlot;
        mem[1152921520269993528] = cableShadowSlot;
    }

}
