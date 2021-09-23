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
            string pattern = "^[A-Z]{1}[a-z]{2,}[ ]{1}[A-Z]{1}[a-z]{2,}$";    
            //writing the valid pattern
            string[] inputs = { "Varun Lad","varUnl?ad","Varun134","SaksHi.com","DHVSJK", "Bfghjbjsb Gkajx", "abc@1.com","Varun" };//Validating some Example


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
