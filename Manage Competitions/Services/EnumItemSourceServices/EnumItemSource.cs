using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Reflection;
using System.ComponentModel;

namespace Manage_Competitions.Services.EnumItemSourceServices
{
    public class EnumItemSource : Collection<String>, IValueConverter
    {

        private Type _type;
        private IDictionary<object, object> _valueToNameMap;
        private IDictionary<object, object> _nameToValueMap;

        public Type Type
        {
            get => _type;
            set
            {
                if (!value.IsEnum)
                    throw new ArgumentException("Type is not an enum.", "value");
                _type = value;
                Initialize();
            }
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return _valueToNameMap[value];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return _nameToValueMap[value];
        }

        void Initialize()
        {
            _valueToNameMap = _type.GetFields(BindingFlags.Static | BindingFlags.Public)
                .ToDictionary(fi => fi.GetValue(null), GetDescription);
            _nameToValueMap = _valueToNameMap
                .ToDictionary(kvp => kvp.Value, kvp => kvp.Key);
            Clear();
            foreach (string name in _nameToValueMap.Keys)
                Add(name);
        }

        static Object GetDescription(FieldInfo fieldInfo)
        {
            var descriptionAttribute =
                (DescriptionAttribute)Attribute.GetCustomAttribute(fieldInfo, typeof(DescriptionAttribute));
            return descriptionAttribute != null ? descriptionAttribute.Description : fieldInfo.Name;
        }
    }
}
