using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthwindUI.Extensions
{
    public static class SessionExtensionMethods
    {
        public static void SetObj(this ISession session, string key, object value)
        {
            string objString = JsonConvert.SerializeObject(value);
            session.SetString(key, objString);
        }

        public static T GetObj<T>(this ISession session, string key) where T : class
        {
            string objString = session.GetString(key);
            if (string.IsNullOrEmpty(objString))
            {
                return null;
            }
            else
            {
                T value = JsonConvert.DeserializeObject<T>(objString);
                return value;
            }
        }
    }
}
