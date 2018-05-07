using Microsoft.VisualStudio.TestTools.UnitTesting;
using testM;


namespace UnitTest
{
    [TestClass]
    public class UnitTestMathString
    {

       private MathString mathStringClass; 

        [TestInitialize]
        public void testInit()
        {
            mathStringClass = new MathString();
            
        }
        [DataRow("")]
        [DataTestMethod]
        public void Inc_InputValueForEmptyString_ReturnError( string inputValue)
        {
            Assert.AreEqual(mathStringClass.Inc(inputValue), "Input value is empty"); 
        }
        [DataTestMethod]
        [DataRow("dfdfdfgfdgfdgdd")]
        public void Inc_InputValueIsNotNumber_ReturnError(string inputValue)
        {
            Assert.AreEqual(mathStringClass.Inc(inputValue), "Input value is not number");
        }
        [DataTestMethod]
        [DataRow("10")]
        public void Inc_InputValueIsNumber_ReturnNumber(string inputValue)
        {
            Assert.AreEqual(mathStringClass.Inc(inputValue), "11");
        }
        

        [TestCleanup]
        public void testClean()
        {
            mathStringClass = null;
            
        }
    }
}
