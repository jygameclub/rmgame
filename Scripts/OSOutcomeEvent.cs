using UnityEngine;
public class OSOutcomeEvent
{
    // Fields
    public OSOutcomeEvent.OSSession session;
    public System.Collections.Generic.List<string> notificationIds;
    public string name;
    public long timestamp;
    public double weight;
    
    // Methods
    public OSOutcomeEvent()
    {
        this.session = 3;
        this.notificationIds = new System.Collections.Generic.List<System.String>();
        this.name = "";
    }
    public OSOutcomeEvent(System.Collections.Generic.Dictionary<string, object> outcomeDict)
    {
        string val_18;
        var val_19;
        string val_34;
        System.Collections.Generic.List<System.String> val_35;
        IntPtr val_36;
        string val_37;
        string val_38;
        string val_39;
        string val_40;
        this.session = 3;
        this.notificationIds = new System.Collections.Generic.List<System.String>();
        this.name = "";
        if(((outcomeDict.ContainsKey(key:  "session")) != false) && (outcomeDict.Item["session"] != null))
        {
                string val_33 = "session";
            object val_4 = outcomeDict.Item[val_33];
            if(val_4 != null)
        {
                val_33 = (null == null) ? (val_4) : 0;
        }
        else
        {
                val_34 = 0;
        }
        
            this.session = val_4.SessionFromString(session:  val_34);
        }
        
        if(((outcomeDict.ContainsKey(key:  "notification_ids")) == false) || (outcomeDict.Item["notification_ids"] == null))
        {
            goto label_7;
        }
        
        System.Collections.Generic.List<System.String> val_8 = null;
        val_35 = val_8;
        val_8 = new System.Collections.Generic.List<System.String>();
        val_36 = null;
        System.Type val_11 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = val_36});
        if((outcomeDict.Item["notification_ids"].GetType() & 1) == 0)
        {
            goto label_12;
        }
        
        System.Collections.Generic.List<System.String> val_12 = null;
        val_35 = val_12;
        val_12 = new System.Collections.Generic.List<System.String>();
        object val_13 = outcomeDict.Item["notification_ids"];
        if(val_13 == null)
        {
            goto label_15;
        }
        
        var val_14 = (null == null) ? (val_13) : 0;
        goto label_16;
        label_12:
        object val_15 = outcomeDict.Item["notification_ids"];
        List.Enumerator<T> val_17 = GetEnumerator();
        val_36 = 1152921510813432288;
        label_25:
        val_38 = public System.Boolean List.Enumerator<System.Object>::MoveNext();
        if((1360722048 & 1) == 0)
        {
            goto label_22;
        }
        
        val_39 = val_18;
        if(val_39 == 0)
        {
                throw new NullReferenceException();
        }
        
        val_38 = val_39;
        if(val_35 == null)
        {
                throw new NullReferenceException();
        }
        
        val_8.Add(item:  val_38);
        goto label_25;
        label_22:
        val_19.Dispose();
        goto label_46;
        label_15:
        val_37 = 0;
        label_16:
        val_12.Add(item:  System.Convert.ToString(value:  val_37));
        label_46:
        this.notificationIds = val_35;
        label_7:
        if(((outcomeDict.ContainsKey(key:  "id")) != false) && (outcomeDict.Item["id"] != null))
        {
                object val_23 = outcomeDict.Item["id"];
            if(val_23 != null)
        {
                var val_24 = (null == null) ? (val_23) : 0;
        }
        else
        {
                val_40 = 0;
        }
        
            this.name = val_40;
        }
        
        if((outcomeDict.ContainsKey(key:  "timestamp")) != false)
        {
                if(outcomeDict.Item["timestamp"] != null)
        {
                val_38 = null;
            outcomeDict.Item["timestamp"].System.IDisposable.Dispose();
            this.timestamp = null;
        }
        
        }
        
        if((outcomeDict.ContainsKey(key:  "weight")) == false)
        {
                return;
        }
        
        if(outcomeDict.Item["weight"] == null)
        {
                return;
        }
        
        this.weight = System.Double.Parse(s:  System.Convert.ToString(value:  outcomeDict.Item["weight"]));
    }
    private OSOutcomeEvent.OSSession SessionFromString(string session)
    {
        var val_6;
        string val_1 = session.ToLower();
        if((val_1.Equals(value:  "direct")) != false)
        {
                val_6 = 0;
            return (OSSession)(((val_1.Equals(value:  "unattributed")) & true) != 0) ? (2 + 1) : 2;
        }
        
        if((val_1.Equals(value:  "indirect")) == false)
        {
                return (OSSession)(((val_1.Equals(value:  "unattributed")) & true) != 0) ? (2 + 1) : 2;
        }
        
        val_6 = 1;
        return (OSSession)(((val_1.Equals(value:  "unattributed")) & true) != 0) ? (2 + 1) : 2;
    }

}
