using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;

//need to have included the System.Web.Extensions.dll in the References 
namespace MessageWalls.Utils
{
    class JsonSerializer
    {
        public static bool Serialize<T>(T obj, out string json)
        {
            json = "";
            try
            {
                json = new JavaScriptSerializer().Serialize(obj);
            }
            catch (Exception ex) 
            {
                return false;
            }

            return true;
        }

        public static bool Deserialize<T>(string json, out T obj)
        {
            obj = default(T);
            try
            {
                obj = (T)new JavaScriptSerializer().Deserialize<T>(json);
            }
            catch (Exception ex) 
            {
                return false;
            }

            return true;
        }
    }
}
