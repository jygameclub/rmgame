using UnityEngine;

namespace OneSignalPush.MiniJSON
{
    public static class Json
    {
        // Methods
        public static object Deserialize(string json)
        {
            if(json == null)
            {
                    return (object)json;
            }
            
            return Json.Parser.Parse(jsonString:  json);
        }
        public static string Serialize(object obj)
        {
            return Json.Serializer.Serialize(obj:  obj);
        }
    
    }

}
