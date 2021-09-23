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
            string pattern = "^[a-zA-Z0-9]{1,}[0-9]{1,}[a-zA-Z0-9]*$";    
            //writing the valid pattern
            string[] inputs = { "xvdfsdvg42vsfdb","9198scv8189","VhawfhaiwhUG224114FDIUG","Sa11ksHawsfn","56 740921740", "Bfjx", "abc@1.com","Vascrun" };//Validating some Example


        /// <summary>
        /// Validation this instance.
        /// </summary>
            public void Validation()
            {
                Regex regrex1 = new Regex(pattern);
                Console.WriteLine("Validating User Password: ");
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
