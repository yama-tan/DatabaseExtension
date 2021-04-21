using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;

namespace DatabaseExtension {


    public static class DbExtensions {
        public static void LoadFromRow(this object value, SqlResultRow row) {
            if (value == null) {
                return;
            }
            if (row == null) {
                return;
            }
            value.SetValues(row);
        }
        public static T Create<T>(this SqlResultRow row) {
            var ctor = GetConstructor<T>();
            var obj = (T)ctor.Invoke(null);
            obj.SetValues(row);
            return obj;
        }

        public static T0 Create<T0, T1>(this SqlResultRow row, T1 param1) {
            var ctor = GetConstructor<T0, T1>();
            var obj = (T0)ctor.Invoke(new object[] { param1 });
            obj.SetValues(row);
            return obj;
        }
        public static T0 Create<T0, T1, T2>(this SqlResultRow row, T1 param1, T2 param2) {
            var ctor = GetConstructor<T0, T1, T2>();
            var obj = (T0)ctor.Invoke(new object[] { param1, param2 });
            obj.SetValues(row);
            return obj;
        }
        public static T0 Create<T0, T1, T2, T3>(this SqlResultRow row, T1 param1, T2 param2, T3 param3) {
            var ctor = GetConstructor<T0, T1, T2, T3>();
            var obj = (T0)ctor.Invoke(new object[] { param1, param2, param3 });
            obj.SetValues(row);
            return obj;
        }
        public static T0 Create<T0, T1, T2, T3, T4>(this SqlResultRow row, T1 param1, T2 param2, T3 param3, T4 param4) {
            var ctor = GetConstructor<T0, T1, T2, T3, T4>();
            var obj = (T0)ctor.Invoke(new object[] { param1, param2, param3, param4 });
            obj.SetValues(row);
            return obj;
        }
        public static T0 Create<T0, T1, T2, T3, T4, T5>(this SqlResultRow row, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {
            var ctor = GetConstructor<T0, T1, T2, T3, T4, T5>();
            var obj = (T0)ctor.Invoke(new object[] { param1, param2, param3, param4, param5 });
            obj.SetValues(row);
            return obj;
        }
        public static T0 Create<T0, T1, T2, T3, T4, T5, T6>(this SqlResultRow row, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {
            var ctor = GetConstructor<T0, T1, T2, T3, T4, T5, T6>();
            var obj = (T0)ctor.Invoke(new object[] { param1, param2, param3, param4, param5, param6 });
            obj.SetValues(row);
            return obj;
        }

        public static T0 Create<T0, T1, T2, T3, T4, T5, T6, T7>(this SqlResultRow row, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {
            var ctor = GetConstructor<T0, T1, T2, T3, T4, T5, T6, T7>();
            var obj = (T0)ctor.Invoke(new object[] { param1, param2, param3, param4, param5, param6, param7 });
            obj.SetValues(row);
            return obj;
        }

        #region ConstructorInfo Dictionaries
        private static readonly Dictionary<Type, ConstructorInfo> _constructors0 = new Dictionary<Type, ConstructorInfo>();
        private static readonly Dictionary<Tuple<Type, Type>, ConstructorInfo> _constructors1 =
            new Dictionary<Tuple<Type, Type>, ConstructorInfo>();
        private static readonly Dictionary<Tuple<Type, Type, Type>, ConstructorInfo> _constructors2 =
            new Dictionary<Tuple<Type, Type, Type>, ConstructorInfo>();
        private static readonly Dictionary<Tuple<Type, Type, Type, Type>, ConstructorInfo> _constructors3 =
            new Dictionary<Tuple<Type, Type, Type, Type>, ConstructorInfo>();
        private static readonly Dictionary<Tuple<Type, Type, Type, Type, Type>, ConstructorInfo> _constructors4 =
            new Dictionary<Tuple<Type, Type, Type, Type, Type>, ConstructorInfo>();
        private static readonly Dictionary<Tuple<Type, Type, Type, Type, Type, Type>, ConstructorInfo> _constructors5 =
            new Dictionary<Tuple<Type, Type, Type, Type, Type, Type>, ConstructorInfo>();
        private static readonly Dictionary<Tuple<Type, Type, Type, Type, Type, Type, Type>, ConstructorInfo> _constructors6 =
            new Dictionary<Tuple<Type, Type, Type, Type, Type, Type, Type>, ConstructorInfo>();
        private static readonly Dictionary<Tuple<Type, Type, Type, Type, Type, Type, Type, Type>, ConstructorInfo> _constructors7 =
            new Dictionary<Tuple<Type, Type, Type, Type, Type, Type, Type, Type>, ConstructorInfo>();

        #endregion
        #region FieldInfo Dictionaries
        private static readonly Dictionary<Type, Dictionary<FieldInfo, DbColumnAttribute>> _fields = new Dictionary<Type, Dictionary<FieldInfo, DbColumnAttribute>>();
        private static readonly Dictionary<Type, Dictionary<PropertyInfo, DbColumnAttribute>> _properties = new Dictionary<Type, Dictionary<PropertyInfo, DbColumnAttribute>>();
        #endregion

        #region GetConstructor
        private static ConstructorInfo GetConstructor<T>() {
            var t = typeof(T);
            if (!_constructors0.ContainsKey(t)) {
                _constructors0.Add(t, t.GetConstructor(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, Type.DefaultBinder, Type.EmptyTypes, null));
            }
            return _constructors0[t];
        }
        private static ConstructorInfo GetConstructor<T0, T1>() {
            var t = new Tuple<Type, Type>(typeof(T0), typeof(T1));
            if (!_constructors1.ContainsKey(t)) {

                _constructors1.Add(t, typeof(T0).GetConstructor(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, Type.DefaultBinder, new Type[] { typeof(T1) }, null));
            }
            return _constructors1[t];
        }
        private static ConstructorInfo GetConstructor<T0, T1, T2>() {
            var t = new Tuple<Type, Type, Type>(typeof(T0), typeof(T1), typeof(T2));
            if (!_constructors2.ContainsKey(t)) {
                _constructors2.Add(t, typeof(T0).GetConstructor(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, Type.DefaultBinder, new Type[] { typeof(T1), typeof(T2) }, null));
            }
            return _constructors2[t];
        }
        private static ConstructorInfo GetConstructor<T0, T1, T2, T3>() {
            var t = new Tuple<Type, Type, Type, Type>(typeof(T0), typeof(T1), typeof(T2), typeof(T3));
            if (!_constructors3.ContainsKey(t)) {
                _constructors3.Add(t,
                    typeof(T0).GetConstructor(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, Type.DefaultBinder,
                    new Type[] { typeof(T1), typeof(T2), typeof(T3) }, null));
            }
            return _constructors3[t];
        }
        private static ConstructorInfo GetConstructor<T0, T1, T2, T3, T4>() {
            var t = new Tuple<Type, Type, Type, Type, Type>(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4));
            if (!_constructors4.ContainsKey(t)) {
                _constructors4.Add(t,
                    typeof(T0).GetConstructor(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, Type.DefaultBinder,
                    new Type[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4) }, null));
            }
            return _constructors4[t];
        }
        private static ConstructorInfo GetConstructor<T0, T1, T2, T3, T4, T5>() {
            var t = new Tuple<Type, Type, Type, Type, Type, Type>(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5));
            if (!_constructors5.ContainsKey(t)) {
                _constructors5.Add(t,
                    typeof(T0).GetConstructor(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, Type.DefaultBinder,
                    new Type[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5) }, null));
            }
            return _constructors5[t];
        }
        private static ConstructorInfo GetConstructor<T0, T1, T2, T3, T4, T5, T6>() {
            var t = new Tuple<Type, Type, Type, Type, Type, Type, Type>(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6));
            if (!_constructors6.ContainsKey(t)) {
                _constructors6.Add(t,
                    typeof(T0).GetConstructor(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, Type.DefaultBinder,
                    new Type[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6) }, null));
            }
            return _constructors6[t];
        }
        private static ConstructorInfo GetConstructor<T0, T1, T2, T3, T4, T5, T6, T7>() {
            var t = new Tuple<Type, Type, Type, Type, Type, Type, Type, Type>(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7));
            if (!_constructors7.ContainsKey(t)) {
                _constructors7.Add(t,
                    typeof(T0).GetConstructor(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, Type.DefaultBinder,
                    new Type[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7) }, null));
            }
            return _constructors7[t];
        }
        #endregion

        public static void SetValues<T>(this T src, SqlResultRow row) {
            foreach (var p in GetPropertyDictionary<T>()) {
                p.Key.SetValue(src, p.GetValue(row), null);
            }
            foreach (var f in GetFieldDictionary<T>()) {
                f.Key.SetValue(src, f.GetValue(row));
            }
        }

        private static IDictionary<PropertyInfo, DbColumnAttribute> GetPropertyDictionary<T>() {
            if (!_properties.ContainsKey(typeof(T))) {
                var members = new Dictionary<PropertyInfo, DbColumnAttribute>();
                foreach (var p in typeof(T).GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)) {
                    var attrs = p.GetCustomAttributes(typeof(DbColumnAttribute), false);
                    if (attrs != null && attrs.Length > 0) {
                        members.Add(p, attrs[0] as DbColumnAttribute);
                    }
                }
                _properties.Add(typeof(T), members);
            }
            return _properties[typeof(T)];
        }

        private static IDictionary<FieldInfo, DbColumnAttribute> GetFieldDictionary<T>() {
            if (!_fields.ContainsKey(typeof(T))) {
                var fields = new Dictionary<FieldInfo, DbColumnAttribute>();
                foreach (var f in typeof(T).GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)) {
                    var attrs = f.GetCustomAttributes(typeof(DbColumnAttribute), false);
                    if (attrs != null && attrs.Length > 0) {
                        fields.Add(f, attrs[0] as DbColumnAttribute);
                    }
                }
                _fields.Add(typeof(T), fields);
            }
            return _fields[typeof(T)];
        }


        private static object GetValue(this KeyValuePair<FieldInfo, DbColumnAttribute> f, SqlResultRow row) {
            return row[f.Value.ColumnName].GetValue(f.Key.FieldType, f.Value?.DateFormat);
        }

        private static object GetValue(this KeyValuePair<PropertyInfo, DbColumnAttribute> p, SqlResultRow row) {
            return row[p.Value.ColumnName].GetValue(p.Key.PropertyType, p.Value?.DateFormat);
        }

        private static object GetValue(this object value, Type t, string format) {
            if (t == typeof(DateTime)) {
                if (!string.IsNullOrEmpty(format)) {
                    return value.ToDateTime(format).Value;
                } else {
                    return value.ToDateTime().Value;
                }
            } else if (t == typeof(DateTime?)) {
                if (!string.IsNullOrEmpty(format)) {
                    return value.ToDateTime(format);
                } else {
                    return value.ToDateTime();
                }
            } else if (t == typeof(int)) {
                return value.ToIntN().Value;
            } else if (t == typeof(int?)) {
                return value.ToIntN();
            } else if (t == typeof(decimal)) {
                return value.ToDecimalN().Value;
            } else if (t == typeof(decimal?)) {
                return value.ToDecimalN();
            } else if (t == typeof(float)) {
                return value.ToFloatN().Value;
            } else if (t == typeof(float?)) {
                return value.ToFloatN();
            } else if (t == typeof(double)) {
                return value.ToDoubleN().Value;
            } else if (t == typeof(double?)) {
                return value.ToDoubleN();
            } else if (t == typeof(string)) {
                return value.ToString();
            } else if (t == typeof(bool)) {
                return "Y".Equals(value?.ToString(), StringComparison.OrdinalIgnoreCase);
            } else if (t == typeof(bool?)) {
                if (value == null) {
                    return null;
                } else {
                    return "Y".Equals(value.ToString(), StringComparison.OrdinalIgnoreCase);
                }
            } else {
                return Convert.ChangeType(value, t);
            }
        }

        public static int? ToIntN(this object value) {
            if (value == null || value == DBNull.Value) {
                return null;
            }
            int ret;
            return int.TryParse(value.ToString(), out ret) ? ret : (int?)null;
        }

        internal static int ToInt32(this object value, int defaultValue) {
            return value.ToIntN() ?? defaultValue;
        }

        internal static DateTime? ToDateTime(this object value) {
            if (value == null || value == DBNull.Value) {
                return null;
            }
            if (value is DateTime) {
                return (DateTime)value;
            }
            if (value is DateTime?) {
                return (DateTime?)value;
            }
            return null;
        }

        internal static DateTime? ToDateTime(this object value, string dateFormat) {
            if (value == null || value == DBNull.Value) {
                return null;
            }
            DateTime d;
            return DateTime.TryParseExact(value.ToString(), dateFormat, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out d) ? d : (DateTime?)null;
        }

        internal static decimal? ToDecimalN(this object value) {
            if (value == null || value == DBNull.Value) {
                return null;
            }
            decimal ret;
            return decimal.TryParse(value.ToString(), out ret) ? ret : (decimal?)null;
        }

        internal static decimal ToDecimal(this object value, decimal defaultValue) {
            return value.ToDecimalN() ?? defaultValue;
        }

        internal static float? ToFloatN(this object value) {
            if (value == null || value == DBNull.Value) {
                return null;
            }
            float ret;
            return float.TryParse(value.ToString(), out ret) ? ret : (float?)null;
        }

        internal static float ToFloat(this object value, float defaultValue) {
            return value.ToFloatN() ?? defaultValue;
        }

        internal static double? ToDoubleN(this object value) {
            if (value == null || value == DBNull.Value) {
                return null;
            }
            double ret;
            return double.TryParse(value.ToString(), out ret) ? ret : (double?)null;
        }

        internal static double ToDouble(this object value, double defaultValue) {
            return value.ToDoubleN() ?? defaultValue;
        }
    }
}