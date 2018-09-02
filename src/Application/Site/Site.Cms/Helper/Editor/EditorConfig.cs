﻿using MicBeach.Web.Utility;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Linq;

namespace Site.Cms.Util.Editor
{
    /// <summary>
    /// Config 的摘要说明
    /// </summary>
    public static class EditorConfig
    {
        private static bool noCache = true;

        private static JObject BuildItems()
        {
            var json = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "config.json"));
            return JObject.Parse(json);
        }

        public static JObject Items
        {
            get
            {
                if (noCache || _Items == null)
                {
                    _Items = BuildItems();
                }
                return _Items;
            }
        }

        private static JObject _Items;

        public static T GetValue<T>(string key)
        {
            return Items[key].Value<T>();
        }

        public static String[] GetStringList(string key)
        {
            return Items[key].Select(x => x.Value<String>()).ToArray();
        }

        public static String GetString(string key)
        {
            return GetValue<String>(key);
        }

        public static int GetInt(string key)
        {
            return GetValue<int>(key);
        }
    }
}