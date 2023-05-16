using UnityEngine;
private class AreaDownloadManager.DownloadOperation
{
    // Fields
    public readonly int areaId;
    public bool isRequiredNow;
    public System.Action<bool> onComplete;
    
    // Methods
    public AreaDownloadManager.DownloadOperation(int areaId, bool isRequiredNow, System.Action<bool> onComplete)
    {
        this.areaId = areaId;
        this.isRequiredNow = isRequiredNow;
        this.onComplete = onComplete;
    }

}
