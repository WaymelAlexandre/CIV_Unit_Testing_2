﻿using System;

namespace MiscLib
{
    public class GroupTwoFunctions
    {
        //---- Group 2 Functions ----------
        
        public int CalcRectPerimeter(int length, int width) {     
            throw new NotImplementedException();   
        }

        public bool IsTriangularNum(int num) {
            throw new NotImplementedException();
        }

        public int FarenheitToCelcius(int farenheit) 
        {
            throw new NotImplementedException();
        }

        public bool CheckWhiteSpace(string word) {
            throw new NotImplementedException();
        }
        
        public string CamelString(string word) {
            throw new NotImplementedException();
        }
        public int CountDigits(string word) 
        {
         int digits = 0;

            foreach (var character in word)
            {
                if (char.IsDigit(character))
                {
                    digits += 1;
                }
            }
            return digits;
        }

        
    }

}
