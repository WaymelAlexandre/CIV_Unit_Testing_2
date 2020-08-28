using System;

namespace MiscLib
{
    public class GroupOneFunctions
    {
        //---- Group 1 Functions ----------
        public int CalcRectArea(int length, int width)
    {
           if (length < 0 || width < 0 )
           {
             throw new System.Exception("Input cannot be less than 0");
           }
           else
           {
            int RectArea;
            RectArea =  (length * width);
            return RectArea;
           }
            
    }


        public bool IsFactiorialNum(int num) {
            throw new NotImplementedException();
        }

        public int CelciusToFarenheit(int celcius) {
            throw new NotImplementedException();
        }

        public bool IsPalindrome(string word) {
            throw new NotImplementedException();
        }

        public string StringReplace(string word, char replaceChar, char replacement) {
            throw new NotImplementedException();
        }

        public int CharCount(string word, char countCharacter) {
            throw new NotImplementedException();
        }

        
    }
}
