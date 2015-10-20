using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace GoConsole
{
    class AttributesDemo1
    {
        public static void DoAttributesDemo1()
        {
            MemberInfo typeInfo = typeof(String);
            object[] attributes = typeInfo.GetCustomAttributes(true);

            Console.WriteLine("List of the attributes applying to String class....");
            foreach (object o in  attributes) 
            {
              
                Console.WriteLine(o);

            }

            Console.ReadKey();

        }
    }
}
