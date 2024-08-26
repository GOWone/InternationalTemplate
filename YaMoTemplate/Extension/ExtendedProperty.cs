using System;
using System.Collections.Generic;

namespace YaMoTemplate.Extension
{
    public class ExtendedProperty : Dictionary<string, object>
    {
        public new object this[string key]
        {
            get
            {
                bool flag = key == null;
                object result;
                if (flag)
                {
                    result = null;
                }
                else
                {
                    bool flag2 = base.ContainsKey(key);
                    if (flag2)
                    {
                        result = base[key];
                    }
                    else
                    {
                        result = null;
                    }
                }
                return result;
            }
            set
            {
                bool flag = key == null;
                if (!flag)
                {
                    bool flag2 = base.ContainsKey(key);
                    if (flag2)
                    {
                        base[key] = value;
                    }
                    else
                    {
                        base.Add(key, value);
                    }
                }
            }
        }

        public T GetValue<T>(string key)
        {
            bool flag = key == null;
            T result;
            if (flag)
            {
                result = default(T);
            }
            else
            {
                object obj = base[key];
                bool flag2 = obj == null;
                if (flag2)
                {
                    result = default(T);
                }
                else
                {
                    Type type = obj.GetType();
                    Type typeFromHandle = typeof(T);
                    bool flag3 = type.IsSubclassOf(typeFromHandle) || typeFromHandle.IsAssignableFrom(type);
                    if (flag3)
                    {
                        result = (T)((object)obj);
                    }
                    else
                    {
                        result = default(T);
                    }
                }
            }
            return result;
        }

        public string GetStringValue(string key)
        {
            bool flag = key == null;
            string result;
            if (flag)
            {
                result = null;
            }
            else
            {
                object obj = this[key];
                bool flag2 = obj == null;
                if (flag2)
                {
                    result = null;
                }
                else
                {
                    result = obj.ToString();
                }
            }
            return result;
        }

        public new bool ContainsKey(string key)
        {
            return key != null && base.ContainsKey(key);
        }

        public new bool TryGetValue(string key, out object value)
        {
            bool flag = key == null;
            bool result;
            if (flag)
            {
                value = null;
                result = false;
            }
            else
            {
                result = base.TryGetValue(key, out value);
            }
            return result;
        }

        public bool TryGetStringValue(string key, out string value)
        {
            bool flag = key == null;
            bool result;
            if (flag)
            {
                value = null;
                result = false;
            }
            else
            {
                object obj;
                bool flag2 = base.TryGetValue(key, out obj);
                bool flag3 = flag2;
                if (flag3)
                {
                    value = ((obj != null) ? obj.ToString() : null);
                    result = true;
                }
                else
                {
                    value = null;
                    result = false;
                }
            }
            return result;
        }

        public bool TryGetValue<T>(string key, out T value)
        {
            bool flag = key == null;
            bool result;
            if (flag)
            {
                value = default(T);
                result = false;
            }
            else
            {
                object obj;
                bool flag2 = base.TryGetValue(key, out obj);
                bool flag3 = flag2;
                if (flag3)
                {
                    bool flag4 = obj == null;
                    if (flag4)
                    {
                        value = default(T);
                    }
                    else
                    {
                        Type type = obj.GetType();
                        Type typeFromHandle = typeof(T);
                        bool flag5 = type.IsSubclassOf(typeFromHandle) || typeFromHandle.IsAssignableFrom(type);
                        if (flag5)
                        {
                            value = (T)((object)obj);
                        }
                        else
                        {
                            value = default(T);
                        }
                    }
                    result = true;
                }
                else
                {
                    value = default(T);
                    result = false;
                }
            }
            return result;
        }
    }
}
