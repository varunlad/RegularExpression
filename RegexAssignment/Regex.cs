﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexAssignment
{
    class Regex058assignment
    {
            string pattern = "^[a-zA-Z0-9]+[._+]{0,1}[a-zA-Z0-9]*@[a-zA-Z0-9]{1,10}.[a-zA-Z]{2,10}[.]*[a-zA-Z]*$";    
            //writing the valid pattern
            string[] inputs = {  "abc@yahoo.com" ,"abc","abc111@abc.com","abc()*@gmail.com","abc-100@abc.net","abc@.com.my","abc.100@abc.com.au" };//Validating some Example


        /// <summary>
        /// Validation this instance.
        /// </summary>
            public void Validation()
            {
                Regex regrex1 = new Regex(pattern);
                Console.WriteLine("Validating User Email ID : ");
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
