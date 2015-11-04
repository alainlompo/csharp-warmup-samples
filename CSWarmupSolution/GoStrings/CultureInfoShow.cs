using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoStrings
{
    class CultureInfoShow
    {
        public static void DoCultureInfoShow()
        {
            var allCultures = CultureInfo.GetCultures(CultureTypes.AllCultures).OrderBy(c => c.EnglishName);
            foreach (var specificCulture in allCultures)
            {
                Console.WriteLine(specificCulture.EnglishName + ", code: " + specificCulture.Name);
            }

        }
    }
}
