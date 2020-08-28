using System;
using Xunit;
using MiscLib;

namespace Tests
{
    public class MiscLibTests
    {
        GroupTwoFunctions FunctiontoTest = new GroupTwoFunctions();

        [Fact]
        public void CalcRectPerimeter_Test(){

            Assert.Equal (10, FunctiontoTest.CalcRectPerimeter(4, 1));
            Assert.Equal (150, FunctiontoTest.CalcRectPerimeter(50, 25));
        }

        [Fact]
        public void IsTriangularNum_Test(){
            
            Assert.True(FunctiontoTest.IsTriangularNum(1));
            Assert.False(FunctiontoTest.IsTriangularNum(2));
            Assert.True(FunctiontoTest.IsTriangularNum(3));
            Assert.False(FunctiontoTest.IsTriangularNum(4));
            Assert.False(FunctiontoTest.IsTriangularNum(5));
            Assert.True(FunctiontoTest.IsTriangularNum(6));
            Assert.False(FunctiontoTest.IsTriangularNum(7));
            Assert.False(FunctiontoTest.IsTriangularNum(8));
            Assert.False(FunctiontoTest.IsTriangularNum(9));
            Assert.True(FunctiontoTest.IsTriangularNum(10));
            
        }

        [Fact]
        public void FarenheitToCelcius_Test()
        {
            Assert.Equal(0, FunctiontoTest.FarenheitToCelcius(32));
            Assert.Equal(22.22, FunctiontoTest.FarenheitToCelcius(72));
            Assert.Equal(100, FunctiontoTest.FarenheitToCelcius(212));
        }

            [Fact]
        public void CheckWhiteSpace_Test(){
            //not sure about this question I just check if the string have space
            Assert.True(FunctiontoTest.CheckWhiteSpace("Hi my name is Alexandre And i love the roast beef  "));
            Assert.False(FunctiontoTest.CheckWhiteSpace("Whouuuuuuuuuuuuuuuuuuuuuuuuuuuu"));
        }
        
        [Theory]
        [InlineData("noIdeaWhatItIsAbout ","No idea what it is about"  )]
        [InlineData("hiyaBarbieHiKenYouWannaGoForARideSureKenJumpIn!", "Hiya barbie hi ken you wanna go for a ride sure ken jump in!")]
        /*
        again not sure what the question is (the function return)
        I do suppose the function will return a line in camelCase like below  AND yes i love barbie girld 
        */
        public void CamelString_Test(string expec, string word) 
        {
            Assert.Equal(expec, FunctiontoTest.CamelString(word));
        }

        [Theory]
        [InlineData(5, "12345")]
        [InlineData(9, "123456789")]
        public void CountDigits_Test(int ex, string stringToCount)
        {
            Assert.Equal(ex,  FunctiontoTest.CountDigits(stringToCount));
        }


    }
}
