using UnityEngine;
private sealed class FileDownloader.<>c__DisplayClass12_1
{
    // Fields
    public string filePath;
    public Royal.Infrastructure.Services.AssetDownload.FileDownloader.<>c__DisplayClass12_0 CS$<>8__locals1;
    
    // Methods
    public FileDownloader.<>c__DisplayClass12_1()
    {
    
    }
    internal void <Download>b__0(BestHTTP.HTTPRequest request, BestHTTP.HTTPResponse response)
    {
        string val_18;
        System.Object[] val_19;
        object val_20;
        int val_21;
        string val_22;
        string val_23;
        val_18 = 39826;
        if(request == null)
        {
                throw new NullReferenceException();
        }
        
        if((request.<Tag>k__BackingField) != null)
        {
                request.<Tag>k__BackingField.Dispose();
        }
        
        if((response != null) && (request.State == 2))
        {
                val_18 = response;
            if(val_18.IsSuccess != false)
        {
                val_18 = this.filePath;
            Royal.Infrastructure.Services.AssetDownload.FileDownloader.MoveTempFile(filePath:  val_18);
            if((this.CS$<>8__locals1) == null)
        {
                throw new NullReferenceException();
        }
        
            object[] val_3 = new object[1];
            if((this.CS$<>8__locals1) == null)
        {
                throw new NullReferenceException();
        }
        
            val_19 = val_3;
            if(val_3 == null)
        {
                throw new NullReferenceException();
        }
        
            if((this.CS$<>8__locals1.fileName) != null)
        {
                if(X0 == false)
        {
                throw new ArrayTypeMismatchException();
        }
        
        }
        
            if(val_3.Length == 0)
        {
                throw new IndexOutOfRangeException();
        }
        
            val_19[0] = this.CS$<>8__locals1.fileName;
            val_18 = this.CS$<>8__locals1.<>4__this;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  val_18, logTag:  22, log:  "Download file finished: {0}", values:  val_3);
            if((this.CS$<>8__locals1) == null)
        {
                throw new NullReferenceException();
        }
        
            val_18 = this.CS$<>8__locals1.<>4__this;
            if(val_18 == null)
        {
                throw new NullReferenceException();
        }
        
            val_18.DownloadCompleted(success:  true);
            return;
        }
        
        }
        
        if((this.CS$<>8__locals1) == null)
        {
                throw new NullReferenceException();
        }
        
        object[] val_4 = new object[4];
        if((this.CS$<>8__locals1) == null)
        {
                throw new NullReferenceException();
        }
        
        if(val_4 == null)
        {
                throw new NullReferenceException();
        }
        
        if((this.CS$<>8__locals1.fileName) != null)
        {
                if(X0 == false)
        {
                throw new ArrayTypeMismatchException();
        }
        
        }
        
        if(val_4.Length == 0)
        {
                throw new IndexOutOfRangeException();
        }
        
        val_4[0] = this.CS$<>8__locals1.fileName;
        BestHTTP.HTTPRequestStates val_5 = request.State;
        if(val_5 != 0)
        {
                if(X0 == false)
        {
                throw new ArrayTypeMismatchException();
        }
        
        }
        
        if(val_4.Length <= 1)
        {
                throw new IndexOutOfRangeException();
        }
        
        val_4[1] = val_5;
        if(response != null)
        {
                val_20 = 0;
        }
        else
        {
                val_20 = 0;
        }
        
        if(val_20 != 0)
        {
                if(X0 == false)
        {
                throw new ArrayTypeMismatchException();
        }
        
        }
        
        val_21 = val_4.Length;
        if(val_21 <= 2)
        {
                throw new IndexOutOfRangeException();
        }
        
        val_4[2] = val_20;
        if((this.CS$<>8__locals1) == null)
        {
                throw new NullReferenceException();
        }
        
        val_22 = this.CS$<>8__locals1.url;
        if(val_22 != null)
        {
                if(X0 == false)
        {
                throw new ArrayTypeMismatchException();
        }
        
            val_21 = val_4.Length;
        }
        
        if(val_21 <= 3)
        {
                throw new IndexOutOfRangeException();
        }
        
        val_4[3] = val_22;
        val_18 = this.CS$<>8__locals1.<>4__this;
        Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  val_18, logTag:  22, log:  "Download file failed: {0}, status:{1}/{2}, url:{3}", values:  val_4);
        if((this.CS$<>8__locals1) == null)
        {
                throw new NullReferenceException();
        }
        
        val_18 = this.CS$<>8__locals1.<>4__this;
        if(val_18 == null)
        {
                throw new NullReferenceException();
        }
        
        val_18.DownloadCompleted(success:  false);
        if((this.CS$<>8__locals1) == null)
        {
                throw new NullReferenceException();
        }
        
        Royal.Infrastructure.Services.AssetDownload.FileDownloader.RemoveDownloadedFile(filePath:  System.IO.Path.Combine(path1:  this.CS$<>8__locals1.saveDirectory, path2:  this.CS$<>8__locals1.fileName));
        val_23 = "other";
        if((request.State != 3) || ((request.<Exception>k__BackingField) == null))
        {
            goto label_41;
        }
        
        if((this.CS$<>8__locals1) == null)
        {
                throw new NullReferenceException();
        }
        
        val_23 = "error";
        object[] val_8 = new object[2];
        val_18 = request.<Exception>k__BackingField;
        if(val_18 == null)
        {
                throw new NullReferenceException();
        }
        
        if(val_8 == null)
        {
                throw new NullReferenceException();
        }
        
        if(val_18 != null)
        {
                if(X0 == false)
        {
                throw new ArrayTypeMismatchException();
        }
        
        }
        
        if(val_8.Length == 0)
        {
                throw new IndexOutOfRangeException();
        }
        
        val_8[0] = val_18;
        val_18 = request.<Exception>k__BackingField;
        if(val_18 == null)
        {
                throw new NullReferenceException();
        }
        
        val_22 = val_18;
        if(val_18 != null)
        {
                if(X0 == false)
        {
                throw new ArrayTypeMismatchException();
        }
        
        }
        
        if(val_8.Length <= 1)
        {
                throw new IndexOutOfRangeException();
        }
        
        val_8[1] = val_22;
        Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this.CS$<>8__locals1.<>4__this, logTag:  22, log:  "Exception: {0} - {1}", values:  val_8);
        goto label_63;
        label_41:
        if((request.State == 6) || (request.State == 5))
        {
            goto label_54;
        }
        
        if(response == null)
        {
            goto label_63;
        }
        
        if((response.<StatusCode>k__BackingField) != 408)
        {
            goto label_56;
        }
        
        label_54:
        val_23 = "timeout";
        label_63:
        Firebase.Analytics.Parameter[] val_11 = new Firebase.Analytics.Parameter[1];
        val_19 = val_11;
        Firebase.Analytics.Parameter val_12 = new Firebase.Analytics.Parameter(parameterName:  "reason", parameterValue:  val_23);
        if(val_19 == null)
        {
                throw new NullReferenceException();
        }
        
        if(val_12 != null)
        {
                if(X0 == false)
        {
                throw new ArrayTypeMismatchException();
        }
        
        }
        
        if(val_11.Length == 0)
        {
                throw new IndexOutOfRangeException();
        }
        
        val_19[0] = val_12;
        Firebase.Analytics.FirebaseAnalytics.LogEvent(name:  "download_failed", parameters:  val_11);
        return;
        label_56:
        var val_13 = ((response.<StatusCode>k__BackingField) < 400) ? (val_23) : "http_response";
        goto label_63;
    }
    internal bool <Download>b__1(BestHTTP.HTTPRequest request, BestHTTP.HTTPResponse response, byte[] dataFragment, int dataFragmentLength)
    {
        BestHTTP.HTTPResponse val_3 = response;
        if(val_3.IsSuccess == false)
        {
                return true;
        }
        
        val_3 = request.<Tag>k__BackingField;
        System.IO.FileStream val_2 = null;
        val_3 = val_2;
        val_2 = new System.IO.FileStream(path:  this.filePath, mode:  2);
        request = val_3;
        return true;
    }

}
