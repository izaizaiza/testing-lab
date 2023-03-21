using System.Runtime.CompilerServices;

namespace BasicMathTests
{
    public class BasicMathTests
    {
        private BasicMath.BasicMath basicMath;
        [SetUp]
        public void Setup()
        {
            basicMath = new BasicMath.BasicMath();

        }


        // test all the methods in Basic Math
        [Test]
        [TestCase(-1,-1)] 
        //[TestCase(1,0)] // would give infinity when divided
        //[TestCase(1,-1)]
        //[TestCase(1,1)]
        //[TestCase(0,0)]
        //can you divide by 0 in double?

        // naming convention: question_condition_expReturn
        public void IsDouble_Add_ReturnsDouble(double x, double y)
        {
            double expSum = -2.0;
            double actSum = basicMath.Add(x, y);
            Assert.That(expSum, Is.EqualTo(actSum));
        }

        [Test]
        [TestCase(1, -1)]
        public void IsDouble_Subtract_ReturnsDouble(double x, double y)
        {
            double expDiff = 2.0;
            double actDiff = basicMath.Subtract(x, y);
            Assert.That(expDiff, Is.EqualTo(actDiff));
        }

        [Test]
        [TestCase(1, 0)]

        public void IsDouble_Multiply_ReturnsDouble(double x, double y)
        {
            double expProduct = 0.0;
            double actProduct = basicMath.Mutiply(x, y);
            Assert.That(expProduct, Is.EqualTo(actProduct));
        }




        [Test]
        [TestCase(1, 0)]

        public void IsDouble_Divide_ReturnsDouble(double x, double y)
        {
            double expQuotient = double.PositiveInfinity;
            double actQuotient = basicMath.Divide(x, y);
            Assert.That(expQuotient, Is.EqualTo(actQuotient));
        }

    }
}