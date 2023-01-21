using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PI_Zadaca.Model
{
    public static class DescriptionExtensions
    {
            public static int GetValue(this Enum value)
            {
                // Get the type
                Type type = value.GetType();

                // Get fieldinfo for this type
                FieldInfo fieldInfo = type.GetField(value.ToString());

                // Get the stringvalue attributes
                DescriptionAttribute[] attribs = fieldInfo.GetCustomAttributes(
                    typeof(DescriptionAttribute), false) as DescriptionAttribute[];


                // Return the first if there was a match.
                return int.Parse(attribs[0].Description);
            }


    }
}
