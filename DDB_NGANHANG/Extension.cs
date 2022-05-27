using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDB_NGANHANG
{
    public static class Extension
    {
        public static string CapitalizeFirstLetter(string value)
        {
            value = value.ToLower();
            value = value.Trim();
            while(value.IndexOf("  ") != -1)
            {
                value = value.Remove(value.IndexOf("  "), 1);
            }
            char[] array = value.ToCharArray();
            

            if (array.Length >= 1)
            {
                if (char.IsLower(array[0]))
                {
                    array[0] = char.ToUpper(array[0]);
                }
            }

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] == ' ')
                {
                    if (char.IsLower(array[i]))
                    {
                        array[i] = char.ToUpper(array[i]);
                    }
                }
            }
            return new string(array);
        }
    }
}
