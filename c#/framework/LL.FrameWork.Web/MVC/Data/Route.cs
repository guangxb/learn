﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace LL.Framework.Web.MVC
{
    /// <summary>
    /// 路由元数据
    /// </summary>
    public class Route
    {
        private readonly static Route _Instance = new Route();

        /// <summary>
        /// 路由元数据实例
        /// </summary>
        public static Route Instance { get { return _Instance; } }

        /// <summary>
        /// 创建RouteData
        /// </summary>
        protected Route() { }
        /// <summary>
        /// 创建RouteData
        /// </summary>
        /// <param name="url"></param>
        public Route(string url) : this(Instance) { Url = url; }
        /// <summary>
        /// 创建RouteData
        /// </summary>
        /// <param name="url"></param>
        /// <param name="routeData"></param>
        public Route(string url, Dictionary<string, object> routeData)
            : this(Instance)
        {
            this.Url = url;
            _routeData = routeData;
        }
        /// <summary>
        /// 创建RouteData
        /// </summary>
        /// <param name="routeData"></param>
        public Route(Route routeData)
        {
            this.Url = routeData.Url;
            _routeData = routeData._routeData;
        }

        private Dictionary<string, object> _routeData = null;
        /// <summary>
        /// 路由数据
        /// </summary>
        public Dictionary<string, object> RouteData
        {
            get
            {
                if (_routeData == null)
                {
                    _routeData = new Dictionary<string, object>();
                }
                return _routeData;
            }
        }
        /// <summary>
        /// 路由时的url
        /// </summary>
        public string Url { get; internal set; }

        /// <summary>
        /// 命名空间
        /// </summary>
        public IEnumerable<string> Namespaces
        {
            get
            {
                return (IEnumerable<string>)GetValue(RouteData, "Namespaces", Enumerable.Empty<string>());
            }
            set
            {
                RouteData["Namespaces"] = value;
            }
        }
        /// <summary>
        /// 使用默认的命名空间(或没有命名空间)限定返回区域
        /// </summary>
        public bool UseNamespaceFallback
        {
            get
            {
                return (bool)GetValue(RouteData, "UseNamespaceFallback", false);
            }
            set
            {
                RouteData["UseNamespaceFallback"] = value;
            }
        }

        /// <summary>
        /// 获取控制器
        /// </summary>
        public string Controller
        {
            get
            {
                return Convert.ToString(GetValue(RouteData, "Controller", ""));
            }
            set
            {
                RouteData["Controller"] = value;
                ShortController = value;
            }
        }
        /// <summary>
        /// 获取短格式控制器名称
        /// </summary>
        public string ShortController
        {
            get
            {
                //ShortController//短格式控制器
                var sc = Convert.ToString(GetValue(RouteData, "ShortController", ""));
                if (string.IsNullOrEmpty(sc))
                    return Controller;
                return sc;
            }
            private set
            {
                int len = value.Length;
                var shortlen = "Controller".Length;
                if (len > shortlen)
                {
                    if (string.Equals("Controller", value.Substring(len - shortlen), StringComparison.OrdinalIgnoreCase))
                    {
                        RouteData["ShortController"] = value.Substring(0, len - shortlen);
                        return;
                    }
                }
                RouteData["ShortController"] = value;
            }
        }

        /// <summary>
        /// 获取动作
        /// </summary>
        public string Action
        {
            get
            {
                return Convert.ToString(GetValue(RouteData, "Action", ""));
            }
            set
            {
                RouteData["Action"] = value;
            }
        }

        /// <summary>
        /// 是否使用 PageUrl 路由
        /// </summary>
        public bool UsePageUrlRoute
        {
            get
            {
                return (bool)GetValue(RouteData, "UsePageUrlRoute", false);
            }
            set
            {
                RouteData["UsePageUrlRoute"] = value;
            }
        }
        /// <summary>
        /// PageUrl 获取的元数据
        /// </summary>
        public Tuple<Type, MethodInfo> PageUrlData
        {
            get
            {
                return (Tuple<Type, MethodInfo>)GetValue(RouteData, "PageUrlData", null);
            }
            set
            {
                RouteData["PageUrlData"] = value;
            }
        }

        /// <summary>
        /// 获取请求的数据
        /// </summary>
        /// <param name="valueName"></param>
        /// <returns></returns>
        public string GetRequiredString(string valueName)
        {
            var value = Convert.ToString(GetValue(RouteData, valueName, ""));
            if (!string.IsNullOrEmpty(value))
            {
                return value;
            }
            throw new InvalidOperationException(string.Format(CultureInfo.CurrentUICulture, "请求的值:{0}不存在或者为空", new object[]
			{
				valueName
			}));
        }

        /// <summary>
        /// 添加命名空间
        /// </summary>
        /// <param name="nameSpace"></param>
        public void AddNS(string nameSpace)
        {
            Namespaces = Namespaces.Concat(new string[] { nameSpace });
        }
        /// <summary>
        /// 添加命名空间
        /// </summary>
        /// <param name="nameSpaces"></param>
        public void AddNS(IEnumerable<string> nameSpaces)
        {
            Namespaces = Namespaces.Concat(nameSpaces);
        }

        /// <summary>
        /// 在字典中查找指定的值查找指定的值，如果没有返回默认值
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="dict"></param>
        /// <param name="key"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        internal static TValue GetValue<TKey, TValue>(IDictionary<TKey, TValue> dict, TKey key, TValue defaultValue)
        {
            if (dict == null) return defaultValue;
            TValue val = default(TValue);
            if (dict.TryGetValue(key, out val))
            {
                return val;
            }
            return defaultValue;
        }
    }
}
