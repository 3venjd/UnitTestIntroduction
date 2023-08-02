namespace MsTest1
{
    [TestClass]
    public class UnitTest1
    {
        //Arrange: Start the variables
        int val1 = 6;
        int val2 = 2;

        [TestMethod]
        public void Test_correct_sum()
        {

            //Act:execute the method to test
            int resultado = Calculator.Calculator.Sum(val1, val2);


            //Assert: check the values
            Assert.AreEqual(8, resultado);
            
        }

        [TestMethod]
        public void Test_correct_Substract()
        {

            //Act:execute the method to test
            int resultado = Calculator.Calculator.Substract(val1, val2);


            //Assert: check the values
            Assert.AreEqual(4, resultado);

        }

        [TestMethod]
        public void Test_correct_Multiplication()
        {

            //Act:execute the method to test
            int resultado = Calculator.Calculator.Multiplication(val1, val2);


            //Assert: check the values
            Assert.AreEqual(12, resultado);

        }

        [TestMethod]
        public void Test_correct_Division()
        {

            //Act:execute the method to test
            int resultado = Calculator.Calculator.Division(val1, val2);


            //Assert: check the values
            Assert.AreEqual(3, resultado);

        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void test_exceptions()
        {
            int dividend = 120;
            int divider = 0;

            double result = Calculator.Calculator.Division(dividend,divider);
        }
    }
}