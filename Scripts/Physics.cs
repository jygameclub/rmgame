using UnityEngine;
public static class DOTweenModuleUtils.Physics
{
    // Methods
    public static void SetOrientationOnPath(DG.Tweening.Plugins.Options.PathOptions options, DG.Tweening.Tween t, UnityEngine.Quaternion newRot, UnityEngine.Transform trans)
    {
        if(trans != null)
        {
                trans.rotation = new UnityEngine.Quaternion() {x = newRot.x, y = newRot.y, z = newRot.z, w = newRot.w};
            return;
        }
        
        throw new NullReferenceException();
    }
    public static bool HasRigidbody2D(UnityEngine.Component target)
    {
        return false;
    }
    public static bool HasRigidbody(UnityEngine.Component target)
    {
        return false;
    }
    public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> CreateDOTweenPathTween(UnityEngine.MonoBehaviour target, bool tweenRigidbody, bool isLocal, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, DG.Tweening.PathMode pathMode)
    {
        UnityEngine.Transform val_1 = target.transform;
        if(isLocal == false)
        {
                return DG.Tweening.ShortcutExtensions.DOPath(target:  val_1, path:  path, duration:  duration, pathMode:  pathMode);
        }
        
        return DG.Tweening.ShortcutExtensions.DOLocalPath(target:  val_1, path:  path, duration:  duration, pathMode:  pathMode);
    }

}
