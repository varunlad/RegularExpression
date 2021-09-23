using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexAssignment
{
    class Regex058assignment
    {
            string pattern = "^[0-9]{2}[ ]*[0-9]{10}$";    
            //writing the valid pattern
            string[] inputs = { "903464352","91 9834978189","V792479017134","SaksHi862489612","56 740921740", "Bfg24124 Gk25125ajx", "abc@1.com","Varun" };//Validating some Example


        /// <summary>
        /// Validation this instance.
        /// </summary>
            public void Validation()
            {
                Regex regrex1 = new Regex(pattern);
                Console.WriteLine("Validating User First & Last name: ");
                ItarateLoop(inputs, regrex1);
            }          
            public void ItarateLoop(string[] arr, Regex regrex1)
            {
                for (int i = 0; i < arr.Length; i++)//validation Loop
                {
                    bool result = regrex1.IsMatch(arr[i]);
                    if (result)
                    {
                        Console.WriteLine(arr[i] + " It is --->" + "Valid");
                    }
                    else
                    {
                        Console.WriteLine(arr[i] + " It is --->" + "Invalid");
                    }
                }
            }


        
    }
}
